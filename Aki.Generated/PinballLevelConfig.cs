using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2D RID: 3885
	public struct PinballLevelConfig : IFlatbufferObject
	{
		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600AEEB RID: 44779 RVA: 0x002C1ABA File Offset: 0x002BFCBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x002C1AC7 File Offset: 0x002BFCC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x002C1AD0 File Offset: 0x002BFCD0
		public static PinballLevelConfig GetRootAsPinballLevelConfig(ByteBuffer _bb)
		{
			return PinballLevelConfig.GetRootAsPinballLevelConfig(_bb, default(PinballLevelConfig));
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x002C1AEC File Offset: 0x002BFCEC
		public static PinballLevelConfig GetRootAsPinballLevelConfig(ByteBuffer _bb, PinballLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEEF RID: 44783 RVA: 0x002C1B09 File Offset: 0x002BFD09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x002C1B18 File Offset: 0x002BFD18
		public PinballLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600AEF1 RID: 44785 RVA: 0x002C1B28 File Offset: 0x002BFD28
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

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600AEF2 RID: 44786 RVA: 0x002C1B64 File Offset: 0x002BFD64
		public int ShowRoleId
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

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600AEF3 RID: 44787 RVA: 0x002C1BA0 File Offset: 0x002BFDA0
		public int Type
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

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x002C1BDC File Offset: 0x002BFDDC
		public int PreLevelIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x0600AEF5 RID: 44789 RVA: 0x002C1C1C File Offset: 0x002BFE1C
		public int PreLevelIdsLength
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

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x002C1C48 File Offset: 0x002BFE48
		public Span<int> GetPreLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x002C1C58 File Offset: 0x002BFE58
		public int[] GetPreLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x002C1C70 File Offset: 0x002BFE70
		public int FirstClearDropId
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

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x002C1CB0 File Offset: 0x002BFEB0
		public int InstId
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

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x002C1CF0 File Offset: 0x002BFEF0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AEFB RID: 44795 RVA: 0x002C1D28 File Offset: 0x002BFF28
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x002C1D38 File Offset: 0x002BFF38
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x002C1D50 File Offset: 0x002BFF50
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x002C1D88 File Offset: 0x002BFF88
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x002C1D98 File Offset: 0x002BFF98
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002C1DB0 File Offset: 0x002BFFB0
		public string Icon
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

		// Token: 0x0600AF01 RID: 44801 RVA: 0x002C1DE8 File Offset: 0x002BFFE8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x002C1DF8 File Offset: 0x002BFFF8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x002C1E10 File Offset: 0x002C0010
		public int StarCond(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x002C1E50 File Offset: 0x002C0050
		public int StarCondLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x002C1E7C File Offset: 0x002C007C
		public Span<int> GetStarCondBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x002C1E8C File Offset: 0x002C008C
		public int[] GetStarCondArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x002C1EA4 File Offset: 0x002C00A4
		public int RecommendRole(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x002C1EE4 File Offset: 0x002C00E4
		public int RecommendRoleLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x002C1F10 File Offset: 0x002C0110
		public Span<int> GetRecommendRoleBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x002C1F20 File Offset: 0x002C0120
		public int[] GetRecommendRoleArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x002C1F38 File Offset: 0x002C0138
		public int TrailRole(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x002C1F78 File Offset: 0x002C0178
		public int TrailRoleLength
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

		// Token: 0x0600AF0D RID: 44813 RVA: 0x002C1FA4 File Offset: 0x002C01A4
		public Span<int> GetTrailRoleBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x002C1FB4 File Offset: 0x002C01B4
		public int[] GetTrailRoleArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x002C1FCC File Offset: 0x002C01CC
		public string ScoreDesc
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x002C2004 File Offset: 0x002C0204
		public Span<byte> GetScoreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x002C2014 File Offset: 0x002C0214
		public byte[] GetScoreDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF12 RID: 44818 RVA: 0x002C202C File Offset: 0x002C022C
		public DicIntInt? ScoreLevelReward(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x002C2090 File Offset: 0x002C0290
		public int ScoreLevelRewardLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x002C20BC File Offset: 0x002C02BC
		public int LevelTime
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x002C20FC File Offset: 0x002C02FC
		public int TowerNum
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x002C213C File Offset: 0x002C033C
		public bool IsTowerBoss
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x0600AF17 RID: 44823 RVA: 0x002C217C File Offset: 0x002C037C
		public int ScoreRatio
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

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x002C21BC File Offset: 0x002C03BC
		public int MaxRevive
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x0600AF19 RID: 44825 RVA: 0x002C21FC File Offset: 0x002C03FC
		public int FormationGroup
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600AF1A RID: 44826 RVA: 0x002C223C File Offset: 0x002C043C
		public string FailTipsTxt
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x002C2274 File Offset: 0x002C0474
		public Span<byte> GetFailTipsTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x002C2284 File Offset: 0x002C0484
		public byte[] GetFailTipsTxtArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x002C229C File Offset: 0x002C049C
		public string LevelBg
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x002C22D4 File Offset: 0x002C04D4
		public Span<byte> GetLevelBgBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x002C22E4 File Offset: 0x002C04E4
		public byte[] GetLevelBgArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x002C22FC File Offset: 0x002C04FC
		public int NextLevelId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600AF21 RID: 44833 RVA: 0x002C233C File Offset: 0x002C053C
		public int RecommendLevel
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600AF22 RID: 44834 RVA: 0x002C237C File Offset: 0x002C057C
		public int AvgStyle
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600AF23 RID: 44835 RVA: 0x002C23BC File Offset: 0x002C05BC
		public string FeverBarMaterialPath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002C23F4 File Offset: 0x002C05F4
		public Span<byte> GetFeverBarMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x002C2404 File Offset: 0x002C0604
		public byte[] GetFeverBarMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x002C241C File Offset: 0x002C061C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreLevelIdsIter()或GetPreLevelIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreLevelIds()
		{
			PinballLevelConfig pinballLevelConfig = this;
			return pinballLevelConfig.GetPreLevelIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x002C2440 File Offset: 0x002C0640
		[NullableContext(1)]
		public readonly IEnumerable<int> PreLevelIdsIter()
		{
			PinballLevelConfig.<PreLevelIdsIter>d__88 <PreLevelIdsIter>d__ = new PinballLevelConfig.<PreLevelIdsIter>d__88(-2);
			<PreLevelIdsIter>d__.<>3__<>4__this = this;
			return <PreLevelIdsIter>d__;
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x002C2458 File Offset: 0x002C0658
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendRoleIter()或GetRecommendRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendRole()
		{
			PinballLevelConfig pinballLevelConfig = this;
			return pinballLevelConfig.GetRecommendRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x002C247C File Offset: 0x002C067C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendRoleIter()
		{
			PinballLevelConfig.<RecommendRoleIter>d__90 <RecommendRoleIter>d__ = new PinballLevelConfig.<RecommendRoleIter>d__90(-2);
			<RecommendRoleIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIter>d__;
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x002C2494 File Offset: 0x002C0694
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ScoreLevelRewardFrozenDict()缓存字典，遍历请使用ScoreLevelRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ScoreLevelReward()
		{
			return this.ScoreLevelRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x002C24EA File Offset: 0x002C06EA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ScoreLevelRewardIter()
		{
			PinballLevelConfig.<ScoreLevelRewardIter>d__92 <ScoreLevelRewardIter>d__ = new PinballLevelConfig.<ScoreLevelRewardIter>d__92(-2);
			<ScoreLevelRewardIter>d__.<>3__<>4__this = this;
			return <ScoreLevelRewardIter>d__;
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x002C2500 File Offset: 0x002C0700
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StarCondIter()或GetStarCondBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] StarCond()
		{
			PinballLevelConfig pinballLevelConfig = this;
			return pinballLevelConfig.GetStarCondArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x002C2524 File Offset: 0x002C0724
		[NullableContext(1)]
		public readonly IEnumerable<int> StarCondIter()
		{
			PinballLevelConfig.<StarCondIter>d__94 <StarCondIter>d__ = new PinballLevelConfig.<StarCondIter>d__94(-2);
			<StarCondIter>d__.<>3__<>4__this = this;
			return <StarCondIter>d__;
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x002C253C File Offset: 0x002C073C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrailRoleIter()或GetTrailRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrailRole()
		{
			PinballLevelConfig pinballLevelConfig = this;
			return pinballLevelConfig.GetTrailRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x002C2560 File Offset: 0x002C0760
		[NullableContext(1)]
		public readonly IEnumerable<int> TrailRoleIter()
		{
			PinballLevelConfig.<TrailRoleIter>d__96 <TrailRoleIter>d__ = new PinballLevelConfig.<TrailRoleIter>d__96(-2);
			<TrailRoleIter>d__.<>3__<>4__this = this;
			return <TrailRoleIter>d__;
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x002C2578 File Offset: 0x002C0778
		public int? GetScoreLevelReward(int key)
		{
			this.EnsureScoreLevelRewardCacheIfNeeded();
			int value;
			if (!this.ScoreLevelRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AF31 RID: 44849 RVA: 0x002C25AC File Offset: 0x002C07AC
		private void EnsureScoreLevelRewardCacheIfNeeded()
		{
			if (this.ScoreLevelRewardCache != null)
			{
				return;
			}
			this.ScoreLevelRewardCache = this.ScoreLevelRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x002C2612 File Offset: 0x002C0812
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScoreLevelRewardFrozenDict(int key)
		{
			this.EnsureScoreLevelRewardCacheIfNeeded();
			return this.ScoreLevelRewardCache;
		}

		// Token: 0x04004FF6 RID: 20470
		private Table __p;

		// Token: 0x04004FF7 RID: 20471
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreLevelRewardCache;
	}
}
