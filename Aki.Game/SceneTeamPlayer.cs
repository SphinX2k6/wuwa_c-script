using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Plot;

// Token: 0x0200294B RID: 10571
[NullableContext(1)]
[Nullable(0)]
public class SceneTeamPlayer
{
	// Token: 0x06015D8E RID: 89486 RVA: 0x00583337 File Offset: 0x00581537
	public static SceneTeamPlayer Create(int playerId)
	{
		return new SceneTeamPlayer
		{
			PlayerId = playerId
		};
	}

	// Token: 0x06015D8F RID: 89487 RVA: 0x00583348 File Offset: 0x00581548
	public void Clear()
	{
		this.CurrentGroupType = null;
		foreach (SceneTeamGroup sceneTeamGroup in this.GroupMap.Values)
		{
			sceneTeamGroup.Clear();
		}
		this.GroupMap.Clear();
	}

	// Token: 0x06015D90 RID: 89488 RVA: 0x005833B4 File Offset: 0x005815B4
	public ETeamGroupType? GetCurrentGroupType()
	{
		return this.CurrentGroupType;
	}

	// Token: 0x06015D91 RID: 89489 RVA: 0x005833BC File Offset: 0x005815BC
	[NullableContext(2)]
	public SceneTeamGroup GetCurrentGroup()
	{
		if (this.CurrentGroupType == null)
		{
			return null;
		}
		if (!this.GroupMap.ContainsKey(this.CurrentGroupType.Value))
		{
			return null;
		}
		return this.GroupMap[this.CurrentGroupType.Value];
	}

	// Token: 0x06015D92 RID: 89490 RVA: 0x00583408 File Offset: 0x00581608
	[NullableContext(2)]
	public SceneTeamGroup GetGroup(ETeamGroupType groupType)
	{
		if (!this.GroupMap.ContainsKey(groupType))
		{
			return null;
		}
		return this.GroupMap[groupType];
	}

