using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C30 RID: 15408
	[RequiredMember]
	public class SeasonLoopState : ISeasonLoopState
	{
		// Token: 0x17005084 RID: 20612
		// (get) Token: 0x06027775 RID: 161653 RVA: 0x00B11C93 File Offset: 0x00B0FE93
		// (set) Token: 0x06027776 RID: 161654 RVA: 0x00B11C9B File Offset: 0x00B0FE9B
		[RequiredMember]
		public ESeason CurrentSeason { get; set; }

		// Token: 0x17005085 RID: 20613
		// (get) Token: 0x06027777 RID: 161655 RVA: 0x00B11CA4 File Offset: 0x00B0FEA4
		// (set) Token: 0x06027778 RID: 161656 RVA: 0x00B11CAC File Offset: 0x00B0FEAC
		[RequiredMember]
		public ESeasonLoopPhase Phase { get; set; }

		// Token: 0x17005086 RID: 20614
		// (get) Token: 0x06027779 RID: 161657 RVA: 0x00B11CB5 File Offset: 0x00B0FEB5
		// (set) Token: 0x0602777A RID: 161658 RVA: 0x00B11CBD File Offset: 0x00B0FEBD
		[RequiredMember]
		public double PhaseElapsed { get; set; }

		// Token: 0x0602777B RID: 161659 RVA: 0x00B11CC6 File Offset: 0x00B0FEC6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SeasonLoopState()
		{
		}
	}
}
