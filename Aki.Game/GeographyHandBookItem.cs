using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001DDF RID: 7647
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GeographyHandBookItem : GridProxyAbstract<IGeographyHandBookItemData>
{
	// Token: 0x0600E8C4 RID: 59588 RVA: 0x00371ACC File Offset: 0x0036FCCC
	public GeographyHandBookItem()
	{
		this.GeographyHandBookList = new List<GeographyHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.GeographyHandBookChildItemList = new List<GeographyHandBookChildItem>();
	}

	// Token: 0x0600E8C5 RID: 59589 RVA: 0x00371AF5 File Offset: 0x0036FCF5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600E8C6 RID: 59590 RVA: 0x00371B2E File Offset: 0x0036FD2E
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayoutNew<GeographyHandBookChildItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<GeographyHandBookChildItem>(this.InitChildItem), null);
	}

	// Token: 0x0600E8C7 RID: 59591 RVA: 0x00371B50 File Offset: 0x0036FD50
	public override void Refresh(IGeographyHandBookItemData data, bool isSelected, int gridIndex)
	{
		this.GeographyHandBookList = data.HandBookList;
		this.GeographyHandBookList.Sort((GeographyHandBook a, GeographyHandBook b) => a.Id - b.Id);
		base.GetText(0).ShowTextNew(data.Type.TypeDescription);
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		int count = this.GeographyHandBookList.Count;
		for (int i = 0; i < count; i++)
		{
			GeographyHandBook geographyHandBook = this.GeographyHandBookList[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Geography, geographyHandBook.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			handBookCommonItemData.Config = geographyHandBook;
			handBookCommonItemData.IsLock = isLock;
			handBookCommonItemData.IsNew = isNew;
			this.HandBookCommonItemDataList.Add(handBookCommonItemData);
		}
		this.GeographyHandBookChildItemList = new List<GeographyHandBookChildItem>();
		this.ContentGenericLayout.RebuildLayoutByDataNew<HandBookCommonItemData>(this.HandBookCommonItemDataList, null);
	}

	// Token: 0x0600E8C8 RID: 59592 RVA: 0x00371C64 File Offset: 0x0036FE64
	private ILayoutItem<GeographyHandBookChildItem> InitChildItem(object data, UUIItem uiItem, int index)
	{
		GeographyHandBookChildItem geographyHandBookChildItem = new GeographyHandBookChildItem(uiItem);
		geographyHandBookChildItem.Refresh((HandBookCommonItemData)data, false, index);
		this.GeographyHandBookChildItemList.Add(geographyHandBookChildItem);
		return new LayoutItem<GeographyHandBookChildItem>
		{
			Key = index,
			Value = geographyHandBookChildItem
		};
	}

	// Token: 0x0600E8C9 RID: 59593 RVA: 0x00371CAA File Offset: 0x0036FEAA
	public List<GeographyHandBookChildItem> GetChildItemList()
	{
		return this.GeographyHandBookChildItemList;
	}

	// Token: 0x0600E8CA RID: 59594 RVA: 0x00371CB2 File Offset: 0x0036FEB2
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.GeographyHandBookList = new List<GeographyHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.GeographyHandBookChildItemList = new List<GeographyHandBookChildItem>();
	}

	// Token: 0x04006BC9 RID: 27593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<GeographyHandBookChildItem> ContentGenericLayout;

	// Token: 0x04006BCA RID: 27594
	private List<GeographyHandBook> GeographyHandBookList;

	// Token: 0x04006BCB RID: 27595
	private List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006BCC RID: 27596
	private List<GeographyHandBookChildItem> GeographyHandBookChildItemList;
}
