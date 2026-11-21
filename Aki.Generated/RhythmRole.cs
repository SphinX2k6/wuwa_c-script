using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AA RID: 4266
	public struct RhythmRole : IFlatbufferObject
	{
		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x002FB5F4 File Offset: 0x002F97F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x002FB601 File Offset: 0x002F9801
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x002FB608 File Offset: 0x002F9808
		public static RhythmRole GetRootAsRhythmRole(ByteBuffer _bb)
		{
			return RhythmRole.GetRootAsRhythmRole(_bb, default(RhythmRole));
		}

		// Token: 0x0600C2AE RID: 49838 RVA: 0x002FB624 File Offset: 0x002F9824
		public static RhythmRole GetRootAsRhythmRole(ByteBuffer _bb, RhythmRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x002FB641 File Offset: 0x002F9841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x002FB650 File Offset: 0x002F9850
		public RhythmRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x002FB660 File Offset: 0x002F9860
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

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600C2B2 RID: 49842 RVA: 0x002FB69C File Offset: 0x002F989C
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

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x002FB6D8 File Offset: 0x002F98D8
		public int UnlockCondition
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

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600C2B4 RID: 49844 RVA: 0x002FB714 File Offset: 0x002F9914
		public bool DefaultRole
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x002FB754 File Offset: 0x002F9954
		public int Effect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600C2B6 RID: 49846 RVA: 0x002FB794 File Offset: 0x002F9994
		public int EffectLength
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

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x002FB7C0 File Offset: 0x002F99C0
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x002FB7D0 File Offset: 0x002F99D0
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x002FB7E8 File Offset: 0x002F99E8
		public string RoleNameText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x002FB820 File Offset: 0x002F9A20
		public Span<byte> GetRoleNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x002FB830 File Offset: 0x002F9A30
		public byte[] GetRoleNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600C2BC RID: 49852 RVA: 0x002FB848 File Offset: 0x002F9A48
		public string RoleHeadTexture
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

		// Token: 0x0600C2BD RID: 49853 RVA: 0x002FB880 File Offset: 0x002F9A80
		public Span<byte> GetRoleHeadTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x002FB890 File Offset: 0x002F9A90
		public byte[] GetRoleHeadTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600C2BF RID: 49855 RVA: 0x002FB8A8 File Offset: 0x002F9AA8
		public string RoleHeadTexture2
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

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x002FB8E0 File Offset: 0x002F9AE0
		public Span<byte> GetRoleHeadTexture2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x002FB8F0 File Offset: 0x002F9AF0
		public byte[] GetRoleHeadTexture2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x002FB908 File Offset: 0x002F9B08
		public int SkillEffectList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x002FB948 File Offset: 0x002F9B48
		public int SkillEffectListLength
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

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x002FB974 File Offset: 0x002F9B74
		public Span<int> GetSkillEffectListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x002FB984 File Offset: 0x002F9B84
		public int[] GetSkillEffectListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600C2C6 RID: 49862 RVA: 0x002FB99C File Offset: 0x002F9B9C
		public string SkillIcon
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

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x002FB9D4 File Offset: 0x002F9BD4
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x002FB9E4 File Offset: 0x002F9BE4
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600C2C9 RID: 49865 RVA: 0x002FB9FC File Offset: 0x002F9BFC
		public string RoleDesText
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

		// Token: 0x0600C2CA RID: 49866 RVA: 0x002FBA34 File Offset: 0x002F9C34
		public Span<byte> GetRoleDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x002FBA44 File Offset: 0x002F9C44
		public byte[] GetRoleDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600C2CC RID: 49868 RVA: 0x002FBA5C File Offset: 0x002F9C5C
		public string LockTips
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x002FBA94 File Offset: 0x002F9C94
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C2CE RID: 49870 RVA: 0x002FBAA4 File Offset: 0x002F9CA4
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x002FBABC File Offset: 0x002F9CBC
		public string RoleSkillText
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

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x002FBAF4 File Offset: 0x002F9CF4
		public Span<byte> GetRoleSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x002FBB04 File Offset: 0x002F9D04
		public byte[] GetRoleSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600C2D2 RID: 49874 RVA: 0x002FBB1C File Offset: 0x002F9D1C
		public string RoleSkillMusic
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x002FBB54 File Offset: 0x002F9D54
		public Span<byte> GetRoleSkillMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x002FBB64 File Offset: 0x002F9D64
		public byte[] GetRoleSkillMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x002FBB7C File Offset: 0x002F9D7C
		[NullableContext(1)]
		public int[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x002FBB84 File Offset: 0x002F9D84
		[NullableContext(1)]
		public IEnumerable<int> EffectIter()
		{
			RhythmRole.<EffectIter>d__59 <EffectIter>d__ = new RhythmRole.<EffectIter>d__59(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x002FBB99 File Offset: 0x002F9D99
		[NullableContext(1)]
		public int[] SkillEffectList()
		{
			return this.GetSkillEffectListArray();
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x002FBBA1 File Offset: 0x002F9DA1
		[NullableContext(1)]
		public IEnumerable<int> SkillEffectListIter()
		{
			RhythmRole.<SkillEffectListIter>d__61 <SkillEffectListIter>d__ = new RhythmRole.<SkillEffectListIter>d__61(-2);
			<SkillEffectListIter>d__.<>3__<>4__this = this;
			return <SkillEffectListIter>d__;
		}

		// Token: 0x04005684 RID: 22148
		private Table __p;
	}
}
