using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027E RID: 638
	[NullableContext(2)]
	[Nullable(0)]
	public class IConnectorPointToPointPathAdvance_SetValue
	{
		// Token: 0x04000B3B RID: 2875
		public EConnectorLogicType Type;

		// Token: 0x04000B3C RID: 2876
		[Nullable(1)]
		public IConnectorEffectConfig EffectConfig;

		// Token: 0x04000B3D RID: 2877
		public IConnectorPathAdvanceInitiator Initiator;

		// Token: 0x04000B3E RID: 2878
		public IConnectorPathAdvanceReceiver Receiver;
	}
}
