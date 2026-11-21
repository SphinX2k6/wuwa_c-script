using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F71 RID: 16241
	public class TWoodenBoxProliferateSpawnConfigUnion
	{
		// Token: 0x17006DCF RID: 28111
		// (get) Token: 0x060161AF RID: 90543 RVA: 0x0032BFAC File Offset: 0x0032A1AC
		// (set) Token: 0x060161B0 RID: 90544 RVA: 0x0032BFB4 File Offset: 0x0032A1B4
		public TWoodenBoxProliferateSpawnConfig Type { get; set; }

		// Token: 0x17006DD0 RID: 28112
		// (get) Token: 0x060161B1 RID: 90545 RVA: 0x0032BFBD File Offset: 0x0032A1BD
		// (set) Token: 0x060161B2 RID: 90546 RVA: 0x0032BFC5 File Offset: 0x0032A1C5
		public object Value { get; set; }

		// Token: 0x060161B3 RID: 90547 RVA: 0x0032BFCE File Offset: 0x0032A1CE
		public TWoodenBoxProliferateSpawnConfigUnion()
		{
			this.Type = TWoodenBoxProliferateSpawnConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060161B4 RID: 90548 RVA: 0x0032BFE4 File Offset: 0x0032A1E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060161B5 RID: 90549 RVA: 0x0032BFF6 File Offset: 0x0032A1F6
		public IWoodenBoxProliferatePositionListT AsIWoodenBoxProliferatePositionList()
		{
			return this.As<IWoodenBoxProliferatePositionListT>();
		}

		// Token: 0x060161B6 RID: 90550 RVA: 0x0032BFFE File Offset: 0x0032A1FE
		public static TWoodenBoxProliferateSpawnConfigUnion FromIWoodenBoxProliferatePositionList(IWoodenBoxProliferatePositionListT _iwoodenboxproliferatepositionlist)
		{
			return new TWoodenBoxProliferateSpawnConfigUnion
			{
				Type = TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferatePositionList,
				Value = _iwoodenboxproliferatepositionlist
			};
		}

		// Token: 0x060161B7 RID: 90551 RVA: 0x0032C013 File Offset: 0x0032A213
		public IWoodenBoxProliferateRandomInRangeT AsIWoodenBoxProliferateRandomInRange()
		{
			return this.As<IWoodenBoxProliferateRandomInRangeT>();
		}

		// Token: 0x060161B8 RID: 90552 RVA: 0x0032C01B File Offset: 0x0032A21B
		public static TWoodenBoxProliferateSpawnConfigUnion FromIWoodenBoxProliferateRandomInRange(IWoodenBoxProliferateRandomInRangeT _iwoodenboxproliferaterandominrange)
		{
			return new TWoodenBoxProliferateSpawnConfigUnion
			{
				Type = TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferateRandomInRange,
				Value = _iwoodenboxproliferaterandominrange
			};
		}

		// Token: 0x060161B9 RID: 90553 RVA: 0x0032C030 File Offset: 0x0032A230
		public static int Pack(FlatBufferBuilder builder, TWoodenBoxProliferateSpawnConfigUnion _o)
		{
			TWoodenBoxProliferateSpawnConfig type = _o.Type;
			if (type == TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferatePositionList)
			{
				return IWoodenBoxProliferatePositionList.Pack(builder, _o.AsIWoodenBoxProliferatePositionList()).Value;
			}
			if (type != TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferateRandomInRange)
			{
				return 0;
			}
			return IWoodenBoxProliferateRandomInRange.Pack(builder, _o.AsIWoodenBoxProliferateRandomInRange()).Value;
		}
	}
}
