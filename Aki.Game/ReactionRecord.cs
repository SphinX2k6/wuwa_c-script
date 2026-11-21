using System;

// Token: 0x02001596 RID: 5526
public class ReactionRecord
{
	// Token: 0x0600DCEE RID: 56558 RVA: 0x00416990 File Offset: 0x00414B90
	public ReactionRecord(int roleId, int reactionNumber)
	{
		this.role_id = roleId;
		this.reaction = reactionNumber;
	}

	// Token: 0x04007BCD RID: 31693
	public int role_id;

	// Token: 0x04007BCE RID: 31694
	public int reaction;

	// Token: 0x04007BCF RID: 31695
	public int trigger_count;

	// Token: 0x04007BD0 RID: 31696
	public int damage;
}
