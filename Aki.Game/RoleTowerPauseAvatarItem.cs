using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CE1 RID: 7393
public class RoleTowerPauseAvatarItem : GridProxyAbstract<int>
{
	// Token: 0x060124CA RID: 74954 RVA: 0x00565948 File Offset: 0x00563B48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x060124CB RID: 74955 RVA: 0x0056596C File Offset: 0x00563B6C
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		UUITexture texture = base.GetTexture(1);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (texture != null && roleConfig != null)
		{
			texture.SetUIActive(true);
			base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, roleId, null, null);
		}
	}

	// Token: 0x060124CC RID: 74956 RVA: 0x005659C1 File Offset: 0x00563BC1
	[NullableContext(1)]
	public override object GetKey(int roleId, int displayIndex)
	{
		return roleId;
	}

	// Token: 0x02007FDF RID: 32735
	private static class EChildType
	{
		// Token: 0x040295E9 RID: 169449
		public const int TexAvatar = 1;
	}
}
