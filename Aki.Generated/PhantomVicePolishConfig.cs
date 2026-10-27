using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFC RID: 3836
	public struct PhantomVicePolishConfig : IFlatbufferObject
	{
		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x002B7ACD File Offset: 0x002B5CCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x002B7ADA File Offset: 0x002B5CDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x002B7AE4 File Offset: 0x002B5CE4
		public static PhantomVicePolishConfig GetRootAsPhantomVicePolishConfig(ByteBuffer _bb)
		{
			return PhantomVicePolishConfig.GetRootAsPhantomVicePolishConfig(_bb, default(PhantomVicePolishConfig));
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x002B7B00 File Offset: 0x002B5D00
		public static PhantomVicePolishConfig GetRootAsPhantomVicePolishConfig(ByteBuffer _bb, PhantomVicePolishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x002B7B1D File Offset: 0x002B5D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x002B7B2C File Offset: 0x002B5D2C
		public PhantomVicePolishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x002B7B3C File Offset: 0x002B5D3C
		public int PropCount
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

		// Token: 0x0600AA90 RID: 43664 RVA: 0x002B7B78 File Offset: 0x002B5D78
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x002B7BD8 File Offset: 0x002B5DD8
		public int CostLength
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

		// Token: 0x0600AA92 RID: 43666 RVA: 0x002B7C04 File Offset: 0x002B5E04
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostFrozenDict()缓存字典，遍历请使用CostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x002B7C5A File Offset: 0x002B5E5A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostIter()
		{
			PhantomVicePolishConfig.<CostIter>d__14 <CostIter>d__ = new PhantomVicePolishConfig.<CostIter>d__14(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x002B7C70 File Offset: 0x002B5E70
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

		// Token: 0x0600AA95 RID: 43669 RVA: 0x002B7CA4 File Offset: 0x002B5EA4
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x002B7D0A File Offset: 0x002B5F0A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostFrozenDict(int key)
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x04004FC3 RID: 20419
		private Table __p;

		// Token: 0x04004FC4 RID: 20420
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
