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
	// Token: 0x02003AE6 RID: 15078
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1644)]
	public class BP_ScreenEffectSystem_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A19 RID: 133657 RVA: 0x008D8525 File Offset: 0x008D6725
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ScreenEffectSystem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C");
			}
			return BP_ScreenEffectSystem_C._ClassPtr;
		}

		// Token: 0x06020A1A RID: 133658 RVA: 0x008D854C File Offset: 0x008D674C
		public BP_ScreenEffectSystem_C() : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectSystem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A1B RID: 133659 RVA: 0x008D8574 File Offset: 0x008D6774
		[NullableContext(1)]
		public BP_ScreenEffectSystem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ScreenEffectSystem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x06020A1C RID: 133660 RVA: 0x008D85A7 File Offset: 0x008D67A7
		// (set) Token: 0x06020A1D RID: 133661 RVA: 0x008D85BB File Offset: 0x008D67BB
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x06020A1E RID: 133662 RVA: 0x008D85D0 File Offset: 0x008D67D0
		// (set) Token: 0x06020A1F RID: 133663 RVA: 0x008D85E4 File Offset: 0x008D67E4
		public unsafe EffectScreenPlayData_C DebugData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x06020A20 RID: 133664 RVA: 0x008D85FC File Offset: 0x008D67FC
		// (set) Token: 0x06020A21 RID: 133665 RVA: 0x008D8635 File Offset: 0x008D6835
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
					result = (this._Effects = new TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x06020A22 RID: 133666 RVA: 0x008D8644 File Offset: 0x008D6844
		// (set) Token: 0x06020A23 RID: 133667 RVA: 0x008D867D File Offset: 0x008D687D
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
					result = (this._OrderDatas = new TArray<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OrderDatas.CopyAssign(value);
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x06020A24 RID: 133668 RVA: 0x008D868C File Offset: 0x008D688C
		// (set) Token: 0x06020A25 RID: 133669 RVA: 0x008D86C5 File Offset: 0x008D68C5
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
					result = (this._IndependentDatas = new TArray<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IndependentDatas.CopyAssign(value);
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x06020A26 RID: 133670 RVA: 0x008D86D3 File Offset: 0x008D68D3
		// (set) Token: 0x06020A27 RID: 133671 RVA: 0x008D86E3 File Offset: 0x008D68E3
		public unsafe bool bEvaluateOrderEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x06020A28 RID: 133672 RVA: 0x008D86F4 File Offset: 0x008D68F4
		// (set) Token: 0x06020A29 RID: 133673 RVA: 0x008D8708 File Offset: 0x008D6908
		public unsafe AUIContainerActor EditorScreenRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x06020A2A RID: 133674 RVA: 0x008D871D File Offset: 0x008D691D
		// (set) Token: 0x06020A2B RID: 133675 RVA: 0x008D8731 File Offset: 0x008D6931
		public unsafe AUIContainerActor ScreenEffectFightRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x06020A2C RID: 133676 RVA: 0x008D8746 File Offset: 0x008D6946
		// (set) Token: 0x06020A2D RID: 133677 RVA: 0x008D875A File Offset: 0x008D695A
		public unsafe AUIContainerActor ScreenEffectPlotRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x06020A2E RID: 133678 RVA: 0x008D876F File Offset: 0x008D696F
		// (set) Token: 0x06020A2F RID: 133679 RVA: 0x008D877F File Offset: 0x008D697F
		public unsafe float EnvironmentFactorDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x06020A30 RID: 133680 RVA: 0x008D8790 File Offset: 0x008D6990
		// (set) Token: 0x06020A31 RID: 133681 RVA: 0x008D87A4 File Offset: 0x008D69A4
		public unsafe AUIContainerActor ScreenEffectGeneralRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x06020A32 RID: 133682 RVA: 0x008D87B9 File Offset: 0x008D69B9
		// (set) Token: 0x06020A33 RID: 133683 RVA: 0x008D87C9 File Offset: 0x008D69C9
		public unsafe int DebugExtraState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x06020A34 RID: 133684 RVA: 0x008D87DA File Offset: 0x008D69DA
		// (set) Token: 0x06020A35 RID: 133685 RVA: 0x008D87EE File Offset: 0x008D69EE
		public unsafe AUIContainerActor ScreenEffectCoverLoadingRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ScreenEffectSystem_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x06020A36 RID: 133686 RVA: 0x008D8803 File Offset: 0x008D6A03
		// (set) Token: 0x06020A37 RID: 133687 RVA: 0x008D8813 File Offset: 0x008D6A13
		public unsafe float NiagaraFrameDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ScreenEffectSystem_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06020A38 RID: 133688 RVA: 0x008D8824 File Offset: 0x008D6A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetNiagaraFrameDeltaTime(float DeltaTime)
		{
			BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetNiagaraFrameDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A39 RID: 133689 RVA: 0x008D886A File Offset: 0x008D6A6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetEffectExtraStateDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetEffectExtraStateDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06020A3A RID: 133690 RVA: 0x008D8880 File Offset: 0x008D6A80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetEffectExtraState(EffectScreenPlayData_C EffectScreenPlayData, int ExtraState)
		{
			BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetEffectExtraState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetEffectExtraState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectScreenPlayData = ((EffectScreenPlayData != null) ? EffectScreenPlayData.NativePtr : IntPtr.Zero);
			ptr->ExtraState = ExtraState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetEffectExtraState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A3B RID: 133691 RVA: 0x008D88DC File Offset: 0x008D6ADC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TweenEffectParameter(EffectScreenPlayData_C EffectScreenPlayData, float targetProgress)
		{
			BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__TweenEffectParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__TweenEffectParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EffectScreenPlayData = ((EffectScreenPlayData != null) ? EffectScreenPlayData.NativePtr : IntPtr.Zero);
			ptr->targetProgress = targetProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__TweenEffectParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A3C RID: 133692 RVA: 0x008D8938 File Offset: 0x008D6B38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEnvironmentFactorDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateEnvironmentFactorDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06020A3D RID: 133693 RVA: 0x008D894C File Offset: 0x008D6B4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateSEEnvironmentFactor(EffectScreenPlayData_C Data, float EnvironmentFactor)
		{
			BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateSEEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A3E RID: 133694 RVA: 0x008D89A8 File Offset: 0x008D6BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DestroyScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__DestroyScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__DestroyScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__DestroyScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A3F RID: 133695 RVA: 0x008D8A00 File Offset: 0x008D6C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A40 RID: 133696 RVA: 0x008D8A80 File Offset: 0x008D6C80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A41 RID: 133697 RVA: 0x008D8AE4 File Offset: 0x008D6CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_SECoverLoadingRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SECoverLoadingRoot_NativeFunctionPtr, null);
		}

		// Token: 0x06020A42 RID: 133698 RVA: 0x008D8AF8 File Offset: 0x008D6CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A43 RID: 133699 RVA: 0x008D8B5C File Offset: 0x008D6D5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_SEGeneralRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEGeneralRoot_NativeFunctionPtr, null);
		}

		// Token: 0x06020A44 RID: 133700 RVA: 0x008D8B70 File Offset: 0x008D6D70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A45 RID: 133701 RVA: 0x008D8BD4 File Offset: 0x008D6DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_SEPlotRoot()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEPlotRoot_NativeFunctionPtr, null);
		}

		// Token: 0x06020A46 RID: 133702 RVA: 0x008D8BE8 File Offset: 0x008D6DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A47 RID: 133703 RVA: 0x008D8C4C File Offset: 0x008D6E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_SEFight_Root()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__Init_SEFight_Root_NativeFunctionPtr, null);
		}

		// Token: 0x06020A48 RID: 133704 RVA: 0x008D8C60 File Offset: 0x008D6E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLGUIMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__UpdateLGUIMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x06020A49 RID: 133705 RVA: 0x008D8C74 File Offset: 0x008D6E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearSystem()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ClearSystem_NativeFunctionPtr, null);
		}

		// Token: 0x06020A4A RID: 133706 RVA: 0x008D8C88 File Offset: 0x008D6E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVisibilityOfSystem(bool Visibility, bool bOverrideFadeSpeed, float OverrideFadeSpeed)
		{
			BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Visibility = Visibility;
			ptr->bOverrideFadeSpeed = bOverrideFadeSpeed;
			ptr->OverrideFadeSpeed = OverrideFadeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__SetVisibilityOfSystem_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A4B RID: 133707 RVA: 0x008D8CDC File Offset: 0x008D6EDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndEffectDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EndEffectDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06020A4C RID: 133708 RVA: 0x008D8CF0 File Offset: 0x008D6EF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EndScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__EndScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__EndScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EndScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A4D RID: 133709 RVA: 0x008D8D45 File Offset: 0x008D6F45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EvaluateOrderEffects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__EvaluateOrderEffects_NativeFunctionPtr, null);
		}

		// Token: 0x06020A4E RID: 133710 RVA: 0x008D8D5C File Offset: 0x008D6F5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayScreenEffectNoPaused(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayScreenEffectNoPaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A4F RID: 133711 RVA: 0x008D8DB1 File Offset: 0x008D6FB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayEffectDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayEffectDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06020A50 RID: 133712 RVA: 0x008D8DC8 File Offset: 0x008D6FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayScreenEffect(EffectScreenPlayData_C Data)
		{
			BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__PlayScreenEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__PlayScreenEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Data = ((Data != null) ? Data.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__PlayScreenEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A51 RID: 133713 RVA: 0x008D8E20 File Offset: 0x008D7020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06020A52 RID: 133714 RVA: 0x008D8EA4 File Offset: 0x008D70A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020A53 RID: 133715 RVA: 0x008D8EB8 File Offset: 0x008D70B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020A54 RID: 133716 RVA: 0x008D8ED0 File Offset: 0x008D70D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A55 RID: 133717 RVA: 0x008D8F18 File Offset: 0x008D7118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ScreenEffectSystem_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ScreenEffectSystem_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020A56 RID: 133718 RVA: 0x008D8F5F File Offset: 0x008D715F
		protected BP_ScreenEffectSystem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD34 RID: 64820
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/BP_ScreenEffectSystem.BP_ScreenEffectSystem_C";

		// Token: 0x0400FD35 RID: 64821
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD36 RID: 64822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD37 RID: 64823
		internal static int __PropertyOffset_1;

		// Token: 0x0400FD38 RID: 64824
		internal static int __PropertyOffset_2;

		// Token: 0x0400FD39 RID: 64825
		internal static int __PropertyOffset_3;

		// Token: 0x0400FD3A RID: 64826
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<EffectScreenPlayData_C, BP_ScreenEffectPlayer_C> _Effects;

		// Token: 0x0400FD3B RID: 64827
		internal static int __PropertyOffset_4;

		// Token: 0x0400FD3C RID: 64828
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<EffectScreenPlayData_C> _OrderDatas;

		// Token: 0x0400FD3D RID: 64829
		internal static int __PropertyOffset_5;

		// Token: 0x0400FD3E RID: 64830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<EffectScreenPlayData_C> _IndependentDatas;

		// Token: 0x0400FD3F RID: 64831
		internal static int __PropertyOffset_6;

		// Token: 0x0400FD40 RID: 64832
		internal static int __PropertyOffset_7;

		// Token: 0x0400FD41 RID: 64833
		internal static int __PropertyOffset_8;

		// Token: 0x0400FD42 RID: 64834
		internal static int __PropertyOffset_9;

		// Token: 0x0400FD43 RID: 64835
		internal static int __PropertyOffset_10;

		// Token: 0x0400FD44 RID: 64836
		internal static int __PropertyOffset_11;

		// Token: 0x0400FD45 RID: 64837
		internal static int __PropertyOffset_12;

		// Token: 0x0400FD46 RID: 64838
		internal static int __PropertyOffset_13;

		// Token: 0x0400FD47 RID: 64839
		internal static int __PropertyOffset_14;

		// Token: 0x0400FD48 RID: 64840
		private static IntPtr __SetNiagaraFrameDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FD49 RID: 64841
		private static IntPtr __SetEffectExtraStateDebug_NativeFunctionPtr;

		// Token: 0x0400FD4A RID: 64842
		private static IntPtr __SetEffectExtraState_NativeFunctionPtr;

		// Token: 0x0400FD4B RID: 64843
		private static IntPtr __TweenEffectParameter_NativeFunctionPtr;

		// Token: 0x0400FD4C RID: 64844
		private static IntPtr __UpdateEnvironmentFactorDebug_NativeFunctionPtr;

		// Token: 0x0400FD4D RID: 64845
		private static IntPtr __UpdateSEEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x0400FD4E RID: 64846
		private static IntPtr __DestroyScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FD4F RID: 64847
		private static IntPtr __SpawnPlayer_NativeFunctionPtr;

		// Token: 0x0400FD50 RID: 64848
		private static IntPtr __GetScreenEffectCoverLoadingRoot_NativeFunctionPtr;

		// Token: 0x0400FD51 RID: 64849
		private static IntPtr __Init_SECoverLoadingRoot_NativeFunctionPtr;

		// Token: 0x0400FD52 RID: 64850
		private static IntPtr __GetScreenEffectGeneralRoot_NativeFunctionPtr;

		// Token: 0x0400FD53 RID: 64851
		private static IntPtr __Init_SEGeneralRoot_NativeFunctionPtr;

		// Token: 0x0400FD54 RID: 64852
		private static IntPtr __GetScreenEffectPlotRoot_NativeFunctionPtr;

		// Token: 0x0400FD55 RID: 64853
		private static IntPtr __Init_SEPlotRoot_NativeFunctionPtr;

		// Token: 0x0400FD56 RID: 64854
		private static IntPtr __GetScreenEffectFightRoot_NativeFunctionPtr;

		// Token: 0x0400FD57 RID: 64855
		private static IntPtr __Init_SEFight_Root_NativeFunctionPtr;

		// Token: 0x0400FD58 RID: 64856
		private static IntPtr __UpdateLGUIMaterialParams_NativeFunctionPtr;

		// Token: 0x0400FD59 RID: 64857
		private static IntPtr __ClearSystem_NativeFunctionPtr;

		// Token: 0x0400FD5A RID: 64858
		private static IntPtr __SetVisibilityOfSystem_NativeFunctionPtr;

		// Token: 0x0400FD5B RID: 64859
		private static IntPtr __EndEffectDebug_NativeFunctionPtr;

		// Token: 0x0400FD5C RID: 64860
		private static IntPtr __EndScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FD5D RID: 64861
		private static IntPtr __EvaluateOrderEffects_NativeFunctionPtr;

		// Token: 0x0400FD5E RID: 64862
		private static IntPtr __PlayScreenEffectNoPaused_NativeFunctionPtr;

		// Token: 0x0400FD5F RID: 64863
		private static IntPtr __PlayEffectDebug_NativeFunctionPtr;

		// Token: 0x0400FD60 RID: 64864
		private static IntPtr __PlayScreenEffect_NativeFunctionPtr;

		// Token: 0x0400FD61 RID: 64865
		private static IntPtr __AddEffect_NativeFunctionPtr;

		// Token: 0x0400FD62 RID: 64866
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FD63 RID: 64867
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BF3 RID: 39923
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetNiagaraFrameDeltaTime_FunctionParams
		{
			// Token: 0x0403128E RID: 201358
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009BF4 RID: 39924
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetEffectExtraState_FunctionParams
		{
			// Token: 0x0403128F RID: 201359
			[FieldOffset(0)]
			public IntPtr EffectScreenPlayData;

			// Token: 0x04031290 RID: 201360
			[FieldOffset(8)]
			public int ExtraState;
		}

		// Token: 0x02009BF5 RID: 39925
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TweenEffectParameter_FunctionParams
		{
			// Token: 0x04031291 RID: 201361
			[FieldOffset(0)]
			public IntPtr EffectScreenPlayData;

			// Token: 0x04031292 RID: 201362
			[FieldOffset(8)]
			public float targetProgress;
		}

		// Token: 0x02009BF6 RID: 39926
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateSEEnvironmentFactor_FunctionParams
		{
			// Token: 0x04031293 RID: 201363
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x04031294 RID: 201364
			[FieldOffset(8)]
			public float EnvironmentFactor;
		}

		// Token: 0x02009BF7 RID: 39927
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __DestroyScreenEffect_FunctionParams
		{
			// Token: 0x04031295 RID: 201365
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02009BF8 RID: 39928
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __SpawnPlayer_FunctionParams
		{
			// Token: 0x04031296 RID: 201366
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x04031297 RID: 201367
			[FieldOffset(8)]
			public IntPtr OutputPlayer;
		}

		// Token: 0x02009BF9 RID: 39929
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectCoverLoadingRoot_FunctionParams
		{
			// Token: 0x04031298 RID: 201368
			[FieldOffset(0)]
			public IntPtr ScreenEffectCoverLoadingRoot;
		}

		// Token: 0x02009BFA RID: 39930
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectGeneralRoot_FunctionParams
		{
			// Token: 0x04031299 RID: 201369
			[FieldOffset(0)]
			public IntPtr ScreenEffectGeneralRoot;
		}

		// Token: 0x02009BFB RID: 39931
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectPlotRoot_FunctionParams
		{
			// Token: 0x0403129A RID: 201370
			[FieldOffset(0)]
			public IntPtr ScreenEffectPlotRoot;
		}

		// Token: 0x02009BFC RID: 39932
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetScreenEffectFightRoot_FunctionParams
		{
			// Token: 0x0403129B RID: 201371
			[FieldOffset(0)]
			public IntPtr ScreenEffectFightRoot;
		}

		// Token: 0x02009BFD RID: 39933
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetVisibilityOfSystem_FunctionParams
		{
			// Token: 0x0403129C RID: 201372
			[FieldOffset(0)]
			public bool Visibility;

			// Token: 0x0403129D RID: 201373
			[FieldOffset(1)]
			public bool bOverrideFadeSpeed;

			// Token: 0x0403129E RID: 201374
			[FieldOffset(4)]
			public float OverrideFadeSpeed;
		}

		// Token: 0x02009BFE RID: 39934
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __EndScreenEffect_FunctionParams
		{
			// Token: 0x0403129F RID: 201375
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02009BFF RID: 39935
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayScreenEffectNoPaused_FunctionParams
		{
			// Token: 0x040312A0 RID: 201376
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02009C00 RID: 39936
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayScreenEffect_FunctionParams
		{
			// Token: 0x040312A1 RID: 201377
			[FieldOffset(0)]
			public IntPtr Data;
		}

		// Token: 0x02009C01 RID: 39937
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __AddEffect_FunctionParams
		{
			// Token: 0x040312A2 RID: 201378
			[FieldOffset(0)]
			public IntPtr Data;

			// Token: 0x040312A3 RID: 201379
			[FieldOffset(8)]
			public bool TickWhenPaused;

			// Token: 0x040312A4 RID: 201380
			[FieldOffset(16)]
			public IntPtr EffectPlayer;
		}

		// Token: 0x02009C02 RID: 39938
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312A5 RID: 201381
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
