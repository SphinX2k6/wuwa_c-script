using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B4C RID: 6988
[NullableContext(2)]
[Nullable(0)]
public class QuestTypeItem : UiPanelBase
{
	// Token: 0x06011697 RID: 71319 RVA: 0x00521160 File Offset: 0x0051F360
	[NullableContext(1)]
	public void Init(UUIItem uiItem, int inQuestType, TQuestItemSelectHandle selectedHandle)
	{
		this.QuestType = inQuestType;
		this.ToggleSelectHandle = selectedHandle;
		uiItem.SetUIActive(true);
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06011698 RID: 71320 RVA: 0x00521184 File Offset: 0x0051F384
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

	// Token: 0x06011699 RID: 71321 RVA: 0x005212F0 File Offset: 0x0051F4F0
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

	// Token: 0x0601169A RID: 71322 RVA: 0x005213E8 File Offset: 0x0051F5E8
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

	// Token: 0x0601169B RID: 71323 RVA: 0x0052148C File Offset: 0x0051F68C
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

	// Token: 0x0601169C RID: 71324 RVA: 0x005216AC File Offset: 0x0051F8AC
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

	// Token: 0x0601169D RID: 71325 RVA: 0x00521748 File Offset: 0x0051F948
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

	// Token: 0x0601169E RID: 71326 RVA: 0x005217E8 File Offset: 0x0051F9E8
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

	// Token: 0x0601169F RID: 71327 RVA: 0x00521918 File Offset: 0x0051FB18
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

	// Token: 0x060116A0 RID: 71328 RVA: 0x00521972 File Offset: 0x0051FB72
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

	// Token: 0x060116A1 RID: 71329 RVA: 0x005219A4 File Offset: 0x0051FBA4
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

	// Token: 0x060116A2 RID: 71330 RVA: 0x00521AB0 File Offset: 0x0051FCB0
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

	// Token: 0x060116A3 RID: 71331 RVA: 0x00521B54 File Offset: 0x0051FD54
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

	// Token: 0x060116A4 RID: 71332 RVA: 0x00521C94 File Offset: 0x0051FE94
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

	// Token: 0x060116A5 RID: 71333 RVA: 0x00521D28 File Offset: 0x0051FF28
	private void HandleTypeButton()
	{
		UUIItem item = base.GetItem(1);
		item.SetUIActive(!item.bIsUIActive);
	}

	// Token: 0x040098E5 RID: 39141
	private TQuestItemSelectHandle ToggleSelectHandle;

	// Token: 0x040098E6 RID: 39142
	public int QuestType;

	// Token: 0x040098E7 RID: 39143
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestItem> QuestList;

	// Token: 0x040098E8 RID: 39144
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestChapterItem> ChapterList;

	// Token: 0x040098E9 RID: 39145
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuestItemData> QuestItemList;

	// Token: 0x040098EA RID: 39146
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IQuestChapterData> QuestChapterItemList;

	// Token: 0x02007E26 RID: 32294
	[NullableContext(0)]
	private class EQuestListItemComponent
	{
		// Token: 0x04028D52 RID: 167250
		public const int TypeButton = 0;

		// Token: 0x04028D53 RID: 167251
		public const int PanelQuestList = 1;

		// Token: 0x04028D54 RID: 167252
		public const int ListItemName = 2;

		// Token: 0x04028D55 RID: 167253
		public const int TypeIcon = 3;

		// Token: 0x04028D56 RID: 167254
		public const int TitleNode = 4;

		// Token: 0x04028D57 RID: 167255
		public const int QuestItem = 5;

		// Token: 0x04028D58 RID: 167256
		public const int ChapterItem = 6;

		// Token: 0x04028D59 RID: 167257
		public const int TitleBg = 7;
	}
}
