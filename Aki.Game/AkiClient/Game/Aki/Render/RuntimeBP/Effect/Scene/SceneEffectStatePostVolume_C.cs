using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCF RID: 15823
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class SceneEffectStatePostVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060276E5 RID: 161509 RVA: 0x00990E2F File Offset: 0x0098F02F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SceneEffectStatePostVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C");
			}
			return SceneEffectStatePostVolume_C._ClassPtr;
		}

		// Token: 0x060276E6 RID: 161510 RVA: 0x00990E54 File Offset: 0x0098F054
		public SceneEffectStatePostVolume_C() : this(BuiltinUtils.AllocNativeUObject(SceneEffectStatePostVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060276E7 RID: 161511 RVA: 0x00990E7C File Offset: 0x0098F07C
		[NullableContext(1)]
		public SceneEffectStatePostVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneEffectStatePostVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x060276E8 RID: 161512 RVA: 0x00990EAF File Offset: 0x0098F0AF
		// (set) Token: 0x060276E9 RID: 161513 RVA: 0x00990EC3 File Offset: 0x0098F0C3
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x060276EA RID: 161514 RVA: 0x00990ED8 File Offset: 0x0098F0D8
		// (set) Token: 0x060276EB RID: 161515 RVA: 0x00990EEC File Offset: 0x0098F0EC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SceneEffectStatePostVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x060276EC RID: 161516 RVA: 0x00990F01 File Offset: 0x0098F101
		// (set) Token: 0x060276ED RID: 161517 RVA: 0x00990F11 File Offset: 0x0098F111
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x060276EE RID: 161518 RVA: 0x00990F22 File Offset: 0x0098F122
		// (set) Token: 0x060276EF RID: 161519 RVA: 0x00990F32 File Offset: 0x0098F132
		public unsafe float value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SceneEffectStatePostVolume_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060276F0 RID: 161520 RVA: 0x00990F43 File Offset: 0x0098F143
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetToxicFog_Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetToxicFog_Debug_NativeFunctionPtr, null);
		}

		// Token: 0x060276F1 RID: 161521 RVA: 0x00990F57 File Offset: 0x0098F157
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetWall_Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetWall_Debug_NativeFunctionPtr, null);
		}

		// Token: 0x060276F2 RID: 161522 RVA: 0x00990F6C File Offset: 0x0098F16C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetEffect(float Value)
		{
			SceneEffectStatePostVolume_C.__SetEffect_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetEffect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060276F3 RID: 161523 RVA: 0x00990FB2 File Offset: 0x0098F1B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__DisableVolume_NativeFunctionPtr, null);
		}

		// Token: 0x060276F4 RID: 161524 RVA: 0x00990FC6 File Offset: 0x0098F1C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableVolume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__EnableVolume_NativeFunctionPtr, null);
		}

		// Token: 0x060276F5 RID: 161525 RVA: 0x00990FDC File Offset: 0x0098F1DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetToxicFog(float Value)
		{
			SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetToxicFog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetToxicFog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetToxicFog_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060276F6 RID: 161526 RVA: 0x00991024 File Offset: 0x0098F224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetAirWall(float value)
		{
			SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams* ptr = stackalloc SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(SceneEffectStatePostVolume_C.__SetAirWall_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SceneEffectStatePostVolume_C.__SetAirWall_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SceneEffectStatePostVolume_C.__SetAirWall_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060276F7 RID: 161527 RVA: 0x0099106A File Offset: 0x0098F26A
		protected SceneEffectStatePostVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E8F RID: 81551
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/SceneEffectStatePostVolume.SceneEffectStatePostVolume_C";

		// Token: 0x04013E90 RID: 81552
		private static IntPtr _ClassPtr;

		// Token: 0x04013E91 RID: 81553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E92 RID: 81554
		internal static int __PropertyOffset_0;

		// Token: 0x04013E93 RID: 81555
		internal static int __PropertyOffset_1;

		// Token: 0x04013E94 RID: 81556
		internal static int __PropertyOffset_2;

		// Token: 0x04013E95 RID: 81557
		internal static int __PropertyOffset_3;

		// Token: 0x04013E96 RID: 81558
		private static IntPtr __SetToxicFog_Debug_NativeFunctionPtr;

		// Token: 0x04013E97 RID: 81559
		private static IntPtr __SetWall_Debug_NativeFunctionPtr;

		// Token: 0x04013E98 RID: 81560
		private static IntPtr __SetEffect_NativeFunctionPtr;

		// Token: 0x04013E99 RID: 81561
		private static IntPtr __DisableVolume_NativeFunctionPtr;

		// Token: 0x04013E9A RID: 81562
		private static IntPtr __EnableVolume_NativeFunctionPtr;

		// Token: 0x04013E9B RID: 81563
		private static IntPtr __SetToxicFog_NativeFunctionPtr;

		// Token: 0x04013E9C RID: 81564
		private static IntPtr __SetAirWall_NativeFunctionPtr;

		// Token: 0x0200A225 RID: 41509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetEffect_FunctionParams
		{
			// Token: 0x04031E8F RID: 204431
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x0200A226 RID: 41510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetToxicFog_FunctionParams
		{
			// Token: 0x04031E90 RID: 204432
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x0200A227 RID: 41511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetAirWall_FunctionParams
		{
			// Token: 0x04031E91 RID: 204433
			[FieldOffset(0)]
			public float value;
		}
	}
}
