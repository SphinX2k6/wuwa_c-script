using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D80 RID: 19840
	public class IFrequencyDetectAiLineConfigT
	{
		// Token: 0x17008DF1 RID: 36337
		// (get) Token: 0x0601EC17 RID: 125975 RVA: 0x0044D047 File Offset: 0x0044B247
		// (set) Token: 0x0601EC18 RID: 125976 RVA: 0x0044D04F File Offset: 0x0044B24F
		public EFrequencyDetectLineOwner Type { get; set; }

		// Token: 0x17008DF2 RID: 36338
		// (get) Token: 0x0601EC19 RID: 125977 RVA: 0x0044D058 File Offset: 0x0044B258
		// (set) Token: 0x0601EC1A RID: 125978 RVA: 0x0044D060 File Offset: 0x0044B260
		public int Batch { get; set; }

		// Token: 0x17008DF3 RID: 36339
		// (get) Token: 0x0601EC1B RID: 125979 RVA: 0x0044D069 File Offset: 0x0044B269
		// (set) Token: 0x0601EC1C RID: 125980 RVA: 0x0044D071 File Offset: 0x0044B271
		public string LineId { get; set; }

		// Token: 0x17008DF4 RID: 36340
		// (get) Token: 0x0601EC1D RID: 125981 RVA: 0x0044D07A File Offset: 0x0044B27A
		// (set) Token: 0x0601EC1E RID: 125982 RVA: 0x0044D082 File Offset: 0x0044B282
		public float TrackStayDuration { get; set; }

		// Token: 0x17008DF5 RID: 36341
		// (get) Token: 0x0601EC1F RID: 125983 RVA: 0x0044D08B File Offset: 0x0044B28B
		// (set) Token: 0x0601EC20 RID: 125984 RVA: 0x0044D093 File Offset: 0x0044B293
		public float StartDelay { get; set; }

		// Token: 0x17008DF6 RID: 36342
		// (get) Token: 0x0601EC21 RID: 125985 RVA: 0x0044D09C File Offset: 0x0044B29C
		// (set) Token: 0x0601EC22 RID: 125986 RVA: 0x0044D0A4 File Offset: 0x0044B2A4
		public float PaintSpeed { get; set; }

		// Token: 0x0601EC23 RID: 125987 RVA: 0x0044D0AD File Offset: 0x0044B2AD
		public IFrequencyDetectAiLineConfigT()
		{
			this.Type = EFrequencyDetectLineOwner.AI;
			this.Batch = 0;
			this.LineId = null;
			this.TrackStayDuration = 0f;
			this.StartDelay = 0f;
			this.PaintSpeed = 0f;
		}
	}
}
