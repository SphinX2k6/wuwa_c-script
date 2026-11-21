using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B3 RID: 2483
	public static class ECircuitConnectElementTypeExtensions
	{
		// Token: 0x060037B8 RID: 14264 RVA: 0x0008D3A8 File Offset: 0x0008B5A8
		public static string ToEnumString(this ECircuitConnectElementType value)
		{
			string result;
			switch (value)
			{
			case ECircuitConnectElementType.Straight:
				result = "Straight";
				break;
			case ECircuitConnectElementType.Curve:
				result = "Curve";
				break;
			case ECircuitConnectElementType.PowerPort:
				result = "PowerPort";
				break;
			case ECircuitConnectElementType.OutputPort:
				result = "OutputPort";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x0008D3FC File Offset: 0x0008B5FC
		public static ECircuitConnectElementType FromString(string name)
		{
			ECircuitConnectElementType result;
			if (!ECircuitConnectElementTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECircuitConnectElementType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0008D428 File Offset: 0x0008B628
		public static bool TryFromString(string name, out ECircuitConnectElementType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECircuitConnectElementType.Straight;
				return false;
			}
			if (name == "Straight")
			{
				value = ECircuitConnectElementType.Straight;
				return true;
			}
			if (name == "Curve")
			{
				value = ECircuitConnectElementType.Curve;
				return true;
			}
			if (name == "PowerPort")
			{
				value = ECircuitConnectElementType.PowerPort;
				return true;
			}
			if (!(name == "OutputPort"))
			{
				value = ECircuitConnectElementType.Straight;
				return false;
			}
			value = ECircuitConnectElementType.OutputPort;
			return true;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0008D490 File Offset: 0x0008B690
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Straight",
				"Curve",
				"PowerPort",
				"OutputPort"
			};
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0008D4B8 File Offset: 0x0008B6B8
		public static ECircuitConnectElementType[] GetValues()
		{
			return new ECircuitConnectElementType[]
			{
				ECircuitConnectElementType.Straight,
				ECircuitConnectElementType.Curve,
				ECircuitConnectElementType.PowerPort,
				ECircuitConnectElementType.OutputPort
			};
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x0008D4CB File Offset: 0x0008B6CB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Straight",
				"Curve",
				"PowerPort",
				"OutputPort"
			};
		}
	}
}
