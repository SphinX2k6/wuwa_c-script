using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007419 RID: 29721
	public class IToggleScanSplineEffect_UnionUnion
	{
		// Token: 0x1700E1AE RID: 57774
		// (get) Token: 0x06035FCF RID: 221135 RVA: 0x007584BD File Offset: 0x007566BD
		// (set) Token: 0x06035FD0 RID: 221136 RVA: 0x007584C5 File Offset: 0x007566C5
		public IToggleScanSplineEffect_Union Type { get; set; }

		// Token: 0x1700E1AF RID: 57775
		// (get) Token: 0x06035FD1 RID: 221137 RVA: 0x007584CE File Offset: 0x007566CE
		// (set) Token: 0x06035FD2 RID: 221138 RVA: 0x007584D6 File Offset: 0x007566D6
		public object Value { get; set; }

		// Token: 0x06035FD3 RID: 221139 RVA: 0x007584DF File Offset: 0x007566DF
		public IToggleScanSplineEffect_UnionUnion()
		{
			this.Type = IToggleScanSplineEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035FD4 RID: 221140 RVA: 0x007584F5 File Offset: 0x007566F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035FD5 RID: 221141 RVA: 0x00758507 File Offset: 0x00756707
		public IToggleScanSplineEffectT AsIToggleScanSplineEffect()
		{
			return this.As<IToggleScanSplineEffectT>();
		}

		// Token: 0x06035FD6 RID: 221142 RVA: 0x0075850F File Offset: 0x0075670F
		public static IToggleScanSplineEffect_UnionUnion FromIToggleScanSplineEffect(IToggleScanSplineEffectT _itogglescansplineeffect)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.IToggleScanSplineEffect,
				Value = _itogglescansplineeffect
			};
		}

		// Token: 0x06035FD7 RID: 221143 RVA: 0x00758524 File Offset: 0x00756724
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x06035FD8 RID: 221144 RVA: 0x0075852C File Offset: 0x0075672C
		public static IToggleScanSplineEffect_UnionUnion FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x06035FD9 RID: 221145 RVA: 0x00758541 File Offset: 0x00756741
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x06035FDA RID: 221146 RVA: 0x00758549 File Offset: 0x00756749
		public static IToggleScanSplineEffect_UnionUnion FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x06035FDB RID: 221147 RVA: 0x00758560 File Offset: 0x00756760
		public static int Pack(FlatBufferBuilder builder, IToggleScanSplineEffect_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleScanSplineEffect_Union.IToggleScanSplineEffect:
				return IToggleScanSplineEffect.Pack(builder, _o.AsIToggleScanSplineEffect()).Value;
			case IToggleScanSplineEffect_Union.IOpenTraceSpline:
				return IOpenTraceSpline.Pack(builder, _o.AsIOpenTraceSpline()).Value;
			case IToggleScanSplineEffect_Union.ICloseTraceSpline:
				return ICloseTraceSpline.Pack(builder, _o.AsICloseTraceSpline()).Value;
			default:
				return 0;
			}
		}
	}
}
