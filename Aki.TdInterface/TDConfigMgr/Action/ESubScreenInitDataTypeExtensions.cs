using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002433 RID: 9267
	public static class ESubScreenInitDataTypeExtensions
	{
		// Token: 0x0600C964 RID: 51556 RVA: 0x001D7D2C File Offset: 0x001D5F2C
		public static string ToEnumString(this ESubScreenInitDataType value)
		{
			string result;
			if (value != ESubScreenInitDataType.Preset)
			{
				if (value != ESubScreenInitDataType.Custom)
				{
					result = value.ToString();
				}
				else
				{
					result = "Custom";
				}
			}
			else
			{
				result = "Preset";
			}
			return result;
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x001D7D64 File Offset: 0x001D5F64
		public static ESubScreenInitDataType FromString(string name)
		{
			ESubScreenInitDataType result;
			if (!ESubScreenInitDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenInitDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x001D7D8D File Offset: 0x001D5F8D
		public static bool TryFromString(string name, out ESubScreenInitDataType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESubScreenInitDataType.Preset;
				return false;
			}
			if (name == "Preset")
			{
				value = ESubScreenInitDataType.Preset;
				return true;
			}
			if (!(name == "Custom"))
			{
				value = ESubScreenInitDataType.Preset;
				return false;
			}
			value = ESubScreenInitDataType.Custom;
			return true;
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x001D7DC6 File Offset: 0x001D5FC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Preset",
				"Custom"
			};
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x001D7DDE File Offset: 0x001D5FDE
		public static ESubScreenInitDataType[] GetValues()
		{
			return new ESubScreenInitDataType[]
			{
				ESubScreenInitDataType.Preset,
				ESubScreenInitDataType.Custom
			};
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x001D7DEA File Offset: 0x001D5FEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Preset",
				"Custom"
			};
		}
	}
}
