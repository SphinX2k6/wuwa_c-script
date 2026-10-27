using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LongGrass
{
	// Token: 0x02003CF1 RID: 15601
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LongGrass/BP_IceMotoInteraction.BP_IceMotoInteraction_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1676)]
	public class BP_IceMotoInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060252FD RID: 152317 RVA: 0x009535B9 File Offset: 0x009517B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_IceMotoInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LongGrass/BP_IceMotoInteraction.BP_IceMotoInteraction_C");
			}
			return BP_IceMotoInteraction_C._ClassPtr;
		}

		// Token: 0x060252FE RID: 152318 RVA: 0x009535E0 File Offset: 0x009517E0
		public BP_IceMotoInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_IceMotoInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252FF RID: 152319 RVA: 0x00953608 File Offset: 0x00951808
		[NullableContext(1)]
		public BP_IceMotoInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_IceMotoInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x06025300 RID: 152320 RVA: 0x0095363B File Offset: 0x0095183B
		// (set) Token: 0x06025301 RID: 152321 RVA: 0x0095364F File Offset: 0x0095184F
		public unsafe UStaticMeshComponent MotoIce
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x06025302 RID: 152322 RVA: 0x00953664 File Offset: 0x00951864
		// (set) Token: 0x06025303 RID: 152323 RVA: 0x00953678 File Offset: 0x00951878
		public unsafe UBoxComponent AreaBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x06025304 RID: 152324 RVA: 0x0095368D File Offset: 0x0095188D
		// (set) Token: 0x06025305 RID: 152325 RVA: 0x009536A1 File Offset: 0x009518A1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x06025306 RID: 152326 RVA: 0x009536B6 File Offset: 0x009518B6
		// (set) Token: 0x06025307 RID: 152327 RVA: 0x009536CA File Offset: 0x009518CA
		public unsafe UTextureRenderTarget2D RT_PosA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x06025308 RID: 152328 RVA: 0x009536DF File Offset: 0x009518DF
		// (set) Token: 0x06025309 RID: 152329 RVA: 0x009536F3 File Offset: 0x009518F3
		public unsafe UTextureRenderTarget2D RT_PosB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x0602530A RID: 152330 RVA: 0x00953708 File Offset: 0x00951908
		// (set) Token: 0x0602530B RID: 152331 RVA: 0x0095371C File Offset: 0x0095191C
		public unsafe UMaterialInstanceDynamic MID_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x0602530C RID: 152332 RVA: 0x00953731 File Offset: 0x00951931
		// (set) Token: 0x0602530D RID: 152333 RVA: 0x00953745 File Offset: 0x00951945
		public unsafe UMaterialInstanceDynamic MID_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceMotoInteraction_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x0602530E RID: 152334 RVA: 0x0095375A File Offset: 0x0095195A
		// (set) Token: 0x0602530F RID: 152335 RVA: 0x0095376A File Offset: 0x0095196A
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x06025310 RID: 152336 RVA: 0x0095377B File Offset: 0x0095197B
		// (set) Token: 0x06025311 RID: 152337 RVA: 0x0095378B File Offset: 0x0095198B
		public unsafe float Attenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x06025312 RID: 152338 RVA: 0x0095379C File Offset: 0x0095199C
		// (set) Token: 0x06025313 RID: 152339 RVA: 0x009537B0 File Offset: 0x009519B0
		public unsafe FLinearColor Clear_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x06025314 RID: 152340 RVA: 0x009537C5 File Offset: 0x009519C5
		// (set) Token: 0x06025315 RID: 152341 RVA: 0x009537D9 File Offset: 0x009519D9
		public unsafe FVectorDouble PlayerPixelPos_Curr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x06025316 RID: 152342 RVA: 0x009537EE File Offset: 0x009519EE
		// (set) Token: 0x06025317 RID: 152343 RVA: 0x00953802 File Offset: 0x00951A02
		public unsafe FVectorDouble PlayerPixelPos_Prev
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x06025318 RID: 152344 RVA: 0x00953817 File Offset: 0x00951A17
		// (set) Token: 0x06025319 RID: 152345 RVA: 0x0095382B File Offset: 0x00951A2B
		public unsafe FVectorDouble CurrFrontWheel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x0602531A RID: 152346 RVA: 0x00953840 File Offset: 0x00951A40
		// (set) Token: 0x0602531B RID: 152347 RVA: 0x00953854 File Offset: 0x00951A54
		public unsafe FVectorDouble CurrBackWheel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x0602531C RID: 152348 RVA: 0x00953869 File Offset: 0x00951A69
		// (set) Token: 0x0602531D RID: 152349 RVA: 0x0095387D File Offset: 0x00951A7D
		public unsafe FVectorDouble PrevFrontWheel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x0602531E RID: 152350 RVA: 0x00953892 File Offset: 0x00951A92
		// (set) Token: 0x0602531F RID: 152351 RVA: 0x009538A6 File Offset: 0x00951AA6
		public unsafe FVectorDouble PrevBackWheel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x06025320 RID: 152352 RVA: 0x009538BB File Offset: 0x00951ABB
		// (set) Token: 0x06025321 RID: 152353 RVA: 0x009538CB File Offset: 0x00951ACB
		public unsafe float BulletRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceMotoInteraction_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x06025322 RID: 152354 RVA: 0x009538DC File Offset: 0x00951ADC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble MainPlayerPos, FVectorDouble OtherPlayerPos, float InteractionSize, ref float TexCoord_X, ref float TexCoord_Y)
		{
			BP_IceMotoInteraction_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_IceMotoInteraction_C.__CalcTexCoord_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_IceMotoInteraction_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceMotoInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MainPlayerPos = MainPlayerPos;
			ptr->OtherPlayerPos = OtherPlayerPos;
			ptr->InteractionSize = InteractionSize;
			ptr->TexCoord_X = TexCoord_X;
			ptr->TexCoord_Y = TexCoord_Y;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord_X = ptr->TexCoord_X;
			TexCoord_Y = ptr->TexCoord_Y;
		}

		// Token: 0x06025323 RID: 152355 RVA: 0x00953958 File Offset: 0x00951B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcDistance2D(FVectorDouble V1, FVectorDouble V2, ref double Distance)
		{
			BP_IceMotoInteraction_C.__CalcDistance2D_FunctionParams* ptr = stackalloc BP_IceMotoInteraction_C.__CalcDistance2D_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_IceMotoInteraction_C.__CalcDistance2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceMotoInteraction_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V1 = V1;
			ptr->V2 = V2;
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr);
			Distance = ptr->Distance;
		}

		// Token: 0x06025324 RID: 152356 RVA: 0x009539B8 File Offset: 0x00951BB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x06025325 RID: 152357 RVA: 0x009539CC File Offset: 0x00951BCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_MID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__Create_MID_NativeFunctionPtr, null);
		}

		// Token: 0x06025326 RID: 152358 RVA: 0x009539E0 File Offset: 0x00951BE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025327 RID: 152359 RVA: 0x009539F4 File Offset: 0x00951BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025328 RID: 152360 RVA: 0x00953A0C File Offset: 0x00951C0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceMotoInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025329 RID: 152361 RVA: 0x00953A54 File Offset: 0x00951C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_IceMotoInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceMotoInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602532A RID: 152362 RVA: 0x00953A9B File Offset: 0x00951C9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRenderTarget()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__ClearRenderTarget_NativeFunctionPtr, null);
		}

		// Token: 0x0602532B RID: 152363 RVA: 0x00953AAF File Offset: 0x00951CAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PrintPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceMotoInteraction_C.__PrintPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0602532C RID: 152364 RVA: 0x00953AC3 File Offset: 0x00951CC3
		protected BP_IceMotoInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401285A RID: 75866
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LongGrass/BP_IceMotoInteraction.BP_IceMotoInteraction_C";

		// Token: 0x0401285B RID: 75867
		private static IntPtr _ClassPtr;

		// Token: 0x0401285C RID: 75868
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401285D RID: 75869
		internal static int __PropertyOffset_1;

		// Token: 0x0401285E RID: 75870
		internal static int __PropertyOffset_2;

		// Token: 0x0401285F RID: 75871
		internal static int __PropertyOffset_3;

		// Token: 0x04012860 RID: 75872
		internal static int __PropertyOffset_4;

		// Token: 0x04012861 RID: 75873
		internal static int __PropertyOffset_5;

		// Token: 0x04012862 RID: 75874
		internal static int __PropertyOffset_6;

		// Token: 0x04012863 RID: 75875
		internal static int __PropertyOffset_7;

		// Token: 0x04012864 RID: 75876
		internal static int __PropertyOffset_8;

		// Token: 0x04012865 RID: 75877
		internal static int __PropertyOffset_9;

		// Token: 0x04012866 RID: 75878
		internal static int __PropertyOffset_10;

		// Token: 0x04012867 RID: 75879
		internal static int __PropertyOffset_11;

		// Token: 0x04012868 RID: 75880
		internal static int __PropertyOffset_12;

		// Token: 0x04012869 RID: 75881
		internal static int __PropertyOffset_13;

		// Token: 0x0401286A RID: 75882
		internal static int __PropertyOffset_14;

		// Token: 0x0401286B RID: 75883
		internal static int __PropertyOffset_15;

		// Token: 0x0401286C RID: 75884
		internal static int __PropertyOffset_16;

		// Token: 0x0401286D RID: 75885
		internal static int __PropertyOffset_17;

		// Token: 0x0401286E RID: 75886
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0401286F RID: 75887
		private static IntPtr __CalcDistance2D_NativeFunctionPtr;

		// Token: 0x04012870 RID: 75888
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x04012871 RID: 75889
		private static IntPtr __Create_MID_NativeFunctionPtr;

		// Token: 0x04012872 RID: 75890
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012873 RID: 75891
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012874 RID: 75892
		private static IntPtr __ClearRenderTarget_NativeFunctionPtr;

		// Token: 0x04012875 RID: 75893
		private static IntPtr __PrintPosition_NativeFunctionPtr;

		// Token: 0x02009FC3 RID: 40899
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031A29 RID: 203305
			[FieldOffset(0)]
			public FVectorDouble MainPlayerPos;

			// Token: 0x04031A2A RID: 203306
			[FieldOffset(24)]
			public FVectorDouble OtherPlayerPos;

			// Token: 0x04031A2B RID: 203307
			[FieldOffset(48)]
			public float InteractionSize;

			// Token: 0x04031A2C RID: 203308
			[FieldOffset(52)]
			public float TexCoord_X;

			// Token: 0x04031A2D RID: 203309
			[FieldOffset(56)]
			public float TexCoord_Y;
		}

		// Token: 0x02009FC4 RID: 40900
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __CalcDistance2D_FunctionParams
		{
			// Token: 0x04031A2E RID: 203310
			[FieldOffset(0)]
			public FVectorDouble V1;

			// Token: 0x04031A2F RID: 203311
			[FieldOffset(24)]
			public FVectorDouble V2;

			// Token: 0x04031A30 RID: 203312
			[FieldOffset(48)]
			public double Distance;
		}

		// Token: 0x02009FC5 RID: 40901
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A31 RID: 203313
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
