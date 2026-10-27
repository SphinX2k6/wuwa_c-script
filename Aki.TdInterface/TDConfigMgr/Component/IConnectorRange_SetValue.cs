using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000280 RID: 640
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorRange_SetValue
	{
		// Token: 0x04000B47 RID: 2887
		public EConnectorLogicType Type;

		// Token: 0x04000B48 RID: 2888
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000B49 RID: 2889
		public string ActiveState;

		// Token: 0x04000B4A RID: 2890
		public int EnterRange;

		// Token: 0x04000B4B RID: 2891
		public int LeaveRange;

		// Token: 0x04000B4C RID: 2892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDynamicEntityMatch> MatchConditions;

		// Token: 0x04000B4D RID: 2893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDynamicEntityMatch> KeepConditions;

		// Token: 0x04000B4E RID: 2894
		public string ConnectedState;

		// Token: 0x04000B4F RID: 2895
		public string DisconnectedState;
	}
}
