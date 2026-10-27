using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ACD RID: 15053
	public class IScoreDisplayParams_UnionUnion
	{
		// Token: 0x17006743 RID: 26435
		// (get) Token: 0x0601479D RID: 83869 RVA: 0x002FBB30 File Offset: 0x002F9D30
		// (set) Token: 0x0601479E RID: 83870 RVA: 0x002FBB38 File Offset: 0x002F9D38
		public IScoreDisplayParams_Union Type { get; set; }

		// Token: 0x17006744 RID: 26436
		// (get) Token: 0x0601479F RID: 83871 RVA: 0x002FBB41 File Offset: 0x002F9D41
		// (set) Token: 0x060147A0 RID: 83872 RVA: 0x002FBB49 File Offset: 0x002F9D49
		public object Value { get; set; }

		// Token: 0x060147A1 RID: 83873 RVA: 0x002FBB52 File Offset: 0x002F9D52
		public IScoreDisplayParams_UnionUnion()
		{
			this.Type = IScoreDisplayParams_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060147A2 RID: 83874 RVA: 0x002FBB68 File Offset: 0x002F9D68
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060147A3 RID: 83875 RVA: 0x002FBB7A File Offset: 0x002F9D7A
		public IScoreDisplayParamsT AsIScoreDisplayParams()
		{
			return this.As<IScoreDisplayParamsT>();
		}

		// Token: 0x060147A4 RID: 83876 RVA: 0x002FBB82 File Offset: 0x002F9D82
		public static IScoreDisplayParams_UnionUnion FromIScoreDisplayParams(IScoreDisplayParamsT _iscoredisplayparams)
		{
			return new IScoreDisplayParams_UnionUnion
			{
				Type = IScoreDisplayParams_Union.IScoreDisplayParams,
				Value = _iscoredisplayparams
			};
		}

		// Token: 0x060147A5 RID: 83877 RVA: 0x002FBB97 File Offset: 0x002F9D97
		public IScoreDisplayParamsVarT AsIScoreDisplayParamsVar()
		{
			return this.As<IScoreDisplayParamsVarT>();
		}

		// Token: 0x060147A6 RID: 83878 RVA: 0x002FBB9F File Offset: 0x002F9D9F
		public static IScoreDisplayParams_UnionUnion FromIScoreDisplayParamsVar(IScoreDisplayParamsVarT _iscoredisplayparamsvar)
		{
			return new IScoreDisplayParams_UnionUnion
			{
				Type = IScoreDisplayParams_Union.IScoreDisplayParamsVar,
				Value = _iscoredisplayparamsvar
			};
		}

		// Token: 0x060147A7 RID: 83879 RVA: 0x002FBBB4 File Offset: 0x002F9DB4
		public static int Pack(FlatBufferBuilder builder, IScoreDisplayParams_UnionUnion _o)
		{
			IScoreDisplayParams_Union type = _o.Type;
			if (type == IScoreDisplayParams_Union.IScoreDisplayParams)
			{
				return IScoreDisplayParams.Pack(builder, _o.AsIScoreDisplayParams()).Value;
			}
			if (type != IScoreDisplayParams_Union.IScoreDisplayParamsVar)
			{
				return 0;
			}
			return IScoreDisplayParamsVar.Pack(builder, _o.AsIScoreDisplayParamsVar()).Value;
		}
	}
}
