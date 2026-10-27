using System;
using System.Runtime.CompilerServices;

// Token: 0x020032C0 RID: 12992
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VehicleEnterExitMontage : IVehicleEnterExitMontage
{
	// Token: 0x1700271D RID: 10013
	// (get) Token: 0x0601C30E RID: 115470 RVA: 0x007D7D60 File Offset: 0x007D5F60
	// (set) Token: 0x0601C30F RID: 115471 RVA: 0x007D7D68 File Offset: 0x007D5F68
	[RequiredMember]
	public string Montage { get; set; }

	// Token: 0x1700271E RID: 10014
	// (get) Token: 0x0601C310 RID: 115472 RVA: 0x007D7D71 File Offset: 0x007D5F71
	// (set) Token: 0x0601C311 RID: 115473 RVA: 0x007D7D79 File Offset: 0x007D5F79
	[RequiredMember]
	public string AdditiveMontage { get; set; }

	// Token: 0x0601C312 RID: 115474 RVA: 0x007D7D82 File Offset: 0x007D5F82
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VehicleEnterExitMontage()
	{
	}
}
