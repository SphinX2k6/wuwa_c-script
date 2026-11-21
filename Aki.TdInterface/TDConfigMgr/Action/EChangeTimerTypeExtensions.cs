using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002546 RID: 9542
	public static class EChangeTimerTypeExtensions
	{
		// Token: 0x0600CF15 RID: 53013 RVA: 0x001E06E4 File Offset: 0x001DE8E4
		public static string ToEnumString(this EChangeTimerType value)
		{
			string result;
			switch (value)
			{
			case EChangeTimerType.Add:
				result = "Add";
				break;
			case EChangeTimerType.Reduce:
				result = "Reduce";
				break;
			case EChangeTimerType.Set:
				result = "Set";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x001E072C File Offset: 0x001DE92C
		public static EChangeTimerType FromString(string name)
		{
			EChangeTimerType result;
			if (!EChangeTimerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeTimerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF17 RID: 53015 RVA: 0x001E0758 File Offset: 0x001DE958
		public static bool TryFromString(string name, out EChangeTimerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChangeTimerType.Add;
				return false;
			}
			if (name == "Add")
			{
				value = EChangeTimerType.Add;
				return true;
			}
			if (name == "Reduce")
			{
				value = EChangeTimerType.Reduce;
				return true;
			}
			if (!(name == "Set"))
			{
				value = EChangeTimerType.Add;
				return false;
			}
			value = EChangeTimerType.Set;
			return true;
		}

		// Token: 0x0600CF18 RID: 53016 RVA: 0x001E07AE File Offset: 0x001DE9AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Reduce",
				"Set"
			};
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x001E07CE File Offset: 0x001DE9CE
		public static EChangeTimerType[] GetValues()
		{
			return new EChangeTimerType[]
			{
				EChangeTimerType.Add,
				EChangeTimerType.Reduce,
				EChangeTimerType.Set
			};
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x001E07DE File Offset: 0x001DE9DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Add",
				"Reduce",
				"Set"
			};
		}
	}
}
