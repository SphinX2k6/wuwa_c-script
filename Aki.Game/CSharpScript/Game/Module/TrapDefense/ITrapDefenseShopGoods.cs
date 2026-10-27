using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A76 RID: 19062
	[NullableContext(1)]
	public interface ITrapDefenseShopGoods
	{
		// Token: 0x17007AB8 RID: 31416
		// (get) Token: 0x06031661 RID: 202337
		// (set) Token: 0x06031662 RID: 202338
		int Id { get; set; }

		// Token: 0x17007AB9 RID: 31417
		// (get) Token: 0x06031663 RID: 202339
		// (set) Token: 0x06031664 RID: 202340
		int? OriginalPrice { get; set; }

		// Token: 0x17007ABA RID: 31418
		// (get) Token: 0x06031665 RID: 202341
		// (set) Token: 0x06031666 RID: 202342
		int CurrentPrice { get; set; }

		// Token: 0x17007ABB RID: 31419
		// (get) Token: 0x06031667 RID: 202343
		// (set) Token: 0x06031668 RID: 202344
		ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17007ABC RID: 31420
		// (get) Token: 0x06031669 RID: 202345
		// (set) Token: 0x0603166A RID: 202346
		int QualityId { get; set; }

		// Token: 0x17007ABD RID: 31421
		// (get) Token: 0x0603166B RID: 202347
		// (set) Token: 0x0603166C RID: 202348
		string Name { get; set; }

		// Token: 0x17007ABE RID: 31422
		// (get) Token: 0x0603166D RID: 202349
		// (set) Token: 0x0603166E RID: 202350
		string Desc { get; set; }

		// Token: 0x17007ABF RID: 31423
		// (get) Token: 0x0603166F RID: 202351
		// (set) Token: 0x06031670 RID: 202352
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

		// Token: 0x17007AC0 RID: 31424
		// (get) Token: 0x06031671 RID: 202353
		// (set) Token: 0x06031672 RID: 202354
		string Icon { get; set; }

		// Token: 0x17007AC1 RID: 31425
		// (get) Token: 0x06031673 RID: 202355
		bool Disable { get; }

		// Token: 0x17007AC2 RID: 31426
		// (get) Token: 0x06031674 RID: 202356
		int CanPurchaseNum { get; }

		// Token: 0x17007AC3 RID: 31427
		// (get) Token: 0x06031675 RID: 202357
		ETrapDefenseShopGoodsUnavailableReason DisableReason { get; }

		// Token: 0x17007AC4 RID: 31428
		// (get) Token: 0x06031676 RID: 202358
		// (set) Token: 0x06031677 RID: 202359
		Func<PropMediumItemGrid> GetItemGridParam { get; set; }
	}
}
