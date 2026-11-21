using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001C4E RID: 7246
[UClass("/Game/Aki/TypeScript/Game/Module/Reward/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C")]
public class RewardBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06011FD5 RID: 73685 RVA: 0x0054AC5A File Offset: 0x00548E5A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RequestPickUpFightDrop(long packageIncId, long dropIncIds)
	{
	}

	// Token: 0x06011FD6 RID: 73686 RVA: 0x0054AC5C File Offset: 0x00548E5C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PackageDestroyCallBack(long packageIncId, long dropIncIds)
	{
	}

	// Token: 0x06011FD7 RID: 73687 RVA: 0x0054AC5E File Offset: 0x00548E5E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (RewardBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C");
		}
		return RewardBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06011FD8 RID: 73688 RVA: 0x0054AC84 File Offset: 0x00548E84
	public RewardBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06011FD9 RID: 73689 RVA: 0x0054ACAC File Offset: 0x00548EAC
	[NullableContext(1)]
	public RewardBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(RewardBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06011FDA RID: 73690 RVA: 0x0054ACDF File Offset: 0x00548EDF
	protected RewardBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06011FDB RID: 73691 RVA: 0x0054ACE8 File Offset: 0x00548EE8
	protected unsafe static void __CPPCALL_RequestPickUpFightDrop_Implementation(RewardBlueprintFunctionLibrary.__RequestPickUpFightDrop_FunctionParams* __Params)
	{
		RewardBlueprintFunctionLibrary.RequestPickUpFightDrop(__Params->packageIncId, __Params->dropIncIds);
	}

	// Token: 0x06011FDC RID: 73692 RVA: 0x0054ACFB File Offset: 0x00548EFB
	protected unsafe static void __CPPCALL_PackageDestroyCallBack_Implementation(RewardBlueprintFunctionLibrary.__PackageDestroyCallBack_FunctionParams* __Params)
	{
		RewardBlueprintFunctionLibrary.PackageDestroyCallBack(__Params->packageIncId, __Params->dropIncIds);
	}

	// Token: 0x04009CBF RID: 40127
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Reward/RewardBlueprintFunctionLibrary.RewardBlueprintFunctionLibrary_C";

	// Token: 0x04009CC0 RID: 40128
	private static IntPtr _ClassPtr;

	// Token: 0x04009CC1 RID: 40129
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007F55 RID: 32597
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RequestPickUpFightDrop_FunctionParams
	{
		// Token: 0x04029361 RID: 168801
		[FieldOffset(0)]
		public long packageIncId;

		// Token: 0x04029362 RID: 168802
		[FieldOffset(8)]
		public long dropIncIds;

		// Token: 0x04029363 RID: 168803
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007F56 RID: 32598
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __PackageDestroyCallBack_FunctionParams
	{
		// Token: 0x04029364 RID: 168804
		[FieldOffset(0)]
		public long packageIncId;

		// Token: 0x04029365 RID: 168805
		[FieldOffset(8)]
		public long dropIncIds;

		// Token: 0x04029366 RID: 168806
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
