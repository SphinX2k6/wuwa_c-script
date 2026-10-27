using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C9 RID: 18633
	public class IWorldEditorTemplateConfigT
	{
		// Token: 0x17008746 RID: 34630
		// (get) Token: 0x0601D22E RID: 119342 RVA: 0x0041D1FF File Offset: 0x0041B3FF
		// (set) Token: 0x0601D22F RID: 119343 RVA: 0x0041D207 File Offset: 0x0041B407
		public string Icon { get; set; }

		// Token: 0x17008747 RID: 34631
		// (get) Token: 0x0601D230 RID: 119344 RVA: 0x0041D210 File Offset: 0x0041B410
		// (set) Token: 0x0601D231 RID: 119345 RVA: 0x0041D218 File Offset: 0x0041B418
		public EZoomType ZoomType { get; set; }

		// Token: 0x17008748 RID: 34632
		// (get) Token: 0x0601D232 RID: 119346 RVA: 0x0041D221 File Offset: 0x0041B421
		// (set) Token: 0x0601D233 RID: 119347 RVA: 0x0041D229 File Offset: 0x0041B429
		public string MainType { get; set; }

		// Token: 0x17008749 RID: 34633
		// (get) Token: 0x0601D234 RID: 119348 RVA: 0x0041D232 File Offset: 0x0041B432
		// (set) Token: 0x0601D235 RID: 119349 RVA: 0x0041D23A File Offset: 0x0041B43A
		public string SubType { get; set; }

		// Token: 0x1700874A RID: 34634
		// (get) Token: 0x0601D236 RID: 119350 RVA: 0x0041D243 File Offset: 0x0041B443
		// (set) Token: 0x0601D237 RID: 119351 RVA: 0x0041D24B File Offset: 0x0041B44B
		public string Tags { get; set; }

		// Token: 0x0601D238 RID: 119352 RVA: 0x0041D254 File Offset: 0x0041B454
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
