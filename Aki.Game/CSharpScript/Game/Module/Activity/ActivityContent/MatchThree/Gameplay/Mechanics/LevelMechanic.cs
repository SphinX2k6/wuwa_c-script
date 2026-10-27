using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064EC RID: 25836
	public abstract class LevelMechanic
	{
		// Token: 0x06040D9B RID: 265627
		public abstract MechanicTipEvent? CreateMountTip(int round);

		// Token: 0x06040D9C RID: 265628
		[NullableContext(1)]
		public abstract void OnRound(int round, IMechanicContext ctx);
	}
}
