using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247D RID: 9341
	public static class ETraceTracingGridTypeExtensions
	{
		// Token: 0x0600CAB1 RID: 51889 RVA: 0x001DD5AC File Offset: 0x001DB7AC
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

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x001DD60C File Offset: 0x001DB80C
		public static ETraceTracingGridType FromString(string name)
		{
			ETraceTracingGridType result;
			if (!ETraceTracingGridTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETraceTracingGridType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x001DD638 File Offset: 0x001DB838
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

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x001DD6B2 File Offset: 0x001DB8B2
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

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x001DD6E2 File Offset: 0x001DB8E2
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

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x001DD6F5 File Offset: 0x001DB8F5
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
