using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000990 RID: 2448
	public static class ELockTypeExtensions
	{
		// Token: 0x060036B9 RID: 14009 RVA: 0x0008E794 File Offset: 0x0008C994
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

		// Token: 0x060036BA RID: 14010 RVA: 0x0008E7E8 File Offset: 0x0008C9E8
		public static ELockType FromString(string name)
		{
			ELockType result;
			if (!ELockTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELockType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x0008E814 File Offset: 0x0008CA14
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

		// Token: 0x060036BC RID: 14012 RVA: 0x0008E87C File Offset: 0x0008CA7C
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

		// Token: 0x060036BD RID: 14013 RVA: 0x0008E8A4 File Offset: 0x0008CAA4
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

		// Token: 0x060036BE RID: 14014 RVA: 0x0008E8B7 File Offset: 0x0008CAB7
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
