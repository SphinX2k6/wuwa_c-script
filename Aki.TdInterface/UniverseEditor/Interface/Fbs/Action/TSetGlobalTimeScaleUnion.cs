using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007781 RID: 30593
	public class TSetGlobalTimeScaleUnion
	{
		// Token: 0x1700E699 RID: 59033
		// (get) Token: 0x060378BE RID: 227518 RVA: 0x007842C6 File Offset: 0x007824C6
		// (set) Token: 0x060378BF RID: 227519 RVA: 0x007842CE File Offset: 0x007824CE
		public TSetGlobalTimeScale Type { get; set; }

		// Token: 0x1700E69A RID: 59034
		// (get) Token: 0x060378C0 RID: 227520 RVA: 0x007842D7 File Offset: 0x007824D7
		// (set) Token: 0x060378C1 RID: 227521 RVA: 0x007842DF File Offset: 0x007824DF
		public object Value { get; set; }

		// Token: 0x060378C2 RID: 227522 RVA: 0x007842E8 File Offset: 0x007824E8
		public TSetGlobalTimeScaleUnion()
		{
			this.Type = TSetGlobalTimeScale.NONE;
			this.Value = null;
		}

		// Token: 0x060378C3 RID: 227523 RVA: 0x007842FE File Offset: 0x007824FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378C4 RID: 227524 RVA: 0x00784310 File Offset: 0x00782510
		public ICloseGlobalTimeScaleT AsICloseGlobalTimeScale()
		{
			return this.As<ICloseGlobalTimeScaleT>();
		}

		// Token: 0x060378C5 RID: 227525 RVA: 0x00784318 File Offset: 0x00782518
		public static TSetGlobalTimeScaleUnion FromICloseGlobalTimeScale(ICloseGlobalTimeScaleT _icloseglobaltimescale)
		{
			return new TSetGlobalTimeScaleUnion
			{
				Type = TSetGlobalTimeScale.ICloseGlobalTimeScale,
				Value = _icloseglobaltimescale
			};
		}

		// Token: 0x060378C6 RID: 227526 RVA: 0x0078432D File Offset: 0x0078252D
		public IOpenGlobalTimeScaleT AsIOpenGlobalTimeScale()
		{
			return this.As<IOpenGlobalTimeScaleT>();
		}

		// Token: 0x060378C7 RID: 227527 RVA: 0x00784335 File Offset: 0x00782535
		public static TSetGlobalTimeScaleUnion FromIOpenGlobalTimeScale(IOpenGlobalTimeScaleT _iopenglobaltimescale)
		{
			return new TSetGlobalTimeScaleUnion
			{
				Type = TSetGlobalTimeScale.IOpenGlobalTimeScale,
				Value = _iopenglobaltimescale
			};
		}

		// Token: 0x060378C8 RID: 227528 RVA: 0x0078434C File Offset: 0x0078254C
		public static int Pack(FlatBufferBuilder builder, TSetGlobalTimeScaleUnion _o)
		{
			TSetGlobalTimeScale type = _o.Type;
			if (type == TSetGlobalTimeScale.ICloseGlobalTimeScale)
			{
				return ICloseGlobalTimeScale.Pack(builder, _o.AsICloseGlobalTimeScale()).Value;
			}
			if (type != TSetGlobalTimeScale.IOpenGlobalTimeScale)
			{
				return 0;
			}
			return IOpenGlobalTimeScale.Pack(builder, _o.AsIOpenGlobalTimeScale()).Value;
		}
	}
}
