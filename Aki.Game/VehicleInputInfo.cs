using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030CD RID: 12493
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class VehicleInputInfo : IVehicleInputInfo
{
	// Token: 0x170024BB RID: 9403
	// (get) Token: 0x0601AC04 RID: 109572 RVA: 0x00735B1C File Offset: 0x00733D1C
	// (set) Token: 0x0601AC05 RID: 109573 RVA: 0x00735B24 File Offset: 0x00733D24
	[RequiredMember]
	public string InputClassPath { get; set; }

	// Token: 0x170024BC RID: 9404
	// (get) Token: 0x0601AC06 RID: 109574 RVA: 0x00735B2D File Offset: 0x00733D2D
	// (set) Token: 0x0601AC07 RID: 109575 RVA: 0x00735B35 File Offset: 0x00733D35
	[RequiredMember]
	public ABaseCharacter Owner { get; set; }

	// Token: 0x0601AC08 RID: 109576 RVA: 0x00735B3E File Offset: 0x00733D3E
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public VehicleInputInfo()
	{
	}
}
