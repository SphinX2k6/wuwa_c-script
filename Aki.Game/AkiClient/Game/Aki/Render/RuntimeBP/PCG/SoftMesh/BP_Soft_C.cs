using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF3 RID: 15347
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft.BP_Soft_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1564)]
	public class BP_Soft_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DF3 RID: 142835 RVA: 0x00914838 File Offset: 0x00912A38
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Soft_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft.BP_Soft_C");
			}
			return BP_Soft_C._ClassPtr;
		}

		// Token: 0x06022DF4 RID: 142836 RVA: 0x0091485C File Offset: 0x00912A5C
		public BP_Soft_C() : this(BuiltinUtils.AllocNativeUObject(BP_Soft_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DF5 RID: 142837 RVA: 0x00914884 File Offset: 0x00912A84
		[NullableContext(1)]
		public BP_Soft_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Soft_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x06022DF6 RID: 142838 RVA: 0x009148B7 File Offset: 0x00912AB7
		// (set) Token: 0x06022DF7 RID: 142839 RVA: 0x009148CB File Offset: 0x00912ACB
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x06022DF8 RID: 142840 RVA: 0x009148E0 File Offset: 0x00912AE0
		// (set) Token: 0x06022DF9 RID: 142841 RVA: 0x009148F4 File Offset: 0x00912AF4
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x06022DFA RID: 142842 RVA: 0x00914909 File Offset: 0x00912B09
		// (set) Token: 0x06022DFB RID: 142843 RVA: 0x0091491D File Offset: 0x00912B1D
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x06022DFC RID: 142844 RVA: 0x00914932 File Offset: 0x00912B32
		// (set) Token: 0x06022DFD RID: 142845 RVA: 0x00914946 File Offset: 0x00912B46
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x06022DFE RID: 142846 RVA: 0x0091495B File Offset: 0x00912B5B
		// (set) Token: 0x06022DFF RID: 142847 RVA: 0x0091496F File Offset: 0x00912B6F
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x06022E00 RID: 142848 RVA: 0x00914984 File Offset: 0x00912B84
		// (set) Token: 0x06022E01 RID: 142849 RVA: 0x00914994 File Offset: 0x00912B94
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x06022E02 RID: 142850 RVA: 0x009149A5 File Offset: 0x00912BA5
		// (set) Token: 0x06022E03 RID: 142851 RVA: 0x009149B9 File Offset: 0x00912BB9
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x06022E04 RID: 142852 RVA: 0x009149CE File Offset: 0x00912BCE
		// (set) Token: 0x06022E05 RID: 142853 RVA: 0x009149DE File Offset: 0x00912BDE
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x06022E06 RID: 142854 RVA: 0x009149EF File Offset: 0x00912BEF
		// (set) Token: 0x06022E07 RID: 142855 RVA: 0x00914A03 File Offset: 0x00912C03
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x06022E08 RID: 142856 RVA: 0x00914A18 File Offset: 0x00912C18
		// (set) Token: 0x06022E09 RID: 142857 RVA: 0x00914A2C File Offset: 0x00912C2C
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x06022E0A RID: 142858 RVA: 0x00914A41 File Offset: 0x00912C41
		// (set) Token: 0x06022E0B RID: 142859 RVA: 0x00914A55 File Offset: 0x00912C55
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06022E0C RID: 142860 RVA: 0x00914A6A File Offset: 0x00912C6A
		// (set) Token: 0x06022E0D RID: 142861 RVA: 0x00914A7E File Offset: 0x00912C7E
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x06022E0E RID: 142862 RVA: 0x00914A93 File Offset: 0x00912C93
		// (set) Token: 0x06022E0F RID: 142863 RVA: 0x00914AA3 File Offset: 0x00912CA3
		public unsafe bool AlreadyBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x06022E10 RID: 142864 RVA: 0x00914AB4 File Offset: 0x00912CB4
		// (set) Token: 0x06022E11 RID: 142865 RVA: 0x00914AC4 File Offset: 0x00912CC4
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x06022E12 RID: 142866 RVA: 0x00914AD5 File Offset: 0x00912CD5
		// (set) Token: 0x06022E13 RID: 142867 RVA: 0x00914AE5 File Offset: 0x00912CE5
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x06022E14 RID: 142868 RVA: 0x00914AF6 File Offset: 0x00912CF6
		// (set) Token: 0x06022E15 RID: 142869 RVA: 0x00914B06 File Offset: 0x00912D06
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06022E16 RID: 142870 RVA: 0x00914B17 File Offset: 0x00912D17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022E17 RID: 142871 RVA: 0x00914B2B File Offset: 0x00912D2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E18 RID: 142872 RVA: 0x00914B40 File Offset: 0x00912D40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E19 RID: 142873 RVA: 0x00914BFC File Offset: 0x00912DFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E1A RID: 142874 RVA: 0x00914C85 File Offset: 0x00912E85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022E1B RID: 142875 RVA: 0x00914C99 File Offset: 0x00912E99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06022E1C RID: 142876 RVA: 0x00914CB0 File Offset: 0x00912EB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Soft_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E1D RID: 142877 RVA: 0x00914CF8 File Offset: 0x00912EF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Soft_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022E1E RID: 142878 RVA: 0x00914D3F File Offset: 0x00912F3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022E1F RID: 142879 RVA: 0x00914D53 File Offset: 0x00912F53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E20 RID: 142880 RVA: 0x00914D68 File Offset: 0x00912F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E21 RID: 142881 RVA: 0x00914D7C File Offset: 0x00912F7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E22 RID: 142882 RVA: 0x00914D91 File Offset: 0x00912F91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E23 RID: 142883 RVA: 0x00914DA5 File Offset: 0x00912FA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E24 RID: 142884 RVA: 0x00914DBA File Offset: 0x00912FBA
		protected BP_Soft_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011290 RID: 70288
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft.BP_Soft_C";

		// Token: 0x04011291 RID: 70289
		private static IntPtr _ClassPtr;

		// Token: 0x04011292 RID: 70290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011293 RID: 70291
		internal static int __PropertyOffset_1;

		// Token: 0x04011294 RID: 70292
		internal static int __PropertyOffset_2;

		// Token: 0x04011295 RID: 70293
		internal static int __PropertyOffset_3;

		// Token: 0x04011296 RID: 70294
		internal static int __PropertyOffset_4;

		// Token: 0x04011297 RID: 70295
		internal static int __PropertyOffset_5;

		// Token: 0x04011298 RID: 70296
		internal static int __PropertyOffset_6;

		// Token: 0x04011299 RID: 70297
		internal static int __PropertyOffset_7;

		// Token: 0x0401129A RID: 70298
		internal static int __PropertyOffset_8;

		// Token: 0x0401129B RID: 70299
		internal static int __PropertyOffset_9;

		// Token: 0x0401129C RID: 70300
		internal static int __PropertyOffset_10;

		// Token: 0x0401129D RID: 70301
		internal static int __PropertyOffset_11;

		// Token: 0x0401129E RID: 70302
		internal static int __PropertyOffset_12;

		// Token: 0x0401129F RID: 70303
		internal static int __PropertyOffset_13;

		// Token: 0x040112A0 RID: 70304
		internal static int __PropertyOffset_14;

		// Token: 0x040112A1 RID: 70305
		internal static int __PropertyOffset_15;

		// Token: 0x040112A2 RID: 70306
		internal static int __PropertyOffset_16;

		// Token: 0x040112A3 RID: 70307
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040112A4 RID: 70308
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112A5 RID: 70309
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112A6 RID: 70310
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040112A7 RID: 70311
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040112A8 RID: 70312
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040112A9 RID: 70313
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040112AA RID: 70314
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x040112AB RID: 70315
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009DE6 RID: 40422
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315E9 RID: 202217
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315EA RID: 202218
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315EB RID: 202219
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315EC RID: 202220
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040315ED RID: 202221
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040315EE RID: 202222
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DE7 RID: 40423
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315EF RID: 202223
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040315F0 RID: 202224
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040315F1 RID: 202225
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040315F2 RID: 202226
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009DE8 RID: 40424
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315F3 RID: 202227
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
