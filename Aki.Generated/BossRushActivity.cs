using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C23 RID: 3107
	public struct BossRushActivity : IFlatbufferObject
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x00206DD1 File Offset: 0x00204FD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x00206DDE File Offset: 0x00204FDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00206DE8 File Offset: 0x00204FE8
		public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb)
		{
			return BossRushActivity.GetRootAsBossRushActivity(_bb, default(BossRushActivity));
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x00206E04 File Offset: 0x00205004
		public static BossRushActivity GetRootAsBossRushActivity(ByteBuffer _bb, BossRushActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00206E21 File Offset: 0x00205021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00206E30 File Offset: 0x00205030
		public BossRushActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x00206E40 File Offset: 0x00205040
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x00206E7C File Offset: 0x0020507C
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x00206EB8 File Offset: 0x002050B8
		public int InstId
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x00206EF4 File Offset: 0x002050F4
		public int GroupId
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x00206F34 File Offset: 0x00205134
		public int SortId
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x00206F74 File Offset: 0x00205174
		public int BuffCount
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

		// Token: 0x0600548B RID: 21643 RVA: 0x00206FB4 File Offset: 0x002051B4
		public int DefaultBuff(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x00206FF4 File Offset: 0x002051F4
		public int DefaultBuffLength
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

		// Token: 0x0600548D RID: 21645 RVA: 0x00207020 File Offset: 0x00205220
		public Span<int> GetDefaultBuffBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00207030 File Offset: 0x00205230
		public int[] GetDefaultBuffArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00207048 File Offset: 0x00205248
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x00207088 File Offset: 0x00205288
		public int OptionalBuffLength
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

		// Token: 0x06005491 RID: 21649 RVA: 0x002070B4 File Offset: 0x002052B4
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x002070C4 File Offset: 0x002052C4
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x002070DC File Offset: 0x002052DC
		public int UnlockBuff(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x0020711C File Offset: 0x0020531C
		public int UnlockBuffLength
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

		// Token: 0x06005495 RID: 21653 RVA: 0x00207148 File Offset: 0x00205348
		public Span<int> GetUnlockBuffBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x00207158 File Offset: 0x00205358
		public int[] GetUnlockBuffArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x00207170 File Offset: 0x00205370
		public int OpenDay
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x002071B0 File Offset: 0x002053B0
		public int Condition
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x002071F0 File Offset: 0x002053F0
		public int PreLevel
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600549A RID: 21658 RVA: 0x00207230 File Offset: 0x00205430
		public int RewardScore
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600549B RID: 21659 RVA: 0x00207270 File Offset: 0x00205470
		public string LevelRewardDesc
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

		// Token: 0x0600549C RID: 21660 RVA: 0x002072A8 File Offset: 0x002054A8
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x002072B8 File Offset: 0x002054B8
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x002072D0 File Offset: 0x002054D0
		public string LevelDesc
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

		// Token: 0x0600549F RID: 21663 RVA: 0x00207308 File Offset: 0x00205508
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00207318 File Offset: 0x00205518
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x00207330 File Offset: 0x00205530
		public int RewardId
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x00207370 File Offset: 0x00205570
		public int BossInfo
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x002073B0 File Offset: 0x002055B0
		public string PreviewTexture
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

		// Token: 0x060054A4 RID: 21668 RVA: 0x002073E8 File Offset: 0x002055E8
		public Span<byte> GetPreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x002073F8 File Offset: 0x002055F8
		public byte[] GetPreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00207410 File Offset: 0x00205610
		public string StageTexture
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x00207448 File Offset: 0x00205648
		public Span<byte> GetStageTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x00207458 File Offset: 0x00205658
		public byte[] GetStageTextureArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x00207470 File Offset: 0x00205670
		public int BossCount
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x002074B0 File Offset: 0x002056B0
		public int ScoreBuffCount
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

		// Token: 0x060054AB RID: 21675 RVA: 0x002074F0 File Offset: 0x002056F0
		public int ScoreBuff(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x00207530 File Offset: 0x00205730
		public int ScoreBuffLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x0020755C File Offset: 0x0020575C
		public Span<int> GetScoreBuffBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x0020756C File Offset: 0x0020576C
		public int[] GetScoreBuffArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00207584 File Offset: 0x00205784
		public IntPair? LevelScoreRewardList(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x002075E8 File Offset: 0x002057E8
		public int LevelScoreRewardListLength
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060054B1 RID: 21681 RVA: 0x00207614 File Offset: 0x00205814
		public string RewardName
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

		// Token: 0x060054B2 RID: 21682 RVA: 0x0020764C File Offset: 0x0020584C
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x0020765C File Offset: 0x0020585C
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x00207674 File Offset: 0x00205874
		public string RewardTexture
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x002076AC File Offset: 0x002058AC
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x002076BC File Offset: 0x002058BC
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x002076D4 File Offset: 0x002058D4
		[NullableContext(1)]
		public int[] DefaultBuff()
		{
			return this.GetDefaultBuffArray();
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x002076DC File Offset: 0x002058DC
		[NullableContext(1)]
		public IEnumerable<int> DefaultBuffIter()
		{
			BossRushActivity.<DefaultBuffIter>d__84 <DefaultBuffIter>d__ = new BossRushActivity.<DefaultBuffIter>d__84(-2);
			<DefaultBuffIter>d__.<>3__<>4__this = this;
			return <DefaultBuffIter>d__;
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x002076F1 File Offset: 0x002058F1
		[NullableContext(1)]
		public IntPair[] LevelScoreRewardList()
		{
			return this.LevelScoreRewardListIter().ToArray<IntPair>();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x002076FE File Offset: 0x002058FE
		[NullableContext(1)]
		public IEnumerable<IntPair> LevelScoreRewardListIter()
		{
			BossRushActivity.<LevelScoreRewardListIter>d__86 <LevelScoreRewardListIter>d__ = new BossRushActivity.<LevelScoreRewardListIter>d__86(-2);
			<LevelScoreRewardListIter>d__.<>3__<>4__this = this;
			return <LevelScoreRewardListIter>d__;
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00207713 File Offset: 0x00205913
		[NullableContext(1)]
		public int[] OptionalBuff()
		{
			return this.GetOptionalBuffArray();
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x0020771B File Offset: 0x0020591B
		[NullableContext(1)]
		public IEnumerable<int> OptionalBuffIter()
		{
			BossRushActivity.<OptionalBuffIter>d__88 <OptionalBuffIter>d__ = new BossRushActivity.<OptionalBuffIter>d__88(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00207730 File Offset: 0x00205930
		[NullableContext(1)]
		public int[] ScoreBuff()
		{
			return this.GetScoreBuffArray();
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00207738 File Offset: 0x00205938
		[NullableContext(1)]
		public IEnumerable<int> ScoreBuffIter()
		{
			BossRushActivity.<ScoreBuffIter>d__90 <ScoreBuffIter>d__ = new BossRushActivity.<ScoreBuffIter>d__90(-2);
			<ScoreBuffIter>d__.<>3__<>4__this = this;
			return <ScoreBuffIter>d__;
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x0020774D File Offset: 0x0020594D
		[NullableContext(1)]
		public int[] UnlockBuff()
		{
			return this.GetUnlockBuffArray();
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00207755 File Offset: 0x00205955
		[NullableContext(1)]
		public IEnumerable<int> UnlockBuffIter()
		{
			BossRushActivity.<UnlockBuffIter>d__92 <UnlockBuffIter>d__ = new BossRushActivity.<UnlockBuffIter>d__92(-2);
			<UnlockBuffIter>d__.<>3__<>4__this = this;
			return <UnlockBuffIter>d__;
		}

		// Token: 0x0400511E RID: 20766
		private Table __p;
	}
}
