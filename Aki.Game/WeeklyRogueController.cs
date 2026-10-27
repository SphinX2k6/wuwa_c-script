using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002D5C RID: 11612
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueController : ActivityControllerBase
{
	// Token: 0x0601868D RID: 99981 RVA: 0x00637010 File Offset: 0x00635210
	[NullableContext(1)]
	protected override void OnOpenView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueActivityView, EWeeklyRogueOpenWay.UI, null);
	}

	// Token: 0x0601868E RID: 99982 RVA: 0x00637028 File Offset: 0x00635228
	[NullableContext(1)]
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRogue21";
	}

	// Token: 0x0601868F RID: 99983 RVA: 0x0063702F File Offset: 0x0063522F
	[NullableContext(1)]
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new WeeklyRogueSubView();
	}

	// Token: 0x06018690 RID: 99984 RVA: 0x00637036 File Offset: 0x00635236
	[NullableContext(1)]
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new WeeklyRogueData();
	}

	// Token: 0x06018691 RID: 99985 RVA: 0x0063703D File Offset: 0x0063523D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		throw new SystemException("Method not implemented.");
	}

	// Token: 0x06018692 RID: 99986 RVA: 0x00637049 File Offset: 0x00635249
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		WeeklyRogueData activityDataNew = WeeklyRogueModel.Instance.ActivityDataNew;
		if (activityDataNew == null)
		{
			return;
		}
		activityDataNew.OnQuestStateChange(questId, state);
	}

	// Token: 0x06018693 RID: 99987 RVA: 0x00637064 File Offset: 0x00635264
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06018694 RID: 99988 RVA: 0x006370C8 File Offset: 0x006352C8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove<ENewLinkStatus>(EEventName.OnNewLinkStatusChanged, new Action<ENewLinkStatus>(this.OnNewLinkStatusChanged));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06018695 RID: 99989 RVA: 0x0063712C File Offset: 0x0063532C
	public void MarkAutoOpenDailyActivityWeekly()
	{
		bool isOpenedViewByWorld = WeeklyRogueModel.Instance.IsOpenedViewByWorld;
		WeeklyRogueModel.Instance.IsOpenedViewByWorld = false;
		this.IsNeedShowDailyActivityWeekly = !isOpenedViewByWorld;
	}

	// Token: 0x06018696 RID: 99990 RVA: 0x0063715C File Offset: 0x0063535C
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
			});
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06018697 RID: 99991 RVA: 0x006371AC File Offset: 0x006353AC
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

	// Token: 0x06018698 RID: 99992 RVA: 0x0063729C File Offset: 0x0063549C
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

	// Token: 0x06018699 RID: 99993 RVA: 0x0063732C File Offset: 0x0063552C
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

	// Token: 0x0601869A RID: 99994 RVA: 0x00637438 File Offset: 0x00635638
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

	// Token: 0x0601869B RID: 99995 RVA: 0x0063747C File Offset: 0x0063567C
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

	// Token: 0x0601869C RID: 99996 RVA: 0x00637504 File Offset: 0x00635704
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

	// Token: 0x0601869D RID: 99997 RVA: 0x0063759C File Offset: 0x0063579C
	private void OnRogueWeeklyResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyResultNotify param = (RogueWeeklyResultNotify)msg;
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueSettleView, param, null);
	}

	// Token: 0x0601869E RID: 99998 RVA: 0x006375C4 File Offset: 0x006357C4
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

	// Token: 0x0601869F RID: 99999 RVA: 0x00637678 File Offset: 0x00635878
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
			AvailableSilentArea = data.SilentAreaIds.ToList<int>(),
			FreeCount = WeeklyRogueModel.Instance.ActivityData.FreeCount,
			FreeMax = WeeklyRogueModel.Instance.ActivityData.FreeCountMax
		};
		UiManager.Instance.OpenView(EUiViewName.WeeklyRoguePhantomRewardView, param, null);
	}

	// Token: 0x060186A0 RID: 100000 RVA: 0x00637738 File Offset: 0x00635938
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

	// Token: 0x060186A1 RID: 100001 RVA: 0x00637800 File Offset: 0x00635A00
	private void OnRogueWeeklyInstInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		RogueWeeklyInstInfoNotify data = (RogueWeeklyInstInfoNotify)msg;
		WeeklyRogueModel.Instance.UpdateInstInfo(data);
		EventSystem.Instance.Emit(EEventName.WeeklyRogueInstDataUpdate);
	}

	// Token: 0x060186A2 RID: 100002 RVA: 0x00637830 File Offset: 0x00635A30
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyOptionSelectResponse.ErrorCode, 20557, rogueWeeklyOptionSelectResponse.ErrorParams.ToArray<string>(), true, true);
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

	// Token: 0x060186A3 RID: 100003 RVA: 0x00637894 File Offset: 0x00635A94
	[NullableContext(0)]
	public UniTask<bool> SelectArtifactRequest()
	{
		WeeklyRogueController.<SelectArtifactRequest>d__23 <SelectArtifactRequest>d__;
		<SelectArtifactRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SelectArtifactRequest>d__.<>1__state = -1;
		<SelectArtifactRequest>d__.<>t__builder.Start<WeeklyRogueController.<SelectArtifactRequest>d__23>(ref <SelectArtifactRequest>d__);
		return <SelectArtifactRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060186A4 RID: 100004 RVA: 0x006378D0 File Offset: 0x00635AD0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyResultResponse.ErrorCode, 25097, null, true, true);
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

	// Token: 0x060186A5 RID: 100005 RVA: 0x00637910 File Offset: 0x00635B10
	public UniTask GotoNextRoomRequest(bool confirmEnter = true)
	{
		WeeklyRogueController.<GotoNextRoomRequest>d__25 <GotoNextRoomRequest>d__;
		<GotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GotoNextRoomRequest>d__.confirmEnter = confirmEnter;
		<GotoNextRoomRequest>d__.<>1__state = -1;
		<GotoNextRoomRequest>d__.<>t__builder.Start<WeeklyRogueController.<GotoNextRoomRequest>d__25>(ref <GotoNextRoomRequest>d__);
		return <GotoNextRoomRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060186A6 RID: 100006 RVA: 0x00637954 File Offset: 0x00635B54
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyBlackFlowerResponse.ErrorCode, 18903, null, true, true);
				return;
			}
			if (isReceive)
			{
				WeeklyRogueModel.Instance.ActivityData.FreeCount = rogueWeeklyBlackFlowerResponse.MaxFreeCount - rogueWeeklyBlackFlowerResponse.UseFreeCount;
				WeeklyRogueModel.Instance.ActivityData.FreeCountMax = rogueWeeklyBlackFlowerResponse.MaxFreeCount;
			}
		}, 0);
	}

	// Token: 0x060186A7 RID: 100007 RVA: 0x006379B4 File Offset: 0x00635BB4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(rogueWeeklyStartResponse.ErrorCode, 26066, null, true, true);
				return;
			}
		}, 0);
	}

	// Token: 0x060186A8 RID: 100008 RVA: 0x00637A14 File Offset: 0x00635C14
	public UniTask RogueWeeklyArtifactSelectStartRequest()
	{
		WeeklyRogueController.<RogueWeeklyArtifactSelectStartRequest>d__28 <RogueWeeklyArtifactSelectStartRequest>d__;
		<RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RogueWeeklyArtifactSelectStartRequest>d__.<>1__state = -1;
		<RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder.Start<WeeklyRogueController.<RogueWeeklyArtifactSelectStartRequest>d__28>(ref <RogueWeeklyArtifactSelectStartRequest>d__);
		return <RogueWeeklyArtifactSelectStartRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060186A9 RID: 100009 RVA: 0x00637A50 File Offset: 0x00635C50
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulRogueWeeklyRewardResponse.ErrorCode, 28205, null, true, true);
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

	// Token: 0x060186AA RID: 100010 RVA: 0x00637B4C File Offset: 0x00635D4C
	public UniTask RogueWeeklyLastInfoRequest()
	{
		WeeklyRogueController.<RogueWeeklyLastInfoRequest>d__30 <RogueWeeklyLastInfoRequest>d__;
		<RogueWeeklyLastInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RogueWeeklyLastInfoRequest>d__.<>1__state = -1;
		<RogueWeeklyLastInfoRequest>d__.<>t__builder.Start<WeeklyRogueController.<RogueWeeklyLastInfoRequest>d__30>(ref <RogueWeeklyLastInfoRequest>d__);
		return <RogueWeeklyLastInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060186AB RID: 100011 RVA: 0x00637B88 File Offset: 0x00635D88
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

	// Token: 0x060186AC RID: 100012 RVA: 0x00637BD4 File Offset: 0x00635DD4
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

	// Token: 0x060186AD RID: 100013 RVA: 0x00637C47 File Offset: 0x00635E47
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

	// Token: 0x060186AE RID: 100014 RVA: 0x00637C68 File Offset: 0x00635E68
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

	// Token: 0x060186AF RID: 100015 RVA: 0x00637CD0 File Offset: 0x00635ED0
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

	// Token: 0x060186B0 RID: 100016 RVA: 0x00637E6C File Offset: 0x0063606C
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

	// Token: 0x170020E7 RID: 8423
	// (get) Token: 0x060186B1 RID: 100017 RVA: 0x00637F40 File Offset: 0x00636140
	[Nullable(1)]
	public static WeeklyRogueController Instance
	{
		[NullableContext(1)]
		get
		{
			return WeeklyRogueController._Instance;
		}
	}

	// Token: 0x060186B2 RID: 100018 RVA: 0x00637F47 File Offset: 0x00636147
	[NullableContext(1)]
	public static WeeklyRogueController GetOrCreateInstance()
	{
		if (WeeklyRogueController._Instance == null)
		{
			WeeklyRogueController.CreateInstance();
		}
		return WeeklyRogueController._Instance;
	}

	// Token: 0x060186B3 RID: 100019 RVA: 0x00637F5B File Offset: 0x0063615B
	public static bool CreateInstance()
	{
		if (WeeklyRogueController._Instance != null)
		{
			return true;
		}
		WeeklyRogueController._Instance = new WeeklyRogueController();
		return true;
	}

	// Token: 0x060186B4 RID: 100020 RVA: 0x00637F71 File Offset: 0x00636171
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060186B5 RID: 100021 RVA: 0x00637F73 File Offset: 0x00636173
	public static void ResetStaticDefaultValue()
	{
		WeeklyRogueController._Instance = null;
	}

	// Token: 0x060186B6 RID: 100022 RVA: 0x00637F7B File Offset: 0x0063617B
	static WeeklyRogueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyRogueController.CreateStaticDefaultValue), new Action(WeeklyRogueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B506 RID: 46342
	public bool IsNeedShowDailyActivityWeekly;

	// Token: 0x0400B507 RID: 46343
	public ENewLinkStage NewLinkStage;

	// Token: 0x0400B508 RID: 46344
	private List<long> CurrentLinkBurstBuffs;

	// Token: 0x0400B509 RID: 46345
	private static WeeklyRogueController _Instance;
}
