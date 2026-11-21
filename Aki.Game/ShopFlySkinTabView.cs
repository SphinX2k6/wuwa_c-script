using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200185B RID: 6235
public class ShopFlySkinTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F6D8 RID: 63192 RVA: 0x00481A8E File Offset: 0x0047FC8E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600F6D9 RID: 63193 RVA: 0x00481AC8 File Offset: 0x0047FCC8
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<FlySkinItemContent, FlySkinItemContentData>(base.GetHorizontalLayout(0), new Func<FlySkinItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x0600F6DA RID: 63194 RVA: 0x00481B2C File Offset: 0x0047FD2C
	[NullableContext(1)]
	private FlySkinItemContent OnCreateItem()
	{
		return new FlySkinItemContent();
	}

	// Token: 0x0600F6DB RID: 63195 RVA: 0x00481B33 File Offset: 0x0047FD33
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x0600F6DC RID: 63196 RVA: 0x00481B3C File Offset: 0x0047FD3C
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

	// Token: 0x0600F6DD RID: 63197 RVA: 0x00481BB6 File Offset: 0x0047FDB6
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x04008A5F RID: 35423
	private int CurrentShopId;

	// Token: 0x04008A60 RID: 35424
	private int TabId;

	// Token: 0x04008A61 RID: 35425
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FlySkinItemContent, FlySkinItemContentData> Layout;

	// Token: 0x02007A9D RID: 31389
	private enum EComponent
	{
		// Token: 0x04027BD3 RID: 162771
		HorizontalLayout,
		// Token: 0x04027BD4 RID: 162772
		Item
	}
}
