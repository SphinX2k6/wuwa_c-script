using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B9A RID: 2970
public class AdviceWordTypeItem : UiPanelBase
{
	// Token: 0x06007BBE RID: 31678 RVA: 0x002654A7 File Offset: 0x002636A7
	[NullableContext(1)]
	public AdviceWordTypeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007BBF RID: 31679 RVA: 0x002654BC File Offset: 0x002636BC
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

	// Token: 0x06007BC0 RID: 31680 RVA: 0x00265558 File Offset: 0x00263758
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

	// Token: 0x06007BC1 RID: 31681 RVA: 0x002655AE File Offset: 0x002637AE
	private void RefreshAdviceSort()
	{
		this.RefreshView();
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x002655B6 File Offset: 0x002637B6
	private bool CanExecuteChange()
	{
		return AdviceModel.Instance.PreSelectSortTypeId != this.SortType;
	}

	// Token: 0x06007BC3 RID: 31683 RVA: 0x002655D0 File Offset: 0x002637D0
	public void UpdateItem(int id)
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.ButtonClick));
		this.SortType = id;
		this.RefreshView();
		this.RefreshShowInfo();
	}

	// Token: 0x06007BC4 RID: 31684 RVA: 0x00265620 File Offset: 0x00263820
	private void RefreshView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (AdviceModel.Instance.PreSelectSortTypeId != this.SortType) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x00265664 File Offset: 0x00263864
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

	// Token: 0x06007BC6 RID: 31686 RVA: 0x0026569E File Offset: 0x0026389E
	private void ButtonClick(EToggleState state)
	{
		if (AdviceModel.Instance.PreSelectSortTypeId != this.SortType)
		{
			AdviceModel.Instance.PreSelectSortTypeId = this.SortType;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSort);
		}
	}

	// Token: 0x06007BC7 RID: 31687 RVA: 0x002656D2 File Offset: 0x002638D2
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x04004C4F RID: 19535
	private int SortType;

	// Token: 0x02006E3A RID: 28218
	private static class EAdviceWordTypeItemComponents
	{
		// Token: 0x040241A3 RID: 147875
		public const int Toggle = 0;

		// Token: 0x040241A4 RID: 147876
		public const int Texture = 1;

		// Token: 0x040241A5 RID: 147877
		public const int NotFoundActor = 2;

		// Token: 0x040241A6 RID: 147878
		public const int TextLv = 3;

		// Token: 0x040241A7 RID: 147879
		public const int TextName = 4;

		// Token: 0x040241A8 RID: 147880
		public const int CopyType = 5;
	}
}
