using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001B2B RID: 6955
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FloroRanchController : ActivityControllerBase
{
	// Token: 0x0600CE68 RID: 52840 RVA: 0x002F0602 File Offset: 0x002EE802
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600CE69 RID: 52841 RVA: 0x002F0609 File Offset: 0x002EE809
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityPastureGuide";
	}

	// Token: 0x0600CE6A RID: 52842 RVA: 0x002F0610 File Offset: 0x002EE810
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FloroRanchActivityView();
	}

	// Token: 0x0600CE6B RID: 52843 RVA: 0x002F0618 File Offset: 0x002EE818
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		global::FloroRanchActivityData floroRanchActivityData = new global::FloroRanchActivityData();
		EFloroRanchActivityDataType activityDataType = FloroRanchModel.Instance.GetActivityDataType(data.Id);
		FloroRanchModel.Instance.SetActivityData(activityDataType, floroRanchActivityData);
		return floroRanchActivityData;
	}

	// Token: 0x0600CE6C RID: 52844 RVA: 0x002F0649 File Offset: 0x002EE849
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600CE6D RID: 52845 RVA: 0x002F064C File Offset: 0x002EE84C
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchUnlockTipView, null, null);
	}

	// Token: 0x0600CE6E RID: 52846 RVA: 0x002F0660 File Offset: 0x002EE860
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.FloroRanchUpdatePlayerInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchUpdatePlayerInfoNotify));
		Net.Instance.Register(ENotifyMessageId.FloroRanchPlayGmInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchPlayGmInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.FloroRanchPlayWeeklyEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFloroRanchPlayWeeklyEndNotify));
	}

	// Token: 0x0600CE6F RID: 52847 RVA: 0x002F06C1 File Offset: 0x002EE8C1
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchUpdatePlayerInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchPlayGmInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FloroRanchPlayWeeklyEndNotify);
	}

	// Token: 0x0600CE70 RID: 52848 RVA: 0x002F06F3 File Offset: 0x002EE8F3
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600CE71 RID: 52849 RVA: 0x002F0711 File Offset: 0x002EE911
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600CE72 RID: 52850 RVA: 0x002F0730 File Offset: 0x002EE930
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

	// Token: 0x0600CE73 RID: 52851 RVA: 0x002F0810 File Offset: 0x002EEA10
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchStartPlayResponse.ErrorCode, 26272, null, true, true);
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

	// Token: 0x0600CE74 RID: 52852 RVA: 0x002F089C File Offset: 0x002EEA9C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayNextDayResponse.ErrorCode, 19866, null, true, true);
				callback(null);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchPlayNextDayResponse.Task);
			callback(floroRanchPlayNextDayResponse);
		}, 0);
	}

	// Token: 0x0600CE75 RID: 52853 RVA: 0x002F08E8 File Offset: 0x002EEAE8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 26482, null, true, true);
				callback(null);
				return;
			}
			FloroRanchEntityActionSystem.AddEntities(new List<FloroRanchPlayUnit>(response.GachaResult)).ContinueWith(delegate()
			{
				callback(response);
			});
		}, 0);
	}

	// Token: 0x0600CE76 RID: 52854 RVA: 0x002F0944 File Offset: 0x002EEB44
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayGachaRefreshResponse.ErrorCode, 22802, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnCurrencyChange(floroRanchPlayGachaRefreshResponse.CurCoin, floroRanchPlayGachaRefreshResponse.CurDiamond);
			callback(floroRanchPlayGachaRefreshResponse);
		}, 0);
	}

	// Token: 0x0600CE77 RID: 52855 RVA: 0x002F0998 File Offset: 0x002EEB98
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayShopBuyResponse.ErrorCode, 21023, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnShopItemPurchased(floroRanchPlayShopBuyResponse);
			callback(floroRanchPlayShopBuyResponse);
		}, 0);
	}

	// Token: 0x0600CE78 RID: 52856 RVA: 0x002F0A04 File Offset: 0x002EEC04
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayRefreshShopResponse.ErrorCode, 18811, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnCurrencyChange(floroRanchPlayRefreshShopResponse.CurCoin, floroRanchPlayRefreshShopResponse.CurDiamond);
			callback(floroRanchPlayRefreshShopResponse);
		}, 0);
	}

	// Token: 0x0600CE79 RID: 52857 RVA: 0x002F0A58 File Offset: 0x002EEC58
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 24077, null, true, true);
				callback(null);
				return;
			}
			FloroRanchEntityActionSystem.AddEntities(new List<FloroRanchPlayUnit>(response.NewPhantoms)).ContinueWith(delegate()
			{
				callback(response);
			});
		}, 0);
	}

	// Token: 0x0600CE7A RID: 52858 RVA: 0x002F0AB0 File Offset: 0x002EECB0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchExecuteSkillPlayResponse.ErrorCode, 26537, null, true, true);
				callback(false);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchExecuteSkillPlayResponse.Task);
			callback(true);
		}, 0);
	}

	// Token: 0x0600CE7B RID: 52859 RVA: 0x002F0AFC File Offset: 0x002EECFC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchEventChoiceResponse.ErrorCode, 21742, null, true, true);
				callback(null);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchEventChoiceResponse.Task);
			callback(floroRanchEventChoiceResponse);
		}, 0);
	}

	// Token: 0x0600CE7C RID: 52860 RVA: 0x002F0B58 File Offset: 0x002EED58
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayTributeResponse.ErrorCode, 19879, null, true, true);
				callback(null);
				return;
			}
			FloroRanchGamePlayModel.Instance.OnTributeResult(floroRanchPlayTributeResponse);
			EventSystem.Instance.Emit<IReadOnlyList<FloroRanchPlayTask>>(EEventName.OnFloroRanchNextDayTaskRefresh, floroRanchPlayTributeResponse.Task);
			callback(floroRanchPlayTributeResponse);
		}, 0);
	}

	// Token: 0x0600CE7D RID: 52861 RVA: 0x002F0BA4 File Offset: 0x002EEDA4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchPlayUnlimitedModeResponse.ErrorCode, 22265, null, true, true);
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

	// Token: 0x0600CE7E RID: 52862 RVA: 0x002F0BF0 File Offset: 0x002EEDF0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, 27510, null, true, true);
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

	// Token: 0x0600CE7F RID: 52863 RVA: 0x002F0C50 File Offset: 0x002EEE50
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleDataResponse.ErrorCode, 21024, null, true, true);
				callback(null);
				return;
			}
			callback(floroRanchSettleDataResponse);
		}, 0);
	}

	// Token: 0x0600CE80 RID: 52864 RVA: 0x002F0C9C File Offset: 0x002EEE9C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleResponse.ErrorCode, 25335, null, true, true);
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

	// Token: 0x0600CE81 RID: 52865 RVA: 0x002F0CFC File Offset: 0x002EEEFC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchSettleResponse.ErrorCode, 25335, null, true, true);
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

	// Token: 0x0600CE82 RID: 52866 RVA: 0x002F0D5C File Offset: 0x002EEF5C
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

	// Token: 0x0600CE83 RID: 52867 RVA: 0x002F0DC0 File Offset: 0x002EEFC0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchCloseTaskResponse.ErrorCode, 22776, null, true, true);
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

	// Token: 0x0600CE84 RID: 52868 RVA: 0x002F0E14 File Offset: 0x002EF014
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchOutResponse.ErrorCode, 21325, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600CE85 RID: 52869 RVA: 0x002F0E68 File Offset: 0x002EF068
	[NullableContext(2)]
	private void OnFloroRanchPlayGmInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		FloroRanchPlayGmInfoUpdateNotify floroRanchPlayGmInfoUpdateNotify = (FloroRanchPlayGmInfoUpdateNotify)msg;
	}

	// Token: 0x0600CE86 RID: 52870 RVA: 0x002F0E7C File Offset: 0x002EF07C
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

	// Token: 0x0600CE87 RID: 52871 RVA: 0x002F0F2C File Offset: 0x002EF12C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchRewardTaskResponse.ErrorCode, 28020, null, true, true);
				return;
			}
			activityData.UpdateTaskRewardStatus(new List<int>(taskIds));
		}, 0);
	}

	// Token: 0x0600CE88 RID: 52872 RVA: 0x002F0FA0 File Offset: 0x002EF1A0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchRewardMilestoneResponse.ErrorCode, 27049, null, true, true);
			}
			activityData.UpdateFloroRanchMilestoneDataList(new List<int>(rewardIds));
		}, 0);
	}

	// Token: 0x0600CE89 RID: 52873 RVA: 0x002F1014 File Offset: 0x002EF214
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

	// Token: 0x0600CE8A RID: 52874 RVA: 0x002F106C File Offset: 0x002EF26C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchUnlockTechPointResponse.ErrorCode, 23616, null, true, true);
				return;
			}
			activityData.UpdateFloroRanchTechnologyData(technologyId);
			callback(floroRanchUnlockTechPointResponse);
		}, 0);
	}

	// Token: 0x0600CE8B RID: 52875 RVA: 0x002F10E0 File Offset: 0x002EF2E0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchAnimationResponse.ErrorCode, 18911, null, true, true);
				return;
			}
			activityData.ReadComic();
		}, 0);
	}

	// Token: 0x0600CE8C RID: 52876 RVA: 0x002F1148 File Offset: 0x002EF348
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(floroRanchFirstEnterResponse.ErrorCode, 21638, null, true, true);
				return;
			}
			activityData.UpdateFloroRanchSubDungeonRedDot(new List<int>
			{
				subDungeonId
			});
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}, 0);
	}

	// Token: 0x17001138 RID: 4408
	// (get) Token: 0x0600CE8D RID: 52877 RVA: 0x002F11B4 File Offset: 0x002EF3B4
	public static FloroRanchController Instance
	{
		get
		{
			return FloroRanchController._Instance;
		}
	}

	// Token: 0x0600CE8E RID: 52878 RVA: 0x002F11BB File Offset: 0x002EF3BB
	public static FloroRanchController GetOrCreateInstance()
	{
		if (FloroRanchController._Instance == null)
		{
			FloroRanchController.CreateInstance();
		}
		return FloroRanchController._Instance;
	}

	// Token: 0x0600CE8F RID: 52879 RVA: 0x002F11CF File Offset: 0x002EF3CF
	public static bool CreateInstance()
	{
		if (FloroRanchController._Instance != null)
		{
			return true;
		}
		FloroRanchController._Instance = new FloroRanchController();
		return true;
	}

	// Token: 0x0600CE90 RID: 52880 RVA: 0x002F11E5 File Offset: 0x002EF3E5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE91 RID: 52881 RVA: 0x002F11E7 File Offset: 0x002EF3E7
	public static void ResetStaticDefaultValue()
	{
		FloroRanchController._Instance = null;
	}

	// Token: 0x0600CE92 RID: 52882 RVA: 0x002F11EF File Offset: 0x002EF3EF
	static FloroRanchController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchController.CreateStaticDefaultValue), new Action(FloroRanchController.ResetStaticDefaultValue));
	}

	// Token: 0x04005E92 RID: 24210
	[Nullable(2)]
	private static FloroRanchController _Instance;
}
