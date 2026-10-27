using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9E RID: 3998
	public struct RecallConfig : IFlatbufferObject
	{
		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600B983 RID: 47491 RVA: 0x002D87A1 File Offset: 0x002D69A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x002D87AE File Offset: 0x002D69AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x002D87B8 File Offset: 0x002D69B8
		public static RecallConfig GetRootAsRecallConfig(ByteBuffer _bb)
		{
			return RecallConfig.GetRootAsRecallConfig(_bb, default(RecallConfig));
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x002D87D4 File Offset: 0x002D69D4
		public static RecallConfig GetRootAsRecallConfig(ByteBuffer _bb, RecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x002D87F1 File Offset: 0x002D69F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x002D8800 File Offset: 0x002D6A00
		public RecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x002D8810 File Offset: 0x002D6A10
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

		// Token: 0x0600B98A RID: 47498 RVA: 0x002D884C File Offset: 0x002D6A4C
		public int NeedFinishQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600B98B RID: 47499 RVA: 0x002D888C File Offset: 0x002D6A8C
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

		// Token: 0x0600B98C RID: 47500 RVA: 0x002D88B7 File Offset: 0x002D6AB7
		public Span<int> GetNeedFinishQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x002D88C6 File Offset: 0x002D6AC6
		public int[] GetNeedFinishQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x002D88E0 File Offset: 0x002D6AE0
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600B98F RID: 47503 RVA: 0x002D8920 File Offset: 0x002D6B20
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

		// Token: 0x0600B990 RID: 47504 RVA: 0x002D894B File Offset: 0x002D6B4B
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x002D895A File Offset: 0x002D6B5A
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x002D8974 File Offset: 0x002D6B74
		public DicIntInt? RecallQuests(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600B993 RID: 47507 RVA: 0x002D89D8 File Offset: 0x002D6BD8
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

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x002D8A04 File Offset: 0x002D6C04
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

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x002D8A44 File Offset: 0x002D6C44
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

		// Token: 0x0600B996 RID: 47510 RVA: 0x002D8A84 File Offset: 0x002D6C84
		public int DungeonIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600B997 RID: 47511 RVA: 0x002D8AC4 File Offset: 0x002D6CC4
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

		// Token: 0x0600B998 RID: 47512 RVA: 0x002D8AF0 File Offset: 0x002D6CF0
		public Span<int> GetDungeonIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x002D8B00 File Offset: 0x002D6D00
		public int[] GetDungeonIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x002D8B18 File Offset: 0x002D6D18
		public DicIntInt? DungeonIdMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600B99B RID: 47515 RVA: 0x002D8B7C File Offset: 0x002D6D7C
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

		// Token: 0x0600B99C RID: 47516 RVA: 0x002D8BA8 File Offset: 0x002D6DA8
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600B99D RID: 47517 RVA: 0x002D8BE8 File Offset: 0x002D6DE8
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

		// Token: 0x0600B99E RID: 47518 RVA: 0x002D8C14 File Offset: 0x002D6E14
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x002D8C24 File Offset: 0x002D6E24
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x002D8C3C File Offset: 0x002D6E3C
		public DicIntInt? RecallLevels(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x002D8CA0 File Offset: 0x002D6EA0
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

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x002D8CCC File Offset: 0x002D6ECC
		public string EntryTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x002D8D08 File Offset: 0x002D6F08
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

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x002D8D34 File Offset: 0x002D6F34
		public int FunctionIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x002D8D74 File Offset: 0x002D6F74
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

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x002D8DA0 File Offset: 0x002D6FA0
		public Span<int> GetFunctionIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x002D8DB0 File Offset: 0x002D6FB0
		public int[] GetFunctionIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x002D8DC8 File Offset: 0x002D6FC8
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

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x002D8E00 File Offset: 0x002D7000
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x002D8E10 File Offset: 0x002D7010
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x002D8E28 File Offset: 0x002D7028
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

		// Token: 0x0600B9AC RID: 47532 RVA: 0x002D8E60 File Offset: 0x002D7060
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x002D8E70 File Offset: 0x002D7070
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x002D8E88 File Offset: 0x002D7088
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

		// Token: 0x0600B9AF RID: 47535 RVA: 0x002D8EC0 File Offset: 0x002D70C0
		public Span<byte> GetSmallChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x002D8ED0 File Offset: 0x002D70D0
		public byte[] GetSmallChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600B9B1 RID: 47537 RVA: 0x002D8EE8 File Offset: 0x002D70E8
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

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x002D8F20 File Offset: 0x002D7120
		public Span<byte> GetAreaTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x002D8F30 File Offset: 0x002D7130
		public byte[] GetAreaTextureArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x002D8F48 File Offset: 0x002D7148
		public string FunctionViewTexture(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600B9B5 RID: 47541 RVA: 0x002D8F84 File Offset: 0x002D7184
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

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x002D8FB0 File Offset: 0x002D71B0
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

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600B9B7 RID: 47543 RVA: 0x002D8FF0 File Offset: 0x002D71F0
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

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x002D9030 File Offset: 0x002D7230
		public int BlockList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x002D9070 File Offset: 0x002D7270
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

		// Token: 0x0600B9BA RID: 47546 RVA: 0x002D909C File Offset: 0x002D729C
		public Span<int> GetBlockListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x002D90AC File Offset: 0x002D72AC
		public int[] GetBlockListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x002D90C4 File Offset: 0x002D72C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlockListIter()或GetBlockListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BlockList()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetBlockListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x002D90E8 File Offset: 0x002D72E8
		[NullableContext(1)]
		public readonly IEnumerable<int> BlockListIter()
		{
			RecallConfig.<BlockListIter>d__80 <BlockListIter>d__ = new RecallConfig.<BlockListIter>d__80(-2);
			<BlockListIter>d__.<>3__<>4__this = this;
			return <BlockListIter>d__;
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x002D9100 File Offset: 0x002D7300
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DungeonIdMapFrozenDict()缓存字典，遍历请使用DungeonIdMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DungeonIdMap()
		{
			return this.DungeonIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B9BF RID: 47551 RVA: 0x002D9156 File Offset: 0x002D7356
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DungeonIdMapIter()
		{
			RecallConfig.<DungeonIdMapIter>d__82 <DungeonIdMapIter>d__ = new RecallConfig.<DungeonIdMapIter>d__82(-2);
			<DungeonIdMapIter>d__.<>3__<>4__this = this;
			return <DungeonIdMapIter>d__;
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x002D916C File Offset: 0x002D736C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonIdsIter()或GetDungeonIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonIds()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetDungeonIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x002D9190 File Offset: 0x002D7390
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonIdsIter()
		{
			RecallConfig.<DungeonIdsIter>d__84 <DungeonIdsIter>d__ = new RecallConfig.<DungeonIdsIter>d__84(-2);
			<DungeonIdsIter>d__.<>3__<>4__this = this;
			return <DungeonIdsIter>d__;
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x002D91A5 File Offset: 0x002D73A5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EntryTagsIter()或GetEntryTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EntryTags()
		{
			return this.EntryTagsIter().ToArray<string>();
		}

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x002D91B2 File Offset: 0x002D73B2
		[NullableContext(1)]
		public readonly IEnumerable<string> EntryTagsIter()
		{
			RecallConfig.<EntryTagsIter>d__86 <EntryTagsIter>d__ = new RecallConfig.<EntryTagsIter>d__86(-2);
			<EntryTagsIter>d__.<>3__<>4__this = this;
			return <EntryTagsIter>d__;
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x002D91C8 File Offset: 0x002D73C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FunctionIdsIter()或GetFunctionIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FunctionIds()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetFunctionIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x002D91EC File Offset: 0x002D73EC
		[NullableContext(1)]
		public readonly IEnumerable<int> FunctionIdsIter()
		{
			RecallConfig.<FunctionIdsIter>d__88 <FunctionIdsIter>d__ = new RecallConfig.<FunctionIdsIter>d__88(-2);
			<FunctionIdsIter>d__.<>3__<>4__this = this;
			return <FunctionIdsIter>d__;
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x002D9201 File Offset: 0x002D7401
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FunctionViewTextureIter()或GetFunctionViewTextureBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FunctionViewTexture()
		{
			return this.FunctionViewTextureIter().ToArray<string>();
		}

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x002D920E File Offset: 0x002D740E
		[NullableContext(1)]
		public readonly IEnumerable<string> FunctionViewTextureIter()
		{
			RecallConfig.<FunctionViewTextureIter>d__90 <FunctionViewTextureIter>d__ = new RecallConfig.<FunctionViewTextureIter>d__90(-2);
			<FunctionViewTextureIter>d__.<>3__<>4__this = this;
			return <FunctionViewTextureIter>d__;
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x002D9224 File Offset: 0x002D7424
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelPlayIdsIter()或GetLevelPlayIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelPlayIds()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetLevelPlayIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x002D9248 File Offset: 0x002D7448
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelPlayIdsIter()
		{
			RecallConfig.<LevelPlayIdsIter>d__92 <LevelPlayIdsIter>d__ = new RecallConfig.<LevelPlayIdsIter>d__92(-2);
			<LevelPlayIdsIter>d__.<>3__<>4__this = this;
			return <LevelPlayIdsIter>d__;
		}

		// Token: 0x0600B9CA RID: 47562 RVA: 0x002D9260 File Offset: 0x002D7460
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NeedFinishQuestIdsIter()或GetNeedFinishQuestIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NeedFinishQuestIds()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetNeedFinishQuestIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9CB RID: 47563 RVA: 0x002D9284 File Offset: 0x002D7484
		[NullableContext(1)]
		public readonly IEnumerable<int> NeedFinishQuestIdsIter()
		{
			RecallConfig.<NeedFinishQuestIdsIter>d__94 <NeedFinishQuestIdsIter>d__ = new RecallConfig.<NeedFinishQuestIdsIter>d__94(-2);
			<NeedFinishQuestIdsIter>d__.<>3__<>4__this = this;
			return <NeedFinishQuestIdsIter>d__;
		}

		// Token: 0x0600B9CC RID: 47564 RVA: 0x002D929C File Offset: 0x002D749C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestIdsIter()或GetQuestIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestIds()
		{
			RecallConfig recallConfig = this;
			return recallConfig.GetQuestIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x002D92C0 File Offset: 0x002D74C0
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestIdsIter()
		{
			RecallConfig.<QuestIdsIter>d__96 <QuestIdsIter>d__ = new RecallConfig.<QuestIdsIter>d__96(-2);
			<QuestIdsIter>d__.<>3__<>4__this = this;
			return <QuestIdsIter>d__;
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x002D92D8 File Offset: 0x002D74D8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RecallLevelsFrozenDict()缓存字典，遍历请使用RecallLevelsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RecallLevels()
		{
			return this.RecallLevelsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x002D932E File Offset: 0x002D752E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RecallLevelsIter()
		{
			RecallConfig.<RecallLevelsIter>d__98 <RecallLevelsIter>d__ = new RecallConfig.<RecallLevelsIter>d__98(-2);
			<RecallLevelsIter>d__.<>3__<>4__this = this;
			return <RecallLevelsIter>d__;
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x002D9344 File Offset: 0x002D7544
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RecallQuestsFrozenDict()缓存字典，遍历请使用RecallQuestsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RecallQuests()
		{
			return this.RecallQuestsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x002D939A File Offset: 0x002D759A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RecallQuestsIter()
		{
			RecallConfig.<RecallQuestsIter>d__100 <RecallQuestsIter>d__ = new RecallConfig.<RecallQuestsIter>d__100(-2);
			<RecallQuestsIter>d__.<>3__<>4__this = this;
			return <RecallQuestsIter>d__;
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x002D93B0 File Offset: 0x002D75B0
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

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x002D93E4 File Offset: 0x002D75E4
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

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x002D9418 File Offset: 0x002D7618
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

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x002D944C File Offset: 0x002D764C
		private void EnsureDungeonIdMapCacheIfNeeded()
		{
			if (this.DungeonIdMapCache != null)
			{
				return;
			}
			this.DungeonIdMapCache = this.DungeonIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x002D94B4 File Offset: 0x002D76B4
		private void EnsureRecallLevelsCacheIfNeeded()
		{
			if (this.RecallLevelsCache != null)
			{
				return;
			}
			this.RecallLevelsCache = this.RecallLevelsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x002D951C File Offset: 0x002D771C
		private void EnsureRecallQuestsCacheIfNeeded()
		{
			if (this.RecallQuestsCache != null)
			{
				return;
			}
			this.RecallQuestsCache = this.RecallQuestsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x002D9582 File Offset: 0x002D7782
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDungeonIdMapFrozenDict(int key)
		{
			this.EnsureDungeonIdMapCacheIfNeeded();
			return this.DungeonIdMapCache;
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x002D9590 File Offset: 0x002D7790
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRecallLevelsFrozenDict(int key)
		{
			this.EnsureRecallLevelsCacheIfNeeded();
			return this.RecallLevelsCache;
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x002D959E File Offset: 0x002D779E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRecallQuestsFrozenDict(int key)
		{
			this.EnsureRecallQuestsCacheIfNeeded();
			return this.RecallQuestsCache;
		}

		// Token: 0x0400506E RID: 20590
		private Table __p;

		// Token: 0x0400506F RID: 20591
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonIdMapCache;

		// Token: 0x04005070 RID: 20592
		[Nullable(2)]
		private FrozenDictionary<int, int> RecallLevelsCache;

		// Token: 0x04005071 RID: 20593
		[Nullable(2)]
		private FrozenDictionary<int, int> RecallQuestsCache;
	}
}
