using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002353 RID: 9043
	public static class EHideTypeExtensions
	{
		// Token: 0x0600C574 RID: 50548 RVA: 0x001CD12C File Offset: 0x001CB32C
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

		// Token: 0x0600C575 RID: 50549 RVA: 0x001CD18C File Offset: 0x001CB38C
		public static EHideType FromString(string name)
		{
			EHideType result;
			if (!EHideTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHideType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x001CD1B8 File Offset: 0x001CB3B8
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

		// Token: 0x0600C577 RID: 50551 RVA: 0x001CD232 File Offset: 0x001CB432
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

		// Token: 0x0600C578 RID: 50552 RVA: 0x001CD262 File Offset: 0x001CB462
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

		// Token: 0x0600C579 RID: 50553 RVA: 0x001CD275 File Offset: 0x001CB475
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
