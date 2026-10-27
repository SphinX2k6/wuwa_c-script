using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1A RID: 3354
	public struct GuideGroup : IFlatbufferObject
	{
		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x002509FC File Offset: 0x0024EBFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x00250A09 File Offset: 0x0024EC09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x00250A10 File Offset: 0x0024EC10
		public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb)
		{
			return GuideGroup.GetRootAsGuideGroup(_bb, default(GuideGroup));
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x00250A2C File Offset: 0x0024EC2C
		public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb, GuideGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x00250A49 File Offset: 0x0024EC49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x00250A58 File Offset: 0x0024EC58
		public GuideGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06007CF6 RID: 31990 RVA: 0x00250A68 File Offset: 0x0024EC68
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

		// Token: 0x06007CF7 RID: 31991 RVA: 0x00250AA4 File Offset: 0x0024ECA4
		public int Step(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x00250AE4 File Offset: 0x0024ECE4
		public int StepLength
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

		// Token: 0x06007CF9 RID: 31993 RVA: 0x00250B0F File Offset: 0x0024ED0F
		public Span<int> GetStepBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x00250B1E File Offset: 0x0024ED1E
		public int[] GetStepArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x00250B38 File Offset: 0x0024ED38
		public int MultiPlatformStep(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06007CFC RID: 31996 RVA: 0x00250B78 File Offset: 0x0024ED78
		public int MultiPlatformStepLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x00250BA3 File Offset: 0x0024EDA3
		public Span<int> GetMultiPlatformStepBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x00250BB2 File Offset: 0x0024EDB2
		public int[] GetMultiPlatformStepArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06007CFF RID: 31999 RVA: 0x00250BCC File Offset: 0x0024EDCC
		public int OpenLimitCondition
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

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06007D00 RID: 32000 RVA: 0x00250C0C File Offset: 0x0024EE0C
		public int AutoOpenCondition
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

		// Token: 0x06007D01 RID: 32001 RVA: 0x00250C4C File Offset: 0x0024EE4C
		public int LimitRepeat(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06007D02 RID: 32002 RVA: 0x00250C8C File Offset: 0x0024EE8C
		public int LimitRepeatLength
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

		// Token: 0x06007D03 RID: 32003 RVA: 0x00250CB8 File Offset: 0x0024EEB8
		public Span<int> GetLimitRepeatBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x00250CC8 File Offset: 0x0024EEC8
		public int[] GetLimitRepeatArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x00250CE0 File Offset: 0x0024EEE0
		public int DungeonId(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06007D06 RID: 32006 RVA: 0x00250D20 File Offset: 0x0024EF20
		public int DungeonIdLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x00250D4C File Offset: 0x0024EF4C
		public Span<int> GetDungeonIdBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x00250D5C File Offset: 0x0024EF5C
		public int[] GetDungeonIdArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x00250D74 File Offset: 0x0024EF74
		public string DungeonSets(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06007D0A RID: 32010 RVA: 0x00250DB0 File Offset: 0x0024EFB0
		public int DungeonSetsLength
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

		// Token: 0x06007D0B RID: 32011 RVA: 0x00250DDC File Offset: 0x0024EFDC
		public IntPair? DungeonTypes(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06007D0C RID: 32012 RVA: 0x00250E40 File Offset: 0x0024F040
		public int DungeonTypesLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x00250E6C File Offset: 0x0024F06C
		public bool ResetInDungeon
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06007D0E RID: 32014 RVA: 0x00250EAC File Offset: 0x0024F0AC
		public int OnlineMode
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x00250EEC File Offset: 0x0024F0EC
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x00250F2C File Offset: 0x0024F12C
		public int PriorityBreakExclude(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x00250F6C File Offset: 0x0024F16C
		public int PriorityBreakExcludeLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x00250F98 File Offset: 0x0024F198
		public Span<int> GetPriorityBreakExcludeBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x00250FA8 File Offset: 0x0024F1A8
		public int[] GetPriorityBreakExcludeArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x00250FC0 File Offset: 0x0024F1C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonIdIter()或GetDungeonIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonId()
		{
			GuideGroup guideGroup = this;
			return guideGroup.GetDungeonIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x00250FE4 File Offset: 0x0024F1E4
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonIdIter()
		{
			GuideGroup.<DungeonIdIter>d__52 <DungeonIdIter>d__ = new GuideGroup.<DungeonIdIter>d__52(-2);
			<DungeonIdIter>d__.<>3__<>4__this = this;
			return <DungeonIdIter>d__;
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x00250FF9 File Offset: 0x0024F1F9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonSetsIter()或GetDungeonSetsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DungeonSets()
		{
			return this.DungeonSetsIter().ToArray<string>();
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x00251006 File Offset: 0x0024F206
		[NullableContext(1)]
		public readonly IEnumerable<string> DungeonSetsIter()
		{
			GuideGroup.<DungeonSetsIter>d__54 <DungeonSetsIter>d__ = new GuideGroup.<DungeonSetsIter>d__54(-2);
			<DungeonSetsIter>d__.<>3__<>4__this = this;
			return <DungeonSetsIter>d__;
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x0025101B File Offset: 0x0024F21B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonTypesIter()或GetDungeonTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] DungeonTypes()
		{
			return this.DungeonTypesIter().ToArray<IntPair>();
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x00251028 File Offset: 0x0024F228
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> DungeonTypesIter()
		{
			GuideGroup.<DungeonTypesIter>d__56 <DungeonTypesIter>d__ = new GuideGroup.<DungeonTypesIter>d__56(-2);
			<DungeonTypesIter>d__.<>3__<>4__this = this;
			return <DungeonTypesIter>d__;
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x00251040 File Offset: 0x0024F240
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitRepeatIter()或GetLimitRepeatBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LimitRepeat()
		{
			GuideGroup guideGroup = this;
			return guideGroup.GetLimitRepeatArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x00251064 File Offset: 0x0024F264
		[NullableContext(1)]
		public readonly IEnumerable<int> LimitRepeatIter()
		{
			GuideGroup.<LimitRepeatIter>d__58 <LimitRepeatIter>d__ = new GuideGroup.<LimitRepeatIter>d__58(-2);
			<LimitRepeatIter>d__.<>3__<>4__this = this;
			return <LimitRepeatIter>d__;
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x0025107C File Offset: 0x0024F27C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiPlatformStepIter()或GetMultiPlatformStepBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MultiPlatformStep()
		{
			GuideGroup guideGroup = this;
			return guideGroup.GetMultiPlatformStepArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x002510A0 File Offset: 0x0024F2A0
		[NullableContext(1)]
		public readonly IEnumerable<int> MultiPlatformStepIter()
		{
			GuideGroup.<MultiPlatformStepIter>d__60 <MultiPlatformStepIter>d__ = new GuideGroup.<MultiPlatformStepIter>d__60(-2);
			<MultiPlatformStepIter>d__.<>3__<>4__this = this;
			return <MultiPlatformStepIter>d__;
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x002510B8 File Offset: 0x0024F2B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PriorityBreakExcludeIter()或GetPriorityBreakExcludeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PriorityBreakExclude()
		{
			GuideGroup guideGroup = this;
			return guideGroup.GetPriorityBreakExcludeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x002510DC File Offset: 0x0024F2DC
		[NullableContext(1)]
		public readonly IEnumerable<int> PriorityBreakExcludeIter()
		{
			GuideGroup.<PriorityBreakExcludeIter>d__62 <PriorityBreakExcludeIter>d__ = new GuideGroup.<PriorityBreakExcludeIter>d__62(-2);
			<PriorityBreakExcludeIter>d__.<>3__<>4__this = this;
			return <PriorityBreakExcludeIter>d__;
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x002510F4 File Offset: 0x0024F2F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StepIter()或GetStepBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Step()
		{
			GuideGroup guideGroup = this;
			return guideGroup.GetStepArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x00251118 File Offset: 0x0024F318
		[NullableContext(1)]
		public readonly IEnumerable<int> StepIter()
		{
			GuideGroup.<StepIter>d__64 <StepIter>d__ = new GuideGroup.<StepIter>d__64(-2);
			<StepIter>d__.<>3__<>4__this = this;
			return <StepIter>d__;
		}

		// Token: 0x04004D92 RID: 19858
		private Table __p;
	}
}
