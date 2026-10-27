using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1A RID: 2586
	public static class ESpecialNpcTypeExtensions
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x000938D4 File Offset: 0x00091AD4
		public static string ToEnumString(this ESpecialNpcType value)
		{
			string result;
			if (value == ESpecialNpcType.BaseRoleNpc)
			{
				result = "BaseRoleNpc";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x000938FC File Offset: 0x00091AFC
		public static ESpecialNpcType FromString(string name)
		{
			ESpecialNpcType result;
			if (!ESpecialNpcTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialNpcType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00093925 File Offset: 0x00091B25
		public static bool TryFromString(string name, out ESpecialNpcType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialNpcType.BaseRoleNpc;
				return false;
			}
			if (name == "BaseRoleNpc")
			{
				value = ESpecialNpcType.BaseRoleNpc;
				return true;
			}
			value = ESpecialNpcType.BaseRoleNpc;
			return false;
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0009394A File Offset: 0x00091B4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BaseRoleNpc"
			};
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0009395A File Offset: 0x00091B5A
		public static ESpecialNpcType[] GetValues()
		{
			return new ESpecialNpcType[1];
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00093962 File Offset: 0x00091B62
		public static string[] GetNames()
		{
			return new string[]
			{
				"BaseRoleNpc"
			};
		}
	}
}
