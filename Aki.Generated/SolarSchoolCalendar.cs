using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DA RID: 4570
	public struct SolarSchoolCalendar : IFlatbufferObject
	{
		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600E022 RID: 57378 RVA: 0x0033E22D File Offset: 0x0033C42D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x0033E23A File Offset: 0x0033C43A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x0033E244 File Offset: 0x0033C444
		public static SolarSchoolCalendar GetRootAsSolarSchoolCalendar(ByteBuffer _bb)
		{
			return SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(_bb, default(SolarSchoolCalendar));
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x0033E260 File Offset: 0x0033C460
		public static SolarSchoolCalendar GetRootAsSolarSchoolCalendar(ByteBuffer _bb, SolarSchoolCalendar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x0033E27D File Offset: 0x0033C47D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x0033E28C File Offset: 0x0033C48C
		public SolarSchoolCalendar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600E028 RID: 57384 RVA: 0x0033E29C File Offset: 0x0033C49C
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

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600E029 RID: 57385 RVA: 0x0033E2D8 File Offset: 0x0033C4D8
		public int DayIndex
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

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600E02A RID: 57386 RVA: 0x0033E314 File Offset: 0x0033C514
		public int ActivityId
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

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600E02B RID: 57387 RVA: 0x0033E350 File Offset: 0x0033C550
		public int ConditionGroupId
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

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600E02C RID: 57388 RVA: 0x0033E390 File Offset: 0x0033C590
		public int InstanceConditionGroupId
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

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600E02D RID: 57389 RVA: 0x0033E3D0 File Offset: 0x0033C5D0
		public int InstanceId
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

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x0033E410 File Offset: 0x0033C610
		public bool HasDayAction
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0033E450 File Offset: 0x0033C650
		public bool HasDuskAction
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E030 RID: 57392 RVA: 0x0033E490 File Offset: 0x0033C690
		public int DawnActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600E031 RID: 57393 RVA: 0x0033E4D0 File Offset: 0x0033C6D0
		public int DawnActionsLength
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

		// Token: 0x0600E032 RID: 57394 RVA: 0x0033E4FC File Offset: 0x0033C6FC
		public Span<int> GetDawnActionsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x0033E50C File Offset: 0x0033C70C
		public int[] GetDawnActionsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E034 RID: 57396 RVA: 0x0033E524 File Offset: 0x0033C724
		public int DayActions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600E035 RID: 57397 RVA: 0x0033E564 File Offset: 0x0033C764
		public int DayActionsLength
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

		// Token: 0x0600E036 RID: 57398 RVA: 0x0033E590 File Offset: 0x0033C790
		public Span<int> GetDayActionsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E037 RID: 57399 RVA: 0x0033E5A0 File Offset: 0x0033C7A0
		public int[] GetDayActionsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E038 RID: 57400 RVA: 0x0033E5B8 File Offset: 0x0033C7B8
		public int NoonActions(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600E039 RID: 57401 RVA: 0x0033E5F8 File Offset: 0x0033C7F8
		public int NoonActionsLength
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

		// Token: 0x0600E03A RID: 57402 RVA: 0x0033E624 File Offset: 0x0033C824
		public Span<int> GetNoonActionsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600E03B RID: 57403 RVA: 0x0033E634 File Offset: 0x0033C834
		public int[] GetNoonActionsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600E03C RID: 57404 RVA: 0x0033E64C File Offset: 0x0033C84C
		public int DuskActions(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600E03D RID: 57405 RVA: 0x0033E68C File Offset: 0x0033C88C
		public int DuskActionsLength
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

		// Token: 0x0600E03E RID: 57406 RVA: 0x0033E6B8 File Offset: 0x0033C8B8
		public Span<int> GetDuskActionsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x0033E6C8 File Offset: 0x0033C8C8
		public int[] GetDuskActionsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x0033E6E0 File Offset: 0x0033C8E0
		public int NightActions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600E041 RID: 57409 RVA: 0x0033E720 File Offset: 0x0033C920
		public int NightActionsLength
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

		// Token: 0x0600E042 RID: 57410 RVA: 0x0033E74C File Offset: 0x0033C94C
		public Span<int> GetNightActionsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x0033E75C File Offset: 0x0033C95C
		public int[] GetNightActionsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600E044 RID: 57412 RVA: 0x0033E774 File Offset: 0x0033C974
		public string SkipDesc
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

		// Token: 0x0600E045 RID: 57413 RVA: 0x0033E7AC File Offset: 0x0033C9AC
		public Span<byte> GetSkipDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x0033E7BC File Offset: 0x0033C9BC
		public byte[] GetSkipDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E047 RID: 57415 RVA: 0x0033E7D4 File Offset: 0x0033C9D4
		[NullableContext(1)]
		public int[] DawnActions()
		{
			return this.GetDawnActionsArray();
		}

		// Token: 0x0600E048 RID: 57416 RVA: 0x0033E7DC File Offset: 0x0033C9DC
		[NullableContext(1)]
		public IEnumerable<int> DawnActionsIter()
		{
			SolarSchoolCalendar.<DawnActionsIter>d__54 <DawnActionsIter>d__ = new SolarSchoolCalendar.<DawnActionsIter>d__54(-2);
			<DawnActionsIter>d__.<>3__<>4__this = this;
			return <DawnActionsIter>d__;
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x0033E7F1 File Offset: 0x0033C9F1
		[NullableContext(1)]
		public int[] DayActions()
		{
			return this.GetDayActionsArray();
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x0033E7F9 File Offset: 0x0033C9F9
		[NullableContext(1)]
		public IEnumerable<int> DayActionsIter()
		{
			SolarSchoolCalendar.<DayActionsIter>d__56 <DayActionsIter>d__ = new SolarSchoolCalendar.<DayActionsIter>d__56(-2);
			<DayActionsIter>d__.<>3__<>4__this = this;
			return <DayActionsIter>d__;
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x0033E80E File Offset: 0x0033CA0E
		[NullableContext(1)]
		public int[] DuskActions()
		{
			return this.GetDuskActionsArray();
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x0033E816 File Offset: 0x0033CA16
		[NullableContext(1)]
		public IEnumerable<int> DuskActionsIter()
		{
			SolarSchoolCalendar.<DuskActionsIter>d__58 <DuskActionsIter>d__ = new SolarSchoolCalendar.<DuskActionsIter>d__58(-2);
			<DuskActionsIter>d__.<>3__<>4__this = this;
			return <DuskActionsIter>d__;
		}

		// Token: 0x0600E04D RID: 57421 RVA: 0x0033E82B File Offset: 0x0033CA2B
		[NullableContext(1)]
		public int[] NightActions()
		{
			return this.GetNightActionsArray();
		}

		// Token: 0x0600E04E RID: 57422 RVA: 0x0033E833 File Offset: 0x0033CA33
		[NullableContext(1)]
		public IEnumerable<int> NightActionsIter()
		{
			SolarSchoolCalendar.<NightActionsIter>d__60 <NightActionsIter>d__ = new SolarSchoolCalendar.<NightActionsIter>d__60(-2);
			<NightActionsIter>d__.<>3__<>4__this = this;
			return <NightActionsIter>d__;
		}

		// Token: 0x0600E04F RID: 57423 RVA: 0x0033E848 File Offset: 0x0033CA48
		[NullableContext(1)]
		public int[] NoonActions()
		{
			return this.GetNoonActionsArray();
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x0033E850 File Offset: 0x0033CA50
		[NullableContext(1)]
		public IEnumerable<int> NoonActionsIter()
		{
			SolarSchoolCalendar.<NoonActionsIter>d__62 <NoonActionsIter>d__ = new SolarSchoolCalendar.<NoonActionsIter>d__62(-2);
			<NoonActionsIter>d__.<>3__<>4__this = this;
			return <NoonActionsIter>d__;
		}

		// Token: 0x04005817 RID: 22551
		private Table __p;
	}
}
