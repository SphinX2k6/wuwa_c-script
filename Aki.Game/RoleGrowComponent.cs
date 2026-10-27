using System;
using System.Runtime.CompilerServices;

// Token: 0x02003244 RID: 12868
[NullableContext(2)]
[Nullable(0)]
public class RoleGrowComponent : EntityComponent
{
	// Token: 0x0601BC5B RID: 113755 RVA: 0x007A824C File Offset: 0x007A644C
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

	// Token: 0x0601BC5C RID: 113756 RVA: 0x007A82DB File Offset: 0x007A64DB
	protected override bool OnEnd()
	{
		return true;
	}

	// Token: 0x0601BC5D RID: 113757 RVA: 0x007A82DE File Offset: 0x007A64DE
	private void InitStartingRestriction()
	{
		this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止.出生专用"]));
		this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止.出生专用"]));
	}

	// Token: 0x0601BC5E RID: 113758 RVA: 0x007A831E File Offset: 0x007A651E
	public int GetWeaponType()
	{
		if (this.WeaponType != 0)
		{
			return this.WeaponType;
		}
		return 0;
	}

	// Token: 0x0601BC5F RID: 113759 RVA: 0x007A8330 File Offset: 0x007A6530
	public int GetSkillLevelBySkillInfoId(long skillInfoId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(skillInfoId, ERoleSkillReferenceType.SkillInfo, null);
		}
		return 0;
	}

	// Token: 0x0601BC60 RID: 113760 RVA: 0x007A834F File Offset: 0x007A654F
	public int GetSkillLevelByBuffId(long buffId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(buffId, ERoleSkillReferenceType.Buff, null);
		}
		return 0;
	}

	// Token: 0x0601BC61 RID: 113761 RVA: 0x007A836E File Offset: 0x007A656E
	public int GetSkillLevelByDamageId(long damageId)
	{
		if (this.RoleInstance != null)
		{
			return this.RoleInstance.GetSkillData().GetReferencedSkillLevel(damageId, ERoleSkillReferenceType.Damage, null);
		}
		return 0;
	}

	// Token: 0x0601BC62 RID: 113762 RVA: 0x007A8390 File Offset: 0x007A6590
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleGrowComponent roleGrowComponent = (RoleGrowComponent)componentTemplate;
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (roleGrowComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RoleInstance"))
		{
			if (roleGrowComponent.RoleInstance == null)
			{
				this.RoleInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleDataBase>(this.RoleInstance), "RoleInstance"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WeaponType"))
		{
			this.WeaponType = roleGrowComponent.WeaponType;
		}
		return true;
	}

	// Token: 0x0400DACA RID: 56010
	private BaseTagComponent TagComponent;

	// Token: 0x0400DACB RID: 56011
	private RoleDataBase RoleInstance;

	// Token: 0x0400DACC RID: 56012
	private int WeaponType;
}
