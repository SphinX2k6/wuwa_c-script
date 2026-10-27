using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBB RID: 3771
	public struct PhantomBattleActivity : IFlatbufferObject
	{
		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x0600A3D8 RID: 41944 RVA: 0x002A82DC File Offset: 0x002A64DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x002A82E9 File Offset: 0x002A64E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x002A82F0 File Offset: 0x002A64F0
		public static PhantomBattleActivity GetRootAsPhantomBattleActivity(ByteBuffer _bb)
		{
			return PhantomBattleActivity.GetRootAsPhantomBattleActivity(_bb, default(PhantomBattleActivity));
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x002A830C File Offset: 0x002A650C
		public static PhantomBattleActivity GetRootAsPhantomBattleActivity(ByteBuffer _bb, PhantomBattleActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x002A8329 File Offset: 0x002A6529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x002A8338 File Offset: 0x002A6538
		public PhantomBattleActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x0600A3DE RID: 41950 RVA: 0x002A8348 File Offset: 0x002A6548
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

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x0600A3DF RID: 41951 RVA: 0x002A8384 File Offset: 0x002A6584
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

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x0600A3E0 RID: 41952 RVA: 0x002A83C0 File Offset: 0x002A65C0
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

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x002A83FC File Offset: 0x002A65FC
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

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600A3E2 RID: 41954 RVA: 0x002A843C File Offset: 0x002A663C
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

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x002A847C File Offset: 0x002A667C
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

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x0600A3E4 RID: 41956 RVA: 0x002A84BC File Offset: 0x002A66BC
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

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x002A84FC File Offset: 0x002A66FC
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

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x0600A3E6 RID: 41958 RVA: 0x002A853C File Offset: 0x002A673C
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

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x002A857C File Offset: 0x002A677C
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

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x002A85BC File Offset: 0x002A67BC
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

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x002A85FC File Offset: 0x002A67FC
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

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600A3EA RID: 41962 RVA: 0x002A863C File Offset: 0x002A683C
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

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600A3EB RID: 41963 RVA: 0x002A867C File Offset: 0x002A687C
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

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x002A86BC File Offset: 0x002A68BC
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

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x002A86FC File Offset: 0x002A68FC
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

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600A3EE RID: 41966 RVA: 0x002A873C File Offset: 0x002A693C
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

		// Token: 0x0600A3EF RID: 41967 RVA: 0x002A877C File Offset: 0x002A697C
		public DicIntInt? CardMinRequired(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x002A87E0 File Offset: 0x002A69E0
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

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x002A880C File Offset: 0x002A6A0C
		public DicIntInt? CardMaxLimit(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600A3F2 RID: 41970 RVA: 0x002A8870 File Offset: 0x002A6A70
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

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x002A889C File Offset: 0x002A6A9C
		public int GroupNameLimit(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600A3F4 RID: 41972 RVA: 0x002A88DC File Offset: 0x002A6ADC
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

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x002A8908 File Offset: 0x002A6B08
		public Span<int> GetGroupNameLimitBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x002A8918 File Offset: 0x002A6B18
		public int[] GetGroupNameLimitArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x002A8930 File Offset: 0x002A6B30
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

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600A3F8 RID: 41976 RVA: 0x002A8970 File Offset: 0x002A6B70
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

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x002A89B0 File Offset: 0x002A6BB0
		public DicIntInt? MaxItemLimit(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600A3FA RID: 41978 RVA: 0x002A8A14 File Offset: 0x002A6C14
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

		// Token: 0x0600A3FB RID: 41979 RVA: 0x002A8A40 File Offset: 0x002A6C40
		public int QuicklyBuild(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x002A8A80 File Offset: 0x002A6C80
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

		// Token: 0x0600A3FD RID: 41981 RVA: 0x002A8AAC File Offset: 0x002A6CAC
		public Span<int> GetQuicklyBuildBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x002A8ABC File Offset: 0x002A6CBC
		public int[] GetQuicklyBuildArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x002A8AD4 File Offset: 0x002A6CD4
		public int BadgeGroupEffects(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600A400 RID: 41984 RVA: 0x002A8B14 File Offset: 0x002A6D14
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

		// Token: 0x0600A401 RID: 41985 RVA: 0x002A8B40 File Offset: 0x002A6D40
		public Span<int> GetBadgeGroupEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x002A8B50 File Offset: 0x002A6D50
		public int[] GetBadgeGroupEffectsArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x002A8B68 File Offset: 0x002A6D68
		public DicIntInt? FuncOpenChallenge(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600A404 RID: 41988 RVA: 0x002A8BCC File Offset: 0x002A6DCC
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

		// Token: 0x0600A405 RID: 41989 RVA: 0x002A8BF8 File Offset: 0x002A6DF8
		public int MainRoleList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600A406 RID: 41990 RVA: 0x002A8C38 File Offset: 0x002A6E38
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

		// Token: 0x0600A407 RID: 41991 RVA: 0x002A8C64 File Offset: 0x002A6E64
		public Span<int> GetMainRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x002A8C74 File Offset: 0x002A6E74
		public int[] GetMainRoleListArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x002A8C8C File Offset: 0x002A6E8C
		public DicIntInt? MainRoleSexChange(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x0600A40A RID: 41994 RVA: 0x002A8CF0 File Offset: 0x002A6EF0
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

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x002A8D1C File Offset: 0x002A6F1C
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

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x0600A40C RID: 41996 RVA: 0x002A8D5C File Offset: 0x002A6F5C
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

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600A40D RID: 41997 RVA: 0x002A8D9C File Offset: 0x002A6F9C
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

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600A40E RID: 41998 RVA: 0x002A8DDC File Offset: 0x002A6FDC
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

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600A40F RID: 41999 RVA: 0x002A8E20 File Offset: 0x002A7020
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

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x0600A410 RID: 42000 RVA: 0x002A8E64 File Offset: 0x002A7064
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

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x002A8EA8 File Offset: 0x002A70A8
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

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x0600A412 RID: 42002 RVA: 0x002A8EE8 File Offset: 0x002A70E8
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

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x0600A413 RID: 42003 RVA: 0x002A8F28 File Offset: 0x002A7128
		public string RecommendQuestTips
		{
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

		// Token: 0x0600A414 RID: 42004 RVA: 0x002A8F60 File Offset: 0x002A7160
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x002A8F70 File Offset: 0x002A7170
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x002A8F88 File Offset: 0x002A7188
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BadgeGroupEffectsIter()或GetBadgeGroupEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BadgeGroupEffects()
		{
			PhantomBattleActivity phantomBattleActivity = this;
			return phantomBattleActivity.GetBadgeGroupEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x002A8FAC File Offset: 0x002A71AC
		[NullableContext(1)]
		public readonly IEnumerable<int> BadgeGroupEffectsIter()
		{
			PhantomBattleActivity.<BadgeGroupEffectsIter>d__102 <BadgeGroupEffectsIter>d__ = new PhantomBattleActivity.<BadgeGroupEffectsIter>d__102(-2);
			<BadgeGroupEffectsIter>d__.<>3__<>4__this = this;
			return <BadgeGroupEffectsIter>d__;
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x002A8FC4 File Offset: 0x002A71C4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CardMaxLimitFrozenDict()缓存字典，遍历请使用CardMaxLimitIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CardMaxLimit()
		{
			return this.CardMaxLimitIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x002A901A File Offset: 0x002A721A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CardMaxLimitIter()
		{
			PhantomBattleActivity.<CardMaxLimitIter>d__104 <CardMaxLimitIter>d__ = new PhantomBattleActivity.<CardMaxLimitIter>d__104(-2);
			<CardMaxLimitIter>d__.<>3__<>4__this = this;
			return <CardMaxLimitIter>d__;
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x002A9030 File Offset: 0x002A7230
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CardMinRequiredFrozenDict()缓存字典，遍历请使用CardMinRequiredIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CardMinRequired()
		{
			return this.CardMinRequiredIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x002A9086 File Offset: 0x002A7286
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CardMinRequiredIter()
		{
			PhantomBattleActivity.<CardMinRequiredIter>d__106 <CardMinRequiredIter>d__ = new PhantomBattleActivity.<CardMinRequiredIter>d__106(-2);
			<CardMinRequiredIter>d__.<>3__<>4__this = this;
			return <CardMinRequiredIter>d__;
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x002A909C File Offset: 0x002A729C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FuncOpenChallengeFrozenDict()缓存字典，遍历请使用FuncOpenChallengeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FuncOpenChallenge()
		{
			return this.FuncOpenChallengeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x002A90F2 File Offset: 0x002A72F2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FuncOpenChallengeIter()
		{
			PhantomBattleActivity.<FuncOpenChallengeIter>d__108 <FuncOpenChallengeIter>d__ = new PhantomBattleActivity.<FuncOpenChallengeIter>d__108(-2);
			<FuncOpenChallengeIter>d__.<>3__<>4__this = this;
			return <FuncOpenChallengeIter>d__;
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x002A9108 File Offset: 0x002A7308
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupNameLimitIter()或GetGroupNameLimitBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupNameLimit()
		{
			PhantomBattleActivity phantomBattleActivity = this;
			return phantomBattleActivity.GetGroupNameLimitArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x002A912C File Offset: 0x002A732C
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupNameLimitIter()
		{
			PhantomBattleActivity.<GroupNameLimitIter>d__110 <GroupNameLimitIter>d__ = new PhantomBattleActivity.<GroupNameLimitIter>d__110(-2);
			<GroupNameLimitIter>d__.<>3__<>4__this = this;
			return <GroupNameLimitIter>d__;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x002A9144 File Offset: 0x002A7344
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainRoleListIter()或GetMainRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainRoleList()
		{
			PhantomBattleActivity phantomBattleActivity = this;
			return phantomBattleActivity.GetMainRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x002A9168 File Offset: 0x002A7368
		[NullableContext(1)]
		public readonly IEnumerable<int> MainRoleListIter()
		{
			PhantomBattleActivity.<MainRoleListIter>d__112 <MainRoleListIter>d__ = new PhantomBattleActivity.<MainRoleListIter>d__112(-2);
			<MainRoleListIter>d__.<>3__<>4__this = this;
			return <MainRoleListIter>d__;
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x002A9180 File Offset: 0x002A7380
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MainRoleSexChangeFrozenDict()缓存字典，遍历请使用MainRoleSexChangeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MainRoleSexChange()
		{
			return this.MainRoleSexChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x002A91D6 File Offset: 0x002A73D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MainRoleSexChangeIter()
		{
			PhantomBattleActivity.<MainRoleSexChangeIter>d__114 <MainRoleSexChangeIter>d__ = new PhantomBattleActivity.<MainRoleSexChangeIter>d__114(-2);
			<MainRoleSexChangeIter>d__.<>3__<>4__this = this;
			return <MainRoleSexChangeIter>d__;
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x002A91EC File Offset: 0x002A73EC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MaxItemLimitFrozenDict()缓存字典，遍历请使用MaxItemLimitIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MaxItemLimit()
		{
			return this.MaxItemLimitIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x002A9242 File Offset: 0x002A7442
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MaxItemLimitIter()
		{
			PhantomBattleActivity.<MaxItemLimitIter>d__116 <MaxItemLimitIter>d__ = new PhantomBattleActivity.<MaxItemLimitIter>d__116(-2);
			<MaxItemLimitIter>d__.<>3__<>4__this = this;
			return <MaxItemLimitIter>d__;
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x002A9258 File Offset: 0x002A7458
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuicklyBuildIter()或GetQuicklyBuildBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuicklyBuild()
		{
			PhantomBattleActivity phantomBattleActivity = this;
			return phantomBattleActivity.GetQuicklyBuildArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x002A927C File Offset: 0x002A747C
		[NullableContext(1)]
		public readonly IEnumerable<int> QuicklyBuildIter()
		{
			PhantomBattleActivity.<QuicklyBuildIter>d__118 <QuicklyBuildIter>d__ = new PhantomBattleActivity.<QuicklyBuildIter>d__118(-2);
			<QuicklyBuildIter>d__.<>3__<>4__this = this;
			return <QuicklyBuildIter>d__;
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x002A9294 File Offset: 0x002A7494
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

		// Token: 0x0600A429 RID: 42025 RVA: 0x002A92C8 File Offset: 0x002A74C8
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

		// Token: 0x0600A42A RID: 42026 RVA: 0x002A92FC File Offset: 0x002A74FC
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

		// Token: 0x0600A42B RID: 42027 RVA: 0x002A9330 File Offset: 0x002A7530
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

		// Token: 0x0600A42C RID: 42028 RVA: 0x002A9364 File Offset: 0x002A7564
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

		// Token: 0x0600A42D RID: 42029 RVA: 0x002A9398 File Offset: 0x002A7598
		private void EnsureCardMaxLimitCacheIfNeeded()
		{
			if (this.CardMaxLimitCache != null)
			{
				return;
			}
			this.CardMaxLimitCache = this.CardMaxLimitIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x002A9400 File Offset: 0x002A7600
		private void EnsureCardMinRequiredCacheIfNeeded()
		{
			if (this.CardMinRequiredCache != null)
			{
				return;
			}
			this.CardMinRequiredCache = this.CardMinRequiredIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x002A9468 File Offset: 0x002A7668
		private void EnsureFuncOpenChallengeCacheIfNeeded()
		{
			if (this.FuncOpenChallengeCache != null)
			{
				return;
			}
			this.FuncOpenChallengeCache = this.FuncOpenChallengeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x002A94D0 File Offset: 0x002A76D0
		private void EnsureMainRoleSexChangeCacheIfNeeded()
		{
			if (this.MainRoleSexChangeCache != null)
			{
				return;
			}
			this.MainRoleSexChangeCache = this.MainRoleSexChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x002A9538 File Offset: 0x002A7738
		private void EnsureMaxItemLimitCacheIfNeeded()
		{
			if (this.MaxItemLimitCache != null)
			{
				return;
			}
			this.MaxItemLimitCache = this.MaxItemLimitIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x002A959E File Offset: 0x002A779E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCardMaxLimitFrozenDict(int key)
		{
			this.EnsureCardMaxLimitCacheIfNeeded();
			return this.CardMaxLimitCache;
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x002A95AC File Offset: 0x002A77AC
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCardMinRequiredFrozenDict(int key)
		{
			this.EnsureCardMinRequiredCacheIfNeeded();
			return this.CardMinRequiredCache;
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x002A95BA File Offset: 0x002A77BA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFuncOpenChallengeFrozenDict(int key)
		{
			this.EnsureFuncOpenChallengeCacheIfNeeded();
			return this.FuncOpenChallengeCache;
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x002A95C8 File Offset: 0x002A77C8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMainRoleSexChangeFrozenDict(int key)
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			return this.MainRoleSexChangeCache;
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x002A95D6 File Offset: 0x002A77D6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMaxItemLimitFrozenDict(int key)
		{
			this.EnsureMaxItemLimitCacheIfNeeded();
			return this.MaxItemLimitCache;
		}

		// Token: 0x04004F71 RID: 20337
		private Table __p;

		// Token: 0x04004F72 RID: 20338
		[Nullable(2)]
		private FrozenDictionary<int, int> CardMaxLimitCache;

		// Token: 0x04004F73 RID: 20339
		[Nullable(2)]
		private FrozenDictionary<int, int> CardMinRequiredCache;

		// Token: 0x04004F74 RID: 20340
		[Nullable(2)]
		private FrozenDictionary<int, int> FuncOpenChallengeCache;

		// Token: 0x04004F75 RID: 20341
		[Nullable(2)]
		private FrozenDictionary<int, int> MainRoleSexChangeCache;

		// Token: 0x04004F76 RID: 20342
		[Nullable(2)]
		private FrozenDictionary<int, int> MaxItemLimitCache;
	}
}
