using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551E RID: 21790
	public class IColorStrategyOfSplineEffectType_UnionUnion
	{
		// Token: 0x17009BB8 RID: 39864
		// (get) Token: 0x06022705 RID: 141061 RVA: 0x004BEBA1 File Offset: 0x004BCDA1
		// (set) Token: 0x06022706 RID: 141062 RVA: 0x004BEBA9 File Offset: 0x004BCDA9
		public IColorStrategyOfSplineEffectType_Union Type { get; set; }

		// Token: 0x17009BB9 RID: 39865
		// (get) Token: 0x06022707 RID: 141063 RVA: 0x004BEBB2 File Offset: 0x004BCDB2
		// (set) Token: 0x06022708 RID: 141064 RVA: 0x004BEBBA File Offset: 0x004BCDBA
		public object Value { get; set; }

		// Token: 0x06022709 RID: 141065 RVA: 0x004BEBC3 File Offset: 0x004BCDC3
		public IColorStrategyOfSplineEffectType_UnionUnion()
		{
			this.Type = IColorStrategyOfSplineEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602270A RID: 141066 RVA: 0x004BEBD9 File Offset: 0x004BCDD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602270B RID: 141067 RVA: 0x004BEBEB File Offset: 0x004BCDEB
		public IColorStrategyOfSplineEffectTypeT AsIColorStrategyOfSplineEffectType()
		{
			return this.As<IColorStrategyOfSplineEffectTypeT>();
		}

		// Token: 0x0602270C RID: 141068 RVA: 0x004BEBF3 File Offset: 0x004BCDF3
		public static IColorStrategyOfSplineEffectType_UnionUnion FromIColorStrategyOfSplineEffectType(IColorStrategyOfSplineEffectTypeT _icolorstrategyofsplineeffecttype)
		{
			return new IColorStrategyOfSplineEffectType_UnionUnion
			{
				Type = IColorStrategyOfSplineEffectType_Union.IColorStrategyOfSplineEffectType,
				Value = _icolorstrategyofsplineeffecttype
			};
		}

		// Token: 0x0602270D RID: 141069 RVA: 0x004BEC08 File Offset: 0x004BCE08
		public IColorChangeStrategyOfRGBT AsIColorChangeStrategyOfRGB()
		{
			return this.As<IColorChangeStrategyOfRGBT>();
		}

		// Token: 0x0602270E RID: 141070 RVA: 0x004BEC10 File Offset: 0x004BCE10
		public static IColorStrategyOfSplineEffectType_UnionUnion FromIColorChangeStrategyOfRGB(IColorChangeStrategyOfRGBT _icolorchangestrategyofrgb)
		{
			return new IColorStrategyOfSplineEffectType_UnionUnion
			{
				Type = IColorStrategyOfSplineEffectType_Union.IColorChangeStrategyOfRGB,
				Value = _icolorchangestrategyofrgb
			};
		}

		// Token: 0x0602270F RID: 141071 RVA: 0x004BEC28 File Offset: 0x004BCE28
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
