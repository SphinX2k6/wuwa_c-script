using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002376 RID: 9078
public class ShopFlySkinTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x06012228 RID: 74280 RVA: 0x0047490E File Offset: 0x00472B0E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012229 RID: 74281 RVA: 0x00474948 File Offset: 0x00472B48
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<FlySkinItemContent, FlySkinItemContentData>(base.GetHorizontalLayout(0), new Func<FlySkinItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x0601222A RID: 74282 RVA: 0x004749AC File Offset: 0x00472BAC
	[NullableContext(1)]
	private FlySkinItemContent OnCreateItem()
	{
		return new FlySkinItemContent();
	}

	// Token: 0x0601222B RID: 74283 RVA: 0x004749B3 File Offset: 0x00472BB3
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x0601222C RID: 74284 RVA: 0x004749BC File Offset: 0x00472BBC
	private void RefreshLayout()
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.TabId, true);
		List<FlySkinItemContentData> list = new List<FlySkinItemContentData>();
		int count = payShopTabData.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods data = payShopTabData[i];
			FlySkinItemContentData flySkinItemContentData = new FlySkinItemContentData();
			ShopFlySkinData shopFlySkinData = ShopFlySkinData.Create(data);
			flySkinItemContentData.ShopFlySkinData = shopFlySkinData;
			flySkinItemContentData.AllData = payShopTabData;
			list.Add(flySkinItemContentData);
		}
		this.Layout.RefreshByData(list, null, true);
	}

	// Token: 0x0601222D RID: 74285 RVA: 0x00474A36 File Offset: 0x00472C36
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x0400891A RID: 35098
	private int CurrentShopId;

	// Token: 0x0400891B RID: 35099
	private int TabId;

	// Token: 0x0400891C RID: 35100
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FlySkinItemContent, FlySkinItemContentData> Layout;

	// Token: 0x02008913 RID: 35091
	private enum EComponent
	{
		// Token: 0x0402C8BB RID: 182459
		HorizontalLayout,
		// Token: 0x0402C8BC RID: 182460
		Item
	}
}
