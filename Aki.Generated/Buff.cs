using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C33 RID: 3123
	[NullableContext(1)]
	[Nullable(0)]
	public struct Buff : IFlatbufferObject
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x00209CA5 File Offset: 0x00207EA5
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00209CB2 File Offset: 0x00207EB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00209CBC File Offset: 0x00207EBC
		[NullableContext(0)]
		public static Buff GetRootAsBuff(ByteBuffer _bb)
		{
			return Buff.GetRootAsBuff(_bb, default(Buff));
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00209CD8 File Offset: 0x00207ED8
		[NullableContext(0)]
		public static Buff GetRootAsBuff(ByteBuffer _bb, Buff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00209CF5 File Offset: 0x00207EF5
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00209D04 File Offset: 0x00207F04
		[NullableContext(0)]
		public Buff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x00209D14 File Offset: 0x00207F14
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x00209D5C File Offset: 0x00207F5C
		[Nullable(0)]
		public string GeDesc
		{
			[NullableContext(0)]
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

		// Token: 0x060055E1 RID: 21985 RVA: 0x00209D93 File Offset: 0x00207F93
		[NullableContext(0)]
		public Span<byte> GetGeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00209DA2 File Offset: 0x00207FA2
		[NullableContext(0)]
		public byte[] GetGeDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060055E3 RID: 21987 RVA: 0x00209DBC File Offset: 0x00207FBC
		public int DurationPolicy
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

		// Token: 0x060055E4 RID: 21988 RVA: 0x00209DF8 File Offset: 0x00207FF8
		public int DurationCalculationPolicy(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060055E5 RID: 21989 RVA: 0x00209E38 File Offset: 0x00208038
		public int DurationCalculationPolicyLength
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

		// Token: 0x060055E6 RID: 21990 RVA: 0x00209E64 File Offset: 0x00208064
		[NullableContext(0)]
		public Span<int> GetDurationCalculationPolicyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00209E74 File Offset: 0x00208074
		[NullableContext(0)]
		public int[] GetDurationCalculationPolicyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00209E8C File Offset: 0x0020808C
		public float DurationMagnitude(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060055E9 RID: 21993 RVA: 0x00209ED0 File Offset: 0x002080D0
		public int DurationMagnitudeLength
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

		// Token: 0x060055EA RID: 21994 RVA: 0x00209EFC File Offset: 0x002080FC
		[NullableContext(0)]
		public Span<float> GetDurationMagnitudeBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00209F0C File Offset: 0x0020810C
		[NullableContext(0)]
		public float[] GetDurationMagnitudeArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00209F24 File Offset: 0x00208124
		public float DurationMagnitude2(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060055ED RID: 21997 RVA: 0x00209F68 File Offset: 0x00208168
		public int DurationMagnitude2Length
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

		// Token: 0x060055EE RID: 21998 RVA: 0x00209F94 File Offset: 0x00208194
		[NullableContext(0)]
		public Span<float> GetDurationMagnitude2Bytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00209FA4 File Offset: 0x002081A4
		[NullableContext(0)]
		public float[] GetDurationMagnitude2Array()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x00209FBC File Offset: 0x002081BC
		public bool BDurationAffectedByBulletTime
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x00209FFC File Offset: 0x002081FC
		public int FormationPolicy
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x0020A03C File Offset: 0x0020823C
		public int Probability
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x0020A080 File Offset: 0x00208280
		public float Period
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x0020A0C4 File Offset: 0x002082C4
		public bool BExecutePeriodicEffectOnApplication
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x0020A104 File Offset: 0x00208304
		public int PeriodicInhibitionPolicy
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

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x0020A144 File Offset: 0x00208344
		public int GameAttributeID
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

		// Token: 0x060055F7 RID: 22007 RVA: 0x0020A184 File Offset: 0x00208384
		public int CalculationPolicy(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x0020A1C4 File Offset: 0x002083C4
		public int CalculationPolicyLength
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

		// Token: 0x060055F9 RID: 22009 RVA: 0x0020A1F0 File Offset: 0x002083F0
		[NullableContext(0)]
		public Span<int> GetCalculationPolicyBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x0020A200 File Offset: 0x00208400
		[NullableContext(0)]
		public int[] GetCalculationPolicyArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x0020A218 File Offset: 0x00208418
		public int ModifierMagnitude(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x0020A258 File Offset: 0x00208458
		public int ModifierMagnitudeLength
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

		// Token: 0x060055FD RID: 22013 RVA: 0x0020A284 File Offset: 0x00208484
		[NullableContext(0)]
		public Span<int> GetModifierMagnitudeBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0020A294 File Offset: 0x00208494
		[NullableContext(0)]
		public int[] GetModifierMagnitudeArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0020A2AC File Offset: 0x002084AC
		public int ModifierMagnitude2(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x0020A2EC File Offset: 0x002084EC
		public int ModifierMagnitude2Length
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0020A318 File Offset: 0x00208518
		[NullableContext(0)]
		public Span<int> GetModifierMagnitude2Bytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x0020A328 File Offset: 0x00208528
		[NullableContext(0)]
		public int[] GetModifierMagnitude2Array()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x0020A340 File Offset: 0x00208540
		public int StackingType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x0020A380 File Offset: 0x00208580
		public int DefaultStackCount
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06005605 RID: 22021 RVA: 0x0020A3C0 File Offset: 0x002085C0
		public int StackAppendCount
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x0020A400 File Offset: 0x00208600
		public int StackLimitCount
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x0020A440 File Offset: 0x00208640
		public int StackDurationRefreshPolicy
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x0020A480 File Offset: 0x00208680
		public int StackPeriodResetPolicy
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

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06005609 RID: 22025 RVA: 0x0020A4C0 File Offset: 0x002086C0
		public int StackExpirationRemoveNumber
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x0020A500 File Offset: 0x00208700
		public bool BDenyOverflowApplication
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600560B RID: 22027 RVA: 0x0020A540 File Offset: 0x00208740
		public bool BClearStackOnOverflow
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x0020A580 File Offset: 0x00208780
		public bool BRequireModifierSuccessToTriggerCues
		{
			get
			{
				int num = this.__p.__offset(54);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600560D RID: 22029 RVA: 0x0020A5C0 File Offset: 0x002087C0
		public bool BSuppressStackingCues
		{
			get
			{
				int num = this.__p.__offset(56);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x0020A600 File Offset: 0x00208800
		public long GameplayCueIds(int j)
		{
			int num = this.__p.__offset(58);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x0020A64C File Offset: 0x0020884C
		public int GameplayCueIdsLength
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

		// Token: 0x06005610 RID: 22032 RVA: 0x0020A678 File Offset: 0x00208878
		[NullableContext(0)]
		public Span<long> GetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(58, 8));
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x0020A68D File Offset: 0x0020888D
		[NullableContext(0)]
		public long[] GetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(58) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x0020A6CC File Offset: 0x002088CC
		[NullableContext(0)]
		public string GrantedTags(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x0020A708 File Offset: 0x00208908
		public int GrantedTagsLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x0020A734 File Offset: 0x00208934
		[NullableContext(0)]
		public string ApplicationSourceTagRequirements(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x0020A770 File Offset: 0x00208970
		public int ApplicationSourceTagRequirementsLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x0020A79C File Offset: 0x0020899C
		[NullableContext(0)]
		public string ApplicationSourceTagIgnores(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x0020A7D8 File Offset: 0x002089D8
		public int ApplicationSourceTagIgnoresLength
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

		// Token: 0x06005618 RID: 22040 RVA: 0x0020A804 File Offset: 0x00208A04
		[NullableContext(0)]
		public string ApplicationTagRequirements(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x0020A840 File Offset: 0x00208A40
		public int ApplicationTagRequirementsLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x0020A86C File Offset: 0x00208A6C
		[NullableContext(0)]
		public string ApplicationTagIgnores(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x0020A8A8 File Offset: 0x00208AA8
		public int ApplicationTagIgnoresLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x0020A8D4 File Offset: 0x00208AD4
		[NullableContext(0)]
		public string OngoingTagRequirements(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x0020A910 File Offset: 0x00208B10
		public int OngoingTagRequirementsLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0020A93C File Offset: 0x00208B3C
		[NullableContext(0)]
		public string OngoingTagIgnores(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x0020A978 File Offset: 0x00208B78
		public int OngoingTagIgnoresLength
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

		// Token: 0x06005620 RID: 22048 RVA: 0x0020A9A4 File Offset: 0x00208BA4
		[NullableContext(0)]
		public string RemovalTagRequirements(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x0020A9E0 File Offset: 0x00208BE0
		public int RemovalTagRequirementsLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x0020AA0C File Offset: 0x00208C0C
		[NullableContext(0)]
		public string RemovalTagIgnores(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x0020AA48 File Offset: 0x00208C48
		public int RemovalTagIgnoresLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x0020AA74 File Offset: 0x00208C74
		[NullableContext(0)]
		public string RemoveBuffWithTags(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x0020AAB0 File Offset: 0x00208CB0
		public int RemoveBuffWithTagsLength
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x0020AADC File Offset: 0x00208CDC
		[NullableContext(0)]
		public string GrantedApplicationImmunityTags(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06005627 RID: 22055 RVA: 0x0020AB18 File Offset: 0x00208D18
		public int GrantedApplicationImmunityTagsLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x0020AB44 File Offset: 0x00208D44
		[NullableContext(0)]
		public string GrantedApplicationImmunityTagIgnores(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x0020AB80 File Offset: 0x00208D80
		public int GrantedApplicationImmunityTagIgnoresLength
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

		// Token: 0x0600562A RID: 22058 RVA: 0x0020ABAC File Offset: 0x00208DAC
		public long PrematureExpirationEffects(int j)
		{
			int num = this.__p.__offset(84);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x0020ABF8 File Offset: 0x00208DF8
		public int PrematureExpirationEffectsLength
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x0020AC24 File Offset: 0x00208E24
		[NullableContext(0)]
		public Span<long> GetPrematureExpirationEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(84, 8));
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0020AC39 File Offset: 0x00208E39
		[NullableContext(0)]
		public long[] GetPrematureExpirationEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(84) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x0020AC78 File Offset: 0x00208E78
		public long RoutineExpirationEffects(int j)
		{
			int num = this.__p.__offset(86);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x0020ACC4 File Offset: 0x00208EC4
		public int RoutineExpirationEffectsLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x0020ACF0 File Offset: 0x00208EF0
		[NullableContext(0)]
		public Span<long> GetRoutineExpirationEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(86, 8));
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x0020AD05 File Offset: 0x00208F05
		[NullableContext(0)]
		public long[] GetRoutineExpirationEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(86) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x0020AD44 File Offset: 0x00208F44
		public long OverflowEffects(int j)
		{
			int num = this.__p.__offset(88);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x0020AD90 File Offset: 0x00208F90
		public int OverflowEffectsLength
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x0020ADBC File Offset: 0x00208FBC
		[NullableContext(0)]
		public Span<long> GetOverflowEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(88, 8));
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x0020ADD1 File Offset: 0x00208FD1
		[NullableContext(0)]
		public long[] GetOverflowEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(88) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0020AE10 File Offset: 0x00209010
		public long RelatedExtraEffectBuffId(int j)
		{
			int num = this.__p.__offset(90);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x0020AE5C File Offset: 0x0020905C
		public int RelatedExtraEffectBuffIdLength
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0020AE88 File Offset: 0x00209088
		[NullableContext(0)]
		public Span<long> GetRelatedExtraEffectBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(90, 8));
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x0020AE9D File Offset: 0x0020909D
		[NullableContext(0)]
		public long[] GetRelatedExtraEffectBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(90) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x0020AEDC File Offset: 0x002090DC
		public int ExtraEffectID
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x0020AF1C File Offset: 0x0020911C
		[NullableContext(0)]
		public string ExtraEffectParameters(int j)
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x0020AF58 File Offset: 0x00209158
		public int ExtraEffectParametersLength
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0020AF84 File Offset: 0x00209184
		public int ExtraEffectParametersGrow1(int j)
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x0020AFC4 File Offset: 0x002091C4
		public int ExtraEffectParametersGrow1Length
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x0020AFF0 File Offset: 0x002091F0
		[NullableContext(0)]
		public Span<int> GetExtraEffectParametersGrow1Bytes()
		{
			return this.__p.__vector_as_span<int>(96, 4);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0020B000 File Offset: 0x00209200
		[NullableContext(0)]
		public int[] GetExtraEffectParametersGrow1Array()
		{
			return this.__p.__vector_as_array<int>(96) ?? Array.Empty<int>();
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x0020B018 File Offset: 0x00209218
		public int ExtraEffectParametersGrow2(int j)
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x0020B058 File Offset: 0x00209258
		public int ExtraEffectParametersGrow2Length
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x0020B084 File Offset: 0x00209284
		[NullableContext(0)]
		public Span<int> GetExtraEffectParametersGrow2Bytes()
		{
			return this.__p.__vector_as_span<int>(98, 4);
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x0020B094 File Offset: 0x00209294
		[NullableContext(0)]
		public int[] GetExtraEffectParametersGrow2Array()
		{
			return this.__p.__vector_as_array<int>(98) ?? Array.Empty<int>();
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x0020B0AC File Offset: 0x002092AC
		public int ExtraEffectRequirements(int j)
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x0020B0EC File Offset: 0x002092EC
		public int ExtraEffectRequirementsLength
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x0020B118 File Offset: 0x00209318
		[NullableContext(0)]
		public Span<int> GetExtraEffectRequirementsBytes()
		{
			return this.__p.__vector_as_span<int>(100, 4);
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x0020B128 File Offset: 0x00209328
		[NullableContext(0)]
		public int[] GetExtraEffectRequirementsArray()
		{
			return this.__p.__vector_as_array<int>(100) ?? Array.Empty<int>();
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x0020B140 File Offset: 0x00209340
		[NullableContext(0)]
		public string ExtraEffectReqPara(int j)
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x0020B17C File Offset: 0x0020937C
		public int ExtraEffectReqParaLength
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600564B RID: 22091 RVA: 0x0020B1A8 File Offset: 0x002093A8
		public int ExtraEffectReqSetting
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

		// Token: 0x0600564C RID: 22092 RVA: 0x0020B1E8 File Offset: 0x002093E8
		public float ExtraEffectCD(int j)
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x0020B22C File Offset: 0x0020942C
		public int ExtraEffectCDLength
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x0020B258 File Offset: 0x00209458
		[NullableContext(0)]
		public Span<float> GetExtraEffectCDBytes()
		{
			return this.__p.__vector_as_span<float>(106, 4);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0020B268 File Offset: 0x00209468
		[NullableContext(0)]
		public float[] GetExtraEffectCDArray()
		{
			return this.__p.__vector_as_array<float>(106) ?? Array.Empty<float>();
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0020B280 File Offset: 0x00209480
		public float ExtraEffectCdForTarget(int j)
		{
			int num = this.__p.__offset(108);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x0020B2C4 File Offset: 0x002094C4
		public int ExtraEffectCdForTargetLength
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x0020B2F0 File Offset: 0x002094F0
		[NullableContext(0)]
		public Span<float> GetExtraEffectCdForTargetBytes()
		{
			return this.__p.__vector_as_span<float>(108, 4);
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0020B300 File Offset: 0x00209500
		[NullableContext(0)]
		public float[] GetExtraEffectCdForTargetArray()
		{
			return this.__p.__vector_as_array<float>(108) ?? Array.Empty<float>();
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06005654 RID: 22100 RVA: 0x0020B318 File Offset: 0x00209518
		public int ExtraEffectRemoveStackNum
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x0020B358 File Offset: 0x00209558
		public int ExtraEffectProbability(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06005656 RID: 22102 RVA: 0x0020B398 File Offset: 0x00209598
		public int ExtraEffectProbabilityLength
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

		// Token: 0x06005657 RID: 22103 RVA: 0x0020B3C4 File Offset: 0x002095C4
		[NullableContext(0)]
		public Span<int> GetExtraEffectProbabilityBytes()
		{
			return this.__p.__vector_as_span<int>(112, 4);
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x0020B3D4 File Offset: 0x002095D4
		[NullableContext(0)]
		public int[] GetExtraEffectProbabilityArray()
		{
			return this.__p.__vector_as_array<int>(112) ?? Array.Empty<int>();
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x0020B3EC File Offset: 0x002095EC
		[NullableContext(0)]
		public string BuffAction(int j)
		{
			int num = this.__p.__offset(114);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600565A RID: 22106 RVA: 0x0020B428 File Offset: 0x00209628
		public int BuffActionLength
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x0020B454 File Offset: 0x00209654
		public IntArray? TagLogic(int j)
		{
			int num = this.__p.__offset(116);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x0020B4B8 File Offset: 0x002096B8
		public int TagLogicLength
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x0020B4E4 File Offset: 0x002096E4
		public bool DeadRemove
		{
			get
			{
				int num = this.__p.__offset(118);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0020B524 File Offset: 0x00209724
		public long RelatedAttributeBuffId(int j)
		{
			int num = this.__p.__offset(120);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x0020B570 File Offset: 0x00209770
		public int RelatedAttributeBuffIdLength
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x0020B59C File Offset: 0x0020979C
		[NullableContext(0)]
		public Span<long> GetRelatedAttributeBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(120, 8));
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x0020B5B1 File Offset: 0x002097B1
		[NullableContext(0)]
		public long[] GetRelatedAttributeBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(120) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x0020B5F0 File Offset: 0x002097F0
		public bool BOnlyLocalAdd
		{
			get
			{
				int num = this.__p.__offset(122);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x0020B630 File Offset: 0x00209830
		public long ReplaceBuffIds(int j)
		{
			int num = this.__p.__offset(124);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06005664 RID: 22116 RVA: 0x0020B67C File Offset: 0x0020987C
		public int ReplaceBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x0020B6A8 File Offset: 0x002098A8
		[NullableContext(0)]
		public Span<long> GetReplaceBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(124, 8));
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x0020B6BD File Offset: 0x002098BD
		[NullableContext(0)]
		public long[] GetReplaceBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(124) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0020B6FC File Offset: 0x002098FC
		[NullableContext(0)]
		public string ReplaceConditions(int j)
		{
			int num = this.__p.__offset(126);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06005668 RID: 22120 RVA: 0x0020B738 File Offset: 0x00209938
		public int ReplaceConditionsLength
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0020B764 File Offset: 0x00209964
		[NullableContext(0)]
		public string ExtraEffectParametersGrow3(int j)
		{
			int num = this.__p.__offset(128);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600566A RID: 22122 RVA: 0x0020B7A4 File Offset: 0x002099A4
		public int ExtraEffectParametersGrow3Length
		{
			get
			{
				int num = this.__p.__offset(128);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x0020B7D3 File Offset: 0x002099D3
		public string[] ApplicationSourceTagIgnores()
		{
			return this.ApplicationSourceTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x0020B7E0 File Offset: 0x002099E0
		public IEnumerable<string> ApplicationSourceTagIgnoresIter()
		{
			Buff.<ApplicationSourceTagIgnoresIter>d__212 <ApplicationSourceTagIgnoresIter>d__ = new Buff.<ApplicationSourceTagIgnoresIter>d__212(-2);
			<ApplicationSourceTagIgnoresIter>d__.<>3__<>4__this = this;
			return <ApplicationSourceTagIgnoresIter>d__;
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x0020B7F5 File Offset: 0x002099F5
		public string[] ApplicationSourceTagRequirements()
		{
			return this.ApplicationSourceTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x0020B802 File Offset: 0x00209A02
		public IEnumerable<string> ApplicationSourceTagRequirementsIter()
		{
			Buff.<ApplicationSourceTagRequirementsIter>d__214 <ApplicationSourceTagRequirementsIter>d__ = new Buff.<ApplicationSourceTagRequirementsIter>d__214(-2);
			<ApplicationSourceTagRequirementsIter>d__.<>3__<>4__this = this;
			return <ApplicationSourceTagRequirementsIter>d__;
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x0020B817 File Offset: 0x00209A17
		public string[] ApplicationTagIgnores()
		{
			return this.ApplicationTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x0020B824 File Offset: 0x00209A24
		public IEnumerable<string> ApplicationTagIgnoresIter()
		{
			Buff.<ApplicationTagIgnoresIter>d__216 <ApplicationTagIgnoresIter>d__ = new Buff.<ApplicationTagIgnoresIter>d__216(-2);
			<ApplicationTagIgnoresIter>d__.<>3__<>4__this = this;
			return <ApplicationTagIgnoresIter>d__;
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x0020B839 File Offset: 0x00209A39
		public string[] ApplicationTagRequirements()
		{
			return this.ApplicationTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x0020B846 File Offset: 0x00209A46
		public IEnumerable<string> ApplicationTagRequirementsIter()
		{
			Buff.<ApplicationTagRequirementsIter>d__218 <ApplicationTagRequirementsIter>d__ = new Buff.<ApplicationTagRequirementsIter>d__218(-2);
			<ApplicationTagRequirementsIter>d__.<>3__<>4__this = this;
			return <ApplicationTagRequirementsIter>d__;
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x0020B85B File Offset: 0x00209A5B
		public string[] BuffAction()
		{
			return this.BuffActionIter().ToArray<string>();
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x0020B868 File Offset: 0x00209A68
		public IEnumerable<string> BuffActionIter()
		{
			Buff.<BuffActionIter>d__220 <BuffActionIter>d__ = new Buff.<BuffActionIter>d__220(-2);
			<BuffActionIter>d__.<>3__<>4__this = this;
			return <BuffActionIter>d__;
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x0020B87D File Offset: 0x00209A7D
		public int[] CalculationPolicy()
		{
			return this.GetCalculationPolicyArray();
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x0020B885 File Offset: 0x00209A85
		public IEnumerable<int> CalculationPolicyIter()
		{
			Buff.<CalculationPolicyIter>d__222 <CalculationPolicyIter>d__ = new Buff.<CalculationPolicyIter>d__222(-2);
			<CalculationPolicyIter>d__.<>3__<>4__this = this;
			return <CalculationPolicyIter>d__;
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x0020B89A File Offset: 0x00209A9A
		public int[] DurationCalculationPolicy()
		{
			return this.GetDurationCalculationPolicyArray();
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x0020B8A2 File Offset: 0x00209AA2
		public IEnumerable<int> DurationCalculationPolicyIter()
		{
			Buff.<DurationCalculationPolicyIter>d__224 <DurationCalculationPolicyIter>d__ = new Buff.<DurationCalculationPolicyIter>d__224(-2);
			<DurationCalculationPolicyIter>d__.<>3__<>4__this = this;
			return <DurationCalculationPolicyIter>d__;
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x0020B8B7 File Offset: 0x00209AB7
		public float[] DurationMagnitude()
		{
			return this.GetDurationMagnitudeArray();
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x0020B8BF File Offset: 0x00209ABF
		public IEnumerable<float> DurationMagnitudeIter()
		{
			Buff.<DurationMagnitudeIter>d__226 <DurationMagnitudeIter>d__ = new Buff.<DurationMagnitudeIter>d__226(-2);
			<DurationMagnitudeIter>d__.<>3__<>4__this = this;
			return <DurationMagnitudeIter>d__;
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x0020B8D4 File Offset: 0x00209AD4
		public float[] DurationMagnitude2()
		{
			return this.GetDurationMagnitude2Array();
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x0020B8DC File Offset: 0x00209ADC
		public IEnumerable<float> DurationMagnitude2Iter()
		{
			Buff.<DurationMagnitude2Iter>d__228 <DurationMagnitude2Iter>d__ = new Buff.<DurationMagnitude2Iter>d__228(-2);
			<DurationMagnitude2Iter>d__.<>3__<>4__this = this;
			return <DurationMagnitude2Iter>d__;
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x0020B8F1 File Offset: 0x00209AF1
		public float[] ExtraEffectCD()
		{
			return this.GetExtraEffectCDArray();
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x0020B8F9 File Offset: 0x00209AF9
		public IEnumerable<float> ExtraEffectCDIter()
		{
			Buff.<ExtraEffectCDIter>d__230 <ExtraEffectCDIter>d__ = new Buff.<ExtraEffectCDIter>d__230(-2);
			<ExtraEffectCDIter>d__.<>3__<>4__this = this;
			return <ExtraEffectCDIter>d__;
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x0020B90E File Offset: 0x00209B0E
		public float[] ExtraEffectCdForTarget()
		{
			return this.GetExtraEffectCdForTargetArray();
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x0020B916 File Offset: 0x00209B16
		public IEnumerable<float> ExtraEffectCdForTargetIter()
		{
			Buff.<ExtraEffectCdForTargetIter>d__232 <ExtraEffectCdForTargetIter>d__ = new Buff.<ExtraEffectCdForTargetIter>d__232(-2);
			<ExtraEffectCdForTargetIter>d__.<>3__<>4__this = this;
			return <ExtraEffectCdForTargetIter>d__;
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x0020B92B File Offset: 0x00209B2B
		public string[] ExtraEffectParameters()
		{
			return this.ExtraEffectParametersIter().ToArray<string>();
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x0020B938 File Offset: 0x00209B38
		public IEnumerable<string> ExtraEffectParametersIter()
		{
			Buff.<ExtraEffectParametersIter>d__234 <ExtraEffectParametersIter>d__ = new Buff.<ExtraEffectParametersIter>d__234(-2);
			<ExtraEffectParametersIter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersIter>d__;
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x0020B94D File Offset: 0x00209B4D
		public int[] ExtraEffectParametersGrow1()
		{
			return this.GetExtraEffectParametersGrow1Array();
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x0020B955 File Offset: 0x00209B55
		public IEnumerable<int> ExtraEffectParametersGrow1Iter()
		{
			Buff.<ExtraEffectParametersGrow1Iter>d__236 <ExtraEffectParametersGrow1Iter>d__ = new Buff.<ExtraEffectParametersGrow1Iter>d__236(-2);
			<ExtraEffectParametersGrow1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow1Iter>d__;
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x0020B96A File Offset: 0x00209B6A
		public int[] ExtraEffectParametersGrow2()
		{
			return this.GetExtraEffectParametersGrow2Array();
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x0020B972 File Offset: 0x00209B72
		public IEnumerable<int> ExtraEffectParametersGrow2Iter()
		{
			Buff.<ExtraEffectParametersGrow2Iter>d__238 <ExtraEffectParametersGrow2Iter>d__ = new Buff.<ExtraEffectParametersGrow2Iter>d__238(-2);
			<ExtraEffectParametersGrow2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow2Iter>d__;
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0020B987 File Offset: 0x00209B87
		public string[] ExtraEffectParametersGrow3()
		{
			return this.ExtraEffectParametersGrow3Iter().ToArray<string>();
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x0020B994 File Offset: 0x00209B94
		public IEnumerable<string> ExtraEffectParametersGrow3Iter()
		{
			Buff.<ExtraEffectParametersGrow3Iter>d__240 <ExtraEffectParametersGrow3Iter>d__ = new Buff.<ExtraEffectParametersGrow3Iter>d__240(-2);
			<ExtraEffectParametersGrow3Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow3Iter>d__;
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x0020B9A9 File Offset: 0x00209BA9
		public int[] ExtraEffectProbability()
		{
			return this.GetExtraEffectProbabilityArray();
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x0020B9B1 File Offset: 0x00209BB1
		public IEnumerable<int> ExtraEffectProbabilityIter()
		{
			Buff.<ExtraEffectProbabilityIter>d__242 <ExtraEffectProbabilityIter>d__ = new Buff.<ExtraEffectProbabilityIter>d__242(-2);
			<ExtraEffectProbabilityIter>d__.<>3__<>4__this = this;
			return <ExtraEffectProbabilityIter>d__;
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x0020B9C6 File Offset: 0x00209BC6
		public string[] ExtraEffectReqPara()
		{
			return this.ExtraEffectReqParaIter().ToArray<string>();
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x0020B9D3 File Offset: 0x00209BD3
		public IEnumerable<string> ExtraEffectReqParaIter()
		{
			Buff.<ExtraEffectReqParaIter>d__244 <ExtraEffectReqParaIter>d__ = new Buff.<ExtraEffectReqParaIter>d__244(-2);
			<ExtraEffectReqParaIter>d__.<>3__<>4__this = this;
			return <ExtraEffectReqParaIter>d__;
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x0020B9E8 File Offset: 0x00209BE8
		public int[] ExtraEffectRequirements()
		{
			return this.GetExtraEffectRequirementsArray();
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x0020B9F0 File Offset: 0x00209BF0
		public IEnumerable<int> ExtraEffectRequirementsIter()
		{
			Buff.<ExtraEffectRequirementsIter>d__246 <ExtraEffectRequirementsIter>d__ = new Buff.<ExtraEffectRequirementsIter>d__246(-2);
			<ExtraEffectRequirementsIter>d__.<>3__<>4__this = this;
			return <ExtraEffectRequirementsIter>d__;
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x0020BA05 File Offset: 0x00209C05
		public long[] GameplayCueIds()
		{
			return this.GetGameplayCueIdsArray();
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x0020BA0D File Offset: 0x00209C0D
		public IEnumerable<long> GameplayCueIdsIter()
		{
			Buff.<GameplayCueIdsIter>d__248 <GameplayCueIdsIter>d__ = new Buff.<GameplayCueIdsIter>d__248(-2);
			<GameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <GameplayCueIdsIter>d__;
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x0020BA22 File Offset: 0x00209C22
		public string[] GrantedApplicationImmunityTagIgnores()
		{
			return this.GrantedApplicationImmunityTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x0020BA2F File Offset: 0x00209C2F
		public IEnumerable<string> GrantedApplicationImmunityTagIgnoresIter()
		{
			Buff.<GrantedApplicationImmunityTagIgnoresIter>d__250 <GrantedApplicationImmunityTagIgnoresIter>d__ = new Buff.<GrantedApplicationImmunityTagIgnoresIter>d__250(-2);
			<GrantedApplicationImmunityTagIgnoresIter>d__.<>3__<>4__this = this;
			return <GrantedApplicationImmunityTagIgnoresIter>d__;
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x0020BA44 File Offset: 0x00209C44
		public string[] GrantedApplicationImmunityTags()
		{
			return this.GrantedApplicationImmunityTagsIter().ToArray<string>();
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0020BA51 File Offset: 0x00209C51
		public IEnumerable<string> GrantedApplicationImmunityTagsIter()
		{
			Buff.<GrantedApplicationImmunityTagsIter>d__252 <GrantedApplicationImmunityTagsIter>d__ = new Buff.<GrantedApplicationImmunityTagsIter>d__252(-2);
			<GrantedApplicationImmunityTagsIter>d__.<>3__<>4__this = this;
			return <GrantedApplicationImmunityTagsIter>d__;
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x0020BA66 File Offset: 0x00209C66
		public string[] GrantedTags()
		{
			return this.GrantedTagsIter().ToArray<string>();
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x0020BA73 File Offset: 0x00209C73
		public IEnumerable<string> GrantedTagsIter()
		{
			Buff.<GrantedTagsIter>d__254 <GrantedTagsIter>d__ = new Buff.<GrantedTagsIter>d__254(-2);
			<GrantedTagsIter>d__.<>3__<>4__this = this;
			return <GrantedTagsIter>d__;
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x0020BA88 File Offset: 0x00209C88
		public int[] ModifierMagnitude()
		{
			return this.GetModifierMagnitudeArray();
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x0020BA90 File Offset: 0x00209C90
		public IEnumerable<int> ModifierMagnitudeIter()
		{
			Buff.<ModifierMagnitudeIter>d__256 <ModifierMagnitudeIter>d__ = new Buff.<ModifierMagnitudeIter>d__256(-2);
			<ModifierMagnitudeIter>d__.<>3__<>4__this = this;
			return <ModifierMagnitudeIter>d__;
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x0020BAA5 File Offset: 0x00209CA5
		public int[] ModifierMagnitude2()
		{
			return this.GetModifierMagnitude2Array();
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x0020BAAD File Offset: 0x00209CAD
		public IEnumerable<int> ModifierMagnitude2Iter()
		{
			Buff.<ModifierMagnitude2Iter>d__258 <ModifierMagnitude2Iter>d__ = new Buff.<ModifierMagnitude2Iter>d__258(-2);
			<ModifierMagnitude2Iter>d__.<>3__<>4__this = this;
			return <ModifierMagnitude2Iter>d__;
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x0020BAC2 File Offset: 0x00209CC2
		public string[] OngoingTagIgnores()
		{
			return this.OngoingTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x0020BACF File Offset: 0x00209CCF
		public IEnumerable<string> OngoingTagIgnoresIter()
		{
			Buff.<OngoingTagIgnoresIter>d__260 <OngoingTagIgnoresIter>d__ = new Buff.<OngoingTagIgnoresIter>d__260(-2);
			<OngoingTagIgnoresIter>d__.<>3__<>4__this = this;
			return <OngoingTagIgnoresIter>d__;
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x0020BAE4 File Offset: 0x00209CE4
		public string[] OngoingTagRequirements()
		{
			return this.OngoingTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x0020BAF1 File Offset: 0x00209CF1
		public IEnumerable<string> OngoingTagRequirementsIter()
		{
			Buff.<OngoingTagRequirementsIter>d__262 <OngoingTagRequirementsIter>d__ = new Buff.<OngoingTagRequirementsIter>d__262(-2);
			<OngoingTagRequirementsIter>d__.<>3__<>4__this = this;
			return <OngoingTagRequirementsIter>d__;
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x0020BB06 File Offset: 0x00209D06
		public long[] OverflowEffects()
		{
			return this.GetOverflowEffectsArray();
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x0020BB0E File Offset: 0x00209D0E
		public IEnumerable<long> OverflowEffectsIter()
		{
			Buff.<OverflowEffectsIter>d__264 <OverflowEffectsIter>d__ = new Buff.<OverflowEffectsIter>d__264(-2);
			<OverflowEffectsIter>d__.<>3__<>4__this = this;
			return <OverflowEffectsIter>d__;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x0020BB23 File Offset: 0x00209D23
		public long[] PrematureExpirationEffects()
		{
			return this.GetPrematureExpirationEffectsArray();
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x0020BB2B File Offset: 0x00209D2B
		public IEnumerable<long> PrematureExpirationEffectsIter()
		{
			Buff.<PrematureExpirationEffectsIter>d__266 <PrematureExpirationEffectsIter>d__ = new Buff.<PrematureExpirationEffectsIter>d__266(-2);
			<PrematureExpirationEffectsIter>d__.<>3__<>4__this = this;
			return <PrematureExpirationEffectsIter>d__;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x0020BB40 File Offset: 0x00209D40
		public long[] RelatedAttributeBuffId()
		{
			return this.GetRelatedAttributeBuffIdArray();
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0020BB48 File Offset: 0x00209D48
		public IEnumerable<long> RelatedAttributeBuffIdIter()
		{
			Buff.<RelatedAttributeBuffIdIter>d__268 <RelatedAttributeBuffIdIter>d__ = new Buff.<RelatedAttributeBuffIdIter>d__268(-2);
			<RelatedAttributeBuffIdIter>d__.<>3__<>4__this = this;
			return <RelatedAttributeBuffIdIter>d__;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x0020BB5D File Offset: 0x00209D5D
		public long[] RelatedExtraEffectBuffId()
		{
			return this.GetRelatedExtraEffectBuffIdArray();
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0020BB65 File Offset: 0x00209D65
		public IEnumerable<long> RelatedExtraEffectBuffIdIter()
		{
			Buff.<RelatedExtraEffectBuffIdIter>d__270 <RelatedExtraEffectBuffIdIter>d__ = new Buff.<RelatedExtraEffectBuffIdIter>d__270(-2);
			<RelatedExtraEffectBuffIdIter>d__.<>3__<>4__this = this;
			return <RelatedExtraEffectBuffIdIter>d__;
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0020BB7A File Offset: 0x00209D7A
		public string[] RemovalTagIgnores()
		{
			return this.RemovalTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0020BB87 File Offset: 0x00209D87
		public IEnumerable<string> RemovalTagIgnoresIter()
		{
			Buff.<RemovalTagIgnoresIter>d__272 <RemovalTagIgnoresIter>d__ = new Buff.<RemovalTagIgnoresIter>d__272(-2);
			<RemovalTagIgnoresIter>d__.<>3__<>4__this = this;
			return <RemovalTagIgnoresIter>d__;
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x0020BB9C File Offset: 0x00209D9C
		public string[] RemovalTagRequirements()
		{
			return this.RemovalTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x0020BBA9 File Offset: 0x00209DA9
		public IEnumerable<string> RemovalTagRequirementsIter()
		{
			Buff.<RemovalTagRequirementsIter>d__274 <RemovalTagRequirementsIter>d__ = new Buff.<RemovalTagRequirementsIter>d__274(-2);
			<RemovalTagRequirementsIter>d__.<>3__<>4__this = this;
			return <RemovalTagRequirementsIter>d__;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x0020BBBE File Offset: 0x00209DBE
		public string[] RemoveBuffWithTags()
		{
			return this.RemoveBuffWithTagsIter().ToArray<string>();
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x0020BBCB File Offset: 0x00209DCB
		public IEnumerable<string> RemoveBuffWithTagsIter()
		{
			Buff.<RemoveBuffWithTagsIter>d__276 <RemoveBuffWithTagsIter>d__ = new Buff.<RemoveBuffWithTagsIter>d__276(-2);
			<RemoveBuffWithTagsIter>d__.<>3__<>4__this = this;
			return <RemoveBuffWithTagsIter>d__;
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x0020BBE0 File Offset: 0x00209DE0
		public long[] ReplaceBuffIds()
		{
			return this.GetReplaceBuffIdsArray();
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x0020BBE8 File Offset: 0x00209DE8
		public IEnumerable<long> ReplaceBuffIdsIter()
		{
			Buff.<ReplaceBuffIdsIter>d__278 <ReplaceBuffIdsIter>d__ = new Buff.<ReplaceBuffIdsIter>d__278(-2);
			<ReplaceBuffIdsIter>d__.<>3__<>4__this = this;
			return <ReplaceBuffIdsIter>d__;
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0020BBFD File Offset: 0x00209DFD
		public string[] ReplaceConditions()
		{
			return this.ReplaceConditionsIter().ToArray<string>();
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x0020BC0A File Offset: 0x00209E0A
		public IEnumerable<string> ReplaceConditionsIter()
		{
			Buff.<ReplaceConditionsIter>d__280 <ReplaceConditionsIter>d__ = new Buff.<ReplaceConditionsIter>d__280(-2);
			<ReplaceConditionsIter>d__.<>3__<>4__this = this;
			return <ReplaceConditionsIter>d__;
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x0020BC1F File Offset: 0x00209E1F
		public long[] RoutineExpirationEffects()
		{
			return this.GetRoutineExpirationEffectsArray();
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x0020BC27 File Offset: 0x00209E27
		public IEnumerable<long> RoutineExpirationEffectsIter()
		{
			Buff.<RoutineExpirationEffectsIter>d__282 <RoutineExpirationEffectsIter>d__ = new Buff.<RoutineExpirationEffectsIter>d__282(-2);
			<RoutineExpirationEffectsIter>d__.<>3__<>4__this = this;
			return <RoutineExpirationEffectsIter>d__;
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x0020BC3C File Offset: 0x00209E3C
		public IntArray[] TagLogic()
		{
			return this.TagLogicIter().ToArray<IntArray>();
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x0020BC49 File Offset: 0x00209E49
		public IEnumerable<IntArray> TagLogicIter()
		{
			Buff.<TagLogicIter>d__284 <TagLogicIter>d__ = new Buff.<TagLogicIter>d__284(-2);
			<TagLogicIter>d__.<>3__<>4__this = this;
			return <TagLogicIter>d__;
		}

		// Token: 0x04005130 RID: 20784
		private Table __p;
	}
}
