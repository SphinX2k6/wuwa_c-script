using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002616 RID: 9750
	public static class EMoraleUiTypeExtensions
	{
		// Token: 0x0600D2BD RID: 53949 RVA: 0x001EA208 File Offset: 0x001E8408
		public static string ToEnumString(this EMoraleUiType value)
		{
			string result;
			if (value != EMoraleUiType.MoraleUi24)
			{
				if (value != EMoraleUiType.MoraleUi32)
				{
					result = value.ToString();
				}
				else
				{
					result = "MoraleUi3_2";
				}
			}
			else
			{
				result = "MoraleUi2_4";
			}
			return result;
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x001EA240 File Offset: 0x001E8440
		public static EMoraleUiType FromString(string name)
		{
			EMoraleUiType result;
			if (!EMoraleUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoraleUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x001EA269 File Offset: 0x001E8469
		public static bool TryFromString(string name, out EMoraleUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoraleUiType.MoraleUi24;
				return false;
			}
			if (name == "MoraleUi2_4")
			{
				value = EMoraleUiType.MoraleUi24;
				return true;
			}
			if (!(name == "MoraleUi3_2"))
			{
				value = EMoraleUiType.MoraleUi24;
				return false;
			}
			value = EMoraleUiType.MoraleUi32;
			return true;
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x001EA2A2 File Offset: 0x001E84A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoraleUi2_4",
				"MoraleUi3_2"
			};
		}

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x001EA2BA File Offset: 0x001E84BA
		public static EMoraleUiType[] GetValues()
		{
			return new EMoraleUiType[]
			{
				EMoraleUiType.MoraleUi24,
				EMoraleUiType.MoraleUi32
			};
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x001EA2C6 File Offset: 0x001E84C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoraleUi24",
				"MoraleUi32"
			};
		}
	}
}
