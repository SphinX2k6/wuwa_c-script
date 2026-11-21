using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x0200546D RID: 21613
	public readonly struct MechanicDisplayData
	{
		// Token: 0x06035A72 RID: 219762 RVA: 0x00EFCAAC File Offset: 0x00EFACAC
		public MechanicDisplayData(int envId, EPieceType targetType, int remainRounds, int generateCount, bool showRemainTime)
		{
			this.EnvId = envId;
			this.TargetType = targetType;
			this.RemainRounds = remainRounds;
			this.GenerateCount = generateCount;
			this.ShowRemainTime = showRemainTime;
		}

		// Token: 0x0401C5D4 RID: 116180
		public readonly int EnvId;

		// Token: 0x0401C5D5 RID: 116181
		public readonly EPieceType TargetType;

		// Token: 0x0401C5D6 RID: 116182
		public readonly int RemainRounds;

		// Token: 0x0401C5D7 RID: 116183
		public readonly int GenerateCount;

		// Token: 0x0401C5D8 RID: 116184
		public readonly bool ShowRemainTime;
	}
}
