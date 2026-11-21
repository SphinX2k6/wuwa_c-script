using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007951 RID: 31057
	public class ISplineMoveConfig_UnionUnion
	{
		// Token: 0x1700E3CA RID: 58314
		// (get) Token: 0x06036B20 RID: 224032 RVA: 0x007518E0 File Offset: 0x0074FAE0
		// (set) Token: 0x06036B21 RID: 224033 RVA: 0x007518E8 File Offset: 0x0074FAE8
		public ISplineMoveConfig_Union Type { get; set; }

		// Token: 0x1700E3CB RID: 58315
		// (get) Token: 0x06036B22 RID: 224034 RVA: 0x007518F1 File Offset: 0x0074FAF1
		// (set) Token: 0x06036B23 RID: 224035 RVA: 0x007518F9 File Offset: 0x0074FAF9
		public object Value { get; set; }

		// Token: 0x06036B24 RID: 224036 RVA: 0x00751902 File Offset: 0x0074FB02
		public ISplineMoveConfig_UnionUnion()
		{
			this.Type = ISplineMoveConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036B25 RID: 224037 RVA: 0x00751918 File Offset: 0x0074FB18
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036B26 RID: 224038 RVA: 0x0075192A File Offset: 0x0074FB2A
		public ISplineMoveConfigT AsISplineMoveConfig()
		{
			return this.As<ISplineMoveConfigT>();
		}

		// Token: 0x06036B27 RID: 224039 RVA: 0x00751932 File Offset: 0x0074FB32
		public static ISplineMoveConfig_UnionUnion FromISplineMoveConfig(ISplineMoveConfigT _isplinemoveconfig)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.ISplineMoveConfig,
				Value = _isplinemoveconfig
			};
		}

		// Token: 0x06036B28 RID: 224040 RVA: 0x00751947 File Offset: 0x0074FB47
		public IOpenSplineMoveT AsIOpenSplineMove()
		{
			return this.As<IOpenSplineMoveT>();
		}

		// Token: 0x06036B29 RID: 224041 RVA: 0x0075194F File Offset: 0x0074FB4F
		public static ISplineMoveConfig_UnionUnion FromIOpenSplineMove(IOpenSplineMoveT _iopensplinemove)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.IOpenSplineMove,
				Value = _iopensplinemove
			};
		}

		// Token: 0x06036B2A RID: 224042 RVA: 0x00751964 File Offset: 0x0074FB64
		public ICloseSplineMoveT AsICloseSplineMove()
		{
			return this.As<ICloseSplineMoveT>();
		}

		// Token: 0x06036B2B RID: 224043 RVA: 0x0075196C File Offset: 0x0074FB6C
		public static ISplineMoveConfig_UnionUnion FromICloseSplineMove(ICloseSplineMoveT _iclosesplinemove)
		{
			return new ISplineMoveConfig_UnionUnion
			{
				Type = ISplineMoveConfig_Union.ICloseSplineMove,
				Value = _iclosesplinemove
			};
		}

		// Token: 0x06036B2C RID: 224044 RVA: 0x00751984 File Offset: 0x0074FB84
		public static int Pack(FlatBufferBuilder builder, ISplineMoveConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMoveConfig_Union.ISplineMoveConfig:
				return ISplineMoveConfig.Pack(builder, _o.AsISplineMoveConfig()).Value;
			case ISplineMoveConfig_Union.IOpenSplineMove:
				return IOpenSplineMove.Pack(builder, _o.AsIOpenSplineMove()).Value;
			case ISplineMoveConfig_Union.ICloseSplineMove:
				return ICloseSplineMove.Pack(builder, _o.AsICloseSplineMove()).Value;
			default:
				return 0;
			}
		}
	}
}
