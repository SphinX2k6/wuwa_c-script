using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E3B RID: 32315
	public class TActorFaceExpressionUnion
	{
		// Token: 0x1700F1EF RID: 61935
		// (get) Token: 0x0603A647 RID: 239175 RVA: 0x007DD266 File Offset: 0x007DB466
		// (set) Token: 0x0603A648 RID: 239176 RVA: 0x007DD26E File Offset: 0x007DB46E
		public TActorFaceExpression Type { get; set; }

		// Token: 0x1700F1F0 RID: 61936
		// (get) Token: 0x0603A649 RID: 239177 RVA: 0x007DD277 File Offset: 0x007DB477
		// (set) Token: 0x0603A64A RID: 239178 RVA: 0x007DD27F File Offset: 0x007DB47F
		public object Value { get; set; }

		// Token: 0x0603A64B RID: 239179 RVA: 0x007DD288 File Offset: 0x007DB488
		public TActorFaceExpressionUnion()
		{
			this.Type = TActorFaceExpression.NONE;
			this.Value = null;
		}

		// Token: 0x0603A64C RID: 239180 RVA: 0x007DD29E File Offset: 0x007DB49E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A64D RID: 239181 RVA: 0x007DD2B0 File Offset: 0x007DB4B0
		public IActorFaceExpressionPlayT AsIActorFaceExpressionPlay()
		{
			return this.As<IActorFaceExpressionPlayT>();
		}

		// Token: 0x0603A64E RID: 239182 RVA: 0x007DD2B8 File Offset: 0x007DB4B8
		public static TActorFaceExpressionUnion FromIActorFaceExpressionPlay(IActorFaceExpressionPlayT _iactorfaceexpressionplay)
		{
			return new TActorFaceExpressionUnion
			{
				Type = TActorFaceExpression.IActorFaceExpressionPlay,
				Value = _iactorfaceexpressionplay
			};
		}

		// Token: 0x0603A64F RID: 239183 RVA: 0x007DD2CD File Offset: 0x007DB4CD
		public IActorFaceExpressionStopT AsIActorFaceExpressionStop()
		{
			return this.As<IActorFaceExpressionStopT>();
		}

		// Token: 0x0603A650 RID: 239184 RVA: 0x007DD2D5 File Offset: 0x007DB4D5
		public static TActorFaceExpressionUnion FromIActorFaceExpressionStop(IActorFaceExpressionStopT _iactorfaceexpressionstop)
		{
			return new TActorFaceExpressionUnion
			{
				Type = TActorFaceExpression.IActorFaceExpressionStop,
				Value = _iactorfaceexpressionstop
			};
		}

		// Token: 0x0603A651 RID: 239185 RVA: 0x007DD2EC File Offset: 0x007DB4EC
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
