using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinTrial;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

// Token: 0x0200097B RID: 2427
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleSkinTrialController : ActivityControllerBase
{
	// Token: 0x06006A76 RID: 27254 RVA: 0x0021277F File Offset: 0x0021097F
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new RoleSkinTrialData();
	}

	// Token: 0x06006A77 RID: 27255 RVA: 0x00212786 File Offset: 0x00210986
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RoleSkinTrialSubView();
	}

	// Token: 0x06006A78 RID: 27256 RVA: 0x0021278D File Offset: 0x0021098D
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006A79 RID: 27257 RVA: 0x0021278F File Offset: 0x0021098F
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006A7A RID: 27258 RVA: 0x00212792 File Offset: 0x00210992
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleSkinOntrial";
	}

	// Token: 0x06006A7B RID: 27259 RVA: 0x00212799 File Offset: 0x00210999
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleSkinTrialSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleSkinTrialSettleNotify));
	}

	// Token: 0x06006A7C RID: 27260 RVA: 0x002127B7 File Offset: 0x002109B7
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinTrialSettleNotify);
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x002127C9 File Offset: 0x002109C9
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x002127E7 File Offset: 0x002109E7
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x00212808 File Offset: 0x00210A08
	private void OnWorldDone()
	{
		if (!RoleSkinTrialController.SkinTrailState || GameModeController.Instance.IsInInstance())
		{
			return;
		}
		List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(35);
		RoleSkinTrialController.SkinTrailState = false;
		foreach (ActivityBaseData activityBaseData in activitiesByType)
		{
			RoleSkinTrialData roleSkinTrialData = activityBaseData as RoleSkinTrialData;
			if (roleSkinTrialData != null && roleSkinTrialData.TrialState)
			{
				roleSkinTrialData.TrialState = false;
				ActivityController.Instance.OpenActivityById(activityBaseData.Id, EActivityViewOpenType.Other, null, null);
				break;
			}
		}
	}

	// Token: 0x06006A80 RID: 27264 RVA: 0x002128A4 File Offset: 0x00210AA4
	public static bool CheckIfInRoleSkinTrialInstance()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 26;
	}

	// Token: 0x06006A81 RID: 27265 RVA: 0x002128E8 File Offset: 0x00210AE8
	[NullableContext(2)]
	private void OnRoleSkinTrialSettleNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleSkinTrialSettleNotify roleSkinTrialSettleNotify = (RoleSkinTrialSettleNotify)msg;
		if (roleSkinTrialSettleNotify.ErrorCode > Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkinTrialSettleNotify.ErrorCode, 25987, null, true, true);
			RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_250_ButtonText_0",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = new Action<int>(RoleSkinTrialController.<OnRoleSkinTrialSettleNotify>g__OnClickQuit|13_0)
			};
			ItemRewardController.Instance.OpenExploreRewardView(3023, false, null, null, null, new List<IRewardExploreConfirmButton>
			{
				item
			}, null, null, null, null, null, null, null, null, null, null, null);
			return;
		}
	}

	// Token: 0x06006A82 RID: 27266 RVA: 0x00212998 File Offset: 0x00210B98
	public static void RequestRoleSkinTrailInstanceReward(int activityId, int id)
	{
		TrialRoleSkinRewardRequest trialRoleSkinRewardRequest = TrialRoleSkinRewardRequest.Create();
		trialRoleSkinRewardRequest.RoleSkinTrialInfoId = id;
		Net.Instance.Call(ERequestMessageId.TrialRoleSkinRewardRequest, trialRoleSkinRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrialRoleSkinRewardResponse trialRoleSkinRewardResponse = (TrialRoleSkinRewardResponse)msg;
			if (trialRoleSkinRewardResponse == null)
			{
				return;
			}
			if (trialRoleSkinRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trialRoleSkinRewardResponse.ErrorCode, 27840, null, true, true);
			}
			RoleSkinTrialData roleSkinTrialData = ActivityModel.Instance.GetActivityById(activityId) as RoleSkinTrialData;
			if (roleSkinTrialData == null)
			{
				return;
			}
			roleSkinTrialData.FinishRewardById(id);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "[角色皮肤试用活动]试用副本奖励领取成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06006A83 RID: 27267 RVA: 0x002129E8 File Offset: 0x00210BE8
	public static void EnterRoleTrialDungeonDirectly(int instanceId, int activityId, int id)
	{
		RoleSkinTrialData roleSkinTrialData = ActivityModel.Instance.GetActivityById(activityId) as RoleSkinTrialData;
		if (roleSkinTrialData == null)
		{
			return;
		}
		roleSkinTrialData.TrialState = true;
		RoleSkinTrialEnterCtx roleSkinTrialEnterCtx = new RoleSkinTrialEnterCtx
		{
			ActivityId = activityId,
			RoleSkinTrialInfoId = id
		};
		RoleSkinTrialController.SkinTrailState = true;
		InstanceDungeonModel.Instance.InstanceEnterContentText.RoleSkinTrialEnterCtx = roleSkinTrialEnterCtx;
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceId, new List<int>(), 0, 0, null, null);
	}

	// Token: 0x06006A84 RID: 27268 RVA: 0x00212A50 File Offset: 0x00210C50
	public static void RequestRoleSkinTrialUiEndPush()
	{
		RoleTrialUiEndPush message = RoleTrialUiEndPush.Create();
		Net.Instance.Send(EPushMessageId.RoleSkinTrialUiEndPush, message);
	}

	// Token: 0x17000D2D RID: 3373
	// (get) Token: 0x06006A85 RID: 27269 RVA: 0x00212A73 File Offset: 0x00210C73
	public static RoleSkinTrialController Instance
	{
		get
		{
			return RoleSkinTrialController._Instance;
		}
	}

	// Token: 0x06006A86 RID: 27270 RVA: 0x00212A7A File Offset: 0x00210C7A
	public static RoleSkinTrialController GetOrCreateInstance()
	{
		if (RoleSkinTrialController._Instance == null)
		{
			RoleSkinTrialController.CreateInstance();
		}
		return RoleSkinTrialController._Instance;
	}

	// Token: 0x06006A87 RID: 27271 RVA: 0x00212A8E File Offset: 0x00210C8E
	public static bool CreateInstance()
	{
		if (RoleSkinTrialController._Instance != null)
		{
			return true;
		}
		RoleSkinTrialController._Instance = new RoleSkinTrialController();
		return true;
	}

	// Token: 0x06006A88 RID: 27272 RVA: 0x00212AA4 File Offset: 0x00210CA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A89 RID: 27273 RVA: 0x00212AA6 File Offset: 0x00210CA6
	public static void ResetStaticDefaultValue()
	{
		RoleSkinTrialController._Instance = null;
	}

	// Token: 0x06006A8A RID: 27274 RVA: 0x00212AAE File Offset: 0x00210CAE
	static RoleSkinTrialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinTrialController.CreateStaticDefaultValue), new Action(RoleSkinTrialController.ResetStaticDefaultValue));
	}

	// Token: 0x06006A8C RID: 27276 RVA: 0x00212AD5 File Offset: 0x00210CD5
	[CompilerGenerated]
	internal static void <OnRoleSkinTrialSettleNotify>g__OnClickQuit|13_0(int _)
	{
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
	}

	// Token: 0x0400431D RID: 17181
	[StaticVariableRuleIgnore]
	private static bool SkinTrailState;

	// Token: 0x0400431E RID: 17182
	public int CurrentActivityId;

	// Token: 0x0400431F RID: 17183
	[Nullable(2)]
	private static RoleSkinTrialController _Instance;
}
