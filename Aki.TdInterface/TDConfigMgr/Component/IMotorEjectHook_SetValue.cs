using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000523 RID: 1315
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorEjectHook_SetValue
	{
		// Token: 0x04001342 RID: 4930
		public EHookInteractType Type;

		// Token: 0x04001343 RID: 4931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> HookActions;

		// Token: 0x04001344 RID: 4932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitHookActions;

		// Token: 0x04001345 RID: 4933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> FinishActions;

		// Token: 0x04001346 RID: 4934
		public IClientHookActionConfig ClientHookActionConfig;

		// Token: 0x04001347 RID: 4935
		public float MinPitchAngle;

		// Token: 0x04001348 RID: 4936
		public float DefaultPitchAngle;

		// Token: 0x04001349 RID: 4937
		public float MaxPitchAngle;

		// Token: 0x0400134A RID: 4938
		public float MaxYawAngleDelta;

		// Token: 0x0400134B RID: 4939
		public float MaxEjectDistance;

		// Token: 0x0400134C RID: 4940
		public float InterpSpeed;

		// Token: 0x0400134D RID: 4941
		public IMotorAutoEjectConfigBase AutoEjectConfig;
	}
}
