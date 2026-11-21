using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D0 RID: 4304
	public struct RogueParam : IFlatbufferObject
	{
		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600C615 RID: 50709 RVA: 0x00302C59 File Offset: 0x00300E59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x00302C66 File Offset: 0x00300E66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x00302C70 File Offset: 0x00300E70
		public static RogueParam GetRootAsRogueParam(ByteBuffer _bb)
		{
			return RogueParam.GetRootAsRogueParam(_bb, default(RogueParam));
		}

		// Token: 0x0600C618 RID: 50712 RVA: 0x00302C8C File Offset: 0x00300E8C
		public static RogueParam GetRootAsRogueParam(ByteBuffer _bb, RogueParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x00302CA9 File Offset: 0x00300EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C61A RID: 50714 RVA: 0x00302CB8 File Offset: 0x00300EB8
		public RogueParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600C61B RID: 50715 RVA: 0x00302CC8 File Offset: 0x00300EC8
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

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600C61C RID: 50716 RVA: 0x00302D04 File Offset: 0x00300F04
		public string RoguelikeSettleBgS
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

		// Token: 0x0600C61D RID: 50717 RVA: 0x00302D3B File Offset: 0x00300F3B
		public Span<byte> GetRoguelikeSettleBgSBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C61E RID: 50718 RVA: 0x00302D4A File Offset: 0x00300F4A
		public byte[] GetRoguelikeSettleBgSArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600C61F RID: 50719 RVA: 0x00302D64 File Offset: 0x00300F64
		public string RoguelikeSettleBgNormal
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

		// Token: 0x0600C620 RID: 50720 RVA: 0x00302D9B File Offset: 0x00300F9B
		public Span<byte> GetRoguelikeSettleBgNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x00302DAA File Offset: 0x00300FAA
		public byte[] GetRoguelikeSettleBgNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600C622 RID: 50722 RVA: 0x00302DC4 File Offset: 0x00300FC4
		public string RoguelikeRoomFloatTipsNoHeadIcon
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

		// Token: 0x0600C623 RID: 50723 RVA: 0x00302DFC File Offset: 0x00300FFC
		public Span<byte> GetRoguelikeRoomFloatTipsNoHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x00302E0C File Offset: 0x0030100C
		public byte[] GetRoguelikeRoomFloatTipsNoHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600C625 RID: 50725 RVA: 0x00302E24 File Offset: 0x00301024
		public string RoguelikeRoomFloatTipsSpecialIcon
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

		// Token: 0x0600C626 RID: 50726 RVA: 0x00302E5C File Offset: 0x0030105C
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C627 RID: 50727 RVA: 0x00302E6C File Offset: 0x0030106C
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600C628 RID: 50728 RVA: 0x00302E84 File Offset: 0x00301084
		public int RoguelikeSettleS
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

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600C629 RID: 50729 RVA: 0x00302EC4 File Offset: 0x003010C4
		public int RoguelikeSettleA
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

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00302F04 File Offset: 0x00301104
		public int RoguelikeSettleB
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

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600C62B RID: 50731 RVA: 0x00302F44 File Offset: 0x00301144
		public int RoguelikeSettleC
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

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600C62C RID: 50732 RVA: 0x00302F84 File Offset: 0x00301184
		public int PointItem
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

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600C62D RID: 50733 RVA: 0x00302FC4 File Offset: 0x003011C4
		public int PointItemMaxCount
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

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600C62E RID: 50734 RVA: 0x00303004 File Offset: 0x00301204
		public int TokenItem
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

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600C62F RID: 50735 RVA: 0x00303044 File Offset: 0x00301244
		public int WeekTokenMaxCount
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

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600C630 RID: 50736 RVA: 0x00303084 File Offset: 0x00301284
		public int SkillPoint
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600C631 RID: 50737 RVA: 0x003030C4 File Offset: 0x003012C4
		public int SkillPointMaxCount
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

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600C632 RID: 50738 RVA: 0x00303104 File Offset: 0x00301304
		public int InsideCurrency
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x00303144 File Offset: 0x00301344
		public int GuideInstArray(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600C634 RID: 50740 RVA: 0x00303184 File Offset: 0x00301384
		public int GuideInstArrayLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x003031B0 File Offset: 0x003013B0
		public Span<int> GetGuideInstArrayBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600C636 RID: 50742 RVA: 0x003031C0 File Offset: 0x003013C0
		public int[] GetGuideInstArrayArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600C637 RID: 50743 RVA: 0x003031D8 File Offset: 0x003013D8
		public int GuideInstRoleIdArray(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600C638 RID: 50744 RVA: 0x00303218 File Offset: 0x00301418
		public int GuideInstRoleIdArrayLength
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

		// Token: 0x0600C639 RID: 50745 RVA: 0x00303244 File Offset: 0x00301444
		public Span<int> GetGuideInstRoleIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600C63A RID: 50746 RVA: 0x00303254 File Offset: 0x00301454
		public int[] GetGuideInstRoleIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x0030326C File Offset: 0x0030146C
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x003032AC File Offset: 0x003014AC
		public int DungeonListLength
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

		// Token: 0x0600C63D RID: 50749 RVA: 0x003032D8 File Offset: 0x003014D8
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600C63E RID: 50750 RVA: 0x003032E8 File Offset: 0x003014E8
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x00303300 File Offset: 0x00301500
		public DicIntInt? ValidRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600C640 RID: 50752 RVA: 0x00303364 File Offset: 0x00301564
		public int ValidRoleOpenTimeMapLength
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

		// Token: 0x0600C641 RID: 50753 RVA: 0x00303390 File Offset: 0x00301590
		public DicIntInt? DungeonRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600C642 RID: 50754 RVA: 0x003033F4 File Offset: 0x003015F4
		public int DungeonRoleOpenTimeMapLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600C643 RID: 50755 RVA: 0x00303420 File Offset: 0x00301620
		public int BlackFlowerDropId
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

		// Token: 0x0600C644 RID: 50756 RVA: 0x00303460 File Offset: 0x00301660
		public int BlackFlowerInstList(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600C645 RID: 50757 RVA: 0x003034A0 File Offset: 0x003016A0
		public int BlackFlowerInstListLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x003034CC File Offset: 0x003016CC
		public Span<int> GetBlackFlowerInstListBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x003034DC File Offset: 0x003016DC
		public int[] GetBlackFlowerInstListArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600C648 RID: 50760 RVA: 0x003034F4 File Offset: 0x003016F4
		public int ElementList(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600C649 RID: 50761 RVA: 0x00303534 File Offset: 0x00301734
		public int ElementListLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x00303560 File Offset: 0x00301760
		public Span<int> GetElementListBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x00303570 File Offset: 0x00301770
		public int[] GetElementListArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x00303588 File Offset: 0x00301788
		[NullableContext(1)]
		public int[] BlackFlowerInstList()
		{
			return this.GetBlackFlowerInstListArray();
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x00303590 File Offset: 0x00301790
		[NullableContext(1)]
		public IEnumerable<int> BlackFlowerInstListIter()
		{
			RogueParam.<BlackFlowerInstListIter>d__82 <BlackFlowerInstListIter>d__ = new RogueParam.<BlackFlowerInstListIter>d__82(-2);
			<BlackFlowerInstListIter>d__.<>3__<>4__this = this;
			return <BlackFlowerInstListIter>d__;
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x003035A5 File Offset: 0x003017A5
		[NullableContext(1)]
		public int[] DungeonList()
		{
			return this.GetDungeonListArray();
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x003035AD File Offset: 0x003017AD
		[NullableContext(1)]
		public IEnumerable<int> DungeonListIter()
		{
			RogueParam.<DungeonListIter>d__84 <DungeonListIter>d__ = new RogueParam.<DungeonListIter>d__84(-2);
			<DungeonListIter>d__.<>3__<>4__this = this;
			return <DungeonListIter>d__;
		}

		// Token: 0x0600C650 RID: 50768 RVA: 0x003035C4 File Offset: 0x003017C4
		[NullableContext(1)]
		public Dictionary<int, int> DungeonRoleOpenTimeMap()
		{
			return this.DungeonRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x0030361A File Offset: 0x0030181A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DungeonRoleOpenTimeMapIter()
		{
			RogueParam.<DungeonRoleOpenTimeMapIter>d__86 <DungeonRoleOpenTimeMapIter>d__ = new RogueParam.<DungeonRoleOpenTimeMapIter>d__86(-2);
			<DungeonRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <DungeonRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x0030362F File Offset: 0x0030182F
		[NullableContext(1)]
		public int[] ElementList()
		{
			return this.GetElementListArray();
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x00303637 File Offset: 0x00301837
		[NullableContext(1)]
		public IEnumerable<int> ElementListIter()
		{
			RogueParam.<ElementListIter>d__88 <ElementListIter>d__ = new RogueParam.<ElementListIter>d__88(-2);
			<ElementListIter>d__.<>3__<>4__this = this;
			return <ElementListIter>d__;
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x0030364C File Offset: 0x0030184C
		[NullableContext(1)]
		public int[] GuideInstArray()
		{
			return this.GetGuideInstArrayArray();
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00303654 File Offset: 0x00301854
		[NullableContext(1)]
		public IEnumerable<int> GuideInstArrayIter()
		{
			RogueParam.<GuideInstArrayIter>d__90 <GuideInstArrayIter>d__ = new RogueParam.<GuideInstArrayIter>d__90(-2);
			<GuideInstArrayIter>d__.<>3__<>4__this = this;
			return <GuideInstArrayIter>d__;
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x00303669 File Offset: 0x00301869
		[NullableContext(1)]
		public int[] GuideInstRoleIdArray()
		{
			return this.GetGuideInstRoleIdArrayArray();
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x00303671 File Offset: 0x00301871
		[NullableContext(1)]
		public IEnumerable<int> GuideInstRoleIdArrayIter()
		{
			RogueParam.<GuideInstRoleIdArrayIter>d__92 <GuideInstRoleIdArrayIter>d__ = new RogueParam.<GuideInstRoleIdArrayIter>d__92(-2);
			<GuideInstRoleIdArrayIter>d__.<>3__<>4__this = this;
			return <GuideInstRoleIdArrayIter>d__;
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x00303688 File Offset: 0x00301888
		[NullableContext(1)]
		public Dictionary<int, int> ValidRoleOpenTimeMap()
		{
			return this.ValidRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x003036DE File Offset: 0x003018DE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ValidRoleOpenTimeMapIter()
		{
			RogueParam.<ValidRoleOpenTimeMapIter>d__94 <ValidRoleOpenTimeMapIter>d__ = new RogueParam.<ValidRoleOpenTimeMapIter>d__94(-2);
			<ValidRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <ValidRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x003036F4 File Offset: 0x003018F4
		public int? GetDungeonRoleOpenTimeMap(int key)
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.DungeonRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x00303728 File Offset: 0x00301928
		public int? GetValidRoleOpenTimeMap(int key)
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.ValidRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x0030375C File Offset: 0x0030195C
		private void EnsureDungeonRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.DungeonRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.DungeonRoleOpenTimeMapCache = this.DungeonRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C65D RID: 50781 RVA: 0x003037C4 File Offset: 0x003019C4
		private void EnsureValidRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.ValidRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.ValidRoleOpenTimeMapCache = this.ValidRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x0030382A File Offset: 0x00301A2A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDungeonRoleOpenTimeMapFrozenDict()
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			return this.DungeonRoleOpenTimeMapCache;
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x00303838 File Offset: 0x00301A38
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetValidRoleOpenTimeMapFrozenDict()
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			return this.ValidRoleOpenTimeMapCache;
		}

		// Token: 0x040056AF RID: 22191
		private Table __p;

		// Token: 0x040056B0 RID: 22192
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonRoleOpenTimeMapCache;

		// Token: 0x040056B1 RID: 22193
		[Nullable(2)]
		private FrozenDictionary<int, int> ValidRoleOpenTimeMapCache;
	}
}
