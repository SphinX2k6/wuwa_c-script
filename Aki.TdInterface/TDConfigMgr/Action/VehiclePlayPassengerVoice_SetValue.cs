using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E3 RID: 9443
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice_SetValue
	{
		// Token: 0x04007999 RID: 31129
		public EGondolaVoiceTriggeredType TriggerType;

		// Token: 0x0400799A RID: 31130
		public IPlayVoicePassengersConfig TriggerPassengers;

		// Token: 0x0400799B RID: 31131
		public List<float> TriggerParams;
	}
}
