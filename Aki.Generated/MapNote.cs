using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED6 RID: 3798
	public struct MapNote : IFlatbufferObject
	{
		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06009792 RID: 38802 RVA: 0x0029D899 File Offset: 0x0029BA99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x0029D8A6 File Offset: 0x0029BAA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0029D8B0 File Offset: 0x0029BAB0
		public static MapNote GetRootAsMapNote(ByteBuffer _bb)
		{
			return MapNote.GetRootAsMapNote(_bb, default(MapNote));
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x0029D8CC File Offset: 0x0029BACC
		public static MapNote GetRootAsMapNote(ByteBuffer _bb, MapNote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0029D8E9 File Offset: 0x0029BAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0029D8F8 File Offset: 0x0029BAF8
		public MapNote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06009798 RID: 38808 RVA: 0x0029D908 File Offset: 0x0029BB08
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

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x0029D944 File Offset: 0x0029BB44
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

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600979A RID: 38810 RVA: 0x0029D980 File Offset: 0x0029BB80
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

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x0029D9BC File Offset: 0x0029BBBC
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

		// Token: 0x0600979C RID: 38812 RVA: 0x0029D9F4 File Offset: 0x0029BBF4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600979D RID: 38813 RVA: 0x0029DA04 File Offset: 0x0029BC04
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600979E RID: 38814 RVA: 0x0029DA1C File Offset: 0x0029BC1C
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

		// Token: 0x0600979F RID: 38815 RVA: 0x0029DA54 File Offset: 0x0029BC54
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x0029DA64 File Offset: 0x0029BC64
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060097A1 RID: 38817 RVA: 0x0029DA7C File Offset: 0x0029BC7C
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

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060097A2 RID: 38818 RVA: 0x0029DABC File Offset: 0x0029BCBC
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060097A3 RID: 38819 RVA: 0x0029DAFC File Offset: 0x0029BCFC
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

		// Token: 0x060097A4 RID: 38820 RVA: 0x0029DB3C File Offset: 0x0029BD3C
		public DicIntInt? MarkIdMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060097A5 RID: 38821 RVA: 0x0029DBA0 File Offset: 0x0029BDA0
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

		// Token: 0x060097A6 RID: 38822 RVA: 0x0029DBCC File Offset: 0x0029BDCC
		public int MarkId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x0029DC0C File Offset: 0x0029BE0C
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

		// Token: 0x060097A8 RID: 38824 RVA: 0x0029DC38 File Offset: 0x0029BE38
		public Span<int> GetMarkIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x0029DC48 File Offset: 0x0029BE48
		public int[] GetMarkIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x0029DC60 File Offset: 0x0029BE60
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

		// Token: 0x060097AB RID: 38827 RVA: 0x0029DCA0 File Offset: 0x0029BEA0
		public int QuestIdList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x0029DCE0 File Offset: 0x0029BEE0
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

		// Token: 0x060097AD RID: 38829 RVA: 0x0029DD0C File Offset: 0x0029BF0C
		public Span<int> GetQuestIdListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x0029DD1C File Offset: 0x0029BF1C
		public int[] GetQuestIdListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x0029DD34 File Offset: 0x0029BF34
		public bool Disable
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x0029DD74 File Offset: 0x0029BF74
		[NullableContext(1)]
		public int[] MarkId()
		{
			return this.GetMarkIdArray();
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0029DD7C File Offset: 0x0029BF7C
		[NullableContext(1)]
		public IEnumerable<int> MarkIdIter()
		{
			MapNote.<MarkIdIter>d__46 <MarkIdIter>d__ = new MapNote.<MarkIdIter>d__46(-2);
			<MarkIdIter>d__.<>3__<>4__this = this;
			return <MarkIdIter>d__;
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0029DD94 File Offset: 0x0029BF94
		[NullableContext(1)]
		public Dictionary<int, int> MarkIdMap()
		{
			return this.MarkIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0029DDEA File Offset: 0x0029BFEA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MarkIdMapIter()
		{
			MapNote.<MarkIdMapIter>d__48 <MarkIdMapIter>d__ = new MapNote.<MarkIdMapIter>d__48(-2);
			<MarkIdMapIter>d__.<>3__<>4__this = this;
			return <MarkIdMapIter>d__;
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0029DDFF File Offset: 0x0029BFFF
		[NullableContext(1)]
		public int[] QuestIdList()
		{
			return this.GetQuestIdListArray();
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0029DE07 File Offset: 0x0029C007
		[NullableContext(1)]
		public IEnumerable<int> QuestIdListIter()
		{
			MapNote.<QuestIdListIter>d__50 <QuestIdListIter>d__ = new MapNote.<QuestIdListIter>d__50(-2);
			<QuestIdListIter>d__.<>3__<>4__this = this;
			return <QuestIdListIter>d__;
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0029DE1C File Offset: 0x0029C01C
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

		// Token: 0x060097B7 RID: 38839 RVA: 0x0029DE50 File Offset: 0x0029C050
		private void EnsureMarkIdMapCacheIfNeeded()
		{
			if (this.MarkIdMapCache != null)
			{
				return;
			}
			this.MarkIdMapCache = this.MarkIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x0029DEB6 File Offset: 0x0029C0B6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMarkIdMapFrozenDict()
		{
			this.EnsureMarkIdMapCacheIfNeeded();
			return this.MarkIdMapCache;
		}

		// Token: 0x04005473 RID: 21619
		private Table __p;

		// Token: 0x04005474 RID: 21620
		[Nullable(2)]
		private FrozenDictionary<int, int> MarkIdMapCache;
	}
}
