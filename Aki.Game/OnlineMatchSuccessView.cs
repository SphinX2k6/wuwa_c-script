using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x020017D5 RID: 6101
public class OnlineMatchSuccessView : UiTickViewBase
{
	// Token: 0x0600EEB4 RID: 61108 RVA: 0x004609E5 File Offset: 0x0045EBE5
	[NullableContext(1)]
	public OnlineMatchSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EEB5 RID: 61109 RVA: 0x00460A08 File Offset: 0x0045EC08
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHandleBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickCancelBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EEB6 RID: 61110 RVA: 0x00460C20 File Offset: 0x0045EE20
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		base.GetButton(8).GetRootComponent().SetUIActive(true);
		this.CountDown = base.GetText(5);
		this.CountDownBar = base.GetSprite(6);
		int value = ConfigCommonParamById.GetIntConfig("match_confirm_time_out_seconds").Value;
		this.CountDownNumber = (float)value;
		this.CountDownNumberMax = value;
		base.GetItem(9).SetUIActive(true);
		base.GetItem(10).SetUIActive(false);
		this.RefreshView();
	}

	// Token: 0x0600EEB7 RID: 61111 RVA: 0x00460CB1 File Offset: 0x0045EEB1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
	}

	// Token: 0x0600EEB8 RID: 61112 RVA: 0x00460CCF File Offset: 0x0045EECF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
	}

	// Token: 0x0600EEB9 RID: 61113 RVA: 0x00460CF0 File Offset: 0x0045EEF0
	protected override void OnTick(float delta)
	{
		if (!this.IsTick)
		{
			return;
		}
		this.CountDownNumber -= delta * (float)TimeUtil.Instance.Millisecond;
		if (this.CountDownNumber <= 0f)
		{
			this.IsTick = false;
			base.CloseMe(null);
			return;
		}
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown((double)this.CountDownNumber), true);
		this.CountDownBar.SetFillAmount(this.CountDownNumber / (float)this.CountDownNumberMax);
	}

	// Token: 0x0600EEBA RID: 61114 RVA: 0x00460D74 File Offset: 0x0045EF74
	private void RefreshView()
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		item.SetUIActive(true);
		item2.SetUIActive(false);
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalText(text, "MatchingSuccess", Array.Empty<object>());
		UUIText text2 = base.GetText(7);
		int matchingId = InstanceDungeonEntranceModel.Instance.GetMatchingId();
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(matchingId).Value.MapName, null);
		text2.SetText(localTextNew, true);
		this.CountDown.SetText(TimeUtil.Instance.GetCoolDown((double)this.CountDownNumber), true);
		this.CountDownBar.SetFillAmount(this.CountDownNumber / (float)this.CountDownNumberMax);
	}

	// Token: 0x0600EEBB RID: 61115 RVA: 0x00460E30 File Offset: 0x0045F030
	private void ShowMatchSuccess()
	{
		base.GetButton(8).GetRootComponent().SetUIActive(false);
		base.GetButton(2).GetRootComponent().SetUIActive(false);
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalText(text, "MatchingTeleport", Array.Empty<object>());
		base.GetText(7).SetUIActive(false);
		this.CountDown.SetUIActive(false);
		this.CountDownBar.SetUIActive(false);
	}

	// Token: 0x0600EEBC RID: 61116 RVA: 0x00460EA4 File Offset: 0x0045F0A4
	private void OnMatchingChange()
	{
		EInstanceMatchState matchingState = InstanceDungeonEntranceModel.Instance.GetMatchingState();
		if (matchingState == EInstanceMatchState.Waiting)
		{
			this.ShowMatchSuccess();
			return;
		}
		if (matchingState == EInstanceMatchState.Matching)
		{
			ScrollingTipsController.Instance.ShowTipsById("MatchingOtherCancel", Array.Empty<object>());
			this.IsTick = false;
			base.CloseMe(null);
			return;
		}
		this.IsTick = false;
		base.CloseMe(null);
	}

	// Token: 0x0600EEBD RID: 61117 RVA: 0x00460EFC File Offset: 0x0045F0FC
	private void OnClickHandleBtn()
	{
		InstanceDungeonEntranceController.Instance.MatchConfirmRequest(true);
		this.IsTick = false;
		this.ShowMatchSuccess();
	}

	// Token: 0x0600EEBE RID: 61118 RVA: 0x00460F16 File Offset: 0x0045F116
	private void OnClickCancelBtn()
	{
		InstanceDungeonEntranceController.Instance.MatchConfirmRequest(false);
		InstanceDungeonModel.Instance.ResetData();
		base.CloseMe(null);
	}

	// Token: 0x0400870B RID: 34571
	private float CountDownNumber = -1f;

	// Token: 0x0400870C RID: 34572
	private int CountDownNumberMax = -1;

	// Token: 0x0400870D RID: 34573
	[Nullable(2)]
	private UUIText CountDown;

	// Token: 0x0400870E RID: 34574
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x0400870F RID: 34575
	private bool IsTick = true;

	// Token: 0x020079F5 RID: 31221
	private enum EOnlineMatchSuccessView
	{
		// Token: 0x0402786F RID: 161903
		RoleTexture,
		// Token: 0x04027870 RID: 161904
		PlayerName,
		// Token: 0x04027871 RID: 161905
		HandleBtn,
		// Token: 0x04027872 RID: 161906
		ApplySprite,
		// Token: 0x04027873 RID: 161907
		MoreSprite,
		// Token: 0x04027874 RID: 161908
		CountDown,
		// Token: 0x04027875 RID: 161909
		CountDownProgressBar,
		// Token: 0x04027876 RID: 161910
		MultipleApplyText,
		// Token: 0x04027877 RID: 161911
		CancelBtn,
		// Token: 0x04027878 RID: 161912
		ApplyItem,
		// Token: 0x04027879 RID: 161913
		RoleTItem,
		// Token: 0x0402787A RID: 161914
		ProgressBarItem
	}
}
