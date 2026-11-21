using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200217B RID: 8571
public class TowerResetItem : GridProxyAbstract<int>
{
	// Token: 0x0601508C RID: 86156 RVA: 0x00621A1C File Offset: 0x0061FC1C
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

	// Token: 0x0601508D RID: 86157 RVA: 0x00621AA8 File Offset: 0x0061FCA8
	protected override void OnStart()
	{
		this.CurrentCostItem = new TowerCostItem();
		this.CurrentCostItem.CreateThenShowByActorAsync(base.GetItem(1).GetOwner(), null, false);
		this.ChangeToCostItem = new TowerCostItem();
		this.ChangeToCostItem.CreateThenShowByActorAsync(base.GetItem(2).GetOwner(), null, false);
	}

	// Token: 0x0601508E RID: 86158 RVA: 0x00621B00 File Offset: 0x0061FD00
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.RoleHeadIcon, base.GetTexture(0), roleId, null, null);
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(TowerModel.Instance.CurrentSelectFloor);
		int roleRemainCost = TowerModel.Instance.GetRoleRemainCost(roleId, floorData.Difficulties);
		this.CurrentCostItem.Update(roleRemainCost);
		this.ChangeToCostItem.Update(roleRemainCost + floorData.Cost);
	}

	// Token: 0x0400B30D RID: 45837
	[Nullable(2)]
	private TowerCostItem CurrentCostItem;

	// Token: 0x0400B30E RID: 45838
	[Nullable(2)]
	private TowerCostItem ChangeToCostItem;

	// Token: 0x0200840A RID: 33802
	private enum EChildType
	{
		// Token: 0x0402A9B4 RID: 174516
		RoleTexture,
		// Token: 0x0402A9B5 RID: 174517
		CurrentCostItem,
		// Token: 0x0402A9B6 RID: 174518
		ChangeToCostItem
	}
}
