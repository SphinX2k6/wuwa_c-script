using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005569 RID: 21865
	public class IConnectorLogicType_UnionUnion
	{
		// Token: 0x17009C5E RID: 40030
		// (get) Token: 0x06022B71 RID: 142193 RVA: 0x004C81B4 File Offset: 0x004C63B4
		// (set) Token: 0x06022B72 RID: 142194 RVA: 0x004C81BC File Offset: 0x004C63BC
		public IConnectorLogicType_Union Type { get; set; }

		// Token: 0x17009C5F RID: 40031
		// (get) Token: 0x06022B73 RID: 142195 RVA: 0x004C81C5 File Offset: 0x004C63C5
		// (set) Token: 0x06022B74 RID: 142196 RVA: 0x004C81CD File Offset: 0x004C63CD
		public object Value { get; set; }

		// Token: 0x06022B75 RID: 142197 RVA: 0x004C81D6 File Offset: 0x004C63D6
		public IConnectorLogicType_UnionUnion()
		{
			this.Type = IConnectorLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022B76 RID: 142198 RVA: 0x004C81EC File Offset: 0x004C63EC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022B77 RID: 142199 RVA: 0x004C81FE File Offset: 0x004C63FE
		public IConnectorLogicTypeT AsIConnectorLogicType()
		{
			return this.As<IConnectorLogicTypeT>();
		}

		// Token: 0x06022B78 RID: 142200 RVA: 0x004C8206 File Offset: 0x004C6406
		public static IConnectorLogicType_UnionUnion FromIConnectorLogicType(IConnectorLogicTypeT _iconnectorlogictype)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorLogicType,
				Value = _iconnectorlogictype
			};
		}

		// Token: 0x06022B79 RID: 142201 RVA: 0x004C821B File Offset: 0x004C641B
		public IConnectorRangeT AsIConnectorRange()
		{
			return this.As<IConnectorRangeT>();
		}

		// Token: 0x06022B7A RID: 142202 RVA: 0x004C8223 File Offset: 0x004C6423
		public static IConnectorLogicType_UnionUnion FromIConnectorRange(IConnectorRangeT _iconnectorrange)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorRange,
				Value = _iconnectorrange
			};
		}

		// Token: 0x06022B7B RID: 142203 RVA: 0x004C8238 File Offset: 0x004C6438
		public IConnectorPointToPointPathAdvanceT AsIConnectorPointToPointPathAdvance()
		{
			return this.As<IConnectorPointToPointPathAdvanceT>();
		}

		// Token: 0x06022B7C RID: 142204 RVA: 0x004C8240 File Offset: 0x004C6440
		public static IConnectorLogicType_UnionUnion FromIConnectorPointToPointPathAdvance(IConnectorPointToPointPathAdvanceT _iconnectorpointtopointpathadvance)
		{
			return new IConnectorLogicType_UnionUnion
			{
				Type = IConnectorLogicType_Union.IConnectorPointToPointPathAdvance,
				Value = _iconnectorpointtopointpathadvance
			};
		}

		// Token: 0x06022B7D RID: 142205 RVA: 0x004C8258 File Offset: 0x004C6458
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
