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
	// Token: 0x020032B9 RID: 12985
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C")]
	[UnrealStructLayout(8368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8353)]
	public class ABP_SimpleNPC_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject, IBPI_Animation_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020D14 RID: 134420 RVA: 0x0094FD4F File Offset: 0x0094DF4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_SimpleNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C");
			}
			return ABP_SimpleNPC_C._ClassPtr;
		}

		// Token: 0x06020D15 RID: 134421 RVA: 0x0094FD74 File Offset: 0x0094DF74
		public ABP_SimpleNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D16 RID: 134422 RVA: 0x0094FD9C File Offset: 0x0094DF9C
		[NullableContext(1)]
		public ABP_SimpleNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_SimpleNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x06020D17 RID: 134423 RVA: 0x0094FDCF File Offset: 0x0094DFCF
		// (set) Token: 0x06020D18 RID: 134424 RVA: 0x0094FDE3 File Offset: 0x0094DFE3
		[Nullable(2)]
		public unsafe BP_BaseNPC_C 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BaseNPC_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x06020D19 RID: 134425 RVA: 0x0094FDF8 File Offset: 0x0094DFF8
		// (set) Token: 0x06020D1A RID: 134426 RVA: 0x0094FE08 File Offset: 0x0094E008
		public unsafe bool ifPlayIdleAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_ifPlayIdleAction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_ifPlayIdleAction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x06020D1B RID: 134427 RVA: 0x0094FE1C File Offset: 0x0094E01C
		// (set) Token: 0x06020D1C RID: 134428 RVA: 0x0094FE55 File Offset: 0x0094E055
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
					result = (this._IdleMontageArray = new TArray<UAnimMontage>(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IdleMontageArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IdleMontageArray.CopyAssign(value);
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x06020D1D RID: 134429 RVA: 0x0094FE63 File Offset: 0x0094E063
		// (set) Token: 0x06020D1E RID: 134430 RVA: 0x0094FE77 File Offset: 0x0094E077
		[Nullable(2)]
		public unsafe USkeletalMeshComponent 角色Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_角色Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_SimpleNPC_C.__PropertyOffset_角色Mesh, value);
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x06020D1F RID: 134431 RVA: 0x0094FE8C File Offset: 0x0094E08C
		// (set) Token: 0x06020D20 RID: 134432 RVA: 0x0094FEA0 File Offset: 0x0094E0A0
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_SightDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_SightDirect) = value;
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x06020D21 RID: 134433 RVA: 0x0094FEB5 File Offset: 0x0094E0B5
		// (set) Token: 0x06020D22 RID: 134434 RVA: 0x0094FEC5 File Offset: 0x0094E0C5
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsBeingImpacted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsBeingImpacted) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x06020D23 RID: 134435 RVA: 0x0094FED6 File Offset: 0x0094E0D6
		// (set) Token: 0x06020D24 RID: 134436 RVA: 0x0094FEE6 File Offset: 0x0094E0E6
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_SightLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_SightLockMode) = (byte)value;
			}
		}

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x06020D25 RID: 134437 RVA: 0x0094FEF7 File Offset: 0x0094E0F7
		// (set) Token: 0x06020D26 RID: 134438 RVA: 0x0094FF07 File Offset: 0x0094E107
		public unsafe int NpcEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_NpcEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_NpcEntityId) = value;
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x06020D27 RID: 134439 RVA: 0x0094FF18 File Offset: 0x0094E118
		// (set) Token: 0x06020D28 RID: 134440 RVA: 0x0094FF28 File Offset: 0x0094E128
		public unsafe float CollisionDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_CollisionDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_CollisionDirection) = value;
			}
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x06020D29 RID: 134441 RVA: 0x0094FF39 File Offset: 0x0094E139
		// (set) Token: 0x06020D2A RID: 134442 RVA: 0x0094FF49 File Offset: 0x0094E149
		public unsafe float CollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_CollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_CollisionStrength) = value;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x06020D2B RID: 134443 RVA: 0x0094FF5A File Offset: 0x0094E15A
		// (set) Token: 0x06020D2C RID: 134444 RVA: 0x0094FF6A File Offset: 0x0094E16A
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsBeingAttacked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsBeingAttacked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06020D2D RID: 134445 RVA: 0x0094FF7B File Offset: 0x0094E17B
		// (set) Token: 0x06020D2E RID: 134446 RVA: 0x0094FF8B File Offset: 0x0094E18B
		public unsafe float ExpresionAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_ExpresionAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_ExpresionAlpha) = value;
			}
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06020D2F RID: 134447 RVA: 0x0094FF9C File Offset: 0x0094E19C
		// (set) Token: 0x06020D30 RID: 134448 RVA: 0x0094FFAC File Offset: 0x0094E1AC
		public unsafe float RandomEpresionEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_RandomEpresionEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_RandomEpresionEndTime) = value;
			}
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06020D31 RID: 134449 RVA: 0x0094FFBD File Offset: 0x0094E1BD
		// (set) Token: 0x06020D32 RID: 134450 RVA: 0x0094FFCD File Offset: 0x0094E1CD
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06020D33 RID: 134451 RVA: 0x0094FFDE File Offset: 0x0094E1DE
		// (set) Token: 0x06020D34 RID: 134452 RVA: 0x0094FFEE File Offset: 0x0094E1EE
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06020D35 RID: 134453 RVA: 0x0094FFFF File Offset: 0x0094E1FF
		// (set) Token: 0x06020D36 RID: 134454 RVA: 0x0095000F File Offset: 0x0094E20F
		public unsafe bool 眨眼中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_眨眼中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_眨眼中) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06020D37 RID: 134455 RVA: 0x00950020 File Offset: 0x0094E220
		// (set) Token: 0x06020D38 RID: 134456 RVA: 0x00950030 File Offset: 0x0094E230
		public unsafe bool 状态_地区运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_状态_地区运动模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_状态_地区运动模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06020D39 RID: 134457 RVA: 0x00950041 File Offset: 0x0094E241
		// (set) Token: 0x06020D3A RID: 134458 RVA: 0x00950051 File Offset: 0x0094E251
		public unsafe bool EnableTurnMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_EnableTurnMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_EnableTurnMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06020D3B RID: 134459 RVA: 0x00950062 File Offset: 0x0094E262
		// (set) Token: 0x06020D3C RID: 134460 RVA: 0x00950072 File Offset: 0x0094E272
		public unsafe float TurnYawRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_TurnYawRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_TurnYawRate) = value;
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06020D3D RID: 134461 RVA: 0x00950083 File Offset: 0x0094E283
		// (set) Token: 0x06020D3E RID: 134462 RVA: 0x00950093 File Offset: 0x0094E293
		public unsafe bool IsForceUpdateSourceAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_SimpleNPC_C.__PropertyOffset_IsForceUpdateSourceAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020D3F RID: 134463 RVA: 0x009500A4 File Offset: 0x0094E2A4
		[SkipLocalsInit]
		public unsafe virtual void InterfaceJumpPressed(ref float Speed)
		{
			ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceJumpPressed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceJumpPressed_NativeFunctionPtr, (void*)ptr);
			Speed = ptr->Speed;
		}

		// Token: 0x06020D40 RID: 134464 RVA: 0x009500F3 File Offset: 0x0094E2F3
		[SkipLocalsInit]
		public virtual void 更新眨眼()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新眨眼_NativeFunctionPtr, null);
		}

		// Token: 0x06020D41 RID: 134465 RVA: 0x00950107 File Offset: 0x0094E307
		[SkipLocalsInit]
		public virtual void 更新角色碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新角色碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x06020D42 RID: 134466 RVA: 0x0095011B File Offset: 0x0094E31B
		[SkipLocalsInit]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x06020D43 RID: 134467 RVA: 0x0095012F File Offset: 0x0094E32F
		[SkipLocalsInit]
		public virtual void ClimbDash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__ClimbDash_NativeFunctionPtr, null);
		}

		// Token: 0x06020D44 RID: 134468 RVA: 0x00950144 File Offset: 0x0094E344
		[SkipLocalsInit]
		public unsafe virtual void InterfaceSimulateJump(float Speed)
		{
			ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceSimulateJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceSimulateJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D45 RID: 134469 RVA: 0x0095018C File Offset: 0x0094E38C
		[SkipLocalsInit]
		public unsafe virtual void InterfaceFixHookDirect(FVector Offset)
		{
			ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceFixHookDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceFixHookDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D46 RID: 134470 RVA: 0x009501D4 File Offset: 0x0094E3D4
		[SkipLocalsInit]
		public unsafe virtual void InterfaceManipulateInteractDirection(float 角度)
		{
			ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角度 = 角度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceManipulateInteractDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D47 RID: 134471 RVA: 0x0095021C File Offset: 0x0094E41C
		[SkipLocalsInit]
		public unsafe virtual void InterfaceControlPoint(FVector Offset)
		{
			ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_SimpleNPC_C.__InterfaceControlPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__InterfaceControlPoint_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D48 RID: 134472 RVA: 0x00950262 File Offset: 0x0094E462
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x00950276 File Offset: 0x0094E476
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x0095028C File Offset: 0x0094E48C
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D4B RID: 134475 RVA: 0x009502D4 File Offset: 0x0094E4D4
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D4C RID: 134476 RVA: 0x0095031A File Offset: 0x0094E51A
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_SimpleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4D RID: 134477 RVA: 0x0095032E File Offset: 0x0094E52E
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_SimpleNPC_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4E RID: 134478 RVA: 0x00950342 File Offset: 0x0094E542
		protected ABP_SimpleNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C1B RID: 72731
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/ABP_SimpleNPC.ABP_SimpleNPC_C";

		// Token: 0x04011C1C RID: 72732
		private static IntPtr _ClassPtr;

		// Token: 0x04011C1D RID: 72733
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C1E RID: 72734
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011C1F RID: 72735
		internal static int __PropertyOffset_ifPlayIdleAction;

		// Token: 0x04011C20 RID: 72736
		internal static int __PropertyOffset_IdleMontageArray;

		// Token: 0x04011C21 RID: 72737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMontage> _IdleMontageArray;

		// Token: 0x04011C22 RID: 72738
		internal static int __PropertyOffset_角色Mesh;

		// Token: 0x04011C23 RID: 72739
		internal static int __PropertyOffset_SightDirect;

		// Token: 0x04011C24 RID: 72740
		internal static int __PropertyOffset_IsBeingImpacted;

		// Token: 0x04011C25 RID: 72741
		internal static int __PropertyOffset_SightLockMode;

		// Token: 0x04011C26 RID: 72742
		internal static int __PropertyOffset_NpcEntityId;

		// Token: 0x04011C27 RID: 72743
		internal static int __PropertyOffset_CollisionDirection;

		// Token: 0x04011C28 RID: 72744
		internal static int __PropertyOffset_CollisionStrength;

		// Token: 0x04011C29 RID: 72745
		internal static int __PropertyOffset_IsBeingAttacked;

		// Token: 0x04011C2A RID: 72746
		internal static int __PropertyOffset_ExpresionAlpha;

		// Token: 0x04011C2B RID: 72747
		internal static int __PropertyOffset_RandomEpresionEndTime;

		// Token: 0x04011C2C RID: 72748
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011C2D RID: 72749
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011C2E RID: 72750
		internal static int __PropertyOffset_眨眼中;

		// Token: 0x04011C2F RID: 72751
		internal static int __PropertyOffset_状态_地区运动模式;

		// Token: 0x04011C30 RID: 72752
		internal static int __PropertyOffset_EnableTurnMode;

		// Token: 0x04011C31 RID: 72753
		internal static int __PropertyOffset_TurnYawRate;

		// Token: 0x04011C32 RID: 72754
		internal static int __PropertyOffset_IsForceUpdateSourceAnimation;

		// Token: 0x04011C33 RID: 72755
		private static IntPtr __InterfaceJumpPressed_NativeFunctionPtr;

		// Token: 0x04011C34 RID: 72756
		private static IntPtr __更新眨眼_NativeFunctionPtr;

		// Token: 0x04011C35 RID: 72757
		private static IntPtr __更新角色碰撞_NativeFunctionPtr;

		// Token: 0x04011C36 RID: 72758
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04011C37 RID: 72759
		private static IntPtr __ClimbDash_NativeFunctionPtr;

		// Token: 0x04011C38 RID: 72760
		private static IntPtr __InterfaceSimulateJump_NativeFunctionPtr;

		// Token: 0x04011C39 RID: 72761
		private static IntPtr __InterfaceFixHookDirect_NativeFunctionPtr;

		// Token: 0x04011C3A RID: 72762
		private static IntPtr __InterfaceManipulateInteractDirection_NativeFunctionPtr;

		// Token: 0x04011C3B RID: 72763
		private static IntPtr __InterfaceControlPoint_NativeFunctionPtr;

		// Token: 0x04011C3C RID: 72764
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011C3D RID: 72765
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011C3E RID: 72766
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008FCA RID: 36810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceJumpPressed_FunctionParams
		{
			// Token: 0x0402CD71 RID: 183665
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FCB RID: 36811
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceSimulateJump_FunctionParams
		{
			// Token: 0x0402CD72 RID: 183666
			[FieldOffset(0)]
			public float Speed;
		}

		// Token: 0x02008FCC RID: 36812
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceFixHookDirect_FunctionParams
		{
			// Token: 0x0402CD73 RID: 183667
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FCD RID: 36813
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InterfaceManipulateInteractDirection_FunctionParams
		{
			// Token: 0x0402CD74 RID: 183668
			[FieldOffset(0)]
			public float 角度;
		}

		// Token: 0x02008FCE RID: 36814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InterfaceControlPoint_FunctionParams
		{
			// Token: 0x0402CD75 RID: 183669
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x02008FCF RID: 36815
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD76 RID: 183670
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
