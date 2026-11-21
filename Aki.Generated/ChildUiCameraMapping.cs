using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C52 RID: 3154
	public struct ChildUiCameraMapping : IFlatbufferObject
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06005A7F RID: 23167 RVA: 0x00214089 File Offset: 0x00212289
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x00214096 File Offset: 0x00212296
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x002140A0 File Offset: 0x002122A0
		public static ChildUiCameraMapping GetRootAsChildUiCameraMapping(ByteBuffer _bb)
		{
			return ChildUiCameraMapping.GetRootAsChildUiCameraMapping(_bb, default(ChildUiCameraMapping));
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x002140BC File Offset: 0x002122BC
		public static ChildUiCameraMapping GetRootAsChildUiCameraMapping(ByteBuffer _bb, ChildUiCameraMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x002140D9 File Offset: 0x002122D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x002140E8 File Offset: 0x002122E8
		public ChildUiCameraMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06005A85 RID: 23173 RVA: 0x002140F8 File Offset: 0x002122F8
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00214134 File Offset: 0x00212334
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

		// Token: 0x06005A87 RID: 23175 RVA: 0x0021416B File Offset: 0x0021236B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x0021417A File Offset: 0x0021237A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06005A89 RID: 23177 RVA: 0x00214194 File Offset: 0x00212394
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

		// Token: 0x06005A8A RID: 23178 RVA: 0x002141CB File Offset: 0x002123CB
		public Span<byte> GetDefaultUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x002141DA File Offset: 0x002123DA
		public byte[] GetDefaultUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06005A8C RID: 23180 RVA: 0x002141F4 File Offset: 0x002123F4
		public bool IsCheckSpecialState
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06005A8D RID: 23181 RVA: 0x00214234 File Offset: 0x00212434
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

		// Token: 0x06005A8E RID: 23182 RVA: 0x0021426C File Offset: 0x0021246C
		public Span<byte> GetSpecialStateCameraSettingNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x0021427C File Offset: 0x0021247C
		public byte[] GetSpecialStateCameraSettingNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x00214294 File Offset: 0x00212494
		public bool BPlayLoadingCameraAnimation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06005A91 RID: 23185 RVA: 0x002142D4 File Offset: 0x002124D4
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

		// Token: 0x06005A92 RID: 23186 RVA: 0x00214314 File Offset: 0x00212514
		public DicStringString? BodyCameraSettingsNameMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06005A93 RID: 23187 RVA: 0x00214378 File Offset: 0x00212578
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x002143A4 File Offset: 0x002125A4
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

		// Token: 0x06005A95 RID: 23189 RVA: 0x002143DC File Offset: 0x002125DC
		public Span<byte> GetDefaultCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x002143EC File Offset: 0x002125EC
		public byte[] GetDefaultCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00214404 File Offset: 0x00212604
		public DicStringString? UiCameraBlendNameMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x00214468 File Offset: 0x00212668
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

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x00214494 File Offset: 0x00212694
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

		// Token: 0x06005A9A RID: 23194 RVA: 0x002144D4 File Offset: 0x002126D4
		[NullableContext(1)]
		public Dictionary<string, string> BodyCameraSettingsNameMap()
		{
			return this.BodyCameraSettingsNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x0021452A File Offset: 0x0021272A
		[NullableContext(1)]
		public IEnumerable<DicStringString> BodyCameraSettingsNameMapIter()
		{
			ChildUiCameraMapping.<BodyCameraSettingsNameMapIter>d__41 <BodyCameraSettingsNameMapIter>d__ = new ChildUiCameraMapping.<BodyCameraSettingsNameMapIter>d__41(-2);
			<BodyCameraSettingsNameMapIter>d__.<>3__<>4__this = this;
			return <BodyCameraSettingsNameMapIter>d__;
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00214540 File Offset: 0x00212740
		[NullableContext(1)]
		public Dictionary<string, string> UiCameraBlendNameMap()
		{
			return this.UiCameraBlendNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x00214596 File Offset: 0x00212796
		[NullableContext(1)]
		public IEnumerable<DicStringString> UiCameraBlendNameMapIter()
		{
			ChildUiCameraMapping.<UiCameraBlendNameMapIter>d__43 <UiCameraBlendNameMapIter>d__ = new ChildUiCameraMapping.<UiCameraBlendNameMapIter>d__43(-2);
			<UiCameraBlendNameMapIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendNameMapIter>d__;
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x002145AC File Offset: 0x002127AC
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

		// Token: 0x06005A9F RID: 23199 RVA: 0x002145D4 File Offset: 0x002127D4
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

		// Token: 0x06005AA0 RID: 23200 RVA: 0x002145FC File Offset: 0x002127FC
		private void EnsureBodyCameraSettingsNameMapCacheIfNeeded()
		{
			if (this.BodyCameraSettingsNameMapCache != null)
			{
				return;
			}
			this.BodyCameraSettingsNameMapCache = this.BodyCameraSettingsNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00214664 File Offset: 0x00212864
		private void EnsureUiCameraBlendNameMapCacheIfNeeded()
		{
			if (this.UiCameraBlendNameMapCache != null)
			{
				return;
			}
			this.UiCameraBlendNameMapCache = this.UiCameraBlendNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x002146CA File Offset: 0x002128CA
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetBodyCameraSettingsNameMapFrozenDict()
		{
			this.EnsureBodyCameraSettingsNameMapCacheIfNeeded();
			return this.BodyCameraSettingsNameMapCache;
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x002146D8 File Offset: 0x002128D8
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetUiCameraBlendNameMapFrozenDict()
		{
			this.EnsureUiCameraBlendNameMapCacheIfNeeded();
			return this.UiCameraBlendNameMapCache;
		}

		// Token: 0x04005154 RID: 20820
		private Table __p;

		// Token: 0x04005155 RID: 20821
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> BodyCameraSettingsNameMapCache;

		// Token: 0x04005156 RID: 20822
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraBlendNameMapCache;
	}
}
