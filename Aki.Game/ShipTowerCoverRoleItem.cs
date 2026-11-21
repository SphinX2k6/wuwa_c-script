using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F20 RID: 7968
public class ShipTowerCoverRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06013BAC RID: 80812 RVA: 0x005C1B84 File Offset: 0x005BFD84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06013BAD RID: 80813 RVA: 0x005C1BA8 File Offset: 0x005BFDA8
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIcon, base.GetTexture(0), roleId, null, null);
	}

	// Token: 0x020081FC RID: 33276
	private static class EChildType
	{
		// Token: 0x04029FA4 RID: 171940
		public const int TextureRole = 0;
	}
}
