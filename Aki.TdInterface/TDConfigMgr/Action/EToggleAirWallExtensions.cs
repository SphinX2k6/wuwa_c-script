using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002718 RID: 10008
	public static class EToggleAirWallExtensions
	{
		// Token: 0x0600D746 RID: 55110 RVA: 0x001F7324 File Offset: 0x001F5524
		public static string ToEnumString(this EToggleAirWall value)
		{
			string result;
			if (value != EToggleAirWall.Open)
			{
				if (value != EToggleAirWall.Close)
				{
					result = value.ToString();
				}
				else
				{
					result = "Close";
				}
			}
			else
			{
				result = "Open";
			}
			return result;
		}

		// Token: 0x0600D747 RID: 55111 RVA: 0x001F735C File Offset: 0x001F555C
		public static EToggleAirWall FromString(string name)
		{
			EToggleAirWall result;
			if (!EToggleAirWallExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EToggleAirWall 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D748 RID: 55112 RVA: 0x001F7385 File Offset: 0x001F5585
		public static bool TryFromString(string name, out EToggleAirWall value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EToggleAirWall.Open;
				return false;
			}
			if (name == "Open")
			{
				value = EToggleAirWall.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = EToggleAirWall.Open;
				return false;
			}
			value = EToggleAirWall.Close;
			return true;
		}

		// Token: 0x0600D749 RID: 55113 RVA: 0x001F73BE File Offset: 0x001F55BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600D74A RID: 55114 RVA: 0x001F73D6 File Offset: 0x001F55D6
		public static EToggleAirWall[] GetValues()
		{
			return new EToggleAirWall[]
			{
				EToggleAirWall.Open,
				EToggleAirWall.Close
			};
		}

		// Token: 0x0600D74B RID: 55115 RVA: 0x001F73E2 File Offset: 0x001F55E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}
	}
}
