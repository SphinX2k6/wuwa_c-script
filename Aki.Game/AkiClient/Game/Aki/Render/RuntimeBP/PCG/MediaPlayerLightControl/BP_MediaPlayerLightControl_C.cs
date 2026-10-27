using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MediaPlayerLightControl
{
	// Token: 0x02003C52 RID: 15442
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1508)]
	public class BP_MediaPlayerLightControl_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06023CD6 RID: 146646 RVA: 0x0092D32C File Offset: 0x0092B52C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MediaPlayerLightControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C");
			}
			return BP_MediaPlayerLightControl_C._ClassPtr;
		}

		// Token: 0x06023CD7 RID: 146647 RVA: 0x0092D350 File Offset: 0x0092B550
		public BP_MediaPlayerLightControl_C() : this(BuiltinUtils.AllocNativeUObject(BP_MediaPlayerLightControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CD8 RID: 146648 RVA: 0x0092D378 File Offset: 0x0092B578
		[NullableContext(1)]
		public BP_MediaPlayerLightControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MediaPlayerLightControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x06023CD9 RID: 146649 RVA: 0x0092D3AB File Offset: 0x0092B5AB
		// (set) Token: 0x06023CDA RID: 146650 RVA: 0x0092D3BF File Offset: 0x0092B5BF
		public unsafe UTextRenderComponent Play
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x06023CDB RID: 146651 RVA: 0x0092D3D4 File Offset: 0x0092B5D4
		// (set) Token: 0x06023CDC RID: 146652 RVA: 0x0092D3E8 File Offset: 0x0092B5E8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x06023CDD RID: 146653 RVA: 0x0092D3FD File Offset: 0x0092B5FD
		// (set) Token: 0x06023CDE RID: 146654 RVA: 0x0092D411 File Offset: 0x0092B611
		public unsafe ULevelSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x06023CDF RID: 146655 RVA: 0x0092D426 File Offset: 0x0092B626
		// (set) Token: 0x06023CE0 RID: 146656 RVA: 0x0092D436 File Offset: 0x0092B636
		public unsafe bool SequenceDebugCanvas
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x06023CE1 RID: 146657 RVA: 0x0092D447 File Offset: 0x0092B647
		// (set) Token: 0x06023CE2 RID: 146658 RVA: 0x0092D45B File Offset: 0x0092B65B
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaPlayerLightControl_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x06023CE3 RID: 146659 RVA: 0x0092D470 File Offset: 0x0092B670
		// (set) Token: 0x06023CE4 RID: 146660 RVA: 0x0092D484 File Offset: 0x0092B684
		public unsafe FVector World_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaPlayerLightControl_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06023CE5 RID: 146661 RVA: 0x0092D49C File Offset: 0x0092B69C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x06023CE6 RID: 146662 RVA: 0x0092D4EC File Offset: 0x0092B6EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x06023CE7 RID: 146663 RVA: 0x0092D53B File Offset: 0x0092B73B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x06023CE8 RID: 146664 RVA: 0x0092D54F File Offset: 0x0092B74F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06023CE9 RID: 146665 RVA: 0x0092D563 File Offset: 0x0092B763
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x06023CEA RID: 146666 RVA: 0x0092D577 File Offset: 0x0092B777
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x06023CEB RID: 146667 RVA: 0x0092D58B File Offset: 0x0092B78B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x06023CEC RID: 146668 RVA: 0x0092D59F File Offset: 0x0092B79F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023CED RID: 146669 RVA: 0x0092D5B3 File Offset: 0x0092B7B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023CEE RID: 146670 RVA: 0x0092D5C8 File Offset: 0x0092B7C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CEF RID: 146671 RVA: 0x0092D610 File Offset: 0x0092B810
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023CF0 RID: 146672 RVA: 0x0092D658 File Offset: 0x0092B858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CF1 RID: 146673 RVA: 0x0092D6A4 File Offset: 0x0092B8A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaPlayerLightControl_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023CF2 RID: 146674 RVA: 0x0092D6F0 File Offset: 0x0092B8F0
		protected BP_MediaPlayerLightControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B2E RID: 72494
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MediaPlayerLightControl/BP_MediaPlayerLightControl.BP_MediaPlayerLightControl_C";

		// Token: 0x04011B2F RID: 72495
		private static IntPtr _ClassPtr;

		// Token: 0x04011B30 RID: 72496
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B31 RID: 72497
		internal static int __PropertyOffset_1;

		// Token: 0x04011B32 RID: 72498
		internal static int __PropertyOffset_2;

		// Token: 0x04011B33 RID: 72499
		internal static int __PropertyOffset_3;

		// Token: 0x04011B34 RID: 72500
		internal static int __PropertyOffset_4;

		// Token: 0x04011B35 RID: 72501
		internal static int __PropertyOffset_5;

		// Token: 0x04011B36 RID: 72502
		internal static int __PropertyOffset_6;

		// Token: 0x04011B37 RID: 72503
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04011B38 RID: 72504
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04011B39 RID: 72505
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04011B3A RID: 72506
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04011B3B RID: 72507
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04011B3C RID: 72508
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04011B3D RID: 72509
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04011B3E RID: 72510
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011B3F RID: 72511
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011B40 RID: 72512
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009EA3 RID: 40611
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0403176A RID: 202602
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009EA4 RID: 40612
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0403176B RID: 202603
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02009EA5 RID: 40613
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403176C RID: 202604
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EA6 RID: 40614
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403176D RID: 202605
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
