using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002187 RID: 8583
public class TowerVariationShareTeamItem : GridProxyAbstract<int>
{
	// Token: 0x060150CE RID: 86222 RVA: 0x00622DEC File Offset: 0x00620FEC
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

	// Token: 0x060150CF RID: 86223 RVA: 0x00622EB8 File Offset: 0x006210B8
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<TowerStarsSimpleItem, bool>(base.GetHorizontalLayout(3), new Func<TowerStarsSimpleItem>(this.InitStarItem), null, false, true);
		this.RoleLayout = new GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch>(base.GetHorizontalLayout(4), new Func<TowerRoleSimpleItem>(this.InitRoleItem), null, false, true);
		base.GetExtendToggle(0).ToggleState = EToggleState.ETT_UnDetermined;
	}

	// Token: 0x060150D0 RID: 86224 RVA: 0x00622F14 File Offset: 0x00621114
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

	// Token: 0x060150D1 RID: 86225 RVA: 0x00623054 File Offset: 0x00621254
	[NullableContext(1)]
	private TowerStarsSimpleItem InitStarItem()
	{
		return new TowerStarsSimpleItem();
	}

	// Token: 0x060150D2 RID: 86226 RVA: 0x0062305B File Offset: 0x0062125B
	[NullableContext(1)]
	private TowerRoleSimpleItem InitRoleItem()
	{
		return new TowerRoleSimpleItem();
	}

	// Token: 0x0400B31A RID: 45850
	private int TowerId = -1;

	// Token: 0x0400B31B RID: 45851
	private int Star = -1;

	// Token: 0x0400B31C RID: 45852
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerStarsSimpleItem, bool> StarLayout;

	// Token: 0x0400B31D RID: 45853
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x0200841A RID: 33818
	private enum EChildType
	{
		// Token: 0x0402A9EF RID: 174575
		FloorToggle,
		// Token: 0x0402A9F0 RID: 174576
		BgTexture,
		// Token: 0x0402A9F1 RID: 174577
		FloorNumberText,
		// Token: 0x0402A9F2 RID: 174578
		StarRootLayout,
		// Token: 0x0402A9F3 RID: 174579
		RoleRootLayout,
		// Token: 0x0402A9F4 RID: 174580
		PnlLevel,
		// Token: 0x0402A9F5 RID: 174581
		QuickPassItem
	}
}
