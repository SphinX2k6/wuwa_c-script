using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006223 RID: 25123
	public class TEffectSplineCreateOptionUnion
	{
		// Token: 0x1700BB2E RID: 47918
		// (get) Token: 0x0602AC85 RID: 175237 RVA: 0x005D812E File Offset: 0x005D632E
		// (set) Token: 0x0602AC86 RID: 175238 RVA: 0x005D8136 File Offset: 0x005D6336
		public TEffectSplineCreateOption Type { get; set; }

		// Token: 0x1700BB2F RID: 47919
		// (get) Token: 0x0602AC87 RID: 175239 RVA: 0x005D813F File Offset: 0x005D633F
		// (set) Token: 0x0602AC88 RID: 175240 RVA: 0x005D8147 File Offset: 0x005D6347
		public object Value { get; set; }

		// Token: 0x0602AC89 RID: 175241 RVA: 0x005D8150 File Offset: 0x005D6350
		public TEffectSplineCreateOptionUnion()
		{
			this.Type = TEffectSplineCreateOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AC8A RID: 175242 RVA: 0x005D8166 File Offset: 0x005D6366
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AC8B RID: 175243 RVA: 0x005D8178 File Offset: 0x005D6378
		public IEffectSplineEquidistantPointModeT AsIEffectSplineEquidistantPointMode()
		{
			return this.As<IEffectSplineEquidistantPointModeT>();
		}

		// Token: 0x0602AC8C RID: 175244 RVA: 0x005D8180 File Offset: 0x005D6380
		public static TEffectSplineCreateOptionUnion FromIEffectSplineEquidistantPointMode(IEffectSplineEquidistantPointModeT _ieffectsplineequidistantpointmode)
		{
			return new TEffectSplineCreateOptionUnion
			{
				Type = TEffectSplineCreateOption.IEffectSplineEquidistantPointMode,
				Value = _ieffectsplineequidistantpointmode
			};
		}

		// Token: 0x0602AC8D RID: 175245 RVA: 0x005D8195 File Offset: 0x005D6395
		public IEffectSplineWholeLineModeT AsIEffectSplineWholeLineMode()
		{
			return this.As<IEffectSplineWholeLineModeT>();
		}

		// Token: 0x0602AC8E RID: 175246 RVA: 0x005D819D File Offset: 0x005D639D
		public static TEffectSplineCreateOptionUnion FromIEffectSplineWholeLineMode(IEffectSplineWholeLineModeT _ieffectsplinewholelinemode)
		{
			return new TEffectSplineCreateOptionUnion
			{
				Type = TEffectSplineCreateOption.IEffectSplineWholeLineMode,
				Value = _ieffectsplinewholelinemode
			};
		}

		// Token: 0x0602AC8F RID: 175247 RVA: 0x005D81B4 File Offset: 0x005D63B4
		public static int Pack(FlatBufferBuilder builder, TEffectSplineCreateOptionUnion _o)
		{
			TEffectSplineCreateOption type = _o.Type;
			if (type == TEffectSplineCreateOption.IEffectSplineEquidistantPointMode)
			{
				return IEffectSplineEquidistantPointMode.Pack(builder, _o.AsIEffectSplineEquidistantPointMode()).Value;
			}
			if (type != TEffectSplineCreateOption.IEffectSplineWholeLineMode)
			{
				return 0;
			}
			return IEffectSplineWholeLineMode.Pack(builder, _o.AsIEffectSplineWholeLineMode()).Value;
		}
	}
}
