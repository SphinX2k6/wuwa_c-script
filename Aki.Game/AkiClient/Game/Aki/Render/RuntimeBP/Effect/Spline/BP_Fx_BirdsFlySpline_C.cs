using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Spline
{
	// Token: 0x02003DC5 RID: 15813
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Spline/BP_Fx_BirdsFlySpline.BP_Fx_BirdsFlySpline_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1084)]
	public class BP_Fx_BirdsFlySpline_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027596 RID: 161174 RVA: 0x0098EBEB File Offset: 0x0098CDEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_BirdsFlySpline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Spline/BP_Fx_BirdsFlySpline.BP_Fx_BirdsFlySpline_C");
			}
			return BP_Fx_BirdsFlySpline_C._ClassPtr;
		}

		// Token: 0x06027597 RID: 161175 RVA: 0x0098EC10 File Offset: 0x0098CE10
		public BP_Fx_BirdsFlySpline_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_BirdsFlySpline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027598 RID: 161176 RVA: 0x0098EC38 File Offset: 0x0098CE38
		[NullableContext(1)]
		public BP_Fx_BirdsFlySpline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_BirdsFlySpline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x06027599 RID: 161177 RVA: 0x0098EC6B File Offset: 0x0098CE6B
		// (set) Token: 0x0602759A RID: 161178 RVA: 0x0098EC7F File Offset: 0x0098CE7F
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_BirdsFlySpline_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_BirdsFlySpline_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x0602759B RID: 161179 RVA: 0x0098EC94 File Offset: 0x0098CE94
		// (set) Token: 0x0602759C RID: 161180 RVA: 0x0098ECA8 File Offset: 0x0098CEA8
		[Nullable(2)]
		public unsafe EffectModelNiagara EffectModelNiagara
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectModelNiagara>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_BirdsFlySpline_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_BirdsFlySpline_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x0602759D RID: 161181 RVA: 0x0098ECBD File Offset: 0x0098CEBD
		// (set) Token: 0x0602759E RID: 161182 RVA: 0x0098ECCD File Offset: 0x0098CECD
		public unsafe int TsEffectComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_BirdsFlySpline_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_BirdsFlySpline_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602759F RID: 161183 RVA: 0x0098ECE0 File Offset: 0x0098CEE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_Fx_BirdsFlySpline_C.__IsEditor_FunctionParams* ptr = stackalloc BP_Fx_BirdsFlySpline_C.__IsEditor_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_Fx_BirdsFlySpline_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_BirdsFlySpline_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x060275A0 RID: 161184 RVA: 0x0098ED2F File Offset: 0x0098CF2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__StopEditor_NativeFunctionPtr, null);
		}

		// Token: 0x060275A1 RID: 161185 RVA: 0x0098ED43 File Offset: 0x0098CF43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__PlayEditor_NativeFunctionPtr, null);
		}

		// Token: 0x060275A2 RID: 161186 RVA: 0x0098ED57 File Offset: 0x0098CF57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x060275A3 RID: 161187 RVA: 0x0098ED6B File Offset: 0x0098CF6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060275A4 RID: 161188 RVA: 0x0098ED7F File Offset: 0x0098CF7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060275A5 RID: 161189 RVA: 0x0098ED94 File Offset: 0x0098CF94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060275A6 RID: 161190 RVA: 0x0098EDE0 File Offset: 0x0098CFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060275A7 RID: 161191 RVA: 0x0098EE2C File Offset: 0x0098D02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_BirdsFlySpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060275A8 RID: 161192 RVA: 0x0098EE74 File Offset: 0x0098D074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_BirdsFlySpline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_BirdsFlySpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_BirdsFlySpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060275A9 RID: 161193 RVA: 0x0098EEBB File Offset: 0x0098D0BB
		protected BP_Fx_BirdsFlySpline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DC3 RID: 81347
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Spline/BP_Fx_BirdsFlySpline.BP_Fx_BirdsFlySpline_C";

		// Token: 0x04013DC4 RID: 81348
		private static IntPtr _ClassPtr;

		// Token: 0x04013DC5 RID: 81349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DC6 RID: 81350
		internal static int __PropertyOffset_1;

		// Token: 0x04013DC7 RID: 81351
		internal static int __PropertyOffset_2;

		// Token: 0x04013DC8 RID: 81352
		internal static int __PropertyOffset_3;

		// Token: 0x04013DC9 RID: 81353
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x04013DCA RID: 81354
		private static IntPtr __StopEditor_NativeFunctionPtr;

		// Token: 0x04013DCB RID: 81355
		private static IntPtr __PlayEditor_NativeFunctionPtr;

		// Token: 0x04013DCC RID: 81356
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04013DCD RID: 81357
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013DCE RID: 81358
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04013DCF RID: 81359
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A218 RID: 41496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x04031E82 RID: 204418
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x0200A219 RID: 41497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031E83 RID: 204419
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A21A RID: 41498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E84 RID: 204420
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
