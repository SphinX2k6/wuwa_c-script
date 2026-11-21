using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED0 RID: 3792
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultPlayerInfo
{
	// Token: 0x060097F5 RID: 38901 RVA: 0x002D0C7C File Offset: 0x002CEE7C
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x060097F6 RID: 38902 RVA: 0x002D0C84 File Offset: 0x002CEE84
	public int GetLikeCount()
	{
		return this.LikeCount;
	}

	// Token: 0x060097F7 RID: 38903 RVA: 0x002D0C8C File Offset: 0x002CEE8C
	public global::AbyssChallengeResultRoleInfo[] GetRoleInfo()
	{
		return this.RoleInfo;
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x002D0C94 File Offset: 0x002CEE94
	public void SetLikeCount(int count)
	{
		this.LikeCount = count;
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x002D0CA0 File Offset: 0x002CEEA0
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

	// Token: 0x04005B27 RID: 23335
	private int PlayerId;

	// Token: 0x04005B28 RID: 23336
	private int LikeCount;

	// Token: 0x04005B29 RID: 23337
	private global::AbyssChallengeResultRoleInfo[] RoleInfo = Array.Empty<global::AbyssChallengeResultRoleInfo>();
}
