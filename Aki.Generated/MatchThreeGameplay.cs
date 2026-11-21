using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE3 RID: 3811
	public struct MatchThreeGameplay : IFlatbufferObject
	{
		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x002A01E5 File Offset: 0x0029E3E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x002A01F2 File Offset: 0x0029E3F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x002A01FC File Offset: 0x0029E3FC
		public static MatchThreeGameplay GetRootAsMatchThreeGameplay(ByteBuffer _bb)
		{
			return MatchThreeGameplay.GetRootAsMatchThreeGameplay(_bb, default(MatchThreeGameplay));
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x002A0218 File Offset: 0x0029E418
		public static MatchThreeGameplay GetRootAsMatchThreeGameplay(ByteBuffer _bb, MatchThreeGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x002A0235 File Offset: 0x0029E435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x002A0244 File Offset: 0x0029E444
		public MatchThreeGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060098D2 RID: 39122 RVA: 0x002A0254 File Offset: 0x0029E454
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

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060098D3 RID: 39123 RVA: 0x002A0290 File Offset: 0x0029E490
		public int Board
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

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060098D4 RID: 39124 RVA: 0x002A02CC File Offset: 0x0029E4CC
		public int TurnCount
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

		// Token: 0x060098D5 RID: 39125 RVA: 0x002A0308 File Offset: 0x0029E508
		public int Goal(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060098D6 RID: 39126 RVA: 0x002A0348 File Offset: 0x0029E548
		public int GoalLength
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

		// Token: 0x060098D7 RID: 39127 RVA: 0x002A0374 File Offset: 0x0029E574
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x002A0384 File Offset: 0x0029E584
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x002A039C File Offset: 0x0029E59C
		public string EnvironmentDesc
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

		// Token: 0x060098DA RID: 39130 RVA: 0x002A03D4 File Offset: 0x0029E5D4
		public Span<byte> GetEnvironmentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x002A03E4 File Offset: 0x0029E5E4
		public byte[] GetEnvironmentDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x002A03FC File Offset: 0x0029E5FC
		public DicIntInt? Enviroments(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060098DD RID: 39133 RVA: 0x002A0460 File Offset: 0x0029E660
		public int EnviromentsLength
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

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060098DE RID: 39134 RVA: 0x002A048C File Offset: 0x0029E68C
		public int ExchangeEnergy
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

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x060098DF RID: 39135 RVA: 0x002A04CC File Offset: 0x0029E6CC
		public int PointerDownTimeThreshold
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x060098E0 RID: 39136 RVA: 0x002A0510 File Offset: 0x0029E710
		public int ValidMoveTimeThreshold
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 7000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x002A0554 File Offset: 0x0029E754
		public int FillRules(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x060098E2 RID: 39138 RVA: 0x002A0594 File Offset: 0x0029E794
		public int FillRulesLength
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

		// Token: 0x060098E3 RID: 39139 RVA: 0x002A05C0 File Offset: 0x0029E7C0
		public Span<int> GetFillRulesBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x002A05D0 File Offset: 0x0029E7D0
		public int[] GetFillRulesArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x002A05E8 File Offset: 0x0029E7E8
		public int SpecialTiles(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x060098E6 RID: 39142 RVA: 0x002A0628 File Offset: 0x0029E828
		public int SpecialTilesLength
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

		// Token: 0x060098E7 RID: 39143 RVA: 0x002A0654 File Offset: 0x0029E854
		public Span<int> GetSpecialTilesBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x002A0664 File Offset: 0x0029E864
		public int[] GetSpecialTilesArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x002A067C File Offset: 0x0029E87C
		[NullableContext(1)]
		public Dictionary<int, int> Enviroments()
		{
			return this.EnviromentsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x002A06D2 File Offset: 0x0029E8D2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EnviromentsIter()
		{
			MatchThreeGameplay.<EnviromentsIter>d__43 <EnviromentsIter>d__ = new MatchThreeGameplay.<EnviromentsIter>d__43(-2);
			<EnviromentsIter>d__.<>3__<>4__this = this;
			return <EnviromentsIter>d__;
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x002A06E7 File Offset: 0x0029E8E7
		[NullableContext(1)]
		public int[] FillRules()
		{
			return this.GetFillRulesArray();
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x002A06EF File Offset: 0x0029E8EF
		[NullableContext(1)]
		public IEnumerable<int> FillRulesIter()
		{
			MatchThreeGameplay.<FillRulesIter>d__45 <FillRulesIter>d__ = new MatchThreeGameplay.<FillRulesIter>d__45(-2);
			<FillRulesIter>d__.<>3__<>4__this = this;
			return <FillRulesIter>d__;
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x002A0704 File Offset: 0x0029E904
		[NullableContext(1)]
		public int[] Goal()
		{
			return this.GetGoalArray();
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x002A070C File Offset: 0x0029E90C
		[NullableContext(1)]
		public IEnumerable<int> GoalIter()
		{
			MatchThreeGameplay.<GoalIter>d__47 <GoalIter>d__ = new MatchThreeGameplay.<GoalIter>d__47(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x002A0721 File Offset: 0x0029E921
		[NullableContext(1)]
		public int[] SpecialTiles()
		{
			return this.GetSpecialTilesArray();
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x002A0729 File Offset: 0x0029E929
		[NullableContext(1)]
		public IEnumerable<int> SpecialTilesIter()
		{
			MatchThreeGameplay.<SpecialTilesIter>d__49 <SpecialTilesIter>d__ = new MatchThreeGameplay.<SpecialTilesIter>d__49(-2);
			<SpecialTilesIter>d__.<>3__<>4__this = this;
			return <SpecialTilesIter>d__;
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x002A0740 File Offset: 0x0029E940
		public int? GetEnviroments(int key)
		{
			this.EnsureEnviromentsCacheIfNeeded();
			int value;
			if (!this.EnviromentsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x002A0774 File Offset: 0x0029E974
		private void EnsureEnviromentsCacheIfNeeded()
		{
			if (this.EnviromentsCache != null)
			{
				return;
			}
			this.EnviromentsCache = this.EnviromentsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x002A07DA File Offset: 0x0029E9DA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEnviromentsFrozenDict()
		{
			this.EnsureEnviromentsCacheIfNeeded();
			return this.EnviromentsCache;
		}

		// Token: 0x04005483 RID: 21635
		private Table __p;

		// Token: 0x04005484 RID: 21636
		[Nullable(2)]
		private FrozenDictionary<int, int> EnviromentsCache;
	}
}
