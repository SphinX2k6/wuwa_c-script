using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FA RID: 4346
	public struct RogueResSkillLvRule : IFlatbufferObject
	{
		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600CA2B RID: 51755 RVA: 0x0030BA95 File Offset: 0x00309C95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x0030BAA2 File Offset: 0x00309CA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x0030BAAC File Offset: 0x00309CAC
		public static RogueResSkillLvRule GetRootAsRogueResSkillLvRule(ByteBuffer _bb)
		{
			return RogueResSkillLvRule.GetRootAsRogueResSkillLvRule(_bb, default(RogueResSkillLvRule));
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x0030BAC8 File Offset: 0x00309CC8
		public static RogueResSkillLvRule GetRootAsRogueResSkillLvRule(ByteBuffer _bb, RogueResSkillLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x0030BAE5 File Offset: 0x00309CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x0030BAF4 File Offset: 0x00309CF4
		public RogueResSkillLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600CA31 RID: 51761 RVA: 0x0030BB04 File Offset: 0x00309D04
		public int Level
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

		// Token: 0x0600CA32 RID: 51762 RVA: 0x0030BB40 File Offset: 0x00309D40
		public DicIntInt? SkillLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600CA33 RID: 51763 RVA: 0x0030BBA0 File Offset: 0x00309DA0
		public int SkillLevelLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x0030BBCC File Offset: 0x00309DCC
		[NullableContext(1)]
		public Dictionary<int, int> SkillLevel()
		{
			return this.SkillLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x0030BC22 File Offset: 0x00309E22
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillLevelIter()
		{
			RogueResSkillLvRule.<SkillLevelIter>d__14 <SkillLevelIter>d__ = new RogueResSkillLvRule.<SkillLevelIter>d__14(-2);
			<SkillLevelIter>d__.<>3__<>4__this = this;
			return <SkillLevelIter>d__;
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x0030BC38 File Offset: 0x00309E38
		public int? GetSkillLevel(int key)
		{
			this.EnsureSkillLevelCacheIfNeeded();
			int value;
			if (!this.SkillLevelCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x0030BC6C File Offset: 0x00309E6C
		private void EnsureSkillLevelCacheIfNeeded()
		{
			if (this.SkillLevelCache != null)
			{
				return;
			}
			this.SkillLevelCache = this.SkillLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x0030BCD2 File Offset: 0x00309ED2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillLevelFrozenDict()
		{
			this.EnsureSkillLevelCacheIfNeeded();
			return this.SkillLevelCache;
		}

		// Token: 0x040056E7 RID: 22247
		private Table __p;

		// Token: 0x040056E8 RID: 22248
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillLevelCache;
	}
}
