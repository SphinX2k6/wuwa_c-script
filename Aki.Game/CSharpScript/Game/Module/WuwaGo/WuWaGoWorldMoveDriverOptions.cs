using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004710 RID: 18192
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoWorldMoveDriverOptions : IWuWaGoWorldMoveDriverOptions
	{
		// Token: 0x170076D7 RID: 30423
		// (get) Token: 0x0602F8AA RID: 194730 RVA: 0x00B03881 File Offset: 0x00B01A81
		// (set) Token: 0x0602F8AB RID: 194731 RVA: 0x00B03889 File Offset: 0x00B01A89
		[RequiredMember]
		public IReadOnlyList<IWuWaGoWorldMoveTarget> Targets { get; set; }

		// Token: 0x170076D8 RID: 30424
		// (get) Token: 0x0602F8AC RID: 194732 RVA: 0x00B03892 File Offset: 0x00B01A92
		// (set) Token: 0x0602F8AD RID: 194733 RVA: 0x00B0389A File Offset: 0x00B01A9A
		[RequiredMember]
		public Vector FromWorldPosition { get; set; }

		// Token: 0x170076D9 RID: 30425
		// (get) Token: 0x0602F8AE RID: 194734 RVA: 0x00B038A3 File Offset: 0x00B01AA3
		// (set) Token: 0x0602F8AF RID: 194735 RVA: 0x00B038AB File Offset: 0x00B01AAB
		[RequiredMember]
		public Vector ToWorldPosition { get; set; }

		// Token: 0x170076DA RID: 30426
		// (get) Token: 0x0602F8B0 RID: 194736 RVA: 0x00B038B4 File Offset: 0x00B01AB4
		// (set) Token: 0x0602F8B1 RID: 194737 RVA: 0x00B038BC File Offset: 0x00B01ABC
		public int? DurationMs { get; set; }

		// Token: 0x170076DB RID: 30427
		// (get) Token: 0x0602F8B2 RID: 194738 RVA: 0x00B038C5 File Offset: 0x00B01AC5
		// (set) Token: 0x0602F8B3 RID: 194739 RVA: 0x00B038CD File Offset: 0x00B01ACD
		public float? Speed { get; set; }

		// Token: 0x170076DC RID: 30428
		// (get) Token: 0x0602F8B4 RID: 194740 RVA: 0x00B038D6 File Offset: 0x00B01AD6
		// (set) Token: 0x0602F8B5 RID: 194741 RVA: 0x00B038DE File Offset: 0x00B01ADE
		public int? TimeoutMs { get; set; }

		// Token: 0x170076DD RID: 30429
		// (get) Token: 0x0602F8B6 RID: 194742 RVA: 0x00B038E7 File Offset: 0x00B01AE7
		// (set) Token: 0x0602F8B7 RID: 194743 RVA: 0x00B038EF File Offset: 0x00B01AEF
		public int? TickIntervalMs { get; set; }

		// Token: 0x170076DE RID: 30430
		// (get) Token: 0x0602F8B8 RID: 194744 RVA: 0x00B038F8 File Offset: 0x00B01AF8
		// (set) Token: 0x0602F8B9 RID: 194745 RVA: 0x00B03900 File Offset: 0x00B01B00
		public int? SettleDurationMs { get; set; }

		// Token: 0x170076DF RID: 30431
		// (get) Token: 0x0602F8BA RID: 194746 RVA: 0x00B03909 File Offset: 0x00B01B09
		// (set) Token: 0x0602F8BB RID: 194747 RVA: 0x00B03911 File Offset: 0x00B01B11
		public float? EarlyStopStepRatio { get; set; }

		// Token: 0x170076E0 RID: 30432
		// (get) Token: 0x0602F8BC RID: 194748 RVA: 0x00B0391A File Offset: 0x00B01B1A
		// (set) Token: 0x0602F8BD RID: 194749 RVA: 0x00B03922 File Offset: 0x00B01B22
		public float? ArriveTolerance { get; set; }

		// Token: 0x170076E1 RID: 30433
		// (get) Token: 0x0602F8BE RID: 194750 RVA: 0x00B0392B File Offset: 0x00B01B2B
		// (set) Token: 0x0602F8BF RID: 194751 RVA: 0x00B03933 File Offset: 0x00B01B33
		[Nullable(2)]
		public Func<bool> ShouldAbort { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170076E2 RID: 30434
		// (get) Token: 0x0602F8C0 RID: 194752 RVA: 0x00B0393C File Offset: 0x00B01B3C
		// (set) Token: 0x0602F8C1 RID: 194753 RVA: 0x00B03944 File Offset: 0x00B01B44
		public EWuWaGoTimeStopPolicy? TimeStopPolicy { get; set; }

		// Token: 0x170076E3 RID: 30435
		// (get) Token: 0x0602F8C2 RID: 194754 RVA: 0x00B0394D File Offset: 0x00B01B4D
		// (set) Token: 0x0602F8C3 RID: 194755 RVA: 0x00B03955 File Offset: 0x00B01B55
		[Nullable(2)]
		public IWuWaGoWorldMoveHooks Hooks { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602F8C4 RID: 194756 RVA: 0x00B0395E File Offset: 0x00B01B5E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoWorldMoveDriverOptions()
		{
		}
	}
}
