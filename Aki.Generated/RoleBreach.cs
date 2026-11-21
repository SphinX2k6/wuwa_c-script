using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001125 RID: 4389
	public struct RoleBreach : IFlatbufferObject
	{
		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600CDC3 RID: 52675 RVA: 0x00313E55 File Offset: 0x00312055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x00313E62 File Offset: 0x00312062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x00313E6C File Offset: 0x0031206C
		public static RoleBreach GetRootAsRoleBreach(ByteBuffer _bb)
		{
			return RoleBreach.GetRootAsRoleBreach(_bb, default(RoleBreach));
		}

		// Token: 0x0600CDC6 RID: 52678 RVA: 0x00313E88 File Offset: 0x00312088
		public static RoleBreach GetRootAsRoleBreach(ByteBuffer _bb, RoleBreach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDC7 RID: 52679 RVA: 0x00313EA5 File Offset: 0x003120A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDC8 RID: 52680 RVA: 0x00313EB4 File Offset: 0x003120B4
		public RoleBreach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600CDC9 RID: 52681 RVA: 0x00313EC4 File Offset: 0x003120C4
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

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x00313F00 File Offset: 0x00312100
		public int BreachGroupId
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

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600CDCB RID: 52683 RVA: 0x00313F3C File Offset: 0x0031213C
		public int BreachLevel
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

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x00313F78 File Offset: 0x00312178
		public int MaxLevel
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

		// Token: 0x0600CDCD RID: 52685 RVA: 0x00313FB8 File Offset: 0x003121B8
		public DicIntInt? BreachConsume(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x0031401C File Offset: 0x0031221C
		public int BreachConsumeLength
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

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600CDCF RID: 52687 RVA: 0x00314048 File Offset: 0x00312248
		public int BreachReward
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

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x00314088 File Offset: 0x00312288
		public int ConditionId
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

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x003140C8 File Offset: 0x003122C8
		[NullableContext(1)]
		public Dictionary<int, int> BreachConsume()
		{
			return this.BreachConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x0031411E File Offset: 0x0031231E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BreachConsumeIter()
		{
			RoleBreach.<BreachConsumeIter>d__24 <BreachConsumeIter>d__ = new RoleBreach.<BreachConsumeIter>d__24(-2);
			<BreachConsumeIter>d__.<>3__<>4__this = this;
			return <BreachConsumeIter>d__;
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x00314134 File Offset: 0x00312334
		public int? GetBreachConsume(int key)
		{
			this.EnsureBreachConsumeCacheIfNeeded();
			int value;
			if (!this.BreachConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x00314168 File Offset: 0x00312368
		private void EnsureBreachConsumeCacheIfNeeded()
		{
			if (this.BreachConsumeCache != null)
			{
				return;
			}
			this.BreachConsumeCache = this.BreachConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CDD5 RID: 52693 RVA: 0x003141CE File Offset: 0x003123CE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBreachConsumeFrozenDict()
		{
			this.EnsureBreachConsumeCacheIfNeeded();
			return this.BreachConsumeCache;
		}

		// Token: 0x04005722 RID: 22306
		private Table __p;

		// Token: 0x04005723 RID: 22307
		[Nullable(2)]
		private FrozenDictionary<int, int> BreachConsumeCache;
	}
}
