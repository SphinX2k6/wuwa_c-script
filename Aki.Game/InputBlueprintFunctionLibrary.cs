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

// Token: 0x02000DE0 RID: 3552
[UClass("/Game/Aki/TypeScript/Game/Input/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C")]
public class InputBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005541 RID: 21825 RVA: 0x000F5A8D File Offset: 0x000F3C8D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PreProcessInput(float deltaTime, bool gamePaused)
	{
		InputController.Instance.PreProcessInput(deltaTime, gamePaused);
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x000F5A9B File Offset: 0x000F3C9B
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PostProcessInput(float deltaTime, bool gamePaused)
	{
		InputController.Instance.PostProcessInput(deltaTime, gamePaused);
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x000F5AA9 File Offset: 0x000F3CA9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsKeyDown(int action)
	{
		return InputController.Instance.IsKeyDown((CSharpScript.Game.Input.EInputAction)((byte)action));
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x000F5ABC File Offset: 0x000F3CBC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetKeyDownTime(int action)
	{
		return InputController.Instance.GetKeyDownTime((CSharpScript.Game.Input.EInputAction)((byte)action));
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x000F5AD0 File Offset: 0x000F3CD0
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

	// Token: 0x06005546 RID: 21830 RVA: 0x000F5AFB File Offset: 0x000F3CFB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetTimeDilation(float timeDilation)
	{
		GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.Default);
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x000F5B09 File Offset: 0x000F3D09
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static string GetActionInputDistributeTag(string actionName)
	{
		return InputDistributeModel.Instance.GetActionInputDistributeTagName(actionName);
	}

	// Token: 0x06005548 RID: 21832 RVA: 0x000F5B16 File Offset: 0x000F3D16
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static string GetAxisInputDistributeTag(string axisName)
	{
		return InputDistributeModel.Instance.GetAxisInputDistributeTagName(axisName);
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x000F5B24 File Offset: 0x000F3D24
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

	// Token: 0x0600554A RID: 21834 RVA: 0x000F5B84 File Offset: 0x000F3D84
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

	// Token: 0x0600554B RID: 21835 RVA: 0x000F5C88 File Offset: 0x000F3E88
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

	// Token: 0x0600554C RID: 21836 RVA: 0x000F5CBC File Offset: 0x000F3EBC
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

	// Token: 0x0600554D RID: 21837 RVA: 0x000F5CEC File Offset: 0x000F3EEC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CanResponseInput(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		return entity != null && entity.Valid && InputFunctionCommon.CanResponseInput(entity);
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x000F5D18 File Offset: 0x000F3F18
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CharacterAttackOnPress(float time, SInputCommand parentCommand, BP_InputComponent_C bpInputComp)
	{
		return InputFunctionAttack.AttackOnPress(time, bpInputComp) ?? parentCommand;
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x000F5D28 File Offset: 0x000F3F28
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

	// Token: 0x06005550 RID: 21840 RVA: 0x000F5D4C File Offset: 0x000F3F4C
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

	// Token: 0x06005551 RID: 21841 RVA: 0x000F5D6C File Offset: 0x000F3F6C
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

	// Token: 0x06005552 RID: 21842 RVA: 0x000F5D8C File Offset: 0x000F3F8C
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

	// Token: 0x06005553 RID: 21843 RVA: 0x000F5DAC File Offset: 0x000F3FAC
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

	// Token: 0x06005554 RID: 21844 RVA: 0x000F5DCC File Offset: 0x000F3FCC
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

	// Token: 0x06005555 RID: 21845 RVA: 0x000F5DEC File Offset: 0x000F3FEC
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

	// Token: 0x06005556 RID: 21846 RVA: 0x000F5E0C File Offset: 0x000F400C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SInputCommand CreateFishingBoatSprintCommand(int skillId)
	{
		return InputFunctionFishingBoat.CreateFishingBoatSprintCommand(skillId);
	}

	// Token: 0x06005557 RID: 21847 RVA: 0x000F5E14 File Offset: 0x000F4014
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

	// Token: 0x06005558 RID: 21848 RVA: 0x000F5E34 File Offset: 0x000F4034
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

	// Token: 0x06005559 RID: 21849 RVA: 0x000F5E54 File Offset: 0x000F4054
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (InputBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C");
		}
		return InputBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x000F5E78 File Offset: 0x000F4078
	public InputBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600555B RID: 21851 RVA: 0x000F5EA0 File Offset: 0x000F40A0
	[NullableContext(1)]
	public InputBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(InputBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600555C RID: 21852 RVA: 0x000F5ED3 File Offset: 0x000F40D3
	protected InputBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600555D RID: 21853 RVA: 0x000F5EDC File Offset: 0x000F40DC
	protected unsafe static void __CPPCALL_PreProcessInput_Implementation(InputBlueprintFunctionLibrary.__PreProcessInput_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.PreProcessInput(__Params->deltaTime, __Params->gamePaused);
	}

	// Token: 0x0600555E RID: 21854 RVA: 0x000F5EEF File Offset: 0x000F40EF
	protected unsafe static void __CPPCALL_PostProcessInput_Implementation(InputBlueprintFunctionLibrary.__PostProcessInput_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.PostProcessInput(__Params->deltaTime, __Params->gamePaused);
	}

	// Token: 0x0600555F RID: 21855 RVA: 0x000F5F02 File Offset: 0x000F4102
	protected unsafe static void __CPPCALL_IsKeyDown_Implementation(InputBlueprintFunctionLibrary.__IsKeyDown_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.IsKeyDown(__Params->action);
	}

	// Token: 0x06005560 RID: 21856 RVA: 0x000F5F15 File Offset: 0x000F4115
	protected unsafe static void __CPPCALL_GetKeyDownTime_Implementation(InputBlueprintFunctionLibrary.__GetKeyDownTime_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.GetKeyDownTime(__Params->action);
	}

	// Token: 0x06005561 RID: 21857 RVA: 0x000F5F28 File Offset: 0x000F4128
	protected unsafe static void __CPPCALL_GetCommandInterval_Implementation(InputBlueprintFunctionLibrary.__GetCommandInterval_FunctionParams* __Params)
	{
		ECommandType commandType = (ECommandType)__Params->commandType;
		__Params->__Result = InputBlueprintFunctionLibrary.GetCommandInterval(commandType, __Params->defaultInterval);
	}

	// Token: 0x06005562 RID: 21858 RVA: 0x000F5F4E File Offset: 0x000F414E
	protected unsafe static void __CPPCALL_SetTimeDilation_Implementation(InputBlueprintFunctionLibrary.__SetTimeDilation_FunctionParams* __Params)
	{
		InputBlueprintFunctionLibrary.SetTimeDilation(__Params->timeDilation);
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x000F5F5C File Offset: 0x000F415C
	protected unsafe static void __CPPCALL_GetActionInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetActionInputDistributeTag_FunctionParams* __Params)
	{
		string actionName = FString.ToString((void*)(&__Params->actionName));
		FString.CopyFrom((void*)(&__Params->__Result), InputBlueprintFunctionLibrary.GetActionInputDistributeTag(actionName));
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x000F5F88 File Offset: 0x000F4188
	protected unsafe static void __CPPCALL_GetAxisInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetAxisInputDistributeTag_FunctionParams* __Params)
	{
		string axisName = FString.ToString((void*)(&__Params->axisName));
		FString.CopyFrom((void*)(&__Params->__Result), InputBlueprintFunctionLibrary.GetAxisInputDistributeTag(axisName));
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x000F5FB4 File Offset: 0x000F41B4
	protected unsafe static void __CPPCALL_GetAllInputDistributeTag_Implementation(InputBlueprintFunctionLibrary.__GetAllInputDistributeTag_FunctionParams* __Params)
	{
		TArray<string> allInputDistributeTag = InputBlueprintFunctionLibrary.GetAllInputDistributeTag();
		if (allInputDistributeTag == null)
		{
			return;
		}
		allInputDistributeTag.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06005566 RID: 21862 RVA: 0x000F5FE0 File Offset: 0x000F41E0
	protected unsafe static void __CPPCALL_HasMoveAxisInput_Implementation(InputBlueprintFunctionLibrary.__HasMoveAxisInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.HasMoveAxisInput();
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x000F5FED File Offset: 0x000F41ED
	protected unsafe static void __CPPCALL_HasRightMoveAxisInput_Implementation(InputBlueprintFunctionLibrary.__HasRightMoveAxisInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.HasRightMoveAxisInput();
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x000F5FFA File Offset: 0x000F41FA
	protected unsafe static void __CPPCALL_CreateSkillCommand_Implementation(InputBlueprintFunctionLibrary.__CreateSkillCommand_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CreateSkillCommand(__Params->entityId, __Params->skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005569 RID: 21865 RVA: 0x000F602D File Offset: 0x000F422D
	protected unsafe static void __CPPCALL_CanResponseInput_Implementation(InputBlueprintFunctionLibrary.__CanResponseInput_FunctionParams* __Params)
	{
		__Params->__Result = InputBlueprintFunctionLibrary.CanResponseInput(__Params->entityId);
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x000F6040 File Offset: 0x000F4240
	protected unsafe static void __CPPCALL_CharacterAttackOnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterAttackOnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		BP_InputComponent_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputComponent_C>(__Params->bpInputComp);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterAttackOnPress(__Params->time, parentCommand, orCreateUObjectByNativePointer);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0600556B RID: 21867 RVA: 0x000F6098 File Offset: 0x000F4298
	protected unsafe static void __CPPCALL_CharacterAttackOnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterAttackOnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		BP_InputComponent_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputComponent_C>(__Params->bpInputComp);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterAttackOnRelease(__Params->time, parentCommand, orCreateUObjectByNativePointer);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0600556C RID: 21868 RVA: 0x000F60F0 File Offset: 0x000F42F0
	protected unsafe static void __CPPCALL_CharacterVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0600556D RID: 21869 RVA: 0x000F6138 File Offset: 0x000F4338
	protected unsafe static void __CPPCALL_CharacterVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x000F6180 File Offset: 0x000F4380
	protected unsafe static void __CPPCALL_CharacterVisionSkill2OnPress_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill2OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill2OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x000F61C8 File Offset: 0x000F43C8
	protected unsafe static void __CPPCALL_CharacterVisionSkill2OnRelease_Implementation(InputBlueprintFunctionLibrary.__CharacterVisionSkill2OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CharacterVisionSkill2OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x000F6210 File Offset: 0x000F4410
	protected unsafe static void __CPPCALL_FishingBoatVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__FishingBoatVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.FishingBoatVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x000F6258 File Offset: 0x000F4458
	protected unsafe static void __CPPCALL_FishingBoatVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__FishingBoatVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.FishingBoatVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x000F62A0 File Offset: 0x000F44A0
	protected unsafe static void __CPPCALL_CreateFishingBoatSprintCommand_Implementation(InputBlueprintFunctionLibrary.__CreateFishingBoatSprintCommand_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.CreateFishingBoatSprintCommand(__Params->skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x000F62D0 File Offset: 0x000F44D0
	protected unsafe static void __CPPCALL_MotorcycleVisionSkill1OnPress_Implementation(InputBlueprintFunctionLibrary.__MotorcycleVisionSkill1OnPress_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.MotorcycleVisionSkill1OnPress(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x000F6318 File Offset: 0x000F4518
	protected unsafe static void __CPPCALL_MotorcycleVisionSkill1OnRelease_Implementation(InputBlueprintFunctionLibrary.__MotorcycleVisionSkill1OnRelease_FunctionParams* __Params)
	{
		SInputCommand parentCommand = new SInputCommand(&__Params->parentCommand, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = SInputCommand.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SInputCommand sinputCommand = InputBlueprintFunctionLibrary.MotorcycleVisionSkill1OnRelease(__Params->time, parentCommand);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (sinputCommand != null) ? sinputCommand.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x040026BE RID: 9918
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Input/InputBlueprintFunctionLibrary.InputBlueprintFunctionLibrary_C";

	// Token: 0x040026BF RID: 9919
	private static IntPtr _ClassPtr;

	// Token: 0x040026C0 RID: 9920
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200747F RID: 29823
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PreProcessInput_FunctionParams
	{
		// Token: 0x04026A38 RID: 158264
		[FieldOffset(0)]
		public float deltaTime;

		// Token: 0x04026A39 RID: 158265
		[FieldOffset(4)]
		public bool gamePaused;

		// Token: 0x04026A3A RID: 158266
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007480 RID: 29824
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PostProcessInput_FunctionParams
	{
		// Token: 0x04026A3B RID: 158267
		[FieldOffset(0)]
		public float deltaTime;

		// Token: 0x04026A3C RID: 158268
		[FieldOffset(4)]
		public bool gamePaused;

		// Token: 0x04026A3D RID: 158269
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007481 RID: 29825
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsKeyDown_FunctionParams
	{
		// Token: 0x04026A3E RID: 158270
		[FieldOffset(0)]
		public int action;

		// Token: 0x04026A3F RID: 158271
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A40 RID: 158272
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02007482 RID: 29826
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetKeyDownTime_FunctionParams
	{
		// Token: 0x04026A41 RID: 158273
		[FieldOffset(0)]
		public int action;

		// Token: 0x04026A42 RID: 158274
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A43 RID: 158275
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02007483 RID: 29827
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCommandInterval_FunctionParams
	{
		// Token: 0x04026A44 RID: 158276
		[FieldOffset(0)]
		public byte commandType;

		// Token: 0x04026A45 RID: 158277
		[FieldOffset(4)]
		public float defaultInterval;

		// Token: 0x04026A46 RID: 158278
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A47 RID: 158279
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02007484 RID: 29828
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetTimeDilation_FunctionParams
	{
		// Token: 0x04026A48 RID: 158280
		[FieldOffset(0)]
		public float timeDilation;

		// Token: 0x04026A49 RID: 158281
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007485 RID: 29829
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetActionInputDistributeTag_FunctionParams
	{
		// Token: 0x04026A4A RID: 158282
		[FieldOffset(0)]
		public FString actionName;

		// Token: 0x04026A4B RID: 158283
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04026A4C RID: 158284
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02007486 RID: 29830
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetAxisInputDistributeTag_FunctionParams
	{
		// Token: 0x04026A4D RID: 158285
		[FieldOffset(0)]
		public FString axisName;

		// Token: 0x04026A4E RID: 158286
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04026A4F RID: 158287
		[FieldOffset(24)]
		public FString __Result;
	}

	// Token: 0x02007487 RID: 29831
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllInputDistributeTag_FunctionParams
	{
		// Token: 0x04026A50 RID: 158288
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026A51 RID: 158289
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02007488 RID: 29832
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HasMoveAxisInput_FunctionParams
	{
		// Token: 0x04026A52 RID: 158290
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026A53 RID: 158291
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02007489 RID: 29833
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HasRightMoveAxisInput_FunctionParams
	{
		// Token: 0x04026A54 RID: 158292
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026A55 RID: 158293
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200748A RID: 29834
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateSkillCommand_FunctionParams
	{
		// Token: 0x04026A56 RID: 158294
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04026A57 RID: 158295
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x04026A58 RID: 158296
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A59 RID: 158297
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200748B RID: 29835
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanResponseInput_FunctionParams
	{
		// Token: 0x04026A5A RID: 158298
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04026A5B RID: 158299
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A5C RID: 158300
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200748C RID: 29836
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CharacterAttackOnPress_FunctionParams
	{
		// Token: 0x04026A5D RID: 158301
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A5E RID: 158302
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A5F RID: 158303
		[FieldOffset(24)]
		public IntPtr bpInputComp;

		// Token: 0x04026A60 RID: 158304
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04026A61 RID: 158305
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x0200748D RID: 29837
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CharacterAttackOnRelease_FunctionParams
	{
		// Token: 0x04026A62 RID: 158306
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A63 RID: 158307
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A64 RID: 158308
		[FieldOffset(24)]
		public IntPtr bpInputComp;

		// Token: 0x04026A65 RID: 158309
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04026A66 RID: 158310
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x0200748E RID: 29838
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04026A67 RID: 158311
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A68 RID: 158312
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A69 RID: 158313
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A6A RID: 158314
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x0200748F RID: 29839
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04026A6B RID: 158315
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A6C RID: 158316
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A6D RID: 158317
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A6E RID: 158318
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007490 RID: 29840
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill2OnPress_FunctionParams
	{
		// Token: 0x04026A6F RID: 158319
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A70 RID: 158320
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A71 RID: 158321
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A72 RID: 158322
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007491 RID: 29841
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __CharacterVisionSkill2OnRelease_FunctionParams
	{
		// Token: 0x04026A73 RID: 158323
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A74 RID: 158324
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A75 RID: 158325
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A76 RID: 158326
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007492 RID: 29842
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FishingBoatVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04026A77 RID: 158327
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A78 RID: 158328
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A79 RID: 158329
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A7A RID: 158330
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007493 RID: 29843
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FishingBoatVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04026A7B RID: 158331
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A7C RID: 158332
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A7D RID: 158333
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A7E RID: 158334
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007494 RID: 29844
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateFishingBoatSprintCommand_FunctionParams
	{
		// Token: 0x04026A7F RID: 158335
		[FieldOffset(0)]
		public int skillId;

		// Token: 0x04026A80 RID: 158336
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026A81 RID: 158337
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02007495 RID: 29845
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MotorcycleVisionSkill1OnPress_FunctionParams
	{
		// Token: 0x04026A82 RID: 158338
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A83 RID: 158339
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A84 RID: 158340
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A85 RID: 158341
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02007496 RID: 29846
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __MotorcycleVisionSkill1OnRelease_FunctionParams
	{
		// Token: 0x04026A86 RID: 158342
		[FieldOffset(0)]
		public float time;

		// Token: 0x04026A87 RID: 158343
		[FieldOffset(4)]
		public byte parentCommand;

		// Token: 0x04026A88 RID: 158344
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x04026A89 RID: 158345
		[FieldOffset(32)]
		public byte __Result;
	}
}
