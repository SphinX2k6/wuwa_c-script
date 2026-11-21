using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAC RID: 4012
	public struct PhantomBattleCardRole : IFlatbufferObject
	{
		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x002CA299 File Offset: 0x002C8499
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x002CA2A6 File Offset: 0x002C84A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x002CA2B0 File Offset: 0x002C84B0
		public static PhantomBattleCardRole GetRootAsPhantomBattleCardRole(ByteBuffer _bb)
		{
			return PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(_bb, default(PhantomBattleCardRole));
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x002CA2CC File Offset: 0x002C84CC
		public static PhantomBattleCardRole GetRootAsPhantomBattleCardRole(ByteBuffer _bb, PhantomBattleCardRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x002CA2E9 File Offset: 0x002C84E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x002CA2F8 File Offset: 0x002C84F8
		public PhantomBattleCardRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x002CA308 File Offset: 0x002C8508
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

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x002CA344 File Offset: 0x002C8544
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

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x002CA380 File Offset: 0x002C8580
		public int RoleConfigId
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

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x002CA3BC File Offset: 0x002C85BC
		public int Type
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

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x002CA3FC File Offset: 0x002C85FC
		public int DropId
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

		// Token: 0x0600AC06 RID: 44038 RVA: 0x002CA43C File Offset: 0x002C863C
		public int ActiveSkillId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x002CA47C File Offset: 0x002C867C
		public int ActiveSkillIdLength
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

		// Token: 0x0600AC08 RID: 44040 RVA: 0x002CA4A8 File Offset: 0x002C86A8
		public Span<int> GetActiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x002CA4B8 File Offset: 0x002C86B8
		public int[] GetActiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x002CA4D0 File Offset: 0x002C86D0
		public int PassiveSkillId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x002CA510 File Offset: 0x002C8710
		public int PassiveSkillIdLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x002CA53C File Offset: 0x002C873C
		public Span<int> GetPassiveSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x002CA54C File Offset: 0x002C874C
		public int[] GetPassiveSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x002CA564 File Offset: 0x002C8764
		public string SkillIconList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0600AC0F RID: 44047 RVA: 0x002CA5A0 File Offset: 0x002C87A0
		public int SkillIconListLength
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

		// Token: 0x0600AC10 RID: 44048 RVA: 0x002CA5CC File Offset: 0x002C87CC
		public string SkillNameList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x002CA608 File Offset: 0x002C8808
		public int SkillNameListLength
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

		// Token: 0x0600AC12 RID: 44050 RVA: 0x002CA634 File Offset: 0x002C8834
		public string SkillDescList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600AC13 RID: 44051 RVA: 0x002CA670 File Offset: 0x002C8870
		public int SkillDescListLength
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

		// Token: 0x0600AC14 RID: 44052 RVA: 0x002CA69C File Offset: 0x002C889C
		public StringArray? SkillDescParamsList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x002CA700 File Offset: 0x002C8900
		public int SkillDescParamsListLength
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

		// Token: 0x0600AC16 RID: 44054 RVA: 0x002CA72C File Offset: 0x002C892C
		public string PassiveSkillIconList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x002CA768 File Offset: 0x002C8968
		public int PassiveSkillIconListLength
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

		// Token: 0x0600AC18 RID: 44056 RVA: 0x002CA794 File Offset: 0x002C8994
		public string PassiveSkillNameList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x002CA7D0 File Offset: 0x002C89D0
		public int PassiveSkillNameListLength
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

		// Token: 0x0600AC1A RID: 44058 RVA: 0x002CA7FC File Offset: 0x002C89FC
		public string PassiveSkillDescList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x0600AC1B RID: 44059 RVA: 0x002CA838 File Offset: 0x002C8A38
		public int PassiveSkillDescListLength
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

		// Token: 0x0600AC1C RID: 44060 RVA: 0x002CA864 File Offset: 0x002C8A64
		public StringArray? PassiveSkillDescParamsList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x002CA8C8 File Offset: 0x002C8AC8
		public int PassiveSkillDescParamsListLength
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

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x002CA8F4 File Offset: 0x002C8AF4
		public string UnlockConditionTip
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

		// Token: 0x0600AC1F RID: 44063 RVA: 0x002CA92C File Offset: 0x002C8B2C
		public Span<byte> GetUnlockConditionTipBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x002CA93C File Offset: 0x002C8B3C
		public byte[] GetUnlockConditionTipArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600AC21 RID: 44065 RVA: 0x002CA954 File Offset: 0x002C8B54
		public string RoleSkillTexture
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

		// Token: 0x0600AC22 RID: 44066 RVA: 0x002CA98C File Offset: 0x002C8B8C
		public Span<byte> GetRoleSkillTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x002CA99C File Offset: 0x002C8B9C
		public byte[] GetRoleSkillTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x002CA9B4 File Offset: 0x002C8BB4
		public string RoleHeadTexture
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x002CA9EC File Offset: 0x002C8BEC
		public Span<byte> GetRoleHeadTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x002CA9FC File Offset: 0x002C8BFC
		public byte[] GetRoleHeadTextureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x0600AC27 RID: 44071 RVA: 0x002CAA14 File Offset: 0x002C8C14
		public string RoleSpinePrefabPath
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

		// Token: 0x0600AC28 RID: 44072 RVA: 0x002CAA4C File Offset: 0x002C8C4C
		public Span<byte> GetRoleSpinePrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x002CAA5C File Offset: 0x002C8C5C
		public byte[] GetRoleSpinePrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x002CAA74 File Offset: 0x002C8C74
		public string RoleTexture
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

		// Token: 0x0600AC2B RID: 44075 RVA: 0x002CAAAC File Offset: 0x002C8CAC
		public Span<byte> GetRoleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x002CAABC File Offset: 0x002C8CBC
		public byte[] GetRoleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x002CAAD4 File Offset: 0x002C8CD4
		public string RoleMaskTexture
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

		// Token: 0x0600AC2E RID: 44078 RVA: 0x002CAB0C File Offset: 0x002C8D0C
		public Span<byte> GetRoleMaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x002CAB1C File Offset: 0x002C8D1C
		public byte[] GetRoleMaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x002CAB34 File Offset: 0x002C8D34
		public string LightTextureColor
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

		// Token: 0x0600AC31 RID: 44081 RVA: 0x002CAB6C File Offset: 0x002C8D6C
		public Span<byte> GetLightTextureColorBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x002CAB7C File Offset: 0x002C8D7C
		public byte[] GetLightTextureColorArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600AC33 RID: 44083 RVA: 0x002CAB94 File Offset: 0x002C8D94
		public string RolePreviewTexture
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x002CABCC File Offset: 0x002C8DCC
		public Span<byte> GetRolePreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x002CABDC File Offset: 0x002C8DDC
		public byte[] GetRolePreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x002CABF4 File Offset: 0x002C8DF4
		public bool IsTrail
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600AC37 RID: 44087 RVA: 0x002CAC34 File Offset: 0x002C8E34
		public string BgDesc
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

		// Token: 0x0600AC38 RID: 44088 RVA: 0x002CAC6C File Offset: 0x002C8E6C
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x002CAC7C File Offset: 0x002C8E7C
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x002CAC94 File Offset: 0x002C8E94
		[NullableContext(1)]
		public int[] ActiveSkillId()
		{
			return this.GetActiveSkillIdArray();
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x002CAC9C File Offset: 0x002C8E9C
		[NullableContext(1)]
		public IEnumerable<int> ActiveSkillIdIter()
		{
			PhantomBattleCardRole.<ActiveSkillIdIter>d__91 <ActiveSkillIdIter>d__ = new PhantomBattleCardRole.<ActiveSkillIdIter>d__91(-2);
			<ActiveSkillIdIter>d__.<>3__<>4__this = this;
			return <ActiveSkillIdIter>d__;
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x002CACB1 File Offset: 0x002C8EB1
		[NullableContext(1)]
		public string[] PassiveSkillDescList()
		{
			return this.PassiveSkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x002CACBE File Offset: 0x002C8EBE
		[NullableContext(1)]
		public IEnumerable<string> PassiveSkillDescListIter()
		{
			PhantomBattleCardRole.<PassiveSkillDescListIter>d__93 <PassiveSkillDescListIter>d__ = new PhantomBattleCardRole.<PassiveSkillDescListIter>d__93(-2);
			<PassiveSkillDescListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillDescListIter>d__;
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x002CACD3 File Offset: 0x002C8ED3
		[NullableContext(1)]
		public StringArray[] PassiveSkillDescParamsList()
		{
			return this.PassiveSkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x002CACE0 File Offset: 0x002C8EE0
		[NullableContext(1)]
		public IEnumerable<StringArray> PassiveSkillDescParamsListIter()
		{
			PhantomBattleCardRole.<PassiveSkillDescParamsListIter>d__95 <PassiveSkillDescParamsListIter>d__ = new PhantomBattleCardRole.<PassiveSkillDescParamsListIter>d__95(-2);
			<PassiveSkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillDescParamsListIter>d__;
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x002CACF5 File Offset: 0x002C8EF5
		[NullableContext(1)]
		public string[] PassiveSkillIconList()
		{
			return this.PassiveSkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x002CAD02 File Offset: 0x002C8F02
		[NullableContext(1)]
		public IEnumerable<string> PassiveSkillIconListIter()
		{
			PhantomBattleCardRole.<PassiveSkillIconListIter>d__97 <PassiveSkillIconListIter>d__ = new PhantomBattleCardRole.<PassiveSkillIconListIter>d__97(-2);
			<PassiveSkillIconListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIconListIter>d__;
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x002CAD17 File Offset: 0x002C8F17
		[NullableContext(1)]
		public int[] PassiveSkillId()
		{
			return this.GetPassiveSkillIdArray();
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x002CAD1F File Offset: 0x002C8F1F
		[NullableContext(1)]
		public IEnumerable<int> PassiveSkillIdIter()
		{
			PhantomBattleCardRole.<PassiveSkillIdIter>d__99 <PassiveSkillIdIter>d__ = new PhantomBattleCardRole.<PassiveSkillIdIter>d__99(-2);
			<PassiveSkillIdIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIdIter>d__;
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x002CAD34 File Offset: 0x002C8F34
		[NullableContext(1)]
		public string[] PassiveSkillNameList()
		{
			return this.PassiveSkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600AC45 RID: 44101 RVA: 0x002CAD41 File Offset: 0x002C8F41
		[NullableContext(1)]
		public IEnumerable<string> PassiveSkillNameListIter()
		{
			PhantomBattleCardRole.<PassiveSkillNameListIter>d__101 <PassiveSkillNameListIter>d__ = new PhantomBattleCardRole.<PassiveSkillNameListIter>d__101(-2);
			<PassiveSkillNameListIter>d__.<>3__<>4__this = this;
			return <PassiveSkillNameListIter>d__;
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x002CAD56 File Offset: 0x002C8F56
		[NullableContext(1)]
		public string[] SkillDescList()
		{
			return this.SkillDescListIter().ToArray<string>();
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x002CAD63 File Offset: 0x002C8F63
		[NullableContext(1)]
		public IEnumerable<string> SkillDescListIter()
		{
			PhantomBattleCardRole.<SkillDescListIter>d__103 <SkillDescListIter>d__ = new PhantomBattleCardRole.<SkillDescListIter>d__103(-2);
			<SkillDescListIter>d__.<>3__<>4__this = this;
			return <SkillDescListIter>d__;
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x002CAD78 File Offset: 0x002C8F78
		[NullableContext(1)]
		public StringArray[] SkillDescParamsList()
		{
			return this.SkillDescParamsListIter().ToArray<StringArray>();
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x002CAD85 File Offset: 0x002C8F85
		[NullableContext(1)]
		public IEnumerable<StringArray> SkillDescParamsListIter()
		{
			PhantomBattleCardRole.<SkillDescParamsListIter>d__105 <SkillDescParamsListIter>d__ = new PhantomBattleCardRole.<SkillDescParamsListIter>d__105(-2);
			<SkillDescParamsListIter>d__.<>3__<>4__this = this;
			return <SkillDescParamsListIter>d__;
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x002CAD9A File Offset: 0x002C8F9A
		[NullableContext(1)]
		public string[] SkillIconList()
		{
			return this.SkillIconListIter().ToArray<string>();
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x002CADA7 File Offset: 0x002C8FA7
		[NullableContext(1)]
		public IEnumerable<string> SkillIconListIter()
		{
			PhantomBattleCardRole.<SkillIconListIter>d__107 <SkillIconListIter>d__ = new PhantomBattleCardRole.<SkillIconListIter>d__107(-2);
			<SkillIconListIter>d__.<>3__<>4__this = this;
			return <SkillIconListIter>d__;
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x002CADBC File Offset: 0x002C8FBC
		[NullableContext(1)]
		public string[] SkillNameList()
		{
			return this.SkillNameListIter().ToArray<string>();
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x002CADC9 File Offset: 0x002C8FC9
		[NullableContext(1)]
		public IEnumerable<string> SkillNameListIter()
		{
			PhantomBattleCardRole.<SkillNameListIter>d__109 <SkillNameListIter>d__ = new PhantomBattleCardRole.<SkillNameListIter>d__109(-2);
			<SkillNameListIter>d__.<>3__<>4__this = this;
			return <SkillNameListIter>d__;
		}

		// Token: 0x04005568 RID: 21864
		private Table __p;
	}
}
