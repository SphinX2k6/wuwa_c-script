using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008022 RID: 32802
	public class TToggleScanSplineEffectUnion
	{
		// Token: 0x1700F339 RID: 62265
		// (get) Token: 0x0603B047 RID: 241735 RVA: 0x007EC8E6 File Offset: 0x007EAAE6
		// (set) Token: 0x0603B048 RID: 241736 RVA: 0x007EC8EE File Offset: 0x007EAAEE
		public TToggleScanSplineEffect Type { get; set; }

		// Token: 0x1700F33A RID: 62266
		// (get) Token: 0x0603B049 RID: 241737 RVA: 0x007EC8F7 File Offset: 0x007EAAF7
		// (set) Token: 0x0603B04A RID: 241738 RVA: 0x007EC8FF File Offset: 0x007EAAFF
		public object Value { get; set; }

		// Token: 0x0603B04B RID: 241739 RVA: 0x007EC908 File Offset: 0x007EAB08
		public TToggleScanSplineEffectUnion()
		{
			this.Type = TToggleScanSplineEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603B04C RID: 241740 RVA: 0x007EC91E File Offset: 0x007EAB1E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B04D RID: 241741 RVA: 0x007EC930 File Offset: 0x007EAB30
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x0603B04E RID: 241742 RVA: 0x007EC938 File Offset: 0x007EAB38
		public static TToggleScanSplineEffectUnion FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new TToggleScanSplineEffectUnion
			{
				Type = TToggleScanSplineEffect.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x0603B04F RID: 241743 RVA: 0x007EC94D File Offset: 0x007EAB4D
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x0603B050 RID: 241744 RVA: 0x007EC955 File Offset: 0x007EAB55
		public static TToggleScanSplineEffectUnion FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new TToggleScanSplineEffectUnion
			{
				Type = TToggleScanSplineEffect.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x0603B051 RID: 241745 RVA: 0x007EC96C File Offset: 0x007EAB6C
		public static int Pack(FlatBufferBuilder builder, TToggleScanSplineEffectUnion _o)
		{
			TToggleScanSplineEffect type = _o.Type;
			if (type == TToggleScanSplineEffect.ICloseTraceSpline)
			{
				return ICloseTraceSpline.Pack(builder, _o.AsICloseTraceSpline()).Value;
			}
			if (type != TToggleScanSplineEffect.IOpenTraceSpline)
			{
				return 0;
			}
			return IOpenTraceSpline.Pack(builder, _o.AsIOpenTraceSpline()).Value;
		}
	}
}
