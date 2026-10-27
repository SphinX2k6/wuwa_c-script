using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030CC RID: 12492
[NullableContext(1)]
public interface IVehicleInputInfo
{
	// Token: 0x170024B9 RID: 9401
	// (get) Token: 0x0601AC00 RID: 109568
	// (set) Token: 0x0601AC01 RID: 109569
	string InputClassPath { get; set; }

	// Token: 0x170024BA RID: 9402
	// (get) Token: 0x0601AC02 RID: 109570
	// (set) Token: 0x0601AC03 RID: 109571
	ABaseCharacter Owner { get; set; }
}
