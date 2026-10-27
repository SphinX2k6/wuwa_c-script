using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099C RID: 2460
	public static class EModelTypeExtensions
	{
		// Token: 0x060036EF RID: 14063 RVA: 0x0008EE80 File Offset: 0x0008D080
		public static string ToEnumString(this EModelType value)
		{
			string result;
			switch (value)
			{
			case EModelType.LevelPrefab:
				result = "LevelPrefab";
				break;
			case EModelType.ModelId:
				result = "ModelId";
				break;
			case EModelType.Npc:
				result = "Npc";
				break;
			case EModelType.Animal:
				result = "Animal";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x0008EED4 File Offset: 0x0008D0D4
		public static EModelType FromString(string name)
		{
			EModelType result;
			if (!EModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x0008EF00 File Offset: 0x0008D100
		public static bool TryFromString(string name, out EModelType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EModelType.LevelPrefab;
				return false;
			}
			if (name == "LevelPrefab")
			{
				value = EModelType.LevelPrefab;
				return true;
			}
			if (name == "ModelId")
			{
				value = EModelType.ModelId;
				return true;
			}
			if (name == "Npc")
			{
				value = EModelType.Npc;
				return true;
			}
			if (!(name == "Animal"))
			{
				value = EModelType.LevelPrefab;
				return false;
			}
			value = EModelType.Animal;
			return true;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0008EF68 File Offset: 0x0008D168
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelPrefab",
				"ModelId",
				"Npc",
				"Animal"
			};
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x0008EF90 File Offset: 0x0008D190
		public static EModelType[] GetValues()
		{
			return new EModelType[]
			{
				EModelType.LevelPrefab,
				EModelType.ModelId,
				EModelType.Npc,
				EModelType.Animal
			};
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x0008EFA3 File Offset: 0x0008D1A3
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelPrefab",
				"ModelId",
				"Npc",
				"Animal"
			};
		}
	}
}
