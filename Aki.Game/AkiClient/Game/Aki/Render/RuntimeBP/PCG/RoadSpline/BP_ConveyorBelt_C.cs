using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C22 RID: 15394
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt.BP_ConveyorBelt_C")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1617)]
	public class BP_ConveyorBelt_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060234A4 RID: 144548 RVA: 0x0091FFC0 File Offset: 0x0091E1C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ConveyorBelt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt.BP_ConveyorBelt_C");
			}
			return BP_ConveyorBelt_C._ClassPtr;
		}

		// Token: 0x060234A5 RID: 144549 RVA: 0x0091FFE4 File Offset: 0x0091E1E4
		public BP_ConveyorBelt_C() : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234A6 RID: 144550 RVA: 0x0092000C File Offset: 0x0091E20C
		[NullableContext(1)]
		public BP_ConveyorBelt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x060234A7 RID: 144551 RVA: 0x0092003F File Offset: 0x0091E23F
		// (set) Token: 0x060234A8 RID: 144552 RVA: 0x00920053 File Offset: 0x0091E253
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x060234A9 RID: 144553 RVA: 0x00920068 File Offset: 0x0091E268
		// (set) Token: 0x060234AA RID: 144554 RVA: 0x0092007C File Offset: 0x0091E27C
		public unsafe UStaticMeshComponent StaticMesh1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x060234AB RID: 144555 RVA: 0x00920091 File Offset: 0x0091E291
		// (set) Token: 0x060234AC RID: 144556 RVA: 0x009200A5 File Offset: 0x0091E2A5
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x060234AD RID: 144557 RVA: 0x009200BA File Offset: 0x0091E2BA
		// (set) Token: 0x060234AE RID: 144558 RVA: 0x009200CE File Offset: 0x0091E2CE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x060234AF RID: 144559 RVA: 0x009200E3 File Offset: 0x0091E2E3
		// (set) Token: 0x060234B0 RID: 144560 RVA: 0x009200F7 File Offset: 0x0091E2F7
		public unsafe UStaticMesh New_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x060234B1 RID: 144561 RVA: 0x0092010C File Offset: 0x0091E30C
		// (set) Token: 0x060234B2 RID: 144562 RVA: 0x0092011C File Offset: 0x0091E31C
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x060234B3 RID: 144563 RVA: 0x0092012D File Offset: 0x0091E32D
		// (set) Token: 0x060234B4 RID: 144564 RVA: 0x0092013D File Offset: 0x0091E33D
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x060234B5 RID: 144565 RVA: 0x0092014E File Offset: 0x0091E34E
		// (set) Token: 0x060234B6 RID: 144566 RVA: 0x0092015E File Offset: 0x0091E35E
		public unsafe float DeltaOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x060234B7 RID: 144567 RVA: 0x0092016F File Offset: 0x0091E36F
		// (set) Token: 0x060234B8 RID: 144568 RVA: 0x0092017F File Offset: 0x0091E37F
		public unsafe bool Restart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x060234B9 RID: 144569 RVA: 0x00920190 File Offset: 0x0091E390
		// (set) Token: 0x060234BA RID: 144570 RVA: 0x009201C9 File Offset: 0x0091E3C9
		[Nullable(1)]
		public TMap<UStaticMeshComponent, bool> MeshState
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMeshComponent, bool> result;
				if ((result = this._MeshState) == null)
				{
					result = (this._MeshState = new TMap<UStaticMeshComponent, bool>(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MeshState.CopyAssign(value);
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x060234BB RID: 144571 RVA: 0x009201D7 File Offset: 0x0091E3D7
		// (set) Token: 0x060234BC RID: 144572 RVA: 0x009201E7 File Offset: 0x0091E3E7
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x060234BD RID: 144573 RVA: 0x009201F8 File Offset: 0x0091E3F8
		// (set) Token: 0x060234BE RID: 144574 RVA: 0x0092020C File Offset: 0x0091E40C
		public unsafe FVector New_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x060234BF RID: 144575 RVA: 0x00920221 File Offset: 0x0091E421
		// (set) Token: 0x060234C0 RID: 144576 RVA: 0x00920231 File Offset: 0x0091E431
		public unsafe bool LastState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x060234C1 RID: 144577 RVA: 0x00920242 File Offset: 0x0091E442
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NewFunction_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__NewFunction_0_NativeFunctionPtr, null);
		}

		// Token: 0x060234C2 RID: 144578 RVA: 0x00920256 File Offset: 0x0091E456
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__DisableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060234C3 RID: 144579 RVA: 0x0092026A File Offset: 0x0091E46A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__EnableTick_NativeFunctionPtr, null);
		}

		// Token: 0x060234C4 RID: 144580 RVA: 0x0092027E File Offset: 0x0091E47E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060234C5 RID: 144581 RVA: 0x00920292 File Offset: 0x0091E492
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060234C6 RID: 144582 RVA: 0x009202A8 File Offset: 0x0091E4A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234C7 RID: 144583 RVA: 0x00920331 File Offset: 0x0091E531
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060234C8 RID: 144584 RVA: 0x00920345 File Offset: 0x0091E545
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060234C9 RID: 144585 RVA: 0x0092035C File Offset: 0x0091E55C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234CA RID: 144586 RVA: 0x009203A4 File Offset: 0x0091E5A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060234CB RID: 144587 RVA: 0x009203EC File Offset: 0x0091E5EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234CC RID: 144588 RVA: 0x009204A8 File Offset: 0x0091E6A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060234CD RID: 144589 RVA: 0x009204F0 File Offset: 0x0091E6F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060234CE RID: 144590 RVA: 0x00920537 File Offset: 0x0091E737
		protected BP_ConveyorBelt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401167D RID: 71293
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_ConveyorBelt.BP_ConveyorBelt_C";

		// Token: 0x0401167E RID: 71294
		private static IntPtr _ClassPtr;

		// Token: 0x0401167F RID: 71295
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011680 RID: 71296
		internal static int __PropertyOffset_1;

		// Token: 0x04011681 RID: 71297
		internal static int __PropertyOffset_2;

		// Token: 0x04011682 RID: 71298
		internal static int __PropertyOffset_3;

		// Token: 0x04011683 RID: 71299
		internal static int __PropertyOffset_4;

		// Token: 0x04011684 RID: 71300
		internal static int __PropertyOffset_5;

		// Token: 0x04011685 RID: 71301
		internal static int __PropertyOffset_6;

		// Token: 0x04011686 RID: 71302
		internal static int __PropertyOffset_7;

		// Token: 0x04011687 RID: 71303
		internal static int __PropertyOffset_8;

		// Token: 0x04011688 RID: 71304
		internal static int __PropertyOffset_9;

		// Token: 0x04011689 RID: 71305
		internal static int __PropertyOffset_10;

		// Token: 0x0401168A RID: 71306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UStaticMeshComponent, bool> _MeshState;

		// Token: 0x0401168B RID: 71307
		internal static int __PropertyOffset_11;

		// Token: 0x0401168C RID: 71308
		internal static int __PropertyOffset_12;

		// Token: 0x0401168D RID: 71309
		internal static int __PropertyOffset_13;

		// Token: 0x0401168E RID: 71310
		private static IntPtr __NewFunction_0_NativeFunctionPtr;

		// Token: 0x0401168F RID: 71311
		private static IntPtr __DisableTick_NativeFunctionPtr;

		// Token: 0x04011690 RID: 71312
		private static IntPtr __EnableTick_NativeFunctionPtr;

		// Token: 0x04011691 RID: 71313
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011692 RID: 71314
		private static IntPtr __BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011693 RID: 71315
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011694 RID: 71316
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011695 RID: 71317
		private static IntPtr __BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011696 RID: 71318
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E4E RID: 40526
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316C0 RID: 202432
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316C1 RID: 202433
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316C2 RID: 202434
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316C3 RID: 202435
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009E4F RID: 40527
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316C4 RID: 202436
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E50 RID: 40528
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_ConveyorBelt_Box_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316C5 RID: 202437
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316C6 RID: 202438
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316C7 RID: 202439
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316C8 RID: 202440
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040316C9 RID: 202441
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040316CA RID: 202442
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E51 RID: 40529
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316CB RID: 202443
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
