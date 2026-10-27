using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9D RID: 2973
	public struct CookFixTool : IFlatbufferObject
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600592C RID: 22828 RVA: 0x001FF224 File Offset: 0x001FD424
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x001FF231 File Offset: 0x001FD431
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x001FF238 File Offset: 0x001FD438
		public static CookFixTool GetRootAsCookFixTool(ByteBuffer _bb)
		{
			return CookFixTool.GetRootAsCookFixTool(_bb, default(CookFixTool));
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x001FF254 File Offset: 0x001FD454
		public static CookFixTool GetRootAsCookFixTool(ByteBuffer _bb, CookFixTool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x001FF271 File Offset: 0x001FD471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x001FF280 File Offset: 0x001FD480
		public CookFixTool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06005932 RID: 22834 RVA: 0x001FF290 File Offset: 0x001FD490
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x001FF2CC File Offset: 0x001FD4CC
		public string Description
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x001FF303 File Offset: 0x001FD503
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x001FF312 File Offset: 0x001FD512
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x001FF32C File Offset: 0x001FD52C
		public DicIntInt? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x001FF38C File Offset: 0x001FD58C
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x001FF3B8 File Offset: 0x001FD5B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ItemsFrozenDict()缓存字典，遍历请使用ItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Items()
		{
			return this.ItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x001FF40E File Offset: 0x001FD60E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ItemsIter()
		{
			CookFixTool.<ItemsIter>d__18 <ItemsIter>d__ = new CookFixTool.<ItemsIter>d__18(-2);
			<ItemsIter>d__.<>3__<>4__this = this;
			return <ItemsIter>d__;
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x001FF424 File Offset: 0x001FD624
		public int? GetItems(int key)
		{
			this.EnsureItemsCacheIfNeeded();
			int value;
			if (!this.ItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x001FF458 File Offset: 0x001FD658
		private void EnsureItemsCacheIfNeeded()
		{
			if (this.ItemsCache != null)
			{
				return;
			}
			this.ItemsCache = this.ItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x001FF4BE File Offset: 0x001FD6BE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetItemsFrozenDict(int key)
		{
			this.EnsureItemsCacheIfNeeded();
			return this.ItemsCache;
		}

		// Token: 0x04004BBE RID: 19390
		private Table __p;

		// Token: 0x04004BBF RID: 19391
		[Nullable(2)]
		private FrozenDictionary<int, int> ItemsCache;
	}
}
