using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069C RID: 1692
	public class IPilotThrow_SetValue
	{
		// Token: 0x040018DC RID: 6364
		public EHookInteractType Type;

		// Token: 0x040018DD RID: 6365
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040018DE RID: 6366
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040018DF RID: 6367
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040018E0 RID: 6368
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040018E1 RID: 6369
		public int TitanEntityId;

		// Token: 0x040018E2 RID: 6370
		public float MinPitchAngle;

		// Token: 0x040018E3 RID: 6371
		public float DefaultPitchAngle;

		// Token: 0x040018E4 RID: 6372
		public float MaxPitchAngle;

		// Token: 0x040018E5 RID: 6373
		public float MaxYawAngleDelta;

		// Token: 0x040018E6 RID: 6374
		public float FlySpeed;

		// Token: 0x040018E7 RID: 6375
		public float? Gravity;

		// Token: 0x040018E8 RID: 6376
		public List<IPilotThrowTarget> TargetList;

		// Token: 0x040018E9 RID: 6377
		public EPilotThrowAutoThrowType? AutoThrowType;

		// Token: 0x040018EA RID: 6378
		public bool? IsAutoRide;

		// Token: 0x040018EB RID: 6379
		public bool? DisableInterrupt;
	}
}
