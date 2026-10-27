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

// Token: 0x02001BB2 RID: 7090
public class FormationNetHandler : IStaticVariableResetter
{
	// Token: 0x0600D37C RID: 54140 RVA: 0x0030A00C File Offset: 0x0030820C
	static FormationNetHandler()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationNetHandler.CreateStaticDefaultValue), new Action(FormationNetHandler.ResetStaticDefaultValue));
	}

	// Token: 0x0600D37D RID: 54141 RVA: 0x0030A02B File Offset: 0x0030822B
	public static void CreateStaticDefaultValue()
	{
		FormationNetHandler.CacheFormationNotify = null;
	}

	// Token: 0x0600D37E RID: 54142 RVA: 0x0030A033 File Offset: 0x00308233
	public static void ResetStaticDefaultValue()
	{
		FormationNetHandler.CacheFormationNotify = null;
	}

	// Token: 0x0600D37F RID: 54143 RVA: 0x0030A03B File Offset: 0x0030823B
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

	// Token: 0x0600D380 RID: 54144 RVA: 0x0030A068 File Offset: 0x00308268
	public static void UnregisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.UpdateFormationNotify);
	}

	// Token: 0x0600D381 RID: 54145 RVA: 0x0030A07C File Offset: 0x0030827C
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

	// Token: 0x0600D382 RID: 54146 RVA: 0x0030A0BC File Offset: 0x003082BC
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

	// Token: 0x0600D383 RID: 54147 RVA: 0x0030A164 File Offset: 0x00308364
	private static bool IsFormationView(EUiViewName viewName)
	{
		return viewName == EUiViewName.Formation2DView || viewName == EUiViewName.Formation3DView;
	}

	// Token: 0x0600D384 RID: 54148 RVA: 0x0030A180 File Offset: 0x00308380
	private static bool IsFormationViewOpen()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.Formation2DView);
		UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.Formation3DView);
		return (viewByName != null && !viewByName.IsDestroyOrDestroying) || (viewByName2 != null && !viewByName2.IsDestroyOrDestroying);
	}

	// Token: 0x0600D385 RID: 54149 RVA: 0x0030A1C8 File Offset: 0x003083C8
	private static void CheckFormationAllowOnline()
	{
		bool enable = FormationModel.Instance.IsCurrentFormationHasSpecialTrialRole();
		OnlineModel.Instance.DisableOnline(EDisableOnlineType.TrialRole, enable, 0, 0);
	}

	// Token: 0x0600D386 RID: 54150 RVA: 0x0030A1F0 File Offset: 0x003083F0
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

	// Token: 0x0600D387 RID: 54151 RVA: 0x0030A234 File Offset: 0x00308434
	public static void GetFormationDataRequest()
	{
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "请求所有编队数据", default(ReadOnlySpan<ValueTuple<string, object>>));
		GetFormationDataRequest message = new GetFormationDataRequest();
		Net.Instance.Call(ERequestMessageId.GetFormationDataRequest, message, null, 0);
	}

	// Token: 0x0600D388 RID: 54152 RVA: 0x0030A278 File Offset: 0x00308478
	public static UniTask<bool> EditFormationRequest(int currentFormationId)
	{
		FormationNetHandler.<EditFormationRequest>d__13 <EditFormationRequest>d__;
		<EditFormationRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EditFormationRequest>d__.currentFormationId = currentFormationId;
		<EditFormationRequest>d__.<>1__state = -1;
		<EditFormationRequest>d__.<>t__builder.Start<FormationNetHandler.<EditFormationRequest>d__13>(ref <EditFormationRequest>d__);
		return <EditFormationRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600D389 RID: 54153 RVA: 0x0030A2BC File Offset: 0x003084BC
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

	// Token: 0x0600D38A RID: 54154 RVA: 0x0030A318 File Offset: 0x00308518
	public static UniTask<bool> UpdateFightRoleRequest()
	{
		FormationNetHandler.<UpdateFightRoleRequest>d__15 <UpdateFightRoleRequest>d__;
		<UpdateFightRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<UpdateFightRoleRequest>d__.<>1__state = -1;
		<UpdateFightRoleRequest>d__.<>t__builder.Start<FormationNetHandler.<UpdateFightRoleRequest>d__15>(ref <UpdateFightRoleRequest>d__);
		return <UpdateFightRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600D38B RID: 54155 RVA: 0x0030A354 File Offset: 0x00308554
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

	// Token: 0x0600D38C RID: 54156 RVA: 0x0030A3A0 File Offset: 0x003085A0
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

	// Token: 0x0600D38D RID: 54157 RVA: 0x0030A3EB File Offset: 0x003085EB
	[NullableContext(1)]
	public static UpdateFormationRequest BuildUpdateFormationMessage(FightFormation[] formations)
	{
		UpdateFormationRequest updateFormationRequest = new UpdateFormationRequest();
		updateFormationRequest.Formations.AddRange(formations);
		return updateFormationRequest;
	}

	// Token: 0x0600D38E RID: 54158 RVA: 0x0030A400 File Offset: 0x00308600
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

	// Token: 0x0600D38F RID: 54159 RVA: 0x0030A524 File Offset: 0x00308724
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

	// Token: 0x0600D390 RID: 54160 RVA: 0x0030A57C File Offset: 0x0030877C
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

	// Token: 0x0600D391 RID: 54161 RVA: 0x0030A5F0 File Offset: 0x003087F0
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

	// Token: 0x040060C4 RID: 24772
	[Nullable(2)]
	private static UpdateFormationNotify CacheFormationNotify;

	// Token: 0x02008178 RID: 33144
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A3F1 RID: 173041
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__OnUpdateFormationNotify;
	}
}
