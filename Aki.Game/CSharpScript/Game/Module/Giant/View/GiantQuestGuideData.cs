using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004963 RID: 18787
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GiantQuestGuideData : IGiantQuestGuideData
	{
		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x0602F1C2 RID: 192962 RVA: 0x00D22D27 File Offset: 0x00D20F27
		// (set) Token: 0x0602F1C3 RID: 192963 RVA: 0x00D22D2F File Offset: 0x00D20F2F
		[RequiredMember]
		public int AccessId { get; set; }

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x0602F1C4 RID: 192964 RVA: 0x00D22D38 File Offset: 0x00D20F38
		// (set) Token: 0x0602F1C5 RID: 192965 RVA: 0x00D22D40 File Offset: 0x00D20F40
		[RequiredMember]
		public List<int> GroupAccessIds { get; set; }

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x0602F1C6 RID: 192966 RVA: 0x00D22D49 File Offset: 0x00D20F49
		// (set) Token: 0x0602F1C7 RID: 192967 RVA: 0x00D22D51 File Offset: 0x00D20F51
		[RequiredMember]
		public int SkipConfigId { get; set; }

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x0602F1C8 RID: 192968 RVA: 0x00D22D5A File Offset: 0x00D20F5A
		// (set) Token: 0x0602F1C9 RID: 192969 RVA: 0x00D22D62 File Offset: 0x00D20F62
		[RequiredMember]
		public int AnchorItemId { get; set; }

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x0602F1CA RID: 192970 RVA: 0x00D22D6B File Offset: 0x00D20F6B
		// (set) Token: 0x0602F1CB RID: 192971 RVA: 0x00D22D73 File Offset: 0x00D20F73
		[RequiredMember]
		public string DescText { get; set; }

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x0602F1CC RID: 192972 RVA: 0x00D22D7C File Offset: 0x00D20F7C
		// (set) Token: 0x0602F1CD RID: 192973 RVA: 0x00D22D84 File Offset: 0x00D20F84
		[RequiredMember]
		public string LockedText { get; set; }

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x0602F1CE RID: 192974 RVA: 0x00D22D8D File Offset: 0x00D20F8D
		// (set) Token: 0x0602F1CF RID: 192975 RVA: 0x00D22D95 File Offset: 0x00D20F95
		[RequiredMember]
		public EGiantQuestGuideState State { get; set; }

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x0602F1D0 RID: 192976 RVA: 0x00D22D9E File Offset: 0x00D20F9E
		// (set) Token: 0x0602F1D1 RID: 192977 RVA: 0x00D22DA6 File Offset: 0x00D20FA6
		[RequiredMember]
		public List<IGiantQuestGuideItemInfo> Items { get; set; }

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x0602F1D2 RID: 192978 RVA: 0x00D22DAF File Offset: 0x00D20FAF
		// (set) Token: 0x0602F1D3 RID: 192979 RVA: 0x00D22DB7 File Offset: 0x00D20FB7
		[RequiredMember]
		public bool HasNew { get; set; }

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x0602F1D4 RID: 192980 RVA: 0x00D22DC0 File Offset: 0x00D20FC0
		// (set) Token: 0x0602F1D5 RID: 192981 RVA: 0x00D22DC8 File Offset: 0x00D20FC8
		[RequiredMember]
		public bool HasSkip { get; set; }

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x0602F1D6 RID: 192982 RVA: 0x00D22DD1 File Offset: 0x00D20FD1
		// (set) Token: 0x0602F1D7 RID: 192983 RVA: 0x00D22DD9 File Offset: 0x00D20FD9
		[RequiredMember]
		public Action<IGiantQuestGuideData> OnGoto { get; set; }

		// Token: 0x0602F1D8 RID: 192984 RVA: 0x00D22DE2 File Offset: 0x00D20FE2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantQuestGuideData()
		{
		}
	}
}
