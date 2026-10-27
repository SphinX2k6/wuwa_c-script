using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007581 RID: 30081
	public class IVisualNovelDisplayItemCloseT
	{
		// Token: 0x1700E420 RID: 58400
		// (get) Token: 0x06036B94 RID: 224148 RVA: 0x0076E092 File Offset: 0x0076C292
		// (set) Token: 0x06036B95 RID: 224149 RVA: 0x0076E09A File Offset: 0x0076C29A
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x06036B96 RID: 224150 RVA: 0x0076E0A3 File Offset: 0x0076C2A3
		public IVisualNovelDisplayItemCloseT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
		}
	}
}
