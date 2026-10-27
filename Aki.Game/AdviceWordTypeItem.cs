using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016E2 RID: 5858
public class AdviceWordTypeItem : UiPanelBase
{
	// Token: 0x0600A7DE RID: 42974 RVA: 0x0025B09F File Offset: 0x0025929F
	[NullableContext(1)]
	public AdviceWordTypeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A7DF RID: 42975 RVA: 0x0025B0B4 File Offset: 0x002592B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600A7E0 RID: 42976 RVA: 0x0025B150 File Offset: 0x00259350
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}
	}

	// Token: 0x0600A7E1 RID: 42977 RVA: 0x0025B1A6 File Offset: 0x002593A6
	private void RefreshAdviceSort()
	{
		this.RefreshView();
	}

	// Token: 0x0600A7E2 RID: 42978 RVA: 0x0025B1AE File Offset: 0x002593AE
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortTypeId != this.SortType;
	}

	// Token: 0x0600A7E3 RID: 42979 RVA: 0x0025B1C8 File Offset: 0x002593C8
	public void UpdateItem(int id)
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.ButtonClick));
		this.SortType = id;
		this.RefreshView();
		this.RefreshShowInfo();
	}

	// Token: 0x0600A7E4 RID: 42980 RVA: 0x0025B218 File Offset: 0x00259418
	private void RefreshView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (AdviceModel.Instance.PreSelectSortTypeId != this.SortType) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A7E5 RID: 42981 RVA: 0x0025B25C File Offset: 0x0025945C
	private void RefreshShowInfo()
	{
		string adviceTypeText = AdviceConfig.Instance.GetAdviceTypeText(this.SortType);
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(adviceTypeText ?? "", true);
	}

	// Token: 0x0600A7E6 RID: 42982 RVA: 0x0025B296 File Offset: 0x00259496
	private void ButtonClick(EToggleState state)
	{
		if (AdviceModel.Instance.PreSelectSortTypeId != this.SortType)
		{
			AdviceModel.Instance.PreSelectSortTypeId = this.SortType;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSort);
		}
	}

	// Token: 0x0600A7E7 RID: 42983 RVA: 0x0025B2CA File Offset: 0x002594CA
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x04004BA8 RID: 19368
	private int SortType;

	// Token: 0x02007CB5 RID: 31925
	private static class EAdviceWordTypeItemComponents
	{
		// Token: 0x04028E7A RID: 167546
		public const int Toggle = 0;

		// Token: 0x04028E7B RID: 167547
		public const int Texture = 1;

		// Token: 0x04028E7C RID: 167548
		public const int NotFoundActor = 2;

		// Token: 0x04028E7D RID: 167549
		public const int TextLv = 3;

		// Token: 0x04028E7E RID: 167550
		public const int TextName = 4;

		// Token: 0x04028E7F RID: 167551
		public const int CopyType = 5;
	}
}
