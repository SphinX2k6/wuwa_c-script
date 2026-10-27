using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB2 RID: 15538
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BPL_BoxColSimulation.BPL_BoxColSimulation_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_BoxColSimulation_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602490B RID: 149771 RVA: 0x00942410 File Offset: 0x00940610
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_BoxColSimulation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BPL_BoxColSimulation.BPL_BoxColSimulation_C");
			}
			return BPL_BoxColSimulation_C._ClassPtr;
		}

		// Token: 0x0602490C RID: 149772 RVA: 0x00942434 File Offset: 0x00940634
		public BPL_BoxColSimulation_C() : this(BuiltinUtils.AllocNativeUObject(BPL_BoxColSimulation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602490D RID: 149773 RVA: 0x0094245C File Offset: 0x0094065C
		[NullableContext(1)]
		public BPL_BoxColSimulation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_BoxColSimulation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602490E RID: 149774 RVA: 0x00942490 File Offset: 0x00940690
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Setup_Params_From_DA_ForCloth_Use_Inside_BP_(BP_genCloth_C GenCloth, PD_MeshToBoxData_C DA, UObject __WorldContext, ref bool Find)
		{
			BPL_BoxColSimulation_C.StaticClass();
			BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_Use_Inside_BP__FunctionParams* ptr = stackalloc BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_Use_Inside_BP__FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_Use_Inside_BP__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_Use_Inside_BP__NativeFunctionPtr, (void*)ptr, 1);
			ptr->GenCloth = ((GenCloth != null) ? GenCloth.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Find = Find;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BoxColSimulation_C._ClassDefaultObjectPtr, BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_Use_Inside_BP__NativeFunctionPtr, (void*)ptr);
			Find = ptr->Find;
		}

		// Token: 0x0602490F RID: 149775 RVA: 0x0094252C File Offset: 0x0094072C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Setup_Params_From_DA_ForCloth(BP_genCloth_C GenCloth, PD_MeshToBoxData_C DA, UObject __WorldContext, ref bool Find)
		{
			BPL_BoxColSimulation_C.StaticClass();
			BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_FunctionParams* ptr = stackalloc BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GenCloth = ((GenCloth != null) ? GenCloth.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Find = Find;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BoxColSimulation_C._ClassDefaultObjectPtr, BPL_BoxColSimulation_C.__Setup_Params_From_DA_ForCloth_NativeFunctionPtr, (void*)ptr);
			Find = ptr->Find;
		}

		// Token: 0x06024910 RID: 149776 RVA: 0x009425C8 File Offset: 0x009407C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void boxCol_SM_2_SM_(PD_SM_2_BPSM_C DASM2SM, UStaticMesh SMInput, UObject __WorldContext, ref UStaticMesh SM, ref bool Find)
		{
			BPL_BoxColSimulation_C.StaticClass();
			BPL_BoxColSimulation_C.__boxCol_SM_2_SM__FunctionParams* ptr = stackalloc BPL_BoxColSimulation_C.__boxCol_SM_2_SM__FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BPL_BoxColSimulation_C.__boxCol_SM_2_SM__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BoxColSimulation_C.__boxCol_SM_2_SM__NativeFunctionPtr, (void*)ptr, 1);
			ptr->DASM2SM = ((DASM2SM != null) ? DASM2SM.NativePtr : IntPtr.Zero);
			ptr->SMInput = ((SMInput != null) ? SMInput.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref BPL_BoxColSimulation_C.__boxCol_SM_2_SM__FunctionParams ptr2 = ref *ptr;
			UStaticMesh ustaticMesh = SM;
			ptr2.SM = ((ustaticMesh != null) ? ustaticMesh.NativePtr : IntPtr.Zero);
			ptr->Find = Find;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BoxColSimulation_C._ClassDefaultObjectPtr, BPL_BoxColSimulation_C.__boxCol_SM_2_SM__NativeFunctionPtr, (void*)ptr);
			SM = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(ptr->SM);
			Find = ptr->Find;
		}

		// Token: 0x06024911 RID: 149777 RVA: 0x00942688 File Offset: 0x00940888
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Setup_Params_From_DA__Use_Inside_BP_(BP_BoxCol_C BoxCol, PD_MeshToBoxData_C DA, UStaticMesh staticMesh, UObject __WorldContext, ref bool Find)
		{
			BPL_BoxColSimulation_C.StaticClass();
			BPL_BoxColSimulation_C.__Setup_Params_From_DA__Use_Inside_BP__FunctionParams* ptr = stackalloc BPL_BoxColSimulation_C.__Setup_Params_From_DA__Use_Inside_BP__FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BPL_BoxColSimulation_C.__Setup_Params_From_DA__Use_Inside_BP__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BoxColSimulation_C.__Setup_Params_From_DA__Use_Inside_BP__NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoxCol = ((BoxCol != null) ? BoxCol.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->staticMesh = ((staticMesh != null) ? staticMesh.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Find = Find;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BoxColSimulation_C._ClassDefaultObjectPtr, BPL_BoxColSimulation_C.__Setup_Params_From_DA__Use_Inside_BP__NativeFunctionPtr, (void*)ptr);
			Find = ptr->Find;
		}

		// Token: 0x06024912 RID: 149778 RVA: 0x0094273C File Offset: 0x0094093C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Setup_Params_From_DA(BP_BoxCol_C BoxCol, PD_MeshToBoxData_C DA, UObject __WorldContext, ref bool Find)
		{
			BPL_BoxColSimulation_C.StaticClass();
			BPL_BoxColSimulation_C.__Setup_Params_From_DA_FunctionParams* ptr = stackalloc BPL_BoxColSimulation_C.__Setup_Params_From_DA_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BPL_BoxColSimulation_C.__Setup_Params_From_DA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BoxColSimulation_C.__Setup_Params_From_DA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoxCol = ((BoxCol != null) ? BoxCol.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Find = Find;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BoxColSimulation_C._ClassDefaultObjectPtr, BPL_BoxColSimulation_C.__Setup_Params_From_DA_NativeFunctionPtr, (void*)ptr);
			Find = ptr->Find;
		}

		// Token: 0x06024913 RID: 149779 RVA: 0x009427D5 File Offset: 0x009409D5
		protected BPL_BoxColSimulation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401228B RID: 74379
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BPL_BoxColSimulation.BPL_BoxColSimulation_C";

		// Token: 0x0401228C RID: 74380
		private static IntPtr _ClassPtr;

		// Token: 0x0401228D RID: 74381
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401228E RID: 74382
		private static IntPtr __Setup_Params_From_DA_ForCloth_Use_Inside_BP__NativeFunctionPtr;

		// Token: 0x0401228F RID: 74383
		private static IntPtr __Setup_Params_From_DA_ForCloth_NativeFunctionPtr;

		// Token: 0x04012290 RID: 74384
		private static IntPtr __boxCol_SM_2_SM__NativeFunctionPtr;

		// Token: 0x04012291 RID: 74385
		private static IntPtr __Setup_Params_From_DA__Use_Inside_BP__NativeFunctionPtr;

		// Token: 0x04012292 RID: 74386
		private static IntPtr __Setup_Params_From_DA_NativeFunctionPtr;

		// Token: 0x02009F3B RID: 40763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __Setup_Params_From_DA_ForCloth_Use_Inside_BP__FunctionParams
		{
			// Token: 0x040318CD RID: 202957
			[FieldOffset(0)]
			public IntPtr GenCloth;

			// Token: 0x040318CE RID: 202958
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040318CF RID: 202959
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040318D0 RID: 202960
			[FieldOffset(24)]
			public bool Find;
		}

		// Token: 0x02009F3C RID: 40764
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __Setup_Params_From_DA_ForCloth_FunctionParams
		{
			// Token: 0x040318D1 RID: 202961
			[FieldOffset(0)]
			public IntPtr GenCloth;

			// Token: 0x040318D2 RID: 202962
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040318D3 RID: 202963
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040318D4 RID: 202964
			[FieldOffset(24)]
			public bool Find;
		}

		// Token: 0x02009F3D RID: 40765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __boxCol_SM_2_SM__FunctionParams
		{
			// Token: 0x040318D5 RID: 202965
			[FieldOffset(0)]
			public IntPtr DASM2SM;

			// Token: 0x040318D6 RID: 202966
			[FieldOffset(8)]
			public IntPtr SMInput;

			// Token: 0x040318D7 RID: 202967
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040318D8 RID: 202968
			[FieldOffset(24)]
			public IntPtr SM;

			// Token: 0x040318D9 RID: 202969
			[FieldOffset(32)]
			public bool Find;
		}

		// Token: 0x02009F3E RID: 40766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __Setup_Params_From_DA__Use_Inside_BP__FunctionParams
		{
			// Token: 0x040318DA RID: 202970
			[FieldOffset(0)]
			public IntPtr BoxCol;

			// Token: 0x040318DB RID: 202971
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040318DC RID: 202972
			[FieldOffset(16)]
			public IntPtr staticMesh;

			// Token: 0x040318DD RID: 202973
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x040318DE RID: 202974
			[FieldOffset(32)]
			public bool Find;
		}

		// Token: 0x02009F3F RID: 40767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __Setup_Params_From_DA_FunctionParams
		{
			// Token: 0x040318DF RID: 202975
			[FieldOffset(0)]
			public IntPtr BoxCol;

			// Token: 0x040318E0 RID: 202976
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040318E1 RID: 202977
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040318E2 RID: 202978
			[FieldOffset(24)]
			public bool Find;
		}
	}
}
