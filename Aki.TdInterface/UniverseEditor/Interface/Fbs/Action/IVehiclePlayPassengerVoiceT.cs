using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752D RID: 29997
	public class IVehiclePlayPassengerVoiceT
	{
		// Token: 0x1700E3A6 RID: 58278
		// (get) Token: 0x06036941 RID: 223553 RVA: 0x0076A5E8 File Offset: 0x007687E8
		// (set) Token: 0x06036942 RID: 223554 RVA: 0x0076A5F0 File Offset: 0x007687F0
		public EGondolaVoiceTriggeredType TriggerType { get; set; }

		// Token: 0x1700E3A7 RID: 58279
		// (get) Token: 0x06036943 RID: 223555 RVA: 0x0076A5F9 File Offset: 0x007687F9
		// (set) Token: 0x06036944 RID: 223556 RVA: 0x0076A601 File Offset: 0x00768801
		public IPlayVoicePassengersConfigT TriggerPassengers { get; set; }

		// Token: 0x1700E3A8 RID: 58280
		// (get) Token: 0x06036945 RID: 223557 RVA: 0x0076A60A File Offset: 0x0076880A
		// (set) Token: 0x06036946 RID: 223558 RVA: 0x0076A612 File Offset: 0x00768812
		public List<float> TriggerParams { get; set; }

		// Token: 0x1700E3A9 RID: 58281
		// (get) Token: 0x06036947 RID: 223559 RVA: 0x0076A61B File Offset: 0x0076881B
		// (set) Token: 0x06036948 RID: 223560 RVA: 0x0076A623 File Offset: 0x00768823
		public byte NullMask { get; set; }

		// Token: 0x06036949 RID: 223561 RVA: 0x0076A62C File Offset: 0x0076882C
		public IVehiclePlayPassengerVoiceT()
		{
			this.TriggerType = EGondolaVoiceTriggeredType.FindTreasure;
			this.TriggerPassengers = null;
			this.TriggerParams = null;
			this.NullMask = 0;
		}
	}
}
