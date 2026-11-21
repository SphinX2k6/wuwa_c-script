using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A1E RID: 14878
	[NullableContext(1)]
	public interface ITrapDefenseShopGoods
	{
		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x060263F1 RID: 156657
		// (set) Token: 0x060263F2 RID: 156658
		int Id { get; set; }

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x060263F3 RID: 156659
		// (set) Token: 0x060263F4 RID: 156660
		int? OriginalPrice { get; set; }

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x060263F5 RID: 156661
		// (set) Token: 0x060263F6 RID: 156662
		int CurrentPrice { get; set; }

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x060263F7 RID: 156663
		// (set) Token: 0x060263F8 RID: 156664
		ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x060263F9 RID: 156665
		// (set) Token: 0x060263FA RID: 156666
		int QualityId { get; set; }

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x060263FB RID: 156667
		// (set) Token: 0x060263FC RID: 156668
		string Name { get; set; }

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x060263FD RID: 156669
		// (set) Token: 0x060263FE RID: 156670
		string Desc { get; set; }

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x060263FF RID: 156671
		// (set) Token: 0x06026400 RID: 156672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] DescArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x06026401 RID: 156673
		// (set) Token: 0x06026402 RID: 156674
		string Icon { get; set; }

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x06026403 RID: 156675
		bool Disable { get; }

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x06026404 RID: 156676
		int CanPurchaseNum { get; }

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x06026405 RID: 156677
		ETrapDefenseShopGoodsUnavailableReason DisableReason { get; }

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06026406 RID: 156678
		// (set) Token: 0x06026407 RID: 156679
		Func<PropMediumItemGrid> GetItemGridParam { get; set; }
	}
}
