using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001022 RID: 4130
	public struct RogueSkillLvRule : IFlatbufferObject
	{
		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600C513 RID: 50451 RVA: 0x002F24B0 File Offset: 0x002F06B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x002F24BD File Offset: 0x002F06BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x002F24C4 File Offset: 0x002F06C4
		public static RogueSkillLvRule GetRootAsRogueSkillLvRule(ByteBuffer _bb)
		{
			return RogueSkillLvRule.GetRootAsRogueSkillLvRule(_bb, default(RogueSkillLvRule));
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x002F24E0 File Offset: 0x002F06E0
		public static RogueSkillLvRule GetRootAsRogueSkillLvRule(ByteBuffer _bb, RogueSkillLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x002F24FD File Offset: 0x002F06FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x002F250C File Offset: 0x002F070C
		public RogueSkillLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600C519 RID: 50457 RVA: 0x002F251C File Offset: 0x002F071C
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

		// Token: 0x0600C51A RID: 50458 RVA: 0x002F2558 File Offset: 0x002F0758
		public DicIntInt? SkillLevel(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600C51B RID: 50459 RVA: 0x002F25B8 File Offset: 0x002F07B8
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

		// Token: 0x0600C51C RID: 50460 RVA: 0x002F25E4 File Offset: 0x002F07E4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillLevelFrozenDict()缓存字典，遍历请使用SkillLevelIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillLevel()
		{
			return this.SkillLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C51D RID: 50461 RVA: 0x002F263A File Offset: 0x002F083A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillLevelIter()
		{
			RogueSkillLvRule.<SkillLevelIter>d__14 <SkillLevelIter>d__ = new RogueSkillLvRule.<SkillLevelIter>d__14(-2);
			<SkillLevelIter>d__.<>3__<>4__this = this;
			return <SkillLevelIter>d__;
		}

		// Token: 0x0600C51E RID: 50462 RVA: 0x002F2650 File Offset: 0x002F0850
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

		// Token: 0x0600C51F RID: 50463 RVA: 0x002F2684 File Offset: 0x002F0884
		private void EnsureSkillLevelCacheIfNeeded()
		{
			if (this.SkillLevelCache != null)
			{
				return;
			}
			this.SkillLevelCache = this.SkillLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C520 RID: 50464 RVA: 0x002F26EA File Offset: 0x002F08EA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillLevelFrozenDict(int key)
		{
			this.EnsureSkillLevelCacheIfNeeded();
			return this.SkillLevelCache;
		}

		// Token: 0x04005114 RID: 20756
		private Table __p;

		// Token: 0x04005115 RID: 20757
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillLevelCache;
	}
}
