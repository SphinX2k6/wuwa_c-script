using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A15 RID: 6677
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationRoleSelectInfo
{
	// Token: 0x0600C3F8 RID: 50168 RVA: 0x002C5E5C File Offset: 0x002C405C
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0600C3F9 RID: 50169 RVA: 0x002C5E64 File Offset: 0x002C4064
	public AbyssFormationRoleSelectDetailInfo[] GetRoleSelectDetailInfoList()
	{
		return this.RoleSelectDetailInfoList;
	}

	// Token: 0x0600C3FA RID: 50170 RVA: 0x002C5E6C File Offset: 0x002C406C
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

	// Token: 0x04005A63 RID: 23139
	private int PlayerId;

	// Token: 0x04005A64 RID: 23140
	private AbyssFormationRoleSelectDetailInfo[] RoleSelectDetailInfoList = Array.Empty<AbyssFormationRoleSelectDetailInfo>();
}
