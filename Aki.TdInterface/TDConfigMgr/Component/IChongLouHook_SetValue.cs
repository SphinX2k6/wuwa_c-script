using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000269 RID: 617
	public class IChongLouHook_SetValue
	{
		// Token: 0x04000AE6 RID: 2790
		public EHookInteractType Type;

		// Token: 0x04000AE7 RID: 2791
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04000AE8 RID: 2792
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04000AE9 RID: 2793
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04000AEA RID: 2794
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04000AEB RID: 2795
		public float HookMoveSpeed;

		// Token: 0x04000AEC RID: 2796
		public float Acceleration;

		// Token: 0x04000AED RID: 2797
		public float? LateralMoveSpeed;

		// Token: 0x04000AEE RID: 2798
		public float? LateralAccelerateTime;

		// Token: 0x04000AEF RID: 2799
		public float? LateralDecelerateTime;

		// Token: 0x04000AF0 RID: 2800
		public float? MaxLateralOffset;

		// Token: 0x04000AF1 RID: 2801
		public float? VerticalMoveSpeed;

		// Token: 0x04000AF2 RID: 2802
		public float? VerticalAccelerateTime;

		// Token: 0x04000AF3 RID: 2803
		public float? VerticalDecelerateTime;
	}
}
