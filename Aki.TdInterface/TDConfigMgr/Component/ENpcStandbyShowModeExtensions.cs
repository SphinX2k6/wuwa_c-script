using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B8 RID: 2488
	public static class ENpcStandbyShowModeExtensions
	{
		// Token: 0x0600376D RID: 14189 RVA: 0x000901AC File Offset: 0x0008E3AC
		public static string ToEnumString(this ENpcStandbyShowMode value)
		{
			string result;
			switch (value)
			{
			case ENpcStandbyShowMode.Finite:
				result = "Finite";
				break;
			case ENpcStandbyShowMode.Loop:
				result = "Loop";
				break;
			case ENpcStandbyShowMode.Sit:
				result = "Sit";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x000901F4 File Offset: 0x0008E3F4
		public static ENpcStandbyShowMode FromString(string name)
		{
			ENpcStandbyShowMode result;
			if (!ENpcStandbyShowModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcStandbyShowMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00090220 File Offset: 0x0008E420
		public static bool TryFromString(string name, out ENpcStandbyShowMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcStandbyShowMode.Finite;
				return false;
			}
			if (name == "Finite")
			{
				value = ENpcStandbyShowMode.Finite;
				return true;
			}
			if (name == "Loop")
			{
				value = ENpcStandbyShowMode.Loop;
				return true;
			}
			if (!(name == "Sit"))
			{
				value = ENpcStandbyShowMode.Finite;
				return false;
			}
			value = ENpcStandbyShowMode.Sit;
			return true;
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00090276 File Offset: 0x0008E476
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Finite",
				"Loop",
				"Sit"
			};
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00090296 File Offset: 0x0008E496
		public static ENpcStandbyShowMode[] GetValues()
		{
			return new ENpcStandbyShowMode[]
			{
				ENpcStandbyShowMode.Finite,
				ENpcStandbyShowMode.Loop,
				ENpcStandbyShowMode.Sit
			};
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x000902A6 File Offset: 0x0008E4A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Finite",
				"Loop",
				"Sit"
			};
		}
	}
}
