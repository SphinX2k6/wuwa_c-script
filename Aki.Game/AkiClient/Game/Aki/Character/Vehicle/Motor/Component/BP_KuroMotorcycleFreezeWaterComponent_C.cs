using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Component
{
	// Token: 0x02004060 RID: 16480
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2216)]
	public class BP_KuroMotorcycleFreezeWaterComponent_C : UKuroWaterInteractionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A515 RID: 173333 RVA: 0x009DC8E4 File Offset: 0x009DAAE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroMotorcycleFreezeWaterComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C");
			}
			return BP_KuroMotorcycleFreezeWaterComponent_C._ClassPtr;
		}

		// Token: 0x0602A516 RID: 173334 RVA: 0x009DC908 File Offset: 0x009DAB08
		public BP_KuroMotorcycleFreezeWaterComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroMotorcycleFreezeWaterComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A517 RID: 173335 RVA: 0x009DC930 File Offset: 0x009DAB30
		[NullableContext(1)]
		public BP_KuroMotorcycleFreezeWaterComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroMotorcycleFreezeWaterComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x0602A518 RID: 173336 RVA: 0x009DC963 File Offset: 0x009DAB63
		// (set) Token: 0x0602A519 RID: 173337 RVA: 0x009DC977 File Offset: 0x009DAB77
		public unsafe UTextureRenderTarget2D RT_PosA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x0602A51A RID: 173338 RVA: 0x009DC98C File Offset: 0x009DAB8C
		// (set) Token: 0x0602A51B RID: 173339 RVA: 0x009DC9A0 File Offset: 0x009DABA0
		public unsafe UTextureRenderTarget2D RT_PosB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x0602A51C RID: 173340 RVA: 0x009DC9B5 File Offset: 0x009DABB5
		// (set) Token: 0x0602A51D RID: 173341 RVA: 0x009DC9C9 File Offset: 0x009DABC9
		public unsafe UMaterialInterface M_DrawRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x0602A51E RID: 173342 RVA: 0x009DC9DE File Offset: 0x009DABDE
		// (set) Token: 0x0602A51F RID: 173343 RVA: 0x009DC9F2 File Offset: 0x009DABF2
		public unsafe UMaterialInstanceDynamic MID_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x0602A520 RID: 173344 RVA: 0x009DCA07 File Offset: 0x009DAC07
		// (set) Token: 0x0602A521 RID: 173345 RVA: 0x009DCA1B File Offset: 0x009DAC1B
		public unsafe UMaterialInstanceDynamic MID_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x0602A522 RID: 173346 RVA: 0x009DCA30 File Offset: 0x009DAC30
		// (set) Token: 0x0602A523 RID: 173347 RVA: 0x009DCA44 File Offset: 0x009DAC44
		public unsafe UMaterialInstanceDynamic MID_Ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x0602A524 RID: 173348 RVA: 0x009DCA59 File Offset: 0x009DAC59
		// (set) Token: 0x0602A525 RID: 173349 RVA: 0x009DCA6D File Offset: 0x009DAC6D
		public unsafe FLinearColor Clear_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x0602A526 RID: 173350 RVA: 0x009DCA82 File Offset: 0x009DAC82
		// (set) Token: 0x0602A527 RID: 173351 RVA: 0x009DCA92 File Offset: 0x009DAC92
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x0602A528 RID: 173352 RVA: 0x009DCAA3 File Offset: 0x009DACA3
		// (set) Token: 0x0602A529 RID: 173353 RVA: 0x009DCAB3 File Offset: 0x009DACB3
		public unsafe float Attenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x0602A52A RID: 173354 RVA: 0x009DCAC4 File Offset: 0x009DACC4
		// (set) Token: 0x0602A52B RID: 173355 RVA: 0x009DCAD8 File Offset: 0x009DACD8
		public unsafe FVectorDouble PixelPos_Curr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x0602A52C RID: 173356 RVA: 0x009DCAED File Offset: 0x009DACED
		// (set) Token: 0x0602A52D RID: 173357 RVA: 0x009DCB01 File Offset: 0x009DAD01
		public unsafe FVectorDouble PixelPos_Prev
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x0602A52E RID: 173358 RVA: 0x009DCB16 File Offset: 0x009DAD16
		// (set) Token: 0x0602A52F RID: 173359 RVA: 0x009DCB26 File Offset: 0x009DAD26
		public unsafe bool DetectingWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x0602A530 RID: 173360 RVA: 0x009DCB37 File Offset: 0x009DAD37
		// (set) Token: 0x0602A531 RID: 173361 RVA: 0x009DCB4B File Offset: 0x009DAD4B
		public unsafe UKuroTrailCollisionAsset Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTrailCollisionAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x0602A532 RID: 173362 RVA: 0x009DCB60 File Offset: 0x009DAD60
		// (set) Token: 0x0602A533 RID: 173363 RVA: 0x009DCB74 File Offset: 0x009DAD74
		public unsafe UMaterialInterface M_Ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x0602A534 RID: 173364 RVA: 0x009DCB89 File Offset: 0x009DAD89
		// (set) Token: 0x0602A535 RID: 173365 RVA: 0x009DCB9D File Offset: 0x009DAD9D
		public unsafe FVectorDouble PixelPos_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0602A536 RID: 173366 RVA: 0x009DCBB2 File Offset: 0x009DADB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x0602A537 RID: 173367 RVA: 0x009DCBC6 File Offset: 0x009DADC6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateMID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__CreateMID_NativeFunctionPtr, null);
		}

		// Token: 0x0602A538 RID: 173368 RVA: 0x009DCBDA File Offset: 0x009DADDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A539 RID: 173369 RVA: 0x009DCBEE File Offset: 0x009DADEE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A53A RID: 173370 RVA: 0x009DCC03 File Offset: 0x009DAE03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void HandleWaterDetectedStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A53B RID: 173371 RVA: 0x009DCC17 File Offset: 0x009DAE17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void HandleWaterDetectedStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A53C RID: 173372 RVA: 0x009DCC2C File Offset: 0x009DAE2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void HandleWaterDetectedEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602A53D RID: 173373 RVA: 0x009DCC40 File Offset: 0x009DAE40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void HandleWaterDetectedEnd_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedEnd_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A53E RID: 173374 RVA: 0x009DCC58 File Offset: 0x009DAE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void HandleWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A53F RID: 173375 RVA: 0x009DCCB4 File Offset: 0x009DAEB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void HandleWaterDetectedTick_Implementation(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A540 RID: 173376 RVA: 0x009DCD10 File Offset: 0x009DAF10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A541 RID: 173377 RVA: 0x009DCD58 File Offset: 0x009DAF58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A542 RID: 173378 RVA: 0x009DCDA0 File Offset: 0x009DAFA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A543 RID: 173379 RVA: 0x009DCDEC File Offset: 0x009DAFEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A544 RID: 173380 RVA: 0x009DCE38 File Offset: 0x009DB038
		protected BP_KuroMotorcycleFreezeWaterComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D52 RID: 89426
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C";

		// Token: 0x04015D53 RID: 89427
		private static IntPtr _ClassPtr;

		// Token: 0x04015D54 RID: 89428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D55 RID: 89429
		internal static int __PropertyOffset_1;

		// Token: 0x04015D56 RID: 89430
		internal static int __PropertyOffset_2;

		// Token: 0x04015D57 RID: 89431
		internal static int __PropertyOffset_3;

		// Token: 0x04015D58 RID: 89432
		internal static int __PropertyOffset_4;

		// Token: 0x04015D59 RID: 89433
		internal static int __PropertyOffset_5;

		// Token: 0x04015D5A RID: 89434
		internal static int __PropertyOffset_6;

		// Token: 0x04015D5B RID: 89435
		internal static int __PropertyOffset_7;

		// Token: 0x04015D5C RID: 89436
		internal static int __PropertyOffset_8;

		// Token: 0x04015D5D RID: 89437
		internal static int __PropertyOffset_9;

		// Token: 0x04015D5E RID: 89438
		internal static int __PropertyOffset_10;

		// Token: 0x04015D5F RID: 89439
		internal static int __PropertyOffset_11;

		// Token: 0x04015D60 RID: 89440
		internal static int __PropertyOffset_12;

		// Token: 0x04015D61 RID: 89441
		internal static int __PropertyOffset_13;

		// Token: 0x04015D62 RID: 89442
		internal static int __PropertyOffset_14;

		// Token: 0x04015D63 RID: 89443
		internal static int __PropertyOffset_15;

		// Token: 0x04015D64 RID: 89444
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x04015D65 RID: 89445
		private static IntPtr __CreateMID_NativeFunctionPtr;

		// Token: 0x04015D66 RID: 89446
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04015D67 RID: 89447
		private static IntPtr __HandleWaterDetectedStart_NativeFunctionPtr;

		// Token: 0x04015D68 RID: 89448
		private static IntPtr __HandleWaterDetectedEnd_NativeFunctionPtr;

		// Token: 0x04015D69 RID: 89449
		private static IntPtr __HandleWaterDetectedTick_NativeFunctionPtr;

		// Token: 0x04015D6A RID: 89450
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015D6B RID: 89451
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A363 RID: 41827
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __HandleWaterDetectedTick_FunctionParams
		{
			// Token: 0x04032133 RID: 205107
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04032134 RID: 205108
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x04032135 RID: 205109
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x0200A364 RID: 41828
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032136 RID: 205110
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A365 RID: 41829
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04032137 RID: 205111
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
