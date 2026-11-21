using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D2E RID: 19758
	public class IWorldEditorTemplateConfigT
	{
		// Token: 0x17008D8E RID: 36238
		// (get) Token: 0x0601EA1B RID: 125467 RVA: 0x0044999B File Offset: 0x00447B9B
		// (set) Token: 0x0601EA1C RID: 125468 RVA: 0x004499A3 File Offset: 0x00447BA3
		public string Icon { get; set; }

		// Token: 0x17008D8F RID: 36239
		// (get) Token: 0x0601EA1D RID: 125469 RVA: 0x004499AC File Offset: 0x00447BAC
		// (set) Token: 0x0601EA1E RID: 125470 RVA: 0x004499B4 File Offset: 0x00447BB4
		public EZoomType ZoomType { get; set; }

		// Token: 0x17008D90 RID: 36240
		// (get) Token: 0x0601EA1F RID: 125471 RVA: 0x004499BD File Offset: 0x00447BBD
		// (set) Token: 0x0601EA20 RID: 125472 RVA: 0x004499C5 File Offset: 0x00447BC5
		public string MainType { get; set; }

		// Token: 0x17008D91 RID: 36241
		// (get) Token: 0x0601EA21 RID: 125473 RVA: 0x004499CE File Offset: 0x00447BCE
		// (set) Token: 0x0601EA22 RID: 125474 RVA: 0x004499D6 File Offset: 0x00447BD6
		public string SubType { get; set; }

		// Token: 0x17008D92 RID: 36242
		// (get) Token: 0x0601EA23 RID: 125475 RVA: 0x004499DF File Offset: 0x00447BDF
		// (set) Token: 0x0601EA24 RID: 125476 RVA: 0x004499E7 File Offset: 0x00447BE7
		public string Tags { get; set; }

		// Token: 0x0601EA25 RID: 125477 RVA: 0x004499F0 File Offset: 0x00447BF0
		public IWorldEditorTemplateConfigT()
		{
			this.Icon = null;
			this.ZoomType = EZoomType.Default;
			this.MainType = null;
			this.SubType = null;
			this.Tags = null;
		}
	}
}
