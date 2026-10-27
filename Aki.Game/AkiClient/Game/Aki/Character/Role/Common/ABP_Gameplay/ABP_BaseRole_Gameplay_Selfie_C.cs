using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004118 RID: 16664
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C")]
	[UnrealStructLayout(7312, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7304)]
	public class ABP_BaseRole_Gameplay_Selfie_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE78 RID: 175736 RVA: 0x009EF458 File Offset: 0x009ED658
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Selfie_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C");
			}
			return ABP_BaseRole_Gameplay_Selfie_C._ClassPtr;
		}

		// Token: 0x0602AE79 RID: 175737 RVA: 0x009EF47C File Offset: 0x009ED67C
		public ABP_BaseRole_Gameplay_Selfie_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Selfie_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE7A RID: 175738 RVA: 0x009EF4A4 File Offset: 0x009ED6A4
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Selfie_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Selfie_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700699E RID: 27038
		// (get) Token: 0x0602AE7B RID: 175739 RVA: 0x009EF4D7 File Offset: 0x009ED6D7
		// (set) Token: 0x0602AE7C RID: 175740 RVA: 0x009EF4EB File Offset: 0x009ED6EB
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x1700699F RID: 27039
		// (get) Token: 0x0602AE7D RID: 175741 RVA: 0x009EF500 File Offset: 0x009ED700
		// (set) Token: 0x0602AE7E RID: 175742 RVA: 0x009EF510 File Offset: 0x009ED710
		public unsafe float ArmPitchAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170069A0 RID: 27040
		// (get) Token: 0x0602AE7F RID: 175743 RVA: 0x009EF521 File Offset: 0x009ED721
		// (set) Token: 0x0602AE80 RID: 175744 RVA: 0x009EF531 File Offset: 0x009ED731
		public unsafe float ArmPitchLimitMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170069A1 RID: 27041
		// (get) Token: 0x0602AE81 RID: 175745 RVA: 0x009EF542 File Offset: 0x009ED742
		// (set) Token: 0x0602AE82 RID: 175746 RVA: 0x009EF552 File Offset: 0x009ED752
		public unsafe float ArmPitchLimitMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170069A2 RID: 27042
		// (get) Token: 0x0602AE83 RID: 175747 RVA: 0x009EF563 File Offset: 0x009ED763
		// (set) Token: 0x0602AE84 RID: 175748 RVA: 0x009EF573 File Offset: 0x009ED773
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170069A3 RID: 27043
		// (get) Token: 0x0602AE85 RID: 175749 RVA: 0x009EF584 File Offset: 0x009ED784
		// (set) Token: 0x0602AE86 RID: 175750 RVA: 0x009EF598 File Offset: 0x009ED798
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170069A4 RID: 27044
		// (get) Token: 0x0602AE87 RID: 175751 RVA: 0x009EF5AD File Offset: 0x009ED7AD
		// (set) Token: 0x0602AE88 RID: 175752 RVA: 0x009EF5BD File Offset: 0x009ED7BD
		public unsafe float MoveX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170069A5 RID: 27045
		// (get) Token: 0x0602AE89 RID: 175753 RVA: 0x009EF5CE File Offset: 0x009ED7CE
		// (set) Token: 0x0602AE8A RID: 175754 RVA: 0x009EF5DE File Offset: 0x009ED7DE
		public unsafe float MoveY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170069A6 RID: 27046
		// (get) Token: 0x0602AE8B RID: 175755 RVA: 0x009EF5EF File Offset: 0x009ED7EF
		// (set) Token: 0x0602AE8C RID: 175756 RVA: 0x009EF5FF File Offset: 0x009ED7FF
		public unsafe float BreathStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170069A7 RID: 27047
		// (get) Token: 0x0602AE8D RID: 175757 RVA: 0x009EF610 File Offset: 0x009ED810
		// (set) Token: 0x0602AE8E RID: 175758 RVA: 0x009EF620 File Offset: 0x009ED820
		public unsafe float PerformStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170069A8 RID: 27048
		// (get) Token: 0x0602AE8F RID: 175759 RVA: 0x009EF631 File Offset: 0x009ED831
		// (set) Token: 0x0602AE90 RID: 175760 RVA: 0x009EF645 File Offset: 0x009ED845
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170069A9 RID: 27049
		// (get) Token: 0x0602AE91 RID: 175761 RVA: 0x009EF65A File Offset: 0x009ED85A
		// (set) Token: 0x0602AE92 RID: 175762 RVA: 0x009EF66E File Offset: 0x009ED86E
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x0602AE93 RID: 175763 RVA: 0x009EF684 File Offset: 0x009ED884
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 表情处理(FPoseLink InPose, ref FPoseLink 表情处理)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__表情处理_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__表情处理_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__表情处理_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__表情处理_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (表情处理 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->表情处理, 表情处理.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__表情处理_NativeFunctionPtr, (void*)ptr);
			if (表情处理 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 表情处理.NativePtr, &ptr->表情处理, 1, false);
			}
		}

		// Token: 0x0602AE94 RID: 175764 RVA: 0x009EF730 File Offset: 0x009ED930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AE95 RID: 175765 RVA: 0x009EF7B8 File Offset: 0x009ED9B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE96 RID: 175766 RVA: 0x009EF800 File Offset: 0x009EDA00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AE97 RID: 175767 RVA: 0x009EF847 File Offset: 0x009EDA47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE98 RID: 175768 RVA: 0x009EF85B File Offset: 0x009EDA5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AE99 RID: 175769 RVA: 0x009EF870 File Offset: 0x009EDA70
		protected ABP_BaseRole_Gameplay_Selfie_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163D3 RID: 91091
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C";

		// Token: 0x040163D4 RID: 91092
		private static IntPtr _ClassPtr;

		// Token: 0x040163D5 RID: 91093
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163D6 RID: 91094
		internal static int __PropertyOffset_19;

		// Token: 0x040163D7 RID: 91095
		internal static int __PropertyOffset_20;

		// Token: 0x040163D8 RID: 91096
		internal static int __PropertyOffset_21;

		// Token: 0x040163D9 RID: 91097
		internal static int __PropertyOffset_22;

		// Token: 0x040163DA RID: 91098
		internal static int __PropertyOffset_23;

		// Token: 0x040163DB RID: 91099
		internal static int __PropertyOffset_24;

		// Token: 0x040163DC RID: 91100
		internal static int __PropertyOffset_25;

		// Token: 0x040163DD RID: 91101
		internal static int __PropertyOffset_26;

		// Token: 0x040163DE RID: 91102
		internal static int __PropertyOffset_27;

		// Token: 0x040163DF RID: 91103
		internal static int __PropertyOffset_28;

		// Token: 0x040163E0 RID: 91104
		internal static int __PropertyOffset_29;

		// Token: 0x040163E1 RID: 91105
		internal static int __PropertyOffset_30;

		// Token: 0x040163E2 RID: 91106
		private static IntPtr __表情处理_NativeFunctionPtr;

		// Token: 0x040163E3 RID: 91107
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163E4 RID: 91108
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040163E5 RID: 91109
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A42B RID: 42027
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __表情处理_FunctionParams
		{
			// Token: 0x04032265 RID: 205413
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x04032266 RID: 205414
			[FieldOffset(24)]
			public byte 表情处理;
		}

		// Token: 0x0200A42C RID: 42028
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032267 RID: 205415
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A42D RID: 42029
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032268 RID: 205416
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
