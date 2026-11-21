using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002720 RID: 10016
	public static class ETraceTracingGridTypeExtensions
	{
		// Token: 0x0600D76A RID: 55146 RVA: 0x001F7774 File Offset: 0x001F5974
		public static string ToEnumString(this ETraceTracingGridType value)
		{
			string result;
			switch (value)
			{
			case ETraceTracingGridType.Block:
				result = "Block";
				break;
			case ETraceTracingGridType.Empty:
				result = "Empty";
				break;
			case ETraceTracingGridType.Chess1:
				result = "Chess1";
				break;
			case ETraceTracingGridType.Chess2:
				result = "Chess2";
				break;
			case ETraceTracingGridType.Chess3:
				result = "Chess3";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x001F77D4 File Offset: 0x001F59D4
		public static ETraceTracingGridType FromString(string name)
		{
			ETraceTracingGridType result;
			if (!ETraceTracingGridTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETraceTracingGridType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x001F7800 File Offset: 0x001F5A00
		public static bool TryFromString(string name, out ETraceTracingGridType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETraceTracingGridType.Block;
				return false;
			}
			if (name == "Block")
			{
				value = ETraceTracingGridType.Block;
				return true;
			}
			if (name == "Empty")
			{
				value = ETraceTracingGridType.Empty;
				return true;
			}
			if (name == "Chess1")
			{
				value = ETraceTracingGridType.Chess1;
				return true;
			}
			if (name == "Chess2")
			{
				value = ETraceTracingGridType.Chess2;
				return true;
			}
			if (!(name == "Chess3"))
			{
				value = ETraceTracingGridType.Block;
				return false;
			}
			value = ETraceTracingGridType.Chess3;
			return true;
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x001F787A File Offset: 0x001F5A7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Block",
				"Empty",
				"Chess1",
				"Chess2",
				"Chess3"
			};
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x001F78AA File Offset: 0x001F5AAA
		public static ETraceTracingGridType[] GetValues()
		{
			return new ETraceTracingGridType[]
			{
				ETraceTracingGridType.Block,
				ETraceTracingGridType.Empty,
				ETraceTracingGridType.Chess1,
				ETraceTracingGridType.Chess2,
				ETraceTracingGridType.Chess3
			};
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x001F78BD File Offset: 0x001F5ABD
		public static string[] GetNames()
		{
			return new string[]
			{
				"Block",
				"Empty",
				"Chess1",
				"Chess2",
				"Chess3"
			};
		}
	}
}
