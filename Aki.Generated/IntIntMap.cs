using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CD RID: 4557
	public struct IntIntMap : IFlatbufferObject
	{
		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x0600EA94 RID: 60052 RVA: 0x003484CD File Offset: 0x003466CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x003484DA File Offset: 0x003466DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x003484E4 File Offset: 0x003466E4
		public static IntIntMap GetRootAsIntIntMap(ByteBuffer _bb)
		{
			return IntIntMap.GetRootAsIntIntMap(_bb, default(IntIntMap));
		}

		// Token: 0x0600EA97 RID: 60055 RVA: 0x00348500 File Offset: 0x00346700
		public static IntIntMap GetRootAsIntIntMap(ByteBuffer _bb, IntIntMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA98 RID: 60056 RVA: 0x0034851D File Offset: 0x0034671D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x0034852C File Offset: 0x0034672C
		public IntIntMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x0034853C File Offset: 0x0034673C
		public DicIntInt? MapIntInt(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x0034859C File Offset: 0x0034679C
		public int MapIntIntLength
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

		// Token: 0x0600EA9C RID: 60060 RVA: 0x003485C8 File Offset: 0x003467C8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MapIntIntFrozenDict()缓存字典，遍历请使用MapIntIntIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MapIntInt()
		{
			return this.MapIntIntIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EA9D RID: 60061 RVA: 0x0034861E File Offset: 0x0034681E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MapIntIntIter()
		{
			IntIntMap.<MapIntIntIter>d__12 <MapIntIntIter>d__ = new IntIntMap.<MapIntIntIter>d__12(-2);
			<MapIntIntIter>d__.<>3__<>4__this = this;
			return <MapIntIntIter>d__;
		}

		// Token: 0x0600EA9E RID: 60062 RVA: 0x00348634 File Offset: 0x00346834
		public int? GetMapIntInt(int key)
		{
			this.EnsureMapIntIntCacheIfNeeded();
			int value;
			if (!this.MapIntIntCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600EA9F RID: 60063 RVA: 0x00348668 File Offset: 0x00346868
		private void EnsureMapIntIntCacheIfNeeded()
		{
			if (this.MapIntIntCache != null)
			{
				return;
			}
			this.MapIntIntCache = this.MapIntIntIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EAA0 RID: 60064 RVA: 0x003486CE File Offset: 0x003468CE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMapIntIntFrozenDict(int key)
		{
			this.EnsureMapIntIntCacheIfNeeded();
			return this.MapIntIntCache;
		}

		// Token: 0x0400533A RID: 21306
		private Table __p;

		// Token: 0x0400533B RID: 21307
		[Nullable(2)]
		private FrozenDictionary<int, int> MapIntIntCache;
	}
}
