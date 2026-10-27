using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C1B RID: 15387
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint.BP_PlantGrowthPoint_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1481)]
	public class BP_PlantGrowthPoint_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233E3 RID: 144355 RVA: 0x0091E8E7 File Offset: 0x0091CAE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantGrowthPoint_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint.BP_PlantGrowthPoint_C");
			}
			return BP_PlantGrowthPoint_C._ClassPtr;
		}

		// Token: 0x060233E4 RID: 144356 RVA: 0x0091E90C File Offset: 0x0091CB0C
		public BP_PlantGrowthPoint_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthPoint_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233E5 RID: 144357 RVA: 0x0091E934 File Offset: 0x0091CB34
		[NullableContext(1)]
		public BP_PlantGrowthPoint_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthPoint_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x060233E6 RID: 144358 RVA: 0x0091E967 File Offset: 0x0091CB67
		// (set) Token: 0x060233E7 RID: 144359 RVA: 0x0091E97B File Offset: 0x0091CB7B
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x060233E8 RID: 144360 RVA: 0x0091E990 File Offset: 0x0091CB90
		// (set) Token: 0x060233E9 RID: 144361 RVA: 0x0091E9A4 File Offset: 0x0091CBA4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthPoint_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x060233EA RID: 144362 RVA: 0x0091E9B9 File Offset: 0x0091CBB9
		// (set) Token: 0x060233EB RID: 144363 RVA: 0x0091E9C9 File Offset: 0x0091CBC9
		public unsafe bool IsDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthPoint_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthPoint_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x060233EC RID: 144364 RVA: 0x0091E9DC File Offset: 0x0091CBDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthPoint_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthPoint_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233ED RID: 144365 RVA: 0x0091EA24 File Offset: 0x0091CC24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthPoint_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthPoint_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthPoint_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060233EE RID: 144366 RVA: 0x0091EA6C File Offset: 0x0091CC6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_PlantGrowthPoint_C.__BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PlantGrowthPoint_C.__BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_PlantGrowthPoint_C.__BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthPoint_C.__BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthPoint_C.__BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233EF RID: 144367 RVA: 0x0091EB26 File Offset: 0x0091CD26
		protected BP_PlantGrowthPoint_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011609 RID: 71177
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_PlantGrowthPoint.BP_PlantGrowthPoint_C";

		// Token: 0x0401160A RID: 71178
		private static IntPtr _ClassPtr;

		// Token: 0x0401160B RID: 71179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401160C RID: 71180
		internal static int __PropertyOffset_1;

		// Token: 0x0401160D RID: 71181
		internal static int __PropertyOffset_2;

		// Token: 0x0401160E RID: 71182
		internal static int __PropertyOffset_3;

		// Token: 0x0401160F RID: 71183
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011610 RID: 71184
		private static IntPtr __BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E3F RID: 40511
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316A9 RID: 202409
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E40 RID: 40512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_FoliageGrowthPOI_Sphere_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316AA RID: 202410
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316AB RID: 202411
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316AC RID: 202412
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316AD RID: 202413
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040316AE RID: 202414
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040316AF RID: 202415
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
