using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C71 RID: 3185
	public struct FilterSortConfig : IFlatbufferObject
	{
		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06006E79 RID: 28281 RVA: 0x0022F180 File Offset: 0x0022D380
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x0022F18D File Offset: 0x0022D38D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x0022F194 File Offset: 0x0022D394
		public static FilterSortConfig GetRootAsFilterSortConfig(ByteBuffer _bb)
		{
			return FilterSortConfig.GetRootAsFilterSortConfig(_bb, default(FilterSortConfig));
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x0022F1B0 File Offset: 0x0022D3B0
		public static FilterSortConfig GetRootAsFilterSortConfig(ByteBuffer _bb, FilterSortConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x0022F1CD File Offset: 0x0022D3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x0022F1DC File Offset: 0x0022D3DC
		public FilterSortConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x0022F1EC File Offset: 0x0022D3EC
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

		// Token: 0x06006E80 RID: 28288 RVA: 0x0022F228 File Offset: 0x0022D428
		public int SaveGroupId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06006E81 RID: 28289 RVA: 0x0022F268 File Offset: 0x0022D468
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

		// Token: 0x06006E82 RID: 28290 RVA: 0x0022F293 File Offset: 0x0022D493
		public Span<int> GetSaveGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x0022F2A2 File Offset: 0x0022D4A2
		public int[] GetSaveGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x0022F2BC File Offset: 0x0022D4BC
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

		// Token: 0x06006E85 RID: 28293 RVA: 0x0022F2F8 File Offset: 0x0022D4F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SaveGroupIdIter()或GetSaveGroupIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SaveGroupId()
		{
			FilterSortConfig filterSortConfig = this;
			return filterSortConfig.GetSaveGroupIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x0022F31C File Offset: 0x0022D51C
		[NullableContext(1)]
		public readonly IEnumerable<int> SaveGroupIdIter()
		{
			FilterSortConfig.<SaveGroupIdIter>d__18 <SaveGroupIdIter>d__ = new FilterSortConfig.<SaveGroupIdIter>d__18(-2);
			<SaveGroupIdIter>d__.<>3__<>4__this = this;
			return <SaveGroupIdIter>d__;
		}

		// Token: 0x04004CBC RID: 19644
		private Table __p;
	}
}
