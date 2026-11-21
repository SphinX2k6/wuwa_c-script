using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001115 RID: 4373
	public struct RogueWeeklyParam : IFlatbufferObject
	{
		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600CC77 RID: 52343 RVA: 0x00310DA8 File Offset: 0x0030EFA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x00310DB5 File Offset: 0x0030EFB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00310DBC File Offset: 0x0030EFBC
		public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb)
		{
			return RogueWeeklyParam.GetRootAsRogueWeeklyParam(_bb, default(RogueWeeklyParam));
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00310DD8 File Offset: 0x0030EFD8
		public static RogueWeeklyParam GetRootAsRogueWeeklyParam(ByteBuffer _bb, RogueWeeklyParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00310DF5 File Offset: 0x0030EFF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00310E04 File Offset: 0x0030F004
		public RogueWeeklyParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600CC7D RID: 52349 RVA: 0x00310E14 File Offset: 0x0030F014
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

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x00310E50 File Offset: 0x0030F050
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

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00310E87 File Offset: 0x0030F087
		public Span<byte> GetRoguelikeSettleBgSBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00310E96 File Offset: 0x0030F096
		public byte[] GetRoguelikeSettleBgSArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600CC81 RID: 52353 RVA: 0x00310EB0 File Offset: 0x0030F0B0
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

		// Token: 0x0600CC82 RID: 52354 RVA: 0x00310EE7 File Offset: 0x0030F0E7
		public Span<byte> GetRoguelikeSettleBgNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x00310EF6 File Offset: 0x0030F0F6
		public byte[] GetRoguelikeSettleBgNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x00310F10 File Offset: 0x0030F110
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

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00310F48 File Offset: 0x0030F148
		public Span<byte> GetRoguelikeRoomFloatTipsNoHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x00310F58 File Offset: 0x0030F158
		public byte[] GetRoguelikeRoomFloatTipsNoHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600CC87 RID: 52359 RVA: 0x00310F70 File Offset: 0x0030F170
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

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00310FA8 File Offset: 0x0030F1A8
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x00310FB8 File Offset: 0x0030F1B8
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600CC8A RID: 52362 RVA: 0x00310FD0 File Offset: 0x0030F1D0
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

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600CC8B RID: 52363 RVA: 0x00311010 File Offset: 0x0030F210
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

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600CC8C RID: 52364 RVA: 0x00311050 File Offset: 0x0030F250
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

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600CC8D RID: 52365 RVA: 0x00311090 File Offset: 0x0030F290
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

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600CC8E RID: 52366 RVA: 0x003110D0 File Offset: 0x0030F2D0
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

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600CC8F RID: 52367 RVA: 0x00311110 File Offset: 0x0030F310
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

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600CC90 RID: 52368 RVA: 0x00311150 File Offset: 0x0030F350
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

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600CC91 RID: 52369 RVA: 0x00311190 File Offset: 0x0030F390
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

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600CC92 RID: 52370 RVA: 0x003111D0 File Offset: 0x0030F3D0
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

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00311210 File Offset: 0x0030F410
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x00311250 File Offset: 0x0030F450
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

		// Token: 0x0600CC95 RID: 52373 RVA: 0x0031127C File Offset: 0x0030F47C
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x0031128C File Offset: 0x0030F48C
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x003112A4 File Offset: 0x0030F4A4
		public DicIntInt? ValidRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600CC98 RID: 52376 RVA: 0x00311308 File Offset: 0x0030F508
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

		// Token: 0x0600CC99 RID: 52377 RVA: 0x00311334 File Offset: 0x0030F534
		public DicIntInt? DungeonRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x00311398 File Offset: 0x0030F598
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

		// Token: 0x0600CC9B RID: 52379 RVA: 0x003113C4 File Offset: 0x0030F5C4
		[NullableContext(1)]
		public int[] DungeonList()
		{
			return this.GetDungeonListArray();
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x003113CC File Offset: 0x0030F5CC
		[NullableContext(1)]
		public IEnumerable<int> DungeonListIter()
		{
			RogueWeeklyParam.<DungeonListIter>d__56 <DungeonListIter>d__ = new RogueWeeklyParam.<DungeonListIter>d__56(-2);
			<DungeonListIter>d__.<>3__<>4__this = this;
			return <DungeonListIter>d__;
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x003113E4 File Offset: 0x0030F5E4
		[NullableContext(1)]
		public Dictionary<int, int> DungeonRoleOpenTimeMap()
		{
			return this.DungeonRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x0031143A File Offset: 0x0030F63A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DungeonRoleOpenTimeMapIter()
		{
			RogueWeeklyParam.<DungeonRoleOpenTimeMapIter>d__58 <DungeonRoleOpenTimeMapIter>d__ = new RogueWeeklyParam.<DungeonRoleOpenTimeMapIter>d__58(-2);
			<DungeonRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <DungeonRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600CC9F RID: 52383 RVA: 0x00311450 File Offset: 0x0030F650
		[NullableContext(1)]
		public Dictionary<int, int> ValidRoleOpenTimeMap()
		{
			return this.ValidRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x003114A6 File Offset: 0x0030F6A6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ValidRoleOpenTimeMapIter()
		{
			RogueWeeklyParam.<ValidRoleOpenTimeMapIter>d__60 <ValidRoleOpenTimeMapIter>d__ = new RogueWeeklyParam.<ValidRoleOpenTimeMapIter>d__60(-2);
			<ValidRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <ValidRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x003114BC File Offset: 0x0030F6BC
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

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x003114F0 File Offset: 0x0030F6F0
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

		// Token: 0x0600CCA3 RID: 52387 RVA: 0x00311524 File Offset: 0x0030F724
		private void EnsureDungeonRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.DungeonRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.DungeonRoleOpenTimeMapCache = this.DungeonRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCA4 RID: 52388 RVA: 0x0031158C File Offset: 0x0030F78C
		private void EnsureValidRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.ValidRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.ValidRoleOpenTimeMapCache = this.ValidRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x003115F2 File Offset: 0x0030F7F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDungeonRoleOpenTimeMapFrozenDict()
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			return this.DungeonRoleOpenTimeMapCache;
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x00311600 File Offset: 0x0030F800
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetValidRoleOpenTimeMapFrozenDict()
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			return this.ValidRoleOpenTimeMapCache;
		}

		// Token: 0x0400570B RID: 22283
		private Table __p;

		// Token: 0x0400570C RID: 22284
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonRoleOpenTimeMapCache;

		// Token: 0x0400570D RID: 22285
		[Nullable(2)]
		private FrozenDictionary<int, int> ValidRoleOpenTimeMapCache;
	}
}
