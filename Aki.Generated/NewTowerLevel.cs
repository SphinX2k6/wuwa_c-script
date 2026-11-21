using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F71 RID: 3953
	public struct NewTowerLevel : IFlatbufferObject
	{
		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600A551 RID: 42321 RVA: 0x002BB24A File Offset: 0x002B944A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x002BB257 File Offset: 0x002B9457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A553 RID: 42323 RVA: 0x002BB260 File Offset: 0x002B9460
		public static NewTowerLevel GetRootAsNewTowerLevel(ByteBuffer _bb)
		{
			return NewTowerLevel.GetRootAsNewTowerLevel(_bb, default(NewTowerLevel));
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x002BB27C File Offset: 0x002B947C
		public static NewTowerLevel GetRootAsNewTowerLevel(ByteBuffer _bb, NewTowerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x002BB299 File Offset: 0x002B9499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x002BB2A8 File Offset: 0x002B94A8
		public NewTowerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x002BB2B8 File Offset: 0x002B94B8
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

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x002BB2F4 File Offset: 0x002B94F4
		public int Param
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

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x002BB330 File Offset: 0x002B9530
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

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x0600A55A RID: 42330 RVA: 0x002BB36C File Offset: 0x002B956C
		public int Cond
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

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x0600A55B RID: 42331 RVA: 0x002BB3AC File Offset: 0x002B95AC
		public int MaxLoopCount
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

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x002BB3EC File Offset: 0x002B95EC
		public int TeamLimit
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

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x002BB42C File Offset: 0x002B962C
		public int Diff
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

		// Token: 0x0600A55E RID: 42334 RVA: 0x002BB46C File Offset: 0x002B966C
		public int NewTowerBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x002BB4AC File Offset: 0x002B96AC
		public int NewTowerBuffsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A560 RID: 42336 RVA: 0x002BB4D8 File Offset: 0x002B96D8
		public Span<int> GetNewTowerBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x002BB4E8 File Offset: 0x002B96E8
		public int[] GetNewTowerBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x002BB500 File Offset: 0x002B9700
		public int NewTowerBuffCount
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x002BB540 File Offset: 0x002B9740
		public DicIntInt? ScoreLevelRule(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x002BB5A4 File Offset: 0x002B97A4
		public int ScoreLevelRuleLength
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

		// Token: 0x0600A565 RID: 42341 RVA: 0x002BB5D0 File Offset: 0x002B97D0
		[NullableContext(1)]
		public int[] NewTowerBuffs()
		{
			return this.GetNewTowerBuffsArray();
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x002BB5D8 File Offset: 0x002B97D8
		[NullableContext(1)]
		public IEnumerable<int> NewTowerBuffsIter()
		{
			NewTowerLevel.<NewTowerBuffsIter>d__33 <NewTowerBuffsIter>d__ = new NewTowerLevel.<NewTowerBuffsIter>d__33(-2);
			<NewTowerBuffsIter>d__.<>3__<>4__this = this;
			return <NewTowerBuffsIter>d__;
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x002BB5F0 File Offset: 0x002B97F0
		[NullableContext(1)]
		public Dictionary<int, int> ScoreLevelRule()
		{
			return this.ScoreLevelRuleIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x002BB646 File Offset: 0x002B9846
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ScoreLevelRuleIter()
		{
			NewTowerLevel.<ScoreLevelRuleIter>d__35 <ScoreLevelRuleIter>d__ = new NewTowerLevel.<ScoreLevelRuleIter>d__35(-2);
			<ScoreLevelRuleIter>d__.<>3__<>4__this = this;
			return <ScoreLevelRuleIter>d__;
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x002BB65C File Offset: 0x002B985C
		public int? GetScoreLevelRule(int key)
		{
			this.EnsureScoreLevelRuleCacheIfNeeded();
			int value;
			if (!this.ScoreLevelRuleCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x002BB690 File Offset: 0x002B9890
		private void EnsureScoreLevelRuleCacheIfNeeded()
		{
			if (this.ScoreLevelRuleCache != null)
			{
				return;
			}
			this.ScoreLevelRuleCache = this.ScoreLevelRuleIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x002BB6F6 File Offset: 0x002B98F6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetScoreLevelRuleFrozenDict()
		{
			this.EnsureScoreLevelRuleCacheIfNeeded();
			return this.ScoreLevelRuleCache;
		}

		// Token: 0x0400551F RID: 21791
		private Table __p;

		// Token: 0x04005520 RID: 21792
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreLevelRuleCache;
	}
}
