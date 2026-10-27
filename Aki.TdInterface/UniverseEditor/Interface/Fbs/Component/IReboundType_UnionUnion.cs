using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005812 RID: 22546
	public class IReboundType_UnionUnion
	{
		// Token: 0x1700A86B RID: 43115
		// (get) Token: 0x06025E77 RID: 155255 RVA: 0x0053A179 File Offset: 0x00538379
		// (set) Token: 0x06025E78 RID: 155256 RVA: 0x0053A181 File Offset: 0x00538381
		public IReboundType_Union Type { get; set; }

		// Token: 0x1700A86C RID: 43116
		// (get) Token: 0x06025E79 RID: 155257 RVA: 0x0053A18A File Offset: 0x0053838A
		// (set) Token: 0x06025E7A RID: 155258 RVA: 0x0053A192 File Offset: 0x00538392
		public object Value { get; set; }

		// Token: 0x06025E7B RID: 155259 RVA: 0x0053A19B File Offset: 0x0053839B
		public IReboundType_UnionUnion()
		{
			this.Type = IReboundType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025E7C RID: 155260 RVA: 0x0053A1B1 File Offset: 0x005383B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025E7D RID: 155261 RVA: 0x0053A1C3 File Offset: 0x005383C3
		public IReboundTypeT AsIReboundType()
		{
			return this.As<IReboundTypeT>();
		}

		// Token: 0x06025E7E RID: 155262 RVA: 0x0053A1CB File Offset: 0x005383CB
		public static IReboundType_UnionUnion FromIReboundType(IReboundTypeT _ireboundtype)
		{
			return new IReboundType_UnionUnion
			{
				Type = IReboundType_Union.IReboundType,
				Value = _ireboundtype
			};
		}

		// Token: 0x06025E7F RID: 155263 RVA: 0x0053A1E0 File Offset: 0x005383E0
		public IForwardFrontReboundT AsIForwardFrontRebound()
		{
			return this.As<IForwardFrontReboundT>();
		}

		// Token: 0x06025E80 RID: 155264 RVA: 0x0053A1E8 File Offset: 0x005383E8
		public static IReboundType_UnionUnion FromIForwardFrontRebound(IForwardFrontReboundT _iforwardfrontrebound)
		{
			return new IReboundType_UnionUnion
			{
				Type = IReboundType_Union.IForwardFrontRebound,
				Value = _iforwardfrontrebound
			};
		}

		// Token: 0x06025E81 RID: 155265 RVA: 0x0053A200 File Offset: 0x00538400
		public static int Pack(FlatBufferBuilder builder, IReboundType_UnionUnion _o)
		{
			IReboundType_Union type = _o.Type;
			if (type == IReboundType_Union.IReboundType)
			{
				return IReboundType.Pack(builder, _o.AsIReboundType()).Value;
			}
			if (type != IReboundType_Union.IForwardFrontRebound)
			{
				return 0;
			}
			return IForwardFrontRebound.Pack(builder, _o.AsIForwardFrontRebound()).Value;
		}
	}
}
