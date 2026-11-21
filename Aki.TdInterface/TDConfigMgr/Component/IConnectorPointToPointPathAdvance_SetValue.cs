using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C1 RID: 705
	public class IConnectorPointToPointPathAdvance_SetValue
	{
		// Token: 0x04000C1C RID: 3100
		public EConnectorLogicType Type;

		// Token: 0x04000C1D RID: 3101
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000C1E RID: 3102
		[Nullable(2)]
		public IConnectorPathAdvanceInitiator Initiator;

		// Token: 0x04000C1F RID: 3103
		[Nullable(2)]
		public IConnectorPathAdvanceReceiver Receiver;
	}
}
