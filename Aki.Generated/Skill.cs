using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B4 RID: 4276
	public struct Skill : IFlatbufferObject
	{
		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x00311865 File Offset: 0x0030FA65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x00311872 File Offset: 0x0030FA72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x0031187C File Offset: 0x0030FA7C
		public static Skill GetRootAsSkill(ByteBuffer _bb)
		{
			return Skill.GetRootAsSkill(_bb, default(Skill));
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x00311898 File Offset: 0x0030FA98
		public static Skill GetRootAsSkill(ByteBuffer _bb, Skill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x003118B5 File Offset: 0x0030FAB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x003118C4 File Offset: 0x0030FAC4
		public Skill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x003118D4 File Offset: 0x0030FAD4
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

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600D2E5 RID: 53989 RVA: 0x00311910 File Offset: 0x0030FB10
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

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600D2E6 RID: 53990 RVA: 0x0031194C File Offset: 0x0030FB4C
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

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600D2E7 RID: 53991 RVA: 0x00311988 File Offset: 0x0030FB88
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

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600D2E8 RID: 53992 RVA: 0x003119C8 File Offset: 0x0030FBC8
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

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600D2E9 RID: 53993 RVA: 0x00311A08 File Offset: 0x0030FC08
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

		// Token: 0x0600D2EA RID: 53994 RVA: 0x00311A40 File Offset: 0x0030FC40
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D2EB RID: 53995 RVA: 0x00311A50 File Offset: 0x0030FC50
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600D2EC RID: 53996 RVA: 0x00311A68 File Offset: 0x0030FC68
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

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600D2ED RID: 53997 RVA: 0x00311AA8 File Offset: 0x0030FCA8
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

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600D2EE RID: 53998 RVA: 0x00311AE8 File Offset: 0x0030FCE8
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

		// Token: 0x0600D2EF RID: 53999 RVA: 0x00311B28 File Offset: 0x0030FD28
		public int SkillInfoList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x00311B68 File Offset: 0x0030FD68
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

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x00311B94 File Offset: 0x0030FD94
		public Span<int> GetSkillInfoListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600D2F2 RID: 54002 RVA: 0x00311BA4 File Offset: 0x0030FDA4
		public int[] GetSkillInfoListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x00311BBC File Offset: 0x0030FDBC
		public long BuffList(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600D2F4 RID: 54004 RVA: 0x00311C08 File Offset: 0x0030FE08
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

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x00311C34 File Offset: 0x0030FE34
		public Span<long> GetBuffListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x00311C49 File Offset: 0x0030FE49
		public long[] GetBuffListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x00311C88 File Offset: 0x0030FE88
		public long DamageList(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600D2F8 RID: 54008 RVA: 0x00311CD4 File Offset: 0x0030FED4
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

		// Token: 0x0600D2F9 RID: 54009 RVA: 0x00311D00 File Offset: 0x0030FF00
		public Span<long> GetDamageListBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x0600D2FA RID: 54010 RVA: 0x00311D15 File Offset: 0x0030FF15
		public long[] GetDamageListArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600D2FB RID: 54011 RVA: 0x00311D54 File Offset: 0x0030FF54
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

		// Token: 0x0600D2FC RID: 54012 RVA: 0x00311D8C File Offset: 0x0030FF8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D2FD RID: 54013 RVA: 0x00311D9C File Offset: 0x0030FF9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x00311DB4 File Offset: 0x0030FFB4
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

		// Token: 0x0600D2FF RID: 54015 RVA: 0x00311DEC File Offset: 0x0030FFEC
		public Span<byte> GetEffectSkillPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x00311DFC File Offset: 0x0030FFFC
		public byte[] GetEffectSkillPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600D301 RID: 54017 RVA: 0x00311E14 File Offset: 0x00310014
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

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600D302 RID: 54018 RVA: 0x00311E54 File Offset: 0x00310054
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

		// Token: 0x0600D303 RID: 54019 RVA: 0x00311E8C File Offset: 0x0031008C
		public Span<byte> GetSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D304 RID: 54020 RVA: 0x00311E9C File Offset: 0x0031009C
		public byte[] GetSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600D305 RID: 54021 RVA: 0x00311EB4 File Offset: 0x003100B4
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

		// Token: 0x0600D306 RID: 54022 RVA: 0x00311EEC File Offset: 0x003100EC
		public Span<byte> GetSkillResumeBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x00311EFC File Offset: 0x003100FC
		public byte[] GetSkillResumeArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x00311F14 File Offset: 0x00310114
		public int SkillTagList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600D309 RID: 54025 RVA: 0x00311F54 File Offset: 0x00310154
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

		// Token: 0x0600D30A RID: 54026 RVA: 0x00311F80 File Offset: 0x00310180
		public Span<int> GetSkillTagListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x00311F90 File Offset: 0x00310190
		public int[] GetSkillTagListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600D30C RID: 54028 RVA: 0x00311FA8 File Offset: 0x003101A8
		public string SkillDetailNum(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600D30D RID: 54029 RVA: 0x00311FE4 File Offset: 0x003101E4
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

		// Token: 0x0600D30E RID: 54030 RVA: 0x00312010 File Offset: 0x00310210
		public string SkillResumeNum(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600D30F RID: 54031 RVA: 0x0031204C File Offset: 0x0031024C
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

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x00312078 File Offset: 0x00310278
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

		// Token: 0x0600D311 RID: 54033 RVA: 0x003120B0 File Offset: 0x003102B0
		public Span<byte> GetMultiSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600D312 RID: 54034 RVA: 0x003120C0 File Offset: 0x003102C0
		public byte[] GetMultiSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x003120D8 File Offset: 0x003102D8
		public string MultiSkillDetailNum(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x00312114 File Offset: 0x00310314
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

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600D315 RID: 54037 RVA: 0x00312140 File Offset: 0x00310340
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

		// Token: 0x0600D316 RID: 54038 RVA: 0x00312180 File Offset: 0x00310380
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffListIter()或GetBuffListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffList()
		{
			Skill skill = this;
			return skill.GetBuffListArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x003121A4 File Offset: 0x003103A4
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffListIter()
		{
			Skill.<BuffListIter>d__82 <BuffListIter>d__ = new Skill.<BuffListIter>d__82(-2);
			<BuffListIter>d__.<>3__<>4__this = this;
			return <BuffListIter>d__;
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x003121BC File Offset: 0x003103BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DamageListIter()或GetDamageListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] DamageList()
		{
			Skill skill = this;
			return skill.GetDamageListArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x003121E0 File Offset: 0x003103E0
		[NullableContext(1)]
		public readonly IEnumerable<long> DamageListIter()
		{
			Skill.<DamageListIter>d__84 <DamageListIter>d__ = new Skill.<DamageListIter>d__84(-2);
			<DamageListIter>d__.<>3__<>4__this = this;
			return <DamageListIter>d__;
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x003121F5 File Offset: 0x003103F5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiSkillDetailNumIter()或GetMultiSkillDetailNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MultiSkillDetailNum()
		{
			return this.MultiSkillDetailNumIter().ToArray<string>();
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x00312202 File Offset: 0x00310402
		[NullableContext(1)]
		public readonly IEnumerable<string> MultiSkillDetailNumIter()
		{
			Skill.<MultiSkillDetailNumIter>d__86 <MultiSkillDetailNumIter>d__ = new Skill.<MultiSkillDetailNumIter>d__86(-2);
			<MultiSkillDetailNumIter>d__.<>3__<>4__this = this;
			return <MultiSkillDetailNumIter>d__;
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x00312217 File Offset: 0x00310417
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDetailNumIter()或GetSkillDetailNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillDetailNum()
		{
			return this.SkillDetailNumIter().ToArray<string>();
		}

		// Token: 0x0600D31D RID: 54045 RVA: 0x00312224 File Offset: 0x00310424
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillDetailNumIter()
		{
			Skill.<SkillDetailNumIter>d__88 <SkillDetailNumIter>d__ = new Skill.<SkillDetailNumIter>d__88(-2);
			<SkillDetailNumIter>d__.<>3__<>4__this = this;
			return <SkillDetailNumIter>d__;
		}

		// Token: 0x0600D31E RID: 54046 RVA: 0x0031223C File Offset: 0x0031043C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillInfoListIter()或GetSkillInfoListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillInfoList()
		{
			Skill skill = this;
			return skill.GetSkillInfoListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D31F RID: 54047 RVA: 0x00312260 File Offset: 0x00310460
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillInfoListIter()
		{
			Skill.<SkillInfoListIter>d__90 <SkillInfoListIter>d__ = new Skill.<SkillInfoListIter>d__90(-2);
			<SkillInfoListIter>d__.<>3__<>4__this = this;
			return <SkillInfoListIter>d__;
		}

		// Token: 0x0600D320 RID: 54048 RVA: 0x00312275 File Offset: 0x00310475
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillResumeNumIter()或GetSkillResumeNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillResumeNum()
		{
			return this.SkillResumeNumIter().ToArray<string>();
		}

		// Token: 0x0600D321 RID: 54049 RVA: 0x00312282 File Offset: 0x00310482
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillResumeNumIter()
		{
			Skill.<SkillResumeNumIter>d__92 <SkillResumeNumIter>d__ = new Skill.<SkillResumeNumIter>d__92(-2);
			<SkillResumeNumIter>d__.<>3__<>4__this = this;
			return <SkillResumeNumIter>d__;
		}

		// Token: 0x0600D322 RID: 54050 RVA: 0x00312298 File Offset: 0x00310498
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillTagListIter()或GetSkillTagListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillTagList()
		{
			Skill skill = this;
			return skill.GetSkillTagListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D323 RID: 54051 RVA: 0x003122BC File Offset: 0x003104BC
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillTagListIter()
		{
			Skill.<SkillTagListIter>d__94 <SkillTagListIter>d__ = new Skill.<SkillTagListIter>d__94(-2);
			<SkillTagListIter>d__.<>3__<>4__this = this;
			return <SkillTagListIter>d__;
		}

		// Token: 0x040051C9 RID: 20937
		private Table __p;
	}
}
