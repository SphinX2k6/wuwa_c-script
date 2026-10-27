using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000EE2 RID: 3810
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C")]
public class LevelGeneralBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005F2D RID: 24365 RVA: 0x0011CE25 File Offset: 0x0011B025
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UpdateEntityTag(int inEntityId, string inTag, bool isAdd)
	{
		LevelGeneralCommons.UpdateEntityTag(inEntityId, inTag, isAdd);
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x0011CE2F File Offset: 0x0011B02F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool HandleConditionInteractOption(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		return false;
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x0011CE32 File Offset: 0x0011B032
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerLevelGeneralEvents(float inEventGroupId, AActor inTrigger)
	{
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x0011CE34 File Offset: 0x0011B034
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HandleConditionalEventListen(TMap<int, int> inTargetMap)
	{
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x0011CE36 File Offset: 0x0011B036
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HandleConditionPush(int inConditionGroupId)
	{
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x0011CE38 File Offset: 0x0011B038
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenInteractHints()
	{
		TsInteractionUtils.OpenInteractHintView();
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x0011CE40 File Offset: 0x0011B040
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseInteractHints()
	{
		TsInteractionUtils.CloseInteractHintView("Unknown");
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x0011CE4C File Offset: 0x0011B04C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGeneralBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C");
		}
		return LevelGeneralBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x0011CE70 File Offset: 0x0011B070
	public LevelGeneralBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x0011CE98 File Offset: 0x0011B098
	[NullableContext(1)]
	public LevelGeneralBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x0011CECB File Offset: 0x0011B0CB
	protected LevelGeneralBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x0011CED4 File Offset: 0x0011B0D4
	protected unsafe static void __CPPCALL_UpdateEntityTag_Implementation(LevelGeneralBlueprintFunctionLibrary.__UpdateEntityTag_FunctionParams* __Params)
	{
		string inTag = FString.ToString((void*)(&__Params->inTag));
		LevelGeneralBlueprintFunctionLibrary.UpdateEntityTag(__Params->inEntityId, inTag, __Params->isAdd);
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x0011CF00 File Offset: 0x0011B100
	protected unsafe static void __CPPCALL_HandleConditionInteractOption_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = LevelGeneralBlueprintFunctionLibrary.HandleConditionInteractOption(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x0011CF4C File Offset: 0x0011B14C
	protected unsafe static void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBlueprintFunctionLibrary.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		LevelGeneralBlueprintFunctionLibrary.TriggerLevelGeneralEvents(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x0011CF71 File Offset: 0x0011B171
	protected unsafe static void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.HandleConditionalEventListen(new TMap<int, int>(&__Params->inTargetMap, true, true));
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x0011CF86 File Offset: 0x0011B186
	protected unsafe static void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionPush_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.HandleConditionPush(__Params->inConditionGroupId);
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x0011CF93 File Offset: 0x0011B193
	protected unsafe static void __CPPCALL_OpenInteractHints_Implementation(LevelGeneralBlueprintFunctionLibrary.__OpenInteractHints_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.OpenInteractHints();
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x0011CF9A File Offset: 0x0011B19A
	protected unsafe static void __CPPCALL_CloseInteractHints_Implementation(LevelGeneralBlueprintFunctionLibrary.__CloseInteractHints_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.CloseInteractHints();
	}

	// Token: 0x04002B35 RID: 11061
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C";

	// Token: 0x04002B36 RID: 11062
	private static IntPtr _ClassPtr;

	// Token: 0x04002B37 RID: 11063
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007539 RID: 30009
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __UpdateEntityTag_FunctionParams
	{
		// Token: 0x04026C5E RID: 158814
		[FieldOffset(0)]
		public int inEntityId;

		// Token: 0x04026C5F RID: 158815
		[FieldOffset(8)]
		public FString inTag;

		// Token: 0x04026C60 RID: 158816
		[FieldOffset(24)]
		public bool isAdd;

		// Token: 0x04026C61 RID: 158817
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200753A RID: 30010
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 296)]
	protected ref struct __HandleConditionInteractOption_FunctionParams
	{
		// Token: 0x04026C62 RID: 158818
		[FieldOffset(0)]
		public byte inInteractOptionConfig;

		// Token: 0x04026C63 RID: 158819
		[FieldOffset(248)]
		public FString inInteractionConfigId;

		// Token: 0x04026C64 RID: 158820
		[FieldOffset(264)]
		public float inOptionIndex;

		// Token: 0x04026C65 RID: 158821
		[FieldOffset(272)]
		public IntPtr inTrigger;

		// Token: 0x04026C66 RID: 158822
		[FieldOffset(280)]
		public IntPtr __WorldContext;

		// Token: 0x04026C67 RID: 158823
		[FieldOffset(288)]
		public bool __Result;
	}

	// Token: 0x0200753B RID: 30011
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TriggerLevelGeneralEvents_FunctionParams
	{
		// Token: 0x04026C68 RID: 158824
		[FieldOffset(0)]
		public float inEventGroupId;

		// Token: 0x04026C69 RID: 158825
		[FieldOffset(8)]
		public IntPtr inTrigger;

		// Token: 0x04026C6A RID: 158826
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200753C RID: 30012
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __HandleConditionalEventListen_FunctionParams
	{
		// Token: 0x04026C6B RID: 158827
		[FieldOffset(0)]
		public byte inTargetMap;

		// Token: 0x04026C6C RID: 158828
		[FieldOffset(80)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200753D RID: 30013
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HandleConditionPush_FunctionParams
	{
		// Token: 0x04026C6D RID: 158829
		[FieldOffset(0)]
		public int inConditionGroupId;

		// Token: 0x04026C6E RID: 158830
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200753E RID: 30014
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OpenInteractHints_FunctionParams
	{
		// Token: 0x04026C6F RID: 158831
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200753F RID: 30015
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseInteractHints_FunctionParams
	{
		// Token: 0x04026C70 RID: 158832
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
