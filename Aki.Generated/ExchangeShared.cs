using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C44 RID: 3140
	public struct ExchangeShared : IFlatbufferObject
	{
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x002264FE File Offset: 0x002246FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x0022650B File Offset: 0x0022470B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x00226514 File Offset: 0x00224714
		public static ExchangeShared GetRootAsExchangeShared(ByteBuffer _bb)
		{
			return ExchangeShared.GetRootAsExchangeShared(_bb, default(ExchangeShared));
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x00226530 File Offset: 0x00224730
		public static ExchangeShared GetRootAsExchangeShared(ByteBuffer _bb, ExchangeShared obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x0022654D File Offset: 0x0022474D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0022655C File Offset: 0x0022475C
		public ExchangeShared __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x0022656C File Offset: 0x0022476C
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

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x002265A8 File Offset: 0x002247A8
		public int MaxCount
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

		// Token: 0x06006AA4 RID: 27300 RVA: 0x002265E4 File Offset: 0x002247E4
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x00226644 File Offset: 0x00224844
		public int CostLength
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

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x00226670 File Offset: 0x00224870
		public int ResetTimeId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x002266B0 File Offset: 0x002248B0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostFrozenDict()缓存字典，遍历请使用CostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00226706 File Offset: 0x00224906
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostIter()
		{
			ExchangeShared.<CostIter>d__18 <CostIter>d__ = new ExchangeShared.<CostIter>d__18(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x0022671C File Offset: 0x0022491C
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00226750 File Offset: 0x00224950
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x002267B6 File Offset: 0x002249B6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostFrozenDict(int key)
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x04004C88 RID: 19592
		private Table __p;

		// Token: 0x04004C89 RID: 19593
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
