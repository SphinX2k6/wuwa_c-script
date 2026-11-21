using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Plot;

// Token: 0x02001EC6 RID: 7878
[NullableContext(1)]
[Nullable(0)]
public class SceneTeamPlayer
{
	// Token: 0x06013792 RID: 79762 RVA: 0x005AE337 File Offset: 0x005AC537
	public static SceneTeamPlayer Create(int playerId)
	{
		return new SceneTeamPlayer
		{
			PlayerId = playerId
		};
	}

	// Token: 0x06013793 RID: 79763 RVA: 0x005AE348 File Offset: 0x005AC548
	public void Clear()
	{
		this.CurrentGroupType = null;
		foreach (SceneTeamGroup sceneTeamGroup in this.GroupMap.Values)
		{
			sceneTeamGroup.Clear();
		}
		this.GroupMap.Clear();
	}

	// Token: 0x06013794 RID: 79764 RVA: 0x005AE3B4 File Offset: 0x005AC5B4
	public ETeamGroupType? GetCurrentGroupType()
	{
		return this.CurrentGroupType;
	}

	// Token: 0x06013795 RID: 79765 RVA: 0x005AE3BC File Offset: 0x005AC5BC
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

	// Token: 0x06013796 RID: 79766 RVA: 0x005AE408 File Offset: 0x005AC608
	[NullableContext(2)]
	public SceneTeamGroup GetGroup(ETeamGroupType groupType)
	{
		if (!this.GroupMap.ContainsKey(groupType))
		{
			return null;
		}
		return this.GroupMap[groupType];
	}

	// Token: 0x06013797 RID: 79767 RVA: 0x005AE428 File Offset: 0x005AC628
	public List<SceneTeamGroup> GetGroupList()
	{
		List<SceneTeamGroup> list = new List<SceneTeamGroup>();
		foreach (SceneTeamGroup item in this.GroupMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06013798 RID: 79768 RVA: 0x005AE488 File Offset: 0x005AC688
	public void SwitchGroup(ETeamGroupType groupType)
	{
		this.CurrentGroupType = new ETeamGroupType?(groupType);
	}

	// Token: 0x06013799 RID: 79769 RVA: 0x005AE498 File Offset: 0x005AC698
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

	// Token: 0x0601379A RID: 79770 RVA: 0x005AE4EC File Offset: 0x005AC6EC
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

	// Token: 0x0601379B RID: 79771 RVA: 0x005AE844 File Offset: 0x005ACA44
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

	// Token: 0x0601379C RID: 79772 RVA: 0x005AE8B8 File Offset: 0x005ACAB8
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

	// Token: 0x0400A670 RID: 42608
	private int PlayerId;

	// Token: 0x0400A671 RID: 42609
	private ETeamGroupType? CurrentGroupType;

	// Token: 0x0400A672 RID: 42610
	private readonly Dictionary<ETeamGroupType, SceneTeamGroup> GroupMap = new Dictionary<ETeamGroupType, SceneTeamGroup>();
}
