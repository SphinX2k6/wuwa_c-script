using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B2 RID: 4530
	public struct CostConfig : IFlatbufferObject
	{
		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x00346ED3 File Offset: 0x003450D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x00346EE0 File Offset: 0x003450E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x00346EE8 File Offset: 0x003450E8
		public static CostConfig GetRootAsCostConfig(ByteBuffer _bb)
		{
			return CostConfig.GetRootAsCostConfig(_bb, default(CostConfig));
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x00346F04 File Offset: 0x00345104
		public static CostConfig GetRootAsCostConfig(ByteBuffer _bb, CostConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x00346F21 File Offset: 0x00345121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9D9 RID: 59865 RVA: 0x00346F30 File Offset: 0x00345130
		public CostConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x00346F40 File Offset: 0x00345140
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x00346FA0 File Offset: 0x003451A0
		public int CostLength
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

		// Token: 0x0600E9DC RID: 59868 RVA: 0x00346FCC File Offset: 0x003451CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostFrozenDict()缓存字典，遍历请使用CostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E9DD RID: 59869 RVA: 0x00347022 File Offset: 0x00345222
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostIter()
		{
			CostConfig.<CostIter>d__12 <CostIter>d__ = new CostConfig.<CostIter>d__12(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600E9DE RID: 59870 RVA: 0x00347038 File Offset: 0x00345238
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

		// Token: 0x0600E9DF RID: 59871 RVA: 0x0034706C File Offset: 0x0034526C
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E9E0 RID: 59872 RVA: 0x003470D2 File Offset: 0x003452D2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostFrozenDict(int key)
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x040052FF RID: 21247
		private Table __p;

		// Token: 0x04005300 RID: 21248
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
