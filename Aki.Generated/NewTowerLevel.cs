using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8C RID: 3724
	public struct NewTowerLevel : IFlatbufferObject
	{
		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06009F31 RID: 40753 RVA: 0x0029DC6E File Offset: 0x0029BE6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x0029DC7B File Offset: 0x0029BE7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x0029DC84 File Offset: 0x0029BE84
		public static NewTowerLevel GetRootAsNewTowerLevel(ByteBuffer _bb)
		{
			return NewTowerLevel.GetRootAsNewTowerLevel(_bb, default(NewTowerLevel));
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x0029DCA0 File Offset: 0x0029BEA0
		public static NewTowerLevel GetRootAsNewTowerLevel(ByteBuffer _bb, NewTowerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x0029DCBD File Offset: 0x0029BEBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x0029DCCC File Offset: 0x0029BECC
		public NewTowerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06009F37 RID: 40759 RVA: 0x0029DCDC File Offset: 0x0029BEDC
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

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06009F38 RID: 40760 RVA: 0x0029DD18 File Offset: 0x0029BF18
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

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x0029DD54 File Offset: 0x0029BF54
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

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x0029DD90 File Offset: 0x0029BF90
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

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x0029DDD0 File Offset: 0x0029BFD0
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

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x0029DE10 File Offset: 0x0029C010
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

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x0029DE50 File Offset: 0x0029C050
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

		// Token: 0x06009F3E RID: 40766 RVA: 0x0029DE90 File Offset: 0x0029C090
		public int NewTowerBuffs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x0029DED0 File Offset: 0x0029C0D0
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

		// Token: 0x06009F40 RID: 40768 RVA: 0x0029DEFC File Offset: 0x0029C0FC
		public Span<int> GetNewTowerBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x0029DF0C File Offset: 0x0029C10C
		public int[] GetNewTowerBuffsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06009F42 RID: 40770 RVA: 0x0029DF24 File Offset: 0x0029C124
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

		// Token: 0x06009F43 RID: 40771 RVA: 0x0029DF64 File Offset: 0x0029C164
		public DicIntInt? ScoreLevelRule(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06009F44 RID: 40772 RVA: 0x0029DFC8 File Offset: 0x0029C1C8
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

		// Token: 0x06009F45 RID: 40773 RVA: 0x0029DFF4 File Offset: 0x0029C1F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NewTowerBuffsIter()或GetNewTowerBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NewTowerBuffs()
		{
			NewTowerLevel newTowerLevel = this;
			return newTowerLevel.GetNewTowerBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x0029E018 File Offset: 0x0029C218
		[NullableContext(1)]
		public readonly IEnumerable<int> NewTowerBuffsIter()
		{
			NewTowerLevel.<NewTowerBuffsIter>d__33 <NewTowerBuffsIter>d__ = new NewTowerLevel.<NewTowerBuffsIter>d__33(-2);
			<NewTowerBuffsIter>d__.<>3__<>4__this = this;
			return <NewTowerBuffsIter>d__;
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x0029E030 File Offset: 0x0029C230
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ScoreLevelRuleFrozenDict()缓存字典，遍历请使用ScoreLevelRuleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ScoreLevelRule()
		{
			return this.ScoreLevelRuleIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x0029E086 File Offset: 0x0029C286
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ScoreLevelRuleIter()
		{
			NewTowerLevel.<ScoreLevelRuleIter>d__35 <ScoreLevelRuleIter>d__ = new NewTowerLevel.<ScoreLevelRuleIter>d__35(-2);
			<ScoreLevelRuleIter>d__.<>3__<>4__this = this;
			return <ScoreLevelRuleIter>d__;
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x0029E09C File Offset: 0x0029C29C
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

		// Token: 0x06009F4A RID: 40778 RVA: 0x0029E0D0 File Offset: 0x0029C2D0
		private void EnsureScoreLevelRuleCacheIfNeeded()
		{
			if (this.ScoreLevelRuleCache != null)
			{
				return;
			}
			this.ScoreLevelRuleCache = this.ScoreLevelRuleIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x0029E136 File Offset: 0x0029C336
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScoreLevelRuleFrozenDict(int key)
		{
			this.EnsureScoreLevelRuleCacheIfNeeded();
			return this.ScoreLevelRuleCache;
		}

		// Token: 0x04004F3A RID: 20282
		private Table __p;

		// Token: 0x04004F3B RID: 20283
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreLevelRuleCache;
	}
}
