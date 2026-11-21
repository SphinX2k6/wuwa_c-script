using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C3 RID: 707
	public class IConnectorRange_SetValue
	{
		// Token: 0x04000C28 RID: 3112
		public EConnectorLogicType Type;

		// Token: 0x04000C29 RID: 3113
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000C2A RID: 3114
		public string ActiveState;

		// Token: 0x04000C2B RID: 3115
		public int EnterRange;

		// Token: 0x04000C2C RID: 3116
		public int LeaveRange;

		// Token: 0x04000C2D RID: 3117
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDynamicEntityMatch> MatchConditions;

		// Token: 0x04000C2E RID: 3118
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDynamicEntityMatch> KeepConditions;

		// Token: 0x04000C2F RID: 3119
		public string ConnectedState;

		// Token: 0x04000C30 RID: 3120
		public string DisconnectedState;
	}
}
