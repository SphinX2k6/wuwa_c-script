using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0B RID: 2827
	public static class ETurntableConnectorGameplayTypeExtensions
	{
		// Token: 0x06003DC4 RID: 15812 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		public static string ToEnumString(this ETurntableConnectorGameplayType value)
		{
			string result;
			if (value == ETurntableConnectorGameplayType.CircuitConnect)
			{
				result = "CircuitConnect";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x0009DF0C File Offset: 0x0009C10C
		public static ETurntableConnectorGameplayType FromString(string name)
		{
			ETurntableConnectorGameplayType result;
			if (!ETurntableConnectorGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETurntableConnectorGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x0009DF35 File Offset: 0x0009C135
		public static bool TryFromString(string name, out ETurntableConnectorGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETurntableConnectorGameplayType.CircuitConnect;
				return false;
			}
			if (name == "CircuitConnect")
			{
				value = ETurntableConnectorGameplayType.CircuitConnect;
				return true;
			}
			value = ETurntableConnectorGameplayType.CircuitConnect;
			return false;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x0009DF5A File Offset: 0x0009C15A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CircuitConnect"
			};
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x0009DF6A File Offset: 0x0009C16A
		public static ETurntableConnectorGameplayType[] GetValues()
		{
			return new ETurntableConnectorGameplayType[1];
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x0009DF72 File Offset: 0x0009C172
		public static string[] GetNames()
		{
			return new string[]
			{
				"CircuitConnect"
			};
		}
	}
}
