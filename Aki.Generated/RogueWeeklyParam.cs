using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102D RID: 4141
	public struct RogueWeeklyParam : IFlatbufferObject
	{
		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600C62D RID: 50733 RVA: 0x002F4E7C File Offset: 0x002F307C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x002F4E89 File Offset: 0x002F3089
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x002F4E90 File Offset: 0x002F3090
		public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb)
		{
			return RogueWeeklyParam.GetRootAsRogueWeeklyParam(_bb, default(RogueWeeklyParam));
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x002F4EAC File Offset: 0x002F30AC
		public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb, RogueWeeklyParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x002F4EC9 File Offset: 0x002F30C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x002F4ED8 File Offset: 0x002F30D8
		public RogueWeeklyParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600C633 RID: 50739 RVA: 0x002F4EE8 File Offset: 0x002F30E8
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

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600C634 RID: 50740 RVA: 0x002F4F24 File Offset: 0x002F3124
		public string RoguelikeSettleBgS
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

		// Token: 0x0600C635 RID: 50741 RVA: 0x002F4F5B File Offset: 0x002F315B
		public Span<byte> GetRoguelikeSettleBgSBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C636 RID: 50742 RVA: 0x002F4F6A File Offset: 0x002F316A
		public byte[] GetRoguelikeSettleBgSArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600C637 RID: 50743 RVA: 0x002F4F84 File Offset: 0x002F3184
		public string RoguelikeSettleBgNormal
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x002F4FBB File Offset: 0x002F31BB
		public Span<byte> GetRoguelikeSettleBgNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C639 RID: 50745 RVA: 0x002F4FCA File Offset: 0x002F31CA
		public byte[] GetRoguelikeSettleBgNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600C63A RID: 50746 RVA: 0x002F4FE4 File Offset: 0x002F31E4
		public string RoguelikeRoomFloatTipsNoHeadIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x002F501C File Offset: 0x002F321C
		public Span<byte> GetRoguelikeRoomFloatTipsNoHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C63C RID: 50748 RVA: 0x002F502C File Offset: 0x002F322C
		public byte[] GetRoguelikeRoomFloatTipsNoHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600C63D RID: 50749 RVA: 0x002F5044 File Offset: 0x002F3244
		public string RoguelikeRoomFloatTipsSpecialIcon
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

		// Token: 0x0600C63E RID: 50750 RVA: 0x002F507C File Offset: 0x002F327C
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x002F508C File Offset: 0x002F328C
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600C640 RID: 50752 RVA: 0x002F50A4 File Offset: 0x002F32A4
		public int RoguelikeSettleS
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

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600C641 RID: 50753 RVA: 0x002F50E4 File Offset: 0x002F32E4
		public int RoguelikeSettleA
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

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600C642 RID: 50754 RVA: 0x002F5124 File Offset: 0x002F3324
		public int RoguelikeSettleB
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

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600C643 RID: 50755 RVA: 0x002F5164 File Offset: 0x002F3364
		public int RoguelikeSettleC
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

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600C644 RID: 50756 RVA: 0x002F51A4 File Offset: 0x002F33A4
		public int PointItem
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

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600C645 RID: 50757 RVA: 0x002F51E4 File Offset: 0x002F33E4
		public int PointItemMaxCount
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

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600C646 RID: 50758 RVA: 0x002F5224 File Offset: 0x002F3424
		public int TokenItem
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

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600C647 RID: 50759 RVA: 0x002F5264 File Offset: 0x002F3464
		public int WeekTokenMaxCount
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

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600C648 RID: 50760 RVA: 0x002F52A4 File Offset: 0x002F34A4
		public int InsideCurrency
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

		// Token: 0x0600C649 RID: 50761 RVA: 0x002F52E4 File Offset: 0x002F34E4
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600C64A RID: 50762 RVA: 0x002F5324 File Offset: 0x002F3524
		public int DungeonListLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x002F5350 File Offset: 0x002F3550
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x002F5360 File Offset: 0x002F3560
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x002F5378 File Offset: 0x002F3578
		public DicIntInt? ValidRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600C64E RID: 50766 RVA: 0x002F53DC File Offset: 0x002F35DC
		public int ValidRoleOpenTimeMapLength
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

		// Token: 0x0600C64F RID: 50767 RVA: 0x002F5408 File Offset: 0x002F3608
		public DicIntInt? DungeonRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600C650 RID: 50768 RVA: 0x002F546C File Offset: 0x002F366C
		public int DungeonRoleOpenTimeMapLength
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

		// Token: 0x0600C651 RID: 50769 RVA: 0x002F5498 File Offset: 0x002F3698
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonListIter()或GetDungeonListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonList()
		{
			RogueWeeklyParam rogueWeeklyParam = this;
			return rogueWeeklyParam.GetDungeonListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x002F54BC File Offset: 0x002F36BC
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonListIter()
		{
			RogueWeeklyParam.<DungeonListIter>d__56 <DungeonListIter>d__ = new RogueWeeklyParam.<DungeonListIter>d__56(-2);
			<DungeonListIter>d__.<>3__<>4__this = this;
			return <DungeonListIter>d__;
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x002F54D4 File Offset: 0x002F36D4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DungeonRoleOpenTimeMapFrozenDict()缓存字典，遍历请使用DungeonRoleOpenTimeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DungeonRoleOpenTimeMap()
		{
			return this.DungeonRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x002F552A File Offset: 0x002F372A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DungeonRoleOpenTimeMapIter()
		{
			RogueWeeklyParam.<DungeonRoleOpenTimeMapIter>d__58 <DungeonRoleOpenTimeMapIter>d__ = new RogueWeeklyParam.<DungeonRoleOpenTimeMapIter>d__58(-2);
			<DungeonRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <DungeonRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x002F5540 File Offset: 0x002F3740
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ValidRoleOpenTimeMapFrozenDict()缓存字典，遍历请使用ValidRoleOpenTimeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ValidRoleOpenTimeMap()
		{
			return this.ValidRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x002F5596 File Offset: 0x002F3796
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ValidRoleOpenTimeMapIter()
		{
			RogueWeeklyParam.<ValidRoleOpenTimeMapIter>d__60 <ValidRoleOpenTimeMapIter>d__ = new RogueWeeklyParam.<ValidRoleOpenTimeMapIter>d__60(-2);
			<ValidRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <ValidRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x002F55AC File Offset: 0x002F37AC
		public int? GetDungeonRoleOpenTimeMap(int key)
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.DungeonRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x002F55E0 File Offset: 0x002F37E0
		public int? GetValidRoleOpenTimeMap(int key)
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.ValidRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x002F5614 File Offset: 0x002F3814
		private void EnsureDungeonRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.DungeonRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.DungeonRoleOpenTimeMapCache = this.DungeonRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x002F567C File Offset: 0x002F387C
		private void EnsureValidRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.ValidRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.ValidRoleOpenTimeMapCache = this.ValidRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x002F56E2 File Offset: 0x002F38E2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDungeonRoleOpenTimeMapFrozenDict(int key)
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			return this.DungeonRoleOpenTimeMapCache;
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x002F56F0 File Offset: 0x002F38F0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetValidRoleOpenTimeMapFrozenDict(int key)
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			return this.ValidRoleOpenTimeMapCache;
		}

		// Token: 0x04005123 RID: 20771
		private Table __p;

		// Token: 0x04005124 RID: 20772
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonRoleOpenTimeMapCache;

		// Token: 0x04005125 RID: 20773
		[Nullable(2)]
		private FrozenDictionary<int, int> ValidRoleOpenTimeMapCache;
	}
}
