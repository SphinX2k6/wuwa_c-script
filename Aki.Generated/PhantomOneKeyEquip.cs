using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD8 RID: 4056
	public struct PhantomOneKeyEquip : IFlatbufferObject
	{
		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600AFE2 RID: 45026 RVA: 0x002D2B1E File Offset: 0x002D0D1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x002D2B2B File Offset: 0x002D0D2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x002D2B34 File Offset: 0x002D0D34
		public static PhantomOneKeyEquip GetRootAsPhantomOneKeyEquip(ByteBuffer _bb)
		{
			return PhantomOneKeyEquip.GetRootAsPhantomOneKeyEquip(_bb, default(PhantomOneKeyEquip));
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x002D2B50 File Offset: 0x002D0D50
		public static PhantomOneKeyEquip GetRootAsPhantomOneKeyEquip(ByteBuffer _bb, PhantomOneKeyEquip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x002D2B6D File Offset: 0x002D0D6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x002D2B7C File Offset: 0x002D0D7C
		public PhantomOneKeyEquip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x002D2B8C File Offset: 0x002D0D8C
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

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x002D2BC8 File Offset: 0x002D0DC8
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x002D2C08 File Offset: 0x002D0E08
		public int LevelRangeLength
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

		// Token: 0x0600AFEB RID: 45035 RVA: 0x002D2C33 File Offset: 0x002D0E33
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x002D2C42 File Offset: 0x002D0E42
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600AFED RID: 45037 RVA: 0x002D2C5C File Offset: 0x002D0E5C
		public int FirstVisionCost
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x0600AFEE RID: 45038 RVA: 0x002D2C98 File Offset: 0x002D0E98
		public bool FirstVisionSpecial
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x002D2CD8 File Offset: 0x002D0ED8
		public DicIntInt? SpecialPlan(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x0600AFF0 RID: 45040 RVA: 0x002D2D3C File Offset: 0x002D0F3C
		public int SpecialPlanLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x002D2D68 File Offset: 0x002D0F68
		public DicIntInt? NormalPlan(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600AFF2 RID: 45042 RVA: 0x002D2DCC File Offset: 0x002D0FCC
		public int NormalPlanLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x002D2DF8 File Offset: 0x002D0FF8
		[NullableContext(1)]
		public int[] LevelRange()
		{
			return this.GetLevelRangeArray();
		}

		// Token: 0x0600AFF4 RID: 45044 RVA: 0x002D2E00 File Offset: 0x002D1000
		[NullableContext(1)]
		public IEnumerable<int> LevelRangeIter()
		{
			PhantomOneKeyEquip.<LevelRangeIter>d__26 <LevelRangeIter>d__ = new PhantomOneKeyEquip.<LevelRangeIter>d__26(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x0600AFF5 RID: 45045 RVA: 0x002D2E18 File Offset: 0x002D1018
		[NullableContext(1)]
		public Dictionary<int, int> NormalPlan()
		{
			return this.NormalPlanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x002D2E6E File Offset: 0x002D106E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> NormalPlanIter()
		{
			PhantomOneKeyEquip.<NormalPlanIter>d__28 <NormalPlanIter>d__ = new PhantomOneKeyEquip.<NormalPlanIter>d__28(-2);
			<NormalPlanIter>d__.<>3__<>4__this = this;
			return <NormalPlanIter>d__;
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x002D2E84 File Offset: 0x002D1084
		[NullableContext(1)]
		public Dictionary<int, int> SpecialPlan()
		{
			return this.SpecialPlanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x002D2EDA File Offset: 0x002D10DA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpecialPlanIter()
		{
			PhantomOneKeyEquip.<SpecialPlanIter>d__30 <SpecialPlanIter>d__ = new PhantomOneKeyEquip.<SpecialPlanIter>d__30(-2);
			<SpecialPlanIter>d__.<>3__<>4__this = this;
			return <SpecialPlanIter>d__;
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x002D2EF0 File Offset: 0x002D10F0
		public int? GetNormalPlan(int key)
		{
			this.EnsureNormalPlanCacheIfNeeded();
			int value;
			if (!this.NormalPlanCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x002D2F24 File Offset: 0x002D1124
		public int? GetSpecialPlan(int key)
		{
			this.EnsureSpecialPlanCacheIfNeeded();
			int value;
			if (!this.SpecialPlanCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AFFB RID: 45051 RVA: 0x002D2F58 File Offset: 0x002D1158
		private void EnsureNormalPlanCacheIfNeeded()
		{
			if (this.NormalPlanCache != null)
			{
				return;
			}
			this.NormalPlanCache = this.NormalPlanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x002D2FC0 File Offset: 0x002D11C0
		private void EnsureSpecialPlanCacheIfNeeded()
		{
			if (this.SpecialPlanCache != null)
			{
				return;
			}
			this.SpecialPlanCache = this.SpecialPlanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x002D3026 File Offset: 0x002D1226
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetNormalPlanFrozenDict()
		{
			this.EnsureNormalPlanCacheIfNeeded();
			return this.NormalPlanCache;
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x002D3034 File Offset: 0x002D1234
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpecialPlanFrozenDict()
		{
			this.EnsureSpecialPlanCacheIfNeeded();
			return this.SpecialPlanCache;
		}

		// Token: 0x0400559B RID: 21915
		private Table __p;

		// Token: 0x0400559C RID: 21916
		[Nullable(2)]
		private FrozenDictionary<int, int> NormalPlanCache;

		// Token: 0x0400559D RID: 21917
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialPlanCache;
	}
}
