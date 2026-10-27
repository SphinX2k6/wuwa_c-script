using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E4 RID: 30692
	public class TToggleScanSplineEffectUnion
	{
		// Token: 0x1700E6DB RID: 59099
		// (get) Token: 0x06037AA8 RID: 228008 RVA: 0x0078703C File Offset: 0x0078523C
		// (set) Token: 0x06037AA9 RID: 228009 RVA: 0x00787044 File Offset: 0x00785244
		public TToggleScanSplineEffect Type { get; set; }

		// Token: 0x1700E6DC RID: 59100
		// (get) Token: 0x06037AAA RID: 228010 RVA: 0x0078704D File Offset: 0x0078524D
		// (set) Token: 0x06037AAB RID: 228011 RVA: 0x00787055 File Offset: 0x00785255
		public object Value { get; set; }

		// Token: 0x06037AAC RID: 228012 RVA: 0x0078705E File Offset: 0x0078525E
		public TToggleScanSplineEffectUnion()
		{
			this.Type = TToggleScanSplineEffect.NONE;
			this.Value = null;
		}

		// Token: 0x06037AAD RID: 228013 RVA: 0x00787074 File Offset: 0x00785274
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037AAE RID: 228014 RVA: 0x00787086 File Offset: 0x00785286
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x06037AAF RID: 228015 RVA: 0x0078708E File Offset: 0x0078528E
		public static TToggleScanSplineEffectUnion FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new TToggleScanSplineEffectUnion
			{
				Type = TToggleScanSplineEffect.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x06037AB0 RID: 228016 RVA: 0x007870A3 File Offset: 0x007852A3
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x06037AB1 RID: 228017 RVA: 0x007870AB File Offset: 0x007852AB
		public static TToggleScanSplineEffectUnion FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new TToggleScanSplineEffectUnion
			{
				Type = TToggleScanSplineEffect.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x06037AB2 RID: 228018 RVA: 0x007870C0 File Offset: 0x007852C0
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
