using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C16 RID: 15382
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1485)]
	public class BP_AnimaInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_DayNightEvent_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06023341 RID: 144193 RVA: 0x0091D2F4 File Offset: 0x0091B4F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimaInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C");
			}
			return BP_AnimaInteraction_C._ClassPtr;
		}

		// Token: 0x06023342 RID: 144194 RVA: 0x0091D318 File Offset: 0x0091B518
		public BP_AnimaInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimaInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023343 RID: 144195 RVA: 0x0091D340 File Offset: 0x0091B540
		[NullableContext(1)]
		public BP_AnimaInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimaInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x06023344 RID: 144196 RVA: 0x0091D373 File Offset: 0x0091B573
		// (set) Token: 0x06023345 RID: 144197 RVA: 0x0091D387 File Offset: 0x0091B587
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SK_Col_Bui_42AM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x06023346 RID: 144198 RVA: 0x0091D39C File Offset: 0x0091B59C
		// (set) Token: 0x06023347 RID: 144199 RVA: 0x0091D3B0 File Offset: 0x0091B5B0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x06023348 RID: 144200 RVA: 0x0091D3C5 File Offset: 0x0091B5C5
		// (set) Token: 0x06023349 RID: 144201 RVA: 0x0091D3D5 File Offset: 0x0091B5D5
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x0602334A RID: 144202 RVA: 0x0091D3E6 File Offset: 0x0091B5E6
		// (set) Token: 0x0602334B RID: 144203 RVA: 0x0091D3F6 File Offset: 0x0091B5F6
		public unsafe bool IsDaytime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602334C RID: 144204 RVA: 0x0091D407 File Offset: 0x0091B607
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602334D RID: 144205 RVA: 0x0091D41B File Offset: 0x0091B61B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602334E RID: 144206 RVA: 0x0091D430 File Offset: 0x0091B630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602334F RID: 144207 RVA: 0x0091D478 File Offset: 0x0091B678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023350 RID: 144208 RVA: 0x0091D4C0 File Offset: 0x0091B6C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnInterrupted_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023351 RID: 144209 RVA: 0x0091D508 File Offset: 0x0091B708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBlendOut_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023352 RID: 144210 RVA: 0x0091D550 File Offset: 0x0091B750
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnCompleted_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023353 RID: 144211 RVA: 0x0091D598 File Offset: 0x0091B798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023354 RID: 144212 RVA: 0x0091D5E0 File Offset: 0x0091B7E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023355 RID: 144213 RVA: 0x0091D628 File Offset: 0x0091B828
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023356 RID: 144214 RVA: 0x0091D670 File Offset: 0x0091B870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023357 RID: 144215 RVA: 0x0091D6B8 File Offset: 0x0091B8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023358 RID: 144216 RVA: 0x0091D6FE File Offset: 0x0091B8FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x06023359 RID: 144217 RVA: 0x0091D712 File Offset: 0x0091B912
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x0602335A RID: 144218 RVA: 0x0091D726 File Offset: 0x0091B926
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602335B RID: 144219 RVA: 0x0091D73A File Offset: 0x0091B93A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602335C RID: 144220 RVA: 0x0091D750 File Offset: 0x0091B950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602335D RID: 144221 RVA: 0x0091D79C File Offset: 0x0091B99C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602335E RID: 144222 RVA: 0x0091D7E8 File Offset: 0x0091B9E8
		protected BP_AnimaInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115A6 RID: 71078
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C";

		// Token: 0x040115A7 RID: 71079
		private static IntPtr _ClassPtr;

		// Token: 0x040115A8 RID: 71080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115A9 RID: 71081
		internal static int __PropertyOffset_1;

		// Token: 0x040115AA RID: 71082
		internal static int __PropertyOffset_2;

		// Token: 0x040115AB RID: 71083
		internal static int __PropertyOffset_3;

		// Token: 0x040115AC RID: 71084
		internal static int __PropertyOffset_4;

		// Token: 0x040115AD RID: 71085
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040115AE RID: 71086
		private static IntPtr __OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x040115AF RID: 71087
		private static IntPtr __OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x040115B0 RID: 71088
		private static IntPtr __OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x040115B1 RID: 71089
		private static IntPtr __OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x040115B2 RID: 71090
		private static IntPtr __OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x040115B3 RID: 71091
		private static IntPtr __OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x040115B4 RID: 71092
		private static IntPtr __OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x040115B5 RID: 71093
		private static IntPtr __OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x040115B6 RID: 71094
		private static IntPtr __OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x040115B7 RID: 71095
		private static IntPtr __OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x040115B8 RID: 71096
		private static IntPtr __OnEnterNight_NativeFunctionPtr;

		// Token: 0x040115B9 RID: 71097
		private static IntPtr __OnEnterDay_NativeFunctionPtr;

		// Token: 0x040115BA RID: 71098
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040115BB RID: 71099
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009E28 RID: 40488
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x04031673 RID: 202355
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E29 RID: 40489
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x04031674 RID: 202356
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2A RID: 40490
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x04031675 RID: 202357
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2B RID: 40491
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x04031676 RID: 202358
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2C RID: 40492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x04031677 RID: 202359
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2D RID: 40493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x04031678 RID: 202360
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2E RID: 40494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x04031679 RID: 202361
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E2F RID: 40495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0403167A RID: 202362
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E30 RID: 40496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0403167B RID: 202363
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E31 RID: 40497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0403167C RID: 202364
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02009E32 RID: 40498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403167D RID: 202365
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
