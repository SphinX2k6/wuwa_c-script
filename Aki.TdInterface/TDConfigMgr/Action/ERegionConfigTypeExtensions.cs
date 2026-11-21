using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267E RID: 9854
	public static class ERegionConfigTypeExtensions
	{
		// Token: 0x0600D491 RID: 54417 RVA: 0x001EE178 File Offset: 0x001EC378
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

		// Token: 0x0600D492 RID: 54418 RVA: 0x001EE1A0 File Offset: 0x001EC3A0
		public static ERegionConfigType FromString(string name)
		{
			ERegionConfigType result;
			if (!ERegionConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERegionConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x001EE1C9 File Offset: 0x001EC3C9
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

		// Token: 0x0600D494 RID: 54420 RVA: 0x001EE1EE File Offset: 0x001EC3EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mpc"
			};
		}

		// Token: 0x0600D495 RID: 54421 RVA: 0x001EE1FE File Offset: 0x001EC3FE
		public static ERegionConfigType[] GetValues()
		{
			return new ERegionConfigType[1];
		}

		// Token: 0x0600D496 RID: 54422 RVA: 0x001EE206 File Offset: 0x001EC406
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mpc"
			};
		}
	}
}
