using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500A RID: 20490
	public class IConnectorLogicType_UnionUnion
	{
		// Token: 0x1700947D RID: 38013
		// (get) Token: 0x06020C51 RID: 134225 RVA: 0x0048E764 File Offset: 0x0048C964
		// (set) Token: 0x06020C52 RID: 134226 RVA: 0x0048E76C File Offset: 0x0048C96C
		public IConnectorLogicType_Union Type { get; set; }

		// Token: 0x1700947E RID: 38014
		// (get) Token: 0x06020C53 RID: 134227 RVA: 0x0048E775 File Offset: 0x0048C975
		// (set) Token: 0x06020C54 RID: 134228 RVA: 0x0048E77D File Offset: 0x0048C97D
		public object Value { get; set; }

		// Token: 0x06020C55 RID: 134229 RVA: 0x0048E786 File Offset: 0x0048C986
		public IConnectorLogicType_UnionUnion()
		{
			this.Type = IConnectorLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020C56 RID: 134230 RVA: 0x0048E79C File Offset: 0x0048C99C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020C57 RID: 134231 RVA: 0x0048E7AE File Offset: 0x0048C9AE
		public IConnectorLogicTypeT AsIConnectorLogicType()
		{
			return this.As<IConnectorLogicTypeT>();
		}

		// Token: 0x06020C58 RID: 134232 RVA: 0x0048E7B6 File Offset: 0x0048C9B6
		public static IConnectorLogicType_UnionUnion FromIConnectorLogicType(IConnectorLogicTypeT _iconnectorlogictype)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorLogicType,
				Value = _iconnectorlogictype
			};
		}

		// Token: 0x06020C59 RID: 134233 RVA: 0x0048E7CB File Offset: 0x0048C9CB
		public IConnectorRangeT AsIConnectorRange()
		{
			return this.As<IConnectorRangeT>();
		}

		// Token: 0x06020C5A RID: 134234 RVA: 0x0048E7D3 File Offset: 0x0048C9D3
		public static IConnectorLogicType_UnionUnion FromIConnectorRange(IConnectorRangeT _iconnectorrange)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorRange,
				Value = _iconnectorrange
			};
		}

		// Token: 0x06020C5B RID: 134235 RVA: 0x0048E7E8 File Offset: 0x0048C9E8
		public IConnectorPointToPointPathAdvanceT AsIConnectorPointToPointPathAdvance()
		{
			return this.As<IConnectorPointToPointPathAdvanceT>();
		}

		// Token: 0x06020C5C RID: 134236 RVA: 0x0048E7F0 File Offset: 0x0048C9F0
		public static IConnectorLogicType_UnionUnion FromIConnectorPointToPointPathAdvance(IConnectorPointToPointPathAdvanceT _iconnectorpointtopointpathadvance)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorPointToPointPathAdvance,
				Value = _iconnectorpointtopointpathadvance
			};
		}

		// Token: 0x06020C5D RID: 134237 RVA: 0x0048E808 File Offset: 0x0048CA08
		public static int Pack(FlatBufferBuilder builder, IConnectorLogicType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IConnectorLogicType_Union.IConnectorLogicType:
				return IConnectorLogicType.Pack(builder, _o.AsIConnectorLogicType()).Value;
			case IConnectorLogicType_Union.IConnectorRange:
				return IConnectorRange.Pack(builder, _o.AsIConnectorRange()).Value;
			case IConnectorLogicType_Union.IConnectorPointToPointPathAdvance:
				return IConnectorPointToPointPathAdvance.Pack(builder, _o.AsIConnectorPointToPointPathAdvance()).Value;
			default:
				return 0;
			}
		}
	}
}
