using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000292 RID: 658
[UClass("/Game/Aki/TypeScript/Game/Input/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C")]
public class InputBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060028CB RID: 10443 RVA: 0x000FCF85 File Offset: 0x000FB185
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PreProcessInput(float deltaTime, bool gamePaused)
	{
		InputController.Instance.PreProcessInput(deltaTime, gamePaused);
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x000FCF93 File Offset: 0x000FB193
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PostProcessInput(float deltaTime, bool gamePaused)
	{
		InputController.Instance.PostProcessInput(deltaTime, gamePaused);
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x000FCFA1 File Offset: 0x000FB1A1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsKeyDown(int action)
	{
		return InputController.Instance.IsKeyDown((CSharpScript.Game.Input.EInputAction)((byte)action));
	}

	// Token: 0x060028CE RID: 10446 RVA: 0x000FCFB4 File Offset: 0x000FB1B4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetKeyDownTime(int action)
	{
		return InputController.Instance.GetKeyDownTime((CSharpScript.Game.Input.EInputAction)((byte)action));
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x000FCFC8 File Offset: 0x000FB1C8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetCommandInterval(ECommandType commandType, float defaultInterval = 1f)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		object obj;
		if (baseCharacter == null)
		{
			obj = null;
		}
		else
		{
			Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
			obj = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterInputComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return defaultInterval;
		}
		return obj2.GetCommandInterval(commandType);
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x000FCFF3 File Offset: 0x000FB1F3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetTimeDilation(float timeDilation)
	{
		GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Default);
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x000FD001 File Offset: 0x000FB201
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static string GetActionInputDistributeTag(string actionName)
	{
		return InputDistributeModel.Instance.GetActionInputDistributeTagName(actionName);
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x000FD00E File Offset: 0x000FB20E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static string GetAxisInputDistributeTag(string axisName)
	{
		return InputDistributeModel.Instance.GetAxisInputDistributeTagName(axisName);
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x000FD01C File Offset: 0x000FB21C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetAllInputDistributeTag()
	{
		TArray<string> tarray = new TArray<string>();
		foreach (ValueTuple<string, string> valueTuple in InputDistributeDefine.InitializeInputDistributeTagDefine)
		{
			tarray.Add(valueTuple.Item1);
		}
		return tarray;
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x000FD07C File Offset: 0x000FB27C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool HasMoveAxisInput()
	{
		if (Info.Instance.OperationType == EOperationType.Pad && BattleUiModel.Instance.IsPressJoyStick)
		{
			return true;
		}
		InputModel instance = InputModel.Instance;
		Dictionary<EInputAxis, float> dictionary = (instance != null) ? instance.GetAxisValues() : null;
		if (dictionary == null)
		{
			return false;
		}
		float num;
		bool flag = dictionary.TryGetValue(EInputAxis.MoveForward, out num);
		if (flag && num != 0f)
		{
			return true;
		}
		float num2;
		bool flag2 = dictionary.TryGetValue(EInputAxis.MoveRight, out num2);
		if (flag2 && num2 != 0f)
		{
			return true;
		}
		if ((flag && num == 0f) || (flag2 && num2 == 0f))
		{
			return false;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterInputComponent characterInputComponent;
		if (baseCharacter == null)
		{
			characterInputComponent = null;
		}
		else
		{
			Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
			characterInputComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterInputComponent>() : null);
		}
		CharacterInputComponent characterInputComponent2 = characterInputComponent;
		if (characterInputComponent2 == null)
		{
			return false;
		}
		float? num3 = characterInputComponent2.QueryInputAxis(EInputAxis.MoveForward);
		if (num3 != null && num3.GetValueOrDefault() != 0f)
		{
			return true;
		}
		float? num4 = characterInputComponent2.QueryInputAxis(EInputAxis.MoveRight);
		return num4 != null && num4.GetValueOrDefault() != 0f;
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x000FD180 File Offset: 0x000FB380
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float HasRightMoveAxisInput()
	{
		Dictionary<EInputAxis, float> axisValues = InputModel.Instance.GetAxisValues();
		float result;
		if (axisValues == null || !axisValues.TryGetValue(EInputAxis.MoveRight, out result))
		{
			return 0f;
		}
		return result;
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x000FD1B4 File Offset: 0x000FB3B4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CreateSkillCommand(int entityId, int skillId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		return InputFunctionCommon.CreateSkillCommand(entity, skillId);
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x000FD1E4 File Offset: 0x000FB3E4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CanResponseInput(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		return entity != null && entity.Valid && InputFunctionCommon.CanResponseInput(entity);
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x000FD210 File Offset: 0x000FB410
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterAttackOnPress(float time, SInputCommand parentCommand, BP_InputComponent_C bpInputComp)
	{
		return InputFunctionAttack.AttackOnPress(time, bpInputComp) ?? parentCommand;
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x000FD220 File Offset: 0x000FB420
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterAttackOnRelease(float time, SInputCommand parentCommand, BP_InputComponent_C bpInputComp)
	{
		SInputCommand sinputCommand = InputFunctionAttack.AttackOnRelease(time, bpInputComp);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x000FD244 File Offset: 0x000FB444
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterVisionSkill1OnPress(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill1.VisionSkill1OnPress(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x000FD264 File Offset: 0x000FB464
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterVisionSkill1OnRelease(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill1.VisionSkill1OnRelease(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x000FD284 File Offset: 0x000FB484
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterVisionSkill2OnPress(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill2.VisionSkill2OnPress(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x000FD2A4 File Offset: 0x000FB4A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterVisionSkill2OnRelease(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill2.VisionSkill2OnRelease(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand FishingBoatVisionSkill1OnPress(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionFishingBoat.FishingBoatVisionSkill1OnPress(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x000FD2E4 File Offset: 0x000FB4E4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand FishingBoatVisionSkill1OnRelease(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionFishingBoat.FishingBoatVisionSkill1OnRelease(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x000FD304 File Offset: 0x000FB504
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CreateFishingBoatSprintCommand(int skillId)
	{
		return InputFunctionFishingBoat.CreateFishingBoatSprintCommand(skillId);
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x000FD30C File Offset: 0x000FB50C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand MotorcycleVisionSkill1OnPress(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionMotorcycle.MotorcycleVisionSkill1OnPress(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x000FD32C File Offset: 0x000FB52C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand MotorcycleVisionSkill1OnRelease(float time, SInputCommand parentCommand)
	{
		SInputCommand sinputCommand = InputFunctionMotorcycle.MotorcycleVisionSkill1OnRelease(time);
		if (!(sinputCommand != null))
		{
			return parentCommand;
		}
		return sinputCommand;
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x000FD34C File Offset: 0x000FB54C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (InputBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C");
		}
		return InputBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x000FD370 File Offset: 0x000FB570
	public InputBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x000FD398 File Offset: 0x000FB598
	[NullableContext(1)]
	public InputBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060028E6 RID: 10470 RVA: 0x000FD3CB File Offset: 0x000FB5CB
	protected InputBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x000FD3D4 File Offset: 0x000FB5D4
	protected unsafe static void __CPPCALL_PreProcessInput_Implementation(InputBlueprintFunctionLibrary.__PreProcessInput_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.PreProcessInput(__Params->deltaTime, __Params->gamePaused);
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x000FD3E7 File Offset: 0x000FB5E7
	protected unsafe static void __CPPCALL_PostProcessInput_Implementation(InputBlueprintFunctionLibrary.__PostProcessInput_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.PostProcessInput(__Params->deltaTime, __Params->gamePaused);
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x000FD3FA File Offset: 0x000FB5FA
	protected unsafe static void __CPPCALL_IsKeyDown_Implementation(InputBlueprintFunctionLibrary.__IsKeyDown_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.IsKeyDown(__Params->action);
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x000FD40D File Offset: 0x000FB60D
	protected unsafe static void __CPPCALL_GetKeyDownTime_Implementation(InputBlueprintFunctionLibrary.__GetKeyDownTime_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.GetKeyDownTime(__Params->action);
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x000FD420 File Offset: 0x000FB620
	protected unsafe static void __CPPCALL_GetCommandInterval_Implementation(InputBlueprintFunctionLibrary.__GetCommandInterval_FunctionParams* __Params)
	{
		ECommandType commandType = (ECommandType)__Params->commandType;
		__Params->__Result = InputBlueprintFunctionLibrary.GetCommandInterval(commandType, __Params->defaultInterval);
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x000FD446 File Offset: 0x000FB646
	protected unsafe static void __CPPCALL_SetTimeDilation_Implementation(InputBlueprintFunctionLibrary.__SetTimeDilation_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.SetTimeDilation(__Params->timeDilation);
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x000FD454 File Offset: 0x000FB654
	protected unsafe static void __CPPCALL_GetActionInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetActionInputDistributeTag_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		FString.CopyFrom((void*)(&__Params->__Result), InputBlueprintFunctionLibrary.GetActionInputDistributeTag(actionName));
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x000FD480 File Offset: 0x000FB680
	protected unsafe static void __CPPCALL_GetAxisInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetAxisInputDistributeTag_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		FString.CopyFrom((void*)(&__Params->__Result), InputBlueprintFunctionLibrary.GetAxisInputDistributeTag(axisName));
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x000FD4AC File Offset: 0x000FB6AC
	protected unsafe static void __CPPCALL_GetAllInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetAllInputDistributeTag_FunctionParams* __Params)
	{
		TArray<string> allInputDistributeTag = InputBlueprintFunctionLibrary.GetAllInputDistributeTag();
		if (allInputDistributeTag == null)
		{
			return;
		}
		allInputDistributeTag.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x000FD4D8 File Offset: 0x000FB6D8
	protected unsafe static void __CPPCALL_HasMoveAxisInput_Implementation(InputBlueprintFunctionLibrary.__HasMoveAxisInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.HasMoveAxisInput();
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x000FD4E5 File Offset: 0x000FB6E5
	protected unsafe static void __CPPCALL_HasRightMoveAxisInput_Implementation(InputBlueprintFunctionLibrary.__HasRightMoveAxisInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.HasRightMoveAxisInput();
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x000FD4F2 File Offset: 0x000FB6F2
	protected unsafe static void __CPPCALL_CreateSkillCommand_Implementation(InputBlueprintFunctionLibrary.__CreateSkillCommand_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CreateSkillCommand(__Params->entityId, __Params->skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x000FD525 File Offset: 0x000FB725
	protected unsafe static void __CPPCALL_CanResponseInput_Implementation(InputBlueprintFunctionLibrary.__CanResponseInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.CanResponseInput(__Params->entityId);
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x000FD538 File Offset: 0x000FB738
	protected unsafe static void __CPPCALL_CharacterAttackOnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterAttackOnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		BP_InputComponent_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputComponent_C>(__Params->bpInputComp);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterAttackOnPress(__Params->time, parentCommand, orCreateUObjectByNativePointer);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x000FD590 File Offset: 0x000FB790
	protected unsafe static void __CPPCALL_CharacterAttackOnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterAttackOnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		BP_InputComponent_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputComponent_C>(__Params->bpInputComp);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterAttackOnRelease(__Params->time, parentCommand, orCreateUObjectByNativePointer);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x000FD5E8 File Offset: 0x000FB7E8
	protected unsafe static void __CPPCALL_CharacterVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F7 RID: 10487 RVA: 0x000FD630 File Offset: 0x000FB830
	protected unsafe static void __CPPCALL_CharacterVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F8 RID: 10488 RVA: 0x000FD678 File Offset: 0x000FB878
	protected unsafe static void __CPPCALL_CharacterVisionSkill2OnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill2OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill2OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028F9 RID: 10489 RVA: 0x000FD6C0 File Offset: 0x000FB8C0
	protected unsafe static void __CPPCALL_CharacterVisionSkill2OnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill2OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill2OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x000FD708 File Offset: 0x000FB908
	protected unsafe static void __CPPCALL_FishingBoatVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__FishingBoatVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.FishingBoatVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x000FD750 File Offset: 0x000FB950
	protected unsafe static void __CPPCALL_FishingBoatVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__FishingBoatVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.FishingBoatVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x000FD798 File Offset: 0x000FB998
	protected unsafe static void __CPPCALL_CreateFishingBoatSprintCommand_Implementation(InputBlueprintFunctionLibrary.__CreateFishingBoatSprintCommand_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CreateFishingBoatSprintCommand(__Params->skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x000FD7C8 File Offset: 0x000FB9C8
	protected unsafe static void __CPPCALL_MotorcycleVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__MotorcycleVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.MotorcycleVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x000FD810 File Offset: 0x000FBA10
	protected unsafe static void __CPPCALL_MotorcycleVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__MotorcycleVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.MotorcycleVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x04002746 RID: 10054
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C";

	// Token: 0x04002747 RID: 10055
	private static IntPtr _ClassPtr;

	// Token: 0x04002748 RID: 10056
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200660F RID: 26127
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PreProcessInput_FunctionParams
	{
		// Token: 0x04021D77 RID: 138615
		[FieldOffset(0)]
		public float deltaTime;

		// Token: 0x04021D78 RID: 138616
		[FieldOffset(4)]
		public bool gamePaused;

		// Token: 0x04021D79 RID: 138617
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006610 RID: 26128
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PostProcessInput_FunctionParams
	{
		// Token: 0x04021D7A RID: 138618
		[FieldOffset(0)]
		public float deltaTime;

		// Token: 0x04021D7B RID: 138619
		[FieldOffset(4)]
		public bool gamePaused;

		// Token: 0x04021D7C RID: 138620
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006611 RID: 26129
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsKeyDown_FunctionParams
	{
		// Token: 0x04021D7D RID: 138621
		[FieldOffset(0)]
		public int action;

		// Token: 0x04021D7E RID: 138622
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021D7F RID: 138623
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02006612 RID: 26130
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetKeyDownTime_FunctionParams
	{
		// Token: 0x04021D80 RID: 138624
		[FieldOffset(0)]
		public int action;

		// Token: 0x04021D81 RID: 138625
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021D82 RID: 138626
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02006613 RID: 26131
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCommandInterval_FunctionParams
	{
		// Token: 0x04021D83 RID: 138627
		[FieldOffset(0)]
		public byte commandType;

		// Token: 0x04021D84 RID: 138628
		[FieldOffset(4)]
		public float defaultInterval;

		// Token: 0x04021D85 RID: 138629
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021D86 RID: 138630
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02006614 RID: 26132
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTimeDilation_FunctionParams
	{
		// Token: 0x04021D87 RID: 138631
		[FieldOffset(0)]
		public float timeDilation;

		// Token: 0x04021D88 RID: 138632
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006615 RID: 26133
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetActionInputDistributeTag_FunctionParams
	{
		// Token: 0x04021D89 RID: 138633
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x04021D8A RID: 138634
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04021D8B RID: 138635
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02006616 RID: 26134
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetAxisInputDistributeTag_FunctionParams
	{
		// Token: 0x04021D8C RID: 138636
		[FieldOffset(0)]
		public FString axisName;

		// Token: 0x04021D8D RID: 138637
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04021D8E RID: 138638
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02006617 RID: 26135
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllInputDistributeTag_FunctionParams
	{
		// Token: 0x04021D8F RID: 138639
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021D90 RID: 138640
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02006618 RID: 26136
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HasMoveAxisInput_FunctionParams
	{
		// Token: 0x04021D91 RID: 138641
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021D92 RID: 138642
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02006619 RID: 26137
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HasRightMoveAxisInput_FunctionParams
	{
		// Token: 0x04021D93 RID: 138643
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021D94 RID: 138644
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200661A RID: 26138
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateSkillCommand_FunctionParams
	{
		// Token: 0x04021D95 RID: 138645
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04021D96 RID: 138646
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x04021D97 RID: 138647
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021D98 RID: 138648
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200661B RID: 26139
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanResponseInput_FunctionParams
	{
		// Token: 0x04021D99 RID: 138649
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04021D9A RID: 138650
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021D9B RID: 138651
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200661C RID: 26140
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CharacterAttackOnPress_FunctionParams
	{
		// Token: 0x04021D9C RID: 138652
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021D9D RID: 138653
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021D9E RID: 138654
		[FieldOffset(24)]
		public IntPtr bpInputComp;

		// Token: 0x04021D9F RID: 138655
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04021DA0 RID: 138656
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x0200661D RID: 26141
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CharacterAttackOnRelease_FunctionParams
	{
		// Token: 0x04021DA1 RID: 138657
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DA2 RID: 138658
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DA3 RID: 138659
		[FieldOffset(24)]
		public IntPtr bpInputComp;

		// Token: 0x04021DA4 RID: 138660
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04021DA5 RID: 138661
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x0200661E RID: 26142
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04021DA6 RID: 138662
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DA7 RID: 138663
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DA8 RID: 138664
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DA9 RID: 138665
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x0200661F RID: 26143
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04021DAA RID: 138666
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DAB RID: 138667
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DAC RID: 138668
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DAD RID: 138669
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006620 RID: 26144
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill2OnPress_FunctionParams
	{
		// Token: 0x04021DAE RID: 138670
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DAF RID: 138671
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DB0 RID: 138672
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DB1 RID: 138673
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006621 RID: 26145
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill2OnRelease_FunctionParams
	{
		// Token: 0x04021DB2 RID: 138674
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DB3 RID: 138675
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DB4 RID: 138676
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DB5 RID: 138677
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006622 RID: 26146
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FishingBoatVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04021DB6 RID: 138678
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DB7 RID: 138679
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DB8 RID: 138680
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DB9 RID: 138681
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006623 RID: 26147
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FishingBoatVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04021DBA RID: 138682
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DBB RID: 138683
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DBC RID: 138684
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DBD RID: 138685
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006624 RID: 26148
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateFishingBoatSprintCommand_FunctionParams
	{
		// Token: 0x04021DBE RID: 138686
		[FieldOffset(0)]
		public int skillId;

		// Token: 0x04021DBF RID: 138687
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021DC0 RID: 138688
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02006625 RID: 26149
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MotorcycleVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04021DC1 RID: 138689
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DC2 RID: 138690
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DC3 RID: 138691
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DC4 RID: 138692
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02006626 RID: 26150
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MotorcycleVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04021DC5 RID: 138693
		[FieldOffset(0)]
		public float time;

		// Token: 0x04021DC6 RID: 138694
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04021DC7 RID: 138695
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04021DC8 RID: 138696
		[FieldOffset(32)]
		public byte __Result;
	}
}
