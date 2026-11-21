using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001303 RID: 4867
	public struct IntIntMap : IFlatbufferObject
	{
		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0600F805 RID: 63493 RVA: 0x0037311A File Offset: 0x0037131A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F806 RID: 63494 RVA: 0x00373127 File Offset: 0x00371327
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F807 RID: 63495 RVA: 0x00373130 File Offset: 0x00371330
		public static IntIntMap GetRootAsIntIntMap(ByteBuffer _bb)
		{
			return IntIntMap.GetRootAsIntIntMap(_bb, default(IntIntMap));
		}

		// Token: 0x0600F808 RID: 63496 RVA: 0x0037314C File Offset: 0x0037134C
		public static IntIntMap GetRootAsIntIntMap(ByteBuffer _bb, IntIntMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F809 RID: 63497 RVA: 0x00373169 File Offset: 0x00371369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F80A RID: 63498 RVA: 0x00373178 File Offset: 0x00371378
		public IntIntMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F80B RID: 63499 RVA: 0x00373188 File Offset: 0x00371388
		public DicIntInt? MapIntInt(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0600F80C RID: 63500 RVA: 0x003731E8 File Offset: 0x003713E8
		public int MapIntIntLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F80D RID: 63501 RVA: 0x00373214 File Offset: 0x00371414
		[NullableContext(1)]
		public Dictionary<int, int> MapIntInt()
		{
			return this.MapIntIntIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F80E RID: 63502 RVA: 0x0037326A File Offset: 0x0037146A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MapIntIntIter()
		{
			IntIntMap.<MapIntIntIter>d__12 <MapIntIntIter>d__ = new IntIntMap.<MapIntIntIter>d__12(-2);
			<MapIntIntIter>d__.<>3__<>4__this = this;
			return <MapIntIntIter>d__;
		}

		// Token: 0x0600F80F RID: 63503 RVA: 0x00373280 File Offset: 0x00371480
		public int? GetMapIntInt(int key)
		{
			this.EnsureMapIntIntCacheIfNeeded();
			int value;
			if (!this.MapIntIntCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F810 RID: 63504 RVA: 0x003732B4 File Offset: 0x003714B4
		private void EnsureMapIntIntCacheIfNeeded()
		{
			if (this.MapIntIntCache != null)
			{
				return;
			}
			this.MapIntIntCache = this.MapIntIntIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x0037331A File Offset: 0x0037151A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMapIntIntFrozenDict()
		{
			this.EnsureMapIntIntCacheIfNeeded();
			return this.MapIntIntCache;
		}

		// Token: 0x0400597D RID: 22909
		private Table __p;

		// Token: 0x0400597E RID: 22910
		[Nullable(2)]
		private FrozenDictionary<int, int> MapIntIntCache;
	}
}
