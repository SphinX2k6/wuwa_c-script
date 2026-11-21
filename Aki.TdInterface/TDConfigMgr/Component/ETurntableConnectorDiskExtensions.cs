using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B09 RID: 2825
	public static class ETurntableConnectorDiskExtensions
	{
		// Token: 0x06003DBB RID: 15803 RVA: 0x0009DD5C File Offset: 0x0009BF5C
		public static string ToEnumString(this ETurntableConnectorDisk value)
		{
			string result;
			switch (value)
			{
			case ETurntableConnectorDisk.Disk0:
				result = "Disk0";
				break;
			case ETurntableConnectorDisk.Disk1:
				result = "Disk1";
				break;
			case ETurntableConnectorDisk.Disk2:
				result = "Disk2";
				break;
			case ETurntableConnectorDisk.Disk3:
				result = "Disk3";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x0009DDB0 File Offset: 0x0009BFB0
		public static ETurntableConnectorDisk FromString(string name)
		{
			ETurntableConnectorDisk result;
			if (!ETurntableConnectorDiskExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETurntableConnectorDisk 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x0009DDDC File Offset: 0x0009BFDC
		public static bool TryFromString(string name, out ETurntableConnectorDisk value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETurntableConnectorDisk.Disk0;
				return false;
			}
			if (name == "Disk0")
			{
				value = ETurntableConnectorDisk.Disk0;
				return true;
			}
			if (name == "Disk1")
			{
				value = ETurntableConnectorDisk.Disk1;
				return true;
			}
			if (name == "Disk2")
			{
				value = ETurntableConnectorDisk.Disk2;
				return true;
			}
			if (!(name == "Disk3"))
			{
				value = ETurntableConnectorDisk.Disk0;
				return false;
			}
			value = ETurntableConnectorDisk.Disk3;
			return true;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x0009DE44 File Offset: 0x0009C044
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Disk0",
				"Disk1",
				"Disk2",
				"Disk3"
			};
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x0009DE6C File Offset: 0x0009C06C
		public static ETurntableConnectorDisk[] GetValues()
		{
			return new ETurntableConnectorDisk[]
			{
				ETurntableConnectorDisk.Disk0,
				ETurntableConnectorDisk.Disk1,
				ETurntableConnectorDisk.Disk2,
				ETurntableConnectorDisk.Disk3
			};
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x0009DE7F File Offset: 0x0009C07F
		public static string[] GetNames()
		{
			return new string[]
			{
				"Disk0",
				"Disk1",
				"Disk2",
				"Disk3"
			};
		}
	}
}
