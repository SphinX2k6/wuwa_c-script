using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200216C RID: 8556
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorItem : GridProxyAbstract<int>
{
	// Token: 0x06014FF9 RID: 86009 RVA: 0x0061DD48 File Offset: 0x0061BF48
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

	// Token: 0x06014FFA RID: 86010 RVA: 0x0061DE94 File Offset: 0x0061C094
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<TowerStarsSimpleItem, bool>(base.GetHorizontalLayout(3), new Func<TowerStarsSimpleItem>(this.InitStarItem), null, false, true);
		this.RoleLayout = new GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch>(base.GetHorizontalLayout(4), new Func<TowerRoleSimpleItem>(this.InitRoleItem), null, false, true);
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x06014FFB RID: 86011 RVA: 0x0061DEEC File Offset: 0x0061C0EC
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

	// Token: 0x06014FFC RID: 86012 RVA: 0x0061E0A4 File Offset: 0x0061C2A4
	public void BindOnClickToggle(Action<int, bool> onClickToggle)
	{
		this.OnClickToggleHandle = onClickToggle;
	}

	// Token: 0x06014FFD RID: 86013 RVA: 0x0061E0AD File Offset: 0x0061C2AD
	private void OnClickToggle(EToggleState state)
	{
		if (this.OnClickToggleHandle != null && state == EToggleState.ETT_Checked)
		{
			this.OnClickToggleHandle(this.TowerId, this.IsLock);
		}
	}

	// Token: 0x06014FFE RID: 86014 RVA: 0x0061E0D2 File Offset: 0x0061C2D2
	protected override void OnBeforeDestroy()
	{
		this.OnClickToggleHandle = null;
		this.StarLayout = null;
		this.RoleLayout = null;
	}

	// Token: 0x06014FFF RID: 86015 RVA: 0x0061E0E9 File Offset: 0x0061C2E9
	private TowerStarsSimpleItem InitStarItem()
	{
		return new TowerStarsSimpleItem();
	}

	// Token: 0x06015000 RID: 86016 RVA: 0x0061E0F0 File Offset: 0x0061C2F0
	private TowerRoleSimpleItem InitRoleItem()
	{
		return new TowerRoleSimpleItem();
	}

	// Token: 0x06015001 RID: 86017 RVA: 0x0061E0F7 File Offset: 0x0061C2F7
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0400B2D7 RID: 45783
	[Nullable(2)]
	private Action<int, bool> OnClickToggleHandle;

	// Token: 0x0400B2D8 RID: 45784
	private int TowerId = -1;

	// Token: 0x0400B2D9 RID: 45785
	private bool IsLock;

	// Token: 0x0400B2DA RID: 45786
	private int Star = -1;

	// Token: 0x0400B2DB RID: 45787
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerStarsSimpleItem, bool> StarLayout;

	// Token: 0x0400B2DC RID: 45788
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TowerRoleSimpleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x020083F2 RID: 33778
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A927 RID: 174375
		FloorToggle,
		// Token: 0x0402A928 RID: 174376
		BgTexture,
		// Token: 0x0402A929 RID: 174377
		FloorNumberText,
		// Token: 0x0402A92A RID: 174378
		StarRootLayout,
		// Token: 0x0402A92B RID: 174379
		RoleRootLayout,
		// Token: 0x0402A92C RID: 174380
		LockToggle,
		// Token: 0x0402A92D RID: 174381
		QuickPassItem
	}
}
