using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020012CB RID: 4811
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMapTravelController : ActivityControllerBase
{
	// Token: 0x0600845D RID: 33885 RVA: 0x001C2B67 File Offset: 0x001C0D67
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MapTravelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMapTravelInfoUpdateNotify));
	}

	// Token: 0x0600845E RID: 33886 RVA: 0x001C2B85 File Offset: 0x001C0D85
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MapTravelInfoUpdateNotify);
	}

	// Token: 0x0600845F RID: 33887 RVA: 0x001C2B97 File Offset: 0x001C0D97
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06008460 RID: 33888 RVA: 0x001C2BD1 File Offset: 0x001C0DD1
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06008461 RID: 33889 RVA: 0x001C2C0B File Offset: 0x001C0E0B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TravelMapSubView";
	}

	// Token: 0x06008462 RID: 33890 RVA: 0x001C2C14 File Offset: 0x001C0E14
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		ActivityMapTravelData mapTravelData = this.GetMapTravelData();
		if (mapTravelData == null)
		{
			return;
		}
		if (mapTravelData.PhantomQuestIds.Contains(questId))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
		}
	}

	// Token: 0x06008463 RID: 33891 RVA: 0x001C2C50 File Offset: 0x001C0E50
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		ActivityMapTravelData mapTravelData = this.GetMapTravelData();
		if (mapTravelData == null)
		{
			return;
		}
		if (mapTravelData.GetActivityConfig().ExpItemId != configId)
		{
			return;
		}
		if (mapTravelData.CanTravelLevelUp())
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
		}
		this.TryOpenLevelTipsView(mapTravelData);
	}

	// Token: 0x06008464 RID: 33892 RVA: 0x001C2C9F File Offset: 0x001C0E9F
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008465 RID: 33893 RVA: 0x001C2CA1 File Offset: 0x001C0EA1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMapTravel();
	}

	// Token: 0x06008466 RID: 33894 RVA: 0x001C2CA8 File Offset: 0x001C0EA8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityMapTravelData();
	}

	// Token: 0x06008467 RID: 33895 RVA: 0x001C2CAF File Offset: 0x001C0EAF
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008468 RID: 33896 RVA: 0x001C2CB4 File Offset: 0x001C0EB4
	[NullableContext(2)]
	public ActivityMapTravelData GetMapTravelData()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(32);
		ActivityMapTravelData result = null;
		if (currentActivitiesByType.Count > 0)
		{
			result = (currentActivitiesByType[0] as ActivityMapTravelData);
		}
		return result;
	}

	// Token: 0x06008469 RID: 33897 RVA: 0x001C2CE8 File Offset: 0x001C0EE8
	[NullableContext(2)]
	private void OnMapTravelInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		MapTravelInfoUpdateNotify mapTravelInfoUpdateNotify = (MapTravelInfoUpdateNotify)msg;
		ActivityMapTravelData mapTravelData = this.GetMapTravelData();
		if (mapTravelData == null)
		{
			return;
		}
		if (mapTravelInfoUpdateNotify.ActivityTask != null)
		{
			mapTravelData.RefreshTravelTaskData(mapTravelInfoUpdateNotify.ActivityTask);
		}
		if (mapTravelInfoUpdateNotify.SoarLevel != null)
		{
			mapTravelData.RefreshSoarChallengePlayData(mapTravelInfoUpdateNotify.SoarLevel);
			GeneralLogicTreeModel.Instance.HistorySoarScore = mapTravelInfoUpdateNotify.SoarLevel.HistorySoarScore;
		}
		if (mapTravelInfoUpdateNotify.HasUnLockArea)
		{
			mapTravelData.UnlockAreaData(mapTravelInfoUpdateNotify.UnLockArea);
		}
		if (mapTravelInfoUpdateNotify.HasUnLockMonsterId)
		{
			mapTravelData.UnlockPhantom(mapTravelInfoUpdateNotify.UnLockMonsterId);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
	}

	// Token: 0x0600846A RID: 33898 RVA: 0x001C2D84 File Offset: 0x001C0F84
	public void RequestMapTravelLevelUp(Action<bool> callback = null)
	{
		MapTravelLevelUpRequest message = MapTravelLevelUpRequest.Create();
		Net.Instance.Call(ERequestMessageId.MapTravelLevelUpRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			MapTravelLevelUpResponse mapTravelLevelUpResponse = (MapTravelLevelUpResponse)msg;
			if (mapTravelLevelUpResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (mapTravelLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mapTravelLevelUpResponse.ErrorCode, 29440, null, true, true);
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
				ActivityMapTravelData mapTravelData = this.GetMapTravelData();
				if (mapTravelData != null)
				{
					mapTravelData.TravelLevel++;
					Action<bool> callback4 = callback;
					if (callback4 != null)
					{
						callback4(true);
					}
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
					this.TryOpenLevelTipsView(mapTravelData);
					return;
				}
				Action<bool> callback5 = callback;
				if (callback5 == null)
				{
					return;
				}
				callback5(false);
				return;
			}
		}, 0);
	}

	// Token: 0x0600846B RID: 33899 RVA: 0x001C2DC8 File Offset: 0x001C0FC8
	public void RequestMultiMapTravelTaskReward(List<int> ids)
	{
		MulMapTravelTaskRewardRequest mulMapTravelTaskRewardRequest = MulMapTravelTaskRewardRequest.Create();
		mulMapTravelTaskRewardRequest.TaskId.AddRange(ids);
		Net.Instance.Call(ERequestMessageId.MulMapTravelTaskRewardRequest, mulMapTravelTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			MulMapTravelTaskRewardResponse mulMapTravelTaskRewardResponse = (MulMapTravelTaskRewardResponse)msg;
			if (mulMapTravelTaskRewardResponse == null)
			{
				return;
			}
			if (mulMapTravelTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulMapTravelTaskRewardResponse.ErrorCode, 22477, null, true, true);
				return;
			}
			ActivityMapTravelData mapTravelData = this.GetMapTravelData();
			if (mapTravelData == null)
			{
				return;
			}
			foreach (int travelTaskDataDone in ids)
			{
				mapTravelData.SetTravelTaskDataDone(travelTaskDataDone);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
			EventSystem.Instance.Emit(EEventName.MapTravelTaskRefresh);
		}, 0);
	}

	// Token: 0x0600846C RID: 33900 RVA: 0x001C2E20 File Offset: 0x001C1020
	public void RequestTakeTaskFinalReward()
	{
		MapTravelFullRewardRequest message = MapTravelFullRewardRequest.Create();
		Net.Instance.Call(ERequestMessageId.MapTravelFullRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus status)
		{
			MapTravelFullRewardResponse mapTravelFullRewardResponse = (MapTravelFullRewardResponse)msg;
			if (mapTravelFullRewardResponse == null)
			{
				return;
			}
			if (mapTravelFullRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mapTravelFullRewardResponse.ErrorCode, 18919, null, true, true);
				return;
			}
			ActivityMapTravelData mapTravelData = this.GetMapTravelData();
			if (mapTravelData == null)
			{
				return;
			}
			mapTravelData.TaskFinalRewardData.IsReceived = true;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
			EventSystem.Instance.Emit(EEventName.MapTravelTaskRefresh);
		}, 0);
	}

	// Token: 0x0600846D RID: 33901 RVA: 0x001C2E50 File Offset: 0x001C1050
	public void RequestMultiTakeSoarChallengeReward(List<int> rewardIds)
	{
		MulMapTravelSoarRewardRequest mulMapTravelSoarRewardRequest = MulMapTravelSoarRewardRequest.Create();
		mulMapTravelSoarRewardRequest.TaskIds.AddRange(rewardIds);
		Net.Instance.Call(ERequestMessageId.MulMapTravelSoarRewardRequest, mulMapTravelSoarRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			MulMapTravelSoarRewardResponse mulMapTravelSoarRewardResponse = (MulMapTravelSoarRewardResponse)msg;
			if (mulMapTravelSoarRewardResponse == null)
			{
				return;
			}
			if (mulMapTravelSoarRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulMapTravelSoarRewardResponse.ErrorCode, 28256, null, true, true);
				return;
			}
			ActivityMapTravelData mapTravelData = this.GetMapTravelData();
			if (mapTravelData == null)
			{
				return;
			}
			foreach (int soarChallengeRewardDone in rewardIds)
			{
				mapTravelData.SetSoarChallengeRewardDone(soarChallengeRewardDone);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, mapTravelData.Id);
			EventSystem.Instance.Emit(EEventName.MapTravelSoarRefresh);
		}, 0);
	}

	// Token: 0x0600846E RID: 33902 RVA: 0x001C2EA5 File Offset: 0x001C10A5
	private void TryOpenLevelTipsView(ActivityMapTravelData data)
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.TravelLevelTipsView))
		{
			UiManager.Instance.OpenView(EUiViewName.TravelLevelTipsView, data, null);
		}
	}

	// Token: 0x0600846F RID: 33903 RVA: 0x001C2EC9 File Offset: 0x001C10C9
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipMapTravelView, null, null);
	}

	// Token: 0x06008470 RID: 33904 RVA: 0x001C2EDC File Offset: 0x001C10DC
	public void OpenSoarStrengthView(float changeValue)
	{
		float baseMax = FormationAttributeController.Instance.GetBaseMax(EFormationAttributeId.SoarStrength);
		FormationProperty? config = ConfigFormationPropertyById.GetConfig(10, true);
		AttributeInfo item = new AttributeInfo
		{
			Name = config.Value.Name,
			IconPath = config.Value.Icon,
			ShowArrow = new bool?(true),
			PreText = Math.Floor((double)(baseMax - changeValue) / 100.0).ToString(),
			CurText = Math.Floor((double)baseMax / 100.0).ToString()
		};
		LevelUpSuccessAttributeData data = new LevelUpSuccessAttributeData
		{
			Title = "Flying_EnergyUp",
			StrengthUpgradeData = new StrengthUpgradeData
			{
				AttributeId = EFormationAttributeId.SoarStrength,
				SingleStrengthValue = ConfigCommonParamById.GetIntConfig("FlySingleStrengthValue").Value,
				MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("FlyMaxSingleStrengthItemCount").Value,
				MaxStrength = (int)baseMax
			},
			AttributeInfo = new List<IAttributeInfo>
			{
				item
			}
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
	}

	// Token: 0x17000B47 RID: 2887
	// (get) Token: 0x06008471 RID: 33905 RVA: 0x001C2FFB File Offset: 0x001C11FB
	public static ActivityMapTravelController Instance
	{
		get
		{
			return ActivityMapTravelController._Instance;
		}
	}

	// Token: 0x06008472 RID: 33906 RVA: 0x001C3002 File Offset: 0x001C1202
	public static ActivityMapTravelController GetOrCreateInstance()
	{
		if (ActivityMapTravelController._Instance == null)
		{
			ActivityMapTravelController.CreateInstance();
		}
		return ActivityMapTravelController._Instance;
	}

	// Token: 0x06008473 RID: 33907 RVA: 0x001C3016 File Offset: 0x001C1216
	public static bool CreateInstance()
	{
		if (ActivityMapTravelController._Instance != null)
		{
			return true;
		}
		ActivityMapTravelController._Instance = new ActivityMapTravelController();
		return true;
	}

	// Token: 0x06008474 RID: 33908 RVA: 0x001C302C File Offset: 0x001C122C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008475 RID: 33909 RVA: 0x001C302E File Offset: 0x001C122E
	public static void ResetStaticDefaultValue()
	{
		ActivityMapTravelController._Instance = null;
	}

	// Token: 0x06008476 RID: 33910 RVA: 0x001C3036 File Offset: 0x001C1236
	static ActivityMapTravelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapTravelController.CreateStaticDefaultValue), new Action(ActivityMapTravelController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B74 RID: 15220
	[Nullable(2)]
	private static ActivityMapTravelController _Instance;
}
