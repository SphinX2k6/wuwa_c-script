using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DE RID: 5854
public class AdviceWordItem : UiPanelBase
{
	// Token: 0x0600A7BD RID: 42941 RVA: 0x0025A83C File Offset: 0x00258A3C
	[NullableContext(1)]
	public AdviceWordItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A7BE RID: 42942 RVA: 0x0025A854 File Offset: 0x00258A54
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

	// Token: 0x0600A7BF RID: 42943 RVA: 0x0025A8D4 File Offset: 0x00258AD4
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

	// Token: 0x0600A7C0 RID: 42944 RVA: 0x0025A92A File Offset: 0x00258B2A
	private void OnClickAdviceSortWord()
	{
		this.RefreshView();
		this.RefreshToggleView();
	}

	// Token: 0x0600A7C1 RID: 42945 RVA: 0x0025A938 File Offset: 0x00258B38
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortWordId != this.WordId;
	}

	// Token: 0x0600A7C2 RID: 42946 RVA: 0x0025A94F File Offset: 0x00258B4F
	public void UpdateItem(int wordId)
	{
		this.WordId = wordId;
		this.RefreshView();
		this.RefreshShowInfo();
		this.RefreshToggleView();
	}

	// Token: 0x0600A7C3 RID: 42947 RVA: 0x0025A96C File Offset: 0x00258B6C
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

	// Token: 0x0600A7C4 RID: 42948 RVA: 0x0025A9A0 File Offset: 0x00258BA0
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

	// Token: 0x0600A7C5 RID: 42949 RVA: 0x0025A9DA File Offset: 0x00258BDA
	private void ButtonClick(EToggleState state)
	{
		if (AdviceModel.Instance.PreSelectSortWordId != this.WordId)
		{
			AdviceModel.Instance.PreSelectSortWordId = this.WordId;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSortWord);
		}
	}

	// Token: 0x0600A7C6 RID: 42950 RVA: 0x0025AA10 File Offset: 0x00258C10
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (this.WordId == AdviceModel.Instance.PreSelectSortWordId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A7C7 RID: 42951 RVA: 0x0025AA53 File Offset: 0x00258C53
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSortWord, new Action(this.OnClickAdviceSortWord));
	}

	// Token: 0x04004B9D RID: 19357
	private int WordId;

	// Token: 0x02007CB2 RID: 31922
	private static class EAdviceWordItemComponents
	{
		// Token: 0x04028E6F RID: 167535
		public const int Toggle = 0;

		// Token: 0x04028E70 RID: 167536
		public const int Text = 1;

		// Token: 0x04028E71 RID: 167537
		public const int SelectItem = 2;
	}
}
