using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002447 RID: 9287
	public static class ESyncOpenSystemBoardFinishTimingExtensions
	{
		// Token: 0x0600C9BE RID: 51646 RVA: 0x001D8880 File Offset: 0x001D6A80
		public static string ToEnumString(this ESyncOpenSystemBoardFinishTiming value)
		{
			string result;
			if (value == ESyncOpenSystemBoardFinishTiming.OpenFinished)
			{
				result = "OpenFinished";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x001D88A8 File Offset: 0x001D6AA8
		public static ESyncOpenSystemBoardFinishTiming FromString(string name)
		{
			ESyncOpenSystemBoardFinishTiming result;
			if (!ESyncOpenSystemBoardFinishTimingExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESyncOpenSystemBoardFinishTiming 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x001D88D1 File Offset: 0x001D6AD1
		public static bool TryFromString(string name, out ESyncOpenSystemBoardFinishTiming value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESyncOpenSystemBoardFinishTiming.OpenFinished;
				return false;
			}
			if (name == "OpenFinished")
			{
				value = ESyncOpenSystemBoardFinishTiming.OpenFinished;
				return true;
			}
			value = ESyncOpenSystemBoardFinishTiming.OpenFinished;
			return false;
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x001D88F6 File Offset: 0x001D6AF6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenFinished"
			};
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x001D8906 File Offset: 0x001D6B06
		public static ESyncOpenSystemBoardFinishTiming[] GetValues()
		{
			return new ESyncOpenSystemBoardFinishTiming[1];
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x001D890E File Offset: 0x001D6B0E
		public static string[] GetNames()
		{
			return new string[]
			{
				"OpenFinished"
			};
		}
	}
}
