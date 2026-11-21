using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02001FA3 RID: 8099
[NullableContext(2)]
[Nullable(0)]
public class FlySkinShowView : UiTickViewBase
{
	// Token: 0x06014108 RID: 82184 RVA: 0x005D8881 File Offset: 0x005D6A81
	[NullableContext(1)]
	public FlySkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014109 RID: 82185 RVA: 0x005D889C File Offset: 0x005D6A9C
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

	// Token: 0x0601410A RID: 82186 RVA: 0x005D8C7D File Offset: 0x005D6E7D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x0601410B RID: 82187 RVA: 0x005D8C9B File Offset: 0x005D6E9B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x0601410C RID: 82188 RVA: 0x005D8CBC File Offset: 0x005D6EBC
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

	// Token: 0x0601410D RID: 82189 RVA: 0x005D8E4B File Offset: 0x005D704B
	protected override void OnHandleLoadScene()
	{
		this.InitGliderObserver();
		this.InitCameraInputData();
	}

	// Token: 0x0601410E RID: 82190 RVA: 0x005D8E5C File Offset: 0x005D705C
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

	// Token: 0x0601410F RID: 82191 RVA: 0x005D8EAC File Offset: 0x005D70AC
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
		UiCameraInputBindingData data = new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
		this.CameraInputBinding.Configure(data);
	}

	// Token: 0x06014110 RID: 82192 RVA: 0x005D8F56 File Offset: 0x005D7156
	protected override void OnBeforeShow()
	{
		this.TryPushCamera();
		this.TryLoadModel();
		this.RefreshView();
	}

	// Token: 0x06014111 RID: 82193 RVA: 0x005D8F6C File Offset: 0x005D716C
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

	// Token: 0x06014112 RID: 82194 RVA: 0x005D9074 File Offset: 0x005D7274
	private void TryPushCamera()
	{
		string flySkinModelCameraId = SkinConfig.Instance.GetFlySkinModelCameraId(this.CurrentFlySkinType);
		this.WaitCameraId = flySkinModelCameraId;
		UiCameraModel.Instance.PushCameraHandleByHandleName(flySkinModelCameraId, true, true, "10010", false, null);
	}

	// Token: 0x06014113 RID: 82195 RVA: 0x005D90B0 File Offset: 0x005D72B0
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

	// Token: 0x06014114 RID: 82196 RVA: 0x005D91D9 File Offset: 0x005D73D9
	protected override void OnBeforeHide()
	{
		UiCameraInputBinding cameraInputBinding = this.CameraInputBinding;
		if (cameraInputBinding == null)
		{
			return;
		}
		cameraInputBinding.Unbind();
	}

	// Token: 0x06014115 RID: 82197 RVA: 0x005D91EB File Offset: 0x005D73EB
	protected override void OnBeforeDestroy()
	{
		this.DestroyGliderObserver();
	}

	// Token: 0x06014116 RID: 82198 RVA: 0x005D91F3 File Offset: 0x005D73F3
	private void DestroyGliderObserver()
	{
		UiSceneManager.Instance.DestroyGliderSkeletalHandle();
		this.GliderObserver = null;
	}

	// Token: 0x06014117 RID: 82199 RVA: 0x005D9206 File Offset: 0x005D7406
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014118 RID: 82200 RVA: 0x005D9210 File Offset: 0x005D7410
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
		if (state)
		{
			this.CameraInputBinding.Bind();
		}
		else
		{
			this.CameraInputBinding.Unbind();
		}
		this.TryPushCamera();
	}

	// Token: 0x06014119 RID: 82201 RVA: 0x005D92DF File Offset: 0x005D74DF
	[NullableContext(1)]
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetHandleName() == this.WaitCameraId)
		{
			this.WaitCameraId = null;
			if (!this.CanLoadModel)
			{
				this.CanLoadModel = true;
				this.TryLoadModel();
			}
		}
	}

	// Token: 0x0601411A RID: 82202 RVA: 0x005D9310 File Offset: 0x005D7510
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(318);
	}

	// Token: 0x0400AAAB RID: 43691
	private FlySkinData SkinData;

	// Token: 0x0400AAAC RID: 43692
	private EFlySkinType CurrentFlySkinType = EFlySkinType.Paragliding;

	// Token: 0x0400AAAD RID: 43693
	private SkeletalObserverHandle GliderObserver;

	// Token: 0x0400AAAE RID: 43694
	[Nullable(1)]
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400AAAF RID: 43695
	private string WaitCameraId;

	// Token: 0x0400AAB0 RID: 43696
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AAB1 RID: 43697
	private bool CanLoadModel;

	// Token: 0x020082A6 RID: 33446
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A33A RID: 172858
		CaptionItem,
		// Token: 0x0402A33B RID: 172859
		OnlyUiToggle,
		// Token: 0x0402A33C RID: 172860
		DetailIconButton,
		// Token: 0x0402A33D RID: 172861
		ButtonLeft,
		// Token: 0x0402A33E RID: 172862
		ButtonRight,
		// Token: 0x0402A33F RID: 172863
		TitleText,
		// Token: 0x0402A340 RID: 172864
		SubTitleText,
		// Token: 0x0402A341 RID: 172865
		SwitchItem,
		// Token: 0x0402A342 RID: 172866
		ToggleLeft,
		// Token: 0x0402A343 RID: 172867
		ExtraRewardItem,
		// Token: 0x0402A344 RID: 172868
		ExtraRewardContentHorizontalLayout,
		// Token: 0x0402A345 RID: 172869
		RewardItem,
		// Token: 0x0402A346 RID: 172870
		DescText,
		// Token: 0x0402A347 RID: 172871
		NotHaveRoleItem,
		// Token: 0x0402A348 RID: 172872
		BuyItemIcon,
		// Token: 0x0402A349 RID: 172873
		NowPrice,
		// Token: 0x0402A34A RID: 172874
		BeforePrice,
		// Token: 0x0402A34B RID: 172875
		BuyButton,
		// Token: 0x0402A34C RID: 172876
		DiscountItem,
		// Token: 0x0402A34D RID: 172877
		DiscountText,
		// Token: 0x0402A34E RID: 172878
		LeftTimeItem,
		// Token: 0x0402A34F RID: 172879
		LeftTimeText,
		// Token: 0x0402A350 RID: 172880
		QualityTexture,
		// Token: 0x0402A351 RID: 172881
		ItemTexture,
		// Token: 0x0402A352 RID: 172882
		FrameTexture,
		// Token: 0x0402A353 RID: 172883
		WeaponRootItem,
		// Token: 0x0402A354 RID: 172884
		WeaponTexture,
		// Token: 0x0402A355 RID: 172885
		HaveItem,
		// Token: 0x0402A356 RID: 172886
		HideUiParentItem,
		// Token: 0x0402A357 RID: 172887
		DragComponent,
		// Token: 0x0402A358 RID: 172888
		WeaponQualityTexture,
		// Token: 0x0402A359 RID: 172889
		ToggleRight,
		// Token: 0x0402A35A RID: 172890
		EffectItemB,
		// Token: 0x0402A35B RID: 172891
		EffectItemA,
		// Token: 0x0402A35C RID: 172892
		TextureToggleLeft,
		// Token: 0x0402A35D RID: 172893
		TextToggleLeft,
		// Token: 0x0402A35E RID: 172894
		TextureToggleRight,
		// Token: 0x0402A35F RID: 172895
		TextToggleRight,
		// Token: 0x0402A360 RID: 172896
		ItemGamePadKeyTipA = 45,
		// Token: 0x0402A361 RID: 172897
		ItemGamePadKeyTipB,
		// Token: 0x0402A362 RID: 172898
		ToggleLayout,
		// Token: 0x0402A363 RID: 172899
		ToggleMale,
		// Token: 0x0402A364 RID: 172900
		ToggleFemale,
		// Token: 0x0402A365 RID: 172901
		ExtraRewardText,
		// Token: 0x0402A366 RID: 172902
		ItemBuyPanel
	}
}
