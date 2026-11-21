using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002625 RID: 9765
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VehicleInputInfo : IVehicleInputInfo
{
	// Token: 0x1700263E RID: 9790
	// (get) Token: 0x06018619 RID: 99865 RVA: 0x0075B802 File Offset: 0x00759A02
	// (set) Token: 0x0601861A RID: 99866 RVA: 0x0075B80A File Offset: 0x00759A0A
	[RequiredMember]
	public string InputClassPath { get; set; }

	// Token: 0x1700263F RID: 9791
	// (get) Token: 0x0601861B RID: 99867 RVA: 0x0075B813 File Offset: 0x00759A13
	// (set) Token: 0x0601861C RID: 99868 RVA: 0x0075B81B File Offset: 0x00759A1B
	[RequiredMember]
	public ABaseCharacter Owner { get; set; }

	// Token: 0x0601861D RID: 99869 RVA: 0x0075B824 File Offset: 0x00759A24
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VehicleInputInfo()
	{
	}
}
