using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DC9 RID: 15817
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening_New.BP_Fx_RandomLightening_New_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1810)]
	public class BP_Fx_RandomLightening_New_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602764B RID: 161355 RVA: 0x0098FE20 File Offset: 0x0098E020
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_RandomLightening_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening_New.BP_Fx_RandomLightening_New_C");
			}
			return BP_Fx_RandomLightening_New_C._ClassPtr;
		}

		// Token: 0x0602764C RID: 161356 RVA: 0x0098FE44 File Offset: 0x0098E044
		public BP_Fx_RandomLightening_New_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_RandomLightening_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602764D RID: 161357 RVA: 0x0098FE6C File Offset: 0x0098E06C
		[NullableContext(1)]
		public BP_Fx_RandomLightening_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_RandomLightening_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x0602764E RID: 161358 RVA: 0x0098FE9F File Offset: 0x0098E09F
		// (set) Token: 0x0602764F RID: 161359 RVA: 0x0098FEB3 File Offset: 0x0098E0B3
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x06027650 RID: 161360 RVA: 0x0098FEC8 File Offset: 0x0098E0C8
		// (set) Token: 0x06027651 RID: 161361 RVA: 0x0098FEDC File Offset: 0x0098E0DC
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x06027652 RID: 161362 RVA: 0x0098FEF1 File Offset: 0x0098E0F1
		// (set) Token: 0x06027653 RID: 161363 RVA: 0x0098FF05 File Offset: 0x0098E105
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x06027654 RID: 161364 RVA: 0x0098FF1A File Offset: 0x0098E11A
		// (set) Token: 0x06027655 RID: 161365 RVA: 0x0098FF2A File Offset: 0x0098E12A
		public unsafe float IntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x06027656 RID: 161366 RVA: 0x0098FF3B File Offset: 0x0098E13B
		// (set) Token: 0x06027657 RID: 161367 RVA: 0x0098FF4B File Offset: 0x0098E14B
		public unsafe float IntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x06027658 RID: 161368 RVA: 0x0098FF5C File Offset: 0x0098E15C
		// (set) Token: 0x06027659 RID: 161369 RVA: 0x0098FF95 File Offset: 0x0098E195
		[Nullable(1)]
		public FKuroCurveFloat LightCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LightCurve) == null)
				{
					result = (this._LightCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x0602765A RID: 161370 RVA: 0x0098FFB8 File Offset: 0x0098E1B8
		// (set) Token: 0x0602765B RID: 161371 RVA: 0x0098FFF1 File Offset: 0x0098E1F1
		[Nullable(1)]
		public FKuroCurveFloat PostProcessCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PostProcessCurve) == null)
				{
					result = (this._PostProcessCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x0602765C RID: 161372 RVA: 0x00990012 File Offset: 0x0098E212
		// (set) Token: 0x0602765D RID: 161373 RVA: 0x00990022 File Offset: 0x0098E222
		public unsafe float Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x0602765E RID: 161374 RVA: 0x00990033 File Offset: 0x0098E233
		// (set) Token: 0x0602765F RID: 161375 RVA: 0x00990043 File Offset: 0x0098E243
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x06027660 RID: 161376 RVA: 0x00990054 File Offset: 0x0098E254
		// (set) Token: 0x06027661 RID: 161377 RVA: 0x00990064 File Offset: 0x0098E264
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x06027662 RID: 161378 RVA: 0x00990075 File Offset: 0x0098E275
		// (set) Token: 0x06027663 RID: 161379 RVA: 0x00990089 File Offset: 0x0098E289
		public unsafe UNiagaraSystem NiagaraAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x06027664 RID: 161380 RVA: 0x0099009E File Offset: 0x0098E29E
		// (set) Token: 0x06027665 RID: 161381 RVA: 0x009900B2 File Offset: 0x0098E2B2
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_New_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x06027666 RID: 161382 RVA: 0x009900C7 File Offset: 0x0098E2C7
		// (set) Token: 0x06027667 RID: 161383 RVA: 0x009900D7 File Offset: 0x0098E2D7
		public unsafe bool UsePostprocess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x06027668 RID: 161384 RVA: 0x009900E8 File Offset: 0x0098E2E8
		// (set) Token: 0x06027669 RID: 161385 RVA: 0x009900F8 File Offset: 0x0098E2F8
		public unsafe bool UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_New_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602766A RID: 161386 RVA: 0x00990109 File Offset: 0x0098E309
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Spawn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__Spawn_NativeFunctionPtr, null);
		}

		// Token: 0x0602766B RID: 161387 RVA: 0x0099011D File Offset: 0x0098E31D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602766C RID: 161388 RVA: 0x00990131 File Offset: 0x0098E331
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602766D RID: 161389 RVA: 0x00990148 File Offset: 0x0098E348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602766E RID: 161390 RVA: 0x00990190 File Offset: 0x0098E390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602766F RID: 161391 RVA: 0x009901D8 File Offset: 0x0098E3D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027670 RID: 161392 RVA: 0x00990220 File Offset: 0x0098E420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_RandomLightening_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027671 RID: 161393 RVA: 0x00990267 File Offset: 0x0098E467
		protected BP_Fx_RandomLightening_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E2E RID: 81454
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening_New.BP_Fx_RandomLightening_New_C";

		// Token: 0x04013E2F RID: 81455
		private static IntPtr _ClassPtr;

		// Token: 0x04013E30 RID: 81456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E31 RID: 81457
		internal static int __PropertyOffset_1;

		// Token: 0x04013E32 RID: 81458
		internal static int __PropertyOffset_2;

		// Token: 0x04013E33 RID: 81459
		internal static int __PropertyOffset_3;

		// Token: 0x04013E34 RID: 81460
		internal static int __PropertyOffset_4;

		// Token: 0x04013E35 RID: 81461
		internal static int __PropertyOffset_5;

		// Token: 0x04013E36 RID: 81462
		internal static int __PropertyOffset_6;

		// Token: 0x04013E37 RID: 81463
		private FKuroCurveFloat _LightCurve;

		// Token: 0x04013E38 RID: 81464
		internal static int __PropertyOffset_7;

		// Token: 0x04013E39 RID: 81465
		private FKuroCurveFloat _PostProcessCurve;

		// Token: 0x04013E3A RID: 81466
		internal static int __PropertyOffset_8;

		// Token: 0x04013E3B RID: 81467
		internal static int __PropertyOffset_9;

		// Token: 0x04013E3C RID: 81468
		internal static int __PropertyOffset_10;

		// Token: 0x04013E3D RID: 81469
		internal static int __PropertyOffset_11;

		// Token: 0x04013E3E RID: 81470
		internal static int __PropertyOffset_12;

		// Token: 0x04013E3F RID: 81471
		internal static int __PropertyOffset_13;

		// Token: 0x04013E40 RID: 81472
		internal static int __PropertyOffset_14;

		// Token: 0x04013E41 RID: 81473
		private static IntPtr __Spawn_NativeFunctionPtr;

		// Token: 0x04013E42 RID: 81474
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013E43 RID: 81475
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013E44 RID: 81476
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A21F RID: 41503
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E89 RID: 204425
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A220 RID: 41504
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E8A RID: 204426
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
