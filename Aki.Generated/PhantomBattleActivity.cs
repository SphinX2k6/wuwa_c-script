using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA0 RID: 4000
	[NullableContext(1)]
	[Nullable(0)]
	public struct PhantomBattleActivity : IFlatbufferObject
	{
		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x002C561C File Offset: 0x002C381C
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x002C5629 File Offset: 0x002C3829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x002C5630 File Offset: 0x002C3830
		[NullableContext(0)]
		public static PhantomBattleActivity GetRootAsPhantomBattleActivity(ByteBuffer _bb)
		{
			return PhantomBattleActivity.GetRootAsPhantomBattleActivity(_bb, default(PhantomBattleActivity));
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x002C564C File Offset: 0x002C384C
		[NullableContext(0)]
		public static PhantomBattleActivity GetRootAsPhantomBattleActivity(ByteBuffer _bb, PhantomBattleActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x002C5669 File Offset: 0x002C3869
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x002C5678 File Offset: 0x002C3878
		[NullableContext(0)]
		public PhantomBattleActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x002C5688 File Offset: 0x002C3888
		public int ActivityId
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

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x002C56C4 File Offset: 0x002C38C4
		public int TimeQuantumId
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

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x002C5700 File Offset: 0x002C3900
		public int ShopId
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

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x0600AA02 RID: 43522 RVA: 0x002C573C File Offset: 0x002C393C
		public int ShopItemId
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

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x002C577C File Offset: 0x002C397C
		public int DustItemId
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

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600AA04 RID: 43524 RVA: 0x002C57BC File Offset: 0x002C39BC
		public int ExpItemId
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

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600AA05 RID: 43525 RVA: 0x002C57FC File Offset: 0x002C39FC
		public int Integration
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

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x002C583C File Offset: 0x002C3A3C
		public int AttackFactor
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

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x0600AA07 RID: 43527 RVA: 0x002C587C File Offset: 0x002C3A7C
		public int LifeFactor
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

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x002C58BC File Offset: 0x002C3ABC
		public int CardGroupNeedNum
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

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600AA09 RID: 43529 RVA: 0x002C58FC File Offset: 0x002C3AFC
		public int CanBattlePhantomNum
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

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600AA0A RID: 43530 RVA: 0x002C593C File Offset: 0x002C3B3C
		public int BattleSlotNum
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

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x0600AA0B RID: 43531 RVA: 0x002C597C File Offset: 0x002C3B7C
		public int FourCostCardCount
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

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x0600AA0C RID: 43532 RVA: 0x002C59BC File Offset: 0x002C3BBC
		public int AreaCardCount
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

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x002C59FC File Offset: 0x002C3BFC
		public int ItemCardMaxCount
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

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x0600AA0E RID: 43534 RVA: 0x002C5A3C File Offset: 0x002C3C3C
		public int NormalCardCount
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

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x0600AA0F RID: 43535 RVA: 0x002C5A7C File Offset: 0x002C3C7C
		public int DeckLimit
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

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002C5ABC File Offset: 0x002C3CBC
		public DicIntInt? CardMinRequired(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x0600AA11 RID: 43537 RVA: 0x002C5B20 File Offset: 0x002C3D20
		public int CardMinRequiredLength
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

		// Token: 0x0600AA12 RID: 43538 RVA: 0x002C5B4C File Offset: 0x002C3D4C
		public DicIntInt? CardMaxLimit(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600AA13 RID: 43539 RVA: 0x002C5BB0 File Offset: 0x002C3DB0
		public int CardMaxLimitLength
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

		// Token: 0x0600AA14 RID: 43540 RVA: 0x002C5BDC File Offset: 0x002C3DDC
		public int GroupNameLimit(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x0600AA15 RID: 43541 RVA: 0x002C5C1C File Offset: 0x002C3E1C
		public int GroupNameLimitLength
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

		// Token: 0x0600AA16 RID: 43542 RVA: 0x002C5C48 File Offset: 0x002C3E48
		[NullableContext(0)]
		public Span<int> GetGroupNameLimitBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x002C5C58 File Offset: 0x002C3E58
		[NullableContext(0)]
		public int[] GetGroupNameLimitArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x0600AA18 RID: 43544 RVA: 0x002C5C70 File Offset: 0x002C3E70
		public int ElementMax
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

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x0600AA19 RID: 43545 RVA: 0x002C5CB0 File Offset: 0x002C3EB0
		public int WeeklyExpLimit
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

		// Token: 0x0600AA1A RID: 43546 RVA: 0x002C5CF0 File Offset: 0x002C3EF0
		public DicIntInt? MaxItemLimit(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x0600AA1B RID: 43547 RVA: 0x002C5D54 File Offset: 0x002C3F54
		public int MaxItemLimitLength
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

		// Token: 0x0600AA1C RID: 43548 RVA: 0x002C5D80 File Offset: 0x002C3F80
		public int QuicklyBuild(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0600AA1D RID: 43549 RVA: 0x002C5DC0 File Offset: 0x002C3FC0
		public int QuicklyBuildLength
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

		// Token: 0x0600AA1E RID: 43550 RVA: 0x002C5DEC File Offset: 0x002C3FEC
		[NullableContext(0)]
		public Span<int> GetQuicklyBuildBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x002C5DFC File Offset: 0x002C3FFC
		[NullableContext(0)]
		public int[] GetQuicklyBuildArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x002C5E14 File Offset: 0x002C4014
		public int BadgeGroupEffects(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600AA21 RID: 43553 RVA: 0x002C5E54 File Offset: 0x002C4054
		public int BadgeGroupEffectsLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x002C5E80 File Offset: 0x002C4080
		[NullableContext(0)]
		public Span<int> GetBadgeGroupEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x002C5E90 File Offset: 0x002C4090
		[NullableContext(0)]
		public int[] GetBadgeGroupEffectsArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x002C5EA8 File Offset: 0x002C40A8
		public DicIntInt? FuncOpenChallenge(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0600AA25 RID: 43557 RVA: 0x002C5F0C File Offset: 0x002C410C
		public int FuncOpenChallengeLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x002C5F38 File Offset: 0x002C4138
		public int MainRoleList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0600AA27 RID: 43559 RVA: 0x002C5F78 File Offset: 0x002C4178
		public int MainRoleListLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x002C5FA4 File Offset: 0x002C41A4
		[NullableContext(0)]
		public Span<int> GetMainRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x002C5FB4 File Offset: 0x002C41B4
		[NullableContext(0)]
		public int[] GetMainRoleListArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x002C5FCC File Offset: 0x002C41CC
		public DicIntInt? MainRoleSexChange(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0600AA2B RID: 43563 RVA: 0x002C6030 File Offset: 0x002C4230
		public int MainRoleSexChangeLength
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

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x002C605C File Offset: 0x002C425C
		public int CopyUidPlayer
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x0600AA2D RID: 43565 RVA: 0x002C609C File Offset: 0x002C429C
		public int CopyUidNpc
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x002C60DC File Offset: 0x002C42DC
		public int CopyUidDifference
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x0600AA2F RID: 43567 RVA: 0x002C611C File Offset: 0x002C431C
		public int SlotLongPressTime
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x0600AA30 RID: 43568 RVA: 0x002C6160 File Offset: 0x002C4360
		public int SlotLongPressStartTime
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 250;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x0600AA31 RID: 43569 RVA: 0x002C61A4 File Offset: 0x002C43A4
		public int SlotLongPressEndTime
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 750;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600AA32 RID: 43570 RVA: 0x002C61E8 File Offset: 0x002C43E8
		public int RewardItemId
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600AA33 RID: 43571 RVA: 0x002C6228 File Offset: 0x002C4428
		public int RecommendQuestId
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x002C6268 File Offset: 0x002C4468
		[Nullable(0)]
		public string RecommendQuestTips
		{
			[NullableContext(0)]
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x002C62A0 File Offset: 0x002C44A0
		[NullableContext(0)]
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x002C62B0 File Offset: 0x002C44B0
		[NullableContext(0)]
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x002C62C8 File Offset: 0x002C44C8
		public int[] BadgeGroupEffects()
		{
			return this.GetBadgeGroupEffectsArray();
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x002C62D0 File Offset: 0x002C44D0
		public IEnumerable<int> BadgeGroupEffectsIter()
		{
			PhantomBattleActivity.<BadgeGroupEffectsIter>d__102 <BadgeGroupEffectsIter>d__ = new PhantomBattleActivity.<BadgeGroupEffectsIter>d__102(-2);
			<BadgeGroupEffectsIter>d__.<>3__<>4__this = this;
			return <BadgeGroupEffectsIter>d__;
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x002C62E8 File Offset: 0x002C44E8
		public Dictionary<int, int> CardMaxLimit()
		{
			return this.CardMaxLimitIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x002C633E File Offset: 0x002C453E
		public IEnumerable<DicIntInt> CardMaxLimitIter()
		{
			PhantomBattleActivity.<CardMaxLimitIter>d__104 <CardMaxLimitIter>d__ = new PhantomBattleActivity.<CardMaxLimitIter>d__104(-2);
			<CardMaxLimitIter>d__.<>3__<>4__this = this;
			return <CardMaxLimitIter>d__;
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x002C6354 File Offset: 0x002C4554
		public Dictionary<int, int> CardMinRequired()
		{
			return this.CardMinRequiredIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x002C63AA File Offset: 0x002C45AA
		public IEnumerable<DicIntInt> CardMinRequiredIter()
		{
			PhantomBattleActivity.<CardMinRequiredIter>d__106 <CardMinRequiredIter>d__ = new PhantomBattleActivity.<CardMinRequiredIter>d__106(-2);
			<CardMinRequiredIter>d__.<>3__<>4__this = this;
			return <CardMinRequiredIter>d__;
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x002C63C0 File Offset: 0x002C45C0
		public Dictionary<int, int> FuncOpenChallenge()
		{
			return this.FuncOpenChallengeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x002C6416 File Offset: 0x002C4616
		public IEnumerable<DicIntInt> FuncOpenChallengeIter()
		{
			PhantomBattleActivity.<FuncOpenChallengeIter>d__108 <FuncOpenChallengeIter>d__ = new PhantomBattleActivity.<FuncOpenChallengeIter>d__108(-2);
			<FuncOpenChallengeIter>d__.<>3__<>4__this = this;
			return <FuncOpenChallengeIter>d__;
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x002C642B File Offset: 0x002C462B
		public int[] GroupNameLimit()
		{
			return this.GetGroupNameLimitArray();
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x002C6433 File Offset: 0x002C4633
		public IEnumerable<int> GroupNameLimitIter()
		{
			PhantomBattleActivity.<GroupNameLimitIter>d__110 <GroupNameLimitIter>d__ = new PhantomBattleActivity.<GroupNameLimitIter>d__110(-2);
			<GroupNameLimitIter>d__.<>3__<>4__this = this;
			return <GroupNameLimitIter>d__;
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x002C6448 File Offset: 0x002C4648
		public int[] MainRoleList()
		{
			return this.GetMainRoleListArray();
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x002C6450 File Offset: 0x002C4650
		public IEnumerable<int> MainRoleListIter()
		{
			PhantomBattleActivity.<MainRoleListIter>d__112 <MainRoleListIter>d__ = new PhantomBattleActivity.<MainRoleListIter>d__112(-2);
			<MainRoleListIter>d__.<>3__<>4__this = this;
			return <MainRoleListIter>d__;
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x002C6468 File Offset: 0x002C4668
		public Dictionary<int, int> MainRoleSexChange()
		{
			return this.MainRoleSexChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x002C64BE File Offset: 0x002C46BE
		public IEnumerable<DicIntInt> MainRoleSexChangeIter()
		{
			PhantomBattleActivity.<MainRoleSexChangeIter>d__114 <MainRoleSexChangeIter>d__ = new PhantomBattleActivity.<MainRoleSexChangeIter>d__114(-2);
			<MainRoleSexChangeIter>d__.<>3__<>4__this = this;
			return <MainRoleSexChangeIter>d__;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x002C64D4 File Offset: 0x002C46D4
		public Dictionary<int, int> MaxItemLimit()
		{
			return this.MaxItemLimitIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x002C652A File Offset: 0x002C472A
		public IEnumerable<DicIntInt> MaxItemLimitIter()
		{
			PhantomBattleActivity.<MaxItemLimitIter>d__116 <MaxItemLimitIter>d__ = new PhantomBattleActivity.<MaxItemLimitIter>d__116(-2);
			<MaxItemLimitIter>d__.<>3__<>4__this = this;
			return <MaxItemLimitIter>d__;
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x002C653F File Offset: 0x002C473F
		public int[] QuicklyBuild()
		{
			return this.GetQuicklyBuildArray();
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x002C6547 File Offset: 0x002C4747
		public IEnumerable<int> QuicklyBuildIter()
		{
			PhantomBattleActivity.<QuicklyBuildIter>d__118 <QuicklyBuildIter>d__ = new PhantomBattleActivity.<QuicklyBuildIter>d__118(-2);
			<QuicklyBuildIter>d__.<>3__<>4__this = this;
			return <QuicklyBuildIter>d__;
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x002C655C File Offset: 0x002C475C
		public int? GetCardMaxLimit(int key)
		{
			this.EnsureCardMaxLimitCacheIfNeeded();
			int value;
			if (!this.CardMaxLimitCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x002C6590 File Offset: 0x002C4790
		public int? GetCardMinRequired(int key)
		{
			this.EnsureCardMinRequiredCacheIfNeeded();
			int value;
			if (!this.CardMinRequiredCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x002C65C4 File Offset: 0x002C47C4
		public int? GetFuncOpenChallenge(int key)
		{
			this.EnsureFuncOpenChallengeCacheIfNeeded();
			int value;
			if (!this.FuncOpenChallengeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x002C65F8 File Offset: 0x002C47F8
		public int? GetMainRoleSexChange(int key)
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			int value;
			if (!this.MainRoleSexChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x002C662C File Offset: 0x002C482C
		public int? GetMaxItemLimit(int key)
		{
			this.EnsureMaxItemLimitCacheIfNeeded();
			int value;
			if (!this.MaxItemLimitCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x002C6660 File Offset: 0x002C4860
		private void EnsureCardMaxLimitCacheIfNeeded()
		{
			if (this.CardMaxLimitCache != null)
			{
				return;
			}
			this.CardMaxLimitCache = this.CardMaxLimitIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x002C66C8 File Offset: 0x002C48C8
		private void EnsureCardMinRequiredCacheIfNeeded()
		{
			if (this.CardMinRequiredCache != null)
			{
				return;
			}
			this.CardMinRequiredCache = this.CardMinRequiredIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x002C6730 File Offset: 0x002C4930
		private void EnsureFuncOpenChallengeCacheIfNeeded()
		{
			if (this.FuncOpenChallengeCache != null)
			{
				return;
			}
			this.FuncOpenChallengeCache = this.FuncOpenChallengeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x002C6798 File Offset: 0x002C4998
		private void EnsureMainRoleSexChangeCacheIfNeeded()
		{
			if (this.MainRoleSexChangeCache != null)
			{
				return;
			}
			this.MainRoleSexChangeCache = this.MainRoleSexChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x002C6800 File Offset: 0x002C4A00
		private void EnsureMaxItemLimitCacheIfNeeded()
		{
			if (this.MaxItemLimitCache != null)
			{
				return;
			}
			this.MaxItemLimitCache = this.MaxItemLimitIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x002C6866 File Offset: 0x002C4A66
		public FrozenDictionary<int, int> GetCardMaxLimitFrozenDict()
		{
			this.EnsureCardMaxLimitCacheIfNeeded();
			return this.CardMaxLimitCache;
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x002C6874 File Offset: 0x002C4A74
		public FrozenDictionary<int, int> GetCardMinRequiredFrozenDict()
		{
			this.EnsureCardMinRequiredCacheIfNeeded();
			return this.CardMinRequiredCache;
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x002C6882 File Offset: 0x002C4A82
		public FrozenDictionary<int, int> GetFuncOpenChallengeFrozenDict()
		{
			this.EnsureFuncOpenChallengeCacheIfNeeded();
			return this.FuncOpenChallengeCache;
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x002C6890 File Offset: 0x002C4A90
		public FrozenDictionary<int, int> GetMainRoleSexChangeFrozenDict()
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			return this.MainRoleSexChangeCache;
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x002C689E File Offset: 0x002C4A9E
		public FrozenDictionary<int, int> GetMaxItemLimitFrozenDict()
		{
			this.EnsureMaxItemLimitCacheIfNeeded();
			return this.MaxItemLimitCache;
		}

		// Token: 0x04005556 RID: 21846
		private Table __p;

		// Token: 0x04005557 RID: 21847
		[Nullable(2)]
		private FrozenDictionary<int, int> CardMaxLimitCache;

		// Token: 0x04005558 RID: 21848
		[Nullable(2)]
		private FrozenDictionary<int, int> CardMinRequiredCache;

		// Token: 0x04005559 RID: 21849
		[Nullable(2)]
		private FrozenDictionary<int, int> FuncOpenChallengeCache;

		// Token: 0x0400555A RID: 21850
		[Nullable(2)]
		private FrozenDictionary<int, int> MainRoleSexChangeCache;

		// Token: 0x0400555B RID: 21851
		[Nullable(2)]
		private FrozenDictionary<int, int> MaxItemLimitCache;
	}
}
