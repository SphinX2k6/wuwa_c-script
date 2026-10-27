using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DB RID: 5851
public class AdviceSentenceSelectItemContent : UiPanelBase
{
	// Token: 0x0600A793 RID: 42899 RVA: 0x00259BB7 File Offset: 0x00257DB7
	[NullableContext(1)]
	public AdviceSentenceSelectItemContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A794 RID: 42900 RVA: 0x00259BCC File Offset: 0x00257DCC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ButtonClick))
		};
	}

	// Token: 0x0600A795 RID: 42901 RVA: 0x00259C4C File Offset: 0x00257E4C
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSortWord, new Action(this.OnClickAdviceSortWord));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}
	}

	// Token: 0x0600A796 RID: 42902 RVA: 0x00259CA2 File Offset: 0x00257EA2
	private void OnClickAdviceSortWord()
	{
		this.RefreshView();
		this.RefreshToggleView();
	}

	// Token: 0x0600A797 RID: 42903 RVA: 0x00259CB0 File Offset: 0x00257EB0
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortWordId != this.WordId;
	}

	// Token: 0x0600A798 RID: 42904 RVA: 0x00259CC7 File Offset: 0x00257EC7
	public void UpdateItem(int wordId)
	{
		this.WordId = wordId;
		this.RefreshView();
		this.RefreshShowInfo();
		this.RefreshToggleView();
	}

	// Token: 0x0600A799 RID: 42905 RVA: 0x00259CE4 File Offset: 0x00257EE4
	private void RefreshView()
	{
		int num;
		AdviceModel.Instance.CurrentPreSentenceWordMap.TryGetValue(AdviceModel.Instance.CurrentSentenceSelectIndex, out num);
		bool uiactive = num == this.WordId;
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A79A RID: 42906 RVA: 0x00259D2C File Offset: 0x00257F2C
	private void RefreshShowInfo()
	{
		string text = AdviceConfig.Instance.GetAdviceSentenceText(this.WordId);
		text = (((text != null) ? text.Replace("{}", "_") : null) ?? "");
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600A79B RID: 42907 RVA: 0x00259D80 File Offset: 0x00257F80
	private void ButtonClick(EToggleState state)
	{
		int num;
		AdviceModel.Instance.CurrentPreSentenceWordMap.TryGetValue(AdviceModel.Instance.CurrentSentenceSelectIndex, out num);
		if (num != this.WordId)
		{
			AdviceModel.Instance.CurrentPreSentenceWordMap[AdviceModel.Instance.CurrentSentenceSelectIndex] = this.WordId;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSortWord);
		}
	}

	// Token: 0x0600A79C RID: 42908 RVA: 0x00259DE4 File Offset: 0x00257FE4
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		int num;
		AdviceModel.Instance.CurrentPreSentenceWordMap.TryGetValue(AdviceModel.Instance.CurrentSentenceSelectIndex, out num);
		EToggleState etoggleState = (this.WordId == num) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A79D RID: 42909 RVA: 0x00259E3A File Offset: 0x0025803A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSortWord, new Action(this.OnClickAdviceSortWord));
	}

	// Token: 0x04004B90 RID: 19344
	private int WordId;

	// Token: 0x02007CAF RID: 31919
	private static class EAdviceSentenceSelectItemContentComponents
	{
		// Token: 0x04028E60 RID: 167520
		public const int Toggle = 0;

		// Token: 0x04028E61 RID: 167521
		public const int Text = 1;

		// Token: 0x04028E62 RID: 167522
		public const int SelectItem = 2;
	}
}
