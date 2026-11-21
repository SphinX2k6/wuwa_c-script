using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF8 RID: 3064
	[NullableContext(1)]
	[Nullable(0)]
	public struct AxisMapping : IFlatbufferObject
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x001FB87C File Offset: 0x001F9A7C
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x001FB889 File Offset: 0x001F9A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x001FB890 File Offset: 0x001F9A90
		[NullableContext(0)]
		public static AxisMapping GetRootAsAxisMapping(ByteBuffer _bb)
		{
			return AxisMapping.GetRootAsAxisMapping(_bb, default(AxisMapping));
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x001FB8AC File Offset: 0x001F9AAC
		[NullableContext(0)]
		public static AxisMapping GetRootAsAxisMapping(ByteBuffer _bb, AxisMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x001FB8C9 File Offset: 0x001F9AC9
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x001FB8D8 File Offset: 0x001F9AD8
		[NullableContext(0)]
		public AxisMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x001FB8E8 File Offset: 0x001F9AE8
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x001FB924 File Offset: 0x001F9B24
		[Nullable(0)]
		public string AxisName
		{
			[NullableContext(0)]
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

		// Token: 0x06004FE8 RID: 20456 RVA: 0x001FB95B File Offset: 0x001F9B5B
		[NullableContext(0)]
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x001FB96A File Offset: 0x001F9B6A
		[NullableContext(0)]
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x001FB984 File Offset: 0x001F9B84
		public int AxisType
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x001FB9C0 File Offset: 0x001F9BC0
		[Nullable(0)]
		public string InputTag
		{
			[NullableContext(0)]
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

		// Token: 0x06004FEC RID: 20460 RVA: 0x001FB9F8 File Offset: 0x001F9BF8
		[NullableContext(0)]
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x001FBA08 File Offset: 0x001F9C08
		[NullableContext(0)]
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x001FBA20 File Offset: 0x001F9C20
		public int ExclusiveType
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

		// Token: 0x06004FEF RID: 20463 RVA: 0x001FBA60 File Offset: 0x001F9C60
		public DicStringFloat? PcKeys(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x001FBAC4 File Offset: 0x001F9CC4
		public int PcKeysLength
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

		// Token: 0x06004FF1 RID: 20465 RVA: 0x001FBAF0 File Offset: 0x001F9CF0
		public DicStringFloat? FrancePcKeys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x001FBB54 File Offset: 0x001F9D54
		public int FrancePcKeysLength
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

		// Token: 0x06004FF3 RID: 20467 RVA: 0x001FBB80 File Offset: 0x001F9D80
		public DicStringFloat? ThaiPcKeys(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x001FBBE4 File Offset: 0x001F9DE4
		public int ThaiPcKeysLength
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

		// Token: 0x06004FF5 RID: 20469 RVA: 0x001FBC10 File Offset: 0x001F9E10
		public DicStringFloat? GamepadKeys(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x001FBC74 File Offset: 0x001F9E74
		public int GamepadKeysLength
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x001FBCA0 File Offset: 0x001F9EA0
		[Nullable(0)]
		public string DisplayName
		{
			[NullableContext(0)]
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

		// Token: 0x06004FF8 RID: 20472 RVA: 0x001FBCD8 File Offset: 0x001F9ED8
		[NullableContext(0)]
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x001FBCE8 File Offset: 0x001F9EE8
		[NullableContext(0)]
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x001FBD00 File Offset: 0x001F9F00
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x001FBD64 File Offset: 0x001F9F64
		public int KeyboardVersionMapLength
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

		// Token: 0x06004FFC RID: 20476 RVA: 0x001FBD90 File Offset: 0x001F9F90
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x001FBDF4 File Offset: 0x001F9FF4
		public int GamepadVersionMapLength
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

		// Token: 0x06004FFE RID: 20478 RVA: 0x001FBE20 File Offset: 0x001FA020
		public Dictionary<string, float> FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x001FBE76 File Offset: 0x001FA076
		public IEnumerable<DicStringFloat> FrancePcKeysIter()
		{
			AxisMapping.<FrancePcKeysIter>d__45 <FrancePcKeysIter>d__ = new AxisMapping.<FrancePcKeysIter>d__45(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x001FBE8C File Offset: 0x001FA08C
		public Dictionary<string, float> GamepadKeys()
		{
			return this.GamepadKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x001FBEE2 File Offset: 0x001FA0E2
		public IEnumerable<DicStringFloat> GamepadKeysIter()
		{
			AxisMapping.<GamepadKeysIter>d__47 <GamepadKeysIter>d__ = new AxisMapping.<GamepadKeysIter>d__47(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x001FBEF8 File Offset: 0x001FA0F8
		public Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x001FBF4E File Offset: 0x001FA14E
		public IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			AxisMapping.<GamepadVersionMapIter>d__49 <GamepadVersionMapIter>d__ = new AxisMapping.<GamepadVersionMapIter>d__49(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x001FBF64 File Offset: 0x001FA164
		public Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x001FBFBA File Offset: 0x001FA1BA
		public IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			AxisMapping.<KeyboardVersionMapIter>d__51 <KeyboardVersionMapIter>d__ = new AxisMapping.<KeyboardVersionMapIter>d__51(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x001FBFD0 File Offset: 0x001FA1D0
		public Dictionary<string, float> PcKeys()
		{
			return this.PcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x001FC026 File Offset: 0x001FA226
		public IEnumerable<DicStringFloat> PcKeysIter()
		{
			AxisMapping.<PcKeysIter>d__53 <PcKeysIter>d__ = new AxisMapping.<PcKeysIter>d__53(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x001FC03C File Offset: 0x001FA23C
		public Dictionary<string, float> ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x001FC092 File Offset: 0x001FA292
		public IEnumerable<DicStringFloat> ThaiPcKeysIter()
		{
			AxisMapping.<ThaiPcKeysIter>d__55 <ThaiPcKeysIter>d__ = new AxisMapping.<ThaiPcKeysIter>d__55(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x001FC0A8 File Offset: 0x001FA2A8
		public float? GetFrancePcKeys(string key)
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			float value;
			if (!this.FrancePcKeysCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x001FC0DC File Offset: 0x001FA2DC
		public float? GetGamepadKeys(string key)
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			float value;
			if (!this.GamepadKeysCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x001FC110 File Offset: 0x001FA310
		public int? GetGamepadVersionMap(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			int value;
			if (!this.GamepadVersionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x001FC144 File Offset: 0x001FA344
		public int? GetKeyboardVersionMap(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			int value;
			if (!this.KeyboardVersionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x001FC178 File Offset: 0x001FA378
		public float? GetPcKeys(string key)
		{
			this.EnsurePcKeysCacheIfNeeded();
			float value;
			if (!this.PcKeysCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x001FC1AC File Offset: 0x001FA3AC
		public float? GetThaiPcKeys(string key)
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			float value;
			if (!this.ThaiPcKeysCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x001FC1E0 File Offset: 0x001FA3E0
		private void EnsureFrancePcKeysCacheIfNeeded()
		{
			if (this.FrancePcKeysCache != null)
			{
				return;
			}
			this.FrancePcKeysCache = this.FrancePcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x001FC248 File Offset: 0x001FA448
		private void EnsureGamepadKeysCacheIfNeeded()
		{
			if (this.GamepadKeysCache != null)
			{
				return;
			}
			this.GamepadKeysCache = this.GamepadKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x001FC2B0 File Offset: 0x001FA4B0
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x001FC318 File Offset: 0x001FA518
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x001FC380 File Offset: 0x001FA580
		private void EnsurePcKeysCacheIfNeeded()
		{
			if (this.PcKeysCache != null)
			{
				return;
			}
			this.PcKeysCache = this.PcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x001FC3E8 File Offset: 0x001FA5E8
		private void EnsureThaiPcKeysCacheIfNeeded()
		{
			if (this.ThaiPcKeysCache != null)
			{
				return;
			}
			this.ThaiPcKeysCache = this.ThaiPcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x001FC44E File Offset: 0x001FA64E
		public FrozenDictionary<string, float> GetFrancePcKeysFrozenDict()
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			return this.FrancePcKeysCache;
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x001FC45C File Offset: 0x001FA65C
		public FrozenDictionary<string, float> GetGamepadKeysFrozenDict()
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			return this.GamepadKeysCache;
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x001FC46A File Offset: 0x001FA66A
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict()
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x001FC478 File Offset: 0x001FA678
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict()
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x001FC486 File Offset: 0x001FA686
		public FrozenDictionary<string, float> GetPcKeysFrozenDict()
		{
			this.EnsurePcKeysCacheIfNeeded();
			return this.PcKeysCache;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x001FC494 File Offset: 0x001FA694
		public FrozenDictionary<string, float> GetThaiPcKeysFrozenDict()
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			return this.ThaiPcKeysCache;
		}

		// Token: 0x040050E0 RID: 20704
		private Table __p;

		// Token: 0x040050E1 RID: 20705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> FrancePcKeysCache;

		// Token: 0x040050E2 RID: 20706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> GamepadKeysCache;

		// Token: 0x040050E3 RID: 20707
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x040050E4 RID: 20708
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x040050E5 RID: 20709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PcKeysCache;

		// Token: 0x040050E6 RID: 20710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> ThaiPcKeysCache;
	}
}
