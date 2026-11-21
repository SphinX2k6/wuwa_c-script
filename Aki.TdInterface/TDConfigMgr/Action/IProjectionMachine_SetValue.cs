using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6A RID: 8042
	public class IProjectionMachine_SetValue
	{
		// Token: 0x04006680 RID: 26240
		public ESimpleGameplayType Type;

		// Token: 0x04006681 RID: 26241
		public int ItemId;

		// Token: 0x04006682 RID: 26242
		public string PhotoAsset;

		// Token: 0x04006683 RID: 26243
		public bool? HideFixedPhoto;

		// Token: 0x04006684 RID: 26244
		[Nullable(2)]
		public IProjectionMachinePhotoFilter PhotoFilter;
	}
}
