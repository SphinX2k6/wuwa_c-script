using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B5 RID: 4533
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillButtonIndex : IFlatbufferObject
	{
		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600DBB1 RID: 56241 RVA: 0x0033323D File Offset: 0x0033143D
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBB2 RID: 56242 RVA: 0x0033324A File Offset: 0x0033144A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBB3 RID: 56243 RVA: 0x00333254 File Offset: 0x00331454
		[NullableContext(0)]
		public static SkillButtonIndex GetRootAsSkillButtonIndex(ByteBuffer _bb)
		{
			return SkillButtonIndex.GetRootAsSkillButtonIndex(_bb, default(SkillButtonIndex));
		}

		// Token: 0x0600DBB4 RID: 56244 RVA: 0x00333270 File Offset: 0x00331470
		[NullableContext(0)]
		public static SkillButtonIndex GetRootAsSkillButtonIndex(ByteBuffer _bb, SkillButtonIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x0033328D File Offset: 0x0033148D
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x0033329C File Offset: 0x0033149C
		[NullableContext(0)]
		public SkillButtonIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600DBB7 RID: 56247 RVA: 0x003332AC File Offset: 0x003314AC
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

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600DBB8 RID: 56248 RVA: 0x003332E8 File Offset: 0x003314E8
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

		// Token: 0x0600DBB9 RID: 56249 RVA: 0x00333324 File Offset: 0x00331524
		public int DesktopButtonTypeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x00333364 File Offset: 0x00331564
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

		// Token: 0x0600DBBB RID: 56251 RVA: 0x0033338F File Offset: 0x0033158F
		[NullableContext(0)]
		public Span<int> GetDesktopButtonTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600DBBC RID: 56252 RVA: 0x0033339E File Offset: 0x0033159E
		[NullableContext(0)]
		public int[] GetDesktopButtonTypeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x003333B8 File Offset: 0x003315B8
		public int PadButtonTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600DBBE RID: 56254 RVA: 0x003333F8 File Offset: 0x003315F8
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

		// Token: 0x0600DBBF RID: 56255 RVA: 0x00333424 File Offset: 0x00331624
		[NullableContext(0)]
		public Span<int> GetPadButtonTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x00333434 File Offset: 0x00331634
		[NullableContext(0)]
		public int[] GetPadButtonTypeListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x0033344C File Offset: 0x0033164C
		public GameplayTagArray? TagList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new GameplayTagArray?(default(GameplayTagArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600DBC2 RID: 56258 RVA: 0x003334B0 File Offset: 0x003316B0
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

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x003334DC File Offset: 0x003316DC
		public IntArray? TagDesktopButtonTypeList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600DBC4 RID: 56260 RVA: 0x00333540 File Offset: 0x00331740
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

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x0033356C File Offset: 0x0033176C
		public IntArray? TagPadButtonTypeList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600DBC6 RID: 56262 RVA: 0x003335D0 File Offset: 0x003317D0
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

		// Token: 0x0600DBC7 RID: 56263 RVA: 0x003335FC File Offset: 0x003317FC
		public DicIntIntArray? DesktopButtonTypeMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x00333660 File Offset: 0x00331860
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

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x0033368C File Offset: 0x0033188C
		public DicIntIntArray? PadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600DBCA RID: 56266 RVA: 0x003336F0 File Offset: 0x003318F0
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

		// Token: 0x0600DBCB RID: 56267 RVA: 0x0033371C File Offset: 0x0033191C
		public DicIntIntArray? GamepadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x00333780 File Offset: 0x00331980
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

		// Token: 0x0600DBCD RID: 56269 RVA: 0x003337AC File Offset: 0x003319AC
		public DicIntIntArray? MotorPadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600DBCE RID: 56270 RVA: 0x00333810 File Offset: 0x00331A10
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

		// Token: 0x0600DBCF RID: 56271 RVA: 0x0033383C File Offset: 0x00331A3C
		public DicIntIntArray? MotorJoystickPadButtonTypeMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600DBD0 RID: 56272 RVA: 0x003338A0 File Offset: 0x00331AA0
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

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x003338CC File Offset: 0x00331ACC
		public int[] DesktopButtonTypeList()
		{
			return this.GetDesktopButtonTypeListArray();
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x003338D4 File Offset: 0x00331AD4
		public IEnumerable<int> DesktopButtonTypeListIter()
		{
			SkillButtonIndex.<DesktopButtonTypeListIter>d__47 <DesktopButtonTypeListIter>d__ = new SkillButtonIndex.<DesktopButtonTypeListIter>d__47(-2);
			<DesktopButtonTypeListIter>d__.<>3__<>4__this = this;
			return <DesktopButtonTypeListIter>d__;
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x003338EC File Offset: 0x00331AEC
		public Dictionary<int, IntArray> DesktopButtonTypeMap()
		{
			return this.DesktopButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00333942 File Offset: 0x00331B42
		public IEnumerable<DicIntIntArray> DesktopButtonTypeMapIter()
		{
			SkillButtonIndex.<DesktopButtonTypeMapIter>d__49 <DesktopButtonTypeMapIter>d__ = new SkillButtonIndex.<DesktopButtonTypeMapIter>d__49(-2);
			<DesktopButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <DesktopButtonTypeMapIter>d__;
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00333958 File Offset: 0x00331B58
		public Dictionary<int, IntArray> GamepadButtonTypeMap()
		{
			return this.GamepadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x003339AE File Offset: 0x00331BAE
		public IEnumerable<DicIntIntArray> GamepadButtonTypeMapIter()
		{
			SkillButtonIndex.<GamepadButtonTypeMapIter>d__51 <GamepadButtonTypeMapIter>d__ = new SkillButtonIndex.<GamepadButtonTypeMapIter>d__51(-2);
			<GamepadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <GamepadButtonTypeMapIter>d__;
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x003339C4 File Offset: 0x00331BC4
		public Dictionary<int, IntArray> MotorJoystickPadButtonTypeMap()
		{
			return this.MotorJoystickPadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x00333A1A File Offset: 0x00331C1A
		public IEnumerable<DicIntIntArray> MotorJoystickPadButtonTypeMapIter()
		{
			SkillButtonIndex.<MotorJoystickPadButtonTypeMapIter>d__53 <MotorJoystickPadButtonTypeMapIter>d__ = new SkillButtonIndex.<MotorJoystickPadButtonTypeMapIter>d__53(-2);
			<MotorJoystickPadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <MotorJoystickPadButtonTypeMapIter>d__;
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x00333A30 File Offset: 0x00331C30
		public Dictionary<int, IntArray> MotorPadButtonTypeMap()
		{
			return this.MotorPadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x00333A86 File Offset: 0x00331C86
		public IEnumerable<DicIntIntArray> MotorPadButtonTypeMapIter()
		{
			SkillButtonIndex.<MotorPadButtonTypeMapIter>d__55 <MotorPadButtonTypeMapIter>d__ = new SkillButtonIndex.<MotorPadButtonTypeMapIter>d__55(-2);
			<MotorPadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <MotorPadButtonTypeMapIter>d__;
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x00333A9B File Offset: 0x00331C9B
		public int[] PadButtonTypeList()
		{
			return this.GetPadButtonTypeListArray();
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x00333AA3 File Offset: 0x00331CA3
		public IEnumerable<int> PadButtonTypeListIter()
		{
			SkillButtonIndex.<PadButtonTypeListIter>d__57 <PadButtonTypeListIter>d__ = new SkillButtonIndex.<PadButtonTypeListIter>d__57(-2);
			<PadButtonTypeListIter>d__.<>3__<>4__this = this;
			return <PadButtonTypeListIter>d__;
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x00333AB8 File Offset: 0x00331CB8
		public Dictionary<int, IntArray> PadButtonTypeMap()
		{
			return this.PadButtonTypeMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DBDE RID: 56286 RVA: 0x00333B0E File Offset: 0x00331D0E
		public IEnumerable<DicIntIntArray> PadButtonTypeMapIter()
		{
			SkillButtonIndex.<PadButtonTypeMapIter>d__59 <PadButtonTypeMapIter>d__ = new SkillButtonIndex.<PadButtonTypeMapIter>d__59(-2);
			<PadButtonTypeMapIter>d__.<>3__<>4__this = this;
			return <PadButtonTypeMapIter>d__;
		}

		// Token: 0x0600DBDF RID: 56287 RVA: 0x00333B23 File Offset: 0x00331D23
		public IntArray[] TagDesktopButtonTypeList()
		{
			return this.TagDesktopButtonTypeListIter().ToArray<IntArray>();
		}

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x00333B30 File Offset: 0x00331D30
		public IEnumerable<IntArray> TagDesktopButtonTypeListIter()
		{
			SkillButtonIndex.<TagDesktopButtonTypeListIter>d__61 <TagDesktopButtonTypeListIter>d__ = new SkillButtonIndex.<TagDesktopButtonTypeListIter>d__61(-2);
			<TagDesktopButtonTypeListIter>d__.<>3__<>4__this = this;
			return <TagDesktopButtonTypeListIter>d__;
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00333B45 File Offset: 0x00331D45
		public GameplayTagArray[] TagList()
		{
			return this.TagListIter().ToArray<GameplayTagArray>();
		}

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x00333B52 File Offset: 0x00331D52
		public IEnumerable<GameplayTagArray> TagListIter()
		{
			SkillButtonIndex.<TagListIter>d__63 <TagListIter>d__ = new SkillButtonIndex.<TagListIter>d__63(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x00333B67 File Offset: 0x00331D67
		public IntArray[] TagPadButtonTypeList()
		{
			return this.TagPadButtonTypeListIter().ToArray<IntArray>();
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x00333B74 File Offset: 0x00331D74
		public IEnumerable<IntArray> TagPadButtonTypeListIter()
		{
			SkillButtonIndex.<TagPadButtonTypeListIter>d__65 <TagPadButtonTypeListIter>d__ = new SkillButtonIndex.<TagPadButtonTypeListIter>d__65(-2);
			<TagPadButtonTypeListIter>d__.<>3__<>4__this = this;
			return <TagPadButtonTypeListIter>d__;
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x00333B8C File Offset: 0x00331D8C
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

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x00333BC0 File Offset: 0x00331DC0
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

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x00333BF4 File Offset: 0x00331DF4
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

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x00333C28 File Offset: 0x00331E28
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

		// Token: 0x0600DBE9 RID: 56297 RVA: 0x00333C5C File Offset: 0x00331E5C
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

		// Token: 0x0600DBEA RID: 56298 RVA: 0x00333C90 File Offset: 0x00331E90
		private void EnsureDesktopButtonTypeMapCacheIfNeeded()
		{
			if (this.DesktopButtonTypeMapCache != null)
			{
				return;
			}
			this.DesktopButtonTypeMapCache = this.DesktopButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DBEB RID: 56299 RVA: 0x00333CF8 File Offset: 0x00331EF8
		private void EnsureGamepadButtonTypeMapCacheIfNeeded()
		{
			if (this.GamepadButtonTypeMapCache != null)
			{
				return;
			}
			this.GamepadButtonTypeMapCache = this.GamepadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DBEC RID: 56300 RVA: 0x00333D60 File Offset: 0x00331F60
		private void EnsureMotorJoystickPadButtonTypeMapCacheIfNeeded()
		{
			if (this.MotorJoystickPadButtonTypeMapCache != null)
			{
				return;
			}
			this.MotorJoystickPadButtonTypeMapCache = this.MotorJoystickPadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x00333DC8 File Offset: 0x00331FC8
		private void EnsureMotorPadButtonTypeMapCacheIfNeeded()
		{
			if (this.MotorPadButtonTypeMapCache != null)
			{
				return;
			}
			this.MotorPadButtonTypeMapCache = this.MotorPadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DBEE RID: 56302 RVA: 0x00333E30 File Offset: 0x00332030
		private void EnsurePadButtonTypeMapCacheIfNeeded()
		{
			if (this.PadButtonTypeMapCache != null)
			{
				return;
			}
			this.PadButtonTypeMapCache = this.PadButtonTypeMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00333E96 File Offset: 0x00332096
		public FrozenDictionary<int, IntArray> GetDesktopButtonTypeMapFrozenDict()
		{
			this.EnsureDesktopButtonTypeMapCacheIfNeeded();
			return this.DesktopButtonTypeMapCache;
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x00333EA4 File Offset: 0x003320A4
		public FrozenDictionary<int, IntArray> GetGamepadButtonTypeMapFrozenDict()
		{
			this.EnsureGamepadButtonTypeMapCacheIfNeeded();
			return this.GamepadButtonTypeMapCache;
		}

		// Token: 0x0600DBF1 RID: 56305 RVA: 0x00333EB2 File Offset: 0x003320B2
		public FrozenDictionary<int, IntArray> GetMotorJoystickPadButtonTypeMapFrozenDict()
		{
			this.EnsureMotorJoystickPadButtonTypeMapCacheIfNeeded();
			return this.MotorJoystickPadButtonTypeMapCache;
		}

		// Token: 0x0600DBF2 RID: 56306 RVA: 0x00333EC0 File Offset: 0x003320C0
		public FrozenDictionary<int, IntArray> GetMotorPadButtonTypeMapFrozenDict()
		{
			this.EnsureMotorPadButtonTypeMapCacheIfNeeded();
			return this.MotorPadButtonTypeMapCache;
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x00333ECE File Offset: 0x003320CE
		public FrozenDictionary<int, IntArray> GetPadButtonTypeMapFrozenDict()
		{
			this.EnsurePadButtonTypeMapCacheIfNeeded();
			return this.PadButtonTypeMapCache;
		}

		// Token: 0x040057D3 RID: 22483
		private Table __p;

		// Token: 0x040057D4 RID: 22484
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DesktopButtonTypeMapCache;

		// Token: 0x040057D5 RID: 22485
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> GamepadButtonTypeMapCache;

		// Token: 0x040057D6 RID: 22486
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> MotorJoystickPadButtonTypeMapCache;

		// Token: 0x040057D7 RID: 22487
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> MotorPadButtonTypeMapCache;

		// Token: 0x040057D8 RID: 22488
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PadButtonTypeMapCache;
	}
}
