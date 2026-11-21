using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDB RID: 4059
	public struct PhantomRarity : IFlatbufferObject
	{
		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600B023 RID: 45091 RVA: 0x002D3560 File Offset: 0x002D1760
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x002D356D File Offset: 0x002D176D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x002D3574 File Offset: 0x002D1774
		public static PhantomRarity GetRootAsPhantomRarity(ByteBuffer _bb)
		{
			return PhantomRarity.GetRootAsPhantomRarity(_bb, default(PhantomRarity));
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x002D3590 File Offset: 0x002D1790
		public static PhantomRarity GetRootAsPhantomRarity(ByteBuffer _bb, PhantomRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x002D35AD File Offset: 0x002D17AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x002D35BC File Offset: 0x002D17BC
		public PhantomRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600B029 RID: 45097 RVA: 0x002D35CC File Offset: 0x002D17CC
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

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600B02A RID: 45098 RVA: 0x002D3608 File Offset: 0x002D1808
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

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x002D3644 File Offset: 0x002D1844
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

		// Token: 0x0600B02C RID: 45100 RVA: 0x002D367B File Offset: 0x002D187B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x002D368A File Offset: 0x002D188A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x002D36A4 File Offset: 0x002D18A4
		public DicIntInt? PolishCost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x002D3708 File Offset: 0x002D1908
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

		// Token: 0x0600B030 RID: 45104 RVA: 0x002D3734 File Offset: 0x002D1934
		[NullableContext(1)]
		public Dictionary<int, int> PolishCost()
		{
			return this.PolishCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B031 RID: 45105 RVA: 0x002D378A File Offset: 0x002D198A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PolishCostIter()
		{
			PhantomRarity.<PolishCostIter>d__20 <PolishCostIter>d__ = new PhantomRarity.<PolishCostIter>d__20(-2);
			<PolishCostIter>d__.<>3__<>4__this = this;
			return <PolishCostIter>d__;
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x002D37A0 File Offset: 0x002D19A0
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

		// Token: 0x0600B033 RID: 45107 RVA: 0x002D37D4 File Offset: 0x002D19D4
		private void EnsurePolishCostCacheIfNeeded()
		{
			if (this.PolishCostCache != null)
			{
				return;
			}
			this.PolishCostCache = this.PolishCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B034 RID: 45108 RVA: 0x002D383A File Offset: 0x002D1A3A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPolishCostFrozenDict()
		{
			this.EnsurePolishCostCacheIfNeeded();
			return this.PolishCostCache;
		}

		// Token: 0x040055A1 RID: 21921
		private Table __p;

		// Token: 0x040055A2 RID: 21922
		[Nullable(2)]
		private FrozenDictionary<int, int> PolishCostCache;
	}
}
