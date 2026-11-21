using System;
using System.Runtime.CompilerServices;

// Token: 0x020027B3 RID: 10163
[NullableContext(2)]
[Nullable(0)]
public class RoleGrowComponent : EntityComponent
{
	// Token: 0x0601980B RID: 104459 RVA: 0x007D09CC File Offset: 0x007CEBCC
	protected override bool OnStart()
	{
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.InitStartingRestriction();
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		int playerId = creatureDataComponent.GetPlayerId();
		int? id = PlayerInfoModel.Instance.GetId();
		int num = playerId;
		bool isSelf = id.GetValueOrDefault() == num & id != null;
		int roleId = creatureDataComponent.GetRoleId();
		this.WeaponType = creatureDataComponent.GetRoleConfig().Value.WeaponType;
		this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, isSelf);
		return true;
	}

	// Token: 0x0601980C RID: 104460 RVA: 0x007D0A5B File Offset: 0x007CEC5B
	protected override bool OnEnd()
	{
		return true;
	}

	// Token: 0x0601980D RID: 104461 RVA: 0x007D0A5E File Offset: 0x007CEC5E
	private void InitStartingRestriction()
	{
		this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止.出生专用"]));
		this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止.出生专用"]));
	}

	// Token: 0x0601980E RID: 104462 RVA: 0x007D0A9E File Offset: 0x007CEC9E
	public int GetWeaponType()
	{
		if (this.WeaponType != 0)
		{
			return this.WeaponType;
		}
		return 0;
	}

	// Token: 0x0601980F RID: 104463 RVA: 0x007D0AB0 File Offset: 0x007CECB0
	public int GetSkillLevelBySkillInfoId(long skillInfoId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(skillInfoId, ERoleSkillReferenceType.SkillInfo, null);
		}
		return 0;
	}

	// Token: 0x06019810 RID: 104464 RVA: 0x007D0ACF File Offset: 0x007CECCF
	public int GetSkillLevelByBuffId(long buffId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(buffId, ERoleSkillReferenceType.Buff, null);
		}
		return 0;
	}

	// Token: 0x06019811 RID: 104465 RVA: 0x007D0AEE File Offset: 0x007CECEE
	public int GetSkillLevelByDamageId(long damageId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(damageId, ERoleSkillReferenceType.Damage, null);
		}
		return 0;
	}

	// Token: 0x06019812 RID: 104466 RVA: 0x007D0B10 File Offset: 0x007CED10
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleGrowComponent roleGrowComponent = (RoleGrowComponent)componentTemplate;
		if (roleGrowComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (roleGrowComponent.RoleInstance == null)
		{
			this.RoleInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RoleInstance), "RoleInstance"))
		{
			return false;
		}
		this.WeaponType = roleGrowComponent.WeaponType;
		return true;
	}

	// Token: 0x170028AF RID: 10415
	// (get) Token: 0x06019813 RID: 104467 RVA: 0x007D0B92 File Offset: 0x007CED92
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B0 RID: 10416
	// (get) Token: 0x06019814 RID: 104468 RVA: 0x007D0B95 File Offset: 0x007CED95
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF69 RID: 57193
	private BaseTagComponent TagComponent;

	// Token: 0x0400DF6A RID: 57194
	private RoleDataBase RoleInstance;

	// Token: 0x0400DF6B RID: 57195
	private int WeaponType;
}
