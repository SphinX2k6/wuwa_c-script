using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B9 RID: 22457
	[NullableContext(2)]
	[Nullable(0)]
	public class CompositeRewardInfo : RewardInfo, ICompositeRewardInfo, IRewardInfo
	{
		// Token: 0x1700894A RID: 35146
		// (get) Token: 0x06039194 RID: 233876 RVA: 0x00D8FD1E File Offset: 0x00D8DF1E
		// (set) Token: 0x06039195 RID: 233877 RVA: 0x00D8FD26 File Offset: 0x00D8DF26
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Composite;

		// Token: 0x1700894B RID: 35147
		// (get) Token: 0x06039196 RID: 233878 RVA: 0x00D8FD2F File Offset: 0x00D8DF2F
		// (set) Token: 0x06039197 RID: 233879 RVA: 0x00D8FD37 File Offset: 0x00D8DF37
		public int Id { get; set; }

		// Token: 0x1700894C RID: 35148
		// (get) Token: 0x06039198 RID: 233880 RVA: 0x00D8FD40 File Offset: 0x00D8DF40
		// (set) Token: 0x06039199 RID: 233881 RVA: 0x00D8FD48 File Offset: 0x00D8DF48
		public bool IsSuccess { get; set; }

		// Token: 0x1700894D RID: 35149
		// (get) Token: 0x0603919A RID: 233882 RVA: 0x00D8FD51 File Offset: 0x00D8DF51
		// (set) Token: 0x0603919B RID: 233883 RVA: 0x00D8FD59 File Offset: 0x00D8DF59
		public string Title { get; set; }

		// Token: 0x1700894E RID: 35150
		// (get) Token: 0x0603919C RID: 233884 RVA: 0x00D8FD62 File Offset: 0x00D8DF62
		// (set) Token: 0x0603919D RID: 233885 RVA: 0x00D8FD6A File Offset: 0x00D8DF6A
		public string ContinueText { get; set; }

		// Token: 0x1700894F RID: 35151
		// (get) Token: 0x0603919E RID: 233886 RVA: 0x00D8FD73 File Offset: 0x00D8DF73
		// (set) Token: 0x0603919F RID: 233887 RVA: 0x00D8FD7B File Offset: 0x00D8DF7B
		public string TitleIconPath { get; set; }

		// Token: 0x17008950 RID: 35152
		// (get) Token: 0x060391A0 RID: 233888 RVA: 0x00D8FD84 File Offset: 0x00D8DF84
		// (set) Token: 0x060391A1 RID: 233889 RVA: 0x00D8FD8C File Offset: 0x00D8DF8C
		public bool IsProgressVisible { get; set; }

		// Token: 0x17008951 RID: 35153
		// (get) Token: 0x060391A2 RID: 233890 RVA: 0x00D8FD95 File Offset: 0x00D8DF95
		// (set) Token: 0x060391A3 RID: 233891 RVA: 0x00D8FD9D File Offset: 0x00D8DF9D
		[Nullable(1)]
		public string ProgressBarTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008952 RID: 35154
		// (get) Token: 0x060391A4 RID: 233892 RVA: 0x00D8FDA6 File Offset: 0x00D8DFA6
		// (set) Token: 0x060391A5 RID: 233893 RVA: 0x00D8FDAE File Offset: 0x00D8DFAE
		public int ProgressBarAnimationTime { get; set; }

		// Token: 0x17008953 RID: 35155
		// (get) Token: 0x060391A6 RID: 233894 RVA: 0x00D8FDB7 File Offset: 0x00D8DFB7
		// (set) Token: 0x060391A7 RID: 233895 RVA: 0x00D8FDBF File Offset: 0x00D8DFBF
		public bool IsItemVisible { get; set; }
	}
}
