using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200491B RID: 18715
	public class IFindSunSpiritGridBase_UnionUnion
	{
		// Token: 0x1700825D RID: 33373
		// (get) Token: 0x0601BC19 RID: 113689 RVA: 0x003EC9ED File Offset: 0x003EABED
		// (set) Token: 0x0601BC1A RID: 113690 RVA: 0x003EC9F5 File Offset: 0x003EABF5
		public IFindSunSpiritGridBase_Union Type { get; set; }

		// Token: 0x1700825E RID: 33374
		// (get) Token: 0x0601BC1B RID: 113691 RVA: 0x003EC9FE File Offset: 0x003EABFE
		// (set) Token: 0x0601BC1C RID: 113692 RVA: 0x003ECA06 File Offset: 0x003EAC06
		public object Value { get; set; }

		// Token: 0x0601BC1D RID: 113693 RVA: 0x003ECA0F File Offset: 0x003EAC0F
		public IFindSunSpiritGridBase_UnionUnion()
		{
			this.Type = IFindSunSpiritGridBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601BC1E RID: 113694 RVA: 0x003ECA25 File Offset: 0x003EAC25
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601BC1F RID: 113695 RVA: 0x003ECA37 File Offset: 0x003EAC37
		public IFindSunSpiritGridBaseT AsIFindSunSpiritGridBase()
		{
			return this.As<IFindSunSpiritGridBaseT>();
		}

		// Token: 0x0601BC20 RID: 113696 RVA: 0x003ECA3F File Offset: 0x003EAC3F
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridBase(IFindSunSpiritGridBaseT _ifindsunspiritgridbase)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridBase,
				Value = _ifindsunspiritgridbase
			};
		}

		// Token: 0x0601BC21 RID: 113697 RVA: 0x003ECA54 File Offset: 0x003EAC54
		public IFindSunSpiritGridEmptyT AsIFindSunSpiritGridEmpty()
		{
			return this.As<IFindSunSpiritGridEmptyT>();
		}

		// Token: 0x0601BC22 RID: 113698 RVA: 0x003ECA5C File Offset: 0x003EAC5C
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridEmpty(IFindSunSpiritGridEmptyT _ifindsunspiritgridempty)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridEmpty,
				Value = _ifindsunspiritgridempty
			};
		}

		// Token: 0x0601BC23 RID: 113699 RVA: 0x003ECA71 File Offset: 0x003EAC71
		public IFindSunSpiritGridNormalFloorT AsIFindSunSpiritGridNormalFloor()
		{
			return this.As<IFindSunSpiritGridNormalFloorT>();
		}

		// Token: 0x0601BC24 RID: 113700 RVA: 0x003ECA79 File Offset: 0x003EAC79
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridNormalFloor(IFindSunSpiritGridNormalFloorT _ifindsunspiritgridnormalfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridNormalFloor,
				Value = _ifindsunspiritgridnormalfloor
			};
		}

		// Token: 0x0601BC25 RID: 113701 RVA: 0x003ECA8E File Offset: 0x003EAC8E
		public IFindSunSpiritGridMutableFloorT AsIFindSunSpiritGridMutableFloor()
		{
			return this.As<IFindSunSpiritGridMutableFloorT>();
		}

		// Token: 0x0601BC26 RID: 113702 RVA: 0x003ECA96 File Offset: 0x003EAC96
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridMutableFloor(IFindSunSpiritGridMutableFloorT _ifindsunspiritgridmutablefloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridMutableFloor,
				Value = _ifindsunspiritgridmutablefloor
			};
		}

		// Token: 0x0601BC27 RID: 113703 RVA: 0x003ECAAB File Offset: 0x003EACAB
		public IFindSunSpiritGridBeginFloorT AsIFindSunSpiritGridBeginFloor()
		{
			return this.As<IFindSunSpiritGridBeginFloorT>();
		}

		// Token: 0x0601BC28 RID: 113704 RVA: 0x003ECAB3 File Offset: 0x003EACB3
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridBeginFloor(IFindSunSpiritGridBeginFloorT _ifindsunspiritgridbeginfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridBeginFloor,
				Value = _ifindsunspiritgridbeginfloor
			};
		}

		// Token: 0x0601BC29 RID: 113705 RVA: 0x003ECAC8 File Offset: 0x003EACC8
		public IFindSunSpiritGridEndFloorT AsIFindSunSpiritGridEndFloor()
		{
			return this.As<IFindSunSpiritGridEndFloorT>();
		}

		// Token: 0x0601BC2A RID: 113706 RVA: 0x003ECAD0 File Offset: 0x003EACD0
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridEndFloor(IFindSunSpiritGridEndFloorT _ifindsunspiritgridendfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridEndFloor,
				Value = _ifindsunspiritgridendfloor
			};
		}

		// Token: 0x0601BC2B RID: 113707 RVA: 0x003ECAE8 File Offset: 0x003EACE8
		public static int Pack(FlatBufferBuilder builder, IFindSunSpiritGridBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridBase:
				return IFindSunSpiritGridBase.Pack(builder, _o.AsIFindSunSpiritGridBase()).Value;
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridEmpty:
				return IFindSunSpiritGridEmpty.Pack(builder, _o.AsIFindSunSpiritGridEmpty()).Value;
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridNormalFloor:
				return IFindSunSpiritGridNormalFloor.Pack(builder, _o.AsIFindSunSpiritGridNormalFloor()).Value;
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridMutableFloor:
				return IFindSunSpiritGridMutableFloor.Pack(builder, _o.AsIFindSunSpiritGridMutableFloor()).Value;
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridBeginFloor:
				return IFindSunSpiritGridBeginFloor.Pack(builder, _o.AsIFindSunSpiritGridBeginFloor()).Value;
			case IFindSunSpiritGridBase_Union.IFindSunSpiritGridEndFloor:
				return IFindSunSpiritGridEndFloor.Pack(builder, _o.AsIFindSunSpiritGridEndFloor()).Value;
			default:
				return 0;
			}
		}
	}
}
