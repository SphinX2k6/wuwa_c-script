using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000232 RID: 562
	public class ICharacterConnectorRange_SetValue
	{
		// Token: 0x04000A0A RID: 2570
		public ECharacterConnectorLogicType Type;

		// Token: 0x04000A0B RID: 2571
		[Nullable(1)]
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000A0C RID: 2572
		public int EnterRange;

		// Token: 0x04000A0D RID: 2573
		public int LeaveRange;

		// Token: 0x04000A0E RID: 2574
		[Nullable(2)]
		public List<int> TagConditions;

		// Token: 0x04000A0F RID: 2575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDynamicEntityMatch> MatchConditions;

		// Token: 0x04000A10 RID: 2576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IDynamicEntityMatch> KeepConditions;
	}
}
