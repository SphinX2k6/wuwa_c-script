using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED2 RID: 3794
public class AbyssChallengeRoleHonor
{
	// Token: 0x06009802 RID: 38914 RVA: 0x002D0E08 File Offset: 0x002CF008
	public new int GetType()
	{
		return this.Type;
	}

	// Token: 0x06009803 RID: 38915 RVA: 0x002D0E10 File Offset: 0x002CF010
	public int GetValue()
	{
		return this.Value;
	}

	// Token: 0x06009804 RID: 38916 RVA: 0x002D0E18 File Offset: 0x002CF018
	[NullableContext(2)]
	public void Phrase(Aki.Protocol.AbyssChallengeRoleHonor data)
	{
		if (data == null)
		{
			return;
		}
		this.Type = data.Type;
		this.Value = data.Value;
	}

	// Token: 0x04005B2F RID: 23343
	private int Type;

	// Token: 0x04005B30 RID: 23344
	private int Value;
}
