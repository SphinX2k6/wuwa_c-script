using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020023E1 RID: 9185
[NullableContext(1)]
[Nullable(0)]
public class PersonalQuickRoleSelectView : QuickRoleSelectView
{
	// Token: 0x060125C1 RID: 75201 RVA: 0x00486732 File Offset: 0x00484932
	public PersonalQuickRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125C2 RID: 75202 RVA: 0x0048673C File Offset: 0x0048493C
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as QuickRoleSelectViewData);
		this.RoleScrollView = new LoopScrollView<TeamRoleGrid, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(10).GetOwner() as AUIBaseActor, new Func<TeamRoleGrid>(this.OnPersonalGridProxyCreate), false);
		this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
	}

	// Token: 0x060125C3 RID: 75203 RVA: 0x0048679E File Offset: 0x0048499E
	protected override void OnBeforeShow()
	{
		base.RefreshRoleList();
	}

	// Token: 0x060125C4 RID: 75204 RVA: 0x004867A6 File Offset: 0x004849A6
	private PersonalQuickRoleSelectGrid OnPersonalGridProxyCreate()
	{
		PersonalQuickRoleSelectGrid personalQuickRoleSelectGrid = new PersonalQuickRoleSelectGrid();
		personalQuickRoleSelectGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(base.ToggleFunction));
		personalQuickRoleSelectGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		return personalQuickRoleSelectGrid;
	}

	// Token: 0x060125C5 RID: 75205 RVA: 0x004867D4 File Offset: 0x004849D4
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
