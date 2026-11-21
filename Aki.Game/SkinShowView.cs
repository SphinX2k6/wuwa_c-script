using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FB3 RID: 8115
[NullableContext(2)]
[Nullable(0)]
public class SkinShowView : UiViewBase
{
	// Token: 0x06014222 RID: 82466 RVA: 0x005DFCBD File Offset: 0x005DDEBD
	[NullableContext(1)]
	public SkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014223 RID: 82467 RVA: 0x005DFCE8 File Offset: 0x005DDEE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn))
		};
	}

	// Token: 0x06014224 RID: 82468 RVA: 0x005DFD94 File Offset: 0x005DDF94
	protected unsafe override void OnStart()
	{
		if (!(this.OpenParam is int))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[OnStart] Spine预览打开参数必须是皮肤编号";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OpenParam", this.OpenParam);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SkinId = (int)this.OpenParam;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.SkinId);
		if (roleSkinConfig == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RoleSkin;
			ELogAuthor author2 = ELogAuthor.HMQ;
			string message2 = "[OnStart] Spine预览的角色皮肤配置缺失";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Table", "RoleSkin");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkinId", this.SkinId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.RoleId = roleSkinConfig.Value.RoleId;
		this.SpineLoadCancellation = new CancellationTokenSource();
		this.RefreshFrameTextureColor(roleSkinConfig.Value.RoleObtainColor1, roleSkinConfig.Value.RoleObtainColor2);
		this.InitializeDrag(roleSkinConfig.Value);
		this.ReadGamepadDragConfig();
		this.RefreshRoleSpine(roleSkinConfig.Value).Forget();
	}

	// Token: 0x06014225 RID: 82469 RVA: 0x005DFED6 File Offset: 0x005DE0D6
	protected override void OnAfterShow()
	{
		this.IsPreviewVisible = true;
		this.RefreshFreeDrag2DEnabled();
		this.ReboundToBoundary();
	}

	// Token: 0x06014226 RID: 82470 RVA: 0x005DFEEB File Offset: 0x005DE0EB
	protected override void OnBeforeHide()
	{
		this.StopInteraction();
	}

	// Token: 0x06014227 RID: 82471 RVA: 0x005DFEF4 File Offset: 0x005DE0F4
	protected override void OnBeforeDestroy()
	{
		this.StopInteraction();
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		foreach (FreeDrag2DComponent freeDrag2DComponent in this.FreeDrag2DComponents)
		{
			freeDrag2DComponent.SetDataCallback(null, null, null, null);
		}
		this.FreeDrag2DComponents.Clear();
		AUIBaseActor rootActor = this.RootActor;
		TsUiNavigationPanelConfig tsUiNavigationPanelConfig = ((rootActor != null) ? rootActor.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) : null) as TsUiNavigationPanelConfig;
		if (tsUiNavigationPanelConfig != null && tsUiNavigationPanelConfig.IsValid())
		{
			HotKeyComponentUtil.ClearCacheCallback(tsUiNavigationPanelConfig, EHotKeyCacheKey.FreeDrag2D);
		}
		if (this.DraggableComponent != null && this.DraggableComponent.IsValid())
		{
			this.DraggableComponent.OnPointerDownCallBack.Unbind();
			this.DraggableComponent.OnPointerDragCallBack.Unbind();
			this.DraggableComponent.OnPointerUpCallBack.Unbind();
			this.DraggableComponent.OnPointerCancelCallBack.Unbind();
			this.DraggableComponent.OnPointerEndDragCallBack.Unbind();
		}
		if (this.TweenSetter != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			this.TweenSetter = null;
		}
		CancellationTokenSource spineLoadCancellation = this.SpineLoadCancellation;
		if (spineLoadCancellation != null)
		{
			spineLoadCancellation.Cancel();
		}
		this.AtlasLoadModule.Clear();
		this.SkeletonLoadModule.Clear();
		CancellationTokenSource spineLoadCancellation2 = this.SpineLoadCancellation;
		if (spineLoadCancellation2 != null)
		{
			spineLoadCancellation2.Dispose();
		}
		this.SpineLoadCancellation = null;
		this.DraggableComponent = null;
		this.DragParent = null;
		this.DragItem = null;
		this.IsDragConfigured = false;
		this.GamepadDragSpeed = 0f;
	}

	// Token: 0x06014228 RID: 82472 RVA: 0x005E0094 File Offset: 0x005DE294
	private void OnClickBackBtn()
	{
		this.StopInteraction();
		base.CloseMe(null);
	}

	// Token: 0x06014229 RID: 82473 RVA: 0x005E00A4 File Offset: 0x005DE2A4
	private UniTask RefreshRoleSpine(RoleSkin skinConfig)
	{
		SkinShowView.<RefreshRoleSpine>d__34 <RefreshRoleSpine>d__;
		<RefreshRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleSpine>d__.<>4__this = this;
		<RefreshRoleSpine>d__.skinConfig = skinConfig;
		<RefreshRoleSpine>d__.<>1__state = -1;
		<RefreshRoleSpine>d__.<>t__builder.Start<SkinShowView.<RefreshRoleSpine>d__34>(ref <RefreshRoleSpine>d__);
		return <RefreshRoleSpine>d__.<>t__builder.Task;
	}

	// Token: 0x0601422A RID: 82474 RVA: 0x005E00F0 File Offset: 0x005DE2F0
	private unsafe void RefreshFrameTextureColor(string color1, string color2)
	{
		for (int i = 0; i < 2; i++)
		{
			SkinShowView.EComponent ecomponent = (i == 0) ? SkinShowView.EComponent.FrameTexture1 : SkinShowView.EComponent.FrameTexture2;
			string text = (i == 0) ? color1 : color2;
			UUITexture texture = base.GetTexture((int)ecomponent);
			if (texture == null || !texture.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RoleSkin;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[RefreshFrameTextureColor] Spine预览底色组件无效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", this.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkinId", this.SkinId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Component", ecomponent);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else if (!this.IsValidColor(text))
			{
				texture.SetUIActive(false);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RoleSkin;
				ELogAuthor author2 = ELogAuthor.HMQ;
				string message2 = "[RefreshFrameTextureColor] Spine预览底色配置无效，隐藏对应底色";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Table", "RoleSkin");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("RoleId", this.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SkinId", this.SkinId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Component", ecomponent);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("RoleObtainColor1", color1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("RoleObtainColor2", color2);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			}
			else
			{
				texture.SetColor(FColor.FromHex(text));
				texture.SetUIActive(true);
			}
		}
	}

	// Token: 0x0601422B RID: 82475 RVA: 0x005E02C8 File Offset: 0x005DE4C8
	private bool IsValidColor(string color)
	{
		if (string.IsNullOrEmpty(color))
		{
			return false;
		}
		int num = (color[0] == '#') ? 1 : 0;
		int num2 = color.Length - num;
		if (num2 != 3 && num2 != 6 && num2 != 8)
		{
			return false;
		}
		for (int i = num; i < color.Length; i++)
		{
			if (!Uri.IsHexDigit(color[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601422C RID: 82476 RVA: 0x005E0324 File Offset: 0x005DE524
	private unsafe void InitializeDrag(RoleSkin skinConfig)
	{
		if (!this.ReadDragConfig(skinConfig))
		{
			return;
		}
		this.DragItem = base.GetItem(4);
		if (this.DragItem != null && this.DragItem.IsValid())
		{
			this.DragParent = this.DragItem.GetAttachParent();
			AActor owner = this.DragItem.GetOwner();
			this.DraggableComponent = (((owner != null) ? owner.GetComponentByClass(UUIDraggableComponent.StaticClass()) : null) as UUIDraggableComponent);
		}
		if (this.DragItem == null || !this.DragItem.IsValid() || this.DragParent == null || !this.DragParent.IsValid() || this.DraggableComponent == null || !this.DraggableComponent.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[InitializeDrag] Spine拖拽节点、父节点或拖拽组件无效，禁用拖拽";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", this.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkinId", this.SkinId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Component", "PnlDrag");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("RegistryIndex", 4);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		this.InitialAnchorOffset = this.DragItem.GetAnchorOffset();
		this.TweenSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
		this.DraggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
		this.DraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
		this.DraggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerReleased));
		this.DraggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerReleased));
		this.DraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerReleased));
		this.IsDragConfigured = true;
	}

	// Token: 0x0601422D RID: 82477 RVA: 0x005E053C File Offset: 0x005DE73C
	private unsafe bool ReadDragConfig(RoleSkin skinConfig)
	{
		string text = ESkinSpinePreviewParam.ReboundTime.ToEnumString();
		string text2 = ESkinSpinePreviewParam.ElasticDistance.ToEnumString();
		string text3 = ESkinSpinePreviewParam.DragRatio.ToEnumString();
		float? floatConfig = ConfigCommonParamById.GetFloatConfig(text);
		float? floatConfig2 = ConfigCommonParamById.GetFloatConfig(text2);
		float? floatConfig3 = ConfigCommonParamById.GetFloatConfig(text3);
		if (floatConfig == null || !float.IsFinite(floatConfig.Value) || floatConfig.Value <= 0f || floatConfig2 == null || !float.IsFinite(floatConfig2.Value) || floatConfig2.Value <= 0f || floatConfig3 == null || !float.IsFinite(floatConfig3.Value) || floatConfig3.Value <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[ReadDragConfig] Spine回弹时长、弹性距离和拖动比例必须是有限正数，禁用拖拽";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Table", "CommonParam");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleId", this.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SkinId", this.SkinId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>(text, floatConfig);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>(text2, floatConfig2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>(text3, floatConfig3);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return false;
		}
		this.MinimumOffset = new FVector2D((float)(-(float)skinConfig.SpinePreviewBoundary(2)), (float)(-(float)skinConfig.SpinePreviewBoundary(1)));
		this.MaximumOffset = new FVector2D((float)skinConfig.SpinePreviewBoundary(3), (float)skinConfig.SpinePreviewBoundary(0));
		this.ReboundTime = floatConfig.Value;
		this.ElasticDistance = floatConfig2.Value;
		this.DragRatio = floatConfig3.Value;
		return true;
	}

	// Token: 0x0601422E RID: 82478 RVA: 0x005E0720 File Offset: 0x005DE920
	private bool CanDrag()
	{
		return this.IsDragConfigured && this.IsPreviewVisible && !base.IsDestroyOrDestroying && this.DragItem != null && this.DragItem.IsValid() && this.DragParent != null && this.DragParent.IsValid();
	}

	// Token: 0x0601422F RID: 82479 RVA: 0x005E0770 File Offset: 0x005DE970
	private unsafe void ReadGamepadDragConfig()
	{
		this.GamepadDragSpeed = 0f;
		string text = ESkinSpinePreviewParam.GamepadDragSpeed.ToEnumString();
		float? floatConfig = ConfigCommonParamById.GetFloatConfig(text);
		if (floatConfig == null || !float.IsFinite(floatConfig.Value) || floatConfig.Value <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleSkin;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[ReadGamepadDragConfig] Spine轴拖拽速度必须是有限正数，禁用轴拖拽";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Table", "CommonParam");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleId", this.RoleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SkinId", this.SkinId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>(text, floatConfig);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		this.GamepadDragSpeed = floatConfig.Value;
	}

	// Token: 0x06014230 RID: 82480 RVA: 0x005E086B File Offset: 0x005DEA6B
	private void SetupFreeDrag2D()
	{
		HotKeyComponentUtil.SetupComponents<FreeDrag2DComponent>(this.RootItem, EHotKeyCacheKey.FreeDrag2D, new Action<FreeDrag2DComponent>(this.ConfigureFreeDrag2DComponent));
		this.RefreshFreeDrag2DEnabled();
	}

	// Token: 0x06014231 RID: 82481 RVA: 0x005E088C File Offset: 0x005DEA8C
	[NullableContext(1)]
	private void ConfigureFreeDrag2DComponent(FreeDrag2DComponent component)
	{
		if (base.IsDestroyOrDestroying || base.IsPendingDestroy)
		{
			return;
		}
		if (!this.FreeDrag2DComponents.Contains(component))
		{
			this.FreeDrag2DComponents.Add(component);
		}
		component.SetDataCallback(new Func<bool>(this.OnFreeDrag2DStarted), new Func<FreeDrag2DInput, bool>(this.OnFreeDrag2DUpdated), new Action(this.OnFreeDrag2DEnded), new Action(this.OnFreeDrag2DCanceled));
		component.SetInputEnabled(this.CanFreeDrag2D());
	}

	// Token: 0x06014232 RID: 82482 RVA: 0x005E0906 File Offset: 0x005DEB06
	private bool CanFreeDrag2D()
	{
		return this.CanDrag() && !base.IsPendingDestroy && this.GamepadDragSpeed > 0f && !this.IsDragging;
	}

	// Token: 0x06014233 RID: 82483 RVA: 0x005E0930 File Offset: 0x005DEB30
	private void RefreshFreeDrag2DEnabled()
	{
		bool inputEnabled = this.CanFreeDrag2D();
		foreach (FreeDrag2DComponent freeDrag2DComponent in this.FreeDrag2DComponents)
		{
			freeDrag2DComponent.SetInputEnabled(inputEnabled);
		}
	}

	// Token: 0x06014234 RID: 82484 RVA: 0x005E0988 File Offset: 0x005DEB88
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		this.SetupFreeDrag2D();
	}

	// Token: 0x06014235 RID: 82485 RVA: 0x005E0990 File Offset: 0x005DEB90
	private bool OnFreeDrag2DStarted()
	{
		if (!this.CanFreeDrag2D())
		{
			return false;
		}
		this.StopRebound();
		FVector2D anchorOffset = this.DragItem.GetAnchorOffset();
		FVector2D fvector2D = anchorOffset - this.InitialAnchorOffset;
		this.RequestedOffsetX = this.GetRequestedOffset(fvector2D.X, this.MinimumOffset.X, this.MaximumOffset.X);
		this.RequestedOffsetY = this.GetRequestedOffset(fvector2D.Y, this.MinimumOffset.Y, this.MaximumOffset.Y);
		this.IsFreeDragging = true;
		return true;
	}

	// Token: 0x06014236 RID: 82486 RVA: 0x005E0A20 File Offset: 0x005DEC20
	private bool OnFreeDrag2DUpdated(FreeDrag2DInput input)
	{
		if (!this.CanFreeDrag2D() || !this.IsFreeDragging)
		{
			return false;
		}
		this.RequestedOffsetX += (double)input.Value.X * (double)this.GamepadDragSpeed * (double)input.DeltaSeconds;
		this.RequestedOffsetY += (double)input.Value.Y * (double)this.GamepadDragSpeed * (double)input.DeltaSeconds;
		FVector2D fvector2D = new FVector2D(this.GetElasticOffset(this.RequestedOffsetX, this.MinimumOffset.X, this.MaximumOffset.X), this.GetElasticOffset(this.RequestedOffsetY, this.MinimumOffset.Y, this.MaximumOffset.Y));
		this.DragItem.SetAnchorOffset(this.InitialAnchorOffset + fvector2D);
		return true;
	}

	// Token: 0x06014237 RID: 82487 RVA: 0x005E0AF5 File Offset: 0x005DECF5
	private void OnFreeDrag2DEnded()
	{
		this.FinishFreeDrag2D();
	}

	// Token: 0x06014238 RID: 82488 RVA: 0x005E0AFD File Offset: 0x005DECFD
	private void OnFreeDrag2DCanceled()
	{
		this.FinishFreeDrag2D();
	}

	// Token: 0x06014239 RID: 82489 RVA: 0x005E0B05 File Offset: 0x005DED05
	private void FinishFreeDrag2D()
	{
		bool isFreeDragging = this.IsFreeDragging;
		this.IsFreeDragging = false;
		if (isFreeDragging && this.CanDrag() && !base.IsPendingDestroy && !this.IsDragging)
		{
			this.ReboundToBoundary();
		}
	}

	// Token: 0x0601423A RID: 82490 RVA: 0x005E0B34 File Offset: 0x005DED34
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"Success",
		"Position"
	})]
	private ValueTuple<bool, FVector2D> TryGetPointerPosition([Nullable(1)] ULGUIPointerEventData eventData)
	{
		FVector worldPointInPlane = eventData.GetWorldPointInPlane();
		FTransform ftransform = this.DragParent.K2_GetComponentToWorld();
		FVector fvector = UKismetMathLibrary.InverseTransformLocation(ftransform, worldPointInPlane);
		FVector2D fvector2D = new FVector2D(fvector.X, fvector.Y);
		return new ValueTuple<bool, FVector2D>(float.IsFinite(fvector2D.X) && float.IsFinite(fvector2D.Y), fvector2D);
	}

	// Token: 0x0601423B RID: 82491 RVA: 0x005E0B94 File Offset: 0x005DED94
	private void OnPointerDown(ULGUIPointerEventData eventData)
	{
		if (!this.CanDrag() || this.IsDragging || eventData == null || !eventData.IsValid())
		{
			return;
		}
		ValueTuple<bool, FVector2D> valueTuple = this.TryGetPointerPosition(eventData);
		if (!valueTuple.Item1)
		{
			return;
		}
		FVector2D item = valueTuple.Item2;
		this.StopRebound();
		FVector2D anchorOffset = this.DragItem.GetAnchorOffset();
		FVector2D fvector2D = anchorOffset - this.InitialAnchorOffset;
		this.RequestedOffsetX = this.GetRequestedOffset(fvector2D.X, this.MinimumOffset.X, this.MaximumOffset.X);
		this.RequestedOffsetY = this.GetRequestedOffset(fvector2D.Y, this.MinimumOffset.Y, this.MaximumOffset.Y);
		this.LastPointerPosition = item;
		this.ActivePointerId = eventData.pointerID;
		this.IsDragging = true;
		this.RefreshFreeDrag2DEnabled();
	}

	// Token: 0x0601423C RID: 82492 RVA: 0x005E0C68 File Offset: 0x005DEE68
	private void OnPointerDrag(ULGUIPointerEventData eventData)
	{
		if (!this.CanDrag() || !this.IsDragging || eventData == null || !eventData.IsValid() || eventData.pointerID != this.ActivePointerId)
		{
			return;
		}
		ValueTuple<bool, FVector2D> valueTuple = this.TryGetPointerPosition(eventData);
		if (!valueTuple.Item1)
		{
			this.OnPointerReleased(eventData);
			return;
		}
		FVector2D item = valueTuple.Item2;
		this.RequestedOffsetX += ((double)item.X - (double)this.LastPointerPosition.X) * (double)this.DragRatio;
		this.RequestedOffsetY += ((double)item.Y - (double)this.LastPointerPosition.Y) * (double)this.DragRatio;
		this.LastPointerPosition = item;
		FVector2D fvector2D = new FVector2D(this.GetElasticOffset(this.RequestedOffsetX, this.MinimumOffset.X, this.MaximumOffset.X), this.GetElasticOffset(this.RequestedOffsetY, this.MinimumOffset.Y, this.MaximumOffset.Y));
		this.DragItem.SetAnchorOffset(this.InitialAnchorOffset + fvector2D);
	}

	// Token: 0x0601423D RID: 82493 RVA: 0x005E0D7A File Offset: 0x005DEF7A
	private void OnPointerReleased(ULGUIPointerEventData eventData)
	{
		if (!this.IsDragging || eventData == null || !eventData.IsValid() || eventData.pointerID != this.ActivePointerId)
		{
			return;
		}
		this.IsDragging = false;
		this.ReboundToBoundary();
		this.RefreshFreeDrag2DEnabled();
	}

	// Token: 0x0601423E RID: 82494 RVA: 0x005E0DB4 File Offset: 0x005DEFB4
	private float GetElasticOffset(double requested, float minimum, float maximum)
	{
		double num = Math.Clamp(requested, (double)minimum, (double)maximum);
		double num2 = requested - num;
		return (float)(num + num2 * (double)this.ElasticDistance / ((double)this.ElasticDistance + Math.Abs(num2)));
	}

	// Token: 0x0601423F RID: 82495 RVA: 0x005E0DEC File Offset: 0x005DEFEC
	private double GetRequestedOffset(float displayed, float minimum, float maximum)
	{
		double num = (double)Math.Clamp(displayed, minimum, maximum);
		double num2 = (double)displayed - num;
		double num3 = (double)MathF.BitDecrement(this.ElasticDistance);
		num2 = Math.Clamp(num2, -num3, num3);
		return num + num2 * (double)this.ElasticDistance / ((double)this.ElasticDistance - Math.Abs(num2));
	}

	// Token: 0x06014240 RID: 82496 RVA: 0x005E0E3C File Offset: 0x005DF03C
	private void ReboundToBoundary()
	{
		if (!this.CanDrag())
		{
			return;
		}
		FVector2D anchorOffset = this.DragItem.GetAnchorOffset();
		FVector2D fvector2D = anchorOffset - this.InitialAnchorOffset;
		FVector2D fvector2D2 = new FVector2D(Math.Clamp(fvector2D.X, this.MinimumOffset.X, this.MaximumOffset.X), Math.Clamp(fvector2D.Y, this.MinimumOffset.Y, this.MaximumOffset.Y));
		if (fvector2D.X == fvector2D2.X && fvector2D.Y == fvector2D2.Y)
		{
			return;
		}
		this.StopRebound();
		this.PositionTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.TweenSetter, anchorOffset, this.InitialAnchorOffset + fvector2D2, this.ReboundTime, 0f, LTweenEase.OutQuad);
	}

	// Token: 0x06014241 RID: 82497 RVA: 0x005E0F08 File Offset: 0x005DF108
	private void OnTweenUpdate(FVector2D position)
	{
		if (this.CanDrag() && !this.IsDragging && !this.IsFreeDragging)
		{
			this.DragItem.SetAnchorOffset(position);
		}
	}

	// Token: 0x06014242 RID: 82498 RVA: 0x005E0F2E File Offset: 0x005DF12E
	private void StopRebound()
	{
		if (this.PositionTweener != null && this.PositionTweener.IsValid())
		{
			this.PositionTweener.Kill(false);
		}
		this.PositionTweener = null;
	}

	// Token: 0x06014243 RID: 82499 RVA: 0x005E0F58 File Offset: 0x005DF158
	private void StopInteraction()
	{
		this.IsPreviewVisible = false;
		this.IsDragging = false;
		this.RefreshFreeDrag2DEnabled();
		this.IsFreeDragging = false;
		this.StopRebound();
	}

	// Token: 0x0400AAFB RID: 43771
	[Nullable(1)]
	private readonly UiSpineAtlasLoadModule AtlasLoadModule = new UiSpineAtlasLoadModule();

	// Token: 0x0400AAFC RID: 43772
	[Nullable(1)]
	private readonly UiSpineSkeletonLoadModule SkeletonLoadModule = new UiSpineSkeletonLoadModule();

	// Token: 0x0400AAFD RID: 43773
	private CancellationTokenSource SpineLoadCancellation;

	// Token: 0x0400AAFE RID: 43774
	private int SkinId;

	// Token: 0x0400AAFF RID: 43775
	private int RoleId;

	// Token: 0x0400AB00 RID: 43776
	private UUIItem DragItem;

	// Token: 0x0400AB01 RID: 43777
	private USceneComponent DragParent;

	// Token: 0x0400AB02 RID: 43778
	private UUIDraggableComponent DraggableComponent;

	// Token: 0x0400AB03 RID: 43779
	private FVector2D InitialAnchorOffset;

	// Token: 0x0400AB04 RID: 43780
	private FVector2D MinimumOffset;

	// Token: 0x0400AB05 RID: 43781
	private FVector2D MaximumOffset;

	// Token: 0x0400AB06 RID: 43782
	private FVector2D LastPointerPosition;

	// Token: 0x0400AB07 RID: 43783
	private double RequestedOffsetX;

	// Token: 0x0400AB08 RID: 43784
	private double RequestedOffsetY;

	// Token: 0x0400AB09 RID: 43785
	private float ReboundTime;

	// Token: 0x0400AB0A RID: 43786
	private float ElasticDistance;

	// Token: 0x0400AB0B RID: 43787
	private float DragRatio;

	// Token: 0x0400AB0C RID: 43788
	private float GamepadDragSpeed;

	// Token: 0x0400AB0D RID: 43789
	private bool IsFreeDragging;

	// Token: 0x0400AB0E RID: 43790
	[Nullable(1)]
	private readonly List<FreeDrag2DComponent> FreeDrag2DComponents = new List<FreeDrag2DComponent>();

	// Token: 0x0400AB0F RID: 43791
	private bool IsDragConfigured;

	// Token: 0x0400AB10 RID: 43792
	private bool IsPreviewVisible;

	// Token: 0x0400AB11 RID: 43793
	private bool IsDragging;

	// Token: 0x0400AB12 RID: 43794
	private int ActivePointerId;

	// Token: 0x0400AB13 RID: 43795
	private ULTweener PositionTweener;

	// Token: 0x0400AB14 RID: 43796
	private FLTweenVector2SetterDynamic TweenSetter;

	// Token: 0x020082C5 RID: 33477
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A43E RID: 173118
		BackBtn,
		// Token: 0x0402A43F RID: 173119
		RoleSpine,
		// Token: 0x0402A440 RID: 173120
		FrameTexture1,
		// Token: 0x0402A441 RID: 173121
		FrameTexture2,
		// Token: 0x0402A442 RID: 173122
		PnlDrag
	}
}
