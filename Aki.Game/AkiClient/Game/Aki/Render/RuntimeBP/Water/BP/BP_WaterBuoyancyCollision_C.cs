using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A8A RID: 14986
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyCollision.BP_WaterBuoyancyCollision_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1506)]
	public class BP_WaterBuoyancyCollision_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD7E RID: 130430 RVA: 0x008C41E4 File Offset: 0x008C23E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBuoyancyCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyCollision.BP_WaterBuoyancyCollision_C");
			}
			return BP_WaterBuoyancyCollision_C._ClassPtr;
		}

		// Token: 0x0601FD7F RID: 130431 RVA: 0x008C4208 File Offset: 0x008C2408
		public BP_WaterBuoyancyCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancyCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD80 RID: 130432 RVA: 0x008C4230 File Offset: 0x008C2430
		[NullableContext(1)]
		public BP_WaterBuoyancyCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBuoyancyCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0601FD81 RID: 130433 RVA: 0x008C4263 File Offset: 0x008C2463
		// (set) Token: 0x0601FD82 RID: 130434 RVA: 0x008C4277 File Offset: 0x008C2477
		public unsafe UStaticMeshComponent Sphere1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0601FD83 RID: 130435 RVA: 0x008C428C File Offset: 0x008C248C
		// (set) Token: 0x0601FD84 RID: 130436 RVA: 0x008C42A0 File Offset: 0x008C24A0
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0601FD85 RID: 130437 RVA: 0x008C42B5 File Offset: 0x008C24B5
		// (set) Token: 0x0601FD86 RID: 130438 RVA: 0x008C42C9 File Offset: 0x008C24C9
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0601FD87 RID: 130439 RVA: 0x008C42DE File Offset: 0x008C24DE
		// (set) Token: 0x0601FD88 RID: 130440 RVA: 0x008C42F2 File Offset: 0x008C24F2
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0601FD89 RID: 130441 RVA: 0x008C4307 File Offset: 0x008C2507
		// (set) Token: 0x0601FD8A RID: 130442 RVA: 0x008C431B File Offset: 0x008C251B
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBuoyancyCollision_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0601FD8B RID: 130443 RVA: 0x008C4330 File Offset: 0x008C2530
		// (set) Token: 0x0601FD8C RID: 130444 RVA: 0x008C4344 File Offset: 0x008C2544
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0601FD8D RID: 130445 RVA: 0x008C4359 File Offset: 0x008C2559
		// (set) Token: 0x0601FD8E RID: 130446 RVA: 0x008C4369 File Offset: 0x008C2569
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0601FD8F RID: 130447 RVA: 0x008C437A File Offset: 0x008C257A
		// (set) Token: 0x0601FD90 RID: 130448 RVA: 0x008C438A File Offset: 0x008C258A
		public unsafe bool InBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0601FD91 RID: 130449 RVA: 0x008C439B File Offset: 0x008C259B
		// (set) Token: 0x0601FD92 RID: 130450 RVA: 0x008C43AB File Offset: 0x008C25AB
		public unsafe bool AlwaysFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBuoyancyCollision_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FD93 RID: 130451 RVA: 0x008C43BC File Offset: 0x008C25BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD94 RID: 130452 RVA: 0x008C43D0 File Offset: 0x008C25D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD95 RID: 130453 RVA: 0x008C43E5 File Offset: 0x008C25E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD96 RID: 130454 RVA: 0x008C43F9 File Offset: 0x008C25F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD97 RID: 130455 RVA: 0x008C4410 File Offset: 0x008C2610
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancyCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD98 RID: 130456 RVA: 0x008C4458 File Offset: 0x008C2658
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterBuoyancyCollision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterBuoyancyCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterBuoyancyCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FD99 RID: 130457 RVA: 0x008C449F File Offset: 0x008C269F
		protected BP_WaterBuoyancyCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F5A0 RID: 62880
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterBuoyancyCollision.BP_WaterBuoyancyCollision_C";

		// Token: 0x0400F5A1 RID: 62881
		private static IntPtr _ClassPtr;

		// Token: 0x0400F5A2 RID: 62882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F5A3 RID: 62883
		internal static int __PropertyOffset_1;

		// Token: 0x0400F5A4 RID: 62884
		internal static int __PropertyOffset_2;

		// Token: 0x0400F5A5 RID: 62885
		internal static int __PropertyOffset_3;

		// Token: 0x0400F5A6 RID: 62886
		internal static int __PropertyOffset_4;

		// Token: 0x0400F5A7 RID: 62887
		internal static int __PropertyOffset_5;

		// Token: 0x0400F5A8 RID: 62888
		internal static int __PropertyOffset_6;

		// Token: 0x0400F5A9 RID: 62889
		internal static int __PropertyOffset_7;

		// Token: 0x0400F5AA RID: 62890
		internal static int __PropertyOffset_8;

		// Token: 0x0400F5AB RID: 62891
		internal static int __PropertyOffset_9;

		// Token: 0x0400F5AC RID: 62892
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F5AD RID: 62893
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F5AE RID: 62894
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B5A RID: 39770
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031184 RID: 201092
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
