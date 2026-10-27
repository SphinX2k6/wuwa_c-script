using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.View
{
	// Token: 0x02004BF6 RID: 19446
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinViewModel : ViewModelBase<ERoleSkinTabViewData>
	{
		// Token: 0x06032498 RID: 205976 RVA: 0x00BAF0DC File Offset: 0x00BAD2DC
		public RoleSkinViewModel()
		{
			int num = 0;
			this.DataMap[ERoleSkinTabViewData.SelectRoleSkinId] = num;
			bool flag = false;
			this.DataMap[ERoleSkinTabViewData.IsWearWeaponSkin] = flag;
		}

		// Token: 0x06032499 RID: 205977 RVA: 0x00BAF118 File Offset: 0x00BAD318
		public void Init(ISkinViewData viewData)
		{
			if (this.GetSelectRoleSkinId() <= 0)
			{
				RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(viewData.RoleId);
				this.SetSelectRoleSkinId(roleInstanceById.GetRoleSkinId(), false);
			}
		}

		// Token: 0x0603249A RID: 205978 RVA: 0x00BAF14C File Offset: 0x00BAD34C
		public void SetSelectRoleSkinId(int selectRoleSkinId, bool notNotify = false)
		{
			base.SetData(ERoleSkinTabViewData.SelectRoleSkinId, selectRoleSkinId, notNotify);
		}

		// Token: 0x0603249B RID: 205979 RVA: 0x00BAF15C File Offset: 0x00BAD35C
		public int GetSelectRoleSkinId()
		{
			return (int)base.GetData(ERoleSkinTabViewData.SelectRoleSkinId);
		}

		// Token: 0x0603249C RID: 205980 RVA: 0x00BAF16A File Offset: 0x00BAD36A
		public void SetIsWearWeaponSkin(bool isWearWeaponSkin, bool notNotify = false)
		{
			base.SetData(ERoleSkinTabViewData.IsWearWeaponSkin, isWearWeaponSkin, notNotify);
		}

		// Token: 0x0603249D RID: 205981 RVA: 0x00BAF17A File Offset: 0x00BAD37A
		public bool GetIsWearWeaponSkin()
		{
			return (bool)base.GetData(ERoleSkinTabViewData.IsWearWeaponSkin);
		}

		// Token: 0x0603249E RID: 205982 RVA: 0x00BAF188 File Offset: 0x00BAD388
		public IUiCameraInputComponentData GetRoleTabCameraInputData(UUIDraggableComponent dragItem, TsUiSceneRoleActor roleActor)
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
			return new UiCameraInputComponentData
			{
				DragComponent = dragItem,
				CameraSettingConfig = roleCameraConfigBySkin.Value,
				CameraOffsetConfig = roleCameraOffsetConfig,
				SourceLocation = fvectorDouble
			};
		}
	}
}
