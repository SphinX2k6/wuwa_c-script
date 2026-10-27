using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C56 RID: 3158
	public struct ExploreTools : IFlatbufferObject
	{
		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06006BF8 RID: 27640 RVA: 0x0022972D File Offset: 0x0022792D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x0022973A File Offset: 0x0022793A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x00229744 File Offset: 0x00227944
		public static ExploreTools GetRootAsExploreTools(ByteBuffer _bb)
		{
			return ExploreTools.GetRootAsExploreTools(_bb, default(ExploreTools));
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00229760 File Offset: 0x00227960
		public static ExploreTools GetRootAsExploreTools(ByteBuffer _bb, ExploreTools obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x0022977D File Offset: 0x0022797D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x0022978C File Offset: 0x0022798C
		public ExploreTools __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x0022979C File Offset: 0x0022799C
		public int PhantomSkillId
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

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x002297D8 File Offset: 0x002279D8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x0022980F File Offset: 0x00227A0F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x0022981E File Offset: 0x00227A1E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06006C02 RID: 27650 RVA: 0x00229838 File Offset: 0x00227A38
		public int SkillType
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

		// Token: 0x06006C03 RID: 27651 RVA: 0x00229874 File Offset: 0x00227A74
		public int RouletteType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06006C04 RID: 27652 RVA: 0x002298B4 File Offset: 0x00227AB4
		public int RouletteTypeLength
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

		// Token: 0x06006C05 RID: 27653 RVA: 0x002298E0 File Offset: 0x00227AE0
		public Span<int> GetRouletteTypeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x002298F0 File Offset: 0x00227AF0
		public int[] GetRouletteTypeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06006C07 RID: 27655 RVA: 0x00229908 File Offset: 0x00227B08
		public bool CanEquip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06006C08 RID: 27656 RVA: 0x00229948 File Offset: 0x00227B48
		public bool AssemblyEquipButton
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06006C09 RID: 27657 RVA: 0x00229988 File Offset: 0x00227B88
		public bool CanAssemblyShow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06006C0A RID: 27658 RVA: 0x002299C8 File Offset: 0x00227BC8
		public int UseType
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

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x00229A08 File Offset: 0x00227C08
		public bool InputLogReport
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06006C0C RID: 27660 RVA: 0x00229A48 File Offset: 0x00227C48
		public string CurrentSkillInfo
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00229A80 File Offset: 0x00227C80
		public Span<byte> GetCurrentSkillInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00229A90 File Offset: 0x00227C90
		public byte[] GetCurrentSkillInfoArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00229AA8 File Offset: 0x00227CA8
		public int HelpId
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

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x00229AE8 File Offset: 0x00227CE8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x00229B20 File Offset: 0x00227D20
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x00229B30 File Offset: 0x00227D30
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06006C13 RID: 27667 RVA: 0x00229B48 File Offset: 0x00227D48
		public string BackGround
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

		// Token: 0x06006C14 RID: 27668 RVA: 0x00229B80 File Offset: 0x00227D80
		public Span<byte> GetBackGroundBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00229B90 File Offset: 0x00227D90
		public byte[] GetBackGroundArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06006C16 RID: 27670 RVA: 0x00229BA8 File Offset: 0x00227DA8
		public string BattleViewIcon
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

		// Token: 0x06006C17 RID: 27671 RVA: 0x00229BE0 File Offset: 0x00227DE0
		public Span<byte> GetBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00229BF0 File Offset: 0x00227DF0
		public byte[] GetBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06006C19 RID: 27673 RVA: 0x00229C08 File Offset: 0x00227E08
		public int SortId
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

		// Token: 0x06006C1A RID: 27674 RVA: 0x00229C48 File Offset: 0x00227E48
		public DicIntInt? Sort(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x00229CAC File Offset: 0x00227EAC
		public int SortLength
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06006C1C RID: 27676 RVA: 0x00229CD8 File Offset: 0x00227ED8
		public bool AutoFill
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x00229D18 File Offset: 0x00227F18
		public bool ShowUnlock
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x00229D58 File Offset: 0x00227F58
		public int SkillGroupId
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x00229D98 File Offset: 0x00227F98
		public bool IsUseInPhantomTeam
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x00229DD8 File Offset: 0x00227FD8
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x00229E3C File Offset: 0x0022803C
		public int CostLength
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

		// Token: 0x06006C22 RID: 27682 RVA: 0x00229E68 File Offset: 0x00228068
		public DicIntInt? Authorization(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x00229ECC File Offset: 0x002280CC
		public int AuthorizationLength
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x00229EF8 File Offset: 0x002280F8
		public int SummonConfigId
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

		// Token: 0x06006C25 RID: 27685 RVA: 0x00229F38 File Offset: 0x00228138
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AuthorizationFrozenDict()缓存字典，遍历请使用AuthorizationIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Authorization()
		{
			return this.AuthorizationIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x00229F8E File Offset: 0x0022818E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> AuthorizationIter()
		{
			ExploreTools.<AuthorizationIter>d__71 <AuthorizationIter>d__ = new ExploreTools.<AuthorizationIter>d__71(-2);
			<AuthorizationIter>d__.<>3__<>4__this = this;
			return <AuthorizationIter>d__;
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x00229FA4 File Offset: 0x002281A4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostFrozenDict()缓存字典，遍历请使用CostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00229FFA File Offset: 0x002281FA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostIter()
		{
			ExploreTools.<CostIter>d__73 <CostIter>d__ = new ExploreTools.<CostIter>d__73(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x0022A010 File Offset: 0x00228210
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RouletteTypeIter()或GetRouletteTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RouletteType()
		{
			ExploreTools exploreTools = this;
			return exploreTools.GetRouletteTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x0022A034 File Offset: 0x00228234
		[NullableContext(1)]
		public readonly IEnumerable<int> RouletteTypeIter()
		{
			ExploreTools.<RouletteTypeIter>d__75 <RouletteTypeIter>d__ = new ExploreTools.<RouletteTypeIter>d__75(-2);
			<RouletteTypeIter>d__.<>3__<>4__this = this;
			return <RouletteTypeIter>d__;
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x0022A04C File Offset: 0x0022824C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SortFrozenDict()缓存字典，遍历请使用SortIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Sort()
		{
			return this.SortIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x0022A0A2 File Offset: 0x002282A2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SortIter()
		{
			ExploreTools.<SortIter>d__77 <SortIter>d__ = new ExploreTools.<SortIter>d__77(-2);
			<SortIter>d__.<>3__<>4__this = this;
			return <SortIter>d__;
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x0022A0B8 File Offset: 0x002282B8
		public int? GetAuthorization(int key)
		{
			this.EnsureAuthorizationCacheIfNeeded();
			int value;
			if (!this.AuthorizationCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x0022A0EC File Offset: 0x002282EC
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x0022A120 File Offset: 0x00228320
		public int? GetSort(int key)
		{
			this.EnsureSortCacheIfNeeded();
			int value;
			if (!this.SortCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x0022A154 File Offset: 0x00228354
		private void EnsureAuthorizationCacheIfNeeded()
		{
			if (this.AuthorizationCache != null)
			{
				return;
			}
			this.AuthorizationCache = this.AuthorizationIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x0022A1BC File Offset: 0x002283BC
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x0022A224 File Offset: 0x00228424
		private void EnsureSortCacheIfNeeded()
		{
			if (this.SortCache != null)
			{
				return;
			}
			this.SortCache = this.SortIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x0022A28A File Offset: 0x0022848A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetAuthorizationFrozenDict(int key)
		{
			this.EnsureAuthorizationCacheIfNeeded();
			return this.AuthorizationCache;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x0022A298 File Offset: 0x00228498
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostFrozenDict(int key)
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x0022A2A6 File Offset: 0x002284A6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSortFrozenDict(int key)
		{
			this.EnsureSortCacheIfNeeded();
			return this.SortCache;
		}

		// Token: 0x04004C9E RID: 19614
		private Table __p;

		// Token: 0x04004C9F RID: 19615
		[Nullable(2)]
		private FrozenDictionary<int, int> AuthorizationCache;

		// Token: 0x04004CA0 RID: 19616
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;

		// Token: 0x04004CA1 RID: 19617
		[Nullable(2)]
		private FrozenDictionary<int, int> SortCache;
	}
}
