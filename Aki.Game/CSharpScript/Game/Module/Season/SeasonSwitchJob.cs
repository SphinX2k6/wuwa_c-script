using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C33 RID: 15411
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class SeasonSwitchJob : ISeasonSwitchJob
	{
		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x0602778A RID: 161674 RVA: 0x00B11CCE File Offset: 0x00B0FECE
		// (set) Token: 0x0602778B RID: 161675 RVA: 0x00B11CD6 File Offset: 0x00B0FED6
		[RequiredMember]
		public ESeason TargetSeason { get; set; }

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x0602778C RID: 161676 RVA: 0x00B11CDF File Offset: 0x00B0FEDF
		// (set) Token: 0x0602778D RID: 161677 RVA: 0x00B11CE7 File Offset: 0x00B0FEE7
		[RequiredMember]
		public double TargetValue { get; set; }

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x0602778E RID: 161678 RVA: 0x00B11CF0 File Offset: 0x00B0FEF0
		// (set) Token: 0x0602778F RID: 161679 RVA: 0x00B11CF8 File Offset: 0x00B0FEF8
		[RequiredMember]
		public double Speed { get; set; }

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x06027790 RID: 161680 RVA: 0x00B11D01 File Offset: 0x00B0FF01
		// (set) Token: 0x06027791 RID: 161681 RVA: 0x00B11D09 File Offset: 0x00B0FF09
		[RequiredMember]
		public double RemainDistance { get; set; }

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x06027792 RID: 161682 RVA: 0x00B11D12 File Offset: 0x00B0FF12
		// (set) Token: 0x06027793 RID: 161683 RVA: 0x00B11D1A File Offset: 0x00B0FF1A
		public TSeasonSwitchCallback OnComplete { get; set; }

		// Token: 0x06027794 RID: 161684 RVA: 0x00B11D23 File Offset: 0x00B0FF23
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SeasonSwitchJob()
		{
		}
	}
}
