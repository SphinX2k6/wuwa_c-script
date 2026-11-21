using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD3 RID: 3283
	public struct DirectTrainActivity : IFlatbufferObject
	{
		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600680A RID: 26634 RVA: 0x00232C35 File Offset: 0x00230E35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00232C42 File Offset: 0x00230E42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x00232C4C File Offset: 0x00230E4C
		public static DirectTrainActivity GetRootAsDirectTrainActivity(ByteBuffer _bb)
		{
			return DirectTrainActivity.GetRootAsDirectTrainActivity(_bb, default(DirectTrainActivity));
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00232C68 File Offset: 0x00230E68
		public static DirectTrainActivity GetRootAsDirectTrainActivity(ByteBuffer _bb, DirectTrainActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00232C85 File Offset: 0x00230E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x00232C94 File Offset: 0x00230E94
		public DirectTrainActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x00232CA4 File Offset: 0x00230EA4
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

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x00232CE0 File Offset: 0x00230EE0
		public int SkipQuestId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x00232D1C File Offset: 0x00230F1C
		public bool IsForceRemind
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x00232D5C File Offset: 0x00230F5C
		public int ForceRemindCond
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

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00232D9C File Offset: 0x00230F9C
		public int SkipQuestCondition
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

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x00232DDC File Offset: 0x00230FDC
		public string SkipButton
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00232E14 File Offset: 0x00231014
		public Span<byte> GetSkipButtonBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x00232E24 File Offset: 0x00231024
		public byte[] GetSkipButtonArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x00232E3C File Offset: 0x0023103C
		public string SkipTipTitle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x00232E74 File Offset: 0x00231074
		public Span<byte> GetSkipTipTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00232E84 File Offset: 0x00231084
		public byte[] GetSkipTipTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x00232E9C File Offset: 0x0023109C
		public string SkipTipContent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00232ED4 File Offset: 0x002310D4
		public Span<byte> GetSkipTipContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x00232EE4 File Offset: 0x002310E4
		public byte[] GetSkipTipContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x00232EFC File Offset: 0x002310FC
		public int LimitInstanceId(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x00232F3C File Offset: 0x0023113C
		public int LimitInstanceIdLength
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

		// Token: 0x06006820 RID: 26656 RVA: 0x00232F68 File Offset: 0x00231168
		public Span<int> GetLimitInstanceIdBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x00232F78 File Offset: 0x00231178
		public int[] GetLimitInstanceIdArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x00232F90 File Offset: 0x00231190
		public string LimitInstanceText
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x00232FC8 File Offset: 0x002311C8
		public Span<byte> GetLimitInstanceTextBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00232FD8 File Offset: 0x002311D8
		public byte[] GetLimitInstanceTextArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x00232FF0 File Offset: 0x002311F0
		public bool OpenQuestViewOnConfirm
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x00233030 File Offset: 0x00231230
		public string VersionTitle
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x00233068 File Offset: 0x00231268
		public Span<byte> GetVersionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00233078 File Offset: 0x00231278
		public byte[] GetVersionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x00233090 File Offset: 0x00231290
		public bool ShowRecommend
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600682A RID: 26666 RVA: 0x002330D0 File Offset: 0x002312D0
		public string EntryPicMale
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

		// Token: 0x0600682B RID: 26667 RVA: 0x00233108 File Offset: 0x00231308
		public Span<byte> GetEntryPicMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00233118 File Offset: 0x00231318
		public byte[] GetEntryPicMaleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x00233130 File Offset: 0x00231330
		public string EntryPicFemale
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x00233168 File Offset: 0x00231368
		public Span<byte> GetEntryPicFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00233178 File Offset: 0x00231378
		public byte[] GetEntryPicFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x00233190 File Offset: 0x00231390
		public string BgPicMale
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x002331C8 File Offset: 0x002313C8
		public Span<byte> GetBgPicMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x002331D8 File Offset: 0x002313D8
		public byte[] GetBgPicMaleArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x002331F0 File Offset: 0x002313F0
		public string BgPicFemale
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x00233228 File Offset: 0x00231428
		public Span<byte> GetBgPicFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00233238 File Offset: 0x00231438
		public byte[] GetBgPicFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x00233250 File Offset: 0x00231450
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00233288 File Offset: 0x00231488
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00233298 File Offset: 0x00231498
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x002332B0 File Offset: 0x002314B0
		public int HighlightList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x002332F0 File Offset: 0x002314F0
		public int HighlightListLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x0023331C File Offset: 0x0023151C
		public Span<int> GetHighlightListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0023332C File Offset: 0x0023152C
		public int[] GetHighlightListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x00233344 File Offset: 0x00231544
		public string LockHint
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x0023337C File Offset: 0x0023157C
		public Span<byte> GetLockHintBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x0023338C File Offset: 0x0023158C
		public byte[] GetLockHintArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x002333A4 File Offset: 0x002315A4
		public string ButtonText
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x002333DC File Offset: 0x002315DC
		public Span<byte> GetButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x002333EC File Offset: 0x002315EC
		public byte[] GetButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06006843 RID: 26691 RVA: 0x00233404 File Offset: 0x00231604
		public string PrefabResource
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x0023343C File Offset: 0x0023163C
		public Span<byte> GetPrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x0023344C File Offset: 0x0023164C
		public byte[] GetPrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06006846 RID: 26694 RVA: 0x00233464 File Offset: 0x00231664
		public int RecommendQuestId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x002334A4 File Offset: 0x002316A4
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06006848 RID: 26696 RVA: 0x002334E4 File Offset: 0x002316E4
		public int RecommendQuestLinkListLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00233510 File Offset: 0x00231710
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00233520 File Offset: 0x00231720
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x00233538 File Offset: 0x00231738
		public string RecommendQuestLabel
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00233570 File Offset: 0x00231770
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00233580 File Offset: 0x00231780
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00233598 File Offset: 0x00231798
		[NullableContext(1)]
		public int[] HighlightList()
		{
			return this.GetHighlightListArray();
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x002335A0 File Offset: 0x002317A0
		[NullableContext(1)]
		public IEnumerable<int> HighlightListIter()
		{
			DirectTrainActivity.<HighlightListIter>d__96 <HighlightListIter>d__ = new DirectTrainActivity.<HighlightListIter>d__96(-2);
			<HighlightListIter>d__.<>3__<>4__this = this;
			return <HighlightListIter>d__;
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x002335B5 File Offset: 0x002317B5
		[NullableContext(1)]
		public int[] LimitInstanceId()
		{
			return this.GetLimitInstanceIdArray();
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x002335BD File Offset: 0x002317BD
		[NullableContext(1)]
		public IEnumerable<int> LimitInstanceIdIter()
		{
			DirectTrainActivity.<LimitInstanceIdIter>d__98 <LimitInstanceIdIter>d__ = new DirectTrainActivity.<LimitInstanceIdIter>d__98(-2);
			<LimitInstanceIdIter>d__.<>3__<>4__this = this;
			return <LimitInstanceIdIter>d__;
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x002335D2 File Offset: 0x002317D2
		[NullableContext(1)]
		public int[] RecommendQuestLinkList()
		{
			return this.GetRecommendQuestLinkListArray();
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x002335DA File Offset: 0x002317DA
		[NullableContext(1)]
		public IEnumerable<int> RecommendQuestLinkListIter()
		{
			DirectTrainActivity.<RecommendQuestLinkListIter>d__100 <RecommendQuestLinkListIter>d__ = new DirectTrainActivity.<RecommendQuestLinkListIter>d__100(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x04005200 RID: 20992
		private Table __p;
	}
}
