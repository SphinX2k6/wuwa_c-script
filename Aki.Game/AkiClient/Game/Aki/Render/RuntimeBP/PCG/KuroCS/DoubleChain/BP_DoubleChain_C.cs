using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.DoubleChain
{
	// Token: 0x02003C8D RID: 15501
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/DoubleChain/BP_DoubleChain.BP_DoubleChain_C")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class BP_DoubleChain_C : AKuroCSDoubleChain, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024360 RID: 148320 RVA: 0x00938078 File Offset: 0x00936278
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DoubleChain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/DoubleChain/BP_DoubleChain.BP_DoubleChain_C");
			}
			return BP_DoubleChain_C._ClassPtr;
		}

		// Token: 0x06024361 RID: 148321 RVA: 0x0093809C File Offset: 0x0093629C
		public BP_DoubleChain_C() : this(BuiltinUtils.AllocNativeUObject(BP_DoubleChain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024362 RID: 148322 RVA: 0x009380C4 File Offset: 0x009362C4
		[NullableContext(1)]
		public BP_DoubleChain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DoubleChain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06024363 RID: 148323 RVA: 0x009380F7 File Offset: 0x009362F7
		// (set) Token: 0x06024364 RID: 148324 RVA: 0x0093810B File Offset: 0x0093630B
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06024365 RID: 148325 RVA: 0x00938120 File Offset: 0x00936320
		// (set) Token: 0x06024366 RID: 148326 RVA: 0x00938134 File Offset: 0x00936334
		public unsafe UStaticMeshComponent ClothMeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06024367 RID: 148327 RVA: 0x00938149 File Offset: 0x00936349
		// (set) Token: 0x06024368 RID: 148328 RVA: 0x0093815D File Offset: 0x0093635D
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06024369 RID: 148329 RVA: 0x00938172 File Offset: 0x00936372
		// (set) Token: 0x0602436A RID: 148330 RVA: 0x00938182 File Offset: 0x00936382
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x0602436B RID: 148331 RVA: 0x00938193 File Offset: 0x00936393
		// (set) Token: 0x0602436C RID: 148332 RVA: 0x009381A3 File Offset: 0x009363A3
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x0602436D RID: 148333 RVA: 0x009381B4 File Offset: 0x009363B4
		// (set) Token: 0x0602436E RID: 148334 RVA: 0x009381C8 File Offset: 0x009363C8
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x0602436F RID: 148335 RVA: 0x009381DD File Offset: 0x009363DD
		// (set) Token: 0x06024370 RID: 148336 RVA: 0x009381ED File Offset: 0x009363ED
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x06024371 RID: 148337 RVA: 0x009381FE File Offset: 0x009363FE
		// (set) Token: 0x06024372 RID: 148338 RVA: 0x0093820E File Offset: 0x0093640E
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x06024373 RID: 148339 RVA: 0x00938220 File Offset: 0x00936420
		// (set) Token: 0x06024374 RID: 148340 RVA: 0x00938259 File Offset: 0x00936459
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x06024375 RID: 148341 RVA: 0x00938267 File Offset: 0x00936467
		// (set) Token: 0x06024376 RID: 148342 RVA: 0x00938277 File Offset: 0x00936477
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x06024377 RID: 148343 RVA: 0x00938288 File Offset: 0x00936488
		// (set) Token: 0x06024378 RID: 148344 RVA: 0x00938298 File Offset: 0x00936498
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x06024379 RID: 148345 RVA: 0x009382A9 File Offset: 0x009364A9
		// (set) Token: 0x0602437A RID: 148346 RVA: 0x009382B9 File Offset: 0x009364B9
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x0602437B RID: 148347 RVA: 0x009382CA File Offset: 0x009364CA
		// (set) Token: 0x0602437C RID: 148348 RVA: 0x009382DA File Offset: 0x009364DA
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DoubleChain_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x0602437D RID: 148349 RVA: 0x009382EB File Offset: 0x009364EB
		// (set) Token: 0x0602437E RID: 148350 RVA: 0x009382FF File Offset: 0x009364FF
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DoubleChain_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x0602437F RID: 148351 RVA: 0x00938314 File Offset: 0x00936514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024380 RID: 148352 RVA: 0x00938328 File Offset: 0x00936528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AutoXCenter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__AutoXCenter_NativeFunctionPtr, null);
		}

		// Token: 0x06024381 RID: 148353 RVA: 0x0093833C File Offset: 0x0093653C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024382 RID: 148354 RVA: 0x00938350 File Offset: 0x00936550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024383 RID: 148355 RVA: 0x00938364 File Offset: 0x00936564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024384 RID: 148356 RVA: 0x00938378 File Offset: 0x00936578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024385 RID: 148357 RVA: 0x0093838C File Offset: 0x0093658C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DoubleChain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024386 RID: 148358 RVA: 0x009383A1 File Offset: 0x009365A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024387 RID: 148359 RVA: 0x009383B5 File Offset: 0x009365B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024388 RID: 148360 RVA: 0x009383CC File Offset: 0x009365CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DoubleChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024389 RID: 148361 RVA: 0x00938414 File Offset: 0x00936614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DoubleChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602438A RID: 148362 RVA: 0x0093845C File Offset: 0x0093665C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602438B RID: 148363 RVA: 0x009384B4 File Offset: 0x009366B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602438C RID: 148364 RVA: 0x0093850C File Offset: 0x0093670C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602438D RID: 148365 RVA: 0x00938564 File Offset: 0x00936764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_DoubleChain_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DoubleChain_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DoubleChain_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602438E RID: 148366 RVA: 0x009385BA File Offset: 0x009367BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DoubleChain_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602438F RID: 148367 RVA: 0x009385CE File Offset: 0x009367CE
		protected BP_DoubleChain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F0D RID: 73485
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/DoubleChain/BP_DoubleChain.BP_DoubleChain_C";

		// Token: 0x04011F0E RID: 73486
		private static IntPtr _ClassPtr;

		// Token: 0x04011F0F RID: 73487
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F10 RID: 73488
		internal static int __PropertyOffset_1;

		// Token: 0x04011F11 RID: 73489
		internal static int __PropertyOffset_2;

		// Token: 0x04011F12 RID: 73490
		internal static int __PropertyOffset_3;

		// Token: 0x04011F13 RID: 73491
		internal static int __PropertyOffset_4;

		// Token: 0x04011F14 RID: 73492
		internal static int __PropertyOffset_5;

		// Token: 0x04011F15 RID: 73493
		internal static int __PropertyOffset_6;

		// Token: 0x04011F16 RID: 73494
		internal static int __PropertyOffset_7;

		// Token: 0x04011F17 RID: 73495
		internal static int __PropertyOffset_8;

		// Token: 0x04011F18 RID: 73496
		internal static int __PropertyOffset_9;

		// Token: 0x04011F19 RID: 73497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04011F1A RID: 73498
		internal static int __PropertyOffset_10;

		// Token: 0x04011F1B RID: 73499
		internal static int __PropertyOffset_11;

		// Token: 0x04011F1C RID: 73500
		internal static int __PropertyOffset_12;

		// Token: 0x04011F1D RID: 73501
		internal static int __PropertyOffset_13;

		// Token: 0x04011F1E RID: 73502
		internal static int __PropertyOffset_14;

		// Token: 0x04011F1F RID: 73503
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04011F20 RID: 73504
		private static IntPtr __AutoXCenter_NativeFunctionPtr;

		// Token: 0x04011F21 RID: 73505
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04011F22 RID: 73506
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04011F23 RID: 73507
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04011F24 RID: 73508
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011F25 RID: 73509
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011F26 RID: 73510
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011F27 RID: 73511
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04011F28 RID: 73512
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x04011F29 RID: 73513
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009EE7 RID: 40679
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317ED RID: 202733
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EE8 RID: 40680
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x040317EE RID: 202734
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009EE9 RID: 40681
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x040317EF RID: 202735
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
