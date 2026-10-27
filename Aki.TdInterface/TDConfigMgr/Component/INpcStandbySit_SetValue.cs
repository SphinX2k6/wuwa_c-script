using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000583 RID: 1411
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit_SetValue
	{
		// Token: 0x04001497 RID: 5271
		public ENpcStandbyShowMode Type;

		// Token: 0x04001498 RID: 5272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x04001499 RID: 5273
		public string Montage;

		// Token: 0x0400149A RID: 5274
		public IMontageId RegisteredMontageId;

		// Token: 0x0400149B RID: 5275
		public int? FaceExpressionId;

		// Token: 0x0400149C RID: 5276
		public int PosEntityId;
	}
}
