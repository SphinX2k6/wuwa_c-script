using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E8 RID: 9960
	public static class ESyncOpenSystemBoardFinishTimingExtensions
	{
		// Token: 0x0600D66E RID: 54894 RVA: 0x001F2748 File Offset: 0x001F0948
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

		// Token: 0x0600D66F RID: 54895 RVA: 0x001F2770 File Offset: 0x001F0970
		public static ESyncOpenSystemBoardFinishTiming FromString(string name)
		{
			ESyncOpenSystemBoardFinishTiming result;
			if (!ESyncOpenSystemBoardFinishTimingExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESyncOpenSystemBoardFinishTiming 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D670 RID: 54896 RVA: 0x001F2799 File Offset: 0x001F0999
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

		// Token: 0x0600D671 RID: 54897 RVA: 0x001F27BE File Offset: 0x001F09BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OpenFinished"
			};
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x001F27CE File Offset: 0x001F09CE
		public static ESyncOpenSystemBoardFinishTiming[] GetValues()
		{
			return new ESyncOpenSystemBoardFinishTiming[1];
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x001F27D6 File Offset: 0x001F09D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"OpenFinished"
			};
		}
	}
}
