using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PlantGrowth
{
	// Token: 0x02003C32 RID: 15410
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PlantGrowth/BP_PlantGrowthController.BP_PlantGrowthController_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_PlantGrowthController_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060236C5 RID: 145093 RVA: 0x00923856 File Offset: 0x00921A56
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantGrowthController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PlantGrowth/BP_PlantGrowthController.BP_PlantGrowthController_C");
			}
			return BP_PlantGrowthController_C._ClassPtr;
		}

		// Token: 0x060236C6 RID: 145094 RVA: 0x0092387C File Offset: 0x00921A7C
		public BP_PlantGrowthController_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060236C7 RID: 145095 RVA: 0x009238A4 File Offset: 0x00921AA4
		[NullableContext(1)]
		public BP_PlantGrowthController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantGrowthController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x060236C8 RID: 145096 RVA: 0x009238D7 File Offset: 0x00921AD7
		// (set) Token: 0x060236C9 RID: 145097 RVA: 0x009238EB File Offset: 0x00921AEB
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x060236CA RID: 145098 RVA: 0x00923900 File Offset: 0x00921B00
		// (set) Token: 0x060236CB RID: 145099 RVA: 0x00923914 File Offset: 0x00921B14
		public unsafe UChildActorComponent EditorCharacterPosition
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x060236CC RID: 145100 RVA: 0x00923929 File Offset: 0x00921B29
		// (set) Token: 0x060236CD RID: 145101 RVA: 0x0092393D File Offset: 0x00921B3D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantGrowthController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x060236CE RID: 145102 RVA: 0x00923952 File Offset: 0x00921B52
		// (set) Token: 0x060236CF RID: 145103 RVA: 0x00923962 File Offset: 0x00921B62
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x060236D0 RID: 145104 RVA: 0x00923973 File Offset: 0x00921B73
		// (set) Token: 0x060236D1 RID: 145105 RVA: 0x00923983 File Offset: 0x00921B83
		public unsafe float MaxDistanceLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x060236D2 RID: 145106 RVA: 0x00923994 File Offset: 0x00921B94
		// (set) Token: 0x060236D3 RID: 145107 RVA: 0x009239A8 File Offset: 0x00921BA8
		public unsafe FVector AreaExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x060236D4 RID: 145108 RVA: 0x009239BD File Offset: 0x00921BBD
		// (set) Token: 0x060236D5 RID: 145109 RVA: 0x009239CD File Offset: 0x00921BCD
		public unsafe bool RuntimePreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x060236D6 RID: 145110 RVA: 0x009239DE File Offset: 0x00921BDE
		// (set) Token: 0x060236D7 RID: 145111 RVA: 0x009239F2 File Offset: 0x00921BF2
		public unsafe FVectorDouble CharacterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x060236D8 RID: 145112 RVA: 0x00923A07 File Offset: 0x00921C07
		// (set) Token: 0x060236D9 RID: 145113 RVA: 0x00923A17 File Offset: 0x00921C17
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x060236DA RID: 145114 RVA: 0x00923A28 File Offset: 0x00921C28
		// (set) Token: 0x060236DB RID: 145115 RVA: 0x00923A38 File Offset: 0x00921C38
		public unsafe float TimeBySeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantGrowthController_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060236DC RID: 145116 RVA: 0x00923A49 File Offset: 0x00921C49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060236DD RID: 145117 RVA: 0x00923A5D File Offset: 0x00921C5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060236DE RID: 145118 RVA: 0x00923A72 File Offset: 0x00921C72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060236DF RID: 145119 RVA: 0x00923A86 File Offset: 0x00921C86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060236E0 RID: 145120 RVA: 0x00923A9C File Offset: 0x00921C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PlantGrowthController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060236E1 RID: 145121 RVA: 0x00923AE4 File Offset: 0x00921CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PlantGrowthController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PlantGrowthController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060236E2 RID: 145122 RVA: 0x00923B2C File Offset: 0x00921D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PlantGrowthController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PlantGrowthController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060236E3 RID: 145123 RVA: 0x00923B74 File Offset: 0x00921D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PlantGrowthController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PlantGrowthController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PlantGrowthController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantGrowthController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060236E4 RID: 145124 RVA: 0x00923BBB File Offset: 0x00921DBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060236E5 RID: 145125 RVA: 0x00923BCF File Offset: 0x00921DCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantGrowthController_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060236E6 RID: 145126 RVA: 0x00923BE4 File Offset: 0x00921DE4
		protected BP_PlantGrowthController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117BC RID: 71612
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PlantGrowth/BP_PlantGrowthController.BP_PlantGrowthController_C";

		// Token: 0x040117BD RID: 71613
		private static IntPtr _ClassPtr;

		// Token: 0x040117BE RID: 71614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117BF RID: 71615
		internal static int __PropertyOffset_1;

		// Token: 0x040117C0 RID: 71616
		internal static int __PropertyOffset_2;

		// Token: 0x040117C1 RID: 71617
		internal static int __PropertyOffset_3;

		// Token: 0x040117C2 RID: 71618
		internal static int __PropertyOffset_4;

		// Token: 0x040117C3 RID: 71619
		internal static int __PropertyOffset_5;

		// Token: 0x040117C4 RID: 71620
		internal static int __PropertyOffset_6;

		// Token: 0x040117C5 RID: 71621
		internal static int __PropertyOffset_7;

		// Token: 0x040117C6 RID: 71622
		internal static int __PropertyOffset_8;

		// Token: 0x040117C7 RID: 71623
		internal static int __PropertyOffset_9;

		// Token: 0x040117C8 RID: 71624
		internal static int __PropertyOffset_10;

		// Token: 0x040117C9 RID: 71625
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040117CA RID: 71626
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040117CB RID: 71627
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040117CC RID: 71628
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040117CD RID: 71629
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009E6A RID: 40554
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316F0 RID: 202480
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E6B RID: 40555
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316F1 RID: 202481
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
