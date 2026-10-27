using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E5 RID: 9189
	public static class ERandomPrefabTypeExtensions
	{
		// Token: 0x0600C805 RID: 51205 RVA: 0x001D48F0 File Offset: 0x001D2AF0
		public static string ToEnumString(this ERandomPrefabType value)
		{
			string result;
			if (value == ERandomPrefabType.Rogue)
			{
				result = "Rogue";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x001D4918 File Offset: 0x001D2B18
		public static ERandomPrefabType FromString(string name)
		{
			ERandomPrefabType result;
			if (!ERandomPrefabTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERandomPrefabType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x001D4941 File Offset: 0x001D2B41
		public static bool TryFromString(string name, out ERandomPrefabType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERandomPrefabType.Rogue;
				return false;
			}
			if (name == "Rogue")
			{
				value = ERandomPrefabType.Rogue;
				return true;
			}
			value = ERandomPrefabType.Rogue;
			return false;
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x001D4966 File Offset: 0x001D2B66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Rogue"
			};
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x001D4976 File Offset: 0x001D2B76
		public static ERandomPrefabType[] GetValues()
		{
			return new ERandomPrefabType[1];
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x001D497E File Offset: 0x001D2B7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Rogue"
			};
		}
	}
}
