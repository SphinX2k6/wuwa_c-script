using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BA RID: 4282
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillButtonIndex : IFlatbufferObject
	{
		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600D3D4 RID: 54228 RVA: 0x00313EB1 File Offset: 0x003120B1
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x00313EBE File Offset: 0x003120BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x00313EC8 File Offset: 0x003120C8
		[NullableContext(0)]
		public static SkillButtonIndex GetRootAsSkillButtonIndex(ByteBuffer _bb)
		{
			return SkillButtonIndex.GetRootAsSkillButtonIndex(_bb, default(SkillButtonIndex));
		}

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x00313EE4 File Offset: 0x003120E4
		[NullableContext(0)]
		public static SkillButtonIndex GetRootAsSkillButtonIndex(ByteBuffer _bb, SkillButtonIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x00313F01 File Offset: 0x00312101
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x00313F10 File Offset: 0x00312110
		[NullableContext(0)]
		public SkillButtonIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600D3DA RID: 54234 RVA: 0x00313F20 File Offset: 0x00312120
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

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x00313F5C File Offset: 0x0031215C
		public int RoleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D3DC RID: 54236 RVA: 0x00313F98 File Offset: 0x00312198
		public int DesktopButtonTypeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600D3DD RID: 54237 RVA: 0x00313FD8 File Offset: 0x003121D8
		public int DesktopButtonTypeListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D3DE RID: 54238 RVA: 0x00314003 File Offset: 0x00312203
		[NullableContext(0)]
		public Span<int> GetDesktopButtonTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D3DF RID: 54239 RVA: 0x00314012 File Offset: 0x00312212
		[NullableContext(0)]
		public int[] GetDesktopButtonTypeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D3E0 RID: 54240 RVA: 0x0031402C File Offset: 0x0031222C
		public int PadButtonTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x0031406C File Offset: 0x0031226C
		public int PadButtonTypeListLength
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

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x00314098 File Offset: 0x00312298
		[NullableContext(0)]
		public Span<int> GetPadButtonTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x003140A8 File Offset: 0x003122A8
		[NullableContext(0)]
		public int[] GetPadButtonTypeListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x003140C0 File Offset: 0x003122C0
		public GameplayTagArray? TagList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new GameplayTagArray?(default(GameplayTagArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x00314124 File Offset: 0x00312324
		public int TagListLength
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

		// Token: 0x0600D3E6 RID: 54246 RVA: 0x00314150 File Offset: 0x00312350
		public IntArray? TagDesktopButtonTypeList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600D3E7 RID: 54247 RVA: 0x003141B4 File Offset: 0x003123B4
		public int TagDesktopButtonTypeListLength
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

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x003141E0 File Offset: 0x003123E0
		public IntArray? TagPadButtonTypeList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600D3E9 RID: 54249 RVA: 0x00314244 File Offset: 0x00312444
		public int TagPadButtonTypeListLength
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

		// Token: 0x0600D3EA RID: 54250 RVA: 0x00314270 File Offset: 0x00312470
		public DicIntIntArray? DesktopButtonTypeMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600D3EB RID: 54251 RVA: 0x003142D4 File Offset: 0x003124D4
		public int DesktopButtonTypeMapLength
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

		// Token: 0x0600D3EC RID: 54252 RVA: 0x00314300 File Offset: 0x00312500
		public DicIntIntArray? PadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x00314364 File Offset: 0x00312564
		public int PadButtonTypeMapLength
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

		// Token: 0x0600D3EE RID: 54254 RVA: 0x00314390 File Offset: 0x00312590
		public DicIntIntArray? GamepadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x003143F4 File Offset: 0x003125F4
		public int GamepadButtonTypeMapLength
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

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x00314420 File Offset: 0x00312620
		public DicIntIntArray? MotorPadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600D3F1 RID: 54257 RVA: 0x00314484 File Offset: 0x00312684
		public int MotorPadButtonTypeMapLength
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

		// Token: 0x0600D3F2 RID: 54258 RVA: 0x003144B0 File Offset: 0x003126B0
		public DicIntIntArray? MotorJoystickPadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600D3F3 RID: 54259 RVA: 0x00314514 File Offset: 0x00312714
		public int MotorJoystickPadButtonTypeMapLength
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

		// Token: 0x0600D3F4 RID: 54260 RVA: 0x00314540 File Offset: 0x00312740
		[Obsolete("本方法用于缓存,遍历请使用DesktopButtonTypeListIter()或GetDesktopButtonTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DesktopButtonTypeList()
		{
			SkillButtonIndex skillButtonIndex = this;
			return skillButtonIndex.GetDesktopButtonTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D3F5 RID: 54261 RVA: 0x00314564 File Offset: 0x00312764
		public readonly IEnumerable<int> DesktopButtonTypeListIter()
		{
			SkillButtonIndex.<DesktopButtonTypeListIter>d__47 <DesktopButtonTypeListIter>d__ = new SkillButtonIndex.<DesktopButtonTypeListIter>d__47(-2);
			<DesktopButtonTypeListIter>d__.<>3__<>4__this = this;
			return <DesktopButtonTypeListIter>d__;
		}

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x0031457C File Offset: 0x0031277C
		[Obsolete("已废弃，请使用DesktopButtonTypeMapFrozenDict()缓存字典，遍历请使用DesktopButtonTypeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DesktopButtonTypeMap()
		{
			return this.DesktopButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x003145D2 File Offset: 0x003127D2
		public readonly IEnumerable<DicIntIntArray> DesktopButtonTypeMapIter()
		{
			SkillButtonIndex.<DesktopButtonTypeMapIter>d__49 <DesktopButtonTypeMapIter>d__ = new SkillButtonIndex.<DesktopButtonTypeMapIter>d__49(-2);
			<DesktopButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <DesktopButtonTypeMapIter>d__;
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x003145E8 File Offset: 0x003127E8
		[Obsolete("已废弃，请使用GamepadButtonTypeMapFrozenDict()缓存字典，遍历请使用GamepadButtonTypeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> GamepadButtonTypeMap()
		{
			return this.GamepadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x0031463E File Offset: 0x0031283E
		public readonly IEnumerable<DicIntIntArray> GamepadButtonTypeMapIter()
		{
			SkillButtonIndex.<GamepadButtonTypeMapIter>d__51 <GamepadButtonTypeMapIter>d__ = new SkillButtonIndex.<GamepadButtonTypeMapIter>d__51(-2);
			<GamepadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <GamepadButtonTypeMapIter>d__;
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x00314654 File Offset: 0x00312854
		[Obsolete("已废弃，请使用MotorJoystickPadButtonTypeMapFrozenDict()缓存字典，遍历请使用MotorJoystickPadButtonTypeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> MotorJoystickPadButtonTypeMap()
		{
			return this.MotorJoystickPadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x003146AA File Offset: 0x003128AA
		public readonly IEnumerable<DicIntIntArray> MotorJoystickPadButtonTypeMapIter()
		{
			SkillButtonIndex.<MotorJoystickPadButtonTypeMapIter>d__53 <MotorJoystickPadButtonTypeMapIter>d__ = new SkillButtonIndex.<MotorJoystickPadButtonTypeMapIter>d__53(-2);
			<MotorJoystickPadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <MotorJoystickPadButtonTypeMapIter>d__;
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x003146C0 File Offset: 0x003128C0
		[Obsolete("已废弃，请使用MotorPadButtonTypeMapFrozenDict()缓存字典，遍历请使用MotorPadButtonTypeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> MotorPadButtonTypeMap()
		{
			return this.MotorPadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x00314716 File Offset: 0x00312916
		public readonly IEnumerable<DicIntIntArray> MotorPadButtonTypeMapIter()
		{
			SkillButtonIndex.<MotorPadButtonTypeMapIter>d__55 <MotorPadButtonTypeMapIter>d__ = new SkillButtonIndex.<MotorPadButtonTypeMapIter>d__55(-2);
			<MotorPadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <MotorPadButtonTypeMapIter>d__;
		}

		// Token: 0x0600D3FE RID: 54270 RVA: 0x0031472C File Offset: 0x0031292C
		[Obsolete("本方法用于缓存,遍历请使用PadButtonTypeListIter()或GetPadButtonTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PadButtonTypeList()
		{
			SkillButtonIndex skillButtonIndex = this;
			return skillButtonIndex.GetPadButtonTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x00314750 File Offset: 0x00312950
		public readonly IEnumerable<int> PadButtonTypeListIter()
		{
			SkillButtonIndex.<PadButtonTypeListIter>d__57 <PadButtonTypeListIter>d__ = new SkillButtonIndex.<PadButtonTypeListIter>d__57(-2);
			<PadButtonTypeListIter>d__.<>3__<>4__this = this;
			return <PadButtonTypeListIter>d__;
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x00314768 File Offset: 0x00312968
		[Obsolete("已废弃，请使用PadButtonTypeMapFrozenDict()缓存字典，遍历请使用PadButtonTypeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> PadButtonTypeMap()
		{
			return this.PadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x003147BE File Offset: 0x003129BE
		public readonly IEnumerable<DicIntIntArray> PadButtonTypeMapIter()
		{
			SkillButtonIndex.<PadButtonTypeMapIter>d__59 <PadButtonTypeMapIter>d__ = new SkillButtonIndex.<PadButtonTypeMapIter>d__59(-2);
			<PadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <PadButtonTypeMapIter>d__;
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x003147D3 File Offset: 0x003129D3
		[Obsolete("本方法用于缓存,遍历请使用TagDesktopButtonTypeListIter()或GetTagDesktopButtonTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] TagDesktopButtonTypeList()
		{
			return this.TagDesktopButtonTypeListIter().ToArray<IntArray>();
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x003147E0 File Offset: 0x003129E0
		public readonly IEnumerable<IntArray> TagDesktopButtonTypeListIter()
		{
			SkillButtonIndex.<TagDesktopButtonTypeListIter>d__61 <TagDesktopButtonTypeListIter>d__ = new SkillButtonIndex.<TagDesktopButtonTypeListIter>d__61(-2);
			<TagDesktopButtonTypeListIter>d__.<>3__<>4__this = this;
			return <TagDesktopButtonTypeListIter>d__;
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x003147F5 File Offset: 0x003129F5
		[Obsolete("本方法用于缓存,遍历请使用TagListIter()或GetTagListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly GameplayTagArray[] TagList()
		{
			return this.TagListIter().ToArray<GameplayTagArray>();
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x00314802 File Offset: 0x00312A02
		public readonly IEnumerable<GameplayTagArray> TagListIter()
		{
			SkillButtonIndex.<TagListIter>d__63 <TagListIter>d__ = new SkillButtonIndex.<TagListIter>d__63(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x00314817 File Offset: 0x00312A17
		[Obsolete("本方法用于缓存,遍历请使用TagPadButtonTypeListIter()或GetTagPadButtonTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] TagPadButtonTypeList()
		{
			return this.TagPadButtonTypeListIter().ToArray<IntArray>();
		}

		// Token: 0x0600D407 RID: 54279 RVA: 0x00314824 File Offset: 0x00312A24
		public readonly IEnumerable<IntArray> TagPadButtonTypeListIter()
		{
			SkillButtonIndex.<TagPadButtonTypeListIter>d__65 <TagPadButtonTypeListIter>d__ = new SkillButtonIndex.<TagPadButtonTypeListIter>d__65(-2);
			<TagPadButtonTypeListIter>d__.<>3__<>4__this = this;
			return <TagPadButtonTypeListIter>d__;
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x0031483C File Offset: 0x00312A3C
		public IntArray? GetDesktopButtonTypeMap(int key)
		{
			this.EnsureDesktopButtonTypeMapCacheIfNeeded();
			IntArray value;
			if (!this.DesktopButtonTypeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x00314870 File Offset: 0x00312A70
		public IntArray? GetGamepadButtonTypeMap(int key)
		{
			this.EnsureGamepadButtonTypeMapCacheIfNeeded();
			IntArray value;
			if (!this.GamepadButtonTypeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x003148A4 File Offset: 0x00312AA4
		public IntArray? GetMotorJoystickPadButtonTypeMap(int key)
		{
			this.EnsureMotorJoystickPadButtonTypeMapCacheIfNeeded();
			IntArray value;
			if (!this.MotorJoystickPadButtonTypeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x003148D8 File Offset: 0x00312AD8
		public IntArray? GetMotorPadButtonTypeMap(int key)
		{
			this.EnsureMotorPadButtonTypeMapCacheIfNeeded();
			IntArray value;
			if (!this.MotorPadButtonTypeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x0031490C File Offset: 0x00312B0C
		public IntArray? GetPadButtonTypeMap(int key)
		{
			this.EnsurePadButtonTypeMapCacheIfNeeded();
			IntArray value;
			if (!this.PadButtonTypeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x00314940 File Offset: 0x00312B40
		private void EnsureDesktopButtonTypeMapCacheIfNeeded()
		{
			if (this.DesktopButtonTypeMapCache != null)
			{
				return;
			}
			this.DesktopButtonTypeMapCache = this.DesktopButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x003149A8 File Offset: 0x00312BA8
		private void EnsureGamepadButtonTypeMapCacheIfNeeded()
		{
			if (this.GamepadButtonTypeMapCache != null)
			{
				return;
			}
			this.GamepadButtonTypeMapCache = this.GamepadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x00314A10 File Offset: 0x00312C10
		private void EnsureMotorJoystickPadButtonTypeMapCacheIfNeeded()
		{
			if (this.MotorJoystickPadButtonTypeMapCache != null)
			{
				return;
			}
			this.MotorJoystickPadButtonTypeMapCache = this.MotorJoystickPadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x00314A78 File Offset: 0x00312C78
		private void EnsureMotorPadButtonTypeMapCacheIfNeeded()
		{
			if (this.MotorPadButtonTypeMapCache != null)
			{
				return;
			}
			this.MotorPadButtonTypeMapCache = this.MotorPadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D411 RID: 54289 RVA: 0x00314AE0 File Offset: 0x00312CE0
		private void EnsurePadButtonTypeMapCacheIfNeeded()
		{
			if (this.PadButtonTypeMapCache != null)
			{
				return;
			}
			this.PadButtonTypeMapCache = this.PadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D412 RID: 54290 RVA: 0x00314B46 File Offset: 0x00312D46
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDesktopButtonTypeMapFrozenDict(int key)
		{
			this.EnsureDesktopButtonTypeMapCacheIfNeeded();
			return this.DesktopButtonTypeMapCache;
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x00314B54 File Offset: 0x00312D54
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetGamepadButtonTypeMapFrozenDict(int key)
		{
			this.EnsureGamepadButtonTypeMapCacheIfNeeded();
			return this.GamepadButtonTypeMapCache;
		}

		// Token: 0x0600D414 RID: 54292 RVA: 0x00314B62 File Offset: 0x00312D62
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetMotorJoystickPadButtonTypeMapFrozenDict(int key)
		{
			this.EnsureMotorJoystickPadButtonTypeMapCacheIfNeeded();
			return this.MotorJoystickPadButtonTypeMapCache;
		}

		// Token: 0x0600D415 RID: 54293 RVA: 0x00314B70 File Offset: 0x00312D70
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetMotorPadButtonTypeMapFrozenDict(int key)
		{
			this.EnsureMotorPadButtonTypeMapCacheIfNeeded();
			return this.MotorPadButtonTypeMapCache;
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x00314B7E File Offset: 0x00312D7E
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetPadButtonTypeMapFrozenDict(int key)
		{
			this.EnsurePadButtonTypeMapCacheIfNeeded();
			return this.PadButtonTypeMapCache;
		}

		// Token: 0x040051D4 RID: 20948
		private Table __p;

		// Token: 0x040051D5 RID: 20949
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DesktopButtonTypeMapCache;

		// Token: 0x040051D6 RID: 20950
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> GamepadButtonTypeMapCache;

		// Token: 0x040051D7 RID: 20951
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> MotorJoystickPadButtonTypeMapCache;

		// Token: 0x040051D8 RID: 20952
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> MotorPadButtonTypeMapCache;

		// Token: 0x040051D9 RID: 20953
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PadButtonTypeMapCache;
	}
}
