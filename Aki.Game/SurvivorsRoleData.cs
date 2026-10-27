using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002B5A RID: 11098
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleData : RoleDataBase
{
	// Token: 0x06017035 RID: 94261 RVA: 0x005D7F3C File Offset: 0x005D613C
	public SurvivorsRoleData(int surRoleId, int trialRoleId, bool isUnLock) : base(trialRoleId)
	{
		this.SurRoleId = surRoleId;
		this.TrialRoleId = trialRoleId;
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(this.TrialRoleId).Value;
		this.Id = value.Id;
		this.IconPath = value.RoleHeadIconBig;
		this.QualityId = value.QualityId;
		this.IsUnLock = isUnLock;
		this.DefaultEvolveTxtID = SurvivorsRogueConfig.Instance.GetSurvivorsRoleDefaultEvolve(this.SurRoleId).Value.Describe;
		SurvivorsRole value2 = SurvivorsRogueConfig.Instance.GetSurvivorsRole(this.SurRoleId).Value;
		this.UnlockConditionId = value2.UnlockConditionId;
		this.InitWeaponID = value2.InitWeapon;
		this.PropId = value2.PropId;
	}

	// Token: 0x06017036 RID: 94262 RVA: 0x005D800D File Offset: 0x005D620D
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x06017037 RID: 94263 RVA: 0x005D8010 File Offset: 0x005D6210
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06017038 RID: 94264 RVA: 0x005D8018 File Offset: 0x005D6218
	public override string GetName(int? playerId = null)
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		return RoleConfig.Instance.GetRoleName(roleConfig.Name);
	}

	// Token: 0x06017039 RID: 94265 RVA: 0x005D803D File Offset: 0x005D623D
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x0601703A RID: 94266 RVA: 0x005D8040 File Offset: 0x005D6240
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x0601703B RID: 94267 RVA: 0x005D8043 File Offset: 0x005D6243
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x0601703C RID: 94268 RVA: 0x005D8046 File Offset: 0x005D6246
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x0601703D RID: 94269 RVA: 0x005D8049 File Offset: 0x005D6249
	public SurvivorsRole? GetSurRoleConfig()
	{
		return SurvivorsRogueConfig.Instance.GetSurvivorsRole(this.SurRoleId);
	}

	// Token: 0x0400ABEB RID: 44011
	public int SurRoleId;

	// Token: 0x0400ABEC RID: 44012
	public bool IsUnLock;

	// Token: 0x0400ABED RID: 44013
	public int TrialRoleId;

	// Token: 0x0400ABEE RID: 44014
	public string IconPath;

	// Token: 0x0400ABEF RID: 44015
	public int QualityId;

	// Token: 0x0400ABF0 RID: 44016
	public int InitWeaponID;

	// Token: 0x0400ABF1 RID: 44017
	public string DefaultEvolveTxtID;

	// Token: 0x0400ABF2 RID: 44018
	public int UnlockConditionId;

	// Token: 0x0400ABF3 RID: 44019
	public int PropId;

	// Token: 0x0400ABF4 RID: 44020
	public bool IsSurvivorsTrial;
}
