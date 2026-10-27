using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF1 RID: 3569
	public struct MapNote : IFlatbufferObject
	{
		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x0027F6F1 File Offset: 0x0027D8F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x0027F6FE File Offset: 0x0027D8FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x0027F708 File Offset: 0x0027D908
		public static MapNote GetRootAsMapNote(ByteBuffer _bb)
		{
			return MapNote.GetRootAsMapNote(_bb, default(MapNote));
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x0027F724 File Offset: 0x0027D924
		public static MapNote GetRootAsMapNote(ByteBuffer _bb, MapNote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600917A RID: 37242 RVA: 0x0027F741 File Offset: 0x0027D941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x0027F750 File Offset: 0x0027D950
		public MapNote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x0027F760 File Offset: 0x0027D960
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

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600917D RID: 37245 RVA: 0x0027F79C File Offset: 0x0027D99C
		public int Type
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

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x0027F7D8 File Offset: 0x0027D9D8
		public int MapId
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

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x0027F814 File Offset: 0x0027DA14
		public string Icon
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

		// Token: 0x06009180 RID: 37248 RVA: 0x0027F84C File Offset: 0x0027DA4C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x0027F85C File Offset: 0x0027DA5C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x0027F874 File Offset: 0x0027DA74
		public string Desc
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

		// Token: 0x06009183 RID: 37251 RVA: 0x0027F8AC File Offset: 0x0027DAAC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x0027F8BC File Offset: 0x0027DABC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06009185 RID: 37253 RVA: 0x0027F8D4 File Offset: 0x0027DAD4
		public int Style
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x0027F914 File Offset: 0x0027DB14
		public int Priority
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

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06009187 RID: 37255 RVA: 0x0027F954 File Offset: 0x0027DB54
		public int Rank
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x0027F994 File Offset: 0x0027DB94
		public DicIntInt? MarkIdMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x0027F9F8 File Offset: 0x0027DBF8
		public int MarkIdMapLength
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

		// Token: 0x0600918A RID: 37258 RVA: 0x0027FA24 File Offset: 0x0027DC24
		public int MarkId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x0027FA64 File Offset: 0x0027DC64
		public int MarkIdLength
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

		// Token: 0x0600918C RID: 37260 RVA: 0x0027FA90 File Offset: 0x0027DC90
		public Span<int> GetMarkIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x0027FAA0 File Offset: 0x0027DCA0
		public int[] GetMarkIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x0027FAB8 File Offset: 0x0027DCB8
		public int ConditionId
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

		// Token: 0x0600918F RID: 37263 RVA: 0x0027FAF8 File Offset: 0x0027DCF8
		public int QuestIdList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x0027FB38 File Offset: 0x0027DD38
		public int QuestIdListLength
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

		// Token: 0x06009191 RID: 37265 RVA: 0x0027FB64 File Offset: 0x0027DD64
		public Span<int> GetQuestIdListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x0027FB74 File Offset: 0x0027DD74
		public int[] GetQuestIdListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x0027FB8C File Offset: 0x0027DD8C
		public bool Disable
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x0027FBCC File Offset: 0x0027DDCC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MarkIdIter()或GetMarkIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MarkId()
		{
			MapNote mapNote = this;
			return mapNote.GetMarkIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x0027FBF0 File Offset: 0x0027DDF0
		[NullableContext(1)]
		public readonly IEnumerable<int> MarkIdIter()
		{
			MapNote.<MarkIdIter>d__46 <MarkIdIter>d__ = new MapNote.<MarkIdIter>d__46(-2);
			<MarkIdIter>d__.<>3__<>4__this = this;
			return <MarkIdIter>d__;
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x0027FC08 File Offset: 0x0027DE08
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MarkIdMapFrozenDict()缓存字典，遍历请使用MarkIdMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MarkIdMap()
		{
			return this.MarkIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x0027FC5E File Offset: 0x0027DE5E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MarkIdMapIter()
		{
			MapNote.<MarkIdMapIter>d__48 <MarkIdMapIter>d__ = new MapNote.<MarkIdMapIter>d__48(-2);
			<MarkIdMapIter>d__.<>3__<>4__this = this;
			return <MarkIdMapIter>d__;
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x0027FC74 File Offset: 0x0027DE74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestIdListIter()或GetQuestIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestIdList()
		{
			MapNote mapNote = this;
			return mapNote.GetQuestIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x0027FC98 File Offset: 0x0027DE98
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestIdListIter()
		{
			MapNote.<QuestIdListIter>d__50 <QuestIdListIter>d__ = new MapNote.<QuestIdListIter>d__50(-2);
			<QuestIdListIter>d__.<>3__<>4__this = this;
			return <QuestIdListIter>d__;
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x0027FCB0 File Offset: 0x0027DEB0
		public int? GetMarkIdMap(int key)
		{
			this.EnsureMarkIdMapCacheIfNeeded();
			int value;
			if (!this.MarkIdMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x0027FCE4 File Offset: 0x0027DEE4
		private void EnsureMarkIdMapCacheIfNeeded()
		{
			if (this.MarkIdMapCache != null)
			{
				return;
			}
			this.MarkIdMapCache = this.MarkIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x0027FD4A File Offset: 0x0027DF4A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMarkIdMapFrozenDict(int key)
		{
			this.EnsureMarkIdMapCacheIfNeeded();
			return this.MarkIdMapCache;
		}

		// Token: 0x04004E8E RID: 20110
		private Table __p;

		// Token: 0x04004E8F RID: 20111
		[Nullable(2)]
		private FrozenDictionary<int, int> MarkIdMapCache;
	}
}
