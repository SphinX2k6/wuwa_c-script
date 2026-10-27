using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFE RID: 3582
	public struct MatchThreeGameplay : IFlatbufferObject
	{
		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x060092B0 RID: 37552 RVA: 0x00282265 File Offset: 0x00280465
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00282272 File Offset: 0x00280472
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x0028227C File Offset: 0x0028047C
		public static MatchThreeGameplay GetRootAsMatchThreeGameplay(ByteBuffer _bb)
		{
			return MatchThreeGameplay.GetRootAsMatchThreeGameplay(_bb, default(MatchThreeGameplay));
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00282298 File Offset: 0x00280498
		public static MatchThreeGameplay GetRootAsMatchThreeGameplay(ByteBuffer _bb, MatchThreeGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x002822B5 File Offset: 0x002804B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x002822C4 File Offset: 0x002804C4
		public MatchThreeGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x060092B6 RID: 37558 RVA: 0x002822D4 File Offset: 0x002804D4
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

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x060092B7 RID: 37559 RVA: 0x00282310 File Offset: 0x00280510
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

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x060092B8 RID: 37560 RVA: 0x0028234C File Offset: 0x0028054C
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

		// Token: 0x060092B9 RID: 37561 RVA: 0x00282388 File Offset: 0x00280588
		public int Goal(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x060092BA RID: 37562 RVA: 0x002823C8 File Offset: 0x002805C8
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

		// Token: 0x060092BB RID: 37563 RVA: 0x002823F4 File Offset: 0x002805F4
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x00282404 File Offset: 0x00280604
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x0028241C File Offset: 0x0028061C
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

		// Token: 0x060092BE RID: 37566 RVA: 0x00282454 File Offset: 0x00280654
		public Span<byte> GetEnvironmentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00282464 File Offset: 0x00280664
		public byte[] GetEnvironmentDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x0028247C File Offset: 0x0028067C
		public DicIntInt? Enviroments(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x060092C1 RID: 37569 RVA: 0x002824E0 File Offset: 0x002806E0
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

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060092C2 RID: 37570 RVA: 0x0028250C File Offset: 0x0028070C
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

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060092C3 RID: 37571 RVA: 0x0028254C File Offset: 0x0028074C
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x00282590 File Offset: 0x00280790
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

		// Token: 0x060092C5 RID: 37573 RVA: 0x002825D4 File Offset: 0x002807D4
		public int FillRules(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x00282614 File Offset: 0x00280814
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

		// Token: 0x060092C7 RID: 37575 RVA: 0x00282640 File Offset: 0x00280840
		public Span<int> GetFillRulesBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x00282650 File Offset: 0x00280850
		public int[] GetFillRulesArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x00282668 File Offset: 0x00280868
		public int SpecialTiles(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060092CA RID: 37578 RVA: 0x002826A8 File Offset: 0x002808A8
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

		// Token: 0x060092CB RID: 37579 RVA: 0x002826D4 File Offset: 0x002808D4
		public Span<int> GetSpecialTilesBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x002826E4 File Offset: 0x002808E4
		public int[] GetSpecialTilesArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x002826FC File Offset: 0x002808FC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EnviromentsFrozenDict()缓存字典，遍历请使用EnviromentsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Enviroments()
		{
			return this.EnviromentsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x00282752 File Offset: 0x00280952
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EnviromentsIter()
		{
			MatchThreeGameplay.<EnviromentsIter>d__43 <EnviromentsIter>d__ = new MatchThreeGameplay.<EnviromentsIter>d__43(-2);
			<EnviromentsIter>d__.<>3__<>4__this = this;
			return <EnviromentsIter>d__;
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00282768 File Offset: 0x00280968
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FillRulesIter()或GetFillRulesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FillRules()
		{
			MatchThreeGameplay matchThreeGameplay = this;
			return matchThreeGameplay.GetFillRulesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x0028278C File Offset: 0x0028098C
		[NullableContext(1)]
		public readonly IEnumerable<int> FillRulesIter()
		{
			MatchThreeGameplay.<FillRulesIter>d__45 <FillRulesIter>d__ = new MatchThreeGameplay.<FillRulesIter>d__45(-2);
			<FillRulesIter>d__.<>3__<>4__this = this;
			return <FillRulesIter>d__;
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x002827A4 File Offset: 0x002809A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GoalIter()或GetGoalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Goal()
		{
			MatchThreeGameplay matchThreeGameplay = this;
			return matchThreeGameplay.GetGoalArray() ?? Array.Empty<int>();
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x002827C8 File Offset: 0x002809C8
		[NullableContext(1)]
		public readonly IEnumerable<int> GoalIter()
		{
			MatchThreeGameplay.<GoalIter>d__47 <GoalIter>d__ = new MatchThreeGameplay.<GoalIter>d__47(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x002827E0 File Offset: 0x002809E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpecialTilesIter()或GetSpecialTilesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpecialTiles()
		{
			MatchThreeGameplay matchThreeGameplay = this;
			return matchThreeGameplay.GetSpecialTilesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x00282804 File Offset: 0x00280A04
		[NullableContext(1)]
		public readonly IEnumerable<int> SpecialTilesIter()
		{
			MatchThreeGameplay.<SpecialTilesIter>d__49 <SpecialTilesIter>d__ = new MatchThreeGameplay.<SpecialTilesIter>d__49(-2);
			<SpecialTilesIter>d__.<>3__<>4__this = this;
			return <SpecialTilesIter>d__;
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x0028281C File Offset: 0x00280A1C
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

		// Token: 0x060092D6 RID: 37590 RVA: 0x00282850 File Offset: 0x00280A50
		private void EnsureEnviromentsCacheIfNeeded()
		{
			if (this.EnviromentsCache != null)
			{
				return;
			}
			this.EnviromentsCache = this.EnviromentsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x002828B6 File Offset: 0x00280AB6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEnviromentsFrozenDict(int key)
		{
			this.EnsureEnviromentsCacheIfNeeded();
			return this.EnviromentsCache;
		}

		// Token: 0x04004E9E RID: 20126
		private Table __p;

		// Token: 0x04004E9F RID: 20127
		[Nullable(2)]
		private FrozenDictionary<int, int> EnviromentsCache;
	}
}
