using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002E35 RID: 11829
[NullableContext(1)]
[Nullable(0)]
public class CharacterUtils
{
	// Token: 0x06018EE5 RID: 102117 RVA: 0x0066D5E4 File Offset: 0x0066B7E4
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

	// Token: 0x06018EE6 RID: 102118 RVA: 0x0066D638 File Offset: 0x0066B838
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

	// Token: 0x06018EE7 RID: 102119 RVA: 0x0066D6A8 File Offset: 0x0066B8A8
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

	// Token: 0x06018EE8 RID: 102120 RVA: 0x0066D818 File Offset: 0x0066BA18
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

	// Token: 0x06018EE9 RID: 102121 RVA: 0x0066D874 File Offset: 0x0066BA74
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

	// Token: 0x06018EEA RID: 102122 RVA: 0x0066D8E0 File Offset: 0x0066BAE0
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

	// Token: 0x06018EEB RID: 102123 RVA: 0x0066D99C File Offset: 0x0066BB9C
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
