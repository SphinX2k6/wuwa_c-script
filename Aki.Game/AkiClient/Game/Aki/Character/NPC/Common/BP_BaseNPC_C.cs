using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x020032BC RID: 12988
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_BaseNPC_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D93 RID: 134547 RVA: 0x009509FB File Offset: 0x0094EBFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C");
			}
			return BP_BaseNPC_C._ClassPtr;
		}

		// Token: 0x06020D94 RID: 134548 RVA: 0x00950A20 File Offset: 0x0094EC20
		public BP_BaseNPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D95 RID: 134549 RVA: 0x00950A48 File Offset: 0x0094EC48
		[NullableContext(1)]
		public BP_BaseNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06020D96 RID: 134550 RVA: 0x00950A7B File Offset: 0x0094EC7B
		// (set) Token: 0x06020D97 RID: 134551 RVA: 0x00950A8F File Offset: 0x0094EC8F
		[Nullable(2)]
		public unsafe UBoxComponent HitCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_HitCollision);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_HitCollision, value);
			}
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06020D98 RID: 134552 RVA: 0x00950AA4 File Offset: 0x0094ECA4
		// (set) Token: 0x06020D99 RID: 134553 RVA: 0x00950AB8 File Offset: 0x0094ECB8
		[Nullable(2)]
		public unsafe UNavigationInvokerComponent NavigationInvoker_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationInvokerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_NavigationInvoker_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_NavigationInvoker_0, value);
			}
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06020D9A RID: 134554 RVA: 0x00950ACD File Offset: 0x0094ECCD
		// (set) Token: 0x06020D9B RID: 134555 RVA: 0x00950ADD File Offset: 0x0094ECDD
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsBeingImpacted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsBeingImpacted) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06020D9C RID: 134556 RVA: 0x00950AEE File Offset: 0x0094ECEE
		// (set) Token: 0x06020D9D RID: 134557 RVA: 0x00950AFE File Offset: 0x0094ECFE
		public unsafe float Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06020D9E RID: 134558 RVA: 0x00950B0F File Offset: 0x0094ED0F
		// (set) Token: 0x06020D9F RID: 134559 RVA: 0x00950B1F File Offset: 0x0094ED1F
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x06020DA0 RID: 134560 RVA: 0x00950B30 File Offset: 0x0094ED30
		// (set) Token: 0x06020DA1 RID: 134561 RVA: 0x00950B40 File Offset: 0x0094ED40
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsBeingAttacked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsBeingAttacked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x06020DA2 RID: 134562 RVA: 0x00950B51 File Offset: 0x0094ED51
		// (set) Token: 0x06020DA3 RID: 134563 RVA: 0x00950B61 File Offset: 0x0094ED61
		public unsafe bool CanPlayerImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanPlayerImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanPlayerImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x06020DA4 RID: 134564 RVA: 0x00950B72 File Offset: 0x0094ED72
		// (set) Token: 0x06020DA5 RID: 134565 RVA: 0x00950B82 File Offset: 0x0094ED82
		public unsafe bool CanPlayerAttack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanPlayerAttack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanPlayerAttack) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x06020DA6 RID: 134566 RVA: 0x00950B93 File Offset: 0x0094ED93
		// (set) Token: 0x06020DA7 RID: 134567 RVA: 0x00950BA3 File Offset: 0x0094EDA3
		public unsafe bool CanLookAtPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanLookAtPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanLookAtPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x06020DA8 RID: 134568 RVA: 0x00950BB4 File Offset: 0x0094EDB4
		// (set) Token: 0x06020DA9 RID: 134569 RVA: 0x00950BED File Offset: 0x0094EDED
		[Nullable(1)]
		public FSoftObjectPath BornEffect
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._BornEffect) == null)
				{
					result = (this._BornEffect = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_BornEffect, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_BornEffect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x06020DAA RID: 134570 RVA: 0x00950C0E File Offset: 0x0094EE0E
		// (set) Token: 0x06020DAB RID: 134571 RVA: 0x00950C22 File Offset: 0x0094EE22
		[Nullable(2)]
		public unsafe USkeletalMeshComponent CombineFaceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_CombineFaceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_CombineFaceMesh, value);
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x06020DAC RID: 134572 RVA: 0x00950C37 File Offset: 0x0094EE37
		// (set) Token: 0x06020DAD RID: 134573 RVA: 0x00950C47 File Offset: 0x0094EE47
		public unsafe bool CanUpdateTextureFace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanUpdateTextureFace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_CanUpdateTextureFace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x06020DAE RID: 134574 RVA: 0x00950C58 File Offset: 0x0094EE58
		// (set) Token: 0x06020DAF RID: 134575 RVA: 0x00950C68 File Offset: 0x0094EE68
		public unsafe bool IsEnableIK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsEnableIK) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_IsEnableIK) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020DB0 RID: 134576 RVA: 0x00950C7C File Offset: 0x0094EE7C
		[SkipLocalsInit]
		public unsafe virtual void 检查是否玩家攻击(ref bool IsAttack)
		{
			BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__检查是否玩家攻击_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsAttack = IsAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__检查是否玩家攻击_NativeFunctionPtr, (void*)ptr);
			IsAttack = ptr->IsAttack;
		}

		// Token: 0x06020DB1 RID: 134577 RVA: 0x00950CCC File Offset: 0x0094EECC
		[SkipLocalsInit]
		public unsafe virtual void 通知AIC攻击结果(bool IsAttack)
		{
			BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__通知AIC攻击结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsAttack = IsAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__通知AIC攻击结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB2 RID: 134578 RVA: 0x00950D14 File Offset: 0x0094EF14
		[SkipLocalsInit]
		public unsafe virtual void 执行攻击处理(ref bool Success)
		{
			BP_BaseNPC_C.__执行攻击处理_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__执行攻击处理_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseNPC_C.__执行攻击处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__执行攻击处理_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Success = Success;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__执行攻击处理_NativeFunctionPtr, (void*)ptr);
			Success = ptr->Success;
		}

		// Token: 0x06020DB3 RID: 134579 RVA: 0x00950D64 File Offset: 0x0094EF64
		[SkipLocalsInit]
		public unsafe virtual void 执行冲撞处理(ref bool Success)
		{
			BP_BaseNPC_C.__执行冲撞处理_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__执行冲撞处理_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_BaseNPC_C.__执行冲撞处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__执行冲撞处理_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Success = Success;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__执行冲撞处理_NativeFunctionPtr, (void*)ptr);
			Success = ptr->Success;
		}

		// Token: 0x06020DB4 RID: 134580 RVA: 0x00950DB8 File Offset: 0x0094EFB8
		[SkipLocalsInit]
		public unsafe virtual void 通知AIC冲撞结果(bool IsImpact)
		{
			BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__通知AIC冲撞结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsImpact = IsImpact;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__通知AIC冲撞结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB5 RID: 134581 RVA: 0x00950E00 File Offset: 0x0094F000
		[SkipLocalsInit]
		public unsafe virtual void 设置硬直(bool Value)
		{
			BP_BaseNPC_C.__设置硬直_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__设置硬直_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_BaseNPC_C.__设置硬直_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__设置硬直_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__设置硬直_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB6 RID: 134582 RVA: 0x00950E46 File Offset: 0x0094F046
		[SkipLocalsInit]
		public virtual void initAI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__initAI_NativeFunctionPtr, null);
		}

		// Token: 0x06020DB7 RID: 134583 RVA: 0x00950E5C File Offset: 0x0094F05C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB8 RID: 134584 RVA: 0x00950EA4 File Offset: 0x0094F0A4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DB9 RID: 134585 RVA: 0x00950EEA File Offset: 0x0094F0EA
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020DBA RID: 134586 RVA: 0x00950EFE File Offset: 0x0094F0FE
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020DBB RID: 134587 RVA: 0x00950F14 File Offset: 0x0094F114
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DBC RID: 134588 RVA: 0x00950FA0 File Offset: 0x0094F1A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DBD RID: 134589 RVA: 0x0095105A File Offset: 0x0094F25A
		protected BP_BaseNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C64 RID: 72804
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C";

		// Token: 0x04011C65 RID: 72805
		private static IntPtr _ClassPtr;

		// Token: 0x04011C66 RID: 72806
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C67 RID: 72807
		internal static int __PropertyOffset_HitCollision;

		// Token: 0x04011C68 RID: 72808
		internal static int __PropertyOffset_NavigationInvoker_0;

		// Token: 0x04011C69 RID: 72809
		internal static int __PropertyOffset_IsBeingImpacted;

		// Token: 0x04011C6A RID: 72810
		internal static int __PropertyOffset_Direction;

		// Token: 0x04011C6B RID: 72811
		internal static int __PropertyOffset_Strength;

		// Token: 0x04011C6C RID: 72812
		internal static int __PropertyOffset_IsBeingAttacked;

		// Token: 0x04011C6D RID: 72813
		internal static int __PropertyOffset_CanPlayerImpact;

		// Token: 0x04011C6E RID: 72814
		internal static int __PropertyOffset_CanPlayerAttack;

		// Token: 0x04011C6F RID: 72815
		internal static int __PropertyOffset_CanLookAtPlayer;

		// Token: 0x04011C70 RID: 72816
		internal static int __PropertyOffset_BornEffect;

		// Token: 0x04011C71 RID: 72817
		[Nullable(2)]
		private FSoftObjectPath _BornEffect;

		// Token: 0x04011C72 RID: 72818
		internal static int __PropertyOffset_CombineFaceMesh;

		// Token: 0x04011C73 RID: 72819
		internal static int __PropertyOffset_CanUpdateTextureFace;

		// Token: 0x04011C74 RID: 72820
		internal static int __PropertyOffset_IsEnableIK;

		// Token: 0x04011C75 RID: 72821
		private static IntPtr __检查是否玩家攻击_NativeFunctionPtr;

		// Token: 0x04011C76 RID: 72822
		private static IntPtr __通知AIC攻击结果_NativeFunctionPtr;

		// Token: 0x04011C77 RID: 72823
		private static IntPtr __执行攻击处理_NativeFunctionPtr;

		// Token: 0x04011C78 RID: 72824
		private static IntPtr __执行冲撞处理_NativeFunctionPtr;

		// Token: 0x04011C79 RID: 72825
		private static IntPtr __通知AIC冲撞结果_NativeFunctionPtr;

		// Token: 0x04011C7A RID: 72826
		private static IntPtr __设置硬直_NativeFunctionPtr;

		// Token: 0x04011C7B RID: 72827
		private static IntPtr __initAI_NativeFunctionPtr;

		// Token: 0x04011C7C RID: 72828
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011C7D RID: 72829
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011C7E RID: 72830
		private static IntPtr __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011C7F RID: 72831
		private static IntPtr __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02008FD6 RID: 36822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __检查是否玩家攻击_FunctionParams
		{
			// Token: 0x0402CD7D RID: 183677
			[FieldOffset(0)]
			public bool IsAttack;
		}

		// Token: 0x02008FD7 RID: 36823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __通知AIC攻击结果_FunctionParams
		{
			// Token: 0x0402CD7E RID: 183678
			[FieldOffset(0)]
			public bool IsAttack;
		}

		// Token: 0x02008FD8 RID: 36824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __执行攻击处理_FunctionParams
		{
			// Token: 0x0402CD7F RID: 183679
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x02008FD9 RID: 36825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __执行冲撞处理_FunctionParams
		{
			// Token: 0x0402CD80 RID: 183680
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x02008FDA RID: 36826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __通知AIC冲撞结果_FunctionParams
		{
			// Token: 0x0402CD81 RID: 183681
			[FieldOffset(0)]
			public bool IsImpact;
		}

		// Token: 0x02008FDB RID: 36827
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __设置硬直_FunctionParams
		{
			// Token: 0x0402CD82 RID: 183682
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x02008FDC RID: 36828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CD83 RID: 183683
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008FDD RID: 36829
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CD84 RID: 183684
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CD85 RID: 183685
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CD86 RID: 183686
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CD87 RID: 183687
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02008FDE RID: 36830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CD88 RID: 183688
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CD89 RID: 183689
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CD8A RID: 183690
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CD8B RID: 183691
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0402CD8C RID: 183692
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0402CD8D RID: 183693
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
