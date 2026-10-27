using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A14 RID: 6676
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationInfo
{
	// Token: 0x0600C3F6 RID: 50166 RVA: 0x002C5DE8 File Offset: 0x002C3FE8
	public void Phrase(AbyssRoleSelectUpdateNotify data)
	{
		this.RoleInfoList = Array.Empty<AbyssFormationRoleSelectInfo>();
		List<AbyssFormationRoleSelectInfo> list = new List<AbyssFormationRoleSelectInfo>();
		int count = data.PlayerInfos.Count;
		for (int i = 0; i < count; i++)
		{
			AbyssFormationRoleSelectInfo abyssFormationRoleSelectInfo = new AbyssFormationRoleSelectInfo();
			abyssFormationRoleSelectInfo.Phrase(data.PlayerInfos[i]);
			list.Add(abyssFormationRoleSelectInfo);
		}
		this.RoleInfoList = list.ToArray();
	}

	// Token: 0x04005A62 RID: 23138
	private AbyssFormationRoleSelectInfo[] RoleInfoList = Array.Empty<AbyssFormationRoleSelectInfo>();
}
