using System;
using System.Runtime.CompilerServices;

// Token: 0x0200177B RID: 6011
[NullableContext(2)]
public interface IMotorcycleDiyEditTabViewRegister : IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001646 RID: 5702
	// (get) Token: 0x0600E8F7 RID: 59639
	// (set) Token: 0x0600E8F8 RID: 59640
	Func<MotorcycleDiyPresetData> GetLocalPresetData { get; set; }

	// Token: 0x17001647 RID: 5703
	// (get) Token: 0x0600E8F9 RID: 59641
	// (set) Token: 0x0600E8FA RID: 59642
	Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
