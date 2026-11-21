using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D95 RID: 19861
	public class IFrequencyDetectPlayerLineConfigT
	{
		// Token: 0x17008E1B RID: 36379
		// (get) Token: 0x0601ECD5 RID: 126165 RVA: 0x0044E62B File Offset: 0x0044C82B
		// (set) Token: 0x0601ECD6 RID: 126166 RVA: 0x0044E633 File Offset: 0x0044C833
		public EFrequencyDetectLineOwner Type { get; set; }

		// Token: 0x17008E1C RID: 36380
		// (get) Token: 0x0601ECD7 RID: 126167 RVA: 0x0044E63C File Offset: 0x0044C83C
		// (set) Token: 0x0601ECD8 RID: 126168 RVA: 0x0044E644 File Offset: 0x0044C844
		public int Batch { get; set; }

		// Token: 0x17008E1D RID: 36381
		// (get) Token: 0x0601ECD9 RID: 126169 RVA: 0x0044E64D File Offset: 0x0044C84D
		// (set) Token: 0x0601ECDA RID: 126170 RVA: 0x0044E655 File Offset: 0x0044C855
		public string LineId { get; set; }

		// Token: 0x17008E1E RID: 36382
		// (get) Token: 0x0601ECDB RID: 126171 RVA: 0x0044E65E File Offset: 0x0044C85E
		// (set) Token: 0x0601ECDC RID: 126172 RVA: 0x0044E666 File Offset: 0x0044C866
		public float TrackStayDuration { get; set; }

		// Token: 0x0601ECDD RID: 126173 RVA: 0x0044E66F File Offset: 0x0044C86F
		public IFrequencyDetectPlayerLineConfigT()
		{
			this.Type = EFrequencyDetectLineOwner.AI;
			this.Batch = 0;
			this.LineId = null;
			this.TrackStayDuration = 0f;
		}
	}
}
