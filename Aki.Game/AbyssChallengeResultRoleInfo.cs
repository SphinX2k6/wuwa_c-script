using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A12 RID: 6674
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultRoleInfo
{
	// Token: 0x0600C3EB RID: 50155 RVA: 0x002C5CD4 File Offset: 0x002C3ED4
	public int GetRoleSkinId()
	{
		return this.RoleSkinId;
	}

	// Token: 0x0600C3EC RID: 50156 RVA: 0x002C5CDC File Offset: 0x002C3EDC
	public int GetRoleLevel()
	{
		return this.RoleLevel;
	}

	// Token: 0x0600C3ED RID: 50157 RVA: 0x002C5CE4 File Offset: 0x002C3EE4
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x0600C3EE RID: 50158 RVA: 0x002C5CEC File Offset: 0x002C3EEC
	[NullableContext(2)]
	public global::AbyssChallengeRoleHonor GetMainHonor()
	{
		return this.MainHonor;
	}

	// Token: 0x0600C3EF RID: 50159 RVA: 0x002C5CF4 File Offset: 0x002C3EF4
	public global::AbyssChallengeRoleHonor[] GetSubHonor()
	{
		return this.SubHonor;
	}

	// Token: 0x0600C3F0 RID: 50160 RVA: 0x002C5CFC File Offset: 0x002C3EFC
	public void Phrase(Aki.Protocol.AbyssChallengeResultRoleInfo data)
	{
		this.RoleSkinId = data.RoleSkinId;
		this.RoleLevel = data.RoleLevel;
		this.DangoId = data.LittleRoleId;
		this.MainHonor = new global::AbyssChallengeRoleHonor();
		this.MainHonor.Phrase(data.MainHonor);
		this.SubHonor = Array.Empty<global::AbyssChallengeRoleHonor>();
		List<global::AbyssChallengeRoleHonor> list = new List<global::AbyssChallengeRoleHonor>();
		int count = data.OtherHonor.Count;
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengeRoleHonor abyssChallengeRoleHonor = new global::AbyssChallengeRoleHonor();
			abyssChallengeRoleHonor.Phrase(data.OtherHonor[i]);
			list.Add(abyssChallengeRoleHonor);
		}
		this.SubHonor = list.ToArray();
	}

	// Token: 0x04005A5B RID: 23131
	private int RoleSkinId;

	// Token: 0x04005A5C RID: 23132
	private int RoleLevel;

	// Token: 0x04005A5D RID: 23133
	private int DangoId;

	// Token: 0x04005A5E RID: 23134
	[Nullable(2)]
	private global::AbyssChallengeRoleHonor MainHonor;

	// Token: 0x04005A5F RID: 23135
	private global::AbyssChallengeRoleHonor[] SubHonor = Array.Empty<global::AbyssChallengeRoleHonor>();
}
