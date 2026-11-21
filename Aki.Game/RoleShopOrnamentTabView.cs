using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200185E RID: 6238
public class RoleShopOrnamentTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F6F4 RID: 63220 RVA: 0x00482509 File Offset: 0x00480709
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600F6F5 RID: 63221 RVA: 0x00482544 File Offset: 0x00480744
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<OrnamentItemContent, OrnamentItemContentData>(base.GetHorizontalLayout(0), new Func<OrnamentItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x0600F6F6 RID: 63222 RVA: 0x004825A8 File Offset: 0x004807A8
	[NullableContext(1)]
	private OrnamentItemContent OnCreateItem()
	{
		return new OrnamentItemContent();
	}

	// Token: 0x0600F6F7 RID: 63223 RVA: 0x004825AF File Offset: 0x004807AF
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x0600F6F8 RID: 63224 RVA: 0x004825B8 File Offset: 0x004807B8
	private void RefreshLayout()
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.TabId, true);
		List<OrnamentItemContentData> list = new List<OrnamentItemContentData>();
		int count = payShopTabData.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods data = payShopTabData[i];
			list.Add(new OrnamentItemContentData
			{
				ShopRoleOrnamentData = ShopRoleOrnamentData.Create(data),
				AllData = payShopTabData
			});
		}
		this.Layout.RefreshByData(list, null, true);
	}

	// Token: 0x0600F6F9 RID: 63225 RVA: 0x00482632 File Offset: 0x00480832
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x04008A66 RID: 35430
	private int CurrentShopId;

	// Token: 0x04008A67 RID: 35431
	private int TabId;

	// Token: 0x04008A68 RID: 35432
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<OrnamentItemContent, OrnamentItemContentData> Layout;

	// Token: 0x02007A9F RID: 31391
	private enum EComponent
	{
		// Token: 0x04027BEF RID: 162799
		HorizontalLayout,
		// Token: 0x04027BF0 RID: 162800
		Item
	}
}
