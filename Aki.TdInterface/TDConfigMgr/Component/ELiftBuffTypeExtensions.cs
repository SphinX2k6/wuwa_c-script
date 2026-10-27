using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098E RID: 2446
	public static class ELiftBuffTypeExtensions
	{
		// Token: 0x060036B0 RID: 14000 RVA: 0x0008E680 File Offset: 0x0008C880
		public static string ToEnumString(this ELiftBuffType value)
		{
			string result;
			if (value != ELiftBuffType.DefaultLiftBuff)
			{
				if (value != ELiftBuffType.AllowJumpDash)
				{
					result = value.ToString();
				}
				else
				{
					result = "AllowJumpDash";
				}
			}
			else
			{
				result = "DefaultLiftBuff";
			}
			return result;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0008E6B8 File Offset: 0x0008C8B8
		public static ELiftBuffType FromString(string name)
		{
			ELiftBuffType result;
			if (!ELiftBuffTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiftBuffType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0008E6E1 File Offset: 0x0008C8E1
		public static bool TryFromString(string name, out ELiftBuffType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiftBuffType.DefaultLiftBuff;
				return false;
			}
			if (name == "DefaultLiftBuff")
			{
				value = ELiftBuffType.DefaultLiftBuff;
				return true;
			}
			if (!(name == "AllowJumpDash"))
			{
				value = ELiftBuffType.DefaultLiftBuff;
				return false;
			}
			value = ELiftBuffType.AllowJumpDash;
			return true;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0008E71A File Offset: 0x0008C91A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DefaultLiftBuff",
				"AllowJumpDash"
			};
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x0008E732 File Offset: 0x0008C932
		public static ELiftBuffType[] GetValues()
		{
			return new ELiftBuffType[]
			{
				ELiftBuffType.DefaultLiftBuff,
				ELiftBuffType.AllowJumpDash
			};
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0008E73E File Offset: 0x0008C93E
		public static string[] GetNames()
		{
			return new string[]
			{
				"DefaultLiftBuff",
				"AllowJumpDash"
			};
		}
	}
}
