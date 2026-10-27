using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002427 RID: 9255
	public static class ESplineMoveDriveModeExtensions
	{
		// Token: 0x0600C92E RID: 51502 RVA: 0x001D752C File Offset: 0x001D572C
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

		// Token: 0x0600C92F RID: 51503 RVA: 0x001D7564 File Offset: 0x001D5764
		public static ESplineMoveDriveMode FromString(string name)
		{
			ESplineMoveDriveMode result;
			if (!ESplineMoveDriveModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveDriveMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C930 RID: 51504 RVA: 0x001D758D File Offset: 0x001D578D
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

		// Token: 0x0600C931 RID: 51505 RVA: 0x001D75C6 File Offset: 0x001D57C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"InputDriven",
				"PositionDriven"
			};
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x001D75DE File Offset: 0x001D57DE
		public static ESplineMoveDriveMode[] GetValues()
		{
			return new ESplineMoveDriveMode[]
			{
				ESplineMoveDriveMode.InputDriven,
				ESplineMoveDriveMode.PositionDriven
			};
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x001D75EA File Offset: 0x001D57EA
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
