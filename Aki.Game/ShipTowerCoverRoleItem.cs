using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029A5 RID: 10661
public class ShipTowerCoverRoleItem : GridProxyAbstract<int>
{
	// Token: 0x060161A6 RID: 90534 RVA: 0x00596BC4 File Offset: 0x00594DC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x060161A7 RID: 90535 RVA: 0x00596BE8 File Offset: 0x00594DE8
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIcon, base.GetTexture(0), roleId, null, null);
	}

	// Token: 0x02008FB3 RID: 36787
	private static class EChildType
	{
		// Token: 0x0402E8A5 RID: 190629
		public const int TextureRole = 0;
	}
}
