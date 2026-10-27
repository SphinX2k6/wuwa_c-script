using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001152 RID: 4434
	public struct TrapDefenseActivity : IFlatbufferObject
	{
		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600E163 RID: 57699 RVA: 0x00333A68 File Offset: 0x00331C68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x00333A75 File Offset: 0x00331C75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x00333A7C File Offset: 0x00331C7C
		public static TrapDefenseActivity GetRootAsTrapDefenseActivity(ByteBuffer _bb)
		{
			return TrapDefenseActivity.GetRootAsTrapDefenseActivity(_bb, default(TrapDefenseActivity));
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x00333A98 File Offset: 0x00331C98
		public static TrapDefenseActivity GetRootAsTrapDefenseActivity(ByteBuffer _bb, TrapDefenseActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x00333AB5 File Offset: 0x00331CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x00333AC4 File Offset: 0x00331CC4
		public TrapDefenseActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600E169 RID: 57705 RVA: 0x00333AD4 File Offset: 0x00331CD4
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

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0600E16A RID: 57706 RVA: 0x00333B10 File Offset: 0x00331D10
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

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0600E16B RID: 57707 RVA: 0x00333B4C File Offset: 0x00331D4C
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

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600E16C RID: 57708 RVA: 0x00333B88 File Offset: 0x00331D88
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

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600E16D RID: 57709 RVA: 0x00333BC8 File Offset: 0x00331DC8
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

		// Token: 0x0600E16E RID: 57710 RVA: 0x00333C08 File Offset: 0x00331E08
		public int LevelGaining(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600E16F RID: 57711 RVA: 0x00333C48 File Offset: 0x00331E48
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

		// Token: 0x0600E170 RID: 57712 RVA: 0x00333C74 File Offset: 0x00331E74
		public Span<int> GetLevelGainingBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x00333C84 File Offset: 0x00331E84
		public int[] GetLevelGainingArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600E172 RID: 57714 RVA: 0x00333C9C File Offset: 0x00331E9C
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

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600E173 RID: 57715 RVA: 0x00333CDC File Offset: 0x00331EDC
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

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600E174 RID: 57716 RVA: 0x00333D1C File Offset: 0x00331F1C
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

		// Token: 0x0600E175 RID: 57717 RVA: 0x00333D5C File Offset: 0x00331F5C
		public IntArray? StarRatingConditions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600E176 RID: 57718 RVA: 0x00333DC0 File Offset: 0x00331FC0
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

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600E177 RID: 57719 RVA: 0x00333DEC File Offset: 0x00331FEC
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

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600E178 RID: 57720 RVA: 0x00333E2C File Offset: 0x0033202C
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

		// Token: 0x0600E179 RID: 57721 RVA: 0x00333E6C File Offset: 0x0033206C
		public int RewardBuildingTypes(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600E17A RID: 57722 RVA: 0x00333EAC File Offset: 0x003320AC
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

		// Token: 0x0600E17B RID: 57723 RVA: 0x00333ED8 File Offset: 0x003320D8
		public Span<int> GetRewardBuildingTypesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x00333EE8 File Offset: 0x003320E8
		public int[] GetRewardBuildingTypesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x00333F00 File Offset: 0x00332100
		public int RewardAuxiliaryTypes(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600E17E RID: 57726 RVA: 0x00333F40 File Offset: 0x00332140
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

		// Token: 0x0600E17F RID: 57727 RVA: 0x00333F6C File Offset: 0x0033216C
		public Span<int> GetRewardAuxiliaryTypesBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600E180 RID: 57728 RVA: 0x00333F7C File Offset: 0x0033217C
		public int[] GetRewardAuxiliaryTypesArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x00333F94 File Offset: 0x00332194
		public int RewardBd(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600E182 RID: 57730 RVA: 0x00333FD4 File Offset: 0x003321D4
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

		// Token: 0x0600E183 RID: 57731 RVA: 0x00334000 File Offset: 0x00332200
		public Span<int> GetRewardBdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600E184 RID: 57732 RVA: 0x00334010 File Offset: 0x00332210
		public int[] GetRewardBdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00334028 File Offset: 0x00332228
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

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600E186 RID: 57734 RVA: 0x00334068 File Offset: 0x00332268
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

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600E187 RID: 57735 RVA: 0x003340A8 File Offset: 0x003322A8
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

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600E188 RID: 57736 RVA: 0x003340E8 File Offset: 0x003322E8
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

		// Token: 0x0600E189 RID: 57737 RVA: 0x00334128 File Offset: 0x00332328
		public int DefaultBuildingType(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600E18A RID: 57738 RVA: 0x00334168 File Offset: 0x00332368
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

		// Token: 0x0600E18B RID: 57739 RVA: 0x00334194 File Offset: 0x00332394
		public Span<int> GetDefaultBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x003341A4 File Offset: 0x003323A4
		public int[] GetDefaultBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x003341BC File Offset: 0x003323BC
		public int DefaultAuxiliaryType(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600E18E RID: 57742 RVA: 0x003341FC File Offset: 0x003323FC
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

		// Token: 0x0600E18F RID: 57743 RVA: 0x00334228 File Offset: 0x00332428
		public Span<int> GetDefaultAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x00334238 File Offset: 0x00332438
		public int[] GetDefaultAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x00334250 File Offset: 0x00332450
		public int ForceBuildingType(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600E192 RID: 57746 RVA: 0x00334290 File Offset: 0x00332490
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

		// Token: 0x0600E193 RID: 57747 RVA: 0x003342BC File Offset: 0x003324BC
		public Span<int> GetForceBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x003342CC File Offset: 0x003324CC
		public int[] GetForceBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x003342E4 File Offset: 0x003324E4
		public int ForceAuxiliaryType(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600E196 RID: 57750 RVA: 0x00334324 File Offset: 0x00332524
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

		// Token: 0x0600E197 RID: 57751 RVA: 0x00334350 File Offset: 0x00332550
		public Span<int> GetForceAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600E198 RID: 57752 RVA: 0x00334360 File Offset: 0x00332560
		public int[] GetForceAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600E199 RID: 57753 RVA: 0x00334378 File Offset: 0x00332578
		public int RecommendBuildingType(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600E19A RID: 57754 RVA: 0x003343B8 File Offset: 0x003325B8
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

		// Token: 0x0600E19B RID: 57755 RVA: 0x003343E4 File Offset: 0x003325E4
		public Span<int> GetRecommendBuildingTypeBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600E19C RID: 57756 RVA: 0x003343F4 File Offset: 0x003325F4
		public int[] GetRecommendBuildingTypeArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600E19D RID: 57757 RVA: 0x0033440C File Offset: 0x0033260C
		public int RecommendAuxiliaryType(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600E19E RID: 57758 RVA: 0x0033444C File Offset: 0x0033264C
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

		// Token: 0x0600E19F RID: 57759 RVA: 0x00334478 File Offset: 0x00332678
		public Span<int> GetRecommendAuxiliaryTypeBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x00334488 File Offset: 0x00332688
		public int[] GetRecommendAuxiliaryTypeArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600E1A1 RID: 57761 RVA: 0x003344A0 File Offset: 0x003326A0
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

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600E1A2 RID: 57762 RVA: 0x003344E0 File Offset: 0x003326E0
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

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600E1A3 RID: 57763 RVA: 0x00334520 File Offset: 0x00332720
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

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600E1A4 RID: 57764 RVA: 0x00334560 File Offset: 0x00332760
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

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x003345A0 File Offset: 0x003327A0
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

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x003345D8 File Offset: 0x003327D8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x003345E8 File Offset: 0x003327E8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600E1A8 RID: 57768 RVA: 0x00334600 File Offset: 0x00332800
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

		// Token: 0x0600E1A9 RID: 57769 RVA: 0x00334638 File Offset: 0x00332838
		public Span<byte> GetLevelNameImageBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600E1AA RID: 57770 RVA: 0x00334648 File Offset: 0x00332848
		public byte[] GetLevelNameImageArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x00334660 File Offset: 0x00332860
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

		// Token: 0x0600E1AC RID: 57772 RVA: 0x00334698 File Offset: 0x00332898
		public Span<byte> GetLevelImageBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600E1AD RID: 57773 RVA: 0x003346A8 File Offset: 0x003328A8
		public byte[] GetLevelImageArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x003346C0 File Offset: 0x003328C0
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

		// Token: 0x0600E1AF RID: 57775 RVA: 0x003346F8 File Offset: 0x003328F8
		public Span<byte> GetResultImageBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x00334708 File Offset: 0x00332908
		public byte[] GetResultImageArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600E1B1 RID: 57777 RVA: 0x00334720 File Offset: 0x00332920
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

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x00334758 File Offset: 0x00332958
		public Span<byte> GetDifficultyDescBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x00334768 File Offset: 0x00332968
		public byte[] GetDifficultyDescArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E1B4 RID: 57780 RVA: 0x00334780 File Offset: 0x00332980
		public string DifficultyDescArgs(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x003347BC File Offset: 0x003329BC
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

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x003347E8 File Offset: 0x003329E8
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

		// Token: 0x0600E1B7 RID: 57783 RVA: 0x00334820 File Offset: 0x00332A20
		public Span<byte> GetLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600E1B8 RID: 57784 RVA: 0x00334830 File Offset: 0x00332A30
		public byte[] GetLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x00334848 File Offset: 0x00332A48
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

		// Token: 0x0600E1BA RID: 57786 RVA: 0x00334880 File Offset: 0x00332A80
		public Span<byte> GetTargetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x00334890 File Offset: 0x00332A90
		public byte[] GetTargetDescArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600E1BC RID: 57788 RVA: 0x003348A8 File Offset: 0x00332AA8
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

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x003348E8 File Offset: 0x00332AE8
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

		// Token: 0x0600E1BE RID: 57790 RVA: 0x00334920 File Offset: 0x00332B20
		public Span<byte> GetRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x00334930 File Offset: 0x00332B30
		public byte[] GetRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x00334948 File Offset: 0x00332B48
		public int UseBdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600E1C1 RID: 57793 RVA: 0x00334988 File Offset: 0x00332B88
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

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x003349B4 File Offset: 0x00332BB4
		public Span<int> GetUseBdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x003349C4 File Offset: 0x00332BC4
		public int[] GetUseBdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x003349DC File Offset: 0x00332BDC
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

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00334A1C File Offset: 0x00332C1C
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

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600E1C6 RID: 57798 RVA: 0x00334A5C File Offset: 0x00332C5C
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

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600E1C7 RID: 57799 RVA: 0x00334A9C File Offset: 0x00332C9C
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

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00334AD4 File Offset: 0x00332CD4
		public Span<byte> GetLoopStartWaveDescBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x00334AE4 File Offset: 0x00332CE4
		public byte[] GetLoopStartWaveDescArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E1CA RID: 57802 RVA: 0x00334AFC File Offset: 0x00332CFC
		public int SplineList(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600E1CB RID: 57803 RVA: 0x00334B3C File Offset: 0x00332D3C
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

		// Token: 0x0600E1CC RID: 57804 RVA: 0x00334B68 File Offset: 0x00332D68
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x00334B78 File Offset: 0x00332D78
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x00334B90 File Offset: 0x00332D90
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

		// Token: 0x0600E1CF RID: 57807 RVA: 0x00334BC8 File Offset: 0x00332DC8
		public Span<byte> GetLevelMapUiShowBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x00334BD8 File Offset: 0x00332DD8
		public byte[] GetLevelMapUiShowArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x00334BF0 File Offset: 0x00332DF0
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

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x00334C30 File Offset: 0x00332E30
		public bool NeedStarWhenPause
		{
			get
			{
				int num = this.__p.__offset(98);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x00334C70 File Offset: 0x00332E70
		public bool IsCanSave
		{
			get
			{
				int num = this.__p.__offset(100);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0600E1D4 RID: 57812 RVA: 0x00334CB0 File Offset: 0x00332EB0
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

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00334CF0 File Offset: 0x00332EF0
		public IntArray? ObstacleSegments(int j)
		{
			int num = this.__p.__offset(104);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x0600E1D6 RID: 57814 RVA: 0x00334D54 File Offset: 0x00332F54
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

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00334D80 File Offset: 0x00332F80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DefaultAuxiliaryTypeIter()或GetDefaultAuxiliaryTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DefaultAuxiliaryType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetDefaultAuxiliaryTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00334DA4 File Offset: 0x00332FA4
		[NullableContext(1)]
		public readonly IEnumerable<int> DefaultAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<DefaultAuxiliaryTypeIter>d__170 <DefaultAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<DefaultAuxiliaryTypeIter>d__170(-2);
			<DefaultAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <DefaultAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x00334DBC File Offset: 0x00332FBC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DefaultBuildingTypeIter()或GetDefaultBuildingTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DefaultBuildingType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetDefaultBuildingTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x00334DE0 File Offset: 0x00332FE0
		[NullableContext(1)]
		public readonly IEnumerable<int> DefaultBuildingTypeIter()
		{
			TrapDefenseActivity.<DefaultBuildingTypeIter>d__172 <DefaultBuildingTypeIter>d__ = new TrapDefenseActivity.<DefaultBuildingTypeIter>d__172(-2);
			<DefaultBuildingTypeIter>d__.<>3__<>4__this = this;
			return <DefaultBuildingTypeIter>d__;
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x00334DF5 File Offset: 0x00332FF5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyDescArgsIter()或GetDifficultyDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DifficultyDescArgs()
		{
			return this.DifficultyDescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x00334E02 File Offset: 0x00333002
		[NullableContext(1)]
		public readonly IEnumerable<string> DifficultyDescArgsIter()
		{
			TrapDefenseActivity.<DifficultyDescArgsIter>d__174 <DifficultyDescArgsIter>d__ = new TrapDefenseActivity.<DifficultyDescArgsIter>d__174(-2);
			<DifficultyDescArgsIter>d__.<>3__<>4__this = this;
			return <DifficultyDescArgsIter>d__;
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x00334E18 File Offset: 0x00333018
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ForceAuxiliaryTypeIter()或GetForceAuxiliaryTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ForceAuxiliaryType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetForceAuxiliaryTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x00334E3C File Offset: 0x0033303C
		[NullableContext(1)]
		public readonly IEnumerable<int> ForceAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<ForceAuxiliaryTypeIter>d__176 <ForceAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<ForceAuxiliaryTypeIter>d__176(-2);
			<ForceAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <ForceAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x00334E54 File Offset: 0x00333054
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ForceBuildingTypeIter()或GetForceBuildingTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ForceBuildingType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetForceBuildingTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x00334E78 File Offset: 0x00333078
		[NullableContext(1)]
		public readonly IEnumerable<int> ForceBuildingTypeIter()
		{
			TrapDefenseActivity.<ForceBuildingTypeIter>d__178 <ForceBuildingTypeIter>d__ = new TrapDefenseActivity.<ForceBuildingTypeIter>d__178(-2);
			<ForceBuildingTypeIter>d__.<>3__<>4__this = this;
			return <ForceBuildingTypeIter>d__;
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00334E90 File Offset: 0x00333090
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelGainingIter()或GetLevelGainingBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelGaining()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetLevelGainingArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x00334EB4 File Offset: 0x003330B4
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelGainingIter()
		{
			TrapDefenseActivity.<LevelGainingIter>d__180 <LevelGainingIter>d__ = new TrapDefenseActivity.<LevelGainingIter>d__180(-2);
			<LevelGainingIter>d__.<>3__<>4__this = this;
			return <LevelGainingIter>d__;
		}

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00334EC9 File Offset: 0x003330C9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ObstacleSegmentsIter()或GetObstacleSegmentsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] ObstacleSegments()
		{
			return this.ObstacleSegmentsIter().ToArray<IntArray>();
		}

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x00334ED6 File Offset: 0x003330D6
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> ObstacleSegmentsIter()
		{
			TrapDefenseActivity.<ObstacleSegmentsIter>d__182 <ObstacleSegmentsIter>d__ = new TrapDefenseActivity.<ObstacleSegmentsIter>d__182(-2);
			<ObstacleSegmentsIter>d__.<>3__<>4__this = this;
			return <ObstacleSegmentsIter>d__;
		}

		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00334EEC File Offset: 0x003330EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendAuxiliaryTypeIter()或GetRecommendAuxiliaryTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendAuxiliaryType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetRecommendAuxiliaryTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1E6 RID: 57830 RVA: 0x00334F10 File Offset: 0x00333110
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendAuxiliaryTypeIter()
		{
			TrapDefenseActivity.<RecommendAuxiliaryTypeIter>d__184 <RecommendAuxiliaryTypeIter>d__ = new TrapDefenseActivity.<RecommendAuxiliaryTypeIter>d__184(-2);
			<RecommendAuxiliaryTypeIter>d__.<>3__<>4__this = this;
			return <RecommendAuxiliaryTypeIter>d__;
		}

		// Token: 0x0600E1E7 RID: 57831 RVA: 0x00334F28 File Offset: 0x00333128
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendBuildingTypeIter()或GetRecommendBuildingTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendBuildingType()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetRecommendBuildingTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1E8 RID: 57832 RVA: 0x00334F4C File Offset: 0x0033314C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendBuildingTypeIter()
		{
			TrapDefenseActivity.<RecommendBuildingTypeIter>d__186 <RecommendBuildingTypeIter>d__ = new TrapDefenseActivity.<RecommendBuildingTypeIter>d__186(-2);
			<RecommendBuildingTypeIter>d__.<>3__<>4__this = this;
			return <RecommendBuildingTypeIter>d__;
		}

		// Token: 0x0600E1E9 RID: 57833 RVA: 0x00334F64 File Offset: 0x00333164
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardAuxiliaryTypesIter()或GetRewardAuxiliaryTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardAuxiliaryTypes()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetRewardAuxiliaryTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1EA RID: 57834 RVA: 0x00334F88 File Offset: 0x00333188
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardAuxiliaryTypesIter()
		{
			TrapDefenseActivity.<RewardAuxiliaryTypesIter>d__188 <RewardAuxiliaryTypesIter>d__ = new TrapDefenseActivity.<RewardAuxiliaryTypesIter>d__188(-2);
			<RewardAuxiliaryTypesIter>d__.<>3__<>4__this = this;
			return <RewardAuxiliaryTypesIter>d__;
		}

		// Token: 0x0600E1EB RID: 57835 RVA: 0x00334FA0 File Offset: 0x003331A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardBdIter()或GetRewardBdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardBd()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetRewardBdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1EC RID: 57836 RVA: 0x00334FC4 File Offset: 0x003331C4
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardBdIter()
		{
			TrapDefenseActivity.<RewardBdIter>d__190 <RewardBdIter>d__ = new TrapDefenseActivity.<RewardBdIter>d__190(-2);
			<RewardBdIter>d__.<>3__<>4__this = this;
			return <RewardBdIter>d__;
		}

		// Token: 0x0600E1ED RID: 57837 RVA: 0x00334FDC File Offset: 0x003331DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardBuildingTypesIter()或GetRewardBuildingTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardBuildingTypes()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetRewardBuildingTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1EE RID: 57838 RVA: 0x00335000 File Offset: 0x00333200
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardBuildingTypesIter()
		{
			TrapDefenseActivity.<RewardBuildingTypesIter>d__192 <RewardBuildingTypesIter>d__ = new TrapDefenseActivity.<RewardBuildingTypesIter>d__192(-2);
			<RewardBuildingTypesIter>d__.<>3__<>4__this = this;
			return <RewardBuildingTypesIter>d__;
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x00335018 File Offset: 0x00333218
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SplineListIter()或GetSplineListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SplineList()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetSplineListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1F0 RID: 57840 RVA: 0x0033503C File Offset: 0x0033323C
		[NullableContext(1)]
		public readonly IEnumerable<int> SplineListIter()
		{
			TrapDefenseActivity.<SplineListIter>d__194 <SplineListIter>d__ = new TrapDefenseActivity.<SplineListIter>d__194(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x00335051 File Offset: 0x00333251
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StarRatingConditionsIter()或GetStarRatingConditionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] StarRatingConditions()
		{
			return this.StarRatingConditionsIter().ToArray<IntArray>();
		}

		// Token: 0x0600E1F2 RID: 57842 RVA: 0x0033505E File Offset: 0x0033325E
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> StarRatingConditionsIter()
		{
			TrapDefenseActivity.<StarRatingConditionsIter>d__196 <StarRatingConditionsIter>d__ = new TrapDefenseActivity.<StarRatingConditionsIter>d__196(-2);
			<StarRatingConditionsIter>d__.<>3__<>4__this = this;
			return <StarRatingConditionsIter>d__;
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x00335074 File Offset: 0x00333274
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UseBdListIter()或GetUseBdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UseBdList()
		{
			TrapDefenseActivity trapDefenseActivity = this;
			return trapDefenseActivity.GetUseBdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E1F4 RID: 57844 RVA: 0x00335098 File Offset: 0x00333298
		[NullableContext(1)]
		public readonly IEnumerable<int> UseBdListIter()
		{
			TrapDefenseActivity.<UseBdListIter>d__198 <UseBdListIter>d__ = new TrapDefenseActivity.<UseBdListIter>d__198(-2);
			<UseBdListIter>d__.<>3__<>4__this = this;
			return <UseBdListIter>d__;
		}

		// Token: 0x04005297 RID: 21143
		private Table __p;
	}
}
