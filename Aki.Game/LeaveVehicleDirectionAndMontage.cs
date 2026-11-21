using System;
using System.Runtime.CompilerServices;

// Token: 0x02002762 RID: 10082
[RequiredMember]
public class LeaveVehicleDirectionAndMontage
{
	// Token: 0x060194EC RID: 103660 RVA: 0x007BB056 File Offset: 0x007B9256
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public LeaveVehicleDirectionAndMontage()
	{
	}

	// Token: 0x0400DD77 RID: 56695
	[RequiredMember]
	public CommonNpcPerformComponent.EEnterVehicleDirection Direction;

	// Token: 0x0400DD78 RID: 56696
	[Nullable(1)]
	[RequiredMember]
	public string Montage;
}
