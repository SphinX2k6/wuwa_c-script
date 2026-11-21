using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272A RID: 10026
	public static class ETrapDefenseTipTypeExtensions
	{
		// Token: 0x0600D797 RID: 55191 RVA: 0x001F7DCC File Offset: 0x001F5FCC
		public static string ToEnumString(this ETrapDefenseTipType value)
		{
			string result;
			if (value == ETrapDefenseTipType.OpenNewAreaTip)
			{
				result = "OpenNewAreaTip";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x001F7DF4 File Offset: 0x001F5FF4
		public static ETrapDefenseTipType FromString(string name)
		{
			ETrapDefenseTipType result;
			if (!ETrapDefenseTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D799 RID: 55193 RVA: 0x001F7E1D File Offset: 0x001F601D
		public static bool TryFromString(string name, out ETrapDefenseTipType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrapDefenseTipType.OpenNewAreaTip;
				return false;
			}
			if (name == "OpenNewAreaTip")
			{
				value = ETrapDefenseTipType.OpenNewAreaTip;
				return true;
			}
			value = ETrapDefenseTipType.OpenNewAreaTip;
			return false;
		}

		// Token: 0x0600D79A RID: 55194 RVA: 0x001F7E42 File Offset: 0x001F6042
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenNewAreaTip"
			};
		}

		// Token: 0x0600D79B RID: 55195 RVA: 0x001F7E52 File Offset: 0x001F6052
		public static ETrapDefenseTipType[] GetValues()
		{
			return new ETrapDefenseTipType[1];
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x001F7E5A File Offset: 0x001F605A
		public static string[] GetNames()
		{
			return new string[]
			{
				"OpenNewAreaTip"
			};
		}
	}
}
