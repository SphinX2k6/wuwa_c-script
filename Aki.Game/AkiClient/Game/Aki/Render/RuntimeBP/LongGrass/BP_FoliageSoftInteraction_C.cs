using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LongGrass
{
	// Token: 0x02003CF0 RID: 15600
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LongGrass/BP_FoliageSoftInteraction.BP_FoliageSoftInteraction_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1525)]
	public class BP_FoliageSoftInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060252DE RID: 152286 RVA: 0x009531F1 File Offset: 0x009513F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FoliageSoftInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LongGrass/BP_FoliageSoftInteraction.BP_FoliageSoftInteraction_C");
			}
			return BP_FoliageSoftInteraction_C._ClassPtr;
		}

		// Token: 0x060252DF RID: 152287 RVA: 0x00953218 File Offset: 0x00951418
		public BP_FoliageSoftInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FoliageSoftInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252E0 RID: 152288 RVA: 0x00953240 File Offset: 0x00951440
		[NullableContext(1)]
		public BP_FoliageSoftInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FoliageSoftInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x060252E1 RID: 152289 RVA: 0x00953273 File Offset: 0x00951473
		// (set) Token: 0x060252E2 RID: 152290 RVA: 0x00953287 File Offset: 0x00951487
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x060252E3 RID: 152291 RVA: 0x0095329C File Offset: 0x0095149C
		// (set) Token: 0x060252E4 RID: 152292 RVA: 0x009532B0 File Offset: 0x009514B0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x060252E5 RID: 152293 RVA: 0x009532C5 File Offset: 0x009514C5
		// (set) Token: 0x060252E6 RID: 152294 RVA: 0x009532D9 File Offset: 0x009514D9
		public unsafe AActor TestActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x060252E7 RID: 152295 RVA: 0x009532EE File Offset: 0x009514EE
		// (set) Token: 0x060252E8 RID: 152296 RVA: 0x00953302 File Offset: 0x00951502
		public unsafe FVector PlayerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x060252E9 RID: 152297 RVA: 0x00953317 File Offset: 0x00951517
		// (set) Token: 0x060252EA RID: 152298 RVA: 0x00953327 File Offset: 0x00951527
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x060252EB RID: 152299 RVA: 0x00953338 File Offset: 0x00951538
		// (set) Token: 0x060252EC RID: 152300 RVA: 0x0095334C File Offset: 0x0095154C
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x060252ED RID: 152301 RVA: 0x00953361 File Offset: 0x00951561
		// (set) Token: 0x060252EE RID: 152302 RVA: 0x00953375 File Offset: 0x00951575
		public unsafe UMaterialParameterCollection Scene_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoliageSoftInteraction_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x060252EF RID: 152303 RVA: 0x0095338A File Offset: 0x0095158A
		// (set) Token: 0x060252F0 RID: 152304 RVA: 0x0095339A File Offset: 0x0095159A
		public unsafe int OtherCharacterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x060252F1 RID: 152305 RVA: 0x009533AB File Offset: 0x009515AB
		// (set) Token: 0x060252F2 RID: 152306 RVA: 0x009533BB File Offset: 0x009515BB
		public unsafe bool DisablePartnerInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FoliageSoftInteraction_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x060252F3 RID: 152307 RVA: 0x009533CC File Offset: 0x009515CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble MainPlayerPos, FVectorDouble OtherPlayerPos, float InteractionSize, ref FVector2D TexCoord)
		{
			BP_FoliageSoftInteraction_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_FoliageSoftInteraction_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_FoliageSoftInteraction_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FoliageSoftInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MainPlayerPos = MainPlayerPos;
			ptr->OtherPlayerPos = OtherPlayerPos;
			ptr->InteractionSize = InteractionSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x060252F4 RID: 152308 RVA: 0x0095343D File Offset: 0x0095163D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060252F5 RID: 152309 RVA: 0x00953451 File Offset: 0x00951651
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252F6 RID: 152310 RVA: 0x00953468 File Offset: 0x00951668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FoliageSoftInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252F7 RID: 152311 RVA: 0x009534B0 File Offset: 0x009516B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FoliageSoftInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FoliageSoftInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252F8 RID: 152312 RVA: 0x009534F8 File Offset: 0x009516F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FoliageSoftInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252F9 RID: 152313 RVA: 0x00953540 File Offset: 0x00951740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FoliageSoftInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FoliageSoftInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252FA RID: 152314 RVA: 0x00953587 File Offset: 0x00951787
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060252FB RID: 152315 RVA: 0x0095359B File Offset: 0x0095179B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FoliageSoftInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252FC RID: 152316 RVA: 0x009535B0 File Offset: 0x009517B0
		protected BP_FoliageSoftInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012849 RID: 75849
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LongGrass/BP_FoliageSoftInteraction.BP_FoliageSoftInteraction_C";

		// Token: 0x0401284A RID: 75850
		private static IntPtr _ClassPtr;

		// Token: 0x0401284B RID: 75851
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401284C RID: 75852
		internal static int __PropertyOffset_1;

		// Token: 0x0401284D RID: 75853
		internal static int __PropertyOffset_2;

		// Token: 0x0401284E RID: 75854
		internal static int __PropertyOffset_3;

		// Token: 0x0401284F RID: 75855
		internal static int __PropertyOffset_4;

		// Token: 0x04012850 RID: 75856
		internal static int __PropertyOffset_5;

		// Token: 0x04012851 RID: 75857
		internal static int __PropertyOffset_6;

		// Token: 0x04012852 RID: 75858
		internal static int __PropertyOffset_7;

		// Token: 0x04012853 RID: 75859
		internal static int __PropertyOffset_8;

		// Token: 0x04012854 RID: 75860
		internal static int __PropertyOffset_9;

		// Token: 0x04012855 RID: 75861
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x04012856 RID: 75862
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012857 RID: 75863
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012858 RID: 75864
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012859 RID: 75865
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009FC0 RID: 40896
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031A23 RID: 203299
			[FieldOffset(0)]
			public FVectorDouble MainPlayerPos;

			// Token: 0x04031A24 RID: 203300
			[FieldOffset(24)]
			public FVectorDouble OtherPlayerPos;

			// Token: 0x04031A25 RID: 203301
			[FieldOffset(48)]
			public float InteractionSize;

			// Token: 0x04031A26 RID: 203302
			[FieldOffset(52)]
			public FVector2D TexCoord;
		}

		// Token: 0x02009FC1 RID: 40897
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A27 RID: 203303
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FC2 RID: 40898
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A28 RID: 203304
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
