using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200082F RID: 2095
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MowingTowerController : ActivityControllerBase
{
	// Token: 0x06005F2C RID: 24364 RVA: 0x001E64EC File Offset: 0x001E46EC
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005F2D RID: 24365 RVA: 0x001E64EE File Offset: 0x001E46EE
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMowingTower";
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x001E64F5 File Offset: 0x001E46F5
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new MowingTowerSubView();
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x001E64FC File Offset: 0x001E46FC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new MowingTowerData();
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x001E6503 File Offset: 0x001E4703
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x001E6506 File Offset: 0x001E4706
	protected override bool OnInit()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.MowingTowerMainView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "MowingTowerController.CheckCanOpen");
		return true;
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x001E6529 File Offset: 0x001E4729
	protected override bool OnClear()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.MowingTowerMainView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
		return true;
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x001E6548 File Offset: 0x001E4748
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MowTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeEndNotify));
		Net.Instance.Register(ENotifyMessageId.MowTowerLevelsInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMowingTowerLevelInfoNotify));
		Net.Instance.Register(ENotifyMessageId.MowTowerFirstScoreNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMowTowerFirstScoreNotify));
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x001E65A9 File Offset: 0x001E47A9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerLevelsInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerFirstScoreNotify);
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x001E65DB File Offset: 0x001E47DB
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x001E65F9 File Offset: 0x001E47F9
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x001E6618 File Offset: 0x001E4818
	private void OnLeaveInstanceDungeonConfirm()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config != null && config.Value.InstSubType == 24)
		{
			MowingTowerController.Instance.RequestSettlement();
		}
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x001E6664 File Offset: 0x001E4864
	[NullableContext(2)]
	private void OnMowingTowerLevelInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		MowTowerLevelsInfoUpdateNotify mowTowerLevelsInfoUpdateNotify = (MowTowerLevelsInfoUpdateNotify)msg;
		int activityId = MowingTowerConfig.Instance.GetBossMowingTowerConfigById(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos[0].LevelsId).Value.ActivityId;
		MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(activityId) as MowingTowerData;
		if (mowingTowerData != null)
		{
			mowingTowerData.PhraseLevelInfo(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos);
			mowingTowerData.PhraseRewardInfo(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos);
			mowingTowerData.CheckIfNewMowingTowerOpen();
			EventSystem.Instance.Emit(EEventName.RefreshMowingTowerData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, activityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x001E6709 File Offset: 0x001E4909
	[NullableContext(2)]
	protected void OnMowTowerFirstScoreNotify(IMessage msg, Net.CallbackStatus _2)
	{
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x001E670C File Offset: 0x001E490C
	[NullableContext(2)]
	private void OnChallengeEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		MowTowerResultNotify mowTowerResultNotify = (MowTowerResultNotify)msg;
		bool isSuccess = true;
		RewardData<IExploreRewardInfo> rewardData = this.CreateExploreData(3016, isSuccess, null, mowTowerResultNotify);
		MowTowerLevelsRe? mowTowerLevelsRe;
		bool? flag = (MowingTowerConfig.Instance.GetBossMowingTowerConfigById(mowTowerResultNotify.LevelsId) != null) ? new bool?(mowTowerLevelsRe.GetValueOrDefault().IsInfinite) : null;
		List<IRewardExploreScoreBelongHalfAreaItem> list = new List<IRewardExploreScoreBelongHalfAreaItem>();
		RewardExploreScoreBelongHalfAreaItem item = new RewardExploreScoreBelongHalfAreaItem
		{
			Target = mowTowerResultNotify.FirstKilMonsterScore.ToString(),
			DescriptionTextId = "BossRushMonsterScoreTips",
			Belong = ETeamBelong.FirstPart
		};
		list.Add(item);
		bool? flag3;
		bool? flag2 = flag3 = flag;
		bool flag4 = false;
		if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
		{
			RewardExploreScoreBelongHalfAreaItem item2 = new RewardExploreScoreBelongHalfAreaItem
			{
				Target = mowTowerResultNotify.FirstTimerScore.ToString(),
				DescriptionTextId = "BossRushTimeScoreTips",
				Belong = ETeamBelong.FirstPart
			};
			list.Add(item2);
		}
		RewardExploreScoreBelongHalfAreaItem item3 = new RewardExploreScoreBelongHalfAreaItem
		{
			Target = mowTowerResultNotify.SecondKilMonsterScore.ToString(),
			DescriptionTextId = "BossRushMonsterScoreTips",
			Belong = ETeamBelong.LowPart
		};
		list.Add(item3);
		flag3 = flag2;
		flag4 = false;
		if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
		{
			RewardExploreScoreBelongHalfAreaItem item4 = new RewardExploreScoreBelongHalfAreaItem
			{
				Target = mowTowerResultNotify.SecondTimerScore.ToString(),
				DescriptionTextId = "BossRushTimeScoreTips",
				Belong = ETeamBelong.LowPart
			};
			list.Add(item4);
		}
		int num = mowTowerResultNotify.FirstKilMonsterScore + mowTowerResultNotify.FirstTimerScore + mowTowerResultNotify.SecondKilMonsterScore + mowTowerResultNotify.SecondTimerScore;
		bool ifNewRecord = num > mowTowerResultNotify.HighScore;
		RewardExploreScoreBelongHalfArea halfAreaData = new RewardExploreScoreBelongHalfArea
		{
			ItemList = list,
			IfNewRecord = ifNewRecord,
			FullScore = num
		};
		rewardData.SetHalfAreaData(halfAreaData);
		ItemRewardController.Instance.Open<IExploreRewardInfo>(rewardData, null);
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x001E68DC File Offset: 0x001E4ADC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<IExploreRewardInfo> CreateExploreData(int configId, bool isSuccess, Action onCloseCallback, MowTowerResultNotify notify)
	{
		List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
		List<IRewardExploreConfirmButton> list2 = list;
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "Text_ButtonTextConfirmResult_Text";
		rewardExploreConfirmButtonData.DescriptionTextId = null;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = true;
		rewardExploreConfirmButtonData.IsClickedCloseView = false;
		rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
		{
			MowingTowerController.Instance.OpenDefaultMowingTowerView().ContinueWith(delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				}
			});
		};
		list2.Add(rewardExploreConfirmButtonData);
		bool flag = notify.HighScore > 0;
		list.Add(new RewardExploreConfirmButtonData
		{
			ButtonTextId = "Text_ButtonTextChallengeOneMore_Text",
			DescriptionTextId = (flag ? "BossRushCurrentHighScore" : null),
			DescriptionArgs = new List<object>
			{
				notify.HighScore
			},
			IsTimeDownCloseView = false,
			IsClickedCloseView = false,
			OnClickedCallback = delegate(int _)
			{
				int activityId = MowingTowerConfig.Instance.GetBossMowingTowerConfigById(notify.LevelsId).Value.ActivityId;
				MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(activityId) as MowingTowerData;
				if (mowingTowerData == null)
				{
					return;
				}
				MowingTowerLevelDetailInfo mowingTowerLevelDetailInfoById = mowingTowerData.GetMowingTowerLevelDetailInfoById(notify.LevelsId);
				if (mowingTowerLevelDetailInfoById == null)
				{
					return;
				}
				MowingTowerController.Instance.RequestStartMowingTowerByTeamData(mowingTowerLevelDetailInfoById.ConvertToTeamInfo());
			}
		});
		ItemRewardModel.Instance.ClearCurrentRewardData();
		return ItemRewardModel.Instance.RefreshExploreRewardDataFromConfig(configId, isSuccess, null, null, null, list, null, null, onCloseCallback, null, null, null, null, null, null, null);
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x001E69F8 File Offset: 0x001E4BF8
	public void RequestStartMowingTowerByTeamData(MowingTowerTeamInfo data)
	{
		List<BuffSelection> list = new List<BuffSelection>();
		foreach (MowingTowerBuffInfo mowingTowerBuffInfo in data.GetPrepareSelectBuff())
		{
			BuffSelection buffSelection = BuffSelection.Create();
			buffSelection.BuffId = mowingTowerBuffInfo.BuffId;
			buffSelection.Slot = mowingTowerBuffInfo.Slot;
			list.Add(buffSelection);
		}
		ValueTuple<List<int>, List<int>> currentTeamMembers = data.GetCurrentTeamMembers();
		int[] firstPartRole = currentTeamMembers.Item1.ToArray();
		int[] lowPartRole = currentTeamMembers.Item2.ToArray();
		int activityId = data.ActivityId;
		MowingTowerController.Instance.RequestStartMowingTower(activityId, data.GetCurrentSelectLevel().GetInstanceDungeonId(), data.GetCurrentSelectLevel().GetId(), list.ToArray(), firstPartRole, lowPartRole);
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x001E6AC4 File Offset: 0x001E4CC4
	public void RequestStartMowingTower(int id, int instanceDungeonId, int configId, BuffSelection[] buff, int[] firstPartRole, int[] lowPartRole)
	{
		if (this.LastRequestMowingTowerTime != 0f && Time.Instance.Now - (double)this.LastRequestMowingTowerTime <= 1000.0)
		{
			return;
		}
		this.LastRequestMowingTowerTime = (float)Time.Instance.Now;
		List<int> list = new List<int>();
		foreach (BuffSelection buffSelection in buff)
		{
			if (buffSelection.BuffId == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_2500057_Text", Array.Empty<object>());
				return;
			}
			list.Add(buffSelection.BuffId);
		}
		List<int> list2 = new List<int>();
		foreach (int num in lowPartRole)
		{
			if (num != 0)
			{
				list2.Add(num);
			}
		}
		MowTowerCtx mowTowerCtx = MowTowerCtx.Create();
		mowTowerCtx.SelectBuff.AddRange(list);
		mowTowerCtx.LevelsId = configId;
		mowTowerCtx.SecondRoles.AddRange(list2);
		InstanceDungeonModel.Instance.InstanceEnterContentText.MowTowerCtx = mowTowerCtx;
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceDungeonId, new List<int>(firstPartRole), 0, 0, null, null);
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x001E6BD8 File Offset: 0x001E4DD8
	public void RequestSettlement()
	{
		MowTowerSettlementRequest message = MowTowerSettlementRequest.Create();
		Net.Instance.Call(ERequestMessageId.MowTowerSettlementRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MowTowerSettlementResponse mowTowerSettlementResponse = (MowTowerSettlementResponse)msg;
			if (mowTowerSettlementResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mowTowerSettlementResponse.ErrorCode, 27490, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06005F3F RID: 24383 RVA: 0x001E6C1B File Offset: 0x001E4E1B
	public bool CheckCanOpen(EUiViewName _, object _1)
	{
		GameModeModel instance = GameModeModel.Instance;
		if (instance != null && instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsById("MowingTowerMultiTips", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x001E6C48 File Offset: 0x001E4E48
	public void RequestGetMowingTowerLevelReward(int activityId, int configId, int levelId, int index)
	{
		MowTowerLevelsRewardRequest mowTowerLevelsRewardRequest = MowTowerLevelsRewardRequest.Create();
		mowTowerLevelsRewardRequest.RewardId = configId;
		Net.Instance.Call(ERequestMessageId.MowTowerLevelsRewardRequest, mowTowerLevelsRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MowTowerLevelsRewardResponse mowTowerLevelsRewardResponse = (MowTowerLevelsRewardResponse)msg;
			if (mowTowerLevelsRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mowTowerLevelsRewardResponse.ErrorCode, 17233, null, true, true);
			}
			MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(activityId) as MowingTowerData;
			if (mowingTowerData != null)
			{
				mowingTowerData.SetRewardStateClaimed(levelId, index);
				EventSystem.Instance.Emit(EEventName.RefreshMowingTowerReward);
				EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, activityId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			}
		}, 0);
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x001E6C9C File Offset: 0x001E4E9C
	[NullableContext(0)]
	public UniTask<bool> OpenDefaultMowingTowerView()
	{
		MowingTowerController.<OpenDefaultMowingTowerView>d__24 <OpenDefaultMowingTowerView>d__;
		<OpenDefaultMowingTowerView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenDefaultMowingTowerView>d__.<>1__state = -1;
		<OpenDefaultMowingTowerView>d__.<>t__builder.Start<MowingTowerController.<OpenDefaultMowingTowerView>d__24>(ref <OpenDefaultMowingTowerView>d__);
		return <OpenDefaultMowingTowerView>d__.<>t__builder.Task;
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x001E6CD8 File Offset: 0x001E4ED8
	[NullableContext(0)]
	public UniTask<bool> OpenMowingTowerView(int activityId)
	{
		MowingTowerController.<OpenMowingTowerView>d__25 <OpenMowingTowerView>d__;
		<OpenMowingTowerView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenMowingTowerView>d__.activityId = activityId;
		<OpenMowingTowerView>d__.<>1__state = -1;
		<OpenMowingTowerView>d__.<>t__builder.Start<MowingTowerController.<OpenMowingTowerView>d__25>(ref <OpenMowingTowerView>d__);
		return <OpenMowingTowerView>d__.<>t__builder.Task;
	}

	// Token: 0x17000BFF RID: 3071
	// (get) Token: 0x06005F43 RID: 24387 RVA: 0x001E6D1B File Offset: 0x001E4F1B
	public static MowingTowerController Instance
	{
		get
		{
			return MowingTowerController._Instance;
		}
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x001E6D22 File Offset: 0x001E4F22
	public static MowingTowerController GetOrCreateInstance()
	{
		if (MowingTowerController._Instance == null)
		{
			MowingTowerController.CreateInstance();
		}
		return MowingTowerController._Instance;
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x001E6D36 File Offset: 0x001E4F36
	public static bool CreateInstance()
	{
		if (MowingTowerController._Instance != null)
		{
			return true;
		}
		MowingTowerController._Instance = new MowingTowerController();
		return true;
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x001E6D4C File Offset: 0x001E4F4C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x001E6D4E File Offset: 0x001E4F4E
	public static void ResetStaticDefaultValue()
	{
		MowingTowerController._Instance = null;
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x001E6D56 File Offset: 0x001E4F56
	static MowingTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerController.CreateStaticDefaultValue), new Action(MowingTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04003E81 RID: 16001
	private const int SENDCD = 1000;

	// Token: 0x04003E82 RID: 16002
	private const string BUFF_IS_NOT_VAILD = "ErrorCode_2500057_Text";

	// Token: 0x04003E83 RID: 16003
	private float LastRequestMowingTowerTime;

	// Token: 0x04003E84 RID: 16004
	[Nullable(2)]
	private static MowingTowerController _Instance;
}
