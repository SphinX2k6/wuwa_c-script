using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A0 RID: 5024
	public static class EPhotographSubTargetTypeExtensions
	{
		// Token: 0x060070AA RID: 28842 RVA: 0x0010CA2C File Offset: 0x0010AC2C
		public static string ToEnumString(this EPhotographSubTargetType value)
		{
			string result;
			if (value != EPhotographSubTargetType.SpecificRole)
			{
				if (value != EPhotographSubTargetType.AnyRole)
				{
					result = value.ToString();
				}
				else
				{
					result = "AnyRole";
				}
			}
			else
			{
				result = "SpecificRole";
			}
			return result;
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x0010CA64 File Offset: 0x0010AC64
		public static EPhotographSubTargetType FromString(string name)
		{
			EPhotographSubTargetType result;
			if (!EPhotographSubTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhotographSubTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x0010CA8D File Offset: 0x0010AC8D
		public static bool TryFromString(string name, out EPhotographSubTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhotographSubTargetType.SpecificRole;
				return false;
			}
			if (name == "SpecificRole")
			{
				value = EPhotographSubTargetType.SpecificRole;
				return true;
			}
			if (!(name == "AnyRole"))
			{
				value = EPhotographSubTargetType.SpecificRole;
				return false;
			}
			value = EPhotographSubTargetType.AnyRole;
			return true;
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x0010CAC6 File Offset: 0x0010ACC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpecificRole",
				"AnyRole"
			};
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x0010CADE File Offset: 0x0010ACDE
		public static EPhotographSubTargetType[] GetValues()
		{
			return new EPhotographSubTargetType[]
			{
				EPhotographSubTargetType.SpecificRole,
				EPhotographSubTargetType.AnyRole
			};
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x0010CAEA File Offset: 0x0010ACEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpecificRole",
				"AnyRole"
			};
		}
	}
}
