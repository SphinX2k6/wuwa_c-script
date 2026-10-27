using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.Editor
{
	// Token: 0x02003B34 RID: 15156
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/Editor/BP_PerformanceDisableLight_MP4_OnlyEditor.BP_PerformanceDisableLight_MP4_OnlyEditor_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class BP_PerformanceDisableLight_MP4_OnlyEditor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602181F RID: 137247 RVA: 0x008EE2C0 File Offset: 0x008EC4C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PerformanceDisableLight_MP4_OnlyEditor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/Editor/BP_PerformanceDisableLight_MP4_OnlyEditor.BP_PerformanceDisableLight_MP4_OnlyEditor_C");
			}
			return BP_PerformanceDisableLight_MP4_OnlyEditor_C._ClassPtr;
		}

		// Token: 0x06021820 RID: 137248 RVA: 0x008EE2E4 File Offset: 0x008EC4E4
		public BP_PerformanceDisableLight_MP4_OnlyEditor_C() : this(BuiltinUtils.AllocNativeUObject(BP_PerformanceDisableLight_MP4_OnlyEditor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021821 RID: 137249 RVA: 0x008EE30C File Offset: 0x008EC50C
		public BP_PerformanceDisableLight_MP4_OnlyEditor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PerformanceDisableLight_MP4_OnlyEditor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x06021822 RID: 137250 RVA: 0x008EE33F File Offset: 0x008EC53F
		// (set) Token: 0x06021823 RID: 137251 RVA: 0x008EE353 File Offset: 0x008EC553
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x06021824 RID: 137252 RVA: 0x008EE368 File Offset: 0x008EC568
		// (set) Token: 0x06021825 RID: 137253 RVA: 0x008EE378 File Offset: 0x008EC578
		public unsafe float LightIntensity_MP4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x06021826 RID: 137254 RVA: 0x008EE389 File Offset: 0x008EC589
		// (set) Token: 0x06021827 RID: 137255 RVA: 0x008EE39D File Offset: 0x008EC59D
		public unsafe string MainCommand
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_PerformanceDisableLight_MP4_OnlyEditor_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x06021828 RID: 137256 RVA: 0x008EE3B2 File Offset: 0x008EC5B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableLightFun_MP4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__DisableLightFun_MP4_NativeFunctionPtr, null);
		}

		// Token: 0x06021829 RID: 137257 RVA: 0x008EE3C6 File Offset: 0x008EC5C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableLightFun()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__DisableLightFun_NativeFunctionPtr, null);
		}

		// Token: 0x0602182A RID: 137258 RVA: 0x008EE3DA File Offset: 0x008EC5DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602182B RID: 137259 RVA: 0x008EE3EE File Offset: 0x008EC5EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602182C RID: 137260 RVA: 0x008EE404 File Offset: 0x008EC604
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602182D RID: 137261 RVA: 0x008EE44C File Offset: 0x008EC64C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PerformanceDisableLight_MP4_OnlyEditor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602182E RID: 137262 RVA: 0x008EE493 File Offset: 0x008EC693
		protected BP_PerformanceDisableLight_MP4_OnlyEditor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401053D RID: 66877
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/Editor/BP_PerformanceDisableLight_MP4_OnlyEditor.BP_PerformanceDisableLight_MP4_OnlyEditor_C";

		// Token: 0x0401053E RID: 66878
		private static IntPtr _ClassPtr;

		// Token: 0x0401053F RID: 66879
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010540 RID: 66880
		internal static int __PropertyOffset_1;

		// Token: 0x04010541 RID: 66881
		internal static int __PropertyOffset_2;

		// Token: 0x04010542 RID: 66882
		internal static int __PropertyOffset_3;

		// Token: 0x04010543 RID: 66883
		private static IntPtr __DisableLightFun_MP4_NativeFunctionPtr;

		// Token: 0x04010544 RID: 66884
		private static IntPtr __DisableLightFun_NativeFunctionPtr;

		// Token: 0x04010545 RID: 66885
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010546 RID: 66886
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C9C RID: 40092
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031361 RID: 201569
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
