using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EFC RID: 16124
	public class ITimeDisplayParams_UnionUnion
	{
		// Token: 0x17006D22 RID: 27938
		// (get) Token: 0x06015DDD RID: 89565 RVA: 0x00324FF8 File Offset: 0x003231F8
		// (set) Token: 0x06015DDE RID: 89566 RVA: 0x00325000 File Offset: 0x00323200
		public ITimeDisplayParams_Union Type { get; set; }

		// Token: 0x17006D23 RID: 27939
		// (get) Token: 0x06015DDF RID: 89567 RVA: 0x00325009 File Offset: 0x00323209
		// (set) Token: 0x06015DE0 RID: 89568 RVA: 0x00325011 File Offset: 0x00323211
		public object Value { get; set; }

		// Token: 0x06015DE1 RID: 89569 RVA: 0x0032501A File Offset: 0x0032321A
		public ITimeDisplayParams_UnionUnion()
		{
			this.Type = ITimeDisplayParams_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015DE2 RID: 89570 RVA: 0x00325030 File Offset: 0x00323230
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015DE3 RID: 89571 RVA: 0x00325042 File Offset: 0x00323242
		public ITimeDisplayParamsT AsITimeDisplayParams()
		{
			return this.As<ITimeDisplayParamsT>();
		}

		// Token: 0x06015DE4 RID: 89572 RVA: 0x0032504A File Offset: 0x0032324A
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParams(ITimeDisplayParamsT _itimedisplayparams)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParams,
				Value = _itimedisplayparams
			};
		}

		// Token: 0x06015DE5 RID: 89573 RVA: 0x0032505F File Offset: 0x0032325F
		public ITimeDisplayParamsConstantT AsITimeDisplayParamsConstant()
		{
			return this.As<ITimeDisplayParamsConstantT>();
		}

		// Token: 0x06015DE6 RID: 89574 RVA: 0x00325067 File Offset: 0x00323267
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParamsConstant(ITimeDisplayParamsConstantT _itimedisplayparamsconstant)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParamsConstant,
				Value = _itimedisplayparamsconstant
			};
		}

		// Token: 0x06015DE7 RID: 89575 RVA: 0x0032507C File Offset: 0x0032327C
		public ITimeDisplayParamsVarT AsITimeDisplayParamsVar()
		{
			return this.As<ITimeDisplayParamsVarT>();
		}

		// Token: 0x06015DE8 RID: 89576 RVA: 0x00325084 File Offset: 0x00323284
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParamsVar(ITimeDisplayParamsVarT _itimedisplayparamsvar)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParamsVar,
				Value = _itimedisplayparamsvar
			};
		}

		// Token: 0x06015DE9 RID: 89577 RVA: 0x0032509C File Offset: 0x0032329C
		public static int Pack(FlatBufferBuilder builder, ITimeDisplayParams_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITimeDisplayParams_Union.ITimeDisplayParams:
				return ITimeDisplayParams.Pack(builder, _o.AsITimeDisplayParams()).Value;
			case ITimeDisplayParams_Union.ITimeDisplayParamsConstant:
				return ITimeDisplayParamsConstant.Pack(builder, _o.AsITimeDisplayParamsConstant()).Value;
			case ITimeDisplayParams_Union.ITimeDisplayParamsVar:
				return ITimeDisplayParamsVar.Pack(builder, _o.AsITimeDisplayParamsVar()).Value;
			default:
				return 0;
			}
		}
	}
}
