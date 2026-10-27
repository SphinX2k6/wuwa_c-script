using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E12 RID: 7698
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestItem : GridProxyAbstract<PlotType>
{
	// Token: 0x0600EA20 RID: 59936 RVA: 0x00376B70 File Offset: 0x00374D70
	public HandBookQuestItem()
	{
		this.QuestHandBookList = new List<PhotographHandBook>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x0600EA21 RID: 59937 RVA: 0x00376B8E File Offset: 0x00374D8E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600EA22 RID: 59938 RVA: 0x00376BC7 File Offset: 0x00374DC7
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayout<HandBookQuestChildItem, HandBookCommonItemData>(base.GetGridLayout(1), new Func<HandBookQuestChildItem>(this.InitChildItem), null, false, true);
	}

	// Token: 0x0600EA23 RID: 59939 RVA: 0x00376BEC File Offset: 0x00374DEC
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

	// Token: 0x0600EA24 RID: 59940 RVA: 0x00376D55 File Offset: 0x00374F55
	private HandBookQuestChildItem InitChildItem()
	{
		return new HandBookQuestChildItem();
	}

	// Token: 0x0600EA25 RID: 59941 RVA: 0x00376D5C File Offset: 0x00374F5C
	public List<HandBookQuestChildItem> GetChildItemList()
	{
		return this.ContentGenericLayout.GetLayoutItemList();
	}

	// Token: 0x0600EA26 RID: 59942 RVA: 0x00376D69 File Offset: 0x00374F69
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

	// Token: 0x04006CA6 RID: 27814
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HandBookQuestChildItem, HandBookCommonItemData> ContentGenericLayout;

	// Token: 0x04006CA7 RID: 27815
	private List<PhotographHandBook> QuestHandBookList;

	// Token: 0x04006CA8 RID: 27816
	private List<HandBookCommonItemData> HandBookCommonItemDataList;
}
