using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E8F RID: 11919
[NullableContext(1)]
[Nullable(0)]
public class BuffModifierData : IBuffModifierData
{
	// Token: 0x17002325 RID: 8997
	// (get) Token: 0x060197B4 RID: 104372 RVA: 0x00694155 File Offset: 0x00692355
	// (set) Token: 0x060197B5 RID: 104373 RVA: 0x0069415D File Offset: 0x0069235D
	public EAttributeType AttributeId { get; set; }

	// Token: 0x17002326 RID: 8998
	// (get) Token: 0x060197B6 RID: 104374 RVA: 0x00694166 File Offset: 0x00692366
	// (set) Token: 0x060197B7 RID: 104375 RVA: 0x0069416E File Offset: 0x0069236E
	public float[] Value1 { get; set; } = Array.Empty<float>();

	// Token: 0x17002327 RID: 8999
	// (get) Token: 0x060197B8 RID: 104376 RVA: 0x00694177 File Offset: 0x00692377
	// (set) Token: 0x060197B9 RID: 104377 RVA: 0x0069417F File Offset: 0x0069237F
	public float[] Value2 { get; set; } = Array.Empty<float>();

	// Token: 0x17002328 RID: 9000
	// (get) Token: 0x060197BA RID: 104378 RVA: 0x00694188 File Offset: 0x00692388
	// (set) Token: 0x060197BB RID: 104379 RVA: 0x00694190 File Offset: 0x00692390
	public int[] CalculationPolicy { get; set; } = Array.Empty<int>();
}
