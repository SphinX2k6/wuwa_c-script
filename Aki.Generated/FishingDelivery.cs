using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5F RID: 3423
	public struct FishingDelivery : IFlatbufferObject
	{
		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x0024F421 File Offset: 0x0024D621
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x0024F42E File Offset: 0x0024D62E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x0024F438 File Offset: 0x0024D638
		public static FishingDelivery GetRootAsFishingDelivery(ByteBuffer _bb)
		{
			return FishingDelivery.GetRootAsFishingDelivery(_bb, default(FishingDelivery));
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x0024F454 File Offset: 0x0024D654
		public static FishingDelivery GetRootAsFishingDelivery(ByteBuffer _bb, FishingDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x0024F471 File Offset: 0x0024D671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x0024F480 File Offset: 0x0024D680
		public FishingDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x0024F490 File Offset: 0x0024D690
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

		// Token: 0x06007508 RID: 29960 RVA: 0x0024F4CC File Offset: 0x0024D6CC
		public DicIntIntArray? NeedItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x0024F52C File Offset: 0x0024D72C
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

		// Token: 0x0600750A RID: 29962 RVA: 0x0024F558 File Offset: 0x0024D758
		[NullableContext(1)]
		public Dictionary<int, IntArray> NeedItems()
		{
			return this.NeedItemsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x0024F5AE File Offset: 0x0024D7AE
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> NeedItemsIter()
		{
			FishingDelivery.<NeedItemsIter>d__14 <NeedItemsIter>d__ = new FishingDelivery.<NeedItemsIter>d__14(-2);
			<NeedItemsIter>d__.<>3__<>4__this = this;
			return <NeedItemsIter>d__;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x0024F5C4 File Offset: 0x0024D7C4
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

		// Token: 0x0600750D RID: 29965 RVA: 0x0024F5F8 File Offset: 0x0024D7F8
		private void EnsureNeedItemsCacheIfNeeded()
		{
			if (this.NeedItemsCache != null)
			{
				return;
			}
			this.NeedItemsCache = this.NeedItemsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x0024F65E File Offset: 0x0024D85E
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetNeedItemsFrozenDict()
		{
			this.EnsureNeedItemsCacheIfNeeded();
			return this.NeedItemsCache;
		}

		// Token: 0x040052AA RID: 21162
		private Table __p;

		// Token: 0x040052AB RID: 21163
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> NeedItemsCache;
	}
}
