using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FB RID: 1019
	public class IGroupAiPatrol_SetValue
	{
		// Token: 0x0400101D RID: 4125
		public EGroupAiMode Type;

		// Token: 0x0400101E RID: 4126
		public int Leader;

		// Token: 0x0400101F RID: 4127
		public int SplineEntityId;

		// Token: 0x04001020 RID: 4128
		public int? PlayerPlaceholderEntityId;

		// Token: 0x04001021 RID: 4129
		public EGroupAiFormationBasis? FormationBasis;

		// Token: 0x04001022 RID: 4130
		public bool? IsPreciseFormation;

		// Token: 0x04001023 RID: 4131
		[Nullable(2)]
		public IGroupAiEcologyGameplayAbp EcologyGameplayAbp;
	}
}
