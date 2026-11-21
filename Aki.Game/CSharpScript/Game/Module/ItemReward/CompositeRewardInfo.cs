using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004790 RID: 18320
	[NullableContext(2)]
	[Nullable(0)]
	public class CompositeRewardInfo : RewardInfo, ICompositeRewardInfo, IRewardInfo
	{
		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x0602E0A4 RID: 188580 RVA: 0x00CDEB56 File Offset: 0x00CDCD56
		// (set) Token: 0x0602E0A5 RID: 188581 RVA: 0x00CDEB5E File Offset: 0x00CDCD5E
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Composite;

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x0602E0A6 RID: 188582 RVA: 0x00CDEB67 File Offset: 0x00CDCD67
		// (set) Token: 0x0602E0A7 RID: 188583 RVA: 0x00CDEB6F File Offset: 0x00CDCD6F
		public int Id { get; set; }

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x0602E0A8 RID: 188584 RVA: 0x00CDEB78 File Offset: 0x00CDCD78
		// (set) Token: 0x0602E0A9 RID: 188585 RVA: 0x00CDEB80 File Offset: 0x00CDCD80
		public bool IsSuccess { get; set; }

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x0602E0AA RID: 188586 RVA: 0x00CDEB89 File Offset: 0x00CDCD89
		// (set) Token: 0x0602E0AB RID: 188587 RVA: 0x00CDEB91 File Offset: 0x00CDCD91
		public string Title { get; set; }

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x0602E0AC RID: 188588 RVA: 0x00CDEB9A File Offset: 0x00CDCD9A
		// (set) Token: 0x0602E0AD RID: 188589 RVA: 0x00CDEBA2 File Offset: 0x00CDCDA2
		public string ContinueText { get; set; }

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0602E0AE RID: 188590 RVA: 0x00CDEBAB File Offset: 0x00CDCDAB
		// (set) Token: 0x0602E0AF RID: 188591 RVA: 0x00CDEBB3 File Offset: 0x00CDCDB3
		public string TitleIconPath { get; set; }

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x0602E0B0 RID: 188592 RVA: 0x00CDEBBC File Offset: 0x00CDCDBC
		// (set) Token: 0x0602E0B1 RID: 188593 RVA: 0x00CDEBC4 File Offset: 0x00CDCDC4
		public bool IsProgressVisible { get; set; }

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x0602E0B2 RID: 188594 RVA: 0x00CDEBCD File Offset: 0x00CDCDCD
		// (set) Token: 0x0602E0B3 RID: 188595 RVA: 0x00CDEBD5 File Offset: 0x00CDCDD5
		[Nullable(1)]
		public string ProgressBarTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x0602E0B4 RID: 188596 RVA: 0x00CDEBDE File Offset: 0x00CDCDDE
		// (set) Token: 0x0602E0B5 RID: 188597 RVA: 0x00CDEBE6 File Offset: 0x00CDCDE6
		public int ProgressBarAnimationTime { get; set; }

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x0602E0B6 RID: 188598 RVA: 0x00CDEBEF File Offset: 0x00CDCDEF
		// (set) Token: 0x0602E0B7 RID: 188599 RVA: 0x00CDEBF7 File Offset: 0x00CDCDF7
		public bool IsItemVisible { get; set; }
	}
}
