using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003AC5 RID: 15045
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C")]
	[UnrealStructLayout(2536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2536)]
	public class BP_StateMachineEffectBase_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602062B RID: 132651 RVA: 0x008D11FF File Offset: 0x008CF3FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StateMachineEffectBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C");
			}
			return BP_StateMachineEffectBase_C._ClassPtr;
		}

		// Token: 0x0602062C RID: 132652 RVA: 0x008D1224 File Offset: 0x008CF424
		public BP_StateMachineEffectBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_StateMachineEffectBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602062D RID: 132653 RVA: 0x008D124C File Offset: 0x008CF44C
		public BP_StateMachineEffectBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StateMachineEffectBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0602062E RID: 132654 RVA: 0x008D127F File Offset: 0x008CF47F
		// (set) Token: 0x0602062F RID: 132655 RVA: 0x008D1293 File Offset: 0x008CF493
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06020630 RID: 132656 RVA: 0x008D12A8 File Offset: 0x008CF4A8
		// (set) Token: 0x06020631 RID: 132657 RVA: 0x008D12B8 File Offset: 0x008CF4B8
		public unsafe bool IsEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06020632 RID: 132658 RVA: 0x008D12C9 File Offset: 0x008CF4C9
		// (set) Token: 0x06020633 RID: 132659 RVA: 0x008D12DD File Offset: 0x008CF4DD
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> CurrentState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x06020634 RID: 132660 RVA: 0x008D12F2 File Offset: 0x008CF4F2
		// (set) Token: 0x06020635 RID: 132661 RVA: 0x008D1302 File Offset: 0x008CF502
		public unsafe bool IsInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x06020636 RID: 132662 RVA: 0x008D1313 File Offset: 0x008CF513
		// (set) Token: 0x06020637 RID: 132663 RVA: 0x008D1327 File Offset: 0x008CF527
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> TargetState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x06020638 RID: 132664 RVA: 0x008D133C File Offset: 0x008CF53C
		// (set) Token: 0x06020639 RID: 132665 RVA: 0x008D134C File Offset: 0x008CF54C
		public unsafe bool IsInTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0602063A RID: 132666 RVA: 0x008D135D File Offset: 0x008CF55D
		// (set) Token: 0x0602063B RID: 132667 RVA: 0x008D1371 File Offset: 0x008CF571
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> TransitionTargetState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0602063C RID: 132668 RVA: 0x008D1386 File Offset: 0x008CF586
		// (set) Token: 0x0602063D RID: 132669 RVA: 0x008D1396 File Offset: 0x008CF596
		public unsafe float TransitionCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0602063E RID: 132670 RVA: 0x008D13A7 File Offset: 0x008CF5A7
		// (set) Token: 0x0602063F RID: 132671 RVA: 0x008D13B7 File Offset: 0x008CF5B7
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06020640 RID: 132672 RVA: 0x008D13C8 File Offset: 0x008CF5C8
		// (set) Token: 0x06020641 RID: 132673 RVA: 0x008D1401 File Offset: 0x008CF601
		public TMap<FName, float> TransitionFloatStartMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TransitionFloatStartMap) == null)
				{
					result = (this._TransitionFloatStartMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.TransitionFloatStartMap.CopyAssign(value);
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06020642 RID: 132674 RVA: 0x008D1410 File Offset: 0x008CF610
		// (set) Token: 0x06020643 RID: 132675 RVA: 0x008D1449 File Offset: 0x008CF649
		public TMap<FName, float> TransitionFloatEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TransitionFloatEndMap) == null)
				{
					result = (this._TransitionFloatEndMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.TransitionFloatEndMap.CopyAssign(value);
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06020644 RID: 132676 RVA: 0x008D1458 File Offset: 0x008CF658
		// (set) Token: 0x06020645 RID: 132677 RVA: 0x008D1491 File Offset: 0x008CF691
		public TMap<FName, FLinearColor> TransitionLinearColorStartMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TransitionLinearColorStartMap) == null)
				{
					result = (this._TransitionLinearColorStartMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.TransitionLinearColorStartMap.CopyAssign(value);
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06020646 RID: 132678 RVA: 0x008D14A0 File Offset: 0x008CF6A0
		// (set) Token: 0x06020647 RID: 132679 RVA: 0x008D14D9 File Offset: 0x008CF6D9
		public TMap<FName, FLinearColor> TransitionLinearColorEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TransitionLinearColorEndMap) == null)
				{
					result = (this._TransitionLinearColorEndMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.TransitionLinearColorEndMap.CopyAssign(value);
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06020648 RID: 132680 RVA: 0x008D14E7 File Offset: 0x008CF6E7
		// (set) Token: 0x06020649 RID: 132681 RVA: 0x008D14F7 File Offset: 0x008CF6F7
		public unsafe bool IsInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0602064A RID: 132682 RVA: 0x008D1508 File Offset: 0x008CF708
		// (set) Token: 0x0602064B RID: 132683 RVA: 0x008D1518 File Offset: 0x008CF718
		public unsafe bool IsStatePreLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0602064C RID: 132684 RVA: 0x008D1529 File Offset: 0x008CF729
		// (set) Token: 0x0602064D RID: 132685 RVA: 0x008D1539 File Offset: 0x008CF739
		public unsafe float StateCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0602064E RID: 132686 RVA: 0x008D154A File Offset: 0x008CF74A
		// (set) Token: 0x0602064F RID: 132687 RVA: 0x008D155E File Offset: 0x008CF75E
		[Nullable(2)]
		public unsafe PD_StateMachineEffect_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_StateMachineEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_17);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StateMachineEffectBase_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06020650 RID: 132688 RVA: 0x008D1574 File Offset: 0x008CF774
		// (set) Token: 0x06020651 RID: 132689 RVA: 0x008D15AD File Offset: 0x008CF7AD
		public TArray<UStaticMeshComponent> StaticMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._StaticMeshComponents) == null)
				{
					result = (this._StaticMeshComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06020652 RID: 132690 RVA: 0x008D15BC File Offset: 0x008CF7BC
		// (set) Token: 0x06020653 RID: 132691 RVA: 0x008D15F5 File Offset: 0x008CF7F5
		public TArray<UMaterialInstanceDynamic> StaticMeshDMIs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._StaticMeshDMIs) == null)
				{
					result = (this._StaticMeshDMIs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshDMIs.CopyAssign(value);
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06020654 RID: 132692 RVA: 0x008D1604 File Offset: 0x008CF804
		// (set) Token: 0x06020655 RID: 132693 RVA: 0x008D163D File Offset: 0x008CF83D
		public SEffectStateInfo CurrentStateInfo
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._CurrentStateInfo) == null)
				{
					result = (this._CurrentStateInfo = new SEffectStateInfo(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06020656 RID: 132694 RVA: 0x008D165E File Offset: 0x008CF85E
		// (set) Token: 0x06020657 RID: 132695 RVA: 0x008D166E File Offset: 0x008CF86E
		public unsafe bool IsFirstTickInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06020658 RID: 132696 RVA: 0x008D1680 File Offset: 0x008CF880
		// (set) Token: 0x06020659 RID: 132697 RVA: 0x008D16B9 File Offset: 0x008CF8B9
		public TMap<FName, float> CurrentFloatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._CurrentFloatMap) == null)
				{
					result = (this._CurrentFloatMap = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				this.CurrentFloatMap.CopyAssign(value);
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0602065A RID: 132698 RVA: 0x008D16C8 File Offset: 0x008CF8C8
		// (set) Token: 0x0602065B RID: 132699 RVA: 0x008D1701 File Offset: 0x008CF901
		public TMap<FName, FLinearColor> CurrentLinearColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._CurrentLinearColorMap) == null)
				{
					result = (this._CurrentLinearColorMap = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				this.CurrentLinearColorMap.CopyAssign(value);
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0602065C RID: 132700 RVA: 0x008D170F File Offset: 0x008CF90F
		// (set) Token: 0x0602065D RID: 132701 RVA: 0x008D1723 File Offset: 0x008CF923
		[Nullable(0)]
		public unsafe TEnumAsByte<EEffectState> InitState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_24);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0602065E RID: 132702 RVA: 0x008D1738 File Offset: 0x008CF938
		// (set) Token: 0x0602065F RID: 132703 RVA: 0x008D1771 File Offset: 0x008CF971
		public TArray<UNiagaraComponent> NiagaraComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraComponents) == null)
				{
					result = (this._NiagaraComponents = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.NiagaraComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06020660 RID: 132704 RVA: 0x008D1780 File Offset: 0x008CF980
		// (set) Token: 0x06020661 RID: 132705 RVA: 0x008D17B9 File Offset: 0x008CF9B9
		public TMap<int, STransitionFloatIndexGroup> TransitionIndexFloatEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, STransitionFloatIndexGroup> result;
				if ((result = this._TransitionIndexFloatEndMap) == null)
				{
					result = (this._TransitionIndexFloatEndMap = new TMap<int, STransitionFloatIndexGroup>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				this.TransitionIndexFloatEndMap.CopyAssign(value);
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06020662 RID: 132706 RVA: 0x008D17C8 File Offset: 0x008CF9C8
		// (set) Token: 0x06020663 RID: 132707 RVA: 0x008D1801 File Offset: 0x008CFA01
		public TMap<int, STransitionLinearColorIndexGroup> TransitionIndexLinearColorEndMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, STransitionLinearColorIndexGroup> result;
				if ((result = this._TransitionIndexLinearColorEndMap) == null)
				{
					result = (this._TransitionIndexLinearColorEndMap = new TMap<int, STransitionLinearColorIndexGroup>(base.NativePtr + (IntPtr)BP_StateMachineEffectBase_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				this.TransitionIndexLinearColorEndMap.CopyAssign(value);
			}
		}

		// Token: 0x06020664 RID: 132708 RVA: 0x008D1810 File Offset: 0x008CFA10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetState(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__SetState_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__SetState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__SetState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__SetState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020665 RID: 132709 RVA: 0x008D185B File Offset: 0x008CFA5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG重初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG重初始化_NativeFunctionPtr, null);
		}

		// Token: 0x06020666 RID: 132710 RVA: 0x008D186F File Offset: 0x008CFA6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG进入状态5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态5_NativeFunctionPtr, null);
		}

		// Token: 0x06020667 RID: 132711 RVA: 0x008D1883 File Offset: 0x008CFA83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG进入状态4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态4_NativeFunctionPtr, null);
		}

		// Token: 0x06020668 RID: 132712 RVA: 0x008D1897 File Offset: 0x008CFA97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG进入状态3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态3_NativeFunctionPtr, null);
		}

		// Token: 0x06020669 RID: 132713 RVA: 0x008D18AB File Offset: 0x008CFAAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG进入状态2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态2_NativeFunctionPtr, null);
		}

		// Token: 0x0602066A RID: 132714 RVA: 0x008D18BF File Offset: 0x008CFABF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG进入状态1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__DEBUG进入状态1_NativeFunctionPtr, null);
		}

		// Token: 0x0602066B RID: 132715 RVA: 0x008D18D4 File Offset: 0x008CFAD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CreateTransitionState(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams[(UIntPtr)4135] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__CreateTransitionState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__CreateTransitionState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__CreateTransitionState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602066C RID: 132716 RVA: 0x008D1924 File Offset: 0x008CFB24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602066D RID: 132717 RVA: 0x008D1993 File Offset: 0x008CFB93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLoopState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UpdateLoopState_NativeFunctionPtr, null);
		}

		// Token: 0x0602066E RID: 132718 RVA: 0x008D19A7 File Offset: 0x008CFBA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePreLoopState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UpdatePreLoopState_NativeFunctionPtr, null);
		}

		// Token: 0x0602066F RID: 132719 RVA: 0x008D19BB File Offset: 0x008CFBBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Transition_State()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Update_Transition_State_NativeFunctionPtr, null);
		}

		// Token: 0x06020670 RID: 132720 RVA: 0x008D19CF File Offset: 0x008CFBCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06020671 RID: 132721 RVA: 0x008D19E4 File Offset: 0x008CFBE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayEffectState(PD_StateMachineEffect_C InputData, EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__PlayEffectState_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__PlayEffectState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__PlayEffectState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__PlayEffectState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputData = ((InputData != null) ? InputData.NativePtr : IntPtr.Zero);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__PlayEffectState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020672 RID: 132722 RVA: 0x008D1A45 File Offset: 0x008CFC45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Tick_NativeFunctionPtr, null);
		}

		// Token: 0x06020673 RID: 132723 RVA: 0x008D1A5C File Offset: 0x008CFC5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Init(EEffectState TargetState)
		{
			BP_StateMachineEffectBase_C.__Init_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__Init_FunctionParams[(UIntPtr)927] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetState = TargetState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__Init_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020674 RID: 132724 RVA: 0x008D1AAA File Offset: 0x008CFCAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020675 RID: 132725 RVA: 0x008D1ABE File Offset: 0x008CFCBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020676 RID: 132726 RVA: 0x008D1AD4 File Offset: 0x008CFCD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020677 RID: 132727 RVA: 0x008D1B1C File Offset: 0x008CFD1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020678 RID: 132728 RVA: 0x008D1B63 File Offset: 0x008CFD63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x06020679 RID: 132729 RVA: 0x008D1B77 File Offset: 0x008CFD77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602067A RID: 132730 RVA: 0x008D1B8C File Offset: 0x008CFD8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602067B RID: 132731 RVA: 0x008D1BD4 File Offset: 0x008CFDD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StateMachineEffectBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602067C RID: 132732 RVA: 0x008D1C1B File Offset: 0x008CFE1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602067D RID: 132733 RVA: 0x008D1C2F File Offset: 0x008CFE2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StateMachineEffectBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602067E RID: 132734 RVA: 0x008D1C44 File Offset: 0x008CFE44
		protected BP_StateMachineEffectBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAC1 RID: 64193
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/BP_StateMachineEffectBase.BP_StateMachineEffectBase_C";

		// Token: 0x0400FAC2 RID: 64194
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAC3 RID: 64195
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAC4 RID: 64196
		internal static int __PropertyOffset_1;

		// Token: 0x0400FAC5 RID: 64197
		internal static int __PropertyOffset_2;

		// Token: 0x0400FAC6 RID: 64198
		internal static int __PropertyOffset_3;

		// Token: 0x0400FAC7 RID: 64199
		internal static int __PropertyOffset_4;

		// Token: 0x0400FAC8 RID: 64200
		internal static int __PropertyOffset_5;

		// Token: 0x0400FAC9 RID: 64201
		internal static int __PropertyOffset_6;

		// Token: 0x0400FACA RID: 64202
		internal static int __PropertyOffset_7;

		// Token: 0x0400FACB RID: 64203
		internal static int __PropertyOffset_8;

		// Token: 0x0400FACC RID: 64204
		internal static int __PropertyOffset_9;

		// Token: 0x0400FACD RID: 64205
		internal static int __PropertyOffset_10;

		// Token: 0x0400FACE RID: 64206
		[Nullable(2)]
		private TMap<FName, float> _TransitionFloatStartMap;

		// Token: 0x0400FACF RID: 64207
		internal static int __PropertyOffset_11;

		// Token: 0x0400FAD0 RID: 64208
		[Nullable(2)]
		private TMap<FName, float> _TransitionFloatEndMap;

		// Token: 0x0400FAD1 RID: 64209
		internal static int __PropertyOffset_12;

		// Token: 0x0400FAD2 RID: 64210
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TransitionLinearColorStartMap;

		// Token: 0x0400FAD3 RID: 64211
		internal static int __PropertyOffset_13;

		// Token: 0x0400FAD4 RID: 64212
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TransitionLinearColorEndMap;

		// Token: 0x0400FAD5 RID: 64213
		internal static int __PropertyOffset_14;

		// Token: 0x0400FAD6 RID: 64214
		internal static int __PropertyOffset_15;

		// Token: 0x0400FAD7 RID: 64215
		internal static int __PropertyOffset_16;

		// Token: 0x0400FAD8 RID: 64216
		internal static int __PropertyOffset_17;

		// Token: 0x0400FAD9 RID: 64217
		internal static int __PropertyOffset_18;

		// Token: 0x0400FADA RID: 64218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _StaticMeshComponents;

		// Token: 0x0400FADB RID: 64219
		internal static int __PropertyOffset_19;

		// Token: 0x0400FADC RID: 64220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _StaticMeshDMIs;

		// Token: 0x0400FADD RID: 64221
		internal static int __PropertyOffset_20;

		// Token: 0x0400FADE RID: 64222
		[Nullable(2)]
		private SEffectStateInfo _CurrentStateInfo;

		// Token: 0x0400FADF RID: 64223
		internal static int __PropertyOffset_21;

		// Token: 0x0400FAE0 RID: 64224
		internal static int __PropertyOffset_22;

		// Token: 0x0400FAE1 RID: 64225
		[Nullable(2)]
		private TMap<FName, float> _CurrentFloatMap;

		// Token: 0x0400FAE2 RID: 64226
		internal static int __PropertyOffset_23;

		// Token: 0x0400FAE3 RID: 64227
		[Nullable(2)]
		private TMap<FName, FLinearColor> _CurrentLinearColorMap;

		// Token: 0x0400FAE4 RID: 64228
		internal static int __PropertyOffset_24;

		// Token: 0x0400FAE5 RID: 64229
		internal static int __PropertyOffset_25;

		// Token: 0x0400FAE6 RID: 64230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraComponents;

		// Token: 0x0400FAE7 RID: 64231
		internal static int __PropertyOffset_26;

		// Token: 0x0400FAE8 RID: 64232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, STransitionFloatIndexGroup> _TransitionIndexFloatEndMap;

		// Token: 0x0400FAE9 RID: 64233
		internal static int __PropertyOffset_27;

		// Token: 0x0400FAEA RID: 64234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, STransitionLinearColorIndexGroup> _TransitionIndexLinearColorEndMap;

		// Token: 0x0400FAEB RID: 64235
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x0400FAEC RID: 64236
		private static IntPtr __DEBUG重初始化_NativeFunctionPtr;

		// Token: 0x0400FAED RID: 64237
		private static IntPtr __DEBUG进入状态5_NativeFunctionPtr;

		// Token: 0x0400FAEE RID: 64238
		private static IntPtr __DEBUG进入状态4_NativeFunctionPtr;

		// Token: 0x0400FAEF RID: 64239
		private static IntPtr __DEBUG进入状态3_NativeFunctionPtr;

		// Token: 0x0400FAF0 RID: 64240
		private static IntPtr __DEBUG进入状态2_NativeFunctionPtr;

		// Token: 0x0400FAF1 RID: 64241
		private static IntPtr __DEBUG进入状态1_NativeFunctionPtr;

		// Token: 0x0400FAF2 RID: 64242
		private static IntPtr __CreateTransitionState_NativeFunctionPtr;

		// Token: 0x0400FAF3 RID: 64243
		private static IntPtr __UpdateParameters_NativeFunctionPtr;

		// Token: 0x0400FAF4 RID: 64244
		private static IntPtr __UpdateLoopState_NativeFunctionPtr;

		// Token: 0x0400FAF5 RID: 64245
		private static IntPtr __UpdatePreLoopState_NativeFunctionPtr;

		// Token: 0x0400FAF6 RID: 64246
		private static IntPtr __Update_Transition_State_NativeFunctionPtr;

		// Token: 0x0400FAF7 RID: 64247
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400FAF8 RID: 64248
		private static IntPtr __PlayEffectState_NativeFunctionPtr;

		// Token: 0x0400FAF9 RID: 64249
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400FAFA RID: 64250
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400FAFB RID: 64251
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FAFC RID: 64252
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FAFD RID: 64253
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x0400FAFE RID: 64254
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FAFF RID: 64255
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009BAD RID: 39853
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x04031224 RID: 201252
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02009BAE RID: 39854
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4120)]
		protected ref struct __CreateTransitionState_FunctionParams
		{
			// Token: 0x04031225 RID: 201253
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02009BAF RID: 39855
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __UpdateParameters_FunctionParams
		{
			// Token: 0x04031226 RID: 201254
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x04031227 RID: 201255
			[FieldOffset(12)]
			public bool IsFloat;

			// Token: 0x04031228 RID: 201256
			[FieldOffset(16)]
			public float FloatValue;

			// Token: 0x04031229 RID: 201257
			[FieldOffset(20)]
			public bool IsLinearColor;

			// Token: 0x0403122A RID: 201258
			[FieldOffset(24)]
			public FLinearColor LinearColorValue;

			// Token: 0x0403122B RID: 201259
			[FieldOffset(40)]
			public int Index;
		}

		// Token: 0x02009BB0 RID: 39856
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PlayEffectState_FunctionParams
		{
			// Token: 0x0403122C RID: 201260
			[FieldOffset(0)]
			public IntPtr InputData;

			// Token: 0x0403122D RID: 201261
			[FieldOffset(8)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02009BB1 RID: 39857
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 912)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x0403122E RID: 201262
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> TargetState;
		}

		// Token: 0x02009BB2 RID: 39858
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403122F RID: 201263
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BB3 RID: 39859
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031230 RID: 201264
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
