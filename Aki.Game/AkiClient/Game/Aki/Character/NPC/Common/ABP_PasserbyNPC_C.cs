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
	// Token: 0x020032B8 RID: 12984
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C")]
	[UnrealStructLayout(9616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9616)]
	public class ABP_PasserbyNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020CDC RID: 134364 RVA: 0x0094F6F3 File Offset: 0x0094D8F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_PasserbyNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C");
			}
			return ABP_PasserbyNPC_C._ClassPtr;
		}

		// Token: 0x06020CDD RID: 134365 RVA: 0x0094F718 File Offset: 0x0094D918
		public ABP_PasserbyNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_PasserbyNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CDE RID: 134366 RVA: 0x0094F740 File Offset: 0x0094D940
		[NullableContext(1)]
		public ABP_PasserbyNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_PasserbyNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x06020CDF RID: 134367 RVA: 0x0094F773 File Offset: 0x0094D973
		// (set) Token: 0x06020CE0 RID: 134368 RVA: 0x0094F787 File Offset: 0x0094D987
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x06020CE1 RID: 134369 RVA: 0x0094F79C File Offset: 0x0094D99C
		// (set) Token: 0x06020CE2 RID: 134370 RVA: 0x0094F7B0 File Offset: 0x0094D9B0
		public unsafe FVector 移动输入向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_移动输入向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_移动输入向量) = value;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x06020CE3 RID: 134371 RVA: 0x0094F7C5 File Offset: 0x0094D9C5
		// (set) Token: 0x06020CE4 RID: 134372 RVA: 0x0094F7D5 File Offset: 0x0094D9D5
		public unsafe float 速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_速度) = value;
			}
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x06020CE5 RID: 134373 RVA: 0x0094F7E6 File Offset: 0x0094D9E6
		// (set) Token: 0x06020CE6 RID: 134374 RVA: 0x0094F7F6 File Offset: 0x0094D9F6
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_是否有移动输入) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_是否有移动输入) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x06020CE7 RID: 134375 RVA: 0x0094F807 File Offset: 0x0094DA07
		// (set) Token: 0x06020CE8 RID: 134376 RVA: 0x0094F817 File Offset: 0x0094DA17
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_ifPlayIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_ifPlayIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x06020CE9 RID: 134377 RVA: 0x0094F828 File Offset: 0x0094DA28
		// (set) Token: 0x06020CEA RID: 134378 RVA: 0x0094F861 File Offset: 0x0094DA61
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_IdleMontageArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x06020CEB RID: 134379 RVA: 0x0094F86F File Offset: 0x0094DA6F
		// (set) Token: 0x06020CEC RID: 134380 RVA: 0x0094F883 File Offset: 0x0094DA83
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PasserbyNPC_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x06020CED RID: 134381 RVA: 0x0094F898 File Offset: 0x0094DA98
		// (set) Token: 0x06020CEE RID: 134382 RVA: 0x0094F8A8 File Offset: 0x0094DAA8
		public unsafe bool 是否原地转身
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_是否原地转身) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_是否原地转身) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x06020CEF RID: 134383 RVA: 0x0094F8B9 File Offset: 0x0094DAB9
		// (set) Token: 0x06020CF0 RID: 134384 RVA: 0x0094F8C9 File Offset: 0x0094DAC9
		public unsafe float 旋转角度差值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_旋转角度差值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_旋转角度差值) = value;
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x06020CF1 RID: 134385 RVA: 0x0094F8DA File Offset: 0x0094DADA
		// (set) Token: 0x06020CF2 RID: 134386 RVA: 0x0094F8EA File Offset: 0x0094DAEA
		public unsafe float 上一次旋转角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_上一次旋转角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_上一次旋转角度) = value;
			}
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x06020CF3 RID: 134387 RVA: 0x0094F8FB File Offset: 0x0094DAFB
		// (set) Token: 0x06020CF4 RID: 134388 RVA: 0x0094F90F File Offset: 0x0094DB0F
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x06020CF5 RID: 134389 RVA: 0x0094F924 File Offset: 0x0094DB24
		// (set) Token: 0x06020CF6 RID: 134390 RVA: 0x0094F934 File Offset: 0x0094DB34
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x06020CF7 RID: 134391 RVA: 0x0094F945 File Offset: 0x0094DB45
		// (set) Token: 0x06020CF8 RID: 134392 RVA: 0x0094F955 File Offset: 0x0094DB55
		public unsafe float 走跑混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_走跑混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_走跑混合) = value;
			}
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x06020CF9 RID: 134393 RVA: 0x0094F966 File Offset: 0x0094DB66
		// (set) Token: 0x06020CFA RID: 134394 RVA: 0x0094F976 File Offset: 0x0094DB76
		public unsafe bool IsTurnLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_IsTurnLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_IsTurnLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x06020CFB RID: 134395 RVA: 0x0094F987 File Offset: 0x0094DB87
		// (set) Token: 0x06020CFC RID: 134396 RVA: 0x0094F99B File Offset: 0x0094DB9B
		public unsafe FRotator 角色旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_角色旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_角色旋转) = value;
			}
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x06020CFD RID: 134397 RVA: 0x0094F9B0 File Offset: 0x0094DBB0
		// (set) Token: 0x06020CFE RID: 134398 RVA: 0x0094F9C0 File Offset: 0x0094DBC0
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_NpcEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_NpcEntityId) = value;
			}
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x06020CFF RID: 134399 RVA: 0x0094F9D1 File Offset: 0x0094DBD1
		// (set) Token: 0x06020D00 RID: 134400 RVA: 0x0094F9E1 File Offset: 0x0094DBE1
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_DeltaTimeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PasserbyNPC_C.__PropertyOffset_DeltaTimeX) = value;
			}
		}

		// Token: 0x06020D01 RID: 134401 RVA: 0x0094F9F4 File Offset: 0x0094DBF4
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020D02 RID: 134402 RVA: 0x0094FA44 File Offset: 0x0094DC44
		[SkipLocalsInit]
		public unsafe virtual void HasInputRotate(ref bool Output_Get)
		{
			ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__HasInputRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__HasInputRotate_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x06020D03 RID: 134403 RVA: 0x0094FA94 File Offset: 0x0094DC94
		[SkipLocalsInit]
		public unsafe virtual void 是否AI驱动(ref bool Result)
		{
			ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__是否AI驱动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__是否AI驱动_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06020D04 RID: 134404 RVA: 0x0094FAE3 File Offset: 0x0094DCE3
		[SkipLocalsInit]
		public virtual void 更新角色转身()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色转身_NativeFunctionPtr, null);
		}

		// Token: 0x06020D05 RID: 134405 RVA: 0x0094FAF7 File Offset: 0x0094DCF7
		[SkipLocalsInit]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x06020D06 RID: 134406 RVA: 0x0094FB0B File Offset: 0x0094DD0B
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020D07 RID: 134407 RVA: 0x0094FB1F File Offset: 0x0094DD1F
		[SkipLocalsInit]
		public virtual void 更新角色信息()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__更新角色信息_NativeFunctionPtr, null);
		}

		// Token: 0x06020D08 RID: 134408 RVA: 0x0094FB33 File Offset: 0x0094DD33
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020D09 RID: 134409 RVA: 0x0094FB48 File Offset: 0x0094DD48
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D0A RID: 134410 RVA: 0x0094FB90 File Offset: 0x0094DD90
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D0B RID: 134411 RVA: 0x0094FBD8 File Offset: 0x0094DDD8
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D0C RID: 134412 RVA: 0x0094FC20 File Offset: 0x0094DE20
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D0D RID: 134413 RVA: 0x0094FC66 File Offset: 0x0094DE66
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D0E RID: 134414 RVA: 0x0094FC7A File Offset: 0x0094DE7A
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D0F RID: 134415 RVA: 0x0094FC90 File Offset: 0x0094DE90
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D10 RID: 134416 RVA: 0x0094FCD8 File Offset: 0x0094DED8
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D11 RID: 134417 RVA: 0x0094FD1E File Offset: 0x0094DF1E
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PasserbyNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D12 RID: 134418 RVA: 0x0094FD32 File Offset: 0x0094DF32
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PasserbyNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D13 RID: 134419 RVA: 0x0094FD46 File Offset: 0x0094DF46
		protected ABP_PasserbyNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BF7 RID: 72695
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_PasserbyNPC.ABP_PasserbyNPC_C";

		// Token: 0x04011BF8 RID: 72696
		private static IntPtr _ClassPtr;

		// Token: 0x04011BF9 RID: 72697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BFA RID: 72698
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011BFB RID: 72699
		internal static int __PropertyOffset_移动输入向量;

		// Token: 0x04011BFC RID: 72700
		internal static int __PropertyOffset_速度;

		// Token: 0x04011BFD RID: 72701
		internal static int __PropertyOffset_是否有移动输入;

		// Token: 0x04011BFE RID: 72702
		internal static int __PropertyOffset_ifPlayIdleAction;

		// Token: 0x04011BFF RID: 72703
		internal static int __PropertyOffset_IdleMontageArray;

		// Token: 0x04011C00 RID: 72704
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04011C01 RID: 72705
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011C02 RID: 72706
		internal static int __PropertyOffset_是否原地转身;

		// Token: 0x04011C03 RID: 72707
		internal static int __PropertyOffset_旋转角度差值;

		// Token: 0x04011C04 RID: 72708
		internal static int __PropertyOffset_上一次旋转角度;

		// Token: 0x04011C05 RID: 72709
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011C06 RID: 72710
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011C07 RID: 72711
		internal static int __PropertyOffset_走跑混合;

		// Token: 0x04011C08 RID: 72712
		internal static int __PropertyOffset_IsTurnLeft;

		// Token: 0x04011C09 RID: 72713
		internal static int __PropertyOffset_角色旋转;

		// Token: 0x04011C0A RID: 72714
		internal static int __PropertyOffset_NpcEntityId;

		// Token: 0x04011C0B RID: 72715
		internal static int __PropertyOffset_DeltaTimeX;

		// Token: 0x04011C0C RID: 72716
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04011C0D RID: 72717
		private static IntPtr __HasInputRotate_NativeFunctionPtr;

		// Token: 0x04011C0E RID: 72718
		private static IntPtr __是否AI驱动_NativeFunctionPtr;

		// Token: 0x04011C0F RID: 72719
		private static IntPtr __更新角色转身_NativeFunctionPtr;

		// Token: 0x04011C10 RID: 72720
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04011C11 RID: 72721
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011C12 RID: 72722
		private static IntPtr __更新角色信息_NativeFunctionPtr;

		// Token: 0x04011C13 RID: 72723
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011C14 RID: 72724
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011C15 RID: 72725
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011C16 RID: 72726
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011C17 RID: 72727
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04011C18 RID: 72728
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011C19 RID: 72729
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011C1A RID: 72730
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008FC2 RID: 36802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD69 RID: 183657
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FC3 RID: 36803
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __HasInputRotate_FunctionParams
		{
			// Token: 0x0402CD6A RID: 183658
			[FieldOffset(0)]
			public bool Output_Get;
		}

		// Token: 0x02008FC4 RID: 36804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __是否AI驱动_FunctionParams
		{
			// Token: 0x0402CD6B RID: 183659
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008FC5 RID: 36805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD6C RID: 183660
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FC6 RID: 36806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD6D RID: 183661
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FC7 RID: 36807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD6E RID: 183662
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008FC8 RID: 36808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD6F RID: 183663
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FC9 RID: 36809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD70 RID: 183664
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
