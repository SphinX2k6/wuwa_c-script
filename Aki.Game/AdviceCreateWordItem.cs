using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D0 RID: 5840
public class AdviceCreateWordItem : UiPanelBase
{
	// Token: 0x0600A703 RID: 42755 RVA: 0x00257125 File Offset: 0x00255325
	[NullableContext(1)]
	public AdviceCreateWordItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A704 RID: 42756 RVA: 0x00257148 File Offset: 0x00255348
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600A705 RID: 42757 RVA: 0x002571A2 File Offset: 0x002553A2
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

	// Token: 0x0600A706 RID: 42758 RVA: 0x002571DC File Offset: 0x002553DC
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

	// Token: 0x0600A707 RID: 42759 RVA: 0x00257224 File Offset: 0x00255424
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

	// Token: 0x0600A708 RID: 42760 RVA: 0x00257268 File Offset: 0x00255468
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

	// Token: 0x0600A709 RID: 42761 RVA: 0x002572AB File Offset: 0x002554AB
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

	// Token: 0x0600A70A RID: 42762 RVA: 0x002572D7 File Offset: 0x002554D7
	public void RefreshView()
	{
		this.ResetView();
		this.RefreshWord();
	}

	// Token: 0x0600A70B RID: 42763 RVA: 0x002572E8 File Offset: 0x002554E8
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

	// Token: 0x0600A70C RID: 42764 RVA: 0x002573A0 File Offset: 0x002555A0
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

	// Token: 0x04004B74 RID: 19316
	private int Index;

	// Token: 0x04004B75 RID: 19317
	[Nullable(1)]
	private readonly List<UUIText> TextArray = new List<UUIText>();

	// Token: 0x04004B76 RID: 19318
	[Nullable(2)]
	private AdviceCreateWordBtnItem ConjunctionBtnItem;

	// Token: 0x04004B77 RID: 19319
	[Nullable(2)]
	private AdviceCreateWordBtnItem MiddleBtnItem;

	// Token: 0x02007CA3 RID: 31907
	private static class EComponents
	{
		// Token: 0x04028E23 RID: 167459
		public const int TextTemplate = 0;

		// Token: 0x04028E24 RID: 167460
		public const int WordItem = 1;

		// Token: 0x04028E25 RID: 167461
		public const int HideItem = 2;
	}
}
