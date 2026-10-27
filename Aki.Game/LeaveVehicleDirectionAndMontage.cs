using System;
using System.Runtime.CompilerServices;

// Token: 0x020031F3 RID: 12787
[RequiredMember]
public class LeaveVehicleDirectionAndMontage
{
	// Token: 0x0601B967 RID: 112999 RVA: 0x0079292A File Offset: 0x00790B2A
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public LeaveVehicleDirectionAndMontage()
	{
	}

	// Token: 0x0400D8D9 RID: 55513
	[RequiredMember]
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400D8DA RID: 55514
	[Nullable(1)]
	[RequiredMember]
	public string Montage;
}
