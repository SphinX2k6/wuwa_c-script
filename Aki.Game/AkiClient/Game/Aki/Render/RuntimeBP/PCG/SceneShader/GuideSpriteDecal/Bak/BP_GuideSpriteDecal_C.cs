using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.GuideSpriteDecal.Bak
{
	// Token: 0x02003C07 RID: 15367
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal.BP_GuideSpriteDecal_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1562)]
	public class BP_GuideSpriteDecal_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602306D RID: 143469 RVA: 0x00918908 File Offset: 0x00916B08
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GuideSpriteDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal.BP_GuideSpriteDecal_C");
			}
			return BP_GuideSpriteDecal_C._ClassPtr;
		}

		// Token: 0x0602306E RID: 143470 RVA: 0x0091892C File Offset: 0x00916B2C
		public BP_GuideSpriteDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602306F RID: 143471 RVA: 0x00918954 File Offset: 0x00916B54
		[NullableContext(1)]
		public BP_GuideSpriteDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GuideSpriteDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x06023070 RID: 143472 RVA: 0x00918987 File Offset: 0x00916B87
		// (set) Token: 0x06023071 RID: 143473 RVA: 0x0091899B File Offset: 0x00916B9B
		public unsafe UBoxComponent TriggerBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x06023072 RID: 143474 RVA: 0x009189B0 File Offset: 0x00916BB0
		// (set) Token: 0x06023073 RID: 143475 RVA: 0x009189C4 File Offset: 0x00916BC4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x06023074 RID: 143476 RVA: 0x009189D9 File Offset: 0x00916BD9
		// (set) Token: 0x06023075 RID: 143477 RVA: 0x009189ED File Offset: 0x00916BED
		public unsafe FVector Collision_Box_Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x06023076 RID: 143478 RVA: 0x00918A02 File Offset: 0x00916C02
		// (set) Token: 0x06023077 RID: 143479 RVA: 0x00918A12 File Offset: 0x00916C12
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x06023078 RID: 143480 RVA: 0x00918A23 File Offset: 0x00916C23
		// (set) Token: 0x06023079 RID: 143481 RVA: 0x00918A33 File Offset: 0x00916C33
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0602307A RID: 143482 RVA: 0x00918A44 File Offset: 0x00916C44
		// (set) Token: 0x0602307B RID: 143483 RVA: 0x00918A54 File Offset: 0x00916C54
		public unsafe bool bShouldMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0602307C RID: 143484 RVA: 0x00918A65 File Offset: 0x00916C65
		// (set) Token: 0x0602307D RID: 143485 RVA: 0x00918A75 File Offset: 0x00916C75
		public unsafe float Progress_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0602307E RID: 143486 RVA: 0x00918A86 File Offset: 0x00916C86
		// (set) Token: 0x0602307F RID: 143487 RVA: 0x00918A9B File Offset: 0x00916C9B
		[Nullable(1)]
		public TSoftObjectPtr<ADecalActor> Decal
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ADecalActor>(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_8, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x06023080 RID: 143488 RVA: 0x00918AC0 File Offset: 0x00916CC0
		// (set) Token: 0x06023081 RID: 143489 RVA: 0x00918AD4 File Offset: 0x00916CD4
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GuideSpriteDecal_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x06023082 RID: 143490 RVA: 0x00918AE9 File Offset: 0x00916CE9
		// (set) Token: 0x06023083 RID: 143491 RVA: 0x00918AF9 File Offset: 0x00916CF9
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x06023084 RID: 143492 RVA: 0x00918B0A File Offset: 0x00916D0A
		// (set) Token: 0x06023085 RID: 143493 RVA: 0x00918B1A File Offset: 0x00916D1A
		public unsafe bool Debug_One
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GuideSpriteDecal_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023086 RID: 143494 RVA: 0x00918B2B File Offset: 0x00916D2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06023087 RID: 143495 RVA: 0x00918B3F File Offset: 0x00916D3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_ProgressSeconds()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__Set_ProgressSeconds_NativeFunctionPtr, null);
		}

		// Token: 0x06023088 RID: 143496 RVA: 0x00918B53 File Offset: 0x00916D53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023089 RID: 143497 RVA: 0x00918B67 File Offset: 0x00916D67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602308A RID: 143498 RVA: 0x00918B7C File Offset: 0x00916D7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927(UObject Loaded)
		{
			BP_GuideSpriteDecal_C.__OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602308B RID: 143499 RVA: 0x00918BD1 File Offset: 0x00916DD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602308C RID: 143500 RVA: 0x00918BE5 File Offset: 0x00916DE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602308D RID: 143501 RVA: 0x00918BFC File Offset: 0x00916DFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602308E RID: 143502 RVA: 0x00918C44 File Offset: 0x00916E44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602308F RID: 143503 RVA: 0x00918C8C File Offset: 0x00916E8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023090 RID: 143504 RVA: 0x00918CD4 File Offset: 0x00916ED4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_GuideSpriteDecal_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023091 RID: 143505 RVA: 0x00918D1C File Offset: 0x00916F1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023092 RID: 143506 RVA: 0x00918DD8 File Offset: 0x00916FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GuideSpriteDecal_C.__BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023093 RID: 143507 RVA: 0x00918E61 File Offset: 0x00917061
		protected BP_GuideSpriteDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113FA RID: 70650
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/GuideSpriteDecal/Bak/BP_GuideSpriteDecal.BP_GuideSpriteDecal_C";

		// Token: 0x040113FB RID: 70651
		private static IntPtr _ClassPtr;

		// Token: 0x040113FC RID: 70652
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113FD RID: 70653
		internal static int __PropertyOffset_1;

		// Token: 0x040113FE RID: 70654
		internal static int __PropertyOffset_2;

		// Token: 0x040113FF RID: 70655
		internal static int __PropertyOffset_3;

		// Token: 0x04011400 RID: 70656
		internal static int __PropertyOffset_4;

		// Token: 0x04011401 RID: 70657
		internal static int __PropertyOffset_5;

		// Token: 0x04011402 RID: 70658
		internal static int __PropertyOffset_6;

		// Token: 0x04011403 RID: 70659
		internal static int __PropertyOffset_7;

		// Token: 0x04011404 RID: 70660
		internal static int __PropertyOffset_8;

		// Token: 0x04011405 RID: 70661
		internal static int __PropertyOffset_9;

		// Token: 0x04011406 RID: 70662
		internal static int __PropertyOffset_10;

		// Token: 0x04011407 RID: 70663
		internal static int __PropertyOffset_11;

		// Token: 0x04011408 RID: 70664
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04011409 RID: 70665
		private static IntPtr __Set_ProgressSeconds_NativeFunctionPtr;

		// Token: 0x0401140A RID: 70666
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401140B RID: 70667
		private static IntPtr __OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_NativeFunctionPtr;

		// Token: 0x0401140C RID: 70668
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401140D RID: 70669
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401140E RID: 70670
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401140F RID: 70671
		private static IntPtr __BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011410 RID: 70672
		private static IntPtr __BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E01 RID: 40449
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_367A92FD4EA8FCCD11F1B3BEAC615927_FunctionParams
		{
			// Token: 0x04031620 RID: 202272
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02009E02 RID: 40450
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031621 RID: 202273
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E03 RID: 40451
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031622 RID: 202274
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E04 RID: 40452
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_3_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031623 RID: 202275
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031624 RID: 202276
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031625 RID: 202277
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031626 RID: 202278
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031627 RID: 202279
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031628 RID: 202280
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E05 RID: 40453
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_GuideSprote_TriggerBox_K2Node_ComponentBoundEvent_4_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031629 RID: 202281
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403162A RID: 202282
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403162B RID: 202283
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403162C RID: 202284
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
