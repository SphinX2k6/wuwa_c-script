using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001107 RID: 4359
	public struct RogueSeason : IFlatbufferObject
	{
		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600CB0E RID: 51982 RVA: 0x0030D878 File Offset: 0x0030BA78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x0030D885 File Offset: 0x0030BA85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x0030D88C File Offset: 0x0030BA8C
		public static RogueSeason GetRootAsRogueSeason(ByteBuffer _bb)
		{
			return RogueSeason.GetRootAsRogueSeason(_bb, default(RogueSeason));
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x0030D8A8 File Offset: 0x0030BAA8
		public static RogueSeason GetRootAsRogueSeason(ByteBuffer _bb, RogueSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x0030D8C5 File Offset: 0x0030BAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x0030D8D4 File Offset: 0x0030BAD4
		public RogueSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600CB14 RID: 51988 RVA: 0x0030D8E4 File Offset: 0x0030BAE4
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

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600CB15 RID: 51989 RVA: 0x0030D920 File Offset: 0x0030BB20
		public int ActivityId
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

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600CB16 RID: 51990 RVA: 0x0030D95C File Offset: 0x0030BB5C
		public string SeasonName
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

		// Token: 0x0600CB17 RID: 51991 RVA: 0x0030D993 File Offset: 0x0030BB93
		public Span<byte> GetSeasonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x0030D9A2 File Offset: 0x0030BBA2
		public byte[] GetSeasonNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600CB19 RID: 51993 RVA: 0x0030D9BC File Offset: 0x0030BBBC
		public int PointItem
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

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600CB1A RID: 51994 RVA: 0x0030D9FC File Offset: 0x0030BBFC
		public int InstanceDungeonEntrance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x0030DA3C File Offset: 0x0030BC3C
		public DicIntIntArray? InstanceDungeonList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x0030DAA0 File Offset: 0x0030BCA0
		public int InstanceDungeonListLength
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

		// Token: 0x0600CB1D RID: 51997 RVA: 0x0030DACC File Offset: 0x0030BCCC
		public DicIntString? InstanceDungeonTypeName(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600CB1E RID: 51998 RVA: 0x0030DB30 File Offset: 0x0030BD30
		public int InstanceDungeonTypeNameLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x0030DB5C File Offset: 0x0030BD5C
		public int ChallengeInstanceId
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

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600CB20 RID: 52000 RVA: 0x0030DB9C File Offset: 0x0030BD9C
		public int SaveDataMaxNum
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x0030DBDC File Offset: 0x0030BDDC
		public string TabIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x0030DC14 File Offset: 0x0030BE14
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x0030DC24 File Offset: 0x0030BE24
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x0030DC3C File Offset: 0x0030BE3C
		public int ShopId
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

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x0030DC7C File Offset: 0x0030BE7C
		public int Achievement
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600CB26 RID: 52006 RVA: 0x0030DCBC File Offset: 0x0030BEBC
		public int ParamId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x0030DCFC File Offset: 0x0030BEFC
		public string RogueThemeType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x0030DD34 File Offset: 0x0030BF34
		public Span<byte> GetRogueThemeTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CB29 RID: 52009 RVA: 0x0030DD44 File Offset: 0x0030BF44
		public byte[] GetRogueThemeTypeArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB2A RID: 52010 RVA: 0x0030DD5C File Offset: 0x0030BF5C
		[NullableContext(1)]
		public Dictionary<int, IntArray> InstanceDungeonList()
		{
			return this.InstanceDungeonListIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600CB2B RID: 52011 RVA: 0x0030DDB2 File Offset: 0x0030BFB2
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> InstanceDungeonListIter()
		{
			RogueSeason.<InstanceDungeonListIter>d__45 <InstanceDungeonListIter>d__ = new RogueSeason.<InstanceDungeonListIter>d__45(-2);
			<InstanceDungeonListIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonListIter>d__;
		}

		// Token: 0x0600CB2C RID: 52012 RVA: 0x0030DDC8 File Offset: 0x0030BFC8
		[NullableContext(1)]
		public Dictionary<int, string> InstanceDungeonTypeName()
		{
			return this.InstanceDungeonTypeNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x0030DE1E File Offset: 0x0030C01E
		[NullableContext(1)]
		public IEnumerable<DicIntString> InstanceDungeonTypeNameIter()
		{
			RogueSeason.<InstanceDungeonTypeNameIter>d__47 <InstanceDungeonTypeNameIter>d__ = new RogueSeason.<InstanceDungeonTypeNameIter>d__47(-2);
			<InstanceDungeonTypeNameIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonTypeNameIter>d__;
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x0030DE34 File Offset: 0x0030C034
		public IntArray? GetInstanceDungeonList(int key)
		{
			this.EnsureInstanceDungeonListCacheIfNeeded();
			IntArray value;
			if (!this.InstanceDungeonListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x0030DE68 File Offset: 0x0030C068
		[NullableContext(2)]
		public string GetInstanceDungeonTypeName(int key)
		{
			this.EnsureInstanceDungeonTypeNameCacheIfNeeded();
			string result;
			if (!this.InstanceDungeonTypeNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x0030DE90 File Offset: 0x0030C090
		private void EnsureInstanceDungeonListCacheIfNeeded()
		{
			if (this.InstanceDungeonListCache != null)
			{
				return;
			}
			this.InstanceDungeonListCache = this.InstanceDungeonListIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x0030DEF8 File Offset: 0x0030C0F8
		private void EnsureInstanceDungeonTypeNameCacheIfNeeded()
		{
			if (this.InstanceDungeonTypeNameCache != null)
			{
				return;
			}
			this.InstanceDungeonTypeNameCache = this.InstanceDungeonTypeNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x0030DF5E File Offset: 0x0030C15E
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetInstanceDungeonListFrozenDict()
		{
			this.EnsureInstanceDungeonListCacheIfNeeded();
			return this.InstanceDungeonListCache;
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x0030DF6C File Offset: 0x0030C16C
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetInstanceDungeonTypeNameFrozenDict()
		{
			this.EnsureInstanceDungeonTypeNameCacheIfNeeded();
			return this.InstanceDungeonTypeNameCache;
		}

		// Token: 0x040056F7 RID: 22263
		private Table __p;

		// Token: 0x040056F8 RID: 22264
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> InstanceDungeonListCache;

		// Token: 0x040056F9 RID: 22265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> InstanceDungeonTypeNameCache;
	}
}
