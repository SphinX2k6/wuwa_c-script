using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064EF RID: 25839
	public readonly struct MechanicDisplayData
	{
		// Token: 0x06040DAE RID: 265646 RVA: 0x00FB5A7C File Offset: 0x00FB3C7C
		public MechanicDisplayData(int envId, EPieceType targetType, int remainRounds, int generateCount, bool showRemainTime)
		{
			this.EnvId = envId;
			this.TargetType = targetType;
			this.RemainRounds = remainRounds;
			this.GenerateCount = generateCount;
			this.ShowRemainTime = showRemainTime;
		}

		// Token: 0x04021CA3 RID: 138403
		public readonly int EnvId;

		// Token: 0x04021CA4 RID: 138404
		public readonly EPieceType TargetType;

		// Token: 0x04021CA5 RID: 138405
		public readonly int RemainRounds;

		// Token: 0x04021CA6 RID: 138406
		public readonly int GenerateCount;

		// Token: 0x04021CA7 RID: 138407
		public readonly bool ShowRemainTime;
	}
}
