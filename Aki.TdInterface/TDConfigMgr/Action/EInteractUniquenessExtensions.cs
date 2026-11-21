using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DA RID: 9690
	public static class EInteractUniquenessExtensions
	{
		// Token: 0x0600D1AF RID: 53679 RVA: 0x001E6DB0 File Offset: 0x001E4FB0
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

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x001E6DD8 File Offset: 0x001E4FD8
		public static EInteractUniqueness FromString(string name)
		{
			EInteractUniqueness result;
			if (!EInteractUniquenessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractUniqueness 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1B1 RID: 53681 RVA: 0x001E6E01 File Offset: 0x001E5001
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

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x001E6E26 File Offset: 0x001E5026
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Closest"
			};
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x001E6E36 File Offset: 0x001E5036
		public static EInteractUniqueness[] GetValues()
		{
			return new EInteractUniqueness[1];
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x001E6E3E File Offset: 0x001E503E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Closest"
			};
		}
	}
}
