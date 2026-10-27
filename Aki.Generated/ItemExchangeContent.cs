using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7C RID: 3452
	public struct ItemExchangeContent : IFlatbufferObject
	{
		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x00265995 File Offset: 0x00263B95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x002659A2 File Offset: 0x00263BA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x002659AC File Offset: 0x00263BAC
		public static ItemExchangeContent GetRootAsItemExchangeContent(ByteBuffer _bb)
		{
			return ItemExchangeContent.GetRootAsItemExchangeContent(_bb, default(ItemExchangeContent));
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x002659C8 File Offset: 0x00263BC8
		public static ItemExchangeContent GetRootAsItemExchangeContent(ByteBuffer _bb, ItemExchangeContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x002659E5 File Offset: 0x00263BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x002659F4 File Offset: 0x00263BF4
		public ItemExchangeContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06008643 RID: 34371 RVA: 0x00265A04 File Offset: 0x00263C04
		public int ItemId
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

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x00265A40 File Offset: 0x00263C40
		public int Times
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

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06008645 RID: 34373 RVA: 0x00265A7C File Offset: 0x00263C7C
		public int GainCount
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

		// Token: 0x06008646 RID: 34374 RVA: 0x00265AB8 File Offset: 0x00263CB8
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06008647 RID: 34375 RVA: 0x00265B1C File Offset: 0x00263D1C
		public int ConsumeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00265B48 File Offset: 0x00263D48
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x00265B9E File Offset: 0x00263D9E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			ItemExchangeContent.<ConsumeIter>d__18 <ConsumeIter>d__ = new ItemExchangeContent.<ConsumeIter>d__18(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00265BB4 File Offset: 0x00263DB4
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x00265BE8 File Offset: 0x00263DE8
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x00265C4E File Offset: 0x00263E4E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x04004E04 RID: 19972
		private Table __p;

		// Token: 0x04004E05 RID: 19973
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
