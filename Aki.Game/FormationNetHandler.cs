using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001071 RID: 4209
public class FormationNetHandler : IStaticVariableResetter
{
	// Token: 0x0600A78E RID: 42894 RVA: 0x00315100 File Offset: 0x00313300
	static FormationNetHandler()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationNetHandler.CreateStaticDefaultValue), new Action(FormationNetHandler.ResetStaticDefaultValue));
	}

	// Token: 0x0600A78F RID: 42895 RVA: 0x0031511F File Offset: 0x0031331F
	public static void CreateStaticDefaultValue()
	{
		FormationNetHandler.CacheFormationNotify = null;
	}

	// Token: 0x0600A790 RID: 42896 RVA: 0x00315127 File Offset: 0x00313327
	public static void ResetStaticDefaultValue()
	{
		FormationNetHandler.CacheFormationNotify = null;
	}

	// Token: 0x0600A791 RID: 42897 RVA: 0x0031512F File Offset: 0x0031332F
	public static void RegisterNetEvent()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.UpdateFormationNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = FormationNetHandler.<>O.<0>__OnUpdateFormationNotify) == null)
		{
			callback = (FormationNetHandler.<>O.<0>__OnUpdateFormationNotify = new Action<IMessage, Net.CallbackStatus>(FormationNetHandler.OnUpdateFormationNotify));
		}
		instance.Register(id, callback);
	}

	// Token: 0x0600A792 RID: 42898 RVA: 0x0031515C File Offset: 0x0031335C
	public static void UnregisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.UpdateFormationNotify);
	}

	// Token: 0x0600A793 RID: 42899 RVA: 0x00315170 File Offset: 0x00313370
	public static void FlushCachedNotify(EUiViewName viewName)
	{
		if (!FormationNetHandler.IsFormationView(viewName) || FormationNetHandler.CacheFormationNotify == null || FormationNetHandler.IsFormationViewOpen())
		{
			return;
		}
		RepeatedField<PlayerFightFormations> playersFormations = FormationNetHandler.CacheFormationNotify.PlayersFormations;
		FormationModel.Instance.UpdatePlayerFormations(playersFormations);
		FormationNetHandler.CacheFormationNotify = null;
	}

	// Token: 0x0600A794 RID: 42900 RVA: 0x003151B0 File Offset: 0x003133B0
	[NullableContext(2)]
	private static void OnUpdateFormationNotify(IMessage msg, Net.CallbackStatus status)
	{
		UpdateFormationNotify updateFormationNotify = (UpdateFormationNotify)msg;
		RepeatedField<PlayerFightFormations> playersFormations = updateFormationNotify.PlayersFormations;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "更新背包编队";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formations", playersFormations);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		OnlineModel.Instance.RefreshWorldTeamRoleInfo(playersFormations);
		if (GameModeModel.Instance.IsMulti && FormationNetHandler.IsFormationViewOpen())
		{
			Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "更新背包编队时联机打开界面中,进行缓存", default(ReadOnlySpan<ValueTuple<string, object>>));
			FormationNetHandler.CacheFormationNotify = updateFormationNotify;
			return;
		}
		FormationModel.Instance.UpdatePlayerFormations(playersFormations);
		EventSystem.Instance.Emit(EEventName.OnRefreshOnlineTeamList);
		FormationNetHandler.CheckFormationAllowOnline();
		FormationNetHandler.TryUpdateSpecialTrialRole();
	}

	// Token: 0x0600A795 RID: 42901 RVA: 0x00315258 File Offset: 0x00313458
	private static bool IsFormationView(EUiViewName viewName)
	{
		return viewName == EUiViewName.Formation2DView || viewName == EUiViewName.Formation3DView;
	}

	// Token: 0x0600A796 RID: 42902 RVA: 0x00315274 File Offset: 0x00313474
	private static bool IsFormationViewOpen()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.Formation2DView);
		UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.Formation3DView);
		return (viewByName != null && !viewByName.IsDestroyOrDestroying) || (viewByName2 != null && !viewByName2.IsDestroyOrDestroying);
	}

	// Token: 0x0600A797 RID: 42903 RVA: 0x003152BC File Offset: 0x003134BC
	private static void CheckFormationAllowOnline()
	{
		bool enable = FormationModel.Instance.IsCurrentFormationHasSpecialTrialRole();
		OnlineModel.Instance.DisableOnline(EDisableOnlineType.TrialRole, enable, 0, 0);
	}

	// Token: 0x0600A798 RID: 42904 RVA: 0x003152E4 File Offset: 0x003134E4
	private static void TryUpdateSpecialTrialRole()
	{
		FormationModel instance = FormationModel.Instance;
		if (!instance.IsFormationHasSpecialTrialRole())
		{
			return;
		}
		foreach (int roleId in instance.GetFormationAllSpecialTrialRole())
		{
			TrialRoleModel.Instance.SetTrialRoleVisibility(roleId, true);
		}
	}

	// Token: 0x0600A799 RID: 42905 RVA: 0x00315328 File Offset: 0x00313528
	public static void GetFormationDataRequest()
	{
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "请求所有编队数据", default(ReadOnlySpan<ValueTuple<string, object>>));
		GetFormationDataRequest message = new GetFormationDataRequest();
		Net.Instance.Call(ERequestMessageId.GetFormationDataRequest, message, null, 0);
	}

	// Token: 0x0600A79A RID: 42906 RVA: 0x0031536C File Offset: 0x0031356C
	public static UniTask<bool> EditFormationRequest(int currentFormationId)
	{
		FormationNetHandler.<EditFormationRequest>d__13 <EditFormationRequest>d__;
		<EditFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EditFormationRequest>d__.currentFormationId = currentFormationId;
		<EditFormationRequest>d__.<>1__state = -1;
		<EditFormationRequest>d__.<>t__builder.Start<FormationNetHandler.<EditFormationRequest>d__13>(ref <EditFormationRequest>d__);
		return <EditFormationRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A79B RID: 42907 RVA: 0x003153B0 File Offset: 0x003135B0
	public static UniTask<bool> UpdateFormationRequest(int formationId, bool isCurrent, [Nullable(1)] int[] roleIdList, int currentRole)
	{
		FormationNetHandler.<UpdateFormationRequest>d__14 <UpdateFormationRequest>d__;
		<UpdateFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<UpdateFormationRequest>d__.formationId = formationId;
		<UpdateFormationRequest>d__.isCurrent = isCurrent;
		<UpdateFormationRequest>d__.roleIdList = roleIdList;
		<UpdateFormationRequest>d__.currentRole = currentRole;
		<UpdateFormationRequest>d__.<>1__state = -1;
		<UpdateFormationRequest>d__.<>t__builder.Start<FormationNetHandler.<UpdateFormationRequest>d__14>(ref <UpdateFormationRequest>d__);
		return <UpdateFormationRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A79C RID: 42908 RVA: 0x0031540C File Offset: 0x0031360C
	public static UniTask<bool> UpdateFightRoleRequest()
	{
		FormationNetHandler.<UpdateFightRoleRequest>d__15 <UpdateFightRoleRequest>d__;
		<UpdateFightRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<UpdateFightRoleRequest>d__.<>1__state = -1;
		<UpdateFightRoleRequest>d__.<>t__builder.Start<FormationNetHandler.<UpdateFightRoleRequest>d__15>(ref <UpdateFightRoleRequest>d__);
		return <UpdateFightRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A79D RID: 42909 RVA: 0x00315448 File Offset: 0x00313648
	public static UniTask<ErrorCode> RenameFormationRequest(int formationId, [Nullable(1)] string name)
	{
		FormationNetHandler.<RenameFormationRequest>d__16 <RenameFormationRequest>d__;
		<RenameFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<RenameFormationRequest>d__.formationId = formationId;
		<RenameFormationRequest>d__.name = name;
		<RenameFormationRequest>d__.<>1__state = -1;
		<RenameFormationRequest>d__.<>t__builder.Start<FormationNetHandler.<RenameFormationRequest>d__16>(ref <RenameFormationRequest>d__);
		return <RenameFormationRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A79E RID: 42910 RVA: 0x00315494 File Offset: 0x00313694
	public static UniTask<bool> ReorderFormationRequest(int formationId, int targetId)
	{
		FormationNetHandler.<ReorderFormationRequest>d__17 <ReorderFormationRequest>d__;
		<ReorderFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ReorderFormationRequest>d__.formationId = formationId;
		<ReorderFormationRequest>d__.targetId = targetId;
		<ReorderFormationRequest>d__.<>1__state = -1;
		<ReorderFormationRequest>d__.<>t__builder.Start<FormationNetHandler.<ReorderFormationRequest>d__17>(ref <ReorderFormationRequest>d__);
		return <ReorderFormationRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600A79F RID: 42911 RVA: 0x003154DF File Offset: 0x003136DF
	[NullableContext(1)]
	public static UpdateFormationRequest BuildUpdateFormationMessage(FightFormation[] formations)
	{
		UpdateFormationRequest updateFormationRequest = new UpdateFormationRequest();
		updateFormationRequest.Formations.AddRange(formations);
		return updateFormationRequest;
	}

	// Token: 0x0600A7A0 RID: 42912 RVA: 0x003154F4 File Offset: 0x003136F4
	[NullableContext(1)]
	private static FightFormation[] ConvertEditingFormationsToProto(int currentFormationId)
	{
		FormationModel instance = FormationModel.Instance;
		List<FightFormation> list = new List<FightFormation>();
		foreach (KeyValuePair<int, int[]> keyValuePair in instance.GetAllEditingFormation())
		{
			int key = keyValuePair.Key;
			int[] value = keyValuePair.Value;
			bool flag = key == currentFormationId;
			if (!flag || value.Length != 0)
			{
				int num = key;
				int? currentFormationId2 = instance.CurrentFormationId;
				if ((num == currentFormationId2.GetValueOrDefault() & currentFormationId2 != null) && FormationNetHandler.IsFormationDataUnchanged(key, value))
				{
					Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "更新单机编队,新旧编队相同", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					int curRole = flag ? FormationNetHandler.PickCurrentRoleForFormation(value) : ((value.Length != 0) ? value[0] : 0);
					FightFormation fightFormation = new FightFormation();
					fightFormation.FormationId = key;
					fightFormation.IsCurrent = flag;
					fightFormation.RoleIds.AddRange(value);
					fightFormation.CurRole = curRole;
					list.Add(fightFormation);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600A7A1 RID: 42913 RVA: 0x00315618 File Offset: 0x00313818
	[NullableContext(1)]
	private static bool IsFormationDataUnchanged(int formationId, int[] roleList)
	{
		FormationData formationData = FormationModel.Instance.GetFormationData(formationId);
		List<int> list = (formationData != null) ? formationData.RoleIdList : null;
		if (list == null || list.Count != roleList.Length)
		{
			return false;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != roleList[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600A7A2 RID: 42914 RVA: 0x00315670 File Offset: 0x00313870
	[NullableContext(1)]
	private static int PickCurrentRoleForFormation(int[] roleList)
	{
		FormationModel instance = FormationModel.Instance;
		int currentRolePosition = instance.CurrentFormationData.CurrentRolePosition;
		int num = (roleList.Length != 0) ? roleList[0] : 0;
		if (currentRolePosition >= 1 && currentRolePosition <= roleList.Length)
		{
			num = roleList[currentRolePosition - 1];
		}
		if (instance.IsRoleDead(num))
		{
			foreach (int num2 in roleList)
			{
				if (num2 != num && !instance.IsRoleDead(num2))
				{
					num = num2;
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x0600A7A3 RID: 42915 RVA: 0x003156E4 File Offset: 0x003138E4
	[NullableContext(1)]
	public static bool RequestSwitchSkillBranch(int configId, int skillBranch, Action<int> onMatchRejected)
	{
		InstanceDungeonModel instance = InstanceDungeonModel.Instance;
		if (instance.GetMatchTeamInfo() != null)
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (instance.GetPrewarPlayerReadyState(playerId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_700039_Text", Array.Empty<object>());
				int obj = (RoleModel.Instance.GetRoleBranchIndexById(configId, skillBranch) == 0) ? 1 : 0;
				onMatchRejected(obj);
				return false;
			}
		}
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(configId, skillBranch);
		if (RoleModel.Instance.IsInGamePlayRoleEdit)
		{
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(configId, roleBranchIdByIndex, true);
		}
		else
		{
			RoleController.Instance.RequestRoleSkillBranchModify(configId, roleBranchIdByIndex);
		}
		return true;
	}

	// Token: 0x04006193 RID: 24979
	[Nullable(2)]
	private static UpdateFormationNotify CacheFormationNotify;

	// Token: 0x02007306 RID: 29446
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04025725 RID: 153381
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__OnUpdateFormationNotify;
	}
}
