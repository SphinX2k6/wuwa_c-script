using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023E1 RID: 9185
[NullableContext(1)]
[Nullable(0)]
public class BuffModifierData : IBuffModifierData
{
	// Token: 0x170023B0 RID: 9136
	// (get) Token: 0x0601708A RID: 94346 RVA: 0x006BA511 File Offset: 0x006B8711
	// (set) Token: 0x0601708B RID: 94347 RVA: 0x006BA519 File Offset: 0x006B8719
	public EAttributeType AttributeId { get; set; }

	// Token: 0x170023B1 RID: 9137
	// (get) Token: 0x0601708C RID: 94348 RVA: 0x006BA522 File Offset: 0x006B8722
	// (set) Token: 0x0601708D RID: 94349 RVA: 0x006BA52A File Offset: 0x006B872A
	public float[] Value1 { get; set; } = Array.Empty<float>();

	// Token: 0x170023B2 RID: 9138
	// (get) Token: 0x0601708E RID: 94350 RVA: 0x006BA533 File Offset: 0x006B8733
	// (set) Token: 0x0601708F RID: 94351 RVA: 0x006BA53B File Offset: 0x006B873B
	public float[] Value2 { get; set; } = Array.Empty<float>();

	// Token: 0x170023B3 RID: 9139
	// (get) Token: 0x06017090 RID: 94352 RVA: 0x006BA544 File Offset: 0x006B8744
	// (set) Token: 0x06017091 RID: 94353 RVA: 0x006BA54C File Offset: 0x006B874C
	public int[] CalculationPolicy { get; set; } = Array.Empty<int>();
}
