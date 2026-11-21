using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022B1 RID: 8881
public class WeeklyRogueSelectTokenView : UiViewBase
{
	// Token: 0x06015EE7 RID: 89831 RVA: 0x0065C0A6 File Offset: 0x0065A2A6
	[NullableContext(1)]
	public WeeklyRogueSelectTokenView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EE8 RID: 89832 RVA: 0x0065C0B0 File Offset: 0x0065A2B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBtnConfirm)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnBtnBack)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnInfo)),
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleDesc))
		};
	}

	// Token: 0x06015EE9 RID: 89833 RVA: 0x0065C1D0 File Offset: 0x0065A3D0
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSelectTokenView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSelectTokenView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EEA RID: 89834 RVA: 0x0065C214 File Offset: 0x0065A414
	protected override void OnBeforeShow()
	{
		EToggleState state = (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(4).SetToggleState(state, false, false, false);
	}

	// Token: 0x06015EEB RID: 89835 RVA: 0x0065C243 File Offset: 0x0065A443
	[NullableContext(1)]
	private WeeklyRogueTokenItem CreateTokenItem()
	{
		return new WeeklyRogueTokenItem
		{
			OnSelectedChange = new Action<int?>(this.OnSelectChange)
		};
	}

	// Token: 0x06015EEC RID: 89836 RVA: 0x0065C25C File Offset: 0x0065A45C
	private void OnSelectChange(int? selectIndex)
	{
		if (selectIndex == null)
		{
			GenericLayout<WeeklyRogueTokenItem, RogueWeeklyEntry> tokenLayout = this.TokenLayout;
			if (tokenLayout != null)
			{
				tokenLayout.DeselectCurrentGridProxy();
			}
			base.GetButton(1).SetSelfInteractive(false);
			return;
		}
		GenericLayout<WeeklyRogueTokenItem, RogueWeeklyEntry> tokenLayout2 = this.TokenLayout;
		if (tokenLayout2 != null)
		{
			tokenLayout2.SelectGridProxy(selectIndex.Value, false);
		}
		base.GetButton(1).SetSelfInteractive(true);
	}

	// Token: 0x06015EED RID: 89837 RVA: 0x0065C2B7 File Offset: 0x0065A4B7
	private void OnBtnConfirm()
	{
		WeeklyRogueController.Instance.SelectOptionRequest(null);
		base.CloseMe(null);
	}

	// Token: 0x06015EEE RID: 89838 RVA: 0x0065C2CB File Offset: 0x0065A4CB
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015EEF RID: 89839 RVA: 0x0065C2D4 File Offset: 0x0065A4D4
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x06015EF0 RID: 89840 RVA: 0x0065C2E7 File Offset: 0x0065A4E7
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x0400B86B RID: 47211
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueTokenItem, RogueWeeklyEntry> TokenLayout;

	// Token: 0x0400B86C RID: 47212
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02008519 RID: 34073
	private enum EWeeklyRogueSelectTokenDefine
	{
		// Token: 0x0402AE72 RID: 175730
		Layout,
		// Token: 0x0402AE73 RID: 175731
		BtnConfirm,
		// Token: 0x0402AE74 RID: 175732
		BtnBack,
		// Token: 0x0402AE75 RID: 175733
		BtnInfo,
		// Token: 0x0402AE76 RID: 175734
		ToggleDesc,
		// Token: 0x0402AE77 RID: 175735
		TxtToggleDesc,
		// Token: 0x0402AE78 RID: 175736
		CaptionItem
	}
}
