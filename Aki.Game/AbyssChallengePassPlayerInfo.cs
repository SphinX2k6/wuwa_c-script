using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED8 RID: 3800
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengePassPlayerInfo
{
	// Token: 0x06009837 RID: 38967 RVA: 0x002D1BB8 File Offset: 0x002CFDB8
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x06009838 RID: 38968 RVA: 0x002D1BC0 File Offset: 0x002CFDC0
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06009839 RID: 38969 RVA: 0x002D1BC8 File Offset: 0x002CFDC8
	public AbyssChallengePassRoleInfo[] GetPassRoleInfoList()
	{
		return this.PassRoleInfoList;
	}

	// Token: 0x0600983A RID: 38970 RVA: 0x002D1BD0 File Offset: 0x002CFDD0
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

	// Token: 0x04005B4F RID: 23375
	private string Name = "";

	// Token: 0x04005B50 RID: 23376
	private int PlayerId;

	// Token: 0x04005B51 RID: 23377
	private AbyssChallengePassRoleInfo[] PassRoleInfoList = Array.Empty<AbyssChallengePassRoleInfo>();
}
