using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000454 RID: 1108
	public class IGroupAiPatrol_SetValue
	{
		// Token: 0x0400113F RID: 4415
		public EGroupAiMode Type;

		// Token: 0x04001140 RID: 4416
		public int Leader;

		// Token: 0x04001141 RID: 4417
		public int SplineEntityId;

		// Token: 0x04001142 RID: 4418
		public int? PlayerPlaceholderEntityId;

		// Token: 0x04001143 RID: 4419
		public EGroupAiFormationBasis? FormationBasis;

		// Token: 0x04001144 RID: 4420
		public bool? IsPreciseFormation;

		// Token: 0x04001145 RID: 4421
		[Nullable(2)]
		public IGroupAiEcologyGameplayAbp EcologyGameplayAbp;
	}
}
