using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001101 RID: 4353
	public struct RogueResTeamLvRule : IFlatbufferObject
	{
		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600CA96 RID: 51862 RVA: 0x0030C890 File Offset: 0x0030AA90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x0030C89D File Offset: 0x0030AA9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x0030C8A4 File Offset: 0x0030AAA4
		public static RogueResTeamLvRule GetRootAsRogueResTeamLvRule(ByteBuffer _bb)
		{
			return RogueResTeamLvRule.GetRootAsRogueResTeamLvRule(_bb, default(RogueResTeamLvRule));
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x0030C8C0 File Offset: 0x0030AAC0
		public static RogueResTeamLvRule GetRootAsRogueResTeamLvRule(ByteBuffer _bb, RogueResTeamLvRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x0030C8DD File Offset: 0x0030AADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x0030C8EC File Offset: 0x0030AAEC
		public RogueResTeamLvRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x0030C8FC File Offset: 0x0030AAFC
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

		// Token: 0x0600CA9D RID: 51869 RVA: 0x0030C938 File Offset: 0x0030AB38
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x0030C978 File Offset: 0x0030AB78
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

		// Token: 0x0600CA9F RID: 51871 RVA: 0x0030C9A3 File Offset: 0x0030ABA3
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x0030C9B2 File Offset: 0x0030ABB2
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x0030C9CC File Offset: 0x0030ABCC
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

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x0030CA08 File Offset: 0x0030AC08
		public int RangeEffects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600CAA3 RID: 51875 RVA: 0x0030CA48 File Offset: 0x0030AC48
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

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x0030CA74 File Offset: 0x0030AC74
		public Span<int> GetRangeEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CAA5 RID: 51877 RVA: 0x0030CA84 File Offset: 0x0030AC84
		public int[] GetRangeEffectsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600CAA6 RID: 51878 RVA: 0x0030CA9C File Offset: 0x0030AC9C
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

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x0030CADC File Offset: 0x0030ACDC
		public int TargetEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600CAA8 RID: 51880 RVA: 0x0030CB1C File Offset: 0x0030AD1C
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

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x0030CB48 File Offset: 0x0030AD48
		public Span<int> GetTargetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x0030CB58 File Offset: 0x0030AD58
		public int[] GetTargetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x0030CB70 File Offset: 0x0030AD70
		[NullableContext(1)]
		public int[] LevelRange()
		{
			return this.GetLevelRangeArray();
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x0030CB78 File Offset: 0x0030AD78
		[NullableContext(1)]
		public IEnumerable<int> LevelRangeIter()
		{
			RogueResTeamLvRule.<LevelRangeIter>d__30 <LevelRangeIter>d__ = new RogueResTeamLvRule.<LevelRangeIter>d__30(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x0030CB8D File Offset: 0x0030AD8D
		[NullableContext(1)]
		public int[] RangeEffects()
		{
			return this.GetRangeEffectsArray();
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x0030CB95 File Offset: 0x0030AD95
		[NullableContext(1)]
		public IEnumerable<int> RangeEffectsIter()
		{
			RogueResTeamLvRule.<RangeEffectsIter>d__32 <RangeEffectsIter>d__ = new RogueResTeamLvRule.<RangeEffectsIter>d__32(-2);
			<RangeEffectsIter>d__.<>3__<>4__this = this;
			return <RangeEffectsIter>d__;
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x0030CBAA File Offset: 0x0030ADAA
		[NullableContext(1)]
		public int[] TargetEffects()
		{
			return this.GetTargetEffectsArray();
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x0030CBB2 File Offset: 0x0030ADB2
		[NullableContext(1)]
		public IEnumerable<int> TargetEffectsIter()
		{
			RogueResTeamLvRule.<TargetEffectsIter>d__34 <TargetEffectsIter>d__ = new RogueResTeamLvRule.<TargetEffectsIter>d__34(-2);
			<TargetEffectsIter>d__.<>3__<>4__this = this;
			return <TargetEffectsIter>d__;
		}

		// Token: 0x040056F0 RID: 22256
		private Table __p;
	}
}
