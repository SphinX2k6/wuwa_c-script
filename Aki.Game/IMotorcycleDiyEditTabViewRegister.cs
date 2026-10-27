using System;
using System.Runtime.CompilerServices;

// Token: 0x02002297 RID: 8855
[NullableContext(2)]
public interface IMotorcycleDiyEditTabViewRegister : IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700160F RID: 5647
	// (get) Token: 0x06011461 RID: 70753
	// (set) Token: 0x06011462 RID: 70754
	Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x17001610 RID: 5648
	// (get) Token: 0x06011463 RID: 70755
	// (set) Token: 0x06011464 RID: 70756
	Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
