using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.IceSnowThawWater
{
	// Token: 0x02003C05 RID: 15365
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class BP_SnowThawWater_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_DayNightEvent_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06022FFB RID: 143355 RVA: 0x00917DE5 File Offset: 0x00915FE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowThawWater_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C");
			}
			return BP_SnowThawWater_C._ClassPtr;
		}

		// Token: 0x06022FFC RID: 143356 RVA: 0x00917E0C File Offset: 0x0091600C
		public BP_SnowThawWater_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowThawWater_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022FFD RID: 143357 RVA: 0x00917E34 File Offset: 0x00916034
		[NullableContext(1)]
		public BP_SnowThawWater_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowThawWater_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06022FFE RID: 143358 RVA: 0x00917E67 File Offset: 0x00916067
		// (set) Token: 0x06022FFF RID: 143359 RVA: 0x00917E7B File Offset: 0x0091607B
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x06023000 RID: 143360 RVA: 0x00917E90 File Offset: 0x00916090
		// (set) Token: 0x06023001 RID: 143361 RVA: 0x00917EA4 File Offset: 0x009160A4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x06023002 RID: 143362 RVA: 0x00917EB9 File Offset: 0x009160B9
		// (set) Token: 0x06023003 RID: 143363 RVA: 0x00917ECD File Offset: 0x009160CD
		public unsafe UStaticMesh SnowStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x06023004 RID: 143364 RVA: 0x00917EE2 File Offset: 0x009160E2
		// (set) Token: 0x06023005 RID: 143365 RVA: 0x00917EF2 File Offset: 0x009160F2
		public unsafe float SM_SinkHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x06023006 RID: 143366 RVA: 0x00917F03 File Offset: 0x00916103
		// (set) Token: 0x06023007 RID: 143367 RVA: 0x00917F17 File Offset: 0x00916117
		public unsafe FVectorDouble OriginalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06023008 RID: 143368 RVA: 0x00917F2C File Offset: 0x0091612C
		// (set) Token: 0x06023009 RID: 143369 RVA: 0x00917F3C File Offset: 0x0091613C
		public unsafe bool IsFirstInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x0602300A RID: 143370 RVA: 0x00917F4D File Offset: 0x0091614D
		// (set) Token: 0x0602300B RID: 143371 RVA: 0x00917F5D File Offset: 0x0091615D
		public unsafe float StartZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0602300C RID: 143372 RVA: 0x00917F6E File Offset: 0x0091616E
		// (set) Token: 0x0602300D RID: 143373 RVA: 0x00917F7E File Offset: 0x0091617E
		public unsafe float TargetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0602300E RID: 143374 RVA: 0x00917F8F File Offset: 0x0091618F
		// (set) Token: 0x0602300F RID: 143375 RVA: 0x00917F9F File Offset: 0x0091619F
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x06023010 RID: 143376 RVA: 0x00917FB0 File Offset: 0x009161B0
		// (set) Token: 0x06023011 RID: 143377 RVA: 0x00917FC0 File Offset: 0x009161C0
		public unsafe bool StartEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x06023012 RID: 143378 RVA: 0x00917FD1 File Offset: 0x009161D1
		// (set) Token: 0x06023013 RID: 143379 RVA: 0x00917FE5 File Offset: 0x009161E5
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x06023014 RID: 143380 RVA: 0x00917FFA File Offset: 0x009161FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_DMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Set_DMI_NativeFunctionPtr, null);
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x0091800E File Offset: 0x0091620E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug_Night()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Debug_Night_NativeFunctionPtr, null);
		}

		// Token: 0x06023016 RID: 143382 RVA: 0x00918022 File Offset: 0x00916222
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug_Day()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Debug_Day_NativeFunctionPtr, null);
		}

		// Token: 0x06023017 RID: 143383 RVA: 0x00918036 File Offset: 0x00916236
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetOriginalPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__SetOriginalPosition_NativeFunctionPtr, null);
		}

		// Token: 0x06023018 RID: 143384 RVA: 0x0091804A File Offset: 0x0091624A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023019 RID: 143385 RVA: 0x0091805E File Offset: 0x0091625E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602301A RID: 143386 RVA: 0x00918074 File Offset: 0x00916274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateSculptureHeight(bool IsDay)
		{
			BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__UpdateSculptureHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDay = IsDay;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__UpdateSculptureHeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602301B RID: 143387 RVA: 0x009180BA File Offset: 0x009162BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x0602301C RID: 143388 RVA: 0x009180CE File Offset: 0x009162CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x0602301D RID: 143389 RVA: 0x009180E2 File Offset: 0x009162E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602301E RID: 143390 RVA: 0x009180F6 File Offset: 0x009162F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602301F RID: 143391 RVA: 0x0091810C File Offset: 0x0091630C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023020 RID: 143392 RVA: 0x00918158 File Offset: 0x00916358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023021 RID: 143393 RVA: 0x009181A4 File Offset: 0x009163A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023022 RID: 143394 RVA: 0x009181EC File Offset: 0x009163EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023023 RID: 143395 RVA: 0x00918234 File Offset: 0x00916434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023024 RID: 143396 RVA: 0x0091827C File Offset: 0x0091647C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023025 RID: 143397 RVA: 0x009182C3 File Offset: 0x009164C3
		protected BP_SnowThawWater_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113BB RID: 70587
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C";

		// Token: 0x040113BC RID: 70588
		private static IntPtr _ClassPtr;

		// Token: 0x040113BD RID: 70589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113BE RID: 70590
		internal static int __PropertyOffset_1;

		// Token: 0x040113BF RID: 70591
		internal static int __PropertyOffset_2;

		// Token: 0x040113C0 RID: 70592
		internal static int __PropertyOffset_3;

		// Token: 0x040113C1 RID: 70593
		internal static int __PropertyOffset_4;

		// Token: 0x040113C2 RID: 70594
		internal static int __PropertyOffset_5;

		// Token: 0x040113C3 RID: 70595
		internal static int __PropertyOffset_6;

		// Token: 0x040113C4 RID: 70596
		internal static int __PropertyOffset_7;

		// Token: 0x040113C5 RID: 70597
		internal static int __PropertyOffset_8;

		// Token: 0x040113C6 RID: 70598
		internal static int __PropertyOffset_9;

		// Token: 0x040113C7 RID: 70599
		internal static int __PropertyOffset_10;

		// Token: 0x040113C8 RID: 70600
		internal static int __PropertyOffset_11;

		// Token: 0x040113C9 RID: 70601
		private static IntPtr __Set_DMI_NativeFunctionPtr;

		// Token: 0x040113CA RID: 70602
		private static IntPtr __Debug_Night_NativeFunctionPtr;

		// Token: 0x040113CB RID: 70603
		private static IntPtr __Debug_Day_NativeFunctionPtr;

		// Token: 0x040113CC RID: 70604
		private static IntPtr __SetOriginalPosition_NativeFunctionPtr;

		// Token: 0x040113CD RID: 70605
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040113CE RID: 70606
		private static IntPtr __UpdateSculptureHeight_NativeFunctionPtr;

		// Token: 0x040113CF RID: 70607
		private static IntPtr __OnEnterDay_NativeFunctionPtr;

		// Token: 0x040113D0 RID: 70608
		private static IntPtr __OnEnterNight_NativeFunctionPtr;

		// Token: 0x040113D1 RID: 70609
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040113D2 RID: 70610
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040113D3 RID: 70611
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040113D4 RID: 70612
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009DFB RID: 40443
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UpdateSculptureHeight_FunctionParams
		{
			// Token: 0x0403161A RID: 202266
			[FieldOffset(0)]
			public bool IsDay;
		}

		// Token: 0x02009DFC RID: 40444
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403161B RID: 202267
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009DFD RID: 40445
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403161C RID: 202268
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DFE RID: 40446
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403161D RID: 202269
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
