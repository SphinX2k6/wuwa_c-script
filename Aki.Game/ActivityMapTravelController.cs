using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200077F RID: 1919
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMapTravelController : ActivityControllerBase
{
	// Token: 0x060057F8 RID: 22520 RVA: 0x001CB9C3 File Offset: 0x001C9BC3
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MapTravelInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMapTravelInfoUpdateNotify));
	}

	// Token: 0x060057F9 RID: 22521 RVA: 0x001CB9E1 File Offset: 0x001C9BE1
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MapTravelInfoUpdateNotify);
	}

	// Token: 0x060057FA RID: 22522 RVA: 0x001CB9F3 File Offset: 0x001C9BF3
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x001CBA2D File Offset: 0x001C9C2D
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060057FC RID: 22524 RVA: 0x001CBA67 File Offset: 0x001C9C67
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TravelMapSubView";
	}

	// Token: 0x060057FD RID: 22525 RVA: 0x001CBA70 File Offset: 0x001C9C70
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

	// Token: 0x060057FE RID: 22526 RVA: 0x001CBAAC File Offset: 0x001C9CAC
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

	// Token: 0x060057FF RID: 22527 RVA: 0x001CBAFB File Offset: 0x001C9CFB
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005800 RID: 22528 RVA: 0x001CBAFD File Offset: 0x001C9CFD
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMapTravel();
	}

	// Token: 0x06005801 RID: 22529 RVA: 0x001CBB04 File Offset: 0x001C9D04
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityMapTravelData();
	}

	// Token: 0x06005802 RID: 22530 RVA: 0x001CBB0B File Offset: 0x001C9D0B
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005803 RID: 22531 RVA: 0x001CBB10 File Offset: 0x001C9D10
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

	// Token: 0x06005804 RID: 22532 RVA: 0x001CBB44 File Offset: 0x001C9D44
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

	// Token: 0x06005805 RID: 22533 RVA: 0x001CBBE0 File Offset: 0x001C9DE0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mapTravelLevelUpResponse.ErrorCode, 26622, null, true, true);
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

	// Token: 0x06005806 RID: 22534 RVA: 0x001CBC24 File Offset: 0x001C9E24
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulMapTravelTaskRewardResponse.ErrorCode, 16436, null, true, true);
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

	// Token: 0x06005807 RID: 22535 RVA: 0x001CBC7C File Offset: 0x001C9E7C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mapTravelFullRewardResponse.ErrorCode, 18348, null, true, true);
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

	// Token: 0x06005808 RID: 22536 RVA: 0x001CBCAC File Offset: 0x001C9EAC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulMapTravelSoarRewardResponse.ErrorCode, 16779, null, true, true);
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

	// Token: 0x06005809 RID: 22537 RVA: 0x001CBD01 File Offset: 0x001C9F01
	private void TryOpenLevelTipsView(ActivityMapTravelData data)
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.TravelLevelTipsView))
		{
			UiManager.Instance.OpenView(EUiViewName.TravelLevelTipsView, data, null);
		}
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x001CBD25 File Offset: 0x001C9F25
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipMapTravelView, null, null);
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x001CBD38 File Offset: 0x001C9F38
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

	// Token: 0x17000B67 RID: 2919
	// (get) Token: 0x0600580C RID: 22540 RVA: 0x001CBE57 File Offset: 0x001CA057
	public static ActivityMapTravelController Instance
	{
		get
		{
			return ActivityMapTravelController._Instance;
		}
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x001CBE5E File Offset: 0x001CA05E
	public static ActivityMapTravelController GetOrCreateInstance()
	{
		if (ActivityMapTravelController._Instance == null)
		{
			ActivityMapTravelController.CreateInstance();
		}
		return ActivityMapTravelController._Instance;
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x001CBE72 File Offset: 0x001CA072
	public static bool CreateInstance()
	{
		if (ActivityMapTravelController._Instance != null)
		{
			return true;
		}
		ActivityMapTravelController._Instance = new ActivityMapTravelController();
		return true;
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x001CBE88 File Offset: 0x001CA088
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x001CBE8A File Offset: 0x001CA08A
	public static void ResetStaticDefaultValue()
	{
		ActivityMapTravelController._Instance = null;
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x001CBE92 File Offset: 0x001CA092
	static ActivityMapTravelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapTravelController.CreateStaticDefaultValue), new Action(ActivityMapTravelController.ResetStaticDefaultValue));
	}

	// Token: 0x04003C0C RID: 15372
	[Nullable(2)]
	private static ActivityMapTravelController _Instance;
}
