using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE1 RID: 4065
	public struct PhantomVicePolishConfig : IFlatbufferObject
	{
		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x002D486E File Offset: 0x002D2A6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0AB RID: 45227 RVA: 0x002D487B File Offset: 0x002D2A7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x002D4884 File Offset: 0x002D2A84
		public static PhantomVicePolishConfig GetRootAsPhantomVicePolishConfig(ByteBuffer _bb)
		{
			return PhantomVicePolishConfig.GetRootAsPhantomVicePolishConfig(_bb, default(PhantomVicePolishConfig));
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x002D48A0 File Offset: 0x002D2AA0
		public static PhantomVicePolishConfig GetRootAsPhantomVicePolishConfig(ByteBuffer _bb, PhantomVicePolishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x002D48BD File Offset: 0x002D2ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x002D48CC File Offset: 0x002D2ACC
		public PhantomVicePolishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x002D48DC File Offset: 0x002D2ADC
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

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x002D4918 File Offset: 0x002D2B18
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x002D4978 File Offset: 0x002D2B78
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

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x002D49A4 File Offset: 0x002D2BA4
		[NullableContext(1)]
		public Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B0B4 RID: 45236 RVA: 0x002D49FA File Offset: 0x002D2BFA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostIter()
		{
			PhantomVicePolishConfig.<CostIter>d__14 <CostIter>d__ = new PhantomVicePolishConfig.<CostIter>d__14(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x002D4A10 File Offset: 0x002D2C10
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

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x002D4A44 File Offset: 0x002D2C44
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x002D4AAA File Offset: 0x002D2CAA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostFrozenDict()
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x040055A8 RID: 21928
		private Table __p;

		// Token: 0x040055A9 RID: 21929
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;
	}
}
