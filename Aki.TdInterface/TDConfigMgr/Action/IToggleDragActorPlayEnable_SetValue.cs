using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCF RID: 8143
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable_SetValue
	{
		// Token: 0x04006C18 RID: 27672
		public EToggleDragActorPlayType Type;

		// Token: 0x04006C19 RID: 27673
		[Nullable(1)]
		public IFixedCameraConfig CameraConfig;

		// Token: 0x04006C1A RID: 27674
		public string TidMainText;

		// Token: 0x04006C1B RID: 27675
		public string TidSubText;

		// Token: 0x04006C1C RID: 27676
		public string TidHintText;

		// Token: 0x04006C1D RID: 27677
		public bool? KeepDialog;

		// Token: 0x04006C1E RID: 27678
		public bool? DisableExit;

		// Token: 0x04006C1F RID: 27679
		public string EdTidMainText;

		// Token: 0x04006C20 RID: 27680
		public string EdTidSubText;

		// Token: 0x04006C21 RID: 27681
		public string EdTidHintText;
	}
}
