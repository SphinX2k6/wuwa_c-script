using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Cloth
{
	// Token: 0x02003C8E RID: 15502
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BPL_KuroCSCloth.BPL_KuroCSCloth_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_KuroCSCloth_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024390 RID: 148368 RVA: 0x009385D7 File Offset: 0x009367D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_KuroCSCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BPL_KuroCSCloth.BPL_KuroCSCloth_C");
			}
			return BPL_KuroCSCloth_C._ClassPtr;
		}

		// Token: 0x06024391 RID: 148369 RVA: 0x009385FC File Offset: 0x009367FC
		public BPL_KuroCSCloth_C() : this(BuiltinUtils.AllocNativeUObject(BPL_KuroCSCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024392 RID: 148370 RVA: 0x00938624 File Offset: 0x00936824
		[NullableContext(1)]
		public BPL_KuroCSCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_KuroCSCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024393 RID: 148371 RVA: 0x00938658 File Offset: 0x00936858
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool CheckClothEnable(AActor Actor, UObject __WorldContext)
		{
			BPL_KuroCSCloth_C.StaticClass();
			BPL_KuroCSCloth_C.__CheckClothEnable_FunctionParams* ptr = stackalloc BPL_KuroCSCloth_C.__CheckClothEnable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BPL_KuroCSCloth_C.__CheckClothEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_KuroCSCloth_C.__CheckClothEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_KuroCSCloth_C._ClassDefaultObjectPtr, BPL_KuroCSCloth_C.__CheckClothEnable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06024394 RID: 148372 RVA: 0x009386D0 File Offset: 0x009368D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReadParamsFromDA(BP_KuroCSCloth_C Cloth, PD_MeshToClothData_C DA, UObject __WorldContext, ref bool bFind)
		{
			BPL_KuroCSCloth_C.__ReadParamsFromDA_FunctionParams* ptr = stackalloc BPL_KuroCSCloth_C.__ReadParamsFromDA_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BPL_KuroCSCloth_C.__ReadParamsFromDA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_KuroCSCloth_C.__ReadParamsFromDA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Cloth = ((Cloth != null) ? Cloth.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bFind = bFind;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPL_KuroCSCloth_C.__ReadParamsFromDA_NativeFunctionPtr, (void*)ptr);
			bFind = ptr->bFind;
		}

		// Token: 0x06024395 RID: 148373 RVA: 0x00938768 File Offset: 0x00936968
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyBPToDA(BP_KuroCSCloth_C Cloth, PD_MeshToClothData_C DA, UObject __WorldContext)
		{
			BPL_KuroCSCloth_C.__ApplyBPToDA_FunctionParams* ptr = stackalloc BPL_KuroCSCloth_C.__ApplyBPToDA_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BPL_KuroCSCloth_C.__ApplyBPToDA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_KuroCSCloth_C.__ApplyBPToDA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Cloth = ((Cloth != null) ? Cloth.NativePtr : IntPtr.Zero);
			ptr->DA = ((DA != null) ? DA.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BPL_KuroCSCloth_C.__ApplyBPToDA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024396 RID: 148374 RVA: 0x009387EC File Offset: 0x009369EC
		protected BPL_KuroCSCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F2A RID: 73514
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/BPL_KuroCSCloth.BPL_KuroCSCloth_C";

		// Token: 0x04011F2B RID: 73515
		private static IntPtr _ClassPtr;

		// Token: 0x04011F2C RID: 73516
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F2D RID: 73517
		private static IntPtr __CheckClothEnable_NativeFunctionPtr;

		// Token: 0x04011F2E RID: 73518
		private static IntPtr __ReadParamsFromDA_NativeFunctionPtr;

		// Token: 0x04011F2F RID: 73519
		private static IntPtr __ApplyBPToDA_NativeFunctionPtr;

		// Token: 0x02009EEA RID: 40682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CheckClothEnable_FunctionParams
		{
			// Token: 0x040317F0 RID: 202736
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040317F1 RID: 202737
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x040317F2 RID: 202738
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009EEB RID: 40683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __ReadParamsFromDA_FunctionParams
		{
			// Token: 0x040317F3 RID: 202739
			[FieldOffset(0)]
			public IntPtr Cloth;

			// Token: 0x040317F4 RID: 202740
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040317F5 RID: 202741
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040317F6 RID: 202742
			[FieldOffset(24)]
			public bool bFind;
		}

		// Token: 0x02009EEC RID: 40684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __ApplyBPToDA_FunctionParams
		{
			// Token: 0x040317F7 RID: 202743
			[FieldOffset(0)]
			public IntPtr Cloth;

			// Token: 0x040317F8 RID: 202744
			[FieldOffset(8)]
			public IntPtr DA;

			// Token: 0x040317F9 RID: 202745
			[FieldOffset(16)]
			public IntPtr __WorldContext;
		}
	}
}
