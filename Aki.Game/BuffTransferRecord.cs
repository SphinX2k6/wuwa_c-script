using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F26 RID: 12070
[NullableContext(1)]
[Nullable(0)]
public class BuffTransferRecord
{
	// Token: 0x0400C1C8 RID: 49608
	public long BulletMessageId;

	// Token: 0x0400C1C9 RID: 49609
	public long RecordSkillMessageId;

	// Token: 0x0400C1CA RID: 49610
	public long TargetSkillMessageId;

	// Token: 0x0400C1CB RID: 49611
	public HashSet<int> TransferEntity = new HashSet<int>();

	// Token: 0x0400C1CC RID: 49612
	public int[] BuffStack = Array.Empty<int>();

	// Token: 0x0400C1CD RID: 49613
	public bool IsAbnormalDamage;

	// Token: 0x0400C1CE RID: 49614
	public int VictimEntityId;
}
