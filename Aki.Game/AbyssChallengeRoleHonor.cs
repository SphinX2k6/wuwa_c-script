using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A13 RID: 6675
public class AbyssChallengeRoleHonor
{
	// Token: 0x0600C3F2 RID: 50162 RVA: 0x002C5DB0 File Offset: 0x002C3FB0
	public new int GetType()
	{
		return this.Type;
	}

	// Token: 0x0600C3F3 RID: 50163 RVA: 0x002C5DB8 File Offset: 0x002C3FB8
	public int GetValue()
	{
		return this.Value;
	}

	// Token: 0x0600C3F4 RID: 50164 RVA: 0x002C5DC0 File Offset: 0x002C3FC0
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

	// Token: 0x04005A60 RID: 23136
	private int Type;

	// Token: 0x04005A61 RID: 23137
	private int Value;
}
