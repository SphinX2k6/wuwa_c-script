using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200049E RID: 1182
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopScrollItem : UiPanelBase
{
	// Token: 0x06003C2A RID: 15402 RVA: 0x0015511E File Offset: 0x0015331E
	public FurnitureShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item)
	{
		this.Scroller = scroller;
		this.Item = item;
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x00155134 File Offset: 0x00153334
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<FurnitureShopGridItem, FurnitureShopGridItemProxy>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<FurnitureShopGridItem>(this.InitItem), false);
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x00155164 File Offset: 0x00153364
	private FurnitureShopGridItem InitItem()
	{
		return new FurnitureShopGridItem();
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x0015516C File Offset: 0x0015336C
	private List<PayShopGoods> GetDataList(int shopId, FurnitureFilterConfig filterConfig)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, 1, true);
		int[] array = filterConfig.TagList();
		List<PayShopGoods> list = new List<PayShopGoods>();
		foreach (PayShopGoods payShopGoods in payShopTabData)
		{
			if (Array.IndexOf<int>(array, FurnitureModel.Instance.GetFurnitureConfigByGoodsData(payShopGoods).TagId) >= 0)
			{
				list.Add(payShopGoods);
			}
		}
		return list;
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x001551F4 File Offset: 0x001533F4
	public UniTask Refresh(int shopId, FurnitureFilterConfig filterConfig)
	{
		FurnitureShopScrollItem.<Refresh>d__7 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.shopId = shopId;
		<Refresh>d__.filterConfig = filterConfig;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<FurnitureShopScrollItem.<Refresh>d__7>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x04003076 RID: 12406
	protected LoopScrollView<FurnitureShopGridItem, FurnitureShopGridItemProxy> LoopScrollView;

	// Token: 0x04003077 RID: 12407
	[Nullable(2)]
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x04003078 RID: 12408
	[Nullable(2)]
	private readonly UUIItem Item;
}
