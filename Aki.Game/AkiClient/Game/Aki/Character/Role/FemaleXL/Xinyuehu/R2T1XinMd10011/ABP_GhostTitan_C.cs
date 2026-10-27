using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleXL.Xinyuehu.R2T1XinMd10011
{
	// Token: 0x02004092 RID: 16530
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C")]
	[UnrealStructLayout(9280, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9265)]
	public class ABP_GhostTitan_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A919 RID: 174361 RVA: 0x009E4858 File Offset: 0x009E2A58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_GhostTitan_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C");
			}
			return ABP_GhostTitan_C._ClassPtr;
		}

		// Token: 0x0602A91A RID: 174362 RVA: 0x009E487C File Offset: 0x009E2A7C
		public ABP_GhostTitan_C() : this(BuiltinUtils.AllocNativeUObject(ABP_GhostTitan_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A91B RID: 174363 RVA: 0x009E48A4 File Offset: 0x009E2AA4
		[NullableContext(1)]
		public ABP_GhostTitan_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_GhostTitan_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x0602A91C RID: 174364 RVA: 0x009E48D7 File Offset: 0x009E2AD7
		// (set) Token: 0x0602A91D RID: 174365 RVA: 0x009E48EB File Offset: 0x009E2AEB
		public unsafe FName CurrentIdleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x0602A91E RID: 174366 RVA: 0x009E4900 File Offset: 0x009E2B00
		// (set) Token: 0x0602A91F RID: 174367 RVA: 0x009E4910 File Offset: 0x009E2B10
		public unsafe bool RestVariantIsA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x0602A920 RID: 174368 RVA: 0x009E4921 File Offset: 0x009E2B21
		// (set) Token: 0x0602A921 RID: 174369 RVA: 0x009E4935 File Offset: 0x009E2B35
		public unsafe FVector SightTargetDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x0602A922 RID: 174370 RVA: 0x009E494A File Offset: 0x009E2B4A
		// (set) Token: 0x0602A923 RID: 174371 RVA: 0x009E495A File Offset: 0x009E2B5A
		public unsafe float SightAlphaCurrent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x1700685D RID: 26717
		// (get) Token: 0x0602A924 RID: 174372 RVA: 0x009E496B File Offset: 0x009E2B6B
		// (set) Token: 0x0602A925 RID: 174373 RVA: 0x009E497B File Offset: 0x009E2B7B
		public unsafe bool IsPlayingSpecial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A926 RID: 174374 RVA: 0x009E498C File Offset: 0x009E2B8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_GhostTitan_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_GhostTitan_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_GhostTitan_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_GhostTitan_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_GhostTitan_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A927 RID: 174375 RVA: 0x009E4A14 File Offset: 0x009E2C14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A928 RID: 174376 RVA: 0x009E4A5C File Offset: 0x009E2C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A929 RID: 174377 RVA: 0x009E4AA3 File Offset: 0x009E2CA3
		protected ABP_GhostTitan_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016031 RID: 90161
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C";

		// Token: 0x04016032 RID: 90162
		private static IntPtr _ClassPtr;

		// Token: 0x04016033 RID: 90163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016034 RID: 90164
		internal static int __PropertyOffset_47;

		// Token: 0x04016035 RID: 90165
		internal static int __PropertyOffset_48;

		// Token: 0x04016036 RID: 90166
		internal static int __PropertyOffset_49;

		// Token: 0x04016037 RID: 90167
		internal static int __PropertyOffset_50;

		// Token: 0x04016038 RID: 90168
		internal static int __PropertyOffset_51;

		// Token: 0x04016039 RID: 90169
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0401603A RID: 90170
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A3CB RID: 41931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040321B8 RID: 205240
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A3CC RID: 41932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040321B9 RID: 205241
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
