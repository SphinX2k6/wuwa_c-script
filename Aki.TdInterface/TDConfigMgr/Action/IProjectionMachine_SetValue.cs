using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D59 RID: 7513
	public class IProjectionMachine_SetValue
	{
		// Token: 0x04006104 RID: 24836
		public ESimpleGameplayType Type;

		// Token: 0x04006105 RID: 24837
		public int ItemId;

		// Token: 0x04006106 RID: 24838
		[Nullable(1)]
		public string PhotoAsset;

		// Token: 0x04006107 RID: 24839
		public bool? HideFixedPhoto;

		// Token: 0x04006108 RID: 24840
		[Nullable(2)]
		public IProjectionMachinePhotoFilter PhotoFilter;
	}
}
