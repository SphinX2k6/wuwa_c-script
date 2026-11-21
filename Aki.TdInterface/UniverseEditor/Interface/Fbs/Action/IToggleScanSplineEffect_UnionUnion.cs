using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C0C RID: 31756
	public class IToggleScanSplineEffect_UnionUnion
	{
		// Token: 0x1700EDCB RID: 60875
		// (get) Token: 0x060393B8 RID: 234424 RVA: 0x007BB1E9 File Offset: 0x007B93E9
		// (set) Token: 0x060393B9 RID: 234425 RVA: 0x007BB1F1 File Offset: 0x007B93F1
		public IToggleScanSplineEffect_Union Type { get; set; }

		// Token: 0x1700EDCC RID: 60876
		// (get) Token: 0x060393BA RID: 234426 RVA: 0x007BB1FA File Offset: 0x007B93FA
		// (set) Token: 0x060393BB RID: 234427 RVA: 0x007BB202 File Offset: 0x007B9402
		public object Value { get; set; }

		// Token: 0x060393BC RID: 234428 RVA: 0x007BB20B File Offset: 0x007B940B
		public IToggleScanSplineEffect_UnionUnion()
		{
			this.Type = IToggleScanSplineEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060393BD RID: 234429 RVA: 0x007BB221 File Offset: 0x007B9421
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060393BE RID: 234430 RVA: 0x007BB233 File Offset: 0x007B9433
		public IToggleScanSplineEffectT AsIToggleScanSplineEffect()
		{
			return this.As<IToggleScanSplineEffectT>();
		}

		// Token: 0x060393BF RID: 234431 RVA: 0x007BB23B File Offset: 0x007B943B
		public static IToggleScanSplineEffect_UnionUnion FromIToggleScanSplineEffect(IToggleScanSplineEffectT _itogglescansplineeffect)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.IToggleScanSplineEffect,
				Value = _itogglescansplineeffect
			};
		}

		// Token: 0x060393C0 RID: 234432 RVA: 0x007BB250 File Offset: 0x007B9450
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x060393C1 RID: 234433 RVA: 0x007BB258 File Offset: 0x007B9458
		public static IToggleScanSplineEffect_UnionUnion FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x060393C2 RID: 234434 RVA: 0x007BB26D File Offset: 0x007B946D
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x060393C3 RID: 234435 RVA: 0x007BB275 File Offset: 0x007B9475
		public static IToggleScanSplineEffect_UnionUnion FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new IToggleScanSplineEffect_UnionUnion
			{
				Type = IToggleScanSplineEffect_Union.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x060393C4 RID: 234436 RVA: 0x007BB28C File Offset: 0x007B948C
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
