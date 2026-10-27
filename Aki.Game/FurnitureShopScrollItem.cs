using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FE9 RID: 4073
[NullableContext(1)]
[Nullable(0)]
public class FurnitureShopScrollItem : UiPanelBase
{
	// Token: 0x06006892 RID: 26770 RVA: 0x0014C85A File Offset: 0x0014AA5A
	public FurnitureShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item)
	{
		this.Scroller = scroller;
		this.Item = item;
	}

	// Token: 0x06006893 RID: 26771 RVA: 0x0014C870 File Offset: 0x0014AA70
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<FurnitureShopGridItem, FurnitureShopGridItemProxy>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<FurnitureShopGridItem>(this.InitItem), false);
	}

	// Token: 0x06006894 RID: 26772 RVA: 0x0014C8A0 File Offset: 0x0014AAA0
	private FurnitureShopGridItem InitItem()
	{
		return new FurnitureShopGridItem();
	}

	// Token: 0x06006895 RID: 26773 RVA: 0x0014C8A8 File Offset: 0x0014AAA8
	private List<PayShopGoods> GetDataList(int shopId, FurnitureFilterConfig filterConfig)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)shopId, 1, true);
		int[] source = filterConfig.TagList();
		List<PayShopGoods> list = new List<PayShopGoods>();
		foreach (PayShopGoods payShopGoods in payShopTabData)
		{
			if (source.Contains(FurnitureModel.Instance.GetFurnitureConfigByGoodsData(payShopGoods).TagId))
			{
				list.Add(payShopGoods);
			}
		}
		return list;
	}

	// Token: 0x06006896 RID: 26774 RVA: 0x0014C930 File Offset: 0x0014AB30
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

	// Token: 0x04002FDD RID: 12253
	protected LoopScrollView<FurnitureShopGridItem, FurnitureShopGridItemProxy> LoopScrollView;

	// Token: 0x04002FDE RID: 12254
	[Nullable(2)]
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x04002FDF RID: 12255
	[Nullable(2)]
	private readonly UUIItem Item;
}
