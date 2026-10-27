using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779C RID: 30620
	public class TSplineMoveModelUnion
	{
		// Token: 0x1700E6AB RID: 59051
		// (get) Token: 0x06037936 RID: 227638 RVA: 0x00784D5E File Offset: 0x00782F5E
		// (set) Token: 0x06037937 RID: 227639 RVA: 0x00784D66 File Offset: 0x00782F66
		public TSplineMoveModel Type { get; set; }

		// Token: 0x1700E6AC RID: 59052
		// (get) Token: 0x06037938 RID: 227640 RVA: 0x00784D6F File Offset: 0x00782F6F
		// (set) Token: 0x06037939 RID: 227641 RVA: 0x00784D77 File Offset: 0x00782F77
		public object Value { get; set; }

		// Token: 0x0603793A RID: 227642 RVA: 0x00784D80 File Offset: 0x00782F80
		public TSplineMoveModelUnion()
		{
			this.Type = TSplineMoveModel.NONE;
			this.Value = null;
		}

		// Token: 0x0603793B RID: 227643 RVA: 0x00784D96 File Offset: 0x00782F96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603793C RID: 227644 RVA: 0x00784DA8 File Offset: 0x00782FA8
		public ICloseSplineMoveT AsICloseSplineMove()
		{
			return this.As<ICloseSplineMoveT>();
		}

		// Token: 0x0603793D RID: 227645 RVA: 0x00784DB0 File Offset: 0x00782FB0
		public static TSplineMoveModelUnion FromICloseSplineMove(ICloseSplineMoveT _iclosesplinemove)
		{
			return new TSplineMoveModelUnion
			{
				Type = TSplineMoveModel.ICloseSplineMove,
				Value = _iclosesplinemove
			};
		}

		// Token: 0x0603793E RID: 227646 RVA: 0x00784DC5 File Offset: 0x00782FC5
		public IOpenSplineMoveT AsIOpenSplineMove()
		{
			return this.As<IOpenSplineMoveT>();
		}

		// Token: 0x0603793F RID: 227647 RVA: 0x00784DCD File Offset: 0x00782FCD
		public static TSplineMoveModelUnion FromIOpenSplineMove(IOpenSplineMoveT _iopensplinemove)
		{
			return new TSplineMoveModelUnion
			{
				Type = TSplineMoveModel.IOpenSplineMove,
				Value = _iopensplinemove
			};
		}

		// Token: 0x06037940 RID: 227648 RVA: 0x00784DE4 File Offset: 0x00782FE4
		public static int Pack(FlatBufferBuilder builder, TSplineMoveModelUnion _o)
		{
			TSplineMoveModel type = _o.Type;
			if (type == TSplineMoveModel.ICloseSplineMove)
			{
				return ICloseSplineMove.Pack(builder, _o.AsICloseSplineMove()).Value;
			}
			if (type != TSplineMoveModel.IOpenSplineMove)
			{
				return 0;
			}
			return IOpenSplineMove.Pack(builder, _o.AsIOpenSplineMove()).Value;
		}
	}
}
