using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C8 RID: 9672
	public static class EHideTypeExtensions
	{
		// Token: 0x0600D15E RID: 53598 RVA: 0x001E540C File Offset: 0x001E360C
		public static string ToEnumString(this EHideType value)
		{
			string result;
			switch (value)
			{
			case EHideType.WorldMonsterAndMonsterTreasure:
				result = "WorldMonsterAndMonsterTreasure";
				break;
			case EHideType.WorldEntityAndLevelPlay:
				result = "WorldEntityAndLevelPlay";
				break;
			case EHideType.SpecifyEntity:
				result = "SpecifyEntity";
				break;
			case EHideType.SpecifyLevelPlay:
				result = "SpecifyLevelPlay";
				break;
			case EHideType.SpecifyDataLayers:
				result = "SpecifyDataLayers";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x001E546C File Offset: 0x001E366C
		public static EHideType FromString(string name)
		{
			EHideType result;
			if (!EHideTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHideType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D160 RID: 53600 RVA: 0x001E5498 File Offset: 0x001E3698
		public static bool TryFromString(string name, out EHideType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHideType.WorldMonsterAndMonsterTreasure;
				return false;
			}
			if (name == "WorldMonsterAndMonsterTreasure")
			{
				value = EHideType.WorldMonsterAndMonsterTreasure;
				return true;
			}
			if (name == "WorldEntityAndLevelPlay")
			{
				value = EHideType.WorldEntityAndLevelPlay;
				return true;
			}
			if (name == "SpecifyEntity")
			{
				value = EHideType.SpecifyEntity;
				return true;
			}
			if (name == "SpecifyLevelPlay")
			{
				value = EHideType.SpecifyLevelPlay;
				return true;
			}
			if (!(name == "SpecifyDataLayers"))
			{
				value = EHideType.WorldMonsterAndMonsterTreasure;
				return false;
			}
			value = EHideType.SpecifyDataLayers;
			return true;
		}

		// Token: 0x0600D161 RID: 53601 RVA: 0x001E5512 File Offset: 0x001E3712
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WorldMonsterAndMonsterTreasure",
				"WorldEntityAndLevelPlay",
				"SpecifyEntity",
				"SpecifyLevelPlay",
				"SpecifyDataLayers"
			};
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x001E5542 File Offset: 0x001E3742
		public static EHideType[] GetValues()
		{
			return new EHideType[]
			{
				EHideType.WorldMonsterAndMonsterTreasure,
				EHideType.WorldEntityAndLevelPlay,
				EHideType.SpecifyEntity,
				EHideType.SpecifyLevelPlay,
				EHideType.SpecifyDataLayers
			};
		}

		// Token: 0x0600D163 RID: 53603 RVA: 0x001E5555 File Offset: 0x001E3755
		public static string[] GetNames()
		{
			return new string[]
			{
				"WorldMonsterAndMonsterTreasure",
				"WorldEntityAndLevelPlay",
				"SpecifyEntity",
				"SpecifyLevelPlay",
				"SpecifyDataLayers"
			};
		}
	}
}
