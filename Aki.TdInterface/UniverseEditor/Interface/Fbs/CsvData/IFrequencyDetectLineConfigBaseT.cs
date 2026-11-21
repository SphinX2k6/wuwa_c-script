using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8F RID: 19855
	public class IFrequencyDetectLineConfigBaseT
	{
		// Token: 0x17008E10 RID: 36368
		// (get) Token: 0x0601ECA7 RID: 126119 RVA: 0x0044E183 File Offset: 0x0044C383
		// (set) Token: 0x0601ECA8 RID: 126120 RVA: 0x0044E18B File Offset: 0x0044C38B
		public EFrequencyDetectLineOwner Type { get; set; }

		// Token: 0x17008E11 RID: 36369
		// (get) Token: 0x0601ECA9 RID: 126121 RVA: 0x0044E194 File Offset: 0x0044C394
		// (set) Token: 0x0601ECAA RID: 126122 RVA: 0x0044E19C File Offset: 0x0044C39C
		public int Batch { get; set; }

		// Token: 0x17008E12 RID: 36370
		// (get) Token: 0x0601ECAB RID: 126123 RVA: 0x0044E1A5 File Offset: 0x0044C3A5
		// (set) Token: 0x0601ECAC RID: 126124 RVA: 0x0044E1AD File Offset: 0x0044C3AD
		public string LineId { get; set; }

		// Token: 0x17008E13 RID: 36371
		// (get) Token: 0x0601ECAD RID: 126125 RVA: 0x0044E1B6 File Offset: 0x0044C3B6
		// (set) Token: 0x0601ECAE RID: 126126 RVA: 0x0044E1BE File Offset: 0x0044C3BE
		public float TrackStayDuration { get; set; }

		// Token: 0x0601ECAF RID: 126127 RVA: 0x0044E1C7 File Offset: 0x0044C3C7
		public IFrequencyDetectLineConfigBaseT()
		{
			this.Type = EFrequencyDetectLineOwner.AI;
			this.Batch = 0;
			this.LineId = null;
			this.TrackStayDuration = 0f;
		}
	}
}
