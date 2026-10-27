using System;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072B9 RID: 29369
	public enum ECameraNearClipPriority
	{
		// Token: 0x0402604E RID: 155726
		PhotoCamera = 250,
		// Token: 0x0402604F RID: 155727
		PhotoSelfie = 300,
		// Token: 0x04026050 RID: 155728
		TsAnimNotifyStateSetNearClip = 500,
		// Token: 0x04026051 RID: 155729
		LevelEventAdjustPlayerCamera = 1000,
		// Token: 0x04026052 RID: 155730
		SequenceCamera = 2000
	}
}
