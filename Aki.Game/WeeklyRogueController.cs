using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020022B6 RID: 8886
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueController : ActivityControllerBase
{
	// Token: 0x06015F2F RID: 89903 RVA: 0x0065D020 File Offset: 0x0065B220
	[NullableContext(1)]
	protected override void OnOpenView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueActivityView, EWeeklyRogueOpenWay.UI, null);
	}

	// Token: 0x06015F30 RID: 89904 RVA: 0x0065D038 File Offset: 0x0065B238
	[NullableContext(1)]
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRogue21";
	}

	// Token: 0x06015F31 RID: 89905 RVA: 0x0065D03F File Offset: 0x0065B23F
	[NullableContext(1)]
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new WeeklyRogueSubView();
	}

	// Token: 0x06015F32 RID: 89906 RVA: 0x0065D046 File Offset: 0x0065B246
	[NullableContext(1)]
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new WeeklyRogueData();
	}

	// Token: 0x06015F33 RID: 89907 RVA: 0x0065D04D File Offset: 0x0065B24D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		throw new SystemException("Method not implemented.");
	}

	// Token: 0x06015F34 RID: 89908 RVA: 0x0065D059 File Offset: 0x0065B259
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		if (activityDataNew == null)
		{
			return;
		}
		activityDataNew.OnQuestStateChange(questId, state);
	}

	// Token: 0x06015F35 RID: 89909 RVA: 0x0065D074 File Offset: 0x0065B274
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06015F36 RID: 89910 RVA: 0x0065D0D8 File Offset: 0x0065B2D8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06015F37 RID: 89911 RVA: 0x0065D13C File Offset: 0x0065B33C
	public void MarkAutoOpenDailyActivityWeekly()
	{
		bool isOpenedViewByWorld = WeeklyRogueModel.Instance.IsOpenedViewByWorld;
		WeeklyRogueModel.Instance.IsOpenedViewByWorld = false;
		this.IsNeedShowDailyActivityWeekly = !isOpenedViewByWorld;
	}

	// Token: 0x06015F38 RID: 89912 RVA: 0x0065D16C File Offset: 0x0065B36C
	private void OnWorldDone()
	{
		if (!this.IsNeedShowDailyActivityWeekly)
		{
			return;
		}
		this.IsNeedShowDailyActivityWeekly = false;
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.DailyActivityTabView), new int?(2), delegate(bool success, int _)
			{
				SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
			}, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06015F39 RID: 89913 RVA: 0x0065D1BC File Offset: 0x0065B3BC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyRoomInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyRoomInfoNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyResultNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklySubLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklySubLevelNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyInstInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyInstInfoNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyBlackFlowerNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyBlackFlowerNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyCurrencyNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyCurrencyNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyCurrencyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyCurrencyUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RogueWeeklyInteractionResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueWeeklyInteractionResultNotify));
	}

	// Token: 0x06015F3A RID: 89914 RVA: 0x0065D2AC File Offset: 0x0065B4AC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyRoomInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklySubLevelNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyInstInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyBlackFlowerNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyCurrencyNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyCurrencyUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RogueWeeklyInteractionResultNotify);
	}

	// Token: 0x06015F3B RID: 89915 RVA: 0x0065D33C File Offset: 0x0065B53C
	private void OnRogueWeeklyRoomInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyRoomInfoNotify rogueWeeklyRoomInfoNotify = (RogueWeeklyRoomInfoNotify)msg;
		WeeklyRogueModel.Instance.CurrentLayer = rogueWeeklyRoomInfoNotify.CurLayer;
		WeeklyRogueModel.Instance.MaxLayer = rogueWeeklyRoomInfoNotify.MaxLayer;
		RogueWeeklyRoomPool? roomPoolConfig = WeeklyRogueConfig.Instance.GetRoomPoolConfig(rogueWeeklyRoomInfoNotify.RoguelikeRoomId);
		Aki.Config.RogueWeeklyRoomType value = WeeklyRogueConfig.Instance.GetRogueWeeklyRoomType(rogueWeeklyRoomInfoNotify.RoguelikeRoomTypeId).Value;
		WeeklyRogueModel.Instance.CurrentRoomTypeId = value.RoomType;
		WeeklyRogueModel.Instance.CurrentRoomId = rogueWeeklyRoomInfoNotify.RoguelikeRoomId;
		WeeklyRogueModel.Instance.CurrentScore = rogueWeeklyRoomInfoNotify.Score;
		if (!StringUtils.IsEmpty((roomPoolConfig != null) ? roomPoolConfig.GetValueOrDefault().RoomsMusicState : null))
		{
			WeeklyRogueModel.Instance.CurrentRoomMusicState = roomPoolConfig.Value.RoomsMusicState;
		}
		else
		{
			WeeklyRogueModel.Instance.CurrentRoomMusicState = value.RoomsMusicState;
		}
		if (rogueWeeklyRoomInfoNotify.SkyBoxId != 0)
		{
			WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(rogueWeeklyRoomInfoNotify.SkyBoxId, 0f);
			return;
		}
		WeatherController.Instance.StopWeather();
	}

	// Token: 0x06015F3C RID: 89916 RVA: 0x0065D448 File Offset: 0x0065B648
	private void OnRogueWeeklyInteractionResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyInteractionResultNotify rogueWeeklyInteractionResultNotify = (RogueWeeklyInteractionResultNotify)msg;
		WeeklyRogueResultCheckData param = new WeeklyRogueResultCheckData
		{
			CurrentInGameScore = rogueWeeklyInteractionResultNotify.CurScore,
			MaxInGameScore = rogueWeeklyInteractionResultNotify.MaxScore
		};
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueResultCheckView, param, null);
	}

	// Token: 0x06015F3D RID: 89917 RVA: 0x0065D48C File Offset: 0x0065B68C
	private void OnRogueWeeklyCurrencyNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyCurrencyNotify rogueWeeklyCurrencyNotify = (RogueWeeklyCurrencyNotify)msg;
		WeeklyRogueModel.Instance.CurrencyDictMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in rogueWeeklyCurrencyNotify.CurrencyDict)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			WeeklyRogueModel.Instance.SetCurrency(key, value);
			EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, key);
		}
	}

	// Token: 0x06015F3E RID: 89918 RVA: 0x0065D514 File Offset: 0x0065B714
	private void OnRogueWeeklyCurrencyUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (KeyValuePair<int, int> keyValuePair in ((RogueWeeklyCurrencyUpdateNotify)msg).CurrencyDict)
		{
			int key = keyValuePair.Key;
			int currency = WeeklyRogueModel.Instance.GetCurrency(key);
			int value = keyValuePair.Value;
			int count = currency + value;
			if (value > 0)
			{
				ItemHintController.Instance.AddRoguelikeItemList(key, value);
			}
			WeeklyRogueModel.Instance.SetCurrency(key, count);
			EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, key);
		}
	}

	// Token: 0x06015F3F RID: 89919 RVA: 0x0065D5AC File Offset: 0x0065B7AC
	private void OnRogueWeeklyResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyResultNotify param = (RogueWeeklyResultNotify)msg;
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueSettleView, param, null);
	}

	// Token: 0x06015F40 RID: 89920 RVA: 0x0065D5D4 File Offset: 0x0065B7D4
	private void OnRogueWeeklySubLevelNotify(IMessage msg, Net.CallbackStatus status)
	{
		WeeklyRogueController.<>c__DisplayClass18_0 CS$<>8__locals1 = new WeeklyRogueController.<>c__DisplayClass18_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.notify = (RogueWeeklySubLevelNotify)msg;
		Action cancelFunc = delegate()
		{
			CS$<>8__locals1.<>4__this.GotoNextRoomRequest(false).Forget();
		};
		Action action = delegate()
		{
			string name = "WeeklyRoguelikeSubLevelChangeTask";
			Func<UniTask<bool>> runHandle;
			if ((runHandle = CS$<>8__locals1.<>9__2) == null)
			{
				runHandle = (CS$<>8__locals1.<>9__2 = delegate()
				{
					WeeklyRogueController.<>c__DisplayClass18_0.<<OnRogueWeeklySubLevelNotify>b__2>d <<OnRogueWeeklySubLevelNotify>b__2>d;
					<<OnRogueWeeklySubLevelNotify>b__2>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
					<<OnRogueWeeklySubLevelNotify>b__2>d.<>4__this = CS$<>8__locals1;
					<<OnRogueWeeklySubLevelNotify>b__2>d.<>1__state = -1;
					<<OnRogueWeeklySubLevelNotify>b__2>d.<>t__builder.Start<WeeklyRogueController.<>c__DisplayClass18_0.<<OnRogueWeeklySubLevelNotify>b__2>d>(ref <<OnRogueWeeklySubLevelNotify>b__2>d);
					return <<OnRogueWeeklySubLevelNotify>b__2>d.<>t__builder.Task;
				});
			}
			AsyncTask task = new AsyncTask(name, runHandle, null, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run().Forget<bool>();
		};
		if (CS$<>8__locals1.notify.IsExtra && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.WeeklyRogueExtraEnterTips, true))
		{
			ExtraRoomTipsData param = new ExtraRoomTipsData
			{
				CurScore = CS$<>8__locals1.notify.CurScore,
				MaxScore = CS$<>8__locals1.notify.MaxScore,
				ConfirmFunc = action,
				CancelFunc = cancelFunc
			};
			UiManager.Instance.OpenView(EUiViewName.WeeklyRogueExtraRoomConfirmView, param, null);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.WeeklyRogueExtraEnterTips, false);
			return;
		}
		action();
	}

	// Token: 0x06015F41 RID: 89921 RVA: 0x0065D688 File Offset: 0x0065B888
	private void OnRogueWeeklyBlackFlowerNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyBlackFlowerNotify data = (RogueWeeklyBlackFlowerNotify)msg;
		int cycleBlackFlowerCost = WeeklyRogueModel.Instance.ActivityData.GetCycleBlackFlowerCost();
		bool isReceive = false;
		WeeklyRogueRewardPopViewData param = new WeeklyRogueRewardPopViewData
		{
			SinglePowerCost = cycleBlackFlowerCost,
			RewardCallBack = delegate(int count, int silentId)
			{
				isReceive = true;
				this.BlackFlowerRewardRequest(data.EntityConfigId, true, count == 2, silentId);
			},
			CloseCallBack = delegate
			{
				if (!isReceive)
				{
					this.BlackFlowerRewardRequest(data.EntityConfigId, false, false, -1);
				}
			},
			AvailableSilentArea = new List<int>(data.SilentAreaIds),
			FreeCount = WeeklyRogueModel.Instance.ActivityData.FreeCount,
			FreeMax = WeeklyRogueModel.Instance.ActivityData.FreeCountMax
		};
		UiManager.Instance.OpenView(EUiViewName.WeeklyRoguePhantomRewardView, param, null);
	}

	// Token: 0x06015F42 RID: 89922 RVA: 0x0065D748 File Offset: 0x0065B948
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1
	})]
	private ValueTuple<string[], string[]> FilterSameSubLevel(RogueWeeklySubLevelNotify notify)
	{
		List<string> list = new List<string>();
		foreach (string item in notify.UnLoadSubLevels)
		{
			if (notify.LoadSubLevels.IndexOf(item) < 0)
			{
				list.Add(item);
			}
		}
		List<string> list2 = new List<string>();
		foreach (string item2 in notify.LoadSubLevels)
		{
			if (notify.UnLoadSubLevels.IndexOf(item2) < 0)
			{
				list2.Add(item2);
			}
		}
		return new ValueTuple<string[], string[]>(list.ToArray(), list2.ToArray());
	}

	// Token: 0x06015F43 RID: 89923 RVA: 0x0065D810 File Offset: 0x0065BA10
	private void OnRogueWeeklyInstInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyInstInfoNotify data = (RogueWeeklyInstInfoNotify)msg;
		WeeklyRogueModel.Instance.UpdateInstInfo(data);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueInstDataUpdate);
	}

	// Token: 0x06015F44 RID: 89924 RVA: 0x0065D840 File Offset: 0x0065BA40
	public void SelectOptionRequest(Action<bool> callback = null)
	{
		RogueWeeklyOptionSelectRequest rogueWeeklyOptionSelectRequest = RogueWeeklyOptionSelectRequest.Create();
		rogueWeeklyOptionSelectRequest.BindId = WeeklyRogueModel.Instance.CurrentBindId;
		rogueWeeklyOptionSelectRequest.Index = WeeklyRogueModel.Instance.SelectEntry.Index;
		Net.Instance.Call(ERequestMessageId.RogueWeeklyOptionSelectRequest, rogueWeeklyOptionSelectRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RogueWeeklyOptionSelectResponse rogueWeeklyOptionSelectResponse = (RogueWeeklyOptionSelectResponse)msg;
			if (rogueWeeklyOptionSelectResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (rogueWeeklyOptionSelectResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyOptionSelectResponse.ErrorCode, 19544, rogueWeeklyOptionSelectResponse.ErrorParams, true, true);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else
			{
				EventSystem.Instance.Emit(EEventName.WeeklyRogueSelectOption);
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(true);
				return;
			}
		}, 0);
	}

	// Token: 0x06015F45 RID: 89925 RVA: 0x0065D8A4 File Offset: 0x0065BAA4
	[NullableContext(0)]
	public UniTask<bool> SelectArtifactRequest()
	{
		WeeklyRogueController.<SelectArtifactRequest>d__23 <SelectArtifactRequest>d__;
		<SelectArtifactRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SelectArtifactRequest>d__.<>1__state = -1;
		<SelectArtifactRequest>d__.<>t__builder.Start<WeeklyRogueController.<SelectArtifactRequest>d__23>(ref <SelectArtifactRequest>d__);
		return <SelectArtifactRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06015F46 RID: 89926 RVA: 0x0065D8E0 File Offset: 0x0065BAE0
	public void InstanceSettleRequest(Action<bool> callback = null)
	{
		RogueWeeklyResultRequest message = RogueWeeklyResultRequest.Create();
		Net.Instance.Call(ERequestMessageId.RogueWeeklyResultRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RogueWeeklyResultResponse rogueWeeklyResultResponse = (RogueWeeklyResultResponse)msg;
			if (rogueWeeklyResultResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (rogueWeeklyResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyResultResponse.ErrorCode, 28144, null, true, true);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else
			{
				if (WeeklyRogueModel.Instance.HasLastInfo())
				{
					WeeklyRogueModel.Instance.ActivityData.LastInstInfo = null;
				}
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(true);
				return;
			}
		}, 0);
	}

	// Token: 0x06015F47 RID: 89927 RVA: 0x0065D920 File Offset: 0x0065BB20
	public UniTask GotoNextRoomRequest(bool confirmEnter = true)
	{
		WeeklyRogueController.<GotoNextRoomRequest>d__25 <GotoNextRoomRequest>d__;
		<GotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GotoNextRoomRequest>d__.confirmEnter = confirmEnter;
		<GotoNextRoomRequest>d__.<>1__state = -1;
		<GotoNextRoomRequest>d__.<>t__builder.Start<WeeklyRogueController.<GotoNextRoomRequest>d__25>(ref <GotoNextRoomRequest>d__);
		return <GotoNextRoomRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06015F48 RID: 89928 RVA: 0x0065D964 File Offset: 0x0065BB64
	public void BlackFlowerRewardRequest(int entityId, bool isReceive, bool isDouble, int areaId)
	{
		RogueWeeklyBlackFlowerRequest rogueWeeklyBlackFlowerRequest = RogueWeeklyBlackFlowerRequest.Create();
		rogueWeeklyBlackFlowerRequest.EntityConfigId = entityId;
		rogueWeeklyBlackFlowerRequest.IsDouble = isDouble;
		rogueWeeklyBlackFlowerRequest.Ret = isReceive;
		rogueWeeklyBlackFlowerRequest.SilentAreaId = areaId;
		Net.Instance.Call(ERequestMessageId.RogueWeeklyBlackFlowerRequest, rogueWeeklyBlackFlowerRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RogueWeeklyBlackFlowerResponse rogueWeeklyBlackFlowerResponse = (RogueWeeklyBlackFlowerResponse)msg;
			if (rogueWeeklyBlackFlowerResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyBlackFlowerResponse.ErrorCode, 21004, null, true, true);
				return;
			}
			if (isReceive)
			{
				WeeklyRogueModel.Instance.ActivityData.FreeCount = rogueWeeklyBlackFlowerResponse.MaxFreeCount - rogueWeeklyBlackFlowerResponse.UseFreeCount;
				WeeklyRogueModel.Instance.ActivityData.FreeCountMax = rogueWeeklyBlackFlowerResponse.MaxFreeCount;
			}
		}, 0);
	}

	// Token: 0x06015F49 RID: 89929 RVA: 0x0065D9C4 File Offset: 0x0065BBC4
	[NullableContext(1)]
	public void RogueWeeklyStartRequest(List<int> roleList)
	{
		RogueWeeklyStartRequest rogueWeeklyStartRequest = Aki.Protocol.RogueWeeklyStartRequest.Create();
		rogueWeeklyStartRequest.CycleId = WeeklyRogueModel.Instance.CycleId;
		rogueWeeklyStartRequest.Roles.AddRange(roleList);
		Net.Instance.Call(ERequestMessageId.RogueWeeklyStartRequest, rogueWeeklyStartRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			RogueWeeklyStartResponse rogueWeeklyStartResponse = (RogueWeeklyStartResponse)msg;
			if (rogueWeeklyStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyStartResponse.ErrorCode, 28012, null, true, true);
				return;
			}
		}, 0);
	}

	// Token: 0x06015F4A RID: 89930 RVA: 0x0065DA24 File Offset: 0x0065BC24
	public UniTask RogueWeeklyArtifactSelectStartRequest()
	{
		WeeklyRogueController.<RogueWeeklyArtifactSelectStartRequest>d__28 <RogueWeeklyArtifactSelectStartRequest>d__;
		<RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RogueWeeklyArtifactSelectStartRequest>d__.<>1__state = -1;
		<RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder.Start<WeeklyRogueController.<RogueWeeklyArtifactSelectStartRequest>d__28>(ref <RogueWeeklyArtifactSelectStartRequest>d__);
		return <RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06015F4B RID: 89931 RVA: 0x0065DA60 File Offset: 0x0065BC60
	public void MultiRogueWeeklyRewardRequest()
	{
		MulRogueWeeklyRewardRequest mulRogueWeeklyRewardRequest = MulRogueWeeklyRewardRequest.Create();
		mulRogueWeeklyRewardRequest.ActivityId = WeeklyRogueModel.Instance.ActivityData.Id;
		List<IActivityRewardData> dataList = WeeklyRogueModel.Instance.GetScoreRewardData().DataPageList[0].DataList;
		List<int> configIds = new List<int>();
		foreach (IActivityRewardData activityRewardData in dataList)
		{
			if (activityRewardData.RewardState == EActivityRewardState.Enable && activityRewardData.Id != null)
			{
				configIds.Add(activityRewardData.Id.Value);
			}
		}
		if (configIds.Count == 0)
		{
			return;
		}
		mulRogueWeeklyRewardRequest.ConfigId.AddRange(configIds);
		Net.Instance.Call(ERequestMessageId.MulRogueWeeklyRewardRequest, mulRogueWeeklyRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			MulRogueWeeklyRewardResponse mulRogueWeeklyRewardResponse = (MulRogueWeeklyRewardResponse)msg;
			if (mulRogueWeeklyRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulRogueWeeklyRewardResponse.ErrorCode, 16599, null, true, true);
				return;
			}
			foreach (int id in configIds)
			{
				WeeklyRogueModel.Instance.ActivityData.SetScoreRewardState(id, SignState.IsReceive);
			}
			EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, WeeklyRogueModel.Instance.GetScoreRewardData());
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, WeeklyRogueModel.Instance.ActivityData.Id);
			EventSystem.Instance.Emit(EEventName.WeeklyRogueRedDotInfoRefresh);
		}, 0);
	}

	// Token: 0x06015F4C RID: 89932 RVA: 0x0065DB5C File Offset: 0x0065BD5C
	public UniTask RogueWeeklyLastInfoRequest()
	{
		WeeklyRogueController.<RogueWeeklyLastInfoRequest>d__30 <RogueWeeklyLastInfoRequest>d__;
		<RogueWeeklyLastInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RogueWeeklyLastInfoRequest>d__.<>1__state = -1;
		<RogueWeeklyLastInfoRequest>d__.<>t__builder.Start<WeeklyRogueController.<RogueWeeklyLastInfoRequest>d__30>(ref <RogueWeeklyLastInfoRequest>d__);
		return <RogueWeeklyLastInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06015F4D RID: 89933 RVA: 0x0065DB98 File Offset: 0x0065BD98
	[NullableContext(0)]
	public UniTask<bool> OpenTokenSelectViewById(int boardId)
	{
		WeeklyRogueController.<OpenTokenSelectViewById>d__31 <OpenTokenSelectViewById>d__;
		<OpenTokenSelectViewById>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTokenSelectViewById>d__.<>4__this = this;
		<OpenTokenSelectViewById>d__.boardId = boardId;
		<OpenTokenSelectViewById>d__.<>1__state = -1;
		<OpenTokenSelectViewById>d__.<>t__builder.Start<WeeklyRogueController.<OpenTokenSelectViewById>d__31>(ref <OpenTokenSelectViewById>d__);
		return <OpenTokenSelectViewById>d__.<>t__builder.Task;
	}

	// Token: 0x06015F4E RID: 89934 RVA: 0x0065DBE4 File Offset: 0x0065BDE4
	public EUiViewName? GetViewNameByType(RogueWeeklyEntryType optionType)
	{
		if (optionType == RogueWeeklyEntryType.Unknow)
		{
			return null;
		}
		if (optionType == RogueWeeklyEntryType.Goods)
		{
			return new EUiViewName?(EUiViewName.WeeklyRogueShop);
		}
		if (optionType != RogueWeeklyEntryType.CommonBuff)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "未知选项类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("optionType", optionType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new EUiViewName?(EUiViewName.WeeklyRogueSelectToken);
	}

	// Token: 0x06015F4F RID: 89935 RVA: 0x0065DC57 File Offset: 0x0065BE57
	private void OnNewLinkStatusChanged(ENewLinkStatus stage)
	{
		this.NewLinkStage = (ENewLinkStage)stage;
		if (this.NewLinkStage == ENewLinkStage.Burst)
		{
			this.AddLinkBuffAndBullet();
			return;
		}
		this.ClearLinkBurstBuffs();
	}

	// Token: 0x06015F50 RID: 89936 RVA: 0x0065DC78 File Offset: 0x0065BE78
	public bool RequestNewLinkBurst()
	{
		if (this.NewLinkStage != ENewLinkStage.Ready)
		{
			return false;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			return false;
		}
		CombatNet.Instance.Send(EPushMessageId.NewLinkBurstPush, worldEntity, NewLinkBurstPush.Create(), null, null, null);
		return true;
	}

	// Token: 0x06015F51 RID: 89937 RVA: 0x0065DCE0 File Offset: 0x0065BEE0
	private void AddLinkBuffAndBullet()
	{
		if (!WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
		{
			return;
		}
		WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
		CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
		RogueWeeklyCycle? cycleConfig = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig();
		int? num = (cycleConfig != null) ? new int?(cycleConfig.GetValueOrDefault().LinkId) : null;
		if (num == null)
		{
			return;
		}
		BattleLinkConfig instance = BattleLinkConfig.Instance;
		LinkData? linkData = (instance != null) ? instance.GetLinkDataConfig(num.Value) : null;
		if (linkData == null)
		{
			return;
		}
		long? messageId = BattleLinkController.Instance.GetMessageId();
		if (messageId == null)
		{
			return;
		}
		long value = MathUtils.Instance.LongToBigInt(messageId.Value);
		foreach (long num2 in linkData.Value.BuffIdsInBrust())
		{
			component.AddBuff(num2, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				Reason = "周常肉鸽link增加buff",
				PreMessageId = new long?(value)
			});
			if (this.CurrentLinkBurstBuffs == null)
			{
				this.CurrentLinkBurstBuffs = new List<long>();
			}
			this.CurrentLinkBurstBuffs.Add(num2);
		}
		foreach (long num3 in linkData.Value.BulletIdsInBrust())
		{
			BulletController.Instance.CreateBulletCustomTarget(entity, num3.ToString(), null, null, new long?(value), global::EBulletCreateSource.Others);
		}
	}

	// Token: 0x06015F52 RID: 89938 RVA: 0x0065DE7C File Offset: 0x0065C07C
	private void ClearLinkBurstBuffs()
	{
		if (this.CurrentLinkBurstBuffs == null || this.CurrentLinkBurstBuffs.Count == 0)
		{
			return;
		}
		if (!WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
		{
			this.CurrentLinkBurstBuffs.Clear();
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		CharacterBuffComponent characterBuffComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent != null)
		{
			foreach (long buffId in this.CurrentLinkBurstBuffs)
			{
				characterBuffComponent.RemoveBuff(buffId, -1, "周常肉鸽离开Link爆发状态", null, null, null);
			}
		}
		this.CurrentLinkBurstBuffs.Clear();
	}

	// Token: 0x17002142 RID: 8514
	// (get) Token: 0x06015F53 RID: 89939 RVA: 0x0065DF50 File Offset: 0x0065C150
	[Nullable(1)]
	public static WeeklyRogueController Instance
	{
		[NullableContext(1)]
		get
		{
			return WeeklyRogueController._Instance;
		}
	}

	// Token: 0x06015F54 RID: 89940 RVA: 0x0065DF57 File Offset: 0x0065C157
	[NullableContext(1)]
	public static WeeklyRogueController GetOrCreateInstance()
	{
		if (WeeklyRogueController._Instance == null)
		{
			WeeklyRogueController.CreateInstance();
		}
		return WeeklyRogueController._Instance;
	}

	// Token: 0x06015F55 RID: 89941 RVA: 0x0065DF6B File Offset: 0x0065C16B
	public static bool CreateInstance()
	{
		if (WeeklyRogueController._Instance != null)
		{
			return true;
		}
		WeeklyRogueController._Instance = new WeeklyRogueController();
		return true;
	}

	// Token: 0x06015F56 RID: 89942 RVA: 0x0065DF81 File Offset: 0x0065C181
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015F57 RID: 89943 RVA: 0x0065DF83 File Offset: 0x0065C183
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueController._Instance = null;
	}

	// Token: 0x06015F58 RID: 89944 RVA: 0x0065DF8B File Offset: 0x0065C18B
	static WeeklyRogueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueController.CreateStaticDefaultValue), new Action(WeeklyRogueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B87B RID: 47227
	public bool IsNeedShowDailyActivityWeekly;

	// Token: 0x0400B87C RID: 47228
	public ENewLinkStage NewLinkStage;

	// Token: 0x0400B87D RID: 47229
	private List<long> CurrentLinkBurstBuffs;

	// Token: 0x0400B87E RID: 47230
	private static WeeklyRogueController _Instance;
}
