using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C82 RID: 19586
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class SeasonSwitchJob : ISeasonSwitchJob
	{
		// Token: 0x17007CE2 RID: 31970
		// (get) Token: 0x060329D7 RID: 207319 RVA: 0x00BCD06A File Offset: 0x00BCB26A
		// (set) Token: 0x060329D8 RID: 207320 RVA: 0x00BCD072 File Offset: 0x00BCB272
		[RequiredMember]
		public ESeason TargetSeason { get; set; }

		// Token: 0x17007CE3 RID: 31971
		// (get) Token: 0x060329D9 RID: 207321 RVA: 0x00BCD07B File Offset: 0x00BCB27B
		// (set) Token: 0x060329DA RID: 207322 RVA: 0x00BCD083 File Offset: 0x00BCB283
		[RequiredMember]
		public double TargetValue { get; set; }

		// Token: 0x17007CE4 RID: 31972
		// (get) Token: 0x060329DB RID: 207323 RVA: 0x00BCD08C File Offset: 0x00BCB28C
		// (set) Token: 0x060329DC RID: 207324 RVA: 0x00BCD094 File Offset: 0x00BCB294
		[RequiredMember]
		public double Speed { get; set; }

		// Token: 0x17007CE5 RID: 31973
		// (get) Token: 0x060329DD RID: 207325 RVA: 0x00BCD09D File Offset: 0x00BCB29D
		// (set) Token: 0x060329DE RID: 207326 RVA: 0x00BCD0A5 File Offset: 0x00BCB2A5
		[RequiredMember]
		public double RemainDistance { get; set; }

		// Token: 0x17007CE6 RID: 31974
		// (get) Token: 0x060329DF RID: 207327 RVA: 0x00BCD0AE File Offset: 0x00BCB2AE
		// (set) Token: 0x060329E0 RID: 207328 RVA: 0x00BCD0B6 File Offset: 0x00BCB2B6
		public TSeasonSwitchCallback OnComplete { get; set; }

		// Token: 0x060329E1 RID: 207329 RVA: 0x00BCD0BF File Offset: 0x00BCB2BF
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SeasonSwitchJob()
		{
		}
	}
}
