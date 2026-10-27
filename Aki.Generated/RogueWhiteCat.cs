using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001033 RID: 4147
	public struct RogueWhiteCat : IFlatbufferObject
	{
		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600C6AE RID: 50862 RVA: 0x002F6080 File Offset: 0x002F4280
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x002F608D File Offset: 0x002F428D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x002F6094 File Offset: 0x002F4294
		public static RogueWhiteCat GetRootAsRogueWhiteCat(ByteBuffer _bb)
		{
			return RogueWhiteCat.GetRootAsRogueWhiteCat(_bb, default(RogueWhiteCat));
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x002F60B0 File Offset: 0x002F42B0
		public static RogueWhiteCat GetRootAsRogueWhiteCat(ByteBuffer _bb, RogueWhiteCat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x002F60CD File Offset: 0x002F42CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x002F60DC File Offset: 0x002F42DC
		public RogueWhiteCat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600C6B4 RID: 50868 RVA: 0x002F60EC File Offset: 0x002F42EC
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

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600C6B5 RID: 50869 RVA: 0x002F6128 File Offset: 0x002F4328
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

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600C6B6 RID: 50870 RVA: 0x002F6164 File Offset: 0x002F4364
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

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x002F61A0 File Offset: 0x002F43A0
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

		// Token: 0x0600C6B8 RID: 50872 RVA: 0x002F61E0 File Offset: 0x002F43E0
		public int Insts(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x002F6220 File Offset: 0x002F4420
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

		// Token: 0x0600C6BA RID: 50874 RVA: 0x002F624C File Offset: 0x002F444C
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x002F625C File Offset: 0x002F445C
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x002F6274 File Offset: 0x002F4474
		public int BossRewards(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600C6BD RID: 50877 RVA: 0x002F62B4 File Offset: 0x002F44B4
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

		// Token: 0x0600C6BE RID: 50878 RVA: 0x002F62E0 File Offset: 0x002F44E0
		public Span<int> GetBossRewardsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x002F62F0 File Offset: 0x002F44F0
		public int[] GetBossRewardsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600C6C0 RID: 50880 RVA: 0x002F6308 File Offset: 0x002F4508
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

		// Token: 0x0600C6C1 RID: 50881 RVA: 0x002F6348 File Offset: 0x002F4548
		public int Rewards(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x002F6388 File Offset: 0x002F4588
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

		// Token: 0x0600C6C3 RID: 50883 RVA: 0x002F63B4 File Offset: 0x002F45B4
		public Span<int> GetRewardsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C6C4 RID: 50884 RVA: 0x002F63C4 File Offset: 0x002F45C4
		public int[] GetRewardsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600C6C5 RID: 50885 RVA: 0x002F63DC File Offset: 0x002F45DC
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

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x002F641C File Offset: 0x002F461C
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

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600C6C7 RID: 50887 RVA: 0x002F645C File Offset: 0x002F465C
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

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x002F649C File Offset: 0x002F469C
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

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600C6C9 RID: 50889 RVA: 0x002F64DC File Offset: 0x002F46DC
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

		// Token: 0x0600C6CA RID: 50890 RVA: 0x002F651C File Offset: 0x002F471C
		public DicIntInt? OpenCondition(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600C6CB RID: 50891 RVA: 0x002F6580 File Offset: 0x002F4780
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

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x002F65AC File Offset: 0x002F47AC
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

		// Token: 0x0600C6CD RID: 50893 RVA: 0x002F65EC File Offset: 0x002F47EC
		public DicIntString? TabText(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600C6CE RID: 50894 RVA: 0x002F6650 File Offset: 0x002F4850
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

		// Token: 0x0600C6CF RID: 50895 RVA: 0x002F667C File Offset: 0x002F487C
		public DicIntString? TabIcon(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x002F66E0 File Offset: 0x002F48E0
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

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x002F670C File Offset: 0x002F490C
		public DicIntString? BossTabText(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x002F6770 File Offset: 0x002F4970
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

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600C6D3 RID: 50899 RVA: 0x002F679C File Offset: 0x002F499C
		public string PlotRoleLinkAudio
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

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x002F67D4 File Offset: 0x002F49D4
		public Span<byte> GetPlotRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x002F67E4 File Offset: 0x002F49E4
		public byte[] GetPlotRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x002F67FC File Offset: 0x002F49FC
		public int BossInstanceList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600C6D7 RID: 50903 RVA: 0x002F683C File Offset: 0x002F4A3C
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

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x002F6868 File Offset: 0x002F4A68
		public Span<int> GetBossInstanceListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600C6D9 RID: 50905 RVA: 0x002F6878 File Offset: 0x002F4A78
		public int[] GetBossInstanceListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600C6DA RID: 50906 RVA: 0x002F6890 File Offset: 0x002F4A90
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

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600C6DB RID: 50907 RVA: 0x002F68D0 File Offset: 0x002F4AD0
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

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600C6DC RID: 50908 RVA: 0x002F6910 File Offset: 0x002F4B10
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

		// Token: 0x0600C6DD RID: 50909 RVA: 0x002F6950 File Offset: 0x002F4B50
		public DicIntString? PreloadRoleIds(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x002F69B4 File Offset: 0x002F4BB4
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

		// Token: 0x0600C6DF RID: 50911 RVA: 0x002F69E0 File Offset: 0x002F4BE0
		public int PlotRoleLinkTeam(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x002F6A20 File Offset: 0x002F4C20
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

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x002F6A4C File Offset: 0x002F4C4C
		public Span<int> GetPlotRoleLinkTeamBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x002F6A5C File Offset: 0x002F4C5C
		public int[] GetPlotRoleLinkTeamArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x002F6A74 File Offset: 0x002F4C74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BossInstanceListIter()或GetBossInstanceListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BossInstanceList()
		{
			RogueWhiteCat rogueWhiteCat = this;
			return rogueWhiteCat.GetBossInstanceListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x002F6A98 File Offset: 0x002F4C98
		[NullableContext(1)]
		public readonly IEnumerable<int> BossInstanceListIter()
		{
			RogueWhiteCat.<BossInstanceListIter>d__81 <BossInstanceListIter>d__ = new RogueWhiteCat.<BossInstanceListIter>d__81(-2);
			<BossInstanceListIter>d__.<>3__<>4__this = this;
			return <BossInstanceListIter>d__;
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x002F6AB0 File Offset: 0x002F4CB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BossRewardsIter()或GetBossRewardsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BossRewards()
		{
			RogueWhiteCat rogueWhiteCat = this;
			return rogueWhiteCat.GetBossRewardsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x002F6AD4 File Offset: 0x002F4CD4
		[NullableContext(1)]
		public readonly IEnumerable<int> BossRewardsIter()
		{
			RogueWhiteCat.<BossRewardsIter>d__83 <BossRewardsIter>d__ = new RogueWhiteCat.<BossRewardsIter>d__83(-2);
			<BossRewardsIter>d__.<>3__<>4__this = this;
			return <BossRewardsIter>d__;
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x002F6AEC File Offset: 0x002F4CEC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BossTabTextFrozenDict()缓存字典，遍历请使用BossTabTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> BossTabText()
		{
			return this.BossTabTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x002F6B42 File Offset: 0x002F4D42
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> BossTabTextIter()
		{
			RogueWhiteCat.<BossTabTextIter>d__85 <BossTabTextIter>d__ = new RogueWhiteCat.<BossTabTextIter>d__85(-2);
			<BossTabTextIter>d__.<>3__<>4__this = this;
			return <BossTabTextIter>d__;
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x002F6B58 File Offset: 0x002F4D58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RogueWhiteCat rogueWhiteCat = this;
			return rogueWhiteCat.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x002F6B7C File Offset: 0x002F4D7C
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RogueWhiteCat.<InstsIter>d__87 <InstsIter>d__ = new RogueWhiteCat.<InstsIter>d__87(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x0600C6EB RID: 50923 RVA: 0x002F6B94 File Offset: 0x002F4D94
		[NullableContext(1)]
		[Obsolete("已废弃，请使用OpenConditionFrozenDict()缓存字典，遍历请使用OpenConditionIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> OpenCondition()
		{
			return this.OpenConditionIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x002F6BEA File Offset: 0x002F4DEA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> OpenConditionIter()
		{
			RogueWhiteCat.<OpenConditionIter>d__89 <OpenConditionIter>d__ = new RogueWhiteCat.<OpenConditionIter>d__89(-2);
			<OpenConditionIter>d__.<>3__<>4__this = this;
			return <OpenConditionIter>d__;
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x002F6C00 File Offset: 0x002F4E00
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlotRoleLinkTeamIter()或GetPlotRoleLinkTeamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlotRoleLinkTeam()
		{
			RogueWhiteCat rogueWhiteCat = this;
			return rogueWhiteCat.GetPlotRoleLinkTeamArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x002F6C24 File Offset: 0x002F4E24
		[NullableContext(1)]
		public readonly IEnumerable<int> PlotRoleLinkTeamIter()
		{
			RogueWhiteCat.<PlotRoleLinkTeamIter>d__91 <PlotRoleLinkTeamIter>d__ = new RogueWhiteCat.<PlotRoleLinkTeamIter>d__91(-2);
			<PlotRoleLinkTeamIter>d__.<>3__<>4__this = this;
			return <PlotRoleLinkTeamIter>d__;
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x002F6C3C File Offset: 0x002F4E3C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PreloadRoleIdsFrozenDict()缓存字典，遍历请使用PreloadRoleIdsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> PreloadRoleIds()
		{
			return this.PreloadRoleIdsIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x002F6C92 File Offset: 0x002F4E92
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> PreloadRoleIdsIter()
		{
			RogueWhiteCat.<PreloadRoleIdsIter>d__93 <PreloadRoleIdsIter>d__ = new RogueWhiteCat.<PreloadRoleIdsIter>d__93(-2);
			<PreloadRoleIdsIter>d__.<>3__<>4__this = this;
			return <PreloadRoleIdsIter>d__;
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x002F6CA8 File Offset: 0x002F4EA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardsIter()或GetRewardsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Rewards()
		{
			RogueWhiteCat rogueWhiteCat = this;
			return rogueWhiteCat.GetRewardsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x002F6CCC File Offset: 0x002F4ECC
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardsIter()
		{
			RogueWhiteCat.<RewardsIter>d__95 <RewardsIter>d__ = new RogueWhiteCat.<RewardsIter>d__95(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x002F6CE4 File Offset: 0x002F4EE4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TabIconFrozenDict()缓存字典，遍历请使用TabIconIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TabIcon()
		{
			return this.TabIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6F4 RID: 50932 RVA: 0x002F6D3A File Offset: 0x002F4F3A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TabIconIter()
		{
			RogueWhiteCat.<TabIconIter>d__97 <TabIconIter>d__ = new RogueWhiteCat.<TabIconIter>d__97(-2);
			<TabIconIter>d__.<>3__<>4__this = this;
			return <TabIconIter>d__;
		}

		// Token: 0x0600C6F5 RID: 50933 RVA: 0x002F6D50 File Offset: 0x002F4F50
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TabTextFrozenDict()缓存字典，遍历请使用TabTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TabText()
		{
			return this.TabTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6F6 RID: 50934 RVA: 0x002F6DA6 File Offset: 0x002F4FA6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TabTextIter()
		{
			RogueWhiteCat.<TabTextIter>d__99 <TabTextIter>d__ = new RogueWhiteCat.<TabTextIter>d__99(-2);
			<TabTextIter>d__.<>3__<>4__this = this;
			return <TabTextIter>d__;
		}

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x002F6DBC File Offset: 0x002F4FBC
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

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x002F6DE4 File Offset: 0x002F4FE4
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

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x002F6E18 File Offset: 0x002F5018
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

		// Token: 0x0600C6FA RID: 50938 RVA: 0x002F6E40 File Offset: 0x002F5040
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

		// Token: 0x0600C6FB RID: 50939 RVA: 0x002F6E68 File Offset: 0x002F5068
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

		// Token: 0x0600C6FC RID: 50940 RVA: 0x002F6E90 File Offset: 0x002F5090
		private void EnsureBossTabTextCacheIfNeeded()
		{
			if (this.BossTabTextCache != null)
			{
				return;
			}
			this.BossTabTextCache = this.BossTabTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C6FD RID: 50941 RVA: 0x002F6EF8 File Offset: 0x002F50F8
		private void EnsureOpenConditionCacheIfNeeded()
		{
			if (this.OpenConditionCache != null)
			{
				return;
			}
			this.OpenConditionCache = this.OpenConditionIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x002F6F60 File Offset: 0x002F5160
		private void EnsurePreloadRoleIdsCacheIfNeeded()
		{
			if (this.PreloadRoleIdsCache != null)
			{
				return;
			}
			this.PreloadRoleIdsCache = this.PreloadRoleIdsIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x002F6FC8 File Offset: 0x002F51C8
		private void EnsureTabIconCacheIfNeeded()
		{
			if (this.TabIconCache != null)
			{
				return;
			}
			this.TabIconCache = this.TabIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x002F7030 File Offset: 0x002F5230
		private void EnsureTabTextCacheIfNeeded()
		{
			if (this.TabTextCache != null)
			{
				return;
			}
			this.TabTextCache = this.TabTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x002F7096 File Offset: 0x002F5296
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetBossTabTextFrozenDict(int key)
		{
			this.EnsureBossTabTextCacheIfNeeded();
			return this.BossTabTextCache;
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x002F70A4 File Offset: 0x002F52A4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetOpenConditionFrozenDict(int key)
		{
			this.EnsureOpenConditionCacheIfNeeded();
			return this.OpenConditionCache;
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x002F70B2 File Offset: 0x002F52B2
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetPreloadRoleIdsFrozenDict(int key)
		{
			this.EnsurePreloadRoleIdsCacheIfNeeded();
			return this.PreloadRoleIdsCache;
		}

		// Token: 0x0600C704 RID: 50948 RVA: 0x002F70C0 File Offset: 0x002F52C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTabIconFrozenDict(int key)
		{
			this.EnsureTabIconCacheIfNeeded();
			return this.TabIconCache;
		}

		// Token: 0x0600C705 RID: 50949 RVA: 0x002F70CE File Offset: 0x002F52CE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTabTextFrozenDict(int key)
		{
			this.EnsureTabTextCacheIfNeeded();
			return this.TabTextCache;
		}

		// Token: 0x0400512B RID: 20779
		private Table __p;

		// Token: 0x0400512C RID: 20780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> BossTabTextCache;

		// Token: 0x0400512D RID: 20781
		[Nullable(2)]
		private FrozenDictionary<int, int> OpenConditionCache;

		// Token: 0x0400512E RID: 20782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PreloadRoleIdsCache;

		// Token: 0x0400512F RID: 20783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabIconCache;

		// Token: 0x04005130 RID: 20784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabTextCache;
	}
}
