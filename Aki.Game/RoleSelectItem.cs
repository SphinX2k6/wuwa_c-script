using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000649 RID: 1609
[NullableContext(2)]
[Nullable(0)]
public class RoleSelectItem : GridProxyAbstract<int>
{
	// Token: 0x06004AB2 RID: 19122 RVA: 0x001962EC File Offset: 0x001944EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnPreviewBtnClick)),
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x0019641C File Offset: 0x0019461C
	private void OnToggleClick(EToggleState _)
	{
		Action<int, int> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(base.GridIndex, this.RoleId);
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x0019643C File Offset: 0x0019463C
	private void OnPreviewBtnClick()
	{
		NewbieCarnivalRole? newbieCarnivalRole = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalRole(this.RoleId);
		List<int> roleIdList = new List<int>
		{
			(newbieCarnivalRole != null) ? newbieCarnivalRole.GetValueOrDefault().TrialRoleId : 0
		};
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, roleIdList, null, null);
	}

	// Token: 0x06004AB5 RID: 19125 RVA: 0x00196498 File Offset: 0x00194698
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

	// Token: 0x06004AB6 RID: 19126 RVA: 0x001964E8 File Offset: 0x001946E8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RoleId = data;
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(this.RoleId == BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().ChoseRoleId);
		}
		NewbieCarnivalRole value = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalRole(this.RoleId).Value;
		base.SetTextureByPath(value.HeadCard, base.GetTexture(1), null, null);
		RoleInfo value2 = RoleConfig.Instance.GetRoleConfig(this.RoleId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), value2.Name, Array.Empty<object>());
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(true);
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

	// Token: 0x06004AB7 RID: 19127 RVA: 0x00196654 File Offset: 0x00194854
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06004AB8 RID: 19128 RVA: 0x0019666C File Offset: 0x0019486C
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003745 RID: 14149
	private int RoleId;

	// Token: 0x04003746 RID: 14150
	private SimpleGenericLayout StarLayout;

	// Token: 0x04003747 RID: 14151
	public Action<int, int> ToggleCallBack;

	// Token: 0x04003748 RID: 14152
	public Func<int, bool> CanToggleChange;
}
