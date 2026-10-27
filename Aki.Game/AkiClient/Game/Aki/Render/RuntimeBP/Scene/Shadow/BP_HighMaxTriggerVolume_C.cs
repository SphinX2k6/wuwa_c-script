using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Shadow
{
	// Token: 0x02003AF5 RID: 15093
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Shadow/BP_HighMaxTriggerVolume.BP_HighMaxTriggerVolume_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1068)]
	public class BP_HighMaxTriggerVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B09 RID: 133897 RVA: 0x008DA7C5 File Offset: 0x008D89C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HighMaxTriggerVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Shadow/BP_HighMaxTriggerVolume.BP_HighMaxTriggerVolume_C");
			}
			return BP_HighMaxTriggerVolume_C._ClassPtr;
		}

		// Token: 0x06020B0A RID: 133898 RVA: 0x008DA7EC File Offset: 0x008D89EC
		public BP_HighMaxTriggerVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_HighMaxTriggerVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B0B RID: 133899 RVA: 0x008DA814 File Offset: 0x008D8A14
		[NullableContext(1)]
		public BP_HighMaxTriggerVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HighMaxTriggerVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x06020B0C RID: 133900 RVA: 0x008DA847 File Offset: 0x008D8A47
		// (set) Token: 0x06020B0D RID: 133901 RVA: 0x008DA85B File Offset: 0x008D8A5B
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HighMaxTriggerVolume_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HighMaxTriggerVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x06020B0E RID: 133902 RVA: 0x008DA870 File Offset: 0x008D8A70
		// (set) Token: 0x06020B0F RID: 133903 RVA: 0x008DA880 File Offset: 0x008D8A80
		public unsafe float ClampDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HighMaxTriggerVolume_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HighMaxTriggerVolume_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06020B10 RID: 133904 RVA: 0x008DA894 File Offset: 0x008D8A94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRayCastLocation(FVectorDouble TriggerLocation, ref FVectorDouble Location)
		{
			BP_HighMaxTriggerVolume_C.__GetRayCastLocation_FunctionParams* ptr = stackalloc BP_HighMaxTriggerVolume_C.__GetRayCastLocation_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(BP_HighMaxTriggerVolume_C.__GetRayCastLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HighMaxTriggerVolume_C.__GetRayCastLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TriggerLocation = TriggerLocation;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HighMaxTriggerVolume_C.__GetRayCastLocation_NativeFunctionPtr, (void*)ptr);
			Location = ptr->Location;
		}

		// Token: 0x06020B11 RID: 133905 RVA: 0x008DA8F8 File Offset: 0x008D8AF8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSceneLightComponent(ref UDirectionalLightComponent Ret)
		{
			BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_FunctionParams* ptr = stackalloc BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_FunctionParams ptr2 = ref *ptr;
			UDirectionalLightComponent udirectionalLightComponent = Ret;
			ptr2.Ret = ((udirectionalLightComponent != null) ? udirectionalLightComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HighMaxTriggerVolume_C.__GetSceneLightComponent_NativeFunctionPtr, (void*)ptr);
			Ret = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDirectionalLightComponent>(ptr->Ret);
		}

		// Token: 0x06020B12 RID: 133906 RVA: 0x008DA95C File Offset: 0x008D8B5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B13 RID: 133907 RVA: 0x008DAA18 File Offset: 0x008D8C18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HighMaxTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B14 RID: 133908 RVA: 0x008DAAA1 File Offset: 0x008D8CA1
		protected BP_HighMaxTriggerVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDED RID: 65005
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Shadow/BP_HighMaxTriggerVolume.BP_HighMaxTriggerVolume_C";

		// Token: 0x0400FDEE RID: 65006
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDEF RID: 65007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDF0 RID: 65008
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDF1 RID: 65009
		internal static int __PropertyOffset_2;

		// Token: 0x0400FDF2 RID: 65010
		private static IntPtr __GetRayCastLocation_NativeFunctionPtr;

		// Token: 0x0400FDF3 RID: 65011
		private static IntPtr __GetSceneLightComponent_NativeFunctionPtr;

		// Token: 0x0400FDF4 RID: 65012
		private static IntPtr __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FDF5 RID: 65013
		private static IntPtr __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009C23 RID: 39971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 512)]
		protected ref struct __GetRayCastLocation_FunctionParams
		{
			// Token: 0x040312CA RID: 201418
			[FieldOffset(0)]
			public FVectorDouble TriggerLocation;

			// Token: 0x040312CB RID: 201419
			[FieldOffset(24)]
			public FVectorDouble Location;
		}

		// Token: 0x02009C24 RID: 39972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetSceneLightComponent_FunctionParams
		{
			// Token: 0x040312CC RID: 201420
			[FieldOffset(0)]
			public IntPtr Ret;
		}

		// Token: 0x02009C25 RID: 39973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040312CD RID: 201421
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040312CE RID: 201422
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040312CF RID: 201423
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040312D0 RID: 201424
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040312D1 RID: 201425
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040312D2 RID: 201426
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009C26 RID: 39974
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040312D3 RID: 201427
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040312D4 RID: 201428
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040312D5 RID: 201429
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040312D6 RID: 201430
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
