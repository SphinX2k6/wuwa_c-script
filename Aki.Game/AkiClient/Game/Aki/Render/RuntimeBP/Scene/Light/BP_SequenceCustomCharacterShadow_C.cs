using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B17 RID: 15127
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceCustomCharacterShadow.BP_SequenceCustomCharacterShadow_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_SequenceCustomCharacterShadow_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021104 RID: 135428 RVA: 0x008E3F61 File Offset: 0x008E2161
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceCustomCharacterShadow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceCustomCharacterShadow.BP_SequenceCustomCharacterShadow_C");
			}
			return BP_SequenceCustomCharacterShadow_C._ClassPtr;
		}

		// Token: 0x06021105 RID: 135429 RVA: 0x008E3F88 File Offset: 0x008E2188
		public BP_SequenceCustomCharacterShadow_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceCustomCharacterShadow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021106 RID: 135430 RVA: 0x008E3FB0 File Offset: 0x008E21B0
		[NullableContext(1)]
		public BP_SequenceCustomCharacterShadow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceCustomCharacterShadow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x06021107 RID: 135431 RVA: 0x008E3FE3 File Offset: 0x008E21E3
		// (set) Token: 0x06021108 RID: 135432 RVA: 0x008E3FF7 File Offset: 0x008E21F7
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x06021109 RID: 135433 RVA: 0x008E400C File Offset: 0x008E220C
		// (set) Token: 0x0602110A RID: 135434 RVA: 0x008E4020 File Offset: 0x008E2220
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0602110B RID: 135435 RVA: 0x008E4035 File Offset: 0x008E2235
		// (set) Token: 0x0602110C RID: 135436 RVA: 0x008E4045 File Offset: 0x008E2245
		public unsafe float EvolutionaryRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0602110D RID: 135437 RVA: 0x008E4056 File Offset: 0x008E2256
		// (set) Token: 0x0602110E RID: 135438 RVA: 0x008E4066 File Offset: 0x008E2266
		public unsafe float EvolutionaryIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0602110F RID: 135439 RVA: 0x008E4077 File Offset: 0x008E2277
		// (set) Token: 0x06021110 RID: 135440 RVA: 0x008E4087 File Offset: 0x008E2287
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x06021111 RID: 135441 RVA: 0x008E4098 File Offset: 0x008E2298
		// (set) Token: 0x06021112 RID: 135442 RVA: 0x008E40AC File Offset: 0x008E22AC
		public unsafe UMaterialInstanceDynamic MDY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x06021113 RID: 135443 RVA: 0x008E40C1 File Offset: 0x008E22C1
		// (set) Token: 0x06021114 RID: 135444 RVA: 0x008E40D5 File Offset: 0x008E22D5
		public unsafe UTexture2D MaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x06021115 RID: 135445 RVA: 0x008E40EA File Offset: 0x008E22EA
		// (set) Token: 0x06021116 RID: 135446 RVA: 0x008E40FA File Offset: 0x008E22FA
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceCustomCharacterShadow_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x06021117 RID: 135447 RVA: 0x008E410B File Offset: 0x008E230B
		// (set) Token: 0x06021118 RID: 135448 RVA: 0x008E411F File Offset: 0x008E231F
		public unsafe UTexture2D FlowMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceCustomCharacterShadow_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x06021119 RID: 135449 RVA: 0x008E4134 File Offset: 0x008E2334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetCustomShadowParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__SetCustomShadowParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602111A RID: 135450 RVA: 0x008E4148 File Offset: 0x008E2348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602111B RID: 135451 RVA: 0x008E415C File Offset: 0x008E235C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602111C RID: 135452 RVA: 0x008E4171 File Offset: 0x008E2371
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602111D RID: 135453 RVA: 0x008E4185 File Offset: 0x008E2385
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602111E RID: 135454 RVA: 0x008E419C File Offset: 0x008E239C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceCustomCharacterShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602111F RID: 135455 RVA: 0x008E41E4 File Offset: 0x008E23E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceCustomCharacterShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceCustomCharacterShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021120 RID: 135456 RVA: 0x008E422C File Offset: 0x008E242C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceCustomCharacterShadow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021121 RID: 135457 RVA: 0x008E4274 File Offset: 0x008E2474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceCustomCharacterShadow_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceCustomCharacterShadow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceCustomCharacterShadow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021122 RID: 135458 RVA: 0x008E42BB File Offset: 0x008E24BB
		protected BP_SequenceCustomCharacterShadow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401015B RID: 65883
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceCustomCharacterShadow.BP_SequenceCustomCharacterShadow_C";

		// Token: 0x0401015C RID: 65884
		private static IntPtr _ClassPtr;

		// Token: 0x0401015D RID: 65885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401015E RID: 65886
		internal static int __PropertyOffset_1;

		// Token: 0x0401015F RID: 65887
		internal static int __PropertyOffset_2;

		// Token: 0x04010160 RID: 65888
		internal static int __PropertyOffset_3;

		// Token: 0x04010161 RID: 65889
		internal static int __PropertyOffset_4;

		// Token: 0x04010162 RID: 65890
		internal static int __PropertyOffset_5;

		// Token: 0x04010163 RID: 65891
		internal static int __PropertyOffset_6;

		// Token: 0x04010164 RID: 65892
		internal static int __PropertyOffset_7;

		// Token: 0x04010165 RID: 65893
		internal static int __PropertyOffset_8;

		// Token: 0x04010166 RID: 65894
		internal static int __PropertyOffset_9;

		// Token: 0x04010167 RID: 65895
		private static IntPtr __SetCustomShadowParameter_NativeFunctionPtr;

		// Token: 0x04010168 RID: 65896
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010169 RID: 65897
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401016A RID: 65898
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401016B RID: 65899
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C69 RID: 40041
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031327 RID: 201511
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C6A RID: 40042
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031328 RID: 201512
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
