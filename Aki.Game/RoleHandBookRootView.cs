using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;

// Token: 0x02001C6B RID: 7275
public class RoleHandBookRootView : RoleRootView
{
	// Token: 0x060120D5 RID: 73941 RVA: 0x0054F2D9 File Offset: 0x0054D4D9
	[NullableContext(1)]
	public RoleHandBookRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060120D6 RID: 73942 RVA: 0x0054F2E9 File Offset: 0x0054D4E9
	protected override bool OnCheckIfNeedScene()
	{
		return this.IsNeedLoadSceneFlag;
	}

	// Token: 0x060120D7 RID: 73943 RVA: 0x0054F2F4 File Offset: 0x0054D4F4
	protected override void OnHandleLoadScene()
	{
		string uiCameraHandleName = DynamicTabCamera.GetUiCameraHandleName(EUiTabViewName.RoleHandBookPreviewView);
		this.RoleRootUiCameraHandleData = UiCameraModel.Instance.PushCameraHandleByHandleName(uiCameraHandleName, false, false, "1001", false, null);
	}

	// Token: 0x060120D8 RID: 73944 RVA: 0x0054F326 File Offset: 0x0054D526
	protected override void OnHandleReleaseScene()
	{
		UiCameraModel.Instance.PopCameraHandle(this.RoleRootUiCameraHandleData, null);
	}

	// Token: 0x060120D9 RID: 73945 RVA: 0x0054F33C File Offset: 0x0054D53C
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

	// Token: 0x060120DA RID: 73946 RVA: 0x0054F39F File Offset: 0x0054D59F
	protected void InitRoleIdList()
	{
		ConfigCommon.ToList<RoleInfo>(RoleConfig.Instance.GetRoleListByType(ERoleType.Common)).Sort((RoleInfo aRoleConfig, RoleInfo bRoleConfig) => aRoleConfig.Id - bRoleConfig.Id);
	}

	// Token: 0x060120DB RID: 73947 RVA: 0x0054F3D5 File Offset: 0x0054D5D5
	protected void UpdateSelectRoleInstance()
	{
	}

	// Token: 0x060120DC RID: 73948 RVA: 0x0054F3D7 File Offset: 0x0054D5D7
	protected override void OnAfterShow()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
	}

	// Token: 0x060120DD RID: 73949 RVA: 0x0054F3E8 File Offset: 0x0054D5E8
	protected void RebuildTabItem()
	{
		this.TabDataList = ConfigCommon.ToList<UiDynamicTab>(DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RoleHandBookRootView));
		int count = this.TabDataList.Count;
		this.TabComponent.RefreshTabItemByLength(count, null);
	}

	// Token: 0x060120DE RID: 73950 RVA: 0x0054F430 File Offset: 0x0054D630
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

	// Token: 0x060120DF RID: 73951 RVA: 0x0054F48B File Offset: 0x0054D68B
	protected override void LoadFloorEffect()
	{
		if (!this.IsNeedLoadSceneFlag)
		{
			return;
		}
		base.LoadFloorEffect();
	}

	// Token: 0x060120E0 RID: 73952 RVA: 0x0054F49C File Offset: 0x0054D69C
	protected override void OnBeforeDestroy()
	{
		base.ClearData();
	}

	// Token: 0x060120E1 RID: 73953 RVA: 0x0054F4A4 File Offset: 0x0054D6A4
	protected override void OnAfterHide()
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x04009D5F RID: 40287
	private EUiViewName FromViewName;

	// Token: 0x04009D60 RID: 40288
	private bool IsNeedLoadSceneFlag = true;
}
