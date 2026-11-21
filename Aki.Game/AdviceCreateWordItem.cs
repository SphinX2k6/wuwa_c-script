using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B88 RID: 2952
public class AdviceCreateWordItem : UiPanelBase
{
	// Token: 0x06007AE3 RID: 31459 RVA: 0x00261531 File Offset: 0x0025F731
	[NullableContext(1)]
	public AdviceCreateWordItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007AE4 RID: 31460 RVA: 0x00261554 File Offset: 0x0025F754
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06007AE5 RID: 31461 RVA: 0x002615AE File Offset: 0x0025F7AE
	protected override void OnStart()
	{
		this.CreateTextItems();
		this.CreateConjunctionItem();
		this.CreateMiddleItemItem();
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06007AE6 RID: 31462 RVA: 0x002615E8 File Offset: 0x0025F7E8
	private void CreateTextItems()
	{
		for (int i = 0; i < 2; i++)
		{
			UUIText uuitext = LguiUtil.Instance.CopyItem(base.GetText(0), this.RootItem) as UUIText;
			if (uuitext != null)
			{
				this.TextArray.Add(uuitext);
			}
		}
	}

	// Token: 0x06007AE7 RID: 31463 RVA: 0x00261630 File Offset: 0x0025F830
	private void CreateConjunctionItem()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		AdviceCreateWordBtnItem conjunctionBtnItem = new AdviceCreateWordBtnItem(LguiUtil.Instance.CopyItem(item, this.RootItem));
		this.ConjunctionBtnItem = conjunctionBtnItem;
		this.ConjunctionBtnItem.SetType(EActiveCreateWordType.Conjunction);
	}

	// Token: 0x06007AE8 RID: 31464 RVA: 0x00261674 File Offset: 0x0025F874
	private void CreateMiddleItemItem()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		AdviceCreateWordBtnItem middleBtnItem = new AdviceCreateWordBtnItem(LguiUtil.Instance.CopyItem(item, this.RootItem));
		this.MiddleBtnItem = middleBtnItem;
		this.MiddleBtnItem.SetType(EActiveCreateWordType.NormalWord);
	}

	// Token: 0x06007AE9 RID: 31465 RVA: 0x002616B7 File Offset: 0x0025F8B7
	public void SetIndex(int index)
	{
		this.Index = index;
		AdviceCreateWordBtnItem conjunctionBtnItem = this.ConjunctionBtnItem;
		if (conjunctionBtnItem != null)
		{
			conjunctionBtnItem.SetIndex(index);
		}
		AdviceCreateWordBtnItem middleBtnItem = this.MiddleBtnItem;
		if (middleBtnItem == null)
		{
			return;
		}
		middleBtnItem.SetIndex(index);
	}

	// Token: 0x06007AEA RID: 31466 RVA: 0x002616E3 File Offset: 0x0025F8E3
	public void RefreshView()
	{
		this.ResetView();
		this.RefreshWord();
	}

	// Token: 0x06007AEB RID: 31467 RVA: 0x002616F4 File Offset: 0x0025F8F4
	private void ResetView()
	{
		UUIItem item = base.GetItem(2);
		foreach (UUIText uuitext in this.TextArray)
		{
			uuitext.SetUIActive(false);
			uuitext.SetUIParent(item, false);
		}
		if (this.ConjunctionBtnItem != null)
		{
			this.ConjunctionBtnItem.GetRootItem().SetUIParent(item, false);
			this.ConjunctionBtnItem.GetRootItem().SetUIActive(false);
		}
		if (this.MiddleBtnItem != null)
		{
			this.MiddleBtnItem.GetRootItem().SetUIParent(item, false);
			this.MiddleBtnItem.GetRootItem().SetUIActive(false);
		}
	}

	// Token: 0x06007AEC RID: 31468 RVA: 0x002617AC File Offset: 0x0025F9AC
	private void RefreshWord()
	{
		int num;
		AdviceModel.Instance.CurrentSentenceWordMap.TryGetValue(this.Index, out num);
		if (num <= 0)
		{
			return;
		}
		if (this.Index > 0 && this.ConjunctionBtnItem != null)
		{
			this.ConjunctionBtnItem.GetRootItem().SetUIParent(this.RootItem, false);
			this.ConjunctionBtnItem.GetRootItem().SetUIActive(true);
			this.ConjunctionBtnItem.RefreshView();
		}
		string adviceSentenceText = AdviceConfig.Instance.GetAdviceSentenceText(num);
		if (adviceSentenceText == null)
		{
			return;
		}
		string[] array = adviceSentenceText.Split(new string[]
		{
			"{}"
		}, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			this.TextArray[i].SetText(array[i], true);
			this.TextArray[i].SetUIParent(this.RootItem, false);
			if (i + 1 < array.Length && this.MiddleBtnItem != null)
			{
				this.MiddleBtnItem.GetRootItem().SetUIParent(this.RootItem, false);
				this.MiddleBtnItem.GetRootItem().SetUIActive(true);
				this.MiddleBtnItem.RefreshView();
			}
			this.TextArray[i].SetUIActive(true);
		}
	}

	// Token: 0x04004C1B RID: 19483
	private int Index;

	// Token: 0x04004C1C RID: 19484
	[Nullable(1)]
	private readonly List<UUIText> TextArray = new List<UUIText>();

	// Token: 0x04004C1D RID: 19485
	[Nullable(2)]
	private AdviceCreateWordBtnItem ConjunctionBtnItem;

	// Token: 0x04004C1E RID: 19486
	[Nullable(2)]
	private AdviceCreateWordBtnItem MiddleBtnItem;

	// Token: 0x02006E28 RID: 28200
	private static class EComponents
	{
		// Token: 0x0402414C RID: 147788
		public const int TextTemplate = 0;

		// Token: 0x0402414D RID: 147789
		public const int WordItem = 1;

		// Token: 0x0402414E RID: 147790
		public const int HideItem = 2;
	}
}
