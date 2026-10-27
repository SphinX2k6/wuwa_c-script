using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D3 RID: 8915
	public static class EChangeEntityPrefabPerformanceTypeExtensions
	{
		// Token: 0x0600C334 RID: 49972 RVA: 0x001C8670 File Offset: 0x001C6870
		public static string ToEnumString(this EChangeEntityPrefabPerformanceType value)
		{
			string result;
			if (value != EChangeEntityPrefabPerformanceType.Target)
			{
				if (value != EChangeEntityPrefabPerformanceType.Self)
				{
					result = value.ToString();
				}
				else
				{
					result = "Self";
				}
			}
			else
			{
				result = "Target";
			}
			return result;
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x001C86A8 File Offset: 0x001C68A8
		public static EChangeEntityPrefabPerformanceType FromString(string name)
		{
			EChangeEntityPrefabPerformanceType result;
			if (!EChangeEntityPrefabPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeEntityPrefabPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x001C86D1 File Offset: 0x001C68D1
		public static bool TryFromString(string name, out EChangeEntityPrefabPerformanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return false;
			}
			if (name == "Target")
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return true;
			}
			if (!(name == "Self"))
			{
				value = EChangeEntityPrefabPerformanceType.Target;
				return false;
			}
			value = EChangeEntityPrefabPerformanceType.Self;
			return true;
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x001C870A File Offset: 0x001C690A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Target",
				"Self"
			};
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x001C8722 File Offset: 0x001C6922
		public static EChangeEntityPrefabPerformanceType[] GetValues()
		{
			return new EChangeEntityPrefabPerformanceType[]
			{
				EChangeEntityPrefabPerformanceType.Target,
				EChangeEntityPrefabPerformanceType.Self
			};
		}

		// Token: 0x0600C339 RID: 49977 RVA: 0x001C872E File Offset: 0x001C692E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Target",
				"Self"
			};
		}
	}
}
