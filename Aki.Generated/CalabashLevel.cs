using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3D RID: 3133
	public struct CalabashLevel : IFlatbufferObject
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x0020DDEF File Offset: 0x0020BFEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x0020DDFC File Offset: 0x0020BFFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0020DE04 File Offset: 0x0020C004
		public static CalabashLevel GetRootAsCalabashLevel(ByteBuffer _bb)
		{
			return CalabashLevel.GetRootAsCalabashLevel(_bb, default(CalabashLevel));
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x0020DE20 File Offset: 0x0020C020
		public static CalabashLevel GetRootAsCalabashLevel(ByteBuffer _bb, CalabashLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x0020DE3D File Offset: 0x0020C03D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x0020DE4C File Offset: 0x0020C04C
		public CalabashLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x0020DE5C File Offset: 0x0020C05C
		public int Level
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

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x0020DE98 File Offset: 0x0020C098
		public int LevelUpExp
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

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x0020DED4 File Offset: 0x0020C0D4
		public int LevelUpCondition
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x0020DF10 File Offset: 0x0020C110
		public int TempCatchGain
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x0020DF50 File Offset: 0x0020C150
		public int LowCostTempCatchGain
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x0020DF90 File Offset: 0x0020C190
		public int IntensifyCaptureGuarantee
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x0020DFD0 File Offset: 0x0020C1D0
		public int LowCostIntensifyCaptureGuarantee
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x0020E010 File Offset: 0x0020C210
		public int BuffIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x0020E050 File Offset: 0x0020C250
		public int BuffIdsLength
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

		// Token: 0x060057AB RID: 22443 RVA: 0x0020E07C File Offset: 0x0020C27C
		public Span<int> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x0020E08C File Offset: 0x0020C28C
		public int[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x0020E0A4 File Offset: 0x0020C2A4
		public string BuffDescription
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x0020E0DC File Offset: 0x0020C2DC
		public Span<byte> GetBuffDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x0020E0EC File Offset: 0x0020C2EC
		public byte[] GetBuffDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x0020E104 File Offset: 0x0020C304
		public string LevelUpDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0020E13C File Offset: 0x0020C33C
		public Span<byte> GetLevelUpDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x0020E14C File Offset: 0x0020C34C
		public byte[] GetLevelUpDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060057B3 RID: 22451 RVA: 0x0020E164 File Offset: 0x0020C364
		public string QualityDescription
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x0020E19C File Offset: 0x0020C39C
		public Span<byte> GetQualityDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x0020E1AC File Offset: 0x0020C3AC
		public byte[] GetQualityDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x0020E1C4 File Offset: 0x0020C3C4
		public DicIntInt? BuffDescriptionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060057B7 RID: 22455 RVA: 0x0020E228 File Offset: 0x0020C428
		public int BuffDescriptionMapLength
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x0020E254 File Offset: 0x0020C454
		public int Cost
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060057B9 RID: 22457 RVA: 0x0020E294 File Offset: 0x0020C494
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 4301;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x0020E2D8 File Offset: 0x0020C4D8
		public DicIntInt? QualityDropWeight(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060057BB RID: 22459 RVA: 0x0020E33C File Offset: 0x0020C53C
		public int QualityDropWeightLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x0020E368 File Offset: 0x0020C568
		public string ReachTextChangeColor
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x0020E3A0 File Offset: 0x0020C5A0
		public Span<byte> GetReachTextChangeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x0020E3B0 File Offset: 0x0020C5B0
		public byte[] GetReachTextChangeColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x0020E3C8 File Offset: 0x0020C5C8
		public string ReachTextOutlineColor
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x0020E400 File Offset: 0x0020C600
		public Span<byte> GetReachTextOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x0020E410 File Offset: 0x0020C610
		public byte[] GetReachTextOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x0020E428 File Offset: 0x0020C628
		public int ReachTextOutlineSize
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x0020E468 File Offset: 0x0020C668
		public string TexPatternStatePath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x0020E4A0 File Offset: 0x0020C6A0
		public Span<byte> GetTexPatternStatePathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x0020E4B0 File Offset: 0x0020C6B0
		public byte[] GetTexPatternStatePathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060057C6 RID: 22470 RVA: 0x0020E4C8 File Offset: 0x0020C6C8
		public string TexAddLight
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x0020E500 File Offset: 0x0020C700
		public Span<byte> GetTexAddLightBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x0020E510 File Offset: 0x0020C710
		public byte[] GetTexAddLightArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x0020E528 File Offset: 0x0020C728
		[NullableContext(1)]
		public Dictionary<int, int> BuffDescriptionMap()
		{
			return this.BuffDescriptionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x0020E57E File Offset: 0x0020C77E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BuffDescriptionMapIter()
		{
			CalabashLevel.<BuffDescriptionMapIter>d__68 <BuffDescriptionMapIter>d__ = new CalabashLevel.<BuffDescriptionMapIter>d__68(-2);
			<BuffDescriptionMapIter>d__.<>3__<>4__this = this;
			return <BuffDescriptionMapIter>d__;
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x0020E593 File Offset: 0x0020C793
		[NullableContext(1)]
		public int[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x0020E59B File Offset: 0x0020C79B
		[NullableContext(1)]
		public IEnumerable<int> BuffIdsIter()
		{
			CalabashLevel.<BuffIdsIter>d__70 <BuffIdsIter>d__ = new CalabashLevel.<BuffIdsIter>d__70(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x0020E5B0 File Offset: 0x0020C7B0
		[NullableContext(1)]
		public Dictionary<int, int> QualityDropWeight()
		{
			return this.QualityDropWeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0020E606 File Offset: 0x0020C806
		[NullableContext(1)]
		public IEnumerable<DicIntInt> QualityDropWeightIter()
		{
			CalabashLevel.<QualityDropWeightIter>d__72 <QualityDropWeightIter>d__ = new CalabashLevel.<QualityDropWeightIter>d__72(-2);
			<QualityDropWeightIter>d__.<>3__<>4__this = this;
			return <QualityDropWeightIter>d__;
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x0020E61C File Offset: 0x0020C81C
		public int? GetBuffDescriptionMap(int key)
		{
			this.EnsureBuffDescriptionMapCacheIfNeeded();
			int value;
			if (!this.BuffDescriptionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0020E650 File Offset: 0x0020C850
		public int? GetQualityDropWeight(int key)
		{
			this.EnsureQualityDropWeightCacheIfNeeded();
			int value;
			if (!this.QualityDropWeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0020E684 File Offset: 0x0020C884
		private void EnsureBuffDescriptionMapCacheIfNeeded()
		{
			if (this.BuffDescriptionMapCache != null)
			{
				return;
			}
			this.BuffDescriptionMapCache = this.BuffDescriptionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0020E6EC File Offset: 0x0020C8EC
		private void EnsureQualityDropWeightCacheIfNeeded()
		{
			if (this.QualityDropWeightCache != null)
			{
				return;
			}
			this.QualityDropWeightCache = this.QualityDropWeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0020E752 File Offset: 0x0020C952
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBuffDescriptionMapFrozenDict()
		{
			this.EnsureBuffDescriptionMapCacheIfNeeded();
			return this.BuffDescriptionMapCache;
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x0020E760 File Offset: 0x0020C960
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetQualityDropWeightFrozenDict()
		{
			this.EnsureQualityDropWeightCacheIfNeeded();
			return this.QualityDropWeightCache;
		}

		// Token: 0x0400513B RID: 20795
		private Table __p;

		// Token: 0x0400513C RID: 20796
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffDescriptionMapCache;

		// Token: 0x0400513D RID: 20797
		[Nullable(2)]
		private FrozenDictionary<int, int> QualityDropWeightCache;
	}
}
