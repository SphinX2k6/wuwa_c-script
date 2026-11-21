using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D27 RID: 3367
	public struct ExchangeShared : IFlatbufferObject
	{
		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600709E RID: 28830 RVA: 0x00245846 File Offset: 0x00243A46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x00245853 File Offset: 0x00243A53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x0024585C File Offset: 0x00243A5C
		public static ExchangeShared GetRootAsExchangeShared(ByteBuffer _bb)
		{
			return ExchangeShared.GetRootAsExchangeShared(_bb, default(ExchangeShared));
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x00245878 File Offset: 0x00243A78
		public static ExchangeShared GetRootAsExchangeShared(ByteBuffer _bb, ExchangeShared obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x00245895 File Offset: 0x00243A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x002458A4 File Offset: 0x00243AA4
		public ExchangeShared __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x002458B4 File Offset: 0x00243AB4
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x002458F0 File Offset: 0x00243AF0
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

		// Token: 0x060070A6 RID: 28838 RVA: 0x0024592C File Offset: 0x00243B2C
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x0024598C File Offset: 0x00243B8C
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

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x002459B8 File Offset: 0x00243BB8
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

		// Token: 0x060070A9 RID: 28841 RVA: 0x002459F8 File Offset: 0x00243BF8
		[NullableContext(1)]
		public Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x00245A4E File Offset: 0x00243C4E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostIter()
		{
			ExchangeShared.<CostIter>d__18 <CostIter>d__ = new ExchangeShared.<CostIter>d__18(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x00245A64 File Offset: 0x00243C64
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

		// Token: 0x060070AC RID: 28844 RVA: 0x00245A98 File Offset: 0x00243C98
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00245AFE File Offset: 0x00243CFE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostFrozenDict()
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x0400526B RID: 21099
		private Table __p;

		// Token: 0x0400526C RID: 21100
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
