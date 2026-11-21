using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616D RID: 24941
	public class IWaySplineT
	{
		// Token: 0x1700B9EA RID: 47594
		// (get) Token: 0x0602A5DD RID: 173533 RVA: 0x005C7E1E File Offset: 0x005C601E
		// (set) Token: 0x0602A5DE RID: 173534 RVA: 0x005C7E26 File Offset: 0x005C6026
		public ESplineType Type { get; set; }

		// Token: 0x1700B9EB RID: 47595
		// (get) Token: 0x0602A5DF RID: 173535 RVA: 0x005C7E2F File Offset: 0x005C602F
		// (set) Token: 0x0602A5E0 RID: 173536 RVA: 0x005C7E37 File Offset: 0x005C6037
		public int RoadZoneId { get; set; }

		// Token: 0x1700B9EC RID: 47596
		// (get) Token: 0x0602A5E1 RID: 173537 RVA: 0x005C7E40 File Offset: 0x005C6040
		// (set) Token: 0x0602A5E2 RID: 173538 RVA: 0x005C7E48 File Offset: 0x005C6048
		public string PcgRoadPathName { get; set; }

		// Token: 0x1700B9ED RID: 47597
		// (get) Token: 0x0602A5E3 RID: 173539 RVA: 0x005C7E51 File Offset: 0x005C6051
		// (set) Token: 0x0602A5E4 RID: 173540 RVA: 0x005C7E59 File Offset: 0x005C6059
		public bool NoEntry { get; set; }

		// Token: 0x1700B9EE RID: 47598
		// (get) Token: 0x0602A5E5 RID: 173541 RVA: 0x005C7E62 File Offset: 0x005C6062
		// (set) Token: 0x0602A5E6 RID: 173542 RVA: 0x005C7E6A File Offset: 0x005C606A
		public IPavedWayConfigT PavedWayConfig { get; set; }

		// Token: 0x1700B9EF RID: 47599
		// (get) Token: 0x0602A5E7 RID: 173543 RVA: 0x005C7E73 File Offset: 0x005C6073
		// (set) Token: 0x0602A5E8 RID: 173544 RVA: 0x005C7E7B File Offset: 0x005C607B
		public List<IWaySplinePointT> Points { get; set; }

		// Token: 0x1700B9F0 RID: 47600
		// (get) Token: 0x0602A5E9 RID: 173545 RVA: 0x005C7E84 File Offset: 0x005C6084
		// (set) Token: 0x0602A5EA RID: 173546 RVA: 0x005C7E8C File Offset: 0x005C608C
		public List<int> Last { get; set; }

		// Token: 0x1700B9F1 RID: 47601
		// (get) Token: 0x0602A5EB RID: 173547 RVA: 0x005C7E95 File Offset: 0x005C6095
		// (set) Token: 0x0602A5EC RID: 173548 RVA: 0x005C7E9D File Offset: 0x005C609D
		public List<int> Next { get; set; }

		// Token: 0x1700B9F2 RID: 47602
		// (get) Token: 0x0602A5ED RID: 173549 RVA: 0x005C7EA6 File Offset: 0x005C60A6
		// (set) Token: 0x0602A5EE RID: 173550 RVA: 0x005C7EAE File Offset: 0x005C60AE
		public int Opposite { get; set; }

		// Token: 0x1700B9F3 RID: 47603
		// (get) Token: 0x0602A5EF RID: 173551 RVA: 0x005C7EB7 File Offset: 0x005C60B7
		// (set) Token: 0x0602A5F0 RID: 173552 RVA: 0x005C7EBF File Offset: 0x005C60BF
		public float Width { get; set; }

		// Token: 0x1700B9F4 RID: 47604
		// (get) Token: 0x0602A5F1 RID: 173553 RVA: 0x005C7EC8 File Offset: 0x005C60C8
		// (set) Token: 0x0602A5F2 RID: 173554 RVA: 0x005C7ED0 File Offset: 0x005C60D0
		public byte NullMask { get; set; }

		// Token: 0x0602A5F3 RID: 173555 RVA: 0x005C7EDC File Offset: 0x005C60DC
		public IWaySplineT()
		{
			this.Type = ESplineType.Common;
			this.RoadZoneId = 0;
			this.PcgRoadPathName = null;
			this.NoEntry = false;
			this.PavedWayConfig = new IPavedWayConfigT();
			this.Points = null;
			this.Last = null;
			this.Next = null;
			this.Opposite = 0;
			this.Width = 0f;
			this.NullMask = 0;
		}
	}
}
