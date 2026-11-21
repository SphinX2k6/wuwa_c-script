using System;
using System.Runtime.CompilerServices;

// Token: 0x02002268 RID: 8808
[NullableContext(1)]
[Nullable(0)]
public class WeaponPreviewViewParam : IWeaponPreviewViewParam
{
	// Token: 0x1700210D RID: 8461
	// (get) Token: 0x06015C86 RID: 89222 RVA: 0x00651750 File Offset: 0x0064F950
	// (set) Token: 0x06015C87 RID: 89223 RVA: 0x00651758 File Offset: 0x0064F958
	public WeaponDataBase[] WeaponDataList { get; set; }

	// Token: 0x1700210E RID: 8462
	// (get) Token: 0x06015C88 RID: 89224 RVA: 0x00651761 File Offset: 0x0064F961
	// (set) Token: 0x06015C89 RID: 89225 RVA: 0x00651769 File Offset: 0x0064F969
	public int SelectedIndex { get; set; }

	// Token: 0x1700210F RID: 8463
	// (get) Token: 0x06015C8A RID: 89226 RVA: 0x00651772 File Offset: 0x0064F972
	// (set) Token: 0x06015C8B RID: 89227 RVA: 0x0065177A File Offset: 0x0064F97A
	[Nullable(2)]
	public WeaponSkeletalObserverHandles WeaponObservers { [NullableContext(2)] get; [NullableContext(2)] set; }
}
