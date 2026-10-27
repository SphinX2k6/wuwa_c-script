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

// Token: 0x020014C7 RID: 5319
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RoleSkinTrialController : ActivityControllerBase
{
	// Token: 0x060096E1 RID: 38625 RVA: 0x00209813 File Offset: 0x00207A13
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new RoleSkinTrialData();
	}

	// Token: 0x060096E2 RID: 38626 RVA: 0x0020981A File Offset: 0x00207A1A
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RoleSkinTrialSubView();
	}

	// Token: 0x060096E3 RID: 38627 RVA: 0x00209821 File Offset: 0x00207A21
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060096E4 RID: 38628 RVA: 0x00209823 File Offset: 0x00207A23
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060096E5 RID: 38629 RVA: 0x00209826 File Offset: 0x00207A26
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleSkinOntrial";
	}

	// Token: 0x060096E6 RID: 38630 RVA: 0x0020982D File Offset: 0x00207A2D
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleSkinTrialSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleSkinTrialSettleNotify));
	}

	// Token: 0x060096E7 RID: 38631 RVA: 0x0020984B File Offset: 0x00207A4B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleSkinTrialSettleNotify);
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x0020985D File Offset: 0x00207A5D
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x0020987B File Offset: 0x00207A7B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x060096EA RID: 38634 RVA: 0x0020989C File Offset: 0x00207A9C
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

	// Token: 0x060096EB RID: 38635 RVA: 0x00209938 File Offset: 0x00207B38
	public static bool CheckIfInRoleSkinTrialInstance()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 26;
	}

	// Token: 0x060096EC RID: 38636 RVA: 0x0020997C File Offset: 0x00207B7C
	[NullableContext(2)]
	private void OnRoleSkinTrialSettleNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleSkinTrialSettleNotify roleSkinTrialSettleNotify = (RoleSkinTrialSettleNotify)msg;
		if (roleSkinTrialSettleNotify.ErrorCode > Aki.Protocol.ErrorCode.Success)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleSkinTrialSettleNotify.ErrorCode, 20469, null, true, true);
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

	// Token: 0x060096ED RID: 38637 RVA: 0x00209A2C File Offset: 0x00207C2C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(trialRoleSkinRewardResponse.ErrorCode, 19389, null, true, true);
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

	// Token: 0x060096EE RID: 38638 RVA: 0x00209A7C File Offset: 0x00207C7C
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

	// Token: 0x060096EF RID: 38639 RVA: 0x00209AE4 File Offset: 0x00207CE4
	public static void RequestRoleSkinTrialUiEndPush()
	{
		RoleTrialUiEndPush message = RoleTrialUiEndPush.Create();
		Net.Instance.Send(EPushMessageId.RoleSkinTrialUiEndPush, message);
	}

	// Token: 0x17000D0D RID: 3341
	// (get) Token: 0x060096F0 RID: 38640 RVA: 0x00209B07 File Offset: 0x00207D07
	public static RoleSkinTrialController Instance
	{
		get
		{
			return RoleSkinTrialController._Instance;
		}
	}

	// Token: 0x060096F1 RID: 38641 RVA: 0x00209B0E File Offset: 0x00207D0E
	public static RoleSkinTrialController GetOrCreateInstance()
	{
		if (RoleSkinTrialController._Instance == null)
		{
			RoleSkinTrialController.CreateInstance();
		}
		return RoleSkinTrialController._Instance;
	}

	// Token: 0x060096F2 RID: 38642 RVA: 0x00209B22 File Offset: 0x00207D22
	public static bool CreateInstance()
	{
		if (RoleSkinTrialController._Instance != null)
		{
			return true;
		}
		RoleSkinTrialController._Instance = new RoleSkinTrialController();
		return true;
	}

	// Token: 0x060096F3 RID: 38643 RVA: 0x00209B38 File Offset: 0x00207D38
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060096F4 RID: 38644 RVA: 0x00209B3A File Offset: 0x00207D3A
	public static void ResetStaticDefaultValue()
	{
		RoleSkinTrialController._Instance = null;
	}

	// Token: 0x060096F5 RID: 38645 RVA: 0x00209B42 File Offset: 0x00207D42
	static RoleSkinTrialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinTrialController.CreateStaticDefaultValue), new Action(RoleSkinTrialController.ResetStaticDefaultValue));
	}

	// Token: 0x060096F7 RID: 38647 RVA: 0x00209B69 File Offset: 0x00207D69
	[CompilerGenerated]
	internal static void <OnRoleSkinTrialSettleNotify>g__OnClickQuit|13_0(int _)
	{
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
	}

	// Token: 0x04004285 RID: 17029
	[StaticVariableRuleIgnore]
	private static bool SkinTrailState;

	// Token: 0x04004286 RID: 17030
	public int CurrentActivityId;

	// Token: 0x04004287 RID: 17031
	[Nullable(2)]
	private static RoleSkinTrialController _Instance;
}
