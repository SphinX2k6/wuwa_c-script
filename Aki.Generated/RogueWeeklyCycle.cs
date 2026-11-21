using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001114 RID: 4372
	public struct RogueWeeklyCycle : IFlatbufferObject
	{
		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600CC31 RID: 52273 RVA: 0x003100B0 File Offset: 0x0030E2B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x003100BD File Offset: 0x0030E2BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x003100C4 File Offset: 0x0030E2C4
		public static RogueWeeklyCycle GetRootAsRogueWeeklyCycle(ByteBuffer _bb)
		{
			return RogueWeeklyCycle.GetRootAsRogueWeeklyCycle(_bb, default(RogueWeeklyCycle));
		}

		// Token: 0x0600CC34 RID: 52276 RVA: 0x003100E0 File Offset: 0x0030E2E0
		public static RogueWeeklyCycle GetRootAsRogueWeeklyCycle(ByteBuffer _bb, RogueWeeklyCycle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x003100FD File Offset: 0x0030E2FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x0031010C File Offset: 0x0030E30C
		public RogueWeeklyCycle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600CC37 RID: 52279 RVA: 0x0031011C File Offset: 0x0030E31C
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

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600CC38 RID: 52280 RVA: 0x00310158 File Offset: 0x0030E358
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

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600CC39 RID: 52281 RVA: 0x00310194 File Offset: 0x0030E394
		public int LoopId
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

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600CC3A RID: 52282 RVA: 0x003101D0 File Offset: 0x0030E3D0
		public int TimeId
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

		// Token: 0x0600CC3B RID: 52283 RVA: 0x00310210 File Offset: 0x0030E410
		public DicIntInt? Diff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600CC3C RID: 52284 RVA: 0x00310274 File Offset: 0x0030E474
		public int DiffLength
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

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600CC3D RID: 52285 RVA: 0x003102A0 File Offset: 0x0030E4A0
		public int MapMark
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

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x003102E0 File Offset: 0x0030E4E0
		public int QuestId
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

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600CC3F RID: 52287 RVA: 0x00310320 File Offset: 0x0030E520
		public int EntranceId
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

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600CC40 RID: 52288 RVA: 0x00310360 File Offset: 0x0030E560
		public int InstId
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

		// Token: 0x0600CC41 RID: 52289 RVA: 0x003103A0 File Offset: 0x0030E5A0
		public int RecommendedRole(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600CC42 RID: 52290 RVA: 0x003103E0 File Offset: 0x0030E5E0
		public int RecommendedRoleLength
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

		// Token: 0x0600CC43 RID: 52291 RVA: 0x0031040C File Offset: 0x0030E60C
		public Span<int> GetRecommendedRoleBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x0031041C File Offset: 0x0030E61C
		public int[] GetRecommendedRoleArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600CC45 RID: 52293 RVA: 0x00310434 File Offset: 0x0030E634
		public int ScoreRate
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

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600CC46 RID: 52294 RVA: 0x00310474 File Offset: 0x0030E674
		public string RoguelikeRoomFloatTipsSpecialIcon
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

		// Token: 0x0600CC47 RID: 52295 RVA: 0x003104AC File Offset: 0x0030E6AC
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CC48 RID: 52296 RVA: 0x003104BC File Offset: 0x0030E6BC
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x003104D4 File Offset: 0x0030E6D4
		public DicIntInt? BlackFlowerCost(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00310538 File Offset: 0x0030E738
		public int BlackFlowerCostLength
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

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600CC4B RID: 52299 RVA: 0x00310564 File Offset: 0x0030E764
		public int BlackFlowerAward
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

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x003105A4 File Offset: 0x0030E7A4
		public int GoldItemId
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

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600CC4D RID: 52301 RVA: 0x003105E4 File Offset: 0x0030E7E4
		public string CycleName
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

		// Token: 0x0600CC4E RID: 52302 RVA: 0x0031061C File Offset: 0x0030E81C
		public Span<byte> GetCycleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x0031062C File Offset: 0x0030E82C
		public byte[] GetCycleNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x00310644 File Offset: 0x0030E844
		public string ViewBackground
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x0031067C File Offset: 0x0030E87C
		public Span<byte> GetViewBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x0031068C File Offset: 0x0030E88C
		public byte[] GetViewBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600CC53 RID: 52307 RVA: 0x003106A4 File Offset: 0x0030E8A4
		public string BuffIcon
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x003106DC File Offset: 0x0030E8DC
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x003106EC File Offset: 0x0030E8EC
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600CC56 RID: 52310 RVA: 0x00310704 File Offset: 0x0030E904
		public int BuffPR
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600CC57 RID: 52311 RVA: 0x00310744 File Offset: 0x0030E944
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x0031077C File Offset: 0x0030E97C
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600CC59 RID: 52313 RVA: 0x0031078C File Offset: 0x0030E98C
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x003107A4 File Offset: 0x0030E9A4
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600CC5B RID: 52315 RVA: 0x003107E0 File Offset: 0x0030E9E0
		public int BuffDescParamLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x0031080C File Offset: 0x0030EA0C
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x0031084C File Offset: 0x0030EA4C
		public int BlackFlowerHelpId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x0031088C File Offset: 0x0030EA8C
		public int BaseScore
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 4000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600CC5F RID: 52319 RVA: 0x003108D0 File Offset: 0x0030EAD0
		public int MaxScore
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00310910 File Offset: 0x0030EB10
		public int LinkId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00310950 File Offset: 0x0030EB50
		public DicIntLong54? BattleBuffIdMap(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new DicIntLong54?(default(DicIntLong54).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600CC62 RID: 52322 RVA: 0x003109B4 File Offset: 0x0030EBB4
		public int BattleBuffIdMapLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600CC63 RID: 52323 RVA: 0x003109E0 File Offset: 0x0030EBE0
		public long BattleBuffId
		{
			get
			{
				int num = this.__p.__offset(58);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600CC64 RID: 52324 RVA: 0x00310A28 File Offset: 0x0030EC28
		[NullableContext(1)]
		public Dictionary<int, long> BattleBuffIdMap()
		{
			return this.BattleBuffIdMapIter().ToDictionary((DicIntLong54 element) => element.Key, (DicIntLong54 element) => element.Value);
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x00310A7E File Offset: 0x0030EC7E
		[NullableContext(1)]
		public IEnumerable<DicIntLong54> BattleBuffIdMapIter()
		{
			RogueWeeklyCycle.<BattleBuffIdMapIter>d__82 <BattleBuffIdMapIter>d__ = new RogueWeeklyCycle.<BattleBuffIdMapIter>d__82(-2);
			<BattleBuffIdMapIter>d__.<>3__<>4__this = this;
			return <BattleBuffIdMapIter>d__;
		}

		// Token: 0x0600CC66 RID: 52326 RVA: 0x00310A94 File Offset: 0x0030EC94
		[NullableContext(1)]
		public Dictionary<int, int> BlackFlowerCost()
		{
			return this.BlackFlowerCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x00310AEA File Offset: 0x0030ECEA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BlackFlowerCostIter()
		{
			RogueWeeklyCycle.<BlackFlowerCostIter>d__84 <BlackFlowerCostIter>d__ = new RogueWeeklyCycle.<BlackFlowerCostIter>d__84(-2);
			<BlackFlowerCostIter>d__.<>3__<>4__this = this;
			return <BlackFlowerCostIter>d__;
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x00310AFF File Offset: 0x0030ECFF
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x00310B0C File Offset: 0x0030ED0C
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			RogueWeeklyCycle.<BuffDescParamIter>d__86 <BuffDescParamIter>d__ = new RogueWeeklyCycle.<BuffDescParamIter>d__86(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00310B24 File Offset: 0x0030ED24
		[NullableContext(1)]
		public Dictionary<int, int> Diff()
		{
			return this.DiffIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00310B7A File Offset: 0x0030ED7A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DiffIter()
		{
			RogueWeeklyCycle.<DiffIter>d__88 <DiffIter>d__ = new RogueWeeklyCycle.<DiffIter>d__88(-2);
			<DiffIter>d__.<>3__<>4__this = this;
			return <DiffIter>d__;
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00310B8F File Offset: 0x0030ED8F
		[NullableContext(1)]
		public int[] RecommendedRole()
		{
			return this.GetRecommendedRoleArray();
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x00310B97 File Offset: 0x0030ED97
		[NullableContext(1)]
		public IEnumerable<int> RecommendedRoleIter()
		{
			RogueWeeklyCycle.<RecommendedRoleIter>d__90 <RecommendedRoleIter>d__ = new RogueWeeklyCycle.<RecommendedRoleIter>d__90(-2);
			<RecommendedRoleIter>d__.<>3__<>4__this = this;
			return <RecommendedRoleIter>d__;
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00310BAC File Offset: 0x0030EDAC
		public long? GetBattleBuffIdMap(int key)
		{
			this.EnsureBattleBuffIdMapCacheIfNeeded();
			long value;
			if (!this.BattleBuffIdMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new long?(value);
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x00310BE0 File Offset: 0x0030EDE0
		public int? GetBlackFlowerCost(int key)
		{
			this.EnsureBlackFlowerCostCacheIfNeeded();
			int value;
			if (!this.BlackFlowerCostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CC70 RID: 52336 RVA: 0x00310C14 File Offset: 0x0030EE14
		public int? GetDiff(int key)
		{
			this.EnsureDiffCacheIfNeeded();
			int value;
			if (!this.DiffCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x00310C48 File Offset: 0x0030EE48
		private void EnsureBattleBuffIdMapCacheIfNeeded()
		{
			if (this.BattleBuffIdMapCache != null)
			{
				return;
			}
			this.BattleBuffIdMapCache = this.BattleBuffIdMapIter().ToFrozenDictionary((DicIntLong54 kvp) => kvp.Key, (DicIntLong54 kvp) => kvp.Value, null);
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x00310CB0 File Offset: 0x0030EEB0
		private void EnsureBlackFlowerCostCacheIfNeeded()
		{
			if (this.BlackFlowerCostCache != null)
			{
				return;
			}
			this.BlackFlowerCostCache = this.BlackFlowerCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x00310D18 File Offset: 0x0030EF18
		private void EnsureDiffCacheIfNeeded()
		{
			if (this.DiffCache != null)
			{
				return;
			}
			this.DiffCache = this.DiffIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x00310D7E File Offset: 0x0030EF7E
		[NullableContext(1)]
		public FrozenDictionary<int, long> GetBattleBuffIdMapFrozenDict()
		{
			this.EnsureBattleBuffIdMapCacheIfNeeded();
			return this.BattleBuffIdMapCache;
		}

		// Token: 0x0600CC75 RID: 52341 RVA: 0x00310D8C File Offset: 0x0030EF8C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBlackFlowerCostFrozenDict()
		{
			this.EnsureBlackFlowerCostCacheIfNeeded();
			return this.BlackFlowerCostCache;
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x00310D9A File Offset: 0x0030EF9A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDiffFrozenDict()
		{
			this.EnsureDiffCacheIfNeeded();
			return this.DiffCache;
		}

		// Token: 0x04005707 RID: 22279
		private Table __p;

		// Token: 0x04005708 RID: 22280
		[Nullable(2)]
		private FrozenDictionary<int, long> BattleBuffIdMapCache;

		// Token: 0x04005709 RID: 22281
		[Nullable(2)]
		private FrozenDictionary<int, int> BlackFlowerCostCache;

		// Token: 0x0400570A RID: 22282
		[Nullable(2)]
		private FrozenDictionary<int, int> DiffCache;
	}
}
