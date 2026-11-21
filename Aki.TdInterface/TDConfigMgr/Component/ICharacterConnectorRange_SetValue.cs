using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000259 RID: 601
	public class ICharacterConnectorRange_SetValue
	{
		// Token: 0x04000A94 RID: 2708
		public ECharacterConnectorLogicType Type;

		// Token: 0x04000A95 RID: 2709
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000A96 RID: 2710
		public int EnterRange;

		// Token: 0x04000A97 RID: 2711
		public int LeaveRange;

		// Token: 0x04000A98 RID: 2712
		[Nullable(2)]
		public List<int> TagConditions;

		// Token: 0x04000A99 RID: 2713
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDynamicEntityMatch> MatchConditions;

		// Token: 0x04000A9A RID: 2714
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IDynamicEntityMatch> KeepConditions;
	}
}
