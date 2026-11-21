using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002662 RID: 9826
	public static class EPlayerAiControlTypeExtensions
	{
		// Token: 0x0600D413 RID: 54291 RVA: 0x001ECED8 File Offset: 0x001EB0D8
		public static string ToEnumString(this EPlayerAiControlType value)
		{
			string result;
			if (value != EPlayerAiControlType.Enable)
			{
				if (value != EPlayerAiControlType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600D414 RID: 54292 RVA: 0x001ECF10 File Offset: 0x001EB110
		public static EPlayerAiControlType FromString(string name)
		{
			EPlayerAiControlType result;
			if (!EPlayerAiControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerAiControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D415 RID: 54293 RVA: 0x001ECF39 File Offset: 0x001EB139
		public static bool TryFromString(string name, out EPlayerAiControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerAiControlType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EPlayerAiControlType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EPlayerAiControlType.Enable;
				return false;
			}
			value = EPlayerAiControlType.Disable;
			return true;
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x001ECF72 File Offset: 0x001EB172
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x001ECF8A File Offset: 0x001EB18A
		public static EPlayerAiControlType[] GetValues()
		{
			return new EPlayerAiControlType[]
			{
				EPlayerAiControlType.Enable,
				EPlayerAiControlType.Disable
			};
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x001ECF96 File Offset: 0x001EB196
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
