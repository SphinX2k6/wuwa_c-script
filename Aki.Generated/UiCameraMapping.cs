using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B7 RID: 4791
	public struct UiCameraMapping : IFlatbufferObject
	{
		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0600F359 RID: 62297 RVA: 0x00368C69 File Offset: 0x00366E69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x00368C76 File Offset: 0x00366E76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x00368C80 File Offset: 0x00366E80
		public static UiCameraMapping GetRootAsUiCameraMapping(ByteBuffer _bb)
		{
			return UiCameraMapping.GetRootAsUiCameraMapping(_bb, default(UiCameraMapping));
		}

		// Token: 0x0600F35C RID: 62300 RVA: 0x00368C9C File Offset: 0x00366E9C
		public static UiCameraMapping GetRootAsUiCameraMapping(ByteBuffer _bb, UiCameraMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F35D RID: 62301 RVA: 0x00368CB9 File Offset: 0x00366EB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F35E RID: 62302 RVA: 0x00368CC8 File Offset: 0x00366EC8
		public UiCameraMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0600F35F RID: 62303 RVA: 0x00368CD8 File Offset: 0x00366ED8
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

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0600F360 RID: 62304 RVA: 0x00368D14 File Offset: 0x00366F14
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

		// Token: 0x0600F361 RID: 62305 RVA: 0x00368D4B File Offset: 0x00366F4B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F362 RID: 62306 RVA: 0x00368D5A File Offset: 0x00366F5A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0600F363 RID: 62307 RVA: 0x00368D74 File Offset: 0x00366F74
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

		// Token: 0x0600F364 RID: 62308 RVA: 0x00368DAB File Offset: 0x00366FAB
		public Span<byte> GetDefaultUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x00368DBA File Offset: 0x00366FBA
		public byte[] GetDefaultUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0600F366 RID: 62310 RVA: 0x00368DD4 File Offset: 0x00366FD4
		public bool IsCheckSpecialState
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x0600F367 RID: 62311 RVA: 0x00368E14 File Offset: 0x00367014
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

		// Token: 0x0600F368 RID: 62312 RVA: 0x00368E4C File Offset: 0x0036704C
		public Span<byte> GetSpecialStateCameraSettingNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x00368E5C File Offset: 0x0036705C
		public byte[] GetSpecialStateCameraSettingNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x0600F36A RID: 62314 RVA: 0x00368E74 File Offset: 0x00367074
		public bool BPlayLoadingCameraAnimation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x0600F36B RID: 62315 RVA: 0x00368EB4 File Offset: 0x003670B4
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

		// Token: 0x0600F36C RID: 62316 RVA: 0x00368EF4 File Offset: 0x003670F4
		public DicStringString? BodyCameraSettingsNameMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x0600F36D RID: 62317 RVA: 0x00368F58 File Offset: 0x00367158
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

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x0600F36E RID: 62318 RVA: 0x00368F84 File Offset: 0x00367184
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

		// Token: 0x0600F36F RID: 62319 RVA: 0x00368FBC File Offset: 0x003671BC
		public Span<byte> GetDefaultCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F370 RID: 62320 RVA: 0x00368FCC File Offset: 0x003671CC
		public byte[] GetDefaultCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F371 RID: 62321 RVA: 0x00368FE4 File Offset: 0x003671E4
		public DicStringString? UiCameraBlendNameMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0600F372 RID: 62322 RVA: 0x00369048 File Offset: 0x00367248
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

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x0600F373 RID: 62323 RVA: 0x00369074 File Offset: 0x00367274
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

		// Token: 0x0600F374 RID: 62324 RVA: 0x003690B4 File Offset: 0x003672B4
		[NullableContext(1)]
		public Dictionary<string, string> BodyCameraSettingsNameMap()
		{
			return this.BodyCameraSettingsNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600F375 RID: 62325 RVA: 0x0036910A File Offset: 0x0036730A
		[NullableContext(1)]
		public IEnumerable<DicStringString> BodyCameraSettingsNameMapIter()
		{
			UiCameraMapping.<BodyCameraSettingsNameMapIter>d__41 <BodyCameraSettingsNameMapIter>d__ = new UiCameraMapping.<BodyCameraSettingsNameMapIter>d__41(-2);
			<BodyCameraSettingsNameMapIter>d__.<>3__<>4__this = this;
			return <BodyCameraSettingsNameMapIter>d__;
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x00369120 File Offset: 0x00367320
		[NullableContext(1)]
		public Dictionary<string, string> UiCameraBlendNameMap()
		{
			return this.UiCameraBlendNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600F377 RID: 62327 RVA: 0x00369176 File Offset: 0x00367376
		[NullableContext(1)]
		public IEnumerable<DicStringString> UiCameraBlendNameMapIter()
		{
			UiCameraMapping.<UiCameraBlendNameMapIter>d__43 <UiCameraBlendNameMapIter>d__ = new UiCameraMapping.<UiCameraBlendNameMapIter>d__43(-2);
			<UiCameraBlendNameMapIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendNameMapIter>d__;
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x0036918C File Offset: 0x0036738C
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

		// Token: 0x0600F379 RID: 62329 RVA: 0x003691B4 File Offset: 0x003673B4
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

		// Token: 0x0600F37A RID: 62330 RVA: 0x003691DC File Offset: 0x003673DC
		private void EnsureBodyCameraSettingsNameMapCacheIfNeeded()
		{
			if (this.BodyCameraSettingsNameMapCache != null)
			{
				return;
			}
			this.BodyCameraSettingsNameMapCache = this.BodyCameraSettingsNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x00369244 File Offset: 0x00367444
		private void EnsureUiCameraBlendNameMapCacheIfNeeded()
		{
			if (this.UiCameraBlendNameMapCache != null)
			{
				return;
			}
			this.UiCameraBlendNameMapCache = this.UiCameraBlendNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600F37C RID: 62332 RVA: 0x003692AA File Offset: 0x003674AA
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetBodyCameraSettingsNameMapFrozenDict()
		{
			this.EnsureBodyCameraSettingsNameMapCacheIfNeeded();
			return this.BodyCameraSettingsNameMapCache;
		}

		// Token: 0x0600F37D RID: 62333 RVA: 0x003692B8 File Offset: 0x003674B8
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetUiCameraBlendNameMapFrozenDict()
		{
			this.EnsureUiCameraBlendNameMapCacheIfNeeded();
			return this.UiCameraBlendNameMapCache;
		}

		// Token: 0x0400590B RID: 22795
		private Table __p;

		// Token: 0x0400590C RID: 22796
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> BodyCameraSettingsNameMapCache;

		// Token: 0x0400590D RID: 22797
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraBlendNameMapCache;
	}
}
