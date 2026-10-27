using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200137B RID: 4987
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MowingTowerController : ActivityControllerBase
{
	// Token: 0x06008B91 RID: 35729 RVA: 0x001DD6B0 File Offset: 0x001DB8B0
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008B92 RID: 35730 RVA: 0x001DD6B2 File Offset: 0x001DB8B2
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMowingTower";
	}

	// Token: 0x06008B93 RID: 35731 RVA: 0x001DD6B9 File Offset: 0x001DB8B9
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new MowingTowerSubView();
	}

	// Token: 0x06008B94 RID: 35732 RVA: 0x001DD6C0 File Offset: 0x001DB8C0
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new MowingTowerData();
	}

	// Token: 0x06008B95 RID: 35733 RVA: 0x001DD6C7 File Offset: 0x001DB8C7
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008B96 RID: 35734 RVA: 0x001DD6CA File Offset: 0x001DB8CA
	protected override bool OnInit()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.MowingTowerMainView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "MowingTowerController.CheckCanOpen");
		return true;
	}

	// Token: 0x06008B97 RID: 35735 RVA: 0x001DD6ED File Offset: 0x001DB8ED
	protected override bool OnClear()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.MowingTowerMainView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
		return true;
	}

	// Token: 0x06008B98 RID: 35736 RVA: 0x001DD70C File Offset: 0x001DB90C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.MowTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeEndNotify));
		Net.Instance.Register(ENotifyMessageId.MowTowerLevelsInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMowingTowerLevelInfoNotify));
		Net.Instance.Register(ENotifyMessageId.MowTowerFirstScoreNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMowTowerFirstScoreNotify));
	}

	// Token: 0x06008B99 RID: 35737 RVA: 0x001DD76D File Offset: 0x001DB96D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerLevelsInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MowTowerFirstScoreNotify);
	}

	// Token: 0x06008B9A RID: 35738 RVA: 0x001DD79F File Offset: 0x001DB99F
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
	}

	// Token: 0x06008B9B RID: 35739 RVA: 0x001DD7BD File Offset: 0x001DB9BD
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
	}

	// Token: 0x06008B9C RID: 35740 RVA: 0x001DD7DC File Offset: 0x001DB9DC
	private void OnLeaveInstanceDungeonConfirm()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config != null && config.Value.InstSubType == 24)
		{
			MowingTowerController.Instance.RequestSettlement();
		}
	}

	// Token: 0x06008B9D RID: 35741 RVA: 0x001DD828 File Offset: 0x001DBA28
	[NullableContext(2)]
	private void OnMowingTowerLevelInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		MowTowerLevelsInfoUpdateNotify mowTowerLevelsInfoUpdateNotify = (MowTowerLevelsInfoUpdateNotify)msg;
		int activityId = MowingTowerConfig.Instance.GetBossMowingTowerConfigById(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos[0].LevelsId).Value.ActivityId;
		MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(activityId) as MowingTowerData;
		if (mowingTowerData != null)
		{
			mowingTowerData.PhraseLevelInfo(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos.ToList<MowTowerLevelsInfo>());
			mowingTowerData.PhraseRewardInfo(mowTowerLevelsInfoUpdateNotify.MowTowerLevelsInfos.ToList<MowTowerLevelsInfo>());
			mowingTowerData.CheckIfNewMowingTowerOpen();
			EventSystem.Instance.Emit(EEventName.RefreshMowingTowerData);
			EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, activityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}
	}

	// Token: 0x06008B9E RID: 35742 RVA: 0x001DD8D7 File Offset: 0x001DBAD7
	[NullableContext(2)]
	protected void OnMowTowerFirstScoreNotify(IMessage msg, Net.CallbackStatus _2)
	{
	}

	// Token: 0x06008B9F RID: 35743 RVA: 0x001DD8DC File Offset: 0x001DBADC
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

	// Token: 0x06008BA0 RID: 35744 RVA: 0x001DDAAC File Offset: 0x001DBCAC
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

	// Token: 0x06008BA1 RID: 35745 RVA: 0x001DDBC8 File Offset: 0x001DBDC8
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

	// Token: 0x06008BA2 RID: 35746 RVA: 0x001DDC94 File Offset: 0x001DBE94
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
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceDungeonId, firstPartRole.ToList<int>(), 0, 0, null, null);
	}

	// Token: 0x06008BA3 RID: 35747 RVA: 0x001DDDA8 File Offset: 0x001DBFA8
	public void RequestSettlement()
	{
		MowTowerSettlementRequest message = MowTowerSettlementRequest.Create();
		Net.Instance.Call(ERequestMessageId.MowTowerSettlementRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MowTowerSettlementResponse mowTowerSettlementResponse = (MowTowerSettlementResponse)msg;
			if (mowTowerSettlementResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mowTowerSettlementResponse.ErrorCode, 24294, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06008BA4 RID: 35748 RVA: 0x001DDDEB File Offset: 0x001DBFEB
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

	// Token: 0x06008BA5 RID: 35749 RVA: 0x001DDE18 File Offset: 0x001DC018
	public void RequestGetMowingTowerLevelReward(int activityId, int configId, int levelId, int index)
	{
		MowTowerLevelsRewardRequest mowTowerLevelsRewardRequest = MowTowerLevelsRewardRequest.Create();
		mowTowerLevelsRewardRequest.RewardId = configId;
		Net.Instance.Call(ERequestMessageId.MowTowerLevelsRewardRequest, mowTowerLevelsRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MowTowerLevelsRewardResponse mowTowerLevelsRewardResponse = (MowTowerLevelsRewardResponse)msg;
			if (mowTowerLevelsRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mowTowerLevelsRewardResponse.ErrorCode, 25477, null, true, true);
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

	// Token: 0x06008BA6 RID: 35750 RVA: 0x001DDE6C File Offset: 0x001DC06C
	[NullableContext(0)]
	public UniTask<bool> OpenDefaultMowingTowerView()
	{
		MowingTowerController.<OpenDefaultMowingTowerView>d__24 <OpenDefaultMowingTowerView>d__;
		<OpenDefaultMowingTowerView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenDefaultMowingTowerView>d__.<>1__state = -1;
		<OpenDefaultMowingTowerView>d__.<>t__builder.Start<MowingTowerController.<OpenDefaultMowingTowerView>d__24>(ref <OpenDefaultMowingTowerView>d__);
		return <OpenDefaultMowingTowerView>d__.<>t__builder.Task;
	}

	// Token: 0x06008BA7 RID: 35751 RVA: 0x001DDEA8 File Offset: 0x001DC0A8
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

	// Token: 0x17000BDF RID: 3039
	// (get) Token: 0x06008BA8 RID: 35752 RVA: 0x001DDEEB File Offset: 0x001DC0EB
	public static MowingTowerController Instance
	{
		get
		{
			return MowingTowerController._Instance;
		}
	}

	// Token: 0x06008BA9 RID: 35753 RVA: 0x001DDEF2 File Offset: 0x001DC0F2
	public static MowingTowerController GetOrCreateInstance()
	{
		if (MowingTowerController._Instance == null)
		{
			MowingTowerController.CreateInstance();
		}
		return MowingTowerController._Instance;
	}

	// Token: 0x06008BAA RID: 35754 RVA: 0x001DDF06 File Offset: 0x001DC106
	public static bool CreateInstance()
	{
		if (MowingTowerController._Instance != null)
		{
			return true;
		}
		MowingTowerController._Instance = new MowingTowerController();
		return true;
	}

	// Token: 0x06008BAB RID: 35755 RVA: 0x001DDF1C File Offset: 0x001DC11C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008BAC RID: 35756 RVA: 0x001DDF1E File Offset: 0x001DC11E
	public static void ResetStaticDefaultValue()
	{
		MowingTowerController._Instance = null;
	}

	// Token: 0x06008BAD RID: 35757 RVA: 0x001DDF26 File Offset: 0x001DC126
	static MowingTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerController.CreateStaticDefaultValue), new Action(MowingTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04003DE9 RID: 15849
	private const int SENDCD = 1000;

	// Token: 0x04003DEA RID: 15850
	private const string BUFF_IS_NOT_VAILD = "ErrorCode_2500057_Text";

	// Token: 0x04003DEB RID: 15851
	private float LastRequestMowingTowerTime;

	// Token: 0x04003DEC RID: 15852
	[Nullable(2)]
	private static MowingTowerController _Instance;
}
