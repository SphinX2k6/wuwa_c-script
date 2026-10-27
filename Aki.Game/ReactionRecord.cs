using System;

// Token: 0x020020BF RID: 8383
public class ReactionRecord
{
	// Token: 0x0601087E RID: 67710 RVA: 0x0040A288 File Offset: 0x00408488
	public ReactionRecord(int roleId, int reactionNumber)
	{
		this.role_id = roleId;
		this.reaction = reactionNumber;
	}

	// Token: 0x04007ACF RID: 31439
	public int role_id;

	// Token: 0x04007AD0 RID: 31440
	public int reaction;

	// Token: 0x04007AD1 RID: 31441
	public int trigger_count;

	// Token: 0x04007AD2 RID: 31442
	public int damage;
}
