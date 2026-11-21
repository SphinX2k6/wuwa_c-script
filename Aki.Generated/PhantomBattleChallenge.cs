using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAE RID: 4014
	public struct PhantomBattleChallenge : IFlatbufferObject
	{
		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x002CAEE5 File Offset: 0x002C90E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x002CAEF2 File Offset: 0x002C90F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x002CAEFC File Offset: 0x002C90FC
		public static PhantomBattleChallenge GetRootAsPhantomBattleChallenge(ByteBuffer _bb)
		{
			return PhantomBattleChallenge.GetRootAsPhantomBattleChallenge(_bb, default(PhantomBattleChallenge));
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x002CAF18 File Offset: 0x002C9118
		public static PhantomBattleChallenge GetRootAsPhantomBattleChallenge(ByteBuffer _bb, PhantomBattleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x002CAF35 File Offset: 0x002C9135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x002CAF44 File Offset: 0x002C9144
		public PhantomBattleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x002CAF54 File Offset: 0x002C9154
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

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x002CAF90 File Offset: 0x002C9190
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

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x002CAFCC File Offset: 0x002C91CC
		public int GymId
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

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600AC61 RID: 44129 RVA: 0x002CB008 File Offset: 0x002C9208
		public int MarkId
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

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x002CB048 File Offset: 0x002C9248
		public int MapId
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

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x0600AC63 RID: 44131 RVA: 0x002CB088 File Offset: 0x002C9288
		public bool IsRecord
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x002CB0C8 File Offset: 0x002C92C8
		public bool EnableSkip
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x002CB108 File Offset: 0x002C9308
		public int QuestId
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

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002CB148 File Offset: 0x002C9348
		public int InstId
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

		// Token: 0x0600AC67 RID: 44135 RVA: 0x002CB188 File Offset: 0x002C9388
		public DicIntInt? DialogMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x002CB1EC File Offset: 0x002C93EC
		public int DialogMapLength
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

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600AC69 RID: 44137 RVA: 0x002CB218 File Offset: 0x002C9418
		public int OpenConditionGroupId
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

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x002CB258 File Offset: 0x002C9458
		public int ShowConditionGroupId
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

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600AC6B RID: 44139 RVA: 0x002CB298 File Offset: 0x002C9498
		public int UncoverConditionGroupId
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

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x002CB2D8 File Offset: 0x002C94D8
		public int FirstPassDropId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x002CB318 File Offset: 0x002C9518
		public DicIntInt? PassDropId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002CB37C File Offset: 0x002C957C
		public int PassDropIdLength
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

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x002CB3A8 File Offset: 0x002C95A8
		public int CardRoleId
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

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x002CB3E8 File Offset: 0x002C95E8
		public int CardGroupId
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

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x002CB428 File Offset: 0x002C9628
		public bool IsReChallenge
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x002CB468 File Offset: 0x002C9668
		public bool EnableCheckReChallengeFunc
		{
			get
			{
				int num = this.__p.__offset(40);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x002CB4A8 File Offset: 0x002C96A8
		public int Difficult
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

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x002CB4E8 File Offset: 0x002C96E8
		public int NpcGroupId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x002CB528 File Offset: 0x002C9728
		public int MaxRoundNum
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x002CB568 File Offset: 0x002C9768
		public int RecoverCostPoint
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

		// Token: 0x0600AC77 RID: 44151 RVA: 0x002CB5A8 File Offset: 0x002C97A8
		public int NpcChallengeSkillId(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x002CB5E8 File Offset: 0x002C97E8
		public int NpcChallengeSkillIdLength
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

		// Token: 0x0600AC79 RID: 44153 RVA: 0x002CB614 File Offset: 0x002C9814
		public Span<int> GetNpcChallengeSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x002CB624 File Offset: 0x002C9824
		public int[] GetNpcChallengeSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x002CB63C File Offset: 0x002C983C
		public string NpcSkillIconList(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x002CB678 File Offset: 0x002C9878
		public int NpcSkillIconListLength
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

		// Token: 0x0600AC7D RID: 44157 RVA: 0x002CB6A4 File Offset: 0x002C98A4
		public string NpcSkillNameList(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x002CB6E0 File Offset: 0x002C98E0
		public int NpcSkillNameListLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x002CB70C File Offset: 0x002C990C
		public string NpcSkillDescList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x002CB748 File Offset: 0x002C9948
		public int NpcSkillDescListLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x002CB774 File Offset: 0x002C9974
		public StringArray? NpcSkillDescParamsList(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x002CB7D8 File Offset: 0x002C99D8
		public int NpcSkillDescParamsListLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x002CB804 File Offset: 0x002C9A04
		public string ChallengeName
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x002CB83C File Offset: 0x002C9A3C
		public Span<byte> GetChallengeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x002CB84C File Offset: 0x002C9A4C
		public byte[] GetChallengeNameArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x002CB864 File Offset: 0x002C9A64
		public string NpcName
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

		// Token: 0x0600AC87 RID: 44167 RVA: 0x002CB89C File Offset: 0x002C9A9C
		public Span<byte> GetNpcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x002CB8AC File Offset: 0x002C9AAC
		public byte[] GetNpcNameArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x002CB8C4 File Offset: 0x002C9AC4
		public int Elements(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0600AC8A RID: 44170 RVA: 0x002CB904 File Offset: 0x002C9B04
		public int ElementsLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x002CB930 File Offset: 0x002C9B30
		public Span<int> GetElementsBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x002CB940 File Offset: 0x002C9B40
		public int[] GetElementsArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002CB958 File Offset: 0x002C9B58
		public string NpcTitle
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

		// Token: 0x0600AC8E RID: 44174 RVA: 0x002CB990 File Offset: 0x002C9B90
		public Span<byte> GetNpcTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x002CB9A0 File Offset: 0x002C9BA0
		public byte[] GetNpcTitleArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600AC90 RID: 44176 RVA: 0x002CB9B8 File Offset: 0x002C9BB8
		public int NpcLevel
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002CB9F8 File Offset: 0x002C9BF8
		public string NpcChallengeIcon
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

		// Token: 0x0600AC92 RID: 44178 RVA: 0x002CBA30 File Offset: 0x002C9C30
		public Span<byte> GetNpcChallengeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x002CBA40 File Offset: 0x002C9C40
		public byte[] GetNpcChallengeIconArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0600AC94 RID: 44180 RVA: 0x002CBA58 File Offset: 0x002C9C58
		public string NpcLevelIcon
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x002CBA90 File Offset: 0x002C9C90
		public Span<byte> GetNpcLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x002CBAA0 File Offset: 0x002C9CA0
		public byte[] GetNpcLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002CBAB8 File Offset: 0x002C9CB8
		public string NpcLevelBgIcon
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

		// Token: 0x0600AC98 RID: 44184 RVA: 0x002CBAF0 File Offset: 0x002C9CF0
		public Span<byte> GetNpcLevelBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x002CBB00 File Offset: 0x002C9D00
		public byte[] GetNpcLevelBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x0600AC9A RID: 44186 RVA: 0x002CBB18 File Offset: 0x002C9D18
		public string NpcDesc
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

		// Token: 0x0600AC9B RID: 44187 RVA: 0x002CBB50 File Offset: 0x002C9D50
		public Span<byte> GetNpcDescBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x002CBB60 File Offset: 0x002C9D60
		public byte[] GetNpcDescArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x002CBB78 File Offset: 0x002C9D78
		public string NpcIcon
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x002CBBB0 File Offset: 0x002C9DB0
		public Span<byte> GetNpcIconBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x002CBBC0 File Offset: 0x002C9DC0
		public byte[] GetNpcIconArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x002CBBD8 File Offset: 0x002C9DD8
		public string NpcHead
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

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x002CBC10 File Offset: 0x002C9E10
		public Span<byte> GetNpcHeadBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x002CBC20 File Offset: 0x002C9E20
		public byte[] GetNpcHeadArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x002CBC38 File Offset: 0x002C9E38
		public string NpcNumber
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x002CBC70 File Offset: 0x002C9E70
		public Span<byte> GetNpcNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x002CBC80 File Offset: 0x002C9E80
		public byte[] GetNpcNumberArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x002CBC98 File Offset: 0x002C9E98
		public int TeleporterId
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

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002CBCD8 File Offset: 0x002C9ED8
		public string PassConditionDesc
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x002CBD10 File Offset: 0x002C9F10
		public Span<byte> GetPassConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x002CBD20 File Offset: 0x002C9F20
		public byte[] GetPassConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600ACAA RID: 44202 RVA: 0x002CBD38 File Offset: 0x002C9F38
		public bool DeckCoreCardLocked
		{
			get
			{
				int num = this.__p.__offset(88);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600ACAB RID: 44203 RVA: 0x002CBD78 File Offset: 0x002C9F78
		public string BvbBattleLoadingBg
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

		// Token: 0x0600ACAC RID: 44204 RVA: 0x002CBDB0 File Offset: 0x002C9FB0
		public Span<byte> GetBvbBattleLoadingBgBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x002CBDC0 File Offset: 0x002C9FC0
		public byte[] GetBvbBattleLoadingBgArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x002CBDD8 File Offset: 0x002C9FD8
		public string BvbLoadingBg
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x002CBE10 File Offset: 0x002CA010
		public Span<byte> GetBvbLoadingBgBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x002CBE20 File Offset: 0x002CA020
		public byte[] GetBvbLoadingBgArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600ACB1 RID: 44209 RVA: 0x002CBE38 File Offset: 0x002CA038
		public string BvbLoadingTriangleBg
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

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x002CBE70 File Offset: 0x002CA070
		public Span<byte> GetBvbLoadingTriangleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x002CBE80 File Offset: 0x002CA080
		public byte[] GetBvbLoadingTriangleBgArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x002CBE98 File Offset: 0x002CA098
		public string BvbLoadingLeftHand
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x002CBED0 File Offset: 0x002CA0D0
		public Span<byte> GetBvbLoadingLeftHandBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x002CBEE0 File Offset: 0x002CA0E0
		public byte[] GetBvbLoadingLeftHandArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600ACB7 RID: 44215 RVA: 0x002CBEF8 File Offset: 0x002CA0F8
		public string BvbLoadingRightHand
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x002CBF30 File Offset: 0x002CA130
		public Span<byte> GetBvbLoadingRightHandBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x002CBF40 File Offset: 0x002CA140
		public byte[] GetBvbLoadingRightHandArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x002CBF58 File Offset: 0x002CA158
		public string BvbLoadingHandShadow
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x002CBF90 File Offset: 0x002CA190
		public Span<byte> GetBvbLoadingHandShadowBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x002CBFA0 File Offset: 0x002CA1A0
		public byte[] GetBvbLoadingHandShadowArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600ACBD RID: 44221 RVA: 0x002CBFB8 File Offset: 0x002CA1B8
		public string FieldInfoDesc
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x002CBFF0 File Offset: 0x002CA1F0
		public Span<byte> GetFieldInfoDescBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x002CC000 File Offset: 0x002CA200
		public byte[] GetFieldInfoDescArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600ACC0 RID: 44224 RVA: 0x002CC018 File Offset: 0x002CA218
		public int RecommendCardGroupId
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600ACC1 RID: 44225 RVA: 0x002CC058 File Offset: 0x002CA258
		public bool IsShowEntrance
		{
			get
			{
				int num = this.__p.__offset(106);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x002CC098 File Offset: 0x002CA298
		public int ReChallengeQuestId
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x0600ACC3 RID: 44227 RVA: 0x002CC0D8 File Offset: 0x002CA2D8
		public string NpcMapHead
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x002CC110 File Offset: 0x002CA310
		public Span<byte> GetNpcMapHeadBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x002CC120 File Offset: 0x002CA320
		public byte[] GetNpcMapHeadArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x002CC138 File Offset: 0x002CA338
		public int PreGuideQuest(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x0600ACC7 RID: 44231 RVA: 0x002CC178 File Offset: 0x002CA378
		public int PreGuideQuestLength
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x002CC1A4 File Offset: 0x002CA3A4
		public Span<int> GetPreGuideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(112, 4);
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x002CC1B4 File Offset: 0x002CA3B4
		public int[] GetPreGuideQuestArray()
		{
			return this.__p.__vector_as_array<int>(112) ?? Array.Empty<int>();
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x0600ACCA RID: 44234 RVA: 0x002CC1CC File Offset: 0x002CA3CC
		public bool IsWorldMapShowMark
		{
			get
			{
				int num = this.__p.__offset(114);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x002CC20C File Offset: 0x002CA40C
		[NullableContext(1)]
		public Dictionary<int, int> DialogMap()
		{
			return this.DialogMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x002CC262 File Offset: 0x002CA462
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DialogMapIter()
		{
			PhantomBattleChallenge.<DialogMapIter>d__174 <DialogMapIter>d__ = new PhantomBattleChallenge.<DialogMapIter>d__174(-2);
			<DialogMapIter>d__.<>3__<>4__this = this;
			return <DialogMapIter>d__;
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x002CC277 File Offset: 0x002CA477
		[NullableContext(1)]
		public int[] Elements()
		{
			return this.GetElementsArray();
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x002CC27F File Offset: 0x002CA47F
		[NullableContext(1)]
		public IEnumerable<int> ElementsIter()
		{
			PhantomBattleChallenge.<ElementsIter>d__176 <ElementsIter>d__ = new PhantomBattleChallenge.<ElementsIter>d__176(-2);
			<ElementsIter>d__.<>3__<>4__this = this;
			return <ElementsIter>d__;
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x002CC294 File Offset: 0x002CA494
		[NullableContext(1)]
		public int[] NpcChallengeSkillId()
		{
			return this.GetNpcChallengeSkillIdArray();
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x002CC29C File Offset: 0x002CA49C
		[NullableContext(1)]
		public IEnumerable<int> NpcChallengeSkillIdIter()
		{
			PhantomBattleChallenge.<NpcChallengeSkillIdIter>d__178 <NpcChallengeSkillIdIter>d__ = new PhantomBattleChallenge.<NpcChallengeSkillIdIter>d__178(-2);
			<NpcChallengeSkillIdIter>d__.<>3__<>4__this = this;
			return <NpcChallengeSkillIdIter>d__;
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x002CC2B1 File Offset: 0x002CA4B1
		[NullableContext(1)]
		public string[] NpcSkillDescList()
		{
			return this.NpcSkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x002CC2BE File Offset: 0x002CA4BE
		[NullableContext(1)]
		public IEnumerable<string> NpcSkillDescListIter()
		{
			PhantomBattleChallenge.<NpcSkillDescListIter>d__180 <NpcSkillDescListIter>d__ = new PhantomBattleChallenge.<NpcSkillDescListIter>d__180(-2);
			<NpcSkillDescListIter>d__.<>3__<>4__this = this;
			return <NpcSkillDescListIter>d__;
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x002CC2D3 File Offset: 0x002CA4D3
		[NullableContext(1)]
		public StringArray[] NpcSkillDescParamsList()
		{
			return this.NpcSkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x002CC2E0 File Offset: 0x002CA4E0
		[NullableContext(1)]
		public IEnumerable<StringArray> NpcSkillDescParamsListIter()
		{
			PhantomBattleChallenge.<NpcSkillDescParamsListIter>d__182 <NpcSkillDescParamsListIter>d__ = new PhantomBattleChallenge.<NpcSkillDescParamsListIter>d__182(-2);
			<NpcSkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <NpcSkillDescParamsListIter>d__;
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x002CC2F5 File Offset: 0x002CA4F5
		[NullableContext(1)]
		public string[] NpcSkillIconList()
		{
			return this.NpcSkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x002CC302 File Offset: 0x002CA502
		[NullableContext(1)]
		public IEnumerable<string> NpcSkillIconListIter()
		{
			PhantomBattleChallenge.<NpcSkillIconListIter>d__184 <NpcSkillIconListIter>d__ = new PhantomBattleChallenge.<NpcSkillIconListIter>d__184(-2);
			<NpcSkillIconListIter>d__.<>3__<>4__this = this;
			return <NpcSkillIconListIter>d__;
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x002CC317 File Offset: 0x002CA517
		[NullableContext(1)]
		public string[] NpcSkillNameList()
		{
			return this.NpcSkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x002CC324 File Offset: 0x002CA524
		[NullableContext(1)]
		public IEnumerable<string> NpcSkillNameListIter()
		{
			PhantomBattleChallenge.<NpcSkillNameListIter>d__186 <NpcSkillNameListIter>d__ = new PhantomBattleChallenge.<NpcSkillNameListIter>d__186(-2);
			<NpcSkillNameListIter>d__.<>3__<>4__this = this;
			return <NpcSkillNameListIter>d__;
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x002CC33C File Offset: 0x002CA53C
		[NullableContext(1)]
		public Dictionary<int, int> PassDropId()
		{
			return this.PassDropIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x002CC392 File Offset: 0x002CA592
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PassDropIdIter()
		{
			PhantomBattleChallenge.<PassDropIdIter>d__188 <PassDropIdIter>d__ = new PhantomBattleChallenge.<PassDropIdIter>d__188(-2);
			<PassDropIdIter>d__.<>3__<>4__this = this;
			return <PassDropIdIter>d__;
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x002CC3A7 File Offset: 0x002CA5A7
		[NullableContext(1)]
		public int[] PreGuideQuest()
		{
			return this.GetPreGuideQuestArray();
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x002CC3AF File Offset: 0x002CA5AF
		[NullableContext(1)]
		public IEnumerable<int> PreGuideQuestIter()
		{
			PhantomBattleChallenge.<PreGuideQuestIter>d__190 <PreGuideQuestIter>d__ = new PhantomBattleChallenge.<PreGuideQuestIter>d__190(-2);
			<PreGuideQuestIter>d__.<>3__<>4__this = this;
			return <PreGuideQuestIter>d__;
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x002CC3C4 File Offset: 0x002CA5C4
		public int? GetDialogMap(int key)
		{
			this.EnsureDialogMapCacheIfNeeded();
			int value;
			if (!this.DialogMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x002CC3F8 File Offset: 0x002CA5F8
		public int? GetPassDropId(int key)
		{
			this.EnsurePassDropIdCacheIfNeeded();
			int value;
			if (!this.PassDropIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x002CC42C File Offset: 0x002CA62C
		private void EnsureDialogMapCacheIfNeeded()
		{
			if (this.DialogMapCache != null)
			{
				return;
			}
			this.DialogMapCache = this.DialogMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x002CC494 File Offset: 0x002CA694
		private void EnsurePassDropIdCacheIfNeeded()
		{
			if (this.PassDropIdCache != null)
			{
				return;
			}
			this.PassDropIdCache = this.PassDropIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x002CC4FA File Offset: 0x002CA6FA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDialogMapFrozenDict()
		{
			this.EnsureDialogMapCacheIfNeeded();
			return this.DialogMapCache;
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x002CC508 File Offset: 0x002CA708
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPassDropIdFrozenDict()
		{
			this.EnsurePassDropIdCacheIfNeeded();
			return this.PassDropIdCache;
		}

		// Token: 0x0400556A RID: 21866
		private Table __p;

		// Token: 0x0400556B RID: 21867
		[Nullable(2)]
		private FrozenDictionary<int, int> DialogMapCache;

		// Token: 0x0400556C RID: 21868
		[Nullable(2)]
		private FrozenDictionary<int, int> PassDropIdCache;
	}
}
