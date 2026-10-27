using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007572 RID: 30066
	public class IVisualNovelCgLoadSpineT
	{
		// Token: 0x1700E403 RID: 58371
		// (get) Token: 0x06036B1C RID: 224028 RVA: 0x0076D45C File Offset: 0x0076B65C
		// (set) Token: 0x06036B1D RID: 224029 RVA: 0x0076D464 File Offset: 0x0076B664
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x1700E404 RID: 58372
		// (get) Token: 0x06036B1E RID: 224030 RVA: 0x0076D46D File Offset: 0x0076B66D
		// (set) Token: 0x06036B1F RID: 224031 RVA: 0x0076D475 File Offset: 0x0076B675
		public int SpineId { get; set; }

		// Token: 0x06036B20 RID: 224032 RVA: 0x0076D47E File Offset: 0x0076B67E
		public IVisualNovelCgLoadSpineT()
		{
			this.Type = EVisualNovelCgType.LoadSpine;
			this.SpineId = 0;
		}
	}
}
