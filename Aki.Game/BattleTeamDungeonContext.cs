using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BE9 RID: 7145
[NullableContext(2)]
[Nullable(0)]
public class BattleTeamDungeonContext
{
	// Token: 0x0600D4C1 RID: 54465 RVA: 0x0030F7B9 File Offset: 0x0030D9B9
	public void SetInstanceDungeonId(int? instanceDungeonId)
	{
		this.InstanceDungeonIdInternal = instanceDungeonId;
	}

	// Token: 0x1700116F RID: 4463
	// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x0030F7C2 File Offset: 0x0030D9C2
	public int? InstanceDungeonId
	{
		get
		{
			return this.InstanceDungeonIdInternal;
		}
	}

	// Token: 0x0600D4C3 RID: 54467 RVA: 0x0030F7CA File Offset: 0x0030D9CA
	public void SetMultiEntry(bool value)
	{
		this.MultiEntryFlag = value;
	}

	// Token: 0x17001170 RID: 4464
	// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x0030F7D3 File Offset: 0x0030D9D3
	public bool IsMultiEntry
	{
		get
		{
			return this.MultiEntryFlag;
		}
	}

	// Token: 0x0600D4C5 RID: 54469 RVA: 0x0030F7DC File Offset: 0x0030D9DC
	public InstanceDungeon? GetDungeonConfig()
	{
		if (this.InstanceDungeonIdInternal == null)
		{
			return null;
		}
		return InstanceDungeonConfig.Instance.GetConfig(this.InstanceDungeonIdInternal.Value);
	}

	// Token: 0x0600D4C6 RID: 54470 RVA: 0x0030F818 File Offset: 0x0030DA18
	public FightFormation? GetFightFormation()
	{
		InstanceDungeon? dungeonConfig = this.GetDungeonConfig();
		int? num = (dungeonConfig != null) ? new int?(dungeonConfig.GetValueOrDefault().FightFormationId) : null;
		if (num == null || num.Value == 0)
		{
			return null;
		}
		return FormationConfig.Instance.GetFightFormationConfig(num.Value);
	}

	// Token: 0x17001171 RID: 4465
	// (get) Token: 0x0600D4C7 RID: 54471 RVA: 0x0030F884 File Offset: 0x0030DA84
	public bool IsMultiInstanceDungeon
	{
		get
		{
			InstanceDungeon? dungeonConfig = this.GetDungeonConfig();
			if (dungeonConfig == null)
			{
				return this.MultiEntryFlag;
			}
			return dungeonConfig.Value.OnlineType != InstOnlineType.Single && this.MultiEntryFlag;
		}
	}

	// Token: 0x0600D4C8 RID: 54472 RVA: 0x0030F8C4 File Offset: 0x0030DAC4
	public bool IsMatchingTeamLackConfirmBoxCanEnterInstance()
	{
		if (this.InstanceDungeonIdInternal == null)
		{
			return false;
		}
		InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
		return ((instance != null) ? new int?(instance.GetEntranceIdByInstanceId(this.InstanceDungeonIdInternal.Value)) : null).GetValueOrDefault() != 9000;
	}

	// Token: 0x17001172 RID: 4466
	// (get) Token: 0x0600D4C9 RID: 54473 RVA: 0x0030F91B File Offset: 0x0030DB1B
	public bool HasAnyLimit
	{
		get
		{
			return this.HasLimitRole || this.HasLimitCount || this.HasLimitElement || this.HasLimitExtra;
		}
	}

	// Token: 0x17001173 RID: 4467
	// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x0030F940 File Offset: 0x0030DB40
	public bool HasLimitRole
	{
		get
		{
			int[] currentLimitRoleIdList = this.CurrentLimitRoleIdList;
			return currentLimitRoleIdList != null && currentLimitRoleIdList.Length != 0;
		}
	}

	// Token: 0x17001174 RID: 4468
	// (get) Token: 0x0600D4CB RID: 54475 RVA: 0x0030F960 File Offset: 0x0030DB60
	public bool HasLimitCount
	{
		get
		{
			FightFormation? fightFormation = this.GetFightFormation();
			if (fightFormation == null)
			{
				return false;
			}
			int limitCountLength = fightFormation.Value.LimitCountLength;
			return limitCountLength != 3 && limitCountLength > 0;
		}
	}

