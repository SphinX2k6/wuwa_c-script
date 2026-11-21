using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C6 RID: 9926
	public static class ESplineMoveDriveModeExtensions
	{
		// Token: 0x0600D5D5 RID: 54741 RVA: 0x001F1200 File Offset: 0x001EF400
		public static string ToEnumString(this ESplineMoveDriveMode value)
		{
			string result;
			if (value != ESplineMoveDriveMode.InputDriven)
			{
				if (value != ESplineMoveDriveMode.PositionDriven)
				{
					result = value.ToString();
				}
				else
				{
					result = "PositionDriven";
				}
			}
			else
			{
				result = "InputDriven";
			}
			return result;
		}

		// Token: 0x0600D5D6 RID: 54742 RVA: 0x001F1238 File Offset: 0x001EF438
		public static ESplineMoveDriveMode FromString(string name)
		{
			ESplineMoveDriveMode result;
			if (!ESplineMoveDriveModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveDriveMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x001F1261 File Offset: 0x001EF461
		public static bool TryFromString(string name, out ESplineMoveDriveMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMoveDriveMode.InputDriven;
				return false;
			}
			if (name == "InputDriven")
			{
				value = ESplineMoveDriveMode.InputDriven;
				return true;
			}
			if (!(name == "PositionDriven"))
			{
				value = ESplineMoveDriveMode.InputDriven;
				return false;
			}
			value = ESplineMoveDriveMode.PositionDriven;
			return true;
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x001F129A File Offset: 0x001EF49A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InputDriven",
				"PositionDriven"
			};
		}

		// Token: 0x0600D5D9 RID: 54745 RVA: 0x001F12B2 File Offset: 0x001EF4B2
		public static ESplineMoveDriveMode[] GetValues()
		{
			return new ESplineMoveDriveMode[]
			{
				ESplineMoveDriveMode.InputDriven,
				ESplineMoveDriveMode.PositionDriven
			};
		}

		// Token: 0x0600D5DA RID: 54746 RVA: 0x001F12BE File Offset: 0x001EF4BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"InputDriven",
				"PositionDriven"
			};
		}
	}
}
