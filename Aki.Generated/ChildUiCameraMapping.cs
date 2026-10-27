using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B71 RID: 2929
	public struct ChildUiCameraMapping : IFlatbufferObject
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060054B1 RID: 21681 RVA: 0x001F425D File Offset: 0x001F245D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x001F426A File Offset: 0x001F246A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x001F4274 File Offset: 0x001F2474
		public static ChildUiCameraMapping GetRootAsChildUiCameraMapping(ByteBuffer _bb)
		{
			return ChildUiCameraMapping.GetRootAsChildUiCameraMapping(_bb, default(ChildUiCameraMapping));
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x001F4290 File Offset: 0x001F2490
		public static ChildUiCameraMapping GetRootAsChildUiCameraMapping(ByteBuffer _bb, ChildUiCameraMapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x001F42AD File Offset: 0x001F24AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x001F42BC File Offset: 0x001F24BC
		public ChildUiCameraMapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060054B7 RID: 21687 RVA: 0x001F42CC File Offset: 0x001F24CC
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

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x001F4308 File Offset: 0x001F2508
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

		// Token: 0x060054B9 RID: 21689 RVA: 0x001F433F File Offset: 0x001F253F
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x001F434E File Offset: 0x001F254E
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060054BB RID: 21691 RVA: 0x001F4368 File Offset: 0x001F2568
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

		// Token: 0x060054BC RID: 21692 RVA: 0x001F439F File Offset: 0x001F259F
		public Span<byte> GetDefaultUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x001F43AE File Offset: 0x001F25AE
		public byte[] GetDefaultUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x001F43C8 File Offset: 0x001F25C8
		public bool IsCheckSpecialState
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x001F4408 File Offset: 0x001F2608
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

		// Token: 0x060054C0 RID: 21696 RVA: 0x001F4440 File Offset: 0x001F2640
		public Span<byte> GetSpecialStateCameraSettingNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x001F4450 File Offset: 0x001F2650
		public byte[] GetSpecialStateCameraSettingNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x001F4468 File Offset: 0x001F2668
		public bool BPlayLoadingCameraAnimation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x001F44A8 File Offset: 0x001F26A8
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

		// Token: 0x060054C4 RID: 21700 RVA: 0x001F44E8 File Offset: 0x001F26E8
		public DicStringString? BodyCameraSettingsNameMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060054C5 RID: 21701 RVA: 0x001F454C File Offset: 0x001F274C
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

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x001F4578 File Offset: 0x001F2778
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

		// Token: 0x060054C7 RID: 21703 RVA: 0x001F45B0 File Offset: 0x001F27B0
		public Span<byte> GetDefaultCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x001F45C0 File Offset: 0x001F27C0
		public byte[] GetDefaultCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x001F45D8 File Offset: 0x001F27D8
		public DicStringString? UiCameraBlendNameMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x001F463C File Offset: 0x001F283C
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

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060054CB RID: 21707 RVA: 0x001F4668 File Offset: 0x001F2868
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

		// Token: 0x060054CC RID: 21708 RVA: 0x001F46A8 File Offset: 0x001F28A8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BodyCameraSettingsNameMapFrozenDict()缓存字典，遍历请使用BodyCameraSettingsNameMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> BodyCameraSettingsNameMap()
		{
			return this.BodyCameraSettingsNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x001F46FE File Offset: 0x001F28FE
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> BodyCameraSettingsNameMapIter()
		{
			ChildUiCameraMapping.<BodyCameraSettingsNameMapIter>d__41 <BodyCameraSettingsNameMapIter>d__ = new ChildUiCameraMapping.<BodyCameraSettingsNameMapIter>d__41(-2);
			<BodyCameraSettingsNameMapIter>d__.<>3__<>4__this = this;
			return <BodyCameraSettingsNameMapIter>d__;
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x001F4714 File Offset: 0x001F2914
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UiCameraBlendNameMapFrozenDict()缓存字典，遍历请使用UiCameraBlendNameMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> UiCameraBlendNameMap()
		{
			return this.UiCameraBlendNameMapIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x001F476A File Offset: 0x001F296A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> UiCameraBlendNameMapIter()
		{
			ChildUiCameraMapping.<UiCameraBlendNameMapIter>d__43 <UiCameraBlendNameMapIter>d__ = new ChildUiCameraMapping.<UiCameraBlendNameMapIter>d__43(-2);
			<UiCameraBlendNameMapIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendNameMapIter>d__;
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x001F4780 File Offset: 0x001F2980
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

		// Token: 0x060054D1 RID: 21713 RVA: 0x001F47A8 File Offset: 0x001F29A8
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

		// Token: 0x060054D2 RID: 21714 RVA: 0x001F47D0 File Offset: 0x001F29D0
		private void EnsureBodyCameraSettingsNameMapCacheIfNeeded()
		{
			if (this.BodyCameraSettingsNameMapCache != null)
			{
				return;
			}
			this.BodyCameraSettingsNameMapCache = this.BodyCameraSettingsNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x001F4838 File Offset: 0x001F2A38
		private void EnsureUiCameraBlendNameMapCacheIfNeeded()
		{
			if (this.UiCameraBlendNameMapCache != null)
			{
				return;
			}
			this.UiCameraBlendNameMapCache = this.UiCameraBlendNameMapIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x001F489E File Offset: 0x001F2A9E
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

		// Token: 0x060054D5 RID: 21717 RVA: 0x001F48AC File Offset: 0x001F2AAC
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

		// Token: 0x04004B73 RID: 19315
		private Table __p;

		// Token: 0x04004B74 RID: 19316
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> BodyCameraSettingsNameMapCache;

		// Token: 0x04004B75 RID: 19317
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraBlendNameMapCache;
	}
}
