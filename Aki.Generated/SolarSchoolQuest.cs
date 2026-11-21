using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F6 RID: 4598
	public struct SolarSchoolQuest : IFlatbufferObject
	{
		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600E29C RID: 58012 RVA: 0x00343919 File Offset: 0x00341B19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x00343926 File Offset: 0x00341B26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x00343930 File Offset: 0x00341B30
		public static SolarSchoolQuest GetRootAsSolarSchoolQuest(ByteBuffer _bb)
		{
			return SolarSchoolQuest.GetRootAsSolarSchoolQuest(_bb, default(SolarSchoolQuest));
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x0034394C File Offset: 0x00341B4C
		public static SolarSchoolQuest GetRootAsSolarSchoolQuest(ByteBuffer _bb, SolarSchoolQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x00343969 File Offset: 0x00341B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x00343978 File Offset: 0x00341B78
		public SolarSchoolQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600E2A2 RID: 58018 RVA: 0x00343988 File Offset: 0x00341B88
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

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x003439C4 File Offset: 0x00341BC4
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

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600E2A4 RID: 58020 RVA: 0x00343A00 File Offset: 0x00341C00
		public int LogicNodeType
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

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x00343A3C File Offset: 0x00341C3C
		public int StartDayIndex
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

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600E2A6 RID: 58022 RVA: 0x00343A7C File Offset: 0x00341C7C
		public int EndDayIndex
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

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x00343ABC File Offset: 0x00341CBC
		public int PreConditionGroupId
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

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x00343AFC File Offset: 0x00341CFC
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

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x00343B34 File Offset: 0x00341D34
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x00343B44 File Offset: 0x00341D44
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00343B5C File Offset: 0x00341D5C
		public int QuestNodeList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x00343B9C File Offset: 0x00341D9C
		public int QuestNodeListLength
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

		// Token: 0x0600E2AD RID: 58029 RVA: 0x00343BC8 File Offset: 0x00341DC8
		public Span<int> GetQuestNodeListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E2AE RID: 58030 RVA: 0x00343BD8 File Offset: 0x00341DD8
		public int[] GetQuestNodeListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2AF RID: 58031 RVA: 0x00343BF0 File Offset: 0x00341DF0
		public int QuestRewardList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600E2B0 RID: 58032 RVA: 0x00343C30 File Offset: 0x00341E30
		public int QuestRewardListLength
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

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x00343C5C File Offset: 0x00341E5C
		public Span<int> GetQuestRewardListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x00343C6C File Offset: 0x00341E6C
		public int[] GetQuestRewardListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2B3 RID: 58035 RVA: 0x00343C84 File Offset: 0x00341E84
		public int ParentIdList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600E2B4 RID: 58036 RVA: 0x00343CC4 File Offset: 0x00341EC4
		public int ParentIdListLength
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

		// Token: 0x0600E2B5 RID: 58037 RVA: 0x00343CF0 File Offset: 0x00341EF0
		public Span<int> GetParentIdListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x00343D00 File Offset: 0x00341F00
		public int[] GetParentIdListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x00343D18 File Offset: 0x00341F18
		public int ShowParentIdList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600E2B8 RID: 58040 RVA: 0x00343D58 File Offset: 0x00341F58
		public int ShowParentIdListLength
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

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x00343D84 File Offset: 0x00341F84
		public Span<int> GetShowParentIdListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x00343D94 File Offset: 0x00341F94
		public int[] GetShowParentIdListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x00343DAC File Offset: 0x00341FAC
		public bool UnlockAutoOpen
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600E2BC RID: 58044 RVA: 0x00343DEC File Offset: 0x00341FEC
		public int ShowConditionGroupId
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

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x00343E2C File Offset: 0x0034202C
		public int Sort
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

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x00343E6C File Offset: 0x0034206C
		public int ShowType
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

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x00343EAC File Offset: 0x003420AC
		public int Influence
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

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600E2C0 RID: 58048 RVA: 0x00343EEC File Offset: 0x003420EC
		public string ImportantIcon
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

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00343F24 File Offset: 0x00342124
		public Span<byte> GetImportantIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x00343F34 File Offset: 0x00342134
		public byte[] GetImportantIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x00343F4C File Offset: 0x0034214C
		public int RoleSpineId
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

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600E2C4 RID: 58052 RVA: 0x00343F8C File Offset: 0x0034218C
		public string RoleIcon
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

		// Token: 0x0600E2C5 RID: 58053 RVA: 0x00343FC4 File Offset: 0x003421C4
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x00343FD4 File Offset: 0x003421D4
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x00343FEC File Offset: 0x003421EC
		public string RoleFinishIcon
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

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x00344024 File Offset: 0x00342224
		public Span<byte> GetRoleFinishIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x00344034 File Offset: 0x00342234
		public byte[] GetRoleFinishIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600E2CA RID: 58058 RVA: 0x0034404C File Offset: 0x0034224C
		public string RoleExpireIcon
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

		// Token: 0x0600E2CB RID: 58059 RVA: 0x00344084 File Offset: 0x00342284
		public Span<byte> GetRoleExpireIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00344094 File Offset: 0x00342294
		public byte[] GetRoleExpireIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600E2CD RID: 58061 RVA: 0x003440AC File Offset: 0x003422AC
		public int TargetProgress
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

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600E2CE RID: 58062 RVA: 0x003440EC File Offset: 0x003422EC
		public int RewardItem
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

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x0034412C File Offset: 0x0034232C
		public int ShowItemId
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

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x0034416C File Offset: 0x0034236C
		public string MainDesc
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x003441A4 File Offset: 0x003423A4
		public Span<byte> GetMainDescBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x003441B4 File Offset: 0x003423B4
		public byte[] GetMainDescArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600E2D3 RID: 58067 RVA: 0x003441CC File Offset: 0x003423CC
		public int BitFlag
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2D4 RID: 58068 RVA: 0x00344209 File Offset: 0x00342409
		[NullableContext(1)]
		public int[] ParentIdList()
		{
			return this.GetParentIdListArray();
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00344211 File Offset: 0x00342411
		[NullableContext(1)]
		public IEnumerable<int> ParentIdListIter()
		{
			SolarSchoolQuest.<ParentIdListIter>d__85 <ParentIdListIter>d__ = new SolarSchoolQuest.<ParentIdListIter>d__85(-2);
			<ParentIdListIter>d__.<>3__<>4__this = this;
			return <ParentIdListIter>d__;
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x00344226 File Offset: 0x00342426
		[NullableContext(1)]
		public int[] QuestNodeList()
		{
			return this.GetQuestNodeListArray();
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x0034422E File Offset: 0x0034242E
		[NullableContext(1)]
		public IEnumerable<int> QuestNodeListIter()
		{
			SolarSchoolQuest.<QuestNodeListIter>d__87 <QuestNodeListIter>d__ = new SolarSchoolQuest.<QuestNodeListIter>d__87(-2);
			<QuestNodeListIter>d__.<>3__<>4__this = this;
			return <QuestNodeListIter>d__;
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x00344243 File Offset: 0x00342443
		[NullableContext(1)]
		public int[] QuestRewardList()
		{
			return this.GetQuestRewardListArray();
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x0034424B File Offset: 0x0034244B
		[NullableContext(1)]
		public IEnumerable<int> QuestRewardListIter()
		{
			SolarSchoolQuest.<QuestRewardListIter>d__89 <QuestRewardListIter>d__ = new SolarSchoolQuest.<QuestRewardListIter>d__89(-2);
			<QuestRewardListIter>d__.<>3__<>4__this = this;
			return <QuestRewardListIter>d__;
		}

		// Token: 0x0600E2DA RID: 58074 RVA: 0x00344260 File Offset: 0x00342460
		[NullableContext(1)]
		public int[] ShowParentIdList()
		{
			return this.GetShowParentIdListArray();
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x00344268 File Offset: 0x00342468
		[NullableContext(1)]
		public IEnumerable<int> ShowParentIdListIter()
		{
			SolarSchoolQuest.<ShowParentIdListIter>d__91 <ShowParentIdListIter>d__ = new SolarSchoolQuest.<ShowParentIdListIter>d__91(-2);
			<ShowParentIdListIter>d__.<>3__<>4__this = this;
			return <ShowParentIdListIter>d__;
		}

		// Token: 0x04005834 RID: 22580
		private Table __p;
	}
}
