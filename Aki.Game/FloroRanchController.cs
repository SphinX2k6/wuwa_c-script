using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000FEA RID: 4074
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FloroRanchController : ActivityControllerBase
{
	// Token: 0x0600A279 RID: 41593 RVA: 0x002FB6E2 File Offset: 0x002F98E2
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600A27A RID: 41594 RVA: 0x002FB6E9 File Offset: 0x002F98E9
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPastureGuide";
	}

	// Token: 0x0600A27B RID: 41595 RVA: 0x002FB6F0 File Offset: 0x002F98F0
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FloroRanchActivityView();
	}

	// Token: 0x0600A27C RID: 41596 RVA: 0x002FB6F8 File Offset: 0x002F98F8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		global::FloroRanchActivityData floroRanchActivityData = new global::FloroRanchActivityData();
		EFloroRanchActivityDataType activityDataType = FloroRanchModel.Instance.GetActivityDataType(data.Id);
		FloroRanchModel.Instance.SetActivityData(activityDataType, floroRanchActivityData);
		return floroRanchActivityData;
	}

	// Token: 0x0600A27D RID: 41597 RVA: 0x002FB729 File Offset: 0x002F9929
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600A27E RID: 41598 RVA: 0x002FB72C File Offset: 0x002F992C
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchUnlockTipView, null, null);
	}

	// Token: 0x0600A27F RID: 41599 RVA: 0x002FB740 File Offset: 0x002F9940
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.FloroRanchUpdatePlayerInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchUpdatePlayerInfoNotify));
		Net.Instance.Register(ENotifyMessageId.FloroRanchPlayGmInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchPlayGmInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.FloroRanchPlayWeeklyEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchPlayWeeklyEndNotify));
	}

	// Token: 0x0600A280 RID: 41600 RVA: 0x002FB7A1 File Offset: 0x002F99A1
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchUpdatePlayerInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchPlayGmInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchPlayWeeklyEndNotify);
	}

	// Token: 0x0600A281 RID: 41601 RVA: 0x002FB7D3 File Offset: 0x002F99D3
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600A282 RID: 41602 RVA: 0x002FB7F1 File Offset: 0x002F99F1
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600A283 RID: 41603 RVA: 0x002FB810 File Offset: 0x002F9A10
	[NullableContext(2)]
	private void OnFloroRanchUpdatePlayerInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		FloroRanchUpdatePlayerInfoNotify floroRanchUpdatePlayerInfoNotify = (FloroRanchUpdatePlayerInfoNotify)msg;
		EFloroRanchActivityDataType activityDataType = FloroRanchModel.Instance.GetActivityDataType(floroRanchUpdatePlayerInfoNotify.ActivityId);
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(activityDataType, true);
		if (activityData == null)
		{
			return;
		}
		switch (floroRanchUpdatePlayerInfoNotify.FloroCfgType)
		{
		case FloroConfigType.FloroCard:
			activityData.UpdateFloroRanchCardData(floroRanchUpdatePlayerInfoNotify.UnlockCard);
			return;
		case FloroConfigType.FloroRace:
			activityData.UpdateFloroRanchRaceData(floroRanchUpdatePlayerInfoNotify.RaceUnLockInfo);
			return;
		case FloroConfigType.FloroTask:
			activityData.UpdateFloroRanchTaskData(floroRanchUpdatePlayerInfoNotify.ConditionTask, true);
			return;
		case FloroConfigType.FloroSkill:
			activityData.UpdateFloroRanchSkillData(floroRanchUpdatePlayerInfoNotify.UnlockSkill);
			return;
		case FloroConfigType.FloroToy:
			activityData.UpdateFloroRanchToyData(floroRanchUpdatePlayerInfoNotify.UnlockToy);
			return;
		case FloroConfigType.FloroIns:
			activityData.UpdateFloroRanchDungeonUnLock(floroRanchUpdatePlayerInfoNotify.InsLockInfo);
			return;
		case FloroConfigType.FloroSubIns:
			activityData.UpdateFloroRanchSubDungeon(floroRanchUpdatePlayerInfoNotify.FloroSubInsInfo, true);
			return;
		case FloroConfigType.SubInsHistory:
			activityData.UpdateFloroRanchSubDungeonHistoryData(floroRanchUpdatePlayerInfoNotify.SubInfHistory);
			EventSystem.Instance.Emit(EEventName.FloroRanchSubInsHistoryUpdate);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600A284 RID: 41604 RVA: 0x002FB8F0 File Offset: 0x002F9AF0
	[NullableContext(2)]
	public unsafe void SendFloroRanchStartPlayRequest(int activityId, int subInstanceId, int[] races = null, int? skillId = null, Action<FloroRanchStartPlayResponse> callback = null)
	{
		FloroRanchStartPlayRequest floroRanchStartPlayRequest = FloroRanchStartPlayRequest.Create();
		floroRanchStartPlayRequest.ActivityId = activityId;
		floroRanchStartPlayRequest.SubInsId = subInstanceId;
		if (races != null && skillId != null)
		{
			floroRanchStartPlayRequest.Races.AddRange(races);
			floroRanchStartPlayRequest.SkillId = skillId.Value;
		}
		Net.Instance.Call(ERequestMessageId.FloroRanchStartPlayRequest, floroRanchStartPlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchStartPlayResponse floroRanchStartPlayResponse = (FloroRanchStartPlayResponse)msg;
			if (floroRanchStartPlayResponse == null)
			{
				Action<FloroRanchStartPlayResponse> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(null);
				return;
			}
			else
			{
				if (floroRanchStartPlayResponse.ErrorCode == ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.FloroRanchGamePlay;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "弗洛洛牧场 游戏开始";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SubInsId", floroRanchStartPlayResponse.PlayInfo.SubInsId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", floroRanchStartPlayResponse.PlayInfo.Role.SKillData.SkillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Races", string.Join<int>(",", floroRanchStartPlayResponse.PlayInfo.Races));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Stage", floroRanchStartPlayResponse.PlayInfo.Stage);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Day", floroRanchStartPlayResponse.PlayInfo.Day);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
					FloroRanchGamePlayModel.Instance.InitGame(activityId, new List<int>(floroRanchStartPlayResponse.PlayInfo.Races), floroRanchStartPlayResponse.PlayInfo.Role.SKillData.SkillId, floroRanchStartPlayResponse.PlayInfo.IsOver);
					EFloroRanchActivityDataType activityDataType = FloroRanchModel.Instance.GetActivityDataType(activityId);
					global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(activityDataType, true);
					FloroRanchGamePlayModel.Instance.SetCurrentActivityData(activityData);
					FloroRanchGamePlayModel.Instance.EnterGame(floroRanchStartPlayResponse);
					Action<FloroRanchStartPlayResponse> callback3 = callback;
					if (callback3 != null)
					{
						callback3(floroRanchStartPlayResponse);
					}
					activityData.SetUnFinishedSubDungeonId(subInstanceId);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchStartPlayResponse.ErrorCode, 23655, null, true, true);
				Action<FloroRanchStartPlayResponse> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(null);
				return;
			}
		}, 0);
	}

	// Token: 0x0600A285 RID: 41605 RVA: 0x002FB97C File Offset: 0x002F9B7C
	public void SendFloroRanchPlayNextDayRequest(int activityId, int subInstanceId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayNextDayResponse> callback)
	{
		FloroRanchPlayNextDayRequest floroRanchPlayNextDayRequest = FloroRanchPlayNextDayRequest.Create();
		floroRanchPlayNextDayRequest.ActivityId = activityId;
		floroRanchPlayNextDayRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayNextDayRequest, floroRanchPlayNextDayRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayNextDayResponse floroRanchPlayNextDayResponse = (FloroRanchPlayNextDayResponse)msg;
			if (floroRanchPlayNextDayResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchPlayNextDayResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayNextDayResponse.ErrorCode, 26348, null, true, true);
				callback(null);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchPlayNextDayResponse.Task);
			callback(floroRanchPlayNextDayResponse);
		}, 0);
	}

	// Token: 0x0600A286 RID: 41606 RVA: 0x002FB9C8 File Offset: 0x002F9BC8
	public void FloroRanchPlayGachaRequest(int activityId, int subInstanceId, int cardId, int incId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayGachaResponse> callback)
	{
		FloroRanchPlayGachaRequest floroRanchPlayGachaRequest = Aki.Protocol.FloroRanchPlayGachaRequest.Create();
		floroRanchPlayGachaRequest.ActivityId = activityId;
		floroRanchPlayGachaRequest.SubInsId = subInstanceId;
		floroRanchPlayGachaRequest.CardId = cardId;
		floroRanchPlayGachaRequest.IncId = incId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayGachaRequest, floroRanchPlayGachaRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayGachaResponse response = (FloroRanchPlayGachaResponse)msg;
			if (response == null)
			{
				callback(null);
				return;
			}
			if (response.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 26388, null, true, true);
				callback(null);
				return;
			}
			FloroRanchEntityActionSystem.AddEntities(new List<FloroRanchPlayUnit>(response.GachaResult)).ContinueWith(delegate()
			{
				callback(response);
			});
		}, 0);
	}

	// Token: 0x0600A287 RID: 41607 RVA: 0x002FBA24 File Offset: 0x002F9C24
	public void FloroRanchPlayRefreshGachaRequest(int activityId, int subInstanceId, int incId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayGachaRefreshResponse> callback)
	{
		FloroRanchPlayGachaRefreshRequest floroRanchPlayGachaRefreshRequest = FloroRanchPlayGachaRefreshRequest.Create();
		floroRanchPlayGachaRefreshRequest.ActivityId = activityId;
		floroRanchPlayGachaRefreshRequest.SubInsId = subInstanceId;
		floroRanchPlayGachaRefreshRequest.IncId = incId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayGachaRefreshRequest, floroRanchPlayGachaRefreshRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayGachaRefreshResponse floroRanchPlayGachaRefreshResponse = (FloroRanchPlayGachaRefreshResponse)msg;
			if (floroRanchPlayGachaRefreshResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchPlayGachaRefreshResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayGachaRefreshResponse.ErrorCode, 18822, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnCurrencyChange(floroRanchPlayGachaRefreshResponse.CurCoin, floroRanchPlayGachaRefreshResponse.CurDiamond);
			callback(floroRanchPlayGachaRefreshResponse);
		}, 0);
	}

	// Token: 0x0600A288 RID: 41608 RVA: 0x002FBA78 File Offset: 0x002F9C78
	public void SendFloroRanchPlayShopBuyRequest(int activityId, int subInstanceId, int taskIncId, int id, int type, int goodIncId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayShopBuyResponse> callback)
	{
		FloroRanchPlayShopBuyRequest floroRanchPlayShopBuyRequest = FloroRanchPlayShopBuyRequest.Create();
		floroRanchPlayShopBuyRequest.ActivityId = activityId;
		floroRanchPlayShopBuyRequest.SubInsId = subInstanceId;
		floroRanchPlayShopBuyRequest.BuyId = id;
		floroRanchPlayShopBuyRequest.Type = (FloroRanchShopItemType)type;
		floroRanchPlayShopBuyRequest.IncId = taskIncId;
		floroRanchPlayShopBuyRequest.ItemIncId = goodIncId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayShopBuyRequest, floroRanchPlayShopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayShopBuyResponse floroRanchPlayShopBuyResponse = (FloroRanchPlayShopBuyResponse)msg;
			if (floroRanchPlayShopBuyResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchPlayShopBuyResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayShopBuyResponse.ErrorCode, 15480, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnShopItemPurchased(floroRanchPlayShopBuyResponse);
			callback(floroRanchPlayShopBuyResponse);
		}, 0);
	}

	// Token: 0x0600A289 RID: 41609 RVA: 0x002FBAE4 File Offset: 0x002F9CE4
	public void SendFloroRanchPlayRefreshShopRequest(int activityId, int subInstanceId, int incId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayRefreshShopResponse> callback)
	{
		FloroRanchPlayRefreshShopRequest floroRanchPlayRefreshShopRequest = FloroRanchPlayRefreshShopRequest.Create();
		floroRanchPlayRefreshShopRequest.ActivityId = activityId;
		floroRanchPlayRefreshShopRequest.SubInsId = subInstanceId;
		floroRanchPlayRefreshShopRequest.IncId = incId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayRefreshShopRequest, floroRanchPlayRefreshShopRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayRefreshShopResponse floroRanchPlayRefreshShopResponse = (FloroRanchPlayRefreshShopResponse)msg;
			if (floroRanchPlayRefreshShopResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchPlayRefreshShopResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayRefreshShopResponse.ErrorCode, 18191, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnCurrencyChange(floroRanchPlayRefreshShopResponse.CurCoin, floroRanchPlayRefreshShopResponse.CurDiamond);
			callback(floroRanchPlayRefreshShopResponse);
		}, 0);
	}

	// Token: 0x0600A28A RID: 41610 RVA: 0x002FBB38 File Offset: 0x002F9D38
	public void SendFloroRanchPlaySelectCardGroupRequest(int activityId, int subInstanceId, int[] cardIdList, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlaySelectCardGroupResponse> callback)
	{
		FloroRanchPlaySelectCardGroupRequest floroRanchPlaySelectCardGroupRequest = FloroRanchPlaySelectCardGroupRequest.Create();
		floroRanchPlaySelectCardGroupRequest.ActivityId = activityId;
		floroRanchPlaySelectCardGroupRequest.SubInsId = subInstanceId;
		floroRanchPlaySelectCardGroupRequest.CardId.AddRange(cardIdList);
		Net.Instance.Call(ERequestMessageId.FloroRanchPlaySelectCardGroupRequest, floroRanchPlaySelectCardGroupRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlaySelectCardGroupResponse response = (FloroRanchPlaySelectCardGroupResponse)msg;
			if (response == null)
			{
				return;
			}
			if (response.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 19257, null, true, true);
				callback(null);
				return;
			}
			FloroRanchEntityActionSystem.AddEntities(new List<FloroRanchPlayUnit>(response.NewPhantoms)).ContinueWith(delegate()
			{
				callback(response);
			});
		}, 0);
	}

	// Token: 0x0600A28B RID: 41611 RVA: 0x002FBB90 File Offset: 0x002F9D90
	public void SendFloroRanchExecuteSkillPlayRequest(int activityId, int subInstanceId, Action<bool> callback)
	{
		FloroRanchExecuteSkillPlayRequest floroRanchExecuteSkillPlayRequest = FloroRanchExecuteSkillPlayRequest.Create();
		floroRanchExecuteSkillPlayRequest.ActivityId = activityId;
		floroRanchExecuteSkillPlayRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchExecuteSkillPlayRequest, floroRanchExecuteSkillPlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchExecuteSkillPlayResponse floroRanchExecuteSkillPlayResponse = (FloroRanchExecuteSkillPlayResponse)msg;
			if (floroRanchExecuteSkillPlayResponse == null)
			{
				callback(false);
				return;
			}
			if (floroRanchExecuteSkillPlayResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchExecuteSkillPlayResponse.ErrorCode, 28746, null, true, true);
				callback(false);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchExecuteSkillPlayResponse.Task);
			callback(true);
		}, 0);
	}

	// Token: 0x0600A28C RID: 41612 RVA: 0x002FBBDC File Offset: 0x002F9DDC
	public void SendFloroRanchEventChoiceRequest(int activityId, int subInstanceId, int eventIncId, int choiceId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchEventChoiceResponse> callback)
	{
		FloroRanchEventChoiceRequest floroRanchEventChoiceRequest = FloroRanchEventChoiceRequest.Create();
		floroRanchEventChoiceRequest.ActivityId = activityId;
		floroRanchEventChoiceRequest.SubInsId = subInstanceId;
		floroRanchEventChoiceRequest.IncId = eventIncId;
		floroRanchEventChoiceRequest.Choice = choiceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchEventChoiceRequest, floroRanchEventChoiceRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchEventChoiceResponse floroRanchEventChoiceResponse = (FloroRanchEventChoiceResponse)msg;
			if (floroRanchEventChoiceResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchEventChoiceResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchEventChoiceResponse.ErrorCode, 29916, null, true, true);
				callback(null);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchEventChoiceResponse.Task);
			callback(floroRanchEventChoiceResponse);
		}, 0);
	}

	// Token: 0x0600A28D RID: 41613 RVA: 0x002FBC38 File Offset: 0x002F9E38
	public void SendFloroRanchPlayTributeRequest(int activityId, int subInstanceId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayTributeResponse> callback)
	{
		FloroRanchPlayTributeRequest floroRanchPlayTributeRequest = FloroRanchPlayTributeRequest.Create();
		floroRanchPlayTributeRequest.ActivityId = activityId;
		floroRanchPlayTributeRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayTributeRequest, floroRanchPlayTributeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayTributeResponse floroRanchPlayTributeResponse = (FloroRanchPlayTributeResponse)msg;
			if (floroRanchPlayTributeResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchPlayTributeResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayTributeResponse.ErrorCode, 27951, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnTributeResult(floroRanchPlayTributeResponse);
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchPlayTributeResponse.Task);
			callback(floroRanchPlayTributeResponse);
		}, 0);
	}

	// Token: 0x0600A28E RID: 41614 RVA: 0x002FBC84 File Offset: 0x002F9E84
	[NullableContext(2)]
	public void SendFloroRanchPlayUnlimitedModeRequest(int activityId, int subInstanceId, Action<FloroRanchPlayUnlimitedModeResponse> callback = null)
	{
		FloroRanchPlayUnlimitedModeRequest floroRanchPlayUnlimitedModeRequest = FloroRanchPlayUnlimitedModeRequest.Create();
		floroRanchPlayUnlimitedModeRequest.ActivityId = activityId;
		floroRanchPlayUnlimitedModeRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayUnlimitedModeRequest, floroRanchPlayUnlimitedModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayUnlimitedModeResponse floroRanchPlayUnlimitedModeResponse = (FloroRanchPlayUnlimitedModeResponse)msg;
			if (floroRanchPlayUnlimitedModeResponse == null)
			{
				Action<FloroRanchPlayUnlimitedModeResponse> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(null);
				return;
			}
			else if (floroRanchPlayUnlimitedModeResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayUnlimitedModeResponse.ErrorCode, 20504, null, true, true);
				Action<FloroRanchPlayUnlimitedModeResponse> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(null);
				return;
			}
			else
			{
				EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchInsertTask, floroRanchPlayUnlimitedModeResponse.Task);
				FloroRanchGamePlayModel.Instance.IsEndlessMode = true;
				FloroRanchGamePlayModel.Instance.CurStage = floroRanchPlayUnlimitedModeResponse.CurStage;
				EventSystem.Instance.Emit(EEventName.OnFloroRanchStageInfoRefresh);
				Action<FloroRanchPlayUnlimitedModeResponse> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(floroRanchPlayUnlimitedModeResponse);
				return;
			}
		}, 0);
	}

	// Token: 0x0600A28F RID: 41615 RVA: 0x002FBCD0 File Offset: 0x002F9ED0
	public void SendFloroRanchPlayRemoveUnitRequest(int activityId, int subInstanceId, int entityId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchPlayRemoveUnitResponse> callback)
	{
		FloroRanchPlayRemoveUnitRequest floroRanchPlayRemoveUnitRequest = FloroRanchPlayRemoveUnitRequest.Create();
		floroRanchPlayRemoveUnitRequest.ActivityId = activityId;
		floroRanchPlayRemoveUnitRequest.SubInsId = subInstanceId;
		floroRanchPlayRemoveUnitRequest.UnitIncId = entityId;
		Net.Instance.Call(ERequestMessageId.FloroRanchPlayRemoveUnitRequest, floroRanchPlayRemoveUnitRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchPlayRemoveUnitResponse response = (FloroRanchPlayRemoveUnitResponse)msg;
			if (response == null)
			{
				callback(null);
				return;
			}
			if (response.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 16556, null, true, true);
				callback(null);
				return;
			}
			FloroRanchEntityActionSystem.RemoveEntity(entityId).ContinueWith(delegate()
			{
				FloroRanchGamePlayModel.Instance.OnCurrencyChange(response.CurCoin, response.CurDiamond);
				EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchInsertTask, response.Task);
				callback(response);
			});
		}, 0);
	}

	// Token: 0x0600A290 RID: 41616 RVA: 0x002FBD30 File Offset: 0x002F9F30
	public void SendFloroRanchSettleDataRequest(int activityId, int subInstanceId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchSettleDataResponse> callback)
	{
		FloroRanchSettleDataRequest floroRanchSettleDataRequest = FloroRanchSettleDataRequest.Create();
		floroRanchSettleDataRequest.ActivityId = activityId;
		floroRanchSettleDataRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchSettleDataRequest, floroRanchSettleDataRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchSettleDataResponse floroRanchSettleDataResponse = (FloroRanchSettleDataResponse)msg;
			if (floroRanchSettleDataResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchSettleDataResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleDataResponse.ErrorCode, 22164, null, true, true);
				callback(null);
				return;
			}
			callback(floroRanchSettleDataResponse);
		}, 0);
	}

	// Token: 0x0600A291 RID: 41617 RVA: 0x002FBD7C File Offset: 0x002F9F7C
	public unsafe void SendFloroRanchSettleRequest(int activityId, int subInstanceId, bool isSettle, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchSettleResponse> callback)
	{
		FloroRanchSettleRequest floroRanchSettleRequest = FloroRanchSettleRequest.Create();
		floroRanchSettleRequest.ActivityId = activityId;
		floroRanchSettleRequest.SubInsId = subInstanceId;
		floroRanchSettleRequest.Settle = isSettle;
		Net.Instance.Call(ERequestMessageId.FloroRanchSettleRequest, floroRanchSettleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchSettleResponse floroRanchSettleResponse = (FloroRanchSettleResponse)msg;
			if (floroRanchSettleResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchSettleResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleResponse.ErrorCode, 29820, null, true, true);
				callback(null);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "副本结算";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isWin", floroRanchSettleResponse.Win);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("subInstanceId", subInstanceId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			callback(floroRanchSettleResponse);
			global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
			if (floroRanchSettleResponse.Win && currentActivityData != null)
			{
				currentActivityData.UpdateFloroRanchSubDungeonPass(subInstanceId);
			}
			if (currentActivityData != null)
			{
				currentActivityData.ClearUnFinishedSubDungeonId();
			}
			EventSystem.Instance.Emit(EEventName.FloroRanchSettlement);
			FloroRanchGamePlayModel.Instance.GameEnd();
		}, 0);
	}

	// Token: 0x0600A292 RID: 41618 RVA: 0x002FBDDC File Offset: 0x002F9FDC
	public void SendFloroRanchAbandonArchiveRequest(int activityId, int subInstanceId, [Nullable(new byte[]
	{
		1,
		2
	})] Action<FloroRanchSettleResponse> callback)
	{
		FloroRanchSettleRequest floroRanchSettleRequest = FloroRanchSettleRequest.Create();
		floroRanchSettleRequest.ActivityId = activityId;
		floroRanchSettleRequest.SubInsId = subInstanceId;
		floroRanchSettleRequest.Settle = true;
		Net.Instance.Call(ERequestMessageId.FloroRanchSettleRequest, floroRanchSettleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchSettleResponse floroRanchSettleResponse = (FloroRanchSettleResponse)msg;
			if (floroRanchSettleResponse == null)
			{
				callback(null);
				return;
			}
			if (floroRanchSettleResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleResponse.ErrorCode, 29820, null, true, true);
				callback(null);
				return;
			}
			EFloroRanchActivityDataType activityDataType = FloroRanchModel.Instance.GetActivityDataType(activityId);
			global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(activityDataType, true);
			if (activityData != null)
			{
				activityData.ClearUnFinishedSubDungeonId();
			}
			EventSystem.Instance.Emit(EEventName.FloroRanchSettlement);
			callback(floroRanchSettleResponse);
		}, 0);
	}

	// Token: 0x0600A293 RID: 41619 RVA: 0x002FBE3C File Offset: 0x002FA03C
	public UniTask SendFloroRanchReStartRequest(int activityId, int subInstanceId, int[] races, int skillId)
	{
		FloroRanchController.<SendFloroRanchReStartRequest>d__26 <SendFloroRanchReStartRequest>d__;
		<SendFloroRanchReStartRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendFloroRanchReStartRequest>d__.<>4__this = this;
		<SendFloroRanchReStartRequest>d__.activityId = activityId;
		<SendFloroRanchReStartRequest>d__.subInstanceId = subInstanceId;
		<SendFloroRanchReStartRequest>d__.races = races;
		<SendFloroRanchReStartRequest>d__.skillId = skillId;
		<SendFloroRanchReStartRequest>d__.<>1__state = -1;
		<SendFloroRanchReStartRequest>d__.<>t__builder.Start<FloroRanchController.<SendFloroRanchReStartRequest>d__26>(ref <SendFloroRanchReStartRequest>d__);
		return <SendFloroRanchReStartRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A294 RID: 41620 RVA: 0x002FBEA0 File Offset: 0x002FA0A0
	[NullableContext(2)]
	public void SendFloroRanchCloseTaskRequest(int activityId, int subInstanceId, int taskId, Action<FloroRanchCloseTaskResponse> callback = null)
	{
		FloroRanchCloseTaskRequest floroRanchCloseTaskRequest = FloroRanchCloseTaskRequest.Create();
		floroRanchCloseTaskRequest.ActivityId = activityId;
		floroRanchCloseTaskRequest.SubInsId = subInstanceId;
		floroRanchCloseTaskRequest.TaskIncId = taskId;
		Net.Instance.Call(ERequestMessageId.FloroRanchCloseTaskRequest, floroRanchCloseTaskRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchCloseTaskResponse floroRanchCloseTaskResponse = (FloroRanchCloseTaskResponse)msg;
			if (floroRanchCloseTaskResponse == null)
			{
				Action<FloroRanchCloseTaskResponse> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(null);
				return;
			}
			else if (floroRanchCloseTaskResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchCloseTaskResponse.ErrorCode, 19666, null, true, true);
				Action<FloroRanchCloseTaskResponse> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(null);
				return;
			}
			else
			{
				Action<FloroRanchCloseTaskResponse> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(floroRanchCloseTaskResponse);
				return;
			}
		}, 0);
	}

	// Token: 0x0600A295 RID: 41621 RVA: 0x002FBEF4 File Offset: 0x002FA0F4
	public void SendFloroRanchOutRequest(int activityId, int subInstanceId)
	{
		FloroRanchOutRequest floroRanchOutRequest = FloroRanchOutRequest.Create();
		floroRanchOutRequest.ActivityId = activityId;
		floroRanchOutRequest.SubInsId = subInstanceId;
		Net.Instance.Call(ERequestMessageId.FloroRanchOutRequest, floroRanchOutRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchOutResponse floroRanchOutResponse = (FloroRanchOutResponse)msg;
			if (floroRanchOutResponse == null)
			{
				return;
			}
			if (floroRanchOutResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchOutResponse.ErrorCode, 25979, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600A296 RID: 41622 RVA: 0x002FBF48 File Offset: 0x002FA148
	[NullableContext(2)]
	private void OnFloroRanchPlayGmInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		FloroRanchPlayGmInfoUpdateNotify floroRanchPlayGmInfoUpdateNotify = (FloroRanchPlayGmInfoUpdateNotify)msg;
	}

	// Token: 0x0600A297 RID: 41623 RVA: 0x002FBF5C File Offset: 0x002FA15C
	[NullableContext(2)]
	private void OnFloroRanchPlayWeeklyEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		if (FloroRanchGamePlayModel.Instance.IsInGamePlay)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchWeeklyEnd);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				FloroRanchGamePlayModel.Instance.ExitGame(false);
				UiManager.Instance.CloseView(EUiViewName.FloroRanchWeeklyMainView, null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.FloroRanchWeeklyMainView))
		{
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchWeeklyEnd);
			confirmBoxDataNew2.FunctionMap[1] = delegate()
			{
				UiManager.Instance.CloseView(EUiViewName.FloroRanchWeeklyMainView, null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
		}
	}

	// Token: 0x0600A298 RID: 41624 RVA: 0x002FC00C File Offset: 0x002FA20C
	public void RequestTaskReward(int[] taskIds)
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		FloroRanchRewardTaskRequest floroRanchRewardTaskRequest = new FloroRanchRewardTaskRequest();
		floroRanchRewardTaskRequest.TaskIds.AddRange(taskIds);
		floroRanchRewardTaskRequest.ActivityId = activityData.Id;
		Net.Instance.Call(ERequestMessageId.FloroRanchRewardTaskRequest, floroRanchRewardTaskRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchRewardTaskResponse floroRanchRewardTaskResponse = (FloroRanchRewardTaskResponse)msg;
			if (floroRanchRewardTaskResponse == null)
			{
				return;
			}
			if (floroRanchRewardTaskResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchRewardTaskResponse.ErrorCode, 24696, null, true, true);
				return;
			}
			activityData.UpdateTaskRewardStatus(new List<int>(taskIds));
		}, 0);
	}

	// Token: 0x0600A299 RID: 41625 RVA: 0x002FC080 File Offset: 0x002FA280
	public void RequestMilestoneReward(int[] rewardIds)
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		FloroRanchRewardMilestoneRequest floroRanchRewardMilestoneRequest = FloroRanchRewardMilestoneRequest.Create();
		floroRanchRewardMilestoneRequest.ActivityId = activityData.Id;
		floroRanchRewardMilestoneRequest.MilestoneIds.AddRange(rewardIds);
		Net.Instance.Call(ERequestMessageId.FloroRanchRewardMilestoneRequest, floroRanchRewardMilestoneRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchRewardMilestoneResponse floroRanchRewardMilestoneResponse = (FloroRanchRewardMilestoneResponse)msg;
			if (floroRanchRewardMilestoneResponse == null)
			{
				return;
			}
			if (floroRanchRewardMilestoneResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchRewardMilestoneResponse.ErrorCode, 24536, null, true, true);
			}
			activityData.UpdateFloroRanchMilestoneDataList(new List<int>(rewardIds));
		}, 0);
	}

	// Token: 0x0600A29A RID: 41626 RVA: 0x002FC0F4 File Offset: 0x002FA2F4
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, false);
		if (activityData == null)
		{
			return;
		}
		if (activityData.GetFloroRanchParamConfig().MilestoneItemId == configId)
		{
			activityData.UpdateFloroRanchMilestoneItemCount();
		}
		if (activityData.GetFloroRanchParamConfig().TechPointItem == configId)
		{
			EventSystem.Instance.Emit(EEventName.FloroRanchDataRedDot);
		}
	}

	// Token: 0x0600A29B RID: 41627 RVA: 0x002FC14C File Offset: 0x002FA34C
	public void RequestUnlockTechPoint(int technologyId, Action<FloroRanchUnlockTechPointResponse> callback)
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		FloroRanchUnlockTechPointRequest floroRanchUnlockTechPointRequest = FloroRanchUnlockTechPointRequest.Create();
		floroRanchUnlockTechPointRequest.ActivityId = activityData.Id;
		floroRanchUnlockTechPointRequest.TechPoint = technologyId;
		Net.Instance.Call(ERequestMessageId.FloroRanchUnlockTechPointRequest, floroRanchUnlockTechPointRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchUnlockTechPointResponse floroRanchUnlockTechPointResponse = (FloroRanchUnlockTechPointResponse)msg;
			if (floroRanchUnlockTechPointResponse == null)
			{
				return;
			}
			if (floroRanchUnlockTechPointResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchUnlockTechPointResponse.ErrorCode, 18079, null, true, true);
				return;
			}
			activityData.UpdateFloroRanchTechnologyData(technologyId);
			callback(floroRanchUnlockTechPointResponse);
		}, 0);
	}

	// Token: 0x0600A29C RID: 41628 RVA: 0x002FC1C0 File Offset: 0x002FA3C0
	public void RequestComicRead()
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		if (activityData.GetIsReadComic())
		{
			return;
		}
		FloroRanchAnimationRequest floroRanchAnimationRequest = new FloroRanchAnimationRequest();
		floroRanchAnimationRequest.ActivityId = activityData.Id;
		Net.Instance.Call(ERequestMessageId.FloroRanchAnimationRequest, floroRanchAnimationRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchAnimationResponse floroRanchAnimationResponse = (FloroRanchAnimationResponse)msg;
			if (floroRanchAnimationResponse == null)
			{
				return;
			}
			if (floroRanchAnimationResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchAnimationResponse.ErrorCode, 22651, null, true, true);
				return;
			}
			activityData.ReadComic();
		}, 0);
	}

	// Token: 0x0600A29D RID: 41629 RVA: 0x002FC228 File Offset: 0x002FA428
	public void RequestSubDungeonRead(int subDungeonId)
	{
		global::FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		FloroRanchFirstEnterRequest floroRanchFirstEnterRequest = new FloroRanchFirstEnterRequest();
		floroRanchFirstEnterRequest.ActivityId = activityData.Id;
		floroRanchFirstEnterRequest.SubInsId = subDungeonId;
		Net.Instance.Call(ERequestMessageId.FloroRanchFirstEnterRequest, floroRanchFirstEnterRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FloroRanchFirstEnterResponse floroRanchFirstEnterResponse = (FloroRanchFirstEnterResponse)msg;
			if (floroRanchFirstEnterResponse == null)
			{
				return;
			}
			if (floroRanchFirstEnterResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchFirstEnterResponse.ErrorCode, 27776, null, true, true);
				return;
			}
			activityData.UpdateFloroRanchSubDungeonRedDot(new List<int>
			{
				subDungeonId
			});
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}, 0);
	}

	// Token: 0x1700115D RID: 4445
	// (get) Token: 0x0600A29E RID: 41630 RVA: 0x002FC294 File Offset: 0x002FA494
	public static FloroRanchController Instance
	{
		get
		{
			return FloroRanchController._Instance;
		}
	}

	// Token: 0x0600A29F RID: 41631 RVA: 0x002FC29B File Offset: 0x002FA49B
	public static FloroRanchController GetOrCreateInstance()
	{
		if (FloroRanchController._Instance == null)
		{
			FloroRanchController.CreateInstance();
		}
		return FloroRanchController._Instance;
	}

	// Token: 0x0600A2A0 RID: 41632 RVA: 0x002FC2AF File Offset: 0x002FA4AF
	public static bool CreateInstance()
	{
		if (FloroRanchController._Instance != null)
		{
			return true;
		}
		FloroRanchController._Instance = new FloroRanchController();
		return true;
	}

	// Token: 0x0600A2A1 RID: 41633 RVA: 0x002FC2C5 File Offset: 0x002FA4C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A2A2 RID: 41634 RVA: 0x002FC2C7 File Offset: 0x002FA4C7
	public static void ResetStaticDefaultValue()
	{
		FloroRanchController._Instance = null;
	}

	// Token: 0x0600A2A3 RID: 41635 RVA: 0x002FC2CF File Offset: 0x002FA4CF
	static FloroRanchController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchController.CreateStaticDefaultValue), new Action(FloroRanchController.ResetStaticDefaultValue));
	}

	// Token: 0x04005F61 RID: 24417
	[Nullable(2)]
	private static FloroRanchController _Instance;
}
