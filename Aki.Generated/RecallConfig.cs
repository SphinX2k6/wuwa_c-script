using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001085 RID: 4229
	public struct RecallConfig : IFlatbufferObject
	{
		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600BFC0 RID: 49088 RVA: 0x002F4FB9 File Offset: 0x002F31B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x002F4FC6 File Offset: 0x002F31C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x002F4FD0 File Offset: 0x002F31D0
		public static RecallConfig GetRootAsRecallConfig(ByteBuffer _bb)
		{
			return RecallConfig.GetRootAsRecallConfig(_bb, default(RecallConfig));
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x002F4FEC File Offset: 0x002F31EC
		public static RecallConfig GetRootAsRecallConfig(ByteBuffer _bb, RecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x002F5009 File Offset: 0x002F3209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x002F5018 File Offset: 0x002F3218
		public RecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600BFC6 RID: 49094 RVA: 0x002F5028 File Offset: 0x002F3228
		public int RecallId
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

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x002F5064 File Offset: 0x002F3264
		public int NeedFinishQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600BFC8 RID: 49096 RVA: 0x002F50A4 File Offset: 0x002F32A4
		public int NeedFinishQuestIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BFC9 RID: 49097 RVA: 0x002F50CF File Offset: 0x002F32CF
		public Span<int> GetNeedFinishQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x002F50DE File Offset: 0x002F32DE
		public int[] GetNeedFinishQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFCB RID: 49099 RVA: 0x002F50F8 File Offset: 0x002F32F8
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600BFCC RID: 49100 RVA: 0x002F5138 File Offset: 0x002F3338
		public int QuestIdsLength
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

		// Token: 0x0600BFCD RID: 49101 RVA: 0x002F5163 File Offset: 0x002F3363
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x002F5172 File Offset: 0x002F3372
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFCF RID: 49103 RVA: 0x002F518C File Offset: 0x002F338C
		public DicIntInt? RecallQuests(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x0600BFD0 RID: 49104 RVA: 0x002F51F0 File Offset: 0x002F33F0
		public int RecallQuestsLength
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

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x002F521C File Offset: 0x002F341C
		public int ExitGuideQuestId
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

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600BFD2 RID: 49106 RVA: 0x002F525C File Offset: 0x002F345C
		public int DungeonEntranceId
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

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x002F529C File Offset: 0x002F349C
		public int DungeonIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x002F52DC File Offset: 0x002F34DC
		public int DungeonIdsLength
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

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x002F5308 File Offset: 0x002F3508
		public Span<int> GetDungeonIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x002F5318 File Offset: 0x002F3518
		public int[] GetDungeonIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x002F5330 File Offset: 0x002F3530
		public DicIntInt? DungeonIdMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600BFD8 RID: 49112 RVA: 0x002F5394 File Offset: 0x002F3594
		public int DungeonIdMapLength
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

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x002F53C0 File Offset: 0x002F35C0
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600BFDA RID: 49114 RVA: 0x002F5400 File Offset: 0x002F3600
		public int LevelPlayIdsLength
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

		// Token: 0x0600BFDB RID: 49115 RVA: 0x002F542C File Offset: 0x002F362C
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x002F543C File Offset: 0x002F363C
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x002F5454 File Offset: 0x002F3654
		public DicIntInt? RecallLevels(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x002F54B8 File Offset: 0x002F36B8
		public int RecallLevelsLength
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

		// Token: 0x0600BFDF RID: 49119 RVA: 0x002F54E4 File Offset: 0x002F36E4
		public string EntryTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x002F5520 File Offset: 0x002F3720
		public int EntryTagsLength
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

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x002F554C File Offset: 0x002F374C
		public int FunctionIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600BFE2 RID: 49122 RVA: 0x002F558C File Offset: 0x002F378C
		public int FunctionIdsLength
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

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x002F55B8 File Offset: 0x002F37B8
		public Span<int> GetFunctionIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x002F55C8 File Offset: 0x002F37C8
		public int[] GetFunctionIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x002F55E0 File Offset: 0x002F37E0
		public string QuestName
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

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x002F5618 File Offset: 0x002F3818
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x002F5628 File Offset: 0x002F3828
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600BFE8 RID: 49128 RVA: 0x002F5640 File Offset: 0x002F3840
		public string ChapterName
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

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x002F5678 File Offset: 0x002F3878
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x002F5688 File Offset: 0x002F3888
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600BFEB RID: 49131 RVA: 0x002F56A0 File Offset: 0x002F38A0
		public string SmallChapterName
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x002F56D8 File Offset: 0x002F38D8
		public Span<byte> GetSmallChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x002F56E8 File Offset: 0x002F38E8
		public byte[] GetSmallChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600BFEE RID: 49134 RVA: 0x002F5700 File Offset: 0x002F3900
		public string AreaTexture
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

		// Token: 0x0600BFEF RID: 49135 RVA: 0x002F5738 File Offset: 0x002F3938
		public Span<byte> GetAreaTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x002F5748 File Offset: 0x002F3948
		public byte[] GetAreaTextureArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x002F5760 File Offset: 0x002F3960
		public string FunctionViewTexture(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x002F579C File Offset: 0x002F399C
		public int FunctionViewTextureLength
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

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600BFF3 RID: 49139 RVA: 0x002F57C8 File Offset: 0x002F39C8
		public int LoadingId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600BFF4 RID: 49140 RVA: 0x002F5808 File Offset: 0x002F3A08
		public int VideoDownLoadVersion
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

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x002F5848 File Offset: 0x002F3A48
		public int BlockList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600BFF6 RID: 49142 RVA: 0x002F5888 File Offset: 0x002F3A88
		public int BlockListLength
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

		// Token: 0x0600BFF7 RID: 49143 RVA: 0x002F58B4 File Offset: 0x002F3AB4
		public Span<int> GetBlockListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600BFF8 RID: 49144 RVA: 0x002F58C4 File Offset: 0x002F3AC4
		public int[] GetBlockListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFF9 RID: 49145 RVA: 0x002F58DC File Offset: 0x002F3ADC
		[NullableContext(1)]
		public int[] BlockList()
		{
			return this.GetBlockListArray();
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x002F58E4 File Offset: 0x002F3AE4
		[NullableContext(1)]
		public IEnumerable<int> BlockListIter()
		{
			RecallConfig.<BlockListIter>d__80 <BlockListIter>d__ = new RecallConfig.<BlockListIter>d__80(-2);
			<BlockListIter>d__.<>3__<>4__this = this;
			return <BlockListIter>d__;
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x002F58FC File Offset: 0x002F3AFC
		[NullableContext(1)]
		public Dictionary<int, int> DungeonIdMap()
		{
			return this.DungeonIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x002F5952 File Offset: 0x002F3B52
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DungeonIdMapIter()
		{
			RecallConfig.<DungeonIdMapIter>d__82 <DungeonIdMapIter>d__ = new RecallConfig.<DungeonIdMapIter>d__82(-2);
			<DungeonIdMapIter>d__.<>3__<>4__this = this;
			return <DungeonIdMapIter>d__;
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x002F5967 File Offset: 0x002F3B67
		[NullableContext(1)]
		public int[] DungeonIds()
		{
			return this.GetDungeonIdsArray();
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x002F596F File Offset: 0x002F3B6F
		[NullableContext(1)]
		public IEnumerable<int> DungeonIdsIter()
		{
			RecallConfig.<DungeonIdsIter>d__84 <DungeonIdsIter>d__ = new RecallConfig.<DungeonIdsIter>d__84(-2);
			<DungeonIdsIter>d__.<>3__<>4__this = this;
			return <DungeonIdsIter>d__;
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x002F5984 File Offset: 0x002F3B84
		[NullableContext(1)]
		public string[] EntryTags()
		{
			return this.EntryTagsIter().ToArray<string>();
		}

		// Token: 0x0600C000 RID: 49152 RVA: 0x002F5991 File Offset: 0x002F3B91
		[NullableContext(1)]
		public IEnumerable<string> EntryTagsIter()
		{
			RecallConfig.<EntryTagsIter>d__86 <EntryTagsIter>d__ = new RecallConfig.<EntryTagsIter>d__86(-2);
			<EntryTagsIter>d__.<>3__<>4__this = this;
			return <EntryTagsIter>d__;
		}

		// Token: 0x0600C001 RID: 49153 RVA: 0x002F59A6 File Offset: 0x002F3BA6
		[NullableContext(1)]
		public int[] FunctionIds()
		{
			return this.GetFunctionIdsArray();
		}

		// Token: 0x0600C002 RID: 49154 RVA: 0x002F59AE File Offset: 0x002F3BAE
		[NullableContext(1)]
		public IEnumerable<int> FunctionIdsIter()
		{
			RecallConfig.<FunctionIdsIter>d__88 <FunctionIdsIter>d__ = new RecallConfig.<FunctionIdsIter>d__88(-2);
			<FunctionIdsIter>d__.<>3__<>4__this = this;
			return <FunctionIdsIter>d__;
		}

		// Token: 0x0600C003 RID: 49155 RVA: 0x002F59C3 File Offset: 0x002F3BC3
		[NullableContext(1)]
		public string[] FunctionViewTexture()
		{
			return this.FunctionViewTextureIter().ToArray<string>();
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x002F59D0 File Offset: 0x002F3BD0
		[NullableContext(1)]
		public IEnumerable<string> FunctionViewTextureIter()
		{
			RecallConfig.<FunctionViewTextureIter>d__90 <FunctionViewTextureIter>d__ = new RecallConfig.<FunctionViewTextureIter>d__90(-2);
			<FunctionViewTextureIter>d__.<>3__<>4__this = this;
			return <FunctionViewTextureIter>d__;
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x002F59E5 File Offset: 0x002F3BE5
		[NullableContext(1)]
		public int[] LevelPlayIds()
		{
			return this.GetLevelPlayIdsArray();
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x002F59ED File Offset: 0x002F3BED
		[NullableContext(1)]
		public IEnumerable<int> LevelPlayIdsIter()
		{
			RecallConfig.<LevelPlayIdsIter>d__92 <LevelPlayIdsIter>d__ = new RecallConfig.<LevelPlayIdsIter>d__92(-2);
			<LevelPlayIdsIter>d__.<>3__<>4__this = this;
			return <LevelPlayIdsIter>d__;
		}

		// Token: 0x0600C007 RID: 49159 RVA: 0x002F5A02 File Offset: 0x002F3C02
		[NullableContext(1)]
		public int[] NeedFinishQuestIds()
		{
			return this.GetNeedFinishQuestIdsArray();
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x002F5A0A File Offset: 0x002F3C0A
		[NullableContext(1)]
		public IEnumerable<int> NeedFinishQuestIdsIter()
		{
			RecallConfig.<NeedFinishQuestIdsIter>d__94 <NeedFinishQuestIdsIter>d__ = new RecallConfig.<NeedFinishQuestIdsIter>d__94(-2);
			<NeedFinishQuestIdsIter>d__.<>3__<>4__this = this;
			return <NeedFinishQuestIdsIter>d__;
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x002F5A1F File Offset: 0x002F3C1F
		[NullableContext(1)]
		public int[] QuestIds()
		{
			return this.GetQuestIdsArray();
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x002F5A27 File Offset: 0x002F3C27
		[NullableContext(1)]
		public IEnumerable<int> QuestIdsIter()
		{
			RecallConfig.<QuestIdsIter>d__96 <QuestIdsIter>d__ = new RecallConfig.<QuestIdsIter>d__96(-2);
			<QuestIdsIter>d__.<>3__<>4__this = this;
			return <QuestIdsIter>d__;
		}

		// Token: 0x0600C00B RID: 49163 RVA: 0x002F5A3C File Offset: 0x002F3C3C
		[NullableContext(1)]
		public Dictionary<int, int> RecallLevels()
		{
			return this.RecallLevelsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x002F5A92 File Offset: 0x002F3C92
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RecallLevelsIter()
		{
			RecallConfig.<RecallLevelsIter>d__98 <RecallLevelsIter>d__ = new RecallConfig.<RecallLevelsIter>d__98(-2);
			<RecallLevelsIter>d__.<>3__<>4__this = this;
			return <RecallLevelsIter>d__;
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x002F5AA8 File Offset: 0x002F3CA8
		[NullableContext(1)]
		public Dictionary<int, int> RecallQuests()
		{
			return this.RecallQuestsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x002F5AFE File Offset: 0x002F3CFE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RecallQuestsIter()
		{
			RecallConfig.<RecallQuestsIter>d__100 <RecallQuestsIter>d__ = new RecallConfig.<RecallQuestsIter>d__100(-2);
			<RecallQuestsIter>d__.<>3__<>4__this = this;
			return <RecallQuestsIter>d__;
		}

		// Token: 0x0600C00F RID: 49167 RVA: 0x002F5B14 File Offset: 0x002F3D14
		public int? GetDungeonIdMap(int key)
		{
			this.EnsureDungeonIdMapCacheIfNeeded();
			int value;
			if (!this.DungeonIdMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C010 RID: 49168 RVA: 0x002F5B48 File Offset: 0x002F3D48
		public int? GetRecallLevels(int key)
		{
			this.EnsureRecallLevelsCacheIfNeeded();
			int value;
			if (!this.RecallLevelsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x002F5B7C File Offset: 0x002F3D7C
		public int? GetRecallQuests(int key)
		{
			this.EnsureRecallQuestsCacheIfNeeded();
			int value;
			if (!this.RecallQuestsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x002F5BB0 File Offset: 0x002F3DB0
		private void EnsureDungeonIdMapCacheIfNeeded()
		{
			if (this.DungeonIdMapCache != null)
			{
				return;
			}
			this.DungeonIdMapCache = this.DungeonIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x002F5C18 File Offset: 0x002F3E18
		private void EnsureRecallLevelsCacheIfNeeded()
		{
			if (this.RecallLevelsCache != null)
			{
				return;
			}
			this.RecallLevelsCache = this.RecallLevelsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x002F5C80 File Offset: 0x002F3E80
		private void EnsureRecallQuestsCacheIfNeeded()
		{
			if (this.RecallQuestsCache != null)
			{
				return;
			}
			this.RecallQuestsCache = this.RecallQuestsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C015 RID: 49173 RVA: 0x002F5CE6 File Offset: 0x002F3EE6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDungeonIdMapFrozenDict()
		{
			this.EnsureDungeonIdMapCacheIfNeeded();
			return this.DungeonIdMapCache;
		}

		// Token: 0x0600C016 RID: 49174 RVA: 0x002F5CF4 File Offset: 0x002F3EF4
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRecallLevelsFrozenDict()
		{
			this.EnsureRecallLevelsCacheIfNeeded();
			return this.RecallLevelsCache;
		}

		// Token: 0x0600C017 RID: 49175 RVA: 0x002F5D02 File Offset: 0x002F3F02
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRecallQuestsFrozenDict()
		{
			this.EnsureRecallQuestsCacheIfNeeded();
			return this.RecallQuestsCache;
		}

		// Token: 0x04005655 RID: 22101
		private Table __p;

		// Token: 0x04005656 RID: 22102
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonIdMapCache;

		// Token: 0x04005657 RID: 22103
		[Nullable(2)]
		private FrozenDictionary<int, int> RecallLevelsCache;

		// Token: 0x04005658 RID: 22104
		[Nullable(2)]
		private FrozenDictionary<int, int> RecallQuestsCache;
	}
}
