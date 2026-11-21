using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD4 RID: 32724
	public class TSplineMoveModelUnion
	{
		// Token: 0x1700F305 RID: 62213
		// (get) Token: 0x0603AEB1 RID: 241329 RVA: 0x007EA25E File Offset: 0x007E845E
		// (set) Token: 0x0603AEB2 RID: 241330 RVA: 0x007EA266 File Offset: 0x007E8466
		public TSplineMoveModel Type { get; set; }

		// Token: 0x1700F306 RID: 62214
		// (get) Token: 0x0603AEB3 RID: 241331 RVA: 0x007EA26F File Offset: 0x007E846F
		// (set) Token: 0x0603AEB4 RID: 241332 RVA: 0x007EA277 File Offset: 0x007E8477
		public object Value { get; set; }

		// Token: 0x0603AEB5 RID: 241333 RVA: 0x007EA280 File Offset: 0x007E8480
		public TSplineMoveModelUnion()
		{
			this.Type = TSplineMoveModel.NONE;
			this.Value = null;
		}

		// Token: 0x0603AEB6 RID: 241334 RVA: 0x007EA296 File Offset: 0x007E8496
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AEB7 RID: 241335 RVA: 0x007EA2A8 File Offset: 0x007E84A8
		public ICloseSplineMoveT AsICloseSplineMove()
		{
			return this.As<ICloseSplineMoveT>();
		}

		// Token: 0x0603AEB8 RID: 241336 RVA: 0x007EA2B0 File Offset: 0x007E84B0
		public static TSplineMoveModelUnion FromICloseSplineMove(ICloseSplineMoveT _iclosesplinemove)
		{
			return new TSplineMoveModelUnion
			{
				Type = TSplineMoveModel.ICloseSplineMove,
				Value = _iclosesplinemove
			};
		}

		// Token: 0x0603AEB9 RID: 241337 RVA: 0x007EA2C5 File Offset: 0x007E84C5
		public IOpenSplineMoveT AsIOpenSplineMove()
		{
			return this.As<IOpenSplineMoveT>();
		}

		// Token: 0x0603AEBA RID: 241338 RVA: 0x007EA2CD File Offset: 0x007E84CD
		public static TSplineMoveModelUnion FromIOpenSplineMove(IOpenSplineMoveT _iopensplinemove)
		{
			return new TSplineMoveModelUnion
			{
				Type = TSplineMoveModel.IOpenSplineMove,
				Value = _iopensplinemove
			};
		}

		// Token: 0x0603AEBB RID: 241339 RVA: 0x007EA2E4 File Offset: 0x007E84E4
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
