using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022F0 RID: 8944
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallView : UiTickViewBase
{
	// Token: 0x060119F6 RID: 72182 RVA: 0x00452CC3 File Offset: 0x00450EC3
	public OnlineHallView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060119F7 RID: 72183 RVA: 0x00452CCC File Offset: 0x00450ECC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickPermissionBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSearchConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickRefreshBtnBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060119F8 RID: 72184 RVA: 0x00452FD4 File Offset: 0x004511D4
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineHallView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineHallView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060119F9 RID: 72185 RVA: 0x00453018 File Offset: 0x00451218
	protected override void OnStart()
	{
		this.InitTitle();
		if (OnlineModel.Instance.GetIsTeamModel())
		{
			base.GetButton(15).RootUIComp.Get().SetUIActive(false);
			this.RefreshTeamList(OnlineModel.Instance.GetTeamList());
		}
		else
		{
			this.RefreshHallList(OnlineModel.Instance.StrangerWorld);
		}
		OnlineModel.Instance.SetHallShowCanJoin(false);
		OnlineModel.Instance.SetHallShowFriend(false);
		OnlineModel.Instance.HallViewIsShowSearching = false;
		this.OnRefreshPermissionsSetting();
		FriendModel.Instance.ShowingView = new EUiViewName?(this.ViewInfo.Name);
		bool flag = !Info.Instance.IsHomeConsolePlatform();
		if (flag)
		{
			this.FunctionButtonItem = new ButtonAndSpriteItem(base.GetItem(13));
			this.FunctionButtonItem.BindCallback(new Action(this.OnClickClearSearchInputBtn));
		}
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		base.GetInputText(12).OnTextChange.Bind(new Action<string>(this.SetClearOrPaste));
		this.SetClearOrPaste(null);
		this.RefreshFilterText();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "OnlineHallViewRefreshBtnNormal", Array.Empty<object>());
		KuroSdkController.Instance.RefreshOnlineHallActivity();
	}

	// Token: 0x060119FA RID: 72186 RVA: 0x00453158 File Offset: 0x00451358
	protected override void OnAfterShow()
	{
		this.MatchingCountDown.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
		this.MatchingCountDown.BindOnClickBtnCancelMatching(delegate
		{
			InstanceDungeonMatchingCountDown matchingCountDown3 = this.MatchingCountDown;
			if (matchingCountDown3 != null)
			{
				matchingCountDown3.PlayAnimation("Close");
			}
			InstanceDungeonEntranceController.Instance.CancelMatchRequest();
		});
		InstanceDungeonMatchingCountDown matchingCountDown = this.MatchingCountDown;
		if (matchingCountDown != null)
		{
			matchingCountDown.BindOnAfterCloseAnimation(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					InstanceDungeonMatchingCountDown matchingCountDown3 = this.MatchingCountDown;
					if (matchingCountDown3 == null)
					{
						return;
					}
					matchingCountDown3.SetUiActive(false);
				}
			});
		}
		if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
		{
			InstanceDungeonMatchingCountDown matchingCountDown2 = this.MatchingCountDown;
			if (matchingCountDown2 != null)
			{
				matchingCountDown2.PlayAnimation("Start");
			}
			this.MatchingCountDown.StartTimer();
		}
	}

	// Token: 0x060119FB RID: 72187 RVA: 0x004531F1 File Offset: 0x004513F1
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(2).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleFriendClicked));
		this.HallLoopScroll = null;
		this.TeamLoopScroll = null;
		this.MatchingCountDown = null;
		this.RemoveRefreshBtnHandle();
	}

	// Token: 0x060119FC RID: 72188 RVA: 0x0045322C File Offset: 0x0045142C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshPermissionsSetting, new Action(this.OnRefreshPermissionsSetting));
		EventSystem.Instance.Add(EEventName.OnRefreshWorldList, new Action(this.OnRefreshWorldList));
		EventSystem.Instance.Add(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshTeamList));
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Add<int>(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x060119FD RID: 72189 RVA: 0x004532E4 File Offset: 0x004514E4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshPermissionsSetting, new Action(this.OnRefreshPermissionsSetting));
		EventSystem.Instance.Remove(EEventName.OnRefreshWorldList, new Action(this.OnRefreshWorldList));
		EventSystem.Instance.Remove(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshTeamList));
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Remove(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x060119FE RID: 72190 RVA: 0x0045339C File Offset: 0x0045159C
	private void InitTitle()
	{
		if (!OnlineModel.Instance.GetIsTeamModel())
		{
			base.GetExtendToggle(2).OnStateChange.Add(new Action<EToggleState>(this.OnToggleFriendClicked));
			return;
		}
		base.GetItem(8).SetUIActive(false);
		this.RefreshTeamTitleText().Forget();
		bool isMyTeam = OnlineModel.Instance.GetIsMyTeam();
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(isMyTeam);
	}

	// Token: 0x060119FF RID: 72191 RVA: 0x00453418 File Offset: 0x00451618
	private UniTask RefreshTeamTitleText()
	{
		OnlineHallView.<RefreshTeamTitleText>d__17 <RefreshTeamTitleText>d__;
		<RefreshTeamTitleText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTeamTitleText>d__.<>4__this = this;
		<RefreshTeamTitleText>d__.<>1__state = -1;
		<RefreshTeamTitleText>d__.<>t__builder.Start<OnlineHallView.<RefreshTeamTitleText>d__17>(ref <RefreshTeamTitleText>d__);
		return <RefreshTeamTitleText>d__.<>t__builder.Task;
	}

	// Token: 0x06011A00 RID: 72192 RVA: 0x0045345C File Offset: 0x0045165C
	private void InitWorldList()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(4);
		if (!OnlineModel.Instance.GetIsTeamModel())
		{
			AUIBaseActor gridActor = base.GetItem(5).GetOwner() as AUIBaseActor;
			this.HallLoopScroll = new LoopScrollView<OnlineHallItem, OnlineHallData>(loopScrollViewComponent, gridActor, new Func<OnlineHallItem>(this.ProxyCreateHallItemFunction), true);
			return;
		}
		AUIBaseActor gridActor2 = base.GetItem(5).GetOwner() as AUIBaseActor;
		this.TeamLoopScroll = new LoopScrollView<OnlineTeamItem, OnlineTeamData>(loopScrollViewComponent, gridActor2, new Func<OnlineTeamItem>(this.ProxyCreateTeamItemFunction), true);
	}

	// Token: 0x06011A01 RID: 72193 RVA: 0x004534D8 File Offset: 0x004516D8
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private UniTask<List<OnlineHallData>> GetFinalHallData([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<OnlineHallData> data)
	{
		OnlineHallView.<GetFinalHallData>d__19 <GetFinalHallData>d__;
		<GetFinalHallData>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<OnlineHallData>>.Create();
		<GetFinalHallData>d__.data = data;
		<GetFinalHallData>d__.<>1__state = -1;
		<GetFinalHallData>d__.<>t__builder.Start<OnlineHallView.<GetFinalHallData>d__19>(ref <GetFinalHallData>d__);
		return <GetFinalHallData>d__.<>t__builder.Task;
	}

	// Token: 0x06011A02 RID: 72194 RVA: 0x0045351B File Offset: 0x0045171B
	private void RefreshHallList([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<OnlineHallData> data)
	{
		this.OnRefreshHallList(data).Forget();
	}

	// Token: 0x06011A03 RID: 72195 RVA: 0x0045352C File Offset: 0x0045172C
	private UniTask OnRefreshHallList([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<OnlineHallData> data)
	{
		OnlineHallView.<OnRefreshHallList>d__21 <OnRefreshHallList>d__;
		<OnRefreshHallList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnRefreshHallList>d__.<>4__this = this;
		<OnRefreshHallList>d__.data = data;
		<OnRefreshHallList>d__.<>1__state = -1;
		<OnRefreshHallList>d__.<>t__builder.Start<OnlineHallView.<OnRefreshHallList>d__21>(ref <OnRefreshHallList>d__);
		return <OnRefreshHallList>d__.<>t__builder.Task;
	}

	// Token: 0x06011A04 RID: 72196 RVA: 0x00453578 File Offset: 0x00451778
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private UniTask<List<OnlineTeamData>> GetFinalTeamData(IReadOnlyList<OnlineTeamData> data)
	{
		OnlineHallView.<GetFinalTeamData>d__22 <GetFinalTeamData>d__;
		<GetFinalTeamData>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<OnlineTeamData>>.Create();
		<GetFinalTeamData>d__.data = data;
		<GetFinalTeamData>d__.<>1__state = -1;
		<GetFinalTeamData>d__.<>t__builder.Start<OnlineHallView.<GetFinalTeamData>d__22>(ref <GetFinalTeamData>d__);
		return <GetFinalTeamData>d__.<>t__builder.Task;
	}

	// Token: 0x06011A05 RID: 72197 RVA: 0x004535BC File Offset: 0x004517BC
	private UniTask FilterHallDataAndRefresh(IReadOnlyList<OnlineTeamData> data)
	{
		OnlineHallView.<FilterHallDataAndRefresh>d__23 <FilterHallDataAndRefresh>d__;
		<FilterHallDataAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FilterHallDataAndRefresh>d__.<>4__this = this;
		<FilterHallDataAndRefresh>d__.data = data;
		<FilterHallDataAndRefresh>d__.<>1__state = -1;
		<FilterHallDataAndRefresh>d__.<>t__builder.Start<OnlineHallView.<FilterHallDataAndRefresh>d__23>(ref <FilterHallDataAndRefresh>d__);
		return <FilterHallDataAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06011A06 RID: 72198 RVA: 0x00453607 File Offset: 0x00451807
	private void RefreshTeamList(IReadOnlyList<OnlineTeamData> data)
	{
		this.FilterHallDataAndRefresh(data).Forget();
	}

	// Token: 0x06011A07 RID: 72199 RVA: 0x00453615 File Offset: 0x00451815
	private void RefreshFilterText()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), OnlineModel.Instance.HallViewIsShowSearching ? "Online_ResetSearch" : "Online_Search", Array.Empty<object>());
	}

	// Token: 0x06011A08 RID: 72200 RVA: 0x00453646 File Offset: 0x00451846
	private OnlineHallItem ProxyCreateHallItemFunction()
	{
		return new OnlineHallItem(this.ViewInfo.Name);
	}

	// Token: 0x06011A09 RID: 72201 RVA: 0x00453658 File Offset: 0x00451858
	private OnlineTeamItem ProxyCreateTeamItemFunction()
	{
		return new OnlineTeamItem();
	}

	// Token: 0x06011A0A RID: 72202 RVA: 0x00453660 File Offset: 0x00451860
	private void OnToggleFriendClicked(EToggleState state)
	{
		OnlineModel.Instance.HallViewIsShowSearching = false;
		base.GetInputText(12).SetText("", false);
		this.SetClearOrPaste(null);
		this.RefreshFilterText();
		if (state == EToggleState.ETT_Checked)
		{
			OnlineModel.Instance.SetHallShowFriend(true);
			IReadOnlyList<OnlineHallData> data;
			if (!OnlineModel.Instance.ShowCanJoin)
			{
				data = OnlineModel.Instance.FriendWorld;
			}
			else
			{
				IReadOnlyList<OnlineHallData> readOnlyList = OnlineModel.Instance.GetCanJoinFormFriend();
				data = readOnlyList;
			}
			this.RefreshHallList(data);
		}
		if (state == EToggleState.ETT_UnChecked)
		{
			OnlineModel.Instance.SetHallShowFriend(false);
			IReadOnlyList<OnlineHallData> data2;
			if (!OnlineModel.Instance.ShowCanJoin)
			{
				data2 = OnlineModel.Instance.StrangerWorld;
			}
			else
			{
				IReadOnlyList<OnlineHallData> readOnlyList = OnlineModel.Instance.GetCanJoinFormStranger();
				data2 = readOnlyList;
			}
			this.RefreshHallList(data2);
		}
	}

	// Token: 0x06011A0B RID: 72203 RVA: 0x00453709 File Offset: 0x00451909
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011A0C RID: 72204 RVA: 0x00453712 File Offset: 0x00451912
	private void OnClickPermissionBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.OnlineSettingView, null, null);
	}

	// Token: 0x06011A0D RID: 72205 RVA: 0x00453728 File Offset: 0x00451928
	private void OnRefreshPermissionsSetting()
	{
		UUIText text = base.GetText(7);
		string textTableId = "PermissionsSetting_" + ((int)OnlineModel.Instance.CurrentPermissionsSetting).ToString();
		LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
		KuroSdkController.Instance.RefreshOnlineHallActivity();
	}

	// Token: 0x06011A0E RID: 72206 RVA: 0x00453775 File Offset: 0x00451975
	private void OnRefreshWorldList()
	{
		if (base.GetExtendToggle(2).ToggleState == EToggleState.ETT_Checked)
		{
			this.RefreshHallList(OnlineModel.Instance.FriendWorld);
			return;
		}
		this.RefreshHallList(OnlineModel.Instance.StrangerWorld);
	}

	// Token: 0x06011A0F RID: 72207 RVA: 0x004537A7 File Offset: 0x004519A7
	private void OnRefreshTeamList()
	{
		this.RefreshTeamList(OnlineModel.Instance.GetTeamList());
		this.InitTitle();
	}

	// Token: 0x06011A10 RID: 72208 RVA: 0x004537C0 File Offset: 0x004519C0
	private void OnMatchingChange()
	{
		EInstanceMatchState matchingState = InstanceDungeonEntranceModel.Instance.GetMatchingState();
		if (matchingState == EInstanceMatchState.Default)
		{
			InstanceDungeonMatchingCountDown matchingCountDown = this.MatchingCountDown;
			if (matchingCountDown != null && matchingCountDown.GetActive())
			{
				InstanceDungeonMatchingCountDown matchingCountDown2 = this.MatchingCountDown;
				if (matchingCountDown2 == null)
				{
					return;
				}
				matchingCountDown2.PlayAnimation("Close");
				return;
			}
		}
		else if (matchingState == EInstanceMatchState.MatchConfirm)
		{
			InstanceDungeonMatchingCountDown matchingCountDown3 = this.MatchingCountDown;
			if (matchingCountDown3 != null && matchingCountDown3.GetActive())
			{
				InstanceDungeonMatchingCountDown matchingCountDown4 = this.MatchingCountDown;
				if (matchingCountDown4 == null)
				{
					return;
				}
				matchingCountDown4.PlayAnimation("Close");
				return;
			}
		}
		else if (matchingState == EInstanceMatchState.Matching)
		{
			InstanceDungeonMatchingCountDown matchingCountDown5 = this.MatchingCountDown;
			if (matchingCountDown5 != null)
			{
				matchingCountDown5.PlayAnimation("Start");
			}
			this.MatchingCountDown.SetMatchingTime(0);
			this.MatchingCountDown.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
			this.MatchingCountDown.StartTimer();
		}
	}

	// Token: 0x06011A11 RID: 72209 RVA: 0x00453894 File Offset: 0x00451A94
	private void OnMatchingBegin()
	{
		InstanceDungeonMatchingCountDown matchingCountDown = this.MatchingCountDown;
		if (matchingCountDown != null)
		{
			matchingCountDown.PlayAnimation("Start");
		}
		this.MatchingCountDown.SetMatchingTime(0);
		this.MatchingCountDown.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
		this.MatchingCountDown.StartTimer();
	}

	// Token: 0x06011A12 RID: 72210 RVA: 0x004538F8 File Offset: 0x00451AF8
	[NullableContext(2)]
	private void SetClearOrPaste(string _)
	{
		if (this.FunctionButtonItem == null)
		{
			return;
		}
		if (base.GetInputText(12).GetText() == "")
		{
			this.FunctionButtonItem.RefreshSprite("SP_Paste");
			return;
		}
		this.FunctionButtonItem.RefreshSprite("SP_Clear");
	}

	// Token: 0x06011A13 RID: 72211 RVA: 0x00453948 File Offset: 0x00451B48
	private void OnClickClearSearchInputBtn()
	{
		UUITextInputComponent inputText = base.GetInputText(12);
		if (inputText.GetText() == "")
		{
			if (Platform.Instance.IsCloudGame())
			{
				string pasteTarget = "";
				string pasteTargetRef = string.Empty;
				UKuroCloudGameWrapper.ClipBoardPaste();
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					ULGUIBPLibrary.ClipBoardPaste(ref pasteTargetRef);
					pasteTarget = pasteTargetRef;
					inputText.SetText(pasteTarget, false);
				}, 200f, null, null, true, 1f);
			}
			else
			{
				string empty = string.Empty;
				ULGUIBPLibrary.ClipBoardPaste(ref empty);
				string inText = empty;
				inputText.SetText(inText, false);
			}
		}
		else
		{
			inputText.SetText("", false);
		}
		this.SetClearOrPaste(null);
	}

	// Token: 0x06011A14 RID: 72212 RVA: 0x00453A0C File Offset: 0x00451C0C
	private void OnClickSearchConfirmBtn()
	{
		if (OnlineModel.Instance.HallViewIsShowSearching)
		{
			OnlineModel.Instance.HallViewIsShowSearching = false;
			base.GetButton(15).RootUIComp.Get().SetUIActive(true);
			base.GetInputText(12).SetText("", false);
			this.SetClearOrPaste(null);
			this.RefreshFilterText();
			this.RefreshHallList((base.GetExtendToggle(2).ToggleState == EToggleState.ETT_Checked) ? OnlineModel.Instance.FriendWorld : OnlineModel.Instance.StrangerWorld);
			return;
		}
		string text = base.GetInputText(12).GetText();
		if (text.Length > 0)
		{
			OnlineController.Instance.LobbyQueryPlayersRequest(int.Parse(text));
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("OnlineUserIdIsNull", Array.Empty<object>());
	}

	// Token: 0x06011A15 RID: 72213 RVA: 0x00453AD4 File Offset: 0x00451CD4
	private void OnClickRefreshBtnBtn()
	{
		if (this.NextCanClickRefreshBtnLeftTime > 0)
		{
			return;
		}
		this.NextCanClickRefreshBtnLeftTime = 5;
		UUIButtonComponent refreshBtn = base.GetButton(15);
		refreshBtn.SetSelfInteractive(false);
		this.RemoveRefreshBtnHandle();
		UUIText text = base.GetText(16);
		LguiUtil.Instance.SetLocalTextNew(text, "OnlineHallViewRefreshBtnCd", new <>z__ReadOnlySingleElementList<object>(this.NextCanClickRefreshBtnLeftTime.ToString()));
		this.RefreshBtnHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.NextCanClickRefreshBtnLeftTime--;
			if (this.NextCanClickRefreshBtnLeftTime <= 0)
			{
				refreshBtn.SetSelfInteractive(true);
				this.RemoveRefreshBtnHandle();
				LguiUtil.Instance.SetLocalTextNew(text, "OnlineHallViewRefreshBtnNormal", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "OnlineHallViewRefreshBtnCd", new <>z__ReadOnlySingleElementList<object>(this.NextCanClickRefreshBtnLeftTime.ToString()));
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		OnlineController.Instance.RefreshWorldList().ContinueWith(delegate(bool isSuccess)
		{
			if (!isSuccess)
			{
				LoopScrollView<OnlineHallItem, OnlineHallData> hallLoopScroll = this.HallLoopScroll;
				if (hallLoopScroll == null)
				{
					return;
				}
				UUIInturnAnimController uiAnimController = hallLoopScroll.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.Play("Start", -1, false);
			}
		}).Forget();
	}

	// Token: 0x06011A16 RID: 72214 RVA: 0x00453BA1 File Offset: 0x00451DA1
	private void RemoveRefreshBtnHandle()
	{
		if (this.RefreshBtnHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshBtnHandle);
		}
		this.RefreshBtnHandle = null;
	}

	// Token: 0x06011A17 RID: 72215 RVA: 0x00453BC4 File Offset: 0x00451DC4
	private void CallBackSearchWorld(int i)
	{
		base.GetButton(15).RootUIComp.Get().SetUIActive(false);
		IReadOnlyList<OnlineHallData> searchResult = OnlineModel.Instance.SearchResult;
		if (searchResult != null)
		{
			this.RefreshHallList(searchResult);
			OnlineModel.Instance.HallViewIsShowSearching = true;
		}
		this.RefreshFilterText();
	}

	// Token: 0x040085C6 RID: 34246
	private const int REFERSH_BTN_CD = 5;

	// Token: 0x040085C7 RID: 34247
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineHallItem, OnlineHallData> HallLoopScroll;

	// Token: 0x040085C8 RID: 34248
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineTeamItem, OnlineTeamData> TeamLoopScroll;

	// Token: 0x040085C9 RID: 34249
	[Nullable(2)]
	private InstanceDungeonMatchingCountDown MatchingCountDown;

	// Token: 0x040085CA RID: 34250
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x040085CB RID: 34251
	private int NextCanClickRefreshBtnLeftTime;

	// Token: 0x040085CC RID: 34252
	[Nullable(2)]
	private TimerHandle RefreshBtnHandle;

	// Token: 0x02008867 RID: 34919
	[NullableContext(0)]
	private enum EOnlineHallViewComponents
	{
		// Token: 0x0402C536 RID: 181558
		BackBtn,
		// Token: 0x0402C537 RID: 181559
		PermissionsSettingBtn,
		// Token: 0x0402C538 RID: 181560
		TogFriend,
		// Token: 0x0402C539 RID: 181561
		FilterBtn,
		// Token: 0x0402C53A RID: 181562
		OnlineWorldList,
		// Token: 0x0402C53B RID: 181563
		OnlineWorldListItem,
		// Token: 0x0402C53C RID: 181564
		EmptyTips,
		// Token: 0x0402C53D RID: 181565
		SettingText,
		// Token: 0x0402C53E RID: 181566
		HallTopItem,
		// Token: 0x0402C53F RID: 181567
		TeamTopItem,
		// Token: 0x0402C540 RID: 181568
		TeamPlayerNumberText,
		// Token: 0x0402C541 RID: 181569
		MatchingItem,
		// Token: 0x0402C542 RID: 181570
		SearchUIDTextInput,
		// Token: 0x0402C543 RID: 181571
		UIDClearOrPasteBtn,
		// Token: 0x0402C544 RID: 181572
		FilterText,
		// Token: 0x0402C545 RID: 181573
		RefreshBtn,
		// Token: 0x0402C546 RID: 181574
		RefreshBtnText
	}
}
