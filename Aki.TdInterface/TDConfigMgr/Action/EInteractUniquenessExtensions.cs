using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002365 RID: 9061
	public static class EInteractUniquenessExtensions
	{
		// Token: 0x0600C5C5 RID: 50629 RVA: 0x001CEAD0 File Offset: 0x001CCCD0
		public static string ToEnumString(this EInteractUniqueness value)
		{
			string result;
			if (value == EInteractUniqueness.Closest)
			{
				result = "Closest";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C5C6 RID: 50630 RVA: 0x001CEAF8 File Offset: 0x001CCCF8
		public static EInteractUniqueness FromString(string name)
		{
			EInteractUniqueness result;
			if (!EInteractUniquenessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractUniqueness 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5C7 RID: 50631 RVA: 0x001CEB21 File Offset: 0x001CCD21
		public static bool TryFromString(string name, out EInteractUniqueness value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractUniqueness.Closest;
				return false;
			}
			if (name == "Closest")
			{
				value = EInteractUniqueness.Closest;
				return true;
			}
			value = EInteractUniqueness.Closest;
			return false;
		}

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x001CEB46 File Offset: 0x001CCD46
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Closest"
			};
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x001CEB56 File Offset: 0x001CCD56
		public static EInteractUniqueness[] GetValues()
		{
			return new EInteractUniqueness[1];
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x001CEB5E File Offset: 0x001CCD5E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Closest"
			};
		}
	}
}
