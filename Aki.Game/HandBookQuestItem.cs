using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012D4 RID: 4820
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestItem : GridProxyAbstract<PlotType>
{
	// Token: 0x0600BE3F RID: 48703 RVA: 0x00382878 File Offset: 0x00380A78
	public HandBookQuestItem()
	{
		this.QuestHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x0600BE40 RID: 48704 RVA: 0x00382896 File Offset: 0x00380A96
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BE41 RID: 48705 RVA: 0x003828CF File Offset: 0x00380ACF
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayout<HandBookQuestChildItem, HandBookCommonItemData>(base.GetGridLayout(1), new Func<HandBookQuestChildItem>(this.InitChildItem), null, false, true);
	}

	// Token: 0x0600BE42 RID: 48706 RVA: 0x003828F4 File Offset: 0x00380AF4
	public override void Refresh(PlotType data, bool isSelected, int gridIndex)
	{
		PlotType plotType = data;
		int id = plotType.Id;
		List<PhotographHandBook> list = ConfigCommon.ToList<PhotographHandBook>(HandBookConfig.Instance.GetPlotHandBookConfigByType(id));
		if (list != null)
		{
			this.QuestHandBookList = list;
			this.QuestHandBookList.Sort((PhotographHandBook a, PhotographHandBook b) => a.Id - b.Id);
		}
		else
		{
			this.QuestHandBookList = new List<PhotographHandBook>();
		}
		base.GetText(0).ShowTextNew(plotType.TypeDescription);
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		int count = this.QuestHandBookList.Count;
		for (int i = 0; i < count; i++)
		{
			PhotographHandBook photographHandBook = this.QuestHandBookList[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo((EHandBookTabType)plotType.Type, photographHandBook.Id);
			bool flag = handBookInfo == null;
			if (!flag)
			{
				bool isNew = handBookInfo != null && !handBookInfo.IsRead;
				handBookCommonItemData.ConfigId = photographHandBook.Id;
				handBookCommonItemData.Config = photographHandBook;
				handBookCommonItemData.IsLock = flag;
				handBookCommonItemData.IsNew = isNew;
				this.HandBookCommonItemDataList.Add(handBookCommonItemData);
			}
		}
		GenericLayout<HandBookQuestChildItem, HandBookCommonItemData> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout != null)
		{
			contentGenericLayout.SetActive(this.HandBookCommonItemDataList.Count > 0);
		}
		GenericLayout<HandBookQuestChildItem, HandBookCommonItemData> contentGenericLayout2 = this.ContentGenericLayout;
		if (contentGenericLayout2 == null)
		{
			return;
		}
		contentGenericLayout2.RefreshByData(this.HandBookCommonItemDataList, null, false);
	}

	// Token: 0x0600BE43 RID: 48707 RVA: 0x00382A5D File Offset: 0x00380C5D
	private HandBookQuestChildItem InitChildItem()
	{
		return new HandBookQuestChildItem();
	}

	// Token: 0x0600BE44 RID: 48708 RVA: 0x00382A64 File Offset: 0x00380C64
	public List<HandBookQuestChildItem> GetChildItemList()
	{
		return this.ContentGenericLayout.GetLayoutItemList();
	}

	// Token: 0x0600BE45 RID: 48709 RVA: 0x00382A71 File Offset: 0x00380C71
	protected override void OnBeforeDestroy()
	{
		if (this.ContentGenericLayout != null)
		{
			this.ContentGenericLayout.ClearChildren();
			this.ContentGenericLayout = null;
		}
		this.QuestHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x04006D87 RID: 28039
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HandBookQuestChildItem, HandBookCommonItemData> ContentGenericLayout;

	// Token: 0x04006D88 RID: 28040
	private List<PhotographHandBook> QuestHandBookList;

	// Token: 0x04006D89 RID: 28041
	private List<HandBookCommonItemData> HandBookCommonItemDataList;
}
