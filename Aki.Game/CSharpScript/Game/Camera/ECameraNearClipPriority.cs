using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200643B RID: 25659
	public enum ECameraNearClipPriority
	{
		// Token: 0x0402132E RID: 135982
		PhotoCamera = 250,
		// Token: 0x0402132F RID: 135983
		PhotoSelfie = 300,
		// Token: 0x04021330 RID: 135984
		TsAnimNotifyStateSetNearClip = 500,
		// Token: 0x04021331 RID: 135985
		LevelEventAdjustPlayerCamera = 1000,
		// Token: 0x04021332 RID: 135986
		SequenceCamera = 2000
	}
}
