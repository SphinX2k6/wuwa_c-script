using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FB6 RID: 8118
[NullableContext(1)]
[Nullable(0)]
public class SpecialItemSummonShowView : UiTickViewBase
{
	// Token: 0x06014248 RID: 82504 RVA: 0x005E1161 File Offset: 0x005DF361
	public SpecialItemSummonShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014249 RID: 82505 RVA: 0x005E1180 File Offset: 0x005DF380
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

	// Token: 0x0601424A RID: 82506 RVA: 0x005E13DC File Offset: 0x005DF5DC
	protected override UniTask OnBeforeStartAsync()
	{
		SpecialItemSummonShowView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialItemSummonShowView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601424B RID: 82507 RVA: 0x005E1420 File Offset: 0x005DF620
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

	// Token: 0x0601424C RID: 82508 RVA: 0x005E14D3 File Offset: 0x005DF6D3
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

	// Token: 0x0601424D RID: 82509 RVA: 0x005E1514 File Offset: 0x005DF714
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

	// Token: 0x0601424E RID: 82510 RVA: 0x005E154C File Offset: 0x005DF74C
	protected override void OnHandlePostLoadScene(bool isSceneLoad)
	{
		SpecialItemSummonUiModelUtil.CreateSummon();
		SpecialItemSummonUiModelUtil.SetTransform("SummonCase");
		this.InitCameraInputData();
	}

	// Token: 0x0601424F RID: 82511 RVA: 0x005E1564 File Offset: 0x005DF764
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
		this.CameraInputBinding.Unbind();
	}

	// Token: 0x06014250 RID: 82512 RVA: 0x005E15CA File Offset: 0x005DF7CA
	private void OnSummonLoadFinished()
	{
		if (this.DisplayMontagePath == "")
		{
			return;
		}
		SpecialItemSummonUiModelUtil.PlayDisplayMontage(this.DisplayMontagePath, "Loop");
		this.SetEffectPreviewButtonEnable(true);
	}

	// Token: 0x06014251 RID: 82513 RVA: 0x005E15F6 File Offset: 0x005DF7F6
	protected override void OnBeforeHide()
	{
		this.CameraInputBinding.Unbind();
	}

	// Token: 0x06014252 RID: 82514 RVA: 0x005E1603 File Offset: 0x005DF803
	protected override void OnHandleReleaseScene()
	{
		SpecialItemSummonUiModelUtil.DestroySummon();
	}

