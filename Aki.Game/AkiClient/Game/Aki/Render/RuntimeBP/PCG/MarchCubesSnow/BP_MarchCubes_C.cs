using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow
{
	// Token: 0x02003C53 RID: 15443
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/BP_MarchCubes.BP_MarchCubes_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class BP_MarchCubes_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023CF3 RID: 146675 RVA: 0x0092D6F9 File Offset: 0x0092B8F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MarchCubes_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/BP_MarchCubes.BP_MarchCubes_C");
			}
			return BP_MarchCubes_C._ClassPtr;
		}

		// Token: 0x06023CF4 RID: 146676 RVA: 0x0092D720 File Offset: 0x0092B920
		public BP_MarchCubes_C() : this(BuiltinUtils.AllocNativeUObject(BP_MarchCubes_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CF5 RID: 146677 RVA: 0x0092D748 File Offset: 0x0092B948
		[NullableContext(1)]
		public BP_MarchCubes_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MarchCubes_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x06023CF6 RID: 146678 RVA: 0x0092D77B File Offset: 0x0092B97B
		// (set) Token: 0x06023CF7 RID: 146679 RVA: 0x0092D78F File Offset: 0x0092B98F
		public unsafe UBoxComponent EnterTheAttackRange
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x06023CF8 RID: 146680 RVA: 0x0092D7A4 File Offset: 0x0092B9A4
		// (set) Token: 0x06023CF9 RID: 146681 RVA: 0x0092D7B8 File Offset: 0x0092B9B8
		public unsafe UBoxComponent CharaEnter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x06023CFA RID: 146682 RVA: 0x0092D7CD File Offset: 0x0092B9CD
		// (set) Token: 0x06023CFB RID: 146683 RVA: 0x0092D7E1 File Offset: 0x0092B9E1
		public unsafe UMarchingCubesComponent MarchingCubes
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMarchingCubesComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x06023CFC RID: 146684 RVA: 0x0092D7F6 File Offset: 0x0092B9F6
		// (set) Token: 0x06023CFD RID: 146685 RVA: 0x0092D80A File Offset: 0x0092BA0A
		public unsafe USceneComponent DefaultSceneRoot1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MarchCubes_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x06023CFE RID: 146686 RVA: 0x0092D81F File Offset: 0x0092BA1F
		// (set) Token: 0x06023CFF RID: 146687 RVA: 0x0092D82F File Offset: 0x0092BA2F
		public unsafe bool IsEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x06023D00 RID: 146688 RVA: 0x0092D840 File Offset: 0x0092BA40
		// (set) Token: 0x06023D01 RID: 146689 RVA: 0x0092D850 File Offset: 0x0092BA50
		public unsafe bool IsGetCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x06023D02 RID: 146690 RVA: 0x0092D861 File Offset: 0x0092BA61
		// (set) Token: 0x06023D03 RID: 146691 RVA: 0x0092D871 File Offset: 0x0092BA71
		public unsafe bool bHideInLowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x06023D04 RID: 146692 RVA: 0x0092D882 File Offset: 0x0092BA82
		// (set) Token: 0x06023D05 RID: 146693 RVA: 0x0092D892 File Offset: 0x0092BA92
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x06023D06 RID: 146694 RVA: 0x0092D8A3 File Offset: 0x0092BAA3
		// (set) Token: 0x06023D07 RID: 146695 RVA: 0x0092D8B3 File Offset: 0x0092BAB3
		public unsafe float GridCellSizeInMeters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x06023D08 RID: 146696 RVA: 0x0092D8C4 File Offset: 0x0092BAC4
		// (set) Token: 0x06023D09 RID: 146697 RVA: 0x0092D8D8 File Offset: 0x0092BAD8
		public unsafe FVectorDouble WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x06023D0A RID: 146698 RVA: 0x0092D8ED File Offset: 0x0092BAED
		// (set) Token: 0x06023D0B RID: 146699 RVA: 0x0092D901 File Offset: 0x0092BB01
		public unsafe FVectorDouble PreWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x06023D0C RID: 146700 RVA: 0x0092D916 File Offset: 0x0092BB16
		// (set) Token: 0x06023D0D RID: 146701 RVA: 0x0092D926 File Offset: 0x0092BB26
		public unsafe int FilterStateID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x06023D0E RID: 146702 RVA: 0x0092D937 File Offset: 0x0092BB37
		// (set) Token: 0x06023D0F RID: 146703 RVA: 0x0092D94B File Offset: 0x0092BB4B
		public unsafe FVectorDouble LastWeaponInteractionPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MarchCubes_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06023D10 RID: 146704 RVA: 0x0092D960 File Offset: 0x0092BB60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023D11 RID: 146705 RVA: 0x0092D974 File Offset: 0x0092BB74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MarchCubes_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023D12 RID: 146706 RVA: 0x0092D98C File Offset: 0x0092BB8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MarchCubes_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MarchCubes_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D13 RID: 146707 RVA: 0x0092D9D4 File Offset: 0x0092BBD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MarchCubes_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MarchCubes_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MarchCubes_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023D14 RID: 146708 RVA: 0x0092DA1C File Offset: 0x0092BC1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D15 RID: 146709 RVA: 0x0092DAD8 File Offset: 0x0092BCD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D16 RID: 146710 RVA: 0x0092DB61 File Offset: 0x0092BD61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06023D17 RID: 146711 RVA: 0x0092DB78 File Offset: 0x0092BD78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_MarchCubes_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_MarchCubes_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D18 RID: 146712 RVA: 0x0092DBDC File Offset: 0x0092BDDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D19 RID: 146713 RVA: 0x0092DC98 File Offset: 0x0092BE98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MarchCubes_C.__BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023D1A RID: 146714 RVA: 0x0092DD21 File Offset: 0x0092BF21
		protected BP_MarchCubes_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B41 RID: 72513
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/BP_MarchCubes.BP_MarchCubes_C";

		// Token: 0x04011B42 RID: 72514
		private static IntPtr _ClassPtr;

		// Token: 0x04011B43 RID: 72515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B44 RID: 72516
		internal static int __PropertyOffset_1;

		// Token: 0x04011B45 RID: 72517
		internal static int __PropertyOffset_2;

		// Token: 0x04011B46 RID: 72518
		internal static int __PropertyOffset_3;

		// Token: 0x04011B47 RID: 72519
		internal static int __PropertyOffset_4;

		// Token: 0x04011B48 RID: 72520
		internal static int __PropertyOffset_5;

		// Token: 0x04011B49 RID: 72521
		internal static int __PropertyOffset_6;

		// Token: 0x04011B4A RID: 72522
		internal static int __PropertyOffset_7;

		// Token: 0x04011B4B RID: 72523
		internal static int __PropertyOffset_8;

		// Token: 0x04011B4C RID: 72524
		internal static int __PropertyOffset_9;

		// Token: 0x04011B4D RID: 72525
		internal static int __PropertyOffset_10;

		// Token: 0x04011B4E RID: 72526
		internal static int __PropertyOffset_11;

		// Token: 0x04011B4F RID: 72527
		internal static int __PropertyOffset_12;

		// Token: 0x04011B50 RID: 72528
		internal static int __PropertyOffset_13;

		// Token: 0x04011B51 RID: 72529
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011B52 RID: 72530
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011B53 RID: 72531
		private static IntPtr __BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011B54 RID: 72532
		private static IntPtr __BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011B55 RID: 72533
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04011B56 RID: 72534
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04011B57 RID: 72535
		private static IntPtr __BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011B58 RID: 72536
		private static IntPtr __BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EA7 RID: 40615
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403176E RID: 202606
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EA8 RID: 40616
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403176F RID: 202607
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031770 RID: 202608
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031771 RID: 202609
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031772 RID: 202610
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031773 RID: 202611
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031774 RID: 202612
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EA9 RID: 40617
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__marchCubes_CharaEnter_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031775 RID: 202613
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031776 RID: 202614
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031777 RID: 202615
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031778 RID: 202616
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009EAA RID: 40618
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031779 RID: 202617
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403177A RID: 202618
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403177B RID: 202619
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009EAB RID: 40619
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403177C RID: 202620
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403177D RID: 202621
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403177E RID: 202622
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403177F RID: 202623
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031780 RID: 202624
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031781 RID: 202625
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EAC RID: 40620
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_MarchCubes_EnterTheAttackRange_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031782 RID: 202626
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031783 RID: 202627
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031784 RID: 202628
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031785 RID: 202629
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
