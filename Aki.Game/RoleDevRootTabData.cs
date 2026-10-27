using System;
using System.Runtime.CompilerServices;

// Token: 0x020027DE RID: 10206
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRootTabData : IRoleDevRootTabData
{
	// Token: 0x17001B5E RID: 7006
	// (get) Token: 0x06014F58 RID: 85848 RVA: 0x005510F2 File Offset: 0x0054F2F2
	// (set) Token: 0x06014F59 RID: 85849 RVA: 0x005510FA File Offset: 0x0054F2FA
	public ERoleDevTabType TabIndex { get; set; }

	// Token: 0x17001B5F RID: 7007
	// (get) Token: 0x06014F5A RID: 85850 RVA: 0x00551103 File Offset: 0x0054F303
	// (set) Token: 0x06014F5B RID: 85851 RVA: 0x0055110B File Offset: 0x0054F30B
	public string TabName { get; set; }

	// Token: 0x17001B60 RID: 7008
	// (get) Token: 0x06014F5C RID: 85852 RVA: 0x00551114 File Offset: 0x0054F314
	// (set) Token: 0x06014F5D RID: 85853 RVA: 0x0055111C File Offset: 0x0054F31C
	public bool TabIsUpgrade { get; set; }

	// Token: 0x17001B61 RID: 7009
	// (get) Token: 0x06014F5E RID: 85854 RVA: 0x00551125 File Offset: 0x0054F325
	// (set) Token: 0x06014F5F RID: 85855 RVA: 0x0055112D File Offset: 0x0054F32D
	public bool TabIsFinish { get; set; }
}
