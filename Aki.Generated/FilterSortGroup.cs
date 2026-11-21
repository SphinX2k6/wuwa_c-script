using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D56 RID: 3414
	public struct FilterSortGroup : IFlatbufferObject
	{
		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x0024E519 File Offset: 0x0024C719
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x0024E526 File Offset: 0x0024C726
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x0024E530 File Offset: 0x0024C730
		public static FilterSortGroup GetRootAsFilterSortGroup(ByteBuffer _bb)
		{
			return FilterSortGroup.GetRootAsFilterSortGroup(_bb, default(FilterSortGroup));
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x0024E54C File Offset: 0x0024C74C
		public static FilterSortGroup GetRootAsFilterSortGroup(ByteBuffer _bb, FilterSortGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x0024E569 File Offset: 0x0024C769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x0024E578 File Offset: 0x0024C778
		public FilterSortGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x0024E588 File Offset: 0x0024C788
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

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06007499 RID: 29849 RVA: 0x0024E5C4 File Offset: 0x0024C7C4
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

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x0024E600 File Offset: 0x0024C800
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

		// Token: 0x040052A1 RID: 21153
		private Table __p;
	}
}
