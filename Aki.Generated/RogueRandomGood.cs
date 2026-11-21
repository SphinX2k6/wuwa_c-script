using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001310 RID: 4880
	public struct RogueRandomGood : IFlatbufferObject
	{
		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x00374070 File Offset: 0x00372270
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F883 RID: 63619 RVA: 0x0037407D File Offset: 0x0037227D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F884 RID: 63620 RVA: 0x00374084 File Offset: 0x00372284
		public static RogueRandomGood GetRootAsRogueRandomGood(ByteBuffer _bb)
		{
			return RogueRandomGood.GetRootAsRogueRandomGood(_bb, default(RogueRandomGood));
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x003740A0 File Offset: 0x003722A0
		public static RogueRandomGood GetRootAsRogueRandomGood(ByteBuffer _bb, RogueRandomGood obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F886 RID: 63622 RVA: 0x003740BD File Offset: 0x003722BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x003740CC File Offset: 0x003722CC
		public RogueRandomGood __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x003740DC File Offset: 0x003722DC
		public DicStringInt? GoodsPoolWeight(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0600F889 RID: 63625 RVA: 0x0037413C File Offset: 0x0037233C
		public int GoodsPoolWeightLength
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

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0600F88A RID: 63626 RVA: 0x00374168 File Offset: 0x00372368
		public int Discount
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

		// Token: 0x0600F88B RID: 63627 RVA: 0x003741A4 File Offset: 0x003723A4
		[NullableContext(1)]
		public Dictionary<string, int> GoodsPoolWeight()
		{
			return this.GoodsPoolWeightIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x003741FA File Offset: 0x003723FA
		[NullableContext(1)]
		public IEnumerable<DicStringInt> GoodsPoolWeightIter()
		{
			RogueRandomGood.<GoodsPoolWeightIter>d__14 <GoodsPoolWeightIter>d__ = new RogueRandomGood.<GoodsPoolWeightIter>d__14(-2);
			<GoodsPoolWeightIter>d__.<>3__<>4__this = this;
			return <GoodsPoolWeightIter>d__;
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x00374210 File Offset: 0x00372410
		[NullableContext(1)]
		public int? GetGoodsPoolWeight(string key)
		{
			this.EnsureGoodsPoolWeightCacheIfNeeded();
			int value;
			if (!this.GoodsPoolWeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x00374244 File Offset: 0x00372444
		private void EnsureGoodsPoolWeightCacheIfNeeded()
		{
			if (this.GoodsPoolWeightCache != null)
			{
				return;
			}
			this.GoodsPoolWeightCache = this.GoodsPoolWeightIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x003742AA File Offset: 0x003724AA
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetGoodsPoolWeightFrozenDict()
		{
			this.EnsureGoodsPoolWeightCacheIfNeeded();
			return this.GoodsPoolWeightCache;
		}

		// Token: 0x0400598B RID: 22923
		private Table __p;

		// Token: 0x0400598C RID: 22924
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> GoodsPoolWeightCache;
	}
}
