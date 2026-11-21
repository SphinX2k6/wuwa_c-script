using System;
using System.Runtime.CompilerServices;

// Token: 0x0200275C RID: 10076
[NullableContext(1)]
public interface INpcInterestLookAtParam
{
	// Token: 0x1700285E RID: 10334
	// (get) Token: 0x060194BD RID: 103613
	// (set) Token: 0x060194BE RID: 103614
	int TargetPbDataId { get; set; }

	// Token: 0x1700285F RID: 10335
	// (get) Token: 0x060194BF RID: 103615
	// (set) Token: 0x060194C0 RID: 103616
	Vector TargetPosition { get; set; }

	// Token: 0x17002860 RID: 10336
	// (get) Token: 0x060194C1 RID: 103617
	// (set) Token: 0x060194C2 RID: 103618
	float MaxAngle { get; set; }

	// Token: 0x17002861 RID: 10337
	// (get) Token: 0x060194C3 RID: 103619
	// (set) Token: 0x060194C4 RID: 103620
	float MaxDistance { get; set; }
}
