using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ED3 RID: 3795
[NullableContext(1)]
[Nullable(0)]
public class AbyssFormationInfo
{
	// Token: 0x06009806 RID: 38918 RVA: 0x002D0E40 File Offset: 0x002CF040
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

	// Token: 0x04005B31 RID: 23345
	private AbyssFormationRoleSelectInfo[] RoleInfoList = Array.Empty<AbyssFormationRoleSelectInfo>();
}
