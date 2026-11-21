using System;
using Aki.Config;

// Token: 0x02001689 RID: 5769
public class LordGymFirstDifficultyItem : LordGymDifficultyItem
{
	// Token: 0x0600E09C RID: 57500 RVA: 0x0041ECA6 File Offset: 0x0041CEA6
	protected override void SetLevelText(LordGym config)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.FirstGuideGymTitle, Array.Empty<object>());
	}

	// Token: 0x02007865 RID: 30821
	private class EComponent
	{
		// Token: 0x04027134 RID: 160052
		public const int LordToggle = 0;

		// Token: 0x04027135 RID: 160053
		public const int LevelText = 1;

		// Token: 0x04027136 RID: 160054
		public const int LockItem = 2;

		// Token: 0x04027137 RID: 160055
		public const int FinishItem = 3;

		// Token: 0x04027138 RID: 160056
		public const int RedDotItem = 4;
	}
}
