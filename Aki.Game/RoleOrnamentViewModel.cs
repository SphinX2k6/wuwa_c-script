using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;

// Token: 0x02001FD8 RID: 8152
[NullableContext(1)]
[Nullable(0)]
public class RoleOrnamentViewModel : CSharpScript.Game.Module.Skin.ViewModelBase<ERoleOrnamentTabViewData>
{
	// Token: 0x17001E58 RID: 7768
	// (get) Token: 0x060143CA RID: 82890 RVA: 0x005E6D4D File Offset: 0x005E4F4D
	public ISkinViewData ViewData
	{
		get
		{
			return this.ViewDataInternal;
		}
	}

	// Token: 0x060143CB RID: 82891 RVA: 0x005E6D55 File Offset: 0x005E4F55
	public RoleOrnamentViewModel()
	{
		this.DataMap[ERoleOrnamentTabViewData.SelectedOrnamentId] = 0;
		this.DataMap[ERoleOrnamentTabViewData.SelectedSkinId] = 0;
		this.DataMap[ERoleOrnamentTabViewData.PreSelectedOrnamentId] = 0;
	}

	// Token: 0x060143CC RID: 82892 RVA: 0x005E6D93 File Offset: 0x005E4F93
	public void Init(ISkinViewData viewData)
	{
		this.ViewDataInternal = viewData;
	}

	// Token: 0x060143CD RID: 82893 RVA: 0x005E6D9C File Offset: 0x005E4F9C
	public void SetSelectedOrnamentId(int ornamentId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.SelectedOrnamentId, ornamentId, notNotify);
	}

	// Token: 0x060143CE RID: 82894 RVA: 0x005E6DAC File Offset: 0x005E4FAC
	public int GetSelectedOrnamentId()
	{
		return (int)base.GetData(ERoleOrnamentTabViewData.SelectedOrnamentId);
	}

	// Token: 0x060143CF RID: 82895 RVA: 0x005E6DBA File Offset: 0x005E4FBA
	public void SetSelectedSkinId(int skinId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.SelectedSkinId, skinId, notNotify);
	}

	// Token: 0x060143D0 RID: 82896 RVA: 0x005E6DCA File Offset: 0x005E4FCA
	public int GetSelectedSkinId()
	{
		return (int)base.GetData(ERoleOrnamentTabViewData.SelectedSkinId);
	}

	// Token: 0x060143D1 RID: 82897 RVA: 0x005E6DD8 File Offset: 0x005E4FD8
	public void SetPreSelectedOrnamentId(int ornamentId, bool notNotify = false)
	{
		base.SetData(ERoleOrnamentTabViewData.PreSelectedOrnamentId, ornamentId, notNotify);
	}

	// Token: 0x060143D2 RID: 82898 RVA: 0x005E6DE8 File Offset: 0x005E4FE8
	public int GetPreSelectedOrnamentId()
	{
		object data = base.GetData(ERoleOrnamentTabViewData.PreSelectedOrnamentId);
		if (data == null)
		{
			return 0;
		}
		return (int)data;
	}

	// Token: 0x060143D3 RID: 82899 RVA: 0x005E6E08 File Offset: 0x005E5008
	public UiCameraInputBindingData GetOrnamentTabCameraInputData(UUIDraggableComponent dragItem, TsUiSceneRoleActor roleActor, bool isHidingUi)
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
		return new UiCameraInputBindingData
		{
			DragComponent = dragItem,
			CameraSettingConfig = value2,
			CameraOffsetConfig = cameraOffsetConfig,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x060143D4 RID: 82900 RVA: 0x005E6EE8 File Offset: 0x005E50E8
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

	// Token: 0x060143D5 RID: 82901 RVA: 0x005E6F9F File Offset: 0x005E519F
	public int GetDefaultOrnamentId(int skinId)
	{
		return RoleOrnamentModel.Instance.GetSkinAllOrnaments(skinId, new bool?(true))[0];
	}

	// Token: 0x0400ABB3 RID: 43955
	private ISkinViewData ViewDataInternal;
}
