using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C19 RID: 15385
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_HoverCarInteraction.BP_HoverCarInteraction_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class BP_HoverCarInteraction_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233A4 RID: 144292 RVA: 0x0091E13A File Offset: 0x0091C33A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HoverCarInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_HoverCarInteraction.BP_HoverCarInteraction_C");
			}
			return BP_HoverCarInteraction_C._ClassPtr;
		}

		// Token: 0x060233A5 RID: 144293 RVA: 0x0091E160 File Offset: 0x0091C360
		public BP_HoverCarInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_HoverCarInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233A6 RID: 144294 RVA: 0x0091E188 File Offset: 0x0091C388
		[NullableContext(1)]
		public BP_HoverCarInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HoverCarInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x060233A7 RID: 144295 RVA: 0x0091E1BB File Offset: 0x0091C3BB
		// (set) Token: 0x060233A8 RID: 144296 RVA: 0x0091E1CF File Offset: 0x0091C3CF
		public unsafe UStaticMeshComponent SM_Gel_Car_01AL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x060233A9 RID: 144297 RVA: 0x0091E1E4 File Offset: 0x0091C3E4
		// (set) Token: 0x060233AA RID: 144298 RVA: 0x0091E1F8 File Offset: 0x0091C3F8
		public unsafe USkeletalMeshComponent SK_Gel_Car_01AL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x060233AB RID: 144299 RVA: 0x0091E20D File Offset: 0x0091C40D
		// (set) Token: 0x060233AC RID: 144300 RVA: 0x0091E221 File Offset: 0x0091C421
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x060233AD RID: 144301 RVA: 0x0091E236 File Offset: 0x0091C436
		// (set) Token: 0x060233AE RID: 144302 RVA: 0x0091E24A File Offset: 0x0091C44A
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x060233AF RID: 144303 RVA: 0x0091E25F File Offset: 0x0091C45F
		// (set) Token: 0x060233B0 RID: 144304 RVA: 0x0091E273 File Offset: 0x0091C473
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HoverCarInteraction_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x060233B1 RID: 144305 RVA: 0x0091E288 File Offset: 0x0091C488
		// (set) Token: 0x060233B2 RID: 144306 RVA: 0x0091E29C File Offset: 0x0091C49C
		public unsafe FVectorDouble LastFrameVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x060233B3 RID: 144307 RVA: 0x0091E2B1 File Offset: 0x0091C4B1
		// (set) Token: 0x060233B4 RID: 144308 RVA: 0x0091E2C1 File Offset: 0x0091C4C1
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x060233B5 RID: 144309 RVA: 0x0091E2D2 File Offset: 0x0091C4D2
		// (set) Token: 0x060233B6 RID: 144310 RVA: 0x0091E2E2 File Offset: 0x0091C4E2
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x060233B7 RID: 144311 RVA: 0x0091E2F3 File Offset: 0x0091C4F3
		// (set) Token: 0x060233B8 RID: 144312 RVA: 0x0091E303 File Offset: 0x0091C503
		public unsafe float NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x060233B9 RID: 144313 RVA: 0x0091E314 File Offset: 0x0091C514
		// (set) Token: 0x060233BA RID: 144314 RVA: 0x0091E324 File Offset: 0x0091C524
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x060233BB RID: 144315 RVA: 0x0091E335 File Offset: 0x0091C535
		// (set) Token: 0x060233BC RID: 144316 RVA: 0x0091E345 File Offset: 0x0091C545
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x060233BD RID: 144317 RVA: 0x0091E356 File Offset: 0x0091C556
		// (set) Token: 0x060233BE RID: 144318 RVA: 0x0091E366 File Offset: 0x0091C566
		public unsafe float Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x060233BF RID: 144319 RVA: 0x0091E377 File Offset: 0x0091C577
		// (set) Token: 0x060233C0 RID: 144320 RVA: 0x0091E387 File Offset: 0x0091C587
		public unsafe float 晃动幅度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x060233C1 RID: 144321 RVA: 0x0091E398 File Offset: 0x0091C598
		// (set) Token: 0x060233C2 RID: 144322 RVA: 0x0091E3A8 File Offset: 0x0091C5A8
		public unsafe float 晃动时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x060233C3 RID: 144323 RVA: 0x0091E3B9 File Offset: 0x0091C5B9
		// (set) Token: 0x060233C4 RID: 144324 RVA: 0x0091E3C9 File Offset: 0x0091C5C9
		public unsafe float 晃动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x060233C5 RID: 144325 RVA: 0x0091E3DA File Offset: 0x0091C5DA
		// (set) Token: 0x060233C6 RID: 144326 RVA: 0x0091E3EA File Offset: 0x0091C5EA
		public unsafe float Attack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HoverCarInteraction_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x060233C7 RID: 144327 RVA: 0x0091E3FB File Offset: 0x0091C5FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HoverCarInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060233C8 RID: 144328 RVA: 0x0091E40F File Offset: 0x0091C60F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HoverCarInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060233C9 RID: 144329 RVA: 0x0091E424 File Offset: 0x0091C624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HoverCarInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HoverCarInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233CA RID: 144330 RVA: 0x0091E46C File Offset: 0x0091C66C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HoverCarInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HoverCarInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HoverCarInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060233CB RID: 144331 RVA: 0x0091E4B4 File Offset: 0x0091C6B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233CC RID: 144332 RVA: 0x0091E570 File Offset: 0x0091C770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HoverCarInteraction_C.__BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233CD RID: 144333 RVA: 0x0091E5F9 File Offset: 0x0091C7F9
		protected BP_HoverCarInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115E6 RID: 71142
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_HoverCarInteraction.BP_HoverCarInteraction_C";

		// Token: 0x040115E7 RID: 71143
		private static IntPtr _ClassPtr;

		// Token: 0x040115E8 RID: 71144
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115E9 RID: 71145
		internal static int __PropertyOffset_1;

		// Token: 0x040115EA RID: 71146
		internal static int __PropertyOffset_2;

		// Token: 0x040115EB RID: 71147
		internal static int __PropertyOffset_3;

		// Token: 0x040115EC RID: 71148
		internal static int __PropertyOffset_4;

		// Token: 0x040115ED RID: 71149
		internal static int __PropertyOffset_5;

		// Token: 0x040115EE RID: 71150
		internal static int __PropertyOffset_6;

		// Token: 0x040115EF RID: 71151
		internal static int __PropertyOffset_7;

		// Token: 0x040115F0 RID: 71152
		internal static int __PropertyOffset_8;

		// Token: 0x040115F1 RID: 71153
		internal static int __PropertyOffset_9;

		// Token: 0x040115F2 RID: 71154
		internal static int __PropertyOffset_10;

		// Token: 0x040115F3 RID: 71155
		internal static int __PropertyOffset_11;

		// Token: 0x040115F4 RID: 71156
		internal static int __PropertyOffset_12;

		// Token: 0x040115F5 RID: 71157
		internal static int __PropertyOffset_13;

		// Token: 0x040115F6 RID: 71158
		internal static int __PropertyOffset_14;

		// Token: 0x040115F7 RID: 71159
		internal static int __PropertyOffset_15;

		// Token: 0x040115F8 RID: 71160
		internal static int __PropertyOffset_16;

		// Token: 0x040115F9 RID: 71161
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040115FA RID: 71162
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040115FB RID: 71163
		private static IntPtr __BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040115FC RID: 71164
		private static IntPtr __BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E3A RID: 40506
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031697 RID: 202391
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E3B RID: 40507
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031698 RID: 202392
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031699 RID: 202393
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403169A RID: 202394
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403169B RID: 202395
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403169C RID: 202396
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403169D RID: 202397
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E3C RID: 40508
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_Car_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403169E RID: 202398
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403169F RID: 202399
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316A0 RID: 202400
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316A1 RID: 202401
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
