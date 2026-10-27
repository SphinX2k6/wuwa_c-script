using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF4 RID: 15348
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag2.BP_Soft_clothBag2_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1564)]
	public class BP_Soft_clothBag2_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E25 RID: 142885 RVA: 0x00914DC3 File Offset: 0x00912FC3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Soft_clothBag2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag2.BP_Soft_clothBag2_C");
			}
			return BP_Soft_clothBag2_C._ClassPtr;
		}

		// Token: 0x06022E26 RID: 142886 RVA: 0x00914DE8 File Offset: 0x00912FE8
		public BP_Soft_clothBag2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Soft_clothBag2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E27 RID: 142887 RVA: 0x00914E10 File Offset: 0x00913010
		[NullableContext(1)]
		public BP_Soft_clothBag2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Soft_clothBag2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x06022E28 RID: 142888 RVA: 0x00914E43 File Offset: 0x00913043
		// (set) Token: 0x06022E29 RID: 142889 RVA: 0x00914E57 File Offset: 0x00913057
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x06022E2A RID: 142890 RVA: 0x00914E6C File Offset: 0x0091306C
		// (set) Token: 0x06022E2B RID: 142891 RVA: 0x00914E80 File Offset: 0x00913080
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x06022E2C RID: 142892 RVA: 0x00914E95 File Offset: 0x00913095
		// (set) Token: 0x06022E2D RID: 142893 RVA: 0x00914EA9 File Offset: 0x009130A9
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x06022E2E RID: 142894 RVA: 0x00914EBE File Offset: 0x009130BE
		// (set) Token: 0x06022E2F RID: 142895 RVA: 0x00914ED2 File Offset: 0x009130D2
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x06022E30 RID: 142896 RVA: 0x00914EE7 File Offset: 0x009130E7
		// (set) Token: 0x06022E31 RID: 142897 RVA: 0x00914EFB File Offset: 0x009130FB
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x06022E32 RID: 142898 RVA: 0x00914F10 File Offset: 0x00913110
		// (set) Token: 0x06022E33 RID: 142899 RVA: 0x00914F20 File Offset: 0x00913120
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x06022E34 RID: 142900 RVA: 0x00914F31 File Offset: 0x00913131
		// (set) Token: 0x06022E35 RID: 142901 RVA: 0x00914F45 File Offset: 0x00913145
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x06022E36 RID: 142902 RVA: 0x00914F5A File Offset: 0x0091315A
		// (set) Token: 0x06022E37 RID: 142903 RVA: 0x00914F6A File Offset: 0x0091316A
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x06022E38 RID: 142904 RVA: 0x00914F7B File Offset: 0x0091317B
		// (set) Token: 0x06022E39 RID: 142905 RVA: 0x00914F8F File Offset: 0x0091318F
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x06022E3A RID: 142906 RVA: 0x00914FA4 File Offset: 0x009131A4
		// (set) Token: 0x06022E3B RID: 142907 RVA: 0x00914FB8 File Offset: 0x009131B8
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x06022E3C RID: 142908 RVA: 0x00914FCD File Offset: 0x009131CD
		// (set) Token: 0x06022E3D RID: 142909 RVA: 0x00914FE1 File Offset: 0x009131E1
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x06022E3E RID: 142910 RVA: 0x00914FF6 File Offset: 0x009131F6
		// (set) Token: 0x06022E3F RID: 142911 RVA: 0x0091500A File Offset: 0x0091320A
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag2_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x06022E40 RID: 142912 RVA: 0x0091501F File Offset: 0x0091321F
		// (set) Token: 0x06022E41 RID: 142913 RVA: 0x0091502F File Offset: 0x0091322F
		public unsafe bool AlreadyBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x06022E42 RID: 142914 RVA: 0x00915040 File Offset: 0x00913240
		// (set) Token: 0x06022E43 RID: 142915 RVA: 0x00915050 File Offset: 0x00913250
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x06022E44 RID: 142916 RVA: 0x00915061 File Offset: 0x00913261
		// (set) Token: 0x06022E45 RID: 142917 RVA: 0x00915071 File Offset: 0x00913271
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x06022E46 RID: 142918 RVA: 0x00915082 File Offset: 0x00913282
		// (set) Token: 0x06022E47 RID: 142919 RVA: 0x00915092 File Offset: 0x00913292
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag2_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06022E48 RID: 142920 RVA: 0x009150A3 File Offset: 0x009132A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022E49 RID: 142921 RVA: 0x009150B7 File Offset: 0x009132B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E4A RID: 142922 RVA: 0x009150CC File Offset: 0x009132CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E4B RID: 142923 RVA: 0x00915188 File Offset: 0x00913388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E4C RID: 142924 RVA: 0x00915211 File Offset: 0x00913411
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022E4D RID: 142925 RVA: 0x00915225 File Offset: 0x00913425
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06022E4E RID: 142926 RVA: 0x0091523C File Offset: 0x0091343C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E4F RID: 142927 RVA: 0x00915284 File Offset: 0x00913484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_clothBag2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022E50 RID: 142928 RVA: 0x009152CB File Offset: 0x009134CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022E51 RID: 142929 RVA: 0x009152DF File Offset: 0x009134DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E52 RID: 142930 RVA: 0x009152F4 File Offset: 0x009134F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E53 RID: 142931 RVA: 0x00915308 File Offset: 0x00913508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag2_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E54 RID: 142932 RVA: 0x0091531D File Offset: 0x0091351D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag2_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E55 RID: 142933 RVA: 0x00915331 File Offset: 0x00913531
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag2_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E56 RID: 142934 RVA: 0x00915346 File Offset: 0x00913546
		protected BP_Soft_clothBag2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112AC RID: 70316
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag2.BP_Soft_clothBag2_C";

		// Token: 0x040112AD RID: 70317
		private static IntPtr _ClassPtr;

		// Token: 0x040112AE RID: 70318
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112AF RID: 70319
		internal static int __PropertyOffset_1;

		// Token: 0x040112B0 RID: 70320
		internal static int __PropertyOffset_2;

		// Token: 0x040112B1 RID: 70321
		internal static int __PropertyOffset_3;

		// Token: 0x040112B2 RID: 70322
		internal static int __PropertyOffset_4;

		// Token: 0x040112B3 RID: 70323
		internal static int __PropertyOffset_5;

		// Token: 0x040112B4 RID: 70324
		internal static int __PropertyOffset_6;

		// Token: 0x040112B5 RID: 70325
		internal static int __PropertyOffset_7;

		// Token: 0x040112B6 RID: 70326
		internal static int __PropertyOffset_8;

		// Token: 0x040112B7 RID: 70327
		internal static int __PropertyOffset_9;

		// Token: 0x040112B8 RID: 70328
		internal static int __PropertyOffset_10;

		// Token: 0x040112B9 RID: 70329
		internal static int __PropertyOffset_11;

		// Token: 0x040112BA RID: 70330
		internal static int __PropertyOffset_12;

		// Token: 0x040112BB RID: 70331
		internal static int __PropertyOffset_13;

		// Token: 0x040112BC RID: 70332
		internal static int __PropertyOffset_14;

		// Token: 0x040112BD RID: 70333
		internal static int __PropertyOffset_15;

		// Token: 0x040112BE RID: 70334
		internal static int __PropertyOffset_16;

		// Token: 0x040112BF RID: 70335
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040112C0 RID: 70336
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112C1 RID: 70337
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112C2 RID: 70338
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040112C3 RID: 70339
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040112C4 RID: 70340
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040112C5 RID: 70341
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040112C6 RID: 70342
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x040112C7 RID: 70343
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009DE9 RID: 40425
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315F4 RID: 202228
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315F5 RID: 202229
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315F6 RID: 202230
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315F7 RID: 202231
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040315F8 RID: 202232
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040315F9 RID: 202233
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DEA RID: 40426
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315FA RID: 202234
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315FB RID: 202235
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315FC RID: 202236
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315FD RID: 202237
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009DEB RID: 40427
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315FE RID: 202238
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
