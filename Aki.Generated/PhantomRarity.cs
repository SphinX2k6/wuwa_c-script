using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF6 RID: 3830
	public struct PhantomRarity : IFlatbufferObject
	{
		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600AA02 RID: 43522 RVA: 0x002B6704 File Offset: 0x002B4904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x002B6711 File Offset: 0x002B4911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x002B6718 File Offset: 0x002B4918
		public static PhantomRarity GetRootAsPhantomRarity(ByteBuffer _bb)
		{
			return PhantomRarity.GetRootAsPhantomRarity(_bb, default(PhantomRarity));
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x002B6734 File Offset: 0x002B4934
		public static PhantomRarity GetRootAsPhantomRarity(ByteBuffer _bb, PhantomRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x002B6751 File Offset: 0x002B4951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x002B6760 File Offset: 0x002B4960
		public PhantomRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x002B6770 File Offset: 0x002B4970
		public int Rare
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

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x002B67AC File Offset: 0x002B49AC
		public int Cost
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

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x0600AA0A RID: 43530 RVA: 0x002B67E8 File Offset: 0x002B49E8
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x002B681F File Offset: 0x002B4A1F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x002B682E File Offset: 0x002B4A2E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x002B6848 File Offset: 0x002B4A48
		public DicIntInt? PolishCost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x0600AA0E RID: 43534 RVA: 0x002B68AC File Offset: 0x002B4AAC
		public int PolishCostLength
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

		// Token: 0x0600AA0F RID: 43535 RVA: 0x002B68D8 File Offset: 0x002B4AD8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PolishCostFrozenDict()缓存字典，遍历请使用PolishCostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PolishCost()
		{
			return this.PolishCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002B692E File Offset: 0x002B4B2E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PolishCostIter()
		{
			PhantomRarity.<PolishCostIter>d__20 <PolishCostIter>d__ = new PhantomRarity.<PolishCostIter>d__20(-2);
			<PolishCostIter>d__.<>3__<>4__this = this;
			return <PolishCostIter>d__;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x002B6944 File Offset: 0x002B4B44
		public int? GetPolishCost(int key)
		{
			this.EnsurePolishCostCacheIfNeeded();
			int value;
			if (!this.PolishCostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x002B6978 File Offset: 0x002B4B78
		private void EnsurePolishCostCacheIfNeeded()
		{
			if (this.PolishCostCache != null)
			{
				return;
			}
			this.PolishCostCache = this.PolishCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x002B69DE File Offset: 0x002B4BDE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPolishCostFrozenDict(int key)
		{
			this.EnsurePolishCostCacheIfNeeded();
			return this.PolishCostCache;
		}

		// Token: 0x04004FBC RID: 20412
		private Table __p;

		// Token: 0x04004FBD RID: 20413
		[Nullable(2)]
		private FrozenDictionary<int, int> PolishCostCache;
	}
}
