using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D55 RID: 3413
	public struct FilterSortConfig : IFlatbufferObject
	{
		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x0024E384 File Offset: 0x0024C584
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x0024E391 File Offset: 0x0024C591
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x0024E398 File Offset: 0x0024C598
		public static FilterSortConfig GetRootAsFilterSortConfig(ByteBuffer _bb)
		{
			return FilterSortConfig.GetRootAsFilterSortConfig(_bb, default(FilterSortConfig));
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x0024E3B4 File Offset: 0x0024C5B4
		public static FilterSortConfig GetRootAsFilterSortConfig(ByteBuffer _bb, FilterSortConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x0024E3D1 File Offset: 0x0024C5D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x0024E3E0 File Offset: 0x0024C5E0
		public FilterSortConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x0024E3F0 File Offset: 0x0024C5F0
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

		// Token: 0x0600748B RID: 29835 RVA: 0x0024E42C File Offset: 0x0024C62C
		public int SaveGroupId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x0024E46C File Offset: 0x0024C66C
		public int SaveGroupIdLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x0024E497 File Offset: 0x0024C697
		public Span<int> GetSaveGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x0024E4A6 File Offset: 0x0024C6A6
		public int[] GetSaveGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600748F RID: 29839 RVA: 0x0024E4C0 File Offset: 0x0024C6C0
		public int SaveMode
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

		// Token: 0x06007490 RID: 29840 RVA: 0x0024E4FC File Offset: 0x0024C6FC
		[NullableContext(1)]
		public int[] SaveGroupId()
		{
			return this.GetSaveGroupIdArray();
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x0024E504 File Offset: 0x0024C704
		[NullableContext(1)]
		public IEnumerable<int> SaveGroupIdIter()
		{
			FilterSortConfig.<SaveGroupIdIter>d__18 <SaveGroupIdIter>d__ = new FilterSortConfig.<SaveGroupIdIter>d__18(-2);
			<SaveGroupIdIter>d__.<>3__<>4__this = this;
			return <SaveGroupIdIter>d__;
		}

		// Token: 0x040052A0 RID: 21152
		private Table __p;
	}
}
