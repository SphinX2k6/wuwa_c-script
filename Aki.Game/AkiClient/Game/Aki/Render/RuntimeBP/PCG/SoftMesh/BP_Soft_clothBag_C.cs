using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF5 RID: 15349
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag.BP_Soft_clothBag_C")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1604)]
	public class BP_Soft_clothBag_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E57 RID: 142935 RVA: 0x0091534F File Offset: 0x0091354F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Soft_clothBag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag.BP_Soft_clothBag_C");
			}
			return BP_Soft_clothBag_C._ClassPtr;
		}

		// Token: 0x06022E58 RID: 142936 RVA: 0x00915374 File Offset: 0x00913574
		public BP_Soft_clothBag_C() : this(BuiltinUtils.AllocNativeUObject(BP_Soft_clothBag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E59 RID: 142937 RVA: 0x0091539C File Offset: 0x0091359C
		[NullableContext(1)]
		public BP_Soft_clothBag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Soft_clothBag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x06022E5A RID: 142938 RVA: 0x009153CF File Offset: 0x009135CF
		// (set) Token: 0x06022E5B RID: 142939 RVA: 0x009153E3 File Offset: 0x009135E3
		public unsafe UPhysicsConstraintComponent PhysicsConstraint1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x06022E5C RID: 142940 RVA: 0x009153F8 File Offset: 0x009135F8
		// (set) Token: 0x06022E5D RID: 142941 RVA: 0x0091540C File Offset: 0x0091360C
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x06022E5E RID: 142942 RVA: 0x00915421 File Offset: 0x00913621
		// (set) Token: 0x06022E5F RID: 142943 RVA: 0x00915435 File Offset: 0x00913635
		public unsafe UPhysicsConstraintComponent PhysicsConstraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x06022E60 RID: 142944 RVA: 0x0091544A File Offset: 0x0091364A
		// (set) Token: 0x06022E61 RID: 142945 RVA: 0x0091545E File Offset: 0x0091365E
		public unsafe UStaticMeshComponent SoftBox5_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x06022E62 RID: 142946 RVA: 0x00915473 File Offset: 0x00913673
		// (set) Token: 0x06022E63 RID: 142947 RVA: 0x00915487 File Offset: 0x00913687
		public unsafe UStaticMeshComponent SoftBox5_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x06022E64 RID: 142948 RVA: 0x0091549C File Offset: 0x0091369C
		// (set) Token: 0x06022E65 RID: 142949 RVA: 0x009154B0 File Offset: 0x009136B0
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x06022E66 RID: 142950 RVA: 0x009154C5 File Offset: 0x009136C5
		// (set) Token: 0x06022E67 RID: 142951 RVA: 0x009154D9 File Offset: 0x009136D9
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x06022E68 RID: 142952 RVA: 0x009154EE File Offset: 0x009136EE
		// (set) Token: 0x06022E69 RID: 142953 RVA: 0x00915502 File Offset: 0x00913702
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x06022E6A RID: 142954 RVA: 0x00915517 File Offset: 0x00913717
		// (set) Token: 0x06022E6B RID: 142955 RVA: 0x0091552B File Offset: 0x0091372B
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x06022E6C RID: 142956 RVA: 0x00915540 File Offset: 0x00913740
		// (set) Token: 0x06022E6D RID: 142957 RVA: 0x00915554 File Offset: 0x00913754
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x06022E6E RID: 142958 RVA: 0x00915569 File Offset: 0x00913769
		// (set) Token: 0x06022E6F RID: 142959 RVA: 0x00915579 File Offset: 0x00913779
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x06022E70 RID: 142960 RVA: 0x0091558A File Offset: 0x0091378A
		// (set) Token: 0x06022E71 RID: 142961 RVA: 0x0091559E File Offset: 0x0091379E
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x06022E72 RID: 142962 RVA: 0x009155B3 File Offset: 0x009137B3
		// (set) Token: 0x06022E73 RID: 142963 RVA: 0x009155C3 File Offset: 0x009137C3
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x06022E74 RID: 142964 RVA: 0x009155D4 File Offset: 0x009137D4
		// (set) Token: 0x06022E75 RID: 142965 RVA: 0x009155E8 File Offset: 0x009137E8
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x06022E76 RID: 142966 RVA: 0x009155FD File Offset: 0x009137FD
		// (set) Token: 0x06022E77 RID: 142967 RVA: 0x00915611 File Offset: 0x00913811
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x06022E78 RID: 142968 RVA: 0x00915626 File Offset: 0x00913826
		// (set) Token: 0x06022E79 RID: 142969 RVA: 0x0091563A File Offset: 0x0091383A
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x06022E7A RID: 142970 RVA: 0x0091564F File Offset: 0x0091384F
		// (set) Token: 0x06022E7B RID: 142971 RVA: 0x00915663 File Offset: 0x00913863
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Soft_clothBag_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x06022E7C RID: 142972 RVA: 0x00915678 File Offset: 0x00913878
		// (set) Token: 0x06022E7D RID: 142973 RVA: 0x00915688 File Offset: 0x00913888
		public unsafe bool AlreadyBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x06022E7E RID: 142974 RVA: 0x00915699 File Offset: 0x00913899
		// (set) Token: 0x06022E7F RID: 142975 RVA: 0x009156A9 File Offset: 0x009138A9
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x06022E80 RID: 142976 RVA: 0x009156BA File Offset: 0x009138BA
		// (set) Token: 0x06022E81 RID: 142977 RVA: 0x009156CA File Offset: 0x009138CA
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x06022E82 RID: 142978 RVA: 0x009156DB File Offset: 0x009138DB
		// (set) Token: 0x06022E83 RID: 142979 RVA: 0x009156EB File Offset: 0x009138EB
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Soft_clothBag_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x06022E84 RID: 142980 RVA: 0x009156FC File Offset: 0x009138FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022E85 RID: 142981 RVA: 0x00915710 File Offset: 0x00913910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E86 RID: 142982 RVA: 0x00915728 File Offset: 0x00913928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E87 RID: 142983 RVA: 0x009157E4 File Offset: 0x009139E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E88 RID: 142984 RVA: 0x0091586D File Offset: 0x00913A6D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022E89 RID: 142985 RVA: 0x00915881 File Offset: 0x00913A81
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06022E8A RID: 142986 RVA: 0x00915898 File Offset: 0x00913A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Soft_clothBag_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_clothBag_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_clothBag_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022E8B RID: 142987 RVA: 0x009158E0 File Offset: 0x00913AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Soft_clothBag_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Soft_clothBag_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Soft_clothBag_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Soft_clothBag_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022E8C RID: 142988 RVA: 0x00915927 File Offset: 0x00913B27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022E8D RID: 142989 RVA: 0x0091593B File Offset: 0x00913B3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E8E RID: 142990 RVA: 0x00915950 File Offset: 0x00913B50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E8F RID: 142991 RVA: 0x00915964 File Offset: 0x00913B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E90 RID: 142992 RVA: 0x00915979 File Offset: 0x00913B79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Soft_clothBag_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06022E91 RID: 142993 RVA: 0x0091598D File Offset: 0x00913B8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Soft_clothBag_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022E92 RID: 142994 RVA: 0x009159A2 File Offset: 0x00913BA2
		protected BP_Soft_clothBag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112C8 RID: 70344
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/BP_Soft_clothBag.BP_Soft_clothBag_C";

		// Token: 0x040112C9 RID: 70345
		private static IntPtr _ClassPtr;

		// Token: 0x040112CA RID: 70346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112CB RID: 70347
		internal static int __PropertyOffset_1;

		// Token: 0x040112CC RID: 70348
		internal static int __PropertyOffset_2;

		// Token: 0x040112CD RID: 70349
		internal static int __PropertyOffset_3;

		// Token: 0x040112CE RID: 70350
		internal static int __PropertyOffset_4;

		// Token: 0x040112CF RID: 70351
		internal static int __PropertyOffset_5;

		// Token: 0x040112D0 RID: 70352
		internal static int __PropertyOffset_6;

		// Token: 0x040112D1 RID: 70353
		internal static int __PropertyOffset_7;

		// Token: 0x040112D2 RID: 70354
		internal static int __PropertyOffset_8;

		// Token: 0x040112D3 RID: 70355
		internal static int __PropertyOffset_9;

		// Token: 0x040112D4 RID: 70356
		internal static int __PropertyOffset_10;

		// Token: 0x040112D5 RID: 70357
		internal static int __PropertyOffset_11;

		// Token: 0x040112D6 RID: 70358
		internal static int __PropertyOffset_12;

		// Token: 0x040112D7 RID: 70359
		internal static int __PropertyOffset_13;

		// Token: 0x040112D8 RID: 70360
		internal static int __PropertyOffset_14;

		// Token: 0x040112D9 RID: 70361
		internal static int __PropertyOffset_15;

		// Token: 0x040112DA RID: 70362
		internal static int __PropertyOffset_16;

		// Token: 0x040112DB RID: 70363
		internal static int __PropertyOffset_17;

		// Token: 0x040112DC RID: 70364
		internal static int __PropertyOffset_18;

		// Token: 0x040112DD RID: 70365
		internal static int __PropertyOffset_19;

		// Token: 0x040112DE RID: 70366
		internal static int __PropertyOffset_20;

		// Token: 0x040112DF RID: 70367
		internal static int __PropertyOffset_21;

		// Token: 0x040112E0 RID: 70368
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040112E1 RID: 70369
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112E2 RID: 70370
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040112E3 RID: 70371
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040112E4 RID: 70372
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040112E5 RID: 70373
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040112E6 RID: 70374
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040112E7 RID: 70375
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x040112E8 RID: 70376
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009DEC RID: 40428
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040315FF RID: 202239
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031600 RID: 202240
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031601 RID: 202241
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031602 RID: 202242
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031603 RID: 202243
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031604 RID: 202244
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DED RID: 40429
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031605 RID: 202245
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031606 RID: 202246
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031607 RID: 202247
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031608 RID: 202248
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009DEE RID: 40430
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031609 RID: 202249
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
