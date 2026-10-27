using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC2 RID: 20418
	public class IColorStrategyOfSplineEffectType_UnionUnion
	{
		// Token: 0x170093E0 RID: 37856
		// (get) Token: 0x06020811 RID: 133137 RVA: 0x004856BD File Offset: 0x004838BD
		// (set) Token: 0x06020812 RID: 133138 RVA: 0x004856C5 File Offset: 0x004838C5
		public IColorStrategyOfSplineEffectType_Union Type { get; set; }

		// Token: 0x170093E1 RID: 37857
		// (get) Token: 0x06020813 RID: 133139 RVA: 0x004856CE File Offset: 0x004838CE
		// (set) Token: 0x06020814 RID: 133140 RVA: 0x004856D6 File Offset: 0x004838D6
		public object Value { get; set; }

		// Token: 0x06020815 RID: 133141 RVA: 0x004856DF File Offset: 0x004838DF
		public IColorStrategyOfSplineEffectType_UnionUnion()
		{
			this.Type = IColorStrategyOfSplineEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020816 RID: 133142 RVA: 0x004856F5 File Offset: 0x004838F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020817 RID: 133143 RVA: 0x00485707 File Offset: 0x00483907
		public IColorStrategyOfSplineEffectTypeT AsIColorStrategyOfSplineEffectType()
		{
			return this.As<IColorStrategyOfSplineEffectTypeT>();
		}

		// Token: 0x06020818 RID: 133144 RVA: 0x0048570F File Offset: 0x0048390F
		public static IColorStrategyOfSplineEffectType_UnionUnion FromIColorStrategyOfSplineEffectType(IColorStrategyOfSplineEffectTypeT _icolorstrategyofsplineeffecttype)
		{
			return new IColorStrategyOfSplineEffectType_UnionUnion
			{
				Type = IColorStrategyOfSplineEffectType_Union.IColorStrategyOfSplineEffectType,
				Value = _icolorstrategyofsplineeffecttype
			};
		}

		// Token: 0x06020819 RID: 133145 RVA: 0x00485724 File Offset: 0x00483924
		public IColorChangeStrategyOfRGBT AsIColorChangeStrategyOfRGB()
		{
			return this.As<IColorChangeStrategyOfRGBT>();
		}

		// Token: 0x0602081A RID: 133146 RVA: 0x0048572C File Offset: 0x0048392C
		public static IColorStrategyOfSplineEffectType_UnionUnion FromIColorChangeStrategyOfRGB(IColorChangeStrategyOfRGBT _icolorchangestrategyofrgb)
		{
			return new IColorStrategyOfSplineEffectType_UnionUnion
			{
				Type = IColorStrategyOfSplineEffectType_Union.IColorChangeStrategyOfRGB,
				Value = _icolorchangestrategyofrgb
			};
		}

		// Token: 0x0602081B RID: 133147 RVA: 0x00485744 File Offset: 0x00483944
		public static int Pack(FlatBufferBuilder builder, IColorStrategyOfSplineEffectType_UnionUnion _o)
		{
			IColorStrategyOfSplineEffectType_Union type = _o.Type;
			if (type == IColorStrategyOfSplineEffectType_Union.IColorStrategyOfSplineEffectType)
			{
				return IColorStrategyOfSplineEffectType.Pack(builder, _o.AsIColorStrategyOfSplineEffectType()).Value;
			}
			if (type != IColorStrategyOfSplineEffectType_Union.IColorChangeStrategyOfRGB)
			{
				return 0;
			}
			return IColorChangeStrategyOfRGB.Pack(builder, _o.AsIColorChangeStrategyOfRGB()).Value;
		}
	}
}
