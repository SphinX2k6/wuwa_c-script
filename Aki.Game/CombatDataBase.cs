using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.World.Model;

// Token: 0x02002ED7 RID: 11991
[NullableContext(1)]
[Nullable(0)]
public abstract class CombatDataBase
{
	// Token: 0x060199E8 RID: 104936 RVA: 0x006A73D8 File Offset: 0x006A55D8
	public CombatDataBase(int attackerId, int targetId = 0)
	{
		this.AttackerId = attackerId;
		this.TargetId = targetId;
		DateTime now = DateTime.Now;
		this.DateCreate = StringUtils.Format("{0}-{1}-{2}", new string[]
		{
			(now.Hour < 10) ? ("0" + now.Hour.ToString()) : now.Hour.ToString(),
			(now.Minute < 10) ? ("0" + now.Minute.ToString()) : now.Minute.ToString(),
			(now.Second < 10) ? ("0" + now.Second.ToString()) : now.Second.ToString()
		});
	}

	// Token: 0x060199E9 RID: 104937 RVA: 0x006A74C8 File Offset: 0x006A56C8
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.String))
		{
			return this.String;
		}
		this.String = this.ParseToString();
		return this.String;
	}

	// Token: 0x060199EA RID: 104938
	public abstract string ParseToString();

	// Token: 0x060199EB RID: 104939 RVA: 0x006A74F0 File Offset: 0x006A56F0
	[NullableContext(2)]
	public static string GetEntityConfigName(int targetId)
	{
		Entity entity = EntitySystem.Instance.Get(targetId);
		if (entity == null)
		{
			return null;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		EEntityType? eentityType = (component != null) ? new EEntityType?(component.GetEntityType()) : null;
		EEntityType? eentityType2 = eentityType;
		EEntityType eentityType3 = EEntityType.Player;
		if (eentityType2.GetValueOrDefault() == eentityType3 & eentityType2 != null)
		{
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId == 0)
			{
				return null;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			if (roleConfig == null)
			{
				return null;
			}
			return RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		}
		else
		{
			if (eentityType.GetValueOrDefault() == EEntityType.Monster)
			{
				return PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
			}
			return null;
		}
	}

	// Token: 0x060199EC RID: 104940 RVA: 0x006A75CC File Offset: 0x006A57CC
	[NullableContext(2)]
	public static string GetSkillConfigName(int entityId, int skillId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return null;
		}
		BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
		if (component == null)
		{
			return null;
		}
		SSkillInfo skillInfo = component.GetSkillInfo(skillId);
		if (skillInfo == null)
		{
			return null;
		}
		return skillInfo.SkillName.ToString();
	}

	// Token: 0x060199ED RID: 104941 RVA: 0x006A7618 File Offset: 0x006A5818
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	public static string[] GetEntityConfigNameAndSkillName(int entityId, long damageId, int skillId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		string text = null;
		string text2 = null;
		if (entity == null)
		{
			return new string[2];
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		EEntityType? eentityType = (component != null) ? new EEntityType?(component.GetEntityType()) : null;
		EEntityType? eentityType2 = eentityType;
		EEntityType eentityType3 = EEntityType.Player;
		if (eentityType2.GetValueOrDefault() == eentityType3 & eentityType2 != null)
		{
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId == 0)
			{
				return new string[2];
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			if (roleConfig == null)
			{
				return new string[2];
			}
			text = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
			IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
			int num = -1;
			if (skillList != null)
			{
				foreach (Aki.Config.Skill skill in skillList)
				{
					if (CombatDataBase.SkillContainsDamage(skill, damageId))
					{
						text2 = CharacterStatisticsComponent.skillTypeToString[skill.SkillType - 1];
						num = skill.SkillType;
						break;
					}
				}
			}
			if (num < 0)
			{
				Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
				if (((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Type : -1) == 5)
				{
					text2 = "幻象技能";
				}
			}
			return new string[]
			{
				text,
				text2
			};
		}
		else
		{
			if (eentityType.GetValueOrDefault() == EEntityType.Monster)
			{
				text = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
				BaseSkillComponent component2 = entity.GetComponent<BaseSkillComponent>();
				string text3;
				if (component2 == null)
				{
					text3 = null;
				}
				else
				{
					SSkillInfo skillInfo = component2.GetSkillInfo(skillId);
					text3 = ((skillInfo != null) ? skillInfo.SkillName.ToString() : null);
				}
				text2 = text3;
				return new string[]
				{
					text,
					text2
				};
			}
			return new string[2];
		}
	}

	// Token: 0x060199EE RID: 104942 RVA: 0x006A7818 File Offset: 0x006A5A18
	private unsafe static bool SkillContainsDamage(Aki.Config.Skill skill, long damageId)
	{
		try
		{
			Span<long> damageListBytes = skill.GetDamageListBytes();
			for (int i = 0; i < damageListBytes.Length; i++)
			{
				long num = *damageListBytes[i];
				if (num == damageId || num == (long)((int)damageId))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x0400BFDB RID: 49115
	protected readonly string DateCreate;

	// Token: 0x0400BFDC RID: 49116
	protected string String = "";

	// Token: 0x0400BFDD RID: 49117
	public readonly int AttackerId;

	// Token: 0x0400BFDE RID: 49118
	public readonly int TargetId;
}
