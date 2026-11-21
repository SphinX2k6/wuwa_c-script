using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E0 RID: 4576
	public struct SolarSchoolEventCheckOpt : IFlatbufferObject
	{
		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600E0B9 RID: 57529 RVA: 0x0033F6DC File Offset: 0x0033D8DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x0033F6E9 File Offset: 0x0033D8E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x0033F6F0 File Offset: 0x0033D8F0
		public static SolarSchoolEventCheckOpt GetRootAsSolarSchoolEventCheckOpt(ByteBuffer _bb)
		{
			return SolarSchoolEventCheckOpt.GetRootAsSolarSchoolEventCheckOpt(_bb, default(SolarSchoolEventCheckOpt));
		}

		// Token: 0x0600E0BC RID: 57532 RVA: 0x0033F70C File Offset: 0x0033D90C
		public static SolarSchoolEventCheckOpt GetRootAsSolarSchoolEventCheckOpt(ByteBuffer _bb, SolarSchoolEventCheckOpt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x0033F729 File Offset: 0x0033D929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x0033F738 File Offset: 0x0033D938
		public SolarSchoolEventCheckOpt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x0033F748 File Offset: 0x0033D948
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

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600E0C0 RID: 57536 RVA: 0x0033F784 File Offset: 0x0033D984
		public int GroupId
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

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x0033F7C0 File Offset: 0x0033D9C0
		public string DescKey
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

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0033F7F7 File Offset: 0x0033D9F7
		public Span<byte> GetDescKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x0033F806 File Offset: 0x0033DA06
		public byte[] GetDescKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x0033F820 File Offset: 0x0033DA20
		public int AttrRequire(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x0033F860 File Offset: 0x0033DA60
		public int AttrRequireLength
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

		// Token: 0x0600E0C6 RID: 57542 RVA: 0x0033F88C File Offset: 0x0033DA8C
		public Span<int> GetAttrRequireBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E0C7 RID: 57543 RVA: 0x0033F89C File Offset: 0x0033DA9C
		public int[] GetAttrRequireArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E0C8 RID: 57544 RVA: 0x0033F8B4 File Offset: 0x0033DAB4
		public int FocusAttr(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600E0C9 RID: 57545 RVA: 0x0033F8F4 File Offset: 0x0033DAF4
		public int FocusAttrLength
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

		// Token: 0x0600E0CA RID: 57546 RVA: 0x0033F920 File Offset: 0x0033DB20
		public Span<int> GetFocusAttrBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x0033F930 File Offset: 0x0033DB30
		public int[] GetFocusAttrArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x0033F948 File Offset: 0x0033DB48
		public int LowSuccessRate
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600E0CD RID: 57549 RVA: 0x0033F98C File Offset: 0x0033DB8C
		public string SuccessDescKey
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

		// Token: 0x0600E0CE RID: 57550 RVA: 0x0033F9C4 File Offset: 0x0033DBC4
		public Span<byte> GetSuccessDescKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E0CF RID: 57551 RVA: 0x0033F9D4 File Offset: 0x0033DBD4
		public byte[] GetSuccessDescKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x0033F9EC File Offset: 0x0033DBEC
		public string FailDescKey
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

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x0033FA24 File Offset: 0x0033DC24
		public Span<byte> GetFailDescKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E0D2 RID: 57554 RVA: 0x0033FA34 File Offset: 0x0033DC34
		public byte[] GetFailDescKeyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600E0D3 RID: 57555 RVA: 0x0033FA4C File Offset: 0x0033DC4C
		public int RewardSuccess
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

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x0033FA8C File Offset: 0x0033DC8C
		public int RewardFail
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x0033FACC File Offset: 0x0033DCCC
		public int SuccessActionList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600E0D6 RID: 57558 RVA: 0x0033FB0C File Offset: 0x0033DD0C
		public int SuccessActionListLength
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

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x0033FB38 File Offset: 0x0033DD38
		public Span<int> GetSuccessActionListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x0033FB48 File Offset: 0x0033DD48
		public int[] GetSuccessActionListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x0033FB60 File Offset: 0x0033DD60
		public int FailActionList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x0033FBA0 File Offset: 0x0033DDA0
		public int FailActionListLength
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

		// Token: 0x0600E0DB RID: 57563 RVA: 0x0033FBCC File Offset: 0x0033DDCC
		public Span<int> GetFailActionListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E0DC RID: 57564 RVA: 0x0033FBDC File Offset: 0x0033DDDC
		public int[] GetFailActionListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x0033FBF4 File Offset: 0x0033DDF4
		public int AddScore
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

		// Token: 0x0600E0DE RID: 57566 RVA: 0x0033FC31 File Offset: 0x0033DE31
		[NullableContext(1)]
		public int[] AttrRequire()
		{
			return this.GetAttrRequireArray();
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x0033FC39 File Offset: 0x0033DE39
		[NullableContext(1)]
		public IEnumerable<int> AttrRequireIter()
		{
			SolarSchoolEventCheckOpt.<AttrRequireIter>d__53 <AttrRequireIter>d__ = new SolarSchoolEventCheckOpt.<AttrRequireIter>d__53(-2);
			<AttrRequireIter>d__.<>3__<>4__this = this;
			return <AttrRequireIter>d__;
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x0033FC4E File Offset: 0x0033DE4E
		[NullableContext(1)]
		public int[] FailActionList()
		{
			return this.GetFailActionListArray();
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x0033FC56 File Offset: 0x0033DE56
		[NullableContext(1)]
		public IEnumerable<int> FailActionListIter()
		{
			SolarSchoolEventCheckOpt.<FailActionListIter>d__55 <FailActionListIter>d__ = new SolarSchoolEventCheckOpt.<FailActionListIter>d__55(-2);
			<FailActionListIter>d__.<>3__<>4__this = this;
			return <FailActionListIter>d__;
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x0033FC6B File Offset: 0x0033DE6B
		[NullableContext(1)]
		public int[] FocusAttr()
		{
			return this.GetFocusAttrArray();
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x0033FC73 File Offset: 0x0033DE73
		[NullableContext(1)]
		public IEnumerable<int> FocusAttrIter()
		{
			SolarSchoolEventCheckOpt.<FocusAttrIter>d__57 <FocusAttrIter>d__ = new SolarSchoolEventCheckOpt.<FocusAttrIter>d__57(-2);
			<FocusAttrIter>d__.<>3__<>4__this = this;
			return <FocusAttrIter>d__;
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x0033FC88 File Offset: 0x0033DE88
		[NullableContext(1)]
		public int[] SuccessActionList()
		{
			return this.GetSuccessActionListArray();
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x0033FC90 File Offset: 0x0033DE90
		[NullableContext(1)]
		public IEnumerable<int> SuccessActionListIter()
		{
			SolarSchoolEventCheckOpt.<SuccessActionListIter>d__59 <SuccessActionListIter>d__ = new SolarSchoolEventCheckOpt.<SuccessActionListIter>d__59(-2);
			<SuccessActionListIter>d__.<>3__<>4__this = this;
			return <SuccessActionListIter>d__;
		}

		// Token: 0x0400581D RID: 22557
		private Table __p;
	}
}
