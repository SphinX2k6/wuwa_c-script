using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001794 RID: 6036
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyStickerPreviewView : UiViewBase
{
	// Token: 0x0600EB0D RID: 60173 RVA: 0x0044FE4A File Offset: 0x0044E04A
	public MotorcycleDiyStickerPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EB0E RID: 60174 RVA: 0x0044FE68 File Offset: 0x0044E068
	private List<SkinRewardData> GetPreviewReward(IEnumerable<int> itemIdList)
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

	// Token: 0x0600EB0F RID: 60175 RVA: 0x0044FF08 File Offset: 0x0044E108
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

	// Token: 0x0600EB10 RID: 60176 RVA: 0x0045000C File Offset: 0x0044E20C
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
		List<SkinRewardData> previewReward = this.GetPreviewReward(motorGeneralPreviewConfig.Value.GetStickerArray());
		this.ItemRewardLayout.RefreshByData(previewReward, null, false);
	}

	// Token: 0x0600EB11 RID: 60177 RVA: 0x00450186 File Offset: 0x0044E386
	protected override void OnHandleLoadScene()
	{
		this.InitMotorModel();
	}

	// Token: 0x0600EB12 RID: 60178 RVA: 0x00450190 File Offset: 0x0044E390
	protected override void OnBeforeShow()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		this.InitCameraInputData(this.PreviewConfig.Value.FreeCameraConfig);
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
	}

	// Token: 0x0600EB13 RID: 60179 RVA: 0x004501CF File Offset: 0x0044E3CF
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600EB14 RID: 60180 RVA: 0x004501DC File Offset: 0x0044E3DC
	protected override void OnAfterShow()
	{
		if (this.PreviewConfig != null && this.PreviewConfig.GetValueOrDefault().IsFree)
		{
			this.CameraInputBinding.Bind();
		}
	}

	// Token: 0x0600EB15 RID: 60181 RVA: 0x00450215 File Offset: 0x0044E415
	protected override void OnBeforeHide()
	{
		this.CameraInputBinding.Unbind();
		MotorcycleUiModelUtil.Instance.ShowMotor(false);
	}

	// Token: 0x0600EB16 RID: 60182 RVA: 0x0045022D File Offset: 0x0044E42D
	private SkinRewardItemGrid InitGridItem()
	{
		return new SkinRewardItemGrid();
	}

	// Token: 0x0600EB17 RID: 60183 RVA: 0x00450234 File Offset: 0x0044E434
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

	// Token: 0x0600EB18 RID: 60184 RVA: 0x004502A4 File Offset: 0x0044E4A4
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
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(0),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x0600EB19 RID: 60185 RVA: 0x00450328 File Offset: 0x0044E528
	private void PushExCameraHandle()
	{
		if (this.PreviewConfig == null)
		{
			return;
		}
		string handleName = this.IsNotHidingUi ? this.PreviewConfig.Value.CameraId : this.PreviewConfig.Value.FreeCamera;
		if (!this.PreviewConfig.Value.IsFree)
		{
			if (this.IsNotHidingUi)
			{
				this.CameraInputBinding.Unbind();
			}
			else
			{
				this.CameraInputBinding.Bind();
			}
		}
		UiCameraModel.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null);
	}

	// Token: 0x0600EB1A RID: 60186 RVA: 0x004503BE File Offset: 0x0044E5BE
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.MotorcycleDiyStickerPreviewView, null);
	}

	// Token: 0x0600EB1B RID: 60187 RVA: 0x004503D0 File Offset: 0x0044E5D0
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

	// Token: 0x04008580 RID: 34176
	private bool IsNotHidingUi = true;

	// Token: 0x04008581 RID: 34177
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008582 RID: 34178
	private MotorGeneralPreview? PreviewConfig;

	// Token: 0x04008583 RID: 34179
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemRewardLayout;

	// Token: 0x04008584 RID: 34180
	protected UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x020079A1 RID: 31137
	[NullableContext(0)]
	private class EMotorDecorationPreviewComponent
	{
		// Token: 0x040276C0 RID: 161472
		public const int DragComponent = 0;

		// Token: 0x040276C1 RID: 161473
		public const int TogEye = 1;

		// Token: 0x040276C2 RID: 161474
		public const int CaptionItem = 2;

		// Token: 0x040276C3 RID: 161475
		public const int NotHideUIItem = 3;

		// Token: 0x040276C4 RID: 161476
		public const int TxtTitle = 4;

		// Token: 0x040276C5 RID: 161477
		public const int TxtSubTitle = 5;

		// Token: 0x040276C6 RID: 161478
		public const int ItemRewardLayout = 6;

		// Token: 0x040276C7 RID: 161479
		public const int RewardItem = 7;

		// Token: 0x040276C8 RID: 161480
		public const int TxtDescription = 8;

		// Token: 0x040276C9 RID: 161481
		public const int TxtItemRewardTitle = 9;
	}
}
