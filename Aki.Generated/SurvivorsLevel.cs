using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001233 RID: 4659
	public struct SurvivorsLevel : IFlatbufferObject
	{
		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x0034F3CE File Offset: 0x0034D5CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x0034F3DB File Offset: 0x0034D5DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x0034F3E4 File Offset: 0x0034D5E4
		public static SurvivorsLevel GetRootAsSurvivorsLevel(ByteBuffer _bb)
		{
			return SurvivorsLevel.GetRootAsSurvivorsLevel(_bb, default(SurvivorsLevel));
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x0034F400 File Offset: 0x0034D600
		public static SurvivorsLevel GetRootAsSurvivorsLevel(ByteBuffer _bb, SurvivorsLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x0034F41D File Offset: 0x0034D61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x0034F42C File Offset: 0x0034D62C
		public SurvivorsLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x0034F43C File Offset: 0x0034D63C
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

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600E7E0 RID: 59360 RVA: 0x0034F478 File Offset: 0x0034D678
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

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x0034F4B4 File Offset: 0x0034D6B4
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

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600E7E2 RID: 59362 RVA: 0x0034F4F0 File Offset: 0x0034D6F0
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

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x0034F530 File Offset: 0x0034D730
		public bool EndlessMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x0034F570 File Offset: 0x0034D770
		public int InitRoles(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x0034F5B0 File Offset: 0x0034D7B0
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

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x0034F5DC File Offset: 0x0034D7DC
		public Span<int> GetInitRolesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x0034F5EC File Offset: 0x0034D7EC
		public int[] GetInitRolesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x0034F604 File Offset: 0x0034D804
		public int InitWeapons(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600E7E9 RID: 59369 RVA: 0x0034F644 File Offset: 0x0034D844
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

		// Token: 0x0600E7EA RID: 59370 RVA: 0x0034F670 File Offset: 0x0034D870
		public Span<int> GetInitWeaponsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x0034F680 File Offset: 0x0034D880
		public int[] GetInitWeaponsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600E7EC RID: 59372 RVA: 0x0034F698 File Offset: 0x0034D898
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

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x0034F6D8 File Offset: 0x0034D8D8
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

		// Token: 0x0600E7EE RID: 59374 RVA: 0x0034F710 File Offset: 0x0034D910
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E7EF RID: 59375 RVA: 0x0034F720 File Offset: 0x0034D920
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x0034F738 File Offset: 0x0034D938
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

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x0034F770 File Offset: 0x0034D970
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x0034F780 File Offset: 0x0034D980
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x0034F798 File Offset: 0x0034D998
		public DicIntString? InstDesc(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600E7F4 RID: 59380 RVA: 0x0034F7FC File Offset: 0x0034D9FC
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

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x0034F828 File Offset: 0x0034DA28
		public DicIntString? TargetDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600E7F6 RID: 59382 RVA: 0x0034F88C File Offset: 0x0034DA8C
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

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x0034F8B8 File Offset: 0x0034DAB8
		public int MonsterSpawnPoints(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600E7F8 RID: 59384 RVA: 0x0034F8F8 File Offset: 0x0034DAF8
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

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x0034F924 File Offset: 0x0034DB24
		public Span<int> GetMonsterSpawnPointsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x0034F934 File Offset: 0x0034DB34
		public int[] GetMonsterSpawnPointsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x0034F94C File Offset: 0x0034DB4C
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

		// Token: 0x0600E7FC RID: 59388 RVA: 0x0034F98C File Offset: 0x0034DB8C
		public int RewardId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600E7FD RID: 59389 RVA: 0x0034F9CC File Offset: 0x0034DBCC
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

		// Token: 0x0600E7FE RID: 59390 RVA: 0x0034F9F8 File Offset: 0x0034DBF8
		public Span<int> GetRewardIdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600E7FF RID: 59391 RVA: 0x0034FA08 File Offset: 0x0034DC08
		public int[] GetRewardIdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600E800 RID: 59392 RVA: 0x0034FA20 File Offset: 0x0034DC20
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

		// Token: 0x0600E801 RID: 59393 RVA: 0x0034FA58 File Offset: 0x0034DC58
		public Span<byte> GetBoundsPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x0034FA68 File Offset: 0x0034DC68
		public byte[] GetBoundsPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600E803 RID: 59395 RVA: 0x0034FA80 File Offset: 0x0034DC80
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

		// Token: 0x0600E804 RID: 59396 RVA: 0x0034FABD File Offset: 0x0034DCBD
		[NullableContext(1)]
		public int[] InitRoles()
		{
			return this.GetInitRolesArray();
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x0034FAC5 File Offset: 0x0034DCC5
		[NullableContext(1)]
		public IEnumerable<int> InitRolesIter()
		{
			SurvivorsLevel.<InitRolesIter>d__63 <InitRolesIter>d__ = new SurvivorsLevel.<InitRolesIter>d__63(-2);
			<InitRolesIter>d__.<>3__<>4__this = this;
			return <InitRolesIter>d__;
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x0034FADA File Offset: 0x0034DCDA
		[NullableContext(1)]
		public int[] InitWeapons()
		{
			return this.GetInitWeaponsArray();
		}

		// Token: 0x0600E807 RID: 59399 RVA: 0x0034FAE2 File Offset: 0x0034DCE2
		[NullableContext(1)]
		public IEnumerable<int> InitWeaponsIter()
		{
			SurvivorsLevel.<InitWeaponsIter>d__65 <InitWeaponsIter>d__ = new SurvivorsLevel.<InitWeaponsIter>d__65(-2);
			<InitWeaponsIter>d__.<>3__<>4__this = this;
			return <InitWeaponsIter>d__;
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x0034FAF8 File Offset: 0x0034DCF8
		[NullableContext(1)]
		public Dictionary<int, string> InstDesc()
		{
			return this.InstDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x0034FB4E File Offset: 0x0034DD4E
		[NullableContext(1)]
		public IEnumerable<DicIntString> InstDescIter()
		{
			SurvivorsLevel.<InstDescIter>d__67 <InstDescIter>d__ = new SurvivorsLevel.<InstDescIter>d__67(-2);
			<InstDescIter>d__.<>3__<>4__this = this;
			return <InstDescIter>d__;
		}

		// Token: 0x0600E80A RID: 59402 RVA: 0x0034FB63 File Offset: 0x0034DD63
		[NullableContext(1)]
		public int[] MonsterSpawnPoints()
		{
			return this.GetMonsterSpawnPointsArray();
		}

		// Token: 0x0600E80B RID: 59403 RVA: 0x0034FB6B File Offset: 0x0034DD6B
		[NullableContext(1)]
		public IEnumerable<int> MonsterSpawnPointsIter()
		{
			SurvivorsLevel.<MonsterSpawnPointsIter>d__69 <MonsterSpawnPointsIter>d__ = new SurvivorsLevel.<MonsterSpawnPointsIter>d__69(-2);
			<MonsterSpawnPointsIter>d__.<>3__<>4__this = this;
			return <MonsterSpawnPointsIter>d__;
		}

		// Token: 0x0600E80C RID: 59404 RVA: 0x0034FB80 File Offset: 0x0034DD80
		[NullableContext(1)]
		public int[] RewardId()
		{
			return this.GetRewardIdArray();
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x0034FB88 File Offset: 0x0034DD88
		[NullableContext(1)]
		public IEnumerable<int> RewardIdIter()
		{
			SurvivorsLevel.<RewardIdIter>d__71 <RewardIdIter>d__ = new SurvivorsLevel.<RewardIdIter>d__71(-2);
			<RewardIdIter>d__.<>3__<>4__this = this;
			return <RewardIdIter>d__;
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x0034FBA0 File Offset: 0x0034DDA0
		[NullableContext(1)]
		public Dictionary<int, string> TargetDesc()
		{
			return this.TargetDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x0034FBF6 File Offset: 0x0034DDF6
		[NullableContext(1)]
		public IEnumerable<DicIntString> TargetDescIter()
		{
			SurvivorsLevel.<TargetDescIter>d__73 <TargetDescIter>d__ = new SurvivorsLevel.<TargetDescIter>d__73(-2);
			<TargetDescIter>d__.<>3__<>4__this = this;
			return <TargetDescIter>d__;
		}

		// Token: 0x0600E810 RID: 59408 RVA: 0x0034FC0C File Offset: 0x0034DE0C
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

		// Token: 0x0600E811 RID: 59409 RVA: 0x0034FC34 File Offset: 0x0034DE34
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

		// Token: 0x0600E812 RID: 59410 RVA: 0x0034FC5C File Offset: 0x0034DE5C
		private void EnsureInstDescCacheIfNeeded()
		{
			if (this.InstDescCache != null)
			{
				return;
			}
			this.InstDescCache = this.InstDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E813 RID: 59411 RVA: 0x0034FCC4 File Offset: 0x0034DEC4
		private void EnsureTargetDescCacheIfNeeded()
		{
			if (this.TargetDescCache != null)
			{
				return;
			}
			this.TargetDescCache = this.TargetDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600E814 RID: 59412 RVA: 0x0034FD2A File Offset: 0x0034DF2A
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetInstDescFrozenDict()
		{
			this.EnsureInstDescCacheIfNeeded();
			return this.InstDescCache;
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x0034FD38 File Offset: 0x0034DF38
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTargetDescFrozenDict()
		{
			this.EnsureTargetDescCacheIfNeeded();
			return this.TargetDescCache;
		}

		// Token: 0x04005876 RID: 22646
		private Table __p;

		// Token: 0x04005877 RID: 22647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> InstDescCache;

		// Token: 0x04005878 RID: 22648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TargetDescCache;
	}
}
