using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A11 RID: 6673
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultPlayerInfo
{
	// Token: 0x0600C3E5 RID: 50149 RVA: 0x002C5C24 File Offset: 0x002C3E24
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0600C3E6 RID: 50150 RVA: 0x002C5C2C File Offset: 0x002C3E2C
	public int GetLikeCount()
	{
		return this.LikeCount;
	}

	// Token: 0x0600C3E7 RID: 50151 RVA: 0x002C5C34 File Offset: 0x002C3E34
	public global::AbyssChallengeResultRoleInfo[] GetRoleInfo()
	{
		return this.RoleInfo;
	}

	// Token: 0x0600C3E8 RID: 50152 RVA: 0x002C5C3C File Offset: 0x002C3E3C
	public void SetLikeCount(int count)
	{
		this.LikeCount = count;
	}

	// Token: 0x0600C3E9 RID: 50153 RVA: 0x002C5C48 File Offset: 0x002C3E48
	public void Phrase(Aki.Protocol.AbyssChallengeResultPlayerInfo data)
	{
		this.PlayerId = data.PlayerId;
		this.LikeCount = data.LikeCount;
		this.RoleInfo = Array.Empty<global::AbyssChallengeResultRoleInfo>();
		List<global::AbyssChallengeResultRoleInfo> list = new List<global::AbyssChallengeResultRoleInfo>();
		int count = data.RoleInfos.Count;
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengeResultRoleInfo abyssChallengeResultRoleInfo = new global::AbyssChallengeResultRoleInfo();
			abyssChallengeResultRoleInfo.Phrase(data.RoleInfos[i]);
			list.Add(abyssChallengeResultRoleInfo);
		}
		this.RoleInfo = list.ToArray();
	}

	// Token: 0x04005A58 RID: 23128
	private int PlayerId;

	// Token: 0x04005A59 RID: 23129
	private int LikeCount;

	// Token: 0x04005A5A RID: 23130
	private global::AbyssChallengeResultRoleInfo[] RoleInfo = Array.Empty<global::AbyssChallengeResultRoleInfo>();
}
