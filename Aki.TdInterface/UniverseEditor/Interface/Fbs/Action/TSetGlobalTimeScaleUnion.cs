using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB9 RID: 32697
	public class TSetGlobalTimeScaleUnion
	{
		// Token: 0x1700F2F3 RID: 62195
		// (get) Token: 0x0603AE37 RID: 241207 RVA: 0x007E9786 File Offset: 0x007E7986
		// (set) Token: 0x0603AE38 RID: 241208 RVA: 0x007E978E File Offset: 0x007E798E
		public TSetGlobalTimeScale Type { get; set; }

		// Token: 0x1700F2F4 RID: 62196
		// (get) Token: 0x0603AE39 RID: 241209 RVA: 0x007E9797 File Offset: 0x007E7997
		// (set) Token: 0x0603AE3A RID: 241210 RVA: 0x007E979F File Offset: 0x007E799F
		public object Value { get; set; }

		// Token: 0x0603AE3B RID: 241211 RVA: 0x007E97A8 File Offset: 0x007E79A8
		public TSetGlobalTimeScaleUnion()
		{
			this.Type = TSetGlobalTimeScale.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE3C RID: 241212 RVA: 0x007E97BE File Offset: 0x007E79BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE3D RID: 241213 RVA: 0x007E97D0 File Offset: 0x007E79D0
		public ICloseGlobalTimeScaleT AsICloseGlobalTimeScale()
		{
			return this.As<ICloseGlobalTimeScaleT>();
		}

		// Token: 0x0603AE3E RID: 241214 RVA: 0x007E97D8 File Offset: 0x007E79D8
		public static TSetGlobalTimeScaleUnion FromICloseGlobalTimeScale(ICloseGlobalTimeScaleT _icloseglobaltimescale)
		{
			return new TSetGlobalTimeScaleUnion
			{
				Type = TSetGlobalTimeScale.ICloseGlobalTimeScale,
				Value = _icloseglobaltimescale
			};
		}

		// Token: 0x0603AE3F RID: 241215 RVA: 0x007E97ED File Offset: 0x007E79ED
		public IOpenGlobalTimeScaleT AsIOpenGlobalTimeScale()
		{
			return this.As<IOpenGlobalTimeScaleT>();
		}

		// Token: 0x0603AE40 RID: 241216 RVA: 0x007E97F5 File Offset: 0x007E79F5
		public static TSetGlobalTimeScaleUnion FromIOpenGlobalTimeScale(IOpenGlobalTimeScaleT _iopenglobaltimescale)
		{
			return new TSetGlobalTimeScaleUnion
			{
				Type = TSetGlobalTimeScale.IOpenGlobalTimeScale,
				Value = _iopenglobaltimescale
			};
		}

		// Token: 0x0603AE41 RID: 241217 RVA: 0x007E980C File Offset: 0x007E7A0C
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
