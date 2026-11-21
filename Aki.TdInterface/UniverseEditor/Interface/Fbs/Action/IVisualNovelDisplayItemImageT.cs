using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D7A RID: 32122
	public class IVisualNovelDisplayItemImageT
	{
		// Token: 0x1700F054 RID: 61524
		// (get) Token: 0x06039FD0 RID: 237520 RVA: 0x007D1810 File Offset: 0x007CFA10
		// (set) Token: 0x06039FD1 RID: 237521 RVA: 0x007D1818 File Offset: 0x007CFA18
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x1700F055 RID: 61525
		// (get) Token: 0x06039FD2 RID: 237522 RVA: 0x007D1821 File Offset: 0x007CFA21
		// (set) Token: 0x06039FD3 RID: 237523 RVA: 0x007D1829 File Offset: 0x007CFA29
		public int DisplayImageId { get; set; }

		// Token: 0x06039FD4 RID: 237524 RVA: 0x007D1832 File Offset: 0x007CFA32
		public IVisualNovelDisplayItemImageT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
			this.DisplayImageId = 0;
		}
	}
}
