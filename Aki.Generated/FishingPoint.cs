using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D69 RID: 3433
	public struct FishingPoint : IFlatbufferObject
	{
		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060075DB RID: 30171 RVA: 0x002514D0 File Offset: 0x0024F6D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x002514DD File Offset: 0x0024F6DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x002514E4 File Offset: 0x0024F6E4
		public static FishingPoint GetRootAsFishingPoint(ByteBuffer _bb)
		{
			return FishingPoint.GetRootAsFishingPoint(_bb, default(FishingPoint));
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00251500 File Offset: 0x0024F700
		public static FishingPoint GetRootAsFishingPoint(ByteBuffer _bb, FishingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x0025151D File Offset: 0x0024F71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x0025152C File Offset: 0x0024F72C
		public FishingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060075E1 RID: 30177 RVA: 0x0025153C File Offset: 0x0024F73C
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

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x00251578 File Offset: 0x0024F778
		public int EntityConfigId
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

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060075E3 RID: 30179 RVA: 0x002515B4 File Offset: 0x0024F7B4
		public int ShowItem
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060075E4 RID: 30180 RVA: 0x002515F0 File Offset: 0x0024F7F0
		public int GamePlayId
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060075E5 RID: 30181 RVA: 0x00251630 File Offset: 0x0024F830
		public int UnlockTech
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060075E6 RID: 30182 RVA: 0x00251670 File Offset: 0x0024F870
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060075E7 RID: 30183 RVA: 0x002516B0 File Offset: 0x0024F8B0
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x002516F0 File Offset: 0x0024F8F0
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060075E9 RID: 30185 RVA: 0x00251754 File Offset: 0x0024F954
		public int RewardItemLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00251780 File Offset: 0x0024F980
		public DicIntInt? OutGrowth(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x002517E4 File Offset: 0x0024F9E4
		public int OutGrowthLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060075EC RID: 30188 RVA: 0x00251810 File Offset: 0x0024FA10
		public int DoubleRate
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060075ED RID: 30189 RVA: 0x00251850 File Offset: 0x0024FA50
		public int Count
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060075EE RID: 30190 RVA: 0x00251890 File Offset: 0x0024FA90
		public int RefreshTime
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x002518D0 File Offset: 0x0024FAD0
		[NullableContext(1)]
		public Dictionary<int, int> OutGrowth()
		{
			return this.OutGrowthIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00251926 File Offset: 0x0024FB26
		[NullableContext(1)]
		public IEnumerable<DicIntInt> OutGrowthIter()
		{
			FishingPoint.<OutGrowthIter>d__35 <OutGrowthIter>d__ = new FishingPoint.<OutGrowthIter>d__35(-2);
			<OutGrowthIter>d__.<>3__<>4__this = this;
			return <OutGrowthIter>d__;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x0025193C File Offset: 0x0024FB3C
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00251992 File Offset: 0x0024FB92
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			FishingPoint.<RewardItemIter>d__37 <RewardItemIter>d__ = new FishingPoint.<RewardItemIter>d__37(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x002519A8 File Offset: 0x0024FBA8
		public int? GetOutGrowth(int key)
		{
			this.EnsureOutGrowthCacheIfNeeded();
			int value;
			if (!this.OutGrowthCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x002519DC File Offset: 0x0024FBDC
		public int? GetRewardItem(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			int value;
			if (!this.RewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00251A10 File Offset: 0x0024FC10
		private void EnsureOutGrowthCacheIfNeeded()
		{
			if (this.OutGrowthCache != null)
			{
				return;
			}
			this.OutGrowthCache = this.OutGrowthIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00251A78 File Offset: 0x0024FC78
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00251ADE File Offset: 0x0024FCDE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetOutGrowthFrozenDict()
		{
			this.EnsureOutGrowthCacheIfNeeded();
			return this.OutGrowthCache;
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00251AEC File Offset: 0x0024FCEC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x040052B9 RID: 21177
		private Table __p;

		// Token: 0x040052BA RID: 21178
		[Nullable(2)]
		private FrozenDictionary<int, int> OutGrowthCache;

		// Token: 0x040052BB RID: 21179
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}
