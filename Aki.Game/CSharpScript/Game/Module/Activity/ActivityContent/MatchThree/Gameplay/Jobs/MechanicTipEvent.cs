using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005492 RID: 21650
	[NullableContext(1)]
	[Nullable(0)]
	public struct MechanicTipEvent
	{
		// Token: 0x06035B6A RID: 220010 RVA: 0x00F02772 File Offset: 0x00F00972
		public MechanicTipEvent(string textId, int remainingRounds, int generateCount)
		{
			this.TextId = textId;
			this.RemainingRounds = remainingRounds;
			this.GenerateCount = generateCount;
		}

		// Token: 0x0401C6E5 RID: 116453
		public string TextId;

		// Token: 0x0401C6E6 RID: 116454
		public int RemainingRounds;

		// Token: 0x0401C6E7 RID: 116455
		public int GenerateCount;
	}
}
