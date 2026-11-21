using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B96 RID: 2966
public class AdviceWordItem : UiPanelBase
{
	// Token: 0x06007B9D RID: 31645 RVA: 0x00264C44 File Offset: 0x00262E44
	[NullableContext(1)]
	public AdviceWordItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B9E RID: 31646 RVA: 0x00264C5C File Offset: 0x00262E5C
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

	// Token: 0x06007B9F RID: 31647 RVA: 0x00264CDC File Offset: 0x00262EDC
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

	// Token: 0x06007BA0 RID: 31648 RVA: 0x00264D32 File Offset: 0x00262F32
	private void OnClickAdviceSortWord()
	{
		this.RefreshView();
		this.RefreshToggleView();
	}

	// Token: 0x06007BA1 RID: 31649 RVA: 0x00264D40 File Offset: 0x00262F40
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortWordId != this.WordId;
	}

	// Token: 0x06007BA2 RID: 31650 RVA: 0x00264D57 File Offset: 0x00262F57
	public void UpdateItem(int wordId)
	{
		this.WordId = wordId;
		this.RefreshView();
		this.RefreshShowInfo();
		this.RefreshToggleView();
	}

	// Token: 0x06007BA3 RID: 31651 RVA: 0x00264D74 File Offset: 0x00262F74
	private void RefreshView()
	{
		bool uiactive = AdviceModel.Instance.CurrentSelectSortWordId == this.WordId;
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06007BA4 RID: 31652 RVA: 0x00264DA8 File Offset: 0x00262FA8
	private void RefreshShowInfo()
	{
		string adviceWordText = AdviceConfig.Instance.GetAdviceWordText(this.WordId);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(adviceWordText ?? "", true);
	}

	// Token: 0x06007BA5 RID: 31653 RVA: 0x00264DE2 File Offset: 0x00262FE2
	private void ButtonClick(EToggleState state)
	{
		if (AdviceModel.Instance.PreSelectSortWordId != this.WordId)
		{
			AdviceModel.Instance.PreSelectSortWordId = this.WordId;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSortWord);
		}
	}

	// Token: 0x06007BA6 RID: 31654 RVA: 0x00264E18 File Offset: 0x00263018
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (this.WordId == AdviceModel.Instance.PreSelectSortWordId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x06007BA7 RID: 31655 RVA: 0x00264E5B File Offset: 0x0026305B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSortWord, new Action(this.OnClickAdviceSortWord));
	}

	// Token: 0x04004C44 RID: 19524
	private int WordId;

	// Token: 0x02006E37 RID: 28215
	private static class EAdviceWordItemComponents
	{
		// Token: 0x04024198 RID: 147864
		public const int Toggle = 0;

		// Token: 0x04024199 RID: 147865
		public const int Text = 1;

		// Token: 0x0402419A RID: 147866
		public const int SelectItem = 2;
	}
}
