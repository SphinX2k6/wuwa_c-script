using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x020012A1 RID: 4769
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GeographyHandBookItem : GridProxyAbstract<IGeographyHandBookItemData>
{
	// Token: 0x0600BCE3 RID: 48355 RVA: 0x0037D7B8 File Offset: 0x0037B9B8
	public GeographyHandBookItem()
	{
		this.GeographyHandBookList = new List<GeographyHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.GeographyHandBookChildItemList = new List<GeographyHandBookChildItem>();
	}

	// Token: 0x0600BCE4 RID: 48356 RVA: 0x0037D7E1 File Offset: 0x0037B9E1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x0037D81A File Offset: 0x0037BA1A
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayoutNew<GeographyHandBookChildItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<GeographyHandBookChildItem>(this.InitChildItem), null);
	}

	// Token: 0x0600BCE6 RID: 48358 RVA: 0x0037D83C File Offset: 0x0037BA3C
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

	// Token: 0x0600BCE7 RID: 48359 RVA: 0x0037D950 File Offset: 0x0037BB50
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

	// Token: 0x0600BCE8 RID: 48360 RVA: 0x0037D996 File Offset: 0x0037BB96
	public List<GeographyHandBookChildItem> GetChildItemList()
	{
		return this.GeographyHandBookChildItemList;
	}

	// Token: 0x0600BCE9 RID: 48361 RVA: 0x0037D99E File Offset: 0x0037BB9E
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

	// Token: 0x04006CAA RID: 27818
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<GeographyHandBookChildItem> ContentGenericLayout;

	// Token: 0x04006CAB RID: 27819
	private List<GeographyHandBook> GeographyHandBookList;

	// Token: 0x04006CAC RID: 27820
	private List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006CAD RID: 27821
	private List<GeographyHandBookChildItem> GeographyHandBookChildItemList;
}
