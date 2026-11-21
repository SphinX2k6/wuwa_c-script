using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200614C RID: 24908
	public class IViewDistanceMode_UnionUnion
	{
		// Token: 0x1700B981 RID: 47489
		// (get) Token: 0x0602A43A RID: 173114 RVA: 0x005C440D File Offset: 0x005C260D
		// (set) Token: 0x0602A43B RID: 173115 RVA: 0x005C4415 File Offset: 0x005C2615
		public IViewDistanceMode_Union Type { get; set; }

		// Token: 0x1700B982 RID: 47490
		// (get) Token: 0x0602A43C RID: 173116 RVA: 0x005C441E File Offset: 0x005C261E
		// (set) Token: 0x0602A43D RID: 173117 RVA: 0x005C4426 File Offset: 0x005C2626
		public object Value { get; set; }

		// Token: 0x0602A43E RID: 173118 RVA: 0x005C442F File Offset: 0x005C262F
		public IViewDistanceMode_UnionUnion()
		{
			this.Type = IViewDistanceMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A43F RID: 173119 RVA: 0x005C4445 File Offset: 0x005C2645
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A440 RID: 173120 RVA: 0x005C4457 File Offset: 0x005C2657
		public IViewDistanceModeT AsIViewDistanceMode()
		{
			return this.As<IViewDistanceModeT>();
		}

		// Token: 0x0602A441 RID: 173121 RVA: 0x005C445F File Offset: 0x005C265F
		public static IViewDistanceMode_UnionUnion FromIViewDistanceMode(IViewDistanceModeT _iviewdistancemode)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IViewDistanceMode,
				Value = _iviewdistancemode
			};
		}

		// Token: 0x0602A442 RID: 173122 RVA: 0x005C4474 File Offset: 0x005C2674
		public ILowViewDistanceT AsILowViewDistance()
		{
			return this.As<ILowViewDistanceT>();
		}

		// Token: 0x0602A443 RID: 173123 RVA: 0x005C447C File Offset: 0x005C267C
		public static IViewDistanceMode_UnionUnion FromILowViewDistance(ILowViewDistanceT _ilowviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.ILowViewDistance,
				Value = _ilowviewdistance
			};
		}

		// Token: 0x0602A444 RID: 173124 RVA: 0x005C4491 File Offset: 0x005C2691
		public IMidViewDistanceT AsIMidViewDistance()
		{
			return this.As<IMidViewDistanceT>();
		}

		// Token: 0x0602A445 RID: 173125 RVA: 0x005C4499 File Offset: 0x005C2699
		public static IViewDistanceMode_UnionUnion FromIMidViewDistance(IMidViewDistanceT _imidviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IMidViewDistance,
				Value = _imidviewdistance
			};
		}

		// Token: 0x0602A446 RID: 173126 RVA: 0x005C44AE File Offset: 0x005C26AE
		public IHighViewDistanceT AsIHighViewDistance()
		{
			return this.As<IHighViewDistanceT>();
		}

		// Token: 0x0602A447 RID: 173127 RVA: 0x005C44B6 File Offset: 0x005C26B6
		public static IViewDistanceMode_UnionUnion FromIHighViewDistance(IHighViewDistanceT _ihighviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.IHighViewDistance,
				Value = _ihighviewdistance
			};
		}

		// Token: 0x0602A448 RID: 173128 RVA: 0x005C44CB File Offset: 0x005C26CB
		public ICustomViewDistanceT AsICustomViewDistance()
		{
			return this.As<ICustomViewDistanceT>();
		}

		// Token: 0x0602A449 RID: 173129 RVA: 0x005C44D3 File Offset: 0x005C26D3
		public static IViewDistanceMode_UnionUnion FromICustomViewDistance(ICustomViewDistanceT _icustomviewdistance)
		{
			return new IViewDistanceMode_UnionUnion
			{
				Type = IViewDistanceMode_Union.ICustomViewDistance,
				Value = _icustomviewdistance
			};
		}

		// Token: 0x0602A44A RID: 173130 RVA: 0x005C44E8 File Offset: 0x005C26E8
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
