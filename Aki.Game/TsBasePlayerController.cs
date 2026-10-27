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

// Token: 0x02000258 RID: 600
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C")]
public class TsBasePlayerController : ABasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x06002484 RID: 9348 RVA: 0x000DE1BA File Offset: 0x000DC3BA
	// (set) Token: 0x06002485 RID: 9349 RVA: 0x000DE1CE File Offset: 0x000DC3CE
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

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x06002486 RID: 9350 RVA: 0x000DE1E3 File Offset: 0x000DC3E3
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

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x06002487 RID: 9351 RVA: 0x000DE1F8 File Offset: 0x000DC3F8
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

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06002488 RID: 9352 RVA: 0x000DE234 File Offset: 0x000DC434
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

	// Token: 0x06002489 RID: 9353 RVA: 0x000DE270 File Offset: 0x000DC470
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveSetupInputComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveSetupInputComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x000DE2E0 File Offset: 0x000DC4E0
	protected virtual void ReceiveSetupInputComponent_Implementation()
	{
		this.InitInputHandle();
		this.AddInputBinding();
		this.OnSetupInputComponent();
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x000DE2F4 File Offset: 0x000DC4F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000DE364 File Offset: 0x000DC564
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		this.InitInputHandle();
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000DE36C File Offset: 0x000DC56C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveDestroyed()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveDestroyed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000DE3DC File Offset: 0x000DC5DC
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

	// Token: 0x0600248F RID: 9359 RVA: 0x000DE448 File Offset: 0x000DC648
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x000DE4BE File Offset: 0x000DC6BE
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.Tick(deltaSeconds);
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000DE4D4 File Offset: 0x000DC6D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnReceivedPlayer()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnReceivedPlayer"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000DE544 File Offset: 0x000DC744
	protected virtual void OnReceivedPlayer_Implementation()
	{
		UKuroInputFunctionLibrary.ResetInputMode(this);
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000DE54C File Offset: 0x000DC74C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InitInputHandle()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitInputHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x000DE5BC File Offset: 0x000DC7BC
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

	// Token: 0x06002495 RID: 9365 RVA: 0x000DE634 File Offset: 0x000DC834
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddInputBinding()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddInputBinding"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x000DE6A4 File Offset: 0x000DC8A4
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

	// Token: 0x06002497 RID: 9367 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ClearInputBinding()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ClearInputBinding"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x000DE760 File Offset: 0x000DC960
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

	// Token: 0x06002499 RID: 9369 RVA: 0x000DE7DC File Offset: 0x000DC9DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnSetupInputComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnSetupInputComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000DE84C File Offset: 0x000DCA4C
	protected void OnSetupInputComponent_Implementation()
	{
		this.CurrentInputPosition = Vector2D.Create(0.0, 0.0);
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x000DE86B File Offset: 0x000DCA6B
	protected virtual void BindActionHandle()
	{
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x000DE86D File Offset: 0x000DCA6D
	protected virtual void BindAxisHandle()
	{
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x000DE870 File Offset: 0x000DCA70
	protected virtual void BindKeyHandle()
	{
		if (!Info.Instance.UseFastInputCallback)
		{
			FInputChord finputChord = new FInputChord(new FKey(FNameUtil.GetDynamicFName("AnyKey") ?? FName.NAME_None), false, false, false, false);
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

	// Token: 0x0600249E RID: 9374 RVA: 0x000DE91C File Offset: 0x000DCB1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void BindTouchHandle()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindTouchHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x000DE98C File Offset: 0x000DCB8C
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

	// Token: 0x060024A0 RID: 9376 RVA: 0x000DEA15 File Offset: 0x000DCC15
	protected virtual void OnInputAction(string actionName, bool bPress, FKey key)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
		this.PlayerInputHandle.InputAction(actionName, bPress, key);
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x000DEA3E File Offset: 0x000DCC3E
	protected virtual void OnInputAxis(string axisName, float value, bool alwaysTick = false)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(true, axisName, (double)value);
		this.PlayerInputHandle.InputAxis(axisName, value, alwaysTick);
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x000DEA5C File Offset: 0x000DCC5C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchBegin(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchBegin_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x000DEADC File Offset: 0x000DCCDC
	protected void OnTouchBegin_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchBegin(touchIndex, position);
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x000DEB04 File Offset: 0x000DCD04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchEnd(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchEnd_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000DEB84 File Offset: 0x000DCD84
	protected void OnTouchEnd_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchEnd(touchIndex, position);
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000DEB94 File Offset: 0x000DCD94
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnTouchMove(ETouchIndex touchIndex, FVector position)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnTouchMove"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnTouchMove_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnTouchMove_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnTouchMove_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->touchIndex) = (byte)touchIndex;
			ptr2->position = position;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x000DEC14 File Offset: 0x000DCE14
	protected void OnTouchMove_Implementation(ETouchIndex touchIndex, FVector position)
	{
		this.PlayerInputHandle.TouchMove(touchIndex, position);
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x000DEC24 File Offset: 0x000DCE24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnPressAnyKey(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPressAnyKey"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnPressAnyKey_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnPressAnyKey_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnPressAnyKey_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x000DECB3 File Offset: 0x000DCEB3
	protected void OnPressAnyKey_Implementation(FKey key)
	{
		LogReportModel.GetOrCreateInstance().RecordOperateTime(false, "", 0.0);
		this.PlayerInputHandle.PressAnyKey(key);
		PlatformModel.GetOrCreateInstance().OnPressAnyKey(key);
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000DECE8 File Offset: 0x000DCEE8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnReleaseAnyKey(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnReleaseAnyKey"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__OnReleaseAnyKey_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x000DED77 File Offset: 0x000DCF77
	protected void OnReleaseAnyKey_Implementation(FKey key)
	{
		this.PlayerInputHandle.ReleaseAnyKey(key);
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x000DED88 File Offset: 0x000DCF88
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

	// Token: 0x060024AD RID: 9389 RVA: 0x000DEE38 File Offset: 0x000DD038
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

	// Token: 0x060024AE RID: 9390 RVA: 0x000DEEA0 File Offset: 0x000DD0A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemoveActionHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveActionHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__RemoveActionHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__RemoveActionHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__RemoveActionHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x000DEF1C File Offset: 0x000DD11C
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

	// Token: 0x060024B0 RID: 9392 RVA: 0x000DEF48 File Offset: 0x000DD148
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual TsActionHandle GetActionHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetActionHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__GetActionHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__GetActionHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__GetActionHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		TsActionHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsActionHandle>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x000DEFCF File Offset: 0x000DD1CF
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

	// Token: 0x060024B2 RID: 9394 RVA: 0x000DEFE4 File Offset: 0x000DD1E4
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

	// Token: 0x060024B3 RID: 9395 RVA: 0x000DF0C0 File Offset: 0x000DD2C0
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

	// Token: 0x060024B4 RID: 9396 RVA: 0x000DF170 File Offset: 0x000DD370
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

	// Token: 0x060024B5 RID: 9397 RVA: 0x000DF1D8 File Offset: 0x000DD3D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void RemoveAxisHandle(string axisName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveAxisHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__RemoveAxisHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__RemoveAxisHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__RemoveAxisHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->axisName), axisName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000DF254 File Offset: 0x000DD454
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

	// Token: 0x060024B7 RID: 9399 RVA: 0x000DF280 File Offset: 0x000DD480
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	protected unsafe virtual TsAxisHandle GetAxisHandle(string actionName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetAxisHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__GetAxisHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__GetAxisHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__GetAxisHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->actionName), actionName);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		TsAxisHandle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsAxisHandle>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x000DF307 File Offset: 0x000DD507
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

	// Token: 0x060024B9 RID: 9401 RVA: 0x000DF31C File Offset: 0x000DD51C
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

	// Token: 0x060024BA RID: 9402 RVA: 0x000DF3F8 File Offset: 0x000DD5F8
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

	// Token: 0x060024BB RID: 9403 RVA: 0x000DF424 File Offset: 0x000DD624
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

	// Token: 0x060024BC RID: 9404 RVA: 0x000DF46C File Offset: 0x000DD66C
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

	// Token: 0x060024BD RID: 9405 RVA: 0x000DF4B4 File Offset: 0x000DD6B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsInTouch(float touchId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsInTouch"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__IsInTouch_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__IsInTouch_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__IsInTouch_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchId = touchId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x000DF530 File Offset: 0x000DD730
	protected bool IsInTouch_Implementation(float touchId)
	{
		float num = 0f;
		float num2 = 0f;
		bool result = false;
		base.GetInputTouchState((ETouchIndex)touchId, ref num, ref num2, ref result);
		return result;
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x000DF55C File Offset: 0x000DD75C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetIsPrintKeyName(bool bPrintKeyName)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetIsPrintKeyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBasePlayerController.__SetIsPrintKeyName_FunctionParams*)ptr + 15L / (long)sizeof(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->bPrintKeyName = bPrintKeyName;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x000DF5D2 File Offset: 0x000DD7D2
	protected void SetIsPrintKeyName_Implementation(bool bPrintKeyName)
	{
		this.PlayerInputHandle.IsPrintKeyName = bPrintKeyName;
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x000DF5E0 File Offset: 0x000DD7E0
	public virtual void SimulateTouch(ETouchIndex touchIndex, FVector position, bool isPress)
	{
		if (isPress)
		{
			this.PlayerInputHandle.TouchBegin(touchIndex, position);
			return;
		}
		this.PlayerInputHandle.TouchEnd(touchIndex, position);
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x000DF600 File Offset: 0x000DD800
	public virtual void SetCustomAction(string keyName, string actionName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.SetCustomAction(keyName, actionName);
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x000DF614 File Offset: 0x000DD814
	public virtual void ResetAllCustomAction(string keyName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.ResetAllCustomAction(keyName);
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x000DF627 File Offset: 0x000DD827
	public virtual void ResetCustomAction(string keyName, string actionName)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.ResetCustomAction(keyName, actionName);
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x000DF63B File Offset: 0x000DD83B
	public virtual void SetActionEnable(string actionName, bool bEnable)
	{
		PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
		if (playerInputHandle == null)
		{
			return;
		}
		playerInputHandle.SetActionEnable(actionName, bEnable);
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x000DF64F File Offset: 0x000DD84F
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

	// Token: 0x060024C7 RID: 9415 RVA: 0x000DF663 File Offset: 0x000DD863
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsBasePlayerController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C");
		}
		return TsBasePlayerController._ClassPtr;
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x000DF688 File Offset: 0x000DD888
	public TsBasePlayerController() : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x000DF6B0 File Offset: 0x000DD8B0
	public TsBasePlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x000DF6E3 File Offset: 0x000DD8E3
	protected TsBasePlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000DF6EC File Offset: 0x000DD8EC
	protected virtual void __CPPCALL_ReceiveSetupInputComponent_Implementation()
	{
		this.ReceiveSetupInputComponent_Implementation();
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x000DF6F4 File Offset: 0x000DD8F4
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000DF6FC File Offset: 0x000DD8FC
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000DF704 File Offset: 0x000DD904
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x000DF712 File Offset: 0x000DD912
	protected virtual void __CPPCALL_OnReceivedPlayer_Implementation()
	{
		this.OnReceivedPlayer_Implementation();
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000DF71A File Offset: 0x000DD91A
	protected virtual void __CPPCALL_InitInputHandle_Implementation()
	{
		this.InitInputHandle_Implementation();
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000DF722 File Offset: 0x000DD922
	protected virtual void __CPPCALL_AddInputBinding_Implementation()
	{
		this.AddInputBinding_Implementation();
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000DF72A File Offset: 0x000DD92A
	protected virtual void __CPPCALL_ClearInputBinding_Implementation()
	{
		this.ClearInputBinding_Implementation();
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000DF732 File Offset: 0x000DD932
	protected virtual void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		this.OnSetupInputComponent_Implementation();
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x000DF73A File Offset: 0x000DD93A
	protected virtual void __CPPCALL_BindTouchHandle_Implementation()
	{
		this.BindTouchHandle_Implementation();
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000DF744 File Offset: 0x000DD944
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchBegin_Implementation(TsBasePlayerController.__OnTouchBegin_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchBegin_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x000DF768 File Offset: 0x000DD968
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchEnd_Implementation(TsBasePlayerController.__OnTouchEnd_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchEnd_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000DF78C File Offset: 0x000DD98C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnTouchMove_Implementation(TsBasePlayerController.__OnTouchMove_FunctionParams* __Params)
	{
		ETouchIndex touchIndex = (ETouchIndex)__Params->touchIndex;
		this.OnTouchMove_Implementation(touchIndex, __Params->position);
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x000DF7B0 File Offset: 0x000DD9B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnPressAnyKey_Implementation(TsBasePlayerController.__OnPressAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnPressAnyKey_Implementation(key);
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x000DF7D4 File Offset: 0x000DD9D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnReleaseAnyKey_Implementation(TsBasePlayerController.__OnReleaseAnyKey_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnReleaseAnyKey_Implementation(key);
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_RemoveActionHandle_Implementation(TsBasePlayerController.__RemoveActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		this.RemoveActionHandle_Implementation(actionName);
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x000DF81C File Offset: 0x000DDA1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetActionHandle_Implementation(TsBasePlayerController.__GetActionHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsActionHandle actionHandle_Implementation = this.GetActionHandle_Implementation(actionName);
		ptr = ((actionHandle_Implementation != null) ? actionHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x000DF854 File Offset: 0x000DDA54
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_RemoveAxisHandle_Implementation(TsBasePlayerController.__RemoveAxisHandle_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		this.RemoveAxisHandle_Implementation(axisName);
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x000DF878 File Offset: 0x000DDA78
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetAxisHandle_Implementation(TsBasePlayerController.__GetAxisHandle_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsAxisHandle axisHandle_Implementation = this.GetAxisHandle_Implementation(actionName);
		ptr = ((axisHandle_Implementation != null) ? axisHandle_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000DF8AE File Offset: 0x000DDAAE
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_IsInTouch_Implementation(TsBasePlayerController.__IsInTouch_FunctionParams* __Params)
	{
		__Params->__Result = this.IsInTouch_Implementation(__Params->touchId);
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x000DF8C2 File Offset: 0x000DDAC2
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_SetIsPrintKeyName_Implementation(TsBasePlayerController.__SetIsPrintKeyName_FunctionParams* __Params)
	{
		this.SetIsPrintKeyName_Implementation(__Params->bPrintKeyName);
	}

	// Token: 0x040023E3 RID: 9187
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsPureActionHandle> TsActionHandleMap;

	// Token: 0x040023E4 RID: 9188
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsPureAxisHandle> TsAxisHandleMap;

	// Token: 0x040023E5 RID: 9189
	[Nullable(2)]
	private Vector2D CurrentInputPosition;

	// Token: 0x040023E6 RID: 9190
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, bool, FKey> OnInputActionCallback;

	// Token: 0x040023E7 RID: 9191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float> OnInputAxisCallback;

	// Token: 0x040023E8 RID: 9192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float, bool> OnInputAxisCallbackNew;

	// Token: 0x040023E9 RID: 9193
	[Nullable(2)]
	private PlayerInputHandle PlayerInputHandle;

	// Token: 0x040023EA RID: 9194
	[Nullable(2)]
	private TsPureKeyHandle TsKeyHandle;

	// Token: 0x040023EB RID: 9195
	[Nullable(2)]
	private TsPureTouchHandle TsTouchHandle;

	// Token: 0x040023EC RID: 9196
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsBasePlayerController.TsBasePlayerController_C";

	// Token: 0x040023ED RID: 9197
	private static IntPtr _ClassPtr;

	// Token: 0x040023EE RID: 9198
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040023EF RID: 9199
	private static int __PropertyOffset_ActionHandleClass;

	// Token: 0x040023F0 RID: 9200
	private static int __PropertyOffset_AxisHandleClass;

	// Token: 0x040023F1 RID: 9201
	private static int __PropertyOffset_ActionHandleMap;

	// Token: 0x040023F2 RID: 9202
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, TsActionHandle> _ActionHandleMap;

	// Token: 0x040023F3 RID: 9203
	private static int __PropertyOffset_AxisHandleMap;

	// Token: 0x040023F4 RID: 9204
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, TsAxisHandle> _AxisHandleMap;

	// Token: 0x02007446 RID: 29766
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchBegin_FunctionParams
	{
		// Token: 0x0402682E RID: 157742
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x0402682F RID: 157743
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x02007447 RID: 29767
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchEnd_FunctionParams
	{
		// Token: 0x04026830 RID: 157744
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x04026831 RID: 157745
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x02007448 RID: 29768
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnTouchMove_FunctionParams
	{
		// Token: 0x04026832 RID: 157746
		[FieldOffset(0)]
		public byte touchIndex;

		// Token: 0x04026833 RID: 157747
		[FieldOffset(4)]
		public FVector position;
	}

	// Token: 0x02007449 RID: 29769
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnPressAnyKey_FunctionParams
	{
		// Token: 0x04026834 RID: 157748
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x0200744A RID: 29770
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnReleaseAnyKey_FunctionParams
	{
		// Token: 0x04026835 RID: 157749
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x0200744B RID: 29771
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveActionHandle_FunctionParams
	{
		// Token: 0x04026836 RID: 157750
		[FieldOffset(0)]
		public FString actionName;
	}

	// Token: 0x0200744C RID: 29772
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetActionHandle_FunctionParams
	{
		// Token: 0x04026837 RID: 157751
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x04026838 RID: 157752
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200744D RID: 29773
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveAxisHandle_FunctionParams
	{
		// Token: 0x04026839 RID: 157753
		[FieldOffset(0)]
		public FString axisName;
	}

	// Token: 0x0200744E RID: 29774
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAxisHandle_FunctionParams
	{
		// Token: 0x0402683A RID: 157754
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x0402683B RID: 157755
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200744F RID: 29775
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __IsInTouch_FunctionParams
	{
		// Token: 0x0402683C RID: 157756
		[FieldOffset(0)]
		public float touchId;

		// Token: 0x0402683D RID: 157757
		[FieldOffset(4)]
		public bool __Result;
	}

	// Token: 0x02007450 RID: 29776
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetIsPrintKeyName_FunctionParams
	{
		// Token: 0x0402683E RID: 157758
		[FieldOffset(0)]
		public bool bPrintKeyName;
	}
}
