using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B31 RID: 2865
	public struct BehaviorCommonButton : IFlatbufferObject
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06004D04 RID: 19716 RVA: 0x001E2FF5 File Offset: 0x001E11F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x001E3002 File Offset: 0x001E1202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x001E300C File Offset: 0x001E120C
		public static BehaviorCommonButton GetRootAsBehaviorCommonButton(ByteBuffer _bb)
		{
			return BehaviorCommonButton.GetRootAsBehaviorCommonButton(_bb, default(BehaviorCommonButton));
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x001E3028 File Offset: 0x001E1228
		public static BehaviorCommonButton GetRootAsBehaviorCommonButton(ByteBuffer _bb, BehaviorCommonButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x001E3045 File Offset: 0x001E1245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x001E3054 File Offset: 0x001E1254
		public BehaviorCommonButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x001E3064 File Offset: 0x001E1264
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x001E30A0 File Offset: 0x001E12A0
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

		// Token: 0x06004D0C RID: 19724 RVA: 0x001E30D7 File Offset: 0x001E12D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x001E30E6 File Offset: 0x001E12E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x001E3100 File Offset: 0x001E1300
		public int ButtonType
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x001E313C File Offset: 0x001E133C
		public int ActionType
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x001E317C File Offset: 0x001E137C
		public int SkillId
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

		// Token: 0x06004D11 RID: 19729 RVA: 0x001E31BC File Offset: 0x001E13BC
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x001E3220 File Offset: 0x001E1420
		public int SkillIdTagMapLength
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

		// Token: 0x06004D13 RID: 19731 RVA: 0x001E324C File Offset: 0x001E144C
		public string SkillIcons(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06004D14 RID: 19732 RVA: 0x001E3288 File Offset: 0x001E1488
		public int SkillIconsLength
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

		// Token: 0x06004D15 RID: 19733 RVA: 0x001E32B4 File Offset: 0x001E14B4
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06004D16 RID: 19734 RVA: 0x001E32F4 File Offset: 0x001E14F4
		public int SkillIconTagsLength
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

		// Token: 0x06004D17 RID: 19735 RVA: 0x001E3320 File Offset: 0x001E1520
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x001E3330 File Offset: 0x001E1530
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x001E3348 File Offset: 0x001E1548
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06004D1A RID: 19738 RVA: 0x001E3388 File Offset: 0x001E1588
		public int DisableTagsLength
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

		// Token: 0x06004D1B RID: 19739 RVA: 0x001E33B4 File Offset: 0x001E15B4
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x001E33C4 File Offset: 0x001E15C4
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x001E33DC File Offset: 0x001E15DC
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06004D1E RID: 19742 RVA: 0x001E3440 File Offset: 0x001E1640
		public int DisableSkillIdTagsLength
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

		// Token: 0x06004D1F RID: 19743 RVA: 0x001E346C File Offset: 0x001E166C
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x001E34AC File Offset: 0x001E16AC
		public int VisibleTagsLength
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

		// Token: 0x06004D21 RID: 19745 RVA: 0x001E34D8 File Offset: 0x001E16D8
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x001E34E8 File Offset: 0x001E16E8
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001E3500 File Offset: 0x001E1700
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06004D24 RID: 19748 RVA: 0x001E3540 File Offset: 0x001E1740
		public int HiddenTagsLength
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

		// Token: 0x06004D25 RID: 19749 RVA: 0x001E356C File Offset: 0x001E176C
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x001E357C File Offset: 0x001E177C
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x001E3594 File Offset: 0x001E1794
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06004D28 RID: 19752 RVA: 0x001E35F8 File Offset: 0x001E17F8
		public int DynamicEffectTagMapLength
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

		// Token: 0x06004D29 RID: 19753 RVA: 0x001E3624 File Offset: 0x001E1824
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x001E367A File Offset: 0x001E187A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			BehaviorCommonButton.<DisableSkillIdTagsIter>d__53 <DisableSkillIdTagsIter>d__ = new BehaviorCommonButton.<DisableSkillIdTagsIter>d__53(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x001E3690 File Offset: 0x001E1890
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			BehaviorCommonButton behaviorCommonButton = this;
			return behaviorCommonButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x001E36B4 File Offset: 0x001E18B4
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			BehaviorCommonButton.<DisableTagsIter>d__55 <DisableTagsIter>d__ = new BehaviorCommonButton.<DisableTagsIter>d__55(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x001E36CC File Offset: 0x001E18CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x001E3722 File Offset: 0x001E1922
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			BehaviorCommonButton.<DynamicEffectTagMapIter>d__57 <DynamicEffectTagMapIter>d__ = new BehaviorCommonButton.<DynamicEffectTagMapIter>d__57(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001E3738 File Offset: 0x001E1938
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenTagsIter()或GetHiddenTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HiddenTags()
		{
			BehaviorCommonButton behaviorCommonButton = this;
			return behaviorCommonButton.GetHiddenTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x001E375C File Offset: 0x001E195C
		[NullableContext(1)]
		public readonly IEnumerable<int> HiddenTagsIter()
		{
			BehaviorCommonButton.<HiddenTagsIter>d__59 <HiddenTagsIter>d__ = new BehaviorCommonButton.<HiddenTagsIter>d__59(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x001E3774 File Offset: 0x001E1974
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			BehaviorCommonButton behaviorCommonButton = this;
			return behaviorCommonButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x001E3798 File Offset: 0x001E1998
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			BehaviorCommonButton.<SkillIconTagsIter>d__61 <SkillIconTagsIter>d__ = new BehaviorCommonButton.<SkillIconTagsIter>d__61(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x001E37AD File Offset: 0x001E19AD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconsIter()或GetSkillIconsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillIcons()
		{
			return this.SkillIconsIter().ToArray<string>();
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x001E37BA File Offset: 0x001E19BA
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillIconsIter()
		{
			BehaviorCommonButton.<SkillIconsIter>d__63 <SkillIconsIter>d__ = new BehaviorCommonButton.<SkillIconsIter>d__63(-2);
			<SkillIconsIter>d__.<>3__<>4__this = this;
			return <SkillIconsIter>d__;
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001E37D0 File Offset: 0x001E19D0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x001E3826 File Offset: 0x001E1A26
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			BehaviorCommonButton.<SkillIdTagMapIter>d__65 <SkillIdTagMapIter>d__ = new BehaviorCommonButton.<SkillIdTagMapIter>d__65(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x001E383C File Offset: 0x001E1A3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisibleTagsIter()或GetVisibleTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] VisibleTags()
		{
			BehaviorCommonButton behaviorCommonButton = this;
			return behaviorCommonButton.GetVisibleTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x001E3860 File Offset: 0x001E1A60
		[NullableContext(1)]
		public readonly IEnumerable<int> VisibleTagsIter()
		{
			BehaviorCommonButton.<VisibleTagsIter>d__67 <VisibleTagsIter>d__ = new BehaviorCommonButton.<VisibleTagsIter>d__67(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x001E3878 File Offset: 0x001E1A78
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x001E38AC File Offset: 0x001E1AAC
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x001E38E0 File Offset: 0x001E1AE0
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001E3914 File Offset: 0x001E1B14
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x001E397C File Offset: 0x001E1B7C
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x001E39E4 File Offset: 0x001E1BE4
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x001E3A4A File Offset: 0x001E1C4A
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x001E3A58 File Offset: 0x001E1C58
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x001E3A66 File Offset: 0x001E1C66
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x04004B29 RID: 19241
		private Table __p;

		// Token: 0x04004B2A RID: 19242
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x04004B2B RID: 19243
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x04004B2C RID: 19244
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
