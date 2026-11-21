using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AF RID: 4527
	public struct Skill : IFlatbufferObject
	{
		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600DABB RID: 55995 RVA: 0x00330DA1 File Offset: 0x0032EFA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x00330DAE File Offset: 0x0032EFAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x00330DB8 File Offset: 0x0032EFB8
		public static Skill GetRootAsSkill(ByteBuffer _bb)
		{
			return Skill.GetRootAsSkill(_bb, default(Skill));
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x00330DD4 File Offset: 0x0032EFD4
		public static Skill GetRootAsSkill(ByteBuffer _bb, Skill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x00330DF1 File Offset: 0x0032EFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x00330E00 File Offset: 0x0032F000
		public Skill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x00330E10 File Offset: 0x0032F010
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

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600DAC2 RID: 56002 RVA: 0x00330E4C File Offset: 0x0032F04C
		public int SkillGroupId
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

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600DAC3 RID: 56003 RVA: 0x00330E88 File Offset: 0x0032F088
		public int SkillType
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

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x00330EC4 File Offset: 0x0032F0C4
		public int UpgradeCondition
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

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x00330F04 File Offset: 0x0032F104
		public int UpgradeSkillId
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

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x00330F44 File Offset: 0x0032F144
		public string SkillName
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

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00330F7C File Offset: 0x0032F17C
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x00330F8C File Offset: 0x0032F18C
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600DAC9 RID: 56009 RVA: 0x00330FA4 File Offset: 0x0032F1A4
		public int SkillLevelGroupId
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

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600DACA RID: 56010 RVA: 0x00330FE4 File Offset: 0x0032F1E4
		public int LeftSkillEffect
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

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600DACB RID: 56011 RVA: 0x00331024 File Offset: 0x0032F224
		public int MaxSkillLevel
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

		// Token: 0x0600DACC RID: 56012 RVA: 0x00331064 File Offset: 0x0032F264
		public int SkillInfoList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600DACD RID: 56013 RVA: 0x003310A4 File Offset: 0x0032F2A4
		public int SkillInfoListLength
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

		// Token: 0x0600DACE RID: 56014 RVA: 0x003310D0 File Offset: 0x0032F2D0
		public Span<int> GetSkillInfoListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DACF RID: 56015 RVA: 0x003310E0 File Offset: 0x0032F2E0
		public int[] GetSkillInfoListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DAD0 RID: 56016 RVA: 0x003310F8 File Offset: 0x0032F2F8
		public long BuffList(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600DAD1 RID: 56017 RVA: 0x00331144 File Offset: 0x0032F344
		public int BuffListLength
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

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x00331170 File Offset: 0x0032F370
		public Span<long> GetBuffListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600DAD3 RID: 56019 RVA: 0x00331185 File Offset: 0x0032F385
		public long[] GetBuffListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x003311C4 File Offset: 0x0032F3C4
		public long DamageList(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600DAD5 RID: 56021 RVA: 0x00331210 File Offset: 0x0032F410
		public int DamageListLength
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

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x0033123C File Offset: 0x0032F43C
		public Span<long> GetDamageListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x00331251 File Offset: 0x0032F451
		public long[] GetDamageListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x00331290 File Offset: 0x0032F490
		public string Icon
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

		// Token: 0x0600DAD9 RID: 56025 RVA: 0x003312C8 File Offset: 0x0032F4C8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x003312D8 File Offset: 0x0032F4D8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600DADB RID: 56027 RVA: 0x003312F0 File Offset: 0x0032F4F0
		public string EffectSkillPath
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

		// Token: 0x0600DADC RID: 56028 RVA: 0x00331328 File Offset: 0x0032F528
		public Span<byte> GetEffectSkillPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600DADD RID: 56029 RVA: 0x00331338 File Offset: 0x0032F538
		public byte[] GetEffectSkillPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600DADE RID: 56030 RVA: 0x00331350 File Offset: 0x0032F550
		public int SortIndex
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

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600DADF RID: 56031 RVA: 0x00331390 File Offset: 0x0032F590
		public string SkillDescribe
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

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x003313C8 File Offset: 0x0032F5C8
		public Span<byte> GetSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x003313D8 File Offset: 0x0032F5D8
		public byte[] GetSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x003313F0 File Offset: 0x0032F5F0
		public string SkillResume
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

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x00331428 File Offset: 0x0032F628
		public Span<byte> GetSkillResumeBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600DAE4 RID: 56036 RVA: 0x00331438 File Offset: 0x0032F638
		public byte[] GetSkillResumeArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00331450 File Offset: 0x0032F650
		public int SkillTagList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600DAE6 RID: 56038 RVA: 0x00331490 File Offset: 0x0032F690
		public int SkillTagListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x003314BC File Offset: 0x0032F6BC
		public Span<int> GetSkillTagListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600DAE8 RID: 56040 RVA: 0x003314CC File Offset: 0x0032F6CC
		public int[] GetSkillTagListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x003314E4 File Offset: 0x0032F6E4
		public string SkillDetailNum(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600DAEA RID: 56042 RVA: 0x00331520 File Offset: 0x0032F720
		public int SkillDetailNumLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DAEB RID: 56043 RVA: 0x0033154C File Offset: 0x0032F74C
		public string SkillResumeNum(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600DAEC RID: 56044 RVA: 0x00331588 File Offset: 0x0032F788
		public int SkillResumeNumLength
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

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600DAED RID: 56045 RVA: 0x003315B4 File Offset: 0x0032F7B4
		public string MultiSkillDescribe
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

		// Token: 0x0600DAEE RID: 56046 RVA: 0x003315EC File Offset: 0x0032F7EC
		public Span<byte> GetMultiSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x003315FC File Offset: 0x0032F7FC
		public byte[] GetMultiSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00331614 File Offset: 0x0032F814
		public string MultiSkillDetailNum(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x00331650 File Offset: 0x0032F850
		public int MultiSkillDetailNumLength
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

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600DAF2 RID: 56050 RVA: 0x0033167C File Offset: 0x0032F87C
		public int SkillShowTagType
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

		// Token: 0x0600DAF3 RID: 56051 RVA: 0x003316B9 File Offset: 0x0032F8B9
		[NullableContext(1)]
		public long[] BuffList()
		{
			return this.GetBuffListArray();
		}

		// Token: 0x0600DAF4 RID: 56052 RVA: 0x003316C1 File Offset: 0x0032F8C1
		[NullableContext(1)]
		public IEnumerable<long> BuffListIter()
		{
			Skill.<BuffListIter>d__82 <BuffListIter>d__ = new Skill.<BuffListIter>d__82(-2);
			<BuffListIter>d__.<>3__<>4__this = this;
			return <BuffListIter>d__;
		}

		// Token: 0x0600DAF5 RID: 56053 RVA: 0x003316D6 File Offset: 0x0032F8D6
		[NullableContext(1)]
		public long[] DamageList()
		{
			return this.GetDamageListArray();
		}

		// Token: 0x0600DAF6 RID: 56054 RVA: 0x003316DE File Offset: 0x0032F8DE
		[NullableContext(1)]
		public IEnumerable<long> DamageListIter()
		{
			Skill.<DamageListIter>d__84 <DamageListIter>d__ = new Skill.<DamageListIter>d__84(-2);
			<DamageListIter>d__.<>3__<>4__this = this;
			return <DamageListIter>d__;
		}

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x003316F3 File Offset: 0x0032F8F3
		[NullableContext(1)]
		public string[] MultiSkillDetailNum()
		{
			return this.MultiSkillDetailNumIter().ToArray<string>();
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00331700 File Offset: 0x0032F900
		[NullableContext(1)]
		public IEnumerable<string> MultiSkillDetailNumIter()
		{
			Skill.<MultiSkillDetailNumIter>d__86 <MultiSkillDetailNumIter>d__ = new Skill.<MultiSkillDetailNumIter>d__86(-2);
			<MultiSkillDetailNumIter>d__.<>3__<>4__this = this;
			return <MultiSkillDetailNumIter>d__;
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00331715 File Offset: 0x0032F915
		[NullableContext(1)]
		public string[] SkillDetailNum()
		{
			return this.SkillDetailNumIter().ToArray<string>();
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x00331722 File Offset: 0x0032F922
		[NullableContext(1)]
		public IEnumerable<string> SkillDetailNumIter()
		{
			Skill.<SkillDetailNumIter>d__88 <SkillDetailNumIter>d__ = new Skill.<SkillDetailNumIter>d__88(-2);
			<SkillDetailNumIter>d__.<>3__<>4__this = this;
			return <SkillDetailNumIter>d__;
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00331737 File Offset: 0x0032F937
		[NullableContext(1)]
		public int[] SkillInfoList()
		{
			return this.GetSkillInfoListArray();
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x0033173F File Offset: 0x0032F93F
		[NullableContext(1)]
		public IEnumerable<int> SkillInfoListIter()
		{
			Skill.<SkillInfoListIter>d__90 <SkillInfoListIter>d__ = new Skill.<SkillInfoListIter>d__90(-2);
			<SkillInfoListIter>d__.<>3__<>4__this = this;
			return <SkillInfoListIter>d__;
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00331754 File Offset: 0x0032F954
		[NullableContext(1)]
		public string[] SkillResumeNum()
		{
			return this.SkillResumeNumIter().ToArray<string>();
		}

		// Token: 0x0600DAFE RID: 56062 RVA: 0x00331761 File Offset: 0x0032F961
		[NullableContext(1)]
		public IEnumerable<string> SkillResumeNumIter()
		{
			Skill.<SkillResumeNumIter>d__92 <SkillResumeNumIter>d__ = new Skill.<SkillResumeNumIter>d__92(-2);
			<SkillResumeNumIter>d__.<>3__<>4__this = this;
			return <SkillResumeNumIter>d__;
		}

		// Token: 0x0600DAFF RID: 56063 RVA: 0x00331776 File Offset: 0x0032F976
		[NullableContext(1)]
		public int[] SkillTagList()
		{
			return this.GetSkillTagListArray();
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x0033177E File Offset: 0x0032F97E
		[NullableContext(1)]
		public IEnumerable<int> SkillTagListIter()
		{
			Skill.<SkillTagListIter>d__94 <SkillTagListIter>d__ = new Skill.<SkillTagListIter>d__94(-2);
			<SkillTagListIter>d__.<>3__<>4__this = this;
			return <SkillTagListIter>d__;
		}

		// Token: 0x040057C8 RID: 22472
		private Table __p;
	}
}
