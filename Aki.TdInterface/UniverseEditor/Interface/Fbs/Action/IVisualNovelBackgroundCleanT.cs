using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D56 RID: 32086
	public class IVisualNovelBackgroundCleanT
	{
		// Token: 0x1700F017 RID: 61463
		// (get) Token: 0x06039EBE RID: 237246 RVA: 0x007CFCAE File Offset: 0x007CDEAE
		// (set) Token: 0x06039EBF RID: 237247 RVA: 0x007CFCB6 File Offset: 0x007CDEB6
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x06039EC0 RID: 237248 RVA: 0x007CFCBF File Offset: 0x007CDEBF
		public IVisualNovelBackgroundCleanT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
		}
	}
}
