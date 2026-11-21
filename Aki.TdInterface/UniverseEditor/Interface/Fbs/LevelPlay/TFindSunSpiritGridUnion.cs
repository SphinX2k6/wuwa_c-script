using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A6E RID: 19054
	public class TFindSunSpiritGridUnion
	{
		// Token: 0x170085A4 RID: 34212
		// (get) Token: 0x0601CA54 RID: 117332 RVA: 0x0040AA6A File Offset: 0x00408C6A
		// (set) Token: 0x0601CA55 RID: 117333 RVA: 0x0040AA72 File Offset: 0x00408C72
		public TFindSunSpiritGrid Type { get; set; }

		// Token: 0x170085A5 RID: 34213
		// (get) Token: 0x0601CA56 RID: 117334 RVA: 0x0040AA7B File Offset: 0x00408C7B
		// (set) Token: 0x0601CA57 RID: 117335 RVA: 0x0040AA83 File Offset: 0x00408C83
		public object Value { get; set; }

		// Token: 0x0601CA58 RID: 117336 RVA: 0x0040AA8C File Offset: 0x00408C8C
		public TFindSunSpiritGridUnion()
		{
			this.Type = TFindSunSpiritGrid.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA59 RID: 117337 RVA: 0x0040AAA2 File Offset: 0x00408CA2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA5A RID: 117338 RVA: 0x0040AAB4 File Offset: 0x00408CB4
		public IFindSunSpiritGridBeginFloorT AsIFindSunSpiritGridBeginFloor()
		{
			return this.As<IFindSunSpiritGridBeginFloorT>();
		}

		// Token: 0x0601CA5B RID: 117339 RVA: 0x0040AABC File Offset: 0x00408CBC
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridBeginFloor(IFindSunSpiritGridBeginFloorT _ifindsunspiritgridbeginfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridBeginFloor,
				Value = _ifindsunspiritgridbeginfloor
			};
		}

		// Token: 0x0601CA5C RID: 117340 RVA: 0x0040AAD1 File Offset: 0x00408CD1
		public IFindSunSpiritGridEmptyT AsIFindSunSpiritGridEmpty()
		{
			return this.As<IFindSunSpiritGridEmptyT>();
		}

		// Token: 0x0601CA5D RID: 117341 RVA: 0x0040AAD9 File Offset: 0x00408CD9
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridEmpty(IFindSunSpiritGridEmptyT _ifindsunspiritgridempty)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridEmpty,
				Value = _ifindsunspiritgridempty
			};
		}

		// Token: 0x0601CA5E RID: 117342 RVA: 0x0040AAEE File Offset: 0x00408CEE
		public IFindSunSpiritGridEndFloorT AsIFindSunSpiritGridEndFloor()
		{
			return this.As<IFindSunSpiritGridEndFloorT>();
		}

		// Token: 0x0601CA5F RID: 117343 RVA: 0x0040AAF6 File Offset: 0x00408CF6
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridEndFloor(IFindSunSpiritGridEndFloorT _ifindsunspiritgridendfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridEndFloor,
				Value = _ifindsunspiritgridendfloor
			};
		}

		// Token: 0x0601CA60 RID: 117344 RVA: 0x0040AB0B File Offset: 0x00408D0B
		public IFindSunSpiritGridMutableFloorT AsIFindSunSpiritGridMutableFloor()
		{
			return this.As<IFindSunSpiritGridMutableFloorT>();
		}

		// Token: 0x0601CA61 RID: 117345 RVA: 0x0040AB13 File Offset: 0x00408D13
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridMutableFloor(IFindSunSpiritGridMutableFloorT _ifindsunspiritgridmutablefloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridMutableFloor,
				Value = _ifindsunspiritgridmutablefloor
			};
		}

		// Token: 0x0601CA62 RID: 117346 RVA: 0x0040AB28 File Offset: 0x00408D28
		public IFindSunSpiritGridNormalFloorT AsIFindSunSpiritGridNormalFloor()
		{
			return this.As<IFindSunSpiritGridNormalFloorT>();
		}

		// Token: 0x0601CA63 RID: 117347 RVA: 0x0040AB30 File Offset: 0x00408D30
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridNormalFloor(IFindSunSpiritGridNormalFloorT _ifindsunspiritgridnormalfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridNormalFloor,
				Value = _ifindsunspiritgridnormalfloor
			};
		}

		// Token: 0x0601CA64 RID: 117348 RVA: 0x0040AB48 File Offset: 0x00408D48
		public static int Pack(FlatBufferBuilder builder, TFindSunSpiritGridUnion _o)
		{
			switch (_o.Type)
			{
			case TFindSunSpiritGrid.IFindSunSpiritGridBeginFloor:
				return IFindSunSpiritGridBeginFloor.Pack(builder, _o.AsIFindSunSpiritGridBeginFloor()).Value;
			case TFindSunSpiritGrid.IFindSunSpiritGridEmpty:
				return IFindSunSpiritGridEmpty.Pack(builder, _o.AsIFindSunSpiritGridEmpty()).Value;
			case TFindSunSpiritGrid.IFindSunSpiritGridEndFloor:
				return IFindSunSpiritGridEndFloor.Pack(builder, _o.AsIFindSunSpiritGridEndFloor()).Value;
			case TFindSunSpiritGrid.IFindSunSpiritGridMutableFloor:
				return IFindSunSpiritGridMutableFloor.Pack(builder, _o.AsIFindSunSpiritGridMutableFloor()).Value;
			case TFindSunSpiritGrid.IFindSunSpiritGridNormalFloor:
				return IFindSunSpiritGridNormalFloor.Pack(builder, _o.AsIFindSunSpiritGridNormalFloor()).Value;
			default:
				return 0;
			}
		}
	}
}
