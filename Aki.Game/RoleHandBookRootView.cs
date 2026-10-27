using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;

// Token: 0x02002780 RID: 10112
public class RoleHandBookRootView : RoleRootView
{
	// Token: 0x06014BF2 RID: 84978 RVA: 0x0054044D File Offset: 0x0053E64D
	[NullableContext(1)]
	public RoleHandBookRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014BF3 RID: 84979 RVA: 0x0054045D File Offset: 0x0053E65D
	protected override bool OnCheckIfNeedScene()
	{
		return this.IsNeedLoadSceneFlag;
	}

	// Token: 0x06014BF4 RID: 84980 RVA: 0x00540468 File Offset: 0x0053E668
	protected override void OnHandleLoadScene()
	{
		string uiCameraHandleName = DynamicTabCamera.GetUiCameraHandleName(EUiTabViewName.RoleHandBookPreviewView);
		this.RoleRootUiCameraHandleData = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(uiCameraHandleName, false, false, "1001", false, null, null);
	}

	// Token: 0x06014BF5 RID: 84981 RVA: 0x005404A3 File Offset: 0x0053E6A3
	protected override void OnHandleReleaseScene()
	{
		UiCameraAnimationManager.Instance.PopCameraHandle(this.RoleRootUiCameraHandleData, null);
	}

	// Token: 0x06014BF6 RID: 84982 RVA: 0x005404B8 File Offset: 0x0053E6B8
	protected override void OnBeforeCreate()
	{
		object openParam = this.OpenParam;
		EUiViewName fromViewName;
		if (openParam is EUiViewName)
		{
			EUiViewName euiViewName = (EUiViewName)openParam;
			fromViewName = euiViewName;
		}
		else
		{
			fromViewName = default(EUiViewName);
		}
		this.FromViewName = fromViewName;
		this.IsNeedLoadSceneFlag = (this.FromViewName.ToString() != EUiViewName.RoleHandBookSelectionView.ToString());
	}

	// Token: 0x06014BF7 RID: 84983 RVA: 0x0054051B File Offset: 0x0053E71B
	protected void InitRoleIdList()
	{
		ConfigCommon.ToList<RoleInfo>(RoleConfig.Instance.GetRoleListByType(ERoleType.Common)).Sort((RoleInfo aRoleConfig, RoleInfo bRoleConfig) => aRoleConfig.Id - bRoleConfig.Id);
	}

	// Token: 0x06014BF8 RID: 84984 RVA: 0x00540551 File Offset: 0x0053E751
	protected void UpdateSelectRoleInstance()
	{
	}

	// Token: 0x06014BF9 RID: 84985 RVA: 0x00540553 File Offset: 0x0053E753
	protected override void OnAfterShow()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
	}

	// Token: 0x06014BFA RID: 84986 RVA: 0x00540564 File Offset: 0x0053E764
	protected void RebuildTabItem()
	{
		this.TabDataList = ConfigCommon.ToList<UiDynamicTab>(DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RoleHandBookRootView));
		int count = this.TabDataList.Count;
		this.TabComponent.RefreshTabItemByLength(count, null);
	}

	// Token: 0x06014BFB RID: 84987 RVA: 0x005405AC File Offset: 0x0053E7AC
	protected override void OnStart()
	{
		base.InitTabComponent();
		base.GetButton(1).RootUIComp.Get().SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		if (this.IsNeedLoadSceneFlag)
		{
			this.UpdateSelectRoleInstance();
		}
		this.TabComponent.SelectToggleByIndex(0, true);
		this.LoadFloorEffect();
	}

	// Token: 0x06014BFC RID: 84988 RVA: 0x00540607 File Offset: 0x0053E807
	protected override void LoadFloorEffect()
	{
		if (!this.IsNeedLoadSceneFlag)
		{
			return;
		}
		base.LoadFloorEffect();
	}

	// Token: 0x06014BFD RID: 84989 RVA: 0x00540618 File Offset: 0x0053E818
	protected override void OnBeforeDestroy()
	{
		base.ClearData();
	}

	// Token: 0x06014BFE RID: 84990 RVA: 0x00540620 File Offset: 0x0053E820
	protected override void OnAfterHide()
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x04009C07 RID: 39943
	private EUiViewName FromViewName;

	// Token: 0x04009C08 RID: 39944
	private bool IsNeedLoadSceneFlag = true;
}
