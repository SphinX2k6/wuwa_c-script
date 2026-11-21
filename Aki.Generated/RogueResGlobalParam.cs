using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010ED RID: 4333
	public struct RogueResGlobalParam : IFlatbufferObject
	{
		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x00308B50 File Offset: 0x00306D50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x00308B5D File Offset: 0x00306D5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x00308B64 File Offset: 0x00306D64
		public static RogueResGlobalParam GetRootAsRogueResGlobalParam(ByteBuffer _bb)
		{
			return RogueResGlobalParam.GetRootAsRogueResGlobalParam(_bb, default(RogueResGlobalParam));
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x00308B80 File Offset: 0x00306D80
		public static RogueResGlobalParam GetRootAsRogueResGlobalParam(ByteBuffer _bb, RogueResGlobalParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x00308B9D File Offset: 0x00306D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x00308BAC File Offset: 0x00306DAC
		public RogueResGlobalParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x00308BBC File Offset: 0x00306DBC
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

		// Token: 0x0600C8D4 RID: 51412 RVA: 0x00308BF8 File Offset: 0x00306DF8
		public int LimitedRoles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x00308C38 File Offset: 0x00306E38
		public int LimitedRolesLength
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

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x00308C63 File Offset: 0x00306E63
		public Span<int> GetLimitedRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x00308C72 File Offset: 0x00306E72
		public int[] GetLimitedRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x00308C8C File Offset: 0x00306E8C
		public int EventStartSeqType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600C8D9 RID: 51417 RVA: 0x00308CCC File Offset: 0x00306ECC
		public int EventStartSeqTypeLength
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

		// Token: 0x0600C8DA RID: 51418 RVA: 0x00308CF7 File Offset: 0x00306EF7
		public Span<int> GetEventStartSeqTypeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x00308D06 File Offset: 0x00306F06
		public int[] GetEventStartSeqTypeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x00308D20 File Offset: 0x00306F20
		public int EventStartSpineType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x00308D60 File Offset: 0x00306F60
		public int EventStartSpineTypeLength
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

		// Token: 0x0600C8DE RID: 51422 RVA: 0x00308D8C File Offset: 0x00306F8C
		public Span<int> GetEventStartSpineTypeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x00308D9C File Offset: 0x00306F9C
		public int[] GetEventStartSpineTypeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x00308DB4 File Offset: 0x00306FB4
		public int GridTakeTipsEventType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600C8E1 RID: 51425 RVA: 0x00308DF4 File Offset: 0x00306FF4
		public int GridTakeTipsEventTypeLength
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

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x00308E20 File Offset: 0x00307020
		public Span<int> GetGridTakeTipsEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C8E3 RID: 51427 RVA: 0x00308E30 File Offset: 0x00307030
		public int[] GetGridTakeTipsEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x00308E48 File Offset: 0x00307048
		public int GridTakeSpineEventType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600C8E5 RID: 51429 RVA: 0x00308E88 File Offset: 0x00307088
		public int GridTakeSpineEventTypeLength
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

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x00308EB4 File Offset: 0x003070B4
		public Span<int> GetGridTakeSpineEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x00308EC4 File Offset: 0x003070C4
		public int[] GetGridTakeSpineEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x00308EDC File Offset: 0x003070DC
		public int EventDisappearEventType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x00308F1C File Offset: 0x0030711C
		public int EventDisappearEventTypeLength
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

		// Token: 0x0600C8EA RID: 51434 RVA: 0x00308F48 File Offset: 0x00307148
		public Span<int> GetEventDisappearEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x00308F58 File Offset: 0x00307158
		public int[] GetEventDisappearEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x00308F70 File Offset: 0x00307170
		public int ShowMoodChangeEventType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600C8ED RID: 51437 RVA: 0x00308FB0 File Offset: 0x003071B0
		public int ShowMoodChangeEventTypeLength
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

		// Token: 0x0600C8EE RID: 51438 RVA: 0x00308FDC File Offset: 0x003071DC
		public Span<int> GetShowMoodChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x00308FEC File Offset: 0x003071EC
		public int[] GetShowMoodChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x00309004 File Offset: 0x00307204
		public int ShowLvChangeEventType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600C8F1 RID: 51441 RVA: 0x00309044 File Offset: 0x00307244
		public int ShowLvChangeEventTypeLength
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

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x00309070 File Offset: 0x00307270
		public Span<int> GetShowLvChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x00309080 File Offset: 0x00307280
		public int[] GetShowLvChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600C8F4 RID: 51444 RVA: 0x00309098 File Offset: 0x00307298
		public int ShowCurrencyChangeEventType(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600C8F5 RID: 51445 RVA: 0x003090D8 File Offset: 0x003072D8
		public int ShowCurrencyChangeEventTypeLength
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

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x00309104 File Offset: 0x00307304
		public Span<int> GetShowCurrencyChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x00309114 File Offset: 0x00307314
		public int[] GetShowCurrencyChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600C8F8 RID: 51448 RVA: 0x0030912C File Offset: 0x0030732C
		public int FocusTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x00309170 File Offset: 0x00307370
		public string MainHelpImageDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600C8FA RID: 51450 RVA: 0x003091AC File Offset: 0x003073AC
		public int MainHelpImageDescLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x003091D8 File Offset: 0x003073D8
		public string MainHelpImageFig(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600C8FC RID: 51452 RVA: 0x00309214 File Offset: 0x00307414
		public int MainHelpImageFigLength
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

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600C8FD RID: 51453 RVA: 0x00309240 File Offset: 0x00307440
		public string MainHelpRuleDesc
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x00309278 File Offset: 0x00307478
		public Span<byte> GetMainHelpRuleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x00309288 File Offset: 0x00307488
		public byte[] GetMainHelpRuleDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600C900 RID: 51456 RVA: 0x003092A0 File Offset: 0x003074A0
		public int GridValidRangeTolerance
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600C901 RID: 51457 RVA: 0x003092E4 File Offset: 0x003074E4
		public bool OpenMapViewBlackScreen
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x00309324 File Offset: 0x00307524
		[NullableContext(1)]
		public int[] EventDisappearEventType()
		{
			return this.GetEventDisappearEventTypeArray();
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x0030932C File Offset: 0x0030752C
		[NullableContext(1)]
		public IEnumerable<int> EventDisappearEventTypeIter()
		{
			RogueResGlobalParam.<EventDisappearEventTypeIter>d__72 <EventDisappearEventTypeIter>d__ = new RogueResGlobalParam.<EventDisappearEventTypeIter>d__72(-2);
			<EventDisappearEventTypeIter>d__.<>3__<>4__this = this;
			return <EventDisappearEventTypeIter>d__;
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x00309341 File Offset: 0x00307541
		[NullableContext(1)]
		public int[] EventStartSeqType()
		{
			return this.GetEventStartSeqTypeArray();
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x00309349 File Offset: 0x00307549
		[NullableContext(1)]
		public IEnumerable<int> EventStartSeqTypeIter()
		{
			RogueResGlobalParam.<EventStartSeqTypeIter>d__74 <EventStartSeqTypeIter>d__ = new RogueResGlobalParam.<EventStartSeqTypeIter>d__74(-2);
			<EventStartSeqTypeIter>d__.<>3__<>4__this = this;
			return <EventStartSeqTypeIter>d__;
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x0030935E File Offset: 0x0030755E
		[NullableContext(1)]
		public int[] EventStartSpineType()
		{
			return this.GetEventStartSpineTypeArray();
		}

		// Token: 0x0600C907 RID: 51463 RVA: 0x00309366 File Offset: 0x00307566
		[NullableContext(1)]
		public IEnumerable<int> EventStartSpineTypeIter()
		{
			RogueResGlobalParam.<EventStartSpineTypeIter>d__76 <EventStartSpineTypeIter>d__ = new RogueResGlobalParam.<EventStartSpineTypeIter>d__76(-2);
			<EventStartSpineTypeIter>d__.<>3__<>4__this = this;
			return <EventStartSpineTypeIter>d__;
		}

		// Token: 0x0600C908 RID: 51464 RVA: 0x0030937B File Offset: 0x0030757B
		[NullableContext(1)]
		public int[] GridTakeSpineEventType()
		{
			return this.GetGridTakeSpineEventTypeArray();
		}

		// Token: 0x0600C909 RID: 51465 RVA: 0x00309383 File Offset: 0x00307583
		[NullableContext(1)]
		public IEnumerable<int> GridTakeSpineEventTypeIter()
		{
			RogueResGlobalParam.<GridTakeSpineEventTypeIter>d__78 <GridTakeSpineEventTypeIter>d__ = new RogueResGlobalParam.<GridTakeSpineEventTypeIter>d__78(-2);
			<GridTakeSpineEventTypeIter>d__.<>3__<>4__this = this;
			return <GridTakeSpineEventTypeIter>d__;
		}

		// Token: 0x0600C90A RID: 51466 RVA: 0x00309398 File Offset: 0x00307598
		[NullableContext(1)]
		public int[] GridTakeTipsEventType()
		{
			return this.GetGridTakeTipsEventTypeArray();
		}

		// Token: 0x0600C90B RID: 51467 RVA: 0x003093A0 File Offset: 0x003075A0
		[NullableContext(1)]
		public IEnumerable<int> GridTakeTipsEventTypeIter()
		{
			RogueResGlobalParam.<GridTakeTipsEventTypeIter>d__80 <GridTakeTipsEventTypeIter>d__ = new RogueResGlobalParam.<GridTakeTipsEventTypeIter>d__80(-2);
			<GridTakeTipsEventTypeIter>d__.<>3__<>4__this = this;
			return <GridTakeTipsEventTypeIter>d__;
		}

		// Token: 0x0600C90C RID: 51468 RVA: 0x003093B5 File Offset: 0x003075B5
		[NullableContext(1)]
		public int[] LimitedRoles()
		{
			return this.GetLimitedRolesArray();
		}

		// Token: 0x0600C90D RID: 51469 RVA: 0x003093BD File Offset: 0x003075BD
		[NullableContext(1)]
		public IEnumerable<int> LimitedRolesIter()
		{
			RogueResGlobalParam.<LimitedRolesIter>d__82 <LimitedRolesIter>d__ = new RogueResGlobalParam.<LimitedRolesIter>d__82(-2);
			<LimitedRolesIter>d__.<>3__<>4__this = this;
			return <LimitedRolesIter>d__;
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x003093D2 File Offset: 0x003075D2
		[NullableContext(1)]
		public string[] MainHelpImageDesc()
		{
			return this.MainHelpImageDescIter().ToArray<string>();
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x003093DF File Offset: 0x003075DF
		[NullableContext(1)]
		public IEnumerable<string> MainHelpImageDescIter()
		{
			RogueResGlobalParam.<MainHelpImageDescIter>d__84 <MainHelpImageDescIter>d__ = new RogueResGlobalParam.<MainHelpImageDescIter>d__84(-2);
			<MainHelpImageDescIter>d__.<>3__<>4__this = this;
			return <MainHelpImageDescIter>d__;
		}

		// Token: 0x0600C910 RID: 51472 RVA: 0x003093F4 File Offset: 0x003075F4
		[NullableContext(1)]
		public string[] MainHelpImageFig()
		{
			return this.MainHelpImageFigIter().ToArray<string>();
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x00309401 File Offset: 0x00307601
		[NullableContext(1)]
		public IEnumerable<string> MainHelpImageFigIter()
		{
			RogueResGlobalParam.<MainHelpImageFigIter>d__86 <MainHelpImageFigIter>d__ = new RogueResGlobalParam.<MainHelpImageFigIter>d__86(-2);
			<MainHelpImageFigIter>d__.<>3__<>4__this = this;
			return <MainHelpImageFigIter>d__;
		}

		// Token: 0x0600C912 RID: 51474 RVA: 0x00309416 File Offset: 0x00307616
		[NullableContext(1)]
		public int[] ShowCurrencyChangeEventType()
		{
			return this.GetShowCurrencyChangeEventTypeArray();
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x0030941E File Offset: 0x0030761E
		[NullableContext(1)]
		public IEnumerable<int> ShowCurrencyChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowCurrencyChangeEventTypeIter>d__88 <ShowCurrencyChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowCurrencyChangeEventTypeIter>d__88(-2);
			<ShowCurrencyChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowCurrencyChangeEventTypeIter>d__;
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x00309433 File Offset: 0x00307633
		[NullableContext(1)]
		public int[] ShowLvChangeEventType()
		{
			return this.GetShowLvChangeEventTypeArray();
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x0030943B File Offset: 0x0030763B
		[NullableContext(1)]
		public IEnumerable<int> ShowLvChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowLvChangeEventTypeIter>d__90 <ShowLvChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowLvChangeEventTypeIter>d__90(-2);
			<ShowLvChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowLvChangeEventTypeIter>d__;
		}

		// Token: 0x0600C916 RID: 51478 RVA: 0x00309450 File Offset: 0x00307650
		[NullableContext(1)]
		public int[] ShowMoodChangeEventType()
		{
			return this.GetShowMoodChangeEventTypeArray();
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x00309458 File Offset: 0x00307658
		[NullableContext(1)]
		public IEnumerable<int> ShowMoodChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowMoodChangeEventTypeIter>d__92 <ShowMoodChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowMoodChangeEventTypeIter>d__92(-2);
			<ShowMoodChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowMoodChangeEventTypeIter>d__;
		}

		// Token: 0x040056D5 RID: 22229
		private Table __p;
	}
}
