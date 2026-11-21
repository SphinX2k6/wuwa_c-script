using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D50 RID: 32080
	public class IVisualNovelBackgroundBaseT
	{
		// Token: 0x1700F012 RID: 61458
		// (get) Token: 0x06039E9E RID: 237214 RVA: 0x007CF9EE File Offset: 0x007CDBEE
		// (set) Token: 0x06039E9F RID: 237215 RVA: 0x007CF9F6 File Offset: 0x007CDBF6
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x06039EA0 RID: 237216 RVA: 0x007CF9FF File Offset: 0x007CDBFF
		public IVisualNovelBackgroundBaseT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
		}
	}
}
