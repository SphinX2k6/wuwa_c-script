using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001181 RID: 4481
	public struct UiCameraMapping : IFlatbufferObject
	{
		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x0033DE71 File Offset: 0x0033C071
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x0033DE7E File Offset: 0x0033C07E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x0033DE88 File Offset: 0x0033C088
		public static UiCameraMapping GetRootAsUiCameraMapping(ByteBuffer _bb)
		{
			return UiCameraMapping.GetRootAsUiCameraMapping(_bb, default(UiCameraMapping));
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x0033DEA4 File Offset: 0x0033C0A4
		public static UiCameraMapping GetRootAsUiCameraMapping(ByteBuffer _bb, UiCameraMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x0033DEC1 File Offset: 0x0033C0C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x0033DED0 File Offset: 0x0033C0D0
		public UiCameraMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x0033DEE0 File Offset: 0x0033C0E0
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

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600E5F2 RID: 58866 RVA: 0x0033DF1C File Offset: 0x0033C11C
		public string ViewName
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

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x0033DF53 File Offset: 0x0033C153
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x0033DF62 File Offset: 0x0033C162
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600E5F5 RID: 58869 RVA: 0x0033DF7C File Offset: 0x0033C17C
		public string DefaultUiCameraSettingsName
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

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x0033DFB3 File Offset: 0x0033C1B3
		public Span<byte> GetDefaultUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x0033DFC2 File Offset: 0x0033C1C2
		public byte[] GetDefaultUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x0033DFDC File Offset: 0x0033C1DC
		public bool IsCheckSpecialState
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x0033E01C File Offset: 0x0033C21C
		public string SpecialStateCameraSettingName
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

		// Token: 0x0600E5FA RID: 58874 RVA: 0x0033E054 File Offset: 0x0033C254
		public Span<byte> GetSpecialStateCameraSettingNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x0033E064 File Offset: 0x0033C264
		public byte[] GetSpecialStateCameraSettingNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600E5FC RID: 58876 RVA: 0x0033E07C File Offset: 0x0033C27C
		public bool BPlayLoadingCameraAnimation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600E5FD RID: 58877 RVA: 0x0033E0BC File Offset: 0x0033C2BC
		public int BodyTargetType
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

		// Token: 0x0600E5FE RID: 58878 RVA: 0x0033E0FC File Offset: 0x0033C2FC
		public DicStringString? BodyCameraSettingsNameMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x0033E160 File Offset: 0x0033C360
		public int BodyCameraSettingsNameMapLength
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

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600E600 RID: 58880 RVA: 0x0033E18C File Offset: 0x0033C38C
		public string DefaultCameraBlendName
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

		// Token: 0x0600E601 RID: 58881 RVA: 0x0033E1C4 File Offset: 0x0033C3C4
		public Span<byte> GetDefaultCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E602 RID: 58882 RVA: 0x0033E1D4 File Offset: 0x0033C3D4
		public byte[] GetDefaultCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E603 RID: 58883 RVA: 0x0033E1EC File Offset: 0x0033C3EC
		public DicStringString? UiCameraBlendNameMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x0033E250 File Offset: 0x0033C450
		public int UiCameraBlendNameMapLength
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

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x0033E27C File Offset: 0x0033C47C
		public int UiCameraDelayTime
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

		// Token: 0x0600E606 RID: 58886 RVA: 0x0033E2BC File Offset: 0x0033C4BC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BodyCameraSettingsNameMapFrozenDict()缓存字典，遍历请使用BodyCameraSettingsNameMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> BodyCameraSettingsNameMap()
		{
			return this.BodyCameraSettingsNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600E607 RID: 58887 RVA: 0x0033E312 File Offset: 0x0033C512
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> BodyCameraSettingsNameMapIter()
		{
			UiCameraMapping.<BodyCameraSettingsNameMapIter>d__41 <BodyCameraSettingsNameMapIter>d__ = new UiCameraMapping.<BodyCameraSettingsNameMapIter>d__41(-2);
			<BodyCameraSettingsNameMapIter>d__.<>3__<>4__this = this;
			return <BodyCameraSettingsNameMapIter>d__;
		}

		// Token: 0x0600E608 RID: 58888 RVA: 0x0033E328 File Offset: 0x0033C528
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UiCameraBlendNameMapFrozenDict()缓存字典，遍历请使用UiCameraBlendNameMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> UiCameraBlendNameMap()
		{
			return this.UiCameraBlendNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600E609 RID: 58889 RVA: 0x0033E37E File Offset: 0x0033C57E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> UiCameraBlendNameMapIter()
		{
			UiCameraMapping.<UiCameraBlendNameMapIter>d__43 <UiCameraBlendNameMapIter>d__ = new UiCameraMapping.<UiCameraBlendNameMapIter>d__43(-2);
			<UiCameraBlendNameMapIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendNameMapIter>d__;
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x0033E394 File Offset: 0x0033C594
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetBodyCameraSettingsNameMap(string key)
		{
			this.EnsureBodyCameraSettingsNameMapCacheIfNeeded();
			string result;
			if (!this.BodyCameraSettingsNameMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600E60B RID: 58891 RVA: 0x0033E3BC File Offset: 0x0033C5BC
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetUiCameraBlendNameMap(string key)
		{
			this.EnsureUiCameraBlendNameMapCacheIfNeeded();
			string result;
			if (!this.UiCameraBlendNameMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600E60C RID: 58892 RVA: 0x0033E3E4 File Offset: 0x0033C5E4
		private void EnsureBodyCameraSettingsNameMapCacheIfNeeded()
		{
			if (this.BodyCameraSettingsNameMapCache != null)
			{
				return;
			}
			this.BodyCameraSettingsNameMapCache = this.BodyCameraSettingsNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E60D RID: 58893 RVA: 0x0033E44C File Offset: 0x0033C64C
		private void EnsureUiCameraBlendNameMapCacheIfNeeded()
		{
			if (this.UiCameraBlendNameMapCache != null)
			{
				return;
			}
			this.UiCameraBlendNameMapCache = this.UiCameraBlendNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E60E RID: 58894 RVA: 0x0033E4B2 File Offset: 0x0033C6B2
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetBodyCameraSettingsNameMapFrozenDict(string key)
		{
			this.EnsureBodyCameraSettingsNameMapCacheIfNeeded();
			return this.BodyCameraSettingsNameMapCache;
		}

		// Token: 0x0600E60F RID: 58895 RVA: 0x0033E4C0 File Offset: 0x0033C6C0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetUiCameraBlendNameMapFrozenDict(string key)
		{
			this.EnsureUiCameraBlendNameMapCacheIfNeeded();
			return this.UiCameraBlendNameMapCache;
		}

		// Token: 0x040052C8 RID: 21192
		private Table __p;

		// Token: 0x040052C9 RID: 21193
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> BodyCameraSettingsNameMapCache;

		// Token: 0x040052CA RID: 21194
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraBlendNameMapCache;
	}
}
