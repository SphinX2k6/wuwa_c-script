using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B18 RID: 2840
	public struct AxisMapping : IFlatbufferObject
	{
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06004A1E RID: 18974 RVA: 0x001DB2FC File Offset: 0x001D94FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x001DB309 File Offset: 0x001D9509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x001DB310 File Offset: 0x001D9510
		public static AxisMapping GetRootAsAxisMapping(ByteBuffer _bb)
		{
			return AxisMapping.GetRootAsAxisMapping(_bb, default(AxisMapping));
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x001DB32C File Offset: 0x001D952C
		public static AxisMapping GetRootAsAxisMapping(ByteBuffer _bb, AxisMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x001DB349 File Offset: 0x001D9549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x001DB358 File Offset: 0x001D9558
		public AxisMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x001DB368 File Offset: 0x001D9568
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

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x001DB3A4 File Offset: 0x001D95A4
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

		// Token: 0x06004A26 RID: 18982 RVA: 0x001DB3DB File Offset: 0x001D95DB
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x001DB3EA File Offset: 0x001D95EA
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06004A28 RID: 18984 RVA: 0x001DB404 File Offset: 0x001D9604
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x001DB440 File Offset: 0x001D9640
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

		// Token: 0x06004A2A RID: 18986 RVA: 0x001DB478 File Offset: 0x001D9678
		public Span<byte> GetInputTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x001DB488 File Offset: 0x001D9688
		public byte[] GetInputTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06004A2C RID: 18988 RVA: 0x001DB4A0 File Offset: 0x001D96A0
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

		// Token: 0x06004A2D RID: 18989 RVA: 0x001DB4E0 File Offset: 0x001D96E0
		public DicStringFloat? PcKeys(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06004A2E RID: 18990 RVA: 0x001DB544 File Offset: 0x001D9744
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

		// Token: 0x06004A2F RID: 18991 RVA: 0x001DB570 File Offset: 0x001D9770
		public DicStringFloat? FrancePcKeys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06004A30 RID: 18992 RVA: 0x001DB5D4 File Offset: 0x001D97D4
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

		// Token: 0x06004A31 RID: 18993 RVA: 0x001DB600 File Offset: 0x001D9800
		public DicStringFloat? ThaiPcKeys(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06004A32 RID: 18994 RVA: 0x001DB664 File Offset: 0x001D9864
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

		// Token: 0x06004A33 RID: 18995 RVA: 0x001DB690 File Offset: 0x001D9890
		public DicStringFloat? GamepadKeys(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringFloat?(default(DicStringFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06004A34 RID: 18996 RVA: 0x001DB6F4 File Offset: 0x001D98F4
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x001DB720 File Offset: 0x001D9920
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

		// Token: 0x06004A36 RID: 18998 RVA: 0x001DB758 File Offset: 0x001D9958
		public Span<byte> GetDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x001DB768 File Offset: 0x001D9968
		public byte[] GetDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x001DB780 File Offset: 0x001D9980
		public DicIntInt? KeyboardVersionMap(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x001DB7E4 File Offset: 0x001D99E4
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

		// Token: 0x06004A3A RID: 19002 RVA: 0x001DB810 File Offset: 0x001D9A10
		public DicIntInt? GamepadVersionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x001DB874 File Offset: 0x001D9A74
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

		// Token: 0x06004A3C RID: 19004 RVA: 0x001DB8A0 File Offset: 0x001D9AA0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FrancePcKeysFrozenDict()缓存字典，遍历请使用FrancePcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> FrancePcKeys()
		{
			return this.FrancePcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x001DB8F6 File Offset: 0x001D9AF6
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> FrancePcKeysIter()
		{
			AxisMapping.<FrancePcKeysIter>d__45 <FrancePcKeysIter>d__ = new AxisMapping.<FrancePcKeysIter>d__45(-2);
			<FrancePcKeysIter>d__.<>3__<>4__this = this;
			return <FrancePcKeysIter>d__;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x001DB90C File Offset: 0x001D9B0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadKeysFrozenDict()缓存字典，遍历请使用GamepadKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> GamepadKeys()
		{
			return this.GamepadKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x001DB962 File Offset: 0x001D9B62
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> GamepadKeysIter()
		{
			AxisMapping.<GamepadKeysIter>d__47 <GamepadKeysIter>d__ = new AxisMapping.<GamepadKeysIter>d__47(-2);
			<GamepadKeysIter>d__.<>3__<>4__this = this;
			return <GamepadKeysIter>d__;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x001DB978 File Offset: 0x001D9B78
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GamepadVersionMapFrozenDict()缓存字典，遍历请使用GamepadVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> GamepadVersionMap()
		{
			return this.GamepadVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x001DB9CE File Offset: 0x001D9BCE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> GamepadVersionMapIter()
		{
			AxisMapping.<GamepadVersionMapIter>d__49 <GamepadVersionMapIter>d__ = new AxisMapping.<GamepadVersionMapIter>d__49(-2);
			<GamepadVersionMapIter>d__.<>3__<>4__this = this;
			return <GamepadVersionMapIter>d__;
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x001DB9E4 File Offset: 0x001D9BE4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用KeyboardVersionMapFrozenDict()缓存字典，遍历请使用KeyboardVersionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> KeyboardVersionMap()
		{
			return this.KeyboardVersionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x001DBA3A File Offset: 0x001D9C3A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> KeyboardVersionMapIter()
		{
			AxisMapping.<KeyboardVersionMapIter>d__51 <KeyboardVersionMapIter>d__ = new AxisMapping.<KeyboardVersionMapIter>d__51(-2);
			<KeyboardVersionMapIter>d__.<>3__<>4__this = this;
			return <KeyboardVersionMapIter>d__;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x001DBA50 File Offset: 0x001D9C50
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PcKeysFrozenDict()缓存字典，遍历请使用PcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> PcKeys()
		{
			return this.PcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x001DBAA6 File Offset: 0x001D9CA6
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> PcKeysIter()
		{
			AxisMapping.<PcKeysIter>d__53 <PcKeysIter>d__ = new AxisMapping.<PcKeysIter>d__53(-2);
			<PcKeysIter>d__.<>3__<>4__this = this;
			return <PcKeysIter>d__;
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x001DBABC File Offset: 0x001D9CBC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ThaiPcKeysFrozenDict()缓存字典，遍历请使用ThaiPcKeysIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, float> ThaiPcKeys()
		{
			return this.ThaiPcKeysIter().ToDictionary((DicStringFloat element) => element.Key, (DicStringFloat element) => element.Value);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x001DBB12 File Offset: 0x001D9D12
		[NullableContext(1)]
		public readonly IEnumerable<DicStringFloat> ThaiPcKeysIter()
		{
			AxisMapping.<ThaiPcKeysIter>d__55 <ThaiPcKeysIter>d__ = new AxisMapping.<ThaiPcKeysIter>d__55(-2);
			<ThaiPcKeysIter>d__.<>3__<>4__this = this;
			return <ThaiPcKeysIter>d__;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x001DBB28 File Offset: 0x001D9D28
		[NullableContext(1)]
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

		// Token: 0x06004A49 RID: 19017 RVA: 0x001DBB5C File Offset: 0x001D9D5C
		[NullableContext(1)]
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

		// Token: 0x06004A4A RID: 19018 RVA: 0x001DBB90 File Offset: 0x001D9D90
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

		// Token: 0x06004A4B RID: 19019 RVA: 0x001DBBC4 File Offset: 0x001D9DC4
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

		// Token: 0x06004A4C RID: 19020 RVA: 0x001DBBF8 File Offset: 0x001D9DF8
		[NullableContext(1)]
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

		// Token: 0x06004A4D RID: 19021 RVA: 0x001DBC2C File Offset: 0x001D9E2C
		[NullableContext(1)]
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

		// Token: 0x06004A4E RID: 19022 RVA: 0x001DBC60 File Offset: 0x001D9E60
		private void EnsureFrancePcKeysCacheIfNeeded()
		{
			if (this.FrancePcKeysCache != null)
			{
				return;
			}
			this.FrancePcKeysCache = this.FrancePcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x001DBCC8 File Offset: 0x001D9EC8
		private void EnsureGamepadKeysCacheIfNeeded()
		{
			if (this.GamepadKeysCache != null)
			{
				return;
			}
			this.GamepadKeysCache = this.GamepadKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x001DBD30 File Offset: 0x001D9F30
		private void EnsureGamepadVersionMapCacheIfNeeded()
		{
			if (this.GamepadVersionMapCache != null)
			{
				return;
			}
			this.GamepadVersionMapCache = this.GamepadVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x001DBD98 File Offset: 0x001D9F98
		private void EnsureKeyboardVersionMapCacheIfNeeded()
		{
			if (this.KeyboardVersionMapCache != null)
			{
				return;
			}
			this.KeyboardVersionMapCache = this.KeyboardVersionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x001DBE00 File Offset: 0x001DA000
		private void EnsurePcKeysCacheIfNeeded()
		{
			if (this.PcKeysCache != null)
			{
				return;
			}
			this.PcKeysCache = this.PcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x001DBE68 File Offset: 0x001DA068
		private void EnsureThaiPcKeysCacheIfNeeded()
		{
			if (this.ThaiPcKeysCache != null)
			{
				return;
			}
			this.ThaiPcKeysCache = this.ThaiPcKeysIter().ToFrozenDictionary((DicStringFloat kvp) => kvp.Key, (DicStringFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x001DBECE File Offset: 0x001DA0CE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetFrancePcKeysFrozenDict(string key)
		{
			this.EnsureFrancePcKeysCacheIfNeeded();
			return this.FrancePcKeysCache;
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x001DBEDC File Offset: 0x001DA0DC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetGamepadKeysFrozenDict(string key)
		{
			this.EnsureGamepadKeysCacheIfNeeded();
			return this.GamepadKeysCache;
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x001DBEEA File Offset: 0x001DA0EA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetGamepadVersionMapFrozenDict(int key)
		{
			this.EnsureGamepadVersionMapCacheIfNeeded();
			return this.GamepadVersionMapCache;
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x001DBEF8 File Offset: 0x001DA0F8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetKeyboardVersionMapFrozenDict(int key)
		{
			this.EnsureKeyboardVersionMapCacheIfNeeded();
			return this.KeyboardVersionMapCache;
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x001DBF06 File Offset: 0x001DA106
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetPcKeysFrozenDict(string key)
		{
			this.EnsurePcKeysCacheIfNeeded();
			return this.PcKeysCache;
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x001DBF14 File Offset: 0x001DA114
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, float> GetThaiPcKeysFrozenDict(string key)
		{
			this.EnsureThaiPcKeysCacheIfNeeded();
			return this.ThaiPcKeysCache;
		}

		// Token: 0x04004B00 RID: 19200
		private Table __p;

		// Token: 0x04004B01 RID: 19201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> FrancePcKeysCache;

		// Token: 0x04004B02 RID: 19202
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> GamepadKeysCache;

		// Token: 0x04004B03 RID: 19203
		[Nullable(2)]
		private FrozenDictionary<int, int> GamepadVersionMapCache;

		// Token: 0x04004B04 RID: 19204
		[Nullable(2)]
		private FrozenDictionary<int, int> KeyboardVersionMapCache;

		// Token: 0x04004B05 RID: 19205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> PcKeysCache;

		// Token: 0x04004B06 RID: 19206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, float> ThaiPcKeysCache;
	}
}
