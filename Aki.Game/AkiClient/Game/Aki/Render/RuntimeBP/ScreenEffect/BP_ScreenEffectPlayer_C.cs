using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect
{
	// Token: 0x02003AE5 RID: 15077
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1177)]
	public class BP_ScreenEffectPlayer_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209D1 RID: 133585 RVA: 0x008D7BF0 File Offset: 0x008D5DF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ScreenEffectPlayer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C");
			}
			return BP_ScreenEffectPlayer_C._ClassPtr;
		}

		// Token: 0x060209D2 RID: 133586 RVA: 0x008D7C14 File Offset: 0x008D5E14
		public BP_ScreenEffectPlayer_C() : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectPlayer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209D3 RID: 133587 RVA: 0x008D7C3C File Offset: 0x008D5E3C
		[NullableContext(1)]
		public BP_ScreenEffectPlayer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectPlayer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x060209D4 RID: 133588 RVA: 0x008D7C6F File Offset: 0x008D5E6F
		// (set) Token: 0x060209D5 RID: 133589 RVA: 0x008D7C83 File Offset: 0x008D5E83
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x060209D6 RID: 133590 RVA: 0x008D7C98 File Offset: 0x008D5E98
		// (set) Token: 0x060209D7 RID: 133591 RVA: 0x008D7CAC File Offset: 0x008D5EAC
		[Nullable(2)]
		public unsafe EffectScreenPlayData_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x060209D8 RID: 133592 RVA: 0x008D7CC1 File Offset: 0x008D5EC1
		// (set) Token: 0x060209D9 RID: 133593 RVA: 0x008D7CD5 File Offset: 0x008D5ED5
		public unsafe TEnumAsByte<E_SE_PlayState> State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x060209DA RID: 133594 RVA: 0x008D7CEA File Offset: 0x008D5EEA
		// (set) Token: 0x060209DB RID: 133595 RVA: 0x008D7CFA File Offset: 0x008D5EFA
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x060209DC RID: 133596 RVA: 0x008D7D0B File Offset: 0x008D5F0B
		// (set) Token: 0x060209DD RID: 133597 RVA: 0x008D7D1F File Offset: 0x008D5F1F
		[Nullable(2)]
		public unsafe AActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x060209DE RID: 133598 RVA: 0x008D7D34 File Offset: 0x008D5F34
		// (set) Token: 0x060209DF RID: 133599 RVA: 0x008D7D6D File Offset: 0x008D5F6D
		[Nullable(1)]
		public TArray<UActorComponent> CachedComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._CachedComponents) == null)
				{
					result = (this._CachedComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedComponents.CopyAssign(value);
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x060209E0 RID: 133600 RVA: 0x008D7D7B File Offset: 0x008D5F7B
		// (set) Token: 0x060209E1 RID: 133601 RVA: 0x008D7D8B File Offset: 0x008D5F8B
		public unsafe bool bToHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x060209E2 RID: 133602 RVA: 0x008D7D9C File Offset: 0x008D5F9C
		// (set) Token: 0x060209E3 RID: 133603 RVA: 0x008D7DAC File Offset: 0x008D5FAC
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x060209E4 RID: 133604 RVA: 0x008D7DBD File Offset: 0x008D5FBD
		// (set) Token: 0x060209E5 RID: 133605 RVA: 0x008D7DCD File Offset: 0x008D5FCD
		public unsafe float FadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x060209E6 RID: 133606 RVA: 0x008D7DDE File Offset: 0x008D5FDE
		// (set) Token: 0x060209E7 RID: 133607 RVA: 0x008D7DEE File Offset: 0x008D5FEE
		public unsafe float FadeOutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x060209E8 RID: 133608 RVA: 0x008D7E00 File Offset: 0x008D6000
		// (set) Token: 0x060209E9 RID: 133609 RVA: 0x008D7E39 File Offset: 0x008D6039
		[Nullable(1)]
		public TArray<AActor> CachedUIActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._CachedUIActors) == null)
				{
					result = (this._CachedUIActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedUIActors.CopyAssign(value);
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x060209EA RID: 133610 RVA: 0x008D7E47 File Offset: 0x008D6047
		// (set) Token: 0x060209EB RID: 133611 RVA: 0x008D7E57 File Offset: 0x008D6057
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x060209EC RID: 133612 RVA: 0x008D7E68 File Offset: 0x008D6068
		// (set) Token: 0x060209ED RID: 133613 RVA: 0x008D7E7C File Offset: 0x008D607C
		[Nullable(2)]
		public unsafe AUIContainerActor ScreenEffectRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x060209EE RID: 133614 RVA: 0x008D7E91 File Offset: 0x008D6091
		// (set) Token: 0x060209EF RID: 133615 RVA: 0x008D7EA1 File Offset: 0x008D60A1
		public unsafe bool bNeedToDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x060209F0 RID: 133616 RVA: 0x008D7EB2 File Offset: 0x008D60B2
		// (set) Token: 0x060209F1 RID: 133617 RVA: 0x008D7EC2 File Offset: 0x008D60C2
		public unsafe float CacheEnvironmentFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x060209F2 RID: 133618 RVA: 0x008D7ED3 File Offset: 0x008D60D3
		// (set) Token: 0x060209F3 RID: 133619 RVA: 0x008D7EE3 File Offset: 0x008D60E3
		public unsafe float ParameterTweenProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x060209F4 RID: 133620 RVA: 0x008D7EF4 File Offset: 0x008D60F4
		// (set) Token: 0x060209F5 RID: 133621 RVA: 0x008D7F04 File Offset: 0x008D6104
		public unsafe float ParameterTweenSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x060209F6 RID: 133622 RVA: 0x008D7F15 File Offset: 0x008D6115
		// (set) Token: 0x060209F7 RID: 133623 RVA: 0x008D7F25 File Offset: 0x008D6125
		public unsafe float ParameterTweenTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x060209F8 RID: 133624 RVA: 0x008D7F36 File Offset: 0x008D6136
		// (set) Token: 0x060209F9 RID: 133625 RVA: 0x008D7F46 File Offset: 0x008D6146
		public unsafe float NiagaraFrameDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x060209FA RID: 133626 RVA: 0x008D7F57 File Offset: 0x008D6157
		// (set) Token: 0x060209FB RID: 133627 RVA: 0x008D7F67 File Offset: 0x008D6167
		public unsafe bool NiagaraFrameDeltaTimeDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x060209FC RID: 133628 RVA: 0x008D7F78 File Offset: 0x008D6178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetNiagaraFrameDeltaTime(float DeltaTime)
		{
			BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209FD RID: 133629 RVA: 0x008D7FC0 File Offset: 0x008D61C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AlmostEqual(float val1, float val2, ref bool isequal)
		{
			BP_ScreenEffectPlayer_C.__AlmostEqual_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__AlmostEqual_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__AlmostEqual_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__AlmostEqual_NativeFunctionPtr, (void*)ptr, 1);
			ptr->val1 = val1;
			ptr->val2 = val2;
			ptr->isequal = isequal;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__AlmostEqual_NativeFunctionPtr, (void*)ptr);
			isequal = ptr->isequal;
		}

		// Token: 0x060209FE RID: 133630 RVA: 0x008D8020 File Offset: 0x008D6220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetExtraState(int ExtraState)
		{
			BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetExtraState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ExtraState = ExtraState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetExtraState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209FF RID: 133631 RVA: 0x008D806C File Offset: 0x008D626C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Refresh_Addition_Parameter(float TweenProgress)
		{
			BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams[(UIntPtr)911] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenProgress = TweenProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A00 RID: 133632 RVA: 0x008D80B8 File Offset: 0x008D62B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TweenParameterSpeed(float TweenTarget, float TweenSpeed, float TweenDeltaSecond)
		{
			BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameterSpeed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			ptr->TweenSpeed = TweenSpeed;
			ptr->TweenDeltaSecond = TweenDeltaSecond;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameterSpeed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A01 RID: 133633 RVA: 0x008D810C File Offset: 0x008D630C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BP_ScreenEffectPlayer_AutoGenFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__BP_ScreenEffectPlayer_AutoGenFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06020A02 RID: 133634 RVA: 0x008D8120 File Offset: 0x008D6320
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DelayEndAudioCall()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__DelayEndAudioCall_NativeFunctionPtr, null);
		}

		// Token: 0x06020A03 RID: 133635 RVA: 0x008D8134 File Offset: 0x008D6334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdatePlayerSEEnvironmentFactor(float EnvironmentFactor)
		{
			BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A04 RID: 133636 RVA: 0x008D817D File Offset: 0x008D637D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Destroy_Player()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Destroy_Player_NativeFunctionPtr, null);
		}

		// Token: 0x06020A05 RID: 133637 RVA: 0x008D8191 File Offset: 0x008D6391
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearPlayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ClearPlayer_NativeFunctionPtr, null);
		}

		// Token: 0x06020A06 RID: 133638 RVA: 0x008D81A8 File Offset: 0x008D63A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitPlayer(EffectScreenPlayData_C Data, AUIContainerActor ScreenEffectRoot)
		{
			BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__InitPlayer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->ScreenEffectRoot = ((ScreenEffectRoot != null) ? ScreenEffectRoot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__InitPlayer_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A07 RID: 133639 RVA: 0x008D8213 File Offset: 0x008D6413
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020A08 RID: 133640 RVA: 0x008D8228 File Offset: 0x008D6428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Effect_Hidden(bool bToHide, bool bOverrideFadeSpeed, float OverrideFadeSpeed)
		{
			BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bToHide = bToHide;
			ptr->bOverrideFadeSpeed = bOverrideFadeSpeed;
			ptr->OverrideFadeSpeed = OverrideFadeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A09 RID: 133641 RVA: 0x008D827C File Offset: 0x008D647C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetUIVisible(bool Visible)
		{
			BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetUIVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visible = Visible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetUIVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A0A RID: 133642 RVA: 0x008D82C2 File Offset: 0x008D64C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateComponentsAlpha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdateComponentsAlpha_NativeFunctionPtr, null);
		}

		// Token: 0x06020A0B RID: 133643 RVA: 0x008D82D6 File Offset: 0x008D64D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateComponents()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdateComponents_NativeFunctionPtr, null);
		}

		// Token: 0x06020A0C RID: 133644 RVA: 0x008D82EA File Offset: 0x008D64EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndPlayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__EndPlayer_NativeFunctionPtr, null);
		}

		// Token: 0x06020A0D RID: 133645 RVA: 0x008D82FE File Offset: 0x008D64FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start_Player()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Start_Player_NativeFunctionPtr, null);
		}

		// Token: 0x06020A0E RID: 133646 RVA: 0x008D8314 File Offset: 0x008D6514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TweenParameter(float TweenTarget)
		{
			BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A0F RID: 133647 RVA: 0x008D835C File Offset: 0x008D655C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TweenParameterImmediately(float TweenTarget)
		{
			BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameterImmediately_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameterImmediately_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A10 RID: 133648 RVA: 0x008D83A2 File Offset: 0x008D65A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020A11 RID: 133649 RVA: 0x008D83B6 File Offset: 0x008D65B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020A12 RID: 133650 RVA: 0x008D83CB File Offset: 0x008D65CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020A13 RID: 133651 RVA: 0x008D83DF File Offset: 0x008D65DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020A14 RID: 133652 RVA: 0x008D83F4 File Offset: 0x008D65F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A15 RID: 133653 RVA: 0x008D843C File Offset: 0x008D663C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020A16 RID: 133654 RVA: 0x008D8484 File Offset: 0x008D6684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A17 RID: 133655 RVA: 0x008D84D0 File Offset: 0x008D66D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020A18 RID: 133656 RVA: 0x008D851C File Offset: 0x008D671C
		protected BP_ScreenEffectPlayer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD03 RID: 64771
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C";

		// Token: 0x0400FD04 RID: 64772
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD05 RID: 64773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD06 RID: 64774
		internal static int __PropertyOffset_1;

		// Token: 0x0400FD07 RID: 64775
		internal static int __PropertyOffset_2;

		// Token: 0x0400FD08 RID: 64776
		internal static int __PropertyOffset_3;

		// Token: 0x0400FD09 RID: 64777
		internal static int __PropertyOffset_4;

		// Token: 0x0400FD0A RID: 64778
		internal static int __PropertyOffset_5;

		// Token: 0x0400FD0B RID: 64779
		internal static int __PropertyOffset_6;

		// Token: 0x0400FD0C RID: 64780
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _CachedComponents;

		// Token: 0x0400FD0D RID: 64781
		internal static int __PropertyOffset_7;

		// Token: 0x0400FD0E RID: 64782
		internal static int __PropertyOffset_8;

		// Token: 0x0400FD0F RID: 64783
		internal static int __PropertyOffset_9;

		// Token: 0x0400FD10 RID: 64784
		internal static int __PropertyOffset_10;

		// Token: 0x0400FD11 RID: 64785
		internal static int __PropertyOffset_11;

		// Token: 0x0400FD12 RID: 64786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _CachedUIActors;

		// Token: 0x0400FD13 RID: 64787
		internal static int __PropertyOffset_12;

		// Token: 0x0400FD14 RID: 64788
		internal static int __PropertyOffset_13;

		// Token: 0x0400FD15 RID: 64789
		internal static int __PropertyOffset_14;

		// Token: 0x0400FD16 RID: 64790
		internal static int __PropertyOffset_15;

		// Token: 0x0400FD17 RID: 64791
		internal static int __PropertyOffset_16;

		// Token: 0x0400FD18 RID: 64792
		internal static int __PropertyOffset_17;

		// Token: 0x0400FD19 RID: 64793
		internal static int __PropertyOffset_18;

		// Token: 0x0400FD1A RID: 64794
		internal static int __PropertyOffset_19;

		// Token: 0x0400FD1B RID: 64795
		internal static int __PropertyOffset_20;

		// Token: 0x0400FD1C RID: 64796
		private static IntPtr __SetNiagaraFrameDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FD1D RID: 64797
		private static IntPtr __AlmostEqual_NativeFunctionPtr;

		// Token: 0x0400FD1E RID: 64798
		private static IntPtr __SetExtraState_NativeFunctionPtr;

		// Token: 0x0400FD1F RID: 64799
		private static IntPtr __Refresh_Addition_Parameter_NativeFunctionPtr;

		// Token: 0x0400FD20 RID: 64800
		private static IntPtr __TweenParameterSpeed_NativeFunctionPtr;

		// Token: 0x0400FD21 RID: 64801
		private static IntPtr __BP_ScreenEffectPlayer_AutoGenFunc_NativeFunctionPtr;

		// Token: 0x0400FD22 RID: 64802
		private static IntPtr __DelayEndAudioCall_NativeFunctionPtr;

		// Token: 0x0400FD23 RID: 64803
		private static IntPtr __UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x0400FD24 RID: 64804
		private static IntPtr __Destroy_Player_NativeFunctionPtr;

		// Token: 0x0400FD25 RID: 64805
		private static IntPtr __ClearPlayer_NativeFunctionPtr;

		// Token: 0x0400FD26 RID: 64806
		private static IntPtr __InitPlayer_NativeFunctionPtr;

		// Token: 0x0400FD27 RID: 64807
		private static IntPtr __BeforeStart_NativeFunctionPtr;

		// Token: 0x0400FD28 RID: 64808
		private static IntPtr __Set_Effect_Hidden_NativeFunctionPtr;

		// Token: 0x0400FD29 RID: 64809
		private static IntPtr __SetUIVisible_NativeFunctionPtr;

		// Token: 0x0400FD2A RID: 64810
		private static IntPtr __UpdateComponentsAlpha_NativeFunctionPtr;

		// Token: 0x0400FD2B RID: 64811
		private static IntPtr __UpdateComponents_NativeFunctionPtr;

		// Token: 0x0400FD2C RID: 64812
		private static IntPtr __EndPlayer_NativeFunctionPtr;

		// Token: 0x0400FD2D RID: 64813
		private static IntPtr __Start_Player_NativeFunctionPtr;

		// Token: 0x0400FD2E RID: 64814
		private static IntPtr __TweenParameter_NativeFunctionPtr;

		// Token: 0x0400FD2F RID: 64815
		private static IntPtr __TweenParameterImmediately_NativeFunctionPtr;

		// Token: 0x0400FD30 RID: 64816
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FD31 RID: 64817
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FD32 RID: 64818
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FD33 RID: 64819
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BE6 RID: 39910
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetNiagaraFrameDeltaTime_FunctionParams
		{
			// Token: 0x0403127A RID: 201338
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009BE7 RID: 39911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AlmostEqual_FunctionParams
		{
			// Token: 0x0403127B RID: 201339
			[FieldOffset(0)]
			public float val1;

			// Token: 0x0403127C RID: 201340
			[FieldOffset(4)]
			public float val2;

			// Token: 0x0403127D RID: 201341
			[FieldOffset(8)]
			public bool isequal;
		}

		// Token: 0x02009BE8 RID: 39912
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __SetExtraState_FunctionParams
		{
			// Token: 0x0403127E RID: 201342
			[FieldOffset(0)]
			public int ExtraState;
		}

		// Token: 0x02009BE9 RID: 39913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 896)]
		protected ref struct __Refresh_Addition_Parameter_FunctionParams
		{
			// Token: 0x0403127F RID: 201343
			[FieldOffset(0)]
			public float TweenProgress;
		}

		// Token: 0x02009BEA RID: 39914
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __TweenParameterSpeed_FunctionParams
		{
			// Token: 0x04031280 RID: 201344
			[FieldOffset(0)]
			public float TweenTarget;

			// Token: 0x04031281 RID: 201345
			[FieldOffset(4)]
			public float TweenSpeed;

			// Token: 0x04031282 RID: 201346
			[FieldOffset(8)]
			public float TweenDeltaSecond;
		}

		// Token: 0x02009BEB RID: 39915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __UpdatePlayerSEEnvironmentFactor_FunctionParams
		{
			// Token: 0x04031283 RID: 201347
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}

		// Token: 0x02009BEC RID: 39916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitPlayer_FunctionParams
		{
			// Token: 0x04031284 RID: 201348
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x04031285 RID: 201349
			[FieldOffset(8)]
			public IntPtr ScreenEffectRoot;
		}

		// Token: 0x02009BED RID: 39917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Set_Effect_Hidden_FunctionParams
		{
			// Token: 0x04031286 RID: 201350
			[FieldOffset(0)]
			public bool bToHide;

			// Token: 0x04031287 RID: 201351
			[FieldOffset(1)]
			public bool bOverrideFadeSpeed;

			// Token: 0x04031288 RID: 201352
			[FieldOffset(4)]
			public float OverrideFadeSpeed;
		}

		// Token: 0x02009BEE RID: 39918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SetUIVisible_FunctionParams
		{
			// Token: 0x04031289 RID: 201353
			[FieldOffset(0)]
			public bool Visible;
		}

		// Token: 0x02009BEF RID: 39919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TweenParameter_FunctionParams
		{
			// Token: 0x0403128A RID: 201354
			[FieldOffset(0)]
			public float TweenTarget;
		}

		// Token: 0x02009BF0 RID: 39920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TweenParameterImmediately_FunctionParams
		{
			// Token: 0x0403128B RID: 201355
			[FieldOffset(0)]
			public float TweenTarget;
		}

		// Token: 0x02009BF1 RID: 39921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403128C RID: 201356
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BF2 RID: 39922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403128D RID: 201357
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
