using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1C RID: 15644
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_SpaceStationScreen.BP_SpaceStationScreen_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class BP_SpaceStationScreen_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060258E3 RID: 153827 RVA: 0x0095D01D File Offset: 0x0095B21D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpaceStationScreen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_SpaceStationScreen.BP_SpaceStationScreen_C");
			}
			return BP_SpaceStationScreen_C._ClassPtr;
		}

		// Token: 0x060258E4 RID: 153828 RVA: 0x0095D044 File Offset: 0x0095B244
		public BP_SpaceStationScreen_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpaceStationScreen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060258E5 RID: 153829 RVA: 0x0095D06C File Offset: 0x0095B26C
		[NullableContext(1)]
		public BP_SpaceStationScreen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpaceStationScreen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x060258E6 RID: 153830 RVA: 0x0095D09F File Offset: 0x0095B29F
		// (set) Token: 0x060258E7 RID: 153831 RVA: 0x0095D0B3 File Offset: 0x0095B2B3
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x060258E8 RID: 153832 RVA: 0x0095D0C8 File Offset: 0x0095B2C8
		// (set) Token: 0x060258E9 RID: 153833 RVA: 0x0095D0DC File Offset: 0x0095B2DC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x060258EA RID: 153834 RVA: 0x0095D0F1 File Offset: 0x0095B2F1
		// (set) Token: 0x060258EB RID: 153835 RVA: 0x0095D105 File Offset: 0x0095B305
		public unsafe UStaticMesh 静态网格体
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x060258EC RID: 153836 RVA: 0x0095D11A File Offset: 0x0095B31A
		// (set) Token: 0x060258ED RID: 153837 RVA: 0x0095D12E File Offset: 0x0095B32E
		public unsafe UMaterialInstanceDynamic DynamicMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceStationScreen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x060258EE RID: 153838 RVA: 0x0095D143 File Offset: 0x0095B343
		// (set) Token: 0x060258EF RID: 153839 RVA: 0x0095D153 File Offset: 0x0095B353
		public unsafe float MasterSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x060258F0 RID: 153840 RVA: 0x0095D164 File Offset: 0x0095B364
		// (set) Token: 0x060258F1 RID: 153841 RVA: 0x0095D174 File Offset: 0x0095B374
		public unsafe float R_BSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x060258F2 RID: 153842 RVA: 0x0095D185 File Offset: 0x0095B385
		// (set) Token: 0x060258F3 RID: 153843 RVA: 0x0095D195 File Offset: 0x0095B395
		public unsafe float AMSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x060258F4 RID: 153844 RVA: 0x0095D1A6 File Offset: 0x0095B3A6
		// (set) Token: 0x060258F5 RID: 153845 RVA: 0x0095D1BA File Offset: 0x0095B3BA
		public unsafe FVector ScreenContent_Tile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x060258F6 RID: 153846 RVA: 0x0095D1CF File Offset: 0x0095B3CF
		// (set) Token: 0x060258F7 RID: 153847 RVA: 0x0095D1E3 File Offset: 0x0095B3E3
		public unsafe FVector ScreenContent_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceStationScreen_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x060258F8 RID: 153848 RVA: 0x0095D1F8 File Offset: 0x0095B3F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceStationScreen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060258F9 RID: 153849 RVA: 0x0095D20C File Offset: 0x0095B40C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpaceStationScreen_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060258FA RID: 153850 RVA: 0x0095D221 File Offset: 0x0095B421
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceStationScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060258FB RID: 153851 RVA: 0x0095D235 File Offset: 0x0095B435
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpaceStationScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060258FC RID: 153852 RVA: 0x0095D24C File Offset: 0x0095B44C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpaceStationScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceStationScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060258FD RID: 153853 RVA: 0x0095D294 File Offset: 0x0095B494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpaceStationScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpaceStationScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpaceStationScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258FE RID: 153854 RVA: 0x0095D2DC File Offset: 0x0095B4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SpaceStationScreen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SpaceStationScreen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpaceStationScreen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpaceStationScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceStationScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060258FF RID: 153855 RVA: 0x0095D324 File Offset: 0x0095B524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SpaceStationScreen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SpaceStationScreen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpaceStationScreen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpaceStationScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpaceStationScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025900 RID: 153856 RVA: 0x0095D36B File Offset: 0x0095B56B
		protected BP_SpaceStationScreen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BF2 RID: 76786
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_SpaceStationScreen.BP_SpaceStationScreen_C";

		// Token: 0x04012BF3 RID: 76787
		private static IntPtr _ClassPtr;

		// Token: 0x04012BF4 RID: 76788
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BF5 RID: 76789
		internal static int __PropertyOffset_1;

		// Token: 0x04012BF6 RID: 76790
		internal static int __PropertyOffset_2;

		// Token: 0x04012BF7 RID: 76791
		internal static int __PropertyOffset_3;

		// Token: 0x04012BF8 RID: 76792
		internal static int __PropertyOffset_4;

		// Token: 0x04012BF9 RID: 76793
		internal static int __PropertyOffset_5;

		// Token: 0x04012BFA RID: 76794
		internal static int __PropertyOffset_6;

		// Token: 0x04012BFB RID: 76795
		internal static int __PropertyOffset_7;

		// Token: 0x04012BFC RID: 76796
		internal static int __PropertyOffset_8;

		// Token: 0x04012BFD RID: 76797
		internal static int __PropertyOffset_9;

		// Token: 0x04012BFE RID: 76798
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012BFF RID: 76799
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012C00 RID: 76800
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012C01 RID: 76801
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A013 RID: 40979
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ABA RID: 203450
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A014 RID: 40980
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031ABB RID: 203451
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
