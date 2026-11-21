using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001069 RID: 4201
	public struct QuickHackSkill : IFlatbufferObject
	{
		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600BDC3 RID: 48579 RVA: 0x002F09BB File Offset: 0x002EEBBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDC4 RID: 48580 RVA: 0x002F09C8 File Offset: 0x002EEBC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x002F09D0 File Offset: 0x002EEBD0
		public static QuickHackSkill GetRootAsQuickHackSkill(ByteBuffer _bb)
		{
			return QuickHackSkill.GetRootAsQuickHackSkill(_bb, default(QuickHackSkill));
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x002F09EC File Offset: 0x002EEBEC
		public static QuickHackSkill GetRootAsQuickHackSkill(ByteBuffer _bb, QuickHackSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x002F0A09 File Offset: 0x002EEC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x002F0A18 File Offset: 0x002EEC18
		public QuickHackSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x002F0A28 File Offset: 0x002EEC28
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

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x002F0A64 File Offset: 0x002EEC64
		public string SkillName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x002F0A9B File Offset: 0x002EEC9B
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x002F0AAA File Offset: 0x002EECAA
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600BDCD RID: 48589 RVA: 0x002F0AC4 File Offset: 0x002EECC4
		public string SkillDescribe
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDCE RID: 48590 RVA: 0x002F0AFB File Offset: 0x002EECFB
		public Span<byte> GetSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BDCF RID: 48591 RVA: 0x002F0B0A File Offset: 0x002EED0A
		public byte[] GetSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0600BDD0 RID: 48592 RVA: 0x002F0B24 File Offset: 0x002EED24
		public string SkillTag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x002F0B5C File Offset: 0x002EED5C
		public Span<byte> GetSkillTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x002F0B6C File Offset: 0x002EED6C
		public byte[] GetSkillTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x002F0B84 File Offset: 0x002EED84
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x002F0BBC File Offset: 0x002EEDBC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x002F0BCC File Offset: 0x002EEDCC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x002F0BE4 File Offset: 0x002EEDE4
		public int TargetType
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

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600BDD7 RID: 48599 RVA: 0x002F0C24 File Offset: 0x002EEE24
		public int RamCost
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

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x002F0C64 File Offset: 0x002EEE64
		public long SelfBuffIds(int j)
		{
			int num = this.__p.__offset(18);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x002F0CB0 File Offset: 0x002EEEB0
		public int SelfBuffIdsLength
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

		// Token: 0x0600BDDA RID: 48602 RVA: 0x002F0CDC File Offset: 0x002EEEDC
		public Span<long> GetSelfBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(18, 8));
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x002F0CF1 File Offset: 0x002EEEF1
		public long[] GetSelfBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(18) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x002F0D30 File Offset: 0x002EEF30
		public long TargetBuffIds(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x002F0D7C File Offset: 0x002EEF7C
		public int TargetBuffIdsLength
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

		// Token: 0x0600BDDE RID: 48606 RVA: 0x002F0DA8 File Offset: 0x002EEFA8
		public Span<long> GetTargetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x002F0DBD File Offset: 0x002EEFBD
		public long[] GetTargetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600BDE0 RID: 48608 RVA: 0x002F0DFC File Offset: 0x002EEFFC
		public int UsageCount
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600BDE1 RID: 48609 RVA: 0x002F0E3C File Offset: 0x002EF03C
		public int Duration
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

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x002F0E7C File Offset: 0x002EF07C
		public int ExtraEffectList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600BDE3 RID: 48611 RVA: 0x002F0EBC File Offset: 0x002EF0BC
		public int ExtraEffectListLength
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

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x002F0EE8 File Offset: 0x002EF0E8
		public Span<int> GetExtraEffectListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x002F0EF8 File Offset: 0x002EF0F8
		public int[] GetExtraEffectListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600BDE6 RID: 48614 RVA: 0x002F0F10 File Offset: 0x002EF110
		public string ExtraConditionType
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

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x002F0F48 File Offset: 0x002EF148
		public Span<byte> GetExtraConditionTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BDE8 RID: 48616 RVA: 0x002F0F58 File Offset: 0x002EF158
		public byte[] GetExtraConditionTypeArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x002F0F70 File Offset: 0x002EF170
		public string ExtraConditionParams(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0600BDEA RID: 48618 RVA: 0x002F0FAC File Offset: 0x002EF1AC
		public int ExtraConditionParamsLength
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

		// Token: 0x0600BDEB RID: 48619 RVA: 0x002F0FD8 File Offset: 0x002EF1D8
		[NullableContext(1)]
		public string[] ExtraConditionParams()
		{
			return this.ExtraConditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x002F0FE5 File Offset: 0x002EF1E5
		[NullableContext(1)]
		public IEnumerable<string> ExtraConditionParamsIter()
		{
			QuickHackSkill.<ExtraConditionParamsIter>d__57 <ExtraConditionParamsIter>d__ = new QuickHackSkill.<ExtraConditionParamsIter>d__57(-2);
			<ExtraConditionParamsIter>d__.<>3__<>4__this = this;
			return <ExtraConditionParamsIter>d__;
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x002F0FFA File Offset: 0x002EF1FA
		[NullableContext(1)]
		public int[] ExtraEffectList()
		{
			return this.GetExtraEffectListArray();
		}

		// Token: 0x0600BDEE RID: 48622 RVA: 0x002F1002 File Offset: 0x002EF202
		[NullableContext(1)]
		public IEnumerable<int> ExtraEffectListIter()
		{
			QuickHackSkill.<ExtraEffectListIter>d__59 <ExtraEffectListIter>d__ = new QuickHackSkill.<ExtraEffectListIter>d__59(-2);
			<ExtraEffectListIter>d__.<>3__<>4__this = this;
			return <ExtraEffectListIter>d__;
		}

		// Token: 0x0600BDEF RID: 48623 RVA: 0x002F1017 File Offset: 0x002EF217
		[NullableContext(1)]
		public long[] SelfBuffIds()
		{
			return this.GetSelfBuffIdsArray();
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x002F101F File Offset: 0x002EF21F
		[NullableContext(1)]
		public IEnumerable<long> SelfBuffIdsIter()
		{
			QuickHackSkill.<SelfBuffIdsIter>d__61 <SelfBuffIdsIter>d__ = new QuickHackSkill.<SelfBuffIdsIter>d__61(-2);
			<SelfBuffIdsIter>d__.<>3__<>4__this = this;
			return <SelfBuffIdsIter>d__;
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x002F1034 File Offset: 0x002EF234
		[NullableContext(1)]
		public long[] TargetBuffIds()
		{
			return this.GetTargetBuffIdsArray();
		}

		// Token: 0x0600BDF2 RID: 48626 RVA: 0x002F103C File Offset: 0x002EF23C
		[NullableContext(1)]
		public IEnumerable<long> TargetBuffIdsIter()
		{
			QuickHackSkill.<TargetBuffIdsIter>d__63 <TargetBuffIdsIter>d__ = new QuickHackSkill.<TargetBuffIdsIter>d__63(-2);
			<TargetBuffIdsIter>d__.<>3__<>4__this = this;
			return <TargetBuffIdsIter>d__;
		}

		// Token: 0x04005637 RID: 22071
		private Table __p;
	}
}
