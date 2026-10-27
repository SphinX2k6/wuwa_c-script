using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B3 RID: 17587
	public class IFindSunSpiritGridBase_UnionUnion
	{
		// Token: 0x17007C1E RID: 31774
		// (get) Token: 0x0601A448 RID: 107592 RVA: 0x003C07E1 File Offset: 0x003BE9E1
		// (set) Token: 0x0601A449 RID: 107593 RVA: 0x003C07E9 File Offset: 0x003BE9E9
		public IFindSunSpiritGridBase_Union Type { get; set; }

		// Token: 0x17007C1F RID: 31775
		// (get) Token: 0x0601A44A RID: 107594 RVA: 0x003C07F2 File Offset: 0x003BE9F2
		// (set) Token: 0x0601A44B RID: 107595 RVA: 0x003C07FA File Offset: 0x003BE9FA
		public object Value { get; set; }

		// Token: 0x0601A44C RID: 107596 RVA: 0x003C0803 File Offset: 0x003BEA03
		public IFindSunSpiritGridBase_UnionUnion()
		{
			this.Type = IFindSunSpiritGridBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A44D RID: 107597 RVA: 0x003C0819 File Offset: 0x003BEA19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A44E RID: 107598 RVA: 0x003C082B File Offset: 0x003BEA2B
		public IFindSunSpiritGridBaseT AsIFindSunSpiritGridBase()
		{
			return this.As<IFindSunSpiritGridBaseT>();
		}

		// Token: 0x0601A44F RID: 107599 RVA: 0x003C0833 File Offset: 0x003BEA33
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridBase(IFindSunSpiritGridBaseT _ifindsunspiritgridbase)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridBase,
				Value = _ifindsunspiritgridbase
			};
		}

		// Token: 0x0601A450 RID: 107600 RVA: 0x003C0848 File Offset: 0x003BEA48
		public IFindSunSpiritGridEmptyT AsIFindSunSpiritGridEmpty()
		{
			return this.As<IFindSunSpiritGridEmptyT>();
		}

		// Token: 0x0601A451 RID: 107601 RVA: 0x003C0850 File Offset: 0x003BEA50
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridEmpty(IFindSunSpiritGridEmptyT _ifindsunspiritgridempty)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridEmpty,
				Value = _ifindsunspiritgridempty
			};
		}

		// Token: 0x0601A452 RID: 107602 RVA: 0x003C0865 File Offset: 0x003BEA65
		public IFindSunSpiritGridNormalFloorT AsIFindSunSpiritGridNormalFloor()
		{
			return this.As<IFindSunSpiritGridNormalFloorT>();
		}

		// Token: 0x0601A453 RID: 107603 RVA: 0x003C086D File Offset: 0x003BEA6D
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridNormalFloor(IFindSunSpiritGridNormalFloorT _ifindsunspiritgridnormalfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridNormalFloor,
				Value = _ifindsunspiritgridnormalfloor
			};
		}

		// Token: 0x0601A454 RID: 107604 RVA: 0x003C0882 File Offset: 0x003BEA82
		public IFindSunSpiritGridMutableFloorT AsIFindSunSpiritGridMutableFloor()
		{
			return this.As<IFindSunSpiritGridMutableFloorT>();
		}

		// Token: 0x0601A455 RID: 107605 RVA: 0x003C088A File Offset: 0x003BEA8A
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridMutableFloor(IFindSunSpiritGridMutableFloorT _ifindsunspiritgridmutablefloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridMutableFloor,
				Value = _ifindsunspiritgridmutablefloor
			};
		}

		// Token: 0x0601A456 RID: 107606 RVA: 0x003C089F File Offset: 0x003BEA9F
		public IFindSunSpiritGridBeginFloorT AsIFindSunSpiritGridBeginFloor()
		{
			return this.As<IFindSunSpiritGridBeginFloorT>();
		}

		// Token: 0x0601A457 RID: 107607 RVA: 0x003C08A7 File Offset: 0x003BEAA7
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridBeginFloor(IFindSunSpiritGridBeginFloorT _ifindsunspiritgridbeginfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridBeginFloor,
				Value = _ifindsunspiritgridbeginfloor
			};
		}

		// Token: 0x0601A458 RID: 107608 RVA: 0x003C08BC File Offset: 0x003BEABC
		public IFindSunSpiritGridEndFloorT AsIFindSunSpiritGridEndFloor()
		{
			return this.As<IFindSunSpiritGridEndFloorT>();
		}

		// Token: 0x0601A459 RID: 107609 RVA: 0x003C08C4 File Offset: 0x003BEAC4
		public static IFindSunSpiritGridBase_UnionUnion FromIFindSunSpiritGridEndFloor(IFindSunSpiritGridEndFloorT _ifindsunspiritgridendfloor)
		{
			return new IFindSunSpiritGridBase_UnionUnion
			{
				Type = IFindSunSpiritGridBase_Union.IFindSunSpiritGridEndFloor,
				Value = _ifindsunspiritgridendfloor
			};
		}

		// Token: 0x0601A45A RID: 107610 RVA: 0x003C08DC File Offset: 0x003BEADC
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
