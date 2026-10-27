using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004115 RID: 16661
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Ecology.ABP_BaseRole_Gameplay_Ecology_C")]
	[UnrealStructLayout(4704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4696)]
	public class ABP_BaseRole_Gameplay_Ecology_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE2F RID: 175663 RVA: 0x009EEA05 File Offset: 0x009ECC05
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Ecology_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Ecology.ABP_BaseRole_Gameplay_Ecology_C");
			}
			return ABP_BaseRole_Gameplay_Ecology_C._ClassPtr;
		}

		// Token: 0x0602AE30 RID: 175664 RVA: 0x009EEA2C File Offset: 0x009ECC2C
		public ABP_BaseRole_Gameplay_Ecology_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Ecology_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE31 RID: 175665 RVA: 0x009EEA54 File Offset: 0x009ECC54
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Ecology_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Ecology_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700698B RID: 27019
		// (get) Token: 0x0602AE32 RID: 175666 RVA: 0x009EEA87 File Offset: 0x009ECC87
		// (set) Token: 0x0602AE33 RID: 175667 RVA: 0x009EEA9B File Offset: 0x009ECC9B
		[Nullable(2)]
		public unsafe TsBaseCharacter As_Ts_Base_Character
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700698C RID: 27020
		// (get) Token: 0x0602AE34 RID: 175668 RVA: 0x009EEAB0 File Offset: 0x009ECCB0
		// (set) Token: 0x0602AE35 RID: 175669 RVA: 0x009EEAC0 File Offset: 0x009ECCC0
		public unsafe bool 状态_花车
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700698D RID: 27021
		// (get) Token: 0x0602AE36 RID: 175670 RVA: 0x009EEAD1 File Offset: 0x009ECCD1
		// (set) Token: 0x0602AE37 RID: 175671 RVA: 0x009EEAE1 File Offset: 0x009ECCE1
		public unsafe bool 状态_花车舞蹈
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700698E RID: 27022
		// (get) Token: 0x0602AE38 RID: 175672 RVA: 0x009EEAF2 File Offset: 0x009ECCF2
		// (set) Token: 0x0602AE39 RID: 175673 RVA: 0x009EEB02 File Offset: 0x009ECD02
		public unsafe int Entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Ecology_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x0602AE3A RID: 175674 RVA: 0x009EEB14 File Offset: 0x009ECD14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Ecology_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Ecology_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Ecology_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Ecology_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Ecology_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AE3B RID: 175675 RVA: 0x009EEB9C File Offset: 0x009ECD9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE3C RID: 175676 RVA: 0x009EEBE4 File Offset: 0x009ECDE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AE3D RID: 175677 RVA: 0x009EEC2B File Offset: 0x009ECE2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Ecology_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE3E RID: 175678 RVA: 0x009EEC3F File Offset: 0x009ECE3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Ecology_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AE3F RID: 175679 RVA: 0x009EEC54 File Offset: 0x009ECE54
		protected ABP_BaseRole_Gameplay_Ecology_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163A4 RID: 91044
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Ecology.ABP_BaseRole_Gameplay_Ecology_C";

		// Token: 0x040163A5 RID: 91045
		private static IntPtr _ClassPtr;

		// Token: 0x040163A6 RID: 91046
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163A7 RID: 91047
		internal static int __PropertyOffset_15;

		// Token: 0x040163A8 RID: 91048
		internal static int __PropertyOffset_16;

		// Token: 0x040163A9 RID: 91049
		internal static int __PropertyOffset_17;

		// Token: 0x040163AA RID: 91050
		internal static int __PropertyOffset_18;

		// Token: 0x040163AB RID: 91051
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163AC RID: 91052
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040163AD RID: 91053
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A41E RID: 42014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032257 RID: 205399
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A41F RID: 42015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032258 RID: 205400
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
