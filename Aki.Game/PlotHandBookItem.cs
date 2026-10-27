using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001E42 RID: 7746
[NullableContext(1)]
[Nullable(0)]
public class PlotHandBookItem : GridProxyAbstract<PlotType>
{
	// Token: 0x0600EB93 RID: 60307 RVA: 0x0037E797 File Offset: 0x0037C997
	[NullableContext(2)]
	public PlotHandBookItem(UUIItem uiItem = null)
	{
		this.GeographyHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600EB94 RID: 60308 RVA: 0x0037E7C4 File Offset: 0x0037C9C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600EB95 RID: 60309 RVA: 0x0037E800 File Offset: 0x0037CA00
	public override void Refresh(PlotType data, bool isSelected, int gridIndex)
	{
		PlotType plotType = data;
		int id = plotType.Id;
		IReadOnlyList<PhotographHandBook> plotHandBookConfigByType = HandBookConfig.Instance.GetPlotHandBookConfigByType(id);
		this.GeographyHandBookList = ConfigCommon.ToList<PhotographHandBook>(plotHandBookConfigByType);
		base.GetText(0).ShowTextNew(plotType.TypeDescription);
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		int count = this.GeographyHandBookList.Count;
		for (int i = 0; i < count; i++)
		{
			PhotographHandBook photographHandBook = this.GeographyHandBookList[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Quest, photographHandBook.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			handBookCommonItemData.Config = photographHandBook;
			handBookCommonItemData.IsLock = isLock;
			handBookCommonItemData.IsNew = isNew;
			this.HandBookCommonItemDataList.Add(handBookCommonItemData);
		}
		this.ContentGenericLayout = new GenericLayoutNew<PlotHandBookChildItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PlotHandBookChildItem>(this.InitChildItem), null);
		this.ContentGenericLayout.RebuildLayoutByDataNew<HandBookCommonItemData>(this.HandBookCommonItemDataList, null);
	}

	// Token: 0x0600EB96 RID: 60310 RVA: 0x0037E914 File Offset: 0x0037CB14
	private ILayoutItem<PlotHandBookChildItem> InitChildItem(object data, UUIItem uiItem, int index)
	{
		PlotHandBookChildItem plotHandBookChildItem = new PlotHandBookChildItem(uiItem);
		plotHandBookChildItem.Refresh((HandBookCommonItemData)data, false, index);
		return new LayoutItem<PlotHandBookChildItem>
		{
			Key = index,
			Value = plotHandBookChildItem
		};
	}

	// Token: 0x0600EB97 RID: 60311 RVA: 0x0037E94E File Offset: 0x0037CB4E
	public List<PlotHandBookChildItem> GetChildItemList()
	{
		if (this.ContentGenericLayout == null)
		{
			return new List<PlotHandBookChildItem>();
		}
		return this.ContentGenericLayout.GetLayoutItemList();
	}

	// Token: 0x0600EB98 RID: 60312 RVA: 0x0037E969 File Offset: 0x0037CB69
	protected override void OnBeforeDestroy()
	{
		this.GeographyHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x04006D49 RID: 27977
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PlotHandBookChildItem> ContentGenericLayout;

	// Token: 0x04006D4A RID: 27978
	private List<PhotographHandBook> GeographyHandBookList;

	// Token: 0x04006D4B RID: 27979
	private List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x020083F3 RID: 33779
	[NullableContext(0)]
	private class EGeographyHandBookItemDefine
	{
		// Token: 0x0402AF4A RID: 175946
		public const int TitleText = 0;

		// Token: 0x0402AF4B RID: 175947
		public const int GirdLayout = 1;
	}
}
