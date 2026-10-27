using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B86 RID: 2950
	public struct CombinationAction : IFlatbufferObject
	{
		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x001F7E8D File Offset: 0x001F608D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x001F7E9A File Offset: 0x001F609A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x001F7EA4 File Offset: 0x001F60A4
		public static CombinationAction GetRootAsCombinationAction(ByteBuffer _bb)
		{
			return CombinationAction.GetRootAsCombinationAction(_bb, default(CombinationAction));
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x001F7EC0 File Offset: 0x001F60C0
		public static CombinationAction GetRootAsCombinationAction(ByteBuffer _bb, CombinationAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x001F7EDD File Offset: 0x001F60DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x001F7EEC File Offset: 0x001F60EC
		public CombinationAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x001F7EFC File Offset: 0x001F60FC
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x001F7F38 File Offset: 0x001F6138
		public string ActionName
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

		// Token: 0x0600565D RID: 22109 RVA: 0x001F7F6F File Offset: 0x001F616F
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x001F7F7E File Offset: 0x001F617E
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x001F7F98 File Offset: 0x001F6198
		public int ActionType
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

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x001F7FD4 File Offset: 0x001F61D4
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

		// Token: 0x06005661 RID: 22113 RVA: 0x001F800C File Offset: 0x001F620C
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x001F801C File Offset: 0x001F621C
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x001F8034 File Offset: 0x001F6234
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

		// Token: 0x06005664 RID: 22116 RVA: 0x001F8074 File Offset: 0x001F6274
		public DicStringString? PcKeys(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x001F80D8 File Offset: 0x001F62D8
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

		// Token: 0x06005666 RID: 22118 RVA: 0x001F8104 File Offset: 0x001F6304
		public DicStringString? FrancePcKeys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06005667 RID: 22119 RVA: 0x001F8168 File Offset: 0x001F6368
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

		// Token: 0x06005668 RID: 22120 RVA: 0x001F8194 File Offset: 0x001F6394
		public DicStringString? ThaiPcKeys(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x001F81F8 File Offset: 0x001F63F8
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

		// Token: 0x0600566A RID: 22122 RVA: 0x001F8224 File Offset: 0x001F6424
		public DicStringString? GamepadKeys(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x001F8288 File Offset: 0x001F6488
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x001F82B4 File Offset: 0x001F64B4
		public int SecondaryKeyValidTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600566D RID: 22125 RVA: 0x001F82F4 File Offset: 0x001F64F4
		public string MobileIconPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x001F832C File Offset: 0x001F652C
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x001F833C File Offset: 0x001F653C
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x001F8354 File Offset: 0x001F6554
		public string DisplayName
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

		// Token: 0x06005671 RID: 22129 RVA: 0x001F838C File Offset: 0x001F658C
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x001F839C File Offset: 0x001F659C
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x001F83B4 File Offset: 0x001F65B4
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x001F8418 File Offset: 0x001F6618
		public int KeyboardVersionMapLength
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

		// Token: 0x06005675 RID: 22133 RVA: 0x001F8444 File Offset: 0x001F6644
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x001F84A8 File Offset: 0x001F66A8
		public int GamepadVersionMapLength
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

		// Token: 0x06005677 RID: 22135 RVA: 0x001F84D4 File Offset: 0x001F66D4
		public string BlockInput(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x001F8510 File Offset: 0x001F6710
		public int BlockInputLength
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

		// Token: 0x06005679 RID: 22137 RVA: 0x001F853C File Offset: 0x001F673C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlockInputIter()或GetBlockInputBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BlockInput()
		{
			return this.BlockInputIter().ToArray<string>();
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x001F8549 File Offset: 0x001F6749
		[NullableContext(1)]
		public readonly IEnumerable<string> BlockInputIter()
		{
			CombinationAction.<BlockInputIter>d__54 <BlockInputIter>d__ = new CombinationAction.<BlockInputIter>d__54(-2);
			<BlockInputIter>d__.<>3__<>4__this = this;
			return <BlockInputIter>d__;
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x001F8560 File Offset: 0x001F6760
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FrancePcKeysFrozenDict()缓存字典，遍历请使用FrancePcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x001F85B6 File Offset: 0x001F67B6
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> FrancePcKeysIter()
		{
			CombinationAction.<FrancePcKeysIter>d__56 <FrancePcKeysIter>d__ = new CombinationAction.<FrancePcKeysIter>d__56(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x001F85CC File Offset: 0x001F67CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadKeysFrozenDict()缓存字典，遍历请使用GamepadKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> GamepadKeys()
		{
			return this.GamepadKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x001F8622 File Offset: 0x001F6822
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> GamepadKeysIter()
		{
			CombinationAction.<GamepadKeysIter>d__58 <GamepadKeysIter>d__ = new CombinationAction.<GamepadKeysIter>d__58(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x001F8638 File Offset: 0x001F6838
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadVersionMapFrozenDict()缓存字典，遍历请使用GamepadVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x001F868E File Offset: 0x001F688E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			CombinationAction.<GamepadVersionMapIter>d__60 <GamepadVersionMapIter>d__ = new CombinationAction.<GamepadVersionMapIter>d__60(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x001F86A4 File Offset: 0x001F68A4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用KeyboardVersionMapFrozenDict()缓存字典，遍历请使用KeyboardVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x001F86FA File Offset: 0x001F68FA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			CombinationAction.<KeyboardVersionMapIter>d__62 <KeyboardVersionMapIter>d__ = new CombinationAction.<KeyboardVersionMapIter>d__62(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x001F8710 File Offset: 0x001F6910
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PcKeysFrozenDict()缓存字典，遍历请使用PcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> PcKeys()
		{
			return this.PcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x001F8766 File Offset: 0x001F6966
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> PcKeysIter()
		{
			CombinationAction.<PcKeysIter>d__64 <PcKeysIter>d__ = new CombinationAction.<PcKeysIter>d__64(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x001F877C File Offset: 0x001F697C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ThaiPcKeysFrozenDict()缓存字典，遍历请使用ThaiPcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x001F87D2 File Offset: 0x001F69D2
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> ThaiPcKeysIter()
		{
			CombinationAction.<ThaiPcKeysIter>d__66 <ThaiPcKeysIter>d__ = new CombinationAction.<ThaiPcKeysIter>d__66(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x001F87E8 File Offset: 0x001F69E8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetFrancePcKeys(string key)
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			string result;
			if (!this.FrancePcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x001F8810 File Offset: 0x001F6A10
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetGamepadKeys(string key)
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			string result;
			if (!this.GamepadKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x001F8838 File Offset: 0x001F6A38
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

		// Token: 0x0600568A RID: 22154 RVA: 0x001F886C File Offset: 0x001F6A6C
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

		// Token: 0x0600568B RID: 22155 RVA: 0x001F88A0 File Offset: 0x001F6AA0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetPcKeys(string key)
		{
			this.EnsurePcKeysCacheIfNeeded();
			string result;
			if (!this.PcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x001F88C8 File Offset: 0x001F6AC8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetThaiPcKeys(string key)
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			string result;
			if (!this.ThaiPcKeysCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x001F88F0 File Offset: 0x001F6AF0
		private void EnsureFrancePcKeysCacheIfNeeded()
		{
			if (this.FrancePcKeysCache != null)
			{
				return;
			}
			this.FrancePcKeysCache = this.FrancePcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x001F8958 File Offset: 0x001F6B58
		private void EnsureGamepadKeysCacheIfNeeded()
		{
			if (this.GamepadKeysCache != null)
			{
				return;
			}
			this.GamepadKeysCache = this.GamepadKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x001F89C0 File Offset: 0x001F6BC0
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x001F8A28 File Offset: 0x001F6C28
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x001F8A90 File Offset: 0x001F6C90
		private void EnsurePcKeysCacheIfNeeded()
		{
			if (this.PcKeysCache != null)
			{
				return;
			}
			this.PcKeysCache = this.PcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x001F8AF8 File Offset: 0x001F6CF8
		private void EnsureThaiPcKeysCacheIfNeeded()
		{
			if (this.ThaiPcKeysCache != null)
			{
				return;
			}
			this.ThaiPcKeysCache = this.ThaiPcKeysIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x001F8B5E File Offset: 0x001F6D5E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetFrancePcKeysFrozenDict(string key)
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			return this.FrancePcKeysCache;
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x001F8B6C File Offset: 0x001F6D6C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetGamepadKeysFrozenDict(string key)
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			return this.GamepadKeysCache;
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x001F8B7A File Offset: 0x001F6D7A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x001F8B88 File Offset: 0x001F6D88
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x001F8B96 File Offset: 0x001F6D96
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetPcKeysFrozenDict(string key)
		{
			this.EnsurePcKeysCacheIfNeeded();
			return this.PcKeysCache;
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x001F8BA4 File Offset: 0x001F6DA4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetThaiPcKeysFrozenDict(string key)
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			return this.ThaiPcKeysCache;
		}

		// Token: 0x04004B8A RID: 19338
		private Table __p;

		// Token: 0x04004B8B RID: 19339
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> FrancePcKeysCache;

		// Token: 0x04004B8C RID: 19340
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> GamepadKeysCache;

		// Token: 0x04004B8D RID: 19341
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04004B8E RID: 19342
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x04004B8F RID: 19343
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> PcKeysCache;

		// Token: 0x04004B90 RID: 19344
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ThaiPcKeysCache;
	}
}
