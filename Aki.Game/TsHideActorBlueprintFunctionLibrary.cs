using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001E5D RID: 7773
[UClass("/Game/Aki/TypeScript/Game/Module/HideActor/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C")]
public class TsHideActorBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600EC54 RID: 60500 RVA: 0x003826E6 File Offset: 0x003808E6
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideMesh()
	{
		HideActorController.Instance.HideMesh();
	}

	// Token: 0x0600EC55 RID: 60501 RVA: 0x003826F2 File Offset: 0x003808F2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideEffect()
	{
		HideActorController.Instance.HideEffect();
	}

	// Token: 0x0600EC56 RID: 60502 RVA: 0x003826FE File Offset: 0x003808FE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowMesh()
	{
		HideActorController.Instance.ShowMesh();
	}

	// Token: 0x0600EC57 RID: 60503 RVA: 0x0038270A File Offset: 0x0038090A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowEffect()
	{
		HideActorController.Instance.ShowEffect();
	}

	// Token: 0x0600EC58 RID: 60504 RVA: 0x00382716 File Offset: 0x00380916
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideNpcMesh()
	{
		HideActorController.Instance.HideNpcMesh();
	}

	// Token: 0x0600EC59 RID: 60505 RVA: 0x00382722 File Offset: 0x00380922
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void HideNpcEffect()
	{
		HideActorController.Instance.HideNpcEffect();
	}

	// Token: 0x0600EC5A RID: 60506 RVA: 0x0038272E File Offset: 0x0038092E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNpcMesh()
	{
		HideActorController.Instance.ShowNpcMesh();
	}

	// Token: 0x0600EC5B RID: 60507 RVA: 0x0038273A File Offset: 0x0038093A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ShowNpcEffect()
	{
		HideActorController.Instance.ShowNpcEffect();
	}

	// Token: 0x0600EC5C RID: 60508 RVA: 0x00382746 File Offset: 0x00380946
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetHideParameter(float distance, FName boneName)
	{
		HideActorController.Instance.SetHideParameter(distance, boneName);
	}

	// Token: 0x0600EC5D RID: 60509 RVA: 0x00382754 File Offset: 0x00380954
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetHideParameter()
	{
		HideActorController.Instance.ResetHideParameter();
	}

	// Token: 0x0600EC5E RID: 60510 RVA: 0x00382760 File Offset: 0x00380960
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsHideActorBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C");
		}
		return TsHideActorBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0600EC5F RID: 60511 RVA: 0x00382784 File Offset: 0x00380984
	public TsHideActorBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600EC60 RID: 60512 RVA: 0x003827AC File Offset: 0x003809AC
	[NullableContext(1)]
	public TsHideActorBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsHideActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600EC61 RID: 60513 RVA: 0x003827DF File Offset: 0x003809DF
	protected TsHideActorBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600EC62 RID: 60514 RVA: 0x003827E8 File Offset: 0x003809E8
	protected unsafe static void __CPPCALL_HideMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__HideMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideMesh();
	}

	// Token: 0x0600EC63 RID: 60515 RVA: 0x003827EF File Offset: 0x003809EF
	protected unsafe static void __CPPCALL_HideEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__HideEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideEffect();
	}

	// Token: 0x0600EC64 RID: 60516 RVA: 0x003827F6 File Offset: 0x003809F6
	protected unsafe static void __CPPCALL_ShowMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowMesh();
	}

	// Token: 0x0600EC65 RID: 60517 RVA: 0x003827FD File Offset: 0x003809FD
	protected unsafe static void __CPPCALL_ShowEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowEffect();
	}

	// Token: 0x0600EC66 RID: 60518 RVA: 0x00382804 File Offset: 0x00380A04
	protected unsafe static void __CPPCALL_HideNpcMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__HideNpcMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideNpcMesh();
	}

	// Token: 0x0600EC67 RID: 60519 RVA: 0x0038280B File Offset: 0x00380A0B
	protected unsafe static void __CPPCALL_HideNpcEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__HideNpcEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.HideNpcEffect();
	}

	// Token: 0x0600EC68 RID: 60520 RVA: 0x00382812 File Offset: 0x00380A12
	protected unsafe static void __CPPCALL_ShowNpcMesh_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowNpcMesh_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowNpcMesh();
	}

	// Token: 0x0600EC69 RID: 60521 RVA: 0x00382819 File Offset: 0x00380A19
	protected unsafe static void __CPPCALL_ShowNpcEffect_Implementation(TsHideActorBlueprintFunctionLibrary.__ShowNpcEffect_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ShowNpcEffect();
	}

	// Token: 0x0600EC6A RID: 60522 RVA: 0x00382820 File Offset: 0x00380A20
	protected unsafe static void __CPPCALL_SetHideParameter_Implementation(TsHideActorBlueprintFunctionLibrary.__SetHideParameter_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.SetHideParameter(__Params->distance, __Params->boneName);
	}

	// Token: 0x0600EC6B RID: 60523 RVA: 0x00382833 File Offset: 0x00380A33
	protected unsafe static void __CPPCALL_ResetHideParameter_Implementation(TsHideActorBlueprintFunctionLibrary.__ResetHideParameter_FunctionParams* __Params)
	{
		TsHideActorBlueprintFunctionLibrary.ResetHideParameter();
	}

	// Token: 0x04006D9D RID: 28061
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/HideActor/TsHideActorBlueprintFunctionLibrary.TsHideActorBlueprintFunctionLibrary_C";

	// Token: 0x04006D9E RID: 28062
	private static IntPtr _ClassPtr;

	// Token: 0x04006D9F RID: 28063
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200840F RID: 33807
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideMesh_FunctionParams
	{
		// Token: 0x0402AFC1 RID: 176065
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008410 RID: 33808
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideEffect_FunctionParams
	{
		// Token: 0x0402AFC2 RID: 176066
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008411 RID: 33809
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowMesh_FunctionParams
	{
		// Token: 0x0402AFC3 RID: 176067
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008412 RID: 33810
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowEffect_FunctionParams
	{
		// Token: 0x0402AFC4 RID: 176068
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008413 RID: 33811
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideNpcMesh_FunctionParams
	{
		// Token: 0x0402AFC5 RID: 176069
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008414 RID: 33812
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __HideNpcEffect_FunctionParams
	{
		// Token: 0x0402AFC6 RID: 176070
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008415 RID: 33813
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNpcMesh_FunctionParams
	{
		// Token: 0x0402AFC7 RID: 176071
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008416 RID: 33814
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ShowNpcEffect_FunctionParams
	{
		// Token: 0x0402AFC8 RID: 176072
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008417 RID: 33815
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetHideParameter_FunctionParams
	{
		// Token: 0x0402AFC9 RID: 176073
		[FieldOffset(0)]
		public float distance;

		// Token: 0x0402AFCA RID: 176074
		[FieldOffset(4)]
		public FName boneName;

		// Token: 0x0402AFCB RID: 176075
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008418 RID: 33816
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResetHideParameter_FunctionParams
	{
		// Token: 0x0402AFCC RID: 176076
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
