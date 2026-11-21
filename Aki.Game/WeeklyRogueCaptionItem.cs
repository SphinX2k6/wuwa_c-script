using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200228C RID: 8844
public class WeeklyRogueCaptionItem : UiPanelBase
{
	// Token: 0x06015DE1 RID: 89569 RVA: 0x00657298 File Offset: 0x00655498
	public WeeklyRogueCaptionItem(bool needCurrency = true)
	{
		this.NeedCurrency = needCurrency;
	}

	// Token: 0x06015DE2 RID: 89570 RVA: 0x006572CC File Offset: 0x006554CC
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		int num = 3;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnBack));
		num2++;
		*span[num2] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnToggleDesc));
		num2++;
		*span[num2] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnInfo));
		this.BtnBindInfo = list;
	}

	// Token: 0x06015DE3 RID: 89571 RVA: 0x006573D8 File Offset: 0x006555D8
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueCaptionItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueCaptionItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015DE4 RID: 89572 RVA: 0x0065741B File Offset: 0x0065561B
	private void OnBtnBack()
	{
		Action onClickCloseBtnCall = this.OnClickCloseBtnCall;
		if (onClickCloseBtnCall == null)
		{
			return;
		}
		onClickCloseBtnCall();
	}

	// Token: 0x06015DE5 RID: 89573 RVA: 0x0065742D File Offset: 0x0065562D
	[NullableContext(1)]
	public void SetCloseCallBack(Action call)
	{
		this.OnClickCloseBtnCall = call;
	}

	// Token: 0x06015DE6 RID: 89574 RVA: 0x00657436 File Offset: 0x00655636
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x06015DE7 RID: 89575 RVA: 0x00657449 File Offset: 0x00655649
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x06015DE8 RID: 89576 RVA: 0x00657458 File Offset: 0x00655658
	private void RefreshToggleState()
	{
		EToggleState state = (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state, false, false, false);
	}

	// Token: 0x0400B814 RID: 47124
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B815 RID: 47125
	[Nullable(1)]
	private Action OnClickCloseBtnCall = delegate()
	{
	};

	// Token: 0x0400B816 RID: 47126
	public bool NeedCurrency;

	// Token: 0x020084E7 RID: 34023
	private enum EComponents
	{
		// Token: 0x0402AD82 RID: 175490
		PanelCaption,
		// Token: 0x0402AD83 RID: 175491
		BtnBack,
		// Token: 0x0402AD84 RID: 175492
		ToggleDesc,
		// Token: 0x0402AD85 RID: 175493
		TxtDesc,
		// Token: 0x0402AD86 RID: 175494
		BtnInfo
	}
}
