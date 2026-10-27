using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D15 RID: 15637
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_Harquebus.BP_Harquebus_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_Harquebus_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257C4 RID: 153540 RVA: 0x0095B064 File Offset: 0x00959264
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Harquebus_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_Harquebus.BP_Harquebus_C");
			}
			return BP_Harquebus_C._ClassPtr;
		}

		// Token: 0x060257C5 RID: 153541 RVA: 0x0095B088 File Offset: 0x00959288
		public BP_Harquebus_C() : this(BuiltinUtils.AllocNativeUObject(BP_Harquebus_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257C6 RID: 153542 RVA: 0x0095B0B0 File Offset: 0x009592B0
		[NullableContext(1)]
		public BP_Harquebus_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Harquebus_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x060257C7 RID: 153543 RVA: 0x0095B0E3 File Offset: 0x009592E3
		// (set) Token: 0x060257C8 RID: 153544 RVA: 0x0095B0F7 File Offset: 0x009592F7
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x060257C9 RID: 153545 RVA: 0x0095B10C File Offset: 0x0095930C
		// (set) Token: 0x060257CA RID: 153546 RVA: 0x0095B120 File Offset: 0x00959320
		public unsafe URopeEffectComponent RopeEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeEffectComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x060257CB RID: 153547 RVA: 0x0095B135 File Offset: 0x00959335
		// (set) Token: 0x060257CC RID: 153548 RVA: 0x0095B149 File Offset: 0x00959349
		public unsafe URopeVerletComponent RopeVerlet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x060257CD RID: 153549 RVA: 0x0095B15E File Offset: 0x0095935E
		// (set) Token: 0x060257CE RID: 153550 RVA: 0x0095B172 File Offset: 0x00959372
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x060257CF RID: 153551 RVA: 0x0095B187 File Offset: 0x00959387
		// (set) Token: 0x060257D0 RID: 153552 RVA: 0x0095B19B File Offset: 0x0095939B
		public unsafe URopeVerletDataAsset RopeStaticDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x060257D1 RID: 153553 RVA: 0x0095B1B0 File Offset: 0x009593B0
		// (set) Token: 0x060257D2 RID: 153554 RVA: 0x0095B1C4 File Offset: 0x009593C4
		public unsafe URopeVerletDataAsset RopeDynamicDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x060257D3 RID: 153555 RVA: 0x0095B1D9 File Offset: 0x009593D9
		// (set) Token: 0x060257D4 RID: 153556 RVA: 0x0095B1ED File Offset: 0x009593ED
		public unsafe URopeVerletDataAsset LocalRopeDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x060257D5 RID: 153557 RVA: 0x0095B202 File Offset: 0x00959402
		// (set) Token: 0x060257D6 RID: 153558 RVA: 0x0095B216 File Offset: 0x00959416
		public unsafe UEffectModelNiagara NiagaraDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelNiagara>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Harquebus_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x060257D7 RID: 153559 RVA: 0x0095B22B File Offset: 0x0095942B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置特效DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__设置特效DA_NativeFunctionPtr, null);
		}

		// Token: 0x060257D8 RID: 153560 RVA: 0x0095B23F File Offset: 0x0095943F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置空放DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__设置空放DA_NativeFunctionPtr, null);
		}

		// Token: 0x060257D9 RID: 153561 RVA: 0x0095B253 File Offset: 0x00959453
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置战斗DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__设置战斗DA_NativeFunctionPtr, null);
		}

		// Token: 0x060257DA RID: 153562 RVA: 0x0095B267 File Offset: 0x00959467
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060257DB RID: 153563 RVA: 0x0095B27B File Offset: 0x0095947B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Harquebus_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257DC RID: 153564 RVA: 0x0095B290 File Offset: 0x00959490
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Harquebus_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Harquebus_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Harquebus_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Harquebus_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x0095B2D8 File Offset: 0x009594D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Harquebus_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Harquebus_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Harquebus_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Harquebus_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Harquebus_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x0095B320 File Offset: 0x00959520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Harquebus_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Harquebus_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Harquebus_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Harquebus_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257DF RID: 153567 RVA: 0x0095B368 File Offset: 0x00959568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Harquebus_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Harquebus_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Harquebus_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Harquebus_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Harquebus_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x0095B3AF File Offset: 0x009595AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Harquebus_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x0095B3C3 File Offset: 0x009595C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Harquebus_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257E2 RID: 153570 RVA: 0x0095B3D8 File Offset: 0x009595D8
		protected BP_Harquebus_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B4A RID: 76618
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_Harquebus.BP_Harquebus_C";

		// Token: 0x04012B4B RID: 76619
		private static IntPtr _ClassPtr;

		// Token: 0x04012B4C RID: 76620
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B4D RID: 76621
		internal static int __PropertyOffset_1;

		// Token: 0x04012B4E RID: 76622
		internal static int __PropertyOffset_2;

		// Token: 0x04012B4F RID: 76623
		internal static int __PropertyOffset_3;

		// Token: 0x04012B50 RID: 76624
		internal static int __PropertyOffset_4;

		// Token: 0x04012B51 RID: 76625
		internal static int __PropertyOffset_5;

		// Token: 0x04012B52 RID: 76626
		internal static int __PropertyOffset_6;

		// Token: 0x04012B53 RID: 76627
		internal static int __PropertyOffset_7;

		// Token: 0x04012B54 RID: 76628
		internal static int __PropertyOffset_8;

		// Token: 0x04012B55 RID: 76629
		private static IntPtr __设置特效DA_NativeFunctionPtr;

		// Token: 0x04012B56 RID: 76630
		private static IntPtr __设置空放DA_NativeFunctionPtr;

		// Token: 0x04012B57 RID: 76631
		private static IntPtr __设置战斗DA_NativeFunctionPtr;

		// Token: 0x04012B58 RID: 76632
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B59 RID: 76633
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B5A RID: 76634
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012B5B RID: 76635
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A001 RID: 40961
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A9C RID: 203420
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A002 RID: 40962
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A9D RID: 203421
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
