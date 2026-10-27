using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B14 RID: 15124
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_PerformanceDisableLight.BP_PerformanceDisableLight_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1476)]
	public class BP_PerformanceDisableLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021098 RID: 135320 RVA: 0x008E33C0 File Offset: 0x008E15C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PerformanceDisableLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_PerformanceDisableLight.BP_PerformanceDisableLight_C");
			}
			return BP_PerformanceDisableLight_C._ClassPtr;
		}

		// Token: 0x06021099 RID: 135321 RVA: 0x008E33E4 File Offset: 0x008E15E4
		public BP_PerformanceDisableLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_PerformanceDisableLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602109A RID: 135322 RVA: 0x008E340C File Offset: 0x008E160C
		[NullableContext(1)]
		public BP_PerformanceDisableLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PerformanceDisableLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0602109B RID: 135323 RVA: 0x008E343F File Offset: 0x008E163F
		// (set) Token: 0x0602109C RID: 135324 RVA: 0x008E3453 File Offset: 0x008E1653
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PerformanceDisableLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PerformanceDisableLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0602109D RID: 135325 RVA: 0x008E3468 File Offset: 0x008E1668
		// (set) Token: 0x0602109E RID: 135326 RVA: 0x008E3478 File Offset: 0x008E1678
		public unsafe float SceneLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0602109F RID: 135327 RVA: 0x008E3489 File Offset: 0x008E1689
		// (set) Token: 0x060210A0 RID: 135328 RVA: 0x008E3499 File Offset: 0x008E1699
		public unsafe float ToonLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x060210A1 RID: 135329 RVA: 0x008E34AA File Offset: 0x008E16AA
		// (set) Token: 0x060210A2 RID: 135330 RVA: 0x008E34BA File Offset: 0x008E16BA
		public unsafe bool DisableLight_Store
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x060210A3 RID: 135331 RVA: 0x008E34CB File Offset: 0x008E16CB
		// (set) Token: 0x060210A4 RID: 135332 RVA: 0x008E34DB File Offset: 0x008E16DB
		public unsafe bool DisableLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x060210A5 RID: 135333 RVA: 0x008E34EC File Offset: 0x008E16EC
		// (set) Token: 0x060210A6 RID: 135334 RVA: 0x008E34FC File Offset: 0x008E16FC
		public unsafe bool DisableToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x060210A7 RID: 135335 RVA: 0x008E350D File Offset: 0x008E170D
		// (set) Token: 0x060210A8 RID: 135336 RVA: 0x008E351D File Offset: 0x008E171D
		public unsafe bool DisableToonLight_Store
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x060210A9 RID: 135337 RVA: 0x008E352E File Offset: 0x008E172E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x060210AA RID: 135338 RVA: 0x008E3542 File Offset: 0x008E1742
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableToonLightFun()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__DisableToonLightFun_NativeFunctionPtr, null);
		}

		// Token: 0x060210AB RID: 135339 RVA: 0x008E3556 File Offset: 0x008E1756
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableLightFun()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__DisableLightFun_NativeFunctionPtr, null);
		}

		// Token: 0x060210AC RID: 135340 RVA: 0x008E356A File Offset: 0x008E176A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060210AD RID: 135341 RVA: 0x008E357E File Offset: 0x008E177E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210AE RID: 135342 RVA: 0x008E3593 File Offset: 0x008E1793
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060210AF RID: 135343 RVA: 0x008E35A7 File Offset: 0x008E17A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210B0 RID: 135344 RVA: 0x008E35BC File Offset: 0x008E17BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210B1 RID: 135345 RVA: 0x008E3604 File Offset: 0x008E1804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060210B2 RID: 135346 RVA: 0x008E364C File Offset: 0x008E184C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210B3 RID: 135347 RVA: 0x008E3694 File Offset: 0x008E1894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060210B4 RID: 135348 RVA: 0x008E36DB File Offset: 0x008E18DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060210B5 RID: 135349 RVA: 0x008E36EF File Offset: 0x008E18EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210B6 RID: 135350 RVA: 0x008E3704 File Offset: 0x008E1904
		protected BP_PerformanceDisableLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401011C RID: 65820
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_PerformanceDisableLight.BP_PerformanceDisableLight_C";

		// Token: 0x0401011D RID: 65821
		private static IntPtr _ClassPtr;

		// Token: 0x0401011E RID: 65822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401011F RID: 65823
		internal static int __PropertyOffset_1;

		// Token: 0x04010120 RID: 65824
		internal static int __PropertyOffset_2;

		// Token: 0x04010121 RID: 65825
		internal static int __PropertyOffset_3;

		// Token: 0x04010122 RID: 65826
		internal static int __PropertyOffset_4;

		// Token: 0x04010123 RID: 65827
		internal static int __PropertyOffset_5;

		// Token: 0x04010124 RID: 65828
		internal static int __PropertyOffset_6;

		// Token: 0x04010125 RID: 65829
		internal static int __PropertyOffset_7;

		// Token: 0x04010126 RID: 65830
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x04010127 RID: 65831
		private static IntPtr __DisableToonLightFun_NativeFunctionPtr;

		// Token: 0x04010128 RID: 65832
		private static IntPtr __DisableLightFun_NativeFunctionPtr;

		// Token: 0x04010129 RID: 65833
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401012A RID: 65834
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401012B RID: 65835
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401012C RID: 65836
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401012D RID: 65837
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009C63 RID: 40035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031321 RID: 201505
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C64 RID: 40036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031322 RID: 201506
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
