using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002661 RID: 9825
[NullableContext(2)]
[Nullable(0)]
public class QuestTypeItem : UiPanelBase
{
	// Token: 0x060141B5 RID: 82357 RVA: 0x005124A8 File Offset: 0x005106A8
	[NullableContext(1)]
	public void Init(UUIItem uiItem, int inQuestType, TQuestItemSelectHandle selectedHandle)
	{
		this.QuestType = inQuestType;
		this.ToggleSelectHandle = selectedHandle;
		uiItem.SetUIActive(true);
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060141B6 RID: 82358 RVA: 0x005124CC File Offset: 0x005106CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.HandleTypeButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060141B7 RID: 82359 RVA: 0x00512638 File Offset: 0x00510838
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(true);
		QuestMainType? questMainTypeConfig = QuestNewConfig.Instance.GetQuestMainTypeConfig(this.QuestType);
		if (!StringUtils.IsEmpty((questMainTypeConfig != null) ? questMainTypeConfig.GetValueOrDefault().TypeColor : null))
		{
			base.GetSprite(7).SetColor(FColor.FromHex(((questMainTypeConfig != null) ? questMainTypeConfig.GetValueOrDefault().TypeColor : null) ?? ""));
		}
		base.GetText(2).SetText(QuestNewConfig.Instance.GetQuestMainTypeName(this.QuestType), true);
		string questTypeTitleIcon = questMainTypeConfig.Value.QuestTypeTitleIcon;
		if (questTypeTitleIcon == null || questTypeTitleIcon.Length != 0)
		{
			UUISprite sprite = base.GetSprite(3);
			this.SetSpriteByPath(questTypeTitleIcon, sprite, false, null, null);
		}
		this.QuestList = new List<QuestItem>();
		this.ChapterList = new List<QuestChapterItem>();
		this.UpdateList();
	}

	// Token: 0x060141B8 RID: 82360 RVA: 0x00512730 File Offset: 0x00510930
	public void OnTick(float delta)
	{
		if (this.ChapterList != null)
		{
			foreach (QuestChapterItem questChapterItem in this.ChapterList)
			{
				questChapterItem.OnTick(delta);
			}
		}
		if (this.QuestList != null)
		{
			foreach (QuestItem questItem in this.QuestList)
			{
				questItem.OnTick(delta);
			}
		}
	}

