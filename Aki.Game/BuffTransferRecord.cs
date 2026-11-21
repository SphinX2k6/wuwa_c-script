using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002479 RID: 9337
[NullableContext(1)]
[Nullable(0)]
public class BuffTransferRecord
{
	// Token: 0x0400C56A RID: 50538
	public long BulletMessageId;

	// Token: 0x0400C56B RID: 50539
	public long RecordSkillMessageId;

	// Token: 0x0400C56C RID: 50540
	public long TargetSkillMessageId;

	// Token: 0x0400C56D RID: 50541
	public HashSet<int> TransferEntity = new HashSet<int>();

	// Token: 0x0400C56E RID: 50542
	public int[] BuffStack = Array.Empty<int>();

	// Token: 0x0400C56F RID: 50543
	public bool IsAbnormalDamage;

	// Token: 0x0400C570 RID: 50544
	public int VictimEntityId;
}
