using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D71 RID: 32113
	public class IVisualNovelDisplayItemBaseT
	{
		// Token: 0x1700F04B RID: 61515
		// (get) Token: 0x06039F9A RID: 237466 RVA: 0x007D1332 File Offset: 0x007CF532
		// (set) Token: 0x06039F9B RID: 237467 RVA: 0x007D133A File Offset: 0x007CF53A
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x06039F9C RID: 237468 RVA: 0x007D1343 File Offset: 0x007CF543
		public IVisualNovelDisplayItemBaseT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
		}
	}
}
