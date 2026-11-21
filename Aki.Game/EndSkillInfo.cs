using System;
using Aki.Protocol;

// Token: 0x020026AB RID: 9899
public class EndSkillInfo
{
	// Token: 0x06018D19 RID: 101657 RVA: 0x0078957C File Offset: 0x0078777C
	public void Reset()
	{
		this.Reason = EEndSkillReason.Default;
		this.EntityId = 0L;
		this.SkillId = 0;
		this.BulletId = 0L;
	}

	// Token: 0x0400D76E RID: 55150
	public EEndSkillReason Reason;

	// Token: 0x0400D76F RID: 55151
	public long EntityId;

	// Token: 0x0400D770 RID: 55152
	public int SkillId;

	// Token: 0x0400D771 RID: 55153
	public long BulletId;
}
