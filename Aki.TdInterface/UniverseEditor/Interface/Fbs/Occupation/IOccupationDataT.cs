using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B1 RID: 17329
	public class IOccupationDataT
	{
		// Token: 0x17007A8A RID: 31370
		// (get) Token: 0x06019D32 RID: 105778 RVA: 0x003B297B File Offset: 0x003B0B7B
		// (set) Token: 0x06019D33 RID: 105779 RVA: 0x003B2983 File Offset: 0x003B0B83
		public List<string> Npc { get; set; }

		// Token: 0x17007A8B RID: 31371
		// (get) Token: 0x06019D34 RID: 105780 RVA: 0x003B298C File Offset: 0x003B0B8C
		// (set) Token: 0x06019D35 RID: 105781 RVA: 0x003B2994 File Offset: 0x003B0B94
		public List<IOccupationExportConfigT> NpcConfig { get; set; }

		// Token: 0x17007A8C RID: 31372
		// (get) Token: 0x06019D36 RID: 105782 RVA: 0x003B299D File Offset: 0x003B0B9D
		// (set) Token: 0x06019D37 RID: 105783 RVA: 0x003B29A5 File Offset: 0x003B0BA5
		public List<string> Area { get; set; }

		// Token: 0x17007A8D RID: 31373
		// (get) Token: 0x06019D38 RID: 105784 RVA: 0x003B29AE File Offset: 0x003B0BAE
		// (set) Token: 0x06019D39 RID: 105785 RVA: 0x003B29B6 File Offset: 0x003B0BB6
		public List<IAreaExportDataT> AreaConfig { get; set; }

		// Token: 0x17007A8E RID: 31374
		// (get) Token: 0x06019D3A RID: 105786 RVA: 0x003B29BF File Offset: 0x003B0BBF
		// (set) Token: 0x06019D3B RID: 105787 RVA: 0x003B29C7 File Offset: 0x003B0BC7
		public List<ISilentAreaExportDataT> SilentArea { get; set; }

		// Token: 0x17007A8F RID: 31375
		// (get) Token: 0x06019D3C RID: 105788 RVA: 0x003B29D0 File Offset: 0x003B0BD0
		// (set) Token: 0x06019D3D RID: 105789 RVA: 0x003B29D8 File Offset: 0x003B0BD8
		public string ScreenResource { get; set; }

		// Token: 0x17007A90 RID: 31376
		// (get) Token: 0x06019D3E RID: 105790 RVA: 0x003B29E1 File Offset: 0x003B0BE1
		// (set) Token: 0x06019D3F RID: 105791 RVA: 0x003B29E9 File Offset: 0x003B0BE9
		public string TimeOccupation { get; set; }

		// Token: 0x17007A91 RID: 31377
		// (get) Token: 0x06019D40 RID: 105792 RVA: 0x003B29F2 File Offset: 0x003B0BF2
		// (set) Token: 0x06019D41 RID: 105793 RVA: 0x003B29FA File Offset: 0x003B0BFA
		public string ClosedSegmentOccupation { get; set; }

		// Token: 0x17007A92 RID: 31378
		// (get) Token: 0x06019D42 RID: 105794 RVA: 0x003B2A03 File Offset: 0x003B0C03
		// (set) Token: 0x06019D43 RID: 105795 RVA: 0x003B2A0B File Offset: 0x003B0C0B
		public List<string> ClosedSegments { get; set; }

		// Token: 0x06019D44 RID: 105796 RVA: 0x003B2A14 File Offset: 0x003B0C14
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
		}
	}
}
