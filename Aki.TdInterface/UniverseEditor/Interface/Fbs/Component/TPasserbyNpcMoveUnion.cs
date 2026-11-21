using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A7 RID: 25255
	public class TPasserbyNpcMoveUnion
	{
		// Token: 0x1700BB86 RID: 48006
		// (get) Token: 0x0602AF33 RID: 175923 RVA: 0x005DC1F0 File Offset: 0x005DA3F0
		// (set) Token: 0x0602AF34 RID: 175924 RVA: 0x005DC1F8 File Offset: 0x005DA3F8
		public TPasserbyNpcMove Type { get; set; }

		// Token: 0x1700BB87 RID: 48007
		// (get) Token: 0x0602AF35 RID: 175925 RVA: 0x005DC201 File Offset: 0x005DA401
		// (set) Token: 0x0602AF36 RID: 175926 RVA: 0x005DC209 File Offset: 0x005DA409
		public object Value { get; set; }

		// Token: 0x0602AF37 RID: 175927 RVA: 0x005DC212 File Offset: 0x005DA412
		public TPasserbyNpcMoveUnion()
		{
			this.Type = TPasserbyNpcMove.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF38 RID: 175928 RVA: 0x005DC228 File Offset: 0x005DA428
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF39 RID: 175929 RVA: 0x005DC23A File Offset: 0x005DA43A
		public IPasserbyNpcLiftMoveT AsIPasserbyNpcLiftMove()
		{
			return this.As<IPasserbyNpcLiftMoveT>();
		}

		// Token: 0x0602AF3A RID: 175930 RVA: 0x005DC242 File Offset: 0x005DA442
		public static TPasserbyNpcMoveUnion FromIPasserbyNpcLiftMove(IPasserbyNpcLiftMoveT _ipasserbynpcliftmove)
		{
			return new TPasserbyNpcMoveUnion
			{
				Type = TPasserbyNpcMove.IPasserbyNpcLiftMove,
				Value = _ipasserbynpcliftmove
			};
		}

		// Token: 0x0602AF3B RID: 175931 RVA: 0x005DC257 File Offset: 0x005DA457
		public IPasserbyNpcSplineMoveT AsIPasserbyNpcSplineMove()
		{
			return this.As<IPasserbyNpcSplineMoveT>();
		}

		// Token: 0x0602AF3C RID: 175932 RVA: 0x005DC25F File Offset: 0x005DA45F
		public static TPasserbyNpcMoveUnion FromIPasserbyNpcSplineMove(IPasserbyNpcSplineMoveT _ipasserbynpcsplinemove)
		{
			return new TPasserbyNpcMoveUnion
			{
				Type = TPasserbyNpcMove.IPasserbyNpcSplineMove,
				Value = _ipasserbynpcsplinemove
			};
		}

		// Token: 0x0602AF3D RID: 175933 RVA: 0x005DC274 File Offset: 0x005DA474
		public static int Pack(FlatBufferBuilder builder, TPasserbyNpcMoveUnion _o)
		{
			TPasserbyNpcMove type = _o.Type;
			if (type == TPasserbyNpcMove.IPasserbyNpcLiftMove)
			{
				return IPasserbyNpcLiftMove.Pack(builder, _o.AsIPasserbyNpcLiftMove()).Value;
			}
			if (type != TPasserbyNpcMove.IPasserbyNpcSplineMove)
			{
				return 0;
			}
			return IPasserbyNpcSplineMove.Pack(builder, _o.AsIPasserbyNpcSplineMove()).Value;
		}
	}
}
