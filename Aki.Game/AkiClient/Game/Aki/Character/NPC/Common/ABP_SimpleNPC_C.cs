using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x0200419C RID: 16796
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C")]
	[UnrealStructLayout(8352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8337)]
	public class ABP_SimpleNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602BA5F RID: 178783 RVA: 0x00A0645D File Offset: 0x00A0465D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_SimpleNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C");
			}
			return ABP_SimpleNPC_C._ClassPtr;
		}

		// Token: 0x0602BA60 RID: 178784 RVA: 0x00A06484 File Offset: 0x00A04684
		public ABP_SimpleNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BA61 RID: 178785 RVA: 0x00A064AC File Offset: 0x00A046AC
		[NullableContext(1)]
		public ABP_SimpleNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C55 RID: 27733
		// (get) Token: 0x0602BA62 RID: 178786 RVA: 0x00A064DF File Offset: 0x00A046DF
		// (set) Token: 0x0602BA63 RID: 178787 RVA: 0x00A064F3 File Offset: 0x00A046F3
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_33);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17006C56 RID: 27734
		// (get) Token: 0x0602BA64 RID: 178788 RVA: 0x00A06508 File Offset: 0x00A04708
		// (set) Token: 0x0602BA65 RID: 178789 RVA: 0x00A06518 File Offset: 0x00A04718
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C57 RID: 27735
		// (get) Token: 0x0602BA66 RID: 178790 RVA: 0x00A0652C File Offset: 0x00A0472C
		// (set) Token: 0x0602BA67 RID: 178791 RVA: 0x00A06565 File Offset: 0x00A04765
		[Nullable(1)]
		public TArray<UAnimMontage> IdleMontageArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimMontage> result;
				if ((result = this._IdleMontageArray) == null)
				{
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_35, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17006C58 RID: 27736
		// (get) Token: 0x0602BA68 RID: 178792 RVA: 0x00A06573 File Offset: 0x00A04773
		// (set) Token: 0x0602BA69 RID: 178793 RVA: 0x00A06587 File Offset: 0x00A04787
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_36);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17006C59 RID: 27737
		// (get) Token: 0x0602BA6A RID: 178794 RVA: 0x00A0659C File Offset: 0x00A0479C
		// (set) Token: 0x0602BA6B RID: 178795 RVA: 0x00A065B0 File Offset: 0x00A047B0
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006C5A RID: 27738
		// (get) Token: 0x0602BA6C RID: 178796 RVA: 0x00A065C5 File Offset: 0x00A047C5
		// (set) Token: 0x0602BA6D RID: 178797 RVA: 0x00A065D5 File Offset: 0x00A047D5
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C5B RID: 27739
		// (get) Token: 0x0602BA6E RID: 178798 RVA: 0x00A065E6 File Offset: 0x00A047E6
		// (set) Token: 0x0602BA6F RID: 178799 RVA: 0x00A065F6 File Offset: 0x00A047F6
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_39));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_39) = (byte)value;
			}
		}

		// Token: 0x17006C5C RID: 27740
		// (get) Token: 0x0602BA70 RID: 178800 RVA: 0x00A06607 File Offset: 0x00A04807
		// (set) Token: 0x0602BA71 RID: 178801 RVA: 0x00A06617 File Offset: 0x00A04817
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006C5D RID: 27741
		// (get) Token: 0x0602BA72 RID: 178802 RVA: 0x00A06628 File Offset: 0x00A04828
		// (set) Token: 0x0602BA73 RID: 178803 RVA: 0x00A06638 File Offset: 0x00A04838
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006C5E RID: 27742
		// (get) Token: 0x0602BA74 RID: 178804 RVA: 0x00A06649 File Offset: 0x00A04849
		// (set) Token: 0x0602BA75 RID: 178805 RVA: 0x00A06659 File Offset: 0x00A04859
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17006C5F RID: 27743
		// (get) Token: 0x0602BA76 RID: 178806 RVA: 0x00A0666A File Offset: 0x00A0486A
		// (set) Token: 0x0602BA77 RID: 178807 RVA: 0x00A0667A File Offset: 0x00A0487A
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C60 RID: 27744
		// (get) Token: 0x0602BA78 RID: 178808 RVA: 0x00A0668B File Offset: 0x00A0488B
		// (set) Token: 0x0602BA79 RID: 178809 RVA: 0x00A0669B File Offset: 0x00A0489B
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17006C61 RID: 27745
		// (get) Token: 0x0602BA7A RID: 178810 RVA: 0x00A066AC File Offset: 0x00A048AC
		// (set) Token: 0x0602BA7B RID: 178811 RVA: 0x00A066BC File Offset: 0x00A048BC
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17006C62 RID: 27746
		// (get) Token: 0x0602BA7C RID: 178812 RVA: 0x00A066CD File Offset: 0x00A048CD
		// (set) Token: 0x0602BA7D RID: 178813 RVA: 0x00A066DD File Offset: 0x00A048DD
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17006C63 RID: 27747
		// (get) Token: 0x0602BA7E RID: 178814 RVA: 0x00A066EE File Offset: 0x00A048EE
		// (set) Token: 0x0602BA7F RID: 178815 RVA: 0x00A066FE File Offset: 0x00A048FE
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17006C64 RID: 27748
		// (get) Token: 0x0602BA80 RID: 178816 RVA: 0x00A0670F File Offset: 0x00A0490F
		// (set) Token: 0x0602BA81 RID: 178817 RVA: 0x00A0671F File Offset: 0x00A0491F
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C65 RID: 27749
		// (get) Token: 0x0602BA82 RID: 178818 RVA: 0x00A06730 File Offset: 0x00A04930
		// (set) Token: 0x0602BA83 RID: 178819 RVA: 0x00A06740 File Offset: 0x00A04940
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C66 RID: 27750
		// (get) Token: 0x0602BA84 RID: 178820 RVA: 0x00A06751 File Offset: 0x00A04951
		// (set) Token: 0x0602BA85 RID: 178821 RVA: 0x00A06761 File Offset: 0x00A04961
		public unsafe bool EnableTurnMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C67 RID: 27751
		// (get) Token: 0x0602BA86 RID: 178822 RVA: 0x00A06772 File Offset: 0x00A04972
		// (set) Token: 0x0602BA87 RID: 178823 RVA: 0x00A06782 File Offset: 0x00A04982
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17006C68 RID: 27752
		// (get) Token: 0x0602BA88 RID: 178824 RVA: 0x00A06793 File Offset: 0x00A04993
		// (set) Token: 0x0602BA89 RID: 178825 RVA: 0x00A067A3 File Offset: 0x00A049A3
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BA8A RID: 178826 RVA: 0x00A067B4 File Offset: 0x00A049B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602BA8B RID: 178827 RVA: 0x00A06804 File Offset: 0x00A04A04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_SimpleNPC_C.__基础层_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_SimpleNPC_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BA8C RID: 178828 RVA: 0x00A0688C File Offset: 0x00A04A8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_SimpleNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_SimpleNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BA8D RID: 178829 RVA: 0x00A06913 File Offset: 0x00A04B13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA8E RID: 178830 RVA: 0x00A06927 File Offset: 0x00A04B27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA8F RID: 178831 RVA: 0x00A0693B File Offset: 0x00A04B3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA90 RID: 178832 RVA: 0x00A0694F File Offset: 0x00A04B4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA91 RID: 178833 RVA: 0x00A06964 File Offset: 0x00A04B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA92 RID: 178834 RVA: 0x00A069AC File Offset: 0x00A04BAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA93 RID: 178835 RVA: 0x00A069F4 File Offset: 0x00A04BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA94 RID: 178836 RVA: 0x00A06A3C File Offset: 0x00A04C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA95 RID: 178837 RVA: 0x00A06A82 File Offset: 0x00A04C82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA96 RID: 178838 RVA: 0x00A06A96 File Offset: 0x00A04C96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA97 RID: 178839 RVA: 0x00A06AAC File Offset: 0x00A04CAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA98 RID: 178840 RVA: 0x00A06AF4 File Offset: 0x00A04CF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BA99 RID: 178841 RVA: 0x00A06B3B File Offset: 0x00A04D3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA9A RID: 178842 RVA: 0x00A06B4F File Offset: 0x00A04D4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA9B RID: 178843 RVA: 0x00A06B64 File Offset: 0x00A04D64
		protected ABP_SimpleNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016BB2 RID: 93106
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C";

		// Token: 0x04016BB3 RID: 93107
		private static IntPtr _ClassPtr;

		// Token: 0x04016BB4 RID: 93108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016BB5 RID: 93109
		internal static int __PropertyOffset_33;

		// Token: 0x04016BB6 RID: 93110
		internal static int __PropertyOffset_34;

		// Token: 0x04016BB7 RID: 93111
		internal static int __PropertyOffset_35;

		// Token: 0x04016BB8 RID: 93112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04016BB9 RID: 93113
		internal static int __PropertyOffset_36;

		// Token: 0x04016BBA RID: 93114
		internal static int __PropertyOffset_37;

		// Token: 0x04016BBB RID: 93115
		internal static int __PropertyOffset_38;

		// Token: 0x04016BBC RID: 93116
		internal static int __PropertyOffset_39;

		// Token: 0x04016BBD RID: 93117
		internal static int __PropertyOffset_40;

		// Token: 0x04016BBE RID: 93118
		internal static int __PropertyOffset_41;

		// Token: 0x04016BBF RID: 93119
		internal static int __PropertyOffset_42;

		// Token: 0x04016BC0 RID: 93120
		internal static int __PropertyOffset_43;

		// Token: 0x04016BC1 RID: 93121
		internal static int __PropertyOffset_44;

		// Token: 0x04016BC2 RID: 93122
		internal static int __PropertyOffset_45;

		// Token: 0x04016BC3 RID: 93123
		internal static int __PropertyOffset_46;

		// Token: 0x04016BC4 RID: 93124
		internal static int __PropertyOffset_47;

		// Token: 0x04016BC5 RID: 93125
		internal static int __PropertyOffset_48;

		// Token: 0x04016BC6 RID: 93126
		internal static int __PropertyOffset_49;

		// Token: 0x04016BC7 RID: 93127
		internal static int __PropertyOffset_50;

		// Token: 0x04016BC8 RID: 93128
		internal static int __PropertyOffset_51;

		// Token: 0x04016BC9 RID: 93129
		internal static int __PropertyOffset_52;

		// Token: 0x04016BCA RID: 93130
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016BCB RID: 93131
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016BCC RID: 93132
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016BCD RID: 93133
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04016BCE RID: 93134
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04016BCF RID: 93135
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016BD0 RID: 93136
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016BD1 RID: 93137
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04016BD2 RID: 93138
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04016BD3 RID: 93139
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04016BD4 RID: 93140
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016BD5 RID: 93141
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016BD6 RID: 93142
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016BD7 RID: 93143
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A567 RID: 42343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040323E7 RID: 205799
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A568 RID: 42344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040323E8 RID: 205800
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A569 RID: 42345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323E9 RID: 205801
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A56A RID: 42346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040323EA RID: 205802
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A56B RID: 42347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040323EB RID: 205803
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A56C RID: 42348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040323EC RID: 205804
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A56D RID: 42349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040323ED RID: 205805
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A56E RID: 42350
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323EE RID: 205806
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