	// Token: 0x06015D93 RID: 89491 RVA: 0x00583428 File Offset: 0x00581628
	public List<SceneTeamGroup> GetGroupList()
	{
		List<SceneTeamGroup> list = new List<SceneTeamGroup>();
		foreach (SceneTeamGroup item in this.GroupMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06015D94 RID: 89492 RVA: 0x00583488 File Offset: 0x00581688
	public void SwitchGroup(ETeamGroupType groupType)
	{
		this.CurrentGroupType = new ETeamGroupType?(groupType);
	}

	// Token: 0x06015D95 RID: 89493 RVA: 0x00583498 File Offset: 0x00581698
	public void UpdateGroup(ETeamGroupType groupType, IList<SceneTeamRole> groupRoleList, int currentRoleId, ETeamLivingState livingState, bool isFixedLocation)
	{
		SceneTeamGroup sceneTeamGroup = this.GroupMap.ContainsKey(groupType) ? this.GroupMap[groupType] : null;
		if (sceneTeamGroup == null)
		{
			sceneTeamGroup = SceneTeamGroup.Create(this.PlayerId, groupType);
			this.GroupMap[groupType] = sceneTeamGroup;
		}
		sceneTeamGroup.Update(groupRoleList, currentRoleId, livingState, isFixedLocation);
	}

	// Token: 0x06015D96 RID: 89494 RVA: 0x005834EC File Offset: 0x005816EC
	public void RefreshEntityEnable()
	{
		HashSet<long> hashSet = new HashSet<long>();
		HashSet<long> hashSet2 = new HashSet<long>();
		foreach (SceneTeamGroup sceneTeamGroup in this.GroupMap.Values)
		{
			foreach (SceneTeamRole sceneTeamRole in sceneTeamGroup.GetRoleList())
			{
				long creatureDataId = sceneTeamRole.CreatureDataId;
				if (creatureDataId > 0L)
				{
					hashSet2.Add(creatureDataId);
				}
			}
			SceneTeamRole currentRole = sceneTeamGroup.GetCurrentRole();
			ETeamGroupType groupType = sceneTeamGroup.GetGroupType();
			ETeamGroupType? currentGroupType = this.CurrentGroupType;
			if (!(groupType == currentGroupType.GetValueOrDefault() & currentGroupType != null) && currentRole != null && currentRole.OnStageWithoutControl)
			{
				hashSet.Add(currentRole.CreatureDataId);
			}
		}
		if (hashSet2.Count <= 0)
		{
			return;
		}
		bool inSeamlessFormation = PlotModel.Instance.InSeamlessFormation;
		int playerId = this.PlayerId;
		int? id = PlayerInfoModel.Instance.GetId();
		bool flag = playerId == id.GetValueOrDefault() & id != null;
		ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(this.PlayerId);
		bool flag2 = scenePlayerData == null || scenePlayerData.IsRemoteSceneLoading();
		SceneTeamModel instance = SceneTeamModel.Instance;
		bool isSeamlessUpdateTeam = instance.IsSeamlessUpdateTeam;
		SceneTeamItem getCurrentTeamItem = instance.GetCurrentTeamItem;
		long num = (getCurrentTeamItem != null) ? getCurrentTeamItem.GetCreatureDataId() : 0L;
		SceneTeamGroup currentGroup = this.GetCurrentGroup();
		long? num2;
		if (currentGroup == null)
		{
			num2 = null;
		}
		else
		{
			SceneTeamRole currentRole2 = currentGroup.GetCurrentRole();
			num2 = ((currentRole2 != null) ? new long?(currentRole2.CreatureDataId) : null);
		}
		long? num3 = num2;
		long valueOrDefault = num3.GetValueOrDefault();
		foreach (long num4 in hashSet2)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(num4);
			if (entity == null || !entity.Valid)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "更新编队实体时无法获取";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", num4);
				instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				if (inSeamlessFormation)
				{
					this.SetEntityEnable(entity2, false);
				}
				else
				{
					CreatureDataComponent component = entity2.GetComponent<CreatureDataComponent>();
					BaseDeathComponent component2 = entity2.GetComponent<BaseDeathComponent>();
					if (entity2.IsInit ? component2.IsDead() : (component.GetLivingStatus().GetValueOrDefault() == LivingStatus.Dead))
					{
						this.SetEntityEnable(entity2, false);
					}
					else if (!flag)
					{
						bool enable = num4 == valueOrDefault && !flag2;
						this.SetEntityEnable(entity2, enable);
					}
					else if (component.IsAutoRole())
					{
						bool enable2 = currentGroup != null && currentGroup.HasRole(num4);
						this.SetEntityEnable(entity2, enable2);
					}
					else
					{
						bool flag3 = hashSet.Contains(num4);
						bool enable3 = num4 == num || (num4 == valueOrDefault && !isSeamlessUpdateTeam) || flag3;
						this.SetEntityEnable(entity2, enable3);
						if (flag3)
						{
							RoleTeamComponent component3 = entity2.GetComponent<RoleTeamComponent>();
							if (component3 != null)
							{
								component3.OutOfControl();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06015D97 RID: 89495 RVA: 0x00583844 File Offset: 0x00581A44
	public bool IsRoleOnStageWithoutControl(long creatureDataId)
	{
		foreach (SceneTeamGroup sceneTeamGroup in this.GroupMap.Values)
		{
			SceneTeamRole currentRole = sceneTeamGroup.GetCurrentRole();
			if (currentRole != null && currentRole.CreatureDataId == creatureDataId && currentRole.OnStageWithoutControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06015D98 RID: 89496 RVA: 0x005838B8 File Offset: 0x00581AB8
	private void SetEntityEnable(Entity entity, bool enable)
	{
		if (enable)
		{
			entity.GetComponent<CreatureDataComponent>().SetVisible(true);
			entity.EnableByKey(EEntityDisableKey.GoDown, true);
			return;
		}
		entity.DisableByKey(EEntityDisableKey.GoDown, true);
		RoleTeamComponent component = entity.GetComponent<RoleTeamComponent>();
		if (component == null)
		{
			return;
		}
		component.SetTeamTag(ETeamState.UnderStage);
	}

	// Token: 0x0400A286 RID: 41606
	private int PlayerId;

	// Token: 0x0400A287 RID: 41607
	private ETeamGroupType? CurrentGroupType;

	// Token: 0x0400A288 RID: 41608
	private readonly Dictionary<ETeamGroupType, SceneTeamGroup> GroupMap = new Dictionary<ETeamGroupType, SceneTeamGroup>();
}
