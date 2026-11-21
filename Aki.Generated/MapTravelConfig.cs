using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDB RID: 3803
	public struct MapTravelConfig : IFlatbufferObject
	{
		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06009816 RID: 38934 RVA: 0x0029EA47 File Offset: 0x0029CC47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x0029EA54 File Offset: 0x0029CC54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0029EA5C File Offset: 0x0029CC5C
		public static MapTravelConfig GetRootAsMapTravelConfig(ByteBuffer _bb)
		{
			return MapTravelConfig.GetRootAsMapTravelConfig(_bb, default(MapTravelConfig));
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x0029EA78 File Offset: 0x0029CC78
		public static MapTravelConfig GetRootAsMapTravelConfig(ByteBuffer _bb, MapTravelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x0029EA95 File Offset: 0x0029CC95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x0029EAA4 File Offset: 0x0029CCA4
		public MapTravelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600981C RID: 38940 RVA: 0x0029EAB4 File Offset: 0x0029CCB4
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

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600981D RID: 38941 RVA: 0x0029EAF0 File Offset: 0x0029CCF0
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

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600981E RID: 38942 RVA: 0x0029EB2C File Offset: 0x0029CD2C
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

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600981F RID: 38943 RVA: 0x0029EB68 File Offset: 0x0029CD68
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

		// Token: 0x06009820 RID: 38944 RVA: 0x0029EBA8 File Offset: 0x0029CDA8
		public DicIntString? TabName(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06009821 RID: 38945 RVA: 0x0029EC0C File Offset: 0x0029CE0C
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

		// Token: 0x06009822 RID: 38946 RVA: 0x0029EC38 File Offset: 0x0029CE38
		public DicIntString? TabIcon(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06009823 RID: 38947 RVA: 0x0029EC9C File Offset: 0x0029CE9C
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

		// Token: 0x06009824 RID: 38948 RVA: 0x0029ECC8 File Offset: 0x0029CEC8
		[NullableContext(1)]
		public Dictionary<int, string> TabIcon()
		{
			return this.TabIconIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06009825 RID: 38949 RVA: 0x0029ED1E File Offset: 0x0029CF1E
		[NullableContext(1)]
		public IEnumerable<DicIntString> TabIconIter()
		{
			MapTravelConfig.<TabIconIter>d__23 <TabIconIter>d__ = new MapTravelConfig.<TabIconIter>d__23(-2);
			<TabIconIter>d__.<>3__<>4__this = this;
			return <TabIconIter>d__;
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x0029ED34 File Offset: 0x0029CF34
		[NullableContext(1)]
		public Dictionary<int, string> TabName()
		{
			return this.TabNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x0029ED8A File Offset: 0x0029CF8A
		[NullableContext(1)]
		public IEnumerable<DicIntString> TabNameIter()
		{
			MapTravelConfig.<TabNameIter>d__25 <TabNameIter>d__ = new MapTravelConfig.<TabNameIter>d__25(-2);
			<TabNameIter>d__.<>3__<>4__this = this;
			return <TabNameIter>d__;
		}

		// Token: 0x06009828 RID: 38952 RVA: 0x0029EDA0 File Offset: 0x0029CFA0
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

		// Token: 0x06009829 RID: 38953 RVA: 0x0029EDC8 File Offset: 0x0029CFC8
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

		// Token: 0x0600982A RID: 38954 RVA: 0x0029EDF0 File Offset: 0x0029CFF0
		private void EnsureTabIconCacheIfNeeded()
		{
			if (this.TabIconCache != null)
			{
				return;
			}
			this.TabIconCache = this.TabIconIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x0029EE58 File Offset: 0x0029D058
		private void EnsureTabNameCacheIfNeeded()
		{
			if (this.TabNameCache != null)
			{
				return;
			}
			this.TabNameCache = this.TabNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x0029EEBE File Offset: 0x0029D0BE
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTabIconFrozenDict()
		{
			this.EnsureTabIconCacheIfNeeded();
			return this.TabIconCache;
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0029EECC File Offset: 0x0029D0CC
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTabNameFrozenDict()
		{
			this.EnsureTabNameCacheIfNeeded();
			return this.TabNameCache;
		}

		// Token: 0x04005479 RID: 21625
		private Table __p;

		// Token: 0x0400547A RID: 21626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabIconCache;

		// Token: 0x0400547B RID: 21627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabNameCache;
	}
}
