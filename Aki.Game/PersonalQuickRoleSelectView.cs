using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018C6 RID: 6342
[NullableContext(1)]
[Nullable(0)]
public class PersonalQuickRoleSelectView : QuickRoleSelectView
{
	// Token: 0x0600FA73 RID: 64115 RVA: 0x00493C3E File Offset: 0x00491E3E
	public PersonalQuickRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA74 RID: 64116 RVA: 0x00493C48 File Offset: 0x00491E48
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as QuickRoleSelectViewData);
		this.RoleScrollView = new LoopScrollView<TeamRoleGrid, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(10).GetOwner() as AUIBaseActor, new Func<TeamRoleGrid>(this.OnPersonalGridProxyCreate), false);
		this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
	}

	// Token: 0x0600FA75 RID: 64117 RVA: 0x00493CAA File Offset: 0x00491EAA
	protected override void OnBeforeShow()
	{
		base.RefreshRoleList();
	}

	// Token: 0x0600FA76 RID: 64118 RVA: 0x00493CB2 File Offset: 0x00491EB2
	private PersonalQuickRoleSelectGrid OnPersonalGridProxyCreate()
	{
		PersonalQuickRoleSelectGrid personalQuickRoleSelectGrid = new PersonalQuickRoleSelectGrid();
		personalQuickRoleSelectGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(base.ToggleFunction));
		personalQuickRoleSelectGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		return personalQuickRoleSelectGrid;
	}

	// Token: 0x0600FA77 RID: 64119 RVA: 0x00493CE0 File Offset: 0x00491EE0
	protected override bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		RoleDataBase roleDataBase = data as RoleDataBase;
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PersonalDataItem, roleDataBase.GetDataId()))
		{
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.PersonalDataItem, roleDataBase.GetDataId());
			int gridIndex = this.RoleList.IndexOf(roleDataBase);
			this.RoleScrollView.RefreshGridProxy(gridIndex);
		}
		bool flag = RoleSelectModel.Instance.RoleIndexMap.Count >= 3;
		if (flag)
		{
			QuickRoleSelectViewData data2 = this.Data;
			if (((data2 != null) ? data2.OnRoleSelectFull : null) != null)
			{
				QuickRoleSelectViewData data3 = this.Data;
				if (data3 != null)
				{
					data3.OnRoleSelectFull();
				}
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			}
		}
		return !flag;
	}
}
