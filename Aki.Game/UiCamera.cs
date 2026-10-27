using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002C46 RID: 11334
[NullableContext(1)]
[Nullable(0)]
public class UiCamera
{
	// Token: 0x06017A21 RID: 96801 RVA: 0x006035DC File Offset: 0x006017DC
	public UiCamera()
	{
		this.UiCameraComponentMap = new Dictionary<Type, UiCameraComponent>();
		this.UiCameraStructureStack = new global::Stack<UiCameraStructure>();
	}

	// Token: 0x06017A22 RID: 96802 RVA: 0x006035FC File Offset: 0x006017FC
	public bool Initialize()
	{
		WidgetCamera widgetCamera = CameraController.Instance.MainModel.WidgetCamera;
		if (widgetCamera == null)
		{
			Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "初始化界面摄像机时，找不到 widgetCamera 组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		WidgetCameraDisplayComponent component = widgetCamera.GetComponent<WidgetCameraDisplayComponent>();
		if (!component.Valid)
		{
			Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "初始化界面摄像机时，找不到 WidgetCameraDisplayComponent 组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		BP_CineCamera_C cineCamera = component.CineCamera;
		if (cineCamera == null || !cineCamera.IsValid())
		{
			Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "初始化界面摄像机时，CameraActor不可用", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.CameraActor = cineCamera;
		this.CameraActor.SetTickableWhenPaused(true);
		this.CineCameraComponent = cineCamera.GetCineCameraComponent();
		UCineCameraComponent cineCameraComponent = this.CineCameraComponent;
		if (cineCameraComponent != null)
		{
			cineCameraComponent.SetTickableWhenPaused(true);
		}
		this.AddUiCameraComponent(typeof(UiCameraPostEffectComponent), true);
		this.AddUiCameraComponent(typeof(UiCameraSequenceComponent), true);
		return true;
	}

	// Token: 0x06017A23 RID: 96803 RVA: 0x006036F3 File Offset: 0x006018F3
	public void Destroy(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f)
	{
		this.Exit(blendTime, blendFunction, blendExp);
		this.ClearAllUiCameraComponent();
		this.CameraActor = null;
		this.CineCameraComponent = null;
	}

	// Token: 0x06017A24 RID: 96804 RVA: 0x00603714 File Offset: 0x00601914
	public void SetWorldLocation(FVectorDouble location)
	{
		BP_CineCamera_C cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		FHitResult fhitResult = new FHitResult();
		this.CameraActor.D_K2_SetActorLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x06017A25 RID: 96805 RVA: 0x00603750 File Offset: 0x00601950
	public void SetWorldRotation(FRotator rotation)
	{
		BP_CineCamera_C cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		this.CameraActor.K2_SetActorRotation(rotation, false);
	}

	// Token: 0x06017A26 RID: 96806 RVA: 0x00603778 File Offset: 0x00601978
	[NullableContext(2)]
	public unsafe void Enter(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, Action callback = null)
	{
		if (this.IsEntered)
		{
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, null, false, "MainCamera", null);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "进入Ui相机";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("blendTime", blendTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendFunction", blendFunction);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendExp", blendExp);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		foreach (UiCameraComponent uiCameraComponent in this.UiCameraComponentMap.Values)
		{
			uiCameraComponent.Activate();
		}
		CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, callback, false, "MainCamera", null);
		this.IsEntered = true;
	}

	// Token: 0x06017A27 RID: 96807 RVA: 0x00603888 File Offset: 0x00601A88
	public unsafe void Exit(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f)
	{
		if (!this.IsEntered)
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, null, "MainCamera", null);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "退出Ui相机";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("blendTime", blendTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("blendFunction", blendFunction);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("blendExp", blendExp);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (CameraModel.Instance.MainModel.LogicHideHeadEnabled)
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		}
		else
		{
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, null, "MainCamera", null);
		}
		foreach (UiCameraComponent uiCameraComponent in this.UiCameraComponentMap.Values)
		{
			uiCameraComponent.Deactivate();
		}
		this.ClearStructure();
		this.IsEntered = false;
	}

	// Token: 0x06017A28 RID: 96808 RVA: 0x006039CC File Offset: 0x00601BCC
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe T PushStructure<T>() where T : UiCameraStructure, new()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.JYS;
		string message = "PushStructure:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "this.UiCameraStructureStack.Peek()?.constructor.name";
		UiCameraStructure uiCameraStructure = this.UiCameraStructureStack.Peek();
		ptr = new ValueTuple<string, object>(item, (uiCameraStructure != null) ? uiCameraStructure.GetType().Name : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiCameraStructureClass.name", typeof(T).Name);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		UiCameraStructure uiCameraStructure2 = this.UiCameraStructureStack.Peek();
		if (((uiCameraStructure2 != null) ? uiCameraStructure2.GetType() : null) == typeof(T))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiCamera;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "PushStructure时，已经有相同的UiCameraStructure，直接返回此UiCameraStructure:";
			string item2 = "Name";
			UiCameraStructure uiCameraStructure3 = this.UiCameraStructureStack.Peek();
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item2, (uiCameraStructure3 != null) ? uiCameraStructure3.GetType().Name : null);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return this.UiCameraStructureStack.Peek() as T;
		}
		UiCameraStructure uiCameraStructure4 = Activator.CreateInstance<T>();
		uiCameraStructure4.Initialize(this);
		uiCameraStructure4.Activate();
		this.UiCameraStructureStack.Push(uiCameraStructure4);
		return uiCameraStructure4 as T;
	}

	// Token: 0x06017A29 RID: 96809 RVA: 0x00603B04 File Offset: 0x00601D04
	public void PopStructure()
	{
		this.UiCameraStructureStack.Pop().Destroy();
		UiCameraStructure uiCameraStructure = this.UiCameraStructureStack.Peek();
		if (uiCameraStructure == null)
		{
			return;
		}
		uiCameraStructure.Activate();
	}

	// Token: 0x06017A2A RID: 96810 RVA: 0x00603B2B File Offset: 0x00601D2B
	public UiCameraStructure GetStructure()
	{
		return this.UiCameraStructureStack.Peek();
	}

	// Token: 0x06017A2B RID: 96811 RVA: 0x00603B38 File Offset: 0x00601D38
	public void ClearStructure()
	{
		foreach (UiCameraStructure uiCameraStructure in this.UiCameraStructureStack)
		{
			uiCameraStructure.Destroy();
		}
		this.UiCameraStructureStack.Clear();
	}

	// Token: 0x06017A2C RID: 96812 RVA: 0x00603B90 File Offset: 0x00601D90
	public UiCameraComponent AddUiCameraComponent(Type componentClass, bool bAutoActivate = true)
	{
		UiCameraComponent uiCameraComponent;
		if (!this.UiCameraComponentMap.TryGetValue(componentClass, out uiCameraComponent))
		{
			uiCameraComponent = (Activator.CreateInstance(componentClass) as UiCameraComponent);
			uiCameraComponent.Initialize(this);
			this.UiCameraComponentMap[componentClass] = uiCameraComponent;
		}
		if (this.IsEntered && bAutoActivate)
		{
			uiCameraComponent.Activate();
		}
		return uiCameraComponent;
	}

	// Token: 0x06017A2D RID: 96813 RVA: 0x00603BE0 File Offset: 0x00601DE0
	public void DestroyUiCameraComponent(Type componentClass)
	{
		UiCameraComponent uiCameraComponent;
		if (!this.UiCameraComponentMap.TryGetValue(componentClass, out uiCameraComponent))
		{
			return;
		}
		uiCameraComponent.Destroy();
		this.UiCameraComponentMap.Remove(componentClass);
	}

	// Token: 0x06017A2E RID: 96814 RVA: 0x00603C14 File Offset: 0x00601E14
	private void ClearAllUiCameraComponent()
	{
		foreach (UiCameraComponent uiCameraComponent in this.UiCameraComponentMap.Values)
		{
			uiCameraComponent.Destroy();
		}
		this.UiCameraComponentMap.Clear();
	}

	// Token: 0x06017A2F RID: 96815 RVA: 0x00603C74 File Offset: 0x00601E74
	public T GetUiCameraComponent<[Nullable(0)] T>() where T : UiCameraComponent
	{
		return this.UiCameraComponentMap[typeof(T)] as T;
	}

	// Token: 0x06017A30 RID: 96816 RVA: 0x00603C95 File Offset: 0x00601E95
	public BP_CineCamera_C GetCameraActor()
	{
		return this.CameraActor;
	}

	// Token: 0x06017A31 RID: 96817 RVA: 0x00603C9D File Offset: 0x00601E9D
	public UCineCameraComponent GetCineCameraComponent()
	{
		return this.CineCameraComponent;
	}

	// Token: 0x06017A32 RID: 96818 RVA: 0x00603CA5 File Offset: 0x00601EA5
	public bool GetIsEntered()
	{
		return this.IsEntered;
	}

	// Token: 0x0400B023 RID: 45091
	[Nullable(2)]
	protected BP_CineCamera_C CameraActor;

	// Token: 0x0400B024 RID: 45092
	[Nullable(2)]
	protected UCineCameraComponent CineCameraComponent;

	// Token: 0x0400B025 RID: 45093
	private readonly Dictionary<Type, UiCameraComponent> UiCameraComponentMap;

	// Token: 0x0400B026 RID: 45094
	private readonly global::Stack<UiCameraStructure> UiCameraStructureStack;

	// Token: 0x0400B027 RID: 45095
	private bool IsEntered;
}
