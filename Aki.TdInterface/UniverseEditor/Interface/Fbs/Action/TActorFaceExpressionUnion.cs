using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762D RID: 30253
	public class TActorFaceExpressionUnion
	{
		// Token: 0x1700E5B1 RID: 58801
		// (get) Token: 0x060371A2 RID: 225698 RVA: 0x0077916A File Offset: 0x0077736A
		// (set) Token: 0x060371A3 RID: 225699 RVA: 0x00779172 File Offset: 0x00777372
		public TActorFaceExpression Type { get; set; }

		// Token: 0x1700E5B2 RID: 58802
		// (get) Token: 0x060371A4 RID: 225700 RVA: 0x0077917B File Offset: 0x0077737B
		// (set) Token: 0x060371A5 RID: 225701 RVA: 0x00779183 File Offset: 0x00777383
		public object Value { get; set; }

		// Token: 0x060371A6 RID: 225702 RVA: 0x0077918C File Offset: 0x0077738C
		public TActorFaceExpressionUnion()
		{
			this.Type = TActorFaceExpression.NONE;
			this.Value = null;
		}

		// Token: 0x060371A7 RID: 225703 RVA: 0x007791A2 File Offset: 0x007773A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371A8 RID: 225704 RVA: 0x007791B4 File Offset: 0x007773B4
		public IActorFaceExpressionPlayT AsIActorFaceExpressionPlay()
		{
			return this.As<IActorFaceExpressionPlayT>();
		}

		// Token: 0x060371A9 RID: 225705 RVA: 0x007791BC File Offset: 0x007773BC
		public static TActorFaceExpressionUnion FromIActorFaceExpressionPlay(IActorFaceExpressionPlayT _iactorfaceexpressionplay)
		{
			return new TActorFaceExpressionUnion
			{
				Type = TActorFaceExpression.IActorFaceExpressionPlay,
				Value = _iactorfaceexpressionplay
			};
		}

		// Token: 0x060371AA RID: 225706 RVA: 0x007791D1 File Offset: 0x007773D1
		public IActorFaceExpressionStopT AsIActorFaceExpressionStop()
		{
			return this.As<IActorFaceExpressionStopT>();
		}

		// Token: 0x060371AB RID: 225707 RVA: 0x007791D9 File Offset: 0x007773D9
		public static TActorFaceExpressionUnion FromIActorFaceExpressionStop(IActorFaceExpressionStopT _iactorfaceexpressionstop)
		{
			return new TActorFaceExpressionUnion
			{
				Type = TActorFaceExpression.IActorFaceExpressionStop,
				Value = _iactorfaceexpressionstop
			};
		}

		// Token: 0x060371AC RID: 225708 RVA: 0x007791F0 File Offset: 0x007773F0
		public static int Pack(FlatBufferBuilder builder, TActorFaceExpressionUnion _o)
		{
			TActorFaceExpression type = _o.Type;
			if (type == TActorFaceExpression.IActorFaceExpressionPlay)
			{
				return IActorFaceExpressionPlay.Pack(builder, _o.AsIActorFaceExpressionPlay()).Value;
			}
			if (type != TActorFaceExpression.IActorFaceExpressionStop)
			{
				return 0;
			}
			return IActorFaceExpressionStop.Pack(builder, _o.AsIActorFaceExpressionStop()).Value;
		}
	}
}
