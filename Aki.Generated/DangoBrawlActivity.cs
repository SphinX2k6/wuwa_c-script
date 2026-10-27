using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBC RID: 3004
	public struct DangoBrawlActivity : IFlatbufferObject
	{
		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06005C9B RID: 23707 RVA: 0x00206D41 File Offset: 0x00204F41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00206D4E File Offset: 0x00204F4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x00206D58 File Offset: 0x00204F58
		public static DangoBrawlActivity GetRootAsDangoBrawlActivity(ByteBuffer _bb)
		{
			return DangoBrawlActivity.GetRootAsDangoBrawlActivity(_bb, default(DangoBrawlActivity));
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x00206D74 File Offset: 0x00204F74
		public static DangoBrawlActivity GetRootAsDangoBrawlActivity(ByteBuffer _bb, DangoBrawlActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00206D91 File Offset: 0x00204F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00206DA0 File Offset: 0x00204FA0
		public DangoBrawlActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06005CA1 RID: 23713 RVA: 0x00206DB0 File Offset: 0x00204FB0
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

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00206DEC File Offset: 0x00204FEC
		public int DangoBrawlGridSize(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x00206E2C File Offset: 0x0020502C
		public int DangoBrawlGridSizeLength
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

		// Token: 0x06005CA4 RID: 23716 RVA: 0x00206E57 File Offset: 0x00205057
		public Span<int> GetDangoBrawlGridSizeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x00206E66 File Offset: 0x00205066
		public int[] GetDangoBrawlGridSizeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x00206E80 File Offset: 0x00205080
		public int DangoBrawlSellDiscount
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

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x00206EBC File Offset: 0x002050BC
		public int HasteBpLimit
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

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x00206EFC File Offset: 0x002050FC
		public int ShopId
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

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06005CA9 RID: 23721 RVA: 0x00206F3C File Offset: 0x0020513C
		public int LimitCoinId
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

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x00206F7C File Offset: 0x0020517C
		public int LimitCoinMax
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

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06005CAB RID: 23723 RVA: 0x00206FBC File Offset: 0x002051BC
		public int ScoreItemId
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

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06005CAC RID: 23724 RVA: 0x00206FFC File Offset: 0x002051FC
		public int MinLuckyCoinPer
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x0020703C File Offset: 0x0020523C
		public int MaxLuckyCoinPer
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

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06005CAE RID: 23726 RVA: 0x0020707C File Offset: 0x0020527C
		public int BenchItemLimit
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x002070BC File Offset: 0x002052BC
		public int BuffLimit
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

		// Token: 0x06005CB0 RID: 23728 RVA: 0x002070FC File Offset: 0x002052FC
		public int DefaultUnlockRoleId(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x0020713C File Offset: 0x0020533C
		public int DefaultUnlockRoleIdLength
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

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00207168 File Offset: 0x00205368
		public Span<int> GetDefaultUnlockRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00207178 File Offset: 0x00205378
		public int[] GetDefaultUnlockRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x00207190 File Offset: 0x00205390
		public int VisionSkinItemId
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

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x002071D0 File Offset: 0x002053D0
		public int LimitScoreRewardId
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

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x00207210 File Offset: 0x00205410
		public int RecommendQuestId
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

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x00207250 File Offset: 0x00205450
		public int RecommendQuestNodeId
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

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06005CB8 RID: 23736 RVA: 0x00207290 File Offset: 0x00205490
		public int RecommendQuestCondition
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

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x002072D0 File Offset: 0x002054D0
		public string RecommendQuestLabel
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

		// Token: 0x06005CBA RID: 23738 RVA: 0x00207308 File Offset: 0x00205508
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00207318 File Offset: 0x00205518
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00207330 File Offset: 0x00205530
		public int MainRoleList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x00207370 File Offset: 0x00205570
		public int MainRoleListLength
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

		// Token: 0x06005CBE RID: 23742 RVA: 0x0020739C File Offset: 0x0020559C
		public Span<int> GetMainRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x002073AC File Offset: 0x002055AC
		public int[] GetMainRoleListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x002073C4 File Offset: 0x002055C4
		public DicIntInt? MainRoleSexChange(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x00207428 File Offset: 0x00205628
		public int MainRoleSexChangeLength
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

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x00207454 File Offset: 0x00205654
		public int DamageTxtNormal
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

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x00207494 File Offset: 0x00205694
		public int DamageTxtHeal
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

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06005CC4 RID: 23748 RVA: 0x002074D4 File Offset: 0x002056D4
		public int DamageTxtShield
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x00207514 File Offset: 0x00205714
		public int DamageTxtLifeSteal
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06005CC6 RID: 23750 RVA: 0x00207554 File Offset: 0x00205754
		public int CoinText
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x00207594 File Offset: 0x00205794
		public int ShopTipsTalkGapTime
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06005CC8 RID: 23752 RVA: 0x002075D4 File Offset: 0x002057D4
		public int ShopWeaponTalkQuality
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x00207614 File Offset: 0x00205814
		public int StartFightDuringTime
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

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06005CCA RID: 23754 RVA: 0x00207654 File Offset: 0x00205854
		public int HpChangeColor
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

		// Token: 0x06005CCB RID: 23755 RVA: 0x00207694 File Offset: 0x00205894
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DangoBrawlGridSizeIter()或GetDangoBrawlGridSizeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DangoBrawlGridSize()
		{
			DangoBrawlActivity dangoBrawlActivity = this;
			return dangoBrawlActivity.GetDangoBrawlGridSizeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x002076B8 File Offset: 0x002058B8
		[NullableContext(1)]
		public readonly IEnumerable<int> DangoBrawlGridSizeIter()
		{
			DangoBrawlActivity.<DangoBrawlGridSizeIter>d__81 <DangoBrawlGridSizeIter>d__ = new DangoBrawlActivity.<DangoBrawlGridSizeIter>d__81(-2);
			<DangoBrawlGridSizeIter>d__.<>3__<>4__this = this;
			return <DangoBrawlGridSizeIter>d__;
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x002076D0 File Offset: 0x002058D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DefaultUnlockRoleIdIter()或GetDefaultUnlockRoleIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DefaultUnlockRoleId()
		{
			DangoBrawlActivity dangoBrawlActivity = this;
			return dangoBrawlActivity.GetDefaultUnlockRoleIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x002076F4 File Offset: 0x002058F4
		[NullableContext(1)]
		public readonly IEnumerable<int> DefaultUnlockRoleIdIter()
		{
			DangoBrawlActivity.<DefaultUnlockRoleIdIter>d__83 <DefaultUnlockRoleIdIter>d__ = new DangoBrawlActivity.<DefaultUnlockRoleIdIter>d__83(-2);
			<DefaultUnlockRoleIdIter>d__.<>3__<>4__this = this;
			return <DefaultUnlockRoleIdIter>d__;
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x0020770C File Offset: 0x0020590C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainRoleListIter()或GetMainRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainRoleList()
		{
			DangoBrawlActivity dangoBrawlActivity = this;
			return dangoBrawlActivity.GetMainRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00207730 File Offset: 0x00205930
		[NullableContext(1)]
		public readonly IEnumerable<int> MainRoleListIter()
		{
			DangoBrawlActivity.<MainRoleListIter>d__85 <MainRoleListIter>d__ = new DangoBrawlActivity.<MainRoleListIter>d__85(-2);
			<MainRoleListIter>d__.<>3__<>4__this = this;
			return <MainRoleListIter>d__;
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00207748 File Offset: 0x00205948
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MainRoleSexChangeFrozenDict()缓存字典，遍历请使用MainRoleSexChangeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MainRoleSexChange()
		{
			return this.MainRoleSexChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x0020779E File Offset: 0x0020599E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MainRoleSexChangeIter()
		{
			DangoBrawlActivity.<MainRoleSexChangeIter>d__87 <MainRoleSexChangeIter>d__ = new DangoBrawlActivity.<MainRoleSexChangeIter>d__87(-2);
			<MainRoleSexChangeIter>d__.<>3__<>4__this = this;
			return <MainRoleSexChangeIter>d__;
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x002077B4 File Offset: 0x002059B4
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

		// Token: 0x06005CD4 RID: 23764 RVA: 0x002077E8 File Offset: 0x002059E8
		private void EnsureMainRoleSexChangeCacheIfNeeded()
		{
			if (this.MainRoleSexChangeCache != null)
			{
				return;
			}
			this.MainRoleSexChangeCache = this.MainRoleSexChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x0020784E File Offset: 0x00205A4E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMainRoleSexChangeFrozenDict(int key)
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			return this.MainRoleSexChangeCache;
		}

		// Token: 0x04004BE2 RID: 19426
		private Table __p;

		// Token: 0x04004BE3 RID: 19427
		[Nullable(2)]
		private FrozenDictionary<int, int> MainRoleSexChangeCache;
	}
}
