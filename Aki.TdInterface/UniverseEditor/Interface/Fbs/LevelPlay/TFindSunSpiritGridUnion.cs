using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004606 RID: 17926
	public class TFindSunSpiritGridUnion
	{
		// Token: 0x17007F63 RID: 32611
		// (get) Token: 0x0601B27F RID: 111231 RVA: 0x003DE7CE File Offset: 0x003DC9CE
		// (set) Token: 0x0601B280 RID: 111232 RVA: 0x003DE7D6 File Offset: 0x003DC9D6
		public TFindSunSpiritGrid Type { get; set; }

		// Token: 0x17007F64 RID: 32612
		// (get) Token: 0x0601B281 RID: 111233 RVA: 0x003DE7DF File Offset: 0x003DC9DF
		// (set) Token: 0x0601B282 RID: 111234 RVA: 0x003DE7E7 File Offset: 0x003DC9E7
		public object Value { get; set; }

		// Token: 0x0601B283 RID: 111235 RVA: 0x003DE7F0 File Offset: 0x003DC9F0
		public TFindSunSpiritGridUnion()
		{
			this.Type = TFindSunSpiritGrid.NONE;
			this.Value = null;
		}

		// Token: 0x0601B284 RID: 111236 RVA: 0x003DE806 File Offset: 0x003DCA06
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B285 RID: 111237 RVA: 0x003DE818 File Offset: 0x003DCA18
		public IFindSunSpiritGridBeginFloorT AsIFindSunSpiritGridBeginFloor()
		{
			return this.As<IFindSunSpiritGridBeginFloorT>();
		}

		// Token: 0x0601B286 RID: 111238 RVA: 0x003DE820 File Offset: 0x003DCA20
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridBeginFloor(IFindSunSpiritGridBeginFloorT _ifindsunspiritgridbeginfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridBeginFloor,
				Value = _ifindsunspiritgridbeginfloor
			};
		}

		// Token: 0x0601B287 RID: 111239 RVA: 0x003DE835 File Offset: 0x003DCA35
		public IFindSunSpiritGridEmptyT AsIFindSunSpiritGridEmpty()
		{
			return this.As<IFindSunSpiritGridEmptyT>();
		}

		// Token: 0x0601B288 RID: 111240 RVA: 0x003DE83D File Offset: 0x003DCA3D
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridEmpty(IFindSunSpiritGridEmptyT _ifindsunspiritgridempty)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridEmpty,
				Value = _ifindsunspiritgridempty
			};
		}

		// Token: 0x0601B289 RID: 111241 RVA: 0x003DE852 File Offset: 0x003DCA52
		public IFindSunSpiritGridEndFloorT AsIFindSunSpiritGridEndFloor()
		{
			return this.As<IFindSunSpiritGridEndFloorT>();
		}

		// Token: 0x0601B28A RID: 111242 RVA: 0x003DE85A File Offset: 0x003DCA5A
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridEndFloor(IFindSunSpiritGridEndFloorT _ifindsunspiritgridendfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridEndFloor,
				Value = _ifindsunspiritgridendfloor
			};
		}

		// Token: 0x0601B28B RID: 111243 RVA: 0x003DE86F File Offset: 0x003DCA6F
		public IFindSunSpiritGridMutableFloorT AsIFindSunSpiritGridMutableFloor()
		{
			return this.As<IFindSunSpiritGridMutableFloorT>();
		}

		// Token: 0x0601B28C RID: 111244 RVA: 0x003DE877 File Offset: 0x003DCA77
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridMutableFloor(IFindSunSpiritGridMutableFloorT _ifindsunspiritgridmutablefloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridMutableFloor,
				Value = _ifindsunspiritgridmutablefloor
			};
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x003DE88C File Offset: 0x003DCA8C
		public IFindSunSpiritGridNormalFloorT AsIFindSunSpiritGridNormalFloor()
		{
			return this.As<IFindSunSpiritGridNormalFloorT>();
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x003DE894 File Offset: 0x003DCA94
		public static TFindSunSpiritGridUnion FromIFindSunSpiritGridNormalFloor(IFindSunSpiritGridNormalFloorT _ifindsunspiritgridnormalfloor)
		{
			return new TFindSunSpiritGridUnion
			{
				Type = TFindSunSpiritGrid.IFindSunSpiritGridNormalFloor,
				Value = _ifindsunspiritgridnormalfloor
			};
		}

		// Token: 0x0601B28F RID: 111247 RVA: 0x003DE8AC File Offset: 0x003DCAAC
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
