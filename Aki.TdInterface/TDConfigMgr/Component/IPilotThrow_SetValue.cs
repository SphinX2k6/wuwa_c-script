using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FF RID: 1535
	public class IPilotThrow_SetValue
	{
		// Token: 0x040016EA RID: 5866
		public EHookInteractType Type;

		// Token: 0x040016EB RID: 5867
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040016EC RID: 5868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040016ED RID: 5869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040016EE RID: 5870
		[Nullable(2)]
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040016EF RID: 5871
		public int TitanEntityId;

		// Token: 0x040016F0 RID: 5872
		public float MinPitchAngle;

		// Token: 0x040016F1 RID: 5873
		public float DefaultPitchAngle;

		// Token: 0x040016F2 RID: 5874
		public float MaxPitchAngle;

		// Token: 0x040016F3 RID: 5875
		public float MaxYawAngleDelta;

		// Token: 0x040016F4 RID: 5876
		public float FlySpeed;

		// Token: 0x040016F5 RID: 5877
		public float? Gravity;

		// Token: 0x040016F6 RID: 5878
		[Nullable(1)]
		public List<IPilotThrowTarget> TargetList;

		// Token: 0x040016F7 RID: 5879
		public EPilotThrowAutoThrowType? AutoThrowType;

		// Token: 0x040016F8 RID: 5880
		public bool? IsAutoRide;

		// Token: 0x040016F9 RID: 5881
		public bool? DisableInterrupt;
	}
}
