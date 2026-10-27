$CrazyThing[0] = "Good GOD man, it's a flashback!  RUN FOR YOUR LIVES!!!";
$CrazyThing[1] = "There are lots of things you can eat that aren't food!";
$CrazyThing[2] = "Once, I killed a man just to see him die, but I got distracted and looked away.  My friends tried to describe it to me, but it just wasn't the same.";
$CrazyThing[3] = "If I were stranded on a desert island with only one book, one type of food and one person, I'd probably die of exposure.";
$CrazyThing[4] = "The demons inside the servants' skulls were trying to kill me!";
$CrazyThing[5] = "Am I crazy?  Four out of five voices in my head can't be wrong!";
$CrazyThing[6] = "I realize it's customary to extinguish Chicken Flambe before eating it, but I say \"Why waste all that good eating time?\"";
$CrazyThing[7] = "I will return someday.  And when I do, you will all serve me.  Especially you, Lisa.";
$CrazyThing[8] = "You will RUE the day you crossed me.  YOU!  BEGIN YOUR RUEING!!!!";
$CrazyThing[9] = "Pencils are for drawing, not stabbing... right?";
$CrazyThing[10] = "Jason Alexander likes to complain about \"pre-processed mystery meat\".  Frankly, I think that's the biggest appeal of Chicken McNuggets.";
$CrazyThing[11] = "MY BRAIN ITCHES!!!!~wdsgst4";
$CrazyThing[12] = "This week's Sesame Street was written by the president.  I could tell because it was brought to us by the letter 3.";
$CrazyThing[13] = "Dude, you know what would be cool?  If you mixed a Taco and a Nacho.  It'd be called a Naco!  Damn, I could really go for one right now.";


function SayCrazyThing(%client)
{
	%j = 0;
	for(%i = 0;$CrazyThing[%i] != ""; %i++)
	{
		%j++;
	}
	%rnd = floor(getRandom() * %j);
	remoteSay(%client,0,$CrazyThing[%rnd]);
}

function GroupTrigger::onEnter(%this, %object)
{
	%client = Player::getClient(%object);

	if(%this.num == "BG")
		%pos = "14.8478 -207.378 -13.4414";

	else if(%this.num == "DD")
		%pos = "23.2186 231.647 -12.3463";

	Client::SendMessage(%client,0,"~wshieldhit.wav");
	GameBase::setPosition(%object, %pos);

	%rnd = floor(getRandom() * 50);
	if(%rnd == 23 || %rnd == 37)
		SayCrazyThing(%client);
	
} 