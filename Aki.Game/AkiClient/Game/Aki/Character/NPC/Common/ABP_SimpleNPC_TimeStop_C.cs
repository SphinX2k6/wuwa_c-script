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
	// Token: 0x0200419D RID: 16797
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C")]
	[UnrealStructLayout(7920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7913)]
	public class ABP_SimpleNPC_TimeStop_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602BA9C RID: 178844 RVA: 0x00A06B6D File Offset: 0x00A04D6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_SimpleNPC_TimeStop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C");
			}
			return ABP_SimpleNPC_TimeStop_C._ClassPtr;
		}

		// Token: 0x0602BA9D RID: 178845 RVA: 0x00A06B94 File Offset: 0x00A04D94
		public ABP_SimpleNPC_TimeStop_C() : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_TimeStop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BA9E RID: 178846 RVA: 0x00A06BBC File Offset: 0x00A04DBC
		[NullableContext(1)]
		public ABP_SimpleNPC_TimeStop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_TimeStop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C69 RID: 27753
		// (get) Token: 0x0602BA9F RID: 178847 RVA: 0x00A06BEF File Offset: 0x00A04DEF
		// (set) Token: 0x0602BAA0 RID: 178848 RVA: 0x00A06C03 File Offset: 0x00A04E03
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_29);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17006C6A RID: 27754
		// (get) Token: 0x0602BAA1 RID: 178849 RVA: 0x00A06C18 File Offset: 0x00A04E18
		// (set) Token: 0x0602BAA2 RID: 178850 RVA: 0x00A06C28 File Offset: 0x00A04E28
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C6B RID: 27755
		// (get) Token: 0x0602BAA3 RID: 178851 RVA: 0x00A06C3C File Offset: 0x00A04E3C
		// (set) Token: 0x0602BAA4 RID: 178852 RVA: 0x00A06C75 File Offset: 0x00A04E75
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_31, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17006C6C RID: 27756
		// (get) Token: 0x0602BAA5 RID: 178853 RVA: 0x00A06C83 File Offset: 0x00A04E83
		// (set) Token: 0x0602BAA6 RID: 178854 RVA: 0x00A06C97 File Offset: 0x00A04E97
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_32);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17006C6D RID: 27757
		// (get) Token: 0x0602BAA7 RID: 178855 RVA: 0x00A06CAC File Offset: 0x00A04EAC
		// (set) Token: 0x0602BAA8 RID: 178856 RVA: 0x00A06CC0 File Offset: 0x00A04EC0
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17006C6E RID: 27758
		// (get) Token: 0x0602BAA9 RID: 178857 RVA: 0x00A06CD5 File Offset: 0x00A04ED5
		// (set) Token: 0x0602BAAA RID: 178858 RVA: 0x00A06CE5 File Offset: 0x00A04EE5
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C6F RID: 27759
		// (get) Token: 0x0602BAAB RID: 178859 RVA: 0x00A06CF6 File Offset: 0x00A04EF6
		// (set) Token: 0x0602BAAC RID: 178860 RVA: 0x00A06D06 File Offset: 0x00A04F06
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_35));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_35) = (byte)value;
			}
		}

		// Token: 0x17006C70 RID: 27760
		// (get) Token: 0x0602BAAD RID: 178861 RVA: 0x00A06D17 File Offset: 0x00A04F17
		// (set) Token: 0x0602BAAE RID: 178862 RVA: 0x00A06D27 File Offset: 0x00A04F27
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17006C71 RID: 27761
		// (get) Token: 0x0602BAAF RID: 178863 RVA: 0x00A06D38 File Offset: 0x00A04F38
		// (set) Token: 0x0602BAB0 RID: 178864 RVA: 0x00A06D48 File Offset: 0x00A04F48
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17006C72 RID: 27762
		// (get) Token: 0x0602BAB1 RID: 178865 RVA: 0x00A06D59 File Offset: 0x00A04F59
		// (set) Token: 0x0602BAB2 RID: 178866 RVA: 0x00A06D69 File Offset: 0x00A04F69
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17006C73 RID: 27763
		// (get) Token: 0x0602BAB3 RID: 178867 RVA: 0x00A06D7A File Offset: 0x00A04F7A
		// (set) Token: 0x0602BAB4 RID: 178868 RVA: 0x00A06D8A File Offset: 0x00A04F8A
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C74 RID: 27764
		// (get) Token: 0x0602BAB5 RID: 178869 RVA: 0x00A06D9B File Offset: 0x00A04F9B
		// (set) Token: 0x0602BAB6 RID: 178870 RVA: 0x00A06DAB File Offset: 0x00A04FAB
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006C75 RID: 27765
		// (get) Token: 0x0602BAB7 RID: 178871 RVA: 0x00A06DBC File Offset: 0x00A04FBC
		// (set) Token: 0x0602BAB8 RID: 178872 RVA: 0x00A06DCC File Offset: 0x00A04FCC
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006C76 RID: 27766
		// (get) Token: 0x0602BAB9 RID: 178873 RVA: 0x00A06DDD File Offset: 0x00A04FDD
		// (set) Token: 0x0602BABA RID: 178874 RVA: 0x00A06DED File Offset: 0x00A04FED
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17006C77 RID: 27767
		// (get) Token: 0x0602BABB RID: 178875 RVA: 0x00A06DFE File Offset: 0x00A04FFE
		// (set) Token: 0x0602BABC RID: 178876 RVA: 0x00A06E0E File Offset: 0x00A0500E
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17006C78 RID: 27768
		// (get) Token: 0x0602BABD RID: 178877 RVA: 0x00A06E1F File Offset: 0x00A0501F
		// (set) Token: 0x0602BABE RID: 178878 RVA: 0x00A06E2F File Offset: 0x00A0502F
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C79 RID: 27769
		// (get) Token: 0x0602BABF RID: 178879 RVA: 0x00A06E40 File Offset: 0x00A05040
		// (set) Token: 0x0602BAC0 RID: 178880 RVA: 0x00A06E50 File Offset: 0x00A05050
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C7A RID: 27770
		// (get) Token: 0x0602BAC1 RID: 178881 RVA: 0x00A06E61 File Offset: 0x00A05061
		// (set) Token: 0x0602BAC2 RID: 178882 RVA: 0x00A06E71 File Offset: 0x00A05071
		public unsafe bool EnableTurnMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C7B RID: 27771
		// (get) Token: 0x0602BAC3 RID: 178883 RVA: 0x00A06E82 File Offset: 0x00A05082
		// (set) Token: 0x0602BAC4 RID: 178884 RVA: 0x00A06E92 File Offset: 0x00A05092
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17006C7C RID: 27772
		// (get) Token: 0x0602BAC5 RID: 178885 RVA: 0x00A06EA3 File Offset: 0x00A050A3
		// (set) Token: 0x0602BAC6 RID: 178886 RVA: 0x00A06EB3 File Offset: 0x00A050B3
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BAC7 RID: 178887 RVA: 0x00A06EC4 File Offset: 0x00A050C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602BAC8 RID: 178888 RVA: 0x00A06F14 File Offset: 0x00A05114
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_SimpleNPC_TimeStop_C.__基础层_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BAC9 RID: 178889 RVA: 0x00A06F9C File Offset: 0x00A0519C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_SimpleNPC_TimeStop_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BACA RID: 178890 RVA: 0x00A07023 File Offset: 0x00A05223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x0602BACB RID: 178891 RVA: 0x00A07037 File Offset: 0x00A05237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602BACC RID: 178892 RVA: 0x00A0704B File Offset: 0x00A0524B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BACD RID: 178893 RVA: 0x00A07060 File Offset: 0x00A05260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BACE RID: 178894 RVA: 0x00A070A8 File Offset: 0x00A052A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BACF RID: 178895 RVA: 0x00A070F0 File Offset: 0x00A052F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BAD0 RID: 178896 RVA: 0x00A07138 File Offset: 0x00A05338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BAD1 RID: 178897 RVA: 0x00A0717E File Offset: 0x00A0537E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602BAD2 RID: 178898 RVA: 0x00A07192 File Offset: 0x00A05392
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BAD3 RID: 178899 RVA: 0x00A071A6 File Offset: 0x00A053A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BAD4 RID: 178900 RVA: 0x00A071BC File Offset: 0x00A053BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BAD5 RID: 178901 RVA: 0x00A07204 File Offset: 0x00A05404
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BAD6 RID: 178902 RVA: 0x00A0724B File Offset: 0x00A0544B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BAD7 RID: 178903 RVA: 0x00A0725F File Offset: 0x00A0545F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BAD8 RID: 178904 RVA: 0x00A07274 File Offset: 0x00A05474
		protected ABP_SimpleNPC_TimeStop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016BD8 RID: 93144
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C";

		// Token: 0x04016BD9 RID: 93145
		private static IntPtr _ClassPtr;

		// Token: 0x04016BDA RID: 93146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016BDB RID: 93147
		internal static int __PropertyOffset_29;

		// Token: 0x04016BDC RID: 93148
		internal static int __PropertyOffset_30;

		// Token: 0x04016BDD RID: 93149
		internal static int __PropertyOffset_31;

		// Token: 0x04016BDE RID: 93150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04016BDF RID: 93151
		internal static int __PropertyOffset_32;

		// Token: 0x04016BE0 RID: 93152
		internal static int __PropertyOffset_33;

		// Token: 0x04016BE1 RID: 93153
		internal static int __PropertyOffset_34;

		// Token: 0x04016BE2 RID: 93154
		internal static int __PropertyOffset_35;

		// Token: 0x04016BE3 RID: 93155
		internal static int __PropertyOffset_36;

		// Token: 0x04016BE4 RID: 93156
		internal static int __PropertyOffset_37;

		// Token: 0x04016BE5 RID: 93157
		internal static int __PropertyOffset_38;

		// Token: 0x04016BE6 RID: 93158
		internal static int __PropertyOffset_39;

		// Token: 0x04016BE7 RID: 93159
		internal static int __PropertyOffset_40;

		// Token: 0x04016BE8 RID: 93160
		internal static int __PropertyOffset_41;

		// Token: 0x04016BE9 RID: 93161
		internal static int __PropertyOffset_42;

		// Token: 0x04016BEA RID: 93162
		internal static int __PropertyOffset_43;

		// Token: 0x04016BEB RID: 93163
		internal static int __PropertyOffset_44;

		// Token: 0x04016BEC RID: 93164
		internal static int __PropertyOffset_45;

		// Token: 0x04016BED RID: 93165
		internal static int __PropertyOffset_46;

		// Token: 0x04016BEE RID: 93166
		internal static int __PropertyOffset_47;

		// Token: 0x04016BEF RID: 93167
		internal static int __PropertyOffset_48;

		// Token: 0x04016BF0 RID: 93168
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016BF1 RID: 93169
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016BF2 RID: 93170
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016BF3 RID: 93171
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04016BF4 RID: 93172
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04016BF5 RID: 93173
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016BF6 RID: 93174
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016BF7 RID: 93175
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04016BF8 RID: 93176
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04016BF9 RID: 93177
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04016BFA RID: 93178
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016BFB RID: 93179
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016BFC RID: 93180
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016BFD RID: 93181
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A56F RID: 42351
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040323EF RID: 205807
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A570 RID: 42352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040323F0 RID: 205808
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A571 RID: 42353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323F1 RID: 205809
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A572 RID: 42354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040323F2 RID: 205810
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A573 RID: 42355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040323F3 RID: 205811
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A574 RID: 42356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040323F4 RID: 205812
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A575 RID: 42357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040323F5 RID: 205813
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A576 RID: 42358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323F6 RID: 205814
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
