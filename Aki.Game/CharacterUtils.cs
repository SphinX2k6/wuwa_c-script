using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002391 RID: 9105
[NullableContext(1)]
[Nullable(0)]
public class CharacterUtils
{
	// Token: 0x060167B2 RID: 92082 RVA: 0x006934DC File Offset: 0x006916DC
	[NullableContext(2)]
	public static bool IsCharacterMonsterOrSummoned(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			return false;
		}
		CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
		return component != null && component.Valid && (component.IsCharacterMonster() || component.IsSummonByCharacterMonster());
	}

	// Token: 0x060167B3 RID: 92083 RVA: 0x00693530 File Offset: 0x00691730
	[NullableContext(2)]
	public static bool CanCharacterMonsterOrSummonedDisplayEffect(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			return false;
		}
		CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		if (component.IsCharacterMonster())
		{
			return CharacterUtils.HasPerformanceAuthority(entityHandle);
		}
		return !component.IsSummonByCharacterMonster() || CharacterUtils.HasPerformanceAuthority(CreatureModel.Instance.GetEntity(component.GetSummonerId()));
	}

	// Token: 0x060167B4 RID: 92084 RVA: 0x006935A0 File Offset: 0x006917A0
	[NullableContext(2)]
	private static bool HasPerformanceAuthority(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			return false;
		}
		CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
		CharacterSkillComponent component2 = entityHandle.Entity.GetComponent<CharacterSkillComponent>();
		BaseTagComponent component3 = entityHandle.Entity.GetComponent<BaseTagComponent>();
		MonsterBattleConf? monsterBattleConf = null;
		MonsterComponent monsterComponent = component.GetMonsterComponent();
		int? num = (monsterComponent != null) ? new int?(monsterComponent.FightConfigId) : null;
		if (num != null && num.Value != 0)
		{
			monsterBattleConf = ConfigMonsterBattleConfById.GetConfig(num.Value, true);
		}
		int roleId = component.GetRoleId();
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
		if (baseRoleId != 0)
		{
			monsterBattleConf = ConfigMonsterBattleConfByRoleId.GetConfig(baseRoleId, true);
		}
		if (monsterBattleConf != null)
		{
			IReadOnlyList<MonsterPerformanceConf> configList = ConfigMonsterPerformanceConfById.GetConfigList(monsterBattleConf.Value.MonsterPerformanceId, true);
			global::Skill currentSkill = component2.CurrentSkill;
			int value = (currentSkill != null) ? currentSkill.SkillId : 0;
			if (configList != null)
			{
				foreach (MonsterPerformanceConf monsterPerformanceConf in configList)
				{
					int[] skillIdsArray = monsterPerformanceConf.GetSkillIdsArray();
					if (skillIdsArray != null && Array.IndexOf<int>(skillIdsArray, value) >= 0)
					{
						string tag = monsterPerformanceConf.Tag;
						if (tag == null)
						{
							return true;
						}
						int tagIdByName = GameplayTagUtils.GetTagIdByName(tag);
						if (tagIdByName != 0 && component3.HasTag(tagIdByName))
						{
							return true;
						}
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060167B5 RID: 92085 RVA: 0x00693710 File Offset: 0x00691910
	public static int GetHuluModelId(int partyId)
	{
		CalabashMesh? config = ConfigCalabashMeshById.GetConfig(partyId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "势力.xlsx里没有配葫芦模型ID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("partyId", partyId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		return config.Value.MeshId;
	}

	// Token: 0x060167B6 RID: 92086 RVA: 0x0069376C File Offset: 0x0069196C
	public static string GetMovementModeName(EMovementMode movementMode)
	{
		switch (movementMode)
		{
		case EMovementMode.MOVE_None:
			return "MOVE_None";
		case EMovementMode.MOVE_Walking:
			return "MOVE_Walking";
		case EMovementMode.MOVE_NavWalking:
			return "MOVE_NavWalking";
		case EMovementMode.MOVE_Falling:
			return "MOVE_Falling";
		case EMovementMode.MOVE_Swimming:
			return "MOVE_Swimming";
		case EMovementMode.MOVE_Flying:
			return "MOVE_Flying";
		case EMovementMode.MOVE_Custom:
			return "MOVE_Custom";
		case EMovementMode.MOVE_WalkingOnAir:
			return "MOVE_WalkingOnAir";
		default:
			return "请补充运动模式定义";
		}
	}

	// Token: 0x060167B7 RID: 92087 RVA: 0x006937D8 File Offset: 0x006919D8
	public static string GetCustomMovementModeName(int customMovementMode)
	{
		switch (customMovementMode)
		{
		case 0:
			return "CUSTOM_MOVEMENTMODE_CLIMB";
		case 1:
			return "CUSTOM_MOVEMENTMODE_SWIM";
		case 2:
			return "CUSTOM_MOVEMENTMODE_GLIDE";
		case 3:
			return "CUSTOM_MOVEMENTMODE_PENDULUM";
		case 4:
			return "CUSTOM_MOVEMENTMODE_SLIDE";
		case 5:
			return "CUSTOM_MOVEMENTMODE_UP_TO_WALK_ON_WATER";
		case 6:
			return "CUSTOM_MOVEMENTMODE_LEISURE";
		case 7:
			return "CUSTOM_MOVEMENTMODE_SOAR";
		case 8:
			return "CUSTOM_MOVEMENTMODE_SKI";
		case 9:
			return "CUSTOM_MOVEMENTMODE_ROLL";
		case 10:
			return "CUSTOM_MOVEMENTMODE_KITE";
		case 11:
			return "CUSTOM_MOVEMENTMODE_RIDE";
		case 12:
			return "CUSTOM_MOVEMENTMODE_RAIL_SLIDE";
		case 13:
			return "CUSTOM_MOVEMENTMODE_SPLINE_CLIMB";
		case 14:
			return "CUSTOM_MOVEMENTMODE_SWING";
		case 15:
			return "CUSTOM_MOVEMENTMODE_FLOATING";
		default:
			return "请补充自定义运动模式定义";
		}
	}

	// Token: 0x060167B8 RID: 92088 RVA: 0x00693894 File Offset: 0x00691A94
	public static string GetVehicleMovementModeName(EKuroVehicleMovementMode customMovementMode)
	{
		switch (customMovementMode)
		{
		case EKuroVehicleMovementMode.KURO_VEHICLE_MOVE_None:
			return "KURO_VEHICLE_MOVE_None";
		case EKuroVehicleMovementMode.KURO_VEHICLE_MOVE_Falling:
			return "KURO_VEHICLE_MOVE_Falling";
		case EKuroVehicleMovementMode.KURO_VEHICLE_MOVE_Shipping:
			return "KURO_VEHICLE_MOVE_Shipping";
		case EKuroVehicleMovementMode.KURO_VEHICLE_MOVE_Motorcycling:
			return "KURO_VEHICLE_MOVE_Motorcycling";
		case EKuroVehicleMovementMode.KURO_VEHICLE_MOVE_Custom:
			return "KURO_VEHICLE_MOVE_Custom";
		default:
			return "请补充载具运动模式定义";
		}
	}
}
