using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D0D RID: 11533
[NullableContext(1)]
public interface IWeaponPreviewViewParam
{
	// Token: 0x170020AF RID: 8367
	// (get) Token: 0x060183DF RID: 99295
	// (set) Token: 0x060183E0 RID: 99296
	WeaponDataBase[] WeaponDataList { get; set; }

	// Token: 0x170020B0 RID: 8368
	// (get) Token: 0x060183E1 RID: 99297
	// (set) Token: 0x060183E2 RID: 99298
	int SelectedIndex { get; set; }

	// Token: 0x170020B1 RID: 8369
	// (get) Token: 0x060183E3 RID: 99299
	// (set) Token: 0x060183E4 RID: 99300
	[Nullable(2)]
	WeaponSkeletalObserverHandles WeaponObservers { [NullableContext(2)] get; [NullableContext(2)] set; }
}
