using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001EF5 RID: 7925
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ShipTowerController : UiControllerBase
{
	// Token: 0x06013A1C RID: 80412 RVA: 0x005B98BC File Offset: 0x005B7ABC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerResultNotify));
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerLevelPlayNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerLevelPlayNotify));
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerOverNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerOverNotify));
	}

	// Token: 0x06013A1D RID: 80413 RVA: 0x005B991D File Offset: 0x005B7B1D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerLevelPlayNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerOverNotify);
	}

	// Token: 0x06013A1E RID: 80414 RVA: 0x005B9950 File Offset: 0x005B7B50
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.EventWorldDone));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemList));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.EventFunctionOpen));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.EventCrossDay));
	}

	// Token: 0x06013A1F RID: 80415 RVA: 0x005B99D0 File Offset: 0x005B7BD0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.EventWorldDone));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.EventFunctionOpen));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.EventCrossDay));
	}

	// Token: 0x06013A20 RID: 80416 RVA: 0x005B9A50 File Offset: 0x005B7C50
	[NullableContext(2)]
	private void HandleSlashAndTowerResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerResultNotify notify = (SlashAndTowerResultNotify)msg;
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("ShipTower");
		ShipTowerModel.Instance.UpdateResultNotify(notify);
	}

	// Token: 0x06013A21 RID: 80417 RVA: 0x005B9A80 File Offset: 0x005B7C80
	[NullableContext(2)]
	private void HandleSlashAndTowerLevelPlayNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerLevelPlayNotify notify = (SlashAndTowerLevelPlayNotify)msg;
		ShipTowerModel.Instance.UpdateLevelPlayNotify(notify);
	}

	// Token: 0x06013A22 RID: 80418 RVA: 0x005B9AA0 File Offset: 0x005B7CA0
	[NullableContext(2)]
	private void HandleSlashAndTowerOverNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerOverNotify notify = (SlashAndTowerOverNotify)msg;
		ShipTowerModel.Instance.UpdateSeasonNotify(notify);
	}

	// Token: 0x06013A23 RID: 80419 RVA: 0x005B9ABF File Offset: 0x005B7CBF
	private void EventWorldDone()
	{
		if (ShipTowerModel.Instance.CheckInBattleShipTower())
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("ShipTower");
		}
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x06013A24 RID: 80420 RVA: 0x005B9AEC File Offset: 0x005B7CEC
	private void EventCrossDay()
	{
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x06013A25 RID: 80421 RVA: 0x005B9B00 File Offset: 0x005B7D00
	private void EventOnAddCommonItemList(IReadOnlyList<IProto_NormalItem> commonItemList)
	{
		foreach (IProto_NormalItem proto_NormalItem in commonItemList)
		{
			ItemInfo? config = ItemConfig.Instance.GetConfig(proto_NormalItem.Id);
			if (config != null && config.GetValueOrDefault().ItemType == 60005)
			{
				IReadOnlyList<SlashBuffToItem> buffCfgByItemIdList = ShipTowerConfig.Instance.GetBuffCfgByItemIdList(config.Value.Id);
				SlashBuffToItem? slashBuffToItem = null;
				if (buffCfgByItemIdList != null)
				{
					foreach (SlashBuffToItem value in buffCfgByItemIdList)
					{
						if (!ShipTowerModel.Instance.IsOldSeason(value.Season))
						{
							slashBuffToItem = new SlashBuffToItem?(value);
							break;
						}
					}
				}
				if (slashBuffToItem != null)
				{
					ShipTowerModel.Instance.AddShowBuffId(slashBuffToItem.Value.Id, slashBuffToItem.Value.Tips == 1);
				}
			}
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.ShipTowerView))
		{
			ShipTowerModel.Instance.CheckShowGetBuff().Forget<bool>();
		}
	}

	// Token: 0x06013A26 RID: 80422 RVA: 0x005B9C54 File Offset: 0x005B7E54
	private void EventFunctionOpen(EFunctionType id, bool isOpen)
	{
		if (!isOpen || id != EFunctionType.ShipTower)
		{
			return;
		}
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x06013A27 RID: 80423 RVA: 0x005B9C74 File Offset: 0x005B7E74
	public void RequestChallenge(ShipTowerStageData stageData, bool isFromLast = false, bool isAgain = false)
	{
		ShipTowerTeamData shipTowerTeamData = stageData.TeamDataList[0];
		ShipTowerTeamData shipTowerTeamData2 = stageData.TeamDataList[1];
		SlashAndTowerCtx slashAndTowerCtx = SlashAndTowerCtx.Create();
		slashAndTowerCtx.LevelsId = stageData.Id;
		slashAndTowerCtx.SelectBuff.AddRange(stageData.GetAllTeamBuffIdList());
		slashAndTowerCtx.SecondRoles.AddRange(shipTowerTeamData2.GetRoleIdListEdit());
		slashAndTowerCtx.SkillBranchIds.AddRange(ShipTowerController.CollectSkillBranchIdList(stageData));
		slashAndTowerCtx.ReChallenge = isAgain;
		InstanceDungeonModel.Instance.InstanceEnterContentText.SlashAndTowerCtx = slashAndTowerCtx;
		List<int> roleIds = isFromLast ? shipTowerTeamData2.GetRoleIdListEdit() : shipTowerTeamData.GetRoleIdListEdit();
		int instanceId = isFromLast ? shipTowerTeamData2.InstId : shipTowerTeamData.InstId;
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceId, roleIds, 0, 0, null, null).Forget<bool>();
	}

	// Token: 0x06013A28 RID: 80424 RVA: 0x005B9D34 File Offset: 0x005B7F34
	private static List<int> CollectSkillBranchIdList(ShipTowerStageData stageData)
	{
		List<int> list = new List<int>();
		foreach (ShipTowerTeamData shipTowerTeamData in stageData.TeamDataList)
		{
			foreach (ShipTowerRoleData shipTowerRoleData in shipTowerTeamData.RoleList)
			{
				int roleIdEdit = shipTowerRoleData.RoleIdEdit;
				int roleSkillBranchIdInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(roleIdEdit);
				list.Add(roleSkillBranchIdInCurrentGamePlay);
			}
		}
		return list;
	}

	// Token: 0x06013A29 RID: 80425 RVA: 0x005B9DDC File Offset: 0x005B7FDC
	public UniTask SlashAndTowerInfoRequest()
	{
		ShipTowerController.<SlashAndTowerInfoRequest>d__13 <SlashAndTowerInfoRequest>d__;
		<SlashAndTowerInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerInfoRequest>d__.<>1__state = -1;
		<SlashAndTowerInfoRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerInfoRequest>d__13>(ref <SlashAndTowerInfoRequest>d__);
		return <SlashAndTowerInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2A RID: 80426 RVA: 0x005B9E18 File Offset: 0x005B8018
	public UniTask SlashAndTowerScoreRewardRequest(int id, int[] ids)
	{
		ShipTowerController.<SlashAndTowerScoreRewardRequest>d__14 <SlashAndTowerScoreRewardRequest>d__;
		<SlashAndTowerScoreRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerScoreRewardRequest>d__.id = id;
		<SlashAndTowerScoreRewardRequest>d__.ids = ids;
		<SlashAndTowerScoreRewardRequest>d__.<>1__state = -1;
		<SlashAndTowerScoreRewardRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerScoreRewardRequest>d__14>(ref <SlashAndTowerScoreRewardRequest>d__);
		return <SlashAndTowerScoreRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2B RID: 80427 RVA: 0x005B9E64 File Offset: 0x005B8064
	public UniTask EndLessHistoryRequest()
	{
		ShipTowerController.<EndLessHistoryRequest>d__15 <EndLessHistoryRequest>d__;
		<EndLessHistoryRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EndLessHistoryRequest>d__.<>1__state = -1;
		<EndLessHistoryRequest>d__.<>t__builder.Start<ShipTowerController.<EndLessHistoryRequest>d__15>(ref <EndLessHistoryRequest>d__);
		return <EndLessHistoryRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2C RID: 80428 RVA: 0x005B9EA0 File Offset: 0x005B80A0
	public UniTask SlashAndTowerSaveRecordRequest(int id)
	{
		ShipTowerController.<SlashAndTowerSaveRecordRequest>d__16 <SlashAndTowerSaveRecordRequest>d__;
		<SlashAndTowerSaveRecordRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerSaveRecordRequest>d__.id = id;
		<SlashAndTowerSaveRecordRequest>d__.<>1__state = -1;
		<SlashAndTowerSaveRecordRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerSaveRecordRequest>d__16>(ref <SlashAndTowerSaveRecordRequest>d__);
		return <SlashAndTowerSaveRecordRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2D RID: 80429 RVA: 0x005B9EE4 File Offset: 0x005B80E4
	public UniTask SlashAndTowerResetRequest(int id)
	{
		ShipTowerController.<SlashAndTowerResetRequest>d__17 <SlashAndTowerResetRequest>d__;
		<SlashAndTowerResetRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerResetRequest>d__.id = id;
		<SlashAndTowerResetRequest>d__.<>1__state = -1;
		<SlashAndTowerResetRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerResetRequest>d__17>(ref <SlashAndTowerResetRequest>d__);
		return <SlashAndTowerResetRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2E RID: 80430 RVA: 0x005B9F28 File Offset: 0x005B8128
	public UniTask SlashAndTowerRecommendRequest(int id)
	{
		ShipTowerController.<SlashAndTowerRecommendRequest>d__18 <SlashAndTowerRecommendRequest>d__;
		<SlashAndTowerRecommendRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerRecommendRequest>d__.id = id;
		<SlashAndTowerRecommendRequest>d__.<>1__state = -1;
		<SlashAndTowerRecommendRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerRecommendRequest>d__18>(ref <SlashAndTowerRecommendRequest>d__);
		return <SlashAndTowerRecommendRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013A2F RID: 80431 RVA: 0x005B9F6C File Offset: 0x005B816C
	public UniTask SlashAndTowerReviewRequest()
	{
		ShipTowerController.<SlashAndTowerReviewRequest>d__19 <SlashAndTowerReviewRequest>d__;
		<SlashAndTowerReviewRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerReviewRequest>d__.<>1__state = -1;
		<SlashAndTowerReviewRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerReviewRequest>d__19>(ref <SlashAndTowerReviewRequest>d__);
		return <SlashAndTowerReviewRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17001DEA RID: 7658
	// (get) Token: 0x06013A30 RID: 80432 RVA: 0x005B9FA7 File Offset: 0x005B81A7
	public static ShipTowerController Instance
	{
		get
		{
			return ShipTowerController._Instance;
		}
	}

	// Token: 0x06013A31 RID: 80433 RVA: 0x005B9FAE File Offset: 0x005B81AE
	public static ShipTowerController GetOrCreateInstance()
	{
		if (ShipTowerController._Instance == null)
		{
			ShipTowerController.CreateInstance();
		}
		return ShipTowerController._Instance;
	}

	// Token: 0x06013A32 RID: 80434 RVA: 0x005B9FC2 File Offset: 0x005B81C2
	public static bool CreateInstance()
	{
		if (ShipTowerController._Instance != null)
		{
			return true;
		}
		ShipTowerController._Instance = new ShipTowerController();
		return true;
	}

	// Token: 0x06013A33 RID: 80435 RVA: 0x005B9FD8 File Offset: 0x005B81D8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013A34 RID: 80436 RVA: 0x005B9FDA File Offset: 0x005B81DA
	public static void ResetStaticDefaultValue()
	{
		ShipTowerController._Instance = null;
	}

	// Token: 0x06013A35 RID: 80437 RVA: 0x005B9FE2 File Offset: 0x005B81E2
	static ShipTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerController.CreateStaticDefaultValue), new Action(ShipTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A78D RID: 42893
	[Nullable(2)]
	private static ShipTowerController _Instance;
}
