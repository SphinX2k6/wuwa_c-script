using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C1 RID: 9409
	public static class TPlayModeExtensions
	{
		// Token: 0x0600CBE3 RID: 52195 RVA: 0x001E0640 File Offset: 0x001DE840
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

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x001E0694 File Offset: 0x001DE894
		public static TPlayMode FromString(string name)
		{
			TPlayMode result;
			if (!TPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBE5 RID: 52197 RVA: 0x001E06C0 File Offset: 0x001DE8C0
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

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x001E0728 File Offset: 0x001DE928
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

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x001E0750 File Offset: 0x001DE950
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

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x001E0763 File Offset: 0x001DE963
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
