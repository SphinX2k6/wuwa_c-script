using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A3B RID: 10811
[NullableContext(1)]
[Nullable(0)]
public class SpecialItemSummonShowView : UiTickViewBase
{
	// Token: 0x06016826 RID: 92198 RVA: 0x005B4F96 File Offset: 0x005B3196
	public SpecialItemSummonShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016827 RID: 92199 RVA: 0x005B4FB8 File Offset: 0x005B31B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(45, typeof(UUIItem)),
			new ValueTuple<int, Type>(46, typeof(UUIItem)),
			new ValueTuple<int, Type>(47, typeof(UUIItem)),
			new ValueTuple<int, Type>(50, typeof(UUIItem)),
			new ValueTuple<int, Type>(51, typeof(UUIItem)),
			new ValueTuple<int, Type>(52, typeof(UUIItem)),
			new ValueTuple<int, Type>(59, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(38, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickOnlyUiToggle))
		};
	}

	// Token: 0x06016828 RID: 92200 RVA: 0x005B5214 File Offset: 0x005B3414
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialItemSummonShowView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialItemSummonShowView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016829 RID: 92201 RVA: 0x005B5258 File Offset: 0x005B3458
	protected override void OnStart()
	{
		this.ItemId = (int)(this.OpenParam ?? 0);
		this.DisplayMontagePath = this.GetPreviewMontagePath();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.CaptionItem.SetTitleLocalText("SummonPreview");
		this.CaptionItem.SetTitleIconByResourceId("SummonPreviewTitle_Icon");
		this.CaptionItem.SetHelpBtnActive(true);
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
		this.HideRedundantNodes();
		this.SetupEffectPreviewButton();
		this.RefreshView();
	}

	// Token: 0x0601682A RID: 92202 RVA: 0x005B530B File Offset: 0x005B350B
	private void SetupEffectPreviewButton()
	{
		ButtonItem effectPreviewButton = this.EffectPreviewButton;
		if (effectPreviewButton != null)
		{
			effectPreviewButton.SetUiActive(true);
		}
		ButtonItem effectPreviewButton2 = this.EffectPreviewButton;
		if (effectPreviewButton2 != null)
		{
			effectPreviewButton2.SetEnableClick(false);
		}
		ButtonItem effectPreviewButton3 = this.EffectPreviewButton;
		if (effectPreviewButton3 == null)
		{
			return;
		}
		effectPreviewButton3.SetLocalTextNew("SummonPreviewIng", Array.Empty<object>());
	}

	// Token: 0x0601682B RID: 92203 RVA: 0x005B534C File Offset: 0x005B354C
	private void HideRedundantNodes()
	{
		foreach (int name in SpecialItemSummonShowView.DisableNodeList)
		{
			UUIItem item = base.GetItem(name);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
	}

	// Token: 0x0601682C RID: 92204 RVA: 0x005B5384 File Offset: 0x005B3584
	protected override void OnHandlePostLoadScene(bool isSceneLoad)
	{
		SpecialItemSummonUiModelUtil.CreateSummon();
		SpecialItemSummonUiModelUtil.SetTransform("SummonCase");
		this.InitCameraInputData();
	}

	// Token: 0x0601682D RID: 92205 RVA: 0x005B539C File Offset: 0x005B359C
	protected override void OnBeforeShow()
	{
		this.TryPushCamera(false);
		SpecialItemSummonUiModelUtil.ShowSummon(true);
		int previewModelId = this.GetPreviewModelId();
		if (previewModelId > 0)
		{
			SpecialItemSummonUiModelUtil.LoadSummon(previewModelId, this.DisplayMontagePath, new Action(this.OnSummonLoadFinished));
		}
		else
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.TZJ, "[SpecialItemSummon] modelId<=0 跳过加载模型", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.CameraInputComponent.Start();
		this.CameraInputComponent.TryActivate();
	}

	// Token: 0x0601682E RID: 92206 RVA: 0x005B540E File Offset: 0x005B360E
	private void OnSummonLoadFinished()
	{
		if (this.DisplayMontagePath == "")
		{
			return;
		}
		SpecialItemSummonUiModelUtil.PlayDisplayMontage(this.DisplayMontagePath, "Loop");
		this.SetEffectPreviewButtonEnable(true);
	}

	// Token: 0x0601682F RID: 92207 RVA: 0x005B543A File Offset: 0x005B363A
	protected override void OnBeforeHide()
	{
		this.CameraInputComponent.End();
	}

	// Token: 0x06016830 RID: 92208 RVA: 0x005B5447 File Offset: 0x005B3647
	protected override void OnHandleReleaseScene()
	{
		UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
		SpecialItemSummonUiModelUtil.DestroySummon();
	}

	// Token: 0x06016831 RID: 92209 RVA: 0x005B5464 File Offset: 0x005B3664
	private void TryPushCamera(bool useBlend = true)
	{
		UiCameraHandleData uiCameraHandleData = UiCameraHandleData.NewByHandleName("Cam_Summon", null);
		uiCameraHandleData.ViewName = "Cam_Summon";
		uiCameraHandleData.OwnerViewName = "SpecialItemSummonShowView";
		if (useBlend)
		{
			UiLayer.Instance.SetShowMaskLayer("SpecialItemSummonShowView", true);
			UiCameraAnimationManager.Instance.PushCameraHandle(uiCameraHandleData, true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("SpecialItemSummonShowView", false);
			});
			return;
		}
		UiCameraAnimationManager.Instance.PushCameraHandle(uiCameraHandleData, false, false, null, false, null);
	}

	// Token: 0x06016832 RID: 92210 RVA: 0x005B54F4 File Offset: 0x005B36F4
	private IUiCameraInputComponentData GetCameraInputData()
	{
		SUiRoleCameraSetting value = UiRoleCameraConfig.Instance.GetRoleCameraConfig("藏品预览界面").Value;
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SummonCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputComponentData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x06016833 RID: 92211 RVA: 0x005B5560 File Offset: 0x005B3760
	private void InitCameraInputData()
	{
		IUiCameraInputComponentData cameraInputData = this.GetCameraInputData();
		this.CameraInputComponent.InitData(cameraInputData);
		this.CameraInputComponent.CanCameraInput = false;
	}

	// Token: 0x06016834 RID: 92212 RVA: 0x005B558C File Offset: 0x005B378C
	private void UpdateCameraInputData()
	{
		IUiCameraInputComponentData cameraInputData = this.GetCameraInputData();
		this.CameraInputComponent.UpdateData(cameraInputData);
	}

	// Token: 0x06016835 RID: 92213 RVA: 0x005B55AC File Offset: 0x005B37AC
	private void RefreshView()
	{
		this.RefreshAssembleButton();
		InventoryConfig instance = InventoryConfig.Instance;
		ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(this.ItemId) : null;
		if (itemConfig == null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), itemConfig.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), itemConfig.BgDescription ?? "", Array.Empty<object>());
	}

	// Token: 0x06016836 RID: 92214 RVA: 0x005B5654 File Offset: 0x005B3854
	private void RefreshAssembleButton()
	{
		bool uiActive = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0) > 0;
		ButtonItem assembleButton = this.AssembleButton;
		if (assembleButton == null)
		{
			return;
		}
		assembleButton.SetUiActive(uiActive);
	}

	// Token: 0x06016837 RID: 92215 RVA: 0x005B5688 File Offset: 0x005B3888
	private int GetPreviewModelId()
	{
		SpecialItemConfig instance = SpecialItemConfig.Instance;
		SpecialItem? specialItem = (instance != null) ? instance.GetConfig(this.ItemId) : null;
		if (specialItem == null)
		{
			return 0;
		}
		return specialItem.GetValueOrDefault().PreviewModelId;
	}

	// Token: 0x06016838 RID: 92216 RVA: 0x005B56D0 File Offset: 0x005B38D0
	private string GetPreviewMontagePath()
	{
		SpecialItemConfig instance = SpecialItemConfig.Instance;
		SpecialItem? specialItem = (instance != null) ? instance.GetConfig(this.ItemId) : null;
		return ((specialItem != null) ? specialItem.GetValueOrDefault().PreviewMontage : null) ?? "";
	}

	// Token: 0x06016839 RID: 92217 RVA: 0x005B5721 File Offset: 0x005B3921
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601683A RID: 92218 RVA: 0x005B572A File Offset: 0x005B392A
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(672);
	}

	// Token: 0x0601683B RID: 92219 RVA: 0x005B573C File Offset: 0x005B393C
	private void OnClickAssembleButton(int data)
	{
		RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, new int?(this.ItemId), true);
	}

	// Token: 0x0601683C RID: 92220 RVA: 0x005B5774 File Offset: 0x005B3974
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
		this.CameraInputComponent.CanCameraInput = state;
		if (!state)
		{
			this.TryPushCamera(true);
			this.UpdateCameraInputData();
		}
	}

	// Token: 0x0601683D RID: 92221 RVA: 0x005B582A File Offset: 0x005B3A2A
	private void OnClickEffectPreviewButton(int data)
	{
		SpecialItemSummonUiModelUtil.JumpToDisplaySection(this.DisplayMontagePath, "Default");
		this.SetEffectPreviewButtonEnable(false);
		this.NeedCheckSection = true;
		this.SectionCheckElapsed = 0f;
	}

	// Token: 0x0601683E RID: 92222 RVA: 0x005B5858 File Offset: 0x005B3A58
	protected override void OnTick(float delta)
	{
		if (!this.NeedCheckSection)
		{
			return;
		}
		this.SectionCheckElapsed += delta;
		if (this.SectionCheckElapsed < 0.2f)
		{
			return;
		}
		this.SectionCheckElapsed = 0f;
		string text = SpecialItemSummonUiModelUtil.GetCurrentDisplaySection().ToString();
		if (text == null || !text.StartsWith("Loop"))
		{
			return;
		}
		this.NeedCheckSection = false;
		this.SetEffectPreviewButtonEnable(true);
	}

	// Token: 0x0601683F RID: 92223 RVA: 0x005B58C8 File Offset: 0x005B3AC8
	private void SetEffectPreviewButtonEnable(bool enable)
	{
		ButtonItem effectPreviewButton = this.EffectPreviewButton;
		if (effectPreviewButton != null)
		{
			effectPreviewButton.SetEnableClick(enable);
		}
		ButtonItem effectPreviewButton2 = this.EffectPreviewButton;
		if (effectPreviewButton2 == null)
		{
			return;
		}
		effectPreviewButton2.SetLocalTextNew(enable ? "PrefabTextItem_2948403725_Text" : "SummonPreviewIng", Array.Empty<object>());
	}

	// Token: 0x0400A72B RID: 42795
	private const string SUMMON_CASE_TAG = "SummonCase";

	// Token: 0x0400A72C RID: 42796
	private const string CAMERA_CONFIG_ID = "藏品预览界面";

	// Token: 0x0400A72D RID: 42797
	private const string CAMERA_HANDLE_NAME = "Cam_Summon";

	// Token: 0x0400A72E RID: 42798
	private const string VIEW_NAME = "SpecialItemSummonShowView";

	// Token: 0x0400A72F RID: 42799
	private const string LOOP_SECTION = "Loop";

	// Token: 0x0400A730 RID: 42800
	private const string DEFAULT_SECTION = "Default";

	// Token: 0x0400A731 RID: 42801
	private const string CAPTION_TITLE_KEY = "SummonPreview";

	// Token: 0x0400A732 RID: 42802
	private const string CAPTION_ICON_RESOURCE_ID = "SummonPreviewTitle_Icon";

	// Token: 0x0400A733 RID: 42803
	private const string ASSEMBLE_BUTTON_TEXT_KEY = "GoToSummonAssemble";

	// Token: 0x0400A734 RID: 42804
	private const string EFFECT_PREVIEW_ENABLE_TEXT_KEY = "PrefabTextItem_2948403725_Text";

	// Token: 0x0400A735 RID: 42805
	private const string EFFECT_PREVIEW_DISABLE_TEXT_KEY = "SummonPreviewIng";

	// Token: 0x0400A736 RID: 42806
	private const int HELP_GROUP_ID = 672;

	// Token: 0x0400A737 RID: 42807
	private const float SECTION_CHECK_INTERVAL = 0.2f;

	// Token: 0x0400A738 RID: 42808
	[StaticVariableRuleIgnore]
	private static readonly int[] DisableNodeList = new int[]
	{
		2,
		3,
		4,
		6,
		7,
		8,
		9,
		13,
		31,
		45,
		46,
		47,
		50,
		38,
		52
	};

	// Token: 0x0400A739 RID: 42809
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A73A RID: 42810
	private int ItemId;

	// Token: 0x0400A73B RID: 42811
	public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

	// Token: 0x0400A73C RID: 42812
	private bool NeedCheckSection;

	// Token: 0x0400A73D RID: 42813
	private float SectionCheckElapsed;

	// Token: 0x0400A73E RID: 42814
	private string DisplayMontagePath = "";

	// Token: 0x0400A73F RID: 42815
	[Nullable(2)]
	private ButtonItem AssembleButton;

	// Token: 0x0400A740 RID: 42816
	[Nullable(2)]
	private ButtonItem EffectPreviewButton;
}
