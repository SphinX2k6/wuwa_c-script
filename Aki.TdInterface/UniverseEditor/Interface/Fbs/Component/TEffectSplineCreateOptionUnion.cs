using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C04 RID: 23556
	public class TEffectSplineCreateOptionUnion
	{
		// Token: 0x1700B1E0 RID: 45536
		// (get) Token: 0x06028695 RID: 165525 RVA: 0x005901E6 File Offset: 0x0058E3E6
		// (set) Token: 0x06028696 RID: 165526 RVA: 0x005901EE File Offset: 0x0058E3EE
		public TEffectSplineCreateOption Type { get; set; }

		// Token: 0x1700B1E1 RID: 45537
		// (get) Token: 0x06028697 RID: 165527 RVA: 0x005901F7 File Offset: 0x0058E3F7
		// (set) Token: 0x06028698 RID: 165528 RVA: 0x005901FF File Offset: 0x0058E3FF
		public object Value { get; set; }

		// Token: 0x06028699 RID: 165529 RVA: 0x00590208 File Offset: 0x0058E408
		public TEffectSplineCreateOptionUnion()
		{
			this.Type = TEffectSplineCreateOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602869A RID: 165530 RVA: 0x0059021E File Offset: 0x0058E41E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602869B RID: 165531 RVA: 0x00590230 File Offset: 0x0058E430
		public IEffectSplineEquidistantPointModeT AsIEffectSplineEquidistantPointMode()
		{
			return this.As<IEffectSplineEquidistantPointModeT>();
		}

		// Token: 0x0602869C RID: 165532 RVA: 0x00590238 File Offset: 0x0058E438
		public static TEffectSplineCreateOptionUnion FromIEffectSplineEquidistantPointMode(IEffectSplineEquidistantPointModeT _ieffectsplineequidistantpointmode)
		{
			return new TEffectSplineCreateOptionUnion
			{
				Type = TEffectSplineCreateOption.IEffectSplineEquidistantPointMode,
				Value = _ieffectsplineequidistantpointmode
			};
		}

		// Token: 0x0602869D RID: 165533 RVA: 0x0059024D File Offset: 0x0058E44D
		public IEffectSplineWholeLineModeT AsIEffectSplineWholeLineMode()
		{
			return this.As<IEffectSplineWholeLineModeT>();
		}

		// Token: 0x0602869E RID: 165534 RVA: 0x00590255 File Offset: 0x0058E455
		public static TEffectSplineCreateOptionUnion FromIEffectSplineWholeLineMode(IEffectSplineWholeLineModeT _ieffectsplinewholelinemode)
		{
			return new TEffectSplineCreateOptionUnion
			{
				Type = TEffectSplineCreateOption.IEffectSplineWholeLineMode,
				Value = _ieffectsplinewholelinemode
			};
		}

		// Token: 0x0602869F RID: 165535 RVA: 0x0059026C File Offset: 0x0058E46C
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
