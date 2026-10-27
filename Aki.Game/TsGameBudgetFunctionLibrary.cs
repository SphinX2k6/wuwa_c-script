using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.World.Define;
using CSharpScript.Game.World.GameBudget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003518 RID: 13592
[UClass("/Game/Aki/TypeScript/Game/World/GameBudget/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C")]
public class TsGameBudgetFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601DCC7 RID: 122055 RVA: 0x00859F1C File Offset: 0x0085811C
	static TsGameBudgetFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsGameBudgetFunctionLibrary.CreateStaticDefaultValue), new Action(TsGameBudgetFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601DCC8 RID: 122056 RVA: 0x00859F3C File Offset: 0x0085813C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RegisterGameBudget(AActor actor, bool isCollisionPlant)
	{
		TsBlueprintGameBudgetObject tsBlueprintGameBudgetObject = new TsBlueprintGameBudgetObject(actor);
		if (!tsBlueprintGameBudgetObject.HasScheduledTickMethod())
		{
			return;
		}
		TsGameBudgetGroupConfigCache groupConfig;
		if (isCollisionPlant)
		{
			groupConfig = GameBudgetAllocatorConfigCreator.Instance.TsCollisionPlantConfig;
		}
		else
		{
			groupConfig = GameBudgetAllocatorConfigCreator.Instance.TsNormalEntityGroupConfig;
		}
		if (tsBlueprintGameBudgetObject.RegisterTick(groupConfig) != 0U)
		{
			TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap[actor] = tsBlueprintGameBudgetObject;
		}
	}

	// Token: 0x0601DCC9 RID: 122057 RVA: 0x00859F8C File Offset: 0x0085818C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UnregisterGameBudget(AActor actor)
	{
		TsBlueprintGameBudgetObject tsBlueprintGameBudgetObject;
		if (TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap.TryGetValue(actor, out tsBlueprintGameBudgetObject))
		{
			tsBlueprintGameBudgetObject.UnregisterTick();
			TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap.Remove(actor);
		}
	}

	// Token: 0x0601DCCA RID: 122058 RVA: 0x00859FBA File Offset: 0x008581BA
	public static void CreateStaticDefaultValue()
	{
		TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap = new Dictionary<AActor, TsBlueprintGameBudgetObject>();
	}

	// Token: 0x0601DCCB RID: 122059 RVA: 0x00859FC6 File Offset: 0x008581C6
	public static void ResetStaticDefaultValue()
	{
		TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap = null;
	}

	// Token: 0x0601DCCC RID: 122060 RVA: 0x00859FCE File Offset: 0x008581CE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsGameBudgetFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C");
		}
		return TsGameBudgetFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601DCCD RID: 122061 RVA: 0x00859FF4 File Offset: 0x008581F4
	public TsGameBudgetFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601DCCE RID: 122062 RVA: 0x0085A01C File Offset: 0x0085821C
	[NullableContext(1)]
	public TsGameBudgetFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DCCF RID: 122063 RVA: 0x0085A04F File Offset: 0x0085824F
	protected TsGameBudgetFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DCD0 RID: 122064 RVA: 0x0085A058 File Offset: 0x00858258
	protected unsafe static void __CPPCALL_RegisterGameBudget_Implementation(TsGameBudgetFunctionLibrary.__RegisterGameBudget_FunctionParams* __Params)
	{
		TsGameBudgetFunctionLibrary.RegisterGameBudget(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor), __Params->isCollisionPlant);
	}

	// Token: 0x0601DCD1 RID: 122065 RVA: 0x0085A070 File Offset: 0x00858270
	protected unsafe static void __CPPCALL_UnregisterGameBudget_Implementation(TsGameBudgetFunctionLibrary.__UnregisterGameBudget_FunctionParams* __Params)
	{
		TsGameBudgetFunctionLibrary.UnregisterGameBudget(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor));
	}

	// Token: 0x0400E9E8 RID: 59880
	[Nullable(1)]
	private static Dictionary<AActor, TsBlueprintGameBudgetObject> TsGameBudgetObjectMap;

	// Token: 0x0400E9E9 RID: 59881
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C";

	// Token: 0x0400E9EA RID: 59882
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9EB RID: 59883
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020099BA RID: 39354
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RegisterGameBudget_FunctionParams
	{
		// Token: 0x04030E11 RID: 200209
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04030E12 RID: 200210
		[FieldOffset(8)]
		public bool isCollisionPlant;

		// Token: 0x04030E13 RID: 200211
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020099BB RID: 39355
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UnregisterGameBudget_FunctionParams
	{
		// Token: 0x04030E14 RID: 200212
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x04030E15 RID: 200213
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
