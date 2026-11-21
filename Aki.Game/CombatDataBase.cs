using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.World.Model;

// Token: 0x0200242A RID: 9258
[NullableContext(1)]
[Nullable(0)]
public abstract class CombatDataBase
{
	// Token: 0x060172E7 RID: 94951 RVA: 0x006CD57C File Offset: 0x006CB77C
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

	// Token: 0x060172E8 RID: 94952 RVA: 0x006CD66C File Offset: 0x006CB86C
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.String))
		{
			return this.String;
		}
		this.String = this.ParseToString();
		return this.String;
	}

	// Token: 0x060172E9 RID: 94953
	public abstract string ParseToString();

	// Token: 0x060172EA RID: 94954 RVA: 0x006CD694 File Offset: 0x006CB894
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

	// Token: 0x060172EB RID: 94955 RVA: 0x006CD770 File Offset: 0x006CB970
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

	// Token: 0x060172EC RID: 94956 RVA: 0x006CD7BC File Offset: 0x006CB9BC
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

	// Token: 0x060172ED RID: 94957 RVA: 0x006CD9BC File Offset: 0x006CBBBC
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

	// Token: 0x0400C376 RID: 50038
	protected readonly string DateCreate;

	// Token: 0x0400C377 RID: 50039
	protected string String = "";

	// Token: 0x0400C378 RID: 50040
	public readonly int AttackerId;

	// Token: 0x0400C379 RID: 50041
	public readonly int TargetId;
}
