using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000858 RID: 2136
[NullableContext(2)]
[Nullable(0)]
public class NewcomerJourneyRoleSelectItem : GridProxyAbstract<int>
{
	// Token: 0x060060DB RID: 24795 RVA: 0x001EEA20 File Offset: 0x001ECC20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnPreviewBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060060DC RID: 24796 RVA: 0x001EEBF3 File Offset: 0x001ECDF3
	private void OnToggleClick(EToggleState state)
	{
		Action<int, int> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(base.GridIndex, this.RoleId);
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x001EEC14 File Offset: 0x001ECE14
	private void OnPreviewBtnClick()
	{
		List<int> previewCharacterList = ActivityNewcomerJourneyController.Instance.GetNewcomerJourneyData().GetPreviewCharacterList();
		AdventureRole? roleById = ActivityNewcomerJourneyConfig.Instance.GetRoleById(this.RoleId);
		int selectRoleId = (roleById != null) ? roleById.GetValueOrDefault().TrialRoleId : 0;
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, selectRoleId, previewCharacterList, null, null);
		Action openCallBack = this.OpenCallBack;
		if (openCallBack == null)
		{
			return;
		}
		openCallBack();
	}

	// Token: 0x060060DE RID: 24798 RVA: 0x001EEC88 File Offset: 0x001ECE88
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(4));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
		}
		base.GetText(6).SetUIActive(false);
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x001EECD8 File Offset: 0x001ECED8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RoleId = data;
		AdventureRole value = ActivityNewcomerJourneyConfig.Instance.GetRoleById(this.RoleId).Value;
		base.SetTextureByPath(value.HeadCard, base.GetTexture(1), null, null);
		RoleInfo value2 = RoleConfig.Instance.GetRoleConfig(this.RoleId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), value2.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		string icon = CommonConfig.Instance.GetElementConfig(value2.ElementId).Value.Icon5;
		base.SetElementIcon(icon, base.GetTexture(3), value2.ElementId, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.DesText, Array.Empty<object>());
		int qualityId = value2.QualityId;
		SimpleGenericLayout starLayout = this.StarLayout;
		if (starLayout != null)
		{
			starLayout.RebuildLayout(qualityId);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(isSelected);
		}
		if (isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		else
		{
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x001EEE2E File Offset: 0x001ED02E
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x001EEE5A File Offset: 0x001ED05A
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x04003F35 RID: 16181
	private int RoleId;

	// Token: 0x04003F36 RID: 16182
	private SimpleGenericLayout StarLayout;

	// Token: 0x04003F37 RID: 16183
	public Action OpenCallBack;

	// Token: 0x04003F38 RID: 16184
	public Action<int, int> ToggleCallBack;

	// Token: 0x04003F39 RID: 16185
	public Func<int, bool> CanToggleChange;
}
