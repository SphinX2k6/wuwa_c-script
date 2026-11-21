using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x020030AA RID: 12458
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C")]
	[UnrealStructLayout(2536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2536)]
	public class BP_StateMachineEffectBase_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDBD RID: 122301 RVA: 0x0090402F File Offset: 0x0090222F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StateMachineEffectBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C");
			}
			return BP_StateMachineEffectBase_C._ClassPtr;
		}

		// Token: 0x0601DDBE RID: 122302 RVA: 0x00904054 File Offset: 0x00902254
		public BP_StateMachineEffectBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_StateMachineEffectBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDBF RID: 122303 RVA: 0x0090407C File Offset: 0x0090227C
		public BP_StateMachineEffectBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StateMachineEffectBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0601DDC0 RID: 122304 RVA: 0x009040AF File Offset: 0x009022AF
		// (set) Token: 0x0601DDC1 RID: 122305 RVA: 0x009040C3 File Offset: 0x009022C3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0601DDC2 RID: 122306 RVA: 0x009040D8 File Offset: 0x009022D8
		// (set) Token: 0x0601DDC3 RID: 122307 RVA: 0x009040E8 File Offset: 0x009022E8
		public unsafe bool IsEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsEditorTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsEditorTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0601DDC4 RID: 122308 RVA: 0x009040F9 File Offset: 0x009022F9
		// (set) Token: 0x0601DDC5 RID: 122309 RVA: 0x0090410D File Offset: 0x0090230D
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> CurrentState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_CurrentState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_CurrentState) = value;
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0601DDC6 RID: 122310 RVA: 0x00904122 File Offset: 0x00902322
		// (set) Token: 0x0601DDC7 RID: 122311 RVA: 0x00904132 File Offset: 0x00902332
		public unsafe bool IsInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0601DDC8 RID: 122312 RVA: 0x00904143 File Offset: 0x00902343
		// (set) Token: 0x0601DDC9 RID: 122313 RVA: 0x00904157 File Offset: 0x00902357
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> TargetState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TargetState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TargetState) = value;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0601DDCA RID: 122314 RVA: 0x0090416C File Offset: 0x0090236C
		// (set) Token: 0x0601DDCB RID: 122315 RVA: 0x0090417C File Offset: 0x0090237C
		public unsafe bool IsInTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInTransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInTransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0601DDCC RID: 122316 RVA: 0x0090418D File Offset: 0x0090238D
		// (set) Token: 0x0601DDCD RID: 122317 RVA: 0x009041A1 File Offset: 0x009023A1
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> TransitionTargetState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionTargetState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionTargetState) = value;
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0601DDCE RID: 122318 RVA: 0x009041B6 File Offset: 0x009023B6
		// (set) Token: 0x0601DDCF RID: 122319 RVA: 0x009041C6 File Offset: 0x009023C6
		public unsafe float TransitionCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionCounter) = value;
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0601DDD0 RID: 122320 RVA: 0x009041D7 File Offset: 0x009023D7
		// (set) Token: 0x0601DDD1 RID: 122321 RVA: 0x009041E7 File Offset: 0x009023E7
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionTime) = value;
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0601DDD2 RID: 122322 RVA: 0x009041F8 File Offset: 0x009023F8
		// (set) Token: 0x0601DDD3 RID: 122323 RVA: 0x00904231 File Offset: 0x00902431
		public TMap<FName, float> TransitionFloatStartMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TransitionFloatStartMap) == null)
				{
					result = (this._TransitionFloatStartMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionFloatStartMap, this));
				}
				return result;
			}
			set
			{
				this.TransitionFloatStartMap.CopyAssign(value);
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0601DDD4 RID: 122324 RVA: 0x00904240 File Offset: 0x00902440
		// (set) Token: 0x0601DDD5 RID: 122325 RVA: 0x00904279 File Offset: 0x00902479
		public TMap<FName, float> TransitionFloatEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TransitionFloatEndMap) == null)
				{
					result = (this._TransitionFloatEndMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionFloatEndMap, this));
				}
				return result;
			}
			set
			{
				this.TransitionFloatEndMap.CopyAssign(value);
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0601DDD6 RID: 122326 RVA: 0x00904288 File Offset: 0x00902488
		// (set) Token: 0x0601DDD7 RID: 122327 RVA: 0x009042C1 File Offset: 0x009024C1
		public TMap<FName, FLinearColor> TransitionLinearColorStartMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TransitionLinearColorStartMap) == null)
				{
					result = (this._TransitionLinearColorStartMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionLinearColorStartMap, this));
				}
				return result;
			}
			set
			{
				this.TransitionLinearColorStartMap.CopyAssign(value);
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0601DDD8 RID: 122328 RVA: 0x009042D0 File Offset: 0x009024D0
		// (set) Token: 0x0601DDD9 RID: 122329 RVA: 0x00904309 File Offset: 0x00902509
		public TMap<FName, FLinearColor> TransitionLinearColorEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TransitionLinearColorEndMap) == null)
				{
					result = (this._TransitionLinearColorEndMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_TransitionLinearColorEndMap, this));
				}
				return result;
			}
			set
			{
				this.TransitionLinearColorEndMap.CopyAssign(value);
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0601DDDA RID: 122330 RVA: 0x00904317 File Offset: 0x00902517
		// (set) Token: 0x0601DDDB RID: 122331 RVA: 0x00904327 File Offset: 0x00902527
		public unsafe bool IsInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsInState) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0601DDDC RID: 122332 RVA: 0x00904338 File Offset: 0x00902538
		// (set) Token: 0x0601DDDD RID: 122333 RVA: 0x00904348 File Offset: 0x00902548
		public unsafe bool IsStatePreLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsStatePreLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsStatePreLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0601DDDE RID: 122334 RVA: 0x00904359 File Offset: 0x00902559
		// (set) Token: 0x0601DDDF RID: 122335 RVA: 0x00904369 File Offset: 0x00902569
		public unsafe float StateCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_StateCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_StateCounter) = value;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0601DDE0 RID: 122336 RVA: 0x0090437C File Offset: 0x0090257C
		// (set) Token: 0x0601DDE1 RID: 122337 RVA: 0x009043B5 File Offset: 0x009025B5
		public TArray<UStaticMeshComponent> StaticMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._StaticMeshComponents) == null)
				{
					result = (this._StaticMeshComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_StaticMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0601DDE2 RID: 122338 RVA: 0x009043C4 File Offset: 0x009025C4
		// (set) Token: 0x0601DDE3 RID: 122339 RVA: 0x009043FD File Offset: 0x009025FD
		public TArray<UMaterialInstanceDynamic> StaticMeshDMIs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._StaticMeshDMIs) == null)
				{
					result = (this._StaticMeshDMIs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_StaticMeshDMIs, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshDMIs.CopyAssign(value);
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0601DDE4 RID: 122340 RVA: 0x0090440B File Offset: 0x0090260B
		// (set) Token: 0x0601DDE5 RID: 122341 RVA: 0x0090441B File Offset: 0x0090261B
		public unsafe bool IsFirstTickInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsFirstTickInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_IsFirstTickInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0601DDE6 RID: 122342 RVA: 0x0090442C File Offset: 0x0090262C
		// (set) Token: 0x0601DDE7 RID: 122343 RVA: 0x00904465 File Offset: 0x00902665
		public TMap<FName, float> CurrentFloatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._CurrentFloatMap) == null)
				{
					result = (this._CurrentFloatMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_CurrentFloatMap, this));
				}
				return result;
			}
			set
			{
				this.CurrentFloatMap.CopyAssign(value);
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0601DDE8 RID: 122344 RVA: 0x00904474 File Offset: 0x00902674
		// (set) Token: 0x0601DDE9 RID: 122345 RVA: 0x009044AD File Offset: 0x009026AD
		public TMap<FName, FLinearColor> CurrentLinearColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._CurrentLinearColorMap) == null)
				{
					result = (this._CurrentLinearColorMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_CurrentLinearColorMap, this));
				}
				return result;
			}
			set
			{
				this.CurrentLinearColorMap.CopyAssign(value);
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0601DDEA RID: 122346 RVA: 0x009044BB File Offset: 0x009026BB
		// (set) Token: 0x0601DDEB RID: 122347 RVA: 0x009044CF File Offset: 0x009026CF
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> InitState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_InitState);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_InitState) = value;
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0601DDEC RID: 122348 RVA: 0x009044E4 File Offset: 0x009026E4
		// (set) Token: 0x0601DDED RID: 122349 RVA: 0x0090451D File Offset: 0x0090271D
		public TArray<UNiagaraComponent> NiagaraComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraComponents) == null)
				{
					result = (this._NiagaraComponents = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_NiagaraComponents, this));
				}
				return result;
			}
			set
			{
				this.NiagaraComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601DDEE RID: 122350 RVA: 0x0090452C File Offset: 0x0090272C
		[SkipLocalsInit]
		public unsafe virtual void SetState(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__SetState_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__SetState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__SetState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__SetState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDEF RID: 122351 RVA: 0x00904577 File Offset: 0x00902777
		[SkipLocalsInit]
		public virtual void DEBUG重初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG重初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF0 RID: 122352 RVA: 0x0090458B File Offset: 0x0090278B
		[SkipLocalsInit]
		public virtual void DEBUG进入状态5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态5_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF1 RID: 122353 RVA: 0x0090459F File Offset: 0x0090279F
		[SkipLocalsInit]
		public virtual void DEBUG进入状态4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态4_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF2 RID: 122354 RVA: 0x009045B3 File Offset: 0x009027B3
		[SkipLocalsInit]
		public virtual void DEBUG进入状态3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态3_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF3 RID: 122355 RVA: 0x009045C7 File Offset: 0x009027C7
		[SkipLocalsInit]
		public virtual void DEBUG进入状态2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态2_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF4 RID: 122356 RVA: 0x009045DB File Offset: 0x009027DB
		[SkipLocalsInit]
		public virtual void DEBUG进入状态1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态1_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF5 RID: 122357 RVA: 0x009045F0 File Offset: 0x009027F0
		[SkipLocalsInit]
		public unsafe virtual void CreateTransitionState(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams[(UIntPtr)4135] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__CreateTransitionState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__CreateTransitionState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDF6 RID: 122358 RVA: 0x00904640 File Offset: 0x00902840
		[SkipLocalsInit]
		public unsafe virtual void UpdateParameters(FName Name, bool IsFloat, float FloatValue, bool IsLinearColor, FLinearColor LinearColorValue, int Index)
		{
			BP_StateMachineEffectBase_C.__UpdateParameters_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__UpdateParameters_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__UpdateParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__UpdateParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			ptr->IsFloat = IsFloat;
			ptr->FloatValue = FloatValue;
			ptr->IsLinearColor = IsLinearColor;
			ptr->LinearColorValue = LinearColorValue;
			ptr->Index = Index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UpdateParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDF7 RID: 122359 RVA: 0x009046AF File Offset: 0x009028AF
		[SkipLocalsInit]
		public virtual void UpdateLoopState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UpdateLoopState_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF8 RID: 122360 RVA: 0x009046C3 File Offset: 0x009028C3
		[SkipLocalsInit]
		public virtual void UpdatePreLoopState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UpdatePreLoopState_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDF9 RID: 122361 RVA: 0x009046D7 File Offset: 0x009028D7
		[SkipLocalsInit]
		public virtual void Update_Transition_State()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Update_Transition_State_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDFA RID: 122362 RVA: 0x009046EB File Offset: 0x009028EB
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDFB RID: 122363 RVA: 0x009046FF File Offset: 0x009028FF
		[SkipLocalsInit]
		public virtual void Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Tick_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDFC RID: 122364 RVA: 0x00904714 File Offset: 0x00902914
		[SkipLocalsInit]
		public unsafe virtual void Init(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__Init_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__Init_FunctionParams[(UIntPtr)927] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Init_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDFD RID: 122365 RVA: 0x00904762 File Offset: 0x00902962
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDFE RID: 122366 RVA: 0x00904776 File Offset: 0x00902976
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDFF RID: 122367 RVA: 0x0090478C File Offset: 0x0090298C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE00 RID: 122368 RVA: 0x009047D4 File Offset: 0x009029D4
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE01 RID: 122369 RVA: 0x0090481A File Offset: 0x00902A1A
		[SkipLocalsInit]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE02 RID: 122370 RVA: 0x0090482E File Offset: 0x00902A2E
		[SkipLocalsInit]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE03 RID: 122371 RVA: 0x00904844 File Offset: 0x00902A44
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE04 RID: 122372 RVA: 0x0090488C File Offset: 0x00902A8C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE05 RID: 122373 RVA: 0x009048D2 File Offset: 0x00902AD2
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE06 RID: 122374 RVA: 0x009048E6 File Offset: 0x00902AE6
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE07 RID: 122375 RVA: 0x009048FA File Offset: 0x00902AFA
		protected BP_StateMachineEffectBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC18 RID: 64536
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C";

		// Token: 0x0400FC19 RID: 64537
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC1A RID: 64538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC1B RID: 64539
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FC1C RID: 64540
		internal static int __PropertyOffset_IsEditorTick;

		// Token: 0x0400FC1D RID: 64541
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x0400FC1E RID: 64542
		internal static int __PropertyOffset_IsInit;

		// Token: 0x0400FC1F RID: 64543
		internal static int __PropertyOffset_TargetState;

		// Token: 0x0400FC20 RID: 64544
		internal static int __PropertyOffset_IsInTransition;

		// Token: 0x0400FC21 RID: 64545
		internal static int __PropertyOffset_TransitionTargetState;

		// Token: 0x0400FC22 RID: 64546
		internal static int __PropertyOffset_TransitionCounter;

		// Token: 0x0400FC23 RID: 64547
		internal static int __PropertyOffset_TransitionTime;

		// Token: 0x0400FC24 RID: 64548
		internal static int __PropertyOffset_TransitionFloatStartMap;

		// Token: 0x0400FC25 RID: 64549
		[Nullable(2)]
		private TMap<FName, float> _TransitionFloatStartMap;

		// Token: 0x0400FC26 RID: 64550
		internal static int __PropertyOffset_TransitionFloatEndMap;

		// Token: 0x0400FC27 RID: 64551
		[Nullable(2)]
		private TMap<FName, float> _TransitionFloatEndMap;

		// Token: 0x0400FC28 RID: 64552
		internal static int __PropertyOffset_TransitionLinearColorStartMap;

		// Token: 0x0400FC29 RID: 64553
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TransitionLinearColorStartMap;

		// Token: 0x0400FC2A RID: 64554
		internal static int __PropertyOffset_TransitionLinearColorEndMap;

		// Token: 0x0400FC2B RID: 64555
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TransitionLinearColorEndMap;

		// Token: 0x0400FC2C RID: 64556
		internal static int __PropertyOffset_IsInState;

		// Token: 0x0400FC2D RID: 64557
		internal static int __PropertyOffset_IsStatePreLoop;

		// Token: 0x0400FC2E RID: 64558
		internal static int __PropertyOffset_StateCounter;

		// Token: 0x0400FC2F RID: 64559
		internal static int __PropertyOffset_StaticMeshComponents;

		// Token: 0x0400FC30 RID: 64560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _StaticMeshComponents;

		// Token: 0x0400FC31 RID: 64561
		internal static int __PropertyOffset_StaticMeshDMIs;

		// Token: 0x0400FC32 RID: 64562
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _StaticMeshDMIs;

		// Token: 0x0400FC33 RID: 64563
		internal static int __PropertyOffset_IsFirstTickInfo;

		// Token: 0x0400FC34 RID: 64564
		internal static int __PropertyOffset_CurrentFloatMap;

		// Token: 0x0400FC35 RID: 64565
		[Nullable(2)]
		private TMap<FName, float> _CurrentFloatMap;

		// Token: 0x0400FC36 RID: 64566
		internal static int __PropertyOffset_CurrentLinearColorMap;

		// Token: 0x0400FC37 RID: 64567
		[Nullable(2)]
		private TMap<FName, FLinearColor> _CurrentLinearColorMap;

		// Token: 0x0400FC38 RID: 64568
		internal static int __PropertyOffset_InitState;

		// Token: 0x0400FC39 RID: 64569
		internal static int __PropertyOffset_NiagaraComponents;

		// Token: 0x0400FC3A RID: 64570
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraComponents;

		// Token: 0x0400FC3B RID: 64571
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x0400FC3C RID: 64572
		private static IntPtr __DEBUG重初始化_NativeFunctionPtr;

		// Token: 0x0400FC3D RID: 64573
		private static IntPtr __DEBUG进入状态5_NativeFunctionPtr;

		// Token: 0x0400FC3E RID: 64574
		private static IntPtr __DEBUG进入状态4_NativeFunctionPtr;

		// Token: 0x0400FC3F RID: 64575
		private static IntPtr __DEBUG进入状态3_NativeFunctionPtr;

		// Token: 0x0400FC40 RID: 64576
		private static IntPtr __DEBUG进入状态2_NativeFunctionPtr;

		// Token: 0x0400FC41 RID: 64577
		private static IntPtr __DEBUG进入状态1_NativeFunctionPtr;

		// Token: 0x0400FC42 RID: 64578
		private static IntPtr __CreateTransitionState_NativeFunctionPtr;

		// Token: 0x0400FC43 RID: 64579
		private static IntPtr __UpdateParameters_NativeFunctionPtr;

		// Token: 0x0400FC44 RID: 64580
		private static IntPtr __UpdateLoopState_NativeFunctionPtr;

		// Token: 0x0400FC45 RID: 64581
		private static IntPtr __UpdatePreLoopState_NativeFunctionPtr;

		// Token: 0x0400FC46 RID: 64582
		private static IntPtr __Update_Transition_State_NativeFunctionPtr;

		// Token: 0x0400FC47 RID: 64583
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400FC48 RID: 64584
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400FC49 RID: 64585
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400FC4A RID: 64586
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC4B RID: 64587
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FC4C RID: 64588
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x0400FC4D RID: 64589
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC4E RID: 64590
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008DC5 RID: 36293
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x0402C9C5 RID: 182725
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02008DC6 RID: 36294
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4120)]
		protected ref struct __CreateTransitionState_FunctionParams
		{
			// Token: 0x0402C9C6 RID: 182726
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02008DC7 RID: 36295
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __UpdateParameters_FunctionParams
		{
			// Token: 0x0402C9C7 RID: 182727
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0402C9C8 RID: 182728
			[FieldOffset(12)]
			public bool IsFloat;

			// Token: 0x0402C9C9 RID: 182729
			[FieldOffset(16)]
			public float FloatValue;

			// Token: 0x0402C9CA RID: 182730
			[FieldOffset(20)]
			public bool IsLinearColor;

			// Token: 0x0402C9CB RID: 182731
			[FieldOffset(24)]
			public FLinearColor LinearColorValue;

			// Token: 0x0402C9CC RID: 182732
			[FieldOffset(40)]
			public int Index;
		}

		// Token: 0x02008DC8 RID: 36296
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 912)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x0402C9CD RID: 182733
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02008DC9 RID: 36297
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C9CE RID: 182734
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008DCA RID: 36298
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C9CF RID: 182735
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
