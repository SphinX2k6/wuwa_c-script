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
	// Token: 0x020030AF RID: 12463
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1177)]
	public class BP_ScreenEffectPlayer_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE73 RID: 122483 RVA: 0x00905453 File Offset: 0x00903653
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ScreenEffectPlayer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C");
			}
			return BP_ScreenEffectPlayer_C._ClassPtr;
		}

		// Token: 0x0601DE74 RID: 122484 RVA: 0x00905478 File Offset: 0x00903678
		public BP_ScreenEffectPlayer_C() : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectPlayer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE75 RID: 122485 RVA: 0x009054A0 File Offset: 0x009036A0
		[NullableContext(1)]
		public BP_ScreenEffectPlayer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectPlayer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0601DE76 RID: 122486 RVA: 0x009054D3 File Offset: 0x009036D3
		// (set) Token: 0x0601DE77 RID: 122487 RVA: 0x009054E7 File Offset: 0x009036E7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0601DE78 RID: 122488 RVA: 0x009054FC File Offset: 0x009036FC
		// (set) Token: 0x0601DE79 RID: 122489 RVA: 0x00905510 File Offset: 0x00903710
		[Nullable(2)]
		public unsafe EffectScreenPlayData_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_Data);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0601DE7A RID: 122490 RVA: 0x00905525 File Offset: 0x00903725
		// (set) Token: 0x0601DE7B RID: 122491 RVA: 0x00905539 File Offset: 0x00903739
		public unsafe TEnumAsByte<E_SE_PlayState> State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_State);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_State) = value;
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0601DE7C RID: 122492 RVA: 0x0090554E File Offset: 0x0090374E
		// (set) Token: 0x0601DE7D RID: 122493 RVA: 0x0090555E File Offset: 0x0090375E
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_TimeCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_TimeCounter) = value;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0601DE7E RID: 122494 RVA: 0x0090556F File Offset: 0x0090376F
		// (set) Token: 0x0601DE7F RID: 122495 RVA: 0x00905583 File Offset: 0x00903783
		[Nullable(2)]
		public unsafe AActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_TargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0601DE80 RID: 122496 RVA: 0x00905598 File Offset: 0x00903798
		// (set) Token: 0x0601DE81 RID: 122497 RVA: 0x009055D1 File Offset: 0x009037D1
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
					result = (this._CachedComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_CachedComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0601DE82 RID: 122498 RVA: 0x009055DF File Offset: 0x009037DF
		// (set) Token: 0x0601DE83 RID: 122499 RVA: 0x009055EF File Offset: 0x009037EF
		public unsafe bool bToHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bToHide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bToHide) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0601DE84 RID: 122500 RVA: 0x00905600 File Offset: 0x00903800
		// (set) Token: 0x0601DE85 RID: 122501 RVA: 0x00905610 File Offset: 0x00903810
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0601DE86 RID: 122502 RVA: 0x00905621 File Offset: 0x00903821
		// (set) Token: 0x0601DE87 RID: 122503 RVA: 0x00905631 File Offset: 0x00903831
		public unsafe float FadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_FadeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_FadeSpeed) = value;
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0601DE88 RID: 122504 RVA: 0x00905642 File Offset: 0x00903842
		// (set) Token: 0x0601DE89 RID: 122505 RVA: 0x00905652 File Offset: 0x00903852
		public unsafe float FadeOutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_FadeOutSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_FadeOutSpeed) = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0601DE8A RID: 122506 RVA: 0x00905664 File Offset: 0x00903864
		// (set) Token: 0x0601DE8B RID: 122507 RVA: 0x0090569D File Offset: 0x0090389D
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
					result = (this._CachedUIActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_CachedUIActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedUIActors.CopyAssign(value);
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0601DE8C RID: 122508 RVA: 0x009056AB File Offset: 0x009038AB
		// (set) Token: 0x0601DE8D RID: 122509 RVA: 0x009056BB File Offset: 0x009038BB
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0601DE8E RID: 122510 RVA: 0x009056CC File Offset: 0x009038CC
		// (set) Token: 0x0601DE8F RID: 122511 RVA: 0x009056E0 File Offset: 0x009038E0
		[Nullable(2)]
		public unsafe AUIContainerActor ScreenEffectRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_ScreenEffectRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectPlayer_C.__PropertyOffset_ScreenEffectRoot, value);
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0601DE90 RID: 122512 RVA: 0x009056F5 File Offset: 0x009038F5
		// (set) Token: 0x0601DE91 RID: 122513 RVA: 0x00905705 File Offset: 0x00903905
		public unsafe bool bNeedToDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bNeedToDestroy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_bNeedToDestroy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0601DE92 RID: 122514 RVA: 0x00905716 File Offset: 0x00903916
		// (set) Token: 0x0601DE93 RID: 122515 RVA: 0x00905726 File Offset: 0x00903926
		public unsafe float CacheEnvironmentFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_CacheEnvironmentFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_CacheEnvironmentFactor) = value;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0601DE94 RID: 122516 RVA: 0x00905737 File Offset: 0x00903937
		// (set) Token: 0x0601DE95 RID: 122517 RVA: 0x00905747 File Offset: 0x00903947
		public unsafe float ParameterTweenProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenProgress) = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0601DE96 RID: 122518 RVA: 0x00905758 File Offset: 0x00903958
		// (set) Token: 0x0601DE97 RID: 122519 RVA: 0x00905768 File Offset: 0x00903968
		public unsafe float ParameterTweenSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenSpeed) = value;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0601DE98 RID: 122520 RVA: 0x00905779 File Offset: 0x00903979
		// (set) Token: 0x0601DE99 RID: 122521 RVA: 0x00905789 File Offset: 0x00903989
		public unsafe float ParameterTweenTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_ParameterTweenTarget) = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0601DE9A RID: 122522 RVA: 0x0090579A File Offset: 0x0090399A
		// (set) Token: 0x0601DE9B RID: 122523 RVA: 0x009057AA File Offset: 0x009039AA
		public unsafe float NiagaraFrameDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_NiagaraFrameDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_NiagaraFrameDeltaTime) = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0601DE9C RID: 122524 RVA: 0x009057BB File Offset: 0x009039BB
		// (set) Token: 0x0601DE9D RID: 122525 RVA: 0x009057CB File Offset: 0x009039CB
		public unsafe bool NiagaraFrameDeltaTimeDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_NiagaraFrameDeltaTimeDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectPlayer_C.__PropertyOffset_NiagaraFrameDeltaTimeDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DE9E RID: 122526 RVA: 0x009057DC File Offset: 0x009039DC
		[SkipLocalsInit]
		public unsafe virtual void SetNiagaraFrameDeltaTime(float DeltaTime)
		{
			BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE9F RID: 122527 RVA: 0x00905824 File Offset: 0x00903A24
		[SkipLocalsInit]
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

		// Token: 0x0601DEA0 RID: 122528 RVA: 0x00905884 File Offset: 0x00903A84
		[SkipLocalsInit]
		public unsafe virtual void SetExtraState(int ExtraState)
		{
			BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetExtraState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetExtraState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ExtraState = ExtraState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetExtraState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEA1 RID: 122529 RVA: 0x009058D0 File Offset: 0x00903AD0
		[SkipLocalsInit]
		public unsafe virtual void Refresh_Addition_Parameter(float TweenProgress)
		{
			BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams[(UIntPtr)911] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenProgress = TweenProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Refresh_Addition_Parameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEA2 RID: 122530 RVA: 0x0090591C File Offset: 0x00903B1C
		[SkipLocalsInit]
		public unsafe virtual void TweenParameterSpeed(float TweenTarget, float TweenSpeed, float TweenDeltaSecond)
		{
			BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameterSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameterSpeed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			ptr->TweenSpeed = TweenSpeed;
			ptr->TweenDeltaSecond = TweenDeltaSecond;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameterSpeed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEA3 RID: 122531 RVA: 0x00905970 File Offset: 0x00903B70
		[SkipLocalsInit]
		public virtual void BP_ScreenEffectPlayer_AutoGenFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__BP_ScreenEffectPlayer_AutoGenFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x00905984 File Offset: 0x00903B84
		[SkipLocalsInit]
		public virtual void DelayEndAudioCall()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__DelayEndAudioCall_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEA5 RID: 122533 RVA: 0x00905998 File Offset: 0x00903B98
		[SkipLocalsInit]
		public unsafe virtual void UpdatePlayerSEEnvironmentFactor(float EnvironmentFactor)
		{
			BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEA6 RID: 122534 RVA: 0x009059E1 File Offset: 0x00903BE1
		[SkipLocalsInit]
		public virtual void Destroy_Player()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Destroy_Player_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEA7 RID: 122535 RVA: 0x009059F5 File Offset: 0x00903BF5
		[SkipLocalsInit]
		public virtual void ClearPlayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ClearPlayer_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEA8 RID: 122536 RVA: 0x00905A0C File Offset: 0x00903C0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void InitPlayer(EffectScreenPlayData_C Data, AUIContainerActor ScreenEffectRoot)
		{
			BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__InitPlayer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__InitPlayer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->ScreenEffectRoot = ((ScreenEffectRoot != null) ? ScreenEffectRoot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__InitPlayer_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEA9 RID: 122537 RVA: 0x00905A77 File Offset: 0x00903C77
		[SkipLocalsInit]
		public virtual void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEAA RID: 122538 RVA: 0x00905A8C File Offset: 0x00903C8C
		[SkipLocalsInit]
		public unsafe virtual void Set_Effect_Hidden(bool bToHide, bool bOverrideFadeSpeed, float OverrideFadeSpeed)
		{
			BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bToHide = bToHide;
			ptr->bOverrideFadeSpeed = bOverrideFadeSpeed;
			ptr->OverrideFadeSpeed = OverrideFadeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Set_Effect_Hidden_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEAB RID: 122539 RVA: 0x00905AE0 File Offset: 0x00903CE0
		[SkipLocalsInit]
		public unsafe virtual void SetUIVisible(bool Visible)
		{
			BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__SetUIVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__SetUIVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visible = Visible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__SetUIVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEAC RID: 122540 RVA: 0x00905B26 File Offset: 0x00903D26
		[SkipLocalsInit]
		public virtual void UpdateComponentsAlpha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdateComponentsAlpha_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEAD RID: 122541 RVA: 0x00905B3A File Offset: 0x00903D3A
		[SkipLocalsInit]
		public virtual void UpdateComponents()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UpdateComponents_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEAE RID: 122542 RVA: 0x00905B4E File Offset: 0x00903D4E
		[SkipLocalsInit]
		public virtual void EndPlayer()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__EndPlayer_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEAF RID: 122543 RVA: 0x00905B62 File Offset: 0x00903D62
		[SkipLocalsInit]
		public virtual void Start_Player()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__Start_Player_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEB0 RID: 122544 RVA: 0x00905B78 File Offset: 0x00903D78
		[SkipLocalsInit]
		public unsafe virtual void TweenParameter(float TweenTarget)
		{
			BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEB1 RID: 122545 RVA: 0x00905BC0 File Offset: 0x00903DC0
		[SkipLocalsInit]
		public unsafe virtual void TweenParameterImmediately(float TweenTarget)
		{
			BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__TweenParameterImmediately_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__TweenParameterImmediately_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TweenTarget = TweenTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__TweenParameterImmediately_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEB2 RID: 122546 RVA: 0x00905C06 File Offset: 0x00903E06
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEB3 RID: 122547 RVA: 0x00905C1A File Offset: 0x00903E1A
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEB4 RID: 122548 RVA: 0x00905C2E File Offset: 0x00903E2E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEB5 RID: 122549 RVA: 0x00905C42 File Offset: 0x00903E42
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEB6 RID: 122550 RVA: 0x00905C58 File Offset: 0x00903E58
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEB7 RID: 122551 RVA: 0x00905CA0 File Offset: 0x00903EA0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEB8 RID: 122552 RVA: 0x00905CE8 File Offset: 0x00903EE8
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEB9 RID: 122553 RVA: 0x00905D34 File Offset: 0x00903F34
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectPlayer_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEBA RID: 122554 RVA: 0x00905D7F File Offset: 0x00903F7F
		protected BP_ScreenEffectPlayer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC97 RID: 64663
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectPlayer.BP_ScreenEffectPlayer_C";

		// Token: 0x0400FC98 RID: 64664
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC99 RID: 64665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC9A RID: 64666
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FC9B RID: 64667
		internal static int __PropertyOffset_Data;

		// Token: 0x0400FC9C RID: 64668
		internal static int __PropertyOffset_State;

		// Token: 0x0400FC9D RID: 64669
		internal static int __PropertyOffset_TimeCounter;

		// Token: 0x0400FC9E RID: 64670
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0400FC9F RID: 64671
		internal static int __PropertyOffset_CachedComponents;

		// Token: 0x0400FCA0 RID: 64672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _CachedComponents;

		// Token: 0x0400FCA1 RID: 64673
		internal static int __PropertyOffset_bToHide;

		// Token: 0x0400FCA2 RID: 64674
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400FCA3 RID: 64675
		internal static int __PropertyOffset_FadeSpeed;

		// Token: 0x0400FCA4 RID: 64676
		internal static int __PropertyOffset_FadeOutSpeed;

		// Token: 0x0400FCA5 RID: 64677
		internal static int __PropertyOffset_CachedUIActors;

		// Token: 0x0400FCA6 RID: 64678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _CachedUIActors;

		// Token: 0x0400FCA7 RID: 64679
		internal static int __PropertyOffset_bVisible;

		// Token: 0x0400FCA8 RID: 64680
		internal static int __PropertyOffset_ScreenEffectRoot;

		// Token: 0x0400FCA9 RID: 64681
		internal static int __PropertyOffset_bNeedToDestroy;

		// Token: 0x0400FCAA RID: 64682
		internal static int __PropertyOffset_CacheEnvironmentFactor;

		// Token: 0x0400FCAB RID: 64683
		internal static int __PropertyOffset_ParameterTweenProgress;

		// Token: 0x0400FCAC RID: 64684
		internal static int __PropertyOffset_ParameterTweenSpeed;

		// Token: 0x0400FCAD RID: 64685
		internal static int __PropertyOffset_ParameterTweenTarget;

		// Token: 0x0400FCAE RID: 64686
		internal static int __PropertyOffset_NiagaraFrameDeltaTime;

		// Token: 0x0400FCAF RID: 64687
		internal static int __PropertyOffset_NiagaraFrameDeltaTimeDirty;

		// Token: 0x0400FCB0 RID: 64688
		private static IntPtr __SetNiagaraFrameDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FCB1 RID: 64689
		private static IntPtr __AlmostEqual_NativeFunctionPtr;

		// Token: 0x0400FCB2 RID: 64690
		private static IntPtr __SetExtraState_NativeFunctionPtr;

		// Token: 0x0400FCB3 RID: 64691
		private static IntPtr __Refresh_Addition_Parameter_NativeFunctionPtr;

		// Token: 0x0400FCB4 RID: 64692
		private static IntPtr __TweenParameterSpeed_NativeFunctionPtr;

		// Token: 0x0400FCB5 RID: 64693
		private static IntPtr __BP_ScreenEffectPlayer_AutoGenFunc_NativeFunctionPtr;

		// Token: 0x0400FCB6 RID: 64694
		private static IntPtr __DelayEndAudioCall_NativeFunctionPtr;

		// Token: 0x0400FCB7 RID: 64695
		private static IntPtr __UpdatePlayerSEEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x0400FCB8 RID: 64696
		private static IntPtr __Destroy_Player_NativeFunctionPtr;

		// Token: 0x0400FCB9 RID: 64697
		private static IntPtr __ClearPlayer_NativeFunctionPtr;

		// Token: 0x0400FCBA RID: 64698
		private static IntPtr __InitPlayer_NativeFunctionPtr;

		// Token: 0x0400FCBB RID: 64699
		private static IntPtr __BeforeStart_NativeFunctionPtr;

		// Token: 0x0400FCBC RID: 64700
		private static IntPtr __Set_Effect_Hidden_NativeFunctionPtr;

		// Token: 0x0400FCBD RID: 64701
		private static IntPtr __SetUIVisible_NativeFunctionPtr;

		// Token: 0x0400FCBE RID: 64702
		private static IntPtr __UpdateComponentsAlpha_NativeFunctionPtr;

		// Token: 0x0400FCBF RID: 64703
		private static IntPtr __UpdateComponents_NativeFunctionPtr;

		// Token: 0x0400FCC0 RID: 64704
		private static IntPtr __EndPlayer_NativeFunctionPtr;

		// Token: 0x0400FCC1 RID: 64705
		private static IntPtr __Start_Player_NativeFunctionPtr;

		// Token: 0x0400FCC2 RID: 64706
		private static IntPtr __TweenParameter_NativeFunctionPtr;

		// Token: 0x0400FCC3 RID: 64707
		private static IntPtr __TweenParameterImmediately_NativeFunctionPtr;

		// Token: 0x0400FCC4 RID: 64708
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FCC5 RID: 64709
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCC6 RID: 64710
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FCC7 RID: 64711
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008DD4 RID: 36308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetNiagaraFrameDeltaTime_FunctionParams
		{
			// Token: 0x0402C9E6 RID: 182758
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008DD5 RID: 36309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AlmostEqual_FunctionParams
		{
			// Token: 0x0402C9E7 RID: 182759
			[FieldOffset(0)]
			public float val1;

			// Token: 0x0402C9E8 RID: 182760
			[FieldOffset(4)]
			public float val2;

			// Token: 0x0402C9E9 RID: 182761
			[FieldOffset(8)]
			public bool isequal;
		}

		// Token: 0x02008DD6 RID: 36310
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __SetExtraState_FunctionParams
		{
			// Token: 0x0402C9EA RID: 182762
			[FieldOffset(0)]
			public int ExtraState;
		}

		// Token: 0x02008DD7 RID: 36311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 896)]
		protected ref struct __Refresh_Addition_Parameter_FunctionParams
		{
			// Token: 0x0402C9EB RID: 182763
			[FieldOffset(0)]
			public float TweenProgress;
		}

		// Token: 0x02008DD8 RID: 36312
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __TweenParameterSpeed_FunctionParams
		{
			// Token: 0x0402C9EC RID: 182764
			[FieldOffset(0)]
			public float TweenTarget;

			// Token: 0x0402C9ED RID: 182765
			[FieldOffset(4)]
			public float TweenSpeed;

			// Token: 0x0402C9EE RID: 182766
			[FieldOffset(8)]
			public float TweenDeltaSecond;
		}

		// Token: 0x02008DD9 RID: 36313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __UpdatePlayerSEEnvironmentFactor_FunctionParams
		{
			// Token: 0x0402C9EF RID: 182767
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}

		// Token: 0x02008DDA RID: 36314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitPlayer_FunctionParams
		{
			// Token: 0x0402C9F0 RID: 182768
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x0402C9F1 RID: 182769
			[FieldOffset(8)]
			public IntPtr ScreenEffectRoot;
		}

		// Token: 0x02008DDB RID: 36315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Set_Effect_Hidden_FunctionParams
		{
			// Token: 0x0402C9F2 RID: 182770
			[FieldOffset(0)]
			public bool bToHide;

			// Token: 0x0402C9F3 RID: 182771
			[FieldOffset(1)]
			public bool bOverrideFadeSpeed;

			// Token: 0x0402C9F4 RID: 182772
			[FieldOffset(4)]
			public float OverrideFadeSpeed;
		}

		// Token: 0x02008DDC RID: 36316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SetUIVisible_FunctionParams
		{
			// Token: 0x0402C9F5 RID: 182773
			[FieldOffset(0)]
			public bool Visible;
		}

		// Token: 0x02008DDD RID: 36317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TweenParameter_FunctionParams
		{
			// Token: 0x0402C9F6 RID: 182774
			[FieldOffset(0)]
			public float TweenTarget;
		}

		// Token: 0x02008DDE RID: 36318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TweenParameterImmediately_FunctionParams
		{
			// Token: 0x0402C9F7 RID: 182775
			[FieldOffset(0)]
			public float TweenTarget;
		}

		// Token: 0x02008DDF RID: 36319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C9F8 RID: 182776
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008DE0 RID: 36320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402C9F9 RID: 182777
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
