using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7B RID: 3195
	public struct FishingDelivery : IFlatbufferObject
	{
		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x00230255 File Offset: 0x0022E455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x00230262 File Offset: 0x0022E462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x0023026C File Offset: 0x0022E46C
		public static FishingDelivery GetRootAsFishingDelivery(ByteBuffer _bb)
		{
			return FishingDelivery.GetRootAsFishingDelivery(_bb, default(FishingDelivery));
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x00230288 File Offset: 0x0022E488
		public static FishingDelivery GetRootAsFishingDelivery(ByteBuffer _bb, FishingDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x002302A5 File Offset: 0x0022E4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x002302B4 File Offset: 0x0022E4B4
		public FishingDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06006EFC RID: 28412 RVA: 0x002302C4 File Offset: 0x0022E4C4
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

		// Token: 0x06006EFD RID: 28413 RVA: 0x00230300 File Offset: 0x0022E500
		public DicIntIntArray? NeedItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x00230360 File Offset: 0x0022E560
		public int NeedItemsLength
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

		// Token: 0x06006EFF RID: 28415 RVA: 0x0023038C File Offset: 0x0022E58C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用NeedItemsFrozenDict()缓存字典，遍历请使用NeedItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> NeedItems()
		{
			return this.NeedItemsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x002303E2 File Offset: 0x0022E5E2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> NeedItemsIter()
		{
			FishingDelivery.<NeedItemsIter>d__14 <NeedItemsIter>d__ = new FishingDelivery.<NeedItemsIter>d__14(-2);
			<NeedItemsIter>d__.<>3__<>4__this = this;
			return <NeedItemsIter>d__;
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x002303F8 File Offset: 0x0022E5F8
		public IntArray? GetNeedItems(int key)
		{
			this.EnsureNeedItemsCacheIfNeeded();
			IntArray value;
			if (!this.NeedItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x0023042C File Offset: 0x0022E62C
		private void EnsureNeedItemsCacheIfNeeded()
		{
			if (this.NeedItemsCache != null)
			{
				return;
			}
			this.NeedItemsCache = this.NeedItemsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00230492 File Offset: 0x0022E692
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetNeedItemsFrozenDict(int key)
		{
			this.EnsureNeedItemsCacheIfNeeded();
			return this.NeedItemsCache;
		}

		// Token: 0x04004CC6 RID: 19654
		private Table __p;

		// Token: 0x04004CC7 RID: 19655
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> NeedItemsCache;
	}
}
