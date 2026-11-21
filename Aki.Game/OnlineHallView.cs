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

// Token: 0x020017D4 RID: 6100
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallView : UiTickViewBase
{
	// Token: 0x0600EE8E RID: 61070 RVA: 0x0045F98F File Offset: 0x0045DB8F
	public OnlineHallView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EE8F RID: 61071 RVA: 0x0045F998 File Offset: 0x0045DB98
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

	// Token: 0x0600EE90 RID: 61072 RVA: 0x0045FCA0 File Offset: 0x0045DEA0
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineHallView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineHallView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EE91 RID: 61073 RVA: 0x0045FCE4 File Offset: 0x0045DEE4
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

	// Token: 0x0600EE92 RID: 61074 RVA: 0x0045FE24 File Offset: 0x0045E024
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

	// Token: 0x0600EE93 RID: 61075 RVA: 0x0045FEBD File Offset: 0x0045E0BD
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(2).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleFriendClicked));
		this.HallLoopScroll = null;
		this.TeamLoopScroll = null;
		this.MatchingCountDown = null;
		this.RemoveRefreshBtnHandle();
	}

	// Token: 0x0600EE94 RID: 61076 RVA: 0x0045FEF8 File Offset: 0x0045E0F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshPermissionsSetting, new Action(this.OnRefreshPermissionsSetting));
		EventSystem.Instance.Add(EEventName.OnRefreshWorldList, new Action(this.OnRefreshWorldList));
		EventSystem.Instance.Add(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshTeamList));
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Add<int>(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x0600EE95 RID: 61077 RVA: 0x0045FFB0 File Offset: 0x0045E1B0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshPermissionsSetting, new Action(this.OnRefreshPermissionsSetting));
		EventSystem.Instance.Remove(EEventName.OnRefreshWorldList, new Action(this.OnRefreshWorldList));
		EventSystem.Instance.Remove(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshTeamList));
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Remove(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x0600EE96 RID: 61078 RVA: 0x00460068 File Offset: 0x0045E268
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

	// Token: 0x0600EE97 RID: 61079 RVA: 0x004600E4 File Offset: 0x0045E2E4
	private UniTask RefreshTeamTitleText()
	{
		OnlineHallView.<RefreshTeamTitleText>d__17 <RefreshTeamTitleText>d__;
		<RefreshTeamTitleText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTeamTitleText>d__.<>4__this = this;
		<RefreshTeamTitleText>d__.<>1__state = -1;
		<RefreshTeamTitleText>d__.<>t__builder.Start<OnlineHallView.<RefreshTeamTitleText>d__17>(ref <RefreshTeamTitleText>d__);
		return <RefreshTeamTitleText>d__.<>t__builder.Task;
	}

	// Token: 0x0600EE98 RID: 61080 RVA: 0x00460128 File Offset: 0x0045E328
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

	// Token: 0x0600EE99 RID: 61081 RVA: 0x004601A4 File Offset: 0x0045E3A4
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

	// Token: 0x0600EE9A RID: 61082 RVA: 0x004601E7 File Offset: 0x0045E3E7
	private void RefreshHallList([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<OnlineHallData> data)
	{
		this.OnRefreshHallList(data).Forget();
	}

	// Token: 0x0600EE9B RID: 61083 RVA: 0x004601F8 File Offset: 0x0045E3F8
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

	// Token: 0x0600EE9C RID: 61084 RVA: 0x00460244 File Offset: 0x0045E444
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

	// Token: 0x0600EE9D RID: 61085 RVA: 0x00460288 File Offset: 0x0045E488
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

	// Token: 0x0600EE9E RID: 61086 RVA: 0x004602D3 File Offset: 0x0045E4D3
	private void RefreshTeamList(IReadOnlyList<OnlineTeamData> data)
	{
		this.FilterHallDataAndRefresh(data).Forget();
	}

	// Token: 0x0600EE9F RID: 61087 RVA: 0x004602E1 File Offset: 0x0045E4E1
	private void RefreshFilterText()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), OnlineModel.Instance.HallViewIsShowSearching ? "Online_ResetSearch" : "Online_Search", Array.Empty<object>());
	}

	// Token: 0x0600EEA0 RID: 61088 RVA: 0x00460312 File Offset: 0x0045E512
	private OnlineHallItem ProxyCreateHallItemFunction()
	{
		return new OnlineHallItem(this.ViewInfo.Name);
	}

	// Token: 0x0600EEA1 RID: 61089 RVA: 0x00460324 File Offset: 0x0045E524
	private OnlineTeamItem ProxyCreateTeamItemFunction()
	{
		return new OnlineTeamItem();
	}

	// Token: 0x0600EEA2 RID: 61090 RVA: 0x0046032C File Offset: 0x0045E52C
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

	// Token: 0x0600EEA3 RID: 61091 RVA: 0x004603D5 File Offset: 0x0045E5D5
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600EEA4 RID: 61092 RVA: 0x004603DE File Offset: 0x0045E5DE
	private void OnClickPermissionBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.OnlineSettingView, null, null);
	}

	// Token: 0x0600EEA5 RID: 61093 RVA: 0x004603F4 File Offset: 0x0045E5F4
	private void OnRefreshPermissionsSetting()
	{
		UUIText text = base.GetText(7);
		string textTableId = "PermissionsSetting_" + ((int)OnlineModel.Instance.CurrentPermissionsSetting).ToString();
		LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
		KuroSdkController.Instance.RefreshOnlineHallActivity();
	}

	// Token: 0x0600EEA6 RID: 61094 RVA: 0x00460441 File Offset: 0x0045E641
	private void OnRefreshWorldList()
	{
		if (base.GetExtendToggle(2).ToggleState == EToggleState.ETT_Checked)
		{
			this.RefreshHallList(OnlineModel.Instance.FriendWorld);
			return;
		}
		this.RefreshHallList(OnlineModel.Instance.StrangerWorld);
	}

	// Token: 0x0600EEA7 RID: 61095 RVA: 0x00460473 File Offset: 0x0045E673
	private void OnRefreshTeamList()
	{
		this.RefreshTeamList(OnlineModel.Instance.GetTeamList());
		this.InitTitle();
	}

	// Token: 0x0600EEA8 RID: 61096 RVA: 0x0046048C File Offset: 0x0045E68C
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

	// Token: 0x0600EEA9 RID: 61097 RVA: 0x00460560 File Offset: 0x0045E760
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

	// Token: 0x0600EEAA RID: 61098 RVA: 0x004605C4 File Offset: 0x0045E7C4
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

	// Token: 0x0600EEAB RID: 61099 RVA: 0x00460614 File Offset: 0x0045E814
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

	// Token: 0x0600EEAC RID: 61100 RVA: 0x004606D8 File Offset: 0x0045E8D8
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

	// Token: 0x0600EEAD RID: 61101 RVA: 0x004607A0 File Offset: 0x0045E9A0
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

	// Token: 0x0600EEAE RID: 61102 RVA: 0x0046086D File Offset: 0x0045EA6D
	private void RemoveRefreshBtnHandle()
	{
		if (this.RefreshBtnHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshBtnHandle);
		}
		this.RefreshBtnHandle = null;
	}

	// Token: 0x0600EEAF RID: 61103 RVA: 0x00460890 File Offset: 0x0045EA90
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

	// Token: 0x04008704 RID: 34564
	private const int REFERSH_BTN_CD = 5;

	// Token: 0x04008705 RID: 34565
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineHallItem, OnlineHallData> HallLoopScroll;

	// Token: 0x04008706 RID: 34566
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineTeamItem, OnlineTeamData> TeamLoopScroll;

	// Token: 0x04008707 RID: 34567
	[Nullable(2)]
	private InstanceDungeonMatchingCountDown MatchingCountDown;

	// Token: 0x04008708 RID: 34568
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x04008709 RID: 34569
	private int NextCanClickRefreshBtnLeftTime;

	// Token: 0x0400870A RID: 34570
	[Nullable(2)]
	private TimerHandle RefreshBtnHandle;

	// Token: 0x020079EB RID: 31211
	[NullableContext(0)]
	private enum EOnlineHallViewComponents
	{
		// Token: 0x04027838 RID: 161848
		BackBtn,
		// Token: 0x04027839 RID: 161849
		PermissionsSettingBtn,
		// Token: 0x0402783A RID: 161850
		TogFriend,
		// Token: 0x0402783B RID: 161851
		FilterBtn,
		// Token: 0x0402783C RID: 161852
		OnlineWorldList,
		// Token: 0x0402783D RID: 161853
		OnlineWorldListItem,
		// Token: 0x0402783E RID: 161854
		EmptyTips,
		// Token: 0x0402783F RID: 161855
		SettingText,
		// Token: 0x04027840 RID: 161856
		HallTopItem,
		// Token: 0x04027841 RID: 161857
		TeamTopItem,
		// Token: 0x04027842 RID: 161858
		TeamPlayerNumberText,
		// Token: 0x04027843 RID: 161859
		MatchingItem,
		// Token: 0x04027844 RID: 161860
		SearchUIDTextInput,
		// Token: 0x04027845 RID: 161861
		UIDClearOrPasteBtn,
		// Token: 0x04027846 RID: 161862
		FilterText,
		// Token: 0x04027847 RID: 161863
		RefreshBtn,
		// Token: 0x04027848 RID: 161864
		RefreshBtnText
	}
}
