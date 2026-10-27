using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D0E RID: 11534
[NullableContext(1)]
[Nullable(0)]
public class WeaponPreviewViewParam : IWeaponPreviewViewParam
{
	// Token: 0x170020B2 RID: 8370
	// (get) Token: 0x060183E5 RID: 99301 RVA: 0x0062B758 File Offset: 0x00629958
	// (set) Token: 0x060183E6 RID: 99302 RVA: 0x0062B760 File Offset: 0x00629960
	public WeaponDataBase[] WeaponDataList { get; set; }

	// Token: 0x170020B3 RID: 8371
	// (get) Token: 0x060183E7 RID: 99303 RVA: 0x0062B769 File Offset: 0x00629969
	// (set) Token: 0x060183E8 RID: 99304 RVA: 0x0062B771 File Offset: 0x00629971
	public int SelectedIndex { get; set; }

	// Token: 0x170020B4 RID: 8372
	// (get) Token: 0x060183E9 RID: 99305 RVA: 0x0062B77A File Offset: 0x0062997A
	// (set) Token: 0x060183EA RID: 99306 RVA: 0x0062B782 File Offset: 0x00629982
	[Nullable(2)]
	public WeaponSkeletalObserverHandles WeaponObservers { [NullableContext(2)] get; [NullableContext(2)] set; }
}
