using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C7F RID: 19583
	[RequiredMember]
	public class SeasonLoopState : ISeasonLoopState
	{
		// Token: 0x17007CDA RID: 31962
		// (get) Token: 0x060329C2 RID: 207298 RVA: 0x00BCD02F File Offset: 0x00BCB22F
		// (set) Token: 0x060329C3 RID: 207299 RVA: 0x00BCD037 File Offset: 0x00BCB237
		[RequiredMember]
		public ESeason CurrentSeason { get; set; }

		// Token: 0x17007CDB RID: 31963
		// (get) Token: 0x060329C4 RID: 207300 RVA: 0x00BCD040 File Offset: 0x00BCB240
		// (set) Token: 0x060329C5 RID: 207301 RVA: 0x00BCD048 File Offset: 0x00BCB248
		[RequiredMember]
		public ESeasonLoopPhase Phase { get; set; }

		// Token: 0x17007CDC RID: 31964
		// (get) Token: 0x060329C6 RID: 207302 RVA: 0x00BCD051 File Offset: 0x00BCB251
		// (set) Token: 0x060329C7 RID: 207303 RVA: 0x00BCD059 File Offset: 0x00BCB259
		[RequiredMember]
		public double PhaseElapsed { get; set; }

		// Token: 0x060329C8 RID: 207304 RVA: 0x00BCD062 File Offset: 0x00BCB262
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SeasonLoopState()
		{
		}
	}
}
