using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001012 RID: 4114
	public struct RogueResSkillLvRule : IFlatbufferObject
	{
		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600C3E1 RID: 50145 RVA: 0x002EF9B9 File Offset: 0x002EDBB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x002EF9C6 File Offset: 0x002EDBC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x002EF9D0 File Offset: 0x002EDBD0
		public static RogueResSkillLvRule GetRootAsRogueResSkillLvRule(ByteBuffer _bb)
		{
			return RogueResSkillLvRule.GetRootAsRogueResSkillLvRule(_bb, default(RogueResSkillLvRule));
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x002EF9EC File Offset: 0x002EDBEC
		public static RogueResSkillLvRule GetRootAsRogueResSkillLvRule(ByteBuffer _bb, RogueResSkillLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x002EFA09 File Offset: 0x002EDC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3E6 RID: 50150 RVA: 0x002EFA18 File Offset: 0x002EDC18
		public RogueResSkillLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x002EFA28 File Offset: 0x002EDC28
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

		// Token: 0x0600C3E8 RID: 50152 RVA: 0x002EFA64 File Offset: 0x002EDC64
		public DicIntInt? SkillLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600C3E9 RID: 50153 RVA: 0x002EFAC4 File Offset: 0x002EDCC4
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

		// Token: 0x0600C3EA RID: 50154 RVA: 0x002EFAF0 File Offset: 0x002EDCF0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillLevelFrozenDict()缓存字典，遍历请使用SkillLevelIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillLevel()
		{
			return this.SkillLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C3EB RID: 50155 RVA: 0x002EFB46 File Offset: 0x002EDD46
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillLevelIter()
		{
			RogueResSkillLvRule.<SkillLevelIter>d__14 <SkillLevelIter>d__ = new RogueResSkillLvRule.<SkillLevelIter>d__14(-2);
			<SkillLevelIter>d__.<>3__<>4__this = this;
			return <SkillLevelIter>d__;
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x002EFB5C File Offset: 0x002EDD5C
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

		// Token: 0x0600C3ED RID: 50157 RVA: 0x002EFB90 File Offset: 0x002EDD90
		private void EnsureSkillLevelCacheIfNeeded()
		{
			if (this.SkillLevelCache != null)
			{
				return;
			}
			this.SkillLevelCache = this.SkillLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C3EE RID: 50158 RVA: 0x002EFBF6 File Offset: 0x002EDDF6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillLevelFrozenDict(int key)
		{
			this.EnsureSkillLevelCacheIfNeeded();
			return this.SkillLevelCache;
		}

		// Token: 0x040050FF RID: 20735
		private Table __p;

		// Token: 0x04005100 RID: 20736
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillLevelCache;
	}
}
