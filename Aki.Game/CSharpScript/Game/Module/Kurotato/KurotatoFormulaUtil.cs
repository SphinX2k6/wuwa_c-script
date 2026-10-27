using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005718 RID: 22296
	[NullableContext(1)]
	[Nullable(0)]
	public static class KurotatoFormulaUtil
	{
		// Token: 0x06038AA6 RID: 232102 RVA: 0x00D70A54 File Offset: 0x00D6EC54
		public static float GetFormulaResult(int formulaId, int weaponId = 0, int weaponIncId = 0)
		{
			KurotatoFormula? formulaById = KurotatoConfig.Instance.GetFormulaById(formulaId);
			if (formulaById == null)
			{
				return 0f;
			}
			KurotatoFormula value = formulaById.Value;
			float value2;
			switch (value.Type)
			{
			case 1:
				value2 = KurotatoFormulaUtil.CalcFormulaType1(value, weaponId, weaponIncId);
				break;
			case 2:
				value2 = KurotatoFormulaUtil.CalcFormulaType2(value, weaponId);
				break;
			case 3:
				value2 = KurotatoFormulaUtil.CalcFormulaType3(value, weaponId, weaponIncId);
				break;
			case 4:
				value2 = KurotatoFormulaUtil.CalcFormulaType4(value, weaponId, weaponIncId);
				break;
			case 5:
				value2 = KurotatoFormulaUtil.CalcFormulaType5(value, weaponId, weaponIncId);
				break;
			case 6:
				value2 = KurotatoFormulaUtil.CalcFormulaType6(value, weaponId, weaponIncId);
				break;
			default:
				return 0f;
			}
			double num = (double)KurotatoFormulaUtil.ApplyLimit(value2, value);
			float num2 = (float)Math.Pow(10.0, (double)value.Precision);
			return (float)(Math.Ceiling(num * (double)num2) / (double)num2);
		}

		// Token: 0x06038AA7 RID: 232103 RVA: 0x00D70B24 File Offset: 0x00D6ED24
		private static float ApplyLimit(float value, KurotatoFormula config)
		{
			EKurotatoFormulaLimitType limitType = (EKurotatoFormulaLimitType)config.LimitType;
			float num = value;
			if (limitType == EKurotatoFormulaLimitType.HasUpperLimit || limitType == EKurotatoFormulaLimitType.AllHasLimit)
			{
				num = Math.Min(num, (float)config.UpperLimit);
			}
			if (limitType == EKurotatoFormulaLimitType.HasLowerLimit || limitType == EKurotatoFormulaLimitType.AllHasLimit)
			{
				num = Math.Max(num, (float)config.LowerLimit);
			}
			return num;
		}

		// Token: 0x06038AA8 RID: 232104 RVA: 0x00D70B6A File Offset: 0x00D6ED6A
		public static float GetAttr(int attrType)
		{
			return (float)KurotatoModel.Instance.BattleData.GetPlayerPropertyValue(attrType);
		}

		// Token: 0x06038AA9 RID: 232105 RVA: 0x00D70B80 File Offset: 0x00D6ED80
		private static float GetWeaponEntityAttrValue(int attrType, int weaponIncId)
		{
			AKSC_Entity weaponEntity = KurotatoFormulaUtil.GetWeaponEntity(weaponIncId);
			if (weaponEntity == null)
			{
				return 0f;
			}
			UKSC_SkillComp skillComp = weaponEntity.GetSkillComp();
			int? num;
			if (skillComp == null)
			{
				num = null;
			}
			else
			{
				UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
				if (attrSet_ == null)
				{
					num = null;
				}
				else
				{
					TMap<EKSC_AttrType, int> attrs_ = attrSet_.Attrs_;
					num = ((attrs_ != null) ? attrs_.GetValueOrNull((EKSC_AttrType)attrType) : null);
				}
			}
			int? num2 = num;
			return (float)num2.GetValueOrDefault();
		}

		// Token: 0x06038AAA RID: 232106 RVA: 0x00D70BEC File Offset: 0x00D6EDEC
		private static float CalcFormulaType1(KurotatoFormula config, int weaponId, int weaponIncId)
		{
			float num = KurotatoFormulaUtil.ResolvePropValue(config.Prop1, weaponId, weaponIncId) + KurotatoFormulaUtil.ResolvePropValue(config.Prop2, weaponId, weaponIncId) + KurotatoFormulaUtil.ResolvePropValue(config.Prop3, weaponId, weaponIncId);
			if (config.ParamInt1 == 0)
			{
				return num;
			}
			return num / (float)config.ParamInt1;
		}

		// Token: 0x06038AAB RID: 232107 RVA: 0x00D70C3C File Offset: 0x00D6EE3C
		private static float ResolvePropValue(string prop, int weaponId, int weaponIncId)
		{
			if (string.IsNullOrEmpty(prop))
			{
				return 0f;
			}
			int num = prop.IndexOf(':');
			if (num < 0)
			{
				return 0f;
			}
			string propertyVarName = prop.Substring(0, num);
			string a = prop.Substring(num + 1);
			KurotatoProperty? propertyByPropertyVarName = KurotatoConfig.Instance.GetPropertyByPropertyVarName(propertyVarName);
			if (propertyByPropertyVarName == null)
			{
				return 0f;
			}
			int id = propertyByPropertyVarName.Value.Id;
			if (a == "R")
			{
				return KurotatoFormulaUtil.GetAttr(id);
			}
			if (a == "W")
			{
				return KurotatoFormulaUtil.GetWeaponEntityAttrValue(id, weaponIncId);
			}
			if (!(a == "WB"))
			{
				return 0f;
			}
			return KurotatoFormulaUtil.GetWeaponBasicPropertyValue(id, weaponId);
		}

		// Token: 0x06038AAC RID: 232108 RVA: 0x00D70CF4 File Offset: 0x00D6EEF4
		private static float GetWeaponBasicPropertyValue(int propId, int weaponId)
		{
			KurotatoProperty? propertyById = KurotatoConfig.Instance.GetPropertyById(propId);
			string text = (propertyById != null) ? propertyById.GetValueOrDefault().KSCBasePropertyVarName : null;
			if (string.IsNullOrEmpty(text))
			{
				return 0f;
			}
			KurotatoWeapon? weaponConfigByWeaponId = KurotatoConfig.Instance.GetWeaponConfigByWeaponId(weaponId);
			if (weaponConfigByWeaponId == null)
			{
				return 0f;
			}
			KurotatoWeapon value = weaponConfigByWeaponId.Value;
			Func<KurotatoWeapon, float> func;
			if (KurotatoFormulaUtil.WeaponBasicPropertyMap.TryGetValue(propId, out func))
			{
				return func(value);
			}
			KSCBaseProperty? baseProperty = KurotatoConfig.Instance.GetBaseProperty(value.BasicProperty);
			if (baseProperty == null)
			{
				return 0f;
			}
			return KurotatoFormulaUtil.GetKSCBasePropertyValue(baseProperty.Value, text);
		}

		// Token: 0x06038AAD RID: 232109 RVA: 0x00D70DA4 File Offset: 0x00D6EFA4
		private static float GetKSCBasePropertyValue(KSCBaseProperty baseProperty, string varName)
		{
			PropertyInfo property = typeof(KSCBaseProperty).GetProperty(varName);
			if (property != null)
			{
				object value = property.GetValue(baseProperty);
				if (value is float)
				{
					return (float)value;
				}
				if (value is int)
				{
					int num = (int)value;
					return (float)num;
				}
				if (value is long)
				{
					long num2 = (long)value;
					return (float)num2;
				}
				if (value is double)
				{
					double num3 = (double)value;
					return (float)num3;
				}
			}
			FieldInfo field = typeof(KSCBaseProperty).GetField(varName);
			if (field != null)
			{
				object value2 = field.GetValue(baseProperty);
				if (value2 is float)
				{
					return (float)value2;
				}
				if (value2 is int)
				{
					int num4 = (int)value2;
					return (float)num4;
				}
				if (value2 is long)
				{
					long num5 = (long)value2;
					return (float)num5;
				}
				if (value2 is double)
				{
					double num6 = (double)value2;
					return (float)num6;
				}
			}
			return 0f;
		}

		// Token: 0x06038AAE RID: 232110 RVA: 0x00D70EAC File Offset: 0x00D6F0AC
		[NullableContext(2)]
		private static AKSC_Entity GetWeaponEntity(int weaponIncId)
		{
			PotatoSubModel potatoSubModel = KuroSimpleCombatController.Instance.CurSubModel as PotatoSubModel;
			if (((potatoSubModel != null) ? potatoSubModel.WeaponKscEntityMap : null) == null)
			{
				return null;
			}
			AKSC_Entity result;
			if (!potatoSubModel.WeaponKscEntityMap.TryGetValue(weaponIncId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06038AAF RID: 232111 RVA: 0x00D70EEC File Offset: 0x00D6F0EC
		private static float CalcFormulaType2(KurotatoFormula config, int weaponId)
		{
			KurotatoFormulaUtil.<>c__DisplayClass12_0 CS$<>8__locals1;
			CS$<>8__locals1.weaponId = weaponId;
			float num = (float)config.ParamInt1 / 10000f;
			float num2 = (float)config.ParamInt2 / 10000f;
			float num3 = (float)config.ParamInt3 / 10000f;
			float num4 = (float)config.ParamInt4 / 10000f;
			float num5 = (float)config.ParamInt5 / 10000f;
			float num6 = (float)config.ParamInt6 / 10000f;
			float num7 = (float)config.ParamInt7 / 10000f;
			int paramInt = config.ParamInt8;
			int paramInt2 = config.ParamInt9;
			float num8 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Atk, ref CS$<>8__locals1);
			float num9 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.LifeMax, ref CS$<>8__locals1);
			float num10 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.DamageChangePhys, ref CS$<>8__locals1);
			float num11 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom120, ref CS$<>8__locals1);
			float num12 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom121, ref CS$<>8__locals1);
			float num13 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom122, ref CS$<>8__locals1);
			float num14 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom123, ref CS$<>8__locals1);
			float num15 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom124, ref CS$<>8__locals1);
			float num16 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom125, ref CS$<>8__locals1);
			float num17 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom126, ref CS$<>8__locals1);
			float num18 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom127, ref CS$<>8__locals1);
			float num19 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom128, ref CS$<>8__locals1);
			float num20 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom129, ref CS$<>8__locals1);
			float num21 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom130, ref CS$<>8__locals1);
			float num22 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom131, ref CS$<>8__locals1);
			float num23 = KurotatoFormulaUtil.<CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType.Custom132, ref CS$<>8__locals1);
			float num24 = 1f + num10 / 10000f;
			float num25 = num8 * num24 * num + num9 * num24 * num2 + num11 * (num24 + num16 / 10000f) * num3 + num12 * (num24 + num17 / 10000f) * num4 + num13 * (num24 + num18 / 10000f) * num5 + num14 * (num24 + num19 / 10000f) * num6 + num15 * num24 * num7;
			float num26 = 1f + ((1f + num21 / 10000f) * (1f + num23 / 10000f) - 1f) * (float)paramInt;
			float num27 = 1f + ((1f + num20 / 10000f) * (1f + num22 / 10000f) - 1f) * (float)paramInt2;
			return num25 * num26 * num27;
		}

		// Token: 0x06038AB0 RID: 232112 RVA: 0x00D7110C File Offset: 0x00D6F30C
		private static float CalcFormulaType3(KurotatoFormula config, int weaponId, int weaponIncId)
		{
			float num = KurotatoFormulaUtil.ResolvePropValue(config.Prop1, weaponId, weaponIncId);
			float num2 = KurotatoFormulaUtil.ResolvePropValue(config.Prop2, weaponId, weaponIncId);
			float num3 = Math.Max(1f + num2 / 10000f, 0.1f);
			return num / num3;
		}

		// Token: 0x06038AB1 RID: 232113 RVA: 0x00D71150 File Offset: 0x00D6F350
		private static float CalcFormulaType4(KurotatoFormula config, int weaponId, int weaponIncId)
		{
			float num = KurotatoFormulaUtil.ResolvePropValue(config.Prop1, weaponId, weaponIncId);
			float num2 = KurotatoFormulaUtil.ResolvePropValue(config.Prop2, weaponId, weaponIncId);
			return num * (1f + num2 / 10000f);
		}

		// Token: 0x06038AB2 RID: 232114 RVA: 0x00D71188 File Offset: 0x00D6F388
		private static float CalcFormulaType5(KurotatoFormula config, int weaponId, int weaponIncId)
		{
			return KurotatoFormulaUtil.ResolvePropValue(config.Prop1, weaponId, weaponIncId) * (float)config.ParamInt1 / 10000f;
		}

		// Token: 0x06038AB3 RID: 232115 RVA: 0x00D711A8 File Offset: 0x00D6F3A8
		private static float CalcFormulaType6(KurotatoFormula config, int weaponId, int weaponIncId)
		{
			float num = KurotatoFormulaUtil.ResolvePropValue(config.Prop1, weaponId, weaponIncId);
			if (config.ParamInt1 == 0)
			{
				return num;
			}
			float num2 = KurotatoFormulaUtil.ResolvePropValue(config.Prop2, weaponId, weaponIncId);
			return num * (1f + num2 / (float)config.ParamInt1);
		}

		// Token: 0x06038AB5 RID: 232117 RVA: 0x00D7128E File Offset: 0x00D6F48E
		[CompilerGenerated]
		internal static float <CalcFormulaType2>g__GetAttrWithWeaponBasic|12_0(EKSC_AttrType attrType, ref KurotatoFormulaUtil.<>c__DisplayClass12_0 A_1)
		{
			return KurotatoFormulaUtil.GetAttr((int)attrType) + KurotatoFormulaUtil.GetWeaponBasicPropertyValue((int)attrType, A_1.weaponId);
		}

		// Token: 0x0401DBFD RID: 121853
		private const float PERMYRIAD_RATIO = 10000f;

		// Token: 0x0401DBFE RID: 121854
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyDictionary<int, Func<KurotatoWeapon, float>> WeaponBasicPropertyMap = new Dictionary<int, Func<KurotatoWeapon, float>>
		{
			{
				220,
				(KurotatoWeapon weapon) => weapon.AttackSpeedBasic
			},
			{
				136,
				(KurotatoWeapon weapon) => (float)weapon.Attr136Basic
			},
			{
				139,
				(KurotatoWeapon weapon) => (float)weapon.Attr139Basic
			},
			{
				140,
				(KurotatoWeapon weapon) => (float)weapon.Attr140Basic
			},
			{
				151,
				(KurotatoWeapon weapon) => (float)weapon.Attr151Basic
			}
		};

		// Token: 0x0401DBFF RID: 121855
		private const float MinDivisor = 0.1f;
	}
}
