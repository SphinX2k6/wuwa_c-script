using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200115E RID: 4446
internal class BabelTowerHardLevelRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06007524 RID: 29988 RVA: 0x001818F4 File Offset: 0x0017FAF4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007525 RID: 29989 RVA: 0x00181960 File Offset: 0x0017FB60
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(data, true) : null;
		if (roleDataBase == null)
		{
			return;
		}
		base.SetRoleSkinIcon(roleDataBase.GetRoleConfig().Card, base.GetTexture(2), roleDataBase.GetRoleSkinId(), null, null);
	}
}
