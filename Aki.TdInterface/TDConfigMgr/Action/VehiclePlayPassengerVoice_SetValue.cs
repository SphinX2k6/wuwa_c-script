using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002276 RID: 8822
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice_SetValue
	{
		// Token: 0x0400734C RID: 29516
		public EGondolaVoiceTriggeredType TriggerType;

		// Token: 0x0400734D RID: 29517
		public IPlayVoicePassengersConfig TriggerPassengers;

		// Token: 0x0400734E RID: 29518
		public List<float> TriggerParams;
	}
}
