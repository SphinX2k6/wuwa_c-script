using System;

namespace CSharpScript.Launcher
{
	// Token: 0x02000067 RID: 103
	public enum EStartupTimingStep
	{
		// Token: 0x040001BF RID: 447
		SdkLoginStart = 1,
		// Token: 0x040001C0 RID: 448
		SdkLoginSuccess,
		// Token: 0x040001C1 RID: 449
		HotPatchStart,
		// Token: 0x040001C2 RID: 450
		HotPatchEnd,
		// Token: 0x040001C3 RID: 451
		PatchMergeStart,
		// Token: 0x040001C4 RID: 452
		PatchMergeEnd,
		// Token: 0x040001C5 RID: 453
		ShaderCompileStart,
		// Token: 0x040001C6 RID: 454
		ShaderCompileEnd,
		// Token: 0x040001C7 RID: 455
		ServerSelectionViewShown,
		// Token: 0x040001C8 RID: 456
		ConnectGameClicked,
		// Token: 0x040001C9 RID: 457
		EnterGameServer,
		// Token: 0x040001CA RID: 458
		HotPatchSkippedEnterGame
	}
}
