using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062AC RID: 25260
	public class ICaptionParamT
	{
		// Token: 0x1700BC8F RID: 48271
		// (get) Token: 0x0602BA5D RID: 178781 RVA: 0x00602074 File Offset: 0x00600274
		// (set) Token: 0x0602BA5E RID: 178782 RVA: 0x0060207C File Offset: 0x0060027C
		public float StartTime { get; set; }

		// Token: 0x1700BC90 RID: 48272
		// (get) Token: 0x0602BA5F RID: 178783 RVA: 0x00602085 File Offset: 0x00600285
		// (set) Token: 0x0602BA60 RID: 178784 RVA: 0x0060208D File Offset: 0x0060028D
		public float TotalTime { get; set; }

		// Token: 0x1700BC91 RID: 48273
		// (get) Token: 0x0602BA61 RID: 178785 RVA: 0x00602096 File Offset: 0x00600296
		// (set) Token: 0x0602BA62 RID: 178786 RVA: 0x0060209E File Offset: 0x0060029E
		public float IntervalTime { get; set; }

		// Token: 0x1700BC92 RID: 48274
		// (get) Token: 0x0602BA63 RID: 178787 RVA: 0x006020A7 File Offset: 0x006002A7
		// (set) Token: 0x0602BA64 RID: 178788 RVA: 0x006020AF File Offset: 0x006002AF
		public byte NullMask { get; set; }

		// Token: 0x0602BA65 RID: 178789 RVA: 0x006020B8 File Offset: 0x006002B8
		public ICaptionParamT()
		{
			this.StartTime = 0f;
			this.TotalTime = 0f;
			this.IntervalTime = 0f;
			this.NullMask = 0;
		}
	}
}
