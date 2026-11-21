using System;
using System.Runtime.CompilerServices;

// Token: 0x02002831 RID: 10289
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VehicleEnterExitMontage : IVehicleEnterExitMontage
{
	// Token: 0x17002A09 RID: 10761
	// (get) Token: 0x06019F51 RID: 106321 RVA: 0x007FEEE8 File Offset: 0x007FD0E8
	// (set) Token: 0x06019F52 RID: 106322 RVA: 0x007FEEF0 File Offset: 0x007FD0F0
	[RequiredMember]
	public string Montage { get; set; }

	// Token: 0x17002A0A RID: 10762
	// (get) Token: 0x06019F53 RID: 106323 RVA: 0x007FEEF9 File Offset: 0x007FD0F9
	// (set) Token: 0x06019F54 RID: 106324 RVA: 0x007FEF01 File Offset: 0x007FD101
	[RequiredMember]
	public string AdditiveMontage { get; set; }

	// Token: 0x06019F55 RID: 106325 RVA: 0x007FEF0A File Offset: 0x007FD10A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VehicleEnterExitMontage()
	{
	}
}
