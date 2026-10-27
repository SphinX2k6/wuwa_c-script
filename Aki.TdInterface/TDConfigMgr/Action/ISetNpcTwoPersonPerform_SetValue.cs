using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3B RID: 7739
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcTwoPersonPerform_SetValue
	{
		// Token: 0x04006300 RID: 25344
		public ENpcGroupPerformType Type;

		// Token: 0x04006301 RID: 25345
		public IPlayerInitiator Initiator;

		// Token: 0x04006302 RID: 25346
		public int Target;

		// Token: 0x04006303 RID: 25347
		public string GroupPerformMark;

		// Token: 0x04006304 RID: 25348
		public ENpcGroupPerformNpcType NpcType;

		// Token: 0x04006305 RID: 25349
		public EWaitInteractNpcMontageWaitType? WaitInteractNpcType;
	}
}
