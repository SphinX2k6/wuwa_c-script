using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B48 RID: 6984
public class QuestChapterItem : UiPanelBase
{
	// Token: 0x06011664 RID: 71268 RVA: 0x0051F99D File Offset: 0x0051DB9D
	[NullableContext(1)]
	public void Init(UUIItem uiItem, int inChapterId, int inQuestType, List<int> inQuestList, [Nullable(2)] TQuestItemSelectHandle toggleSelectHandle)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		uiItem.SetActive(true, false);
		this.ToggleSelectHandle = toggleSelectHandle;
		this.QuestList = new List<QuestItem>();
		this.UpdateItem(inChapterId, inQuestType, inQuestList);
		this.UpdateToggle();
	}

	// Token: 0x06011665 RID: 71269 RVA: 0x0051F9D8 File Offset: 0x0051DBD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06011666 RID: 71270 RVA: 0x0051FB12 File Offset: 0x0051DD12
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06011667 RID: 71271 RVA: 0x0051FB28 File Offset: 0x0051DD28
	public void OnTick(float delta)
	{
		if (this.QuestList != null)
		{
			foreach (QuestItem questItem in this.QuestList)
			{
				questItem.OnTick(delta);
			}
		}
	}

	// Token: 0x06011668 RID: 71272 RVA: 0x0051FB84 File Offset: 0x0051DD84
	[NullableContext(1)]
	public void UpdateItem(int inChapterId, int inQuestType, List<int> inQuestList)
	{
		this.ChapterId = inChapterId;
		QuestMainType? questMainTypeConfig = QuestNewConfig.Instance.GetQuestMainTypeConfig(inQuestType);
		UUITexture texture = base.GetTexture(7);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(((questMainTypeConfig != null) ? questMainTypeConfig.GetValueOrDefault().TypeColor : null) ?? ""));
		}
		if (!StringUtils.IsEmpty((questMainTypeConfig != null) ? questMainTypeConfig.GetValueOrDefault().QuestChapterBg : null))
		{
			this.SetSpriteByPath(questMainTypeConfig.Value.QuestChapterBg, base.GetSprite(5), false, null, null);
		}
		int num = 0;
		foreach (int inQuestId in inQuestList)
		{
			QuestItem questItem;
			if (num < this.QuestList.Count)
			{
				questItem = this.QuestList[num];
			}
			else
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(2), base.GetItem(2).GetParentAsUIItem());
				questItem = new QuestItem(this.ToggleSelectHandle);
				questItem.SetRootActor(uuiitem.GetOwner(), true);
				this.QuestList.Add(questItem);
			}
			questItem.UpdateItem(inQuestId, inQuestType);
			num++;
		}
		for (int i = 0; i < this.QuestList.Count; i++)
		{
			this.QuestList[i].SetActiveItem(i < inQuestList.Count);
		}
		this.RefreshChapterItem();
	}

	// Token: 0x06011669 RID: 71273 RVA: 0x0051FD20 File Offset: 0x0051DF20
	[NullableContext(2)]
	public QuestItem FindByQuestId(int questId)
	{
		if (this.QuestList == null)
		{
			return null;
		}
		foreach (QuestItem questItem in this.QuestList)
		{
			if (questItem.QuestId == questId)
			{
				return questItem;
			}
		}
		return null;
	}

	// Token: 0x0601166A RID: 71274 RVA: 0x0051FD88 File Offset: 0x0051DF88
	private void RefreshChapterItem()
	{
		QuestChapter value = QuestNewConfig.Instance.GetChapterConfig(this.ChapterId).Value;
		string newText = ConfigMultiTextLang.GetLocalTextNew(value.ChapterName, null) ?? "";
		base.GetText(0).SetText(newText, true);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value.ChapterNum, null);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(value.SectionNum, null);
		LguiUtil.Instance.SetLocalText(base.GetText(1), "QuestChapterText", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			localTextNew2
		}));
	}

	// Token: 0x0601166B RID: 71275 RVA: 0x0051FE19 File Offset: 0x0051E019
	private void UpdateToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x0601166C RID: 71276 RVA: 0x0051FE43 File Offset: 0x0051E043
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			base.GetItem(3).SetUIActive(true);
			return;
		}
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0601166D RID: 71277 RVA: 0x0051FE64 File Offset: 0x0051E064
	public void SetSelected(bool isSelected)
	{
		if (isSelected)
		{
			base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(isSelected);
	}

	// Token: 0x040098D7 RID: 39127
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<QuestItem> QuestList;

	// Token: 0x040098D8 RID: 39128
	private int ChapterId;

	// Token: 0x040098D9 RID: 39129
	[Nullable(2)]
	private TQuestItemSelectHandle ToggleSelectHandle;

	// Token: 0x02007E21 RID: 32289
	private class EComponents
	{
		// Token: 0x04028D2F RID: 167215
		public const int TxtTitle = 0;

		// Token: 0x04028D30 RID: 167216
		public const int TxtChapter = 1;

		// Token: 0x04028D31 RID: 167217
		public const int UiItemQuestPrefab = 2;

		// Token: 0x04028D32 RID: 167218
		public const int UiQuestParent = 3;

		// Token: 0x04028D33 RID: 167219
		public const int ToggleItem = 4;

		// Token: 0x04028D34 RID: 167220
		public const int TitleBg = 5;

		// Token: 0x04028D35 RID: 167221
		public const int SelectOutline = 6;

		// Token: 0x04028D36 RID: 167222
		public const int TextureLine = 7;
	}
}
