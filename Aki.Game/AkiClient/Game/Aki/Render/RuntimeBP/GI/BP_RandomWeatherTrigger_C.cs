using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D31 RID: 15665
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_RandomWeatherTrigger.BP_RandomWeatherTrigger_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1137)]
	public class BP_RandomWeatherTrigger_C : ATriggerBox, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F38 RID: 155448 RVA: 0x009673E4 File Offset: 0x009655E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RandomWeatherTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_RandomWeatherTrigger.BP_RandomWeatherTrigger_C");
			}
			return BP_RandomWeatherTrigger_C._ClassPtr;
		}

		// Token: 0x06025F39 RID: 155449 RVA: 0x00967408 File Offset: 0x00965608
		public BP_RandomWeatherTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_RandomWeatherTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F3A RID: 155450 RVA: 0x00967430 File Offset: 0x00965630
		[NullableContext(1)]
		public BP_RandomWeatherTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RandomWeatherTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x06025F3B RID: 155451 RVA: 0x00967463 File Offset: 0x00965663
		// (set) Token: 0x06025F3C RID: 155452 RVA: 0x00967477 File Offset: 0x00965677
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomWeatherTrigger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomWeatherTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x06025F3D RID: 155453 RVA: 0x0096748C File Offset: 0x0096568C
		// (set) Token: 0x06025F3E RID: 155454 RVA: 0x0096749C File Offset: 0x0096569C
		public unsafe bool IsInVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x06025F3F RID: 155455 RVA: 0x009674AD File Offset: 0x009656AD
		// (set) Token: 0x06025F40 RID: 155456 RVA: 0x009674BD File Offset: 0x009656BD
		public unsafe float RandomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x06025F41 RID: 155457 RVA: 0x009674CE File Offset: 0x009656CE
		// (set) Token: 0x06025F42 RID: 155458 RVA: 0x009674DE File Offset: 0x009656DE
		public unsafe float PostProcessIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x06025F43 RID: 155459 RVA: 0x009674EF File Offset: 0x009656EF
		// (set) Token: 0x06025F44 RID: 155460 RVA: 0x00967503 File Offset: 0x00965703
		public unsafe UKuroWeatherDataAsset RandomWeatherDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomWeatherTrigger_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomWeatherTrigger_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x06025F45 RID: 155461 RVA: 0x00967518 File Offset: 0x00965718
		// (set) Token: 0x06025F46 RID: 155462 RVA: 0x00967528 File Offset: 0x00965728
		public unsafe float RandomFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x06025F47 RID: 155463 RVA: 0x00967539 File Offset: 0x00965739
		// (set) Token: 0x06025F48 RID: 155464 RVA: 0x00967549 File Offset: 0x00965749
		public unsafe float RainyDayPersistSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x06025F49 RID: 155465 RVA: 0x0096755A File Offset: 0x0096575A
		// (set) Token: 0x06025F4A RID: 155466 RVA: 0x0096756A File Offset: 0x0096576A
		public unsafe float RandomWeatherCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06025F4B RID: 155467 RVA: 0x0096757B File Offset: 0x0096577B
		// (set) Token: 0x06025F4C RID: 155468 RVA: 0x0096758B File Offset: 0x0096578B
		public unsafe bool IsRaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06025F4D RID: 155469 RVA: 0x0096759C File Offset: 0x0096579C
		// (set) Token: 0x06025F4E RID: 155470 RVA: 0x009675AC File Offset: 0x009657AC
		public unsafe float EnteringCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06025F4F RID: 155471 RVA: 0x009675BD File Offset: 0x009657BD
		// (set) Token: 0x06025F50 RID: 155472 RVA: 0x009675CD File Offset: 0x009657CD
		public unsafe float ExitingCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06025F51 RID: 155473 RVA: 0x009675DE File Offset: 0x009657DE
		// (set) Token: 0x06025F52 RID: 155474 RVA: 0x009675EE File Offset: 0x009657EE
		public unsafe float EnteringTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x06025F53 RID: 155475 RVA: 0x009675FF File Offset: 0x009657FF
		// (set) Token: 0x06025F54 RID: 155476 RVA: 0x0096760F File Offset: 0x0096580F
		public unsafe float ExitingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06025F55 RID: 155477 RVA: 0x00967620 File Offset: 0x00965820
		// (set) Token: 0x06025F56 RID: 155478 RVA: 0x00967630 File Offset: 0x00965830
		public unsafe bool IsExitingRain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomWeatherTrigger_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025F57 RID: 155479 RVA: 0x00967644 File Offset: 0x00965844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateRandomWeather(float DeltaTime)
		{
			BP_RandomWeatherTrigger_C.__UpdateRandomWeather_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__UpdateRandomWeather_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__UpdateRandomWeather_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__UpdateRandomWeather_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__UpdateRandomWeather_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F58 RID: 155480 RVA: 0x0096768C File Offset: 0x0096588C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsLegalActor(AActor InActor, ref bool Suc)
		{
			BP_RandomWeatherTrigger_C.__IsLegalActor_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__IsLegalActor_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__IsLegalActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__IsLegalActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->Suc = Suc;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__IsLegalActor_NativeFunctionPtr, (void*)ptr);
			Suc = ptr->Suc;
		}

		// Token: 0x06025F59 RID: 155481 RVA: 0x009676F4 File Offset: 0x009658F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ExitWithActor(AActor InActor)
		{
			BP_RandomWeatherTrigger_C.__ExitWithActor_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ExitWithActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ExitWithActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ExitWithActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ExitWithActor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F5A RID: 155482 RVA: 0x0096774C File Offset: 0x0096594C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OverlapWithActor(AActor InActor)
		{
			BP_RandomWeatherTrigger_C.__OverlapWithActor_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__OverlapWithActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__OverlapWithActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__OverlapWithActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__OverlapWithActor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F5B RID: 155483 RVA: 0x009677A1 File Offset: 0x009659A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025F5C RID: 155484 RVA: 0x009677B5 File Offset: 0x009659B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025F5D RID: 155485 RVA: 0x009677CC File Offset: 0x009659CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F5E RID: 155486 RVA: 0x00967824 File Offset: 0x00965A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F5F RID: 155487 RVA: 0x0096787C File Offset: 0x00965A7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F60 RID: 155488 RVA: 0x009678C4 File Offset: 0x00965AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F61 RID: 155489 RVA: 0x0096790C File Offset: 0x00965B0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025F62 RID: 155490 RVA: 0x00967964 File Offset: 0x00965B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomWeatherTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025F63 RID: 155491 RVA: 0x009679BA File Offset: 0x00965BBA
		protected BP_RandomWeatherTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FC2 RID: 77762
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_RandomWeatherTrigger.BP_RandomWeatherTrigger_C";

		// Token: 0x04012FC3 RID: 77763
		private static IntPtr _ClassPtr;

		// Token: 0x04012FC4 RID: 77764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012FC5 RID: 77765
		internal static int __PropertyOffset_1;

		// Token: 0x04012FC6 RID: 77766
		internal static int __PropertyOffset_2;

		// Token: 0x04012FC7 RID: 77767
		internal static int __PropertyOffset_3;

		// Token: 0x04012FC8 RID: 77768
		internal static int __PropertyOffset_4;

		// Token: 0x04012FC9 RID: 77769
		internal static int __PropertyOffset_5;

		// Token: 0x04012FCA RID: 77770
		internal static int __PropertyOffset_6;

		// Token: 0x04012FCB RID: 77771
		internal static int __PropertyOffset_7;

		// Token: 0x04012FCC RID: 77772
		internal static int __PropertyOffset_8;

		// Token: 0x04012FCD RID: 77773
		internal static int __PropertyOffset_9;

		// Token: 0x04012FCE RID: 77774
		internal static int __PropertyOffset_10;

		// Token: 0x04012FCF RID: 77775
		internal static int __PropertyOffset_11;

		// Token: 0x04012FD0 RID: 77776
		internal static int __PropertyOffset_12;

		// Token: 0x04012FD1 RID: 77777
		internal static int __PropertyOffset_13;

		// Token: 0x04012FD2 RID: 77778
		internal static int __PropertyOffset_14;

		// Token: 0x04012FD3 RID: 77779
		private static IntPtr __UpdateRandomWeather_NativeFunctionPtr;

		// Token: 0x04012FD4 RID: 77780
		private static IntPtr __IsLegalActor_NativeFunctionPtr;

		// Token: 0x04012FD5 RID: 77781
		private static IntPtr __ExitWithActor_NativeFunctionPtr;

		// Token: 0x04012FD6 RID: 77782
		private static IntPtr __OverlapWithActor_NativeFunctionPtr;

		// Token: 0x04012FD7 RID: 77783
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012FD8 RID: 77784
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04012FD9 RID: 77785
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012FDA RID: 77786
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x0200A070 RID: 41072
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateRandomWeather_FunctionParams
		{
			// Token: 0x04031B62 RID: 203618
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A071 RID: 41073
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __IsLegalActor_FunctionParams
		{
			// Token: 0x04031B63 RID: 203619
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031B64 RID: 203620
			[FieldOffset(8)]
			public bool Suc;
		}

		// Token: 0x0200A072 RID: 41074
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ExitWithActor_FunctionParams
		{
			// Token: 0x04031B65 RID: 203621
			[FieldOffset(0)]
			public IntPtr InActor;
		}

		// Token: 0x0200A073 RID: 41075
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OverlapWithActor_FunctionParams
		{
			// Token: 0x04031B66 RID: 203622
			[FieldOffset(0)]
			public IntPtr InActor;
		}

		// Token: 0x0200A074 RID: 41076
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031B67 RID: 203623
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x0200A075 RID: 41077
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031B68 RID: 203624
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A076 RID: 41078
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04031B69 RID: 203625
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
