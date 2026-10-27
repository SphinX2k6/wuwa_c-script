using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.SpecialHandling
{
	// Token: 0x02003B30 RID: 15152
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/SpecialHandling/BP_DisableVolumetricFogWhenNotShadow.BP_DisableVolumetricFogWhenNotShadow_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1073)]
	public class BP_DisableVolumetricFogWhenNotShadow_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217A4 RID: 137124 RVA: 0x008ED620 File Offset: 0x008EB820
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DisableVolumetricFogWhenNotShadow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/SpecialHandling/BP_DisableVolumetricFogWhenNotShadow.BP_DisableVolumetricFogWhenNotShadow_C");
			}
			return BP_DisableVolumetricFogWhenNotShadow_C._ClassPtr;
		}

		// Token: 0x060217A5 RID: 137125 RVA: 0x008ED644 File Offset: 0x008EB844
		public BP_DisableVolumetricFogWhenNotShadow_C() : this(BuiltinUtils.AllocNativeUObject(BP_DisableVolumetricFogWhenNotShadow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217A6 RID: 137126 RVA: 0x008ED66C File Offset: 0x008EB86C
		[NullableContext(1)]
		public BP_DisableVolumetricFogWhenNotShadow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DisableVolumetricFogWhenNotShadow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x060217A7 RID: 137127 RVA: 0x008ED69F File Offset: 0x008EB89F
		// (set) Token: 0x060217A8 RID: 137128 RVA: 0x008ED6B3 File Offset: 0x008EB8B3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x060217A9 RID: 137129 RVA: 0x008ED6C8 File Offset: 0x008EB8C8
		// (set) Token: 0x060217AA RID: 137130 RVA: 0x008ED6D8 File Offset: 0x008EB8D8
		public unsafe int CurrentShadowConsole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x060217AB RID: 137131 RVA: 0x008ED6E9 File Offset: 0x008EB8E9
		// (set) Token: 0x060217AC RID: 137132 RVA: 0x008ED6F9 File Offset: 0x008EB8F9
		public unsafe int CurrentVolumetricFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x060217AD RID: 137133 RVA: 0x008ED70A File Offset: 0x008EB90A
		// (set) Token: 0x060217AE RID: 137134 RVA: 0x008ED71A File Offset: 0x008EB91A
		public unsafe bool bDisableVolumetricFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableVolumetricFogWhenNotShadow_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x060217AF RID: 137135 RVA: 0x008ED72B File Offset: 0x008EB92B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableVolumetricFogIfNotShadow()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__DisableVolumetricFogIfNotShadow_NativeFunctionPtr, null);
		}

		// Token: 0x060217B0 RID: 137136 RVA: 0x008ED73F File Offset: 0x008EB93F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060217B1 RID: 137137 RVA: 0x008ED753 File Offset: 0x008EB953
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060217B2 RID: 137138 RVA: 0x008ED768 File Offset: 0x008EB968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060217B3 RID: 137139 RVA: 0x008ED77C File Offset: 0x008EB97C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060217B4 RID: 137140 RVA: 0x008ED794 File Offset: 0x008EB994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060217B5 RID: 137141 RVA: 0x008ED7DC File Offset: 0x008EB9DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060217B6 RID: 137142 RVA: 0x008ED823 File Offset: 0x008EBA23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimerEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableVolumetricFogWhenNotShadow_C.__TimerEvent_NativeFunctionPtr, null);
		}

		// Token: 0x060217B7 RID: 137143 RVA: 0x008ED837 File Offset: 0x008EBA37
		protected BP_DisableVolumetricFogWhenNotShadow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104F7 RID: 66807
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/SpecialHandling/BP_DisableVolumetricFogWhenNotShadow.BP_DisableVolumetricFogWhenNotShadow_C";

		// Token: 0x040104F8 RID: 66808
		private static IntPtr _ClassPtr;

		// Token: 0x040104F9 RID: 66809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104FA RID: 66810
		internal static int __PropertyOffset_1;

		// Token: 0x040104FB RID: 66811
		internal static int __PropertyOffset_2;

		// Token: 0x040104FC RID: 66812
		internal static int __PropertyOffset_3;

		// Token: 0x040104FD RID: 66813
		internal static int __PropertyOffset_4;

		// Token: 0x040104FE RID: 66814
		private static IntPtr __DisableVolumetricFogIfNotShadow_NativeFunctionPtr;

		// Token: 0x040104FF RID: 66815
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010500 RID: 66816
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010501 RID: 66817
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010502 RID: 66818
		private static IntPtr __TimerEvent_NativeFunctionPtr;

		// Token: 0x02009C96 RID: 40086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031354 RID: 201556
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
