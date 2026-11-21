using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004813 RID: 18451
	public class IOccupationDataT
	{
		// Token: 0x170080C0 RID: 32960
		// (get) Token: 0x0601B4C9 RID: 111817 RVA: 0x003DE5A8 File Offset: 0x003DC7A8
		// (set) Token: 0x0601B4CA RID: 111818 RVA: 0x003DE5B0 File Offset: 0x003DC7B0
		public List<string> Npc { get; set; }

		// Token: 0x170080C1 RID: 32961
		// (get) Token: 0x0601B4CB RID: 111819 RVA: 0x003DE5B9 File Offset: 0x003DC7B9
		// (set) Token: 0x0601B4CC RID: 111820 RVA: 0x003DE5C1 File Offset: 0x003DC7C1
		public List<IOccupationExportConfigT> NpcConfig { get; set; }

		// Token: 0x170080C2 RID: 32962
		// (get) Token: 0x0601B4CD RID: 111821 RVA: 0x003DE5CA File Offset: 0x003DC7CA
		// (set) Token: 0x0601B4CE RID: 111822 RVA: 0x003DE5D2 File Offset: 0x003DC7D2
		public List<string> Area { get; set; }

		// Token: 0x170080C3 RID: 32963
		// (get) Token: 0x0601B4CF RID: 111823 RVA: 0x003DE5DB File Offset: 0x003DC7DB
		// (set) Token: 0x0601B4D0 RID: 111824 RVA: 0x003DE5E3 File Offset: 0x003DC7E3
		public List<IAreaExportDataT> AreaConfig { get; set; }

		// Token: 0x170080C4 RID: 32964
		// (get) Token: 0x0601B4D1 RID: 111825 RVA: 0x003DE5EC File Offset: 0x003DC7EC
		// (set) Token: 0x0601B4D2 RID: 111826 RVA: 0x003DE5F4 File Offset: 0x003DC7F4
		public List<ISilentAreaExportDataT> SilentArea { get; set; }

		// Token: 0x170080C5 RID: 32965
		// (get) Token: 0x0601B4D3 RID: 111827 RVA: 0x003DE5FD File Offset: 0x003DC7FD
		// (set) Token: 0x0601B4D4 RID: 111828 RVA: 0x003DE605 File Offset: 0x003DC805
		public string ScreenResource { get; set; }

		// Token: 0x170080C6 RID: 32966
		// (get) Token: 0x0601B4D5 RID: 111829 RVA: 0x003DE60E File Offset: 0x003DC80E
		// (set) Token: 0x0601B4D6 RID: 111830 RVA: 0x003DE616 File Offset: 0x003DC816
		public string TimeOccupation { get; set; }

		// Token: 0x170080C7 RID: 32967
		// (get) Token: 0x0601B4D7 RID: 111831 RVA: 0x003DE61F File Offset: 0x003DC81F
		// (set) Token: 0x0601B4D8 RID: 111832 RVA: 0x003DE627 File Offset: 0x003DC827
		public string ClosedSegmentOccupation { get; set; }

		// Token: 0x170080C8 RID: 32968
		// (get) Token: 0x0601B4D9 RID: 111833 RVA: 0x003DE630 File Offset: 0x003DC830
		// (set) Token: 0x0601B4DA RID: 111834 RVA: 0x003DE638 File Offset: 0x003DC838
		public List<string> ClosedSegments { get; set; }

		// Token: 0x170080C9 RID: 32969
		// (get) Token: 0x0601B4DB RID: 111835 RVA: 0x003DE641 File Offset: 0x003DC841
		// (set) Token: 0x0601B4DC RID: 111836 RVA: 0x003DE649 File Offset: 0x003DC849
		public List<string> SeasonRotation { get; set; }

		// Token: 0x0601B4DD RID: 111837 RVA: 0x003DE654 File Offset: 0x003DC854
		public IOccupationDataT()
		{
			this.Npc = null;
			this.NpcConfig = null;
			this.Area = null;
			this.AreaConfig = null;
			this.SilentArea = null;
			this.ScreenResource = null;
			this.TimeOccupation = null;
			this.ClosedSegmentOccupation = null;
			this.ClosedSegments = null;
			this.SeasonRotation = null;
		}
	}
}
