using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E70 RID: 7792
[NullableContext(1)]
[Nullable(0)]
public class RoleSelectionView : UiViewBase
{
	// Token: 0x06013461 RID: 78945 RVA: 0x005A1FCD File Offset: 0x005A01CD
	public RoleSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013462 RID: 78946 RVA: 0x005A1FE4 File Offset: 0x005A01E4
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

	// Token: 0x06013463 RID: 78947 RVA: 0x005A20A4 File Offset: 0x005A02A4
	protected override void OnStart()
	{
		this.RoleScrollView = new LoopScrollView<RoleSelectionMediumItemGrid, RoleDataBase>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<RoleSelectionMediumItemGrid>(this.OnGridProxyCreate), false);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(5), new TUpdateDataListFunction<RoleDataBase>(this.UpdateList));
		this.RoleViewAgent = (this.OpenParam as RoleViewAgent);
		IEnumerable<int> roleIdList = this.RoleViewAgent.GetRoleIdList(null);
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (int id in roleIdList)
		{
			list.Add(RoleModel.Instance.GetRoleDataById(id, true));
		}
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.Role, list, Array.Empty<object>());
	}

	// Token: 0x06013464 RID: 78948 RVA: 0x005A217C File Offset: 0x005A037C
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

	// Token: 0x06013465 RID: 78949 RVA: 0x005A21D8 File Offset: 0x005A03D8
	protected override void OnBeforeShow()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		this.EnterRoleId = new int?(this.RoleViewAgent.GetCurSelectRoleId());
		this.SelectGridByRoleData(curSelectRoleData, true);
	}

	// Token: 0x06013466 RID: 78950 RVA: 0x005A2210 File Offset: 0x005A0410
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

	// Token: 0x06013467 RID: 78951 RVA: 0x005A2270 File Offset: 0x005A0470
	private RoleSelectionMediumItemGrid OnGridProxyCreate()
	{
		RoleSelectionMediumItemGrid roleSelectionMediumItemGrid = new RoleSelectionMediumItemGrid();
		IRoleSystemUiParams roleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
		roleSelectionMediumItemGrid.SetNeedShowTrial(roleSystemUiParams.RoleListNeedTrial);
		roleSelectionMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		roleSelectionMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return roleSelectionMediumItemGrid;
	}

	// Token: 0x06013468 RID: 78952 RVA: 0x005A22BE File Offset: 0x005A04BE
	private void UpdateList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleDataList = list;
		this.RefreshRoleItem(this.RoleDataList, isOutSideChange, operationType);
	}

	// Token: 0x06013469 RID: 78953 RVA: 0x005A22D8 File Offset: 0x005A04D8
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

	// Token: 0x0601346A RID: 78954 RVA: 0x005A235F File Offset: 0x005A055F
	private void SetNameText(string nameText)
	{
		base.GetText(2).SetText(nameText, true);
	}

	// Token: 0x0601346B RID: 78955 RVA: 0x005A2370 File Offset: 0x005A0570
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

	// Token: 0x0601346C RID: 78956 RVA: 0x005A2414 File Offset: 0x005A0614
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

	// Token: 0x0601346D RID: 78957 RVA: 0x005A244C File Offset: 0x005A064C
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

	// Token: 0x0601346E RID: 78958 RVA: 0x005A2490 File Offset: 0x005A0690
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (UiCameraModel.Instance.IsPlayingAnimation() && this.CurSelectRoleId != null && state == EToggleState.ETT_UnChecked)
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

	// Token: 0x0400A4ED RID: 42221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x0400A4EE RID: 42222
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RoleSelectionMediumItemGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400A4EF RID: 42223
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A4F0 RID: 42224
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

	// Token: 0x0400A4F1 RID: 42225
	private int? EnterRoleId;

	// Token: 0x0400A4F2 RID: 42226
	private int? CurSelectRoleId;

	// Token: 0x02008148 RID: 33096
	[NullableContext(0)]
	private enum ERoleListComponent
	{
		// Token: 0x04029CDB RID: 171227
		CaptionItem,
		// Token: 0x04029CDC RID: 171228
		ButtonBack,
		// Token: 0x04029CDD RID: 171229
		TextName,
		// Token: 0x04029CDE RID: 171230
		ScrollView,
		// Token: 0x04029CDF RID: 171231
		RoleItem,
		// Token: 0x04029CE0 RID: 171232
		FilterSortItem
	}
}
