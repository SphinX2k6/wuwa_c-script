using System;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B1 RID: 14769
	[Flags]
	public enum EUiCameraInputBlockReason
	{
		// Token: 0x04014E50 RID: 85584
		None = 0,
		// Token: 0x04014E51 RID: 85585
		Blend = 1,
		// Token: 0x04014E52 RID: 85586
		Sequence = 2,
		// Token: 0x04014E53 RID: 85587
		Loading = 4
	}
}
