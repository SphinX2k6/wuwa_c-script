using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002624 RID: 9764
[NullableContext(1)]
public interface IVehicleInputInfo
{
	// Token: 0x1700263C RID: 9788
	// (get) Token: 0x06018615 RID: 99861
	// (set) Token: 0x06018616 RID: 99862
	string InputClassPath { get; set; }

	// Token: 0x1700263D RID: 9789
	// (get) Token: 0x06018617 RID: 99863
	// (set) Token: 0x06018618 RID: 99864
	ABaseCharacter Owner { get; set; }
}
