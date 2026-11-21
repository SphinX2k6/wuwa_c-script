using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D4 RID: 9940
	public static class ESubScreenInitDataTypeExtensions
	{
		// Token: 0x0600D614 RID: 54804 RVA: 0x001F1BF4 File Offset: 0x001EFDF4
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

		// Token: 0x0600D615 RID: 54805 RVA: 0x001F1C2C File Offset: 0x001EFE2C
		public static ESubScreenInitDataType FromString(string name)
		{
			ESubScreenInitDataType result;
			if (!ESubScreenInitDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenInitDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x001F1C55 File Offset: 0x001EFE55
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

		// Token: 0x0600D617 RID: 54807 RVA: 0x001F1C8E File Offset: 0x001EFE8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Preset",
				"Custom"
			};
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x001F1CA6 File Offset: 0x001EFEA6
		public static ESubScreenInitDataType[] GetValues()
		{
			return new ESubScreenInitDataType[]
			{
				ESubScreenInitDataType.Preset,
				ESubScreenInitDataType.Custom
			};
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x001F1CB2 File Offset: 0x001EFEB2
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
