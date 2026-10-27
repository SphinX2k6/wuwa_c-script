using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B87 RID: 2951
	public struct CombinationAxis : IFlatbufferObject
	{
		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x001F8BB2 File Offset: 0x001F6DB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x001F8BBF File Offset: 0x001F6DBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x001F8BC8 File Offset: 0x001F6DC8
		public static CombinationAxis GetRootAsCombinationAxis(ByteBuffer _bb)
		{
			return CombinationAxis.GetRootAsCombinationAxis(_bb, default(CombinationAxis));
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x001F8BE4 File Offset: 0x001F6DE4
		public static CombinationAxis GetRootAsCombinationAxis(ByteBuffer _bb, CombinationAxis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x001F8C01 File Offset: 0x001F6E01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x001F8C10 File Offset: 0x001F6E10
		public CombinationAxis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x001F8C20 File Offset: 0x001F6E20
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060056A0 RID: 22176 RVA: 0x001F8C5C File Offset: 0x001F6E5C
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

		// Token: 0x060056A1 RID: 22177 RVA: 0x001F8C93 File Offset: 0x001F6E93
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x001F8CA2 File Offset: 0x001F6EA2
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060056A3 RID: 22179 RVA: 0x001F8CBC File Offset: 0x001F6EBC
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

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060056A4 RID: 22180 RVA: 0x001F8CF8 File Offset: 0x001F6EF8
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

		// Token: 0x060056A5 RID: 22181 RVA: 0x001F8D30 File Offset: 0x001F6F30
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x001F8D40 File Offset: 0x001F6F40
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060056A7 RID: 22183 RVA: 0x001F8D58 File Offset: 0x001F6F58
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

		// Token: 0x060056A8 RID: 22184 RVA: 0x001F8D98 File Offset: 0x001F6F98
		public DicStringString? PcKeyMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060056A9 RID: 22185 RVA: 0x001F8DFC File Offset: 0x001F6FFC
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

		// Token: 0x060056AA RID: 22186 RVA: 0x001F8E28 File Offset: 0x001F7028
		public DicStringString? GamepadKeyMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060056AB RID: 22187 RVA: 0x001F8E8C File Offset: 0x001F708C
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

		// Token: 0x060056AC RID: 22188 RVA: 0x001F8EB8 File Offset: 0x001F70B8
		public DicStringFloat? SecondaryKeyScaleMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060056AD RID: 22189 RVA: 0x001F8F1C File Offset: 0x001F711C
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

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x001F8F48 File Offset: 0x001F7148
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

		// Token: 0x060056AF RID: 22191 RVA: 0x001F8F80 File Offset: 0x001F7180
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x001F8F90 File Offset: 0x001F7190
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060056B1 RID: 22193 RVA: 0x001F8FA8 File Offset: 0x001F71A8
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

		// Token: 0x060056B2 RID: 22194 RVA: 0x001F8FE0 File Offset: 0x001F71E0
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x001F8FF0 File Offset: 0x001F71F0
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x001F9008 File Offset: 0x001F7208
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060056B5 RID: 22197 RVA: 0x001F906C File Offset: 0x001F726C
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

		// Token: 0x060056B6 RID: 22198 RVA: 0x001F9098 File Offset: 0x001F7298
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060056B7 RID: 22199 RVA: 0x001F90FC File Offset: 0x001F72FC
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

		// Token: 0x060056B8 RID: 22200 RVA: 0x001F9128 File Offset: 0x001F7328
		public string BlockInput(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060056B9 RID: 22201 RVA: 0x001F9164 File Offset: 0x001F7364
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

		// Token: 0x060056BA RID: 22202 RVA: 0x001F9190 File Offset: 0x001F7390
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlockInputIter()或GetBlockInputBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BlockInput()
		{
			return this.BlockInputIter().ToArray<string>();
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x001F919D File Offset: 0x001F739D
		[NullableContext(1)]
		public readonly IEnumerable<string> BlockInputIter()
		{
			CombinationAxis.<BlockInputIter>d__49 <BlockInputIter>d__ = new CombinationAxis.<BlockInputIter>d__49(-2);
			<BlockInputIter>d__.<>3__<>4__this = this;
			return <BlockInputIter>d__;
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x001F91B4 File Offset: 0x001F73B4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadKeyMapFrozenDict()缓存字典，遍历请使用GamepadKeyMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> GamepadKeyMap()
		{
			return this.GamepadKeyMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x001F920A File Offset: 0x001F740A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> GamepadKeyMapIter()
		{
			CombinationAxis.<GamepadKeyMapIter>d__51 <GamepadKeyMapIter>d__ = new CombinationAxis.<GamepadKeyMapIter>d__51(-2);
			<GamepadKeyMapIter>d__.<>3__<>4__this = this;
			return <GamepadKeyMapIter>d__;
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x001F9220 File Offset: 0x001F7420
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadVersionMapFrozenDict()缓存字典，遍历请使用GamepadVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x001F9276 File Offset: 0x001F7476
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			CombinationAxis.<GamepadVersionMapIter>d__53 <GamepadVersionMapIter>d__ = new CombinationAxis.<GamepadVersionMapIter>d__53(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x001F928C File Offset: 0x001F748C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用KeyboardVersionMapFrozenDict()缓存字典，遍历请使用KeyboardVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x001F92E2 File Offset: 0x001F74E2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			CombinationAxis.<KeyboardVersionMapIter>d__55 <KeyboardVersionMapIter>d__ = new CombinationAxis.<KeyboardVersionMapIter>d__55(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x001F92F8 File Offset: 0x001F74F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PcKeyMapFrozenDict()缓存字典，遍历请使用PcKeyMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> PcKeyMap()
		{
			return this.PcKeyMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x001F934E File Offset: 0x001F754E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> PcKeyMapIter()
		{
			CombinationAxis.<PcKeyMapIter>d__57 <PcKeyMapIter>d__ = new CombinationAxis.<PcKeyMapIter>d__57(-2);
			<PcKeyMapIter>d__.<>3__<>4__this = this;
			return <PcKeyMapIter>d__;
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x001F9364 File Offset: 0x001F7564
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SecondaryKeyScaleMapFrozenDict()缓存字典，遍历请使用SecondaryKeyScaleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> SecondaryKeyScaleMap()
		{
			return this.SecondaryKeyScaleMapIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x001F93BA File Offset: 0x001F75BA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> SecondaryKeyScaleMapIter()
		{
			CombinationAxis.<SecondaryKeyScaleMapIter>d__59 <SecondaryKeyScaleMapIter>d__ = new CombinationAxis.<SecondaryKeyScaleMapIter>d__59(-2);
			<SecondaryKeyScaleMapIter>d__.<>3__<>4__this = this;
			return <SecondaryKeyScaleMapIter>d__;
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x001F93D0 File Offset: 0x001F75D0
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

		// Token: 0x060056C7 RID: 22215 RVA: 0x001F93F8 File Offset: 0x001F75F8
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

		// Token: 0x060056C8 RID: 22216 RVA: 0x001F942C File Offset: 0x001F762C
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

		// Token: 0x060056C9 RID: 22217 RVA: 0x001F9460 File Offset: 0x001F7660
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

		// Token: 0x060056CA RID: 22218 RVA: 0x001F9488 File Offset: 0x001F7688
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

		// Token: 0x060056CB RID: 22219 RVA: 0x001F94BC File Offset: 0x001F76BC
		private void EnsureGamepadKeyMapCacheIfNeeded()
		{
			if (this.GamepadKeyMapCache != null)
			{
				return;
			}
			this.GamepadKeyMapCache = this.GamepadKeyMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x001F9524 File Offset: 0x001F7724
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x001F958C File Offset: 0x001F778C
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x001F95F4 File Offset: 0x001F77F4
		private void EnsurePcKeyMapCacheIfNeeded()
		{
			if (this.PcKeyMapCache != null)
			{
				return;
			}
			this.PcKeyMapCache = this.PcKeyMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x001F965C File Offset: 0x001F785C
		private void EnsureSecondaryKeyScaleMapCacheIfNeeded()
		{
			if (this.SecondaryKeyScaleMapCache != null)
			{
				return;
			}
			this.SecondaryKeyScaleMapCache = this.SecondaryKeyScaleMapIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x001F96C2 File Offset: 0x001F78C2
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetGamepadKeyMapFrozenDict(string key)
		{
			this.EnsureGamepadKeyMapCacheIfNeeded();
			return this.GamepadKeyMapCache;
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x001F96D0 File Offset: 0x001F78D0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x001F96DE File Offset: 0x001F78DE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x001F96EC File Offset: 0x001F78EC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetPcKeyMapFrozenDict(string key)
		{
			this.EnsurePcKeyMapCacheIfNeeded();
			return this.PcKeyMapCache;
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x001F96FA File Offset: 0x001F78FA
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetSecondaryKeyScaleMapFrozenDict(string key)
		{
			this.EnsureSecondaryKeyScaleMapCacheIfNeeded();
			return this.SecondaryKeyScaleMapCache;
		}

		// Token: 0x04004B91 RID: 19345
		private Table __p;

		// Token: 0x04004B92 RID: 19346
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> GamepadKeyMapCache;

		// Token: 0x04004B93 RID: 19347
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04004B94 RID: 19348
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x04004B95 RID: 19349
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> PcKeyMapCache;

		// Token: 0x04004B96 RID: 19350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> SecondaryKeyScaleMapCache;
	}
}
