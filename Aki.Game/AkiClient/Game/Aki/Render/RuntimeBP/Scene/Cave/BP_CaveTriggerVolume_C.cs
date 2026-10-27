using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Cave
{
	// Token: 0x02003BA2 RID: 15266
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Cave/BP_CaveTriggerVolume.BP_CaveTriggerVolume_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1101)]
	public class BP_CaveTriggerVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FB5 RID: 139189 RVA: 0x008FB565 File Offset: 0x008F9765
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CaveTriggerVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Cave/BP_CaveTriggerVolume.BP_CaveTriggerVolume_C");
			}
			return BP_CaveTriggerVolume_C._ClassPtr;
		}

		// Token: 0x06021FB6 RID: 139190 RVA: 0x008FB58C File Offset: 0x008F978C
		public BP_CaveTriggerVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_CaveTriggerVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FB7 RID: 139191 RVA: 0x008FB5B4 File Offset: 0x008F97B4
		[NullableContext(1)]
		public BP_CaveTriggerVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CaveTriggerVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x06021FB8 RID: 139192 RVA: 0x008FB5E7 File Offset: 0x008F97E7
		// (set) Token: 0x06021FB9 RID: 139193 RVA: 0x008FB5FB File Offset: 0x008F97FB
		public unsafe UTextRenderComponent TextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x06021FBA RID: 139194 RVA: 0x008FB610 File Offset: 0x008F9810
		// (set) Token: 0x06021FBB RID: 139195 RVA: 0x008FB624 File Offset: 0x008F9824
		public unsafe UStaticMeshComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x06021FBC RID: 139196 RVA: 0x008FB639 File Offset: 0x008F9839
		// (set) Token: 0x06021FBD RID: 139197 RVA: 0x008FB64D File Offset: 0x008F984D
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaveTriggerVolume_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x06021FBE RID: 139198 RVA: 0x008FB662 File Offset: 0x008F9862
		// (set) Token: 0x06021FBF RID: 139199 RVA: 0x008FB672 File Offset: 0x008F9872
		public unsafe float MobileCSMDistanceOld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x06021FC0 RID: 139200 RVA: 0x008FB683 File Offset: 0x008F9883
		// (set) Token: 0x06021FC1 RID: 139201 RVA: 0x008FB693 File Offset: 0x008F9893
		public unsafe float MobileCSMDistanceNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x06021FC2 RID: 139202 RVA: 0x008FB6A4 File Offset: 0x008F98A4
		// (set) Token: 0x06021FC3 RID: 139203 RVA: 0x008FB6B4 File Offset: 0x008F98B4
		public unsafe float RayTraceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x06021FC4 RID: 139204 RVA: 0x008FB6C5 File Offset: 0x008F98C5
		// (set) Token: 0x06021FC5 RID: 139205 RVA: 0x008FB6D5 File Offset: 0x008F98D5
		public unsafe bool UseCustomCoef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x06021FC6 RID: 139206 RVA: 0x008FB6E6 File Offset: 0x008F98E6
		// (set) Token: 0x06021FC7 RID: 139207 RVA: 0x008FB6F6 File Offset: 0x008F98F6
		public unsafe ECaveOrRoomLoadType LoadType
		{
			get
			{
				return (ECaveOrRoomLoadType)(*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_8));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_8) = (byte)value;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x06021FC8 RID: 139208 RVA: 0x008FB707 File Offset: 0x008F9907
		// (set) Token: 0x06021FC9 RID: 139209 RVA: 0x008FB717 File Offset: 0x008F9917
		public unsafe float AdjustValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x06021FCA RID: 139210 RVA: 0x008FB728 File Offset: 0x008F9928
		// (set) Token: 0x06021FCB RID: 139211 RVA: 0x008FB738 File Offset: 0x008F9938
		public unsafe bool IsRoom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaveTriggerVolume_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021FCC RID: 139212 RVA: 0x008FB74C File Offset: 0x008F994C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRayCastLocation(FVectorDouble TriggerLocation, ref FVectorDouble Location)
		{
			BP_CaveTriggerVolume_C.__GetRayCastLocation_FunctionParams* ptr = stackalloc BP_CaveTriggerVolume_C.__GetRayCastLocation_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(BP_CaveTriggerVolume_C.__GetRayCastLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CaveTriggerVolume_C.__GetRayCastLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TriggerLocation = TriggerLocation;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CaveTriggerVolume_C.__GetRayCastLocation_NativeFunctionPtr, (void*)ptr);
			Location = ptr->Location;
		}

		// Token: 0x06021FCD RID: 139213 RVA: 0x008FB7B0 File Offset: 0x008F99B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSceneLightComponent(ref UDirectionalLightComponent Ret)
		{
			BP_CaveTriggerVolume_C.__GetSceneLightComponent_FunctionParams* ptr = stackalloc BP_CaveTriggerVolume_C.__GetSceneLightComponent_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_CaveTriggerVolume_C.__GetSceneLightComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CaveTriggerVolume_C.__GetSceneLightComponent_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_CaveTriggerVolume_C.__GetSceneLightComponent_FunctionParams ptr2 = ref *ptr;
			UDirectionalLightComponent udirectionalLightComponent = Ret;
			ptr2.Ret = ((udirectionalLightComponent != null) ? udirectionalLightComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CaveTriggerVolume_C.__GetSceneLightComponent_NativeFunctionPtr, (void*)ptr);
			Ret = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDirectionalLightComponent>(ptr->Ret);
		}

		// Token: 0x06021FCE RID: 139214 RVA: 0x008FB814 File Offset: 0x008F9A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FCF RID: 139215 RVA: 0x008FB8A0 File Offset: 0x008F9AA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CaveTriggerVolume_C.__BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FD0 RID: 139216 RVA: 0x008FB95A File Offset: 0x008F9B5A
		protected BP_CaveTriggerVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109F1 RID: 68081
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Cave/BP_CaveTriggerVolume.BP_CaveTriggerVolume_C";

		// Token: 0x040109F2 RID: 68082
		private static IntPtr _ClassPtr;

		// Token: 0x040109F3 RID: 68083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109F4 RID: 68084
		internal static int __PropertyOffset_1;

		// Token: 0x040109F5 RID: 68085
		internal static int __PropertyOffset_2;

		// Token: 0x040109F6 RID: 68086
		internal static int __PropertyOffset_3;

		// Token: 0x040109F7 RID: 68087
		internal static int __PropertyOffset_4;

		// Token: 0x040109F8 RID: 68088
		internal static int __PropertyOffset_5;

		// Token: 0x040109F9 RID: 68089
		internal static int __PropertyOffset_6;

		// Token: 0x040109FA RID: 68090
		internal static int __PropertyOffset_7;

		// Token: 0x040109FB RID: 68091
		internal static int __PropertyOffset_8;

		// Token: 0x040109FC RID: 68092
		internal static int __PropertyOffset_9;

		// Token: 0x040109FD RID: 68093
		internal static int __PropertyOffset_10;

		// Token: 0x040109FE RID: 68094
		private static IntPtr __GetRayCastLocation_NativeFunctionPtr;

		// Token: 0x040109FF RID: 68095
		private static IntPtr __GetSceneLightComponent_NativeFunctionPtr;

		// Token: 0x04010A00 RID: 68096
		private static IntPtr __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010A01 RID: 68097
		private static IntPtr __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009CFC RID: 40188
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 512)]
		protected ref struct __GetRayCastLocation_FunctionParams
		{
			// Token: 0x04031406 RID: 201734
			[FieldOffset(0)]
			public FVectorDouble TriggerLocation;

			// Token: 0x04031407 RID: 201735
			[FieldOffset(24)]
			public FVectorDouble Location;
		}

		// Token: 0x02009CFD RID: 40189
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetSceneLightComponent_FunctionParams
		{
			// Token: 0x04031408 RID: 201736
			[FieldOffset(0)]
			public IntPtr Ret;
		}

		// Token: 0x02009CFE RID: 40190
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031409 RID: 201737
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403140A RID: 201738
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403140B RID: 201739
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403140C RID: 201740
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009CFF RID: 40191
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_CaveTriggerVolume_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403140D RID: 201741
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403140E RID: 201742
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403140F RID: 201743
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031410 RID: 201744
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031411 RID: 201745
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031412 RID: 201746
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
