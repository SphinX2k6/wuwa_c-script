using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B93 RID: 2963
public class AdviceSentenceSelectItemContent : UiPanelBase
{
	// Token: 0x06007B73 RID: 31603 RVA: 0x00263FBF File Offset: 0x002621BF
	[NullableContext(1)]
	public AdviceSentenceSelectItemContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B74 RID: 31604 RVA: 0x00263FD4 File Offset: 0x002621D4
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

	// Token: 0x06007B75 RID: 31605 RVA: 0x00264054 File Offset: 0x00262254
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

	// Token: 0x06007B76 RID: 31606 RVA: 0x002640AA File Offset: 0x002622AA
	private void OnClickAdviceSortWord()
	{
		this.RefreshView();
		this.RefreshToggleView();
	}

	// Token: 0x06007B77 RID: 31607 RVA: 0x002640B8 File Offset: 0x002622B8
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortWordId != this.WordId;
	}

	// Token: 0x06007B78 RID: 31608 RVA: 0x002640CF File Offset: 0x002622CF
	public void UpdateItem(int wordId)
	{
		this.WordId = wordId;
		this.RefreshView();
		this.RefreshShowInfo();
		this.RefreshToggleView();
	}

	// Token: 0x06007B79 RID: 31609 RVA: 0x002640EC File Offset: 0x002622EC
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

	// Token: 0x06007B7A RID: 31610 RVA: 0x00264134 File Offset: 0x00262334
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

	// Token: 0x06007B7B RID: 31611 RVA: 0x00264188 File Offset: 0x00262388
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

	// Token: 0x06007B7C RID: 31612 RVA: 0x002641EC File Offset: 0x002623EC
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

	// Token: 0x06007B7D RID: 31613 RVA: 0x00264242 File Offset: 0x00262442
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSortWord, new Action(this.OnClickAdviceSortWord));
	}

	// Token: 0x04004C37 RID: 19511
	private int WordId;

	// Token: 0x02006E34 RID: 28212
	private static class EAdviceSentenceSelectItemContentComponents
	{
		// Token: 0x04024189 RID: 147849
		public const int Toggle = 0;

		// Token: 0x0402418A RID: 147850
		public const int Text = 1;

		// Token: 0x0402418B RID: 147851
		public const int SelectItem = 2;
	}
}
