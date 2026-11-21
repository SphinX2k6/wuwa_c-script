using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000612 RID: 1554
internal class BabelTowerHardLevelRoleItem : GridProxyAbstract<int>
{
	// Token: 0x060048BB RID: 18619 RVA: 0x0018A424 File Offset: 0x00188624
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

	// Token: 0x060048BC RID: 18620 RVA: 0x0018A490 File Offset: 0x00188690
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
