using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DC RID: 4572
	[NullableContext(1)]
	[Nullable(0)]
	public struct SCreatureGenBlackboardMaps : IFlatbufferObject
	{
		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0600EB23 RID: 60195 RVA: 0x0034975E File Offset: 0x0034795E
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB24 RID: 60196 RVA: 0x0034976B File Offset: 0x0034796B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x00349774 File Offset: 0x00347974
		[NullableContext(0)]
		public static SCreatureGenBlackboardMaps GetRootAsSCreatureGenBlackboardMaps(ByteBuffer _bb)
		{
			return SCreatureGenBlackboardMaps.GetRootAsSCreatureGenBlackboardMaps(_bb, default(SCreatureGenBlackboardMaps));
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x00349790 File Offset: 0x00347990
		[NullableContext(0)]
		public static SCreatureGenBlackboardMaps GetRootAsSCreatureGenBlackboardMaps(ByteBuffer _bb, SCreatureGenBlackboardMaps obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x003497AD File Offset: 0x003479AD
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x003497BC File Offset: 0x003479BC
		[NullableContext(0)]
		public SCreatureGenBlackboardMaps __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x003497CC File Offset: 0x003479CC
		public DicStringString? MapString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x0034982C File Offset: 0x00347A2C
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

		// Token: 0x0600EB2B RID: 60203 RVA: 0x00349858 File Offset: 0x00347A58
		public DicStringInt? MapInt(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0600EB2C RID: 60204 RVA: 0x003498B8 File Offset: 0x00347AB8
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

		// Token: 0x0600EB2D RID: 60205 RVA: 0x003498E4 File Offset: 0x00347AE4
		public DicStringBool? MapBool(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringBool?(default(DicStringBool).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0600EB2E RID: 60206 RVA: 0x00349944 File Offset: 0x00347B44
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

		// Token: 0x0600EB2F RID: 60207 RVA: 0x00349970 File Offset: 0x00347B70
		[Obsolete("已废弃，请使用MapBoolFrozenDict()缓存字典，遍历请使用MapBoolIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, bool> MapBool()
		{
			return this.MapBoolIter().ToDictionary((DicStringBool element) => element.Key, (DicStringBool element) => element.Value);
		}

		// Token: 0x0600EB30 RID: 60208 RVA: 0x003499C6 File Offset: 0x00347BC6
		public readonly IEnumerable<DicStringBool> MapBoolIter()
		{
			SCreatureGenBlackboardMaps.<MapBoolIter>d__18 <MapBoolIter>d__ = new SCreatureGenBlackboardMaps.<MapBoolIter>d__18(-2);
			<MapBoolIter>d__.<>3__<>4__this = this;
			return <MapBoolIter>d__;
		}

		// Token: 0x0600EB31 RID: 60209 RVA: 0x003499DC File Offset: 0x00347BDC
		[Obsolete("已废弃，请使用MapIntFrozenDict()缓存字典，遍历请使用MapIntIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> MapInt()
		{
			return this.MapIntIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600EB32 RID: 60210 RVA: 0x00349A32 File Offset: 0x00347C32
		public readonly IEnumerable<DicStringInt> MapIntIter()
		{
			SCreatureGenBlackboardMaps.<MapIntIter>d__20 <MapIntIter>d__ = new SCreatureGenBlackboardMaps.<MapIntIter>d__20(-2);
			<MapIntIter>d__.<>3__<>4__this = this;
			return <MapIntIter>d__;
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x00349A48 File Offset: 0x00347C48
		[Obsolete("已废弃，请使用MapStringFrozenDict()缓存字典，遍历请使用MapStringIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> MapString()
		{
			return this.MapStringIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x00349A9E File Offset: 0x00347C9E
		public readonly IEnumerable<DicStringString> MapStringIter()
		{
			SCreatureGenBlackboardMaps.<MapStringIter>d__22 <MapStringIter>d__ = new SCreatureGenBlackboardMaps.<MapStringIter>d__22(-2);
			<MapStringIter>d__.<>3__<>4__this = this;
			return <MapStringIter>d__;
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x00349AB4 File Offset: 0x00347CB4
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

		// Token: 0x0600EB36 RID: 60214 RVA: 0x00349AE8 File Offset: 0x00347CE8
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

		// Token: 0x0600EB37 RID: 60215 RVA: 0x00349B1C File Offset: 0x00347D1C
		[return: Nullable(2)]
		public string GetMapString(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			string result;
			if (!this.MapStringCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x00349B44 File Offset: 0x00347D44
		private void EnsureMapBoolCacheIfNeeded()
		{
			if (this.MapBoolCache != null)
			{
				return;
			}
			this.MapBoolCache = this.MapBoolIter().ToFrozenDictionary((DicStringBool kvp) => kvp.Key, (DicStringBool kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x00349BAC File Offset: 0x00347DAC
		private void EnsureMapIntCacheIfNeeded()
		{
			if (this.MapIntCache != null)
			{
				return;
			}
			this.MapIntCache = this.MapIntIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x00349C14 File Offset: 0x00347E14
		private void EnsureMapStringCacheIfNeeded()
		{
			if (this.MapStringCache != null)
			{
				return;
			}
			this.MapStringCache = this.MapStringIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x00349C7A File Offset: 0x00347E7A
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

		// Token: 0x0600EB3C RID: 60220 RVA: 0x00349C88 File Offset: 0x00347E88
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

		// Token: 0x0600EB3D RID: 60221 RVA: 0x00349C96 File Offset: 0x00347E96
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetMapStringFrozenDict(string key)
		{
			this.EnsureMapStringCacheIfNeeded();
			return this.MapStringCache;
		}

		// Token: 0x0400534F RID: 21327
		private Table __p;

		// Token: 0x04005350 RID: 21328
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, bool> MapBoolCache;

		// Token: 0x04005351 RID: 21329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> MapIntCache;

		// Token: 0x04005352 RID: 21330
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> MapStringCache;
	}
}
