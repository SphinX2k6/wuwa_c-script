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

// Token: 0x02000397 RID: 919
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C")]
public class LevelGeneralBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060032C3 RID: 12995 RVA: 0x00124B75 File Offset: 0x00122D75
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UpdateEntityTag(int inEntityId, string inTag, bool isAdd)
	{
		LevelGeneralCommons.UpdateEntityTag(inEntityId, inTag, isAdd);
	}

	// Token: 0x060032C4 RID: 12996 RVA: 0x00124B7F File Offset: 0x00122D7F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool HandleConditionInteractOption(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		return false;
	}

	// Token: 0x060032C5 RID: 12997 RVA: 0x00124B82 File Offset: 0x00122D82
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TriggerLevelGeneralEvents(float inEventGroupId, AActor inTrigger)
	{
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x00124B84 File Offset: 0x00122D84
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HandleConditionalEventListen(TMap<int, int> inTargetMap)
	{
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x00124B86 File Offset: 0x00122D86
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HandleConditionPush(int inConditionGroupId)
	{
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x00124B88 File Offset: 0x00122D88
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenInteractHints()
	{
		TsInteractionUtils.OpenInteractHintView();
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x00124B90 File Offset: 0x00122D90
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseInteractHints()
	{
		TsInteractionUtils.CloseInteractHintView("Unknown");
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x00124B9C File Offset: 0x00122D9C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGeneralBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C");
		}
		return LevelGeneralBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060032CB RID: 13003 RVA: 0x00124BC0 File Offset: 0x00122DC0
	public LevelGeneralBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x00124BE8 File Offset: 0x00122DE8
	[NullableContext(1)]
	public LevelGeneralBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060032CD RID: 13005 RVA: 0x00124C1B File Offset: 0x00122E1B
	protected LevelGeneralBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x00124C24 File Offset: 0x00122E24
	protected unsafe static void __CPPCALL_UpdateEntityTag_Implementation(LevelGeneralBlueprintFunctionLibrary.__UpdateEntityTag_FunctionParams* __Params)
	{
		string inTag = FString.ToString((void*)(&__Params->inTag));
		LevelGeneralBlueprintFunctionLibrary.UpdateEntityTag(__Params->inEntityId, inTag, __Params->isAdd);
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x00124C50 File Offset: 0x00122E50
	protected unsafe static void __CPPCALL_HandleConditionInteractOption_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = LevelGeneralBlueprintFunctionLibrary.HandleConditionInteractOption(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x00124C9C File Offset: 0x00122E9C
	protected unsafe static void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBlueprintFunctionLibrary.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		LevelGeneralBlueprintFunctionLibrary.TriggerLevelGeneralEvents(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x060032D1 RID: 13009 RVA: 0x00124CC1 File Offset: 0x00122EC1
	protected unsafe static void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.HandleConditionalEventListen(new TMap<int, int>(&__Params->inTargetMap, true, true));
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x00124CD6 File Offset: 0x00122ED6
	protected unsafe static void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBlueprintFunctionLibrary.__HandleConditionPush_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.HandleConditionPush(__Params->inConditionGroupId);
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x00124CE3 File Offset: 0x00122EE3
	protected unsafe static void __CPPCALL_OpenInteractHints_Implementation(LevelGeneralBlueprintFunctionLibrary.__OpenInteractHints_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.OpenInteractHints();
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x00124CEA File Offset: 0x00122EEA
	protected unsafe static void __CPPCALL_CloseInteractHints_Implementation(LevelGeneralBlueprintFunctionLibrary.__CloseInteractHints_FunctionParams* __Params)
	{
		LevelGeneralBlueprintFunctionLibrary.CloseInteractHints();
	}

	// Token: 0x04002BCF RID: 11215
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBlueprintFunctionLibrary.LevelGeneralBlueprintFunctionLibrary_C";

	// Token: 0x04002BD0 RID: 11216
	private static IntPtr _ClassPtr;

	// Token: 0x04002BD1 RID: 11217
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020066CD RID: 26317
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __UpdateEntityTag_FunctionParams
	{
		// Token: 0x04021FA9 RID: 139177
		[FieldOffset(0)]
		public int inEntityId;

		// Token: 0x04021FAA RID: 139178
		[FieldOffset(8)]
		public FString inTag;

		// Token: 0x04021FAB RID: 139179
		[FieldOffset(24)]
		public bool isAdd;

		// Token: 0x04021FAC RID: 139180
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066CE RID: 26318
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 296)]
	protected ref struct __HandleConditionInteractOption_FunctionParams
	{
		// Token: 0x04021FAD RID: 139181
		[FieldOffset(0)]
		public byte inInteractOptionConfig;

		// Token: 0x04021FAE RID: 139182
		[FieldOffset(248)]
		public FString inInteractionConfigId;

		// Token: 0x04021FAF RID: 139183
		[FieldOffset(264)]
		public float inOptionIndex;

		// Token: 0x04021FB0 RID: 139184
		[FieldOffset(272)]
		public IntPtr inTrigger;

		// Token: 0x04021FB1 RID: 139185
		[FieldOffset(280)]
		public IntPtr __WorldContext;

		// Token: 0x04021FB2 RID: 139186
		[FieldOffset(288)]
		public bool __Result;
	}

	// Token: 0x020066CF RID: 26319
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TriggerLevelGeneralEvents_FunctionParams
	{
		// Token: 0x04021FB3 RID: 139187
		[FieldOffset(0)]
		public float inEventGroupId;

		// Token: 0x04021FB4 RID: 139188
		[FieldOffset(8)]
		public IntPtr inTrigger;

		// Token: 0x04021FB5 RID: 139189
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066D0 RID: 26320
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __HandleConditionalEventListen_FunctionParams
	{
		// Token: 0x04021FB6 RID: 139190
		[FieldOffset(0)]
		public byte inTargetMap;

		// Token: 0x04021FB7 RID: 139191
		[FieldOffset(80)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066D1 RID: 26321
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __HandleConditionPush_FunctionParams
	{
		// Token: 0x04021FB8 RID: 139192
		[FieldOffset(0)]
		public int inConditionGroupId;

		// Token: 0x04021FB9 RID: 139193
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066D2 RID: 26322
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __OpenInteractHints_FunctionParams
	{
		// Token: 0x04021FBA RID: 139194
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020066D3 RID: 26323
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseInteractHints_FunctionParams
	{
		// Token: 0x04021FBB RID: 139195
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
