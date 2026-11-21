using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001064 RID: 4196
	public struct QuestTreeNode : IFlatbufferObject
	{
		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0600BD1A RID: 48410 RVA: 0x002EF1D0 File Offset: 0x002ED3D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD1B RID: 48411 RVA: 0x002EF1DD File Offset: 0x002ED3DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x002EF1E4 File Offset: 0x002ED3E4
		public static QuestTreeNode GetRootAsQuestTreeNode(ByteBuffer _bb)
		{
			return QuestTreeNode.GetRootAsQuestTreeNode(_bb, default(QuestTreeNode));
		}

		// Token: 0x0600BD1D RID: 48413 RVA: 0x002EF200 File Offset: 0x002ED400
		public static QuestTreeNode GetRootAsQuestTreeNode(ByteBuffer _bb, QuestTreeNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x002EF21D File Offset: 0x002ED41D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x002EF22C File Offset: 0x002ED42C
		public QuestTreeNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0600BD20 RID: 48416 RVA: 0x002EF23C File Offset: 0x002ED43C
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

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600BD21 RID: 48417 RVA: 0x002EF278 File Offset: 0x002ED478
		public int ChapterId
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

		// Token: 0x0600BD22 RID: 48418 RVA: 0x002EF2B4 File Offset: 0x002ED4B4
		public int QuestArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600BD23 RID: 48419 RVA: 0x002EF2F4 File Offset: 0x002ED4F4
		public int QuestArrayLength
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

		// Token: 0x0600BD24 RID: 48420 RVA: 0x002EF31F File Offset: 0x002ED51F
		public Span<int> GetQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BD25 RID: 48421 RVA: 0x002EF32E File Offset: 0x002ED52E
		public int[] GetQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x002EF348 File Offset: 0x002ED548
		public int CompleteQuestID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600BD27 RID: 48423 RVA: 0x002EF388 File Offset: 0x002ED588
		public int CompleteQuestIDLength
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

		// Token: 0x0600BD28 RID: 48424 RVA: 0x002EF3B4 File Offset: 0x002ED5B4
		public Span<int> GetCompleteQuestIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x002EF3C4 File Offset: 0x002ED5C4
		public int[] GetCompleteQuestIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0600BD2A RID: 48426 RVA: 0x002EF3DC File Offset: 0x002ED5DC
		public string Name
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

		// Token: 0x0600BD2B RID: 48427 RVA: 0x002EF414 File Offset: 0x002ED614
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x002EF424 File Offset: 0x002ED624
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0600BD2D RID: 48429 RVA: 0x002EF43C File Offset: 0x002ED63C
		public string QuestChapterName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x002EF474 File Offset: 0x002ED674
		public Span<byte> GetQuestChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x002EF484 File Offset: 0x002ED684
		public byte[] GetQuestChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x002EF49C File Offset: 0x002ED69C
		public int QuestType
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

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0600BD31 RID: 48433 RVA: 0x002EF4DC File Offset: 0x002ED6DC
		public int NodeType
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

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x002EF51C File Offset: 0x002ED71C
		public int MainQuestNode
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

		// Token: 0x0600BD33 RID: 48435 RVA: 0x002EF55C File Offset: 0x002ED75C
		public int PreNode(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x002EF59C File Offset: 0x002ED79C
		public int PreNodeLength
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

		// Token: 0x0600BD35 RID: 48437 RVA: 0x002EF5C8 File Offset: 0x002ED7C8
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x002EF5D8 File Offset: 0x002ED7D8
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600BD37 RID: 48439 RVA: 0x002EF5F0 File Offset: 0x002ED7F0
		public int NextNode
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

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600BD38 RID: 48440 RVA: 0x002EF630 File Offset: 0x002ED830
		public bool IsChapterEnding
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x002EF670 File Offset: 0x002ED870
		public int IncludeNodes(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0600BD3A RID: 48442 RVA: 0x002EF6B0 File Offset: 0x002ED8B0
		public int IncludeNodesLength
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

		// Token: 0x0600BD3B RID: 48443 RVA: 0x002EF6DC File Offset: 0x002ED8DC
		public Span<int> GetIncludeNodesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x002EF6EC File Offset: 0x002ED8EC
		public int[] GetIncludeNodesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x002EF704 File Offset: 0x002ED904
		public int UnlockConditions(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x002EF744 File Offset: 0x002ED944
		public int UnlockConditionsLength
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

		// Token: 0x0600BD3F RID: 48447 RVA: 0x002EF770 File Offset: 0x002ED970
		public Span<int> GetUnlockConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x002EF780 File Offset: 0x002ED980
		public int[] GetUnlockConditionsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600BD41 RID: 48449 RVA: 0x002EF798 File Offset: 0x002ED998
		public string ChapterName
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

		// Token: 0x0600BD42 RID: 48450 RVA: 0x002EF7D0 File Offset: 0x002ED9D0
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600BD43 RID: 48451 RVA: 0x002EF7E0 File Offset: 0x002ED9E0
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x002EF7F8 File Offset: 0x002ED9F8
		public int AccessPath
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

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0600BD45 RID: 48453 RVA: 0x002EF838 File Offset: 0x002EDA38
		public string AccessDesc
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x002EF870 File Offset: 0x002EDA70
		public Span<byte> GetAccessDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x002EF880 File Offset: 0x002EDA80
		public byte[] GetAccessDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x002EF898 File Offset: 0x002EDA98
		public bool ShowQuestReward
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0600BD49 RID: 48457 RVA: 0x002EF8D8 File Offset: 0x002EDAD8
		public int SortOrder
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

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x002EF918 File Offset: 0x002EDB18
		public string Summary
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD4B RID: 48459 RVA: 0x002EF950 File Offset: 0x002EDB50
		public Span<byte> GetSummaryBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600BD4C RID: 48460 RVA: 0x002EF960 File Offset: 0x002EDB60
		public byte[] GetSummaryArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0600BD4D RID: 48461 RVA: 0x002EF978 File Offset: 0x002EDB78
		public string ImageSmall
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x002EF9B0 File Offset: 0x002EDBB0
		public Span<byte> GetImageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x002EF9C0 File Offset: 0x002EDBC0
		public byte[] GetImageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0600BD50 RID: 48464 RVA: 0x002EF9D8 File Offset: 0x002EDBD8
		public string ImageSmallFemale
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x002EFA10 File Offset: 0x002EDC10
		public Span<byte> GetImageSmallFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x002EFA20 File Offset: 0x002EDC20
		public byte[] GetImageSmallFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0600BD53 RID: 48467 RVA: 0x002EFA38 File Offset: 0x002EDC38
		public string ImageLarge
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x002EFA70 File Offset: 0x002EDC70
		public Span<byte> GetImageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x002EFA80 File Offset: 0x002EDC80
		public byte[] GetImageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0600BD56 RID: 48470 RVA: 0x002EFA98 File Offset: 0x002EDC98
		public string ImageLargeFemale
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x002EFAD0 File Offset: 0x002EDCD0
		public Span<byte> GetImageLargeFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x002EFAE0 File Offset: 0x002EDCE0
		public byte[] GetImageLargeFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0600BD59 RID: 48473 RVA: 0x002EFAF8 File Offset: 0x002EDCF8
		public int RecallId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x002EFB35 File Offset: 0x002EDD35
		[NullableContext(1)]
		public int[] CompleteQuestID()
		{
			return this.GetCompleteQuestIDArray();
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x002EFB3D File Offset: 0x002EDD3D
		[NullableContext(1)]
		public IEnumerable<int> CompleteQuestIDIter()
		{
			QuestTreeNode.<CompleteQuestIDIter>d__92 <CompleteQuestIDIter>d__ = new QuestTreeNode.<CompleteQuestIDIter>d__92(-2);
			<CompleteQuestIDIter>d__.<>3__<>4__this = this;
			return <CompleteQuestIDIter>d__;
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x002EFB52 File Offset: 0x002EDD52
		[NullableContext(1)]
		public int[] IncludeNodes()
		{
			return this.GetIncludeNodesArray();
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x002EFB5A File Offset: 0x002EDD5A
		[NullableContext(1)]
		public IEnumerable<int> IncludeNodesIter()
		{
			QuestTreeNode.<IncludeNodesIter>d__94 <IncludeNodesIter>d__ = new QuestTreeNode.<IncludeNodesIter>d__94(-2);
			<IncludeNodesIter>d__.<>3__<>4__this = this;
			return <IncludeNodesIter>d__;
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x002EFB6F File Offset: 0x002EDD6F
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x002EFB77 File Offset: 0x002EDD77
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			QuestTreeNode.<PreNodeIter>d__96 <PreNodeIter>d__ = new QuestTreeNode.<PreNodeIter>d__96(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x002EFB8C File Offset: 0x002EDD8C
		[NullableContext(1)]
		public int[] QuestArray()
		{
			return this.GetQuestArrayArray();
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x002EFB94 File Offset: 0x002EDD94
		[NullableContext(1)]
		public IEnumerable<int> QuestArrayIter()
		{
			QuestTreeNode.<QuestArrayIter>d__98 <QuestArrayIter>d__ = new QuestTreeNode.<QuestArrayIter>d__98(-2);
			<QuestArrayIter>d__.<>3__<>4__this = this;
			return <QuestArrayIter>d__;
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x002EFBA9 File Offset: 0x002EDDA9
		[NullableContext(1)]
		public int[] UnlockConditions()
		{
			return this.GetUnlockConditionsArray();
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x002EFBB1 File Offset: 0x002EDDB1
		[NullableContext(1)]
		public IEnumerable<int> UnlockConditionsIter()
		{
			QuestTreeNode.<UnlockConditionsIter>d__100 <UnlockConditionsIter>d__ = new QuestTreeNode.<UnlockConditionsIter>d__100(-2);
			<UnlockConditionsIter>d__.<>3__<>4__this = this;
			return <UnlockConditionsIter>d__;
		}

		// Token: 0x04005632 RID: 22066
		private Table __p;
	}
}
