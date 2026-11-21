using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D7D RID: 32125
	public class IVisualNovelDisplayItemPrefabT
	{
		// Token: 0x1700F059 RID: 61529
		// (get) Token: 0x06039FE6 RID: 237542 RVA: 0x007D1A10 File Offset: 0x007CFC10
		// (set) Token: 0x06039FE7 RID: 237543 RVA: 0x007D1A18 File Offset: 0x007CFC18
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x1700F05A RID: 61530
		// (get) Token: 0x06039FE8 RID: 237544 RVA: 0x007D1A21 File Offset: 0x007CFC21
		// (set) Token: 0x06039FE9 RID: 237545 RVA: 0x007D1A29 File Offset: 0x007CFC29
		public int PrefabId { get; set; }

		// Token: 0x06039FEA RID: 237546 RVA: 0x007D1A32 File Offset: 0x007CFC32
		public IVisualNovelDisplayItemPrefabT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
			this.PrefabId = 0;
		}
	}
}
