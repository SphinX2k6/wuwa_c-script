using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756F RID: 30063
	public class IVisualNovelCgLoadImageT
	{
		// Token: 0x1700E3FE RID: 58366
		// (get) Token: 0x06036B06 RID: 224006 RVA: 0x0076D25C File Offset: 0x0076B45C
		// (set) Token: 0x06036B07 RID: 224007 RVA: 0x0076D264 File Offset: 0x0076B464
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x1700E3FF RID: 58367
		// (get) Token: 0x06036B08 RID: 224008 RVA: 0x0076D26D File Offset: 0x0076B46D
		// (set) Token: 0x06036B09 RID: 224009 RVA: 0x0076D275 File Offset: 0x0076B475
		public int ImageId { get; set; }

		// Token: 0x06036B0A RID: 224010 RVA: 0x0076D27E File Offset: 0x0076B47E
		public IVisualNovelCgLoadImageT()
		{
			this.Type = EVisualNovelCgType.LoadSpine;
			this.ImageId = 0;
		}
	}
}
