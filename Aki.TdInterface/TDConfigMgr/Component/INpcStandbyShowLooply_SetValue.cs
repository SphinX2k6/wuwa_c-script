using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057F RID: 1407
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply_SetValue
	{
		// Token: 0x04001484 RID: 5252
		public ENpcStandbyShowMode Type;

		// Token: 0x04001485 RID: 5253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x04001486 RID: 5254
		public string Montage;

		// Token: 0x04001487 RID: 5255
		public IMontageId RegisteredMontageId;

		// Token: 0x04001488 RID: 5256
		public int? FaceExpressionId;

		// Token: 0x04001489 RID: 5257
		public IIgnoreEntityIdsCollision IgnoreEntityCollision;

		// Token: 0x0400148A RID: 5258
		public bool? SetFadeInTimeToZero;
	}
}
