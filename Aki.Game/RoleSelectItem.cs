using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001195 RID: 4501
[NullableContext(2)]
[Nullable(0)]
public class RoleSelectItem : GridProxyAbstract<int>
{
	// Token: 0x0600771B RID: 30491 RVA: 0x0018D704 File Offset: 0x0018B904
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

	// Token: 0x0600771C RID: 30492 RVA: 0x0018D834 File Offset: 0x0018BA34
	private void OnToggleClick(EToggleState _)
	{
		Action<int, int> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(base.GridIndex, this.RoleId);
	}

	// Token: 0x0600771D RID: 30493 RVA: 0x0018D854 File Offset: 0x0018BA54
	private void OnPreviewBtnClick()
	{
		NewbieCarnivalRole? newbieCarnivalRole = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalRole(this.RoleId);
		List<int> roleIdList = new List<int>
		{
			(newbieCarnivalRole != null) ? newbieCarnivalRole.GetValueOrDefault().TrialRoleId : 0
		};
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, roleIdList, null, null);
	}

	// Token: 0x0600771E RID: 30494 RVA: 0x0018D8B0 File Offset: 0x0018BAB0
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

	// Token: 0x0600771F RID: 30495 RVA: 0x0018D900 File Offset: 0x0018BB00
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

	// Token: 0x06007720 RID: 30496 RVA: 0x0018DA6C File Offset: 0x0018BC6C
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06007721 RID: 30497 RVA: 0x0018DA84 File Offset: 0x0018BC84
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040036AC RID: 13996
	private int RoleId;

	// Token: 0x040036AD RID: 13997
	private SimpleGenericLayout StarLayout;

	// Token: 0x040036AE RID: 13998
	public Action<int, int> ToggleCallBack;

	// Token: 0x040036AF RID: 13999
	public Func<int, bool> CanToggleChange;
}
