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

// Token: 0x0200025D RID: 605
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C")]
public class TsCharacterController : TsBasePlayerController, IUnrealUObject, IUnrealObject
{
	// Token: 0x06002598 RID: 9624 RVA: 0x000E5D1C File Offset: 0x000E3F1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), TsCharacterController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x000E5D75 File Offset: 0x000E3F75
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		base.ChangeRotationOnPossess = false;
		base.bShowMouseCursor = Info.Instance.IsInKeyBoard();
		UKuroInputFunctionLibrary.ApplyInputMode(this);
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x000E5D9C File Offset: 0x000E3F9C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsCharacterController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x000E5DF5 File Offset: 0x000E3FF5
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		if (this.TsUiKeyHandle != null)
		{
			this.TsUiKeyHandle.Reset();
			this.TsUiKeyHandle = null;
		}
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000E5E18 File Offset: 0x000E4018
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePossess(APawn PossessedPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceivePossess"), TsCharacterController.StaticClass(), out intPtr, out num))
		{
			this.ReceivePossess_Implementation(PossessedPawn);
			return;
		}
		AController.__ReceivePossess_FunctionParams* ptr = stackalloc AController.__ReceivePossess_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AController.__ReceivePossess_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->PossessedPawn) = ((PossessedPawn != null) ? PossessedPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x000E5EB2 File Offset: 0x000E40B2
	protected virtual void ReceivePossess_Implementation(APawn PossessedPawn)
	{
		CameraController.Instance.OnPossess(PossessedPawn, "MainCamera");
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000E5EC4 File Offset: 0x000E40C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveUnPossess(APawn UnpossessedPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveUnPossess"), TsCharacterController.StaticClass(), out intPtr, out num))
		{
			this.ReceiveUnPossess_Implementation(UnpossessedPawn);
			return;
		}
		AController.__ReceiveUnPossess_FunctionParams* ptr = stackalloc AController.__ReceiveUnPossess_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AController.__ReceiveUnPossess_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->UnpossessedPawn) = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000E5F5E File Offset: 0x000E415E
	protected virtual void ReceiveUnPossess_Implementation(APawn UnpossessedPawn)
	{
		CameraController.Instance.OnPossess(null, "MainCamera");
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x000E5F70 File Offset: 0x000E4170
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected override void OnSetupInputComponent()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnSetupInputComponent"), TsCharacterController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnSetupInputComponent_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000E5FCC File Offset: 0x000E41CC
	protected new void OnSetupInputComponent_Implementation()
	{
		base.OnSetupInputComponent_Implementation();
		this.CursorInputVector = Vector2D.Create(0.0, 0.0);
		this.MoveInputVector = Vector2D.Create(0.0, 0.0);
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x000E601C File Offset: 0x000E421C
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

	// Token: 0x060025A3 RID: 9635 RVA: 0x000E6080 File Offset: 0x000E4280
	protected override void BindAxisHandle()
	{
		base.BindAxisHandle();
		foreach (AxisMapping axisMapping in InputSettingsConfig.Instance.GetAllAxisMappingConfig())
		{
			this.AddAxisHandle(axisMapping.AxisName);
		}
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000E60E0 File Offset: 0x000E42E0
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
		FInputChord finputChord = new FInputChord
		{
			Key = new FKey
			{
				KeyName = TsCharacterController.LEFT_BARACKET_NAME
			}
		};
		EInputEvent keyEvent = EInputEvent.IE_Released;
		FName fname = new FName("OnSetUiRootDeactivate");
		base.AddKeyBinding(finputChord, keyEvent, this, fname);
		FInputChord finputChord2 = new FInputChord
		{
			Key = new FKey
			{
				KeyName = TsCharacterController.RIGHT_BARACKET_NAME
			}
		};
		EInputEvent keyEvent2 = EInputEvent.IE_Released;
		fname = new FName("OnSetUiRootActive");
		base.AddKeyBinding(finputChord2, keyEvent2, this, fname);
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000E6190 File Offset: 0x000E4390
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

	// Token: 0x060025A6 RID: 9638 RVA: 0x000E6210 File Offset: 0x000E4410
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePreProcessInput(float deltaTime, bool bGamePaused)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceivePreProcessInput"), TsCharacterController.StaticClass(), out intPtr, out num))
		{
			this.ReceivePreProcessInput_Implementation(deltaTime, bGamePaused);
			return;
		}
		ABasePlayerController.__ReceivePreProcessInput_FunctionParams* ptr = stackalloc ABasePlayerController.__ReceivePreProcessInput_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ABasePlayerController.__ReceivePreProcessInput_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaTime = deltaTime;
		ptr->bGamePaused = bGamePaused;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000E62A4 File Offset: 0x000E44A4
	protected virtual void ReceivePreProcessInput_Implementation(float deltaTime, bool bGamePaused)
	{
		InputController.GetOrCreateInstance().PreProcessInput(deltaTime, bGamePaused);
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x000E62B4 File Offset: 0x000E44B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceivePostProcessInput(float deltaTime, bool bGamePaused)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceivePostProcessInput"), TsCharacterController.StaticClass(), out intPtr, out num))
		{
			this.ReceivePostProcessInput_Implementation(deltaTime, bGamePaused);
			return;
		}
		ABasePlayerController.__ReceivePostProcessInput_FunctionParams* ptr = stackalloc ABasePlayerController.__ReceivePostProcessInput_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ABasePlayerController.__ReceivePostProcessInput_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaTime = deltaTime;
		ptr->bGamePaused = bGamePaused;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x000E6348 File Offset: 0x000E4548
	protected virtual void ReceivePostProcessInput_Implementation(float deltaTime, bool bGamePaused)
	{
		InputController.Instance.PostProcessInput(deltaTime, bGamePaused);
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000E6358 File Offset: 0x000E4558
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void OnSetUiRootActive()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnSetUiRootActive"), TsCharacterController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnSetUiRootActive_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000E63B4 File Offset: 0x000E45B4
	protected void OnSetUiRootActive_Implementation()
	{
		if (SundryModel.Instance.CanOpenGmView)
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 】 键显示所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiLayer.Instance.ForceShowUi();
		}
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000E63F4 File Offset: 0x000E45F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void OnSetUiRootDeactivate()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsCharacterController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnSetUiRootDeactivate"), TsCharacterController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnSetUiRootDeactivate_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000E6450 File Offset: 0x000E4650
	protected void OnSetUiRootDeactivate_Implementation()
	{
		if (SundryModel.Instance.CanOpenGmView)
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "按下 【 键隐藏所有界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiLayer.Instance.ForceHideUi();
		}
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x000E648F File Offset: 0x000E468F
	public Vector2D GetCursorInputVector()
	{
		return this.CursorInputVector;
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x000E6497 File Offset: 0x000E4697
	public Vector2D GetMoveInputVector()
	{
		return this.MoveInputVector;
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x000E649F File Offset: 0x000E469F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsCharacterController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C");
		}
		return TsCharacterController._ClassPtr;
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x000E64C4 File Offset: 0x000E46C4
	public TsCharacterController() : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x000E64EC File Offset: 0x000E46EC
	[NullableContext(1)]
	public TsCharacterController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCharacterController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000E651F File Offset: 0x000E471F
	protected TsCharacterController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x000E6528 File Offset: 0x000E4728
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000E6530 File Offset: 0x000E4730
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x000E6538 File Offset: 0x000E4738
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePossess_Implementation(AController.__ReceivePossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->PossessedPawn);
		this.ReceivePossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x000E6558 File Offset: 0x000E4758
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveUnPossess_Implementation(AController.__ReceiveUnPossess_FunctionParams* __Params)
	{
		APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->UnpossessedPawn);
		this.ReceiveUnPossess_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x000E6578 File Offset: 0x000E4778
	protected override void __CPPCALL_OnSetupInputComponent_Implementation()
	{
		this.OnSetupInputComponent_Implementation();
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x000E6580 File Offset: 0x000E4780
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePreProcessInput_Implementation(ABasePlayerController.__ReceivePreProcessInput_FunctionParams* __Params)
	{
		this.ReceivePreProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000E6594 File Offset: 0x000E4794
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceivePostProcessInput_Implementation(ABasePlayerController.__ReceivePostProcessInput_FunctionParams* __Params)
	{
		this.ReceivePostProcessInput_Implementation(__Params->DeltaTime, __Params->bGamePaused);
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x000E65A8 File Offset: 0x000E47A8
	protected virtual void __CPPCALL_OnSetUiRootActive_Implementation()
	{
		this.OnSetUiRootActive_Implementation();
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000E65B0 File Offset: 0x000E47B0
	protected virtual void __CPPCALL_OnSetUiRootDeactivate_Implementation()
	{
		this.OnSetUiRootDeactivate_Implementation();
	}

	// Token: 0x04002473 RID: 9331
	private static readonly FName LEFT_BARACKET_NAME = new FName("LeftBracket");

	// Token: 0x04002474 RID: 9332
	private static readonly FName RIGHT_BARACKET_NAME = new FName("RightBracket");

	// Token: 0x04002475 RID: 9333
	private Vector2D CursorInputVector;

	// Token: 0x04002476 RID: 9334
	private Vector2D MoveInputVector;

	// Token: 0x04002477 RID: 9335
	private TsPureUiKeyHandle TsUiKeyHandle;

	// Token: 0x04002478 RID: 9336
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsCharacterController.TsCharacterController_C";

	// Token: 0x04002479 RID: 9337
	private static IntPtr _ClassPtr;

	// Token: 0x0400247A RID: 9338
	private static IntPtr _ClassDefaultObjectPtr;
}
