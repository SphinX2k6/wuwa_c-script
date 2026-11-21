using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B5 RID: 2485
	public static class ECircuitConnectModeExtensions
	{
		// Token: 0x060037C1 RID: 14273 RVA: 0x0008D530 File Offset: 0x0008B730
		public static string ToEnumString(this ECircuitConnectMode value)
		{
			string result;
			if (value != ECircuitConnectMode.TwoRings)
			{
				if (value != ECircuitConnectMode.ThreeRings)
				{
					result = value.ToString();
				}
				else
				{
					result = "ThreeRings";
				}
			}
			else
			{
				result = "TwoRings";
			}
			return result;
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0008D568 File Offset: 0x0008B768
		public static ECircuitConnectMode FromString(string name)
		{
			ECircuitConnectMode result;
			if (!ECircuitConnectModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECircuitConnectMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x0008D591 File Offset: 0x0008B791
		public static bool TryFromString(string name, out ECircuitConnectMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECircuitConnectMode.TwoRings;
				return false;
			}
			if (name == "TwoRings")
			{
				value = ECircuitConnectMode.TwoRings;
				return true;
			}
			if (!(name == "ThreeRings"))
			{
				value = ECircuitConnectMode.TwoRings;
				return false;
			}
			value = ECircuitConnectMode.ThreeRings;
			return true;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0008D5CA File Offset: 0x0008B7CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TwoRings",
				"ThreeRings"
			};
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x0008D5E2 File Offset: 0x0008B7E2
		public static ECircuitConnectMode[] GetValues()
		{
			return new ECircuitConnectMode[]
			{
				ECircuitConnectMode.TwoRings,
				ECircuitConnectMode.ThreeRings
			};
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0008D5EE File Offset: 0x0008B7EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TwoRings",
				"ThreeRings"
			};
		}
	}
}
