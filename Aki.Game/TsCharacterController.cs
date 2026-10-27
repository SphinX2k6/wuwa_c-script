using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Controller;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000259 RID: 601
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C")]
public class TsCharacterController : TsBasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x060024E1 RID: 9441 RVA: 0x000DF8DC File Offset: 0x000DDADC
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

	// Token: 0x060024E2 RID: 9442 RVA: 0x000DF94C File Offset: 0x000DDB4C
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		base.ChangeRotationOnPossess = false;
		base.bShowMouseCursor = Info.Instance.IsInKeyBoard();
		UKuroInputFunctionLibrary.ApplyInputMode(this);
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000DF974 File Offset: 0x000DDB74
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

	// Token: 0x060024E4 RID: 9444 RVA: 0x000DF9E4 File Offset: 0x000DDBE4
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		if (this.TsUiKeyHandle != null)
		{
			this.TsUiKeyHandle.Reset();
			this.TsUiKeyHandle = null;
		}
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000DFA08 File Offset: 0x000DDC08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePossess(APawn PossessedPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceivePossess"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AController.__ReceivePossess_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AController.__ReceivePossess_FunctionParams*)ptr + 15L / (long)sizeof(AController.__ReceivePossess_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->PossessedPawn) = ((PossessedPawn != null) ? PossessedPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000DFA8C File Offset: 0x000DDC8C
	protected virtual void ReceivePossess_Implementation(APawn PossessedPawn)
	{
		CameraController.Instance.OnPossess(PossessedPawn, "MainCamera");
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000DFAA0 File Offset: 0x000DDCA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveUnPossess(APawn UnpossessedPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveUnPossess"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AController.__ReceiveUnPossess_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AController.__ReceiveUnPossess_FunctionParams*)ptr + 15L / (long)sizeof(AController.__ReceiveUnPossess_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->UnpossessedPawn) = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000DFB24 File Offset: 0x000DDD24
	protected virtual void ReceiveUnPossess_Implementation(APawn UnpossessedPawn)
	{
		CameraController.Instance.OnPossess(null, "MainCamera");
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000DFB38 File Offset: 0x000DDD38
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe override void OnSetupInputComponent()
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

	// Token: 0x060024EA RID: 9450 RVA: 0x000DFBA8 File Offset: 0x000DDDA8
	protected new void OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
		this.CursorInputVector = Vector2D.Create(0.0, 0.0);
		this.MoveInputVector = Vector2D.Create(0.0, 0.0);
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000DFBF8 File Offset: 0x000DDDF8
	protected override void BindActionHandle()
	{
		base.BindActionHandle();
		IReadOnlyList<ActionMapping> allActionMappingConfig = InputSettingsConfig.GetOrCreateInstance().GetAllActionMappingConfig();
		if (allActionMappingConfig == null)
		{
			return;
		}
		foreach (ActionMapping actionMapping in allActionMappingConfig)
		{
			base.AddActionHandle(actionMapping.ActionName);
		}
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000DFC5C File Offset: 0x000DDE5C
	protected override void BindAxisHandle()
	{
		base.BindAxisHandle();
		foreach (AxisMapping axisMapping in InputSettingsConfig.Instance.GetAllAxisMappingConfig())
		{
			this.AddAxisHandle(axisMapping.AxisName);
		}
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000DFCBC File Offset: 0x000DDEBC
	protected override void BindKeyHandle()
	{
		base.BindKeyHandle();
		if (Info.Instance.UseFastInputCallback)
		{
			if (this.TsUiKeyHandle == null)
			{
				this.TsUiKeyHandle = new TsPureUiKeyHandle();
				this.TsUiKeyHandle.Initialize(this);
			}
			this.TsUiKeyHandle.BindKey();
			return;
		}
		FInputChord finputChord = new FInputChord(new FKey(TsCharacterController.LEFT_BARACKET_NAME), false, false, false, false);
		EInputEvent keyEvent = EInputEvent.IE_Released;
		FName fname = new FName("OnSetUiRootDeactivate");
		base.AddKeyBinding(finputChord, keyEvent, this, fname);
		FInputChord finputChord2 = new FInputChord(new FKey(TsCharacterController.RIGHT_BARACKET_NAME), false, false, false, false);
		EInputEvent keyEvent2 = EInputEvent.IE_Released;
		fname = new FName("OnSetUiRootActive");
		base.AddKeyBinding(finputChord2, keyEvent2, this, fname);
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x000DFD5C File Offset: 0x000DDF5C
	[NullableContext(1)]
	protected override void OnInputAxis(string axisName, float value, bool alwaysTick = false)
	{
		base.OnInputAxis(axisName, value, alwaysTick);
		if (axisName == "LookUp")
		{
			this.CursorInputVector.Y = (double)value;
		}
		if (axisName == "Turn")
		{
			this.CursorInputVector.X = (double)value;
		}
		if (axisName == "MoveForward")
		{
			this.MoveInputVector.Y = (double)value;
		}
		if (axisName == "MoveRight")
		{
			this.MoveInputVector.X = (double)value;
		}
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000DFDDC File Offset: 0x000DDFDC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePreProcessInput(float deltaTime, bool bGamePaused)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceivePreProcessInput"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ABasePlayerController.__ReceivePreProcessInput_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ABasePlayerController.__ReceivePreProcessInput_FunctionParams*)ptr + 15L / (long)sizeof(ABasePlayerController.__ReceivePreProcessInput_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaTime = deltaTime;
			ptr2->bGamePaused = bGamePaused;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x000DFE59 File Offset: 0x000DE059
	protected virtual void ReceivePreProcessInput_Implementation(float deltaTime, bool bGamePaused)
	{
		InputController.GetOrCreateInstance().PreProcessInput(deltaTime, bGamePaused);
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x000DFE68 File Offset: 0x000DE068
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePostProcessInput(float deltaTime, bool bGamePaused)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceivePostProcessInput"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ABasePlayerController.__ReceivePostProcessInput_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ABasePlayerController.__ReceivePostProcessInput_FunctionParams*)ptr + 15L / (long)sizeof(ABasePlayerController.__ReceivePostProcessInput_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaTime = deltaTime;
			ptr2->bGamePaused = bGamePaused;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x000DFEE5 File Offset: 0x000DE0E5
	protected virtual void ReceivePostProcessInput_Implementation(float deltaTime, bool bGamePaused)
	{
		InputController.Instance.PostProcessInput(deltaTime, bGamePaused);
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000DFEF4 File Offset: 0x000DE0F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnSetUiRootActive()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnSetUiRootActive"), out num);
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

	// Token: 0x060024F4 RID: 9460 RVA: 0x000DFF64 File Offset: 0x000DE164
	protected void OnSetUiRootActive_Implementation()
	{
		if (SundryModel.Instance.CanOpenGmView)
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 】 键显示所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiLayer.Instance.ForceShowUi();
		}
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000DFFA4 File Offset: 0x000DE1A4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnSetUiRootDeactivate()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnSetUiRootDeactivate"), out num);
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

	// Token: 0x060024F6 RID: 9462 RVA: 0x000E0014 File Offset: 0x000DE214
	protected void OnSetUiRootDeactivate_Implementation()
	{
		if (SundryModel.Instance.CanOpenGmView)
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 【 键隐藏所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiLayer.Instance.ForceHideUi();
		}
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x000E0053 File Offset: 0x000DE253
	public Vector2D GetCursorInputVector()
	{
		return this.CursorInputVector;
	}

	// Token: 0x060024F8 RID: 9464 RVA: 0x000E005B File Offset: 0x000DE25B
	public Vector2D GetMoveInputVector()
	{
		return this.MoveInputVector;
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x000E0063 File Offset: 0x000DE263
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsCharacterController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C");
		}
		return TsCharacterController._ClassPtr;
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x000E0088 File Offset: 0x000DE288
	public TsCharacterController() : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000E00B0 File Offset: 0x000DE2B0
	[NullableContext(1)]
	public TsCharacterController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000E00E3 File Offset: 0x000DE2E3
	protected TsCharacterController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000E00EC File Offset: 0x000DE2EC
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x000E00F4 File Offset: 0x000DE2F4
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000E00FC File Offset: 0x000DE2FC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePossess_Implementation(AController.__ReceivePossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->PossessedPawn);
		this.ReceivePossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x000E011C File Offset: 0x000DE31C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveUnPossess_Implementation(AController.__ReceiveUnPossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->UnpossessedPawn);
		this.ReceiveUnPossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x000E013C File Offset: 0x000DE33C
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		this.OnSetupInputComponent_Implementation();
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000E0144 File Offset: 0x000DE344
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePreProcessInput_Implementation(ABasePlayerController.__ReceivePreProcessInput_FunctionParams* __Params)
	{
		this.ReceivePreProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000E0158 File Offset: 0x000DE358
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePostProcessInput_Implementation(ABasePlayerController.__ReceivePostProcessInput_FunctionParams* __Params)
	{
		this.ReceivePostProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000E016C File Offset: 0x000DE36C
	protected virtual void __CPPCALL_OnSetUiRootActive_Implementation()
	{
		this.OnSetUiRootActive_Implementation();
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x000E0174 File Offset: 0x000DE374
	protected virtual void __CPPCALL_OnSetUiRootDeactivate_Implementation()
	{
		this.OnSetUiRootDeactivate_Implementation();
	}

	// Token: 0x040023F5 RID: 9205
	private static readonly FName LEFT_BARACKET_NAME = new FName("LeftBracket");

	// Token: 0x040023F6 RID: 9206
	private static readonly FName RIGHT_BARACKET_NAME = new FName("RightBracket");

	// Token: 0x040023F7 RID: 9207
	private Vector2D CursorInputVector;

	// Token: 0x040023F8 RID: 9208
	private Vector2D MoveInputVector;

	// Token: 0x040023F9 RID: 9209
	private TsPureUiKeyHandle TsUiKeyHandle;

	// Token: 0x040023FA RID: 9210
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C";

	// Token: 0x040023FB RID: 9211
	private static IntPtr _ClassPtr;

	// Token: 0x040023FC RID: 9212
	private static IntPtr _ClassDefaultObjectPtr;
}
