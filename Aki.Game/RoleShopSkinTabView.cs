using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002373 RID: 9075
public class RoleShopSkinTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0601220C RID: 74252 RVA: 0x00473F2E File Offset: 0x0047212E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0601220D RID: 74253 RVA: 0x00473F68 File Offset: 0x00472168
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<SkinItemContent, SkinItemContentData>(base.GetHorizontalLayout(0), new Func<SkinItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x0601220E RID: 74254 RVA: 0x00473FCC File Offset: 0x004721CC
	[NullableContext(1)]
	private SkinItemContent OnCreateItem()
	{
		return new SkinItemContent();
	}

	// Token: 0x0601220F RID: 74255 RVA: 0x00473FD3 File Offset: 0x004721D3
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x06012210 RID: 74256 RVA: 0x00473FDC File Offset: 0x004721DC
	private void RefreshLayout()
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.TabId, true);
		List<SkinItemContentData> list = new List<SkinItemContentData>();
		int count = payShopTabData.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods data = payShopTabData[i];
			SkinItemContentData skinItemContentData = new SkinItemContentData();
			ShopSkinData shopSkinData = ShopSkinData.Create(data);
			skinItemContentData.ShopSkinData = shopSkinData;
			skinItemContentData.AllData = payShopTabData;
			list.Add(skinItemContentData);
		}
		this.Layout.RefreshByData(list, null, true);
	}

	// Token: 0x06012211 RID: 74257 RVA: 0x00474056 File Offset: 0x00472256
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x04008913 RID: 35091
	private int CurrentShopId;

	// Token: 0x04008914 RID: 35092
	private int TabId;

	// Token: 0x04008915 RID: 35093
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinItemContent, SkinItemContentData> Layout;

	// Token: 0x02008911 RID: 35089
	private enum EComponent
	{
		// Token: 0x0402C8A1 RID: 182433
		HorizontalLayout,
		// Token: 0x0402C8A2 RID: 182434
		Item
	}
}
