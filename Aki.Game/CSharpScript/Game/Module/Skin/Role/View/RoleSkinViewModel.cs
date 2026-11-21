using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.View
{
	// Token: 0x02003BA7 RID: 15271
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinViewModel : ViewModelBase<ERoleSkinTabViewData>
	{
		// Token: 0x0602723E RID: 160318 RVA: 0x00AF36DC File Offset: 0x00AF18DC
		public RoleSkinViewModel()
		{
			int num = 0;
			this.DataMap[ERoleSkinTabViewData.SelectRoleSkinId] = num;
			bool flag = false;
			this.DataMap[ERoleSkinTabViewData.IsWearWeaponSkin] = flag;
		}

		// Token: 0x0602723F RID: 160319 RVA: 0x00AF3718 File Offset: 0x00AF1918
		public void Init(ISkinViewData viewData)
		{
			if (this.GetSelectRoleSkinId() <= 0)
			{
				RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(viewData.RoleId);
				this.SetSelectRoleSkinId(roleInstanceById.GetRoleSkinId(), false);
			}
		}

		// Token: 0x06027240 RID: 160320 RVA: 0x00AF374C File Offset: 0x00AF194C
		public void SetSelectRoleSkinId(int selectRoleSkinId, bool notNotify = false)
		{
			base.SetData(ERoleSkinTabViewData.SelectRoleSkinId, selectRoleSkinId, notNotify);
		}

		// Token: 0x06027241 RID: 160321 RVA: 0x00AF375C File Offset: 0x00AF195C
		public int GetSelectRoleSkinId()
		{
			return (int)base.GetData(ERoleSkinTabViewData.SelectRoleSkinId);
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x00AF376A File Offset: 0x00AF196A
		public void SetIsWearWeaponSkin(bool isWearWeaponSkin, bool notNotify = false)
		{
			base.SetData(ERoleSkinTabViewData.IsWearWeaponSkin, isWearWeaponSkin, notNotify);
		}

		// Token: 0x06027243 RID: 160323 RVA: 0x00AF377A File Offset: 0x00AF197A
		public bool GetIsWearWeaponSkin()
		{
			return (bool)base.GetData(ERoleSkinTabViewData.IsWearWeaponSkin);
		}

		// Token: 0x06027244 RID: 160324 RVA: 0x00AF3788 File Offset: 0x00AF1988
		public UiCameraInputBindingData GetRoleTabCameraInputData(UUIDraggableComponent dragItem, TsUiSceneRoleActor roleActor)
		{
			string rowName = this.GetIsWearWeaponSkin() ? PayShopConfig.Instance.GetBuySkinDetailWeaponCameraConfigId() : PayShopConfig.Instance.GetBuySkinDetailRoleCameraConfigId();
			int selectRoleSkinId = this.GetSelectRoleSkinId();
			SUiRoleCameraSetting? roleCameraConfigBySkin = UiRoleCameraConfig.Instance.GetRoleCameraConfigBySkin(rowName, selectRoleSkinId);
			FVectorDouble fvectorDouble = roleActor.D_K2_GetActorLocation();
			UiRoleDataComponent uiRoleDataComponent;
			if (roleActor == null)
			{
				uiRoleDataComponent = null;
			}
			else
			{
				UiModelBase model = roleActor.Model;
				uiRoleDataComponent = ((model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null);
			}
			int roleConfigId = uiRoleDataComponent.RoleConfigId;
			string roleBody = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value.RoleBody;
			SUiRoleCameraOffsetSetting? roleCameraOffsetConfig = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody);
			return new UiCameraInputBindingData
			{
				DragComponent = dragItem,
				CameraSettingConfig = roleCameraConfigBySkin.Value,
				CameraOffsetConfig = roleCameraOffsetConfig,
				SourceLocation = fvectorDouble
			};
		}
	}
}
