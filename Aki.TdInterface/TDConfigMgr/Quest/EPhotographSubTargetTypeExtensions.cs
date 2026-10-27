using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001260 RID: 4704
	public static class EPhotographSubTargetTypeExtensions
	{
		// Token: 0x06006A57 RID: 27223 RVA: 0x000FEE00 File Offset: 0x000FD000
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

		// Token: 0x06006A58 RID: 27224 RVA: 0x000FEE38 File Offset: 0x000FD038
		public static EPhotographSubTargetType FromString(string name)
		{
			EPhotographSubTargetType result;
			if (!EPhotographSubTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhotographSubTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x000FEE61 File Offset: 0x000FD061
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

		// Token: 0x06006A5A RID: 27226 RVA: 0x000FEE9A File Offset: 0x000FD09A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpecificRole",
				"AnyRole"
			};
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x000FEEB2 File Offset: 0x000FD0B2
		public static EPhotographSubTargetType[] GetValues()
		{
			return new EPhotographSubTargetType[]
			{
				EPhotographSubTargetType.SpecificRole,
				EPhotographSubTargetType.AnyRole
			};
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x000FEEBE File Offset: 0x000FD0BE
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
