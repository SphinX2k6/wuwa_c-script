using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265D RID: 9821
public class QuestChapterItem : UiPanelBase
{
	// Token: 0x06014182 RID: 82306 RVA: 0x00510CE5 File Offset: 0x0050EEE5
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

	// Token: 0x06014183 RID: 82307 RVA: 0x00510D20 File Offset: 0x0050EF20
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

	// Token: 0x06014184 RID: 82308 RVA: 0x00510E5A File Offset: 0x0050F05A
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06014185 RID: 82309 RVA: 0x00510E70 File Offset: 0x0050F070
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

	// Token: 0x06014186 RID: 82310 RVA: 0x00510ECC File Offset: 0x0050F0CC
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

	// Token: 0x06014187 RID: 82311 RVA: 0x00511068 File Offset: 0x0050F268
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

	// Token: 0x06014188 RID: 82312 RVA: 0x005110D0 File Offset: 0x0050F2D0
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

	// Token: 0x06014189 RID: 82313 RVA: 0x00511161 File Offset: 0x0050F361
	private void UpdateToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x0601418A RID: 82314 RVA: 0x0051118B File Offset: 0x0050F38B
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			base.GetItem(3).SetUIActive(true);
			return;
		}
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0601418B RID: 82315 RVA: 0x005111AC File Offset: 0x0050F3AC
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

	// Token: 0x0400977F RID: 38783
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<QuestItem> QuestList;

	// Token: 0x04009780 RID: 38784
	private int ChapterId;

	// Token: 0x04009781 RID: 38785
	[Nullable(2)]
	private TQuestItemSelectHandle ToggleSelectHandle;

	// Token: 0x02008C98 RID: 35992
	private class EComponents
	{
		// Token: 0x0402DA18 RID: 186904
		public const int TxtTitle = 0;

		// Token: 0x0402DA19 RID: 186905
		public const int TxtChapter = 1;

		// Token: 0x0402DA1A RID: 186906
		public const int UiItemQuestPrefab = 2;

		// Token: 0x0402DA1B RID: 186907
		public const int UiQuestParent = 3;

		// Token: 0x0402DA1C RID: 186908
		public const int ToggleItem = 4;

		// Token: 0x0402DA1D RID: 186909
		public const int TitleBg = 5;

		// Token: 0x0402DA1E RID: 186910
		public const int SelectOutline = 6;

		// Token: 0x0402DA1F RID: 186911
		public const int TextureLine = 7;
	}
}
