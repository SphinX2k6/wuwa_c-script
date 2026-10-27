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

// Token: 0x020022F1 RID: 8945
public class OnlineMatchSuccessView : UiTickViewBase
{
	// Token: 0x06011A1C RID: 72220 RVA: 0x00453D19 File Offset: 0x00451F19
	[NullableContext(1)]
	public OnlineMatchSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A1D RID: 72221 RVA: 0x00453D3C File Offset: 0x00451F3C
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

	// Token: 0x06011A1E RID: 72222 RVA: 0x00453F54 File Offset: 0x00452154
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

	// Token: 0x06011A1F RID: 72223 RVA: 0x00453FE5 File Offset: 0x004521E5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
	}

	// Token: 0x06011A20 RID: 72224 RVA: 0x00454003 File Offset: 0x00452203
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
	}

	// Token: 0x06011A21 RID: 72225 RVA: 0x00454024 File Offset: 0x00452224
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

	// Token: 0x06011A22 RID: 72226 RVA: 0x004540A8 File Offset: 0x004522A8
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

	// Token: 0x06011A23 RID: 72227 RVA: 0x00454164 File Offset: 0x00452364
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

	// Token: 0x06011A24 RID: 72228 RVA: 0x004541D8 File Offset: 0x004523D8
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

	// Token: 0x06011A25 RID: 72229 RVA: 0x00454230 File Offset: 0x00452430
	private void OnClickHandleBtn()
	{
		InstanceDungeonEntranceController.Instance.MatchConfirmRequest(true);
		this.IsTick = false;
		this.ShowMatchSuccess();
	}

	// Token: 0x06011A26 RID: 72230 RVA: 0x0045424A File Offset: 0x0045244A
	private void OnClickCancelBtn()
	{
		InstanceDungeonEntranceController.Instance.MatchConfirmRequest(false);
		InstanceDungeonModel.Instance.ResetData();
		base.CloseMe(null);
	}

	// Token: 0x040085CD RID: 34253
	private float CountDownNumber = -1f;

	// Token: 0x040085CE RID: 34254
	private int CountDownNumberMax = -1;

	// Token: 0x040085CF RID: 34255
	[Nullable(2)]
	private UUIText CountDown;

	// Token: 0x040085D0 RID: 34256
	[Nullable(2)]
	private UUISprite CountDownBar;

	// Token: 0x040085D1 RID: 34257
	private bool IsTick = true;

	// Token: 0x02008871 RID: 34929
	private enum EOnlineMatchSuccessView
	{
		// Token: 0x0402C56D RID: 181613
		RoleTexture,
		// Token: 0x0402C56E RID: 181614
		PlayerName,
		// Token: 0x0402C56F RID: 181615
		HandleBtn,
		// Token: 0x0402C570 RID: 181616
		ApplySprite,
		// Token: 0x0402C571 RID: 181617
		MoreSprite,
		// Token: 0x0402C572 RID: 181618
		CountDown,
		// Token: 0x0402C573 RID: 181619
		CountDownProgressBar,
		// Token: 0x0402C574 RID: 181620
		MultipleApplyText,
		// Token: 0x0402C575 RID: 181621
		CancelBtn,
		// Token: 0x0402C576 RID: 181622
		ApplyItem,
		// Token: 0x0402C577 RID: 181623
		RoleTItem,
		// Token: 0x0402C578 RID: 181624
		ProgressBarItem
	}
}
