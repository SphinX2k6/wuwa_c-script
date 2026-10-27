using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF6 RID: 3574
	public struct MapTravelConfig : IFlatbufferObject
	{
		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x00280951 File Offset: 0x0027EB51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x0028095E File Offset: 0x0027EB5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00280968 File Offset: 0x0027EB68
		public static MapTravelConfig GetRootAsMapTravelConfig(ByteBuffer _bb)
		{
			return MapTravelConfig.GetRootAsMapTravelConfig(_bb, default(MapTravelConfig));
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00280984 File Offset: 0x0027EB84
		public static MapTravelConfig GetRootAsMapTravelConfig(ByteBuffer _bb, MapTravelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x002809A1 File Offset: 0x0027EBA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x002809B0 File Offset: 0x0027EBB0
		public MapTravelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x002809C0 File Offset: 0x0027EBC0
		public int ActivityId
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

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06009201 RID: 37377 RVA: 0x002809FC File Offset: 0x0027EBFC
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x00280A38 File Offset: 0x0027EC38
		public int ExpItemId
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

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06009203 RID: 37379 RVA: 0x00280A74 File Offset: 0x0027EC74
		public int FinalRewardId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00280AB4 File Offset: 0x0027ECB4
		public DicIntString? TabName(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06009205 RID: 37381 RVA: 0x00280B18 File Offset: 0x0027ED18
		public int TabNameLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00280B44 File Offset: 0x0027ED44
		public DicIntString? TabIcon(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06009207 RID: 37383 RVA: 0x00280BA8 File Offset: 0x0027EDA8
		public int TabIconLength
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

		// Token: 0x06009208 RID: 37384 RVA: 0x00280BD4 File Offset: 0x0027EDD4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TabIconFrozenDict()缓存字典，遍历请使用TabIconIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TabIcon()
		{
			return this.TabIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00280C2A File Offset: 0x0027EE2A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TabIconIter()
		{
			MapTravelConfig.<TabIconIter>d__23 <TabIconIter>d__ = new MapTravelConfig.<TabIconIter>d__23(-2);
			<TabIconIter>d__.<>3__<>4__this = this;
			return <TabIconIter>d__;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00280C40 File Offset: 0x0027EE40
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TabNameFrozenDict()缓存字典，遍历请使用TabNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TabName()
		{
			return this.TabNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00280C96 File Offset: 0x0027EE96
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TabNameIter()
		{
			MapTravelConfig.<TabNameIter>d__25 <TabNameIter>d__ = new MapTravelConfig.<TabNameIter>d__25(-2);
			<TabNameIter>d__.<>3__<>4__this = this;
			return <TabNameIter>d__;
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00280CAC File Offset: 0x0027EEAC
		[NullableContext(2)]
		public string GetTabIcon(int key)
		{
			this.EnsureTabIconCacheIfNeeded();
			string result;
			if (!this.TabIconCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x00280CD4 File Offset: 0x0027EED4
		[NullableContext(2)]
		public string GetTabName(int key)
		{
			this.EnsureTabNameCacheIfNeeded();
			string result;
			if (!this.TabNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x00280CFC File Offset: 0x0027EEFC
		private void EnsureTabIconCacheIfNeeded()
		{
			if (this.TabIconCache != null)
			{
				return;
			}
			this.TabIconCache = this.TabIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x00280D64 File Offset: 0x0027EF64
		private void EnsureTabNameCacheIfNeeded()
		{
			if (this.TabNameCache != null)
			{
				return;
			}
			this.TabNameCache = this.TabNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00280DCA File Offset: 0x0027EFCA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTabIconFrozenDict(int key)
		{
			this.EnsureTabIconCacheIfNeeded();
			return this.TabIconCache;
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00280DD8 File Offset: 0x0027EFD8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTabNameFrozenDict(int key)
		{
			this.EnsureTabNameCacheIfNeeded();
			return this.TabNameCache;
		}

		// Token: 0x04004E94 RID: 20116
		private Table __p;

		// Token: 0x04004E95 RID: 20117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabIconCache;

		// Token: 0x04004E96 RID: 20118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabNameCache;
	}
}
