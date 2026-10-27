using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FD RID: 4349
	public struct SurvivorsLevel : IFlatbufferObject
	{
		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600DA8E RID: 55950 RVA: 0x00324019 File Offset: 0x00322219
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00324026 File Offset: 0x00322226
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA90 RID: 55952 RVA: 0x00324030 File Offset: 0x00322230
		public static SurvivorsLevel GetRootAsSurvivorsLevel(ByteBuffer _bb)
		{
			return SurvivorsLevel.GetRootAsSurvivorsLevel(_bb, default(SurvivorsLevel));
		}

		// Token: 0x0600DA91 RID: 55953 RVA: 0x0032404C File Offset: 0x0032224C
		public static SurvivorsLevel GetRootAsSurvivorsLevel(ByteBuffer _bb, SurvivorsLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA92 RID: 55954 RVA: 0x00324069 File Offset: 0x00322269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x00324078 File Offset: 0x00322278
		public SurvivorsLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x00324088 File Offset: 0x00322288
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

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600DA95 RID: 55957 RVA: 0x003240C4 File Offset: 0x003222C4
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

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x00324100 File Offset: 0x00322300
		public int InstId
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

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600DA97 RID: 55959 RVA: 0x0032413C File Offset: 0x0032233C
		public int UnlockConditionId
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

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600DA98 RID: 55960 RVA: 0x0032417C File Offset: 0x0032237C
		public bool EndlessMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DA99 RID: 55961 RVA: 0x003241BC File Offset: 0x003223BC
		public int InitRoles(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x003241FC File Offset: 0x003223FC
		public int InitRolesLength
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

		// Token: 0x0600DA9B RID: 55963 RVA: 0x00324228 File Offset: 0x00322428
		public Span<int> GetInitRolesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x00324238 File Offset: 0x00322438
		public int[] GetInitRolesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600DA9D RID: 55965 RVA: 0x00324250 File Offset: 0x00322450
		public int InitWeapons(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x00324290 File Offset: 0x00322490
		public int InitWeaponsLength
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

		// Token: 0x0600DA9F RID: 55967 RVA: 0x003242BC File Offset: 0x003224BC
		public Span<int> GetInitWeaponsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x003242CC File Offset: 0x003224CC
		public int[] GetInitWeaponsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x003242E4 File Offset: 0x003224E4
		public int Diff
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

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600DAA2 RID: 55970 RVA: 0x00324324 File Offset: 0x00322524
		public string Icon
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

		// Token: 0x0600DAA3 RID: 55971 RVA: 0x0032435C File Offset: 0x0032255C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600DAA4 RID: 55972 RVA: 0x0032436C File Offset: 0x0032256C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x00324384 File Offset: 0x00322584
		public string Name
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

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x003243BC File Offset: 0x003225BC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x003243CC File Offset: 0x003225CC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x003243E4 File Offset: 0x003225E4
		public DicIntString? InstDesc(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x00324448 File Offset: 0x00322648
		public int InstDescLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DAAA RID: 55978 RVA: 0x00324474 File Offset: 0x00322674
		public DicIntString? TargetDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x003244D8 File Offset: 0x003226D8
		public int TargetDescLength
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

		// Token: 0x0600DAAC RID: 55980 RVA: 0x00324504 File Offset: 0x00322704
		public int MonsterSpawnPoints(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600DAAD RID: 55981 RVA: 0x00324544 File Offset: 0x00322744
		public int MonsterSpawnPointsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00324570 File Offset: 0x00322770
		public Span<int> GetMonsterSpawnPointsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00324580 File Offset: 0x00322780
		public int[] GetMonsterSpawnPointsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600DAB0 RID: 55984 RVA: 0x00324598 File Offset: 0x00322798
		public int ComboCfgId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x003245D8 File Offset: 0x003227D8
		public int RewardId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600DAB2 RID: 55986 RVA: 0x00324618 File Offset: 0x00322818
		public int RewardIdLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DAB3 RID: 55987 RVA: 0x00324644 File Offset: 0x00322844
		public Span<int> GetRewardIdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600DAB4 RID: 55988 RVA: 0x00324654 File Offset: 0x00322854
		public int[] GetRewardIdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600DAB5 RID: 55989 RVA: 0x0032466C File Offset: 0x0032286C
		public string BoundsPath
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DAB6 RID: 55990 RVA: 0x003246A4 File Offset: 0x003228A4
		public Span<byte> GetBoundsPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600DAB7 RID: 55991 RVA: 0x003246B4 File Offset: 0x003228B4
		public byte[] GetBoundsPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x003246CC File Offset: 0x003228CC
		public int LevelInfoType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x0032470C File Offset: 0x0032290C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitRolesIter()或GetInitRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitRoles()
		{
			SurvivorsLevel survivorsLevel = this;
			return survivorsLevel.GetInitRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x00324730 File Offset: 0x00322930
		[NullableContext(1)]
		public readonly IEnumerable<int> InitRolesIter()
		{
			SurvivorsLevel.<InitRolesIter>d__63 <InitRolesIter>d__ = new SurvivorsLevel.<InitRolesIter>d__63(-2);
			<InitRolesIter>d__.<>3__<>4__this = this;
			return <InitRolesIter>d__;
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00324748 File Offset: 0x00322948
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitWeaponsIter()或GetInitWeaponsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitWeapons()
		{
			SurvivorsLevel survivorsLevel = this;
			return survivorsLevel.GetInitWeaponsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x0032476C File Offset: 0x0032296C
		[NullableContext(1)]
		public readonly IEnumerable<int> InitWeaponsIter()
		{
			SurvivorsLevel.<InitWeaponsIter>d__65 <InitWeaponsIter>d__ = new SurvivorsLevel.<InitWeaponsIter>d__65(-2);
			<InitWeaponsIter>d__.<>3__<>4__this = this;
			return <InitWeaponsIter>d__;
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x00324784 File Offset: 0x00322984
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InstDescFrozenDict()缓存字典，遍历请使用InstDescIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> InstDesc()
		{
			return this.InstDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x003247DA File Offset: 0x003229DA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> InstDescIter()
		{
			SurvivorsLevel.<InstDescIter>d__67 <InstDescIter>d__ = new SurvivorsLevel.<InstDescIter>d__67(-2);
			<InstDescIter>d__.<>3__<>4__this = this;
			return <InstDescIter>d__;
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x003247F0 File Offset: 0x003229F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterSpawnPointsIter()或GetMonsterSpawnPointsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterSpawnPoints()
		{
			SurvivorsLevel survivorsLevel = this;
			return survivorsLevel.GetMonsterSpawnPointsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x00324814 File Offset: 0x00322A14
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterSpawnPointsIter()
		{
			SurvivorsLevel.<MonsterSpawnPointsIter>d__69 <MonsterSpawnPointsIter>d__ = new SurvivorsLevel.<MonsterSpawnPointsIter>d__69(-2);
			<MonsterSpawnPointsIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnPointsIter>d__;
		}

		// Token: 0x0600DAC1 RID: 56001 RVA: 0x0032482C File Offset: 0x00322A2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardIdIter()或GetRewardIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardId()
		{
			SurvivorsLevel survivorsLevel = this;
			return survivorsLevel.GetRewardIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DAC2 RID: 56002 RVA: 0x00324850 File Offset: 0x00322A50
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardIdIter()
		{
			SurvivorsLevel.<RewardIdIter>d__71 <RewardIdIter>d__ = new SurvivorsLevel.<RewardIdIter>d__71(-2);
			<RewardIdIter>d__.<>3__<>4__this = this;
			return <RewardIdIter>d__;
		}

		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00324868 File Offset: 0x00322A68
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TargetDescFrozenDict()缓存字典，遍历请使用TargetDescIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TargetDesc()
		{
			return this.TargetDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x003248BE File Offset: 0x00322ABE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TargetDescIter()
		{
			SurvivorsLevel.<TargetDescIter>d__73 <TargetDescIter>d__ = new SurvivorsLevel.<TargetDescIter>d__73(-2);
			<TargetDescIter>d__.<>3__<>4__this = this;
			return <TargetDescIter>d__;
		}

		// Token: 0x0600DAC5 RID: 56005 RVA: 0x003248D4 File Offset: 0x00322AD4
		[NullableContext(2)]
		public string GetInstDesc(int key)
		{
			this.EnsureInstDescCacheIfNeeded();
			string result;
			if (!this.InstDescCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x003248FC File Offset: 0x00322AFC
		[NullableContext(2)]
		public string GetTargetDesc(int key)
		{
			this.EnsureTargetDescCacheIfNeeded();
			string result;
			if (!this.TargetDescCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00324924 File Offset: 0x00322B24
		private void EnsureInstDescCacheIfNeeded()
		{
			if (this.InstDescCache != null)
			{
				return;
			}
			this.InstDescCache = this.InstDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x0032498C File Offset: 0x00322B8C
		private void EnsureTargetDescCacheIfNeeded()
		{
			if (this.TargetDescCache != null)
			{
				return;
			}
			this.TargetDescCache = this.TargetDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x003249F2 File Offset: 0x00322BF2
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetInstDescFrozenDict(int key)
		{
			this.EnsureInstDescCacheIfNeeded();
			return this.InstDescCache;
		}

		// Token: 0x0600DACA RID: 56010 RVA: 0x00324A00 File Offset: 0x00322C00
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTargetDescFrozenDict(int key)
		{
			this.EnsureTargetDescCacheIfNeeded();
			return this.TargetDescCache;
		}

		// Token: 0x04005233 RID: 21043
		private Table __p;

		// Token: 0x04005234 RID: 21044
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> InstDescCache;

		// Token: 0x04005235 RID: 21045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TargetDescCache;
	}
}
