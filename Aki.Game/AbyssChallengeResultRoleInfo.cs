using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED1 RID: 3793
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultRoleInfo
{
	// Token: 0x060097FB RID: 38907 RVA: 0x002D0D2C File Offset: 0x002CEF2C
	public int GetRoleSkinId()
	{
		return this.RoleSkinId;
	}

	// Token: 0x060097FC RID: 38908 RVA: 0x002D0D34 File Offset: 0x002CEF34
	public int GetRoleLevel()
	{
		return this.RoleLevel;
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x002D0D3C File Offset: 0x002CEF3C
	public int GetDangoId()
	{
		return this.DangoId;
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x002D0D44 File Offset: 0x002CEF44
	[NullableContext(2)]
	public global::AbyssChallengeRoleHonor GetMainHonor()
	{
		return this.MainHonor;
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x002D0D4C File Offset: 0x002CEF4C
	public global::AbyssChallengeRoleHonor[] GetSubHonor()
	{
		return this.SubHonor;
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x002D0D54 File Offset: 0x002CEF54
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

	// Token: 0x04005B2A RID: 23338
	private int RoleSkinId;

	// Token: 0x04005B2B RID: 23339
	private int RoleLevel;

	// Token: 0x04005B2C RID: 23340
	private int DangoId;

	// Token: 0x04005B2D RID: 23341
	[Nullable(2)]
	private global::AbyssChallengeRoleHonor MainHonor;

	// Token: 0x04005B2E RID: 23342
	private global::AbyssChallengeRoleHonor[] SubHonor = Array.Empty<global::AbyssChallengeRoleHonor>();
}
