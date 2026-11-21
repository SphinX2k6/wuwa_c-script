using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005E09 RID: 24073
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelConditionCheckFightEnergyBar : LevelConditionBase
	{
		// Token: 0x0603A705 RID: 239365 RVA: 0x01084FA0 File Offset: 0x010831A0
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int num = int.Parse(inConditionInfo.GetLimitParams("机制条状态"));
			if (num < 0 || num > 2)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的机制条状态只能是0，1");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			SpecialEnergyAttributeIdInfo currentSpecialEnergyAttributeId = this.GetCurrentSpecialEnergyAttributeId(getCurrentEntity.Entity);
			if (currentSpecialEnergyAttributeId == null)
			{
				Log.Instance.Error(ELogModule.LevelCondition, ELogAuthor.TL, "查询角色特殊能量条属性错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			BaseAttributeComponent component = getCurrentEntity.Entity.GetComponent<BaseAttributeComponent>();
			float? num2 = (component != null) ? new float?(component.GetCurrentValue(currentSpecialEnergyAttributeId.AttributeId)) : null;
			BaseAttributeComponent component2 = getCurrentEntity.Entity.GetComponent<BaseAttributeComponent>();
			float? num3 = (component2 != null) ? new float?(component2.GetCurrentValue(currentSpecialEnergyAttributeId.MaxAttributeId)) : null;
			float? num4 = num2;
			float num5 = 0f;
			if ((num4.GetValueOrDefault() == num5 & num4 != null) && num == 0)
			{
				return true;
			}
			num4 = num2;
			num5 = 0f;
			float? num6;
			if (num4.GetValueOrDefault() > num5 & num4 != null)
			{
				num4 = num2;
				num6 = num3;
				if ((num4.GetValueOrDefault() < num6.GetValueOrDefault() & (num4 != null & num6 != null)) && num == 2)
				{
					return true;
				}
			}
			num6 = num2;
			num4 = num3;
			return (num6.GetValueOrDefault() >= num4.GetValueOrDefault() & (num6 != null & num4 != null)) && num == 1;
		}

		// Token: 0x0603A706 RID: 239366 RVA: 0x01085190 File Offset: 0x01083390
		[return: Nullable(2)]
		public SpecialEnergyAttributeIdInfo GetCurrentSpecialEnergyAttributeId(Entity entity)
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return null;
			}
			RoleInfo? roleConfig = this.GetRoleConfig(entity);
			if (roleConfig == null)
			{
				return null;
			}
			int specialEnergyBarId = roleConfig.Value.SpecialEnergyBarId;
			SpecialEnergyBarInfo specialEnergyBarInfo = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(specialEnergyBarId);
			if (specialEnergyBarInfo == null)
			{
				return null;
			}
			if (specialEnergyBarInfo.TagEnergyBarIdMap == null || specialEnergyBarInfo.TagEnergyBarIdMap.Count <= 0)
			{
				return new SpecialEnergyAttributeIdInfo
				{
					AttributeId = (EAttributeType)specialEnergyBarInfo.AttributeId,
					MaxAttributeId = (EAttributeType)specialEnergyBarInfo.MaxAttributeId
				};
			}
			foreach (KeyValuePair<int, int> keyValuePair in specialEnergyBarInfo.TagEnergyBarIdMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (component.HasTag(key))
				{
					SpecialEnergyBarInfo specialEnergyBarInfo2 = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(value);
					if (specialEnergyBarInfo2 != null)
					{
						return new SpecialEnergyAttributeIdInfo
						{
							AttributeId = (EAttributeType)specialEnergyBarInfo2.AttributeId,
							MaxAttributeId = (EAttributeType)specialEnergyBarInfo2.MaxAttributeId
						};
					}
				}
			}
			return null;
		}

		// Token: 0x0603A707 RID: 239367 RVA: 0x010852B4 File Offset: 0x010834B4
		public RoleInfo? GetRoleConfig(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return null;
			}
			int roleId = component.GetRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			if (roleDataById == null)
			{
				return null;
			}
			return new RoleInfo?(roleDataById.GetRoleConfig());
		}

		// Token: 0x0603A708 RID: 239368 RVA: 0x01085304 File Offset: 0x01083504
		[return: Nullable(2)]
		public SpecialEnergyAttributeIdInfo GetDefaultSpecialEnergyAttributeId(Entity entity)
		{
			RoleInfo? roleConfig = this.GetRoleConfig(entity);
			if (roleConfig == null)
			{
				return null;
			}
			int specialEnergyBarId = roleConfig.Value.SpecialEnergyBarId;
			SpecialEnergyBarInfo specialEnergyBarInfo = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(specialEnergyBarId);
			if (specialEnergyBarInfo == null)
			{
				return null;
			}
			return new SpecialEnergyAttributeIdInfo
			{
				AttributeId = (EAttributeType)specialEnergyBarInfo.AttributeId,
				MaxAttributeId = (EAttributeType)specialEnergyBarInfo.MaxAttributeId
			};
		}
	}
}
