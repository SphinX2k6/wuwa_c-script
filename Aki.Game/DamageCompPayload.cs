using System;
using System.Runtime.CompilerServices;

// Token: 0x020023BF RID: 9151
[NullableContext(2)]
[Nullable(0)]
public class DamageCompPayload
{
	// Token: 0x1700235B RID: 9051
	// (get) Token: 0x06016F1E RID: 93982 RVA: 0x006B3053 File Offset: 0x006B1253
	// (set) Token: 0x06016F1F RID: 93983 RVA: 0x006B305B File Offset: 0x006B125B
	public BaseDamageComponent Target { get; set; }

	// Token: 0x1700235C RID: 9052
	// (get) Token: 0x06016F20 RID: 93984 RVA: 0x006B3064 File Offset: 0x006B1264
	// (set) Token: 0x06016F21 RID: 93985 RVA: 0x006B306C File Offset: 0x006B126C
	public BaseDamageComponent Attacker { get; set; }
}
