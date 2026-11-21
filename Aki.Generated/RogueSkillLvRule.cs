using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110A RID: 4362
	public struct RogueSkillLvRule : IFlatbufferObject
	{
		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600CB5D RID: 52061 RVA: 0x0030E4B8 File Offset: 0x0030C6B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x0030E4C5 File Offset: 0x0030C6C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB5F RID: 52063 RVA: 0x0030E4CC File Offset: 0x0030C6CC
		public static RogueSkillLvRule GetRootAsRogueSkillLvRule(ByteBuffer _bb)
		{
			return RogueSkillLvRule.GetRootAsRogueSkillLvRule(_bb, default(RogueSkillLvRule));
		}

		// Token: 0x0600CB60 RID: 52064 RVA: 0x0030E4E8 File Offset: 0x0030C6E8
		public static RogueSkillLvRule GetRootAsRogueSkillLvRule(ByteBuffer _bb, RogueSkillLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB61 RID: 52065 RVA: 0x0030E505 File Offset: 0x0030C705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB62 RID: 52066 RVA: 0x0030E514 File Offset: 0x0030C714
		public RogueSkillLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x0030E524 File Offset: 0x0030C724
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

		// Token: 0x0600CB64 RID: 52068 RVA: 0x0030E560 File Offset: 0x0030C760
		public DicIntInt? SkillLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x0030E5C0 File Offset: 0x0030C7C0
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

		// Token: 0x0600CB66 RID: 52070 RVA: 0x0030E5EC File Offset: 0x0030C7EC
		[NullableContext(1)]
		public Dictionary<int, int> SkillLevel()
		{
			return this.SkillLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x0030E642 File Offset: 0x0030C842
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillLevelIter()
		{
			RogueSkillLvRule.<SkillLevelIter>d__14 <SkillLevelIter>d__ = new RogueSkillLvRule.<SkillLevelIter>d__14(-2);
			<SkillLevelIter>d__.<>3__<>4__this = this;
			return <SkillLevelIter>d__;
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x0030E658 File Offset: 0x0030C858
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

		// Token: 0x0600CB69 RID: 52073 RVA: 0x0030E68C File Offset: 0x0030C88C
		private void EnsureSkillLevelCacheIfNeeded()
		{
			if (this.SkillLevelCache != null)
			{
				return;
			}
			this.SkillLevelCache = this.SkillLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x0030E6F2 File Offset: 0x0030C8F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillLevelFrozenDict()
		{
			this.EnsureSkillLevelCacheIfNeeded();
			return this.SkillLevelCache;
		}

		// Token: 0x040056FC RID: 22268
		private Table __p;

		// Token: 0x040056FD RID: 22269
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillLevelCache;
	}
}
