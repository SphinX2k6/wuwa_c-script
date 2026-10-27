using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200511B RID: 20763
	public class IEffectSplineCreationMode_UnionUnion
	{
		// Token: 0x17009744 RID: 38724
		// (get) Token: 0x06021750 RID: 137040 RVA: 0x004A5111 File Offset: 0x004A3311
		// (set) Token: 0x06021751 RID: 137041 RVA: 0x004A5119 File Offset: 0x004A3319
		public IEffectSplineCreationMode_Union Type { get; set; }

		// Token: 0x17009745 RID: 38725
		// (get) Token: 0x06021752 RID: 137042 RVA: 0x004A5122 File Offset: 0x004A3322
		// (set) Token: 0x06021753 RID: 137043 RVA: 0x004A512A File Offset: 0x004A332A
		public object Value { get; set; }

		// Token: 0x06021754 RID: 137044 RVA: 0x004A5133 File Offset: 0x004A3333
		public IEffectSplineCreationMode_UnionUnion()
		{
			this.Type = IEffectSplineCreationMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021755 RID: 137045 RVA: 0x004A5149 File Offset: 0x004A3349
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021756 RID: 137046 RVA: 0x004A515B File Offset: 0x004A335B
		public IEffectSplineCreationModeT AsIEffectSplineCreationMode()
		{
			return this.As<IEffectSplineCreationModeT>();
		}

		// Token: 0x06021757 RID: 137047 RVA: 0x004A5163 File Offset: 0x004A3363
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineCreationMode(IEffectSplineCreationModeT _ieffectsplinecreationmode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineCreationMode,
				Value = _ieffectsplinecreationmode
			};
		}

		// Token: 0x06021758 RID: 137048 RVA: 0x004A5178 File Offset: 0x004A3378
		public IEffectSplineWholeLineModeT AsIEffectSplineWholeLineMode()
		{
			return this.As<IEffectSplineWholeLineModeT>();
		}

		// Token: 0x06021759 RID: 137049 RVA: 0x004A5180 File Offset: 0x004A3380
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineWholeLineMode(IEffectSplineWholeLineModeT _ieffectsplinewholelinemode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineWholeLineMode,
				Value = _ieffectsplinewholelinemode
			};
		}

		// Token: 0x0602175A RID: 137050 RVA: 0x004A5195 File Offset: 0x004A3395
		public IEffectSplineEquidistantPointModeT AsIEffectSplineEquidistantPointMode()
		{
			return this.As<IEffectSplineEquidistantPointModeT>();
		}

		// Token: 0x0602175B RID: 137051 RVA: 0x004A519D File Offset: 0x004A339D
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineEquidistantPointMode(IEffectSplineEquidistantPointModeT _ieffectsplineequidistantpointmode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineEquidistantPointMode,
				Value = _ieffectsplineequidistantpointmode
			};
		}

		// Token: 0x0602175C RID: 137052 RVA: 0x004A51B4 File Offset: 0x004A33B4
		public static int Pack(FlatBufferBuilder builder, IEffectSplineCreationMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEffectSplineCreationMode_Union.IEffectSplineCreationMode:
				return IEffectSplineCreationMode.Pack(builder, _o.AsIEffectSplineCreationMode()).Value;
			case IEffectSplineCreationMode_Union.IEffectSplineWholeLineMode:
				return IEffectSplineWholeLineMode.Pack(builder, _o.AsIEffectSplineWholeLineMode()).Value;
			case IEffectSplineCreationMode_Union.IEffectSplineEquidistantPointMode:
				return IEffectSplineEquidistantPointMode.Pack(builder, _o.AsIEffectSplineEquidistantPointMode()).Value;
			default:
				return 0;
			}
		}
	}
}
