using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002214 RID: 8724
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable_SetValue
	{
		// Token: 0x04007217 RID: 29207
		public EToggleDragActorPlayType Type;

		// Token: 0x04007218 RID: 29208
		[Nullable(0)]
		public IFixedCameraConfig CameraConfig;

		// Token: 0x04007219 RID: 29209
		public string TidMainText;

		// Token: 0x0400721A RID: 29210
		public string TidSubText;

		// Token: 0x0400721B RID: 29211
		public string TidHintText;

		// Token: 0x0400721C RID: 29212
		public bool? KeepDialog;

		// Token: 0x0400721D RID: 29213
		public bool? DisableExit;

		// Token: 0x0400721E RID: 29214
		public string EdTidMainText;

		// Token: 0x0400721F RID: 29215
		public string EdTidSubText;

		// Token: 0x04007220 RID: 29216
		public string EdTidHintText;
	}
}
