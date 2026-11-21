using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002070 RID: 8304
	public class ISetNpcTwoPersonPerform_SetValue
	{
		// Token: 0x040068E4 RID: 26852
		public ENpcGroupPerformType Type;

		// Token: 0x040068E5 RID: 26853
		public IPlayerInitiator Initiator;

		// Token: 0x040068E6 RID: 26854
		public int Target;

		// Token: 0x040068E7 RID: 26855
		public string GroupPerformMark;

		// Token: 0x040068E8 RID: 26856
		public ENpcGroupPerformNpcType NpcType;

		// Token: 0x040068E9 RID: 26857
		public EWaitInteractNpcMontageWaitType? WaitInteractNpcType;
	}
}
