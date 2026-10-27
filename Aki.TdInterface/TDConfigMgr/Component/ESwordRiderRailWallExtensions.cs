using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A26 RID: 2598
	public static class ESwordRiderRailWallExtensions
	{
		// Token: 0x0600395C RID: 14684 RVA: 0x000942F8 File Offset: 0x000924F8
		public static string ToEnumString(this ESwordRiderRailWall value)
		{
			string result;
			if (value != ESwordRiderRailWall.Inner)
			{
				if (value != ESwordRiderRailWall.Outer)
				{
					result = value.ToString();
				}
				else
				{
					result = "Outer";
				}
			}
			else
			{
				result = "Inner";
			}
			return result;
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00094330 File Offset: 0x00092530
		public static ESwordRiderRailWall FromString(string name)
		{
			ESwordRiderRailWall result;
			if (!ESwordRiderRailWallExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwordRiderRailWall 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00094359 File Offset: 0x00092559
		public static bool TryFromString(string name, out ESwordRiderRailWall value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwordRiderRailWall.Inner;
				return false;
			}
			if (name == "Inner")
			{
				value = ESwordRiderRailWall.Inner;
				return true;
			}
			if (!(name == "Outer"))
			{
				value = ESwordRiderRailWall.Inner;
				return false;
			}
			value = ESwordRiderRailWall.Outer;
			return true;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00094392 File Offset: 0x00092592
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Inner",
				"Outer"
			};
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x000943AA File Offset: 0x000925AA
		public static ESwordRiderRailWall[] GetValues()
		{
			return new ESwordRiderRailWall[]
			{
				ESwordRiderRailWall.Inner,
				ESwordRiderRailWall.Outer
			};
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000943B6 File Offset: 0x000925B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Inner",
				"Outer"
			};
		}
	}
}
