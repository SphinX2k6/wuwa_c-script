using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002477 RID: 9335
	public static class EToggleAirWallExtensions
	{
		// Token: 0x0600CA96 RID: 51862 RVA: 0x001DD270 File Offset: 0x001DB470
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

		// Token: 0x0600CA97 RID: 51863 RVA: 0x001DD2A8 File Offset: 0x001DB4A8
		public static EToggleAirWall FromString(string name)
		{
			EToggleAirWall result;
			if (!EToggleAirWallExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EToggleAirWall 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x001DD2D1 File Offset: 0x001DB4D1
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

		// Token: 0x0600CA99 RID: 51865 RVA: 0x001DD30A File Offset: 0x001DB50A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x001DD322 File Offset: 0x001DB522
		public static EToggleAirWall[] GetValues()
		{
			return new EToggleAirWall[]
			{
				EToggleAirWall.Open,
				EToggleAirWall.Close
			};
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x001DD32E File Offset: 0x001DB52E
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
