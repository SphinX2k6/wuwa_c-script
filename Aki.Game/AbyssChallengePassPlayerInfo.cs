using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A19 RID: 6681
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengePassPlayerInfo
{
	// Token: 0x0600C427 RID: 50215 RVA: 0x002C6B34 File Offset: 0x002C4D34
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x0600C428 RID: 50216 RVA: 0x002C6B3C File Offset: 0x002C4D3C
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0600C429 RID: 50217 RVA: 0x002C6B44 File Offset: 0x002C4D44
	public AbyssChallengePassRoleInfo[] GetPassRoleInfoList()
	{
		return this.PassRoleInfoList;
	}

	// Token: 0x0600C42A RID: 50218 RVA: 0x002C6B4C File Offset: 0x002C4D4C
	public void Phrase(Aki.Protocol.AbyssChallengePassPlayerInfo data)
	{
		this.Name = data.Name;
		this.PlayerId = data.PlayerId;
		this.PassRoleInfoList = Array.Empty<AbyssChallengePassRoleInfo>();
		List<AbyssChallengePassRoleInfo> list = new List<AbyssChallengePassRoleInfo>();
		int count = data.RoleInfos.Count;
		for (int i = 0; i < count; i++)
		{
			AbyssChallengePassRoleInfo abyssChallengePassRoleInfo = new AbyssChallengePassRoleInfo();
			abyssChallengePassRoleInfo.Phrase(data.RoleInfos[i]);
			list.Add(abyssChallengePassRoleInfo);
		}
		this.PassRoleInfoList = list.ToArray();
	}

	// Token: 0x04005A80 RID: 23168
	private string Name = "";

	// Token: 0x04005A81 RID: 23169
	private int PlayerId;

	// Token: 0x04005A82 RID: 23170
	private AbyssChallengePassRoleInfo[] PassRoleInfoList = Array.Empty<AbyssChallengePassRoleInfo>();
}
