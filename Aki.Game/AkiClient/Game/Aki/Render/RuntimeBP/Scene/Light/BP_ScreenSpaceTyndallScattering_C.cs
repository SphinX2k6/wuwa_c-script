using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B15 RID: 15125
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ScreenSpaceTyndallScattering.BP_ScreenSpaceTyndallScattering_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1085)]
	public class BP_ScreenSpaceTyndallScattering_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210B7 RID: 135351 RVA: 0x008E370D File Offset: 0x008E190D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ScreenSpaceTyndallScattering_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ScreenSpaceTyndallScattering.BP_ScreenSpaceTyndallScattering_C");
			}
			return BP_ScreenSpaceTyndallScattering_C._ClassPtr;
		}

		// Token: 0x060210B8 RID: 135352 RVA: 0x008E3734 File Offset: 0x008E1934
		public BP_ScreenSpaceTyndallScattering_C() : this(BuiltinUtils.AllocNativeUObject(BP_ScreenSpaceTyndallScattering_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210B9 RID: 135353 RVA: 0x008E375C File Offset: 0x008E195C
		[NullableContext(1)]
		public BP_ScreenSpaceTyndallScattering_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ScreenSpaceTyndallScattering_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x060210BA RID: 135354 RVA: 0x008E378F File Offset: 0x008E198F
		// (set) Token: 0x060210BB RID: 135355 RVA: 0x008E37A3 File Offset: 0x008E19A3
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x060210BC RID: 135356 RVA: 0x008E37B8 File Offset: 0x008E19B8
		// (set) Token: 0x060210BD RID: 135357 RVA: 0x008E37CC File Offset: 0x008E19CC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x060210BE RID: 135358 RVA: 0x008E37E1 File Offset: 0x008E19E1
		// (set) Token: 0x060210BF RID: 135359 RVA: 0x008E37F1 File Offset: 0x008E19F1
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x060210C0 RID: 135360 RVA: 0x008E3802 File Offset: 0x008E1A02
		// (set) Token: 0x060210C1 RID: 135361 RVA: 0x008E3812 File Offset: 0x008E1A12
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x060210C2 RID: 135362 RVA: 0x008E3823 File Offset: 0x008E1A23
		// (set) Token: 0x060210C3 RID: 135363 RVA: 0x008E3833 File Offset: 0x008E1A33
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x060210C4 RID: 135364 RVA: 0x008E3844 File Offset: 0x008E1A44
		// (set) Token: 0x060210C5 RID: 135365 RVA: 0x008E3854 File Offset: 0x008E1A54
		public unsafe bool EnableCustomPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenSpaceTyndallScattering_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x060210C6 RID: 135366 RVA: 0x008E3865 File Offset: 0x008E1A65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__tick_NativeFunctionPtr, null);
		}

		// Token: 0x060210C7 RID: 135367 RVA: 0x008E3879 File Offset: 0x008E1A79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060210C8 RID: 135368 RVA: 0x008E388D File Offset: 0x008E1A8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210C9 RID: 135369 RVA: 0x008E38A2 File Offset: 0x008E1AA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060210CA RID: 135370 RVA: 0x008E38B6 File Offset: 0x008E1AB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210CB RID: 135371 RVA: 0x008E38CC File Offset: 0x008E1ACC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210CC RID: 135372 RVA: 0x008E3914 File Offset: 0x008E1B14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060210CD RID: 135373 RVA: 0x008E395C File Offset: 0x008E1B5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210CE RID: 135374 RVA: 0x008E39A8 File Offset: 0x008E1BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060210CF RID: 135375 RVA: 0x008E39F4 File Offset: 0x008E1BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060210D0 RID: 135376 RVA: 0x008E3A08 File Offset: 0x008E1C08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenSpaceTyndallScattering_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210D1 RID: 135377 RVA: 0x008E3A1D File Offset: 0x008E1C1D
		protected BP_ScreenSpaceTyndallScattering_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401012E RID: 65838
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ScreenSpaceTyndallScattering.BP_ScreenSpaceTyndallScattering_C";

		// Token: 0x0401012F RID: 65839
		private static IntPtr _ClassPtr;

		// Token: 0x04010130 RID: 65840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010131 RID: 65841
		internal static int __PropertyOffset_1;

		// Token: 0x04010132 RID: 65842
		internal static int __PropertyOffset_2;

		// Token: 0x04010133 RID: 65843
		internal static int __PropertyOffset_3;

		// Token: 0x04010134 RID: 65844
		internal static int __PropertyOffset_4;

		// Token: 0x04010135 RID: 65845
		internal static int __PropertyOffset_5;

		// Token: 0x04010136 RID: 65846
		internal static int __PropertyOffset_6;

		// Token: 0x04010137 RID: 65847
		private static IntPtr __tick_NativeFunctionPtr;

		// Token: 0x04010138 RID: 65848
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010139 RID: 65849
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401013A RID: 65850
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401013B RID: 65851
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401013C RID: 65852
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009C65 RID: 40037
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031323 RID: 201507
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C66 RID: 40038
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031324 RID: 201508
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
