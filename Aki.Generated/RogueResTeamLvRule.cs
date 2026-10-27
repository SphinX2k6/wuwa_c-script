using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001019 RID: 4121
	public struct RogueResTeamLvRule : IFlatbufferObject
	{
		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600C44C RID: 50252 RVA: 0x002F0810 File Offset: 0x002EEA10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x002F081D File Offset: 0x002EEA1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x002F0824 File Offset: 0x002EEA24
		public static RogueResTeamLvRule GetRootAsRogueResTeamLvRule(ByteBuffer _bb)
		{
			return RogueResTeamLvRule.GetRootAsRogueResTeamLvRule(_bb, default(RogueResTeamLvRule));
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x002F0840 File Offset: 0x002EEA40
		public static RogueResTeamLvRule GetRootAsRogueResTeamLvRule(ByteBuffer _bb, RogueResTeamLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x002F085D File Offset: 0x002EEA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x002F086C File Offset: 0x002EEA6C
		public RogueResTeamLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600C452 RID: 50258 RVA: 0x002F087C File Offset: 0x002EEA7C
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

		// Token: 0x0600C453 RID: 50259 RVA: 0x002F08B8 File Offset: 0x002EEAB8
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600C454 RID: 50260 RVA: 0x002F08F8 File Offset: 0x002EEAF8
		public int LevelRangeLength
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

		// Token: 0x0600C455 RID: 50261 RVA: 0x002F0923 File Offset: 0x002EEB23
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C456 RID: 50262 RVA: 0x002F0932 File Offset: 0x002EEB32
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600C457 RID: 50263 RVA: 0x002F094C File Offset: 0x002EEB4C
		public int RoleLevel
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

		// Token: 0x0600C458 RID: 50264 RVA: 0x002F0988 File Offset: 0x002EEB88
		public int RangeEffects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x002F09C8 File Offset: 0x002EEBC8
		public int RangeEffectsLength
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

		// Token: 0x0600C45A RID: 50266 RVA: 0x002F09F4 File Offset: 0x002EEBF4
		public Span<int> GetRangeEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x002F0A04 File Offset: 0x002EEC04
		public int[] GetRangeEffectsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600C45C RID: 50268 RVA: 0x002F0A1C File Offset: 0x002EEC1C
		public int TargetLevel
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

		// Token: 0x0600C45D RID: 50269 RVA: 0x002F0A5C File Offset: 0x002EEC5C
		public int TargetEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600C45E RID: 50270 RVA: 0x002F0A9C File Offset: 0x002EEC9C
		public int TargetEffectsLength
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

		// Token: 0x0600C45F RID: 50271 RVA: 0x002F0AC8 File Offset: 0x002EECC8
		public Span<int> GetTargetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x002F0AD8 File Offset: 0x002EECD8
		public int[] GetTargetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x002F0AF0 File Offset: 0x002EECF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelRangeIter()或GetLevelRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelRange()
		{
			RogueResTeamLvRule rogueResTeamLvRule = this;
			return rogueResTeamLvRule.GetLevelRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x002F0B14 File Offset: 0x002EED14
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelRangeIter()
		{
			RogueResTeamLvRule.<LevelRangeIter>d__30 <LevelRangeIter>d__ = new RogueResTeamLvRule.<LevelRangeIter>d__30(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x002F0B2C File Offset: 0x002EED2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RangeEffectsIter()或GetRangeEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RangeEffects()
		{
			RogueResTeamLvRule rogueResTeamLvRule = this;
			return rogueResTeamLvRule.GetRangeEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x002F0B50 File Offset: 0x002EED50
		[NullableContext(1)]
		public readonly IEnumerable<int> RangeEffectsIter()
		{
			RogueResTeamLvRule.<RangeEffectsIter>d__32 <RangeEffectsIter>d__ = new RogueResTeamLvRule.<RangeEffectsIter>d__32(-2);
			<RangeEffectsIter>d__.<>3__<>4__this = this;
			return <RangeEffectsIter>d__;
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x002F0B68 File Offset: 0x002EED68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetEffectsIter()或GetTargetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetEffects()
		{
			RogueResTeamLvRule rogueResTeamLvRule = this;
			return rogueResTeamLvRule.GetTargetEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x002F0B8C File Offset: 0x002EED8C
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetEffectsIter()
		{
			RogueResTeamLvRule.<TargetEffectsIter>d__34 <TargetEffectsIter>d__ = new RogueResTeamLvRule.<TargetEffectsIter>d__34(-2);
			<TargetEffectsIter>d__.<>3__<>4__this = this;
			return <TargetEffectsIter>d__;
		}

		// Token: 0x04005108 RID: 20744
		private Table __p;
	}
}
