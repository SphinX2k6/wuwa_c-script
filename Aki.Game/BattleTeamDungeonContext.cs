using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010A8 RID: 4264
[NullableContext(2)]
[Nullable(0)]
public class BattleTeamDungeonContext
{
	// Token: 0x0600A8D3 RID: 43219 RVA: 0x0031A92D File Offset: 0x00318B2D
	public void SetInstanceDungeonId(int? instanceDungeonId)
	{
		this.InstanceDungeonIdInternal = instanceDungeonId;
	}

	// Token: 0x17001194 RID: 4500
	// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x0031A936 File Offset: 0x00318B36
	public int? InstanceDungeonId
	{
		get
		{
			return this.InstanceDungeonIdInternal;
		}
	}

	// Token: 0x0600A8D5 RID: 43221 RVA: 0x0031A93E File Offset: 0x00318B3E
	public void SetMultiEntry(bool value)
	{
		this.MultiEntryFlag = value;
	}

	// Token: 0x17001195 RID: 4501
	// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x0031A947 File Offset: 0x00318B47
	public bool IsMultiEntry
	{
		get
		{
			return this.MultiEntryFlag;
		}
	}

	// Token: 0x0600A8D7 RID: 43223 RVA: 0x0031A950 File Offset: 0x00318B50
	public InstanceDungeon? GetDungeonConfig()
	{
		if (this.InstanceDungeonIdInternal == null)
		{
			return null;
		}
		return InstanceDungeonConfig.Instance.GetConfig(this.InstanceDungeonIdInternal.Value);
	}

	// Token: 0x0600A8D8 RID: 43224 RVA: 0x0031A98C File Offset: 0x00318B8C
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

	// Token: 0x17001196 RID: 4502
	// (get) Token: 0x0600A8D9 RID: 43225 RVA: 0x0031A9F8 File Offset: 0x00318BF8
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

	// Token: 0x0600A8DA RID: 43226 RVA: 0x0031AA38 File Offset: 0x00318C38
	public bool IsMatchingTeamLackConfirmBoxCanEnterInstance()
	{
		if (this.InstanceDungeonIdInternal == null)
		{
			return false;
		}
		InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
		return ((instance != null) ? new int?(instance.GetEntranceIdByInstanceId(this.InstanceDungeonIdInternal.Value)) : null).GetValueOrDefault() != 9000;
	}

	// Token: 0x17001197 RID: 4503
	// (get) Token: 0x0600A8DB RID: 43227 RVA: 0x0031AA8F File Offset: 0x00318C8F
	public bool HasAnyLimit
	{
		get
		{
			return this.HasLimitRole || this.HasLimitCount || this.HasLimitElement || this.HasLimitExtra;
		}
	}

	// Token: 0x17001198 RID: 4504
	// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x0031AAB4 File Offset: 0x00318CB4
	public bool HasLimitRole
	{
		get
		{
			int[] currentLimitRoleIdList = this.CurrentLimitRoleIdList;
			return currentLimitRoleIdList != null && currentLimitRoleIdList.Length != 0;
		}
	}

	// Token: 0x17001199 RID: 4505
	// (get) Token: 0x0600A8DD RID: 43229 RVA: 0x0031AAD4 File Offset: 0x00318CD4
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

	// Token: 0x1700119A RID: 4506
	// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x0031AB10 File Offset: 0x00318D10
	public bool HasLimitElement
	{
		get
		{
			FightFormation? fightFormation;
			return ((this.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().LitmitElementLength : 0) > 0;
		}
	}

	// Token: 0x1700119B RID: 4507
	// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x0031AB42 File Offset: 0x00318D42
	public bool HasLimitExtra
	{
		get
		{
			return this.IsMowingInstance;
		}
	}

	// Token: 0x1700119C RID: 4508
	// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x0031AB4C File Offset: 0x00318D4C
	public bool IsMowingInstance
	{
		get
		{
			InstanceDungeon? dungeonConfig = this.GetDungeonConfig();
			return dungeonConfig != null && dungeonConfig.Value.InstSubType == 19;
		}
	}

	// Token: 0x1700119D RID: 4509
	// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x0031AB80 File Offset: 0x00318D80
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

	// Token: 0x1700119E RID: 4510
	// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x0031ABB0 File Offset: 0x00318DB0
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

	// Token: 0x1700119F RID: 4511
	// (get) Token: 0x0600A8E3 RID: 43235 RVA: 0x0031ABF4 File Offset: 0x00318DF4
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

	// Token: 0x0600A8E4 RID: 43236 RVA: 0x0031AC14 File Offset: 0x00318E14
	public bool IsInLimitRoleCount(int roleCount)
	{
		int[] limitRoleCountList = this.LimitRoleCountList;
		return limitRoleCountList == null || Array.IndexOf<int>(limitRoleCountList, roleCount) != -1;
	}

	// Token: 0x0600A8E5 RID: 43237 RVA: 0x0031AC3C File Offset: 0x00318E3C
	public bool IsInLimitRole(int roleConfigId)
	{
		FightFormation? fightFormation;
		int[] array = (this.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().GetLimitRoleArray() : null;
		return array == null || array.Length == 0 || Array.IndexOf<int>(array, roleConfigId) != -1;
	}

	// Token: 0x0600A8E6 RID: 43238 RVA: 0x0031AC84 File Offset: 0x00318E84
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

	// Token: 0x0600A8E7 RID: 43239 RVA: 0x0031ACF0 File Offset: 0x00318EF0
	public bool CanAddRoleToEditTeam(int configId)
	{
		return RoleUtils.IsTrialRole(configId) || (this.IsInLimitRole(configId) && this.IsInLimitElement(configId));
	}

	// Token: 0x0400624B RID: 25163
	private const int LIMIT_COUNT_FULL_LENGTH = 3;

	// Token: 0x0400624C RID: 25164
	private int? InstanceDungeonIdInternal;

	// Token: 0x0400624D RID: 25165
	private bool MultiEntryFlag;
}
