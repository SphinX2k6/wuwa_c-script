using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A77 RID: 19063
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoods : ITrapDefenseShopGoods
	{
		// Token: 0x17007AC5 RID: 31429
		// (get) Token: 0x06031678 RID: 202360 RVA: 0x00B727D4 File Offset: 0x00B709D4
		// (set) Token: 0x06031679 RID: 202361 RVA: 0x00B727DC File Offset: 0x00B709DC
		public int Id { get; set; }

		// Token: 0x17007AC6 RID: 31430
		// (get) Token: 0x0603167A RID: 202362 RVA: 0x00B727E5 File Offset: 0x00B709E5
		// (set) Token: 0x0603167B RID: 202363 RVA: 0x00B727ED File Offset: 0x00B709ED
		public int? OriginalPrice { get; set; }

		// Token: 0x17007AC7 RID: 31431
		// (get) Token: 0x0603167C RID: 202364 RVA: 0x00B727F6 File Offset: 0x00B709F6
		// (set) Token: 0x0603167D RID: 202365 RVA: 0x00B727FE File Offset: 0x00B709FE
		public int CurrentPrice { get; set; }

		// Token: 0x17007AC8 RID: 31432
		// (get) Token: 0x0603167E RID: 202366 RVA: 0x00B72807 File Offset: 0x00B70A07
		// (set) Token: 0x0603167F RID: 202367 RVA: 0x00B7280F File Offset: 0x00B70A0F
		public ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17007AC9 RID: 31433
		// (get) Token: 0x06031680 RID: 202368 RVA: 0x00B72818 File Offset: 0x00B70A18
		// (set) Token: 0x06031681 RID: 202369 RVA: 0x00B72820 File Offset: 0x00B70A20
		public int QualityId { get; set; }

		// Token: 0x17007ACA RID: 31434
		// (get) Token: 0x06031682 RID: 202370 RVA: 0x00B72829 File Offset: 0x00B70A29
		// (set) Token: 0x06031683 RID: 202371 RVA: 0x00B72831 File Offset: 0x00B70A31
		public string Name { get; set; } = "";

		// Token: 0x17007ACB RID: 31435
		// (get) Token: 0x06031684 RID: 202372 RVA: 0x00B7283A File Offset: 0x00B70A3A
		// (set) Token: 0x06031685 RID: 202373 RVA: 0x00B72842 File Offset: 0x00B70A42
		public string Desc { get; set; } = "";

		// Token: 0x17007ACC RID: 31436
		// (get) Token: 0x06031686 RID: 202374 RVA: 0x00B7284B File Offset: 0x00B70A4B
		// (set) Token: 0x06031687 RID: 202375 RVA: 0x00B72853 File Offset: 0x00B70A53
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] DescArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007ACD RID: 31437
		// (get) Token: 0x06031688 RID: 202376 RVA: 0x00B7285C File Offset: 0x00B70A5C
		// (set) Token: 0x06031689 RID: 202377 RVA: 0x00B72864 File Offset: 0x00B70A64
		public string Icon { get; set; } = "";

		// Token: 0x17007ACE RID: 31438
		// (get) Token: 0x0603168A RID: 202378 RVA: 0x00B7286D File Offset: 0x00B70A6D
		public bool Disable { get; }

		// Token: 0x17007ACF RID: 31439
		// (get) Token: 0x0603168B RID: 202379 RVA: 0x00B72875 File Offset: 0x00B70A75
		public int CanPurchaseNum { get; }

		// Token: 0x17007AD0 RID: 31440
		// (get) Token: 0x0603168C RID: 202380 RVA: 0x00B7287D File Offset: 0x00B70A7D
		public ETrapDefenseShopGoodsUnavailableReason DisableReason { get; }

		// Token: 0x17007AD1 RID: 31441
		// (get) Token: 0x0603168D RID: 202381 RVA: 0x00B72885 File Offset: 0x00B70A85
		// (set) Token: 0x0603168E RID: 202382 RVA: 0x00B7288D File Offset: 0x00B70A8D
		public Func<PropMediumItemGrid> GetItemGridParam { get; set; }
	}
}
