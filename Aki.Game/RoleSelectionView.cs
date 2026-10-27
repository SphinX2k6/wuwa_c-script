using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028F5 RID: 10485
[NullableContext(1)]
[Nullable(0)]
public class RoleSelectionView : UiViewBase
{
	// Token: 0x06015A5D RID: 88669 RVA: 0x00577105 File Offset: 0x00575305
	public RoleSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015A5E RID: 88670 RVA: 0x0057711C File Offset: 0x0057531C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.BackFunction))
		};
	}

	// Token: 0x06015A5F RID: 88671 RVA: 0x005771DC File Offset: 0x005753DC
	protected override void OnStart()
	{
		this.RoleScrollView = new LoopScrollView<RoleSelectionMediumItemGrid, RoleDataBase>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<RoleSelectionMediumItemGrid>(this.OnGridProxyCreate), false);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(5), new TUpdateDataListFunction<RoleDataBase>(this.UpdateList));
		this.RoleViewAgent = (this.OpenParam as RoleViewAgent);
		IEnumerable<int> roleIdList = this.RoleViewAgent.GetRoleIdList();
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (int id in roleIdList)
		{
			list.Add(RoleModel.Instance.GetRoleDataById(id, true));
		}
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.Role, list, Array.Empty<object>());
	}

	// Token: 0x06015A60 RID: 88672 RVA: 0x005772B0 File Offset: 0x005754B0
	protected override void OnBeforeDestroy()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleDataItem);
		EventSystem.Instance.Emit(EEventName.RoleSelectionListUpdate);
		this.FilterSortEntrance.Destroy(null);
		this.FilterSortEntrance = null;
		this.RoleScrollView.ClearGridProxies();
		this.RoleScrollView = null;
		this.RoleDataList = new List<RoleDataBase>();
	}

	// Token: 0x06015A61 RID: 88673 RVA: 0x0057730C File Offset: 0x0057550C
	protected override void OnBeforeShow()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		this.EnterRoleId = new int?(this.RoleViewAgent.GetCurSelectRoleId());
		this.SelectGridByRoleData(curSelectRoleData, true);
	}

	// Token: 0x06015A62 RID: 88674 RVA: 0x00577344 File Offset: 0x00575544
	private void BackFunction()
	{
		int? enterRoleId = this.EnterRoleId;
		int? curSelectRoleId = this.CurSelectRoleId;
		if (!(enterRoleId.GetValueOrDefault() == curSelectRoleId.GetValueOrDefault() & enterRoleId != null == (curSelectRoleId != null)))
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleSystemChangeRole, this.CurSelectRoleId.Value);
		}
		base.CloseMe(null);
	}

	// Token: 0x06015A63 RID: 88675 RVA: 0x005773A4 File Offset: 0x005755A4
	private RoleSelectionMediumItemGrid OnGridProxyCreate()
	{
		RoleSelectionMediumItemGrid roleSelectionMediumItemGrid = new RoleSelectionMediumItemGrid();
		IRoleSystemUiParams roleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
		roleSelectionMediumItemGrid.SetNeedShowTrial(roleSystemUiParams.RoleListNeedTrial);
		roleSelectionMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		roleSelectionMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return roleSelectionMediumItemGrid;
	}

	// Token: 0x06015A64 RID: 88676 RVA: 0x005773F2 File Offset: 0x005755F2
	private void UpdateList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleDataList = list;
		this.RefreshRoleItem(this.RoleDataList, isOutSideChange, operationType);
	}

	// Token: 0x06015A65 RID: 88677 RVA: 0x0057740C File Offset: 0x0057560C
	private void RefreshRoleItem(List<RoleDataBase> roleList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		this.RoleScrollView.ReloadData(roleList, false);
		if (this.CurSelectRoleId == null)
		{
			return;
		}
		if (roleList.Count <= 0)
		{
			return;
		}
		int num = 0;
		if (operationType == EFilterSortType.Filter)
		{
			num = roleList.FindIndex(delegate(RoleDataBase roleDataBase)
			{
				int dataId = roleDataBase.GetDataId();
				int? curSelectRoleId = this.CurSelectRoleId;
				return dataId == curSelectRoleId.GetValueOrDefault() & curSelectRoleId != null;
			});
			num = ((num <= 0) ? 0 : num);
		}
		this.RoleScrollView.ScrollToGridIndex(num, true);
		this.RoleScrollView.SelectGridProxy(num, false);
		this.SelectGridByRoleData(roleList[num], true);
	}

	// Token: 0x06015A66 RID: 88678 RVA: 0x00577493 File Offset: 0x00575693
	private void SetNameText(string nameText)
	{
		base.GetText(2).SetText(nameText, true);
	}

	// Token: 0x06015A67 RID: 88679 RVA: 0x005774A4 File Offset: 0x005756A4
	private void ChangeRoleByRoleId(RoleDataBase roleInstance)
	{
		int dataId = roleInstance.GetDataId();
		int valueOrDefault = this.CurSelectRoleId.GetValueOrDefault();
		int? curSelectRoleId = this.CurSelectRoleId;
		int num = dataId;
		if (curSelectRoleId.GetValueOrDefault() == num & curSelectRoleId != null)
		{
			return;
		}
		this.CurSelectRoleId = new int?(dataId);
		this.SetNameText(roleInstance.GetName(null));
		this.RoleViewAgent.SetCurSelectRoleId(this.CurSelectRoleId.Value);
		RoleController.Instance.OnSelectedRoleChange(this.CurSelectRoleId.Value, roleInstance.GetRoleSkinId());
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, valueOrDefault > 0, false);
	}

	// Token: 0x06015A68 RID: 88680 RVA: 0x00577548 File Offset: 0x00575748
	private void ToggleFunction(MediumItemGridExtendCallback callbackParameter)
	{
		int state = (int)callbackParameter.State;
		RoleDataBase roleInstance = callbackParameter.Data as RoleDataBase;
		if (state == 1)
		{
			this.RoleScrollView.DeselectCurrentGridProxy(false);
			this.SelectGridByRoleData(roleInstance, false);
		}
	}

	// Token: 0x06015A69 RID: 88681 RVA: 0x00577580 File Offset: 0x00575780
	private void SelectGridByRoleData(RoleDataBase roleInstance, bool needScroll = false)
	{
		int num = this.RoleDataList.IndexOf(roleInstance);
		if (num >= 0)
		{
			if (needScroll)
			{
				this.RoleScrollView.ScrollToGridIndex(num, true);
			}
			this.RoleScrollView.SelectGridProxy(num, false);
			this.ChangeRoleByRoleId(roleInstance);
		}
	}

	// Token: 0x06015A6A RID: 88682 RVA: 0x005775C4 File Offset: 0x005757C4
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (UiCameraAnimationManager.Instance.IsPlayingAnimation() && this.CurSelectRoleId != null && state == EToggleState.ETT_UnChecked)
		{
			return false;
		}
		RoleDataBase roleDataBase = data as RoleDataBase;
		if (state == EToggleState.ETT_Checked)
		{
			int? curSelectRoleId = this.CurSelectRoleId;
			int roleId = roleDataBase.GetRoleId();
			return !(curSelectRoleId.GetValueOrDefault() == roleId & curSelectRoleId != null);
		}
		return true;
	}

	// Token: 0x0400A102 RID: 41218
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400A103 RID: 41219
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RoleSelectionMediumItemGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400A104 RID: 41220
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A105 RID: 41221
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

	// Token: 0x0400A106 RID: 41222
	private int? EnterRoleId;

	// Token: 0x0400A107 RID: 41223
	private int? CurSelectRoleId;

	// Token: 0x02008F00 RID: 36608
	[NullableContext(0)]
	private enum ERoleListComponent
	{
		// Token: 0x0402E5E0 RID: 189920
		CaptionItem,
		// Token: 0x0402E5E1 RID: 189921
		ButtonBack,
		// Token: 0x0402E5E2 RID: 189922
		TextName,
		// Token: 0x0402E5E3 RID: 189923
		ScrollView,
		// Token: 0x0402E5E4 RID: 189924
		RoleItem,
		// Token: 0x0402E5E5 RID: 189925
		FilterSortItem
	}
}
