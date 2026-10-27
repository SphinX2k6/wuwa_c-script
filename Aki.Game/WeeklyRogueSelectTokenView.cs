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

// Token: 0x02002D57 RID: 11607
public class WeeklyRogueSelectTokenView : UiViewBase
{
	// Token: 0x06018645 RID: 99909 RVA: 0x00636096 File Offset: 0x00634296
	[NullableContext(1)]
	public WeeklyRogueSelectTokenView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06018646 RID: 99910 RVA: 0x006360A0 File Offset: 0x006342A0
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

	// Token: 0x06018647 RID: 99911 RVA: 0x006361C0 File Offset: 0x006343C0
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueSelectTokenView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueSelectTokenView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018648 RID: 99912 RVA: 0x00636204 File Offset: 0x00634404
	protected override void OnBeforeShow()
	{
		EToggleState state = (WeeklyRogueModel.Instance.DescMode == EDescModel.SIMPLE) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(4).SetToggleState(state, false, false, false);
	}

	// Token: 0x06018649 RID: 99913 RVA: 0x00636233 File Offset: 0x00634433
	[NullableContext(1)]
	private WeeklyRogueTokenItem CreateTokenItem()
	{
		return new WeeklyRogueTokenItem
		{
			OnSelectedChange = new Action<int?>(this.OnSelectChange)
		};
	}

	// Token: 0x0601864A RID: 99914 RVA: 0x0063624C File Offset: 0x0063444C
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

	// Token: 0x0601864B RID: 99915 RVA: 0x006362A7 File Offset: 0x006344A7
	private void OnBtnConfirm()
	{
		WeeklyRogueController.Instance.SelectOptionRequest(null);
		base.CloseMe(null);
	}

	// Token: 0x0601864C RID: 99916 RVA: 0x006362BB File Offset: 0x006344BB
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601864D RID: 99917 RVA: 0x006362C4 File Offset: 0x006344C4
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x0601864E RID: 99918 RVA: 0x006362D7 File Offset: 0x006344D7
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x0400B4F6 RID: 46326
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyRogueTokenItem, RogueWeeklyEntry> TokenLayout;

	// Token: 0x0400B4F7 RID: 46327
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x020092F2 RID: 37618
	private enum EWeeklyRogueSelectTokenDefine
	{
		// Token: 0x0402F7EA RID: 194538
		Layout,
		// Token: 0x0402F7EB RID: 194539
		BtnConfirm,
		// Token: 0x0402F7EC RID: 194540
		BtnBack,
		// Token: 0x0402F7ED RID: 194541
		BtnInfo,
		// Token: 0x0402F7EE RID: 194542
		ToggleDesc,
		// Token: 0x0402F7EF RID: 194543
		TxtToggleDesc,
		// Token: 0x0402F7F0 RID: 194544
		CaptionItem
	}
}
