using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004116 RID: 16662
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C")]
	[UnrealStructLayout(8096, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8089)]
	public class ABP_BaseRole_Gameplay_Motor_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE40 RID: 175680 RVA: 0x009EEC5D File Offset: 0x009ECE5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Motor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C");
			}
			return ABP_BaseRole_Gameplay_Motor_C._ClassPtr;
		}

		// Token: 0x0602AE41 RID: 175681 RVA: 0x009EEC84 File Offset: 0x009ECE84
		public ABP_BaseRole_Gameplay_Motor_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Motor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE42 RID: 175682 RVA: 0x009EECAC File Offset: 0x009ECEAC
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Motor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Motor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700698F RID: 27023
		// (get) Token: 0x0602AE43 RID: 175683 RVA: 0x009EECDF File Offset: 0x009ECEDF
		// (set) Token: 0x0602AE44 RID: 175684 RVA: 0x009EECEF File Offset: 0x009ECEEF
		public unsafe int VehicleEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006990 RID: 27024
		// (get) Token: 0x0602AE45 RID: 175685 RVA: 0x009EED00 File Offset: 0x009ECF00
		// (set) Token: 0x0602AE46 RID: 175686 RVA: 0x009EED39 File Offset: 0x009ECF39
		[Nullable(1)]
		public TArray<float> 撞击混合
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._撞击混合) == null)
				{
					result = (this._撞击混合 = new TArray<float>(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.撞击混合.CopyAssign(value);
			}
		}

		// Token: 0x17006991 RID: 27025
		// (get) Token: 0x0602AE47 RID: 175687 RVA: 0x009EED47 File Offset: 0x009ECF47
		// (set) Token: 0x0602AE48 RID: 175688 RVA: 0x009EED57 File Offset: 0x009ECF57
		public unsafe float 撞击倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006992 RID: 27026
		// (get) Token: 0x0602AE49 RID: 175689 RVA: 0x009EED68 File Offset: 0x009ECF68
		// (set) Token: 0x0602AE4A RID: 175690 RVA: 0x009EED7C File Offset: 0x009ECF7C
		[Nullable(2)]
		public unsafe AActor Vehicle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17006993 RID: 27027
		// (get) Token: 0x0602AE4B RID: 175691 RVA: 0x009EED91 File Offset: 0x009ECF91
		// (set) Token: 0x0602AE4C RID: 175692 RVA: 0x009EEDA5 File Offset: 0x009ECFA5
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17006994 RID: 27028
		// (get) Token: 0x0602AE4D RID: 175693 RVA: 0x009EEDBA File Offset: 0x009ECFBA
		// (set) Token: 0x0602AE4E RID: 175694 RVA: 0x009EEDCA File Offset: 0x009ECFCA
		public unsafe bool 禁用碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AE4F RID: 175695 RVA: 0x009EEDDC File Offset: 0x009ECFDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Motor_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AE50 RID: 175696 RVA: 0x009EEE64 File Offset: 0x009ED064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 去掉HitNormal的Down(FVector HitNormal, ref FVector Result)
		{
			ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitNormal = HitNormal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0602AE51 RID: 175697 RVA: 0x009EEEC4 File Offset: 0x009ED0C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 计算碰撞反馈(float DeltaTime)
		{
			ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE52 RID: 175698 RVA: 0x009EEF10 File Offset: 0x009ED110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVehicle(int entityId)
		{
			ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->entityId = entityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE53 RID: 175699 RVA: 0x009EEF58 File Offset: 0x009ED158
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE54 RID: 175700 RVA: 0x009EEFA0 File Offset: 0x009ED1A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AE55 RID: 175701 RVA: 0x009EEFE7 File Offset: 0x009ED1E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE56 RID: 175702 RVA: 0x009EEFFB File Offset: 0x009ED1FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AE57 RID: 175703 RVA: 0x009EF010 File Offset: 0x009ED210
		protected ABP_BaseRole_Gameplay_Motor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163AE RID: 91054
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C";

		// Token: 0x040163AF RID: 91055
		private static IntPtr _ClassPtr;

		// Token: 0x040163B0 RID: 91056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163B1 RID: 91057
		internal static int __PropertyOffset_12;

		// Token: 0x040163B2 RID: 91058
		internal static int __PropertyOffset_13;

		// Token: 0x040163B3 RID: 91059
		[Nullable(2)]
		private TArray<float> _撞击混合;

		// Token: 0x040163B4 RID: 91060
		internal static int __PropertyOffset_14;

		// Token: 0x040163B5 RID: 91061
		internal static int __PropertyOffset_15;

		// Token: 0x040163B6 RID: 91062
		internal static int __PropertyOffset_16;

		// Token: 0x040163B7 RID: 91063
		internal static int __PropertyOffset_17;

		// Token: 0x040163B8 RID: 91064
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163B9 RID: 91065
		private static IntPtr __去掉HitNormal的Down_NativeFunctionPtr;

		// Token: 0x040163BA RID: 91066
		private static IntPtr __计算碰撞反馈_NativeFunctionPtr;

		// Token: 0x040163BB RID: 91067
		private static IntPtr __SetVehicle_NativeFunctionPtr;

		// Token: 0x040163BC RID: 91068
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040163BD RID: 91069
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A420 RID: 42016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032259 RID: 205401
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A421 RID: 42017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __去掉HitNormal的Down_FunctionParams
		{
			// Token: 0x0403225A RID: 205402
			[FieldOffset(0)]
			public FVector HitNormal;

			// Token: 0x0403225B RID: 205403
			[FieldOffset(12)]
			public FVector Result;
		}

		// Token: 0x0200A422 RID: 42018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __计算碰撞反馈_FunctionParams
		{
			// Token: 0x0403225C RID: 205404
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A423 RID: 42019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetVehicle_FunctionParams
		{
			// Token: 0x0403225D RID: 205405
			[FieldOffset(0)]
			public int entityId;
		}

		// Token: 0x0200A424 RID: 42020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403225E RID: 205406
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
