using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFF RID: 3583
	public struct GuideGroup : IFlatbufferObject
	{
		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x0026F380 File Offset: 0x0026D580
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008309 RID: 33545 RVA: 0x0026F38D File Offset: 0x0026D58D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x0026F394 File Offset: 0x0026D594
		public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb)
		{
			return GuideGroup.GetRootAsGuideGroup(_bb, default(GuideGroup));
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x0026F3B0 File Offset: 0x0026D5B0
		public static GuideGroup GetRootAsGuideGroup(ByteBuffer _bb, GuideGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x0026F3CD File Offset: 0x0026D5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x0026F3DC File Offset: 0x0026D5DC
		public GuideGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x0026F3EC File Offset: 0x0026D5EC
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

		// Token: 0x0600830F RID: 33551 RVA: 0x0026F428 File Offset: 0x0026D628
		public int Step(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06008310 RID: 33552 RVA: 0x0026F468 File Offset: 0x0026D668
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

		// Token: 0x06008311 RID: 33553 RVA: 0x0026F493 File Offset: 0x0026D693
		public Span<int> GetStepBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0026F4A2 File Offset: 0x0026D6A2
		public int[] GetStepArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x0026F4BC File Offset: 0x0026D6BC
		public int MultiPlatformStep(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x0026F4FC File Offset: 0x0026D6FC
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

		// Token: 0x06008315 RID: 33557 RVA: 0x0026F527 File Offset: 0x0026D727
		public Span<int> GetMultiPlatformStepBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008316 RID: 33558 RVA: 0x0026F536 File Offset: 0x0026D736
		public int[] GetMultiPlatformStepArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x0026F550 File Offset: 0x0026D750
		public int OpenLimitActivityCondition
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

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06008318 RID: 33560 RVA: 0x0026F590 File Offset: 0x0026D790
		public int OpenLimitCondition
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

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06008319 RID: 33561 RVA: 0x0026F5D0 File Offset: 0x0026D7D0
		public int AutoOpenActivityCondition
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

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600831A RID: 33562 RVA: 0x0026F610 File Offset: 0x0026D810
		public int AutoOpenCondition
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

		// Token: 0x0600831B RID: 33563 RVA: 0x0026F650 File Offset: 0x0026D850
		public int LimitRepeat(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x0026F690 File Offset: 0x0026D890
		public int LimitRepeatLength
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

		// Token: 0x0600831D RID: 33565 RVA: 0x0026F6BC File Offset: 0x0026D8BC
		public Span<int> GetLimitRepeatBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0026F6CC File Offset: 0x0026D8CC
		public int[] GetLimitRepeatArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x0026F6E4 File Offset: 0x0026D8E4
		public int DungeonId(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0026F724 File Offset: 0x0026D924
		public int DungeonIdLength
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

		// Token: 0x06008321 RID: 33569 RVA: 0x0026F750 File Offset: 0x0026D950
		public Span<int> GetDungeonIdBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x0026F760 File Offset: 0x0026D960
		public int[] GetDungeonIdArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x0026F778 File Offset: 0x0026D978
		public string DungeonSets(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06008324 RID: 33572 RVA: 0x0026F7B4 File Offset: 0x0026D9B4
		public int DungeonSetsLength
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

		// Token: 0x06008325 RID: 33573 RVA: 0x0026F7E0 File Offset: 0x0026D9E0
		public IntPair? DungeonTypes(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06008326 RID: 33574 RVA: 0x0026F844 File Offset: 0x0026DA44
		public int DungeonTypesLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06008327 RID: 33575 RVA: 0x0026F870 File Offset: 0x0026DA70
		public bool ResetInDungeon
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06008328 RID: 33576 RVA: 0x0026F8B0 File Offset: 0x0026DAB0
		public int OnlineMode
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06008329 RID: 33577 RVA: 0x0026F8F0 File Offset: 0x0026DAF0
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x0026F930 File Offset: 0x0026DB30
		public int PriorityBreakExclude(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600832B RID: 33579 RVA: 0x0026F970 File Offset: 0x0026DB70
		public int PriorityBreakExcludeLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x0026F99C File Offset: 0x0026DB9C
		public Span<int> GetPriorityBreakExcludeBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x0026F9AC File Offset: 0x0026DBAC
		public int[] GetPriorityBreakExcludeArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x0026F9C4 File Offset: 0x0026DBC4
		[NullableContext(1)]
		public int[] DungeonId()
		{
			return this.GetDungeonIdArray();
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0026F9CC File Offset: 0x0026DBCC
		[NullableContext(1)]
		public IEnumerable<int> DungeonIdIter()
		{
			GuideGroup.<DungeonIdIter>d__56 <DungeonIdIter>d__ = new GuideGroup.<DungeonIdIter>d__56(-2);
			<DungeonIdIter>d__.<>3__<>4__this = this;
			return <DungeonIdIter>d__;
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0026F9E1 File Offset: 0x0026DBE1
		[NullableContext(1)]
		public string[] DungeonSets()
		{
			return this.DungeonSetsIter().ToArray<string>();
		}

		// Token: 0x06008331 RID: 33585 RVA: 0x0026F9EE File Offset: 0x0026DBEE
		[NullableContext(1)]
		public IEnumerable<string> DungeonSetsIter()
		{
			GuideGroup.<DungeonSetsIter>d__58 <DungeonSetsIter>d__ = new GuideGroup.<DungeonSetsIter>d__58(-2);
			<DungeonSetsIter>d__.<>3__<>4__this = this;
			return <DungeonSetsIter>d__;
		}

		// Token: 0x06008332 RID: 33586 RVA: 0x0026FA03 File Offset: 0x0026DC03
		[NullableContext(1)]
		public IntPair[] DungeonTypes()
		{
			return this.DungeonTypesIter().ToArray<IntPair>();
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x0026FA10 File Offset: 0x0026DC10
		[NullableContext(1)]
		public IEnumerable<IntPair> DungeonTypesIter()
		{
			GuideGroup.<DungeonTypesIter>d__60 <DungeonTypesIter>d__ = new GuideGroup.<DungeonTypesIter>d__60(-2);
			<DungeonTypesIter>d__.<>3__<>4__this = this;
			return <DungeonTypesIter>d__;
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x0026FA25 File Offset: 0x0026DC25
		[NullableContext(1)]
		public int[] LimitRepeat()
		{
			return this.GetLimitRepeatArray();
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x0026FA2D File Offset: 0x0026DC2D
		[NullableContext(1)]
		public IEnumerable<int> LimitRepeatIter()
		{
			GuideGroup.<LimitRepeatIter>d__62 <LimitRepeatIter>d__ = new GuideGroup.<LimitRepeatIter>d__62(-2);
			<LimitRepeatIter>d__.<>3__<>4__this = this;
			return <LimitRepeatIter>d__;
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x0026FA42 File Offset: 0x0026DC42
		[NullableContext(1)]
		public int[] MultiPlatformStep()
		{
			return this.GetMultiPlatformStepArray();
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x0026FA4A File Offset: 0x0026DC4A
		[NullableContext(1)]
		public IEnumerable<int> MultiPlatformStepIter()
		{
			GuideGroup.<MultiPlatformStepIter>d__64 <MultiPlatformStepIter>d__ = new GuideGroup.<MultiPlatformStepIter>d__64(-2);
			<MultiPlatformStepIter>d__.<>3__<>4__this = this;
			return <MultiPlatformStepIter>d__;
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x0026FA5F File Offset: 0x0026DC5F
		[NullableContext(1)]
		public int[] PriorityBreakExclude()
		{
			return this.GetPriorityBreakExcludeArray();
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x0026FA67 File Offset: 0x0026DC67
		[NullableContext(1)]
		public IEnumerable<int> PriorityBreakExcludeIter()
		{
			GuideGroup.<PriorityBreakExcludeIter>d__66 <PriorityBreakExcludeIter>d__ = new GuideGroup.<PriorityBreakExcludeIter>d__66(-2);
			<PriorityBreakExcludeIter>d__.<>3__<>4__this = this;
			return <PriorityBreakExcludeIter>d__;
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x0026FA7C File Offset: 0x0026DC7C
		[NullableContext(1)]
		public int[] Step()
		{
			return this.GetStepArray();
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x0026FA84 File Offset: 0x0026DC84
		[NullableContext(1)]
		public IEnumerable<int> StepIter()
		{
			GuideGroup.<StepIter>d__68 <StepIter>d__ = new GuideGroup.<StepIter>d__68(-2);
			<StepIter>d__.<>3__<>4__this = this;
			return <StepIter>d__;
		}

		// Token: 0x04005377 RID: 21367
		private Table __p;
	}
}
