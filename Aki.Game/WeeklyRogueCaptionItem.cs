using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D32 RID: 11570
public class WeeklyRogueCaptionItem : UiPanelBase
{
	// Token: 0x0601853F RID: 99647 RVA: 0x00631284 File Offset: 0x0062F484
	public WeeklyRogueCaptionItem(bool needCurrency = true)
	{
		this.NeedCurrency = needCurrency;
	}

	// Token: 0x06018540 RID: 99648 RVA: 0x006312B8 File Offset: 0x0062F4B8
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

	// Token: 0x06018541 RID: 99649 RVA: 0x006313C4 File Offset: 0x0062F5C4
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueCaptionItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueCaptionItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018542 RID: 99650 RVA: 0x00631407 File Offset: 0x0062F607
	private void OnBtnBack()
	{
		Action onClickCloseBtnCall = this.OnClickCloseBtnCall;
		if (onClickCloseBtnCall == null)
		{
			return;
		}
		onClickCloseBtnCall();
	}

	// Token: 0x06018543 RID: 99651 RVA: 0x00631419 File Offset: 0x0062F619
	[NullableContext(1)]
	public void SetCloseCallBack(Action call)
	{
		this.OnClickCloseBtnCall = call;
	}

	// Token: 0x06018544 RID: 99652 RVA: 0x00631422 File Offset: 0x0062F622
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x06018545 RID: 99653 RVA: 0x00631435 File Offset: 0x0062F635
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x06018546 RID: 99654 RVA: 0x00631444 File Offset: 0x0062F644
	private void RefreshToggleState()
	{
		EToggleState state = (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state, false, false, false);
	}

	// Token: 0x0400B49F RID: 46239
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400B4A0 RID: 46240
	[Nullable(1)]
	private Action OnClickCloseBtnCall = delegate()
	{
	};

	// Token: 0x0400B4A1 RID: 46241
	public bool NeedCurrency;

	// Token: 0x020092C0 RID: 37568
	private enum EComponents
	{
		// Token: 0x0402F6FA RID: 194298
		PanelCaption,
		// Token: 0x0402F6FB RID: 194299
		BtnBack,
		// Token: 0x0402F6FC RID: 194300
		ToggleDesc,
		// Token: 0x0402F6FD RID: 194301
		TxtDesc,
		// Token: 0x0402F6FE RID: 194302
		BtnInfo
	}
}
