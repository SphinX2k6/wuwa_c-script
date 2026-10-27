using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DC8 RID: 15816
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening.BP_Fx_RandomLightening_C")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class BP_Fx_RandomLightening_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602762A RID: 161322 RVA: 0x0098FAA4 File Offset: 0x0098DCA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_RandomLightening_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening.BP_Fx_RandomLightening_C");
			}
			return BP_Fx_RandomLightening_C._ClassPtr;
		}

		// Token: 0x0602762B RID: 161323 RVA: 0x0098FAC8 File Offset: 0x0098DCC8
		public BP_Fx_RandomLightening_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_RandomLightening_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602762C RID: 161324 RVA: 0x0098FAF0 File Offset: 0x0098DCF0
		[NullableContext(1)]
		public BP_Fx_RandomLightening_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_RandomLightening_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x0602762D RID: 161325 RVA: 0x0098FB23 File Offset: 0x0098DD23
		// (set) Token: 0x0602762E RID: 161326 RVA: 0x0098FB37 File Offset: 0x0098DD37
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x0602762F RID: 161327 RVA: 0x0098FB4C File Offset: 0x0098DD4C
		// (set) Token: 0x06027630 RID: 161328 RVA: 0x0098FB60 File Offset: 0x0098DD60
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x06027631 RID: 161329 RVA: 0x0098FB75 File Offset: 0x0098DD75
		// (set) Token: 0x06027632 RID: 161330 RVA: 0x0098FB89 File Offset: 0x0098DD89
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x06027633 RID: 161331 RVA: 0x0098FB9E File Offset: 0x0098DD9E
		// (set) Token: 0x06027634 RID: 161332 RVA: 0x0098FBAE File Offset: 0x0098DDAE
		public unsafe float IntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x06027635 RID: 161333 RVA: 0x0098FBBF File Offset: 0x0098DDBF
		// (set) Token: 0x06027636 RID: 161334 RVA: 0x0098FBCF File Offset: 0x0098DDCF
		public unsafe float IntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x06027637 RID: 161335 RVA: 0x0098FBE0 File Offset: 0x0098DDE0
		// (set) Token: 0x06027638 RID: 161336 RVA: 0x0098FC19 File Offset: 0x0098DE19
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
					result = (this._LightCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x06027639 RID: 161337 RVA: 0x0098FC3C File Offset: 0x0098DE3C
		// (set) Token: 0x0602763A RID: 161338 RVA: 0x0098FC75 File Offset: 0x0098DE75
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
					result = (this._PostProcessCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x0602763B RID: 161339 RVA: 0x0098FC96 File Offset: 0x0098DE96
		// (set) Token: 0x0602763C RID: 161340 RVA: 0x0098FCA6 File Offset: 0x0098DEA6
		public unsafe float Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x0602763D RID: 161341 RVA: 0x0098FCB7 File Offset: 0x0098DEB7
		// (set) Token: 0x0602763E RID: 161342 RVA: 0x0098FCC7 File Offset: 0x0098DEC7
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x0602763F RID: 161343 RVA: 0x0098FCD8 File Offset: 0x0098DED8
		// (set) Token: 0x06027640 RID: 161344 RVA: 0x0098FCE8 File Offset: 0x0098DEE8
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_RandomLightening_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x06027641 RID: 161345 RVA: 0x0098FCF9 File Offset: 0x0098DEF9
		// (set) Token: 0x06027642 RID: 161346 RVA: 0x0098FD0D File Offset: 0x0098DF0D
		public unsafe UNiagaraSystem NiagaraAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x06027643 RID: 161347 RVA: 0x0098FD22 File Offset: 0x0098DF22
		// (set) Token: 0x06027644 RID: 161348 RVA: 0x0098FD36 File Offset: 0x0098DF36
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_RandomLightening_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x06027645 RID: 161349 RVA: 0x0098FD4B File Offset: 0x0098DF4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Spawn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_C.__Spawn_NativeFunctionPtr, null);
		}

		// Token: 0x06027646 RID: 161350 RVA: 0x0098FD5F File Offset: 0x0098DF5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027647 RID: 161351 RVA: 0x0098FD73 File Offset: 0x0098DF73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_RandomLightening_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027648 RID: 161352 RVA: 0x0098FD88 File Offset: 0x0098DF88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_RandomLightening_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027649 RID: 161353 RVA: 0x0098FDD0 File Offset: 0x0098DFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_RandomLightening_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_RandomLightening_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_RandomLightening_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602764A RID: 161354 RVA: 0x0098FE17 File Offset: 0x0098E017
		protected BP_Fx_RandomLightening_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E1A RID: 81434
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_Fx_RandomLightening.BP_Fx_RandomLightening_C";

		// Token: 0x04013E1B RID: 81435
		private static IntPtr _ClassPtr;

		// Token: 0x04013E1C RID: 81436
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E1D RID: 81437
		internal static int __PropertyOffset_1;

		// Token: 0x04013E1E RID: 81438
		internal static int __PropertyOffset_2;

		// Token: 0x04013E1F RID: 81439
		internal static int __PropertyOffset_3;

		// Token: 0x04013E20 RID: 81440
		internal static int __PropertyOffset_4;

		// Token: 0x04013E21 RID: 81441
		internal static int __PropertyOffset_5;

		// Token: 0x04013E22 RID: 81442
		internal static int __PropertyOffset_6;

		// Token: 0x04013E23 RID: 81443
		private FKuroCurveFloat _LightCurve;

		// Token: 0x04013E24 RID: 81444
		internal static int __PropertyOffset_7;

		// Token: 0x04013E25 RID: 81445
		private FKuroCurveFloat _PostProcessCurve;

		// Token: 0x04013E26 RID: 81446
		internal static int __PropertyOffset_8;

		// Token: 0x04013E27 RID: 81447
		internal static int __PropertyOffset_9;

		// Token: 0x04013E28 RID: 81448
		internal static int __PropertyOffset_10;

		// Token: 0x04013E29 RID: 81449
		internal static int __PropertyOffset_11;

		// Token: 0x04013E2A RID: 81450
		internal static int __PropertyOffset_12;

		// Token: 0x04013E2B RID: 81451
		private static IntPtr __Spawn_NativeFunctionPtr;

		// Token: 0x04013E2C RID: 81452
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013E2D RID: 81453
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A21E RID: 41502
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E88 RID: 204424
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
