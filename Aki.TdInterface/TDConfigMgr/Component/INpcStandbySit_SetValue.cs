using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EC RID: 1516
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit_SetValue
	{
		// Token: 0x04001605 RID: 5637
		public ENpcStandbyShowMode Type;

		// Token: 0x04001606 RID: 5638
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x04001607 RID: 5639
		public string Montage;

		// Token: 0x04001608 RID: 5640
		public IMontageId RegisteredMontageId;

		// Token: 0x04001609 RID: 5641
		public int? FaceExpressionId;

		// Token: 0x0400160A RID: 5642
		public int PosEntityId;
	}
}