	// Token: 0x06014253 RID: 82515 RVA: 0x005E160C File Offset: 0x005DF80C
	private void TryPushCamera(bool useBlend = true)
	{
		UiCameraHandleData handleData = UiCameraUtil.CreateHandleData("Cam_Summon", "Cam_Summon");
		if (useBlend)
		{
			UiLayer.Instance.SetShowMaskLayer("SpecialItemSummonShowView", true);
			UiCameraModel.Instance.PushCameraHandle(handleData, true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("SpecialItemSummonShowView", false);
			});
			return;
		}
		UiCameraModel.Instance.PushCameraHandle(handleData, false, false, null, false, null);
	}

	// Token: 0x06014254 RID: 82516 RVA: 0x005E1684 File Offset: 0x005DF884
	private UiCameraInputBindingData GetCameraInputData()
	{
		SUiRoleCameraSetting value = UiRoleCameraConfig.Instance.GetRoleCameraConfig("藏品预览界面").Value;
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SummonCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputBindingData
		{
			DragComponent = base.GetDraggable(29),
			CameraSettingConfig = value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x06014255 RID: 82517 RVA: 0x005E16F0 File Offset: 0x005DF8F0
	private void InitCameraInputData()
	{
		UiCameraInputBindingData cameraInputData = this.GetCameraInputData();
		this.CameraInputBinding.Configure(cameraInputData);
	}

	// Token: 0x06014256 RID: 82518 RVA: 0x005E1710 File Offset: 0x005DF910
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

	// Token: 0x06014257 RID: 82519 RVA: 0x005E17B8 File Offset: 0x005DF9B8
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

	// Token: 0x06014258 RID: 82520 RVA: 0x005E17EC File Offset: 0x005DF9EC
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

	// Token: 0x06014259 RID: 82521 RVA: 0x005E1834 File Offset: 0x005DFA34
	private string GetPreviewMontagePath()
	{
		SpecialItemConfig instance = SpecialItemConfig.Instance;
		SpecialItem? specialItem = (instance != null) ? instance.GetConfig(this.ItemId) : null;
		return ((specialItem != null) ? specialItem.GetValueOrDefault().PreviewMontage : null) ?? "";
	}

	// Token: 0x0601425A RID: 82522 RVA: 0x005E1885 File Offset: 0x005DFA85
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601425B RID: 82523 RVA: 0x005E188E File Offset: 0x005DFA8E
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(672);
	}

	// Token: 0x0601425C RID: 82524 RVA: 0x005E18A0 File Offset: 0x005DFAA0
	private void OnClickAssembleButton(int data)
	{
		RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, new int?(this.ItemId), true);
	}

	// Token: 0x0601425D RID: 82525 RVA: 0x005E18D8 File Offset: 0x005DFAD8
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
		if (state)
		{
			this.CameraInputBinding.Bind();
			return;
		}
		this.CameraInputBinding.Unbind();
		this.TryPushCamera(true);
		this.InitCameraInputData();
	}

	// Token: 0x0601425E RID: 82526 RVA: 0x005E1994 File Offset: 0x005DFB94
	private void OnClickEffectPreviewButton(int data)
	{
		SpecialItemSummonUiModelUtil.JumpToDisplaySection(this.DisplayMontagePath, "Default");
		this.SetEffectPreviewButtonEnable(false);
		this.NeedCheckSection = true;
		this.SectionCheckElapsed = 0f;
	}

	// Token: 0x0601425F RID: 82527 RVA: 0x005E19C0 File Offset: 0x005DFBC0
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

	// Token: 0x06014260 RID: 82528 RVA: 0x005E1A30 File Offset: 0x005DFC30
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

	// Token: 0x0400AB2F RID: 43823
	private const string SUMMON_CASE_TAG = "SummonCase";

	// Token: 0x0400AB30 RID: 43824
	private const string CAMERA_CONFIG_ID = "藏品预览界面";

	// Token: 0x0400AB31 RID: 43825
	private const string CAMERA_HANDLE_NAME = "Cam_Summon";

	// Token: 0x0400AB32 RID: 43826
	private const string VIEW_NAME = "SpecialItemSummonShowView";

	// Token: 0x0400AB33 RID: 43827
	private const string LOOP_SECTION = "Loop";

	// Token: 0x0400AB34 RID: 43828
	private const string DEFAULT_SECTION = "Default";

	// Token: 0x0400AB35 RID: 43829
	private const string CAPTION_TITLE_KEY = "SummonPreview";

	// Token: 0x0400AB36 RID: 43830
	private const string CAPTION_ICON_RESOURCE_ID = "SummonPreviewTitle_Icon";

	// Token: 0x0400AB37 RID: 43831
	private const string ASSEMBLE_BUTTON_TEXT_KEY = "GoToSummonAssemble";

	// Token: 0x0400AB38 RID: 43832
	private const string EFFECT_PREVIEW_ENABLE_TEXT_KEY = "PrefabTextItem_2948403725_Text";

	// Token: 0x0400AB39 RID: 43833
	private const string EFFECT_PREVIEW_DISABLE_TEXT_KEY = "SummonPreviewIng";

	// Token: 0x0400AB3A RID: 43834
	private const int HELP_GROUP_ID = 672;

	// Token: 0x0400AB3B RID: 43835
	private const float SECTION_CHECK_INTERVAL = 0.2f;

	// Token: 0x0400AB3C RID: 43836
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

	// Token: 0x0400AB3D RID: 43837
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AB3E RID: 43838
	private int ItemId;

	// Token: 0x0400AB3F RID: 43839
	public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

	// Token: 0x0400AB40 RID: 43840
	private bool NeedCheckSection;

	// Token: 0x0400AB41 RID: 43841
	private float SectionCheckElapsed;

	// Token: 0x0400AB42 RID: 43842
	private string DisplayMontagePath = "";

	// Token: 0x0400AB43 RID: 43843
	[Nullable(2)]
	private ButtonItem AssembleButton;

	// Token: 0x0400AB44 RID: 43844
	[Nullable(2)]
	private ButtonItem EffectPreviewButton;
}
