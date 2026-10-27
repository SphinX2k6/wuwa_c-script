using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFA RID: 15098
	public class ITimeDisplayParams_UnionUnion
	{
		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x06014933 RID: 84275 RVA: 0x002FED68 File Offset: 0x002FCF68
		// (set) Token: 0x06014934 RID: 84276 RVA: 0x002FED70 File Offset: 0x002FCF70
		public ITimeDisplayParams_Union Type { get; set; }

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x06014935 RID: 84277 RVA: 0x002FED79 File Offset: 0x002FCF79
		// (set) Token: 0x06014936 RID: 84278 RVA: 0x002FED81 File Offset: 0x002FCF81
		public object Value { get; set; }

		// Token: 0x06014937 RID: 84279 RVA: 0x002FED8A File Offset: 0x002FCF8A
		public ITimeDisplayParams_UnionUnion()
		{
			this.Type = ITimeDisplayParams_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014938 RID: 84280 RVA: 0x002FEDA0 File Offset: 0x002FCFA0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014939 RID: 84281 RVA: 0x002FEDB2 File Offset: 0x002FCFB2
		public ITimeDisplayParamsT AsITimeDisplayParams()
		{
			return this.As<ITimeDisplayParamsT>();
		}

		// Token: 0x0601493A RID: 84282 RVA: 0x002FEDBA File Offset: 0x002FCFBA
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParams(ITimeDisplayParamsT _itimedisplayparams)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParams,
				Value = _itimedisplayparams
			};
		}

		// Token: 0x0601493B RID: 84283 RVA: 0x002FEDCF File Offset: 0x002FCFCF
		public ITimeDisplayParamsConstantT AsITimeDisplayParamsConstant()
		{
			return this.As<ITimeDisplayParamsConstantT>();
		}

		// Token: 0x0601493C RID: 84284 RVA: 0x002FEDD7 File Offset: 0x002FCFD7
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParamsConstant(ITimeDisplayParamsConstantT _itimedisplayparamsconstant)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParamsConstant,
				Value = _itimedisplayparamsconstant
			};
		}

		// Token: 0x0601493D RID: 84285 RVA: 0x002FEDEC File Offset: 0x002FCFEC
		public ITimeDisplayParamsVarT AsITimeDisplayParamsVar()
		{
			return this.As<ITimeDisplayParamsVarT>();
		}

		// Token: 0x0601493E RID: 84286 RVA: 0x002FEDF4 File Offset: 0x002FCFF4
		public static ITimeDisplayParams_UnionUnion FromITimeDisplayParamsVar(ITimeDisplayParamsVarT _itimedisplayparamsvar)
		{
			return new ITimeDisplayParams_UnionUnion
			{
				Type = ITimeDisplayParams_Union.ITimeDisplayParamsVar,
				Value = _itimedisplayparamsvar
			};
		}

		// Token: 0x0601493F RID: 84287 RVA: 0x002FEE0C File Offset: 0x002FD00C
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
