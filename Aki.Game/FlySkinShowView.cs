using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002A28 RID: 10792
[NullableContext(2)]
[Nullable(0)]
public class FlySkinShowView : UiTickViewBase
{
	// Token: 0x06016702 RID: 91906 RVA: 0x005AD840 File Offset: 0x005ABA40
	[NullableContext(1)]
	public FlySkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016703 RID: 91907 RVA: 0x005AD85C File Offset: 0x005ABA5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUITexture)),
			new ValueTuple<int, Type>(24, typeof(UUITexture)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUITexture)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(30, typeof(UUITexture)),
			new ValueTuple<int, Type>(31, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(32, typeof(UUIItem)),
			new ValueTuple<int, Type>(33, typeof(UUIItem)),
			new ValueTuple<int, Type>(34, typeof(UUITexture)),
			new ValueTuple<int, Type>(35, typeof(UUIText)),
			new ValueTuple<int, Type>(36, typeof(UUITexture)),
			new ValueTuple<int, Type>(37, typeof(UUIText)),
			new ValueTuple<int, Type>(45, typeof(UUIItem)),
			new ValueTuple<int, Type>(46, typeof(UUIItem)),
			new ValueTuple<int, Type>(51, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle))
		};
	}

	// Token: 0x06016704 RID: 91908 RVA: 0x005ADC3D File Offset: 0x005ABE3D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06016705 RID: 91909 RVA: 0x005ADC5B File Offset: 0x005ABE5B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06016706 RID: 91910 RVA: 0x005ADC7C File Offset: 0x005ABE7C
	protected override void OnStart()
	{
		int itemId = (int)(this.OpenParam ?? 0);
		this.SkinData = FlySkinModel.Instance.GetFlySkinData(itemId);
		if (this.SkinData != null)
		{
			this.CurrentFlySkinType = (EFlySkinType)this.SkinData.GetFlySkinConfig().SkinType;
		}
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.CaptionItem.SetTitleLocalText("FlySkinShopTitle_Text");
		this.CaptionItem.SetTitleIconByResourceId("FlySkinShopTitle_Icon");
		this.CaptionItem.SetHelpBtnActive(false);
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		base.GetItem(7).SetUIActive(false);
		base.GetItem(25).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(46);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(51);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x06016707 RID: 91911 RVA: 0x005ADE0B File Offset: 0x005AC00B
	protected override void OnHandleLoadScene()
	{
		this.InitGliderObserver();
		this.InitCameraInputData();
	}

	// Token: 0x06016708 RID: 91912 RVA: 0x005ADE1C File Offset: 0x005AC01C
	private void InitGliderObserver()
	{
		UiSceneManager.Instance.InitGliderSkeletalHandle();
		SkeletalObserverHandle gliderSkeletalHandle = UiSceneManager.Instance.GetGliderSkeletalHandle();
		if (gliderSkeletalHandle == null)
		{
			return;
		}
		UiModelBase model = gliderSkeletalHandle.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag(FlySkinDefine.DEFAULT_FLY_SKIN_CASE);
		}
		this.GliderObserver = gliderSkeletalHandle;
	}

	// Token: 0x06016709 RID: 91913 RVA: 0x005ADE6C File Offset: 0x005AC06C
	public void InitCameraInputData()
	{
		string rowName = "翱翔滑翔皮肤旋转查看";
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig(rowName);
		if (roleCameraConfig == null)
		{
			return;
		}
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		if (((gliderObserver != null) ? gliderObserver.Model : null) == null)
		{
			return;
		}
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(FlySkinDefine.flySkinTypeToCase[this.CurrentFlySkinType]).Value, ECollectActorType.UI);
		if (actorWithTag == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = actorWithTag.D_K2_GetActorLocation();
		UiCameraInputComponentData data = new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputComponent.InitData(data);
		this.CameraInputComponent.CanCameraInput = false;
	}

	// Token: 0x0601670A RID: 91914 RVA: 0x005ADF22 File Offset: 0x005AC122
	protected override void OnBeforeShow()
	{
		this.TryPushCamera();
		this.TryLoadModel();
		this.RefreshView();
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x0601670B RID: 91915 RVA: 0x005ADF50 File Offset: 0x005AC150
	private void RefreshView()
	{
		if (this.SkinData == null)
		{
			return;
		}
		bool uiactive = this.SkinData.GetSkinGrade() == 1;
		base.GetItem(33).SetUIActive(uiactive);
		base.GetItem(32).SetUIActive(uiactive);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.SkinData.GetTitleName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), this.SkinData.GetSubTitle(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), this.SkinData.GetDesc(), Array.Empty<object>());
		base.SetTextureByPath(this.SkinData.GetPreviewTextureInBuyView(), base.GetTexture(23), null, null);
		base.SetTextureByPath(this.SkinData.GetBuyPreviewQualityBgPath(), base.GetTexture(22), null, null);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(20).SetUIActive(false);
	}

	// Token: 0x0601670C RID: 91916 RVA: 0x005AE058 File Offset: 0x005AC258
	private void TryPushCamera()
	{
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.CurrentFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null, null);
	}

	// Token: 0x0601670D RID: 91917 RVA: 0x005AE09C File Offset: 0x005AC29C
	public void TryLoadModel()
	{
		SkeletalObserverHandle gliderObserver = this.GliderObserver;
		UiModelBase uiModelBase = (gliderObserver != null) ? gliderObserver.Model : null;
		if (uiModelBase == null)
		{
			return;
		}
		string transformByTag = FlySkinDefine.flySkinTypeToCase[this.CurrentFlySkinType];
		if (!this.CanLoadModel)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
			UiModelActorComponent uiModelActorComponent = uiModelBase.CheckGetComponent<UiModelActorComponent>();
			if (uiModelActorComponent == null)
			{
				return;
			}
			uiModelActorComponent.SetTransformByTag(transformByTag);
			return;
		}
		else
		{
			SkinConfig instance = SkinConfig.Instance;
			EFlySkinType currentFlySkinType = this.CurrentFlySkinType;
			FlySkinConfig flySkinConfig = this.SkinData.GetFlySkinConfig();
			string standAnimPath = flySkinConfig.StandAnim;
			string flySkinSpawnEffectId = instance.GetFlySkinSpawnEffectId(currentFlySkinType);
			string flySkinSpawnMaterialController = instance.GetFlySkinSpawnMaterialController(currentFlySkinType);
			string effectPath = EffectUtil.GetEffectPath(flySkinSpawnEffectId);
			string changeMaterialControllerPath = EffectUtil.GetEffectPath(flySkinSpawnMaterialController);
			List<string> extraResourceList = new List<string>
			{
				standAnimPath,
				effectPath,
				changeMaterialControllerPath
			};
			UiModelLoadComponent loadComponent = uiModelBase.CheckGetComponent<UiModelLoadComponent>();
			if (loadComponent == null)
			{
				return;
			}
			UiModelActorComponent uiModelActorComponent2 = uiModelBase.CheckGetComponent<UiModelActorComponent>();
			if (uiModelActorComponent2 != null)
			{
				uiModelActorComponent2.SetTransformByTag(transformByTag);
			}
			Action loadFinishCallBack = delegate()
			{
				SkeletalObserverHandle gliderObserver2 = this.GliderObserver;
				UiModelBase uiModelBase2 = (gliderObserver2 != null) ? gliderObserver2.Model : null;
				if (uiModelBase2 == null)
				{
					return;
				}
				UiModelUtil.Instance.SetVisible(uiModelBase2, true);
				UiModelLoadComponent loadComponent = loadComponent;
				UAnimationAsset uanimationAsset = ((loadComponent != null) ? loadComponent.GetLoadedResource(standAnimPath) : null) as UAnimationAsset;
				if (uanimationAsset == null)
				{
					Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.CXJ, "[FlySkin] 商城飞行皮肤待机动画预加载失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				UiModelAnimationComponent uiModelAnimationComponent = uiModelBase2.CheckGetComponent<UiModelAnimationComponent>();
				if (uanimationAsset != null && uiModelAnimationComponent != null)
				{
					uiModelAnimationComponent.PlayAnimation(uanimationAsset, true);
				}
				UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = uiModelBase2.CheckGetComponent<UiModelRenderingMaterialComponent>();
				PD_CharacterControllerData_C pd_CharacterControllerData_C = loadComponent.GetLoadedResource(changeMaterialControllerPath) as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
				}
				UiModelUtil.Instance.PlayEffectOnRoot(uiModelBase2, "GliderEffect");
			};
			loadComponent.LoadModelByModelId(flySkinConfig.ModelId, true, loadFinishCallBack, extraResourceList);
			return;
		}
	}

	// Token: 0x0601670E RID: 91918 RVA: 0x005AE1C5 File Offset: 0x005AC3C5
	protected override void OnBeforeHide()
	{
		UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
		if (cameraInputComponent == null)
		{
			return;
		}
		cameraInputComponent.End();
	}

	// Token: 0x0601670F RID: 91919 RVA: 0x005AE1D7 File Offset: 0x005AC3D7
	protected override void OnBeforeDestroy()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		this.DestroyGliderObserver();
	}

	// Token: 0x06016710 RID: 91920 RVA: 0x005AE1F3 File Offset: 0x005AC3F3
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x06016711 RID: 91921 RVA: 0x005AE206 File Offset: 0x005AC406
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016712 RID: 91922 RVA: 0x005AE210 File Offset: 0x005AC410
	private void OnClickOnlyUiToggle(EToggleState toggleState)
	{
		bool state = base.GetItem(28).bIsUIActive;
		if (!state)
		{
			base.GetItem(28).SetUIActive(!state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
		}
		else
		{
			base.PlaySequence("UiOut", delegate
			{
				if (this.IsDestroyOrDestroying)
				{
					return;
				}
				this.GetItem(28).SetUIActive(!state);
			}, true);
		}
		UUIItem item = base.GetItem(46);
		if (item != null)
		{
			item.SetUIActive(state);
		}
		this.CameraInputComponent.CanCameraInput = state;
		this.TryPushCamera();
	}

	// Token: 0x06016713 RID: 91923 RVA: 0x005AE2D0 File Offset: 0x005AC4D0
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.HandleName == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x06016714 RID: 91924 RVA: 0x005AE301 File Offset: 0x005AC501
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(318);
	}

	// Token: 0x0400A6C1 RID: 42689
	private FlySkinData SkinData;

	// Token: 0x0400A6C2 RID: 42690
	private EFlySkinType CurrentFlySkinType = EFlySkinType.Paragliding;

	// Token: 0x0400A6C3 RID: 42691
	private SkeletalObserverHandle GliderObserver;

	// Token: 0x0400A6C4 RID: 42692
	[Nullable(1)]
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400A6C5 RID: 42693
	private string WaitCameraId;

	// Token: 0x0400A6C6 RID: 42694
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A6C7 RID: 42695
	private bool CanLoadModel;

	// Token: 0x0200905F RID: 36959
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EC42 RID: 191554
		CaptionItem,
		// Token: 0x0402EC43 RID: 191555
		OnlyUiToggle,
		// Token: 0x0402EC44 RID: 191556
		DetailIconButton,
		// Token: 0x0402EC45 RID: 191557
		ButtonLeft,
		// Token: 0x0402EC46 RID: 191558
		ButtonRight,
		// Token: 0x0402EC47 RID: 191559
		TitleText,
		// Token: 0x0402EC48 RID: 191560
		SubTitleText,
		// Token: 0x0402EC49 RID: 191561
		SwitchItem,
		// Token: 0x0402EC4A RID: 191562
		ToggleLeft,
		// Token: 0x0402EC4B RID: 191563
		ExtraRewardItem,
		// Token: 0x0402EC4C RID: 191564
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402EC4D RID: 191565
		RewardItem,
		// Token: 0x0402EC4E RID: 191566
		DescText,
		// Token: 0x0402EC4F RID: 191567
		NotHaveRoleItem,
		// Token: 0x0402EC50 RID: 191568
		BuyItemIcon,
		// Token: 0x0402EC51 RID: 191569
		NowPrice,
		// Token: 0x0402EC52 RID: 191570
		BeforePrice,
		// Token: 0x0402EC53 RID: 191571
		BuyButton,
		// Token: 0x0402EC54 RID: 191572
		DiscountItem,
		// Token: 0x0402EC55 RID: 191573
		DiscountText,
		// Token: 0x0402EC56 RID: 191574
		LeftTimeItem,
		// Token: 0x0402EC57 RID: 191575
		LeftTimeText,
		// Token: 0x0402EC58 RID: 191576
		QualityTexture,
		// Token: 0x0402EC59 RID: 191577
		ItemTexture,
		// Token: 0x0402EC5A RID: 191578
		FrameTexture,
		// Token: 0x0402EC5B RID: 191579
		WeaponRootItem,
		// Token: 0x0402EC5C RID: 191580
		WeaponTexture,
		// Token: 0x0402EC5D RID: 191581
		HaveItem,
		// Token: 0x0402EC5E RID: 191582
		HideUiParentItem,
		// Token: 0x0402EC5F RID: 191583
		DragComponent,
		// Token: 0x0402EC60 RID: 191584
		WeaponQualityTexture,
		// Token: 0x0402EC61 RID: 191585
		ToggleRight,
		// Token: 0x0402EC62 RID: 191586
		EffectItemB,
		// Token: 0x0402EC63 RID: 191587
		EffectItemA,
		// Token: 0x0402EC64 RID: 191588
		TextureToggleLeft,
		// Token: 0x0402EC65 RID: 191589
		TextToggleLeft,
		// Token: 0x0402EC66 RID: 191590
		TextureToggleRight,
		// Token: 0x0402EC67 RID: 191591
		TextToggleRight,
		// Token: 0x0402EC68 RID: 191592
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402EC69 RID: 191593
		ItemGamePadKeyTipB,
		// Token: 0x0402EC6A RID: 191594
		ToggleLayout,
		// Token: 0x0402EC6B RID: 191595
		ToggleMale,
		// Token: 0x0402EC6C RID: 191596
		ToggleFemale,
		// Token: 0x0402EC6D RID: 191597
		ExtraRewardText,
		// Token: 0x0402EC6E RID: 191598
		ItemBuyPanel
	}
}
