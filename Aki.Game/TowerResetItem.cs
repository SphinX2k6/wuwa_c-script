using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C00 RID: 11264
public class TowerResetItem : GridProxyAbstract<int>
{
	// Token: 0x0601765B RID: 95835 RVA: 0x005F4EF4 File Offset: 0x005F30F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601765C RID: 95836 RVA: 0x005F4F80 File Offset: 0x005F3180
	protected override void OnStart()
	{
		this.CurrentCostItem = new TowerCostItem();
		this.CurrentCostItem.CreateThenShowByActorAsync(base.GetItem(1).GetOwner(), null, false);
		this.ChangeToCostItem = new TowerCostItem();
		this.ChangeToCostItem.CreateThenShowByActorAsync(base.GetItem(2).GetOwner(), null, false);
	}

	// Token: 0x0601765D RID: 95837 RVA: 0x005F4FD8 File Offset: 0x005F31D8
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIcon, base.GetTexture(0), roleId, null, null);
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(TowerModel.Instance.CurrentSelectFloor);
		int roleRemainCost = TowerModel.Instance.GetRoleRemainCost(roleId, floorData.Difficulties);
		this.CurrentCostItem.Update(roleRemainCost);
		this.ChangeToCostItem.Update(roleRemainCost + floorData.Cost);
	}

	// Token: 0x0400AF08 RID: 44808
	[Nullable(2)]
	private TowerCostItem CurrentCostItem;

	// Token: 0x0400AF09 RID: 44809
	[Nullable(2)]
	private TowerCostItem ChangeToCostItem;

	// Token: 0x020091C7 RID: 37319
	private enum EChildType
	{
		// Token: 0x0402F2B3 RID: 193203
		RoleTexture,
		// Token: 0x0402F2B4 RID: 193204
		CurrentCostItem,
		// Token: 0x0402F2B5 RID: 193205
		ChangeToCostItem
	}
}
