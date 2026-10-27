using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001005 RID: 4101
	public struct RogueResGlobalParam : IFlatbufferObject
	{
		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600C283 RID: 49795 RVA: 0x002EC924 File Offset: 0x002EAB24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C284 RID: 49796 RVA: 0x002EC931 File Offset: 0x002EAB31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C285 RID: 49797 RVA: 0x002EC938 File Offset: 0x002EAB38
		public static RogueResGlobalParam GetRootAsRogueResGlobalParam(ByteBuffer _bb)
		{
			return RogueResGlobalParam.GetRootAsRogueResGlobalParam(_bb, default(RogueResGlobalParam));
		}

		// Token: 0x0600C286 RID: 49798 RVA: 0x002EC954 File Offset: 0x002EAB54
		public static RogueResGlobalParam GetRootAsRogueResGlobalParam(ByteBuffer _bb, RogueResGlobalParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C287 RID: 49799 RVA: 0x002EC971 File Offset: 0x002EAB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C288 RID: 49800 RVA: 0x002EC980 File Offset: 0x002EAB80
		public RogueResGlobalParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600C289 RID: 49801 RVA: 0x002EC990 File Offset: 0x002EAB90
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

		// Token: 0x0600C28A RID: 49802 RVA: 0x002EC9CC File Offset: 0x002EABCC
		public int LimitedRoles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600C28B RID: 49803 RVA: 0x002ECA0C File Offset: 0x002EAC0C
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

		// Token: 0x0600C28C RID: 49804 RVA: 0x002ECA37 File Offset: 0x002EAC37
		public Span<int> GetLimitedRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x002ECA46 File Offset: 0x002EAC46
		public int[] GetLimitedRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C28E RID: 49806 RVA: 0x002ECA60 File Offset: 0x002EAC60
		public int EventStartSeqType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600C28F RID: 49807 RVA: 0x002ECAA0 File Offset: 0x002EACA0
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

		// Token: 0x0600C290 RID: 49808 RVA: 0x002ECACB File Offset: 0x002EACCB
		public Span<int> GetEventStartSeqTypeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C291 RID: 49809 RVA: 0x002ECADA File Offset: 0x002EACDA
		public int[] GetEventStartSeqTypeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x002ECAF4 File Offset: 0x002EACF4
		public int EventStartSpineType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600C293 RID: 49811 RVA: 0x002ECB34 File Offset: 0x002EAD34
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

		// Token: 0x0600C294 RID: 49812 RVA: 0x002ECB60 File Offset: 0x002EAD60
		public Span<int> GetEventStartSpineTypeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x002ECB70 File Offset: 0x002EAD70
		public int[] GetEventStartSpineTypeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x002ECB88 File Offset: 0x002EAD88
		public int GridTakeTipsEventType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600C297 RID: 49815 RVA: 0x002ECBC8 File Offset: 0x002EADC8
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

		// Token: 0x0600C298 RID: 49816 RVA: 0x002ECBF4 File Offset: 0x002EADF4
		public Span<int> GetGridTakeTipsEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x002ECC04 File Offset: 0x002EAE04
		public int[] GetGridTakeTipsEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600C29A RID: 49818 RVA: 0x002ECC1C File Offset: 0x002EAE1C
		public int GridTakeSpineEventType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600C29B RID: 49819 RVA: 0x002ECC5C File Offset: 0x002EAE5C
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

		// Token: 0x0600C29C RID: 49820 RVA: 0x002ECC88 File Offset: 0x002EAE88
		public Span<int> GetGridTakeSpineEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x002ECC98 File Offset: 0x002EAE98
		public int[] GetGridTakeSpineEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x002ECCB0 File Offset: 0x002EAEB0
		public int EventDisappearEventType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x002ECCF0 File Offset: 0x002EAEF0
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

		// Token: 0x0600C2A0 RID: 49824 RVA: 0x002ECD1C File Offset: 0x002EAF1C
		public Span<int> GetEventDisappearEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600C2A1 RID: 49825 RVA: 0x002ECD2C File Offset: 0x002EAF2C
		public int[] GetEventDisappearEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600C2A2 RID: 49826 RVA: 0x002ECD44 File Offset: 0x002EAF44
		public int ShowMoodChangeEventType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x002ECD84 File Offset: 0x002EAF84
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

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x002ECDB0 File Offset: 0x002EAFB0
		public Span<int> GetShowMoodChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x002ECDC0 File Offset: 0x002EAFC0
		public int[] GetShowMoodChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x002ECDD8 File Offset: 0x002EAFD8
		public int ShowLvChangeEventType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x002ECE18 File Offset: 0x002EB018
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

		// Token: 0x0600C2A8 RID: 49832 RVA: 0x002ECE44 File Offset: 0x002EB044
		public Span<int> GetShowLvChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x002ECE54 File Offset: 0x002EB054
		public int[] GetShowLvChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x002ECE6C File Offset: 0x002EB06C
		public int ShowCurrencyChangeEventType(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x002ECEAC File Offset: 0x002EB0AC
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

		// Token: 0x0600C2AC RID: 49836 RVA: 0x002ECED8 File Offset: 0x002EB0D8
		public Span<int> GetShowCurrencyChangeEventTypeBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x002ECEE8 File Offset: 0x002EB0E8
		public int[] GetShowCurrencyChangeEventTypeArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x002ECF00 File Offset: 0x002EB100
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

		// Token: 0x0600C2AF RID: 49839 RVA: 0x002ECF44 File Offset: 0x002EB144
		public string MainHelpImageDesc(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600C2B0 RID: 49840 RVA: 0x002ECF80 File Offset: 0x002EB180
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

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x002ECFAC File Offset: 0x002EB1AC
		public string MainHelpImageFig(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600C2B2 RID: 49842 RVA: 0x002ECFE8 File Offset: 0x002EB1E8
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

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x002ED014 File Offset: 0x002EB214
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

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x002ED04C File Offset: 0x002EB24C
		public Span<byte> GetMainHelpRuleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x002ED05C File Offset: 0x002EB25C
		public byte[] GetMainHelpRuleDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600C2B6 RID: 49846 RVA: 0x002ED074 File Offset: 0x002EB274
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

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x002ED0B8 File Offset: 0x002EB2B8
		public bool OpenMapViewBlackScreen
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x002ED0F8 File Offset: 0x002EB2F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EventDisappearEventTypeIter()或GetEventDisappearEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EventDisappearEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetEventDisappearEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x002ED11C File Offset: 0x002EB31C
		[NullableContext(1)]
		public readonly IEnumerable<int> EventDisappearEventTypeIter()
		{
			RogueResGlobalParam.<EventDisappearEventTypeIter>d__72 <EventDisappearEventTypeIter>d__ = new RogueResGlobalParam.<EventDisappearEventTypeIter>d__72(-2);
			<EventDisappearEventTypeIter>d__.<>3__<>4__this = this;
			return <EventDisappearEventTypeIter>d__;
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x002ED134 File Offset: 0x002EB334
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EventStartSeqTypeIter()或GetEventStartSeqTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EventStartSeqType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetEventStartSeqTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x002ED158 File Offset: 0x002EB358
		[NullableContext(1)]
		public readonly IEnumerable<int> EventStartSeqTypeIter()
		{
			RogueResGlobalParam.<EventStartSeqTypeIter>d__74 <EventStartSeqTypeIter>d__ = new RogueResGlobalParam.<EventStartSeqTypeIter>d__74(-2);
			<EventStartSeqTypeIter>d__.<>3__<>4__this = this;
			return <EventStartSeqTypeIter>d__;
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x002ED170 File Offset: 0x002EB370
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EventStartSpineTypeIter()或GetEventStartSpineTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EventStartSpineType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetEventStartSpineTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x002ED194 File Offset: 0x002EB394
		[NullableContext(1)]
		public readonly IEnumerable<int> EventStartSpineTypeIter()
		{
			RogueResGlobalParam.<EventStartSpineTypeIter>d__76 <EventStartSpineTypeIter>d__ = new RogueResGlobalParam.<EventStartSpineTypeIter>d__76(-2);
			<EventStartSpineTypeIter>d__.<>3__<>4__this = this;
			return <EventStartSpineTypeIter>d__;
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x002ED1AC File Offset: 0x002EB3AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GridTakeSpineEventTypeIter()或GetGridTakeSpineEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GridTakeSpineEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetGridTakeSpineEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2BF RID: 49855 RVA: 0x002ED1D0 File Offset: 0x002EB3D0
		[NullableContext(1)]
		public readonly IEnumerable<int> GridTakeSpineEventTypeIter()
		{
			RogueResGlobalParam.<GridTakeSpineEventTypeIter>d__78 <GridTakeSpineEventTypeIter>d__ = new RogueResGlobalParam.<GridTakeSpineEventTypeIter>d__78(-2);
			<GridTakeSpineEventTypeIter>d__.<>3__<>4__this = this;
			return <GridTakeSpineEventTypeIter>d__;
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x002ED1E8 File Offset: 0x002EB3E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GridTakeTipsEventTypeIter()或GetGridTakeTipsEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GridTakeTipsEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetGridTakeTipsEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x002ED20C File Offset: 0x002EB40C
		[NullableContext(1)]
		public readonly IEnumerable<int> GridTakeTipsEventTypeIter()
		{
			RogueResGlobalParam.<GridTakeTipsEventTypeIter>d__80 <GridTakeTipsEventTypeIter>d__ = new RogueResGlobalParam.<GridTakeTipsEventTypeIter>d__80(-2);
			<GridTakeTipsEventTypeIter>d__.<>3__<>4__this = this;
			return <GridTakeTipsEventTypeIter>d__;
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x002ED224 File Offset: 0x002EB424
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitedRolesIter()或GetLimitedRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LimitedRoles()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetLimitedRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x002ED248 File Offset: 0x002EB448
		[NullableContext(1)]
		public readonly IEnumerable<int> LimitedRolesIter()
		{
			RogueResGlobalParam.<LimitedRolesIter>d__82 <LimitedRolesIter>d__ = new RogueResGlobalParam.<LimitedRolesIter>d__82(-2);
			<LimitedRolesIter>d__.<>3__<>4__this = this;
			return <LimitedRolesIter>d__;
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x002ED25D File Offset: 0x002EB45D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainHelpImageDescIter()或GetMainHelpImageDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MainHelpImageDesc()
		{
			return this.MainHelpImageDescIter().ToArray<string>();
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x002ED26A File Offset: 0x002EB46A
		[NullableContext(1)]
		public readonly IEnumerable<string> MainHelpImageDescIter()
		{
			RogueResGlobalParam.<MainHelpImageDescIter>d__84 <MainHelpImageDescIter>d__ = new RogueResGlobalParam.<MainHelpImageDescIter>d__84(-2);
			<MainHelpImageDescIter>d__.<>3__<>4__this = this;
			return <MainHelpImageDescIter>d__;
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x002ED27F File Offset: 0x002EB47F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainHelpImageFigIter()或GetMainHelpImageFigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MainHelpImageFig()
		{
			return this.MainHelpImageFigIter().ToArray<string>();
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x002ED28C File Offset: 0x002EB48C
		[NullableContext(1)]
		public readonly IEnumerable<string> MainHelpImageFigIter()
		{
			RogueResGlobalParam.<MainHelpImageFigIter>d__86 <MainHelpImageFigIter>d__ = new RogueResGlobalParam.<MainHelpImageFigIter>d__86(-2);
			<MainHelpImageFigIter>d__.<>3__<>4__this = this;
			return <MainHelpImageFigIter>d__;
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x002ED2A4 File Offset: 0x002EB4A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowCurrencyChangeEventTypeIter()或GetShowCurrencyChangeEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowCurrencyChangeEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetShowCurrencyChangeEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x002ED2C8 File Offset: 0x002EB4C8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowCurrencyChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowCurrencyChangeEventTypeIter>d__88 <ShowCurrencyChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowCurrencyChangeEventTypeIter>d__88(-2);
			<ShowCurrencyChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowCurrencyChangeEventTypeIter>d__;
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x002ED2E0 File Offset: 0x002EB4E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowLvChangeEventTypeIter()或GetShowLvChangeEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowLvChangeEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetShowLvChangeEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x002ED304 File Offset: 0x002EB504
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowLvChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowLvChangeEventTypeIter>d__90 <ShowLvChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowLvChangeEventTypeIter>d__90(-2);
			<ShowLvChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowLvChangeEventTypeIter>d__;
		}

		// Token: 0x0600C2CC RID: 49868 RVA: 0x002ED31C File Offset: 0x002EB51C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowMoodChangeEventTypeIter()或GetShowMoodChangeEventTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowMoodChangeEventType()
		{
			RogueResGlobalParam rogueResGlobalParam = this;
			return rogueResGlobalParam.GetShowMoodChangeEventTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x002ED340 File Offset: 0x002EB540
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowMoodChangeEventTypeIter()
		{
			RogueResGlobalParam.<ShowMoodChangeEventTypeIter>d__92 <ShowMoodChangeEventTypeIter>d__ = new RogueResGlobalParam.<ShowMoodChangeEventTypeIter>d__92(-2);
			<ShowMoodChangeEventTypeIter>d__.<>3__<>4__this = this;
			return <ShowMoodChangeEventTypeIter>d__;
		}

		// Token: 0x040050ED RID: 20717
		private Table __p;
	}
}
