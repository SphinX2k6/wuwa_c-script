using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A43 RID: 2627
	public static class ELockTypeExtensions
	{
		// Token: 0x06003A40 RID: 14912 RVA: 0x00096700 File Offset: 0x00094900
		public static string ToEnumString(this ELockType value)
		{
			string result;
			switch (value)
			{
			case ELockType.Default:
				result = "Default";
				break;
			case ELockType.Program:
				result = "Program";
				break;
			case ELockType.Blackstone:
				result = "Blackstone";
				break;
			case ELockType.Holovision:
				result = "Holovision";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00096754 File Offset: 0x00094954
		public static ELockType FromString(string name)
		{
			ELockType result;
			if (!ELockTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELockType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00096780 File Offset: 0x00094980
		public static bool TryFromString(string name, out ELockType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELockType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = ELockType.Default;
				return true;
			}
			if (name == "Program")
			{
				value = ELockType.Program;
				return true;
			}
			if (name == "Blackstone")
			{
				value = ELockType.Blackstone;
				return true;
			}
			if (!(name == "Holovision"))
			{
				value = ELockType.Default;
				return false;
			}
			value = ELockType.Holovision;
			return true;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x000967E8 File Offset: 0x000949E8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Program",
				"Blackstone",
				"Holovision"
			};
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x00096810 File Offset: 0x00094A10
		public static ELockType[] GetValues()
		{
			return new ELockType[]
			{
				ELockType.Default,
				ELockType.Program,
				ELockType.Blackstone,
				ELockType.Holovision
			};
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00096823 File Offset: 0x00094A23
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Program",
				"Blackstone",
				"Holovision"
			};
		}
	}
}
