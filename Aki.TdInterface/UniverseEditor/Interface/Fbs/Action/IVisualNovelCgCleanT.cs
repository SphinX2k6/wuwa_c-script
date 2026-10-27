using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756C RID: 30060
	public class IVisualNovelCgCleanT
	{
		// Token: 0x1700E3FA RID: 58362
		// (get) Token: 0x06036AF2 RID: 223986 RVA: 0x0076D082 File Offset: 0x0076B282
		// (set) Token: 0x06036AF3 RID: 223987 RVA: 0x0076D08A File Offset: 0x0076B28A
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x06036AF4 RID: 223988 RVA: 0x0076D093 File Offset: 0x0076B293
		public IVisualNovelCgCleanT()
		{
			this.Type = EVisualNovelCgType.LoadSpine;
		}
	}
}
