using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A41 RID: 2625
	public static class ELiftBuffTypeExtensions
	{
		// Token: 0x06003A37 RID: 14903 RVA: 0x000965EC File Offset: 0x000947EC
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

		// Token: 0x06003A38 RID: 14904 RVA: 0x00096624 File Offset: 0x00094824
		public static ELiftBuffType FromString(string name)
		{
			ELiftBuffType result;
			if (!ELiftBuffTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiftBuffType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x0009664D File Offset: 0x0009484D
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

		// Token: 0x06003A3A RID: 14906 RVA: 0x00096686 File Offset: 0x00094886
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DefaultLiftBuff",
				"AllowJumpDash"
			};
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0009669E File Offset: 0x0009489E
		public static ELiftBuffType[] GetValues()
		{
			return new ELiftBuffType[]
			{
				ELiftBuffType.DefaultLiftBuff,
				ELiftBuffType.AllowJumpDash
			};
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x000966AA File Offset: 0x000948AA
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
