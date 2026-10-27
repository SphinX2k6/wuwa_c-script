using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DA RID: 5850
public class AdviceSentenceSelectItem : UiPanelBase
{
	// Token: 0x0600A78B RID: 42891 RVA: 0x00259936 File Offset: 0x00257B36
	[NullableContext(1)]
	public AdviceSentenceSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A78C RID: 42892 RVA: 0x0025994C File Offset: 0x00257B4C
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

	// Token: 0x0600A78D RID: 42893 RVA: 0x002599E8 File Offset: 0x00257BE8
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}
	}

	// Token: 0x0600A78E RID: 42894 RVA: 0x00259A24 File Offset: 0x00257C24
	private bool CanExecuteChange()
	{
		int currentSentenceSelectIndex = AdviceModel.Instance.CurrentSentenceSelectIndex;
		int? sortType = this.SortType;
		return !(currentSentenceSelectIndex == sortType.GetValueOrDefault() & sortType != null);
	}

	// Token: 0x0600A78F RID: 42895 RVA: 0x00259A58 File Offset: 0x00257C58
	public void UpdateItem(int id)
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.ButtonClick));
		this.SortType = new int?(id);
		this.RefreshView();
		this.RefreshShowInfo();
	}

	// Token: 0x0600A790 RID: 42896 RVA: 0x00259AAC File Offset: 0x00257CAC
	private void RefreshView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		int currentSentenceSelectIndex = AdviceModel.Instance.CurrentSentenceSelectIndex;
		int? sortType = this.SortType;
		EToggleState etoggleState = (!(currentSentenceSelectIndex == sortType.GetValueOrDefault() & sortType != null)) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A791 RID: 42897 RVA: 0x00259B04 File Offset: 0x00257D04
	private void RefreshShowInfo()
	{
		int? sortType = this.SortType;
		int num = 0;
		string textTableId = (sortType.GetValueOrDefault() == num & sortType != null) ? "AdviceFirstSentence" : "AdviceSecondSentence";
		LguiUtil.Instance.SetLocalText(base.GetText(4), textTableId, Array.Empty<object>());
	}

	// Token: 0x0600A792 RID: 42898 RVA: 0x00259B54 File Offset: 0x00257D54
	private void ButtonClick(EToggleState state)
	{
		int currentSentenceSelectIndex = AdviceModel.Instance.CurrentSentenceSelectIndex;
		int? sortType = this.SortType;
		if (!(currentSentenceSelectIndex == sortType.GetValueOrDefault() & sortType != null) && this.SortType != null)
		{
			AdviceModel.Instance.CurrentSentenceSelectIndex = this.SortType.Value;
			EventSystem.Instance.Emit(EEventName.OnClickAdviceSort);
		}
	}

	// Token: 0x04004B8F RID: 19343
	private int? SortType;

	// Token: 0x02007CAE RID: 31918
	private static class EAdviceWordTypeItemComponents
	{
		// Token: 0x04028E5A RID: 167514
		public const int Toggle = 0;

		// Token: 0x04028E5B RID: 167515
		public const int Texture = 1;

		// Token: 0x04028E5C RID: 167516
		public const int NotFoundActor = 2;

		// Token: 0x04028E5D RID: 167517
		public const int TextLv = 3;

		// Token: 0x04028E5E RID: 167518
		public const int TextName = 4;

		// Token: 0x04028E5F RID: 167519
		public const int CopyType = 5;
	}
}
