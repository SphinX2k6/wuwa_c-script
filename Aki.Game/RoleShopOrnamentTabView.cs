using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002379 RID: 9081
public class RoleShopOrnamentTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x06012244 RID: 74308 RVA: 0x00475389 File Offset: 0x00473589
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012245 RID: 74309 RVA: 0x004753C4 File Offset: 0x004735C4
	protected override void OnStart()
	{
		this.CurrentShopId = (int)(this.ExtraParams ?? 0);
		this.TabId = (int)(this.Params ?? 0);
		this.Layout = new GenericLayout<OrnamentItemContent, OrnamentItemContentData>(base.GetHorizontalLayout(0), new Func<OrnamentItemContent>(this.OnCreateItem), null, false, true);
	}

	// Token: 0x06012246 RID: 74310 RVA: 0x00475428 File Offset: 0x00473628
	[NullableContext(1)]
	private OrnamentItemContent OnCreateItem()
	{
		return new OrnamentItemContent();
	}

	// Token: 0x06012247 RID: 74311 RVA: 0x0047542F File Offset: 0x0047362F
	protected override void OnBeforeShow()
	{
		this.RefreshLayout();
	}

	// Token: 0x06012248 RID: 74312 RVA: 0x00475438 File Offset: 0x00473638
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

	// Token: 0x06012249 RID: 74313 RVA: 0x004754B2 File Offset: 0x004736B2
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
	}

	// Token: 0x04008921 RID: 35105
	private int CurrentShopId;

	// Token: 0x04008922 RID: 35106
	private int TabId;

	// Token: 0x04008923 RID: 35107
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<OrnamentItemContent, OrnamentItemContentData> Layout;

	// Token: 0x02008915 RID: 35093
	private enum EComponent
	{
		// Token: 0x0402C8D7 RID: 182487
		HorizontalLayout,
		// Token: 0x0402C8D8 RID: 182488
		Item
	}
}