	// Token: 0x060141B9 RID: 82361 RVA: 0x005127D4 File Offset: 0x005109D4
	public void UpdateList()
	{
		this.GetQuestItems();
		List<QuestItemData> questItemList = this.QuestItemList;
		List<IQuestChapterData> questChapterItemList = this.QuestChapterItemList;
		int num = 0;
		foreach (IQuestChapterData questChapterData in questChapterItemList)
		{
			if (num < this.ChapterList.Count)
			{
				QuestChapterItem questChapterItem = this.ChapterList[num];
				questChapterItem.UpdateItem(questChapterData.ChapterId, questChapterData.QuestType, questChapterData.QuestList);
			}
			else
			{
				UUIItem uiItem = LguiUtil.Instance.CopyItem(base.GetItem(6), base.GetItem(1));
				QuestChapterItem questChapterItem = new QuestChapterItem();
				questChapterItem.Init(uiItem, questChapterData.ChapterId, questChapterData.QuestType, questChapterData.QuestList, this.ToggleSelectHandle);
				this.ChapterList.Add(questChapterItem);
			}
			num++;
		}
		for (int i = 0; i < this.ChapterList.Count; i++)
		{
			this.ChapterList[i].SetActive(i < questChapterItemList.Count);
		}
		num = 0;
		foreach (QuestItemData questItemData in questItemList)
		{
			QuestItem questItem;
			if (num < this.QuestList.Count)
			{
				questItem = this.QuestList[num];
			}
			else
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(5), base.GetItem(1));
				questItem = new QuestItem(this.ToggleSelectHandle);
				questItem.SetRootActor(uuiitem.GetOwner(), true);
				this.QuestList.Add(questItem);
			}
			questItem.UpdateItem(questItemData.QuestId, questItemData.QuestType);
			num++;
		}
		for (int j = 0; j < this.QuestList.Count; j++)
		{
			this.QuestList[j].SetActiveItem(j < questItemList.Count);
		}
	}

	// Token: 0x060141BA RID: 82362 RVA: 0x005129F4 File Offset: 0x00510BF4
	public void UpdateItem(int questId)
	{
		QuestItem questItem = this.QuestList.Find((QuestItem value) => value.QuestId == questId);
		if (questItem == null)
		{
			foreach (QuestChapterItem questChapterItem in this.ChapterList)
			{
				QuestItem questItem2 = questChapterItem.FindByQuestId(questId);
				if (questItem2 != null)
				{
					questItem = questItem2;
					break;
				}
			}
		}
		if (questItem == null)
		{
			return;
		}
		questItem.UpdateItem(questItem.QuestId, questItem.QuestType);
	}

	// Token: 0x060141BB RID: 82363 RVA: 0x00512A90 File Offset: 0x00510C90
	public void UpdateAllItem()
	{
		foreach (QuestChapterItem questChapterItem in this.ChapterList)
		{
			foreach (QuestItem questItem in (questChapterItem.QuestList ?? new List<QuestItem>()))
			{
				questItem.UpdateItem(questItem.QuestId, questItem.QuestType);
			}
		}
	}

	// Token: 0x060141BC RID: 82364 RVA: 0x00512B30 File Offset: 0x00510D30
	public void OnSelect(int? inQuestId)
	{
		int num;
		if (inQuestId == null || inQuestId.Value == 0)
		{
			QuestItem defaultItem = this.GetDefaultItem();
			num = ((defaultItem != null) ? defaultItem.QuestId : 0);
		}
		else
		{
			num = inQuestId.Value;
		}
		foreach (QuestItem questItem in this.QuestList)
		{
			questItem.SetSelected(questItem.QuestId == num);
			questItem.SetNotAllowNoneSelect();
		}
		foreach (QuestChapterItem questChapterItem in this.ChapterList)
		{
			bool selected = false;
			foreach (QuestItem questItem2 in questChapterItem.QuestList)
			{
				questItem2.SetSelected(questItem2.QuestId == num);
				questItem2.SetNotAllowNoneSelect();
				if (questItem2.QuestId == num)
				{
					selected = true;
				}
			}
			questChapterItem.SetSelected(selected);
		}
	}

	// Token: 0x060141BD RID: 82365 RVA: 0x00512C60 File Offset: 0x00510E60
	public QuestItem GetDefaultItem()
	{
		if (this.QuestList.Count == 0 && this.ChapterList.Count == 0)
		{
			return null;
		}
		if (this.ChapterList.Count != 0)
		{
			return this.ChapterList[0].QuestList[0];
		}
		return this.QuestList[0];
	}

	// Token: 0x060141BE RID: 82366 RVA: 0x00512CBA File Offset: 0x00510EBA
	public bool IsQuestEmpty()
	{
		List<QuestItemData> questItemList = this.QuestItemList;
		if (questItemList != null && questItemList.Count == 0)
		{
			List<QuestChapterItem> chapterList = this.ChapterList;
			return chapterList != null && chapterList.Count == 0;
		}
		return false;
	}

	// Token: 0x060141BF RID: 82367 RVA: 0x00512CEC File Offset: 0x00510EEC
	public void UpdateListTrackState()
	{
		foreach (QuestItem questItem in this.QuestList)
		{
			questItem.UpdateTrackIconActive();
			global::Quest quest = QuestNewModel.Instance.GetQuest(questItem.QuestId);
			if (quest != null)
			{
				questItem.UpdateFunctionIcon(quest);
			}
		}
		foreach (QuestChapterItem questChapterItem in this.ChapterList)
		{
			foreach (QuestItem questItem2 in questChapterItem.QuestList)
			{
				questItem2.UpdateTrackIconActive();
				global::Quest quest2 = QuestNewModel.Instance.GetQuest(questItem2.QuestId);
				if (quest2 != null)
				{
					questItem2.UpdateFunctionIcon(quest2);
				}
			}
		}
	}

	// Token: 0x060141C0 RID: 82368 RVA: 0x00512DF8 File Offset: 0x00510FF8
	public QuestItem GetQuestItem(int questId)
	{
		Predicate<QuestItem> <>9__1;
		foreach (QuestChapterItem questChapterItem in this.ChapterList)
		{
			List<QuestItem> questList = questChapterItem.QuestList;
			Predicate<QuestItem> match;
			if ((match = <>9__1) == null)
			{
				match = (<>9__1 = ((QuestItem value) => value.QuestId == questId));
			}
			QuestItem questItem = questList.Find(match);
			if (questItem != null)
			{
				return questItem;
			}
		}
		return this.QuestList.Find((QuestItem value) => value.QuestId == questId);
	}

	// Token: 0x060141C1 RID: 82369 RVA: 0x00512E9C File Offset: 0x0051109C
	private void GetQuestItems()
	{
		this.QuestItemList = new List<QuestItemData>();
		this.QuestChapterItemList = new List<IQuestChapterData>();
		foreach (QuestType questType in QuestNewConfig.Instance.GetQuesTypesByMainType(this.QuestType))
		{
			List<global::Quest> questsByType = QuestNewModel.Instance.GetQuestsByType(questType.Id);
			if (questsByType.Count != 0)
			{
				questsByType.Sort(new Comparison<global::Quest>(QuestNewModel.Instance.SortQuestInView));
				foreach (global::Quest quest in questsByType)
				{
					if (quest.CanShowInUiPanel())
					{
						int? chapterId = quest.ChapterId;
						if (chapterId != null && chapterId.GetValueOrDefault() != 0)
						{
							this.PushChapterItemList(quest.ChapterId.Value, (int)quest.Type, quest.Id);
						}
						else
						{
							this.QuestItemList.Add(new QuestItemData(quest.Id, (int)quest.Type));
						}
					}
				}
			}
		}
	}

	// Token: 0x060141C2 RID: 82370 RVA: 0x00512FDC File Offset: 0x005111DC
	private void PushChapterItemList(int chapterId, int questType, int questId)
	{
		foreach (IQuestChapterData questChapterData in this.QuestChapterItemList)
		{
			if (questChapterData.ChapterId == chapterId)
			{
				questChapterData.QuestList.Add(questId);
				return;
			}
		}
		this.QuestChapterItemList.Add(new QuestChapterData
		{
			ChapterId = chapterId,
			QuestType = questType,
			QuestList = new List<int>
			{
				questId
			}
		});
	}

	// Token: 0x060141C3 RID: 82371 RVA: 0x00513070 File Offset: 0x00511270
	private void HandleTypeButton()
	{
		UUIItem item = base.GetItem(1);
		item.SetUIActive(!item.bIsUIActive);
	}

	// Token: 0x0400978D RID: 38797
	private TQuestItemSelectHandle ToggleSelectHandle;

	// Token: 0x0400978E RID: 38798
	public int QuestType;

	// Token: 0x0400978F RID: 38799
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestItem> QuestList;

	// Token: 0x04009790 RID: 38800
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestChapterItem> ChapterList;

	// Token: 0x04009791 RID: 38801
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestItemData> QuestItemList;

	// Token: 0x04009792 RID: 38802
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IQuestChapterData> QuestChapterItemList;

	// Token: 0x02008C9D RID: 35997
	[NullableContext(0)]
	private class EQuestListItemComponent
	{
		// Token: 0x0402DA3B RID: 186939
		public const int TypeButton = 0;

		// Token: 0x0402DA3C RID: 186940
		public const int PanelQuestList = 1;

		// Token: 0x0402DA3D RID: 186941
		public const int ListItemName = 2;

		// Token: 0x0402DA3E RID: 186942
		public const int TypeIcon = 3;

		// Token: 0x0402DA3F RID: 186943
		public const int TitleNode = 4;

		// Token: 0x0402DA40 RID: 186944
		public const int QuestItem = 5;

		// Token: 0x0402DA41 RID: 186945
		public const int ChapterItem = 6;

		// Token: 0x0402DA42 RID: 186946
		public const int TitleBg = 7;
	}
}
