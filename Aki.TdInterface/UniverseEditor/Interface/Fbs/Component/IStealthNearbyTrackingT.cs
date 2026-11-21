using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD9 RID: 24537
	public class IStealthNearbyTrackingT
	{
		// Token: 0x1700B5E6 RID: 46566
		// (get) Token: 0x06029544 RID: 169284 RVA: 0x005A4635 File Offset: 0x005A2835
		// (set) Token: 0x06029545 RID: 169285 RVA: 0x005A463D File Offset: 0x005A283D
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x1700B5E7 RID: 46567
		// (get) Token: 0x06029546 RID: 169286 RVA: 0x005A4646 File Offset: 0x005A2846
		// (set) Token: 0x06029547 RID: 169287 RVA: 0x005A464E File Offset: 0x005A284E
		public int ShowRange { get; set; }

		// Token: 0x1700B5E8 RID: 46568
		// (get) Token: 0x06029548 RID: 169288 RVA: 0x005A4657 File Offset: 0x005A2857
		// (set) Token: 0x06029549 RID: 169289 RVA: 0x005A465F File Offset: 0x005A285F
		public int HideRange { get; set; }

		// Token: 0x1700B5E9 RID: 46569
		// (get) Token: 0x0602954A RID: 169290 RVA: 0x005A4668 File Offset: 0x005A2868
		// (set) Token: 0x0602954B RID: 169291 RVA: 0x005A4670 File Offset: 0x005A2870
		public string Icon { get; set; }

		// Token: 0x1700B5EA RID: 46570
		// (get) Token: 0x0602954C RID: 169292 RVA: 0x005A4679 File Offset: 0x005A2879
		// (set) Token: 0x0602954D RID: 169293 RVA: 0x005A4681 File Offset: 0x005A2881
		public IVectorInfoT IconOffset { get; set; }

		// Token: 0x0602954E RID: 169294 RVA: 0x005A468A File Offset: 0x005A288A
		public IStealthNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.Icon = null;
			this.IconOffset = null;
		}
	}
}
