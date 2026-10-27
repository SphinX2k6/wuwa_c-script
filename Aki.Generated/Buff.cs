using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B53 RID: 2899
	[NullableContext(1)]
	[Nullable(0)]
	public struct Buff : IFlatbufferObject
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x001E9BE1 File Offset: 0x001E7DE1
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x001E9BEE File Offset: 0x001E7DEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x001E9BF8 File Offset: 0x001E7DF8
		[NullableContext(0)]
		public static Buff GetRootAsBuff(ByteBuffer _bb)
		{
			return Buff.GetRootAsBuff(_bb, default(Buff));
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x001E9C14 File Offset: 0x001E7E14
		[NullableContext(0)]
		public static Buff GetRootAsBuff(ByteBuffer _bb, Buff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x001E9C31 File Offset: 0x001E7E31
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x001E9C40 File Offset: 0x001E7E40
		[NullableContext(0)]
		public Buff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x001E9C50 File Offset: 0x001E7E50
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x001E9C98 File Offset: 0x001E7E98
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

		// Token: 0x0600501F RID: 20511 RVA: 0x001E9CCF File Offset: 0x001E7ECF
		[NullableContext(0)]
		public Span<byte> GetGeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x001E9CDE File Offset: 0x001E7EDE
		[NullableContext(0)]
		public byte[] GetGeDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x001E9CF8 File Offset: 0x001E7EF8
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

		// Token: 0x06005022 RID: 20514 RVA: 0x001E9D34 File Offset: 0x001E7F34
		public int DurationCalculationPolicy(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x001E9D74 File Offset: 0x001E7F74
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

		// Token: 0x06005024 RID: 20516 RVA: 0x001E9DA0 File Offset: 0x001E7FA0
		[NullableContext(0)]
		public Span<int> GetDurationCalculationPolicyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x001E9DB0 File Offset: 0x001E7FB0
		[NullableContext(0)]
		public int[] GetDurationCalculationPolicyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x001E9DC8 File Offset: 0x001E7FC8
		public float DurationMagnitude(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x001E9E0C File Offset: 0x001E800C
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

		// Token: 0x06005028 RID: 20520 RVA: 0x001E9E38 File Offset: 0x001E8038
		[NullableContext(0)]
		public Span<float> GetDurationMagnitudeBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x001E9E48 File Offset: 0x001E8048
		[NullableContext(0)]
		public float[] GetDurationMagnitudeArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001E9E60 File Offset: 0x001E8060
		public float DurationMagnitude2(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600502B RID: 20523 RVA: 0x001E9EA4 File Offset: 0x001E80A4
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

		// Token: 0x0600502C RID: 20524 RVA: 0x001E9ED0 File Offset: 0x001E80D0
		[NullableContext(0)]
		public Span<float> GetDurationMagnitude2Bytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x001E9EE0 File Offset: 0x001E80E0
		[NullableContext(0)]
		public float[] GetDurationMagnitude2Array()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x001E9EF8 File Offset: 0x001E80F8
		public bool BDurationAffectedByBulletTime
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600502F RID: 20527 RVA: 0x001E9F38 File Offset: 0x001E8138
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x001E9F78 File Offset: 0x001E8178
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

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06005031 RID: 20529 RVA: 0x001E9FBC File Offset: 0x001E81BC
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

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x001EA000 File Offset: 0x001E8200
		public bool BExecutePeriodicEffectOnApplication
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06005033 RID: 20531 RVA: 0x001EA040 File Offset: 0x001E8240
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x001EA080 File Offset: 0x001E8280
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

		// Token: 0x06005035 RID: 20533 RVA: 0x001EA0C0 File Offset: 0x001E82C0
		public int CalculationPolicy(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x001EA100 File Offset: 0x001E8300
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

		// Token: 0x06005037 RID: 20535 RVA: 0x001EA12C File Offset: 0x001E832C
		[NullableContext(0)]
		public Span<int> GetCalculationPolicyBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x001EA13C File Offset: 0x001E833C
		[NullableContext(0)]
		public int[] GetCalculationPolicyArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x001EA154 File Offset: 0x001E8354
		public int ModifierMagnitude(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x001EA194 File Offset: 0x001E8394
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

		// Token: 0x0600503B RID: 20539 RVA: 0x001EA1C0 File Offset: 0x001E83C0
		[NullableContext(0)]
		public Span<int> GetModifierMagnitudeBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x001EA1D0 File Offset: 0x001E83D0
		[NullableContext(0)]
		public int[] GetModifierMagnitudeArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x001EA1E8 File Offset: 0x001E83E8
		public int ModifierMagnitude2(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x001EA228 File Offset: 0x001E8428
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

		// Token: 0x0600503F RID: 20543 RVA: 0x001EA254 File Offset: 0x001E8454
		[NullableContext(0)]
		public Span<int> GetModifierMagnitude2Bytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x001EA264 File Offset: 0x001E8464
		[NullableContext(0)]
		public int[] GetModifierMagnitude2Array()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x001EA27C File Offset: 0x001E847C
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x001EA2BC File Offset: 0x001E84BC
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x001EA2FC File Offset: 0x001E84FC
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x001EA33C File Offset: 0x001E853C
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06005045 RID: 20549 RVA: 0x001EA37C File Offset: 0x001E857C
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x001EA3BC File Offset: 0x001E85BC
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

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06005047 RID: 20551 RVA: 0x001EA3FC File Offset: 0x001E85FC
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06005048 RID: 20552 RVA: 0x001EA43C File Offset: 0x001E863C
		public bool BDenyOverflowApplication
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06005049 RID: 20553 RVA: 0x001EA47C File Offset: 0x001E867C
		public bool BClearStackOnOverflow
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x001EA4BC File Offset: 0x001E86BC
		public bool BRequireModifierSuccessToTriggerCues
		{
			get
			{
				int num = this.__p.__offset(54);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x001EA4FC File Offset: 0x001E86FC
		public bool BSuppressStackingCues
		{
			get
			{
				int num = this.__p.__offset(56);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x001EA53C File Offset: 0x001E873C
		public long GameplayCueIds(int j)
		{
			int num = this.__p.__offset(58);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600504D RID: 20557 RVA: 0x001EA588 File Offset: 0x001E8788
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

		// Token: 0x0600504E RID: 20558 RVA: 0x001EA5B4 File Offset: 0x001E87B4
		[NullableContext(0)]
		public Span<long> GetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(58, 8));
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x001EA5C9 File Offset: 0x001E87C9
		[NullableContext(0)]
		public long[] GetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(58) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x001EA608 File Offset: 0x001E8808
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

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x001EA644 File Offset: 0x001E8844
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

		// Token: 0x06005052 RID: 20562 RVA: 0x001EA670 File Offset: 0x001E8870
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06005053 RID: 20563 RVA: 0x001EA6AC File Offset: 0x001E88AC
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

		// Token: 0x06005054 RID: 20564 RVA: 0x001EA6D8 File Offset: 0x001E88D8
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06005055 RID: 20565 RVA: 0x001EA714 File Offset: 0x001E8914
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

		// Token: 0x06005056 RID: 20566 RVA: 0x001EA740 File Offset: 0x001E8940
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06005057 RID: 20567 RVA: 0x001EA77C File Offset: 0x001E897C
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

		// Token: 0x06005058 RID: 20568 RVA: 0x001EA7A8 File Offset: 0x001E89A8
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x001EA7E4 File Offset: 0x001E89E4
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

		// Token: 0x0600505A RID: 20570 RVA: 0x001EA810 File Offset: 0x001E8A10
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600505B RID: 20571 RVA: 0x001EA84C File Offset: 0x001E8A4C
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

		// Token: 0x0600505C RID: 20572 RVA: 0x001EA878 File Offset: 0x001E8A78
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600505D RID: 20573 RVA: 0x001EA8B4 File Offset: 0x001E8AB4
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

		// Token: 0x0600505E RID: 20574 RVA: 0x001EA8E0 File Offset: 0x001E8AE0
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600505F RID: 20575 RVA: 0x001EA91C File Offset: 0x001E8B1C
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

		// Token: 0x06005060 RID: 20576 RVA: 0x001EA948 File Offset: 0x001E8B48
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x001EA984 File Offset: 0x001E8B84
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

		// Token: 0x06005062 RID: 20578 RVA: 0x001EA9B0 File Offset: 0x001E8BB0
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06005063 RID: 20579 RVA: 0x001EA9EC File Offset: 0x001E8BEC
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

		// Token: 0x06005064 RID: 20580 RVA: 0x001EAA18 File Offset: 0x001E8C18
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x001EAA54 File Offset: 0x001E8C54
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

		// Token: 0x06005066 RID: 20582 RVA: 0x001EAA80 File Offset: 0x001E8C80
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06005067 RID: 20583 RVA: 0x001EAABC File Offset: 0x001E8CBC
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

		// Token: 0x06005068 RID: 20584 RVA: 0x001EAAE8 File Offset: 0x001E8CE8
		public long PrematureExpirationEffects(int j)
		{
			int num = this.__p.__offset(84);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x001EAB34 File Offset: 0x001E8D34
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

		// Token: 0x0600506A RID: 20586 RVA: 0x001EAB60 File Offset: 0x001E8D60
		[NullableContext(0)]
		public Span<long> GetPrematureExpirationEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(84, 8));
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x001EAB75 File Offset: 0x001E8D75
		[NullableContext(0)]
		public long[] GetPrematureExpirationEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(84) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x001EABB4 File Offset: 0x001E8DB4
		public long RoutineExpirationEffects(int j)
		{
			int num = this.__p.__offset(86);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600506D RID: 20589 RVA: 0x001EAC00 File Offset: 0x001E8E00
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

		// Token: 0x0600506E RID: 20590 RVA: 0x001EAC2C File Offset: 0x001E8E2C
		[NullableContext(0)]
		public Span<long> GetRoutineExpirationEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(86, 8));
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x001EAC41 File Offset: 0x001E8E41
		[NullableContext(0)]
		public long[] GetRoutineExpirationEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(86) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x001EAC80 File Offset: 0x001E8E80
		public long OverflowEffects(int j)
		{
			int num = this.__p.__offset(88);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x001EACCC File Offset: 0x001E8ECC
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

		// Token: 0x06005072 RID: 20594 RVA: 0x001EACF8 File Offset: 0x001E8EF8
		[NullableContext(0)]
		public Span<long> GetOverflowEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(88, 8));
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x001EAD0D File Offset: 0x001E8F0D
		[NullableContext(0)]
		public long[] GetOverflowEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(88) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x001EAD4C File Offset: 0x001E8F4C
		public long RelatedExtraEffectBuffId(int j)
		{
			int num = this.__p.__offset(90);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x001EAD98 File Offset: 0x001E8F98
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

		// Token: 0x06005076 RID: 20598 RVA: 0x001EADC4 File Offset: 0x001E8FC4
		[NullableContext(0)]
		public Span<long> GetRelatedExtraEffectBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(90, 8));
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x001EADD9 File Offset: 0x001E8FD9
		[NullableContext(0)]
		public long[] GetRelatedExtraEffectBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(90) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x001EAE18 File Offset: 0x001E9018
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

		// Token: 0x06005079 RID: 20601 RVA: 0x001EAE58 File Offset: 0x001E9058
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

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x001EAE94 File Offset: 0x001E9094
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

		// Token: 0x0600507B RID: 20603 RVA: 0x001EAEC0 File Offset: 0x001E90C0
		public int ExtraEffectParametersGrow1(int j)
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x001EAF00 File Offset: 0x001E9100
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

		// Token: 0x0600507D RID: 20605 RVA: 0x001EAF2C File Offset: 0x001E912C
		[NullableContext(0)]
		public Span<int> GetExtraEffectParametersGrow1Bytes()
		{
			return this.__p.__vector_as_span<int>(96, 4);
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x001EAF3C File Offset: 0x001E913C
		[NullableContext(0)]
		public int[] GetExtraEffectParametersGrow1Array()
		{
			return this.__p.__vector_as_array<int>(96) ?? Array.Empty<int>();
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x001EAF54 File Offset: 0x001E9154
		public int ExtraEffectParametersGrow2(int j)
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x001EAF94 File Offset: 0x001E9194
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

		// Token: 0x06005081 RID: 20609 RVA: 0x001EAFC0 File Offset: 0x001E91C0
		[NullableContext(0)]
		public Span<int> GetExtraEffectParametersGrow2Bytes()
		{
			return this.__p.__vector_as_span<int>(98, 4);
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x001EAFD0 File Offset: 0x001E91D0
		[NullableContext(0)]
		public int[] GetExtraEffectParametersGrow2Array()
		{
			return this.__p.__vector_as_array<int>(98) ?? Array.Empty<int>();
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x001EAFE8 File Offset: 0x001E91E8
		public int ExtraEffectRequirements(int j)
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x001EB028 File Offset: 0x001E9228
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

		// Token: 0x06005085 RID: 20613 RVA: 0x001EB054 File Offset: 0x001E9254
		[NullableContext(0)]
		public Span<int> GetExtraEffectRequirementsBytes()
		{
			return this.__p.__vector_as_span<int>(100, 4);
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x001EB064 File Offset: 0x001E9264
		[NullableContext(0)]
		public int[] GetExtraEffectRequirementsArray()
		{
			return this.__p.__vector_as_array<int>(100) ?? Array.Empty<int>();
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x001EB07C File Offset: 0x001E927C
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06005088 RID: 20616 RVA: 0x001EB0B8 File Offset: 0x001E92B8
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x001EB0E4 File Offset: 0x001E92E4
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

		// Token: 0x0600508A RID: 20618 RVA: 0x001EB124 File Offset: 0x001E9324
		public float ExtraEffectCD(int j)
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x001EB168 File Offset: 0x001E9368
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

		// Token: 0x0600508C RID: 20620 RVA: 0x001EB194 File Offset: 0x001E9394
		[NullableContext(0)]
		public Span<float> GetExtraEffectCDBytes()
		{
			return this.__p.__vector_as_span<float>(106, 4);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x001EB1A4 File Offset: 0x001E93A4
		[NullableContext(0)]
		public float[] GetExtraEffectCDArray()
		{
			return this.__p.__vector_as_array<float>(106) ?? Array.Empty<float>();
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x001EB1BC File Offset: 0x001E93BC
		public float ExtraEffectCdForTarget(int j)
		{
			int num = this.__p.__offset(108);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x001EB200 File Offset: 0x001E9400
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

		// Token: 0x06005090 RID: 20624 RVA: 0x001EB22C File Offset: 0x001E942C
		[NullableContext(0)]
		public Span<float> GetExtraEffectCdForTargetBytes()
		{
			return this.__p.__vector_as_span<float>(108, 4);
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x001EB23C File Offset: 0x001E943C
		[NullableContext(0)]
		public float[] GetExtraEffectCdForTargetArray()
		{
			return this.__p.__vector_as_array<float>(108) ?? Array.Empty<float>();
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x001EB254 File Offset: 0x001E9454
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

		// Token: 0x06005093 RID: 20627 RVA: 0x001EB294 File Offset: 0x001E9494
		public int ExtraEffectProbability(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x001EB2D4 File Offset: 0x001E94D4
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

		// Token: 0x06005095 RID: 20629 RVA: 0x001EB300 File Offset: 0x001E9500
		[NullableContext(0)]
		public Span<int> GetExtraEffectProbabilityBytes()
		{
			return this.__p.__vector_as_span<int>(112, 4);
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x001EB310 File Offset: 0x001E9510
		[NullableContext(0)]
		public int[] GetExtraEffectProbabilityArray()
		{
			return this.__p.__vector_as_array<int>(112) ?? Array.Empty<int>();
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x001EB328 File Offset: 0x001E9528
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x001EB364 File Offset: 0x001E9564
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

		// Token: 0x06005099 RID: 20633 RVA: 0x001EB390 File Offset: 0x001E9590
		public IntArray? TagLogic(int j)
		{
			int num = this.__p.__offset(116);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x001EB3F4 File Offset: 0x001E95F4
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x001EB420 File Offset: 0x001E9620
		public bool DeadRemove
		{
			get
			{
				int num = this.__p.__offset(118);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x001EB460 File Offset: 0x001E9660
		public long RelatedAttributeBuffId(int j)
		{
			int num = this.__p.__offset(120);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x001EB4AC File Offset: 0x001E96AC
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

		// Token: 0x0600509E RID: 20638 RVA: 0x001EB4D8 File Offset: 0x001E96D8
		[NullableContext(0)]
		public Span<long> GetRelatedAttributeBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(120, 8));
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x001EB4ED File Offset: 0x001E96ED
		[NullableContext(0)]
		public long[] GetRelatedAttributeBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(120) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x001EB52C File Offset: 0x001E972C
		public bool BOnlyLocalAdd
		{
			get
			{
				int num = this.__p.__offset(122);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x001EB56C File Offset: 0x001E976C
		public long ReplaceBuffIds(int j)
		{
			int num = this.__p.__offset(124);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x001EB5B8 File Offset: 0x001E97B8
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

		// Token: 0x060050A3 RID: 20643 RVA: 0x001EB5E4 File Offset: 0x001E97E4
		[NullableContext(0)]
		public Span<long> GetReplaceBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(124, 8));
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x001EB5F9 File Offset: 0x001E97F9
		[NullableContext(0)]
		public long[] GetReplaceBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(124) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x001EB638 File Offset: 0x001E9838
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x001EB674 File Offset: 0x001E9874
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

		// Token: 0x060050A7 RID: 20647 RVA: 0x001EB6A0 File Offset: 0x001E98A0
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x001EB6E0 File Offset: 0x001E98E0
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

		// Token: 0x060050A9 RID: 20649 RVA: 0x001EB70F File Offset: 0x001E990F
		[Obsolete("本方法用于缓存,遍历请使用ApplicationSourceTagIgnoresIter()或GetApplicationSourceTagIgnoresBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ApplicationSourceTagIgnores()
		{
			return this.ApplicationSourceTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x001EB71C File Offset: 0x001E991C
		public readonly IEnumerable<string> ApplicationSourceTagIgnoresIter()
		{
			Buff.<ApplicationSourceTagIgnoresIter>d__212 <ApplicationSourceTagIgnoresIter>d__ = new Buff.<ApplicationSourceTagIgnoresIter>d__212(-2);
			<ApplicationSourceTagIgnoresIter>d__.<>3__<>4__this = this;
			return <ApplicationSourceTagIgnoresIter>d__;
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x001EB731 File Offset: 0x001E9931
		[Obsolete("本方法用于缓存,遍历请使用ApplicationSourceTagRequirementsIter()或GetApplicationSourceTagRequirementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ApplicationSourceTagRequirements()
		{
			return this.ApplicationSourceTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x001EB73E File Offset: 0x001E993E
		public readonly IEnumerable<string> ApplicationSourceTagRequirementsIter()
		{
			Buff.<ApplicationSourceTagRequirementsIter>d__214 <ApplicationSourceTagRequirementsIter>d__ = new Buff.<ApplicationSourceTagRequirementsIter>d__214(-2);
			<ApplicationSourceTagRequirementsIter>d__.<>3__<>4__this = this;
			return <ApplicationSourceTagRequirementsIter>d__;
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x001EB753 File Offset: 0x001E9953
		[Obsolete("本方法用于缓存,遍历请使用ApplicationTagIgnoresIter()或GetApplicationTagIgnoresBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ApplicationTagIgnores()
		{
			return this.ApplicationTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x001EB760 File Offset: 0x001E9960
		public readonly IEnumerable<string> ApplicationTagIgnoresIter()
		{
			Buff.<ApplicationTagIgnoresIter>d__216 <ApplicationTagIgnoresIter>d__ = new Buff.<ApplicationTagIgnoresIter>d__216(-2);
			<ApplicationTagIgnoresIter>d__.<>3__<>4__this = this;
			return <ApplicationTagIgnoresIter>d__;
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x001EB775 File Offset: 0x001E9975
		[Obsolete("本方法用于缓存,遍历请使用ApplicationTagRequirementsIter()或GetApplicationTagRequirementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ApplicationTagRequirements()
		{
			return this.ApplicationTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x001EB782 File Offset: 0x001E9982
		public readonly IEnumerable<string> ApplicationTagRequirementsIter()
		{
			Buff.<ApplicationTagRequirementsIter>d__218 <ApplicationTagRequirementsIter>d__ = new Buff.<ApplicationTagRequirementsIter>d__218(-2);
			<ApplicationTagRequirementsIter>d__.<>3__<>4__this = this;
			return <ApplicationTagRequirementsIter>d__;
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x001EB797 File Offset: 0x001E9997
		[Obsolete("本方法用于缓存,遍历请使用BuffActionIter()或GetBuffActionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffAction()
		{
			return this.BuffActionIter().ToArray<string>();
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x001EB7A4 File Offset: 0x001E99A4
		public readonly IEnumerable<string> BuffActionIter()
		{
			Buff.<BuffActionIter>d__220 <BuffActionIter>d__ = new Buff.<BuffActionIter>d__220(-2);
			<BuffActionIter>d__.<>3__<>4__this = this;
			return <BuffActionIter>d__;
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x001EB7BC File Offset: 0x001E99BC
		[Obsolete("本方法用于缓存,遍历请使用CalculationPolicyIter()或GetCalculationPolicyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CalculationPolicy()
		{
			Buff buff = this;
			return buff.GetCalculationPolicyArray() ?? Array.Empty<int>();
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x001EB7E0 File Offset: 0x001E99E0
		public readonly IEnumerable<int> CalculationPolicyIter()
		{
			Buff.<CalculationPolicyIter>d__222 <CalculationPolicyIter>d__ = new Buff.<CalculationPolicyIter>d__222(-2);
			<CalculationPolicyIter>d__.<>3__<>4__this = this;
			return <CalculationPolicyIter>d__;
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x001EB7F8 File Offset: 0x001E99F8
		[Obsolete("本方法用于缓存,遍历请使用DurationCalculationPolicyIter()或GetDurationCalculationPolicyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DurationCalculationPolicy()
		{
			Buff buff = this;
			return buff.GetDurationCalculationPolicyArray() ?? Array.Empty<int>();
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x001EB81C File Offset: 0x001E9A1C
		public readonly IEnumerable<int> DurationCalculationPolicyIter()
		{
			Buff.<DurationCalculationPolicyIter>d__224 <DurationCalculationPolicyIter>d__ = new Buff.<DurationCalculationPolicyIter>d__224(-2);
			<DurationCalculationPolicyIter>d__.<>3__<>4__this = this;
			return <DurationCalculationPolicyIter>d__;
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x001EB834 File Offset: 0x001E9A34
		[Obsolete("本方法用于缓存,遍历请使用DurationMagnitudeIter()或GetDurationMagnitudeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] DurationMagnitude()
		{
			Buff buff = this;
			return buff.GetDurationMagnitudeArray() ?? Array.Empty<float>();
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x001EB858 File Offset: 0x001E9A58
		public readonly IEnumerable<float> DurationMagnitudeIter()
		{
			Buff.<DurationMagnitudeIter>d__226 <DurationMagnitudeIter>d__ = new Buff.<DurationMagnitudeIter>d__226(-2);
			<DurationMagnitudeIter>d__.<>3__<>4__this = this;
			return <DurationMagnitudeIter>d__;
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x001EB870 File Offset: 0x001E9A70
		[Obsolete("本方法用于缓存,遍历请使用DurationMagnitude2Iter()或GetDurationMagnitude2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] DurationMagnitude2()
		{
			Buff buff = this;
			return buff.GetDurationMagnitude2Array() ?? Array.Empty<float>();
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x001EB894 File Offset: 0x001E9A94
		public readonly IEnumerable<float> DurationMagnitude2Iter()
		{
			Buff.<DurationMagnitude2Iter>d__228 <DurationMagnitude2Iter>d__ = new Buff.<DurationMagnitude2Iter>d__228(-2);
			<DurationMagnitude2Iter>d__.<>3__<>4__this = this;
			return <DurationMagnitude2Iter>d__;
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x001EB8AC File Offset: 0x001E9AAC
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectCDIter()或GetExtraEffectCDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ExtraEffectCD()
		{
			Buff buff = this;
			return buff.GetExtraEffectCDArray() ?? Array.Empty<float>();
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x001EB8D0 File Offset: 0x001E9AD0
		public readonly IEnumerable<float> ExtraEffectCDIter()
		{
			Buff.<ExtraEffectCDIter>d__230 <ExtraEffectCDIter>d__ = new Buff.<ExtraEffectCDIter>d__230(-2);
			<ExtraEffectCDIter>d__.<>3__<>4__this = this;
			return <ExtraEffectCDIter>d__;
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x001EB8E8 File Offset: 0x001E9AE8
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectCdForTargetIter()或GetExtraEffectCdForTargetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ExtraEffectCdForTarget()
		{
			Buff buff = this;
			return buff.GetExtraEffectCdForTargetArray() ?? Array.Empty<float>();
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x001EB90C File Offset: 0x001E9B0C
		public readonly IEnumerable<float> ExtraEffectCdForTargetIter()
		{
			Buff.<ExtraEffectCdForTargetIter>d__232 <ExtraEffectCdForTargetIter>d__ = new Buff.<ExtraEffectCdForTargetIter>d__232(-2);
			<ExtraEffectCdForTargetIter>d__.<>3__<>4__this = this;
			return <ExtraEffectCdForTargetIter>d__;
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x001EB921 File Offset: 0x001E9B21
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectParametersIter()或GetExtraEffectParametersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectParameters()
		{
			return this.ExtraEffectParametersIter().ToArray<string>();
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x001EB92E File Offset: 0x001E9B2E
		public readonly IEnumerable<string> ExtraEffectParametersIter()
		{
			Buff.<ExtraEffectParametersIter>d__234 <ExtraEffectParametersIter>d__ = new Buff.<ExtraEffectParametersIter>d__234(-2);
			<ExtraEffectParametersIter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersIter>d__;
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x001EB944 File Offset: 0x001E9B44
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectParametersGrow1Iter()或GetExtraEffectParametersGrow1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraEffectParametersGrow1()
		{
			Buff buff = this;
			return buff.GetExtraEffectParametersGrow1Array() ?? Array.Empty<int>();
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x001EB968 File Offset: 0x001E9B68
		public readonly IEnumerable<int> ExtraEffectParametersGrow1Iter()
		{
			Buff.<ExtraEffectParametersGrow1Iter>d__236 <ExtraEffectParametersGrow1Iter>d__ = new Buff.<ExtraEffectParametersGrow1Iter>d__236(-2);
			<ExtraEffectParametersGrow1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow1Iter>d__;
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x001EB980 File Offset: 0x001E9B80
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectParametersGrow2Iter()或GetExtraEffectParametersGrow2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraEffectParametersGrow2()
		{
			Buff buff = this;
			return buff.GetExtraEffectParametersGrow2Array() ?? Array.Empty<int>();
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x001EB9A4 File Offset: 0x001E9BA4
		public readonly IEnumerable<int> ExtraEffectParametersGrow2Iter()
		{
			Buff.<ExtraEffectParametersGrow2Iter>d__238 <ExtraEffectParametersGrow2Iter>d__ = new Buff.<ExtraEffectParametersGrow2Iter>d__238(-2);
			<ExtraEffectParametersGrow2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow2Iter>d__;
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x001EB9B9 File Offset: 0x001E9BB9
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectParametersGrow3Iter()或GetExtraEffectParametersGrow3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectParametersGrow3()
		{
			return this.ExtraEffectParametersGrow3Iter().ToArray<string>();
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x001EB9C6 File Offset: 0x001E9BC6
		public readonly IEnumerable<string> ExtraEffectParametersGrow3Iter()
		{
			Buff.<ExtraEffectParametersGrow3Iter>d__240 <ExtraEffectParametersGrow3Iter>d__ = new Buff.<ExtraEffectParametersGrow3Iter>d__240(-2);
			<ExtraEffectParametersGrow3Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectParametersGrow3Iter>d__;
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x001EB9DC File Offset: 0x001E9BDC
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectProbabilityIter()或GetExtraEffectProbabilityBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraEffectProbability()
		{
			Buff buff = this;
			return buff.GetExtraEffectProbabilityArray() ?? Array.Empty<int>();
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x001EBA00 File Offset: 0x001E9C00
		public readonly IEnumerable<int> ExtraEffectProbabilityIter()
		{
			Buff.<ExtraEffectProbabilityIter>d__242 <ExtraEffectProbabilityIter>d__ = new Buff.<ExtraEffectProbabilityIter>d__242(-2);
			<ExtraEffectProbabilityIter>d__.<>3__<>4__this = this;
			return <ExtraEffectProbabilityIter>d__;
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x001EBA15 File Offset: 0x001E9C15
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectReqParaIter()或GetExtraEffectReqParaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectReqPara()
		{
			return this.ExtraEffectReqParaIter().ToArray<string>();
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x001EBA22 File Offset: 0x001E9C22
		public readonly IEnumerable<string> ExtraEffectReqParaIter()
		{
			Buff.<ExtraEffectReqParaIter>d__244 <ExtraEffectReqParaIter>d__ = new Buff.<ExtraEffectReqParaIter>d__244(-2);
			<ExtraEffectReqParaIter>d__.<>3__<>4__this = this;
			return <ExtraEffectReqParaIter>d__;
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x001EBA38 File Offset: 0x001E9C38
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectRequirementsIter()或GetExtraEffectRequirementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraEffectRequirements()
		{
			Buff buff = this;
			return buff.GetExtraEffectRequirementsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x001EBA5C File Offset: 0x001E9C5C
		public readonly IEnumerable<int> ExtraEffectRequirementsIter()
		{
			Buff.<ExtraEffectRequirementsIter>d__246 <ExtraEffectRequirementsIter>d__ = new Buff.<ExtraEffectRequirementsIter>d__246(-2);
			<ExtraEffectRequirementsIter>d__.<>3__<>4__this = this;
			return <ExtraEffectRequirementsIter>d__;
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x001EBA74 File Offset: 0x001E9C74
		[Obsolete("本方法用于缓存,遍历请使用GameplayCueIdsIter()或GetGameplayCueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] GameplayCueIds()
		{
			Buff buff = this;
			return buff.GetGameplayCueIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x001EBA98 File Offset: 0x001E9C98
		public readonly IEnumerable<long> GameplayCueIdsIter()
		{
			Buff.<GameplayCueIdsIter>d__248 <GameplayCueIdsIter>d__ = new Buff.<GameplayCueIdsIter>d__248(-2);
			<GameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <GameplayCueIdsIter>d__;
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x001EBAAD File Offset: 0x001E9CAD
		[Obsolete("本方法用于缓存,遍历请使用GrantedApplicationImmunityTagIgnoresIter()或GetGrantedApplicationImmunityTagIgnoresBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] GrantedApplicationImmunityTagIgnores()
		{
			return this.GrantedApplicationImmunityTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x001EBABA File Offset: 0x001E9CBA
		public readonly IEnumerable<string> GrantedApplicationImmunityTagIgnoresIter()
		{
			Buff.<GrantedApplicationImmunityTagIgnoresIter>d__250 <GrantedApplicationImmunityTagIgnoresIter>d__ = new Buff.<GrantedApplicationImmunityTagIgnoresIter>d__250(-2);
			<GrantedApplicationImmunityTagIgnoresIter>d__.<>3__<>4__this = this;
			return <GrantedApplicationImmunityTagIgnoresIter>d__;
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x001EBACF File Offset: 0x001E9CCF
		[Obsolete("本方法用于缓存,遍历请使用GrantedApplicationImmunityTagsIter()或GetGrantedApplicationImmunityTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] GrantedApplicationImmunityTags()
		{
			return this.GrantedApplicationImmunityTagsIter().ToArray<string>();
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x001EBADC File Offset: 0x001E9CDC
		public readonly IEnumerable<string> GrantedApplicationImmunityTagsIter()
		{
			Buff.<GrantedApplicationImmunityTagsIter>d__252 <GrantedApplicationImmunityTagsIter>d__ = new Buff.<GrantedApplicationImmunityTagsIter>d__252(-2);
			<GrantedApplicationImmunityTagsIter>d__.<>3__<>4__this = this;
			return <GrantedApplicationImmunityTagsIter>d__;
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x001EBAF1 File Offset: 0x001E9CF1
		[Obsolete("本方法用于缓存,遍历请使用GrantedTagsIter()或GetGrantedTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] GrantedTags()
		{
			return this.GrantedTagsIter().ToArray<string>();
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x001EBAFE File Offset: 0x001E9CFE
		public readonly IEnumerable<string> GrantedTagsIter()
		{
			Buff.<GrantedTagsIter>d__254 <GrantedTagsIter>d__ = new Buff.<GrantedTagsIter>d__254(-2);
			<GrantedTagsIter>d__.<>3__<>4__this = this;
			return <GrantedTagsIter>d__;
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x001EBB14 File Offset: 0x001E9D14
		[Obsolete("本方法用于缓存,遍历请使用ModifierMagnitudeIter()或GetModifierMagnitudeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ModifierMagnitude()
		{
			Buff buff = this;
			return buff.GetModifierMagnitudeArray() ?? Array.Empty<int>();
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x001EBB38 File Offset: 0x001E9D38
		public readonly IEnumerable<int> ModifierMagnitudeIter()
		{
			Buff.<ModifierMagnitudeIter>d__256 <ModifierMagnitudeIter>d__ = new Buff.<ModifierMagnitudeIter>d__256(-2);
			<ModifierMagnitudeIter>d__.<>3__<>4__this = this;
			return <ModifierMagnitudeIter>d__;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x001EBB50 File Offset: 0x001E9D50
		[Obsolete("本方法用于缓存,遍历请使用ModifierMagnitude2Iter()或GetModifierMagnitude2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ModifierMagnitude2()
		{
			Buff buff = this;
			return buff.GetModifierMagnitude2Array() ?? Array.Empty<int>();
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x001EBB74 File Offset: 0x001E9D74
		public readonly IEnumerable<int> ModifierMagnitude2Iter()
		{
			Buff.<ModifierMagnitude2Iter>d__258 <ModifierMagnitude2Iter>d__ = new Buff.<ModifierMagnitude2Iter>d__258(-2);
			<ModifierMagnitude2Iter>d__.<>3__<>4__this = this;
			return <ModifierMagnitude2Iter>d__;
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x001EBB89 File Offset: 0x001E9D89
		[Obsolete("本方法用于缓存,遍历请使用OngoingTagIgnoresIter()或GetOngoingTagIgnoresBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OngoingTagIgnores()
		{
			return this.OngoingTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x001EBB96 File Offset: 0x001E9D96
		public readonly IEnumerable<string> OngoingTagIgnoresIter()
		{
			Buff.<OngoingTagIgnoresIter>d__260 <OngoingTagIgnoresIter>d__ = new Buff.<OngoingTagIgnoresIter>d__260(-2);
			<OngoingTagIgnoresIter>d__.<>3__<>4__this = this;
			return <OngoingTagIgnoresIter>d__;
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x001EBBAB File Offset: 0x001E9DAB
		[Obsolete("本方法用于缓存,遍历请使用OngoingTagRequirementsIter()或GetOngoingTagRequirementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OngoingTagRequirements()
		{
			return this.OngoingTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x001EBBB8 File Offset: 0x001E9DB8
		public readonly IEnumerable<string> OngoingTagRequirementsIter()
		{
			Buff.<OngoingTagRequirementsIter>d__262 <OngoingTagRequirementsIter>d__ = new Buff.<OngoingTagRequirementsIter>d__262(-2);
			<OngoingTagRequirementsIter>d__.<>3__<>4__this = this;
			return <OngoingTagRequirementsIter>d__;
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x001EBBD0 File Offset: 0x001E9DD0
		[Obsolete("本方法用于缓存,遍历请使用OverflowEffectsIter()或GetOverflowEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] OverflowEffects()
		{
			Buff buff = this;
			return buff.GetOverflowEffectsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x001EBBF4 File Offset: 0x001E9DF4
		public readonly IEnumerable<long> OverflowEffectsIter()
		{
			Buff.<OverflowEffectsIter>d__264 <OverflowEffectsIter>d__ = new Buff.<OverflowEffectsIter>d__264(-2);
			<OverflowEffectsIter>d__.<>3__<>4__this = this;
			return <OverflowEffectsIter>d__;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x001EBC0C File Offset: 0x001E9E0C
		[Obsolete("本方法用于缓存,遍历请使用PrematureExpirationEffectsIter()或GetPrematureExpirationEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] PrematureExpirationEffects()
		{
			Buff buff = this;
			return buff.GetPrematureExpirationEffectsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x001EBC30 File Offset: 0x001E9E30
		public readonly IEnumerable<long> PrematureExpirationEffectsIter()
		{
			Buff.<PrematureExpirationEffectsIter>d__266 <PrematureExpirationEffectsIter>d__ = new Buff.<PrematureExpirationEffectsIter>d__266(-2);
			<PrematureExpirationEffectsIter>d__.<>3__<>4__this = this;
			return <PrematureExpirationEffectsIter>d__;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x001EBC48 File Offset: 0x001E9E48
		[Obsolete("本方法用于缓存,遍历请使用RelatedAttributeBuffIdIter()或GetRelatedAttributeBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] RelatedAttributeBuffId()
		{
			Buff buff = this;
			return buff.GetRelatedAttributeBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x001EBC6C File Offset: 0x001E9E6C
		public readonly IEnumerable<long> RelatedAttributeBuffIdIter()
		{
			Buff.<RelatedAttributeBuffIdIter>d__268 <RelatedAttributeBuffIdIter>d__ = new Buff.<RelatedAttributeBuffIdIter>d__268(-2);
			<RelatedAttributeBuffIdIter>d__.<>3__<>4__this = this;
			return <RelatedAttributeBuffIdIter>d__;
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x001EBC84 File Offset: 0x001E9E84
		[Obsolete("本方法用于缓存,遍历请使用RelatedExtraEffectBuffIdIter()或GetRelatedExtraEffectBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] RelatedExtraEffectBuffId()
		{
			Buff buff = this;
			return buff.GetRelatedExtraEffectBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x001EBCA8 File Offset: 0x001E9EA8
		public readonly IEnumerable<long> RelatedExtraEffectBuffIdIter()
		{
			Buff.<RelatedExtraEffectBuffIdIter>d__270 <RelatedExtraEffectBuffIdIter>d__ = new Buff.<RelatedExtraEffectBuffIdIter>d__270(-2);
			<RelatedExtraEffectBuffIdIter>d__.<>3__<>4__this = this;
			return <RelatedExtraEffectBuffIdIter>d__;
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x001EBCBD File Offset: 0x001E9EBD
		[Obsolete("本方法用于缓存,遍历请使用RemovalTagIgnoresIter()或GetRemovalTagIgnoresBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RemovalTagIgnores()
		{
			return this.RemovalTagIgnoresIter().ToArray<string>();
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x001EBCCA File Offset: 0x001E9ECA
		public readonly IEnumerable<string> RemovalTagIgnoresIter()
		{
			Buff.<RemovalTagIgnoresIter>d__272 <RemovalTagIgnoresIter>d__ = new Buff.<RemovalTagIgnoresIter>d__272(-2);
			<RemovalTagIgnoresIter>d__.<>3__<>4__this = this;
			return <RemovalTagIgnoresIter>d__;
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x001EBCDF File Offset: 0x001E9EDF
		[Obsolete("本方法用于缓存,遍历请使用RemovalTagRequirementsIter()或GetRemovalTagRequirementsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RemovalTagRequirements()
		{
			return this.RemovalTagRequirementsIter().ToArray<string>();
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x001EBCEC File Offset: 0x001E9EEC
		public readonly IEnumerable<string> RemovalTagRequirementsIter()
		{
			Buff.<RemovalTagRequirementsIter>d__274 <RemovalTagRequirementsIter>d__ = new Buff.<RemovalTagRequirementsIter>d__274(-2);
			<RemovalTagRequirementsIter>d__.<>3__<>4__this = this;
			return <RemovalTagRequirementsIter>d__;
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x001EBD01 File Offset: 0x001E9F01
		[Obsolete("本方法用于缓存,遍历请使用RemoveBuffWithTagsIter()或GetRemoveBuffWithTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RemoveBuffWithTags()
		{
			return this.RemoveBuffWithTagsIter().ToArray<string>();
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x001EBD0E File Offset: 0x001E9F0E
		public readonly IEnumerable<string> RemoveBuffWithTagsIter()
		{
			Buff.<RemoveBuffWithTagsIter>d__276 <RemoveBuffWithTagsIter>d__ = new Buff.<RemoveBuffWithTagsIter>d__276(-2);
			<RemoveBuffWithTagsIter>d__.<>3__<>4__this = this;
			return <RemoveBuffWithTagsIter>d__;
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x001EBD24 File Offset: 0x001E9F24
		[Obsolete("本方法用于缓存,遍历请使用ReplaceBuffIdsIter()或GetReplaceBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ReplaceBuffIds()
		{
			Buff buff = this;
			return buff.GetReplaceBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x001EBD48 File Offset: 0x001E9F48
		public readonly IEnumerable<long> ReplaceBuffIdsIter()
		{
			Buff.<ReplaceBuffIdsIter>d__278 <ReplaceBuffIdsIter>d__ = new Buff.<ReplaceBuffIdsIter>d__278(-2);
			<ReplaceBuffIdsIter>d__.<>3__<>4__this = this;
			return <ReplaceBuffIdsIter>d__;
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x001EBD5D File Offset: 0x001E9F5D
		[Obsolete("本方法用于缓存,遍历请使用ReplaceConditionsIter()或GetReplaceConditionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ReplaceConditions()
		{
			return this.ReplaceConditionsIter().ToArray<string>();
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x001EBD6A File Offset: 0x001E9F6A
		public readonly IEnumerable<string> ReplaceConditionsIter()
		{
			Buff.<ReplaceConditionsIter>d__280 <ReplaceConditionsIter>d__ = new Buff.<ReplaceConditionsIter>d__280(-2);
			<ReplaceConditionsIter>d__.<>3__<>4__this = this;
			return <ReplaceConditionsIter>d__;
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x001EBD80 File Offset: 0x001E9F80
		[Obsolete("本方法用于缓存,遍历请使用RoutineExpirationEffectsIter()或GetRoutineExpirationEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] RoutineExpirationEffects()
		{
			Buff buff = this;
			return buff.GetRoutineExpirationEffectsArray() ?? Array.Empty<long>();
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x001EBDA4 File Offset: 0x001E9FA4
		public readonly IEnumerable<long> RoutineExpirationEffectsIter()
		{
			Buff.<RoutineExpirationEffectsIter>d__282 <RoutineExpirationEffectsIter>d__ = new Buff.<RoutineExpirationEffectsIter>d__282(-2);
			<RoutineExpirationEffectsIter>d__.<>3__<>4__this = this;
			return <RoutineExpirationEffectsIter>d__;
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x001EBDB9 File Offset: 0x001E9FB9
		[Obsolete("本方法用于缓存,遍历请使用TagLogicIter()或GetTagLogicBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] TagLogic()
		{
			return this.TagLogicIter().ToArray<IntArray>();
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x001EBDC6 File Offset: 0x001E9FC6
		public readonly IEnumerable<IntArray> TagLogicIter()
		{
			Buff.<TagLogicIter>d__284 <TagLogicIter>d__ = new Buff.<TagLogicIter>d__284(-2);
			<TagLogicIter>d__.<>3__<>4__this = this;
			return <TagLogicIter>d__;
		}

		// Token: 0x04004B50 RID: 19280
		private Table __p;
	}
}
