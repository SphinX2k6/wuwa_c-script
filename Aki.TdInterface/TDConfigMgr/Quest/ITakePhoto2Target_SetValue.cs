using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001177 RID: 4471
	public class ITakePhoto2Target_SetValue
	{
		// Token: 0x04003CF7 RID: 15607
		public ETakePhoto2TargetType Type;

		// Token: 0x04003CF8 RID: 15608
		public bool? IsOptionalTarget;

		// Token: 0x04003CF9 RID: 15609
		[Nullable(2)]
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;
	}
}
