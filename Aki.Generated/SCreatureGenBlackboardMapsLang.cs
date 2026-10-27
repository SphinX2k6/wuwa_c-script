using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DD RID: 4573
	[NullableContext(1)]
	[Nullable(0)]
	public struct SCreatureGenBlackboardMapsLang : IFlatbufferObject
	{
		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x0600EB3E RID: 60222 RVA: 0x00349CA4 File Offset: 0x00347EA4
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x00349CB1 File Offset: 0x00347EB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x00349CB8 File Offset: 0x00347EB8
		[NullableContext(0)]
		public static SCreatureGenBlackboardMapsLang GetRootAsSCreatureGenBlackboardMapsLang(ByteBuffer _bb)
		{
			return SCreatureGenBlackboardMapsLang.GetRootAsSCreatureGenBlackboardMapsLang(_bb, default(SCreatureGenBlackboardMapsLang));
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x00349CD4 File Offset: 0x00347ED4
		[NullableContext(0)]
		public static SCreatureGenBlackboardMapsLang GetRootAsSCreatureGenBlackboardMapsLang(ByteBuffer _bb, SCreatureGenBlackboardMapsLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x00349CF1 File Offset: 0x00347EF1
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x00349D00 File Offset: 0x00347F00
		[NullableContext(0)]
		public SCreatureGenBlackboardMapsLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x00349D10 File Offset: 0x00347F10
		public DicStringInt? MapString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0600EB45 RID: 60229 RVA: 0x00349D70 File Offset: 0x00347F70
		public int MapStringLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x00349D9C File Offset: 0x00347F9C
		public DicStringInt? MapInt(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0600EB47 RID: 60231 RVA: 0x00349DFC File Offset: 0x00347FFC
		public int MapIntLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x00349E28 File Offset: 0x00348028
		public DicStringBool? MapBool(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringBool?(default(DicStringBool).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0600EB49 RID: 60233 RVA: 0x00349E88 File Offset: 0x00348088
		public int MapBoolLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x00349EB4 File Offset: 0x003480B4
		[Obsolete("已废弃，请使用MapBoolFrozenDict()缓存字典，遍历请使用MapBoolIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, bool> MapBool()
		{
			return this.MapBoolIter().ToDictionary((DicStringBool element) => element.Key, (DicStringBool element) => element.Value);
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x00349F0A File Offset: 0x0034810A
		public readonly IEnumerable<DicStringBool> MapBoolIter()
		{
			SCreatureGenBlackboardMapsLang.<MapBoolIter>d__18 <MapBoolIter>d__ = new SCreatureGenBlackboardMapsLang.<MapBoolIter>d__18(-2);
			<MapBoolIter>d__.<>3__<>4__this = this;
			return <MapBoolIter>d__;
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x00349F20 File Offset: 0x00348120
		[Obsolete("已废弃，请使用MapIntFrozenDict()缓存字典，遍历请使用MapIntIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> MapInt()
		{
			return this.MapIntIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x00349F76 File Offset: 0x00348176
		public readonly IEnumerable<DicStringInt> MapIntIter()
		{
			SCreatureGenBlackboardMapsLang.<MapIntIter>d__20 <MapIntIter>d__ = new SCreatureGenBlackboardMapsLang.<MapIntIter>d__20(-2);
			<MapIntIter>d__.<>3__<>4__this = this;
			return <MapIntIter>d__;
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x00349F8C File Offset: 0x0034818C
		[Obsolete("已废弃，请使用MapStringFrozenDict()缓存字典，遍历请使用MapStringIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> MapString()
		{
			return this.MapStringIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x00349FE2 File Offset: 0x003481E2
		public readonly IEnumerable<DicStringInt> MapStringIter()
		{
			SCreatureGenBlackboardMapsLang.<MapStringIter>d__22 <MapStringIter>d__ = new SCreatureGenBlackboardMapsLang.<MapStringIter>d__22(-2);
			<MapStringIter>d__.<>3__<>4__this = this;
			return <MapStringIter>d__;
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x00349FF8 File Offset: 0x003481F8
		public bool? GetMapBool(string key)
		{
			this.EnsureMapBoolCacheIfNeeded();
			bool value;
			if (!this.MapBoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new bool?(value);
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x0034A02C File Offset: 0x0034822C
		public int? GetMapInt(string key)
		{
			this.EnsureMapIntCacheIfNeeded();
			int value;
			if (!this.MapIntCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x0034A060 File Offset: 0x00348260
		public int? GetMapString(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			int value;
			if (!this.MapStringCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x0034A094 File Offset: 0x00348294
		private void EnsureMapBoolCacheIfNeeded()
		{
			if (this.MapBoolCache != null)
			{
				return;
			}
			this.MapBoolCache = this.MapBoolIter().ToFrozenDictionary((DicStringBool kvp) => kvp.Key, (DicStringBool kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x0034A0FC File Offset: 0x003482FC
		private void EnsureMapIntCacheIfNeeded()
		{
			if (this.MapIntCache != null)
			{
				return;
			}
			this.MapIntCache = this.MapIntIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x0034A164 File Offset: 0x00348364
		private void EnsureMapStringCacheIfNeeded()
		{
			if (this.MapStringCache != null)
			{
				return;
			}
			this.MapStringCache = this.MapStringIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x0034A1CA File Offset: 0x003483CA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, bool> GetMapBoolFrozenDict(string key)
		{
			this.EnsureMapBoolCacheIfNeeded();
			return this.MapBoolCache;
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x0034A1D8 File Offset: 0x003483D8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetMapIntFrozenDict(string key)
		{
			this.EnsureMapIntCacheIfNeeded();
			return this.MapIntCache;
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x0034A1E6 File Offset: 0x003483E6
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetMapStringFrozenDict(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			return this.MapStringCache;
		}

		// Token: 0x04005353 RID: 21331
		private Table __p;

		// Token: 0x04005354 RID: 21332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, bool> MapBoolCache;

		// Token: 0x04005355 RID: 21333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapIntCache;

		// Token: 0x04005356 RID: 21334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapStringCache;
	}
}
