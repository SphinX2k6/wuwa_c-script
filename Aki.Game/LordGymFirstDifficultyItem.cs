using System;
using Aki.Config;

// Token: 0x020021A5 RID: 8613
public class LordGymFirstDifficultyItem : LordGymDifficultyItem
{
	// Token: 0x06010C0B RID: 68619 RVA: 0x004123BE File Offset: 0x004105BE
	protected override void SetLevelText(LordGym config)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.FirstGuideGymTitle, Array.Empty<object>());
	}

	// Token: 0x020086DA RID: 34522
	private class EComponent
	{
		// Token: 0x0402BE13 RID: 179731
		public const int LordToggle = 0;

		// Token: 0x0402BE14 RID: 179732
		public const int LevelText = 1;

		// Token: 0x0402BE15 RID: 179733
		public const int LockItem = 2;

		// Token: 0x0402BE16 RID: 179734
		public const int FinishItem = 3;

		// Token: 0x0402BE17 RID: 179735
		public const int RedDotItem = 4;
	}
}
