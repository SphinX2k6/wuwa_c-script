using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BF1 RID: 11249
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorItem : GridProxyAbstract<int>
{
	// Token: 0x060175C8 RID: 95688 RVA: 0x005F11F4 File Offset: 0x005EF3F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060175C9 RID: 95689 RVA: 0x005F1340 File Offset: 0x005EF540
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<TowerStarsSimpleItem, bool>(base.GetHorizontalLayout(3), new Func<TowerStarsSimpleItem>(this.InitStarItem), null, false, true);
		this.RoleLayout = new GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch>(base.GetHorizontalLayout(4), new Func<TowerRoleSimpleItem>(this.InitRoleItem), null, false, true);
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x060175CA RID: 95690 RVA: 0x005F1398 File Offset: 0x005EF598
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TowerId = data;
		this.IsLock = !TowerModel.Instance.GetFloorIsUnlock(this.TowerId);
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(data).Value;
		base.GetText(2).SetText(value.Floor.ToString(), true);
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
			goto IL_10C;
		}
		using (List<TowerRolePb>.Enumerator enumerator = floorData.Formation.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TowerRolePb towerRolePb = enumerator.Current;
				list2.Add(new RoleDataWithBranch(towerRolePb.RoleId, towerRolePb.SkillBranchId));
			}
			goto IL_10C;
		}
		IL_FF:
		list2.Add(new RoleDataWithBranch(0, 0));
		IL_10C:
		if (list2.Count >= 3)
		{
			this.RoleLayout.RefreshByData(list2, null, false);
			base.SetTextureByPath(value.ItemBgPath, base.GetTexture(1), null, null);
			if (this.IsLock)
			{
				base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			}
			else
			{
				base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			if (TowerModel.Instance.DefaultFloor == data)
			{
				this.SetToggleState(EToggleState.ETT_Checked);
			}
			base.GetItem(6).SetUIActive(floorData != null && floorData.IsQuickPass);
			return;
		}
		goto IL_FF;
	}

	// Token: 0x060175CB RID: 95691 RVA: 0x005F1550 File Offset: 0x005EF750
	public void BindOnClickToggle(Action<int, bool> onClickToggle)
	{
		this.OnClickToggleHandle = onClickToggle;
	}

	// Token: 0x060175CC RID: 95692 RVA: 0x005F1559 File Offset: 0x005EF759
	private void OnClickToggle(EToggleState state)
	{
		if (this.OnClickToggleHandle != null && state == EToggleState.ETT_Checked)
		{
			this.OnClickToggleHandle(this.TowerId, this.IsLock);
		}
	}

	// Token: 0x060175CD RID: 95693 RVA: 0x005F157E File Offset: 0x005EF77E
	protected override void OnBeforeDestroy()
	{
		this.OnClickToggleHandle = null;
		this.StarLayout = null;
		this.RoleLayout = null;
	}

	// Token: 0x060175CE RID: 95694 RVA: 0x005F1595 File Offset: 0x005EF795
	private TowerStarsSimpleItem InitStarItem()
	{
		return new TowerStarsSimpleItem();
	}

	// Token: 0x060175CF RID: 95695 RVA: 0x005F159C File Offset: 0x005EF79C
	private TowerRoleSimpleItem InitRoleItem()
	{
		return new TowerRoleSimpleItem();
	}

	// Token: 0x060175D0 RID: 95696 RVA: 0x005F15A3 File Offset: 0x005EF7A3
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0400AED2 RID: 44754
	[Nullable(2)]
	private Action<int, bool> OnClickToggleHandle;

	// Token: 0x0400AED3 RID: 44755
	private int TowerId = -1;

	// Token: 0x0400AED4 RID: 44756
	private bool IsLock;

	// Token: 0x0400AED5 RID: 44757
	private int Star = -1;

	// Token: 0x0400AED6 RID: 44758
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerStarsSimpleItem, bool> StarLayout;

	// Token: 0x0400AED7 RID: 44759
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x020091AF RID: 37295
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F226 RID: 193062
		FloorToggle,
		// Token: 0x0402F227 RID: 193063
		BgTexture,
		// Token: 0x0402F228 RID: 193064
		FloorNumberText,
		// Token: 0x0402F229 RID: 193065
		StarRootLayout,
		// Token: 0x0402F22A RID: 193066
		RoleRootLayout,
		// Token: 0x0402F22B RID: 193067
		LockToggle,
		// Token: 0x0402F22C RID: 193068
		QuickPassItem
	}
}
