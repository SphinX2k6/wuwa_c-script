using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B1 RID: 4785
	public class ITakePhoto2Target_SetValue
	{
		// Token: 0x0400405F RID: 16479
		public ETakePhoto2TargetType Type;

		// Token: 0x04004060 RID: 16480
		public bool? IsOptionalTarget;

		// Token: 0x04004061 RID: 16481
		[Nullable(2)]
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;
	}
}
