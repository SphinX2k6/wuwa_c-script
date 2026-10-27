using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B36 RID: 23350
	public class IViewDistanceMode_UnionUnion
	{
		// Token: 0x1700B039 RID: 45113
		// (get) Token: 0x06027E76 RID: 163446 RVA: 0x0057C9B9 File Offset: 0x0057ABB9
		// (set) Token: 0x06027E77 RID: 163447 RVA: 0x0057C9C1 File Offset: 0x0057ABC1
		public IViewDistanceMode_Union Type { get; set; }

		// Token: 0x1700B03A RID: 45114
		// (get) Token: 0x06027E78 RID: 163448 RVA: 0x0057C9CA File Offset: 0x0057ABCA
		// (set) Token: 0x06027E79 RID: 163449 RVA: 0x0057C9D2 File Offset: 0x0057ABD2
		public object Value { get; set; }

		// Token: 0x06027E7A RID: 163450 RVA: 0x0057C9DB File Offset: 0x0057ABDB
		public IViewDistanceMode_UnionUnion()
		{
			this.Type = IViewDistanceMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027E7B RID: 163451 RVA: 0x0057C9F1 File Offset: 0x0057ABF1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027E7C RID: 163452 RVA: 0x0057CA03 File Offset: 0x0057AC03
		public IViewDistanceModeT AsIViewDistanceMode()
		{
			return this.As<IViewDistanceModeT>();
		}

		// Token: 0x06027E7D RID: 163453 RVA: 0x0057CA0B File Offset: 0x0057AC0B
		public static IViewDistanceMode_UnionUnion FromIViewDistanceMode(IViewDistanceModeT _iviewdistancemode)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IViewDistanceMode,
				Value = _iviewdistancemode
			};
		}

		// Token: 0x06027E7E RID: 163454 RVA: 0x0057CA20 File Offset: 0x0057AC20
		public ILowViewDistanceT AsILowViewDistance()
		{
			return this.As<ILowViewDistanceT>();
		}

		// Token: 0x06027E7F RID: 163455 RVA: 0x0057CA28 File Offset: 0x0057AC28
		public static IViewDistanceMode_UnionUnion FromILowViewDistance(ILowViewDistanceT _ilowviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.ILowViewDistance,
				Value = _ilowviewdistance
			};
		}

		// Token: 0x06027E80 RID: 163456 RVA: 0x0057CA3D File Offset: 0x0057AC3D
		public IMidViewDistanceT AsIMidViewDistance()
		{
			return this.As<IMidViewDistanceT>();
		}

		// Token: 0x06027E81 RID: 163457 RVA: 0x0057CA45 File Offset: 0x0057AC45
		public static IViewDistanceMode_UnionUnion FromIMidViewDistance(IMidViewDistanceT _imidviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IMidViewDistance,
				Value = _imidviewdistance
			};
		}

		// Token: 0x06027E82 RID: 163458 RVA: 0x0057CA5A File Offset: 0x0057AC5A
		public IHighViewDistanceT AsIHighViewDistance()
		{
			return this.As<IHighViewDistanceT>();
		}

		// Token: 0x06027E83 RID: 163459 RVA: 0x0057CA62 File Offset: 0x0057AC62
		public static IViewDistanceMode_UnionUnion FromIHighViewDistance(IHighViewDistanceT _ihighviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IHighViewDistance,
				Value = _ihighviewdistance
			};
		}

		// Token: 0x06027E84 RID: 163460 RVA: 0x0057CA77 File Offset: 0x0057AC77
		public ICustomViewDistanceT AsICustomViewDistance()
		{
			return this.As<ICustomViewDistanceT>();
		}

		// Token: 0x06027E85 RID: 163461 RVA: 0x0057CA7F File Offset: 0x0057AC7F
		public static IViewDistanceMode_UnionUnion FromICustomViewDistance(ICustomViewDistanceT _icustomviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.ICustomViewDistance,
				Value = _icustomviewdistance
			};
		}

		// Token: 0x06027E86 RID: 163462 RVA: 0x0057CA94 File Offset: 0x0057AC94
		public static int Pack(FlatBufferBuilder builder, IViewDistanceMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IViewDistanceMode_Union.IViewDistanceMode:
				return IViewDistanceMode.Pack(builder, _o.AsIViewDistanceMode()).Value;
			case IViewDistanceMode_Union.ILowViewDistance:
				return ILowViewDistance.Pack(builder, _o.AsILowViewDistance()).Value;
			case IViewDistanceMode_Union.IMidViewDistance:
				return IMidViewDistance.Pack(builder, _o.AsIMidViewDistance()).Value;
			case IViewDistanceMode_Union.IHighViewDistance:
				return IHighViewDistance.Pack(builder, _o.AsIHighViewDistance()).Value;
			case IViewDistanceMode_Union.ICustomViewDistance:
				return ICustomViewDistance.Pack(builder, _o.AsICustomViewDistance()).Value;
			default:
				return 0;
			}
		}
	}
}
