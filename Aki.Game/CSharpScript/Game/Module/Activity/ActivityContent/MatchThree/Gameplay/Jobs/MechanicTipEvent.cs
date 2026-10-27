using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006514 RID: 25876
	[NullableContext(1)]
	[Nullable(0)]
	public struct MechanicTipEvent
	{
		// Token: 0x06040EA6 RID: 265894 RVA: 0x00FBB742 File Offset: 0x00FB9942
		public MechanicTipEvent(string textId, int remainingRounds, int generateCount)
		{
			this.TextId = textId;
			this.RemainingRounds = remainingRounds;
			this.GenerateCount = generateCount;
		}

		// Token: 0x04021DB4 RID: 138676
		public string TextId;

		// Token: 0x04021DB5 RID: 138677
		public int RemainingRounds;

		// Token: 0x04021DB6 RID: 138678
		public int GenerateCount;
	}
}
