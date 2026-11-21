using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E8 RID: 1512
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply_SetValue
	{
		// Token: 0x040015F2 RID: 5618
		public ENpcStandbyShowMode Type;

		// Token: 0x040015F3 RID: 5619
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcLookAtConfig> LookAtConfigs;

		// Token: 0x040015F4 RID: 5620
		public string Montage;

		// Token: 0x040015F5 RID: 5621
		public IMontageId RegisteredMontageId;

		// Token: 0x040015F6 RID: 5622
		public int? FaceExpressionId;

		// Token: 0x040015F7 RID: 5623
		public IIgnoreEntityIdsCollision IgnoreEntityCollision;

		// Token: 0x040015F8 RID: 5624
		public bool? SetFadeInTimeToZero;
	}
}
