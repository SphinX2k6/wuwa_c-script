using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253C RID: 9532
	public static class ECameraShakeTypeExtensions
	{
		// Token: 0x0600CEE8 RID: 52968 RVA: 0x001E00F8 File Offset: 0x001DE2F8
		public static string ToEnumString(this ECameraShakeType value)
		{
			string result;
			if (value != ECameraShakeType.Constant)
			{
				if (value != ECameraShakeType.LinearOverRange)
				{
					result = value.ToString();
				}
				else
				{
					result = "LinearOverRange";
				}
			}
			else
			{
				result = "Constant";
			}
			return result;
		}

		// Token: 0x0600CEE9 RID: 52969 RVA: 0x001E0130 File Offset: 0x001DE330
		public static ECameraShakeType FromString(string name)
		{
			ECameraShakeType result;
			if (!ECameraShakeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraShakeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x001E0159 File Offset: 0x001DE359
		public static bool TryFromString(string name, out ECameraShakeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECameraShakeType.Constant;
				return false;
			}
			if (name == "Constant")
			{
				value = ECameraShakeType.Constant;
				return true;
			}
			if (!(name == "LinearOverRange"))
			{
				value = ECameraShakeType.Constant;
				return false;
			}
			value = ECameraShakeType.LinearOverRange;
			return true;
		}

		// Token: 0x0600CEEB RID: 52971 RVA: 0x001E0192 File Offset: 0x001DE392
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Constant",
				"LinearOverRange"
			};
		}

		// Token: 0x0600CEEC RID: 52972 RVA: 0x001E01AA File Offset: 0x001DE3AA
		public static ECameraShakeType[] GetValues()
		{
			return new ECameraShakeType[]
			{
				ECameraShakeType.Constant,
				ECameraShakeType.LinearOverRange
			};
		}

		// Token: 0x0600CEED RID: 52973 RVA: 0x001E01B6 File Offset: 0x001DE3B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Constant",
				"LinearOverRange"
			};
		}
	}
}
