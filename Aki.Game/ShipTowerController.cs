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

// Token: 0x0200297A RID: 10618
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ShipTowerController : UiControllerBase
{
	// Token: 0x06016016 RID: 90134 RVA: 0x0058E8F8 File Offset: 0x0058CAF8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerResultNotify));
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerLevelPlayNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerLevelPlayNotify));
		Net.Instance.Register(ENotifyMessageId.SlashAndTowerOverNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleSlashAndTowerOverNotify));
	}

	// Token: 0x06016017 RID: 90135 RVA: 0x0058E959 File Offset: 0x0058CB59
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerLevelPlayNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SlashAndTowerOverNotify);
	}

	// Token: 0x06016018 RID: 90136 RVA: 0x0058E98C File Offset: 0x0058CB8C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.EventWorldDone));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemList));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.EventFunctionOpen));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.EventCrossDay));
	}

	// Token: 0x06016019 RID: 90137 RVA: 0x0058EA0C File Offset: 0x0058CC0C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.EventWorldDone));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.EventOnAddCommonItemList));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.EventFunctionOpen));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.EventCrossDay));
	}

	// Token: 0x0601601A RID: 90138 RVA: 0x0058EA8C File Offset: 0x0058CC8C
	[NullableContext(2)]
	private void HandleSlashAndTowerResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerResultNotify notify = (SlashAndTowerResultNotify)msg;
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("ShipTower");
		ShipTowerModel.Instance.UpdateResultNotify(notify);
	}

	// Token: 0x0601601B RID: 90139 RVA: 0x0058EABC File Offset: 0x0058CCBC
	[NullableContext(2)]
	private void HandleSlashAndTowerLevelPlayNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerLevelPlayNotify notify = (SlashAndTowerLevelPlayNotify)msg;
		ShipTowerModel.Instance.UpdateLevelPlayNotify(notify);
	}

	// Token: 0x0601601C RID: 90140 RVA: 0x0058EADC File Offset: 0x0058CCDC
	[NullableContext(2)]
	private void HandleSlashAndTowerOverNotify(IMessage msg, Net.CallbackStatus status)
	{
		SlashAndTowerOverNotify notify = (SlashAndTowerOverNotify)msg;
		ShipTowerModel.Instance.UpdateSeasonNotify(notify);
	}

	// Token: 0x0601601D RID: 90141 RVA: 0x0058EAFB File Offset: 0x0058CCFB
	private void EventWorldDone()
	{
		if (ShipTowerModel.Instance.CheckInBattleShipTower())
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("ShipTower");
		}
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x0601601E RID: 90142 RVA: 0x0058EB28 File Offset: 0x0058CD28
	private void EventCrossDay()
	{
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x0601601F RID: 90143 RVA: 0x0058EB3C File Offset: 0x0058CD3C
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

	// Token: 0x06016020 RID: 90144 RVA: 0x0058EC90 File Offset: 0x0058CE90
	private void EventFunctionOpen(EFunctionType id, bool isOpen)
	{
		if (!isOpen || id != EFunctionType.ShipTower)
		{
			return;
		}
		ShipTowerModel.Instance.CheckInitProto(true).Forget<bool>();
	}

	// Token: 0x06016021 RID: 90145 RVA: 0x0058ECB0 File Offset: 0x0058CEB0
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

	// Token: 0x06016022 RID: 90146 RVA: 0x0058ED70 File Offset: 0x0058CF70
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

	// Token: 0x06016023 RID: 90147 RVA: 0x0058EE18 File Offset: 0x0058D018
	public UniTask SlashAndTowerInfoRequest()
	{
		ShipTowerController.<SlashAndTowerInfoRequest>d__13 <SlashAndTowerInfoRequest>d__;
		<SlashAndTowerInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerInfoRequest>d__.<>1__state = -1;
		<SlashAndTowerInfoRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerInfoRequest>d__13>(ref <SlashAndTowerInfoRequest>d__);
		return <SlashAndTowerInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06016024 RID: 90148 RVA: 0x0058EE54 File Offset: 0x0058D054
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

	// Token: 0x06016025 RID: 90149 RVA: 0x0058EEA0 File Offset: 0x0058D0A0
	public UniTask EndLessHistoryRequest()
	{
		ShipTowerController.<EndLessHistoryRequest>d__15 <EndLessHistoryRequest>d__;
		<EndLessHistoryRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EndLessHistoryRequest>d__.<>1__state = -1;
		<EndLessHistoryRequest>d__.<>t__builder.Start<ShipTowerController.<EndLessHistoryRequest>d__15>(ref <EndLessHistoryRequest>d__);
		return <EndLessHistoryRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06016026 RID: 90150 RVA: 0x0058EEDC File Offset: 0x0058D0DC
	public UniTask SlashAndTowerSaveRecordRequest(int id)
	{
		ShipTowerController.<SlashAndTowerSaveRecordRequest>d__16 <SlashAndTowerSaveRecordRequest>d__;
		<SlashAndTowerSaveRecordRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerSaveRecordRequest>d__.id = id;
		<SlashAndTowerSaveRecordRequest>d__.<>1__state = -1;
		<SlashAndTowerSaveRecordRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerSaveRecordRequest>d__16>(ref <SlashAndTowerSaveRecordRequest>d__);
		return <SlashAndTowerSaveRecordRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06016027 RID: 90151 RVA: 0x0058EF20 File Offset: 0x0058D120
	public UniTask SlashAndTowerResetRequest(int id)
	{
		ShipTowerController.<SlashAndTowerResetRequest>d__17 <SlashAndTowerResetRequest>d__;
		<SlashAndTowerResetRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerResetRequest>d__.id = id;
		<SlashAndTowerResetRequest>d__.<>1__state = -1;
		<SlashAndTowerResetRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerResetRequest>d__17>(ref <SlashAndTowerResetRequest>d__);
		return <SlashAndTowerResetRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06016028 RID: 90152 RVA: 0x0058EF64 File Offset: 0x0058D164
	public UniTask SlashAndTowerRecommendRequest(int id)
	{
		ShipTowerController.<SlashAndTowerRecommendRequest>d__18 <SlashAndTowerRecommendRequest>d__;
		<SlashAndTowerRecommendRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerRecommendRequest>d__.id = id;
		<SlashAndTowerRecommendRequest>d__.<>1__state = -1;
		<SlashAndTowerRecommendRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerRecommendRequest>d__18>(ref <SlashAndTowerRecommendRequest>d__);
		return <SlashAndTowerRecommendRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06016029 RID: 90153 RVA: 0x0058EFA8 File Offset: 0x0058D1A8
	public UniTask SlashAndTowerReviewRequest()
	{
		ShipTowerController.<SlashAndTowerReviewRequest>d__19 <SlashAndTowerReviewRequest>d__;
		<SlashAndTowerReviewRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SlashAndTowerReviewRequest>d__.<>1__state = -1;
		<SlashAndTowerReviewRequest>d__.<>t__builder.Start<ShipTowerController.<SlashAndTowerReviewRequest>d__19>(ref <SlashAndTowerReviewRequest>d__);
		return <SlashAndTowerReviewRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17001D91 RID: 7569
	// (get) Token: 0x0601602A RID: 90154 RVA: 0x0058EFE3 File Offset: 0x0058D1E3
	public static ShipTowerController Instance
	{
		get
		{
			return ShipTowerController._Instance;
		}
	}

	// Token: 0x0601602B RID: 90155 RVA: 0x0058EFEA File Offset: 0x0058D1EA
	public static ShipTowerController GetOrCreateInstance()
	{
		if (ShipTowerController._Instance == null)
		{
			ShipTowerController.CreateInstance();
		}
		return ShipTowerController._Instance;
	}

	// Token: 0x0601602C RID: 90156 RVA: 0x0058EFFE File Offset: 0x0058D1FE
	public static bool CreateInstance()
	{
		if (ShipTowerController._Instance != null)
		{
			return true;
		}
		ShipTowerController._Instance = new ShipTowerController();
		return true;
	}

	// Token: 0x0601602D RID: 90157 RVA: 0x0058F014 File Offset: 0x0058D214
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601602E RID: 90158 RVA: 0x0058F016 File Offset: 0x0058D216
	public static void ResetStaticDefaultValue()
	{
		ShipTowerController._Instance = null;
	}

	// Token: 0x0601602F RID: 90159 RVA: 0x0058F01E File Offset: 0x0058D21E
	static ShipTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerController.CreateStaticDefaultValue), new Action(ShipTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A3A3 RID: 41891
	[Nullable(2)]
	private static ShipTowerController _Instance;
}
