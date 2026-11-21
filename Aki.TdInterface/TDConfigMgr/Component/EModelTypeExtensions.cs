using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4F RID: 2639
	public static class EModelTypeExtensions
	{
		// Token: 0x06003A76 RID: 14966 RVA: 0x00096E30 File Offset: 0x00095030
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

		// Token: 0x06003A77 RID: 14967 RVA: 0x00096E84 File Offset: 0x00095084
		public static EModelType FromString(string name)
		{
			EModelType result;
			if (!EModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00096EB0 File Offset: 0x000950B0
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

		// Token: 0x06003A79 RID: 14969 RVA: 0x00096F18 File Offset: 0x00095118
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

		// Token: 0x06003A7A RID: 14970 RVA: 0x00096F40 File Offset: 0x00095140
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

		// Token: 0x06003A7B RID: 14971 RVA: 0x00096F53 File Offset: 0x00095153
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
