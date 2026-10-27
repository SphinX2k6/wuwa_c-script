using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B7 RID: 22455
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonRewardInfo : RewardInfo, ICommonRewardInfo, IRewardInfo
	{
		// Token: 0x17008935 RID: 35125
		// (get) Token: 0x06039169 RID: 233833 RVA: 0x00D8FC54 File Offset: 0x00D8DE54
		// (set) Token: 0x0603916A RID: 233834 RVA: 0x00D8FC5C File Offset: 0x00D8DE5C
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Common;

		// Token: 0x17008936 RID: 35126
		// (get) Token: 0x0603916B RID: 233835 RVA: 0x00D8FC65 File Offset: 0x00D8DE65
		// (set) Token: 0x0603916C RID: 233836 RVA: 0x00D8FC6D File Offset: 0x00D8DE6D
		public string Title { get; set; }

		// Token: 0x17008937 RID: 35127
		// (get) Token: 0x0603916D RID: 233837 RVA: 0x00D8FC76 File Offset: 0x00D8DE76
		// (set) Token: 0x0603916E RID: 233838 RVA: 0x00D8FC7E File Offset: 0x00D8DE7E
		public string ContinueText { get; set; }

		// Token: 0x17008938 RID: 35128
		// (get) Token: 0x0603916F RID: 233839 RVA: 0x00D8FC87 File Offset: 0x00D8DE87
		// (set) Token: 0x06039170 RID: 233840 RVA: 0x00D8FC8F File Offset: 0x00D8DE8F
		public bool IsItemVisible { get; set; }

		// Token: 0x17008939 RID: 35129
		// (get) Token: 0x06039171 RID: 233841 RVA: 0x00D8FC98 File Offset: 0x00D8DE98
		// (set) Token: 0x06039172 RID: 233842 RVA: 0x00D8FCA0 File Offset: 0x00D8DEA0
		public Action OnCloseCallback { get; set; }

		// Token: 0x1700893A RID: 35130
		// (get) Token: 0x06039173 RID: 233843 RVA: 0x00D8FCA9 File Offset: 0x00D8DEA9
		// (set) Token: 0x06039174 RID: 233844 RVA: 0x00D8FCB1 File Offset: 0x00D8DEB1
		public string LeftBtnTextId { get; set; }

		// Token: 0x1700893B RID: 35131
		// (get) Token: 0x06039175 RID: 233845 RVA: 0x00D8FCBA File Offset: 0x00D8DEBA
		// (set) Token: 0x06039176 RID: 233846 RVA: 0x00D8FCC2 File Offset: 0x00D8DEC2
		public string RightBtnTextId { get; set; }

		// Token: 0x1700893C RID: 35132
		// (get) Token: 0x06039177 RID: 233847 RVA: 0x00D8FCCB File Offset: 0x00D8DECB
		// (set) Token: 0x06039178 RID: 233848 RVA: 0x00D8FCD3 File Offset: 0x00D8DED3
		public Action LeftAction { get; set; }

		// Token: 0x1700893D RID: 35133
		// (get) Token: 0x06039179 RID: 233849 RVA: 0x00D8FCDC File Offset: 0x00D8DEDC
		// (set) Token: 0x0603917A RID: 233850 RVA: 0x00D8FCE4 File Offset: 0x00D8DEE4
		public Action RightAction { get; set; }

		// Token: 0x1700893E RID: 35134
		// (get) Token: 0x0603917B RID: 233851 RVA: 0x00D8FCED File Offset: 0x00D8DEED
		// (set) Token: 0x0603917C RID: 233852 RVA: 0x00D8FCF5 File Offset: 0x00D8DEF5
		public bool? DisableMaskClose { get; set; }

		// Token: 0x1700893F RID: 35135
		// (get) Token: 0x0603917D RID: 233853 RVA: 0x00D8FCFE File Offset: 0x00D8DEFE
		// (set) Token: 0x0603917E RID: 233854 RVA: 0x00D8FD06 File Offset: 0x00D8DF06
		public bool? TipsCanSkip { get; set; }
	}
}
