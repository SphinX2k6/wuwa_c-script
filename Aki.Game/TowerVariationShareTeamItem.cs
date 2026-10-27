using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C0C RID: 11276
public class TowerVariationShareTeamItem : GridProxyAbstract<int>
{
	// Token: 0x0601769D RID: 95901 RVA: 0x005F62C8 File Offset: 0x005F44C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601769E RID: 95902 RVA: 0x005F6394 File Offset: 0x005F4594
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<TowerStarsSimpleItem, bool>(base.GetHorizontalLayout(3), new Func<TowerStarsSimpleItem>(this.InitStarItem), null, false, true);
		this.RoleLayout = new GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch>(base.GetHorizontalLayout(4), new Func<TowerRoleSimpleItem>(this.InitRoleItem), null, false, true);
		base.GetExtendToggle(0).ToggleState = EToggleState.ETT_UnDetermined;
	}

	// Token: 0x0601769F RID: 95903 RVA: 0x005F63F0 File Offset: 0x005F45F0
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TowerId = data;
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(data);
		base.GetText(2).SetText(towerInfo.Value.Floor.ToString(), true);
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(this.TowerId);
		this.Star = ((floorData != null) ? floorData.Star : 0);
		List<bool> list = new List<bool>();
		for (int i = 1; i <= 3; i++)
		{
			list.Add(this.Star >= i);
		}
		this.StarLayout.RefreshByData(list, null, false);
		List<RoleDataWithBranch> list2 = new List<RoleDataWithBranch>();
		if (floorData == null)
		{
			goto IL_F3;
		}
		using (List<TowerRolePb>.Enumerator enumerator = floorData.Formation.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TowerRolePb towerRolePb = enumerator.Current;
				list2.Add(new RoleDataWithBranch(towerRolePb.RoleId, towerRolePb.SkillBranchId));
			}
			goto IL_F3;
		}
		IL_E6:
		list2.Add(new RoleDataWithBranch(0, 0));
		IL_F3:
		if (list2.Count >= 3)
		{
			this.RoleLayout.RefreshByData(list2, null, false);
			base.GetItem(6).SetUIActive(floorData != null && floorData.IsQuickPass);
			return;
		}
		goto IL_E6;
	}

	// Token: 0x060176A0 RID: 95904 RVA: 0x005F6530 File Offset: 0x005F4730
	[NullableContext(1)]
	private TowerStarsSimpleItem InitStarItem()
	{
		return new TowerStarsSimpleItem();
	}

	// Token: 0x060176A1 RID: 95905 RVA: 0x005F6537 File Offset: 0x005F4737
	[NullableContext(1)]
	private TowerRoleSimpleItem InitRoleItem()
	{
		return new TowerRoleSimpleItem();
	}

	// Token: 0x0400AF15 RID: 44821
	private int TowerId = -1;

	// Token: 0x0400AF16 RID: 44822
	private int Star = -1;

	// Token: 0x0400AF17 RID: 44823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerStarsSimpleItem, bool> StarLayout;

	// Token: 0x0400AF18 RID: 44824
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x020091D7 RID: 37335
	private enum EChildType
	{
		// Token: 0x0402F2EE RID: 193262
		FloorToggle,
		// Token: 0x0402F2EF RID: 193263
		BgTexture,
		// Token: 0x0402F2F0 RID: 193264
		FloorNumberText,
		// Token: 0x0402F2F1 RID: 193265
		StarRootLayout,
		// Token: 0x0402F2F2 RID: 193266
		RoleRootLayout,
		// Token: 0x0402F2F3 RID: 193267
		PnlLevel,
		// Token: 0x0402F2F4 RID: 193268
		QuickPassItem
	}
}
