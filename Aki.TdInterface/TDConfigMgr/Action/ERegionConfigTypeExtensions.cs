using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E7 RID: 9191
	public static class ERegionConfigTypeExtensions
	{
		// Token: 0x0600C80E RID: 51214 RVA: 0x001D49CC File Offset: 0x001D2BCC
		public static string ToEnumString(this ERegionConfigType value)
		{
			string result;
			if (value == ERegionConfigType.Mpc)
			{
				result = "Mpc";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C80F RID: 51215 RVA: 0x001D49F4 File Offset: 0x001D2BF4
		public static ERegionConfigType FromString(string name)
		{
			ERegionConfigType result;
			if (!ERegionConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERegionConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C810 RID: 51216 RVA: 0x001D4A1D File Offset: 0x001D2C1D
		public static bool TryFromString(string name, out ERegionConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERegionConfigType.Mpc;
				return false;
			}
			if (name == "Mpc")
			{
				value = ERegionConfigType.Mpc;
				return true;
			}
			value = ERegionConfigType.Mpc;
			return false;
		}

		// Token: 0x0600C811 RID: 51217 RVA: 0x001D4A42 File Offset: 0x001D2C42
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mpc"
			};
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x001D4A52 File Offset: 0x001D2C52
		public static ERegionConfigType[] GetValues()
		{
			return new ERegionConfigType[1];
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x001D4A5A File Offset: 0x001D2C5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mpc"
			};
		}
	}
}
