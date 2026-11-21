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
	// Token: 0x020032BA RID: 12986
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C")]
	[UnrealStructLayout(7936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7929)]
	public class ABP_SimpleNPC_TimeStop_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020D4F RID: 134479 RVA: 0x0095034B File Offset: 0x0094E54B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_SimpleNPC_TimeStop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C");
			}
			return ABP_SimpleNPC_TimeStop_C._ClassPtr;
		}

		// Token: 0x06020D50 RID: 134480 RVA: 0x00950370 File Offset: 0x0094E570
		public ABP_SimpleNPC_TimeStop_C() : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_TimeStop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D51 RID: 134481 RVA: 0x00950398 File Offset: 0x0094E598
		[NullableContext(1)]
		public ABP_SimpleNPC_TimeStop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_TimeStop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x06020D52 RID: 134482 RVA: 0x009503CB File Offset: 0x0094E5CB
		// (set) Token: 0x06020D53 RID: 134483 RVA: 0x009503DF File Offset: 0x0094E5DF
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x06020D54 RID: 134484 RVA: 0x009503F4 File Offset: 0x0094E5F4
		// (set) Token: 0x06020D55 RID: 134485 RVA: 0x00950404 File Offset: 0x0094E604
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_ifPlayIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_ifPlayIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x06020D56 RID: 134486 RVA: 0x00950418 File Offset: 0x0094E618
		// (set) Token: 0x06020D57 RID: 134487 RVA: 0x00950451 File Offset: 0x0094E651
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IdleMontageArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06020D58 RID: 134488 RVA: 0x0095045F File Offset: 0x0094E65F
		// (set) Token: 0x06020D59 RID: 134489 RVA: 0x00950473 File Offset: 0x0094E673
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_TimeStop_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06020D5A RID: 134490 RVA: 0x00950488 File Offset: 0x0094E688
		// (set) Token: 0x06020D5B RID: 134491 RVA: 0x0095049C File Offset: 0x0094E69C
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06020D5C RID: 134492 RVA: 0x009504B1 File Offset: 0x0094E6B1
		// (set) Token: 0x06020D5D RID: 134493 RVA: 0x009504C1 File Offset: 0x0094E6C1
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsBeingImpacted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsBeingImpacted) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06020D5E RID: 134494 RVA: 0x009504D2 File Offset: 0x0094E6D2
		// (set) Token: 0x06020D5F RID: 134495 RVA: 0x009504E2 File Offset: 0x0094E6E2
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06020D60 RID: 134496 RVA: 0x009504F3 File Offset: 0x0094E6F3
		// (set) Token: 0x06020D61 RID: 134497 RVA: 0x00950503 File Offset: 0x0094E703
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_NpcEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_NpcEntityId) = value;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x06020D62 RID: 134498 RVA: 0x00950514 File Offset: 0x0094E714
		// (set) Token: 0x06020D63 RID: 134499 RVA: 0x00950524 File Offset: 0x0094E724
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_CollisionDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_CollisionDirection) = value;
			}
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x06020D64 RID: 134500 RVA: 0x00950535 File Offset: 0x0094E735
		// (set) Token: 0x06020D65 RID: 134501 RVA: 0x00950545 File Offset: 0x0094E745
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_CollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_CollisionStrength) = value;
			}
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x06020D66 RID: 134502 RVA: 0x00950556 File Offset: 0x0094E756
		// (set) Token: 0x06020D67 RID: 134503 RVA: 0x00950566 File Offset: 0x0094E766
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsBeingAttacked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsBeingAttacked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x06020D68 RID: 134504 RVA: 0x00950577 File Offset: 0x0094E777
		// (set) Token: 0x06020D69 RID: 134505 RVA: 0x00950587 File Offset: 0x0094E787
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x06020D6A RID: 134506 RVA: 0x00950598 File Offset: 0x0094E798
		// (set) Token: 0x06020D6B RID: 134507 RVA: 0x009505A8 File Offset: 0x0094E7A8
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_RandomEpresionEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_RandomEpresionEndTime) = value;
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06020D6C RID: 134508 RVA: 0x009505B9 File Offset: 0x0094E7B9
		// (set) Token: 0x06020D6D RID: 134509 RVA: 0x009505C9 File Offset: 0x0094E7C9
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06020D6E RID: 134510 RVA: 0x009505DA File Offset: 0x0094E7DA
		// (set) Token: 0x06020D6F RID: 134511 RVA: 0x009505EA File Offset: 0x0094E7EA
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06020D70 RID: 134512 RVA: 0x009505FB File Offset: 0x0094E7FB
		// (set) Token: 0x06020D71 RID: 134513 RVA: 0x0095060B File Offset: 0x0094E80B
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_眨眼中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_眨眼中) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x06020D72 RID: 134514 RVA: 0x0095061C File Offset: 0x0094E81C
		// (set) Token: 0x06020D73 RID: 134515 RVA: 0x0095062C File Offset: 0x0094E82C
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x06020D74 RID: 134516 RVA: 0x0095063D File Offset: 0x0094E83D
		// (set) Token: 0x06020D75 RID: 134517 RVA: 0x0095064D File Offset: 0x0094E84D
		public unsafe bool EnableTurnMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_EnableTurnMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_EnableTurnMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06020D76 RID: 134518 RVA: 0x0095065E File Offset: 0x0094E85E
		// (set) Token: 0x06020D77 RID: 134519 RVA: 0x0095066E File Offset: 0x0094E86E
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_TurnYawRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_TurnYawRate) = value;
			}
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06020D78 RID: 134520 RVA: 0x0095067F File Offset: 0x0094E87F
		// (set) Token: 0x06020D79 RID: 134521 RVA: 0x0095068F File Offset: 0x0094E88F
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsForceUpdateSourceAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_TimeStop_C.__PropertyOffset_IsForceUpdateSourceAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020D7A RID: 134522 RVA: 0x009506A0 File Offset: 0x0094E8A0
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020D7B RID: 134523 RVA: 0x009506EF File Offset: 0x0094E8EF
		[SkipLocalsInit]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x06020D7C RID: 134524 RVA: 0x00950703 File Offset: 0x0094E903
		[SkipLocalsInit]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x06020D7D RID: 134525 RVA: 0x00950717 File Offset: 0x0094E917
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020D7E RID: 134526 RVA: 0x0095072C File Offset: 0x0094E92C
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D7F RID: 134527 RVA: 0x00950774 File Offset: 0x0094E974
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D80 RID: 134528 RVA: 0x009507BC File Offset: 0x0094E9BC
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D81 RID: 134529 RVA: 0x00950804 File Offset: 0x0094EA04
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D82 RID: 134530 RVA: 0x0095084A File Offset: 0x0094EA4A
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020D83 RID: 134531 RVA: 0x0095085E File Offset: 0x0094EA5E
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D84 RID: 134532 RVA: 0x00950872 File Offset: 0x0094EA72
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D85 RID: 134533 RVA: 0x00950888 File Offset: 0x0094EA88
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D86 RID: 134534 RVA: 0x009508D0 File Offset: 0x0094EAD0
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D87 RID: 134535 RVA: 0x00950916 File Offset: 0x0094EB16
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D88 RID: 134536 RVA: 0x0095092A File Offset: 0x0094EB2A
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_TimeStop_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D89 RID: 134537 RVA: 0x0095093E File Offset: 0x0094EB3E
		protected ABP_SimpleNPC_TimeStop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C3F RID: 72767
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC_TimeStop.ABP_SimpleNPC_TimeStop_C";

		// Token: 0x04011C40 RID: 72768
		private static IntPtr _ClassPtr;

		// Token: 0x04011C41 RID: 72769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C42 RID: 72770
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011C43 RID: 72771
		internal static int __PropertyOffset_ifPlayIdleAction;

		// Token: 0x04011C44 RID: 72772
		internal static int __PropertyOffset_IdleMontageArray;

		// Token: 0x04011C45 RID: 72773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04011C46 RID: 72774
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011C47 RID: 72775
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011C48 RID: 72776
		internal static int __PropertyOffset_IsBeingImpacted;

		// Token: 0x04011C49 RID: 72777
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011C4A RID: 72778
		internal static int __PropertyOffset_NpcEntityId;

		// Token: 0x04011C4B RID: 72779
		internal static int __PropertyOffset_CollisionDirection;

		// Token: 0x04011C4C RID: 72780
		internal static int __PropertyOffset_CollisionStrength;

		// Token: 0x04011C4D RID: 72781
		internal static int __PropertyOffset_IsBeingAttacked;

		// Token: 0x04011C4E RID: 72782
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04011C4F RID: 72783
		internal static int __PropertyOffset_RandomEpresionEndTime;

		// Token: 0x04011C50 RID: 72784
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011C51 RID: 72785
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011C52 RID: 72786
		internal static int __PropertyOffset_眨眼中;

		// Token: 0x04011C53 RID: 72787
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x04011C54 RID: 72788
		internal static int __PropertyOffset_EnableTurnMode;

		// Token: 0x04011C55 RID: 72789
		internal static int __PropertyOffset_TurnYawRate;

		// Token: 0x04011C56 RID: 72790
		internal static int __PropertyOffset_IsForceUpdateSourceAnimation;

		// Token: 0x04011C57 RID: 72791
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04011C58 RID: 72792
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04011C59 RID: 72793
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04011C5A RID: 72794
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011C5B RID: 72795
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04011C5C RID: 72796
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011C5D RID: 72797
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011C5E RID: 72798
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011C5F RID: 72799
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011C60 RID: 72800
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011C61 RID: 72801
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011C62 RID: 72802
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008FD0 RID: 36816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD77 RID: 183671
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FD1 RID: 36817
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD78 RID: 183672
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FD2 RID: 36818
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD79 RID: 183673
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008FD3 RID: 36819
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD7A RID: 183674
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FD4 RID: 36820
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD7B RID: 183675
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FD5 RID: 36821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD7C RID: 183676
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
