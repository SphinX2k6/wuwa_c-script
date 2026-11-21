using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C69 RID: 3177
	public struct CombinationAxis : IFlatbufferObject
	{
		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06005C6E RID: 23662 RVA: 0x00218A12 File Offset: 0x00216C12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00218A1F File Offset: 0x00216C1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00218A28 File Offset: 0x00216C28
		public static CombinationAxis GetRootAsCombinationAxis(ByteBuffer _bb)
		{
			return CombinationAxis.GetRootAsCombinationAxis(_bb, default(CombinationAxis));
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x00218A44 File Offset: 0x00216C44
		public static CombinationAxis GetRootAsCombinationAxis(ByteBuffer _bb, CombinationAxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x00218A61 File Offset: 0x00216C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x00218A70 File Offset: 0x00216C70
		public CombinationAxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00218A80 File Offset: 0x00216C80
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

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06005C75 RID: 23669 RVA: 0x00218ABC File Offset: 0x00216CBC
		public string AxisName
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

		// Token: 0x06005C76 RID: 23670 RVA: 0x00218AF3 File Offset: 0x00216CF3
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x00218B02 File Offset: 0x00216D02
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06005C78 RID: 23672 RVA: 0x00218B1C File Offset: 0x00216D1C
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

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06005C79 RID: 23673 RVA: 0x00218B58 File Offset: 0x00216D58
		public string InputTag
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

		// Token: 0x06005C7A RID: 23674 RVA: 0x00218B90 File Offset: 0x00216D90
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00218BA0 File Offset: 0x00216DA0
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06005C7C RID: 23676 RVA: 0x00218BB8 File Offset: 0x00216DB8
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

		// Token: 0x06005C7D RID: 23677 RVA: 0x00218BF8 File Offset: 0x00216DF8
		public DicStringString? PcKeyMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x00218C5C File Offset: 0x00216E5C
		public int PcKeyMapLength
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

		// Token: 0x06005C7F RID: 23679 RVA: 0x00218C88 File Offset: 0x00216E88
		public DicStringString? GamepadKeyMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x00218CEC File Offset: 0x00216EEC
		public int GamepadKeyMapLength
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

		// Token: 0x06005C81 RID: 23681 RVA: 0x00218D18 File Offset: 0x00216F18
		public DicStringFloat? SecondaryKeyScaleMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x00218D7C File Offset: 0x00216F7C
		public int SecondaryKeyScaleMapLength
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

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06005C83 RID: 23683 RVA: 0x00218DA8 File Offset: 0x00216FA8
		public string MobileIconPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00218DE0 File Offset: 0x00216FE0
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00218DF0 File Offset: 0x00216FF0
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x00218E08 File Offset: 0x00217008
		public string DisplayName
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

		// Token: 0x06005C87 RID: 23687 RVA: 0x00218E40 File Offset: 0x00217040
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00218E50 File Offset: 0x00217050
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00218E68 File Offset: 0x00217068
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x00218ECC File Offset: 0x002170CC
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

		// Token: 0x06005C8B RID: 23691 RVA: 0x00218EF8 File Offset: 0x002170F8
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00218F5C File Offset: 0x0021715C
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

		// Token: 0x06005C8D RID: 23693 RVA: 0x00218F88 File Offset: 0x00217188
		public string BlockInput(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x00218FC4 File Offset: 0x002171C4
		public int BlockInputLength
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

		// Token: 0x06005C8F RID: 23695 RVA: 0x00218FF0 File Offset: 0x002171F0
		[NullableContext(1)]
		public string[] BlockInput()
		{
			return this.BlockInputIter().ToArray<string>();
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00218FFD File Offset: 0x002171FD
		[NullableContext(1)]
		public IEnumerable<string> BlockInputIter()
		{
			CombinationAxis.<BlockInputIter>d__49 <BlockInputIter>d__ = new CombinationAxis.<BlockInputIter>d__49(-2);
			<BlockInputIter>d__.<>3__<>4__this = this;
			return <BlockInputIter>d__;
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00219014 File Offset: 0x00217214
		[NullableContext(1)]
		public Dictionary<string, string> GamepadKeyMap()
		{
			return this.GamepadKeyMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x0021906A File Offset: 0x0021726A
		[NullableContext(1)]
		public IEnumerable<DicStringString> GamepadKeyMapIter()
		{
			CombinationAxis.<GamepadKeyMapIter>d__51 <GamepadKeyMapIter>d__ = new CombinationAxis.<GamepadKeyMapIter>d__51(-2);
			<GamepadKeyMapIter>d__.<>3__<>4__this = this;
			return <GamepadKeyMapIter>d__;
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00219080 File Offset: 0x00217280
		[NullableContext(1)]
		public Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x002190D6 File Offset: 0x002172D6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			CombinationAxis.<GamepadVersionMapIter>d__53 <GamepadVersionMapIter>d__ = new CombinationAxis.<GamepadVersionMapIter>d__53(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x002190EC File Offset: 0x002172EC
		[NullableContext(1)]
		public Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00219142 File Offset: 0x00217342
		[NullableContext(1)]
		public IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			CombinationAxis.<KeyboardVersionMapIter>d__55 <KeyboardVersionMapIter>d__ = new CombinationAxis.<KeyboardVersionMapIter>d__55(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00219158 File Offset: 0x00217358
		[NullableContext(1)]
		public Dictionary<string, string> PcKeyMap()
		{
			return this.PcKeyMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x002191AE File Offset: 0x002173AE
		[NullableContext(1)]
		public IEnumerable<DicStringString> PcKeyMapIter()
		{
			CombinationAxis.<PcKeyMapIter>d__57 <PcKeyMapIter>d__ = new CombinationAxis.<PcKeyMapIter>d__57(-2);
			<PcKeyMapIter>d__.<>3__<>4__this = this;
			return <PcKeyMapIter>d__;
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x002191C4 File Offset: 0x002173C4
		[NullableContext(1)]
		public Dictionary<string, float> SecondaryKeyScaleMap()
		{
			return this.SecondaryKeyScaleMapIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x0021921A File Offset: 0x0021741A
		[NullableContext(1)]
		public IEnumerable<DicStringFloat> SecondaryKeyScaleMapIter()
		{
			CombinationAxis.<SecondaryKeyScaleMapIter>d__59 <SecondaryKeyScaleMapIter>d__ = new CombinationAxis.<SecondaryKeyScaleMapIter>d__59(-2);
			<SecondaryKeyScaleMapIter>d__.<>3__<>4__this = this;
			return <SecondaryKeyScaleMapIter>d__;
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00219230 File Offset: 0x00217430
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetGamepadKeyMap(string key)
		{
			this.EnsureGamepadKeyMapCacheIfNeeded();
			string result;
			if (!this.GamepadKeyMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00219258 File Offset: 0x00217458
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

		// Token: 0x06005C9D RID: 23709 RVA: 0x0021928C File Offset: 0x0021748C
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

		// Token: 0x06005C9E RID: 23710 RVA: 0x002192C0 File Offset: 0x002174C0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetPcKeyMap(string key)
		{
			this.EnsurePcKeyMapCacheIfNeeded();
			string result;
			if (!this.PcKeyMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x002192E8 File Offset: 0x002174E8
		[NullableContext(1)]
		public float? GetSecondaryKeyScaleMap(string key)
		{
			this.EnsureSecondaryKeyScaleMapCacheIfNeeded();
			float value;
			if (!this.SecondaryKeyScaleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x0021931C File Offset: 0x0021751C
		private void EnsureGamepadKeyMapCacheIfNeeded()
		{
			if (this.GamepadKeyMapCache != null)
			{
				return;
			}
			this.GamepadKeyMapCache = this.GamepadKeyMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00219384 File Offset: 0x00217584
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x002193EC File Offset: 0x002175EC
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00219454 File Offset: 0x00217654
		private void EnsurePcKeyMapCacheIfNeeded()
		{
			if (this.PcKeyMapCache != null)
			{
				return;
			}
			this.PcKeyMapCache = this.PcKeyMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x002194BC File Offset: 0x002176BC
		private void EnsureSecondaryKeyScaleMapCacheIfNeeded()
		{
			if (this.SecondaryKeyScaleMapCache != null)
			{
				return;
			}
			this.SecondaryKeyScaleMapCache = this.SecondaryKeyScaleMapIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x00219522 File Offset: 0x00217722
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetGamepadKeyMapFrozenDict()
		{
			this.EnsureGamepadKeyMapCacheIfNeeded();
			return this.GamepadKeyMapCache;
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x00219530 File Offset: 0x00217730
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict()
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x0021953E File Offset: 0x0021773E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict()
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x0021954C File Offset: 0x0021774C
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetPcKeyMapFrozenDict()
		{
			this.EnsurePcKeyMapCacheIfNeeded();
			return this.PcKeyMapCache;
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x0021955A File Offset: 0x0021775A
		[NullableContext(1)]
		public FrozenDictionary<string, float> GetSecondaryKeyScaleMapFrozenDict()
		{
			this.EnsureSecondaryKeyScaleMapCacheIfNeeded();
			return this.SecondaryKeyScaleMapCache;
		}

		// Token: 0x04005173 RID: 20851
		private Table __p;

		// Token: 0x04005174 RID: 20852
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> GamepadKeyMapCache;

		// Token: 0x04005175 RID: 20853
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04005176 RID: 20854
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x04005177 RID: 20855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> PcKeyMapCache;

		// Token: 0x04005178 RID: 20856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> SecondaryKeyScaleMapCache;
	}
}
