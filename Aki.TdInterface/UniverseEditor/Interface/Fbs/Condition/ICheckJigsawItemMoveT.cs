using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F81 RID: 20353
	public class ICheckJigsawItemMoveT
	{
		// Token: 0x17009188 RID: 37256
		// (get) Token: 0x0601FB29 RID: 129833 RVA: 0x00468112 File Offset: 0x00466312
		// (set) Token: 0x0601FB2A RID: 129834 RVA: 0x0046811A File Offset: 0x0046631A
		public ECheckJigsawInfoType Type { get; set; }

		// Token: 0x17009189 RID: 37257
		// (get) Token: 0x0601FB2B RID: 129835 RVA: 0x00468123 File Offset: 0x00466323
		// (set) Token: 0x0601FB2C RID: 129836 RVA: 0x0046812B File Offset: 0x0046632B
		public int ItemEntityId { get; set; }

		// Token: 0x1700918A RID: 37258
		// (get) Token: 0x0601FB2D RID: 129837 RVA: 0x00468134 File Offset: 0x00466334
		// (set) Token: 0x0601FB2E RID: 129838 RVA: 0x0046813C File Offset: 0x0046633C
		public ECompare Compare { get; set; }

		// Token: 0x0601FB2F RID: 129839 RVA: 0x00468145 File Offset: 0x00466345
		public ICheckJigsawItemMoveT()
		{
			this.Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
			this.ItemEntityId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
