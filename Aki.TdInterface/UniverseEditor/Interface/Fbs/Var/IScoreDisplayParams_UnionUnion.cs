using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ECF RID: 16079
	public class IScoreDisplayParams_UnionUnion
	{
		// Token: 0x17006CDE RID: 27870
		// (get) Token: 0x06015C47 RID: 89159 RVA: 0x00321DC0 File Offset: 0x0031FFC0
		// (set) Token: 0x06015C48 RID: 89160 RVA: 0x00321DC8 File Offset: 0x0031FFC8
		public IScoreDisplayParams_Union Type { get; set; }

		// Token: 0x17006CDF RID: 27871
		// (get) Token: 0x06015C49 RID: 89161 RVA: 0x00321DD1 File Offset: 0x0031FFD1
		// (set) Token: 0x06015C4A RID: 89162 RVA: 0x00321DD9 File Offset: 0x0031FFD9
		public object Value { get; set; }

		// Token: 0x06015C4B RID: 89163 RVA: 0x00321DE2 File Offset: 0x0031FFE2
		public IScoreDisplayParams_UnionUnion()
		{
			this.Type = IScoreDisplayParams_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015C4C RID: 89164 RVA: 0x00321DF8 File Offset: 0x0031FFF8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015C4D RID: 89165 RVA: 0x00321E0A File Offset: 0x0032000A
		public IScoreDisplayParamsT AsIScoreDisplayParams()
		{
			return this.As<IScoreDisplayParamsT>();
		}

		// Token: 0x06015C4E RID: 89166 RVA: 0x00321E12 File Offset: 0x00320012
		public static IScoreDisplayParams_UnionUnion FromIScoreDisplayParams(IScoreDisplayParamsT _iscoredisplayparams)
		{
			return new IScoreDisplayParams_UnionUnion
			{
				Type = IScoreDisplayParams_Union.IScoreDisplayParams,
				Value = _iscoredisplayparams
			};
		}

		// Token: 0x06015C4F RID: 89167 RVA: 0x00321E27 File Offset: 0x00320027
		public IScoreDisplayParamsVarT AsIScoreDisplayParamsVar()
		{
			return this.As<IScoreDisplayParamsVarT>();
		}

		// Token: 0x06015C50 RID: 89168 RVA: 0x00321E2F File Offset: 0x0032002F
		public static IScoreDisplayParams_UnionUnion FromIScoreDisplayParamsVar(IScoreDisplayParamsVarT _iscoredisplayparamsvar)
		{
			return new IScoreDisplayParams_UnionUnion
			{
				Type = IScoreDisplayParams_Union.IScoreDisplayParamsVar,
				Value = _iscoredisplayparamsvar
			};
		}

		// Token: 0x06015C51 RID: 89169 RVA: 0x00321E44 File Offset: 0x00320044
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
