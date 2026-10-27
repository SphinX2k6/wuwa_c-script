using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02002A5D RID: 10845
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentViewModel : CSharpScript.Game.Module.Skin.ViewModelBase<ERoleOrnamentTabViewData>
{
	// Token: 0x17001E00 RID: 7680
	// (get) Token: 0x060169A9 RID: 92585 RVA: 0x005BABC5 File Offset: 0x005B8DC5
	public ISkinViewData ViewData
	{
		get
		{
			return this.ViewDataInternal;
		}
	}

	// Token: 0x060169AA RID: 92586 RVA: 0x005BABCD File Offset: 0x005B8DCD
	public RoleOrnamentViewModel()
	{
		this.DataMap[ERoleOrnamentTabViewData.SelectedOrnamentId] = 0;
		this.DataMap[ERoleOrnamentTabViewData.SelectedSkinId] = 0;
		this.DataMap[ERoleOrnamentTabViewData.PreSelectedOrnamentId] = 0;
	}

	// Token: 0x060169AB RID: 92587 RVA: 0x005BAC0B File Offset: 0x005B8E0B
	public void Init(ISkinViewData viewData)
	{
		this.ViewDataInternal = viewData;
	}

	// Token: 0x060169AC RID: 92588 RVA: 0x005BAC14 File Offset: 0x005B8E14
	public void SetSelectedOrnamentId(int ornamentId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.SelectedOrnamentId, ornamentId, notNotify);
	}

	// Token: 0x060169AD RID: 92589 RVA: 0x005BAC24 File Offset: 0x005B8E24
	public int GetSelectedOrnamentId()
	{
		return (int)base.GetData(ERoleOrnamentTabViewData.SelectedOrnamentId);
	}

	// Token: 0x060169AE RID: 92590 RVA: 0x005BAC32 File Offset: 0x005B8E32
	public void SetSelectedSkinId(int skinId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.SelectedSkinId, skinId, notNotify);
	}

	// Token: 0x060169AF RID: 92591 RVA: 0x005BAC42 File Offset: 0x005B8E42
	public int GetSelectedSkinId()
	{
		return (int)base.GetData(ERoleOrnamentTabViewData.SelectedSkinId);
	}

	// Token: 0x060169B0 RID: 92592 RVA: 0x005BAC50 File Offset: 0x005B8E50
	public void SetPreSelectedOrnamentId(int ornamentId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.PreSelectedOrnamentId, ornamentId, notNotify);
	}

	// Token: 0x060169B1 RID: 92593 RVA: 0x005BAC60 File Offset: 0x005B8E60
	public int GetPreSelectedOrnamentId()
	{
		object data = base.GetData(ERoleOrnamentTabViewData.PreSelectedOrnamentId);
		if (data == null)
		{
			return 0;
		}
		return (int)data;
	}

	// Token: 0x060169B2 RID: 92594 RVA: 0x005BAC80 File Offset: 0x005B8E80
	public IUiCameraInputComponentData GetOrnamentTabCameraInputData(UUIDraggableComponent dragItem, TsUiSceneRoleActor roleActor, bool isHidingUi)
	{
		int selectedOrnamentId = this.GetSelectedOrnamentId();
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(selectedOrnamentId).Value;
		string text = isHidingUi ? value.HideUiCameraConfig : value.UiCameraConfig;
		if (string.IsNullOrEmpty(text))
		{
			text = PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId();
		}
		string text2 = isHidingUi ? value.HideUiCameraOffsetConfig : value.UiCameraOffsetConfig;
		SUiRoleCameraSetting value2 = UiRoleCameraConfig.Instance.GetRoleCameraConfig(text).Value;
		SUiRoleCameraOffsetSetting? cameraOffsetConfig = null;
		if (!string.IsNullOrEmpty(text2))
		{
			SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(text2);
			if (roleCameraOffsetConfig != null)
			{
				cameraOffsetConfig = new SUiRoleCameraOffsetSetting?(roleCameraOffsetConfig.Value);
			}
		}
		FVectorDouble fvectorDouble = roleActor.D_K2_GetActorLocation();
		return new UiCameraInputComponentData
		{
			DragComponent = dragItem,
			CameraSettingConfig = value2,
			CameraOffsetConfig = cameraOffsetConfig,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x060169B3 RID: 92595 RVA: 0x005BAD60 File Offset: 0x005B8F60
	public int GetDefaultSkinId(int roleId)
	{
		List<RoleSkinData> roleSkinDataList = RoleSkinModel.Instance.GetRoleSkinDataList(roleId);
		RoleOrnamentModel instance = RoleOrnamentModel.Instance;
		for (int i = 0; i < roleSkinDataList.Count; i++)
		{
			RoleSkinData roleSkinData = roleSkinDataList[i];
			if (roleSkinData.IsWear() && instance.GetSkinAllOrnaments(roleSkinData.GetItemId(), null).Count > 0)
			{
				return roleSkinData.GetItemId();
			}
		}
		for (int j = 0; j < roleSkinDataList.Count; j++)
		{
			RoleSkinData roleSkinData2 = roleSkinDataList[j];
			if (instance.GetSkinAllOrnaments(roleSkinData2.GetItemId(), null).Count > 0)
			{
				return roleSkinData2.GetItemId();
			}
		}
		return roleSkinDataList[0].GetItemId();
	}

	// Token: 0x060169B4 RID: 92596 RVA: 0x005BAE17 File Offset: 0x005B9017
	public int GetDefaultOrnamentId(int skinId)
	{
		return RoleOrnamentModel.Instance.GetSkinAllOrnaments(skinId, new bool?(true))[0];
	}

	// Token: 0x0400A7AF RID: 42927
	private ISkinViewData ViewDataInternal;
}
