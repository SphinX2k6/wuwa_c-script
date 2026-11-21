using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001012 RID: 4114
	public struct PinballLevelConfig : IFlatbufferObject
	{
		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x002DE57E File Offset: 0x002DC77E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x002DE58B File Offset: 0x002DC78B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x002DE594 File Offset: 0x002DC794
		public static PinballLevelConfig GetRootAsPinballLevelConfig(ByteBuffer _bb)
		{
			return PinballLevelConfig.GetRootAsPinballLevelConfig(_bb, default(PinballLevelConfig));
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x002DE5B0 File Offset: 0x002DC7B0
		public static PinballLevelConfig GetRootAsPinballLevelConfig(ByteBuffer _bb, PinballLevelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x002DE5CD File Offset: 0x002DC7CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x002DE5DC File Offset: 0x002DC7DC
		public PinballLevelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0600B512 RID: 46354 RVA: 0x002DE5EC File Offset: 0x002DC7EC
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

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600B513 RID: 46355 RVA: 0x002DE628 File Offset: 0x002DC828
		public int ShowRoleId
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

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0600B514 RID: 46356 RVA: 0x002DE664 File Offset: 0x002DC864
		public int Type
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

		// Token: 0x0600B515 RID: 46357 RVA: 0x002DE6A0 File Offset: 0x002DC8A0
		public int PreLevelIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600B516 RID: 46358 RVA: 0x002DE6E0 File Offset: 0x002DC8E0
		public int PreLevelIdsLength
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

		// Token: 0x0600B517 RID: 46359 RVA: 0x002DE70C File Offset: 0x002DC90C
		public Span<int> GetPreLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x002DE71C File Offset: 0x002DC91C
		public int[] GetPreLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600B519 RID: 46361 RVA: 0x002DE734 File Offset: 0x002DC934
		public int FirstClearDropId
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

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0600B51A RID: 46362 RVA: 0x002DE774 File Offset: 0x002DC974
		public int InstId
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

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0600B51B RID: 46363 RVA: 0x002DE7B4 File Offset: 0x002DC9B4
		public string Name
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

		// Token: 0x0600B51C RID: 46364 RVA: 0x002DE7EC File Offset: 0x002DC9EC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x002DE7FC File Offset: 0x002DC9FC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0600B51E RID: 46366 RVA: 0x002DE814 File Offset: 0x002DCA14
		public string Desc
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

		// Token: 0x0600B51F RID: 46367 RVA: 0x002DE84C File Offset: 0x002DCA4C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x002DE85C File Offset: 0x002DCA5C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0600B521 RID: 46369 RVA: 0x002DE874 File Offset: 0x002DCA74
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x002DE8AC File Offset: 0x002DCAAC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x002DE8BC File Offset: 0x002DCABC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x002DE8D4 File Offset: 0x002DCAD4
		public int StarCond(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600B525 RID: 46373 RVA: 0x002DE914 File Offset: 0x002DCB14
		public int StarCondLength
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

		// Token: 0x0600B526 RID: 46374 RVA: 0x002DE940 File Offset: 0x002DCB40
		public Span<int> GetStarCondBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x002DE950 File Offset: 0x002DCB50
		public int[] GetStarCondArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x002DE968 File Offset: 0x002DCB68
		public int RecommendRole(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600B529 RID: 46377 RVA: 0x002DE9A8 File Offset: 0x002DCBA8
		public int RecommendRoleLength
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

		// Token: 0x0600B52A RID: 46378 RVA: 0x002DE9D4 File Offset: 0x002DCBD4
		public Span<int> GetRecommendRoleBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x002DE9E4 File Offset: 0x002DCBE4
		public int[] GetRecommendRoleArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600B52C RID: 46380 RVA: 0x002DE9FC File Offset: 0x002DCBFC
		public int TrailRole(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600B52D RID: 46381 RVA: 0x002DEA3C File Offset: 0x002DCC3C
		public int TrailRoleLength
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

		// Token: 0x0600B52E RID: 46382 RVA: 0x002DEA68 File Offset: 0x002DCC68
		public Span<int> GetTrailRoleBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x002DEA78 File Offset: 0x002DCC78
		public int[] GetTrailRoleArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0600B530 RID: 46384 RVA: 0x002DEA90 File Offset: 0x002DCC90
		public string ScoreDesc
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

		// Token: 0x0600B531 RID: 46385 RVA: 0x002DEAC8 File Offset: 0x002DCCC8
		public Span<byte> GetScoreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x002DEAD8 File Offset: 0x002DCCD8
		public byte[] GetScoreDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x002DEAF0 File Offset: 0x002DCCF0
		public DicIntInt? ScoreLevelReward(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600B534 RID: 46388 RVA: 0x002DEB54 File Offset: 0x002DCD54
		public int ScoreLevelRewardLength
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

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600B535 RID: 46389 RVA: 0x002DEB80 File Offset: 0x002DCD80
		public int LevelTime
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

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600B536 RID: 46390 RVA: 0x002DEBC0 File Offset: 0x002DCDC0
		public int TowerNum
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

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0600B537 RID: 46391 RVA: 0x002DEC00 File Offset: 0x002DCE00
		public bool IsTowerBoss
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0600B538 RID: 46392 RVA: 0x002DEC40 File Offset: 0x002DCE40
		public int ScoreRatio
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

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600B539 RID: 46393 RVA: 0x002DEC80 File Offset: 0x002DCE80
		public int MaxRevive
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

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600B53A RID: 46394 RVA: 0x002DECC0 File Offset: 0x002DCEC0
		public int FormationGroup
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

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600B53B RID: 46395 RVA: 0x002DED00 File Offset: 0x002DCF00
		public string FailTipsTxt
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

		// Token: 0x0600B53C RID: 46396 RVA: 0x002DED38 File Offset: 0x002DCF38
		public Span<byte> GetFailTipsTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x002DED48 File Offset: 0x002DCF48
		public byte[] GetFailTipsTxtArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x002DED60 File Offset: 0x002DCF60
		public string LevelBg
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

		// Token: 0x0600B53F RID: 46399 RVA: 0x002DED98 File Offset: 0x002DCF98
		public Span<byte> GetLevelBgBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x002DEDA8 File Offset: 0x002DCFA8
		public byte[] GetLevelBgArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600B541 RID: 46401 RVA: 0x002DEDC0 File Offset: 0x002DCFC0
		public int NextLevelId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600B542 RID: 46402 RVA: 0x002DEE00 File Offset: 0x002DD000
		public int RecommendLevel
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600B543 RID: 46403 RVA: 0x002DEE40 File Offset: 0x002DD040
		public int AvgStyle
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

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600B544 RID: 46404 RVA: 0x002DEE80 File Offset: 0x002DD080
		public string FeverBarMaterialPath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x002DEEB8 File Offset: 0x002DD0B8
		public Span<byte> GetFeverBarMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x002DEEC8 File Offset: 0x002DD0C8
		public byte[] GetFeverBarMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x002DEEE0 File Offset: 0x002DD0E0
		[NullableContext(1)]
		public int[] PreLevelIds()
		{
			return this.GetPreLevelIdsArray();
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x002DEEE8 File Offset: 0x002DD0E8
		[NullableContext(1)]
		public IEnumerable<int> PreLevelIdsIter()
		{
			PinballLevelConfig.<PreLevelIdsIter>d__88 <PreLevelIdsIter>d__ = new PinballLevelConfig.<PreLevelIdsIter>d__88(-2);
			<PreLevelIdsIter>d__.<>3__<>4__this = this;
			return <PreLevelIdsIter>d__;
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x002DEEFD File Offset: 0x002DD0FD
		[NullableContext(1)]
		public int[] RecommendRole()
		{
			return this.GetRecommendRoleArray();
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x002DEF05 File Offset: 0x002DD105
		[NullableContext(1)]
		public IEnumerable<int> RecommendRoleIter()
		{
			PinballLevelConfig.<RecommendRoleIter>d__90 <RecommendRoleIter>d__ = new PinballLevelConfig.<RecommendRoleIter>d__90(-2);
			<RecommendRoleIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIter>d__;
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x002DEF1C File Offset: 0x002DD11C
		[NullableContext(1)]
		public Dictionary<int, int> ScoreLevelReward()
		{
			return this.ScoreLevelRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x002DEF72 File Offset: 0x002DD172
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ScoreLevelRewardIter()
		{
			PinballLevelConfig.<ScoreLevelRewardIter>d__92 <ScoreLevelRewardIter>d__ = new PinballLevelConfig.<ScoreLevelRewardIter>d__92(-2);
			<ScoreLevelRewardIter>d__.<>3__<>4__this = this;
			return <ScoreLevelRewardIter>d__;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x002DEF87 File Offset: 0x002DD187
		[NullableContext(1)]
		public int[] StarCond()
		{
			return this.GetStarCondArray();
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x002DEF8F File Offset: 0x002DD18F
		[NullableContext(1)]
		public IEnumerable<int> StarCondIter()
		{
			PinballLevelConfig.<StarCondIter>d__94 <StarCondIter>d__ = new PinballLevelConfig.<StarCondIter>d__94(-2);
			<StarCondIter>d__.<>3__<>4__this = this;
			return <StarCondIter>d__;
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x002DEFA4 File Offset: 0x002DD1A4
		[NullableContext(1)]
		public int[] TrailRole()
		{
			return this.GetTrailRoleArray();
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x002DEFAC File Offset: 0x002DD1AC
		[NullableContext(1)]
		public IEnumerable<int> TrailRoleIter()
		{
			PinballLevelConfig.<TrailRoleIter>d__96 <TrailRoleIter>d__ = new PinballLevelConfig.<TrailRoleIter>d__96(-2);
			<TrailRoleIter>d__.<>3__<>4__this = this;
			return <TrailRoleIter>d__;
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x002DEFC4 File Offset: 0x002DD1C4
		public int? GetScoreLevelReward(int key)
		{
			this.EnsureScoreLevelRewardCacheIfNeeded();
			int value;
			if (!this.ScoreLevelRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x002DEFF8 File Offset: 0x002DD1F8
		private void EnsureScoreLevelRewardCacheIfNeeded()
		{
			if (this.ScoreLevelRewardCache != null)
			{
				return;
			}
			this.ScoreLevelRewardCache = this.ScoreLevelRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x002DF05E File Offset: 0x002DD25E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetScoreLevelRewardFrozenDict()
		{
			this.EnsureScoreLevelRewardCacheIfNeeded();
			return this.ScoreLevelRewardCache;
		}

		// Token: 0x040055DB RID: 21979
		private Table __p;

		// Token: 0x040055DC RID: 21980
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreLevelRewardCache;
	}
}
