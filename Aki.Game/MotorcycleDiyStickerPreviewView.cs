using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022B0 RID: 8880
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyStickerPreviewView : UiViewBase
{
	// Token: 0x06011675 RID: 71285 RVA: 0x00443252 File Offset: 0x00441452
	public MotorcycleDiyStickerPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011676 RID: 71286 RVA: 0x00443270 File Offset: 0x00441470
	private List<SkinRewardData> GetPreviewReward(List<int> itemIdList)
	{
		List<SkinRewardData> list = new List<SkinRewardData>();
		int count = 1;
		foreach (int itemId in itemIdList)
		{
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(itemId, 0);
			SkinRewardData item = new SkinRewardData
			{
				ItemData = new TItem?(new TItem(itemData, count)),
				FinishState = false
			};
			list.Add(item);
		}
		list.Sort(delegate(SkinRewardData a, SkinRewardData b)
		{
			int num = (a.ItemData != null) ? a.ItemData.GetValueOrDefault().ItemData.ItemId : 0;
			int num2 = (b.ItemData != null) ? b.ItemData.GetValueOrDefault().ItemData.ItemId : 0;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(num2);
			int num3 = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num4 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			if (num3 != num4)
			{
				return num4 - num3;
			}
			return num - num2;
		});
		return list;
	}

	// Token: 0x06011677 RID: 71287 RVA: 0x00443314 File Offset: 0x00441514
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTogEyeClick))
		};
	}

	// Token: 0x06011678 RID: 71288 RVA: 0x00443418 File Offset: 0x00441618
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(2));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBackBtnClick));
		this.CaptionItem.SetHelpBtnActive(false);
		this.CaptionItem.SetTitleTextActive(false);
		this.CaptionItem.SetTitleIconVisible(false);
		int valueOrDefault = (this.OpenParam as int?).GetValueOrDefault();
		MotorGeneralPreview? motorGeneralPreviewConfig = MotorDiyConfig.Instance.GetMotorGeneralPreviewConfig(valueOrDefault);
		if (motorGeneralPreviewConfig == null)
		{
			return;
		}
		this.PreviewConfig = new MotorGeneralPreview?(motorGeneralPreviewConfig.Value);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), motorGeneralPreviewConfig.Value.IconTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorGeneralPreviewConfig.Value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), motorGeneralPreviewConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), motorGeneralPreviewConfig.Value.Describe, Array.Empty<object>());
		this.ItemRewardLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(6), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		List<SkinRewardData> previewReward = this.GetPreviewReward(motorGeneralPreviewConfig.Value.GetStickerArray().ToList<int>());
		this.ItemRewardLayout.RefreshByData(previewReward, null, false);
	}

	// Token: 0x06011679 RID: 71289 RVA: 0x00443597 File Offset: 0x00441797
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
	}

	// Token: 0x0601167A RID: 71290 RVA: 0x004435A0 File Offset: 0x004417A0
	protected override void OnBeforeShow()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		this.InitCameraInputData(this.PreviewConfig.Value.FreeCameraConfig);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
	}

	// Token: 0x0601167B RID: 71291 RVA: 0x004435DF File Offset: 0x004417DF
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0601167C RID: 71292 RVA: 0x004435EB File Offset: 0x004417EB
	protected override void OnAfterShow()
	{
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x0601167D RID: 71293 RVA: 0x00443604 File Offset: 0x00441804
	protected override void OnBeforeHide()
	{
		this.CameraInputComponent.End();
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x0601167E RID: 71294 RVA: 0x0044361C File Offset: 0x0044181C
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x0601167F RID: 71295 RVA: 0x00443624 File Offset: 0x00441824
	private void InitMotorModel()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		if (this.PreviewConfig == null)
		{
			return;
		}
		int frame = this.PreviewConfig.Value.Frame;
		int[] stickerArray = this.PreviewConfig.Value.GetStickerArray();
		MotorcycleUiModelParam param = new MotorcycleUiModelParam
		{
			FrameId = frame,
			StickerIds = stickerArray
		};
		MotorcycleUiModelUtil.Instance.LoadMotorByParam(param, null);
	}

	// Token: 0x06011680 RID: 71296 RVA: 0x00443694 File Offset: 0x00441894
	private void InitCameraInputData(string cameraRotateConfig)
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(cameraRotateConfig);
		if (roleCameraConfig == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("RoleCase").Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
		if (this.PreviewConfig != null)
		{
			this.CameraInputComponent.CanCameraInput = this.PreviewConfig.Value.IsFree;
		}
	}

	// Token: 0x06011681 RID: 71297 RVA: 0x00443744 File Offset: 0x00441944
	private void PushExCameraHandle()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		string handleName = this.IsNotHidingUi ? this.PreviewConfig.Value.CameraId : this.PreviewConfig.Value.FreeCamera;
		if (!this.PreviewConfig.Value.IsFree)
		{
			this.CameraInputComponent.CanCameraInput = !this.IsNotHidingUi;
		}
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x06011682 RID: 71298 RVA: 0x004437D7 File Offset: 0x004419D7
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.MotorcycleDiyStickerPreviewView, null);
	}

	// Token: 0x06011683 RID: 71299 RVA: 0x004437EC File Offset: 0x004419EC
	private void OnTogEyeClick(EToggleState toggleState)
	{
		this.IsNotHidingUi = !this.IsNotHidingUi;
		base.GetItem(3).SetUIActive(!this.IsNotHidingUi);
		bool state = this.IsNotHidingUi;
		if (state)
		{
			base.GetItem(3).SetUIActive(state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				this.GetItem(3).SetUIActive(state);
			}, true);
		}
		this.PushExCameraHandle();
	}

	// Token: 0x04008442 RID: 33858
	private bool IsNotHidingUi = true;

	// Token: 0x04008443 RID: 33859
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008444 RID: 33860
	private MotorGeneralPreview? PreviewConfig;

	// Token: 0x04008445 RID: 33861
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemRewardLayout;

	// Token: 0x04008446 RID: 33862
	protected UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0200881D RID: 34845
	[NullableContext(0)]
	private class EMotorDecorationPreviewComponent
	{
		// Token: 0x0402C3BB RID: 181179
		public const int DragComponent = 0;

		// Token: 0x0402C3BC RID: 181180
		public const int TogEye = 1;

		// Token: 0x0402C3BD RID: 181181
		public const int CaptionItem = 2;

		// Token: 0x0402C3BE RID: 181182
		public const int NotHideUIItem = 3;

		// Token: 0x0402C3BF RID: 181183
		public const int TxtTitle = 4;

		// Token: 0x0402C3C0 RID: 181184
		public const int TxtSubTitle = 5;

		// Token: 0x0402C3C1 RID: 181185
		public const int ItemRewardLayout = 6;

		// Token: 0x0402C3C2 RID: 181186
		public const int RewardItem = 7;

		// Token: 0x0402C3C3 RID: 181187
		public const int TxtDescription = 8;

		// Token: 0x0402C3C4 RID: 181188
		public const int TxtItemRewardTitle = 9;
	}
}
