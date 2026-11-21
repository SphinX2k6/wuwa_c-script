using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A1F RID: 14879
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoods : ITrapDefenseShopGoods
	{
		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x06026408 RID: 156680 RVA: 0x00AB6758 File Offset: 0x00AB4958
		// (set) Token: 0x06026409 RID: 156681 RVA: 0x00AB6760 File Offset: 0x00AB4960
		public int Id { get; set; }

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x0602640A RID: 156682 RVA: 0x00AB6769 File Offset: 0x00AB4969
		// (set) Token: 0x0602640B RID: 156683 RVA: 0x00AB6771 File Offset: 0x00AB4971
		public int? OriginalPrice { get; set; }

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x0602640C RID: 156684 RVA: 0x00AB677A File Offset: 0x00AB497A
		// (set) Token: 0x0602640D RID: 156685 RVA: 0x00AB6782 File Offset: 0x00AB4982
		public int CurrentPrice { get; set; }

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x0602640E RID: 156686 RVA: 0x00AB678B File Offset: 0x00AB498B
		// (set) Token: 0x0602640F RID: 156687 RVA: 0x00AB6793 File Offset: 0x00AB4993
		public ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x06026410 RID: 156688 RVA: 0x00AB679C File Offset: 0x00AB499C
		// (set) Token: 0x06026411 RID: 156689 RVA: 0x00AB67A4 File Offset: 0x00AB49A4
		public int QualityId { get; set; }

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x06026412 RID: 156690 RVA: 0x00AB67AD File Offset: 0x00AB49AD
		// (set) Token: 0x06026413 RID: 156691 RVA: 0x00AB67B5 File Offset: 0x00AB49B5
		public string Name { get; set; } = "";

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x06026414 RID: 156692 RVA: 0x00AB67BE File Offset: 0x00AB49BE
		// (set) Token: 0x06026415 RID: 156693 RVA: 0x00AB67C6 File Offset: 0x00AB49C6
		public string Desc { get; set; } = "";

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x06026416 RID: 156694 RVA: 0x00AB67CF File Offset: 0x00AB49CF
		// (set) Token: 0x06026417 RID: 156695 RVA: 0x00AB67D7 File Offset: 0x00AB49D7
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

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x06026418 RID: 156696 RVA: 0x00AB67E0 File Offset: 0x00AB49E0
		// (set) Token: 0x06026419 RID: 156697 RVA: 0x00AB67E8 File Offset: 0x00AB49E8
		public string Icon { get; set; } = "";

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x0602641A RID: 156698 RVA: 0x00AB67F1 File Offset: 0x00AB49F1
		public bool Disable { get; }

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x0602641B RID: 156699 RVA: 0x00AB67F9 File Offset: 0x00AB49F9
		public int CanPurchaseNum { get; }

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x0602641C RID: 156700 RVA: 0x00AB6801 File Offset: 0x00AB4A01
		public ETrapDefenseShopGoodsUnavailableReason DisableReason { get; }

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x0602641D RID: 156701 RVA: 0x00AB6809 File Offset: 0x00AB4A09
		// (set) Token: 0x0602641E RID: 156702 RVA: 0x00AB6811 File Offset: 0x00AB4A11
		public Func<PropMediumItemGrid> GetItemGridParam { get; set; }
	}
}
