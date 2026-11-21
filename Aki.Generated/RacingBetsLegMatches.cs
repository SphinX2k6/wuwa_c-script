using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001072 RID: 4210
	public struct RacingBetsLegMatches : IFlatbufferObject
	{
		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0600BE68 RID: 48744 RVA: 0x002F209B File Offset: 0x002F029B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x002F20A8 File Offset: 0x002F02A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x002F20B0 File Offset: 0x002F02B0
		public static RacingBetsLegMatches GetRootAsRacingBetsLegMatches(ByteBuffer _bb)
		{
			return RacingBetsLegMatches.GetRootAsRacingBetsLegMatches(_bb, default(RacingBetsLegMatches));
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x002F20CC File Offset: 0x002F02CC
		public static RacingBetsLegMatches GetRootAsRacingBetsLegMatches(ByteBuffer _bb, RacingBetsLegMatches obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x002F20E9 File Offset: 0x002F02E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x002F20F8 File Offset: 0x002F02F8
		public RacingBetsLegMatches __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0600BE6E RID: 48750 RVA: 0x002F2108 File Offset: 0x002F0308
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

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600BE6F RID: 48751 RVA: 0x002F2144 File Offset: 0x002F0344
		public int MatchId
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

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600BE70 RID: 48752 RVA: 0x002F2180 File Offset: 0x002F0380
		public string Name
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

		// Token: 0x0600BE71 RID: 48753 RVA: 0x002F21B7 File Offset: 0x002F03B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x002F21C6 File Offset: 0x002F03C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x002F21E0 File Offset: 0x002F03E0
		public string SimpleName
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

		// Token: 0x0600BE74 RID: 48756 RVA: 0x002F2218 File Offset: 0x002F0418
		public Span<byte> GetSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x002F2228 File Offset: 0x002F0428
		public byte[] GetSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600BE76 RID: 48758 RVA: 0x002F2240 File Offset: 0x002F0440
		public string ShortName
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

		// Token: 0x0600BE77 RID: 48759 RVA: 0x002F2278 File Offset: 0x002F0478
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x002F2288 File Offset: 0x002F0488
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x002F22A0 File Offset: 0x002F04A0
		public int Type
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

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0600BE7A RID: 48762 RVA: 0x002F22E0 File Offset: 0x002F04E0
		public int EndPoint
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

		// Token: 0x0600BE7B RID: 48763 RVA: 0x002F2320 File Offset: 0x002F0520
		public int DiceTypeList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0600BE7C RID: 48764 RVA: 0x002F2360 File Offset: 0x002F0560
		public int DiceTypeListLength
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

		// Token: 0x0600BE7D RID: 48765 RVA: 0x002F238C File Offset: 0x002F058C
		public Span<int> GetDiceTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x002F239C File Offset: 0x002F059C
		public int[] GetDiceTypeListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x002F23B4 File Offset: 0x002F05B4
		public string OrganList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0600BE80 RID: 48768 RVA: 0x002F23F0 File Offset: 0x002F05F0
		public int OrganListLength
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

		// Token: 0x0600BE81 RID: 48769 RVA: 0x002F241C File Offset: 0x002F061C
		public int ShowOrganList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x002F245C File Offset: 0x002F065C
		public int ShowOrganListLength
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

		// Token: 0x0600BE83 RID: 48771 RVA: 0x002F2488 File Offset: 0x002F0688
		public Span<int> GetShowOrganListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x002F2498 File Offset: 0x002F0698
		public int[] GetShowOrganListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600BE85 RID: 48773 RVA: 0x002F24B0 File Offset: 0x002F06B0
		public string BtnBgPath
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

		// Token: 0x0600BE86 RID: 48774 RVA: 0x002F24E8 File Offset: 0x002F06E8
		public Span<byte> GetBtnBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x002F24F8 File Offset: 0x002F06F8
		public byte[] GetBtnBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x002F2510 File Offset: 0x002F0710
		[NullableContext(1)]
		public int[] DiceTypeList()
		{
			return this.GetDiceTypeListArray();
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x002F2518 File Offset: 0x002F0718
		[NullableContext(1)]
		public IEnumerable<int> DiceTypeListIter()
		{
			RacingBetsLegMatches.<DiceTypeListIter>d__46 <DiceTypeListIter>d__ = new RacingBetsLegMatches.<DiceTypeListIter>d__46(-2);
			<DiceTypeListIter>d__.<>3__<>4__this = this;
			return <DiceTypeListIter>d__;
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x002F252D File Offset: 0x002F072D
		[NullableContext(1)]
		public string[] OrganList()
		{
			return this.OrganListIter().ToArray<string>();
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x002F253A File Offset: 0x002F073A
		[NullableContext(1)]
		public IEnumerable<string> OrganListIter()
		{
			RacingBetsLegMatches.<OrganListIter>d__48 <OrganListIter>d__ = new RacingBetsLegMatches.<OrganListIter>d__48(-2);
			<OrganListIter>d__.<>3__<>4__this = this;
			return <OrganListIter>d__;
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x002F254F File Offset: 0x002F074F
		[NullableContext(1)]
		public int[] ShowOrganList()
		{
			return this.GetShowOrganListArray();
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x002F2557 File Offset: 0x002F0757
		[NullableContext(1)]
		public IEnumerable<int> ShowOrganListIter()
		{
			RacingBetsLegMatches.<ShowOrganListIter>d__50 <ShowOrganListIter>d__ = new RacingBetsLegMatches.<ShowOrganListIter>d__50(-2);
			<ShowOrganListIter>d__.<>3__<>4__this = this;
			return <ShowOrganListIter>d__;
		}

		// Token: 0x04005641 RID: 22081
		private Table __p;
	}
}
