using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D39 RID: 3385
	public struct ExploreTools : IFlatbufferObject
	{
		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x002489B9 File Offset: 0x00246BB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x002489C6 File Offset: 0x00246BC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x002489D0 File Offset: 0x00246BD0
		public static ExploreTools GetRootAsExploreTools(ByteBuffer _bb)
		{
			return ExploreTools.GetRootAsExploreTools(_bb, default(ExploreTools));
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x002489EC File Offset: 0x00246BEC
		public static ExploreTools GetRootAsExploreTools(ByteBuffer _bb, ExploreTools obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00248A09 File Offset: 0x00246C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00248A18 File Offset: 0x00246C18
		public ExploreTools __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06007200 RID: 29184 RVA: 0x00248A28 File Offset: 0x00246C28
		public int PhantomSkillId
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

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x00248A64 File Offset: 0x00246C64
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00248A9B File Offset: 0x00246C9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00248AAA File Offset: 0x00246CAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06007204 RID: 29188 RVA: 0x00248AC4 File Offset: 0x00246CC4
		public int SkillType
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

		// Token: 0x06007205 RID: 29189 RVA: 0x00248B00 File Offset: 0x00246D00
		public int RouletteType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06007206 RID: 29190 RVA: 0x00248B40 File Offset: 0x00246D40
		public int RouletteTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00248B6C File Offset: 0x00246D6C
		public Span<int> GetRouletteTypeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x00248B7C File Offset: 0x00246D7C
		public int[] GetRouletteTypeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x00248B94 File Offset: 0x00246D94
		public bool CanEquip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x00248BD4 File Offset: 0x00246DD4
		public bool AssemblyEquipButton
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x00248C14 File Offset: 0x00246E14
		public bool CanAssemblyShow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x00248C54 File Offset: 0x00246E54
		public int UseType
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

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x00248C94 File Offset: 0x00246E94
		public bool InputLogReport
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x0600720E RID: 29198 RVA: 0x00248CD4 File Offset: 0x00246ED4
		public string CurrentSkillInfo
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

		// Token: 0x0600720F RID: 29199 RVA: 0x00248D0C File Offset: 0x00246F0C
		public Span<byte> GetCurrentSkillInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00248D1C File Offset: 0x00246F1C
		public byte[] GetCurrentSkillInfoArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06007211 RID: 29201 RVA: 0x00248D34 File Offset: 0x00246F34
		public int HelpId
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

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06007212 RID: 29202 RVA: 0x00248D74 File Offset: 0x00246F74
		public string Icon
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

		// Token: 0x06007213 RID: 29203 RVA: 0x00248DAC File Offset: 0x00246FAC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00248DBC File Offset: 0x00246FBC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x00248DD4 File Offset: 0x00246FD4
		public string BackGround
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

		// Token: 0x06007216 RID: 29206 RVA: 0x00248E0C File Offset: 0x0024700C
		public Span<byte> GetBackGroundBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00248E1C File Offset: 0x0024701C
		public byte[] GetBackGroundArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06007218 RID: 29208 RVA: 0x00248E34 File Offset: 0x00247034
		public string BattleViewIcon
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

		// Token: 0x06007219 RID: 29209 RVA: 0x00248E6C File Offset: 0x0024706C
		public Span<byte> GetBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x00248E7C File Offset: 0x0024707C
		public byte[] GetBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600721B RID: 29211 RVA: 0x00248E94 File Offset: 0x00247094
		public int SortId
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

		// Token: 0x0600721C RID: 29212 RVA: 0x00248ED4 File Offset: 0x002470D4
		public DicIntInt? Sort(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600721D RID: 29213 RVA: 0x00248F38 File Offset: 0x00247138
		public int SortLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600721E RID: 29214 RVA: 0x00248F64 File Offset: 0x00247164
		public bool AutoFill
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x0600721F RID: 29215 RVA: 0x00248FA4 File Offset: 0x002471A4
		public bool ShowUnlock
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06007220 RID: 29216 RVA: 0x00248FE4 File Offset: 0x002471E4
		public int SkillGroupId
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

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06007221 RID: 29217 RVA: 0x00249024 File Offset: 0x00247224
		public bool IsUseInPhantomTeam
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00249064 File Offset: 0x00247264
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06007223 RID: 29219 RVA: 0x002490C8 File Offset: 0x002472C8
		public int CostLength
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

		// Token: 0x06007224 RID: 29220 RVA: 0x002490F4 File Offset: 0x002472F4
		public DicIntInt? Authorization(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06007225 RID: 29221 RVA: 0x00249158 File Offset: 0x00247358
		public int AuthorizationLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06007226 RID: 29222 RVA: 0x00249184 File Offset: 0x00247384
		public int SummonConfigId
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

		// Token: 0x06007227 RID: 29223 RVA: 0x002491C4 File Offset: 0x002473C4
		[NullableContext(1)]
		public Dictionary<int, int> Authorization()
		{
			return this.AuthorizationIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0024921A File Offset: 0x0024741A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AuthorizationIter()
		{
			ExploreTools.<AuthorizationIter>d__71 <AuthorizationIter>d__ = new ExploreTools.<AuthorizationIter>d__71(-2);
			<AuthorizationIter>d__.<>3__<>4__this = this;
			return <AuthorizationIter>d__;
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00249230 File Offset: 0x00247430
		[NullableContext(1)]
		public Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00249286 File Offset: 0x00247486
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CostIter()
		{
			ExploreTools.<CostIter>d__73 <CostIter>d__ = new ExploreTools.<CostIter>d__73(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x0024929B File Offset: 0x0024749B
		[NullableContext(1)]
		public int[] RouletteType()
		{
			return this.GetRouletteTypeArray();
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x002492A3 File Offset: 0x002474A3
		[NullableContext(1)]
		public IEnumerable<int> RouletteTypeIter()
		{
			ExploreTools.<RouletteTypeIter>d__75 <RouletteTypeIter>d__ = new ExploreTools.<RouletteTypeIter>d__75(-2);
			<RouletteTypeIter>d__.<>3__<>4__this = this;
			return <RouletteTypeIter>d__;
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x002492B8 File Offset: 0x002474B8
		[NullableContext(1)]
		public Dictionary<int, int> Sort()
		{
			return this.SortIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x0024930E File Offset: 0x0024750E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SortIter()
		{
			ExploreTools.<SortIter>d__77 <SortIter>d__ = new ExploreTools.<SortIter>d__77(-2);
			<SortIter>d__.<>3__<>4__this = this;
			return <SortIter>d__;
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00249324 File Offset: 0x00247524
		public int? GetAuthorization(int key)
		{
			this.EnsureAuthorizationCacheIfNeeded();
			int value;
			if (!this.AuthorizationCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00249358 File Offset: 0x00247558
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x0024938C File Offset: 0x0024758C
		public int? GetSort(int key)
		{
			this.EnsureSortCacheIfNeeded();
			int value;
			if (!this.SortCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x002493C0 File Offset: 0x002475C0
		private void EnsureAuthorizationCacheIfNeeded()
		{
			if (this.AuthorizationCache != null)
			{
				return;
			}
			this.AuthorizationCache = this.AuthorizationIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x00249428 File Offset: 0x00247628
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00249490 File Offset: 0x00247690
		private void EnsureSortCacheIfNeeded()
		{
			if (this.SortCache != null)
			{
				return;
			}
			this.SortCache = this.SortIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x002494F6 File Offset: 0x002476F6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAuthorizationFrozenDict()
		{
			this.EnsureAuthorizationCacheIfNeeded();
			return this.AuthorizationCache;
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00249504 File Offset: 0x00247704
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCostFrozenDict()
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x00249512 File Offset: 0x00247712
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSortFrozenDict()
		{
			this.EnsureSortCacheIfNeeded();
			return this.SortCache;
		}

		// Token: 0x04005281 RID: 21121
		private Table __p;

		// Token: 0x04005282 RID: 21122
		[Nullable(2)]
		private FrozenDictionary<int, int> AuthorizationCache;

		// Token: 0x04005283 RID: 21123
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;

		// Token: 0x04005284 RID: 21124
		[Nullable(2)]
		private FrozenDictionary<int, int> SortCache;
	}
}
