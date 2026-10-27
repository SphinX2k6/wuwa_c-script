using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C72 RID: 3186
	public struct FilterSortGroup : IFlatbufferObject
	{
		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x0022F331 File Offset: 0x0022D531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x0022F33E File Offset: 0x0022D53E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x0022F348 File Offset: 0x0022D548
		public static FilterSortGroup GetRootAsFilterSortGroup(ByteBuffer _bb)
		{
			return FilterSortGroup.GetRootAsFilterSortGroup(_bb, default(FilterSortGroup));
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x0022F364 File Offset: 0x0022D564
		public static FilterSortGroup GetRootAsFilterSortGroup(ByteBuffer _bb, FilterSortGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x0022F381 File Offset: 0x0022D581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x0022F390 File Offset: 0x0022D590
		public FilterSortGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x0022F3A0 File Offset: 0x0022D5A0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06006E8E RID: 28302 RVA: 0x0022F3DC File Offset: 0x0022D5DC
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x0022F418 File Offset: 0x0022D618
		public int FilterId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CBD RID: 19645
		private Table __p;
	}
}
