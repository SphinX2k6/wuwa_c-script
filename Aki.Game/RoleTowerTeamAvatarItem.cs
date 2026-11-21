using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CE7 RID: 7399
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerTeamAvatarItem : GridProxyAbstract<RoleTowerTeamAvatarData>
{
	// Token: 0x0601250E RID: 75022 RVA: 0x00567252 File Offset: 0x00565452
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0601250F RID: 75023 RVA: 0x00567278 File Offset: 0x00565478
	[NullableContext(1)]
	public override void Refresh(RoleTowerTeamAvatarData data, bool isSelected, int gridIndex)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data.RoleId);
		if (roleConfig == null)
		{
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, data.RoleId, null, null);
	}

	// Token: 0x02007FEE RID: 32750
	private static class EChildType
	{
		// Token: 0x0402963C RID: 169532
		public const int TexRoleHead = 1;
	}
}
