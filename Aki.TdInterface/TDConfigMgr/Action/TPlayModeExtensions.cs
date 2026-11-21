using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002766 RID: 10086
	public static class TPlayModeExtensions
	{
		// Token: 0x0600D8A5 RID: 55461 RVA: 0x001FA8D4 File Offset: 0x001F8AD4
		public static string ToEnumString(this TPlayMode value)
		{
			string result;
			switch (value)
			{
			case TPlayMode.direct:
				result = "direct";
				break;
			case TPlayMode.instant:
				result = "instant";
				break;
			case TPlayMode.loop:
				result = "loop";
				break;
			case TPlayMode.shortestPath:
				result = "shortestPath";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x001FA928 File Offset: 0x001F8B28
		public static TPlayMode FromString(string name)
		{
			TPlayMode result;
			if (!TPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D8A7 RID: 55463 RVA: 0x001FA954 File Offset: 0x001F8B54
		public static bool TryFromString(string name, out TPlayMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TPlayMode.direct;
				return false;
			}
			if (name == "direct")
			{
				value = TPlayMode.direct;
				return true;
			}
			if (name == "instant")
			{
				value = TPlayMode.instant;
				return true;
			}
			if (name == "loop")
			{
				value = TPlayMode.loop;
				return true;
			}
			if (!(name == "shortestPath"))
			{
				value = TPlayMode.direct;
				return false;
			}
			value = TPlayMode.shortestPath;
			return true;
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x001FA9BC File Offset: 0x001F8BBC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"direct",
				"instant",
				"loop",
				"shortestPath"
			};
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x001FA9E4 File Offset: 0x001F8BE4
		public static TPlayMode[] GetValues()
		{
			return new TPlayMode[]
			{
				TPlayMode.direct,
				TPlayMode.instant,
				TPlayMode.loop,
				TPlayMode.shortestPath
			};
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x001FA9F7 File Offset: 0x001F8BF7
		public static string[] GetNames()
		{
			return new string[]
			{
				"direct",
				"instant",
				"loop",
				"shortestPath"
			};
		}
	}
}
