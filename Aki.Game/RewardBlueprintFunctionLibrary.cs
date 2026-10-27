using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002763 RID: 10083
[UClass("/Game/Aki/TypeScript/Game/Module/Reward/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C")]
public class RewardBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06014AF2 RID: 84722 RVA: 0x0053BE4A File Offset: 0x0053A04A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RequestPickUpFightDrop(long packageIncId, long dropIncIds)
	{
	}

	// Token: 0x06014AF3 RID: 84723 RVA: 0x0053BE4C File Offset: 0x0053A04C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PackageDestroyCallBack(long packageIncId, long dropIncIds)
	{
	}

	// Token: 0x06014AF4 RID: 84724 RVA: 0x0053BE4E File Offset: 0x0053A04E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (RewardBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C");
		}
		return RewardBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06014AF5 RID: 84725 RVA: 0x0053BE74 File Offset: 0x0053A074
	public RewardBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06014AF6 RID: 84726 RVA: 0x0053BE9C File Offset: 0x0053A09C
	[NullableContext(1)]
	public RewardBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06014AF7 RID: 84727 RVA: 0x0053BECF File Offset: 0x0053A0CF
	protected RewardBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06014AF8 RID: 84728 RVA: 0x0053BED8 File Offset: 0x0053A0D8
	protected unsafe static void __CPPCALL_RequestPickUpFightDrop_Implementation(RewardBlueprintFunctionLibrary.__RequestPickUpFightDrop_FunctionParams* __Params)
	{
		RewardBlueprintFunctionLibrary.RequestPickUpFightDrop(__Params->packageIncId, __Params->dropIncIds);
	}

	// Token: 0x06014AF9 RID: 84729 RVA: 0x0053BEEB File Offset: 0x0053A0EB
	protected unsafe static void __CPPCALL_PackageDestroyCallBack_Implementation(RewardBlueprintFunctionLibrary.__PackageDestroyCallBack_FunctionParams* __Params)
	{
		RewardBlueprintFunctionLibrary.PackageDestroyCallBack(__Params->packageIncId, __Params->dropIncIds);
	}

	// Token: 0x04009B67 RID: 39783
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C";

	// Token: 0x04009B68 RID: 39784
	private static IntPtr _ClassPtr;

	// Token: 0x04009B69 RID: 39785
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008DCD RID: 36301
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RequestPickUpFightDrop_FunctionParams
	{
		// Token: 0x0402E04C RID: 188492
		[FieldOffset(0)]
		public long packageIncId;

		// Token: 0x0402E04D RID: 188493
		[FieldOffset(8)]
		public long dropIncIds;

		// Token: 0x0402E04E RID: 188494
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008DCE RID: 36302
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PackageDestroyCallBack_FunctionParams
	{
		// Token: 0x0402E04F RID: 188495
		[FieldOffset(0)]
		public long packageIncId;

		// Token: 0x0402E050 RID: 188496
		[FieldOffset(8)]
		public long dropIncIds;

		// Token: 0x0402E051 RID: 188497
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
