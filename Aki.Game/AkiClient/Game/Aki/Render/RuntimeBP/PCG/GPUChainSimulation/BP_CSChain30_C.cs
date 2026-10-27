using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUChainSimulation
{
	// Token: 0x02003CAE RID: 15534
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain30.BP_CSChain30_C")]
	[UnrealStructLayout(1760, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1756)]
	public class BP_CSChain30_C : AKuroCSChain30, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024897 RID: 149655 RVA: 0x009415C2 File Offset: 0x0093F7C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CSChain30_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain30.BP_CSChain30_C");
			}
			return BP_CSChain30_C._ClassPtr;
		}

		// Token: 0x06024898 RID: 149656 RVA: 0x009415E8 File Offset: 0x0093F7E8
		public BP_CSChain30_C() : this(BuiltinUtils.AllocNativeUObject(BP_CSChain30_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024899 RID: 149657 RVA: 0x00941610 File Offset: 0x0093F810
		[NullableContext(1)]
		public BP_CSChain30_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CSChain30_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x0602489A RID: 149658 RVA: 0x00941643 File Offset: 0x0093F843
		// (set) Token: 0x0602489B RID: 149659 RVA: 0x00941657 File Offset: 0x0093F857
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x0602489C RID: 149660 RVA: 0x0094166C File Offset: 0x0093F86C
		// (set) Token: 0x0602489D RID: 149661 RVA: 0x00941680 File Offset: 0x0093F880
		public unsafe UStaticMeshComponent ClothMeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x0602489E RID: 149662 RVA: 0x00941695 File Offset: 0x0093F895
		// (set) Token: 0x0602489F RID: 149663 RVA: 0x009416A9 File Offset: 0x0093F8A9
		public unsafe UTextureRenderTarget2D RT_P
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x060248A0 RID: 149664 RVA: 0x009416BE File Offset: 0x0093F8BE
		// (set) Token: 0x060248A1 RID: 149665 RVA: 0x009416D2 File Offset: 0x0093F8D2
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x060248A2 RID: 149666 RVA: 0x009416E7 File Offset: 0x0093F8E7
		// (set) Token: 0x060248A3 RID: 149667 RVA: 0x009416F7 File Offset: 0x0093F8F7
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x060248A4 RID: 149668 RVA: 0x00941708 File Offset: 0x0093F908
		// (set) Token: 0x060248A5 RID: 149669 RVA: 0x00941718 File Offset: 0x0093F918
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x060248A6 RID: 149670 RVA: 0x0094172C File Offset: 0x0093F92C
		// (set) Token: 0x060248A7 RID: 149671 RVA: 0x00941765 File Offset: 0x0093F965
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x060248A8 RID: 149672 RVA: 0x00941773 File Offset: 0x0093F973
		// (set) Token: 0x060248A9 RID: 149673 RVA: 0x00941783 File Offset: 0x0093F983
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x060248AA RID: 149674 RVA: 0x00941794 File Offset: 0x0093F994
		// (set) Token: 0x060248AB RID: 149675 RVA: 0x009417A4 File Offset: 0x0093F9A4
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x060248AC RID: 149676 RVA: 0x009417B5 File Offset: 0x0093F9B5
		// (set) Token: 0x060248AD RID: 149677 RVA: 0x009417C5 File Offset: 0x0093F9C5
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x060248AE RID: 149678 RVA: 0x009417D6 File Offset: 0x0093F9D6
		// (set) Token: 0x060248AF RID: 149679 RVA: 0x009417E6 File Offset: 0x0093F9E6
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x060248B0 RID: 149680 RVA: 0x009417F7 File Offset: 0x0093F9F7
		// (set) Token: 0x060248B1 RID: 149681 RVA: 0x0094180B File Offset: 0x0093FA0B
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x060248B2 RID: 149682 RVA: 0x00941820 File Offset: 0x0093FA20
		// (set) Token: 0x060248B3 RID: 149683 RVA: 0x00941834 File Offset: 0x0093FA34
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x060248B4 RID: 149684 RVA: 0x00941849 File Offset: 0x0093FA49
		// (set) Token: 0x060248B5 RID: 149685 RVA: 0x00941859 File Offset: 0x0093FA59
		public unsafe float 弹力系数_0_1_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x060248B6 RID: 149686 RVA: 0x0094186A File Offset: 0x0093FA6A
		// (set) Token: 0x060248B7 RID: 149687 RVA: 0x0094187A File Offset: 0x0093FA7A
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x060248B8 RID: 149688 RVA: 0x0094188B File Offset: 0x0093FA8B
		// (set) Token: 0x060248B9 RID: 149689 RVA: 0x0094189F File Offset: 0x0093FA9F
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CSChain30_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x060248BA RID: 149690 RVA: 0x009418B4 File Offset: 0x0093FAB4
		// (set) Token: 0x060248BB RID: 149691 RVA: 0x009418C8 File Offset: 0x0093FAC8
		public unsafe FVector playerColPosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CSChain30_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x060248BC RID: 149692 RVA: 0x009418DD File Offset: 0x0093FADD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void buildArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__buildArr_NativeFunctionPtr, null);
		}

		// Token: 0x060248BD RID: 149693 RVA: 0x009418F1 File Offset: 0x0093FAF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x060248BE RID: 149694 RVA: 0x00941905 File Offset: 0x0093FB05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x060248BF RID: 149695 RVA: 0x00941919 File Offset: 0x0093FB19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060248C0 RID: 149696 RVA: 0x0094192D File Offset: 0x0093FB2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain30_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060248C1 RID: 149697 RVA: 0x00941942 File Offset: 0x0093FB42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060248C2 RID: 149698 RVA: 0x00941956 File Offset: 0x0093FB56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060248C3 RID: 149699 RVA: 0x0094196C File Offset: 0x0093FB6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CSChain30_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CSChain30_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CSChain30_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248C4 RID: 149700 RVA: 0x009419B4 File Offset: 0x0093FBB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CSChain30_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CSChain30_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CSChain30_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060248C5 RID: 149701 RVA: 0x009419FB File Offset: 0x0093FBFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060248C6 RID: 149702 RVA: 0x00941A10 File Offset: 0x0093FC10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CSChain30_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CSChain30_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CSChain30_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248C7 RID: 149703 RVA: 0x00941A5C File Offset: 0x0093FC5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CSChain30_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CSChain30_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CSChain30_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CSChain30_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060248C8 RID: 149704 RVA: 0x00941AA8 File Offset: 0x0093FCA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248C9 RID: 149705 RVA: 0x00941B64 File Offset: 0x0093FD64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CSChain30_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060248CA RID: 149706 RVA: 0x00941BED File Offset: 0x0093FDED
		protected BP_CSChain30_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012241 RID: 74305
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/BP_CSChain30.BP_CSChain30_C";

		// Token: 0x04012242 RID: 74306
		private static IntPtr _ClassPtr;

		// Token: 0x04012243 RID: 74307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012244 RID: 74308
		internal static int __PropertyOffset_1;

		// Token: 0x04012245 RID: 74309
		internal static int __PropertyOffset_2;

		// Token: 0x04012246 RID: 74310
		internal static int __PropertyOffset_3;

		// Token: 0x04012247 RID: 74311
		internal static int __PropertyOffset_4;

		// Token: 0x04012248 RID: 74312
		internal static int __PropertyOffset_5;

		// Token: 0x04012249 RID: 74313
		internal static int __PropertyOffset_6;

		// Token: 0x0401224A RID: 74314
		internal static int __PropertyOffset_7;

		// Token: 0x0401224B RID: 74315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x0401224C RID: 74316
		internal static int __PropertyOffset_8;

		// Token: 0x0401224D RID: 74317
		internal static int __PropertyOffset_9;

		// Token: 0x0401224E RID: 74318
		internal static int __PropertyOffset_10;

		// Token: 0x0401224F RID: 74319
		internal static int __PropertyOffset_11;

		// Token: 0x04012250 RID: 74320
		internal static int __PropertyOffset_12;

		// Token: 0x04012251 RID: 74321
		internal static int __PropertyOffset_13;

		// Token: 0x04012252 RID: 74322
		internal static int __PropertyOffset_14;

		// Token: 0x04012253 RID: 74323
		internal static int __PropertyOffset_15;

		// Token: 0x04012254 RID: 74324
		internal static int __PropertyOffset_16;

		// Token: 0x04012255 RID: 74325
		internal static int __PropertyOffset_17;

		// Token: 0x04012256 RID: 74326
		private static IntPtr __buildArr_NativeFunctionPtr;

		// Token: 0x04012257 RID: 74327
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04012258 RID: 74328
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04012259 RID: 74329
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401225A RID: 74330
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401225B RID: 74331
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401225C RID: 74332
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401225D RID: 74333
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401225E RID: 74334
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401225F RID: 74335
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F33 RID: 40755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318B5 RID: 202933
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F34 RID: 40756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040318B6 RID: 202934
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F35 RID: 40757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318B7 RID: 202935
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318B8 RID: 202936
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318B9 RID: 202937
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318BA RID: 202938
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040318BB RID: 202939
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040318BC RID: 202940
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F36 RID: 40758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318BD RID: 202941
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318BE RID: 202942
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318BF RID: 202943
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318C0 RID: 202944
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
