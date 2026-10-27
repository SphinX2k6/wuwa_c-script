using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DFA RID: 28154
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class QteHourglassCompletedQteInfo : IQteHourglassCompletedQteInfo
	{
		// Token: 0x170099E0 RID: 39392
		// (get) Token: 0x06044ADB RID: 281307 RVA: 0x010F39CC File Offset: 0x010F1BCC
		// (set) Token: 0x06044ADC RID: 281308 RVA: 0x010F39D4 File Offset: 0x010F1BD4
		[RequiredMember]
		public int HandleId { get; set; }

		// Token: 0x170099E1 RID: 39393
		// (get) Token: 0x06044ADD RID: 281309 RVA: 0x010F39DD File Offset: 0x010F1BDD
		// (set) Token: 0x06044ADE RID: 281310 RVA: 0x010F39E5 File Offset: 0x010F1BE5
		[RequiredMember]
		public int QteId { get; set; }

		// Token: 0x170099E2 RID: 39394
		// (get) Token: 0x06044ADF RID: 281311 RVA: 0x010F39EE File Offset: 0x010F1BEE
		// (set) Token: 0x06044AE0 RID: 281312 RVA: 0x010F39F6 File Offset: 0x010F1BF6
		[RequiredMember]
		public bool IsSuccess { get; set; }

		// Token: 0x170099E3 RID: 39395
		// (get) Token: 0x06044AE1 RID: 281313 RVA: 0x010F39FF File Offset: 0x010F1BFF
		// (set) Token: 0x06044AE2 RID: 281314 RVA: 0x010F3A07 File Offset: 0x010F1C07
		[RequiredMember]
		public bool IsFail { get; set; }

		// Token: 0x170099E4 RID: 39396
		// (get) Token: 0x06044AE3 RID: 281315 RVA: 0x010F3A10 File Offset: 0x010F1C10
		// (set) Token: 0x06044AE4 RID: 281316 RVA: 0x010F3A18 File Offset: 0x010F1C18
		public Vector StartPos { get; set; }

		// Token: 0x06044AE5 RID: 281317 RVA: 0x010F3A21 File Offset: 0x010F1C21
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QteHourglassCompletedQteInfo()
		{
		}
	}
}
