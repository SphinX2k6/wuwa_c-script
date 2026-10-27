using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096C RID: 2412
	public static class EInhalationPerformanceTypeExtensions
	{
		// Token: 0x06003617 RID: 13847 RVA: 0x0008D2F8 File Offset: 0x0008B4F8
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

		// Token: 0x06003618 RID: 13848 RVA: 0x0008D330 File Offset: 0x0008B530
		public static EInhalationPerformanceType FromString(string name)
		{
			EInhalationPerformanceType result;
			if (!EInhalationPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInhalationPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x0008D359 File Offset: 0x0008B559
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

		// Token: 0x0600361A RID: 13850 RVA: 0x0008D392 File Offset: 0x0008B592
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role",
				"SceneItem"
			};
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0008D3AA File Offset: 0x0008B5AA
		public static EInhalationPerformanceType[] GetValues()
		{
			return new EInhalationPerformanceType[]
			{
				EInhalationPerformanceType.Role,
				EInhalationPerformanceType.SceneItem
			};
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0008D3B6 File Offset: 0x0008B5B6
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
