using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005680 RID: 22144
	public class IEffectSplineCreationMode_UnionUnion
	{
		// Token: 0x17009F31 RID: 40753
		// (get) Token: 0x060236A4 RID: 145060 RVA: 0x004DF09D File Offset: 0x004DD29D
		// (set) Token: 0x060236A5 RID: 145061 RVA: 0x004DF0A5 File Offset: 0x004DD2A5
		public IEffectSplineCreationMode_Union Type { get; set; }

		// Token: 0x17009F32 RID: 40754
		// (get) Token: 0x060236A6 RID: 145062 RVA: 0x004DF0AE File Offset: 0x004DD2AE
		// (set) Token: 0x060236A7 RID: 145063 RVA: 0x004DF0B6 File Offset: 0x004DD2B6
		public object Value { get; set; }

		// Token: 0x060236A8 RID: 145064 RVA: 0x004DF0BF File Offset: 0x004DD2BF
		public IEffectSplineCreationMode_UnionUnion()
		{
			this.Type = IEffectSplineCreationMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060236A9 RID: 145065 RVA: 0x004DF0D5 File Offset: 0x004DD2D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060236AA RID: 145066 RVA: 0x004DF0E7 File Offset: 0x004DD2E7
		public IEffectSplineCreationModeT AsIEffectSplineCreationMode()
		{
			return this.As<IEffectSplineCreationModeT>();
		}

		// Token: 0x060236AB RID: 145067 RVA: 0x004DF0EF File Offset: 0x004DD2EF
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineCreationMode(IEffectSplineCreationModeT _ieffectsplinecreationmode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineCreationMode,
				Value = _ieffectsplinecreationmode
			};
		}

		// Token: 0x060236AC RID: 145068 RVA: 0x004DF104 File Offset: 0x004DD304
		public IEffectSplineWholeLineModeT AsIEffectSplineWholeLineMode()
		{
			return this.As<IEffectSplineWholeLineModeT>();
		}

		// Token: 0x060236AD RID: 145069 RVA: 0x004DF10C File Offset: 0x004DD30C
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineWholeLineMode(IEffectSplineWholeLineModeT _ieffectsplinewholelinemode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineWholeLineMode,
				Value = _ieffectsplinewholelinemode
			};
		}

		// Token: 0x060236AE RID: 145070 RVA: 0x004DF121 File Offset: 0x004DD321
		public IEffectSplineEquidistantPointModeT AsIEffectSplineEquidistantPointMode()
		{
			return this.As<IEffectSplineEquidistantPointModeT>();
		}

		// Token: 0x060236AF RID: 145071 RVA: 0x004DF129 File Offset: 0x004DD329
		public static IEffectSplineCreationMode_UnionUnion FromIEffectSplineEquidistantPointMode(IEffectSplineEquidistantPointModeT _ieffectsplineequidistantpointmode)
		{
			return new IEffectSplineCreationMode_UnionUnion
			{
				Type = IEffectSplineCreationMode_Union.IEffectSplineEquidistantPointMode,
				Value = _ieffectsplineequidistantpointmode
			};
		}

		// Token: 0x060236B0 RID: 145072 RVA: 0x004DF140 File Offset: 0x004DD340
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
