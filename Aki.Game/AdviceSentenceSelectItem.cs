using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B92 RID: 2962
public class AdviceSentenceSelectItem : UiPanelBase
{
	// Token: 0x06007B6B RID: 31595 RVA: 0x00263D3E File Offset: 0x00261F3E
	[NullableContext(1)]
	public AdviceSentenceSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B6C RID: 31596 RVA: 0x00263D54 File Offset: 0x00261F54
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

	// Token: 0x06007B6D RID: 31597 RVA: 0x00263DF0 File Offset: 0x00261FF0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}
	}

	// Token: 0x06007B6E RID: 31598 RVA: 0x00263E2C File Offset: 0x0026202C
	private bool CanExecuteChange()
	{
		int currentSentenceSelectIndex = AdviceModel.Instance.CurrentSentenceSelectIndex;
		int? sortType = this.SortType;
		return !(currentSentenceSelectIndex == sortType.GetValueOrDefault() & sortType != null);
	}

	// Token: 0x06007B6F RID: 31599 RVA: 0x00263E60 File Offset: 0x00262060
	public void UpdateItem(int id)
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.ButtonClick));
		this.SortType = new int?(id);
		this.RefreshView();
		this.RefreshShowInfo();
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x00263EB4 File Offset: 0x002620B4
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

	// Token: 0x06007B71 RID: 31601 RVA: 0x00263F0C File Offset: 0x0026210C
	private void RefreshShowInfo()
	{
		int? sortType = this.SortType;
		int num = 0;
		string textTableId = (sortType.GetValueOrDefault() == num & sortType != null) ? "AdviceFirstSentence" : "AdviceSecondSentence";
		LguiUtil.Instance.SetLocalText(base.GetText(4), textTableId, Array.Empty<object>());
	}

	// Token: 0x06007B72 RID: 31602 RVA: 0x00263F5C File Offset: 0x0026215C
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

	// Token: 0x04004C36 RID: 19510
	private int? SortType;

	// Token: 0x02006E33 RID: 28211
	private static class EAdviceWordTypeItemComponents
	{
		// Token: 0x04024183 RID: 147843
		public const int Toggle = 0;

		// Token: 0x04024184 RID: 147844
		public const int Texture = 1;

		// Token: 0x04024185 RID: 147845
		public const int NotFoundActor = 2;

		// Token: 0x04024186 RID: 147846
		public const int TextLv = 3;

		// Token: 0x04024187 RID: 147847
		public const int TextName = 4;

		// Token: 0x04024188 RID: 147848
		public const int CopyType = 5;
	}
}
