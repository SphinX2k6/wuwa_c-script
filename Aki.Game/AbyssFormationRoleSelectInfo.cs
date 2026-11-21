using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED4 RID: 3796
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationRoleSelectInfo
{
	// Token: 0x06009808 RID: 38920 RVA: 0x002D0EB4 File Offset: 0x002CF0B4
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x002D0EBC File Offset: 0x002CF0BC
	public AbyssFormationRoleSelectDetailInfo[] GetRoleSelectDetailInfoList()
	{
		return this.RoleSelectDetailInfoList;
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x002D0EC4 File Offset: 0x002CF0C4
	public void Phrase(AbyssRoleSelectInfo data)
	{
		this.PlayerId = data.PlayerId;
		this.RoleSelectDetailInfoList = Array.Empty<AbyssFormationRoleSelectDetailInfo>();
		List<AbyssFormationRoleSelectDetailInfo> list = new List<AbyssFormationRoleSelectDetailInfo>();
		int count = data.RoleInfos.Count;
		for (int i = 0; i < count; i++)
		{
			AbyssFormationRoleSelectDetailInfo abyssFormationRoleSelectDetailInfo = new AbyssFormationRoleSelectDetailInfo();
			abyssFormationRoleSelectDetailInfo.Phrase(data.RoleInfos[i]);
			list.Add(abyssFormationRoleSelectDetailInfo);
		}
		this.RoleSelectDetailInfoList = list.ToArray();
	}

	// Token: 0x04005B32 RID: 23346
	private int PlayerId;

	// Token: 0x04005B33 RID: 23347
	private AbyssFormationRoleSelectDetailInfo[] RoleSelectDetailInfoList = Array.Empty<AbyssFormationRoleSelectDetailInfo>();
}
