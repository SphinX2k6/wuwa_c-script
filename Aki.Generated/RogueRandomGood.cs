using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D9 RID: 4569
	public struct RogueRandomGood : IFlatbufferObject
	{
		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0600EB09 RID: 60169 RVA: 0x00349380 File Offset: 0x00347580
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x0034938D File Offset: 0x0034758D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x00349394 File Offset: 0x00347594
		public static RogueRandomGood GetRootAsRogueRandomGood(ByteBuffer _bb)
		{
			return RogueRandomGood.GetRootAsRogueRandomGood(_bb, default(RogueRandomGood));
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x003493B0 File Offset: 0x003475B0
		public static RogueRandomGood GetRootAsRogueRandomGood(ByteBuffer _bb, RogueRandomGood obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x003493CD File Offset: 0x003475CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x003493DC File Offset: 0x003475DC
		public RogueRandomGood __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x003493EC File Offset: 0x003475EC
		public DicStringInt? GoodsPoolWeight(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0600EB10 RID: 60176 RVA: 0x0034944C File Offset: 0x0034764C
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

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0600EB11 RID: 60177 RVA: 0x00349478 File Offset: 0x00347678
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

		// Token: 0x0600EB12 RID: 60178 RVA: 0x003494B4 File Offset: 0x003476B4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GoodsPoolWeightFrozenDict()缓存字典，遍历请使用GoodsPoolWeightIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> GoodsPoolWeight()
		{
			return this.GoodsPoolWeightIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x0034950A File Offset: 0x0034770A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> GoodsPoolWeightIter()
		{
			RogueRandomGood.<GoodsPoolWeightIter>d__14 <GoodsPoolWeightIter>d__ = new RogueRandomGood.<GoodsPoolWeightIter>d__14(-2);
			<GoodsPoolWeightIter>d__.<>3__<>4__this = this;
			return <GoodsPoolWeightIter>d__;
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x00349520 File Offset: 0x00347720
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

		// Token: 0x0600EB15 RID: 60181 RVA: 0x00349554 File Offset: 0x00347754
		private void EnsureGoodsPoolWeightCacheIfNeeded()
		{
			if (this.GoodsPoolWeightCache != null)
			{
				return;
			}
			this.GoodsPoolWeightCache = this.GoodsPoolWeightIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x003495BA File Offset: 0x003477BA
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetGoodsPoolWeightFrozenDict(string key)
		{
			this.EnsureGoodsPoolWeightCacheIfNeeded();
			return this.GoodsPoolWeightCache;
		}

		// Token: 0x04005347 RID: 21319
		private Table __p;

		// Token: 0x04005348 RID: 21320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> GoodsPoolWeightCache;
	}
}
