using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A6D RID: 2669
	public static class ENpcStandbyShowModeExtensions
	{
		// Token: 0x06003AFD RID: 15101 RVA: 0x000982E4 File Offset: 0x000964E4
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

		// Token: 0x06003AFE RID: 15102 RVA: 0x0009832C File Offset: 0x0009652C
		public static ENpcStandbyShowMode FromString(string name)
		{
			ENpcStandbyShowMode result;
			if (!ENpcStandbyShowModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcStandbyShowMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00098358 File Offset: 0x00096558
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

		// Token: 0x06003B00 RID: 15104 RVA: 0x000983AE File Offset: 0x000965AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Finite",
				"Loop",
				"Sit"
			};
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x000983CE File Offset: 0x000965CE
		public static ENpcStandbyShowMode[] GetValues()
		{
			return new ENpcStandbyShowMode[]
			{
				ENpcStandbyShowMode.Finite,
				ENpcStandbyShowMode.Loop,
				ENpcStandbyShowMode.Sit
			};
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x000983DE File Offset: 0x000965DE
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
