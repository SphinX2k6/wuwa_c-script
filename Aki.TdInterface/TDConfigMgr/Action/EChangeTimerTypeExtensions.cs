using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D7 RID: 8919
	public static class EChangeTimerTypeExtensions
	{
		// Token: 0x0600C346 RID: 49990 RVA: 0x001C88DC File Offset: 0x001C6ADC
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

		// Token: 0x0600C347 RID: 49991 RVA: 0x001C8924 File Offset: 0x001C6B24
		public static EChangeTimerType FromString(string name)
		{
			EChangeTimerType result;
			if (!EChangeTimerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeTimerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C348 RID: 49992 RVA: 0x001C8950 File Offset: 0x001C6B50
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

		// Token: 0x0600C349 RID: 49993 RVA: 0x001C89A6 File Offset: 0x001C6BA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Reduce",
				"Set"
			};
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x001C89C6 File Offset: 0x001C6BC6
		public static EChangeTimerType[] GetValues()
		{
			return new EChangeTimerType[]
			{
				EChangeTimerType.Add,
				EChangeTimerType.Reduce,
				EChangeTimerType.Set
			};
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x001C89D6 File Offset: 0x001C6BD6
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
