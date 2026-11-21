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
	// Token: 0x020030DC RID: 12508
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class BP_SnowThawWater_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_DayNightEvent_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E332 RID: 123698 RVA: 0x0090DB1B File Offset: 0x0090BD1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowThawWater_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C");
			}
			return BP_SnowThawWater_C._ClassPtr;
		}

		// Token: 0x0601E333 RID: 123699 RVA: 0x0090DB40 File Offset: 0x0090BD40
		public BP_SnowThawWater_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowThawWater_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E334 RID: 123700 RVA: 0x0090DB68 File Offset: 0x0090BD68
		[NullableContext(1)]
		public BP_SnowThawWater_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowThawWater_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0601E335 RID: 123701 RVA: 0x0090DB9B File Offset: 0x0090BD9B
		// (set) Token: 0x0601E336 RID: 123702 RVA: 0x0090DBAF File Offset: 0x0090BDAF
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0601E337 RID: 123703 RVA: 0x0090DBC4 File Offset: 0x0090BDC4
		// (set) Token: 0x0601E338 RID: 123704 RVA: 0x0090DBD8 File Offset: 0x0090BDD8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0601E339 RID: 123705 RVA: 0x0090DBED File Offset: 0x0090BDED
		// (set) Token: 0x0601E33A RID: 123706 RVA: 0x0090DC01 File Offset: 0x0090BE01
		public unsafe UStaticMesh SnowStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_SnowStaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_SnowStaticMesh, value);
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0601E33B RID: 123707 RVA: 0x0090DC16 File Offset: 0x0090BE16
		// (set) Token: 0x0601E33C RID: 123708 RVA: 0x0090DC26 File Offset: 0x0090BE26
		public unsafe float SM_SinkHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_SM_SinkHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_SM_SinkHeight) = value;
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0601E33D RID: 123709 RVA: 0x0090DC37 File Offset: 0x0090BE37
		// (set) Token: 0x0601E33E RID: 123710 RVA: 0x0090DC4B File Offset: 0x0090BE4B
		public unsafe FVectorDouble OriginalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_OriginalPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_OriginalPosition) = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0601E33F RID: 123711 RVA: 0x0090DC60 File Offset: 0x0090BE60
		// (set) Token: 0x0601E340 RID: 123712 RVA: 0x0090DC70 File Offset: 0x0090BE70
		public unsafe bool IsFirstInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_IsFirstInit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_IsFirstInit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0601E341 RID: 123713 RVA: 0x0090DC81 File Offset: 0x0090BE81
		// (set) Token: 0x0601E342 RID: 123714 RVA: 0x0090DC91 File Offset: 0x0090BE91
		public unsafe float StartZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_StartZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_StartZ) = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0601E343 RID: 123715 RVA: 0x0090DCA2 File Offset: 0x0090BEA2
		// (set) Token: 0x0601E344 RID: 123716 RVA: 0x0090DCB2 File Offset: 0x0090BEB2
		public unsafe float TargetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_TargetZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_TargetZ) = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0601E345 RID: 123717 RVA: 0x0090DCC3 File Offset: 0x0090BEC3
		// (set) Token: 0x0601E346 RID: 123718 RVA: 0x0090DCD3 File Offset: 0x0090BED3
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_Progress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_Progress) = value;
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0601E347 RID: 123719 RVA: 0x0090DCE4 File Offset: 0x0090BEE4
		// (set) Token: 0x0601E348 RID: 123720 RVA: 0x0090DCF4 File Offset: 0x0090BEF4
		public unsafe bool StartEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_StartEditorTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowThawWater_C.__PropertyOffset_StartEditorTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0601E349 RID: 123721 RVA: 0x0090DD05 File Offset: 0x0090BF05
		// (set) Token: 0x0601E34A RID: 123722 RVA: 0x0090DD19 File Offset: 0x0090BF19
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_DMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowThawWater_C.__PropertyOffset_DMI, value);
			}
		}

		// Token: 0x0601E34B RID: 123723 RVA: 0x0090DD2E File Offset: 0x0090BF2E
		[SkipLocalsInit]
		public virtual void Set_DMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Set_DMI_NativeFunctionPtr, null);
		}

		// Token: 0x0601E34C RID: 123724 RVA: 0x0090DD42 File Offset: 0x0090BF42
		[SkipLocalsInit]
		public virtual void Debug_Night()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Debug_Night_NativeFunctionPtr, null);
		}

		// Token: 0x0601E34D RID: 123725 RVA: 0x0090DD56 File Offset: 0x0090BF56
		[SkipLocalsInit]
		public virtual void Debug_Day()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__Debug_Day_NativeFunctionPtr, null);
		}

		// Token: 0x0601E34E RID: 123726 RVA: 0x0090DD6A File Offset: 0x0090BF6A
		[SkipLocalsInit]
		public virtual void SetOriginalPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__SetOriginalPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0601E34F RID: 123727 RVA: 0x0090DD7E File Offset: 0x0090BF7E
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E350 RID: 123728 RVA: 0x0090DD92 File Offset: 0x0090BF92
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E351 RID: 123729 RVA: 0x0090DDA8 File Offset: 0x0090BFA8
		[SkipLocalsInit]
		public unsafe virtual void UpdateSculptureHeight(bool IsDay)
		{
			BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__UpdateSculptureHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__UpdateSculptureHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDay = IsDay;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__UpdateSculptureHeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E352 RID: 123730 RVA: 0x0090DDEE File Offset: 0x0090BFEE
		[SkipLocalsInit]
		public virtual void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E353 RID: 123731 RVA: 0x0090DE02 File Offset: 0x0090C002
		[SkipLocalsInit]
		public virtual void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E354 RID: 123732 RVA: 0x0090DE16 File Offset: 0x0090C016
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E355 RID: 123733 RVA: 0x0090DE2A File Offset: 0x0090C02A
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E356 RID: 123734 RVA: 0x0090DE40 File Offset: 0x0090C040
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E357 RID: 123735 RVA: 0x0090DE8C File Offset: 0x0090C08C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E358 RID: 123736 RVA: 0x0090DED8 File Offset: 0x0090C0D8
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E359 RID: 123737 RVA: 0x0090DF20 File Offset: 0x0090C120
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E35A RID: 123738 RVA: 0x0090DF68 File Offset: 0x0090C168
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E35B RID: 123739 RVA: 0x0090DFB0 File Offset: 0x0090C1B0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowThawWater_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowThawWater_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowThawWater_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowThawWater_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E35C RID: 123740 RVA: 0x0090DFF6 File Offset: 0x0090C1F6
		protected BP_SnowThawWater_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFA3 RID: 65443
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/IceSnowThawWater/BP_SnowThawWater.BP_SnowThawWater_C";

		// Token: 0x0400FFA4 RID: 65444
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFA5 RID: 65445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFA6 RID: 65446
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FFA7 RID: 65447
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FFA8 RID: 65448
		internal static int __PropertyOffset_SnowStaticMesh;

		// Token: 0x0400FFA9 RID: 65449
		internal static int __PropertyOffset_SM_SinkHeight;

		// Token: 0x0400FFAA RID: 65450
		internal static int __PropertyOffset_OriginalPosition;

		// Token: 0x0400FFAB RID: 65451
		internal static int __PropertyOffset_IsFirstInit;

		// Token: 0x0400FFAC RID: 65452
		internal static int __PropertyOffset_StartZ;

		// Token: 0x0400FFAD RID: 65453
		internal static int __PropertyOffset_TargetZ;

		// Token: 0x0400FFAE RID: 65454
		internal static int __PropertyOffset_Progress;

		// Token: 0x0400FFAF RID: 65455
		internal static int __PropertyOffset_StartEditorTick;

		// Token: 0x0400FFB0 RID: 65456
		internal static int __PropertyOffset_DMI;

		// Token: 0x0400FFB1 RID: 65457
		private static IntPtr __Set_DMI_NativeFunctionPtr;

		// Token: 0x0400FFB2 RID: 65458
		private static IntPtr __Debug_Night_NativeFunctionPtr;

		// Token: 0x0400FFB3 RID: 65459
		private static IntPtr __Debug_Day_NativeFunctionPtr;

		// Token: 0x0400FFB4 RID: 65460
		private static IntPtr __SetOriginalPosition_NativeFunctionPtr;

		// Token: 0x0400FFB5 RID: 65461
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FFB6 RID: 65462
		private static IntPtr __UpdateSculptureHeight_NativeFunctionPtr;

		// Token: 0x0400FFB7 RID: 65463
		private static IntPtr __OnEnterDay_NativeFunctionPtr;

		// Token: 0x0400FFB8 RID: 65464
		private static IntPtr __OnEnterNight_NativeFunctionPtr;

		// Token: 0x0400FFB9 RID: 65465
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FFBA RID: 65466
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FFBB RID: 65467
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FFBC RID: 65468
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008E3C RID: 36412
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UpdateSculptureHeight_FunctionParams
		{
			// Token: 0x0402CA7D RID: 182909
			[FieldOffset(0)]
			public bool IsDay;
		}

		// Token: 0x02008E3D RID: 36413
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CA7E RID: 182910
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02008E3E RID: 36414
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA7F RID: 182911
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E3F RID: 36415
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA80 RID: 182912
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
