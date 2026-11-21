using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1F RID: 2591
	public static class EInhalationPerformanceTypeExtensions
	{
		// Token: 0x0600399E RID: 14750 RVA: 0x00095264 File Offset: 0x00093464
		public static string ToEnumString(this EInhalationPerformanceType value)
		{
			string result;
			if (value != EInhalationPerformanceType.Role)
			{
				if (value != EInhalationPerformanceType.SceneItem)
				{
					result = value.ToString();
				}
				else
				{
					result = "SceneItem";
				}
			}
			else
			{
				result = "Role";
			}
			return result;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x0009529C File Offset: 0x0009349C
		public static EInhalationPerformanceType FromString(string name)
		{
			EInhalationPerformanceType result;
			if (!EInhalationPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInhalationPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x000952C5 File Offset: 0x000934C5
		public static bool TryFromString(string name, out EInhalationPerformanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInhalationPerformanceType.Role;
				return false;
			}
			if (name == "Role")
			{
				value = EInhalationPerformanceType.Role;
				return true;
			}
			if (!(name == "SceneItem"))
			{
				value = EInhalationPerformanceType.Role;
				return false;
			}
			value = EInhalationPerformanceType.SceneItem;
			return true;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x000952FE File Offset: 0x000934FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role",
				"SceneItem"
			};
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00095316 File Offset: 0x00093516
		public static EInhalationPerformanceType[] GetValues()
		{
			return new EInhalationPerformanceType[]
			{
				EInhalationPerformanceType.Role,
				EInhalationPerformanceType.SceneItem
			};
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00095322 File Offset: 0x00093522
		public static string[] GetNames()
		{
			return new string[]
			{
				"Role",
				"SceneItem"
			};
		}
	}
}
