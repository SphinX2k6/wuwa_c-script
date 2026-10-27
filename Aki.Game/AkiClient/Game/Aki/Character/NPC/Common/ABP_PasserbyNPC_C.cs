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
	// Token: 0x0200419B RID: 16795
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C")]
	[UnrealStructLayout(9568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9568)]
	public class ABP_PasserbyNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602BA25 RID: 178725 RVA: 0x00A05CED File Offset: 0x00A03EED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_PasserbyNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C");
			}
			return ABP_PasserbyNPC_C._ClassPtr;
		}

		// Token: 0x0602BA26 RID: 178726 RVA: 0x00A05D14 File Offset: 0x00A03F14
		public ABP_PasserbyNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_PasserbyNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BA27 RID: 178727 RVA: 0x00A05D3C File Offset: 0x00A03F3C
		[NullableContext(1)]
		public ABP_PasserbyNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_PasserbyNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C44 RID: 27716
		// (get) Token: 0x0602BA28 RID: 178728 RVA: 0x00A05D6F File Offset: 0x00A03F6F
		// (set) Token: 0x0602BA29 RID: 178729 RVA: 0x00A05D83 File Offset: 0x00A03F83
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_39);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17006C45 RID: 27717
		// (get) Token: 0x0602BA2A RID: 178730 RVA: 0x00A05D98 File Offset: 0x00A03F98
		// (set) Token: 0x0602BA2B RID: 178731 RVA: 0x00A05DAC File Offset: 0x00A03FAC
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17006C46 RID: 27718
		// (get) Token: 0x0602BA2C RID: 178732 RVA: 0x00A05DC1 File Offset: 0x00A03FC1
		// (set) Token: 0x0602BA2D RID: 178733 RVA: 0x00A05DD1 File Offset: 0x00A03FD1
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17006C47 RID: 27719
		// (get) Token: 0x0602BA2E RID: 178734 RVA: 0x00A05DE2 File Offset: 0x00A03FE2
		// (set) Token: 0x0602BA2F RID: 178735 RVA: 0x00A05DF2 File Offset: 0x00A03FF2
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C48 RID: 27720
		// (get) Token: 0x0602BA30 RID: 178736 RVA: 0x00A05E03 File Offset: 0x00A04003
		// (set) Token: 0x0602BA31 RID: 178737 RVA: 0x00A05E13 File Offset: 0x00A04013
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C49 RID: 27721
		// (get) Token: 0x0602BA32 RID: 178738 RVA: 0x00A05E24 File Offset: 0x00A04024
		// (set) Token: 0x0602BA33 RID: 178739 RVA: 0x00A05E5D File Offset: 0x00A0405D
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_44, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17006C4A RID: 27722
		// (get) Token: 0x0602BA34 RID: 178740 RVA: 0x00A05E6B File Offset: 0x00A0406B
		// (set) Token: 0x0602BA35 RID: 178741 RVA: 0x00A05E7F File Offset: 0x00A0407F
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_45);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_45, value);
			}
		}

		// Token: 0x17006C4B RID: 27723
		// (get) Token: 0x0602BA36 RID: 178742 RVA: 0x00A05E94 File Offset: 0x00A04094
		// (set) Token: 0x0602BA37 RID: 178743 RVA: 0x00A05EA4 File Offset: 0x00A040A4
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C4C RID: 27724
		// (get) Token: 0x0602BA38 RID: 178744 RVA: 0x00A05EB5 File Offset: 0x00A040B5
		// (set) Token: 0x0602BA39 RID: 178745 RVA: 0x00A05EC5 File Offset: 0x00A040C5
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17006C4D RID: 27725
		// (get) Token: 0x0602BA3A RID: 178746 RVA: 0x00A05ED6 File Offset: 0x00A040D6
		// (set) Token: 0x0602BA3B RID: 178747 RVA: 0x00A05EE6 File Offset: 0x00A040E6
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17006C4E RID: 27726
		// (get) Token: 0x0602BA3C RID: 178748 RVA: 0x00A05EF7 File Offset: 0x00A040F7
		// (set) Token: 0x0602BA3D RID: 178749 RVA: 0x00A05F0B File Offset: 0x00A0410B
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17006C4F RID: 27727
		// (get) Token: 0x0602BA3E RID: 178750 RVA: 0x00A05F20 File Offset: 0x00A04120
		// (set) Token: 0x0602BA3F RID: 178751 RVA: 0x00A05F30 File Offset: 0x00A04130
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_50));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_50) = (byte)value;
			}
		}

		// Token: 0x17006C50 RID: 27728
		// (get) Token: 0x0602BA40 RID: 178752 RVA: 0x00A05F41 File Offset: 0x00A04141
		// (set) Token: 0x0602BA41 RID: 178753 RVA: 0x00A05F51 File Offset: 0x00A04151
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17006C51 RID: 27729
		// (get) Token: 0x0602BA42 RID: 178754 RVA: 0x00A05F62 File Offset: 0x00A04162
		// (set) Token: 0x0602BA43 RID: 178755 RVA: 0x00A05F72 File Offset: 0x00A04172
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_52) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_52) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C52 RID: 27730
		// (get) Token: 0x0602BA44 RID: 178756 RVA: 0x00A05F83 File Offset: 0x00A04183
		// (set) Token: 0x0602BA45 RID: 178757 RVA: 0x00A05F97 File Offset: 0x00A04197
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17006C53 RID: 27731
		// (get) Token: 0x0602BA46 RID: 178758 RVA: 0x00A05FAC File Offset: 0x00A041AC
		// (set) Token: 0x0602BA47 RID: 178759 RVA: 0x00A05FBC File Offset: 0x00A041BC
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17006C54 RID: 27732
		// (get) Token: 0x0602BA48 RID: 178760 RVA: 0x00A05FCD File Offset: 0x00A041CD
		// (set) Token: 0x0602BA49 RID: 178761 RVA: 0x00A05FDD File Offset: 0x00A041DD
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x0602BA4A RID: 178762 RVA: 0x00A05FF0 File Offset: 0x00A041F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x0602BA4B RID: 178763 RVA: 0x00A06040 File Offset: 0x00A04240
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_PasserbyNPC_C.__基础层_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BA4C RID: 178764 RVA: 0x00A060C8 File Offset: 0x00A042C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_PasserbyNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BA4D RID: 178765 RVA: 0x00A06150 File Offset: 0x00A04350
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x0602BA4E RID: 178766 RVA: 0x00A061A0 File Offset: 0x00A043A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0602BA4F RID: 178767 RVA: 0x00A061EF File Offset: 0x00A043EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA50 RID: 178768 RVA: 0x00A06203 File Offset: 0x00A04403
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA51 RID: 178769 RVA: 0x00A06217 File Offset: 0x00A04417
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA52 RID: 178770 RVA: 0x00A0622B File Offset: 0x00A0442B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA53 RID: 178771 RVA: 0x00A0623F File Offset: 0x00A0443F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA54 RID: 178772 RVA: 0x00A06254 File Offset: 0x00A04454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA55 RID: 178773 RVA: 0x00A0629C File Offset: 0x00A0449C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA56 RID: 178774 RVA: 0x00A062E4 File Offset: 0x00A044E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA57 RID: 178775 RVA: 0x00A0632C File Offset: 0x00A0452C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA58 RID: 178776 RVA: 0x00A06372 File Offset: 0x00A04572
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA59 RID: 178777 RVA: 0x00A06386 File Offset: 0x00A04586
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA5A RID: 178778 RVA: 0x00A0639C File Offset: 0x00A0459C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BA5B RID: 178779 RVA: 0x00A063E4 File Offset: 0x00A045E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BA5C RID: 178780 RVA: 0x00A0642B File Offset: 0x00A0462B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BA5D RID: 178781 RVA: 0x00A0643F File Offset: 0x00A0463F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BA5E RID: 178782 RVA: 0x00A06454 File Offset: 0x00A04654
		protected ABP_PasserbyNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016B8C RID: 93068
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C";

		// Token: 0x04016B8D RID: 93069
		private static IntPtr _ClassPtr;

		// Token: 0x04016B8E RID: 93070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016B8F RID: 93071
		internal static int __PropertyOffset_39;

		// Token: 0x04016B90 RID: 93072
		internal static int __PropertyOffset_40;

		// Token: 0x04016B91 RID: 93073
		internal static int __PropertyOffset_41;

		// Token: 0x04016B92 RID: 93074
		internal static int __PropertyOffset_42;

		// Token: 0x04016B93 RID: 93075
		internal static int __PropertyOffset_43;

		// Token: 0x04016B94 RID: 93076
		internal static int __PropertyOffset_44;

		// Token: 0x04016B95 RID: 93077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04016B96 RID: 93078
		internal static int __PropertyOffset_45;

		// Token: 0x04016B97 RID: 93079
		internal static int __PropertyOffset_46;

		// Token: 0x04016B98 RID: 93080
		internal static int __PropertyOffset_47;

		// Token: 0x04016B99 RID: 93081
		internal static int __PropertyOffset_48;

		// Token: 0x04016B9A RID: 93082
		internal static int __PropertyOffset_49;

		// Token: 0x04016B9B RID: 93083
		internal static int __PropertyOffset_50;

		// Token: 0x04016B9C RID: 93084
		internal static int __PropertyOffset_51;

		// Token: 0x04016B9D RID: 93085
		internal static int __PropertyOffset_52;

		// Token: 0x04016B9E RID: 93086
		internal static int __PropertyOffset_53;

		// Token: 0x04016B9F RID: 93087
		internal static int __PropertyOffset_54;

		// Token: 0x04016BA0 RID: 93088
		internal static int __PropertyOffset_55;

		// Token: 0x04016BA1 RID: 93089
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04016BA2 RID: 93090
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016BA3 RID: 93091
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016BA4 RID: 93092
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04016BA5 RID: 93093
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04016BA6 RID: 93094
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04016BA7 RID: 93095
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016BA8 RID: 93096
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016BA9 RID: 93097
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04016BAA RID: 93098
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04016BAB RID: 93099
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04016BAC RID: 93100
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04016BAD RID: 93101
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04016BAE RID: 93102
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04016BAF RID: 93103
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016BB0 RID: 93104
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016BB1 RID: 93105
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A55D RID: 42333
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x040323DD RID: 205789
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A55E RID: 42334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040323DE RID: 205790
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A55F RID: 42335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040323DF RID: 205791
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A560 RID: 42336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x040323E0 RID: 205792
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x0200A561 RID: 42337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x040323E1 RID: 205793
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A562 RID: 42338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x040323E2 RID: 205794
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x0200A563 RID: 42339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x040323E3 RID: 205795
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A564 RID: 42340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x040323E4 RID: 205796
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x0200A565 RID: 42341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x040323E5 RID: 205797
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A566 RID: 42342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040323E6 RID: 205798
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
