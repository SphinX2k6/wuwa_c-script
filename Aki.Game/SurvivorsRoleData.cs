using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020020D6 RID: 8406
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleData : RoleDataBase
{
	// Token: 0x06014A66 RID: 84582 RVA: 0x00604AA8 File Offset: 0x00602CA8
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

	// Token: 0x06014A67 RID: 84583 RVA: 0x00604B79 File Offset: 0x00602D79
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x06014A68 RID: 84584 RVA: 0x00604B7C File Offset: 0x00602D7C
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06014A69 RID: 84585 RVA: 0x00604B84 File Offset: 0x00602D84
	public override string GetName(int? playerId = null)
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		return RoleConfig.Instance.GetRoleName(roleConfig.Name);
	}

	// Token: 0x06014A6A RID: 84586 RVA: 0x00604BA9 File Offset: 0x00602DA9
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x06014A6B RID: 84587 RVA: 0x00604BAC File Offset: 0x00602DAC
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06014A6C RID: 84588 RVA: 0x00604BAF File Offset: 0x00602DAF
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x06014A6D RID: 84589 RVA: 0x00604BB2 File Offset: 0x00602DB2
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x06014A6E RID: 84590 RVA: 0x00604BB5 File Offset: 0x00602DB5
	public SurvivorsRole? GetSurRoleConfig()
	{
		return SurvivorsRogueConfig.Instance.GetSurvivorsRole(this.SurRoleId);
	}

	// Token: 0x0400AFF1 RID: 45041
	public int SurRoleId;

	// Token: 0x0400AFF2 RID: 45042
	public bool IsUnLock;

	// Token: 0x0400AFF3 RID: 45043
	public int TrialRoleId;

	// Token: 0x0400AFF4 RID: 45044
	public string IconPath;

	// Token: 0x0400AFF5 RID: 45045
	public int QualityId;

	// Token: 0x0400AFF6 RID: 45046
	public int InitWeaponID;

	// Token: 0x0400AFF7 RID: 45047
	public string DefaultEvolveTxtID;

	// Token: 0x0400AFF8 RID: 45048
	public int UnlockConditionId;

	// Token: 0x0400AFF9 RID: 45049
	public int PropId;

	// Token: 0x0400AFFA RID: 45050
	public bool IsSurvivorsTrial;
}
