using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Prop.Shipin.Common
{
	// Token: 0x0200418A RID: 16778
	[UnrealObjectPath("/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C")]
	[UnrealStructLayout(11248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 11240)]
	public class ABP_BaseDecoration_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B72D RID: 177965 RVA: 0x00A0105C File Offset: 0x009FF25C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseDecoration_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C");
			}
			return ABP_BaseDecoration_C._ClassPtr;
		}

		// Token: 0x0602B72E RID: 177966 RVA: 0x00A01080 File Offset: 0x009FF280
		public ABP_BaseDecoration_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseDecoration_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B72F RID: 177967 RVA: 0x00A010A8 File Offset: 0x009FF2A8
		[NullableContext(1)]
		public ABP_BaseDecoration_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseDecoration_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B2B RID: 27435
		// (get) Token: 0x0602B730 RID: 177968 RVA: 0x00A010DB File Offset: 0x009FF2DB
		// (set) Token: 0x0602B731 RID: 177969 RVA: 0x00A010EB File Offset: 0x009FF2EB
		public unsafe bool bFollowOwner
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B2C RID: 27436
		// (get) Token: 0x0602B732 RID: 177970 RVA: 0x00A010FC File Offset: 0x009FF2FC
		// (set) Token: 0x0602B733 RID: 177971 RVA: 0x00A0110C File Offset: 0x009FF30C
		public unsafe bool bUseAllAnims
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseDecoration_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B2D RID: 27437
		// (get) Token: 0x0602B734 RID: 177972 RVA: 0x00A0111D File Offset: 0x009FF31D
		// (set) Token: 0x0602B735 RID: 177973 RVA: 0x00A01131 File Offset: 0x009FF331
		[Nullable(2)]
		public unsafe TsBaseCharacter 当前角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseDecoration_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseDecoration_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x0602B736 RID: 177974 RVA: 0x00A01148 File Offset: 0x009FF348
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseDecoration_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseDecoration_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseDecoration_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseDecoration_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseDecoration_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602B737 RID: 177975 RVA: 0x00A011D0 File Offset: 0x009FF3D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetExtraFollowOwner(UAnimInstance Owner)
		{
			ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams* ptr = stackalloc ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ABP_BaseDecoration_C.__SetExtraFollowOwner_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseDecoration_C.__SetExtraFollowOwner_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseDecoration_C.__SetExtraFollowOwner_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B738 RID: 177976 RVA: 0x00A01225 File Offset: 0x009FF425
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseDecoration_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B739 RID: 177977 RVA: 0x00A01239 File Offset: 0x009FF439
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseDecoration_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B73A RID: 177978 RVA: 0x00A0124E File Offset: 0x009FF44E
		protected ABP_BaseDecoration_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169D4 RID: 92628
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Prop/Shipin/Common/ABP_BaseDecoration.ABP_BaseDecoration_C";

		// Token: 0x040169D5 RID: 92629
		private static IntPtr _ClassPtr;

		// Token: 0x040169D6 RID: 92630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169D7 RID: 92631
		internal static int __PropertyOffset_16;

		// Token: 0x040169D8 RID: 92632
		internal static int __PropertyOffset_17;

		// Token: 0x040169D9 RID: 92633
		internal static int __PropertyOffset_18;

		// Token: 0x040169DA RID: 92634
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040169DB RID: 92635
		private static IntPtr __SetExtraFollowOwner_NativeFunctionPtr;

		// Token: 0x040169DC RID: 92636
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A528 RID: 42280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032396 RID: 205718
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A529 RID: 42281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetExtraFollowOwner_FunctionParams
		{
			// Token: 0x04032397 RID: 205719
			[FieldOffset(0)]
			public IntPtr Owner;
		}
	}
}
