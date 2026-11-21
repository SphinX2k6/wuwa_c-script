using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001858 RID: 6232
public class RoleShopSkinTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F6BC RID: 63164 RVA: 0x004810AE File Offset: 0x0047F2AE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600F6BD RID: 63165 RVA: 0x004810E8 File Offset: 0x0047F2E8
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<SkinItemContent, SkinItemContentData>(base.GetHorizontalLayout(0), new Func<SkinItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x0600F6BE RID: 63166 RVA: 0x0048114C File Offset: 0x0047F34C
	[NullableContext(1)]
	private SkinItemContent OnCreateItem()
	{
		return new SkinItemContent();
	}

	// Token: 0x0600F6BF RID: 63167 RVA: 0x00481153 File Offset: 0x0047F353
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x0600F6C0 RID: 63168 RVA: 0x0048115C File Offset: 0x0047F35C
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

	// Token: 0x0600F6C1 RID: 63169 RVA: 0x004811D6 File Offset: 0x0047F3D6
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x04008A58 RID: 35416
	private int CurrentShopId;

	// Token: 0x04008A59 RID: 35417
	private int TabId;

	// Token: 0x04008A5A RID: 35418
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinItemContent, SkinItemContentData> Layout;

	// Token: 0x02007A9B RID: 31387
	private enum EComponent
	{
		// Token: 0x04027BB9 RID: 162745
		HorizontalLayout,
		// Token: 0x04027BBA RID: 162746
		Item
	}
}
