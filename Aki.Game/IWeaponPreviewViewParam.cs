using System;
using System.Runtime.CompilerServices;

// Token: 0x02002267 RID: 8807
[NullableContext(1)]
public interface IWeaponPreviewViewParam
{
	// Token: 0x1700210A RID: 8458
	// (get) Token: 0x06015C80 RID: 89216
	// (set) Token: 0x06015C81 RID: 89217
	WeaponDataBase[] WeaponDataList { get; set; }

	// Token: 0x1700210B RID: 8459
	// (get) Token: 0x06015C82 RID: 89218
	// (set) Token: 0x06015C83 RID: 89219
	int SelectedIndex { get; set; }

	// Token: 0x1700210C RID: 8460
	// (get) Token: 0x06015C84 RID: 89220
	// (set) Token: 0x06015C85 RID: 89221
	[Nullable(2)]
	WeaponSkeletalObserverHandles WeaponObservers { [NullableContext(2)] get; [NullableContext(2)] set; }
}
