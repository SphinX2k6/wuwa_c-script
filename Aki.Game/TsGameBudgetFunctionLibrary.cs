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

// Token: 0x02002A8D RID: 10893
[UClass("/Game/Aki/TypeScript/Game/World/GameBudget/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C")]
public class TsGameBudgetFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B9E1 RID: 113121 RVA: 0x008824C4 File Offset: 0x008806C4
	static TsGameBudgetFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsGameBudgetFunctionLibrary.CreateStaticDefaultValue), new Action(TsGameBudgetFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601B9E2 RID: 113122 RVA: 0x008824E4 File Offset: 0x008806E4
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

	// Token: 0x0601B9E3 RID: 113123 RVA: 0x00882534 File Offset: 0x00880734
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

	// Token: 0x0601B9E4 RID: 113124 RVA: 0x00882562 File Offset: 0x00880762
	public static void CreateStaticDefaultValue()
	{
		TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap = new Dictionary<AActor, TsBlueprintGameBudgetObject>();
	}

	// Token: 0x0601B9E5 RID: 113125 RVA: 0x0088256E File Offset: 0x0088076E
	public static void ResetStaticDefaultValue()
	{
		TsGameBudgetFunctionLibrary.TsGameBudgetObjectMap = null;
	}

	// Token: 0x0601B9E6 RID: 113126 RVA: 0x00882576 File Offset: 0x00880776
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsGameBudgetFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C");
		}
		return TsGameBudgetFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601B9E7 RID: 113127 RVA: 0x0088259C File Offset: 0x0088079C
	public TsGameBudgetFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B9E8 RID: 113128 RVA: 0x008825C4 File Offset: 0x008807C4
	[NullableContext(1)]
	public TsGameBudgetFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameBudgetFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B9E9 RID: 113129 RVA: 0x008825F7 File Offset: 0x008807F7
	protected TsGameBudgetFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B9EA RID: 113130 RVA: 0x00882600 File Offset: 0x00880800
	protected unsafe static void __CPPCALL_RegisterGameBudget_Implementation(TsGameBudgetFunctionLibrary.__RegisterGameBudget_FunctionParams* __Params)
	{
		TsGameBudgetFunctionLibrary.RegisterGameBudget(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor), __Params->isCollisionPlant);
	}

	// Token: 0x0601B9EB RID: 113131 RVA: 0x00882618 File Offset: 0x00880818
	protected unsafe static void __CPPCALL_UnregisterGameBudget_Implementation(TsGameBudgetFunctionLibrary.__UnregisterGameBudget_FunctionParams* __Params)
	{
		TsGameBudgetFunctionLibrary.UnregisterGameBudget(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor));
	}

	// Token: 0x0400EEA3 RID: 61091
	[Nullable(1)]
	private static Dictionary<AActor, TsBlueprintGameBudgetObject> TsGameBudgetObjectMap;

	// Token: 0x0400EEA4 RID: 61092
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/World/GameBudget/TsGameBudgetFunctionLibrary.TsGameBudgetFunctionLibrary_C";

	// Token: 0x0400EEA5 RID: 61093
	private static IntPtr _ClassPtr;

	// Token: 0x0400EEA6 RID: 61094
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008BD4 RID: 35796
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RegisterGameBudget_FunctionParams
	{
		// Token: 0x0402C494 RID: 181396
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402C495 RID: 181397
		[FieldOffset(8)]
		public bool isCollisionPlant;

		// Token: 0x0402C496 RID: 181398
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008BD5 RID: 35797
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __UnregisterGameBudget_FunctionParams
	{
		// Token: 0x0402C497 RID: 181399
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x0402C498 RID: 181400
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
