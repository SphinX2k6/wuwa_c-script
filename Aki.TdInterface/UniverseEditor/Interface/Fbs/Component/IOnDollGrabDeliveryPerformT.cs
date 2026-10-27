using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005699 RID: 22169
	public class IOnDollGrabDeliveryPerformT
	{
		// Token: 0x1700A4DD RID: 42205
		// (get) Token: 0x06024FF8 RID: 151544 RVA: 0x0051C2D6 File Offset: 0x0051A4D6
		// (set) Token: 0x06024FF9 RID: 151545 RVA: 0x0051C2DE File Offset: 0x0051A4DE
		public string EventMontage { get; set; }

		// Token: 0x1700A4DE RID: 42206
		// (get) Token: 0x06024FFA RID: 151546 RVA: 0x0051C2E7 File Offset: 0x0051A4E7
		// (set) Token: 0x06024FFB RID: 151547 RVA: 0x0051C2EF File Offset: 0x0051A4EF
		public string StandByMontage { get; set; }

		// Token: 0x1700A4DF RID: 42207
		// (get) Token: 0x06024FFC RID: 151548 RVA: 0x0051C2F8 File Offset: 0x0051A4F8
		// (set) Token: 0x06024FFD RID: 151549 RVA: 0x0051C300 File Offset: 0x0051A500
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700A4E0 RID: 42208
		// (get) Token: 0x06024FFE RID: 151550 RVA: 0x0051C309 File Offset: 0x0051A509
		// (set) Token: 0x06024FFF RID: 151551 RVA: 0x0051C311 File Offset: 0x0051A511
		public float PerformDuration { get; set; }

		// Token: 0x1700A4E1 RID: 42209
		// (get) Token: 0x06025000 RID: 151552 RVA: 0x0051C31A File Offset: 0x0051A51A
		// (set) Token: 0x06025001 RID: 151553 RVA: 0x0051C322 File Offset: 0x0051A522
		public byte NullMask { get; set; }

		// Token: 0x06025002 RID: 151554 RVA: 0x0051C32B File Offset: 0x0051A52B
		public IOnDollGrabDeliveryPerformT()
		{
			this.EventMontage = null;
			this.StandByMontage = null;
			this.Flow = null;
			this.PerformDuration = 0f;
			this.NullMask = 0;
		}
	}
}
