using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FE RID: 30718
	public class ISetNpcGroupPerformType_UnionUnion
	{
		// Token: 0x1700E11F RID: 57631
		// (get) Token: 0x06035F69 RID: 221033 RVA: 0x0073A831 File Offset: 0x00738A31
		// (set) Token: 0x06035F6A RID: 221034 RVA: 0x0073A839 File Offset: 0x00738A39
		public ISetNpcGroupPerformType_Union Type { get; set; }

		// Token: 0x1700E120 RID: 57632
		// (get) Token: 0x06035F6B RID: 221035 RVA: 0x0073A842 File Offset: 0x00738A42
		// (set) Token: 0x06035F6C RID: 221036 RVA: 0x0073A84A File Offset: 0x00738A4A
		public object Value { get; set; }

		// Token: 0x06035F6D RID: 221037 RVA: 0x0073A853 File Offset: 0x00738A53
		public ISetNpcGroupPerformType_UnionUnion()
		{
			this.Type = ISetNpcGroupPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035F6E RID: 221038 RVA: 0x0073A869 File Offset: 0x00738A69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035F6F RID: 221039 RVA: 0x0073A87B File Offset: 0x00738A7B
		public ISetNpcGroupPerformTypeT AsISetNpcGroupPerformType()
		{
			return this.As<ISetNpcGroupPerformTypeT>();
		}

		// Token: 0x06035F70 RID: 221040 RVA: 0x0073A883 File Offset: 0x00738A83
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcGroupPerformType(ISetNpcGroupPerformTypeT _isetnpcgroupperformtype)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcGroupPerformType,
				Value = _isetnpcgroupperformtype
			};
		}

		// Token: 0x06035F71 RID: 221041 RVA: 0x0073A898 File Offset: 0x00738A98
		public ISetNpcHandInHandPerformT AsISetNpcHandInHandPerform()
		{
			return this.As<ISetNpcHandInHandPerformT>();
		}

		// Token: 0x06035F72 RID: 221042 RVA: 0x0073A8A0 File Offset: 0x00738AA0
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHandInHandPerform(ISetNpcHandInHandPerformT _isetnpchandinhandperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHandInHandPerform,
				Value = _isetnpchandinhandperform
			};
		}

		// Token: 0x06035F73 RID: 221043 RVA: 0x0073A8B5 File Offset: 0x00738AB5
		public ISetNpcHighFivePerformT AsISetNpcHighFivePerform()
		{
			return this.As<ISetNpcHighFivePerformT>();
		}

		// Token: 0x06035F74 RID: 221044 RVA: 0x0073A8BD File Offset: 0x00738ABD
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHighFivePerform(ISetNpcHighFivePerformT _isetnpchighfiveperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHighFivePerform,
				Value = _isetnpchighfiveperform
			};
		}

		// Token: 0x06035F75 RID: 221045 RVA: 0x0073A8D2 File Offset: 0x00738AD2
		public ISetNpcHuggingBearPerformT AsISetNpcHuggingBearPerform()
		{
			return this.As<ISetNpcHuggingBearPerformT>();
		}

		// Token: 0x06035F76 RID: 221046 RVA: 0x0073A8DA File Offset: 0x00738ADA
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHuggingBearPerform(ISetNpcHuggingBearPerformT _isetnpchuggingbearperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHuggingBearPerform,
				Value = _isetnpchuggingbearperform
			};
		}

		// Token: 0x06035F77 RID: 221047 RVA: 0x0073A8EF File Offset: 0x00738AEF
		public ISetNpcTwoPersonPerformT AsISetNpcTwoPersonPerform()
		{
			return this.As<ISetNpcTwoPersonPerformT>();
		}

		// Token: 0x06035F78 RID: 221048 RVA: 0x0073A8F7 File Offset: 0x00738AF7
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcTwoPersonPerform(ISetNpcTwoPersonPerformT _isetnpctwopersonperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcTwoPersonPerform,
				Value = _isetnpctwopersonperform
			};
		}

		// Token: 0x06035F79 RID: 221049 RVA: 0x0073A90C File Offset: 0x00738B0C
		public ISetNpcSupportedWalkingPerformT AsISetNpcSupportedWalkingPerform()
		{
			return this.As<ISetNpcSupportedWalkingPerformT>();
		}

		// Token: 0x06035F7A RID: 221050 RVA: 0x0073A914 File Offset: 0x00738B14
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcSupportedWalkingPerform(ISetNpcSupportedWalkingPerformT _isetnpcsupportedwalkingperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcSupportedWalkingPerform,
				Value = _isetnpcsupportedwalkingperform
			};
		}

		// Token: 0x06035F7B RID: 221051 RVA: 0x0073A929 File Offset: 0x00738B29
		public ISetNpcSequencePerformT AsISetNpcSequencePerform()
		{
			return this.As<ISetNpcSequencePerformT>();
		}

		// Token: 0x06035F7C RID: 221052 RVA: 0x0073A931 File Offset: 0x00738B31
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcSequencePerform(ISetNpcSequencePerformT _isetnpcsequenceperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcSequencePerform,
				Value = _isetnpcsequenceperform
			};
		}

		// Token: 0x06035F7D RID: 221053 RVA: 0x0073A948 File Offset: 0x00738B48
		public static int Pack(FlatBufferBuilder builder, ISetNpcGroupPerformType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetNpcGroupPerformType_Union.ISetNpcGroupPerformType:
				return ISetNpcGroupPerformType.Pack(builder, _o.AsISetNpcGroupPerformType()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcHandInHandPerform:
				return ISetNpcHandInHandPerform.Pack(builder, _o.AsISetNpcHandInHandPerform()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcHighFivePerform:
				return ISetNpcHighFivePerform.Pack(builder, _o.AsISetNpcHighFivePerform()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcHuggingBearPerform:
				return ISetNpcHuggingBearPerform.Pack(builder, _o.AsISetNpcHuggingBearPerform()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcTwoPersonPerform:
				return ISetNpcTwoPersonPerform.Pack(builder, _o.AsISetNpcTwoPersonPerform()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcSupportedWalkingPerform:
				return ISetNpcSupportedWalkingPerform.Pack(builder, _o.AsISetNpcSupportedWalkingPerform()).Value;
			case ISetNpcGroupPerformType_Union.ISetNpcSequencePerform:
				return ISetNpcSequencePerform.Pack(builder, _o.AsISetNpcSequencePerform()).Value;
			default:
				return 0;
			}
		}
	}
}
