using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025C RID: 604
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C")]
public class TsBasePlayerController : ABasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x0600253B RID: 9531 RVA: 0x000E45AE File Offset: 0x000E27AE
	// (set) Token: 0x0600253C RID: 9532 RVA: 0x000E45C2 File Offset: 0x000E27C2
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe TSubclassOf<TsActionHandle> ActionHandleClass
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			return *(base.NativePtr + (IntPtr)TsBasePlayerController.__PropertyOffset_ActionHandleClass);
		}
		[param: Nullable(new byte[]
		{
			0,
			1
		})]
		set
		{
			*(base.NativePtr + (IntPtr)TsBasePlayerController.__PropertyOffset_ActionHandleClass) = value;
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x0600253D RID: 9533 RVA: 0x000E45D7 File Offset: 0x000E27D7
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe TSubclassOf<TsAxisHandle> AxisHandleClass
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			return *(base.NativePtr + (IntPtr)TsBasePlayerController.__PropertyOffset_AxisHandleClass);
		}
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x0600253E RID: 9534 RVA: 0x000E45EC File Offset: 0x000E27EC
	[UProperty(EPropertyFlags.CPF_None)]
	private TMap<string, TsActionHandle> ActionHandleMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, TsActionHandle> result;
			if ((result = this._ActionHandleMap) == null)
			{
				result = (this._ActionHandleMap = new TMap<string, TsActionHandle>(base.NativePtr + (IntPtr)TsBasePlayerController.__PropertyOffset_ActionHandleMap, this));
			}
			return result;
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x0600253F RID: 9535 RVA: 0x000E4628 File Offset: 0x000E2828
	[UProperty(EPropertyFlags.CPF_None)]
	private TMap<string, TsAxisHandle> AxisHandleMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, TsAxisHandle> result;
			if ((result = this._AxisHandleMap) == null)
			{
				result = (this._AxisHandleMap = new TMap<string, TsAxisHandle>(base.NativePtr + (IntPtr)TsBasePlayerController.__PropertyOffset_AxisHandleMap, this));
			}
			return result;
		}
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x000E4664 File Offset: 0x000E2864
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveSetupInputComponent()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveSetupInputComponent"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveSetupInputComponent_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000E46BD File Offset: 0x000E28BD
	protected virtual void ReceiveSetupInputComponent_Implementation()
	{
		this.InitInputHandle();
		this.AddInputBinding();
		this.OnSetupInputComponent();
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000E46D4 File Offset: 0x000E28D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000E472D File Offset: 0x000E292D
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.InitInputHandle();
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000E4738 File Offset: 0x000E2938
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000E4794 File Offset: 0x000E2994
	protected virtual void ReceiveDestroyed_Implementation()
	{
		if (!ObjectUtils.IsValid(this))
		{
			return;
		}
		this.ClearInputBinding();
		if (this.PlayerInputHandle != null)
		{
			this.PlayerInputHandle.Clear();
			this.PlayerInputHandle = null;
		}
		if (this.TsKeyHandle != null)
		{
			this.TsKeyHandle.Reset();
			this.TsKeyHandle = null;
		}
		if (this.TsTouchHandle != null)
		{
			this.TsTouchHandle.Reset();
			this.TsTouchHandle = null;
		}
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000E4800 File Offset: 0x000E2A00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000E488C File Offset: 0x000E2A8C
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.Tick(deltaSeconds);
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000E48A0 File Offset: 0x000E2AA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnReceivedPlayer()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnReceivedPlayer"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnReceivedPlayer_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x000E48F9 File Offset: 0x000E2AF9
	protected virtual void OnReceivedPlayer_Implementation()
	{
		UKuroInputFunctionLibrary.ResetInputMode(this);
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x000E4904 File Offset: 0x000E2B04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void InitInputHandle()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitInputHandle"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitInputHandle_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x000E4960 File Offset: 0x000E2B60
	protected void InitInputHandle_Implementation()
	{
		if (this.PlayerInputHandle != null)
		{
			return;
		}
		this.PlayerInputHandle = new PlayerInputHandle();
		this.PlayerInputHandle.Initialize();
		if (this.TsKeyHandle == null)
		{
			this.TsKeyHandle = new TsPureKeyHandle();
			this.TsKeyHandle.Initialize(this, this.PlayerInputHandle);
		}
		if (this.TsTouchHandle == null)
		{
			this.TsTouchHandle = new TsPureTouchHandle();
			this.TsTouchHandle.Initialize(this, this.PlayerInputHandle);
		}
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x000E49D8 File Offset: 0x000E2BD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void AddInputBinding()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddInputBinding"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AddInputBinding_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x000E4A34 File Offset: 0x000E2C34
	protected void AddInputBinding_Implementation()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InputSettings;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "添加PlayerController绑定输入";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerController", this);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.BindActionHandle();
		this.BindAxisHandle();
		this.BindKeyHandle();
		this.BindTouchHandle();
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x000E4A80 File Offset: 0x000E2C80
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ClearInputBinding()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ClearInputBinding"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ClearInputBinding_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000E4ADC File Offset: 0x000E2CDC
	protected void ClearInputBinding_Implementation()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InputSettings;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "清理PlayerController绑定输入";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerController", this);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (Info.Instance.UseFastInputCallback)
		{
			UKuroInputDelegateLibrary.ClearInputBinding(this);
		}
		else
		{
			base.ClearActionBindings();
			base.ClearAxisBindings();
			base.ClearKeyBindings();
			base.ClearTouchBindings();
		}
		this.ClearActionHandle();
		this.ClearAxisHandle();
		this.OnInputActionCallback = null;
		this.OnInputAxisCallback = null;
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000E4B58 File Offset: 0x000E2D58
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void OnSetupInputComponent()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnSetupInputComponent"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnSetupInputComponent_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x000E4BB1 File Offset: 0x000E2DB1
	protected void OnSetupInputComponent_Implementation()
	{
		this.CurrentInputPosition = Vector2D.Create(0.0, 0.0);
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000E4BD0 File Offset: 0x000E2DD0
	protected virtual void BindActionHandle()
	{
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000E4BD2 File Offset: 0x000E2DD2
	protected virtual void BindAxisHandle()
	{
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x000E4BD4 File Offset: 0x000E2DD4
	protected virtual void BindKeyHandle()
	{
		if (!Info.Instance.UseFastInputCallback)
		{
			FInputChord finputChord = new FInputChord
			{
				Key = new FKey
				{
					KeyName = FNameUtil.GetCheckDynamicFName("AnyKey")
				}
			};
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			FName fname = new FName("OnPressAnyKey");
			base.AddKeyBinding(finputChord, keyEvent, this, fname);
			EInputEvent keyEvent2 = EInputEvent.IE_Released;
			fname = new FName("OnReleaseAnyKey");
			base.AddKeyBinding(finputChord, keyEvent2, this, fname);
			return;
		}
		if (this.TsKeyHandle != null)
		{
			this.TsKeyHandle.BindKey();
			return;
		}
		Log.Instance.Error(ELogModule.Input, ELogAuthor.WLJ, "BindKeyHandle Failed, TsKeyHandle is null", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x000E4C70 File Offset: 0x000E2E70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void BindTouchHandle()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("BindTouchHandle"), TsBasePlayerController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.BindTouchHandle_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000E4CCC File Offset: 0x000E2ECC
	protected void BindTouchHandle_Implementation()
	{
		if (!Info.Instance.UseFastInputCallback)
		{
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			FName fname = new FName("OnTouchBegin");
			base.AddTouchBinding(keyEvent, this, fname);
			EInputEvent keyEvent2 = EInputEvent.IE_Released;
			fname = new FName("OnTouchEnd");
			base.AddTouchBinding(keyEvent2, this, fname);
			EInputEvent keyEvent3 = EInputEvent.IE_Repeat;
			fname = new FName("OnTouchMove");
			base.AddTouchBinding(keyEvent3, this, fname);
			return;
		}
		if (this.TsTouchHandle != null)
		{
			this.TsTouchHandle.BindTouch();
			return;
		}
		Log.Instance.Error(ELogModule.Input, ELogAuthor.WLJ, "BindKeyHandle Failed, TsTouchHandle is null", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x000E4D55 File Offset: 0x000E2F55
	protected virtual void OnInputAction(string actionName, bool bPress, FKey key)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
		this.PlayerInputHandle.InputAction(actionName, bPress, key);
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000E4D7E File Offset: 0x000E2F7E
	protected virtual void OnInputAxis(string axisName, float value, bool alwaysTick = false)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(true, axisName, (double)value);
		this.PlayerInputHandle.InputAxis(axisName, value, alwaysTick);
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000E4D9C File Offset: 0x000E2F9C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchBegin(ETouchIndex touchIndex, FVector position)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnTouchBegin"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.OnTouchBegin_Implementation(touchIndex, position);
			return;
		}
		TsBasePlayerController.__OnTouchBegin_FunctionParams* ptr = stackalloc TsBasePlayerController.__OnTouchBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__OnTouchBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->touchIndex) = (byte)touchIndex;
		ptr->position = position;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x000E4E33 File Offset: 0x000E3033
	protected void OnTouchBegin_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchBegin(touchIndex, position);
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000E4E5C File Offset: 0x000E305C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchEnd(ETouchIndex touchIndex, FVector position)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnTouchEnd"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.OnTouchEnd_Implementation(touchIndex, position);
			return;
		}
		TsBasePlayerController.__OnTouchEnd_FunctionParams* ptr = stackalloc TsBasePlayerController.__OnTouchEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__OnTouchEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->touchIndex) = (byte)touchIndex;
		ptr->position = position;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x000E4EF3 File Offset: 0x000E30F3
	protected void OnTouchEnd_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchEnd(touchIndex, position);
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000E4F04 File Offset: 0x000E3104
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchMove(ETouchIndex touchIndex, FVector position)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnTouchMove"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.OnTouchMove_Implementation(touchIndex, position);
			return;
		}
		TsBasePlayerController.__OnTouchMove_FunctionParams* ptr = stackalloc TsBasePlayerController.__OnTouchMove_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__OnTouchMove_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->touchIndex) = (byte)touchIndex;
		ptr->position = position;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x000E4F9B File Offset: 0x000E319B
	protected void OnTouchMove_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchMove(touchIndex, position);
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000E4FAC File Offset: 0x000E31AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnPressAnyKey(FKey key)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPressAnyKey"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.OnPressAnyKey_Implementation(key);
			return;
		}
		TsBasePlayerController.__OnPressAnyKey_FunctionParams* ptr = stackalloc TsBasePlayerController.__OnPressAnyKey_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__OnPressAnyKey_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000E5051 File Offset: 0x000E3251
	protected void OnPressAnyKey_Implementation(FKey key)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
		this.PlayerInputHandle.PressAnyKey(key);
		PlatformModel.GetOrCreateInstance().OnPressAnyKey(key);
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000E5084 File Offset: 0x000E3284
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnReleaseAnyKey(FKey key)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnReleaseAnyKey"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.OnReleaseAnyKey_Implementation(key);
			return;
		}
		TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* ptr = stackalloc TsBasePlayerController.__OnReleaseAnyKey_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000E5129 File Offset: 0x000E3329
	protected void OnReleaseAnyKey_Implementation(FKey key)
	{
		this.PlayerInputHandle.ReleaseAnyKey(key);
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000E5138 File Offset: 0x000E3338
	protected void AddActionHandle(string actionName)
	{
		if (Info.Instance.UseFastInputCallback)
		{
			if (this.TsActionHandleMap == null)
			{
				this.TsActionHandleMap = new Dictionary<string, TsPureActionHandle>();
			}
			TsPureActionHandle tsPureActionHandle;
			if (!this.TsActionHandleMap.TryGetValue(actionName, out tsPureActionHandle))
			{
				tsPureActionHandle = new TsPureActionHandle();
				tsPureActionHandle.Initialize(this);
				this.TsActionHandleMap[actionName] = tsPureActionHandle;
			}
			this.OnInputActionCallback = new Action<string, bool, FKey>(this.OnInputAction);
			tsPureActionHandle.AddActionBinding(actionName, this.OnInputActionCallback);
			return;
		}
		TsActionHandle tsActionHandle = this.GetActionHandle(actionName);
		if (tsActionHandle == null)
		{
			tsActionHandle = this.NewActionHandle(actionName);
		}
		if (tsActionHandle == null)
		{
			return;
		}
		this.OnInputActionCallback = new Action<string, bool, FKey>(this.OnInputAction);
		tsActionHandle.AddActionBinding(actionName, this.OnInputActionCallback);
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000E51E8 File Offset: 0x000E33E8
	[return: Nullable(2)]
	protected virtual TsActionHandle NewActionHandle(string actionName)
	{
		if (this.ActionHandleClass == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前Controller中的ActionHandleClass不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ControllerName", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		TsActionHandle tsActionHandle = new TsActionHandle();
		tsActionHandle.Initialize(this);
		this.ActionHandleMap.Add(actionName, tsActionHandle);
		return tsActionHandle;
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000E5250 File Offset: 0x000E3450
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemoveActionHandle(string actionName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveActionHandle"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.RemoveActionHandle_Implementation(actionName);
			return;
		}
		TsBasePlayerController.__RemoveActionHandle_FunctionParams* ptr = stackalloc TsBasePlayerController.__RemoveActionHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__RemoveActionHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->actionName), actionName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000E52E4 File Offset: 0x000E34E4
	protected void RemoveActionHandle_Implementation(string actionName)
	{
		TsActionHandle actionHandle = this.GetActionHandle(actionName);
		if (actionHandle == null)
		{
			return;
		}
		actionHandle.Reset();
		this.ActionHandleMap.Remove(actionName);
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000E5310 File Offset: 0x000E3510
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual TsActionHandle GetActionHandle(string actionName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetActionHandle"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			return this.GetActionHandle_Implementation(actionName);
		}
		TsBasePlayerController.__GetActionHandle_FunctionParams* ptr = stackalloc TsBasePlayerController.__GetActionHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__GetActionHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->actionName), actionName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		TsActionHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsActionHandle>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000E53AD File Offset: 0x000E35AD
	[return: Nullable(2)]
	protected TsActionHandle GetActionHandle_Implementation(string actionName)
	{
		TMap<string, TsActionHandle> actionHandleMap = this.ActionHandleMap;
		if (actionHandleMap == null)
		{
			return null;
		}
		return actionHandleMap.Get(actionName);
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000E53C4 File Offset: 0x000E35C4
	private void ClearActionHandle()
	{
		if (!Info.Instance.UseFastInputCallback)
		{
			foreach (TsActionHandle tsActionHandle in this.ActionHandleMap.Values)
			{
				if (tsActionHandle != null)
				{
					tsActionHandle.Reset();
				}
			}
			this.ActionHandleMap.Empty(0);
			return;
		}
		if (this.TsActionHandleMap == null)
		{
			return;
		}
		foreach (KeyValuePair<string, TsPureActionHandle> keyValuePair in this.TsActionHandleMap)
		{
			TsPureActionHandle value = keyValuePair.Value;
			if (value != null)
			{
				value.Reset();
			}
		}
		this.TsActionHandleMap.Clear();
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000E54A0 File Offset: 0x000E36A0
	protected virtual void AddAxisHandle(string axisName)
	{
		if (Info.Instance.UseFastInputCallback)
		{
			if (this.TsAxisHandleMap == null)
			{
				this.TsAxisHandleMap = new Dictionary<string, TsPureAxisHandle>();
			}
			TsPureAxisHandle tsPureAxisHandle;
			if (!this.TsAxisHandleMap.TryGetValue(axisName, out tsPureAxisHandle))
			{
				tsPureAxisHandle = new TsPureAxisHandle();
				tsPureAxisHandle.Initialize(this);
				this.TsAxisHandleMap[axisName] = tsPureAxisHandle;
			}
			this.OnInputAxisCallbackNew = new Action<string, float, bool>(this.OnInputAxis);
			tsPureAxisHandle.AddAxisBinding(axisName, this.OnInputAxisCallbackNew);
			return;
		}
		TsAxisHandle tsAxisHandle = this.GetAxisHandle(axisName);
		if (tsAxisHandle == null)
		{
			tsAxisHandle = this.NewAxisHandle(axisName);
		}
		if (tsAxisHandle == null)
		{
			return;
		}
		this.OnInputAxisCallback = delegate(string axisNameInner, float value)
		{
			this.OnInputAxis(axisNameInner, value, false);
		};
		tsAxisHandle.AddAxisBinding(axisName, this.OnInputAxisCallback);
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000E5550 File Offset: 0x000E3750
	[return: Nullable(2)]
	protected virtual TsAxisHandle NewAxisHandle(string axisName)
	{
		if (this.AxisHandleClass == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前Controller中的AxisHandleClass不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ControllerName", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		TsAxisHandle tsAxisHandle = new TsAxisHandle();
		tsAxisHandle.Initialize(this);
		this.AxisHandleMap.Add(axisName, tsAxisHandle);
		return tsAxisHandle;
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000E55B8 File Offset: 0x000E37B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemoveAxisHandle(string axisName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveAxisHandle"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.RemoveAxisHandle_Implementation(axisName);
			return;
		}
		TsBasePlayerController.__RemoveAxisHandle_FunctionParams* ptr = stackalloc TsBasePlayerController.__RemoveAxisHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__RemoveAxisHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->axisName), axisName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000E564C File Offset: 0x000E384C
	protected void RemoveAxisHandle_Implementation(string axisName)
	{
		TsAxisHandle axisHandle = this.GetAxisHandle(axisName);
		if (axisHandle == null)
		{
			return;
		}
		axisHandle.Reset();
		this.AxisHandleMap.Remove(axisName);
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000E5678 File Offset: 0x000E3878
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual TsAxisHandle GetAxisHandle(string actionName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetAxisHandle"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			return this.GetAxisHandle_Implementation(actionName);
		}
		TsBasePlayerController.__GetAxisHandle_FunctionParams* ptr = stackalloc TsBasePlayerController.__GetAxisHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__GetAxisHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->actionName), actionName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		TsAxisHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsAxisHandle>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000E5715 File Offset: 0x000E3915
	[return: Nullable(2)]
	protected TsAxisHandle GetAxisHandle_Implementation(string actionName)
	{
		TMap<string, TsAxisHandle> axisHandleMap = this.AxisHandleMap;
		if (axisHandleMap == null)
		{
			return null;
		}
		return axisHandleMap.Get(actionName);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x000E572C File Offset: 0x000E392C
	private void ClearAxisHandle()
	{
		if (!Info.Instance.UseFastInputCallback)
		{
			foreach (TsAxisHandle tsAxisHandle in this.AxisHandleMap.Values)
			{
				if (tsAxisHandle != null)
				{
					tsAxisHandle.Reset();
				}
			}
			this.AxisHandleMap.Empty(0);
			return;
		}
		if (this.TsAxisHandleMap == null)
		{
			return;
		}
		foreach (KeyValuePair<string, TsPureAxisHandle> keyValuePair in this.TsAxisHandleMap)
		{
			TsPureAxisHandle value = keyValuePair.Value;
			if (value != null)
			{
				value.Reset();
			}
		}
		this.TsAxisHandleMap.Clear();
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x000E5808 File Offset: 0x000E3A08
	[NullableContext(2)]
	public virtual Vector2D GetInputPosition(int touchId = 0)
	{
		if (Info.Instance.IsInKeyBoard())
		{
			return this.GetCursorPosition();
		}
		if (Info.Instance.IsInTouch())
		{
			return this.GetTouchPosition(touchId);
		}
		return null;
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x000E5834 File Offset: 0x000E3A34
	[NullableContext(2)]
	public virtual Vector2D GetCursorPosition()
	{
		float num = 0f;
		float num2 = 0f;
		if (!base.GetMousePosition(ref num, ref num2))
		{
			return null;
		}
		this.CurrentInputPosition.X = (double)num;
		this.CurrentInputPosition.Y = (double)num2;
		return this.CurrentInputPosition;
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x000E587C File Offset: 0x000E3A7C
	[NullableContext(2)]
	public virtual Vector2D GetTouchPosition(int touchId)
	{
		float num = 0f;
		float num2 = 0f;
		bool flag = false;
		base.GetInputTouchState((ETouchIndex)touchId, ref num, ref num2, ref flag);
		this.CurrentInputPosition.X = (double)num;
		this.CurrentInputPosition.Y = (double)num2;
		return this.CurrentInputPosition;
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000E58C4 File Offset: 0x000E3AC4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsInTouch(float touchId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("IsInTouch"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			return this.IsInTouch_Implementation(touchId);
		}
		TsBasePlayerController.__IsInTouch_FunctionParams* ptr = stackalloc TsBasePlayerController.__IsInTouch_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__IsInTouch_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->touchId = touchId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000E5958 File Offset: 0x000E3B58
	protected bool IsInTouch_Implementation(float touchId)
	{
		float num = 0f;
		float num2 = 0f;
		bool result = false;
		base.GetInputTouchState((ETouchIndex)touchId, ref num, ref num2, ref result);
		return result;
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000E5984 File Offset: 0x000E3B84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetIsPrintKeyName(bool bPrintKeyName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsBasePlayerController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetIsPrintKeyName"), TsBasePlayerController.StaticClass(), out intPtr, out num))
		{
			this.SetIsPrintKeyName_Implementation(bPrintKeyName);
			return;
		}
		TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* ptr = stackalloc TsBasePlayerController.__SetIsPrintKeyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->bPrintKeyName = bPrintKeyName;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000E5A10 File Offset: 0x000E3C10
	protected void SetIsPrintKeyName_Implementation(bool bPrintKeyName)
	{
		this.PlayerInputHandle.IsPrintKeyName = bPrintKeyName;
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000E5A1E File Offset: 0x000E3C1E
	public virtual void SimulateTouch(ETouchIndex touchIndex, FVector position, bool isPress)
	{
		if (isPress)
		{
			this.PlayerInputHandle.TouchBegin(touchIndex, position);
			return;
		}
		this.PlayerInputHandle.TouchEnd(touchIndex, position);
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000E5A3E File Offset: 0x000E3C3E
	public virtual void SetCustomAction(string keyName, string actionName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.SetCustomAction(keyName, actionName);
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000E5A52 File Offset: 0x000E3C52
	public virtual void ResetAllCustomAction(string keyName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.ResetAllCustomAction(keyName);
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000E5A65 File Offset: 0x000E3C65
	public virtual void ResetCustomAction(string keyName, string actionName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.ResetCustomAction(keyName, actionName);
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000E5A79 File Offset: 0x000E3C79
	public virtual void SetActionEnable(string actionName, bool bEnable)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.SetActionEnable(actionName, bEnable);
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x000E5A8D File Offset: 0x000E3C8D
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual List<string> GetCurrentPlatformCustomActionKeyNameList(string actionName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return null;
		}
		return playerInputHandle.GetCurrentPlatformCustomActionKeyNameList(actionName);
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x000E5AA1 File Offset: 0x000E3CA1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBasePlayerController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C");
		}
		return TsBasePlayerController._ClassPtr;
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x000E5AC8 File Offset: 0x000E3CC8
	public TsBasePlayerController() : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x000E5AF0 File Offset: 0x000E3CF0
	public TsBasePlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x000E5B23 File Offset: 0x000E3D23
	protected TsBasePlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000E5B2C File Offset: 0x000E3D2C
	protected virtual void __CPPCALL_ReceiveSetupInputComponent_Implementation()
	{
		this.ReceiveSetupInputComponent_Implementation();
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000E5B34 File Offset: 0x000E3D34
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x000E5B3C File Offset: 0x000E3D3C
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x000E5B44 File Offset: 0x000E3D44
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x000E5B52 File Offset: 0x000E3D52
	protected virtual void __CPPCALL_OnReceivedPlayer_Implementation()
	{
		this.OnReceivedPlayer_Implementation();
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x000E5B5A File Offset: 0x000E3D5A
	protected virtual void __CPPCALL_InitInputHandle_Implementation()
	{
		this.InitInputHandle_Implementation();
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x000E5B62 File Offset: 0x000E3D62
	protected virtual void __CPPCALL_AddInputBinding_Implementation()
	{
		this.AddInputBinding_Implementation();
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x000E5B6A File Offset: 0x000E3D6A
	protected virtual void __CPPCALL_ClearInputBinding_Implementation()
	{
		this.ClearInputBinding_Implementation();
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x000E5B72 File Offset: 0x000E3D72
	protected virtual void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		this.OnSetupInputComponent_Implementation();
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x000E5B7A File Offset: 0x000E3D7A
	protected virtual void __CPPCALL_BindTouchHandle_Implementation()
	{
		this.BindTouchHandle_Implementation();
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x000E5B84 File Offset: 0x000E3D84
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchBegin_Implementation(TsBasePlayerController.__OnTouchBegin_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchBegin_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x000E5BA8 File Offset: 0x000E3DA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchEnd_Implementation(TsBasePlayerController.__OnTouchEnd_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchEnd_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x000E5BCC File Offset: 0x000E3DCC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchMove_Implementation(TsBasePlayerController.__OnTouchMove_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchMove_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x000E5BF0 File Offset: 0x000E3DF0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnPressAnyKey_Implementation(TsBasePlayerController.__OnPressAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnPressAnyKey_Implementation(key);
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x000E5C14 File Offset: 0x000E3E14
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnReleaseAnyKey_Implementation(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnReleaseAnyKey_Implementation(key);
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x000E5C38 File Offset: 0x000E3E38
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_RemoveActionHandle_Implementation(TsBasePlayerController.__RemoveActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		this.RemoveActionHandle_Implementation(actionName);
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x000E5C5C File Offset: 0x000E3E5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetActionHandle_Implementation(TsBasePlayerController.__GetActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsActionHandle actionHandle_Implementation = this.GetActionHandle_Implementation(actionName);
		ptr = ((actionHandle_Implementation != null) ? actionHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x000E5C94 File Offset: 0x000E3E94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_RemoveAxisHandle_Implementation(TsBasePlayerController.__RemoveAxisHandle_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		this.RemoveAxisHandle_Implementation(axisName);
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x000E5CB8 File Offset: 0x000E3EB8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetAxisHandle_Implementation(TsBasePlayerController.__GetAxisHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsAxisHandle axisHandle_Implementation = this.GetAxisHandle_Implementation(actionName);
		ptr = ((axisHandle_Implementation != null) ? axisHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x000E5CEE File Offset: 0x000E3EEE
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_IsInTouch_Implementation(TsBasePlayerController.__IsInTouch_FunctionParams* __Params)
	{
		__Params->__Result = this.IsInTouch_Implementation(__Params->touchId);
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x000E5D02 File Offset: 0x000E3F02
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetIsPrintKeyName_Implementation(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* __Params)
	{
		this.SetIsPrintKeyName_Implementation(__Params->bPrintKeyName);
	}

	// Token: 0x04002461 RID: 9313
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsPureActionHandle> TsActionHandleMap;

	// Token: 0x04002462 RID: 9314
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsPureAxisHandle> TsAxisHandleMap;

	// Token: 0x04002463 RID: 9315
	[Nullable(2)]
	private Vector2D CurrentInputPosition;

	// Token: 0x04002464 RID: 9316
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, bool, FKey> OnInputActionCallback;

	// Token: 0x04002465 RID: 9317
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float> OnInputAxisCallback;

	// Token: 0x04002466 RID: 9318
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float, bool> OnInputAxisCallbackNew;

	// Token: 0x04002467 RID: 9319
	[Nullable(2)]
	private PlayerInputHandle PlayerInputHandle;

	// Token: 0x04002468 RID: 9320
	[Nullable(2)]
	private TsPureKeyHandle TsKeyHandle;

	// Token: 0x04002469 RID: 9321
	[Nullable(2)]
	private TsPureTouchHandle TsTouchHandle;

	// Token: 0x0400246A RID: 9322
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C";

	// Token: 0x0400246B RID: 9323
	private static IntPtr _ClassPtr;

	// Token: 0x0400246C RID: 9324
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400246D RID: 9325
	private static int __PropertyOffset_ActionHandleClass;

	// Token: 0x0400246E RID: 9326
	private static int __PropertyOffset_AxisHandleClass;

	// Token: 0x0400246F RID: 9327
	private static int __PropertyOffset_ActionHandleMap;

	// Token: 0x04002470 RID: 9328
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, TsActionHandle> _ActionHandleMap;

	// Token: 0x04002471 RID: 9329
	private static int __PropertyOffset_AxisHandleMap;

	// Token: 0x04002472 RID: 9330
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, TsAxisHandle> _AxisHandleMap;

	// Token: 0x020065D7 RID: 26071
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchBegin_FunctionParams
	{
		// Token: 0x04021B6C RID: 138092
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x04021B6D RID: 138093
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x020065D8 RID: 26072
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchEnd_FunctionParams
	{
		// Token: 0x04021B6E RID: 138094
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x04021B6F RID: 138095
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x020065D9 RID: 26073
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchMove_FunctionParams
	{
		// Token: 0x04021B70 RID: 138096
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x04021B71 RID: 138097
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x020065DA RID: 26074
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnPressAnyKey_FunctionParams
	{
		// Token: 0x04021B72 RID: 138098
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x020065DB RID: 26075
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnReleaseAnyKey_FunctionParams
	{
		// Token: 0x04021B73 RID: 138099
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x020065DC RID: 26076
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveActionHandle_FunctionParams
	{
		// Token: 0x04021B74 RID: 138100
		[FieldOffset(0)]
		public FString actionName;
	}

	// Token: 0x020065DD RID: 26077
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetActionHandle_FunctionParams
	{
		// Token: 0x04021B75 RID: 138101
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x04021B76 RID: 138102
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020065DE RID: 26078
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveAxisHandle_FunctionParams
	{
		// Token: 0x04021B77 RID: 138103
		[FieldOffset(0)]
		public FString axisName;
	}

	// Token: 0x020065DF RID: 26079
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAxisHandle_FunctionParams
	{
		// Token: 0x04021B78 RID: 138104
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x04021B79 RID: 138105
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020065E0 RID: 26080
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __IsInTouch_FunctionParams
	{
		// Token: 0x04021B7A RID: 138106
		[FieldOffset(0)]
		public float touchId;

		// Token: 0x04021B7B RID: 138107
		[FieldOffset(4)]
		public bool __Result;
	}

	// Token: 0x020065E1 RID: 26081
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetIsPrintKeyName_FunctionParams
	{
		// Token: 0x04021B7C RID: 138108
		[FieldOffset(0)]
		public bool bPrintKeyName;
	}
}
