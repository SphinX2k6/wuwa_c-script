using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058A RID: 1418
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorEjectHook_SetValue
	{
		// Token: 0x040014AC RID: 5292
		public EHookInteractType Type;

		// Token: 0x040014AD RID: 5293
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x040014AE RID: 5294
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x040014AF RID: 5295
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x040014B0 RID: 5296
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x040014B1 RID: 5297
		public float MinPitchAngle;

		// Token: 0x040014B2 RID: 5298
		public float DefaultPitchAngle;

		// Token: 0x040014B3 RID: 5299
		public float MaxPitchAngle;

		// Token: 0x040014B4 RID: 5300
		public float MaxYawAngleDelta;

		// Token: 0x040014B5 RID: 5301
		public float MaxEjectDistance;

		// Token: 0x040014B6 RID: 5302
		public float InterpSpeed;

		// Token: 0x040014B7 RID: 5303
		public IMotorAutoEjectConfigBase AutoEjectConfig;
	}
}
