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
	// Token: 0x020030B0 RID: 12464
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1644)]
	public class BP_ScreenEffectSystem_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEBB RID: 122555 RVA: 0x00905D88 File Offset: 0x00903F88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ScreenEffectSystem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C");
			}
			return BP_ScreenEffectSystem_C._ClassPtr;
		}

		// Token: 0x0601DEBC RID: 122556 RVA: 0x00905DAC File Offset: 0x00903FAC
		public BP_ScreenEffectSystem_C() : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectSystem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEBD RID: 122557 RVA: 0x00905DD4 File Offset: 0x00903FD4
		[NullableContext(1)]
		public BP_ScreenEffectSystem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectSystem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0601DEBE RID: 122558 RVA: 0x00905E07 File Offset: 0x00904007
		// (set) Token: 0x0601DEBF RID: 122559 RVA: 0x00905E1B File Offset: 0x0090401B
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0601DEC0 RID: 122560 RVA: 0x00905E30 File Offset: 0x00904030
		// (set) Token: 0x0601DEC1 RID: 122561 RVA: 0x00905E44 File Offset: 0x00904044
		public unsafe EffectScreenPlayData_C DebugData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_DebugData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_DebugData, value);
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0601DEC2 RID: 122562 RVA: 0x00905E5C File Offset: 0x0090405C
		// (set) Token: 0x0601DEC3 RID: 122563 RVA: 0x00905E95 File Offset: 0x00904095
		[Nullable(1)]
		public TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C> Effects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_Effects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0601DEC4 RID: 122564 RVA: 0x00905EA4 File Offset: 0x009040A4
		// (set) Token: 0x0601DEC5 RID: 122565 RVA: 0x00905EDD File Offset: 0x009040DD
		[Nullable(1)]
		public TArray<EffectScreenPlayData_C> OrderDatas
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<EffectScreenPlayData_C> result;
				if ((result = this._OrderDatas) == null)
				{
					result = (this._OrderDatas = new TArray<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_OrderDatas, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OrderDatas.CopyAssign(value);
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0601DEC6 RID: 122566 RVA: 0x00905EEC File Offset: 0x009040EC
		// (set) Token: 0x0601DEC7 RID: 122567 RVA: 0x00905F25 File Offset: 0x00904125
		[Nullable(1)]
		public TArray<EffectScreenPlayData_C> IndependentDatas
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<EffectScreenPlayData_C> result;
				if ((result = this._IndependentDatas) == null)
				{
					result = (this._IndependentDatas = new TArray<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_IndependentDatas, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IndependentDatas.CopyAssign(value);
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0601DEC8 RID: 122568 RVA: 0x00905F33 File Offset: 0x00904133
		// (set) Token: 0x0601DEC9 RID: 122569 RVA: 0x00905F43 File Offset: 0x00904143
		public unsafe bool bEvaluateOrderEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_bEvaluateOrderEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_bEvaluateOrderEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0601DECA RID: 122570 RVA: 0x00905F54 File Offset: 0x00904154
		// (set) Token: 0x0601DECB RID: 122571 RVA: 0x00905F68 File Offset: 0x00904168
		public unsafe AUIContainerActor EditorScreenRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_EditorScreenRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_EditorScreenRoot, value);
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0601DECC RID: 122572 RVA: 0x00905F7D File Offset: 0x0090417D
		// (set) Token: 0x0601DECD RID: 122573 RVA: 0x00905F91 File Offset: 0x00904191
		public unsafe AUIContainerActor ScreenEffectFightRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectFightRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectFightRoot, value);
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0601DECE RID: 122574 RVA: 0x00905FA6 File Offset: 0x009041A6
		// (set) Token: 0x0601DECF RID: 122575 RVA: 0x00905FBA File Offset: 0x009041BA
		public unsafe AUIContainerActor ScreenEffectPlotRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectPlotRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectPlotRoot, value);
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0601DED0 RID: 122576 RVA: 0x00905FCF File Offset: 0x009041CF
		// (set) Token: 0x0601DED1 RID: 122577 RVA: 0x00905FDF File Offset: 0x009041DF
		public unsafe float EnvironmentFactorDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_EnvironmentFactorDebug);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_EnvironmentFactorDebug) = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0601DED2 RID: 122578 RVA: 0x00905FF0 File Offset: 0x009041F0
		// (set) Token: 0x0601DED3 RID: 122579 RVA: 0x00906004 File Offset: 0x00904204
		public unsafe AUIContainerActor ScreenEffectGeneralRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectGeneralRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectGeneralRoot, value);
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0601DED4 RID: 122580 RVA: 0x00906019 File Offset: 0x00904219
		// (set) Token: 0x0601DED5 RID: 122581 RVA: 0x00906029 File Offset: 0x00904229
		public unsafe int DebugExtraState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_DebugExtraState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_DebugExtraState) = value;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0601DED6 RID: 122582 RVA: 0x0090603A File Offset: 0x0090423A
		// (set) Token: 0x0601DED7 RID: 122583 RVA: 0x0090604E File Offset: 0x0090424E
		public unsafe AUIContainerActor ScreenEffectCoverLoadingRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectCoverLoadingRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_ScreenEffectCoverLoadingRoot, value);
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0601DED8 RID: 122584 RVA: 0x00906063 File Offset: 0x00904263
		// (set) Token: 0x0601DED9 RID: 122585 RVA: 0x00906073 File Offset: 0x00904273
		public unsafe float NiagaraFrameDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_NiagaraFrameDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_NiagaraFrameDeltaTime) = value;
			}
		}

		// Token: 0x0601DEDA RID: 122586 RVA: 0x00906084 File Offset: 0x00904284
		[SkipLocalsInit]
		public unsafe virtual void SetNiagaraFrameDeltaTime(float DeltaTime)
		{
			BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEDB RID: 122587 RVA: 0x009060CA File Offset: 0x009042CA
		[SkipLocalsInit]
		public virtual void SetEffectExtraStateDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetEffectExtraStateDebug_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEDC RID: 122588 RVA: 0x009060E0 File Offset: 0x009042E0
		[SkipLocalsInit]
		public unsafe virtual void SetEffectExtraState(EffectScreenPlayData_C EffectScreenPlayData, int ExtraState)
		{
			BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetEffectExtraState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectScreenPlayData = ((EffectScreenPlayData != null) ? EffectScreenPlayData.NativePtr : IntPtr.Zero);
			ptr->ExtraState = ExtraState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetEffectExtraState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEDD RID: 122589 RVA: 0x0090613C File Offset: 0x0090433C
		[SkipLocalsInit]
		public unsafe virtual void TweenEffectParameter(EffectScreenPlayData_C EffectScreenPlayData, float targetProgress)
		{
			BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__TweenEffectParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectScreenPlayData = ((EffectScreenPlayData != null) ? EffectScreenPlayData.NativePtr : IntPtr.Zero);
			ptr->targetProgress = targetProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__TweenEffectParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEDE RID: 122590 RVA: 0x00906198 File Offset: 0x00904398
		[SkipLocalsInit]
		public virtual void UpdateEnvironmentFactorDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateEnvironmentFactorDebug_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEDF RID: 122591 RVA: 0x009061AC File Offset: 0x009043AC
		[SkipLocalsInit]
		public unsafe virtual void UpdateSEEnvironmentFactor(EffectScreenPlayData_C Data, float EnvironmentFactor)
		{
			BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEE0 RID: 122592 RVA: 0x00906208 File Offset: 0x00904408
		[SkipLocalsInit]
		public unsafe virtual void DestroyScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__DestroyScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__DestroyScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEE1 RID: 122593 RVA: 0x00906260 File Offset: 0x00904460
		[SkipLocalsInit]
		public unsafe virtual void SpawnPlayer(EffectScreenPlayData_C Data, ref BP_ScreenEffectPlayer_C OutputPlayer)
		{
			BP_ScreenEffectSystem_C.__SpawnPlayer_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SpawnPlayer_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SpawnPlayer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SpawnPlayer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ref BP_ScreenEffectSystem_C.__SpawnPlayer_FunctionParams ptr2 = ref *ptr;
			BP_ScreenEffectPlayer_C bp_ScreenEffectPlayer_C = OutputPlayer;
			ptr2.OutputPlayer = ((bp_ScreenEffectPlayer_C != null) ? bp_ScreenEffectPlayer_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SpawnPlayer_NativeFunctionPtr, (void*)ptr);
			OutputPlayer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ScreenEffectPlayer_C>(ptr->OutputPlayer);
		}

		// Token: 0x0601DEE2 RID: 122594 RVA: 0x009062E0 File Offset: 0x009044E0
		[SkipLocalsInit]
		public unsafe virtual void GetScreenEffectCoverLoadingRoot(ref AUIContainerActor ScreenEffectCoverLoadingRoot)
		{
			BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_FunctionParams ptr2 = ref *ptr;
			AUIContainerActor auicontainerActor = ScreenEffectCoverLoadingRoot;
			ptr2.ScreenEffectCoverLoadingRoot = ((auicontainerActor != null) ? auicontainerActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__GetScreenEffectCoverLoadingRoot_NativeFunctionPtr, (void*)ptr);
			ScreenEffectCoverLoadingRoot = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIContainerActor>(ptr->ScreenEffectCoverLoadingRoot);
		}

		// Token: 0x0601DEE3 RID: 122595 RVA: 0x00906344 File Offset: 0x00904544
		[SkipLocalsInit]
		public virtual void Init_SECoverLoadingRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SECoverLoadingRoot_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEE4 RID: 122596 RVA: 0x00906358 File Offset: 0x00904558
		[SkipLocalsInit]
		public unsafe virtual void GetScreenEffectGeneralRoot(ref AUIContainerActor ScreenEffectGeneralRoot)
		{
			BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_FunctionParams ptr2 = ref *ptr;
			AUIContainerActor auicontainerActor = ScreenEffectGeneralRoot;
			ptr2.ScreenEffectGeneralRoot = ((auicontainerActor != null) ? auicontainerActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__GetScreenEffectGeneralRoot_NativeFunctionPtr, (void*)ptr);
			ScreenEffectGeneralRoot = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIContainerActor>(ptr->ScreenEffectGeneralRoot);
		}

		// Token: 0x0601DEE5 RID: 122597 RVA: 0x009063BC File Offset: 0x009045BC
		[SkipLocalsInit]
		public virtual void Init_SEGeneralRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEGeneralRoot_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEE6 RID: 122598 RVA: 0x009063D0 File Offset: 0x009045D0
		[SkipLocalsInit]
		public unsafe virtual void GetScreenEffectPlotRoot(ref AUIContainerActor ScreenEffectPlotRoot)
		{
			BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_FunctionParams ptr2 = ref *ptr;
			AUIContainerActor auicontainerActor = ScreenEffectPlotRoot;
			ptr2.ScreenEffectPlotRoot = ((auicontainerActor != null) ? auicontainerActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__GetScreenEffectPlotRoot_NativeFunctionPtr, (void*)ptr);
			ScreenEffectPlotRoot = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIContainerActor>(ptr->ScreenEffectPlotRoot);
		}

		// Token: 0x0601DEE7 RID: 122599 RVA: 0x00906434 File Offset: 0x00904634
		[SkipLocalsInit]
		public virtual void Init_SEPlotRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEPlotRoot_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEE8 RID: 122600 RVA: 0x00906448 File Offset: 0x00904648
		[SkipLocalsInit]
		public unsafe virtual void GetScreenEffectFightRoot(ref AUIContainerActor ScreenEffectFightRoot)
		{
			BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_FunctionParams ptr2 = ref *ptr;
			AUIContainerActor auicontainerActor = ScreenEffectFightRoot;
			ptr2.ScreenEffectFightRoot = ((auicontainerActor != null) ? auicontainerActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__GetScreenEffectFightRoot_NativeFunctionPtr, (void*)ptr);
			ScreenEffectFightRoot = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIContainerActor>(ptr->ScreenEffectFightRoot);
		}

		// Token: 0x0601DEE9 RID: 122601 RVA: 0x009064AC File Offset: 0x009046AC
		[SkipLocalsInit]
		public virtual void Init_SEFight_Root()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEFight_Root_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEEA RID: 122602 RVA: 0x009064C0 File Offset: 0x009046C0
		[SkipLocalsInit]
		public virtual void UpdateLGUIMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateLGUIMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEEB RID: 122603 RVA: 0x009064D4 File Offset: 0x009046D4
		[SkipLocalsInit]
		public virtual void ClearSystem()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ClearSystem_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEEC RID: 122604 RVA: 0x009064E8 File Offset: 0x009046E8
		[SkipLocalsInit]
		public unsafe virtual void SetVisibilityOfSystem(bool Visibility, bool bOverrideFadeSpeed, float OverrideFadeSpeed)
		{
			BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visibility = Visibility;
			ptr->bOverrideFadeSpeed = bOverrideFadeSpeed;
			ptr->OverrideFadeSpeed = OverrideFadeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEED RID: 122605 RVA: 0x0090653C File Offset: 0x0090473C
		[SkipLocalsInit]
		public virtual void EndEffectDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EndEffectDebug_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEEE RID: 122606 RVA: 0x00906550 File Offset: 0x00904750
		[SkipLocalsInit]
		public unsafe virtual void EndScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__EndScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EndScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEEF RID: 122607 RVA: 0x009065A5 File Offset: 0x009047A5
		[SkipLocalsInit]
		public virtual void EvaluateOrderEffects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EvaluateOrderEffects_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEF0 RID: 122608 RVA: 0x009065BC File Offset: 0x009047BC
		[SkipLocalsInit]
		public unsafe virtual void PlayScreenEffectNoPaused(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEF1 RID: 122609 RVA: 0x00906611 File Offset: 0x00904811
		[SkipLocalsInit]
		public virtual void PlayEffectDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayEffectDebug_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEF2 RID: 122610 RVA: 0x00906628 File Offset: 0x00904828
		[SkipLocalsInit]
		public unsafe virtual void PlayScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__PlayScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEF3 RID: 122611 RVA: 0x00906680 File Offset: 0x00904880
		[SkipLocalsInit]
		public unsafe virtual void AddEffect(EffectScreenPlayData_C Data, bool TickWhenPaused, ref BP_ScreenEffectPlayer_C EffectPlayer)
		{
			BP_ScreenEffectSystem_C.__AddEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__AddEffect_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__AddEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__AddEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->TickWhenPaused = TickWhenPaused;
			ref BP_ScreenEffectSystem_C.__AddEffect_FunctionParams ptr2 = ref *ptr;
			BP_ScreenEffectPlayer_C bp_ScreenEffectPlayer_C = EffectPlayer;
			ptr2.EffectPlayer = ((bp_ScreenEffectPlayer_C != null) ? bp_ScreenEffectPlayer_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__AddEffect_NativeFunctionPtr, (void*)ptr);
			EffectPlayer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ScreenEffectPlayer_C>(ptr->EffectPlayer);
		}

		// Token: 0x0601DEF4 RID: 122612 RVA: 0x00906704 File Offset: 0x00904904
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEF5 RID: 122613 RVA: 0x00906718 File Offset: 0x00904918
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DEF6 RID: 122614 RVA: 0x0090672C File Offset: 0x0090492C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEF7 RID: 122615 RVA: 0x00906774 File Offset: 0x00904974
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DEF8 RID: 122616 RVA: 0x009067BA File Offset: 0x009049BA
		protected BP_ScreenEffectSystem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCC8 RID: 64712
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C";

		// Token: 0x0400FCC9 RID: 64713
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCCA RID: 64714
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCCB RID: 64715
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FCCC RID: 64716
		internal static int __PropertyOffset_DebugData;

		// Token: 0x0400FCCD RID: 64717
		internal static int __PropertyOffset_Effects;

		// Token: 0x0400FCCE RID: 64718
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C> _Effects;

		// Token: 0x0400FCCF RID: 64719
		internal static int __PropertyOffset_OrderDatas;

		// Token: 0x0400FCD0 RID: 64720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<EffectScreenPlayData_C> _OrderDatas;

		// Token: 0x0400FCD1 RID: 64721
		internal static int __PropertyOffset_IndependentDatas;

		// Token: 0x0400FCD2 RID: 64722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<EffectScreenPlayData_C> _IndependentDatas;

		// Token: 0x0400FCD3 RID: 64723
		internal static int __PropertyOffset_bEvaluateOrderEffects;

		// Token: 0x0400FCD4 RID: 64724
		internal static int __PropertyOffset_EditorScreenRoot;

		// Token: 0x0400FCD5 RID: 64725
		internal static int __PropertyOffset_ScreenEffectFightRoot;

		// Token: 0x0400FCD6 RID: 64726
		internal static int __PropertyOffset_ScreenEffectPlotRoot;

		// Token: 0x0400FCD7 RID: 64727
		internal static int __PropertyOffset_EnvironmentFactorDebug;

		// Token: 0x0400FCD8 RID: 64728
		internal static int __PropertyOffset_ScreenEffectGeneralRoot;

		// Token: 0x0400FCD9 RID: 64729
		internal static int __PropertyOffset_DebugExtraState;

		// Token: 0x0400FCDA RID: 64730
		internal static int __PropertyOffset_ScreenEffectCoverLoadingRoot;

		// Token: 0x0400FCDB RID: 64731
		internal static int __PropertyOffset_NiagaraFrameDeltaTime;

		// Token: 0x0400FCDC RID: 64732
		private static IntPtr __SetNiagaraFrameDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FCDD RID: 64733
		private static IntPtr __SetEffectExtraStateDebug_NativeFunctionPtr;

		// Token: 0x0400FCDE RID: 64734
		private static IntPtr __SetEffectExtraState_NativeFunctionPtr;

		// Token: 0x0400FCDF RID: 64735
		private static IntPtr __TweenEffectParameter_NativeFunctionPtr;

		// Token: 0x0400FCE0 RID: 64736
		private static IntPtr __UpdateEnvironmentFactorDebug_NativeFunctionPtr;

		// Token: 0x0400FCE1 RID: 64737
		private static IntPtr __UpdateSEEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x0400FCE2 RID: 64738
		private static IntPtr __DestroyScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FCE3 RID: 64739
		private static IntPtr __SpawnPlayer_NativeFunctionPtr;

		// Token: 0x0400FCE4 RID: 64740
		private static IntPtr __GetScreenEffectCoverLoadingRoot_NativeFunctionPtr;

		// Token: 0x0400FCE5 RID: 64741
		private static IntPtr __Init_SECoverLoadingRoot_NativeFunctionPtr;

		// Token: 0x0400FCE6 RID: 64742
		private static IntPtr __GetScreenEffectGeneralRoot_NativeFunctionPtr;

		// Token: 0x0400FCE7 RID: 64743
		private static IntPtr __Init_SEGeneralRoot_NativeFunctionPtr;

		// Token: 0x0400FCE8 RID: 64744
		private static IntPtr __GetScreenEffectPlotRoot_NativeFunctionPtr;

		// Token: 0x0400FCE9 RID: 64745
		private static IntPtr __Init_SEPlotRoot_NativeFunctionPtr;

		// Token: 0x0400FCEA RID: 64746
		private static IntPtr __GetScreenEffectFightRoot_NativeFunctionPtr;

		// Token: 0x0400FCEB RID: 64747
		private static IntPtr __Init_SEFight_Root_NativeFunctionPtr;

		// Token: 0x0400FCEC RID: 64748
		private static IntPtr __UpdateLGUIMaterialParams_NativeFunctionPtr;

		// Token: 0x0400FCED RID: 64749
		private static IntPtr __ClearSystem_NativeFunctionPtr;

		// Token: 0x0400FCEE RID: 64750
		private static IntPtr __SetVisibilityOfSystem_NativeFunctionPtr;

		// Token: 0x0400FCEF RID: 64751
		private static IntPtr __EndEffectDebug_NativeFunctionPtr;

		// Token: 0x0400FCF0 RID: 64752
		private static IntPtr __EndScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FCF1 RID: 64753
		private static IntPtr __EvaluateOrderEffects_NativeFunctionPtr;

		// Token: 0x0400FCF2 RID: 64754
		private static IntPtr __PlayScreenEffectNoPaused_NativeFunctionPtr;

		// Token: 0x0400FCF3 RID: 64755
		private static IntPtr __PlayEffectDebug_NativeFunctionPtr;

		// Token: 0x0400FCF4 RID: 64756
		private static IntPtr __PlayScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FCF5 RID: 64757
		private static IntPtr __AddEffect_NativeFunctionPtr;

		// Token: 0x0400FCF6 RID: 64758
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCF7 RID: 64759
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008DE1 RID: 36321
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetNiagaraFrameDeltaTime_FunctionParams
		{
			// Token: 0x0402C9FA RID: 182778
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008DE2 RID: 36322
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetEffectExtraState_FunctionParams
		{
			// Token: 0x0402C9FB RID: 182779
			[FieldOffset(0)]
			public IntPtr EffectScreenPlayData;

			// Token: 0x0402C9FC RID: 182780
			[FieldOffset(8)]
			public int ExtraState;
		}

		// Token: 0x02008DE3 RID: 36323
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TweenEffectParameter_FunctionParams
		{
			// Token: 0x0402C9FD RID: 182781
			[FieldOffset(0)]
			public IntPtr EffectScreenPlayData;

			// Token: 0x0402C9FE RID: 182782
			[FieldOffset(8)]
			public float targetProgress;
		}

		// Token: 0x02008DE4 RID: 36324
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateSEEnvironmentFactor_FunctionParams
		{
			// Token: 0x0402C9FF RID: 182783
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x0402CA00 RID: 182784
			[FieldOffset(8)]
			public float EnvironmentFactor;
		}

		// Token: 0x02008DE5 RID: 36325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __DestroyScreenEffect_FunctionParams
		{
			// Token: 0x0402CA01 RID: 182785
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02008DE6 RID: 36326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __SpawnPlayer_FunctionParams
		{
			// Token: 0x0402CA02 RID: 182786
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x0402CA03 RID: 182787
			[FieldOffset(8)]
			public IntPtr OutputPlayer;
		}

		// Token: 0x02008DE7 RID: 36327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectCoverLoadingRoot_FunctionParams
		{
			// Token: 0x0402CA04 RID: 182788
			[FieldOffset(0)]
			public IntPtr ScreenEffectCoverLoadingRoot;
		}

		// Token: 0x02008DE8 RID: 36328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectGeneralRoot_FunctionParams
		{
			// Token: 0x0402CA05 RID: 182789
			[FieldOffset(0)]
			public IntPtr ScreenEffectGeneralRoot;
		}

		// Token: 0x02008DE9 RID: 36329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectPlotRoot_FunctionParams
		{
			// Token: 0x0402CA06 RID: 182790
			[FieldOffset(0)]
			public IntPtr ScreenEffectPlotRoot;
		}

		// Token: 0x02008DEA RID: 36330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectFightRoot_FunctionParams
		{
			// Token: 0x0402CA07 RID: 182791
			[FieldOffset(0)]
			public IntPtr ScreenEffectFightRoot;
		}

		// Token: 0x02008DEB RID: 36331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetVisibilityOfSystem_FunctionParams
		{
			// Token: 0x0402CA08 RID: 182792
			[FieldOffset(0)]
			public bool Visibility;

			// Token: 0x0402CA09 RID: 182793
			[FieldOffset(1)]
			public bool bOverrideFadeSpeed;

			// Token: 0x0402CA0A RID: 182794
			[FieldOffset(4)]
			public float OverrideFadeSpeed;
		}

		// Token: 0x02008DEC RID: 36332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EndScreenEffect_FunctionParams
		{
			// Token: 0x0402CA0B RID: 182795
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02008DED RID: 36333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayScreenEffectNoPaused_FunctionParams
		{
			// Token: 0x0402CA0C RID: 182796
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02008DEE RID: 36334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayScreenEffect_FunctionParams
		{
			// Token: 0x0402CA0D RID: 182797
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02008DEF RID: 36335
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __AddEffect_FunctionParams
		{
			// Token: 0x0402CA0E RID: 182798
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x0402CA0F RID: 182799
			[FieldOffset(8)]
			public bool TickWhenPaused;

			// Token: 0x0402CA10 RID: 182800
			[FieldOffset(16)]
			public IntPtr EffectPlayer;
		}

		// Token: 0x02008DF0 RID: 36336
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA11 RID: 182801
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
