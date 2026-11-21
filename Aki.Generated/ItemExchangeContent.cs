using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E61 RID: 3681
	public struct ItemExchangeContent : IFlatbufferObject
	{
		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06008C58 RID: 35928 RVA: 0x00283C26 File Offset: 0x00281E26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00283C33 File Offset: 0x00281E33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00283C3C File Offset: 0x00281E3C
		public static ItemExchangeContent GetRootAsItemExchangeContent(ByteBuffer _bb)
		{
			return ItemExchangeContent.GetRootAsItemExchangeContent(_bb, default(ItemExchangeContent));
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00283C58 File Offset: 0x00281E58
		public static ItemExchangeContent GetRootAsItemExchangeContent(ByteBuffer _bb, ItemExchangeContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x00283C75 File Offset: 0x00281E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x00283C84 File Offset: 0x00281E84
		public ItemExchangeContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06008C5E RID: 35934 RVA: 0x00283C94 File Offset: 0x00281E94
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

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06008C5F RID: 35935 RVA: 0x00283CD0 File Offset: 0x00281ED0
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x00283D0C File Offset: 0x00281F0C
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

		// Token: 0x06008C61 RID: 35937 RVA: 0x00283D48 File Offset: 0x00281F48
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x00283DAC File Offset: 0x00281FAC
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

		// Token: 0x06008C63 RID: 35939 RVA: 0x00283DD8 File Offset: 0x00281FD8
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x00283E2E File Offset: 0x0028202E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			ItemExchangeContent.<ConsumeIter>d__18 <ConsumeIter>d__ = new ItemExchangeContent.<ConsumeIter>d__18(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x00283E44 File Offset: 0x00282044
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

		// Token: 0x06008C66 RID: 35942 RVA: 0x00283E78 File Offset: 0x00282078
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x00283EDE File Offset: 0x002820DE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040053E9 RID: 21481
		private Table __p;

		// Token: 0x040053EA RID: 21482
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
