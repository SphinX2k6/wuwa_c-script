using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007035 RID: 28725
	public class ISetNpcGroupPerformType_UnionUnion
	{
		// Token: 0x1700D54B RID: 54603
		// (get) Token: 0x06032D02 RID: 208130 RVA: 0x006DAB91 File Offset: 0x006D8D91
		// (set) Token: 0x06032D03 RID: 208131 RVA: 0x006DAB99 File Offset: 0x006D8D99
		public ISetNpcGroupPerformType_Union Type { get; set; }

		// Token: 0x1700D54C RID: 54604
		// (get) Token: 0x06032D04 RID: 208132 RVA: 0x006DABA2 File Offset: 0x006D8DA2
		// (set) Token: 0x06032D05 RID: 208133 RVA: 0x006DABAA File Offset: 0x006D8DAA
		public object Value { get; set; }

		// Token: 0x06032D06 RID: 208134 RVA: 0x006DABB3 File Offset: 0x006D8DB3
		public ISetNpcGroupPerformType_UnionUnion()
		{
			this.Type = ISetNpcGroupPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032D07 RID: 208135 RVA: 0x006DABC9 File Offset: 0x006D8DC9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032D08 RID: 208136 RVA: 0x006DABDB File Offset: 0x006D8DDB
		public ISetNpcGroupPerformTypeT AsISetNpcGroupPerformType()
		{
			return this.As<ISetNpcGroupPerformTypeT>();
		}

		// Token: 0x06032D09 RID: 208137 RVA: 0x006DABE3 File Offset: 0x006D8DE3
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcGroupPerformType(ISetNpcGroupPerformTypeT _isetnpcgroupperformtype)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcGroupPerformType,
				Value = _isetnpcgroupperformtype
			};
		}

		// Token: 0x06032D0A RID: 208138 RVA: 0x006DABF8 File Offset: 0x006D8DF8
		public ISetNpcHandInHandPerformT AsISetNpcHandInHandPerform()
		{
			return this.As<ISetNpcHandInHandPerformT>();
		}

		// Token: 0x06032D0B RID: 208139 RVA: 0x006DAC00 File Offset: 0x006D8E00
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHandInHandPerform(ISetNpcHandInHandPerformT _isetnpchandinhandperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHandInHandPerform,
				Value = _isetnpchandinhandperform
			};
		}

		// Token: 0x06032D0C RID: 208140 RVA: 0x006DAC15 File Offset: 0x006D8E15
		public ISetNpcHighFivePerformT AsISetNpcHighFivePerform()
		{
			return this.As<ISetNpcHighFivePerformT>();
		}

		// Token: 0x06032D0D RID: 208141 RVA: 0x006DAC1D File Offset: 0x006D8E1D
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHighFivePerform(ISetNpcHighFivePerformT _isetnpchighfiveperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHighFivePerform,
				Value = _isetnpchighfiveperform
			};
		}

		// Token: 0x06032D0E RID: 208142 RVA: 0x006DAC32 File Offset: 0x006D8E32
		public ISetNpcHuggingBearPerformT AsISetNpcHuggingBearPerform()
		{
			return this.As<ISetNpcHuggingBearPerformT>();
		}

		// Token: 0x06032D0F RID: 208143 RVA: 0x006DAC3A File Offset: 0x006D8E3A
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcHuggingBearPerform(ISetNpcHuggingBearPerformT _isetnpchuggingbearperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcHuggingBearPerform,
				Value = _isetnpchuggingbearperform
			};
		}

		// Token: 0x06032D10 RID: 208144 RVA: 0x006DAC4F File Offset: 0x006D8E4F
		public ISetNpcTwoPersonPerformT AsISetNpcTwoPersonPerform()
		{
			return this.As<ISetNpcTwoPersonPerformT>();
		}

		// Token: 0x06032D11 RID: 208145 RVA: 0x006DAC57 File Offset: 0x006D8E57
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcTwoPersonPerform(ISetNpcTwoPersonPerformT _isetnpctwopersonperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcTwoPersonPerform,
				Value = _isetnpctwopersonperform
			};
		}

		// Token: 0x06032D12 RID: 208146 RVA: 0x006DAC6C File Offset: 0x006D8E6C
		public ISetNpcSupportedWalkingPerformT AsISetNpcSupportedWalkingPerform()
		{
			return this.As<ISetNpcSupportedWalkingPerformT>();
		}

		// Token: 0x06032D13 RID: 208147 RVA: 0x006DAC74 File Offset: 0x006D8E74
		public static ISetNpcGroupPerformType_UnionUnion FromISetNpcSupportedWalkingPerform(ISetNpcSupportedWalkingPerformT _isetnpcsupportedwalkingperform)
		{
			return new ISetNpcGroupPerformType_UnionUnion
			{
				Type = ISetNpcGroupPerformType_Union.ISetNpcSupportedWalkingPerform,
				Value = _isetnpcsupportedwalkingperform
			};
		}

		// Token: 0x06032D14 RID: 208148 RVA: 0x006DAC8C File Offset: 0x006D8E8C
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
			default:
				return 0;
			}
		}
	}
}
