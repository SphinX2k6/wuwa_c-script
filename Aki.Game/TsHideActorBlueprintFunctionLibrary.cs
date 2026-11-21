using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200131F RID: 4895
[UClass("/Game/Aki/TypeScript/Game/Module/HideActor/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C")]
public class TsHideActorBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600C073 RID: 49267 RVA: 0x0038E392 File Offset: 0x0038C592
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideMesh()
	{
		HideActorController.Instance.HideMesh();
	}

	// Token: 0x0600C074 RID: 49268 RVA: 0x0038E39E File Offset: 0x0038C59E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideEffect()
	{
		HideActorController.Instance.HideEffect();
	}

	// Token: 0x0600C075 RID: 49269 RVA: 0x0038E3AA File Offset: 0x0038C5AA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowMesh()
	{
		HideActorController.Instance.ShowMesh();
	}

	// Token: 0x0600C076 RID: 49270 RVA: 0x0038E3B6 File Offset: 0x0038C5B6
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowEffect()
	{
		HideActorController.Instance.ShowEffect();
	}

	// Token: 0x0600C077 RID: 49271 RVA: 0x0038E3C2 File Offset: 0x0038C5C2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideNpcMesh()
	{
		HideActorController.Instance.HideNpcMesh();
	}

	// Token: 0x0600C078 RID: 49272 RVA: 0x0038E3CE File Offset: 0x0038C5CE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideNpcEffect()
	{
		HideActorController.Instance.HideNpcEffect();
	}

	// Token: 0x0600C079 RID: 49273 RVA: 0x0038E3DA File Offset: 0x0038C5DA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNpcMesh()
	{
		HideActorController.Instance.ShowNpcMesh();
	}

	// Token: 0x0600C07A RID: 49274 RVA: 0x0038E3E6 File Offset: 0x0038C5E6
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNpcEffect()
	{
		HideActorController.Instance.ShowNpcEffect();
	}

	// Token: 0x0600C07B RID: 49275 RVA: 0x0038E3F2 File Offset: 0x0038C5F2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetHideParameter(float distance, FName boneName)
	{
		HideActorController.Instance.SetHideParameter(distance, boneName);
	}

	// Token: 0x0600C07C RID: 49276 RVA: 0x0038E400 File Offset: 0x0038C600
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetHideParameter()
	{
		HideActorController.Instance.ResetHideParameter();
	}

	// Token: 0x0600C07D RID: 49277 RVA: 0x0038E40C File Offset: 0x0038C60C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsHideActorBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C");
		}
		return TsHideActorBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0600C07E RID: 49278 RVA: 0x0038E430 File Offset: 0x0038C630
	public TsHideActorBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600C07F RID: 49279 RVA: 0x0038E458 File Offset: 0x0038C658
	[NullableContext(1)]
	public TsHideActorBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600C080 RID: 49280 RVA: 0x0038E48B File Offset: 0x0038C68B
	protected TsHideActorBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600C081 RID: 49281 RVA: 0x0038E494 File Offset: 0x0038C694
	protected unsafe static void __CPPCALL_HideMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__HideMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideMesh();
	}

	// Token: 0x0600C082 RID: 49282 RVA: 0x0038E49B File Offset: 0x0038C69B
	protected unsafe static void __CPPCALL_HideEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__HideEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideEffect();
	}

	// Token: 0x0600C083 RID: 49283 RVA: 0x0038E4A2 File Offset: 0x0038C6A2
	protected unsafe static void __CPPCALL_ShowMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowMesh();
	}

	// Token: 0x0600C084 RID: 49284 RVA: 0x0038E4A9 File Offset: 0x0038C6A9
	protected unsafe static void __CPPCALL_ShowEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowEffect();
	}

	// Token: 0x0600C085 RID: 49285 RVA: 0x0038E4B0 File Offset: 0x0038C6B0
	protected unsafe static void __CPPCALL_HideNpcMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__HideNpcMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideNpcMesh();
	}

	// Token: 0x0600C086 RID: 49286 RVA: 0x0038E4B7 File Offset: 0x0038C6B7
	protected unsafe static void __CPPCALL_HideNpcEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__HideNpcEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideNpcEffect();
	}

	// Token: 0x0600C087 RID: 49287 RVA: 0x0038E4BE File Offset: 0x0038C6BE
	protected unsafe static void __CPPCALL_ShowNpcMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowNpcMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowNpcMesh();
	}

	// Token: 0x0600C088 RID: 49288 RVA: 0x0038E4C5 File Offset: 0x0038C6C5
	protected unsafe static void __CPPCALL_ShowNpcEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowNpcEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowNpcEffect();
	}

	// Token: 0x0600C089 RID: 49289 RVA: 0x0038E4CC File Offset: 0x0038C6CC
	protected unsafe static void __CPPCALL_SetHideParameter_Implementation(TsHideActorBlueprintFunctionLibrary.__SetHideParameter_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.SetHideParameter(__Params->distance, __Params->boneName);
	}

	// Token: 0x0600C08A RID: 49290 RVA: 0x0038E4DF File Offset: 0x0038C6DF
	protected unsafe static void __CPPCALL_ResetHideParameter_Implementation(TsHideActorBlueprintFunctionLibrary.__ResetHideParameter_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ResetHideParameter();
	}

	// Token: 0x04006E7E RID: 28286
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C";

	// Token: 0x04006E7F RID: 28287
	private static IntPtr _ClassPtr;

	// Token: 0x04006E80 RID: 28288
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007594 RID: 30100
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideMesh_FunctionParams
	{
		// Token: 0x040262E5 RID: 156389
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007595 RID: 30101
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideEffect_FunctionParams
	{
		// Token: 0x040262E6 RID: 156390
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007596 RID: 30102
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowMesh_FunctionParams
	{
		// Token: 0x040262E7 RID: 156391
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007597 RID: 30103
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowEffect_FunctionParams
	{
		// Token: 0x040262E8 RID: 156392
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007598 RID: 30104
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideNpcMesh_FunctionParams
	{
		// Token: 0x040262E9 RID: 156393
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007599 RID: 30105
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideNpcEffect_FunctionParams
	{
		// Token: 0x040262EA RID: 156394
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200759A RID: 30106
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNpcMesh_FunctionParams
	{
		// Token: 0x040262EB RID: 156395
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200759B RID: 30107
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNpcEffect_FunctionParams
	{
		// Token: 0x040262EC RID: 156396
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200759C RID: 30108
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetHideParameter_FunctionParams
	{
		// Token: 0x040262ED RID: 156397
		[FieldOffset(0)]
		public float distance;

		// Token: 0x040262EE RID: 156398
		[FieldOffset(4)]
		public FName boneName;

		// Token: 0x040262EF RID: 156399
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200759D RID: 30109
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResetHideParameter_FunctionParams
	{
		// Token: 0x040262F0 RID: 156400
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
