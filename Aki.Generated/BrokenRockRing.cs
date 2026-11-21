using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C31 RID: 3121
	public struct BrokenRockRing : IFlatbufferObject
	{
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600559C RID: 21916 RVA: 0x002092D2 File Offset: 0x002074D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x002092DF File Offset: 0x002074DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x002092E8 File Offset: 0x002074E8
		public static BrokenRockRing GetRootAsBrokenRockRing(ByteBuffer _bb)
		{
			return BrokenRockRing.GetRootAsBrokenRockRing(_bb, default(BrokenRockRing));
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00209304 File Offset: 0x00207504
		public static BrokenRockRing GetRootAsBrokenRockRing(ByteBuffer _bb, BrokenRockRing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00209321 File Offset: 0x00207521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00209330 File Offset: 0x00207530
		public BrokenRockRing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x00209340 File Offset: 0x00207540
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

		// Token: 0x060055A3 RID: 21923 RVA: 0x0020937C File Offset: 0x0020757C
		public IntArray? InvalidBox(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x002093DC File Offset: 0x002075DC
		public int InvalidBoxLength
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

		// Token: 0x060055A5 RID: 21925 RVA: 0x00209408 File Offset: 0x00207608
		public int RandomBox(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060055A6 RID: 21926 RVA: 0x00209448 File Offset: 0x00207648
		public int RandomBoxLength
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

		// Token: 0x060055A7 RID: 21927 RVA: 0x00209473 File Offset: 0x00207673
		public Span<int> GetRandomBoxBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00209482 File Offset: 0x00207682
		public int[] GetRandomBoxArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060055A9 RID: 21929 RVA: 0x0020949C File Offset: 0x0020769C
		public int PerfectBox
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x002094DC File Offset: 0x002076DC
		public DicIntInt? BonusRate(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x00209540 File Offset: 0x00207740
		public int BonusRateLength
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x0020956C File Offset: 0x0020776C
		public int GoodScore
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060055AD RID: 21933 RVA: 0x002095AC File Offset: 0x002077AC
		public int PerfectScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 30;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x002095EC File Offset: 0x002077EC
		public int BonusScore
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x0020962C File Offset: 0x0020782C
		public DicIntInt? Speed(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x00209690 File Offset: 0x00207890
		public int SpeedLength
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

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x002096BC File Offset: 0x002078BC
		public int ColdTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x00209700 File Offset: 0x00207900
		public int MultiBoxGroup
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00209740 File Offset: 0x00207940
		public int Offset(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x00209780 File Offset: 0x00207980
		public int OffsetLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x002097AC File Offset: 0x002079AC
		public Span<int> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x002097BC File Offset: 0x002079BC
		public int[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x002097D4 File Offset: 0x002079D4
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00209814 File Offset: 0x00207A14
		[NullableContext(1)]
		public Dictionary<int, int> BonusRate()
		{
			return this.BonusRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x0020986A File Offset: 0x00207A6A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BonusRateIter()
		{
			BrokenRockRing.<BonusRateIter>d__44 <BonusRateIter>d__ = new BrokenRockRing.<BonusRateIter>d__44(-2);
			<BonusRateIter>d__.<>3__<>4__this = this;
			return <BonusRateIter>d__;
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x0020987F File Offset: 0x00207A7F
		[NullableContext(1)]
		public IntArray[] InvalidBox()
		{
			return this.InvalidBoxIter().ToArray<IntArray>();
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0020988C File Offset: 0x00207A8C
		[NullableContext(1)]
		public IEnumerable<IntArray> InvalidBoxIter()
		{
			BrokenRockRing.<InvalidBoxIter>d__46 <InvalidBoxIter>d__ = new BrokenRockRing.<InvalidBoxIter>d__46(-2);
			<InvalidBoxIter>d__.<>3__<>4__this = this;
			return <InvalidBoxIter>d__;
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x002098A1 File Offset: 0x00207AA1
		[NullableContext(1)]
		public int[] Offset()
		{
			return this.GetOffsetArray();
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x002098A9 File Offset: 0x00207AA9
		[NullableContext(1)]
		public IEnumerable<int> OffsetIter()
		{
			BrokenRockRing.<OffsetIter>d__48 <OffsetIter>d__ = new BrokenRockRing.<OffsetIter>d__48(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x002098BE File Offset: 0x00207ABE
		[NullableContext(1)]
		public int[] RandomBox()
		{
			return this.GetRandomBoxArray();
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x002098C6 File Offset: 0x00207AC6
		[NullableContext(1)]
		public IEnumerable<int> RandomBoxIter()
		{
			BrokenRockRing.<RandomBoxIter>d__50 <RandomBoxIter>d__ = new BrokenRockRing.<RandomBoxIter>d__50(-2);
			<RandomBoxIter>d__.<>3__<>4__this = this;
			return <RandomBoxIter>d__;
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x002098DC File Offset: 0x00207ADC
		[NullableContext(1)]
		public Dictionary<int, int> Speed()
		{
			return this.SpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00209932 File Offset: 0x00207B32
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpeedIter()
		{
			BrokenRockRing.<SpeedIter>d__52 <SpeedIter>d__ = new BrokenRockRing.<SpeedIter>d__52(-2);
			<SpeedIter>d__.<>3__<>4__this = this;
			return <SpeedIter>d__;
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00209948 File Offset: 0x00207B48
		public int? GetBonusRate(int key)
		{
			this.EnsureBonusRateCacheIfNeeded();
			int value;
			if (!this.BonusRateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x0020997C File Offset: 0x00207B7C
		public int? GetSpeed(int key)
		{
			this.EnsureSpeedCacheIfNeeded();
			int value;
			if (!this.SpeedCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x002099B0 File Offset: 0x00207BB0
		private void EnsureBonusRateCacheIfNeeded()
		{
			if (this.BonusRateCache != null)
			{
				return;
			}
			this.BonusRateCache = this.BonusRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00209A18 File Offset: 0x00207C18
		private void EnsureSpeedCacheIfNeeded()
		{
			if (this.SpeedCache != null)
			{
				return;
			}
			this.SpeedCache = this.SpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00209A7E File Offset: 0x00207C7E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBonusRateFrozenDict()
		{
			this.EnsureBonusRateCacheIfNeeded();
			return this.BonusRateCache;
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00209A8C File Offset: 0x00207C8C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpeedFrozenDict()
		{
			this.EnsureSpeedCacheIfNeeded();
			return this.SpeedCache;
		}

		// Token: 0x0400512C RID: 20780
		private Table __p;

		// Token: 0x0400512D RID: 20781
		[Nullable(2)]
		private FrozenDictionary<int, int> BonusRateCache;

		// Token: 0x0400512E RID: 20782
		[Nullable(2)]
		private FrozenDictionary<int, int> SpeedCache;
	}
}
