using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x0200419F RID: 16799
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C")]
	[UnrealStructLayout(2336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2330)]
	public class BP_BaseNPC_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BAE2 RID: 178914 RVA: 0x00A07331 File Offset: 0x00A05531
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C");
			}
			return BP_BaseNPC_C._ClassPtr;
		}

		// Token: 0x0602BAE3 RID: 178915 RVA: 0x00A07358 File Offset: 0x00A05558
		public BP_BaseNPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BAE4 RID: 178916 RVA: 0x00A07380 File Offset: 0x00A05580
		[NullableContext(1)]
		public BP_BaseNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C7D RID: 27773
		// (get) Token: 0x0602BAE5 RID: 178917 RVA: 0x00A073B3 File Offset: 0x00A055B3
		// (set) Token: 0x0602BAE6 RID: 178918 RVA: 0x00A073C7 File Offset: 0x00A055C7
		[Nullable(2)]
		public unsafe UBoxComponent HitCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006C7E RID: 27774
		// (get) Token: 0x0602BAE7 RID: 178919 RVA: 0x00A073DC File Offset: 0x00A055DC
		// (set) Token: 0x0602BAE8 RID: 178920 RVA: 0x00A073F0 File Offset: 0x00A055F0
		[Nullable(2)]
		public unsafe UNavigationInvokerComponent NavigationInvoker_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationInvokerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006C7F RID: 27775
		// (get) Token: 0x0602BAE9 RID: 178921 RVA: 0x00A07405 File Offset: 0x00A05605
		// (set) Token: 0x0602BAEA RID: 178922 RVA: 0x00A07415 File Offset: 0x00A05615
		public unsafe bool IsBeingImpacted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C80 RID: 27776
		// (get) Token: 0x0602BAEB RID: 178923 RVA: 0x00A07426 File Offset: 0x00A05626
		// (set) Token: 0x0602BAEC RID: 178924 RVA: 0x00A07436 File Offset: 0x00A05636
		public unsafe float Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006C81 RID: 27777
		// (get) Token: 0x0602BAED RID: 178925 RVA: 0x00A07447 File Offset: 0x00A05647
		// (set) Token: 0x0602BAEE RID: 178926 RVA: 0x00A07457 File Offset: 0x00A05657
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006C82 RID: 27778
		// (get) Token: 0x0602BAEF RID: 178927 RVA: 0x00A07468 File Offset: 0x00A05668
		// (set) Token: 0x0602BAF0 RID: 178928 RVA: 0x00A07478 File Offset: 0x00A05678
		public unsafe bool IsBeingAttacked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C83 RID: 27779
		// (get) Token: 0x0602BAF1 RID: 178929 RVA: 0x00A07489 File Offset: 0x00A05689
		// (set) Token: 0x0602BAF2 RID: 178930 RVA: 0x00A07499 File Offset: 0x00A05699
		public unsafe bool CanPlayerImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C84 RID: 27780
		// (get) Token: 0x0602BAF3 RID: 178931 RVA: 0x00A074AA File Offset: 0x00A056AA
		// (set) Token: 0x0602BAF4 RID: 178932 RVA: 0x00A074BA File Offset: 0x00A056BA
		public unsafe bool CanPlayerAttack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C85 RID: 27781
		// (get) Token: 0x0602BAF5 RID: 178933 RVA: 0x00A074CB File Offset: 0x00A056CB
		// (set) Token: 0x0602BAF6 RID: 178934 RVA: 0x00A074DB File Offset: 0x00A056DB
		public unsafe bool CanLookAtPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C86 RID: 27782
		// (get) Token: 0x0602BAF7 RID: 178935 RVA: 0x00A074EC File Offset: 0x00A056EC
		// (set) Token: 0x0602BAF8 RID: 178936 RVA: 0x00A07525 File Offset: 0x00A05725
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
					result = (this._BornEffect = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C87 RID: 27783
		// (get) Token: 0x0602BAF9 RID: 178937 RVA: 0x00A07546 File Offset: 0x00A05746
		// (set) Token: 0x0602BAFA RID: 178938 RVA: 0x00A0755A File Offset: 0x00A0575A
		[Nullable(2)]
		public unsafe USkeletalMeshComponent CombineFaceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseNPC_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006C88 RID: 27784
		// (get) Token: 0x0602BAFB RID: 178939 RVA: 0x00A0756F File Offset: 0x00A0576F
		// (set) Token: 0x0602BAFC RID: 178940 RVA: 0x00A0757F File Offset: 0x00A0577F
		public unsafe bool CanUpdateTextureFace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C89 RID: 27785
		// (get) Token: 0x0602BAFD RID: 178941 RVA: 0x00A07590 File Offset: 0x00A05790
		// (set) Token: 0x0602BAFE RID: 178942 RVA: 0x00A075A0 File Offset: 0x00A057A0
		public unsafe bool IsEnableIK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseNPC_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BAFF RID: 178943 RVA: 0x00A075B4 File Offset: 0x00A057B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 检查是否玩家攻击(ref bool IsAttack)
		{
			BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BaseNPC_C.__检查是否玩家攻击_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__检查是否玩家攻击_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsAttack = IsAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__检查是否玩家攻击_NativeFunctionPtr, (void*)ptr);
			IsAttack = ptr->IsAttack;
		}

		// Token: 0x0602BB00 RID: 178944 RVA: 0x00A07604 File Offset: 0x00A05804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通知AIC攻击结果(bool IsAttack)
		{
			BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_BaseNPC_C.__通知AIC攻击结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__通知AIC攻击结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsAttack = IsAttack;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__通知AIC攻击结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB01 RID: 178945 RVA: 0x00A0764C File Offset: 0x00A0584C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 执行攻击处理(ref bool Success)
		{
			BP_BaseNPC_C.__执行攻击处理_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__执行攻击处理_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BaseNPC_C.__执行攻击处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__执行攻击处理_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Success = Success;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__执行攻击处理_NativeFunctionPtr, (void*)ptr);
			Success = ptr->Success;
		}

		// Token: 0x0602BB02 RID: 178946 RVA: 0x00A0769C File Offset: 0x00A0589C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 执行冲撞处理(ref bool Success)
		{
			BP_BaseNPC_C.__执行冲撞处理_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__执行冲撞处理_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_BaseNPC_C.__执行冲撞处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__执行冲撞处理_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Success = Success;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__执行冲撞处理_NativeFunctionPtr, (void*)ptr);
			Success = ptr->Success;
		}

		// Token: 0x0602BB03 RID: 178947 RVA: 0x00A076F0 File Offset: 0x00A058F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通知AIC冲撞结果(bool IsImpact)
		{
			BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_BaseNPC_C.__通知AIC冲撞结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__通知AIC冲撞结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsImpact = IsImpact;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__通知AIC冲撞结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB04 RID: 178948 RVA: 0x00A07738 File Offset: 0x00A05938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置硬直(bool Value)
		{
			BP_BaseNPC_C.__设置硬直_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__设置硬直_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_BaseNPC_C.__设置硬直_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__设置硬直_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__设置硬直_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB05 RID: 178949 RVA: 0x00A0777E File Offset: 0x00A0597E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initAI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__initAI_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB06 RID: 178950 RVA: 0x00A07794 File Offset: 0x00A05994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB07 RID: 178951 RVA: 0x00A077DC File Offset: 0x00A059DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseNPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseNPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseNPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BB08 RID: 178952 RVA: 0x00A07823 File Offset: 0x00A05A23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB09 RID: 178953 RVA: 0x00A07837 File Offset: 0x00A05A37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BB0A RID: 178954 RVA: 0x00A0784C File Offset: 0x00A05A4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602BB0B RID: 178955 RVA: 0x00A078D8 File Offset: 0x00A05AD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602BB0C RID: 178956 RVA: 0x00A07992 File Offset: 0x00A05B92
		protected BP_BaseNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016BFF RID: 93183
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/BP_BaseNPC.BP_BaseNPC_C";

		// Token: 0x04016C00 RID: 93184
		private static IntPtr _ClassPtr;

		// Token: 0x04016C01 RID: 93185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016C02 RID: 93186
		internal static int __PropertyOffset_1;

		// Token: 0x04016C03 RID: 93187
		internal static int __PropertyOffset_2;

		// Token: 0x04016C04 RID: 93188
		internal static int __PropertyOffset_3;

		// Token: 0x04016C05 RID: 93189
		internal static int __PropertyOffset_4;

		// Token: 0x04016C06 RID: 93190
		internal static int __PropertyOffset_5;

		// Token: 0x04016C07 RID: 93191
		internal static int __PropertyOffset_6;

		// Token: 0x04016C08 RID: 93192
		internal static int __PropertyOffset_7;

		// Token: 0x04016C09 RID: 93193
		internal static int __PropertyOffset_8;

		// Token: 0x04016C0A RID: 93194
		internal static int __PropertyOffset_9;

		// Token: 0x04016C0B RID: 93195
		internal static int __PropertyOffset_10;

		// Token: 0x04016C0C RID: 93196
		[Nullable(2)]
		private FSoftObjectPath _BornEffect;

		// Token: 0x04016C0D RID: 93197
		internal static int __PropertyOffset_11;

		// Token: 0x04016C0E RID: 93198
		internal static int __PropertyOffset_12;

		// Token: 0x04016C0F RID: 93199
		internal static int __PropertyOffset_13;

		// Token: 0x04016C10 RID: 93200
		private static IntPtr __检查是否玩家攻击_NativeFunctionPtr;

		// Token: 0x04016C11 RID: 93201
		private static IntPtr __通知AIC攻击结果_NativeFunctionPtr;

		// Token: 0x04016C12 RID: 93202
		private static IntPtr __执行攻击处理_NativeFunctionPtr;

		// Token: 0x04016C13 RID: 93203
		private static IntPtr __执行冲撞处理_NativeFunctionPtr;

		// Token: 0x04016C14 RID: 93204
		private static IntPtr __通知AIC冲撞结果_NativeFunctionPtr;

		// Token: 0x04016C15 RID: 93205
		private static IntPtr __设置硬直_NativeFunctionPtr;

		// Token: 0x04016C16 RID: 93206
		private static IntPtr __initAI_NativeFunctionPtr;

		// Token: 0x04016C17 RID: 93207
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04016C18 RID: 93208
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04016C19 RID: 93209
		private static IntPtr __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04016C1A RID: 93210
		private static IntPtr __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A577 RID: 42359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __检查是否玩家攻击_FunctionParams
		{
			// Token: 0x040323F7 RID: 205815
			[FieldOffset(0)]
			public bool IsAttack;
		}

		// Token: 0x0200A578 RID: 42360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __通知AIC攻击结果_FunctionParams
		{
			// Token: 0x040323F8 RID: 205816
			[FieldOffset(0)]
			public bool IsAttack;
		}

		// Token: 0x0200A579 RID: 42361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __执行攻击处理_FunctionParams
		{
			// Token: 0x040323F9 RID: 205817
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x0200A57A RID: 42362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __执行冲撞处理_FunctionParams
		{
			// Token: 0x040323FA RID: 205818
			[FieldOffset(0)]
			public bool Success;
		}

		// Token: 0x0200A57B RID: 42363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __通知AIC冲撞结果_FunctionParams
		{
			// Token: 0x040323FB RID: 205819
			[FieldOffset(0)]
			public bool IsImpact;
		}

		// Token: 0x0200A57C RID: 42364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __设置硬直_FunctionParams
		{
			// Token: 0x040323FC RID: 205820
			[FieldOffset(0)]
			public bool Value;
		}

		// Token: 0x0200A57D RID: 42365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040323FD RID: 205821
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A57E RID: 42366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040323FE RID: 205822
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040323FF RID: 205823
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04032400 RID: 205824
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04032401 RID: 205825
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x0200A57F RID: 42367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BaseNPC_HitCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04032402 RID: 205826
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04032403 RID: 205827
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04032404 RID: 205828
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04032405 RID: 205829
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04032406 RID: 205830
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04032407 RID: 205831
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
