using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

// Token: 0x02001304 RID: 4868
[NullableContext(1)]
[Nullable(0)]
public class PlotHandBookItem : GridProxyAbstract<PlotType>
{
	// Token: 0x0600BFB2 RID: 49074 RVA: 0x0038A427 File Offset: 0x00388627
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

	// Token: 0x0600BFB3 RID: 49075 RVA: 0x0038A454 File Offset: 0x00388654
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BFB4 RID: 49076 RVA: 0x0038A490 File Offset: 0x00388690
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

	// Token: 0x0600BFB5 RID: 49077 RVA: 0x0038A5A4 File Offset: 0x003887A4
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

	// Token: 0x0600BFB6 RID: 49078 RVA: 0x0038A5DE File Offset: 0x003887DE
	public List<PlotHandBookChildItem> GetChildItemList()
	{
		if (this.ContentGenericLayout == null)
		{
			return new List<PlotHandBookChildItem>();
		}
		return this.ContentGenericLayout.GetLayoutItemList();
	}

	// Token: 0x0600BFB7 RID: 49079 RVA: 0x0038A5F9 File Offset: 0x003887F9
	protected override void OnBeforeDestroy()
	{
		this.GeographyHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x04006E2A RID: 28202
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PlotHandBookChildItem> ContentGenericLayout;

	// Token: 0x04006E2B RID: 28203
	private List<PhotographHandBook> GeographyHandBookList;

	// Token: 0x04006E2C RID: 28204
	private List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x02007578 RID: 30072
	[NullableContext(0)]
	private class EGeographyHandBookItemDefine
	{
		// Token: 0x0402626E RID: 156270
		public const int TitleText = 0;

		// Token: 0x0402626F RID: 156271
		public const int GirdLayout = 1;
	}
}
