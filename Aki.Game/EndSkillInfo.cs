using System;
using Aki.Protocol;

// Token: 0x02003149 RID: 12617
public class EndSkillInfo
{
	// Token: 0x0601B268 RID: 111208 RVA: 0x00762C6E File Offset: 0x00760E6E
	public void Reset()
	{
		this.Reason = EEndSkillReason.Default;
		this.EntityId = 0L;
		this.SkillId = 0;
		this.BulletId = 0L;
	}

	// Token: 0x0400D32D RID: 54061
	public EEndSkillReason Reason;

	// Token: 0x0400D32E RID: 54062
	public long EntityId;

	// Token: 0x0400D32F RID: 54063
	public int SkillId;

	// Token: 0x0400D330 RID: 54064
	public long BulletId;
}
