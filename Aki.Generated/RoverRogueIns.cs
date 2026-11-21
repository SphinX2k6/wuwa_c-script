using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001178 RID: 4472
	public struct RoverRogueIns : IFlatbufferObject
	{
		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600D5B6 RID: 54710 RVA: 0x00325AAD File Offset: 0x00323CAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x00325ABA File Offset: 0x00323CBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x00325AC4 File Offset: 0x00323CC4
		public static RoverRogueIns GetRootAsRoverRogueIns(ByteBuffer _bb)
		{
			return RoverRogueIns.GetRootAsRoverRogueIns(_bb, default(RoverRogueIns));
		}

		// Token: 0x0600D5B9 RID: 54713 RVA: 0x00325AE0 File Offset: 0x00323CE0
		public static RoverRogueIns GetRootAsRoverRogueIns(ByteBuffer _bb, RoverRogueIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D5BA RID: 54714 RVA: 0x00325AFD File Offset: 0x00323CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x00325B0C File Offset: 0x00323D0C
		public RoverRogueIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x00325B1C File Offset: 0x00323D1C
		public int InstId
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

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600D5BD RID: 54717 RVA: 0x00325B58 File Offset: 0x00323D58
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

		// Token: 0x0600D5BE RID: 54718 RVA: 0x00325B94 File Offset: 0x00323D94
		public int RoadTypeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600D5BF RID: 54719 RVA: 0x00325BD4 File Offset: 0x00323DD4
		public int RoadTypeListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x00325BFF File Offset: 0x00323DFF
		public Span<int> GetRoadTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x00325C0E File Offset: 0x00323E0E
		public int[] GetRoadTypeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x00325C28 File Offset: 0x00323E28
		public int RoverList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600D5C3 RID: 54723 RVA: 0x00325C68 File Offset: 0x00323E68
		public int RoverListLength
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

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x00325C94 File Offset: 0x00323E94
		public Span<int> GetRoverListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x00325CA4 File Offset: 0x00323EA4
		public int[] GetRoverListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600D5C6 RID: 54726 RVA: 0x00325CBC File Offset: 0x00323EBC
		public int MaxLootNum
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600D5C7 RID: 54727 RVA: 0x00325CFC File Offset: 0x00323EFC
		public int BlessGroupNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x00325D3C File Offset: 0x00323F3C
		public int BlessGroupTargetBlessRoleId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x00325D7C File Offset: 0x00323F7C
		public int BlessGroupTargetBlessRoleIdLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x00325DA8 File Offset: 0x00323FA8
		public Span<int> GetBlessGroupTargetBlessRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D5CB RID: 54731 RVA: 0x00325DB8 File Offset: 0x00323FB8
		public int[] GetBlessGroupTargetBlessRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x00325DD0 File Offset: 0x00323FD0
		public string Name
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

		// Token: 0x0600D5CD RID: 54733 RVA: 0x00325E08 File Offset: 0x00324008
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x00325E18 File Offset: 0x00324018
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600D5CF RID: 54735 RVA: 0x00325E30 File Offset: 0x00324030
		public int Difficulty
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

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x00325E70 File Offset: 0x00324070
		public int SortId
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

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x00325EB0 File Offset: 0x003240B0
		public string IconPath
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

		// Token: 0x0600D5D2 RID: 54738 RVA: 0x00325EE8 File Offset: 0x003240E8
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x00325EF8 File Offset: 0x003240F8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x00325F10 File Offset: 0x00324110
		public string LevelName
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

		// Token: 0x0600D5D5 RID: 54741 RVA: 0x00325F48 File Offset: 0x00324148
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D5D6 RID: 54742 RVA: 0x00325F58 File Offset: 0x00324158
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600D5D7 RID: 54743 RVA: 0x00325F70 File Offset: 0x00324170
		public string LevelDesc
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

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x00325FA8 File Offset: 0x003241A8
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D5D9 RID: 54745 RVA: 0x00325FB8 File Offset: 0x003241B8
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x00325FD0 File Offset: 0x003241D0
		public string LevelRoomNumDesc
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

		// Token: 0x0600D5DB RID: 54747 RVA: 0x00326008 File Offset: 0x00324208
		public Span<byte> GetLevelRoomNumDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x00326018 File Offset: 0x00324218
		public byte[] GetLevelRoomNumDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x00326030 File Offset: 0x00324230
		public int LevelRoomNumParam(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x00326070 File Offset: 0x00324270
		public int LevelRoomNumParamLength
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

		// Token: 0x0600D5DF RID: 54751 RVA: 0x0032609C File Offset: 0x0032429C
		public Span<int> GetLevelRoomNumParamBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x003260AC File Offset: 0x003242AC
		public int[] GetLevelRoomNumParamArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600D5E1 RID: 54753 RVA: 0x003260C4 File Offset: 0x003242C4
		public string LevelMonsterRateDesc
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

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x003260FC File Offset: 0x003242FC
		public Span<byte> GetLevelMonsterRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x0032610C File Offset: 0x0032430C
		public byte[] GetLevelMonsterRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x00326124 File Offset: 0x00324324
		public int LevelMonsterRateParam(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x00326164 File Offset: 0x00324364
		public int LevelMonsterRateParamLength
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

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x00326190 File Offset: 0x00324390
		public Span<int> GetLevelMonsterRateParamBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x003261A0 File Offset: 0x003243A0
		public int[] GetLevelMonsterRateParamArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600D5E8 RID: 54760 RVA: 0x003261B8 File Offset: 0x003243B8
		public string LevelRewardRateDesc
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x003261F0 File Offset: 0x003243F0
		public Span<byte> GetLevelRewardRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x00326200 File Offset: 0x00324400
		public byte[] GetLevelRewardRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x00326218 File Offset: 0x00324418
		public int LevelRewardRateParam(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600D5EC RID: 54764 RVA: 0x00326258 File Offset: 0x00324458
		public int LevelRewardRateParamLength
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

		// Token: 0x0600D5ED RID: 54765 RVA: 0x00326284 File Offset: 0x00324484
		public Span<int> GetLevelRewardRateParamBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x00326294 File Offset: 0x00324494
		public int[] GetLevelRewardRateParamArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x003262AC File Offset: 0x003244AC
		public string LevelDetailDesc(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600D5F0 RID: 54768 RVA: 0x003262E8 File Offset: 0x003244E8
		public int LevelDetailDescLength
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

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x00326314 File Offset: 0x00324514
		public IntArray? LevelDetailParam(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x00326378 File Offset: 0x00324578
		public int LevelDetailParamLength
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

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x003263A4 File Offset: 0x003245A4
		[NullableContext(1)]
		public int[] BlessGroupTargetBlessRoleId()
		{
			return this.GetBlessGroupTargetBlessRoleIdArray();
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x003263AC File Offset: 0x003245AC
		[NullableContext(1)]
		public IEnumerable<int> BlessGroupTargetBlessRoleIdIter()
		{
			RoverRogueIns.<BlessGroupTargetBlessRoleIdIter>d__85 <BlessGroupTargetBlessRoleIdIter>d__ = new RoverRogueIns.<BlessGroupTargetBlessRoleIdIter>d__85(-2);
			<BlessGroupTargetBlessRoleIdIter>d__.<>3__<>4__this = this;
			return <BlessGroupTargetBlessRoleIdIter>d__;
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x003263C1 File Offset: 0x003245C1
		[NullableContext(1)]
		public string[] LevelDetailDesc()
		{
			return this.LevelDetailDescIter().ToArray<string>();
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x003263CE File Offset: 0x003245CE
		[NullableContext(1)]
		public IEnumerable<string> LevelDetailDescIter()
		{
			RoverRogueIns.<LevelDetailDescIter>d__87 <LevelDetailDescIter>d__ = new RoverRogueIns.<LevelDetailDescIter>d__87(-2);
			<LevelDetailDescIter>d__.<>3__<>4__this = this;
			return <LevelDetailDescIter>d__;
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x003263E3 File Offset: 0x003245E3
		[NullableContext(1)]
		public IntArray[] LevelDetailParam()
		{
			return this.LevelDetailParamIter().ToArray<IntArray>();
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x003263F0 File Offset: 0x003245F0
		[NullableContext(1)]
		public IEnumerable<IntArray> LevelDetailParamIter()
		{
			RoverRogueIns.<LevelDetailParamIter>d__89 <LevelDetailParamIter>d__ = new RoverRogueIns.<LevelDetailParamIter>d__89(-2);
			<LevelDetailParamIter>d__.<>3__<>4__this = this;
			return <LevelDetailParamIter>d__;
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x00326405 File Offset: 0x00324605
		[NullableContext(1)]
		public int[] LevelMonsterRateParam()
		{
			return this.GetLevelMonsterRateParamArray();
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x0032640D File Offset: 0x0032460D
		[NullableContext(1)]
		public IEnumerable<int> LevelMonsterRateParamIter()
		{
			RoverRogueIns.<LevelMonsterRateParamIter>d__91 <LevelMonsterRateParamIter>d__ = new RoverRogueIns.<LevelMonsterRateParamIter>d__91(-2);
			<LevelMonsterRateParamIter>d__.<>3__<>4__this = this;
			return <LevelMonsterRateParamIter>d__;
		}

		// Token: 0x0600D5FB RID: 54779 RVA: 0x00326422 File Offset: 0x00324622
		[NullableContext(1)]
		public int[] LevelRewardRateParam()
		{
			return this.GetLevelRewardRateParamArray();
		}

		// Token: 0x0600D5FC RID: 54780 RVA: 0x0032642A File Offset: 0x0032462A
		[NullableContext(1)]
		public IEnumerable<int> LevelRewardRateParamIter()
		{
			RoverRogueIns.<LevelRewardRateParamIter>d__93 <LevelRewardRateParamIter>d__ = new RoverRogueIns.<LevelRewardRateParamIter>d__93(-2);
			<LevelRewardRateParamIter>d__.<>3__<>4__this = this;
			return <LevelRewardRateParamIter>d__;
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x0032643F File Offset: 0x0032463F
		[NullableContext(1)]
		public int[] LevelRoomNumParam()
		{
			return this.GetLevelRoomNumParamArray();
		}

		// Token: 0x0600D5FE RID: 54782 RVA: 0x00326447 File Offset: 0x00324647
		[NullableContext(1)]
		public IEnumerable<int> LevelRoomNumParamIter()
		{
			RoverRogueIns.<LevelRoomNumParamIter>d__95 <LevelRoomNumParamIter>d__ = new RoverRogueIns.<LevelRoomNumParamIter>d__95(-2);
			<LevelRoomNumParamIter>d__.<>3__<>4__this = this;
			return <LevelRoomNumParamIter>d__;
		}

		// Token: 0x0600D5FF RID: 54783 RVA: 0x0032645C File Offset: 0x0032465C
		[NullableContext(1)]
		public int[] RoadTypeList()
		{
			return this.GetRoadTypeListArray();
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x00326464 File Offset: 0x00324664
		[NullableContext(1)]
		public IEnumerable<int> RoadTypeListIter()
		{
			RoverRogueIns.<RoadTypeListIter>d__97 <RoadTypeListIter>d__ = new RoverRogueIns.<RoadTypeListIter>d__97(-2);
			<RoadTypeListIter>d__.<>3__<>4__this = this;
			return <RoadTypeListIter>d__;
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x00326479 File Offset: 0x00324679
		[NullableContext(1)]
		public int[] RoverList()
		{
			return this.GetRoverListArray();
		}

		// Token: 0x0600D602 RID: 54786 RVA: 0x00326481 File Offset: 0x00324681
		[NullableContext(1)]
		public IEnumerable<int> RoverListIter()
		{
			RoverRogueIns.<RoverListIter>d__99 <RoverListIter>d__ = new RoverRogueIns.<RoverListIter>d__99(-2);
			<RoverListIter>d__.<>3__<>4__this = this;
			return <RoverListIter>d__;
		}

		// Token: 0x04005786 RID: 22406
		private Table __p;
	}
}
