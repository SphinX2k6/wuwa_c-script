using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001288 RID: 4744
	public struct TrapDefenseActivity : IFlatbufferObject
	{
		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x0035EE18 File Offset: 0x0035D018
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EED2 RID: 61138 RVA: 0x0035EE25 File Offset: 0x0035D025
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EED3 RID: 61139 RVA: 0x0035EE2C File Offset: 0x0035D02C
		public static TrapDefenseActivity GetRootAsTrapDefenseActivity(ByteBuffer _bb)
		{
			return TrapDefenseActivity.GetRootAsTrapDefenseActivity(_bb, default(TrapDefenseActivity));
		}

		// Token: 0x0600EED4 RID: 61140 RVA: 0x0035EE48 File Offset: 0x0035D048
		public static TrapDefenseActivity GetRootAsTrapDefenseActivity(ByteBuffer _bb, TrapDefenseActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EED5 RID: 61141 RVA: 0x0035EE65 File Offset: 0x0035D065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EED6 RID: 61142 RVA: 0x0035EE74 File Offset: 0x0035D074
		public TrapDefenseActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0600EED7 RID: 61143 RVA: 0x0035EE84 File Offset: 0x0035D084
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

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0600EED8 RID: 61144 RVA: 0x0035EEC0 File Offset: 0x0035D0C0
		public int ActivityId
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

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0600EED9 RID: 61145 RVA: 0x0035EEFC File Offset: 0x0035D0FC
		public int InstId
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

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0600EEDA RID: 61146 RVA: 0x0035EF38 File Offset: 0x0035D138
		public int ModeType
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

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0600EEDB RID: 61147 RVA: 0x0035EF78 File Offset: 0x0035D178
		public int GroupId
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

		// Token: 0x0600EEDC RID: 61148 RVA: 0x0035EFB8 File Offset: 0x0035D1B8
		public int LevelGaining(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x0600EEDD RID: 61149 RVA: 0x0035EFF8 File Offset: 0x0035D1F8
		public int LevelGainingLength
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

		// Token: 0x0600EEDE RID: 61150 RVA: 0x0035F024 File Offset: 0x0035D224
		public Span<int> GetLevelGainingBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600EEDF RID: 61151 RVA: 0x0035F034 File Offset: 0x0035D234
		public int[] GetLevelGainingArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x0600EEE0 RID: 61152 RVA: 0x0035F04C File Offset: 0x0035D24C
		public int OpenDay
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

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x0600EEE1 RID: 61153 RVA: 0x0035F08C File Offset: 0x0035D28C
		public int OpenCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x0035F0CC File Offset: 0x0035D2CC
		public int NextId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EEE3 RID: 61155 RVA: 0x0035F10C File Offset: 0x0035D30C
		public IntArray? StarRatingConditions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0600EEE4 RID: 61156 RVA: 0x0035F170 File Offset: 0x0035D370
		public int StarRatingConditionsLength
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

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0600EEE5 RID: 61157 RVA: 0x0035F19C File Offset: 0x0035D39C
		public int RewardStarLimit
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

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0600EEE6 RID: 61158 RVA: 0x0035F1DC File Offset: 0x0035D3DC
		public int RewardMoneyCount
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

		// Token: 0x0600EEE7 RID: 61159 RVA: 0x0035F21C File Offset: 0x0035D41C
		public int RewardBuildingTypes(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0600EEE8 RID: 61160 RVA: 0x0035F25C File Offset: 0x0035D45C
		public int RewardBuildingTypesLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EEE9 RID: 61161 RVA: 0x0035F288 File Offset: 0x0035D488
		public Span<int> GetRewardBuildingTypesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600EEEA RID: 61162 RVA: 0x0035F298 File Offset: 0x0035D498
		public int[] GetRewardBuildingTypesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600EEEB RID: 61163 RVA: 0x0035F2B0 File Offset: 0x0035D4B0
		public int RewardAuxiliaryTypes(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0600EEEC RID: 61164 RVA: 0x0035F2F0 File Offset: 0x0035D4F0
		public int RewardAuxiliaryTypesLength
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

		// Token: 0x0600EEED RID: 61165 RVA: 0x0035F31C File Offset: 0x0035D51C
		public Span<int> GetRewardAuxiliaryTypesBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600EEEE RID: 61166 RVA: 0x0035F32C File Offset: 0x0035D52C
		public int[] GetRewardAuxiliaryTypesArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x0600EEEF RID: 61167 RVA: 0x0035F344 File Offset: 0x0035D544
		public int RewardBd(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x0600EEF0 RID: 61168 RVA: 0x0035F384 File Offset: 0x0035D584
		public int RewardBdLength
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

		// Token: 0x0600EEF1 RID: 61169 RVA: 0x0035F3B0 File Offset: 0x0035D5B0
		public Span<int> GetRewardBdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600EEF2 RID: 61170 RVA: 0x0035F3C0 File Offset: 0x0035D5C0
		public int[] GetRewardBdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0600EEF3 RID: 61171 RVA: 0x0035F3D8 File Offset: 0x0035D5D8
		public int InitHealth
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

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0600EEF4 RID: 61172 RVA: 0x0035F418 File Offset: 0x0035D618
		public int InitGold
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0600EEF5 RID: 61173 RVA: 0x0035F458 File Offset: 0x0035D658
		public int InitMaxBuildingCount
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

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0600EEF6 RID: 61174 RVA: 0x0035F498 File Offset: 0x0035D698
		public int AuxiliarySummonCfgId
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

		// Token: 0x0600EEF7 RID: 61175 RVA: 0x0035F4D8 File Offset: 0x0035D6D8
		public int DefaultBuildingType(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0600EEF8 RID: 61176 RVA: 0x0035F518 File Offset: 0x0035D718
		public int DefaultBuildingTypeLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EEF9 RID: 61177 RVA: 0x0035F544 File Offset: 0x0035D744
		public Span<int> GetDefaultBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600EEFA RID: 61178 RVA: 0x0035F554 File Offset: 0x0035D754
		public int[] GetDefaultBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600EEFB RID: 61179 RVA: 0x0035F56C File Offset: 0x0035D76C
		public int DefaultAuxiliaryType(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0600EEFC RID: 61180 RVA: 0x0035F5AC File Offset: 0x0035D7AC
		public int DefaultAuxiliaryTypeLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EEFD RID: 61181 RVA: 0x0035F5D8 File Offset: 0x0035D7D8
		public Span<int> GetDefaultAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600EEFE RID: 61182 RVA: 0x0035F5E8 File Offset: 0x0035D7E8
		public int[] GetDefaultAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600EEFF RID: 61183 RVA: 0x0035F600 File Offset: 0x0035D800
		public int ForceBuildingType(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0600EF00 RID: 61184 RVA: 0x0035F640 File Offset: 0x0035D840
		public int ForceBuildingTypeLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF01 RID: 61185 RVA: 0x0035F66C File Offset: 0x0035D86C
		public Span<int> GetForceBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600EF02 RID: 61186 RVA: 0x0035F67C File Offset: 0x0035D87C
		public int[] GetForceBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x0035F694 File Offset: 0x0035D894
		public int ForceAuxiliaryType(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0600EF04 RID: 61188 RVA: 0x0035F6D4 File Offset: 0x0035D8D4
		public int ForceAuxiliaryTypeLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF05 RID: 61189 RVA: 0x0035F700 File Offset: 0x0035D900
		public Span<int> GetForceAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600EF06 RID: 61190 RVA: 0x0035F710 File Offset: 0x0035D910
		public int[] GetForceAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600EF07 RID: 61191 RVA: 0x0035F728 File Offset: 0x0035D928
		public int RecommendBuildingType(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0600EF08 RID: 61192 RVA: 0x0035F768 File Offset: 0x0035D968
		public int RecommendBuildingTypeLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x0035F794 File Offset: 0x0035D994
		public Span<int> GetRecommendBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600EF0A RID: 61194 RVA: 0x0035F7A4 File Offset: 0x0035D9A4
		public int[] GetRecommendBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600EF0B RID: 61195 RVA: 0x0035F7BC File Offset: 0x0035D9BC
		public int RecommendAuxiliaryType(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0600EF0C RID: 61196 RVA: 0x0035F7FC File Offset: 0x0035D9FC
		public int RecommendAuxiliaryTypeLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF0D RID: 61197 RVA: 0x0035F828 File Offset: 0x0035DA28
		public Span<int> GetRecommendAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600EF0E RID: 61198 RVA: 0x0035F838 File Offset: 0x0035DA38
		public int[] GetRecommendAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0600EF0F RID: 61199 RVA: 0x0035F850 File Offset: 0x0035DA50
		public int BaseEquipCount
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0600EF10 RID: 61200 RVA: 0x0035F890 File Offset: 0x0035DA90
		public int BaseAuxiliaryCount
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x0035F8D0 File Offset: 0x0035DAD0
		public int BaseResolvePolluteCount
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0600EF12 RID: 61202 RVA: 0x0035F910 File Offset: 0x0035DB10
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x0035F950 File Offset: 0x0035DB50
		public string Name
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF14 RID: 61204 RVA: 0x0035F988 File Offset: 0x0035DB88
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600EF15 RID: 61205 RVA: 0x0035F998 File Offset: 0x0035DB98
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x0600EF16 RID: 61206 RVA: 0x0035F9B0 File Offset: 0x0035DBB0
		public string LevelNameImage
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x0035F9E8 File Offset: 0x0035DBE8
		public Span<byte> GetLevelNameImageBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x0035F9F8 File Offset: 0x0035DBF8
		public byte[] GetLevelNameImageArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x0600EF19 RID: 61209 RVA: 0x0035FA10 File Offset: 0x0035DC10
		public string LevelImage
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF1A RID: 61210 RVA: 0x0035FA48 File Offset: 0x0035DC48
		public Span<byte> GetLevelImageBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600EF1B RID: 61211 RVA: 0x0035FA58 File Offset: 0x0035DC58
		public byte[] GetLevelImageArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x0600EF1C RID: 61212 RVA: 0x0035FA70 File Offset: 0x0035DC70
		public string ResultImage
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF1D RID: 61213 RVA: 0x0035FAA8 File Offset: 0x0035DCA8
		public Span<byte> GetResultImageBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600EF1E RID: 61214 RVA: 0x0035FAB8 File Offset: 0x0035DCB8
		public byte[] GetResultImageArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x0600EF1F RID: 61215 RVA: 0x0035FAD0 File Offset: 0x0035DCD0
		public string DifficultyDesc
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF20 RID: 61216 RVA: 0x0035FB08 File Offset: 0x0035DD08
		public Span<byte> GetDifficultyDescBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600EF21 RID: 61217 RVA: 0x0035FB18 File Offset: 0x0035DD18
		public byte[] GetDifficultyDescArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF22 RID: 61218 RVA: 0x0035FB30 File Offset: 0x0035DD30
		public string DifficultyDescArgs(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x0600EF23 RID: 61219 RVA: 0x0035FB6C File Offset: 0x0035DD6C
		public int DifficultyDescArgsLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x0600EF24 RID: 61220 RVA: 0x0035FB98 File Offset: 0x0035DD98
		public string LockDesc
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF25 RID: 61221 RVA: 0x0035FBD0 File Offset: 0x0035DDD0
		public Span<byte> GetLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600EF26 RID: 61222 RVA: 0x0035FBE0 File Offset: 0x0035DDE0
		public byte[] GetLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0600EF27 RID: 61223 RVA: 0x0035FBF8 File Offset: 0x0035DDF8
		public string TargetDesc
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF28 RID: 61224 RVA: 0x0035FC30 File Offset: 0x0035DE30
		public Span<byte> GetTargetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600EF29 RID: 61225 RVA: 0x0035FC40 File Offset: 0x0035DE40
		public byte[] GetTargetDescArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x0600EF2A RID: 61226 RVA: 0x0035FC58 File Offset: 0x0035DE58
		public int RewardDrop
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x0600EF2B RID: 61227 RVA: 0x0035FC98 File Offset: 0x0035DE98
		public string RewardDesc
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF2C RID: 61228 RVA: 0x0035FCD0 File Offset: 0x0035DED0
		public Span<byte> GetRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600EF2D RID: 61229 RVA: 0x0035FCE0 File Offset: 0x0035DEE0
		public byte[] GetRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x0035FCF8 File Offset: 0x0035DEF8
		public int UseBdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0600EF2F RID: 61231 RVA: 0x0035FD38 File Offset: 0x0035DF38
		public int UseBdListLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF30 RID: 61232 RVA: 0x0035FD64 File Offset: 0x0035DF64
		public Span<int> GetUseBdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600EF31 RID: 61233 RVA: 0x0035FD74 File Offset: 0x0035DF74
		public int[] GetUseBdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0600EF32 RID: 61234 RVA: 0x0035FD8C File Offset: 0x0035DF8C
		public int GuranteeDraw
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0600EF33 RID: 61235 RVA: 0x0035FDCC File Offset: 0x0035DFCC
		public int MonsterWaveMainId
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0600EF34 RID: 61236 RVA: 0x0035FE0C File Offset: 0x0035E00C
		public int LoopStartWaveId
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x0035FE4C File Offset: 0x0035E04C
		public string LoopStartWaveDesc
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF36 RID: 61238 RVA: 0x0035FE84 File Offset: 0x0035E084
		public Span<byte> GetLoopStartWaveDescBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600EF37 RID: 61239 RVA: 0x0035FE94 File Offset: 0x0035E094
		public byte[] GetLoopStartWaveDescArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EF38 RID: 61240 RVA: 0x0035FEAC File Offset: 0x0035E0AC
		public int SplineList(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0600EF39 RID: 61241 RVA: 0x0035FEEC File Offset: 0x0035E0EC
		public int SplineListLength
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF3A RID: 61242 RVA: 0x0035FF18 File Offset: 0x0035E118
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x0600EF3B RID: 61243 RVA: 0x0035FF28 File Offset: 0x0035E128
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x0035FF40 File Offset: 0x0035E140
		public string LevelMapUiShow
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF3D RID: 61245 RVA: 0x0035FF78 File Offset: 0x0035E178
		public Span<byte> GetLevelMapUiShowBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600EF3E RID: 61246 RVA: 0x0035FF88 File Offset: 0x0035E188
		public byte[] GetLevelMapUiShowArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0600EF3F RID: 61247 RVA: 0x0035FFA0 File Offset: 0x0035E1A0
		public int UnlockLevelNeedStar
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x0600EF40 RID: 61248 RVA: 0x0035FFE0 File Offset: 0x0035E1E0
		public bool NeedStarWhenPause
		{
			get
			{
				int num = this.__p.__offset(98);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x0600EF41 RID: 61249 RVA: 0x00360020 File Offset: 0x0035E220
		public bool IsCanSave
		{
			get
			{
				int num = this.__p.__offset(100);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x0600EF42 RID: 61250 RVA: 0x00360060 File Offset: 0x0035E260
		public int WorldKillZ
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EF43 RID: 61251 RVA: 0x003600A0 File Offset: 0x0035E2A0
		public IntArray? ObstacleSegments(int j)
		{
			int num = this.__p.__offset(104);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0600EF44 RID: 61252 RVA: 0x00360104 File Offset: 0x0035E304
		public int ObstacleSegmentsLength
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EF45 RID: 61253 RVA: 0x00360130 File Offset: 0x0035E330
		[NullableContext(1)]
		public int[] DefaultAuxiliaryType()
		{
			return this.GetDefaultAuxiliaryTypeArray();
		}

		// Token: 0x0600EF46 RID: 61254 RVA: 0x00360138 File Offset: 0x0035E338
		[NullableContext(1)]
		public IEnumerable<int> DefaultAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<DefaultAuxiliaryTypeIter>d__170 <DefaultAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<DefaultAuxiliaryTypeIter>d__170(-2);
			<DefaultAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <DefaultAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600EF47 RID: 61255 RVA: 0x0036014D File Offset: 0x0035E34D
		[NullableContext(1)]
		public int[] DefaultBuildingType()
		{
			return this.GetDefaultBuildingTypeArray();
		}

		// Token: 0x0600EF48 RID: 61256 RVA: 0x00360155 File Offset: 0x0035E355
		[NullableContext(1)]
		public IEnumerable<int> DefaultBuildingTypeIter()
		{
			TrapDefenseActivity.<DefaultBuildingTypeIter>d__172 <DefaultBuildingTypeIter>d__ = new TrapDefenseActivity.<DefaultBuildingTypeIter>d__172(-2);
			<DefaultBuildingTypeIter>d__.<>3__<>4__this = this;
			return <DefaultBuildingTypeIter>d__;
		}

		// Token: 0x0600EF49 RID: 61257 RVA: 0x0036016A File Offset: 0x0035E36A
		[NullableContext(1)]
		public string[] DifficultyDescArgs()
		{
			return this.DifficultyDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600EF4A RID: 61258 RVA: 0x00360177 File Offset: 0x0035E377
		[NullableContext(1)]
		public IEnumerable<string> DifficultyDescArgsIter()
		{
			TrapDefenseActivity.<DifficultyDescArgsIter>d__174 <DifficultyDescArgsIter>d__ = new TrapDefenseActivity.<DifficultyDescArgsIter>d__174(-2);
			<DifficultyDescArgsIter>d__.<>3__<>4__this = this;
			return <DifficultyDescArgsIter>d__;
		}

		// Token: 0x0600EF4B RID: 61259 RVA: 0x0036018C File Offset: 0x0035E38C
		[NullableContext(1)]
		public int[] ForceAuxiliaryType()
		{
			return this.GetForceAuxiliaryTypeArray();
		}

		// Token: 0x0600EF4C RID: 61260 RVA: 0x00360194 File Offset: 0x0035E394
		[NullableContext(1)]
		public IEnumerable<int> ForceAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<ForceAuxiliaryTypeIter>d__176 <ForceAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<ForceAuxiliaryTypeIter>d__176(-2);
			<ForceAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <ForceAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600EF4D RID: 61261 RVA: 0x003601A9 File Offset: 0x0035E3A9
		[NullableContext(1)]
		public int[] ForceBuildingType()
		{
			return this.GetForceBuildingTypeArray();
		}

		// Token: 0x0600EF4E RID: 61262 RVA: 0x003601B1 File Offset: 0x0035E3B1
		[NullableContext(1)]
		public IEnumerable<int> ForceBuildingTypeIter()
		{
			TrapDefenseActivity.<ForceBuildingTypeIter>d__178 <ForceBuildingTypeIter>d__ = new TrapDefenseActivity.<ForceBuildingTypeIter>d__178(-2);
			<ForceBuildingTypeIter>d__.<>3__<>4__this = this;
			return <ForceBuildingTypeIter>d__;
		}

		// Token: 0x0600EF4F RID: 61263 RVA: 0x003601C6 File Offset: 0x0035E3C6
		[NullableContext(1)]
		public int[] LevelGaining()
		{
			return this.GetLevelGainingArray();
		}

		// Token: 0x0600EF50 RID: 61264 RVA: 0x003601CE File Offset: 0x0035E3CE
		[NullableContext(1)]
		public IEnumerable<int> LevelGainingIter()
		{
			TrapDefenseActivity.<LevelGainingIter>d__180 <LevelGainingIter>d__ = new TrapDefenseActivity.<LevelGainingIter>d__180(-2);
			<LevelGainingIter>d__.<>3__<>4__this = this;
			return <LevelGainingIter>d__;
		}

		// Token: 0x0600EF51 RID: 61265 RVA: 0x003601E3 File Offset: 0x0035E3E3
		[NullableContext(1)]
		public IntArray[] ObstacleSegments()
		{
			return this.ObstacleSegmentsIter().ToArray<IntArray>();
		}

		// Token: 0x0600EF52 RID: 61266 RVA: 0x003601F0 File Offset: 0x0035E3F0
		[NullableContext(1)]
		public IEnumerable<IntArray> ObstacleSegmentsIter()
		{
			TrapDefenseActivity.<ObstacleSegmentsIter>d__182 <ObstacleSegmentsIter>d__ = new TrapDefenseActivity.<ObstacleSegmentsIter>d__182(-2);
			<ObstacleSegmentsIter>d__.<>3__<>4__this = this;
			return <ObstacleSegmentsIter>d__;
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x00360205 File Offset: 0x0035E405
		[NullableContext(1)]
		public int[] RecommendAuxiliaryType()
		{
			return this.GetRecommendAuxiliaryTypeArray();
		}

		// Token: 0x0600EF54 RID: 61268 RVA: 0x0036020D File Offset: 0x0035E40D
		[NullableContext(1)]
		public IEnumerable<int> RecommendAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<RecommendAuxiliaryTypeIter>d__184 <RecommendAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<RecommendAuxiliaryTypeIter>d__184(-2);
			<RecommendAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <RecommendAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600EF55 RID: 61269 RVA: 0x00360222 File Offset: 0x0035E422
		[NullableContext(1)]
		public int[] RecommendBuildingType()
		{
			return this.GetRecommendBuildingTypeArray();
		}

		// Token: 0x0600EF56 RID: 61270 RVA: 0x0036022A File Offset: 0x0035E42A
		[NullableContext(1)]
		public IEnumerable<int> RecommendBuildingTypeIter()
		{
			TrapDefenseActivity.<RecommendBuildingTypeIter>d__186 <RecommendBuildingTypeIter>d__ = new TrapDefenseActivity.<RecommendBuildingTypeIter>d__186(-2);
			<RecommendBuildingTypeIter>d__.<>3__<>4__this = this;
			return <RecommendBuildingTypeIter>d__;
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x0036023F File Offset: 0x0035E43F
		[NullableContext(1)]
		public int[] RewardAuxiliaryTypes()
		{
			return this.GetRewardAuxiliaryTypesArray();
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x00360247 File Offset: 0x0035E447
		[NullableContext(1)]
		public IEnumerable<int> RewardAuxiliaryTypesIter()
		{
			TrapDefenseActivity.<RewardAuxiliaryTypesIter>d__188 <RewardAuxiliaryTypesIter>d__ = new TrapDefenseActivity.<RewardAuxiliaryTypesIter>d__188(-2);
			<RewardAuxiliaryTypesIter>d__.<>3__<>4__this = this;
			return <RewardAuxiliaryTypesIter>d__;
		}

		// Token: 0x0600EF59 RID: 61273 RVA: 0x0036025C File Offset: 0x0035E45C
		[NullableContext(1)]
		public int[] RewardBd()
		{
			return this.GetRewardBdArray();
		}

		// Token: 0x0600EF5A RID: 61274 RVA: 0x00360264 File Offset: 0x0035E464
		[NullableContext(1)]
		public IEnumerable<int> RewardBdIter()
		{
			TrapDefenseActivity.<RewardBdIter>d__190 <RewardBdIter>d__ = new TrapDefenseActivity.<RewardBdIter>d__190(-2);
			<RewardBdIter>d__.<>3__<>4__this = this;
			return <RewardBdIter>d__;
		}

		// Token: 0x0600EF5B RID: 61275 RVA: 0x00360279 File Offset: 0x0035E479
		[NullableContext(1)]
		public int[] RewardBuildingTypes()
		{
			return this.GetRewardBuildingTypesArray();
		}

		// Token: 0x0600EF5C RID: 61276 RVA: 0x00360281 File Offset: 0x0035E481
		[NullableContext(1)]
		public IEnumerable<int> RewardBuildingTypesIter()
		{
			TrapDefenseActivity.<RewardBuildingTypesIter>d__192 <RewardBuildingTypesIter>d__ = new TrapDefenseActivity.<RewardBuildingTypesIter>d__192(-2);
			<RewardBuildingTypesIter>d__.<>3__<>4__this = this;
			return <RewardBuildingTypesIter>d__;
		}

		// Token: 0x0600EF5D RID: 61277 RVA: 0x00360296 File Offset: 0x0035E496
		[NullableContext(1)]
		public int[] SplineList()
		{
			return this.GetSplineListArray();
		}

		// Token: 0x0600EF5E RID: 61278 RVA: 0x0036029E File Offset: 0x0035E49E
		[NullableContext(1)]
		public IEnumerable<int> SplineListIter()
		{
			TrapDefenseActivity.<SplineListIter>d__194 <SplineListIter>d__ = new TrapDefenseActivity.<SplineListIter>d__194(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x0600EF5F RID: 61279 RVA: 0x003602B3 File Offset: 0x0035E4B3
		[NullableContext(1)]
		public IntArray[] StarRatingConditions()
		{
			return this.StarRatingConditionsIter().ToArray<IntArray>();
		}

		// Token: 0x0600EF60 RID: 61280 RVA: 0x003602C0 File Offset: 0x0035E4C0
		[NullableContext(1)]
		public IEnumerable<IntArray> StarRatingConditionsIter()
		{
			TrapDefenseActivity.<StarRatingConditionsIter>d__196 <StarRatingConditionsIter>d__ = new TrapDefenseActivity.<StarRatingConditionsIter>d__196(-2);
			<StarRatingConditionsIter>d__.<>3__<>4__this = this;
			return <StarRatingConditionsIter>d__;
		}

		// Token: 0x0600EF61 RID: 61281 RVA: 0x003602D5 File Offset: 0x0035E4D5
		[NullableContext(1)]
		public int[] UseBdList()
		{
			return this.GetUseBdListArray();
		}

		// Token: 0x0600EF62 RID: 61282 RVA: 0x003602DD File Offset: 0x0035E4DD
		[NullableContext(1)]
		public IEnumerable<int> UseBdListIter()
		{
			TrapDefenseActivity.<UseBdListIter>d__198 <UseBdListIter>d__ = new TrapDefenseActivity.<UseBdListIter>d__198(-2);
			<UseBdListIter>d__.<>3__<>4__this = this;
			return <UseBdListIter>d__;
		}

		// Token: 0x040058DA RID: 22746
		private Table __p;
	}
}
