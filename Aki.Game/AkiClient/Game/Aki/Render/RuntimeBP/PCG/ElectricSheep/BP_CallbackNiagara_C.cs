using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.ElectricSheep
{
	// Token: 0x02003CC6 RID: 15558
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/ElectricSheep/BP_CallbackNiagara.BP_CallbackNiagara_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class BP_CallbackNiagara_C : AKuroBPActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024C74 RID: 150644 RVA: 0x00948092 File Offset: 0x00946292
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CallbackNiagara_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/ElectricSheep/BP_CallbackNiagara.BP_CallbackNiagara_C");
			}
			return BP_CallbackNiagara_C._ClassPtr;
		}

		// Token: 0x06024C75 RID: 150645 RVA: 0x009480B6 File Offset: 0x009462B6
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_CallbackNiagara_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x06024C76 RID: 150646 RVA: 0x009480C0 File Offset: 0x009462C0
		public BP_CallbackNiagara_C() : this(BuiltinUtils.AllocNativeUObject(BP_CallbackNiagara_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C77 RID: 150647 RVA: 0x009480E8 File Offset: 0x009462E8
		[NullableContext(1)]
		public BP_CallbackNiagara_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CallbackNiagara_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x06024C78 RID: 150648 RVA: 0x0094811B File Offset: 0x0094631B
		// (set) Token: 0x06024C79 RID: 150649 RVA: 0x0094812F File Offset: 0x0094632F
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x06024C7A RID: 150650 RVA: 0x00948144 File Offset: 0x00946344
		// (set) Token: 0x06024C7B RID: 150651 RVA: 0x00948158 File Offset: 0x00946358
		public unsafe UStaticMeshComponent TemplateMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x06024C7C RID: 150652 RVA: 0x0094816D File Offset: 0x0094636D
		// (set) Token: 0x06024C7D RID: 150653 RVA: 0x00948181 File Offset: 0x00946381
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x06024C7E RID: 150654 RVA: 0x00948196 File Offset: 0x00946396
		// (set) Token: 0x06024C7F RID: 150655 RVA: 0x009481AA File Offset: 0x009463AA
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x06024C80 RID: 150656 RVA: 0x009481BF File Offset: 0x009463BF
		// (set) Token: 0x06024C81 RID: 150657 RVA: 0x009481D3 File Offset: 0x009463D3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x06024C82 RID: 150658 RVA: 0x009481E8 File Offset: 0x009463E8
		// (set) Token: 0x06024C83 RID: 150659 RVA: 0x009481FC File Offset: 0x009463FC
		public unsafe FVector PitchMinMax_YawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x06024C84 RID: 150660 RVA: 0x00948211 File Offset: 0x00946411
		// (set) Token: 0x06024C85 RID: 150661 RVA: 0x00948221 File Offset: 0x00946421
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x06024C86 RID: 150662 RVA: 0x00948232 File Offset: 0x00946432
		// (set) Token: 0x06024C87 RID: 150663 RVA: 0x00948242 File Offset: 0x00946442
		public unsafe float Size_Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x06024C88 RID: 150664 RVA: 0x00948253 File Offset: 0x00946453
		// (set) Token: 0x06024C89 RID: 150665 RVA: 0x00948263 File Offset: 0x00946463
		public unsafe float Size_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x06024C8A RID: 150666 RVA: 0x00948274 File Offset: 0x00946474
		// (set) Token: 0x06024C8B RID: 150667 RVA: 0x00948284 File Offset: 0x00946484
		public unsafe int SpawnCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x06024C8C RID: 150668 RVA: 0x00948295 File Offset: 0x00946495
		// (set) Token: 0x06024C8D RID: 150669 RVA: 0x009482A5 File Offset: 0x009464A5
		public unsafe float SpawnDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x06024C8E RID: 150670 RVA: 0x009482B6 File Offset: 0x009464B6
		// (set) Token: 0x06024C8F RID: 150671 RVA: 0x009482C6 File Offset: 0x009464C6
		public unsafe float SpawnRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x06024C90 RID: 150672 RVA: 0x009482D7 File Offset: 0x009464D7
		// (set) Token: 0x06024C91 RID: 150673 RVA: 0x009482E7 File Offset: 0x009464E7
		public unsafe float SpeedWiggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x06024C92 RID: 150674 RVA: 0x009482F8 File Offset: 0x009464F8
		// (set) Token: 0x06024C93 RID: 150675 RVA: 0x00948308 File Offset: 0x00946508
		public unsafe float SplineSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x06024C94 RID: 150676 RVA: 0x0094831C File Offset: 0x0094651C
		// (set) Token: 0x06024C95 RID: 150677 RVA: 0x00948355 File Offset: 0x00946555
		[Nullable(1)]
		public TArray<UStaticMeshComponent> CollisionComponentReferences
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._CollisionComponentReferences) == null)
				{
					result = (this._CollisionComponentReferences = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CollisionComponentReferences.CopyAssign(value);
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x06024C96 RID: 150678 RVA: 0x00948363 File Offset: 0x00946563
		// (set) Token: 0x06024C97 RID: 150679 RVA: 0x00948373 File Offset: 0x00946573
		public unsafe bool IsSetExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x06024C98 RID: 150680 RVA: 0x00948384 File Offset: 0x00946584
		// (set) Token: 0x06024C99 RID: 150681 RVA: 0x009483BD File Offset: 0x009465BD
		[Nullable(1)]
		public TArray<UStaticMeshComponent> NewVar_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._NewVar_0) == null)
				{
					result = (this._NewVar_0 = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NewVar_0.CopyAssign(value);
			}
		}

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x06024C9A RID: 150682 RVA: 0x009483CB File Offset: 0x009465CB
		// (set) Token: 0x06024C9B RID: 150683 RVA: 0x009483DB File Offset: 0x009465DB
		public unsafe float time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x06024C9C RID: 150684 RVA: 0x009483EC File Offset: 0x009465EC
		// (set) Token: 0x06024C9D RID: 150685 RVA: 0x00948400 File Offset: 0x00946600
		public unsafe FBoxSphereBounds Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CallbackNiagara_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x06024C9E RID: 150686 RVA: 0x00948415 File Offset: 0x00946615
		// (set) Token: 0x06024C9F RID: 150687 RVA: 0x00948429 File Offset: 0x00946629
		public unsafe USceneComponent Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CallbackNiagara_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x06024CA0 RID: 150688 RVA: 0x0094843E File Offset: 0x0094663E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetNiagaraParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__SetNiagaraParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06024CA1 RID: 150689 RVA: 0x00948452 File Offset: 0x00946652
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024CA2 RID: 150690 RVA: 0x00948466 File Offset: 0x00946666
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CallbackNiagara_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024CA3 RID: 150691 RVA: 0x0094847B File Offset: 0x0094667B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024CA4 RID: 150692 RVA: 0x0094848F File Offset: 0x0094668F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024CA5 RID: 150693 RVA: 0x009484A4 File Offset: 0x009466A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CallbackNiagara_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CallbackNiagara_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CA6 RID: 150694 RVA: 0x009484EC File Offset: 0x009466EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CallbackNiagara_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CallbackNiagara_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024CA7 RID: 150695 RVA: 0x00948534 File Offset: 0x00946734
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024CA8 RID: 150696 RVA: 0x009485C4 File Offset: 0x009467C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_CallbackNiagara_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CallbackNiagara_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024CA9 RID: 150697 RVA: 0x00948654 File Offset: 0x00946854
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CAA RID: 150698 RVA: 0x00948710 File Offset: 0x00946910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CallbackNiagara_C.__BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CAB RID: 150699 RVA: 0x00948799 File Offset: 0x00946999
		protected BP_CallbackNiagara_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012465 RID: 74853
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x04012466 RID: 74854
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/ElectricSheep/BP_CallbackNiagara.BP_CallbackNiagara_C";

		// Token: 0x04012467 RID: 74855
		private static IntPtr _ClassPtr;

		// Token: 0x04012468 RID: 74856
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012469 RID: 74857
		internal static int __PropertyOffset_1;

		// Token: 0x0401246A RID: 74858
		internal static int __PropertyOffset_2;

		// Token: 0x0401246B RID: 74859
		internal static int __PropertyOffset_3;

		// Token: 0x0401246C RID: 74860
		internal static int __PropertyOffset_4;

		// Token: 0x0401246D RID: 74861
		internal static int __PropertyOffset_5;

		// Token: 0x0401246E RID: 74862
		internal static int __PropertyOffset_6;

		// Token: 0x0401246F RID: 74863
		internal static int __PropertyOffset_7;

		// Token: 0x04012470 RID: 74864
		internal static int __PropertyOffset_8;

		// Token: 0x04012471 RID: 74865
		internal static int __PropertyOffset_9;

		// Token: 0x04012472 RID: 74866
		internal static int __PropertyOffset_10;

		// Token: 0x04012473 RID: 74867
		internal static int __PropertyOffset_11;

		// Token: 0x04012474 RID: 74868
		internal static int __PropertyOffset_12;

		// Token: 0x04012475 RID: 74869
		internal static int __PropertyOffset_13;

		// Token: 0x04012476 RID: 74870
		internal static int __PropertyOffset_14;

		// Token: 0x04012477 RID: 74871
		internal static int __PropertyOffset_15;

		// Token: 0x04012478 RID: 74872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _CollisionComponentReferences;

		// Token: 0x04012479 RID: 74873
		internal static int __PropertyOffset_16;

		// Token: 0x0401247A RID: 74874
		internal static int __PropertyOffset_17;

		// Token: 0x0401247B RID: 74875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _NewVar_0;

		// Token: 0x0401247C RID: 74876
		internal static int __PropertyOffset_18;

		// Token: 0x0401247D RID: 74877
		internal static int __PropertyOffset_19;

		// Token: 0x0401247E RID: 74878
		internal static int __PropertyOffset_20;

		// Token: 0x0401247F RID: 74879
		private static IntPtr __SetNiagaraParameters_NativeFunctionPtr;

		// Token: 0x04012480 RID: 74880
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012481 RID: 74881
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012482 RID: 74882
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012483 RID: 74883
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x04012484 RID: 74884
		private static IntPtr __BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012485 RID: 74885
		private static IntPtr __BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F68 RID: 40808
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403195E RID: 203102
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F69 RID: 40809
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x0403195F RID: 203103
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x04031960 RID: 203104
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}

		// Token: 0x02009F6A RID: 40810
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031961 RID: 203105
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031962 RID: 203106
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031963 RID: 203107
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031964 RID: 203108
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031965 RID: 203109
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031966 RID: 203110
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F6B RID: 40811
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_CallbackNiagara_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031967 RID: 203111
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031968 RID: 203112
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031969 RID: 203113
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403196A RID: 203114
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
