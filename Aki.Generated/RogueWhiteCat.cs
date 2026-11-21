using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111B RID: 4379
	[NullableContext(1)]
	[Nullable(0)]
	public struct RogueWhiteCat : IFlatbufferObject
	{
		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x00311F90 File Offset: 0x00310190
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00311F9D File Offset: 0x0031019D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00311FA4 File Offset: 0x003101A4
		[NullableContext(0)]
		public static RogueWhiteCat GetRootAsRogueWhiteCat(ByteBuffer _bb)
		{
			return RogueWhiteCat.GetRootAsRogueWhiteCat(_bb, default(RogueWhiteCat));
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x00311FC0 File Offset: 0x003101C0
		[NullableContext(0)]
		public static RogueWhiteCat GetRootAsRogueWhiteCat(ByteBuffer _bb, RogueWhiteCat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x00311FDD File Offset: 0x003101DD
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCFD RID: 52477 RVA: 0x00311FEC File Offset: 0x003101EC
		[NullableContext(0)]
		public RogueWhiteCat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600CCFE RID: 52478 RVA: 0x00311FFC File Offset: 0x003101FC
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

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x00312038 File Offset: 0x00310238
		public int ScoreId
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

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600CD00 RID: 52480 RVA: 0x00312074 File Offset: 0x00310274
		public int EnergyId
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

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600CD01 RID: 52481 RVA: 0x003120B0 File Offset: 0x003102B0
		public int MaxEnergy
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

		// Token: 0x0600CD02 RID: 52482 RVA: 0x003120F0 File Offset: 0x003102F0
		public int Insts(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600CD03 RID: 52483 RVA: 0x00312130 File Offset: 0x00310330
		public int InstsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CD04 RID: 52484 RVA: 0x0031215C File Offset: 0x0031035C
		[NullableContext(0)]
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600CD05 RID: 52485 RVA: 0x0031216C File Offset: 0x0031036C
		[NullableContext(0)]
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600CD06 RID: 52486 RVA: 0x00312184 File Offset: 0x00310384
		public int BossRewards(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600CD07 RID: 52487 RVA: 0x003121C4 File Offset: 0x003103C4
		public int BossRewardsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x003121F0 File Offset: 0x003103F0
		[NullableContext(0)]
		public Span<int> GetBossRewardsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CD09 RID: 52489 RVA: 0x00312200 File Offset: 0x00310400
		[NullableContext(0)]
		public int[] GetBossRewardsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600CD0A RID: 52490 RVA: 0x00312218 File Offset: 0x00310418
		public int LimitedTimeId
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

		// Token: 0x0600CD0B RID: 52491 RVA: 0x00312258 File Offset: 0x00310458
		public int Rewards(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600CD0C RID: 52492 RVA: 0x00312298 File Offset: 0x00310498
		public int RewardsLength
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

		// Token: 0x0600CD0D RID: 52493 RVA: 0x003122C4 File Offset: 0x003104C4
		[NullableContext(0)]
		public Span<int> GetRewardsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x003122D4 File Offset: 0x003104D4
		[NullableContext(0)]
		public int[] GetRewardsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600CD0F RID: 52495 RVA: 0x003122EC File Offset: 0x003104EC
		public int FirstWhiteCatDungeonId
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

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600CD10 RID: 52496 RVA: 0x0031232C File Offset: 0x0031052C
		public int RepeatWhiteCatDungeonId
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

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600CD11 RID: 52497 RVA: 0x0031236C File Offset: 0x0031056C
		public int WhiteCatFirstOpenCondition
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

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600CD12 RID: 52498 RVA: 0x003123AC File Offset: 0x003105AC
		public int FirstWhiteCatQuestId
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

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600CD13 RID: 52499 RVA: 0x003123EC File Offset: 0x003105EC
		public int WhiteCatRepeatOpenCondition
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

		// Token: 0x0600CD14 RID: 52500 RVA: 0x0031242C File Offset: 0x0031062C
		public DicIntInt? OpenCondition(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600CD15 RID: 52501 RVA: 0x00312490 File Offset: 0x00310690
		public int OpenConditionLength
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

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x003124BC File Offset: 0x003106BC
		public int DreamLinkTeleportMarkId
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

		// Token: 0x0600CD17 RID: 52503 RVA: 0x003124FC File Offset: 0x003106FC
		public DicIntString? TabText(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x00312560 File Offset: 0x00310760
		public int TabTextLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x0031258C File Offset: 0x0031078C
		public DicIntString? TabIcon(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x003125F0 File Offset: 0x003107F0
		public int TabIconLength
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

		// Token: 0x0600CD1B RID: 52507 RVA: 0x0031261C File Offset: 0x0031081C
		public DicIntString? BossTabText(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600CD1C RID: 52508 RVA: 0x00312680 File Offset: 0x00310880
		public int BossTabTextLength
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

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600CD1D RID: 52509 RVA: 0x003126AC File Offset: 0x003108AC
		[Nullable(0)]
		public string PlotRoleLinkAudio
		{
			[NullableContext(0)]
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

		// Token: 0x0600CD1E RID: 52510 RVA: 0x003126E4 File Offset: 0x003108E4
		[NullableContext(0)]
		public Span<byte> GetPlotRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x003126F4 File Offset: 0x003108F4
		[NullableContext(0)]
		public byte[] GetPlotRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x0031270C File Offset: 0x0031090C
		public int BossInstanceList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x0031274C File Offset: 0x0031094C
		public int BossInstanceListLength
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

		// Token: 0x0600CD22 RID: 52514 RVA: 0x00312778 File Offset: 0x00310978
		[NullableContext(0)]
		public Span<int> GetBossInstanceListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x00312788 File Offset: 0x00310988
		[NullableContext(0)]
		public int[] GetBossInstanceListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600CD24 RID: 52516 RVA: 0x003127A0 File Offset: 0x003109A0
		public int WeaponPreviewId
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

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600CD25 RID: 52517 RVA: 0x003127E0 File Offset: 0x003109E0
		public int DungeonBaseProgress
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

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600CD26 RID: 52518 RVA: 0x00312820 File Offset: 0x00310A20
		public int DungeonMaxProgress
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

		// Token: 0x0600CD27 RID: 52519 RVA: 0x00312860 File Offset: 0x00310A60
		public DicIntString? PreloadRoleIds(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x003128C4 File Offset: 0x00310AC4
		public int PreloadRoleIdsLength
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

		// Token: 0x0600CD29 RID: 52521 RVA: 0x003128F0 File Offset: 0x00310AF0
		public int PlotRoleLinkTeam(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600CD2A RID: 52522 RVA: 0x00312930 File Offset: 0x00310B30
		public int PlotRoleLinkTeamLength
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

		// Token: 0x0600CD2B RID: 52523 RVA: 0x0031295C File Offset: 0x00310B5C
		[NullableContext(0)]
		public Span<int> GetPlotRoleLinkTeamBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x0031296C File Offset: 0x00310B6C
		[NullableContext(0)]
		public int[] GetPlotRoleLinkTeamArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x00312984 File Offset: 0x00310B84
		public int[] BossInstanceList()
		{
			return this.GetBossInstanceListArray();
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x0031298C File Offset: 0x00310B8C
		public IEnumerable<int> BossInstanceListIter()
		{
			RogueWhiteCat.<BossInstanceListIter>d__81 <BossInstanceListIter>d__ = new RogueWhiteCat.<BossInstanceListIter>d__81(-2);
			<BossInstanceListIter>d__.<>3__<>4__this = this;
			return <BossInstanceListIter>d__;
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x003129A1 File Offset: 0x00310BA1
		public int[] BossRewards()
		{
			return this.GetBossRewardsArray();
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x003129A9 File Offset: 0x00310BA9
		public IEnumerable<int> BossRewardsIter()
		{
			RogueWhiteCat.<BossRewardsIter>d__83 <BossRewardsIter>d__ = new RogueWhiteCat.<BossRewardsIter>d__83(-2);
			<BossRewardsIter>d__.<>3__<>4__this = this;
			return <BossRewardsIter>d__;
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x003129C0 File Offset: 0x00310BC0
		public Dictionary<int, string> BossTabText()
		{
			return this.BossTabTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x00312A16 File Offset: 0x00310C16
		public IEnumerable<DicIntString> BossTabTextIter()
		{
			RogueWhiteCat.<BossTabTextIter>d__85 <BossTabTextIter>d__ = new RogueWhiteCat.<BossTabTextIter>d__85(-2);
			<BossTabTextIter>d__.<>3__<>4__this = this;
			return <BossTabTextIter>d__;
		}

		// Token: 0x0600CD33 RID: 52531 RVA: 0x00312A2B File Offset: 0x00310C2B
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x00312A33 File Offset: 0x00310C33
		public IEnumerable<int> InstsIter()
		{
			RogueWhiteCat.<InstsIter>d__87 <InstsIter>d__ = new RogueWhiteCat.<InstsIter>d__87(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x00312A48 File Offset: 0x00310C48
		public Dictionary<int, int> OpenCondition()
		{
			return this.OpenConditionIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x00312A9E File Offset: 0x00310C9E
		public IEnumerable<DicIntInt> OpenConditionIter()
		{
			RogueWhiteCat.<OpenConditionIter>d__89 <OpenConditionIter>d__ = new RogueWhiteCat.<OpenConditionIter>d__89(-2);
			<OpenConditionIter>d__.<>3__<>4__this = this;
			return <OpenConditionIter>d__;
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x00312AB3 File Offset: 0x00310CB3
		public int[] PlotRoleLinkTeam()
		{
			return this.GetPlotRoleLinkTeamArray();
		}

		// Token: 0x0600CD38 RID: 52536 RVA: 0x00312ABB File Offset: 0x00310CBB
		public IEnumerable<int> PlotRoleLinkTeamIter()
		{
			RogueWhiteCat.<PlotRoleLinkTeamIter>d__91 <PlotRoleLinkTeamIter>d__ = new RogueWhiteCat.<PlotRoleLinkTeamIter>d__91(-2);
			<PlotRoleLinkTeamIter>d__.<>3__<>4__this = this;
			return <PlotRoleLinkTeamIter>d__;
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x00312AD0 File Offset: 0x00310CD0
		public Dictionary<int, string> PreloadRoleIds()
		{
			return this.PreloadRoleIdsIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x00312B26 File Offset: 0x00310D26
		public IEnumerable<DicIntString> PreloadRoleIdsIter()
		{
			RogueWhiteCat.<PreloadRoleIdsIter>d__93 <PreloadRoleIdsIter>d__ = new RogueWhiteCat.<PreloadRoleIdsIter>d__93(-2);
			<PreloadRoleIdsIter>d__.<>3__<>4__this = this;
			return <PreloadRoleIdsIter>d__;
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x00312B3B File Offset: 0x00310D3B
		public int[] Rewards()
		{
			return this.GetRewardsArray();
		}

		// Token: 0x0600CD3C RID: 52540 RVA: 0x00312B43 File Offset: 0x00310D43
		public IEnumerable<int> RewardsIter()
		{
			RogueWhiteCat.<RewardsIter>d__95 <RewardsIter>d__ = new RogueWhiteCat.<RewardsIter>d__95(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x00312B58 File Offset: 0x00310D58
		public Dictionary<int, string> TabIcon()
		{
			return this.TabIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x00312BAE File Offset: 0x00310DAE
		public IEnumerable<DicIntString> TabIconIter()
		{
			RogueWhiteCat.<TabIconIter>d__97 <TabIconIter>d__ = new RogueWhiteCat.<TabIconIter>d__97(-2);
			<TabIconIter>d__.<>3__<>4__this = this;
			return <TabIconIter>d__;
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x00312BC4 File Offset: 0x00310DC4
		public Dictionary<int, string> TabText()
		{
			return this.TabTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CD40 RID: 52544 RVA: 0x00312C1A File Offset: 0x00310E1A
		public IEnumerable<DicIntString> TabTextIter()
		{
			RogueWhiteCat.<TabTextIter>d__99 <TabTextIter>d__ = new RogueWhiteCat.<TabTextIter>d__99(-2);
			<TabTextIter>d__.<>3__<>4__this = this;
			return <TabTextIter>d__;
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x00312C30 File Offset: 0x00310E30
		[NullableContext(2)]
		public string GetBossTabText(int key)
		{
			this.EnsureBossTabTextCacheIfNeeded();
			string result;
			if (!this.BossTabTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x00312C58 File Offset: 0x00310E58
		public int? GetOpenCondition(int key)
		{
			this.EnsureOpenConditionCacheIfNeeded();
			int value;
			if (!this.OpenConditionCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CD43 RID: 52547 RVA: 0x00312C8C File Offset: 0x00310E8C
		[NullableContext(2)]
		public string GetPreloadRoleIds(int key)
		{
			this.EnsurePreloadRoleIdsCacheIfNeeded();
			string result;
			if (!this.PreloadRoleIdsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CD44 RID: 52548 RVA: 0x00312CB4 File Offset: 0x00310EB4
		[NullableContext(2)]
		public string GetTabIcon(int key)
		{
			this.EnsureTabIconCacheIfNeeded();
			string result;
			if (!this.TabIconCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CD45 RID: 52549 RVA: 0x00312CDC File Offset: 0x00310EDC
		[NullableContext(2)]
		public string GetTabText(int key)
		{
			this.EnsureTabTextCacheIfNeeded();
			string result;
			if (!this.TabTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CD46 RID: 52550 RVA: 0x00312D04 File Offset: 0x00310F04
		private void EnsureBossTabTextCacheIfNeeded()
		{
			if (this.BossTabTextCache != null)
			{
				return;
			}
			this.BossTabTextCache = this.BossTabTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD47 RID: 52551 RVA: 0x00312D6C File Offset: 0x00310F6C
		private void EnsureOpenConditionCacheIfNeeded()
		{
			if (this.OpenConditionCache != null)
			{
				return;
			}
			this.OpenConditionCache = this.OpenConditionIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x00312DD4 File Offset: 0x00310FD4
		private void EnsurePreloadRoleIdsCacheIfNeeded()
		{
			if (this.PreloadRoleIdsCache != null)
			{
				return;
			}
			this.PreloadRoleIdsCache = this.PreloadRoleIdsIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD49 RID: 52553 RVA: 0x00312E3C File Offset: 0x0031103C
		private void EnsureTabIconCacheIfNeeded()
		{
			if (this.TabIconCache != null)
			{
				return;
			}
			this.TabIconCache = this.TabIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD4A RID: 52554 RVA: 0x00312EA4 File Offset: 0x003110A4
		private void EnsureTabTextCacheIfNeeded()
		{
			if (this.TabTextCache != null)
			{
				return;
			}
			this.TabTextCache = this.TabTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD4B RID: 52555 RVA: 0x00312F0A File Offset: 0x0031110A
		public FrozenDictionary<int, string> GetBossTabTextFrozenDict()
		{
			this.EnsureBossTabTextCacheIfNeeded();
			return this.BossTabTextCache;
		}

		// Token: 0x0600CD4C RID: 52556 RVA: 0x00312F18 File Offset: 0x00311118
		public FrozenDictionary<int, int> GetOpenConditionFrozenDict()
		{
			this.EnsureOpenConditionCacheIfNeeded();
			return this.OpenConditionCache;
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x00312F26 File Offset: 0x00311126
		public FrozenDictionary<int, string> GetPreloadRoleIdsFrozenDict()
		{
			this.EnsurePreloadRoleIdsCacheIfNeeded();
			return this.PreloadRoleIdsCache;
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x00312F34 File Offset: 0x00311134
		public FrozenDictionary<int, string> GetTabIconFrozenDict()
		{
			this.EnsureTabIconCacheIfNeeded();
			return this.TabIconCache;
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x00312F42 File Offset: 0x00311142
		public FrozenDictionary<int, string> GetTabTextFrozenDict()
		{
			this.EnsureTabTextCacheIfNeeded();
			return this.TabTextCache;
		}

		// Token: 0x04005713 RID: 22291
		private Table __p;

		// Token: 0x04005714 RID: 22292
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> BossTabTextCache;

		// Token: 0x04005715 RID: 22293
		[Nullable(2)]
		private FrozenDictionary<int, int> OpenConditionCache;

		// Token: 0x04005716 RID: 22294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PreloadRoleIdsCache;

		// Token: 0x04005717 RID: 22295
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabIconCache;

		// Token: 0x04005718 RID: 22296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabTextCache;
	}
}
