using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5F RID: 15199
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLightWithStaticMesh.BP_KuroSmartLightWithStaticMesh_C")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class BP_KuroSmartLightWithStaticMesh_C : BP_KuroSmartLight_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B98 RID: 138136 RVA: 0x008F410C File Offset: 0x008F230C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSmartLightWithStaticMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLightWithStaticMesh.BP_KuroSmartLightWithStaticMesh_C");
			}
			return BP_KuroSmartLightWithStaticMesh_C._ClassPtr;
		}

		// Token: 0x06021B99 RID: 138137 RVA: 0x008F4130 File Offset: 0x008F2330
		public BP_KuroSmartLightWithStaticMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSmartLightWithStaticMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B9A RID: 138138 RVA: 0x008F4158 File Offset: 0x008F2358
		[NullableContext(1)]
		public BP_KuroSmartLightWithStaticMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSmartLightWithStaticMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x06021B9B RID: 138139 RVA: 0x008F418B File Offset: 0x008F238B
		// (set) Token: 0x06021B9C RID: 138140 RVA: 0x008F419F File Offset: 0x008F239F
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLightWithStaticMesh_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSmartLightWithStaticMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021B9D RID: 138141 RVA: 0x008F41B4 File Offset: 0x008F23B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnUpdateLightOn(float Time)
		{
			BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams* ptr = stackalloc BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021B9E RID: 138142 RVA: 0x008F41FC File Offset: 0x008F23FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void OnUpdateLightOn_Implementation(float Time)
		{
			BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams* ptr = stackalloc BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOn_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021B9F RID: 138143 RVA: 0x008F4244 File Offset: 0x008F2444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnUpdateLightOff(float Time)
		{
			BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams* ptr = stackalloc BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021BA0 RID: 138144 RVA: 0x008F428C File Offset: 0x008F248C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void OnUpdateLightOff_Implementation(float Time)
		{
			BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams* ptr = stackalloc BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSmartLightWithStaticMesh_C.__OnUpdateLightOff_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021BA1 RID: 138145 RVA: 0x008F42D3 File Offset: 0x008F24D3
		protected BP_KuroSmartLightWithStaticMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010750 RID: 67408
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_KuroSmartLightWithStaticMesh.BP_KuroSmartLightWithStaticMesh_C";

		// Token: 0x04010751 RID: 67409
		private static IntPtr _ClassPtr;

		// Token: 0x04010752 RID: 67410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010753 RID: 67411
		internal new static int __PropertyOffset_1;

		// Token: 0x04010754 RID: 67412
		private static IntPtr __OnUpdateLightOn_NativeFunctionPtr;

		// Token: 0x04010755 RID: 67413
		private static IntPtr __OnUpdateLightOff_NativeFunctionPtr;

		// Token: 0x02009CC3 RID: 40131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnUpdateLightOn_FunctionParams
		{
			// Token: 0x040313A8 RID: 201640
			[FieldOffset(0)]
			public float Time;
		}

		// Token: 0x02009CC4 RID: 40132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __OnUpdateLightOff_FunctionParams
		{
			// Token: 0x040313A9 RID: 201641
			[FieldOffset(0)]
			public float Time;
		}
	}
}
