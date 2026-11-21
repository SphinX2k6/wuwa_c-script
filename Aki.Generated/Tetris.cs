using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001258 RID: 4696
	public struct Tetris : IFlatbufferObject
	{
		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x00356AED File Offset: 0x00354CED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x00356AFA File Offset: 0x00354CFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x00356B04 File Offset: 0x00354D04
		public static Tetris GetRootAsTetris(ByteBuffer _bb)
		{
			return Tetris.GetRootAsTetris(_bb, default(Tetris));
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x00356B20 File Offset: 0x00354D20
		public static Tetris GetRootAsTetris(ByteBuffer _bb, Tetris obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x00356B3D File Offset: 0x00354D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x00356B4C File Offset: 0x00354D4C
		public Tetris __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600EB2C RID: 60204 RVA: 0x00356B5C File Offset: 0x00354D5C
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

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600EB2D RID: 60205 RVA: 0x00356B98 File Offset: 0x00354D98
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

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600EB2E RID: 60206 RVA: 0x00356BD4 File Offset: 0x00354DD4
		public int GroupId
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

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600EB2F RID: 60207 RVA: 0x00356C10 File Offset: 0x00354E10
		public int UnlockId
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

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600EB30 RID: 60208 RVA: 0x00356C50 File Offset: 0x00354E50
		public int Mode
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

		// Token: 0x0600EB31 RID: 60209 RVA: 0x00356C90 File Offset: 0x00354E90
		public DicIntInt? TargetResult(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x00356CF4 File Offset: 0x00354EF4
		public int TargetResultLength
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

		// Token: 0x0600EB33 RID: 60211 RVA: 0x00356D20 File Offset: 0x00354F20
		public IntIntMap? TargetResults(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntIntMap?(default(IntIntMap).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600EB34 RID: 60212 RVA: 0x00356D84 File Offset: 0x00354F84
		public int TargetResultsLength
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

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600EB35 RID: 60213 RVA: 0x00356DB0 File Offset: 0x00354FB0
		public int OpenDay
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

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600EB36 RID: 60214 RVA: 0x00356DF0 File Offset: 0x00354FF0
		public int DropId
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

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600EB37 RID: 60215 RVA: 0x00356E30 File Offset: 0x00355030
		public int BlockNum
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600EB38 RID: 60216 RVA: 0x00356E70 File Offset: 0x00355070
		public string TotalLevelName
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x00356EA8 File Offset: 0x003550A8
		public Span<byte> GetTotalLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x00356EB8 File Offset: 0x003550B8
		public byte[] GetTotalLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600EB3B RID: 60219 RVA: 0x00356ED0 File Offset: 0x003550D0
		public string LevelName
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x00356F08 File Offset: 0x00355108
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x00356F18 File Offset: 0x00355118
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600EB3E RID: 60222 RVA: 0x00356F30 File Offset: 0x00355130
		public string LevelDes
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x00356F68 File Offset: 0x00355168
		public Span<byte> GetLevelDesBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x00356F78 File Offset: 0x00355178
		public byte[] GetLevelDesArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x00356F90 File Offset: 0x00355190
		public int ReduceDiffCnt(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600EB42 RID: 60226 RVA: 0x00356FD0 File Offset: 0x003551D0
		public int ReduceDiffCntLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x00356FFC File Offset: 0x003551FC
		public Span<int> GetReduceDiffCntBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x0035700C File Offset: 0x0035520C
		public int[] GetReduceDiffCntArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600EB45 RID: 60229 RVA: 0x00357024 File Offset: 0x00355224
		public int TakeBackCnt
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600EB46 RID: 60230 RVA: 0x00357064 File Offset: 0x00355264
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x003570A4 File Offset: 0x003552A4
		public string FlowId(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600EB48 RID: 60232 RVA: 0x003570E0 File Offset: 0x003552E0
		public int FlowIdLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600EB49 RID: 60233 RVA: 0x0035710C File Offset: 0x0035530C
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600EB4A RID: 60234 RVA: 0x0035714C File Offset: 0x0035534C
		public bool EnableRotation
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600EB4B RID: 60235 RVA: 0x0035718C File Offset: 0x0035538C
		public TetrisRotationConfig? RotationConfig
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new TetrisRotationConfig?(default(TetrisRotationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600EB4C RID: 60236 RVA: 0x003571EC File Offset: 0x003553EC
		public TetrisBombConfig? BombConfig
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new TetrisBombConfig?(default(TetrisBombConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600EB4D RID: 60237 RVA: 0x0035724C File Offset: 0x0035544C
		public bool NeedRecord
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x0035728C File Offset: 0x0035548C
		[NullableContext(1)]
		public string[] FlowId()
		{
			return this.FlowIdIter().ToArray<string>();
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x00357299 File Offset: 0x00355499
		[NullableContext(1)]
		public IEnumerable<string> FlowIdIter()
		{
			Tetris.<FlowIdIter>d__65 <FlowIdIter>d__ = new Tetris.<FlowIdIter>d__65(-2);
			<FlowIdIter>d__.<>3__<>4__this = this;
			return <FlowIdIter>d__;
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x003572AE File Offset: 0x003554AE
		[NullableContext(1)]
		public int[] ReduceDiffCnt()
		{
			return this.GetReduceDiffCntArray();
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x003572B6 File Offset: 0x003554B6
		[NullableContext(1)]
		public IEnumerable<int> ReduceDiffCntIter()
		{
			Tetris.<ReduceDiffCntIter>d__67 <ReduceDiffCntIter>d__ = new Tetris.<ReduceDiffCntIter>d__67(-2);
			<ReduceDiffCntIter>d__.<>3__<>4__this = this;
			return <ReduceDiffCntIter>d__;
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x003572CC File Offset: 0x003554CC
		[NullableContext(1)]
		public Dictionary<int, int> TargetResult()
		{
			return this.TargetResultIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x00357322 File Offset: 0x00355522
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TargetResultIter()
		{
			Tetris.<TargetResultIter>d__69 <TargetResultIter>d__ = new Tetris.<TargetResultIter>d__69(-2);
			<TargetResultIter>d__.<>3__<>4__this = this;
			return <TargetResultIter>d__;
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x00357337 File Offset: 0x00355537
		[NullableContext(1)]
		public IntIntMap[] TargetResults()
		{
			return this.TargetResultsIter().ToArray<IntIntMap>();
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x00357344 File Offset: 0x00355544
		[NullableContext(1)]
		public IEnumerable<IntIntMap> TargetResultsIter()
		{
			Tetris.<TargetResultsIter>d__71 <TargetResultsIter>d__ = new Tetris.<TargetResultsIter>d__71(-2);
			<TargetResultsIter>d__.<>3__<>4__this = this;
			return <TargetResultsIter>d__;
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x0035735C File Offset: 0x0035555C
		public int? GetTargetResult(int key)
		{
			this.EnsureTargetResultCacheIfNeeded();
			int value;
			if (!this.TargetResultCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x00357390 File Offset: 0x00355590
		private void EnsureTargetResultCacheIfNeeded()
		{
			if (this.TargetResultCache != null)
			{
				return;
			}
			this.TargetResultCache = this.TargetResultIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x003573F6 File Offset: 0x003555F6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTargetResultFrozenDict()
		{
			this.EnsureTargetResultCacheIfNeeded();
			return this.TargetResultCache;
		}

		// Token: 0x040058A2 RID: 22690
		private Table __p;

		// Token: 0x040058A3 RID: 22691
		[Nullable(2)]
		private FrozenDictionary<int, int> TargetResultCache;
	}
}
