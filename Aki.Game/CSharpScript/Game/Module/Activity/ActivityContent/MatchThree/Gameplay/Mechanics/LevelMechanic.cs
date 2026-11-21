using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x0200546A RID: 21610
	public abstract class LevelMechanic
	{
		// Token: 0x06035A5F RID: 219743
		public abstract MechanicTipEvent? CreateMountTip(int round);

		// Token: 0x06035A60 RID: 219744
		[NullableContext(1)]
		public abstract void OnRound(int round, IMechanicContext ctx);
	}
}
