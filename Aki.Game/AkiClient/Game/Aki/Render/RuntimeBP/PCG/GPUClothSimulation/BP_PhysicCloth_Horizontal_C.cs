using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CAA RID: 15530
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_Horizontal.BP_PhysicCloth_Horizontal_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class BP_PhysicCloth_Horizontal_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024810 RID: 149520 RVA: 0x00940935 File Offset: 0x0093EB35
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicCloth_Horizontal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_Horizontal.BP_PhysicCloth_Horizontal_C");
			}
			return BP_PhysicCloth_Horizontal_C._ClassPtr;
		}

		// Token: 0x06024811 RID: 149521 RVA: 0x0094095C File Offset: 0x0093EB5C
		public BP_PhysicCloth_Horizontal_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_Horizontal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024812 RID: 149522 RVA: 0x00940984 File Offset: 0x0093EB84
		[NullableContext(1)]
		public BP_PhysicCloth_Horizontal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_Horizontal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700476A RID: 18282
		// (get) Token: 0x06024813 RID: 149523 RVA: 0x009409B7 File Offset: 0x0093EBB7
		// (set) Token: 0x06024814 RID: 149524 RVA: 0x009409CB File Offset: 0x0093EBCB
		public unsafe UStaticMeshComponent coll
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700476B RID: 18283
		// (get) Token: 0x06024815 RID: 149525 RVA: 0x009409E0 File Offset: 0x0093EBE0
		// (set) Token: 0x06024816 RID: 149526 RVA: 0x009409F4 File Offset: 0x0093EBF4
		public unsafe UStaticMeshComponent CollsionCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700476C RID: 18284
		// (get) Token: 0x06024817 RID: 149527 RVA: 0x00940A09 File Offset: 0x0093EC09
		// (set) Token: 0x06024818 RID: 149528 RVA: 0x00940A1D File Offset: 0x0093EC1D
		public unsafe UChildActorComponent ChildActor3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x06024819 RID: 149529 RVA: 0x00940A32 File Offset: 0x0093EC32
		// (set) Token: 0x0602481A RID: 149530 RVA: 0x00940A46 File Offset: 0x0093EC46
		public unsafe UChildActorComponent ChildActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700476E RID: 18286
		// (get) Token: 0x0602481B RID: 149531 RVA: 0x00940A5B File Offset: 0x0093EC5B
		// (set) Token: 0x0602481C RID: 149532 RVA: 0x00940A6F File Offset: 0x0093EC6F
		public unsafe UChildActorComponent ChildActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700476F RID: 18287
		// (get) Token: 0x0602481D RID: 149533 RVA: 0x00940A84 File Offset: 0x0093EC84
		// (set) Token: 0x0602481E RID: 149534 RVA: 0x00940A98 File Offset: 0x0093EC98
		public unsafe UChildActorComponent ChildActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x0602481F RID: 149535 RVA: 0x00940AAD File Offset: 0x0093ECAD
		// (set) Token: 0x06024820 RID: 149536 RVA: 0x00940AC1 File Offset: 0x0093ECC1
		public unsafe UNiagaraComponent NS_cloth_horizontal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x06024821 RID: 149537 RVA: 0x00940AD6 File Offset: 0x0093ECD6
		// (set) Token: 0x06024822 RID: 149538 RVA: 0x00940AEA File Offset: 0x0093ECEA
		public unsafe UStaticMeshComponent SM_Tab_Clo_01AH
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x06024823 RID: 149539 RVA: 0x00940AFF File Offset: 0x0093ECFF
		// (set) Token: 0x06024824 RID: 149540 RVA: 0x00940B13 File Offset: 0x0093ED13
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x06024825 RID: 149541 RVA: 0x00940B28 File Offset: 0x0093ED28
		// (set) Token: 0x06024826 RID: 149542 RVA: 0x00940B3C File Offset: 0x0093ED3C
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x06024827 RID: 149543 RVA: 0x00940B51 File Offset: 0x0093ED51
		// (set) Token: 0x06024828 RID: 149544 RVA: 0x00940B65 File Offset: 0x0093ED65
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x06024829 RID: 149545 RVA: 0x00940B7A File Offset: 0x0093ED7A
		// (set) Token: 0x0602482A RID: 149546 RVA: 0x00940B8A File Offset: 0x0093ED8A
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x0602482B RID: 149547 RVA: 0x00940B9B File Offset: 0x0093ED9B
		// (set) Token: 0x0602482C RID: 149548 RVA: 0x00940BAB File Offset: 0x0093EDAB
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x0602482D RID: 149549 RVA: 0x00940BBC File Offset: 0x0093EDBC
		// (set) Token: 0x0602482E RID: 149550 RVA: 0x00940BCC File Offset: 0x0093EDCC
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_Horizontal_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x0602482F RID: 149551 RVA: 0x00940BDD File Offset: 0x0093EDDD
		// (set) Token: 0x06024830 RID: 149552 RVA: 0x00940BF1 File Offset: 0x0093EDF1
		public unsafe UMaterialInstanceDynamic dynamic_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_Horizontal_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x06024831 RID: 149553 RVA: 0x00940C06 File Offset: 0x0093EE06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Niagara_Input()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__Niagara_Input_NativeFunctionPtr, null);
		}

		// Token: 0x06024832 RID: 149554 RVA: 0x00940C1A File Offset: 0x0093EE1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Bending_Points()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__Bending_Points_NativeFunctionPtr, null);
		}

		// Token: 0x06024833 RID: 149555 RVA: 0x00940C2E File Offset: 0x0093EE2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__Input_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x06024834 RID: 149556 RVA: 0x00940C42 File Offset: 0x0093EE42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024835 RID: 149557 RVA: 0x00940C56 File Offset: 0x0093EE56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024836 RID: 149558 RVA: 0x00940C6B File Offset: 0x0093EE6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024837 RID: 149559 RVA: 0x00940C7F File Offset: 0x0093EE7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024838 RID: 149560 RVA: 0x00940C94 File Offset: 0x0093EE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_Horizontal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024839 RID: 149561 RVA: 0x00940CDC File Offset: 0x0093EEDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_Horizontal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_Horizontal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_Horizontal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602483A RID: 149562 RVA: 0x00940D23 File Offset: 0x0093EF23
		protected BP_PhysicCloth_Horizontal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121F8 RID: 74232
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_Horizontal.BP_PhysicCloth_Horizontal_C";

		// Token: 0x040121F9 RID: 74233
		private static IntPtr _ClassPtr;

		// Token: 0x040121FA RID: 74234
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121FB RID: 74235
		internal static int __PropertyOffset_1;

		// Token: 0x040121FC RID: 74236
		internal static int __PropertyOffset_2;

		// Token: 0x040121FD RID: 74237
		internal static int __PropertyOffset_3;

		// Token: 0x040121FE RID: 74238
		internal static int __PropertyOffset_4;

		// Token: 0x040121FF RID: 74239
		internal static int __PropertyOffset_5;

		// Token: 0x04012200 RID: 74240
		internal static int __PropertyOffset_6;

		// Token: 0x04012201 RID: 74241
		internal static int __PropertyOffset_7;

		// Token: 0x04012202 RID: 74242
		internal static int __PropertyOffset_8;

		// Token: 0x04012203 RID: 74243
		internal static int __PropertyOffset_9;

		// Token: 0x04012204 RID: 74244
		internal static int __PropertyOffset_10;

		// Token: 0x04012205 RID: 74245
		internal static int __PropertyOffset_11;

		// Token: 0x04012206 RID: 74246
		internal static int __PropertyOffset_12;

		// Token: 0x04012207 RID: 74247
		internal static int __PropertyOffset_13;

		// Token: 0x04012208 RID: 74248
		internal static int __PropertyOffset_14;

		// Token: 0x04012209 RID: 74249
		internal static int __PropertyOffset_15;

		// Token: 0x0401220A RID: 74250
		private static IntPtr __Niagara_Input_NativeFunctionPtr;

		// Token: 0x0401220B RID: 74251
		private static IntPtr __Bending_Points_NativeFunctionPtr;

		// Token: 0x0401220C RID: 74252
		private static IntPtr __Input_Parameters_NativeFunctionPtr;

		// Token: 0x0401220D RID: 74253
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401220E RID: 74254
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401220F RID: 74255
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F2F RID: 40751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318B1 RID: 202929
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
