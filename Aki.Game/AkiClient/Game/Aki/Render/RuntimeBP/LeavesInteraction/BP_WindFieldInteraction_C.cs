using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CFB RID: 15611
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WindFieldInteraction.BP_WindFieldInteraction_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1768)]
	public class BP_WindFieldInteraction_C : AKuroWindFieldInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025468 RID: 152680 RVA: 0x00955BE4 File Offset: 0x00953DE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WindFieldInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WindFieldInteraction.BP_WindFieldInteraction_C");
			}
			return BP_WindFieldInteraction_C._ClassPtr;
		}

		// Token: 0x06025469 RID: 152681 RVA: 0x00955C08 File Offset: 0x00953E08
		public BP_WindFieldInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_WindFieldInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602546A RID: 152682 RVA: 0x00955C30 File Offset: 0x00953E30
		[NullableContext(1)]
		public BP_WindFieldInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WindFieldInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x0602546B RID: 152683 RVA: 0x00955C63 File Offset: 0x00953E63
		// (set) Token: 0x0602546C RID: 152684 RVA: 0x00955C77 File Offset: 0x00953E77
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x0602546D RID: 152685 RVA: 0x00955C8C File Offset: 0x00953E8C
		// (set) Token: 0x0602546E RID: 152686 RVA: 0x00955CA0 File Offset: 0x00953EA0
		public unsafe UNiagaraComponent NS_WindField
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x0602546F RID: 152687 RVA: 0x00955CB5 File Offset: 0x00953EB5
		// (set) Token: 0x06025470 RID: 152688 RVA: 0x00955CC9 File Offset: 0x00953EC9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x06025471 RID: 152689 RVA: 0x00955CDE File Offset: 0x00953EDE
		// (set) Token: 0x06025472 RID: 152690 RVA: 0x00955CF2 File Offset: 0x00953EF2
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x06025473 RID: 152691 RVA: 0x00955D07 File Offset: 0x00953F07
		// (set) Token: 0x06025474 RID: 152692 RVA: 0x00955D1B File Offset: 0x00953F1B
		public unsafe UMaterialParameterCollection Leaves_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindFieldInteraction_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x06025475 RID: 152693 RVA: 0x00955D30 File Offset: 0x00953F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMotorcycleData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__UpdateMotorcycleData_NativeFunctionPtr, null);
		}

		// Token: 0x06025476 RID: 152694 RVA: 0x00955D44 File Offset: 0x00953F44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetWeaponPosition(FVector Position, int Type)
		{
			BP_WindFieldInteraction_C.__SetWeaponPosition_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__SetWeaponPosition_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__SetWeaponPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__SetWeaponPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			ptr->Type = Type;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__SetWeaponPosition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025477 RID: 152695 RVA: 0x00955D91 File Offset: 0x00953F91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06025478 RID: 152696 RVA: 0x00955DA8 File Offset: 0x00953FA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ForceFieldDara(BP_SceneBattleInteract_C config)
		{
			BP_WindFieldInteraction_C.__ForceFieldDara_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__ForceFieldDara_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__ForceFieldDara_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__ForceFieldDara_NativeFunctionPtr, (void*)ptr, 1);
			ptr->config = ((config != null) ? config.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__ForceFieldDara_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025479 RID: 152697 RVA: 0x00955DFD File Offset: 0x00953FFD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWeaponData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__UpdateWeaponData_NativeFunctionPtr, null);
		}

		// Token: 0x0602547A RID: 152698 RVA: 0x00955E14 File Offset: 0x00954014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParam(float dt)
		{
			BP_WindFieldInteraction_C.__UpdateParam_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__UpdateParam_FunctionParams[(UIntPtr)783] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__UpdateParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__UpdateParam_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602547B RID: 152699 RVA: 0x00955E5D File Offset: 0x0095405D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602547C RID: 152700 RVA: 0x00955E71 File Offset: 0x00954071
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindFieldInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602547D RID: 152701 RVA: 0x00955E86 File Offset: 0x00954086
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602547E RID: 152702 RVA: 0x00955E9A File Offset: 0x0095409A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindFieldInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602547F RID: 152703 RVA: 0x00955EB0 File Offset: 0x009540B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025480 RID: 152704 RVA: 0x00955EF8 File Offset: 0x009540F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindFieldInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025481 RID: 152705 RVA: 0x00955F40 File Offset: 0x00954140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_WindFieldInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_WindFieldInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WindFieldInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindFieldInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindFieldInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025482 RID: 152706 RVA: 0x00955FA3 File Offset: 0x009541A3
		protected BP_WindFieldInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401294B RID: 76107
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WindFieldInteraction.BP_WindFieldInteraction_C";

		// Token: 0x0401294C RID: 76108
		private static IntPtr _ClassPtr;

		// Token: 0x0401294D RID: 76109
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401294E RID: 76110
		internal static int __PropertyOffset_1;

		// Token: 0x0401294F RID: 76111
		internal static int __PropertyOffset_2;

		// Token: 0x04012950 RID: 76112
		internal static int __PropertyOffset_3;

		// Token: 0x04012951 RID: 76113
		internal static int __PropertyOffset_4;

		// Token: 0x04012952 RID: 76114
		internal static int __PropertyOffset_5;

		// Token: 0x04012953 RID: 76115
		private static IntPtr __UpdateMotorcycleData_NativeFunctionPtr;

		// Token: 0x04012954 RID: 76116
		private static IntPtr __SetWeaponPosition_NativeFunctionPtr;

		// Token: 0x04012955 RID: 76117
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x04012956 RID: 76118
		private static IntPtr __ForceFieldDara_NativeFunctionPtr;

		// Token: 0x04012957 RID: 76119
		private static IntPtr __UpdateWeaponData_NativeFunctionPtr;

		// Token: 0x04012958 RID: 76120
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04012959 RID: 76121
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401295A RID: 76122
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401295B RID: 76123
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401295C RID: 76124
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009FDC RID: 40924
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetWeaponPosition_FunctionParams
		{
			// Token: 0x04031A63 RID: 203363
			[FieldOffset(0)]
			public FVector Position;

			// Token: 0x04031A64 RID: 203364
			[FieldOffset(12)]
			public int Type;
		}

		// Token: 0x02009FDD RID: 40925
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ForceFieldDara_FunctionParams
		{
			// Token: 0x04031A65 RID: 203365
			[FieldOffset(0)]
			public IntPtr config;
		}

		// Token: 0x02009FDE RID: 40926
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 768)]
		protected ref struct __UpdateParam_FunctionParams
		{
			// Token: 0x04031A66 RID: 203366
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009FDF RID: 40927
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A67 RID: 203367
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FE0 RID: 40928
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031A68 RID: 203368
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A69 RID: 203369
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A6A RID: 203370
			[FieldOffset(32)]
			public int Id;
		}
	}
}
