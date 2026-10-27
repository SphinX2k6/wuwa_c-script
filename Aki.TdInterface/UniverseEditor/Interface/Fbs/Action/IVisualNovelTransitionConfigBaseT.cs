using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E1 RID: 30177
	public class IVisualNovelTransitionConfigBaseT
	{
		// Token: 0x1700E543 RID: 58691
		// (get) Token: 0x06036F8C RID: 225164 RVA: 0x00775B52 File Offset: 0x00773D52
		// (set) Token: 0x06036F8D RID: 225165 RVA: 0x00775B5A File Offset: 0x00773D5A
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x06036F8E RID: 225166 RVA: 0x00775B63 File Offset: 0x00773D63
		public IVisualNovelTransitionConfigBaseT()
		{
			this.Type = EVisualNovelTransitionType.Location;
		}
	}
}