	// Token: 0x17001175 RID: 4469
	// (get) Token: 0x0600D4CC RID: 54476 RVA: 0x0030F99C File Offset: 0x0030DB9C
	public bool HasLimitElement
	{
		get
		{
			FightFormation? fightFormation;
			return ((this.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().LitmitElementLength : 0) > 0;
		}
	}

	// Token: 0x17001176 RID: 4470
	// (get) Token: 0x0600D4CD RID: 54477 RVA: 0x0030F9CE File Offset: 0x0030DBCE
	public bool HasLimitExtra
	{
		get
		{
			return this.IsMowingInstance;
		}
	}

	// Token: 0x17001177 RID: 4471
	// (get) Token: 0x0600D4CE RID: 54478 RVA: 0x0030F9D8 File Offset: 0x0030DBD8
	public bool IsMowingInstance
	{
		get
		{
			InstanceDungeon? dungeonConfig = this.GetDungeonConfig();
			return dungeonConfig != null && dungeonConfig.Value.InstSubType == 19;
		}
	}

	// Token: 0x17001178 RID: 4472
	// (get) Token: 0x0600D4CF RID: 54479 RVA: 0x0030FA0C File Offset: 0x0030DC0C
	public int[] CurrentLimitRoleIdList
	{
		get
		{
			if (this.GetFightFormation() == null)
			{
				return null;
			}
			FightFormation? fightFormation;
			return fightFormation.GetValueOrDefault().GetLimitRoleArray();
		}
	}

	// Token: 0x17001179 RID: 4473
	// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x0030FA3C File Offset: 0x0030DC3C
	public int[] LimitRoleCountList
	{
		get
		{
			FightFormation? fightFormation = this.GetFightFormation();
			if (fightFormation == null)
			{
				return null;
			}
			if (fightFormation.Value.LimitCountLength == 0)
			{
				return null;
			}
			return fightFormation.Value.GetLimitCountArray();
		}
	}

	// Token: 0x1700117A RID: 4474
	// (get) Token: 0x0600D4D1 RID: 54481 RVA: 0x0030FA80 File Offset: 0x0030DC80
	public int MaxLimitRoleCount
	{
		get
		{
			int[] limitRoleCountList = this.LimitRoleCountList;
			if (limitRoleCountList == null)
			{
				return 0;
			}
			return limitRoleCountList[limitRoleCountList.Length - 1];
		}
	}

	// Token: 0x0600D4D2 RID: 54482 RVA: 0x0030FAA0 File Offset: 0x0030DCA0
	public bool IsInLimitRoleCount(int roleCount)
	{
		int[] limitRoleCountList = this.LimitRoleCountList;
		return limitRoleCountList == null || Array.IndexOf<int>(limitRoleCountList, roleCount) != -1;
	}

	// Token: 0x0600D4D3 RID: 54483 RVA: 0x0030FAC8 File Offset: 0x0030DCC8
	public bool IsInLimitRole(int roleConfigId)
	{
		FightFormation? fightFormation;
		int[] array = (this.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().GetLimitRoleArray() : null;
		return array == null || array.Length == 0 || Array.IndexOf<int>(array, roleConfigId) != -1;
	}

	// Token: 0x0600D4D4 RID: 54484 RVA: 0x0030FB10 File Offset: 0x0030DD10
	public bool IsInLimitElement(int roleConfigId)
	{
		FightFormation? fightFormation;
		int[] array = (this.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().GetLitmitElementArray() : null;
		if (array == null || array.Length == 0)
		{
			return true;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
		return roleConfig != null && Array.IndexOf<int>(array, roleConfig.Value.ElementId) != -1;
	}

	// Token: 0x0600D4D5 RID: 54485 RVA: 0x0030FB7C File Offset: 0x0030DD7C
	public bool CanAddRoleToEditTeam(int configId)
	{
		return RoleUtils.IsTrialRole(configId) || (this.IsInLimitRole(configId) && this.IsInLimitElement(configId));
	}

	// Token: 0x0400617C RID: 24956
	private const int LIMIT_COUNT_FULL_LENGTH = 3;

	// Token: 0x0400617D RID: 24957
	private int? InstanceDungeonIdInternal;

	// Token: 0x0400617E RID: 24958
	private bool MultiEntryFlag;
}
