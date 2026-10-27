using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200295C RID: 10588
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SceneTeamModel : ModelBase
{
	// Token: 0x17001D7C RID: 7548
	// (get) Token: 0x06015E07 RID: 89607 RVA: 0x005840A8 File Offset: 0x005822A8
	// (set) Token: 0x06015E08 RID: 89608 RVA: 0x005840E8 File Offset: 0x005822E8
	public bool ChangingRole
	{
		get
		{
			if (this.ChangingRoleTime <= 0L)
			{
				return false;
			}
			if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.ChangingRoleTime > 2000L)
			{
				this.ChangingRoleTime = 0L;
				return false;
			}
			return true;
		}
		set
		{
			this.RequestingChangeRole = value;
			this.ChangingRoleTime = (value ? DateTimeOffset.Now.ToUnixTimeMilliseconds() : 0L);
		}
	}

	// Token: 0x06015E09 RID: 89609 RVA: 0x00584118 File Offset: 0x00582318
	protected override bool OnInit()
	{
		this.DefaultChangeRoleCooldown = (double)ConfigCommonParamById.GetFloatConfig("change_role_cooldown").Value;
		this.ResetChangeRoleCooldown();
		this.OnChangeRoleStat = Stat.Create("SceneTeamModel.OnChangeRoleStat", "", "STATGROUP_KuroBattle");
		this.MarkTeamNotReady();
		EventSystem.Instance.Add(EEventName.OnGlobalFootstepMaterialChange, new Action<UPhysicalMaterial>(this.OnPhysicalMaterialChange));
		return true;
	}

	// Token: 0x06015E0A RID: 89610 RVA: 0x00584181 File Offset: 0x00582381
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnGlobalFootstepMaterialChange, new Action<UPhysicalMaterial>(this.OnPhysicalMaterialChange));
		return true;
	}

	// Token: 0x06015E0B RID: 89611 RVA: 0x005841A0 File Offset: 0x005823A0
	protected override bool OnLeaveLevel()
	{
		this.FinishSeamlessUpdateTeam();
		this.ResetChangeRoleCooldown();
		if (SeamlessTravelModel.Instance.IsSeamlessTravel)
		{
			return true;
		}
		this.ClearTeam();
		return true;
	}

	// Token: 0x06015E0C RID: 89612 RVA: 0x005841C3 File Offset: 0x005823C3
	protected override bool OnChangeMode()
	{
		this.FinishSeamlessUpdateTeam();
		this.ResetChangeRoleCooldown();
		this.ClearTeam();
		return true;
	}

	// Token: 0x06015E0D RID: 89613 RVA: 0x005841D8 File Offset: 0x005823D8
	private void ClearTeam()
	{
		this.LastTransform = null;
		foreach (SceneTeamPlayer sceneTeamPlayer in this.TeamPlayerMap.Values)
		{
			sceneTeamPlayer.Clear();
		}
		this.TeamPlayerMap.Clear();
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			sceneTeamItem.Reset();
		}
		this.TeamItems.Clear();
		this.PlayerIdSet.Clear();
		this.PreloadEntitySet.Clear();
		this.PanelQteHandleId = 0;
		this.PanelQteRoleIdSet.Clear();
		this.WaitTask = null;
		this.CurrentItem = null;
		this.IsPhantomTeam = false;
		this.LastRoleIdList = null;
		GameModePromise loadTeamPromise = this.LoadTeamPromise;
		if (loadTeamPromise != null)
		{
			loadTeamPromise.SetResult(false);
		}
		this.LoadTeamPromise = null;
		this.MarkTeamNotReady();
	}

	// Token: 0x06015E0E RID: 89614 RVA: 0x005842F4 File Offset: 0x005824F4
	public void FinishSeamlessUpdateTeam()
	{
		this.IsSeamlessUpdateTeam = false;
		this.SeamlessUpdateTeamStartTime = 0L;
		if (this.IsSeamlessUpdateTeamBlockInput)
		{
			this.IsSeamlessUpdateTeamBlockInput = false;
			InputDistributeController.Instance.RefreshInputTag();
		}
		EntityHandle seamlessDelayRemoveEntityHandle = this.SeamlessDelayRemoveEntityHandle;
		if (seamlessDelayRemoveEntityHandle != null)
		{
			CreatureController.Instance.DelayRemoveEntityFinished(seamlessDelayRemoveEntityHandle);
			this.SeamlessDelayRemoveEntityHandle = null;
		}
	}

	// Token: 0x06015E0F RID: 89615 RVA: 0x00584345 File Offset: 0x00582545
	[NullableContext(2)]
	private void OnPhysicalMaterialChange(UPhysicalMaterial material)
	{
		if (this.PhysMaterial != material)
		{
			this.PhysMaterial = material;
		}
	}

	// Token: 0x06015E10 RID: 89616 RVA: 0x00584358 File Offset: 0x00582558
	public unsafe void SwitchGroup(int playerId, ETeamGroupType groupType, bool useGoBattleSkill = false, bool forceInheritState = false)
	{
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneTeam;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "切换编队组玩家不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", playerId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.SceneTeam;
		ELogAuthor author2 = ELogAuthor.LYY;
		string message2 = "切换编队组";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", playerId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GroupType", groupType);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ETeamGroupType? currentGroupType = sceneTeamPlayer.GetCurrentGroupType();
		if (groupType == currentGroupType.GetValueOrDefault() & currentGroupType != null)
		{
			return;
		}
		this.SwitchGroupInternal(playerId, sceneTeamPlayer, groupType);
		bool flag = forceInheritState;
		if (!flag)
		{
			ETeamGroupType? currentGroupType2 = this.CurrentGroupType;
			flag = this.IsNeedInherit(currentGroupType2.GetValueOrDefault(), groupType);
		}
		this.TeamGoBattle(flag, useGoBattleSkill);
	}

	// Token: 0x06015E11 RID: 89617 RVA: 0x0058445C File Offset: 0x0058265C
	private void SwitchGroupInternal(int playerId, SceneTeamPlayer player, ETeamGroupType groupType)
	{
		player.SwitchGroup(groupType);
		int? id = PlayerInfoModel.Instance.GetId();
		if (playerId == id.GetValueOrDefault() & id != null)
		{
			this.CurrentGroupType = new ETeamGroupType?(groupType);
			this.IsPhantomTeam = (groupType == ETeamGroupType.Phantom);
			EventSystem.Instance.Emit(EEventName.OnUpdateTeamGroupType);
		}
	}

	// Token: 0x06015E12 RID: 89618 RVA: 0x005844B8 File Offset: 0x005826B8
	public void UpdateGroupData(int playerId, IUpdateGroupParams @params)
	{
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer == null)
		{
			sceneTeamPlayer = SceneTeamPlayer.Create(playerId);
			this.TeamPlayerMap[playerId] = sceneTeamPlayer;
		}
		sceneTeamPlayer.UpdateGroup(@params.GroupType, @params.GroupRoleList, @params.CurrentRoleId, @params.LivingState.GetValueOrDefault(ETeamLivingState.Alive), @params.IsFixedLocation.GetValueOrDefault());
		sceneTeamPlayer.RefreshEntityEnable();
		SceneTeamPlayer valueOrDefault = this.TeamPlayerMap.GetValueOrDefault(playerId);
		ETeamGroupType? eteamGroupType = (valueOrDefault != null) ? valueOrDefault.GetCurrentGroupType() : null;
		ETeamGroupType groupType = @params.GroupType;
		ETeamGroupType? eteamGroupType2 = eteamGroupType;
		if (groupType == eteamGroupType2.GetValueOrDefault() & eteamGroupType2 != null)
		{
			this.TeamGoBattle(true, false);
		}
	}

	// Token: 0x06015E13 RID: 89619 RVA: 0x0058457C File Offset: 0x0058277C
	public void UpdateGroupDataAndSwitchGroup(int playerId, IUpdateGroupParams @params)
	{
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer == null)
		{
			sceneTeamPlayer = SceneTeamPlayer.Create(playerId);
			this.TeamPlayerMap[playerId] = sceneTeamPlayer;
		}
		ETeamGroupType groupType = @params.GroupType;
		sceneTeamPlayer.UpdateGroup(groupType, @params.GroupRoleList, @params.CurrentRoleId, @params.LivingState.GetValueOrDefault(ETeamLivingState.Alive), @params.IsFixedLocation.GetValueOrDefault());
		this.SwitchGroupInternal(playerId, sceneTeamPlayer, groupType);
		sceneTeamPlayer.RefreshEntityEnable();
		this.TeamGoBattle(true, false);
	}

	// Token: 0x06015E14 RID: 89620 RVA: 0x0058460C File Offset: 0x0058280C
	public void AddRoleAndSwitchGroup(int playerId, ETeamGroupType groupType, SceneTeamRole[] roleList)
	{
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer == null)
		{
			return;
		}
		SceneTeamGroup group = sceneTeamPlayer.GetGroup(groupType);
		if (group == null || group.GetLivingState() == ETeamLivingState.Dead)
		{
			return;
		}
		group.AddRoleList(roleList);
		this.SwitchGroupInternal(playerId, sceneTeamPlayer, groupType);
		sceneTeamPlayer.RefreshEntityEnable();
		this.TeamGoBattle(true, false);
	}

	// Token: 0x06015E15 RID: 89621 RVA: 0x00584670 File Offset: 0x00582870
	public unsafe void UpdateAllPlayerData(IList<IUpdatePlayerParams> paramsList)
	{
		List<int> list = new List<int>();
		foreach (int num in this.TeamPlayerMap.Keys)
		{
			bool flag = false;
			using (IEnumerator<IUpdatePlayerParams> enumerator2 = paramsList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.PlayerId == num)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				list.Add(num);
			}
		}
		foreach (int key in list)
		{
			if (this.TeamPlayerMap.ContainsKey(key))
			{
				this.TeamPlayerMap[key].Clear();
			}
			this.TeamPlayerMap.Remove(key);
		}
		int playerId = CreatureModel.Instance.GetPlayerId();
		ETeamGroupType? currentGroupType = this.CurrentGroupType;
		foreach (IUpdatePlayerParams updatePlayerParams in paramsList)
		{
			int playerId2 = updatePlayerParams.PlayerId;
			ETeamGroupType currentGroupType2 = updatePlayerParams.CurrentGroupType;
			SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId2) ? this.TeamPlayerMap[playerId2] : null;
			if (sceneTeamPlayer == null)
			{
				sceneTeamPlayer = SceneTeamPlayer.Create(playerId2);
				this.TeamPlayerMap[playerId2] = sceneTeamPlayer;
			}
			SceneTeamGroup currentGroup = sceneTeamPlayer.GetCurrentGroup();
			int? num2;
			if (currentGroup == null)
			{
				num2 = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num2 = ((currentRole != null) ? new int?(currentRole.RoleId) : null);
			}
			int? num3 = num2;
			bool flag2 = playerId == playerId2 && this.RequestingChangeRole;
			this.SwitchGroupInternal(playerId2, sceneTeamPlayer, currentGroupType2);
			foreach (IUpdateGroupParams updateGroupParams in updatePlayerParams.Groups)
			{
				int num4 = updateGroupParams.CurrentRoleId;
				if (flag2 && updateGroupParams.GroupType == currentGroupType2)
				{
					foreach (SceneTeamRole sceneTeamRole in updateGroupParams.GroupRoleList)
					{
						int roleId = sceneTeamRole.RoleId;
						int? num5 = num3;
						if (roleId == num5.GetValueOrDefault() & num5 != null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.SceneTeam;
							ELogAuthor author = ELogAuthor.LYY;
							string message = "更新编队组数据时，覆盖服务端当前角色";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ServerRoleId", num4);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ClientRoleId", num3);
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							num4 = num3.Value;
							break;
						}
					}
				}
				sceneTeamPlayer.UpdateGroup(updateGroupParams.GroupType, updateGroupParams.GroupRoleList, num4, updateGroupParams.LivingState.GetValueOrDefault(ETeamLivingState.Alive), updateGroupParams.IsFixedLocation.GetValueOrDefault());
			}
			sceneTeamPlayer.RefreshEntityEnable();
		}
		ETeamGroupType? currentGroupType3 = this.CurrentGroupType;
		bool needInheritState = this.IsNeedInherit(currentGroupType.GetValueOrDefault(), currentGroupType3.GetValueOrDefault());
		this.TeamGoBattle(needInheritState, false);
	}

	// Token: 0x06015E16 RID: 89622 RVA: 0x00584A40 File Offset: 0x00582C40
	private bool IsNeedInherit(ETeamGroupType lastType = ETeamGroupType.Default, ETeamGroupType newType = ETeamGroupType.Default)
	{
		return newType == lastType || SceneTeamDefine.needInheritTypeSet.Contains(lastType) || SceneTeamDefine.needInheritTypeSet.Contains(newType);
	}

	// Token: 0x06015E17 RID: 89623 RVA: 0x00584A60 File Offset: 0x00582C60
	public void UpdateGroupLivingStates(int playerId, Dictionary<ETeamGroupType, ETeamLivingState> teamLivingStateMap)
	{
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer != null)
		{
			foreach (KeyValuePair<ETeamGroupType, ETeamLivingState> keyValuePair in teamLivingStateMap)
			{
				SceneTeamGroup group = sceneTeamPlayer.GetGroup(keyValuePair.Key);
				if (group != null)
				{
					group.UpdateLivingState(keyValuePair.Value);
				}
			}
		}
	}

	// Token: 0x06015E18 RID: 89624 RVA: 0x00584AE8 File Offset: 0x00582CE8
	private void TeamGoBattle(bool needInheritState, bool useGoBattleSkill = false)
	{
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.MarkTeamNotReady();
		this.RefreshLastTransform();
		this.TeamItems.Clear();
		this.PlayerIdSet.Clear();
		if (this.SeamlessWaitUpdateTeamTimer != null)
		{
			this.SeamlessWaitUpdateTeamTimer.Remove();
			this.SeamlessWaitUpdateTeamTimer = null;
		}
		if (this.WaitTask != null)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，中断等待", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.WaitTask.Cancel();
		}
		this.TeamGoBattleStartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		SceneTeamItem goBattleItem = null;
		bool allowRefreshTransform = false;
		List<long> list = new List<long>();
		int selfPlayerId = CreatureModel.Instance.GetPlayerId();
		int[] array;
		if (!GameModeModel.Instance.IsMulti)
		{
			(array = new int[1])[0] = selfPlayerId;
		}
		else
		{
			array = OnlineModel.Instance.GetAllWorldTeamPlayer();
		}
		foreach (int num in array)
		{
			SceneTeamPlayer sceneTeamPlayer;
			SceneTeamGroup sceneTeamGroup = this.TeamPlayerMap.TryGetValue(num, out sceneTeamPlayer) ? ((sceneTeamPlayer != null) ? sceneTeamPlayer.GetCurrentGroup() : null) : null;
			List<SceneTeamRole> list2 = (sceneTeamGroup != null) ? sceneTeamGroup.GetRoleList() : null;
			if (list2 != null && list2.Count != 0)
			{
				if (num == selfPlayerId)
				{
					allowRefreshTransform = !sceneTeamGroup.IsFixedLocation;
				}
				ETeamGroupType groupType = sceneTeamGroup.GetGroupType();
				SceneTeamRole currentRole = sceneTeamGroup.GetCurrentRole();
				foreach (SceneTeamRole sceneTeamRole in list2)
				{
					long creatureDataId = sceneTeamRole.CreatureDataId;
					if (creatureDataId > 0L)
					{
						int roleId = sceneTeamRole.RoleId;
						bool flag = sceneTeamRole == currentRole;
						SceneTeamItem sceneTeamItem = SceneTeamItem.Create(groupType, num, roleId, creatureDataId);
						this.TeamItems.Add(sceneTeamItem);
						this.PlayerIdSet.Add(num);
						list.Add(creatureDataId);
						if (!sceneTeamItem.IsMyRole())
						{
							sceneTeamItem.SetRemoteIsControl(flag);
						}
						else if (flag)
						{
							goBattleItem = sceneTeamItem;
						}
					}
				}
			}
		}
		if (this.GetTeamItems(true).Count <= 0)
		{
			Log.Instance.Warn(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，当前玩家无角色实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，等待加载开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.WaitTask = WaitEntityTask.Create("SceneTeamModel.TeamGoBattle", list, delegate(bool? result)
		{
			if (result == null || !result.Value)
			{
				Log.Instance.Warn(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，加载角色失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，等待加载结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshLastTransform();
			this.ResetCurrentItem(needInheritState);
			SceneTeamItem goBattleItem = goBattleItem;
			EntityHandle entityHandle = (goBattleItem != null) ? goBattleItem.EntityHandle : null;
			SceneTeamItem currentItem = this.CurrentItem;
			EntityHandle entityHandle2 = (currentItem != null) ? currentItem.EntityHandle : null;
			EventSystem.Instance.Emit<EntityHandle, EntityHandle>(EEventName.OnBeforeUpdateSceneTeam, entityHandle, entityHandle2);
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			if (worldEntity != null && worldEntity.Valid && worldEntity.Active)
			{
				BaseTagComponent component = worldEntity.GetComponent<BaseTagComponent>();
				if (component != null && component.HasAnyTag(new int[]
				{
					GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"],
					GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]
				}))
				{
					allowRefreshTransform = false;
				}
			}
			if (goBattleItem != null && goBattleItem.CanControl(false))
			{
				if (entityHandle != null)
				{
					int id = entityHandle.Id;
					int? num2 = (entityHandle2 != null) ? new int?(entityHandle2.Id) : null;
					if (id == num2.GetValueOrDefault() & num2 != null)
					{
						this.CurrentItem = goBattleItem;
						goto IL_1D0;
					}
				}
				if (goBattleItem.GetGroupType() > ETeamGroupType.Default)
				{
					SceneTeamController.Instance.SendSwitchRole(goBattleItem);
				}
				ChangeRoleParams @params = new ChangeRoleParams
				{
					UseGoBattleSkill = new bool?(useGoBattleSkill),
					AllowRefreshTransform = new bool?(allowRefreshTransform)
				};
				this.ChangeRole(goBattleItem.GetCreatureDataId(), @params);
				IL_1D0:
				this.TeamGoBattleFinish();
				return;
			}
			Log.Instance.Warn(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，当前角色不可上阵", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (SceneTeamItem sceneTeamItem2 in this.TeamItems)
			{
				if (sceneTeamItem2.IsMyRole() && sceneTeamItem2.CanControl(false))
				{
					if (goBattleItem != null && goBattleItem.IsDead())
					{
						EntityHandle entityHandle3 = goBattleItem.EntityHandle;
						WorldEntity worldEntity2 = (entityHandle3 != null) ? entityHandle3.Entity : null;
						if (worldEntity2 != null)
						{
							worldEntity2.DisableByKey(EEntityDisableKey.GoDown, true);
							RoleTeamComponent component2 = worldEntity2.GetComponent<RoleTeamComponent>();
							if (component2 != null)
							{
								component2.SetTeamTag(ETeamState.UnderStage);
							}
						}
					}
					RequestChangeRoleParams params2 = new RequestChangeRoleParams
					{
						FilterSameRole = new bool?(false)
					};
					SceneTeamController.Instance.RequestChangeRole(sceneTeamItem2.GetCreatureDataId(), params2);
					this.TeamGoBattleFinish();
					return;
				}
			}
			Log.Instance.Warn(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，未找到存活角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (goBattleItem == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneTeam;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "刷新出战编队，数据错误，当前玩家找不到可上阵角色";
				string item = "CurrentRole";
				object item2;
				if (!this.TeamPlayerMap.ContainsKey(selfPlayerId))
				{
					item2 = null;
				}
				else
				{
					SceneTeamPlayer sceneTeamPlayer2 = this.TeamPlayerMap[selfPlayerId];
					if (sceneTeamPlayer2 == null)
					{
						item2 = null;
					}
					else
					{
						SceneTeamGroup currentGroup = sceneTeamPlayer2.GetCurrentGroup();
						item2 = ((currentGroup != null) ? currentGroup.GetCurrentRole() : null);
					}
				}
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, item2);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.TeamGoBattleFinish();
				return;
			}
			ChangeRoleParams params3 = new ChangeRoleParams
			{
				ForceChangeRole = new bool?(true),
				AllowRefreshTransform = new bool?(true)
			};
			this.ChangeRole(goBattleItem.GetCreatureDataId(), params3);
			EntityHandle entityHandle4 = goBattleItem.EntityHandle;
			WorldEntity worldEntity3 = (entityHandle4 != null) ? entityHandle4.Entity : null;
			if (worldEntity3 != null)
			{
				worldEntity3.DisableByKey(EEntityDisableKey.GoDown, true);
			}
			this.TeamGoBattleFinish();
		}, -1, true, false);
	}

	// Token: 0x06015E19 RID: 89625 RVA: 0x00584DA8 File Offset: 0x00582FA8
	private void ResetCurrentItem(bool needInheritState)
	{
		if (this.CurrentItem == null)
		{
			return;
		}
		EntityHandle entityHandle = this.CurrentItem.EntityHandle;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity != null)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null && baseCharacter.IsValid())
			{
				if (needInheritState)
				{
					return;
				}
				SceneTeamPlayer teamPlayerData = this.GetTeamPlayerData(CreatureModel.Instance.GetPlayerId());
				if (!((teamPlayerData != null) ? new bool?(teamPlayerData.IsRoleOnStageWithoutControl(this.CurrentItem.GetCreatureDataId())) : null).GetValueOrDefault())
				{
					worldEntity.DisableByKey(EEntityDisableKey.GoDown, true);
					RoleTeamComponent component = worldEntity.GetComponent<RoleTeamComponent>();
					if (component != null)
					{
						component.SetTeamTag(ETeamState.UnderStage);
					}
				}
				this.CurrentItem = null;
				return;
			}
		}
		this.CurrentItem = null;
	}

	// Token: 0x06015E1A RID: 89626 RVA: 0x00584E5C File Offset: 0x0058305C
	private void TeamGoBattleFinish()
	{
		if (this.SeamlessUpdateTeamStartTime > 0L && this.TeamGoBattleStartTime > this.SeamlessUpdateTeamStartTime)
		{
			this.FinishSeamlessUpdateTeam();
		}
		this.WaitTask = null;
		this.IsTeamReady = true;
		GameModePromise loadTeamPromise = this.LoadTeamPromise;
		if (loadTeamPromise != null)
		{
			loadTeamPromise.SetResult(true);
		}
		this.LoadTeamPromise = null;
		this.NotifyTeamChange();
		Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "刷新出战编队，结束", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06015E1B RID: 89627 RVA: 0x00584ED0 File Offset: 0x005830D0
	private void NotifyTeamChange()
	{
		ETeamGroupType? currentGroupType = this.CurrentGroupType;
		if (currentGroupType == null || SceneTeamDefine.innerGroupType.Contains(currentGroupType.Value))
		{
			return;
		}
		if (!GameModeModel.Instance.IsMulti && currentGroupType.GetValueOrDefault() == ETeamGroupType.Battle)
		{
			int[] array = this.LastRoleIdList ?? new int[0];
			List<int> list = new List<int>();
			foreach (SceneTeamItem sceneTeamItem in this.GetTeamItems(false))
			{
				list.Add(sceneTeamItem.GetConfigId);
			}
			for (int i = 0; i < 4; i++)
			{
				int num = (i < array.Length) ? array[i] : 0;
				int num2 = (i < list.Count) ? list[i] : 0;
				if (num != num2)
				{
					if (num > 0)
					{
						EventSystem.Instance.Emit<int>(EEventName.RedDotRoleChange, num);
					}
					if (num2 > 0)
					{
						EventSystem.Instance.Emit<int>(EEventName.RedDotRoleChange, num2);
					}
				}
			}
			this.LastRoleIdList = list.ToArray();
		}
		EventSystem.Instance.Emit(EEventName.OnUpdateSceneTeam);
		if (GlobalData.GameInstance != null)
		{
			GlobalData.BpEventManager.当编队更新时.Broadcast();
		}
	}

	// Token: 0x06015E1C RID: 89628 RVA: 0x00585020 File Offset: 0x00583220
	public void OnAddEntity(EntityHandle handle)
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component.GetEntityType() != EEntityType.Player)
		{
			return;
		}
		long creatureDataId = component.GetCreatureDataId();
		CreatureModel instance = CreatureModel.Instance;
		foreach (SceneTeamItem sceneTeamItem in this.GetTeamItems(false))
		{
			if (creatureDataId == sceneTeamItem.GetCreatureDataId())
			{
				EntityHandle entity = instance.GetEntity(creatureDataId);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				ScenePlayerData scenePlayerData = instance.GetScenePlayerData(sceneTeamItem.GetPlayerId());
				bool? flag = (scenePlayerData != null) ? new bool?(scenePlayerData.IsRemoteSceneLoading()) : null;
				if (worldEntity != null && flag.GetValueOrDefault())
				{
					worldEntity.DisableByKey(EEntityDisableKey.GoDown, true);
				}
			}
		}
		if (SceneTeamModel.Instance.IsTeamReady)
		{
			foreach (SceneTeamItem sceneTeamItem2 in this.TeamItems)
			{
				if (sceneTeamItem2.GetCreatureDataId() == creatureDataId)
				{
					Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "更新联机场景队伍", default(ReadOnlySpan<ValueTuple<string, object>>));
					sceneTeamItem2.UpdateEntityHandle();
					this.NotifyTeamChange();
					break;
				}
			}
		}
	}

	// Token: 0x06015E1D RID: 89629 RVA: 0x0058517C File Offset: 0x0058337C
	public void OnRemoveEntity(EntityHandle handle)
	{
		WorldEntity entity = handle.Entity;
		long creatureDataId = entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		this.PreloadEntitySet.Remove(creatureDataId);
		int id = handle.Id;
		EntityHandle getCurrentEntity = this.GetCurrentEntity;
		int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
		if (id == num.GetValueOrDefault() & num != null)
		{
			this.LastEntityIsOnGround = (entity.GetComponent<BaseUnifiedStateComponent>().PositionState == global::ECharPositionState.Ground);
			if (!GameModeModel.Instance.IsMulti)
			{
				this.RefreshLastTransform();
			}
			this.MarkTeamNotReady();
		}
	}

	// Token: 0x06015E1E RID: 89630 RVA: 0x0058520E File Offset: 0x0058340E
	private void MarkTeamNotReady()
	{
		this.IsTeamReady = false;
		if (this.LoadTeamPromise == null)
		{
			this.LoadTeamPromise = new GameModePromise();
		}
	}

	// Token: 0x06015E1F RID: 89631 RVA: 0x0058522C File Offset: 0x0058342C
	public void AddPreloadEntity(long creatureDataId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "添加预加载角色实体";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.PreloadEntitySet.Add(creatureDataId);
	}

	// Token: 0x06015E20 RID: 89632 RVA: 0x00585274 File Offset: 0x00583474
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<long, EntityHandle>? GetPreloadEntityData(int roleId)
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		foreach (long num in this.PreloadEntitySet)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(num);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (worldEntity != null && worldEntity.Valid)
			{
				CreatureDataComponent component = worldEntity.GetComponent<CreatureDataComponent>();
				if (component != null && component.GetPlayerId() == playerId)
				{
					int roleId2 = component.GetRoleId();
					if (this.IsRoleMatch(roleId2, roleId))
					{
						return new ValueTuple<long, EntityHandle>?(new ValueTuple<long, EntityHandle>(num, entity));
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06015E21 RID: 89633 RVA: 0x00585340 File Offset: 0x00583540
	private bool IsRoleMatch(int realRoleId, int targetRoleId)
	{
		if (realRoleId == targetRoleId)
		{
			return true;
		}
		if (realRoleId > 100000)
		{
			TrialRoleInfo? config = ConfigTrialRoleInfoById.GetConfig(realRoleId, true);
			if (config != null && config.GetValueOrDefault().GroupId == targetRoleId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17001D7D RID: 7549
	// (get) Token: 0x06015E22 RID: 89634 RVA: 0x00585386 File Offset: 0x00583586
	[Nullable(2)]
	public SceneTeamItem GetCurrentTeamItem
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentItem;
		}
	}

	// Token: 0x17001D7E RID: 7550
	// (get) Token: 0x06015E23 RID: 89635 RVA: 0x0058538E File Offset: 0x0058358E
	[Nullable(2)]
	public EntityHandle GetCurrentEntity
	{
		[NullableContext(2)]
		get
		{
			SceneTeamItem currentItem = this.CurrentItem;
			if (currentItem == null)
			{
				return null;
			}
			return currentItem.EntityHandle;
		}
	}

	// Token: 0x17001D7F RID: 7551
	// (get) Token: 0x06015E24 RID: 89636 RVA: 0x005853A1 File Offset: 0x005835A1
	[Nullable(2)]
	public UPhysicalMaterial GetPhysMaterial
	{
		[NullableContext(2)]
		get
		{
			return this.PhysMaterial;
		}
	}

	// Token: 0x06015E25 RID: 89637 RVA: 0x005853A9 File Offset: 0x005835A9
	public int GetTeamLength()
	{
		return this.TeamItems.Count;
	}

	// Token: 0x06015E26 RID: 89638 RVA: 0x005853B6 File Offset: 0x005835B6
	public int GetTeamPlayerSize()
	{
		return this.PlayerIdSet.Count;
	}

	// Token: 0x06015E27 RID: 89639 RVA: 0x005853C4 File Offset: 0x005835C4
	[return: Nullable(2)]
	public SceneTeamItem GetTeamItem(long param, IGetTeamItemOptions options)
	{
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			if (this.IsItemMatch(sceneTeamItem, param, options))
			{
				return sceneTeamItem;
			}
		}
		return null;
	}

	// Token: 0x06015E28 RID: 89640 RVA: 0x00585424 File Offset: 0x00583624
	private bool IsItemMatch(SceneTeamItem item, long param, IGetTeamItemOptions options)
	{
		if (options.OnlyMyRole.GetValueOrDefault() && !item.IsMyRole())
		{
			return false;
		}
		if (options.IsControl.GetValueOrDefault() && !item.IsControl())
		{
			return false;
		}
		switch (options.ParamType)
		{
		case ETeamParamType.ConfigId:
			return (long)item.GetConfigId == param;
		case ETeamParamType.EntityId:
		{
			EntityHandle entityHandle = item.EntityHandle;
			int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
			long? num2 = (num != null) ? new long?((long)num.GetValueOrDefault()) : null;
			return num2.GetValueOrDefault() == param & num2 != null;
		}
		case ETeamParamType.PlayerId:
			return (long)item.GetPlayerId() == param;
		case ETeamParamType.CreatureDataId:
			return item.GetCreatureDataId() == param;
		default:
			return false;
		}
	}

	// Token: 0x06015E29 RID: 89641 RVA: 0x00585500 File Offset: 0x00583700
	public List<SceneTeamItem> GetTeamItems(bool onlyMyRole = false)
	{
		List<SceneTeamItem> list = new List<SceneTeamItem>();
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			if (!onlyMyRole || sceneTeamItem.IsMyRole())
			{
				list.Add(sceneTeamItem);
			}
		}
		return list;
	}

	// Token: 0x06015E2A RID: 89642 RVA: 0x00585568 File Offset: 0x00583768
	public List<SceneTeamItem> GetTeamItemsByPlayer(int playerId)
	{
		List<SceneTeamItem> list = new List<SceneTeamItem>();
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			if (sceneTeamItem.GetPlayerId() == playerId)
			{
				list.Add(sceneTeamItem);
			}
		}
		return list;
	}

	// Token: 0x06015E2B RID: 89643 RVA: 0x005855CC File Offset: 0x005837CC
	public List<int> GetTeamRoleConfigIdList(bool onlyMyRole = false, bool getBaseRoleId = false)
	{
		List<int> list = new List<int>();
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			if (!onlyMyRole || sceneTeamItem.IsMyRole())
			{
				if (!getBaseRoleId)
				{
					list.Add(sceneTeamItem.GetConfigId);
				}
				else
				{
					list.Add(RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId));
				}
			}
		}
		return list;
	}

	// Token: 0x06015E2C RID: 89644 RVA: 0x00585654 File Offset: 0x00583854
	public List<EntityHandle> GetTeamEntities(bool onlyMyRole = false)
	{
		List<EntityHandle> list = new List<EntityHandle>();
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			if (!onlyMyRole || sceneTeamItem.IsMyRole())
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				if (entityHandle != null)
				{
					list.Add(entityHandle);
				}
			}
		}
		return list;
	}

	// Token: 0x06015E2D RID: 89645 RVA: 0x005856C4 File Offset: 0x005838C4
	public List<EntityHandle> GetAllGroupEntities(int playerId)
	{
		List<EntityHandle> list = new List<EntityHandle>();
		SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap.ContainsKey(playerId) ? this.TeamPlayerMap[playerId] : null;
		if (sceneTeamPlayer == null)
		{
			return list;
		}
		CreatureModel instance = CreatureModel.Instance;
		foreach (SceneTeamGroup sceneTeamGroup in sceneTeamPlayer.GetGroupList())
		{
			foreach (SceneTeamRole sceneTeamRole in sceneTeamGroup.GetRoleList())
			{
				EntityHandle entity = instance.GetEntity(sceneTeamRole.CreatureDataId);
				if (entity != null && entity.IsInit)
				{
					list.Add(entity);
				}
			}
		}
		return list;
	}

	// Token: 0x06015E2E RID: 89646 RVA: 0x005857A0 File Offset: 0x005839A0
	public List<SceneTeamItem> GetTeamItemsInRange(global::Vector location, float distance)
	{
		List<SceneTeamItem> list = new List<SceneTeamItem>();
		float num = distance * distance;
		foreach (SceneTeamItem sceneTeamItem in this.TeamItems)
		{
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			if (((entityHandle != null) ? entityHandle.Entity : null) != null)
			{
				ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(sceneTeamItem.GetPlayerId());
				global::Vector vector = (scenePlayerData != null) ? scenePlayerData.GetLocation() : null;
				if (vector != null && global::Vector.DistSquared(location, vector) <= (double)num)
				{
					list.Add(sceneTeamItem);
				}
			}
		}
		return list;
	}

	// Token: 0x06015E2F RID: 89647 RVA: 0x00585840 File Offset: 0x00583A40
	[NullableContext(2)]
	public SceneTeamPlayer GetTeamPlayerData(int playerId)
	{
		if (!this.TeamPlayerMap.ContainsKey(playerId))
		{
			return null;
		}
		return this.TeamPlayerMap[playerId];
	}

	// Token: 0x06015E30 RID: 89648 RVA: 0x00585860 File Offset: 0x00583A60
	public bool HasPhantomRole()
	{
		foreach (SceneTeamItem sceneTeamItem in this.GetTeamItems(true))
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(sceneTeamItem.GetConfigId);
			if (roleConfig != null && roleConfig.GetValueOrDefault().RoleType == 2)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06015E31 RID: 89649 RVA: 0x005858E8 File Offset: 0x00583AE8
	[NullableContext(2)]
	public void ChangeRole(long creatureDataId, IChangeRoleParams @params = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "开始切换角色";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SceneTeamItem teamItem = this.GetTeamItem(creatureDataId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.CreatureDataId
		});
		if (teamItem == null || !teamItem.IsMyRole())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneTeam;
			ELogAuthor author2 = ELogAuthor.LYY;
			string message2 = "队伍实例不存在或非本机角色";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		bool valueOrDefault = ((@params != null) ? @params.ForceChangeRole : null).GetValueOrDefault();
		if (!teamItem.CanControl(valueOrDefault))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SceneTeam;
			ELogAuthor author3 = ELogAuthor.LYY;
			string message3 = "角色不允许操控";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		SceneTeamItem getCurrentTeamItem = this.GetCurrentTeamItem;
		EntityHandle entityHandle = (getCurrentTeamItem != null) ? getCurrentTeamItem.EntityHandle : null;
		EntityHandle entityHandle2 = teamItem.EntityHandle;
		if (entityHandle2 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.SceneTeam;
			ELogAuthor author4 = ELogAuthor.LYY;
			string message4 = "角色实体无效";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return;
		}
		WorldEntity entity = entityHandle2.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		if (creatureDataComponent == null || creatureDataComponent.GetRemoveState())
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.SceneTeam;
			ELogAuthor author5 = ELogAuthor.HYJ;
			string message5 = "角色实体删除中";
			ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
			instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
		}
		int? id = PlayerInfoModel.Instance.GetId();
		if (this.TeamPlayerMap.ContainsKey(id.Value))
		{
			SceneTeamGroup currentGroup = this.TeamPlayerMap[id.Value].GetCurrentGroup();
			if (currentGroup != null)
			{
				currentGroup.SetCurrentRole(teamItem.GetCreatureDataId());
			}
		}
		this.CurrentItem = teamItem;
		EventSystem.Instance.Emit<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, entityHandle2, entityHandle);
		bool valueOrDefault2 = ((@params != null) ? @params.UseGoBattleSkill : null).GetValueOrDefault();
		double valueOrDefault3 = ((@params != null) ? @params.CoolDown : null).GetValueOrDefault();
		bool valueOrDefault4 = ((@params != null) ? @params.GoDownWaitSkillEnd : null).GetValueOrDefault();
		bool? flag = (@params != null) ? @params.AllowRefreshTransform : null;
		bool? flag2;
		if (flag == null)
		{
			WorldEntity entity2 = entityHandle2.Entity;
			flag2 = ((entity2 != null) ? new bool?(!entity2.Active) : null);
		}
		else
		{
			flag2 = flag;
		}
		bool? flag3 = flag2;
		bool valueOrDefault5 = ((@params != null) ? @params.ForceInheritTransform : null).GetValueOrDefault(true);
		RoleTeamComponent.OnChangeRole(entityHandle, entityHandle2, valueOrDefault2, valueOrDefault3, valueOrDefault4, flag3.GetValueOrDefault(), valueOrDefault5);
		if (entityHandle != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnRoleGoDown, entityHandle.Id);
		}
		EventSystem.Instance.Emit<EntityHandle, EntityHandle>(EEventName.OnChangeRole, entityHandle2, entityHandle);
	}

	// Token: 0x06015E32 RID: 89650 RVA: 0x00585BC4 File Offset: 0x00583DC4
	public void OtherPlayerChangeRole(int playerId, long newCreatureDataId)
	{
		if (this.TeamPlayerMap.ContainsKey(playerId))
		{
			SceneTeamGroup currentGroup = this.TeamPlayerMap[playerId].GetCurrentGroup();
			if (currentGroup == null)
			{
				return;
			}
			currentGroup.SetCurrentRole(newCreatureDataId);
		}
	}

	// Token: 0x06015E33 RID: 89651 RVA: 0x00585BF0 File Offset: 0x00583DF0
	public void RefreshLastTransform()
	{
		EntityHandle getCurrentEntity = this.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return;
		}
		AActor actor = CharacterController.Instance.GetActor(getCurrentEntity);
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		FTransformDouble value = actor.D_GetTransform();
		this.LastTransform = new FTransformDouble?(value);
	}

	// Token: 0x06015E34 RID: 89652 RVA: 0x00585C47 File Offset: 0x00583E47
	public void SetLastTransform(FTransformDouble? transform)
	{
		this.LastTransform = transform;
	}

	// Token: 0x06015E35 RID: 89653 RVA: 0x00585C50 File Offset: 0x00583E50
	public FTransformDouble? GetSpawnTransform()
	{
		FTransformDouble? lastTransform = this.LastTransform;
		if (lastTransform != null)
		{
			return lastTransform;
		}
		EntityHandle getCurrentEntity = this.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			return new FTransformDouble?(getCurrentEntity.Entity.GetComponent<CharacterActorComponent>().Actor.D_GetTransform());
		}
		UWorld world = GlobalData.World;
		if (world != null)
		{
			FVectorDouble? fvectorDouble = null;
			FRotator? frotator = null;
			EBornMode ebornMode = UiBlueprintFunctionLibrary.TestSceneLoadBornMode();
			if (ebornMode == EBornMode.PlayLocationCurrentCameraLocation)
			{
				fvectorDouble = new FVectorDouble?(UiBlueprintFunctionLibrary.TempLocation.ToUeVector(false));
				FRotator value = UiBlueprintFunctionLibrary.TempRotator.ToUeRotator();
				value.Roll = 0f;
				value.Pitch = 0f;
				frotator = new FRotator?(value);
			}
			else if (ebornMode == EBornMode.PlayLocationDefaultPlayerStart)
			{
				TArray<AActor> tarray = new TArray<AActor>();
				UGameplayStatics.GetAllActorsOfClass(world, APlayerStart.StaticClass(), ref tarray);
				FTransformDouble ftransformDouble = tarray.Get(0).D_GetTransform();
				fvectorDouble = new FVectorDouble?(ftransformDouble.GetLocation());
				frotator = new FRotator?(ftransformDouble.Rotator());
			}
			return new FTransformDouble?(UKismetMathLibrary.MakeTransformDouble(fvectorDouble.Value, frotator.Value, new FVector(1f, 1f, 1f)));
		}
		return null;
	}

	// Token: 0x06015E36 RID: 89654 RVA: 0x00585D84 File Offset: 0x00583F84
	public double GetChangeRoleCooldown()
	{
		return this.ChangeRoleCooldown;
	}

	// Token: 0x06015E37 RID: 89655 RVA: 0x00585D8C File Offset: 0x00583F8C
	public void ResetChangeRoleCooldown()
	{
		this.ChangeRoleCooldown = this.DefaultChangeRoleCooldown;
	}

	// Token: 0x06015E38 RID: 89656 RVA: 0x00585D9A File Offset: 0x00583F9A
	public void UpdateChangeRoleCooldown(float time)
	{
		this.ChangeRoleCooldown = (double)time;
	}

	// Token: 0x06015E39 RID: 89657 RVA: 0x00585DA4 File Offset: 0x00583FA4
	public unsafe void RoleDeathEnded(int entityId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SceneTeam;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "开始执行队伍角色死亡逻辑";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		SceneTeamItem teamItem = this.GetTeamItem((long)entityId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.EntityId
		});
		WorldEntity worldEntity;
		if (teamItem == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityHandle = teamItem.EntityHandle;
			worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "无法获取死亡角色Entity", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ETeamGroupType groupType = teamItem.GetGroupType();
		int playerId = teamItem.GetPlayerId();
		SceneTeamGroup sceneTeamGroup;
		if (!this.TeamPlayerMap.ContainsKey(playerId))
		{
			sceneTeamGroup = null;
		}
		else
		{
			SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap[playerId];
			sceneTeamGroup = ((sceneTeamPlayer != null) ? sceneTeamPlayer.GetCurrentGroup() : null);
		}
		SceneTeamGroup sceneTeamGroup2 = sceneTeamGroup;
		if (sceneTeamGroup2 == null || groupType != sceneTeamGroup2.GetGroupType())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneTeam;
			ELogAuthor author2 = ELogAuthor.LYY;
			string message2 = "死亡角色非玩家当前编队";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeadGroupType", groupType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentGroupType", (sceneTeamGroup2 != null) ? new ETeamGroupType?(sceneTeamGroup2.GetGroupType()) : null);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (sceneTeamGroup2.GetLivingState() == ETeamLivingState.Dead || teamItem.IsAutoRole())
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "隐藏死亡角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			worldEntity2.DisableByKey(EEntityDisableKey.GoDown, true);
			return;
		}
		CharacterActorComponent component = worldEntity2.GetComponent<CharacterActorComponent>();
		if (component == null || !component.IsAutonomousProxy)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "非逻辑主控死亡不进行切人", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		SceneTeamItem getCurrentTeamItem = this.GetCurrentTeamItem;
		if (getCurrentTeamItem == null)
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "死亡时编队无当前角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!getCurrentTeamItem.IsDead())
		{
			Log.Instance.Info(ELogModule.SceneTeam, ELogAuthor.LYY, "当前角色未死亡", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (SceneTeamItem sceneTeamItem in this.GetTeamItems(true))
		{
			if (sceneTeamItem.CanControl(false))
			{
				long creatureDataId = sceneTeamItem.GetCreatureDataId();
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneTeam;
				ELogAuthor author3 = ELogAuthor.LYY;
				string message3 = "前台角色死亡进行切人";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				RequestChangeRoleParams @params = new RequestChangeRoleParams
				{
					GoBattleInvincible = new bool?(true)
				};
				SceneTeamController.Instance.RequestChangeRole(creatureDataId, @params);
				break;
			}
		}
	}

	// Token: 0x06015E3A RID: 89658 RVA: 0x00586050 File Offset: 0x00584250
	public bool IsAllDid()
	{
		using (List<SceneTeamItem>.Enumerator enumerator = this.TeamItems.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsDead())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06015E3B RID: 89659 RVA: 0x005860AC File Offset: 0x005842AC
	public ETeamLivingState GetCurrentGroupLivingState(int playerId)
	{
		SceneTeamGroup sceneTeamGroup;
		if (!this.TeamPlayerMap.ContainsKey(playerId))
		{
			sceneTeamGroup = null;
		}
		else
		{
			SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap[playerId];
			sceneTeamGroup = ((sceneTeamPlayer != null) ? sceneTeamPlayer.GetCurrentGroup() : null);
		}
		SceneTeamGroup sceneTeamGroup2 = sceneTeamGroup;
		if (sceneTeamGroup2 == null)
		{
			return ETeamLivingState.Unknown;
		}
		return sceneTeamGroup2.GetLivingState();
	}

	// Token: 0x06015E3C RID: 89660 RVA: 0x005860F0 File Offset: 0x005842F0
	public ETeamLivingState GetGroupLivingState(int playerId, ETeamGroupType groupType)
	{
		SceneTeamGroup sceneTeamGroup;
		if (!this.TeamPlayerMap.ContainsKey(playerId))
		{
			sceneTeamGroup = null;
		}
		else
		{
			SceneTeamPlayer sceneTeamPlayer = this.TeamPlayerMap[playerId];
			sceneTeamGroup = ((sceneTeamPlayer != null) ? sceneTeamPlayer.GetGroup(groupType) : null);
		}
		SceneTeamGroup sceneTeamGroup2 = sceneTeamGroup;
		if (sceneTeamGroup2 == null)
		{
			return ETeamLivingState.Unknown;
		}
		return sceneTeamGroup2.GetLivingState();
	}

	// Token: 0x06015E3D RID: 89661 RVA: 0x00586134 File Offset: 0x00584334
	public void InitializeOfflineSceneTeam(int aConfigId, int bConfigId, int cConfigId)
	{
		if (AActor.GetKuroNetMode() == EKuroNetMode.KNM_Net)
		{
			return;
		}
		long[] array = new long[]
		{
			CreatureController.Instance.GenUniqueId(),
			CreatureController.Instance.GenUniqueId(),
			CreatureController.Instance.GenUniqueId()
		};
		int num = 100003;
		int[] array2 = new int[]
		{
			(aConfigId > 0) ? aConfigId : num,
			(bConfigId > 0) ? bConfigId : num,
			(cConfigId > 0) ? cConfigId : num
		};
		FTransformDouble? spawnTransform = this.GetSpawnTransform();
		if (spawnTransform == null)
		{
			Log.Instance.Error(ELogModule.SceneTeam, ELogAuthor.LYY, "初始化失败队伍失败，GetSpawnTransform为空���", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<SceneTeamRole> groupRoleList = new List<SceneTeamRole>();
		int num2 = array2.Length;
		int loadCount = num2;
		for (int i = 1; i <= num2; i++)
		{
			long num3 = array[i - 1];
			int playerId = CreatureModel.Instance.GetPlayerId();
			int roleId = array2[i - 1];
			EntityPb entityPb = EntityPb.Create();
			entityPb.Id = MathUtils.Instance.NumberToLong(num3);
			entityPb.Pos = WorldGlobal.ToTsVector(spawnTransform.Value.GetLocation());
			entityPb.Rot = WorldGlobal.ToTsRotator(spawnTransform.Value.GetRotation().Rotator());
			entityPb.IsVisible = true;
			entityPb.PlayerId = CreatureModel.Instance.GetPlayerId();
			entityPb.EntityType = 0;
			entityPb.ConfigType = EntityConfigType.Character;
			entityPb.ConfigId = array2[i - 1];
			EntityHandle entityHandle = CreatureController.Instance.CreateEntity(entityPb, "InitializeOfflineSceneTeam");
			SceneTeamRole sceneTeamRole = new SceneTeamRole();
			sceneTeamRole.CreatureDataId = num3;
			sceneTeamRole.RoleId = roleId;
			groupRoleList.Add(sceneTeamRole);
			CreatureController.Instance.LoadEntityAsync(entityHandle, delegate(ELoadResultType result)
			{
				if (result == ELoadResultType.None)
				{
					return;
				}
				int loadCount = loadCount;
				loadCount--;
				EntityHandle entityHandle = entityHandle;
				WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
				if (worldEntity != null)
				{
					RoleTeamComponent roleTeamComponent = worldEntity.CheckGetComponent<RoleTeamComponent>();
					if (roleTeamComponent != null)
					{
						roleTeamComponent.SetTeamTag(ETeamState.UnderStage);
					}
					worldEntity.DisableByKey(EEntityDisableKey.GoDown, true);
				}
				if (loadCount == 0)
				{
					UpdateGroupParams @params = new UpdateGroupParams
					{
						GroupType = ETeamGroupType.Battle,
						GroupRoleList = groupRoleList,
						CurrentRoleId = groupRoleList[0].RoleId
					};
					this.UpdateGroupData(playerId, @params);
					this.SwitchGroup(playerId, ETeamGroupType.Battle, false, false);
				}
			}, false);
		}
	}

	// Token: 0x17001D80 RID: 7552
	// (get) Token: 0x06015E3E RID: 89662 RVA: 0x0058633A File Offset: 0x0058453A
	public static SceneTeamModel Instance
	{
		get
		{
			return SceneTeamModel._Instance;
		}
	}

	// Token: 0x06015E3F RID: 89663 RVA: 0x00586341 File Offset: 0x00584541
	public static SceneTeamModel GetOrCreateInstance()
	{
		if (SceneTeamModel._Instance == null)
		{
			SceneTeamModel.CreateInstance();
		}
		return SceneTeamModel._Instance;
	}

	// Token: 0x06015E40 RID: 89664 RVA: 0x00586355 File Offset: 0x00584555
	public static bool CreateInstance()
	{
		if (SceneTeamModel._Instance != null)
		{
			return true;
		}
		SceneTeamModel._Instance = new SceneTeamModel();
		return true;
	}

	// Token: 0x06015E41 RID: 89665 RVA: 0x0058636B File Offset: 0x0058456B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015E42 RID: 89666 RVA: 0x0058636D File Offset: 0x0058456D
	public static void ResetStaticDefaultValue()
	{
		SceneTeamModel._Instance = null;
	}

	// Token: 0x06015E43 RID: 89667 RVA: 0x00586375 File Offset: 0x00584575
	static SceneTeamModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneTeamModel.CreateStaticDefaultValue), new Action(SceneTeamModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2D8 RID: 41688
	[Nullable(2)]
	private Stat OnChangeRoleStat;

	// Token: 0x0400A2D9 RID: 41689
	private readonly Dictionary<int, SceneTeamPlayer> TeamPlayerMap = new Dictionary<int, SceneTeamPlayer>();

	// Token: 0x0400A2DA RID: 41690
	private readonly List<SceneTeamItem> TeamItems = new List<SceneTeamItem>();

	// Token: 0x0400A2DB RID: 41691
	private readonly HashSet<int> PlayerIdSet = new HashSet<int>();

	// Token: 0x0400A2DC RID: 41692
	private readonly HashSet<long> PreloadEntitySet = new HashSet<long>();

	// Token: 0x0400A2DD RID: 41693
	public ETeamGroupType? CurrentGroupType;

	// Token: 0x0400A2DE RID: 41694
	[Nullable(2)]
	private WaitEntityTask WaitTask;

	// Token: 0x0400A2DF RID: 41695
	[Nullable(2)]
	private int[] LastRoleIdList;

	// Token: 0x0400A2E0 RID: 41696
	private long TeamGoBattleStartTime;

	// Token: 0x0400A2E1 RID: 41697
	[Nullable(2)]
	private SceneTeamItem CurrentItem;

	// Token: 0x0400A2E2 RID: 41698
	public bool IsTeamReady;

	// Token: 0x0400A2E3 RID: 41699
	public bool IsPhantomTeam;

	// Token: 0x0400A2E4 RID: 41700
	public int PanelQteHandleId;

	// Token: 0x0400A2E5 RID: 41701
	public readonly HashSet<int> PanelQteRoleIdSet = new HashSet<int>();

	// Token: 0x0400A2E6 RID: 41702
	public bool PanelQteShowTrialRoleTips;

	// Token: 0x0400A2E7 RID: 41703
	private double ChangeRoleCooldown;

	// Token: 0x0400A2E8 RID: 41704
	private double DefaultChangeRoleCooldown;

	// Token: 0x0400A2E9 RID: 41705
	private FTransformDouble? LastTransform;

	// Token: 0x0400A2EA RID: 41706
	public bool LastEntityIsOnGround = true;

	// Token: 0x0400A2EB RID: 41707
	[Nullable(2)]
	public GameModePromise LoadTeamPromise;

	// Token: 0x0400A2EC RID: 41708
	[Nullable(2)]
	private UPhysicalMaterial PhysMaterial;

	// Token: 0x0400A2ED RID: 41709
	private long ChangingRoleTime;

	// Token: 0x0400A2EE RID: 41710
	private bool RequestingChangeRole;

	// Token: 0x0400A2EF RID: 41711
	public bool IsSeamlessUpdateTeam;

	// Token: 0x0400A2F0 RID: 41712
	public long SeamlessUpdateTeamStartTime;

	// Token: 0x0400A2F1 RID: 41713
	public bool IsSeamlessUpdateTeamBlockInput;

	// Token: 0x0400A2F2 RID: 41714
	[Nullable(2)]
	public EntityHandle SeamlessDelayRemoveEntityHandle;

	// Token: 0x0400A2F3 RID: 41715
	[Nullable(2)]
	public TimerHandle SeamlessWaitUpdateTeamTimer;

	// Token: 0x0400A2F4 RID: 41716
	[Nullable(2)]
	private static SceneTeamModel _Instance;
}
