using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP
{
	// Token: 0x02003F0B RID: 16139
	[UnrealObjectPath("/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C")]
	[UnrealStructLayout(6592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6592)]
	public class ABP_Plane_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028F22 RID: 167714 RVA: 0x009B8179 File Offset: 0x009B6379
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Plane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C");
			}
			return ABP_Plane_C._ClassPtr;
		}

		// Token: 0x06028F23 RID: 167715 RVA: 0x009B81A0 File Offset: 0x009B63A0
		public ABP_Plane_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Plane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028F24 RID: 167716 RVA: 0x009B81C8 File Offset: 0x009B63C8
		[NullableContext(1)]
		public ABP_Plane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Plane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x06028F25 RID: 167717 RVA: 0x009B81FB File Offset: 0x009B63FB
		// (set) Token: 0x06028F26 RID: 167718 RVA: 0x009B820B File Offset: 0x009B640B
		public unsafe bool InputRollL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x06028F27 RID: 167719 RVA: 0x009B821C File Offset: 0x009B641C
		// (set) Token: 0x06028F28 RID: 167720 RVA: 0x009B822C File Offset: 0x009B642C
		public unsafe float Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x06028F29 RID: 167721 RVA: 0x009B823D File Offset: 0x009B643D
		// (set) Token: 0x06028F2A RID: 167722 RVA: 0x009B824D File Offset: 0x009B644D
		public unsafe bool InputRollR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x06028F2B RID: 167723 RVA: 0x009B825E File Offset: 0x009B645E
		// (set) Token: 0x06028F2C RID: 167724 RVA: 0x009B826E File Offset: 0x009B646E
		public unsafe float Horzontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x1700608F RID: 24719
		// (get) Token: 0x06028F2D RID: 167725 RVA: 0x009B827F File Offset: 0x009B647F
		// (set) Token: 0x06028F2E RID: 167726 RVA: 0x009B828F File Offset: 0x009B648F
		public unsafe float Jump_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x06028F2F RID: 167727 RVA: 0x009B82A0 File Offset: 0x009B64A0
		// (set) Token: 0x06028F30 RID: 167728 RVA: 0x009B82B0 File Offset: 0x009B64B0
		public unsafe bool InputJump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006091 RID: 24721
		// (get) Token: 0x06028F31 RID: 167729 RVA: 0x009B82C1 File Offset: 0x009B64C1
		// (set) Token: 0x06028F32 RID: 167730 RVA: 0x009B82D1 File Offset: 0x009B64D1
		public unsafe bool InputRollL3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006092 RID: 24722
		// (get) Token: 0x06028F33 RID: 167731 RVA: 0x009B82E2 File Offset: 0x009B64E2
		// (set) Token: 0x06028F34 RID: 167732 RVA: 0x009B82F2 File Offset: 0x009B64F2
		public unsafe bool InputRollR3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_51) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_51) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x06028F35 RID: 167733 RVA: 0x009B8303 File Offset: 0x009B6503
		// (set) Token: 0x06028F36 RID: 167734 RVA: 0x009B8313 File Offset: 0x009B6513
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x06028F37 RID: 167735 RVA: 0x009B8324 File Offset: 0x009B6524
		// (set) Token: 0x06028F38 RID: 167736 RVA: 0x009B8334 File Offset: 0x009B6534
		public unsafe bool InputSwingL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x06028F39 RID: 167737 RVA: 0x009B8345 File Offset: 0x009B6545
		// (set) Token: 0x06028F3A RID: 167738 RVA: 0x009B8355 File Offset: 0x009B6555
		public unsafe bool InputSwingR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006096 RID: 24726
		// (get) Token: 0x06028F3B RID: 167739 RVA: 0x009B8366 File Offset: 0x009B6566
		// (set) Token: 0x06028F3C RID: 167740 RVA: 0x009B8376 File Offset: 0x009B6576
		public unsafe bool InputMoveL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006097 RID: 24727
		// (get) Token: 0x06028F3D RID: 167741 RVA: 0x009B8387 File Offset: 0x009B6587
		// (set) Token: 0x06028F3E RID: 167742 RVA: 0x009B8397 File Offset: 0x009B6597
		public unsafe bool InputMoveR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Plane_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028F3F RID: 167743 RVA: 0x009B83A8 File Offset: 0x009B65A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Plane_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Plane_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Plane_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Plane_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Plane_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x06028F40 RID: 167744 RVA: 0x009B8430 File Offset: 0x009B6630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028F41 RID: 167745 RVA: 0x009B8478 File Offset: 0x009B6678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Plane_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Plane_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028F42 RID: 167746 RVA: 0x009B84BF File Offset: 0x009B66BF
		protected ABP_Plane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F1B RID: 85787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/PlaneYinyou/BP/ABP_Plane.ABP_Plane_C";

		// Token: 0x04014F1C RID: 85788
		private static IntPtr _ClassPtr;

		// Token: 0x04014F1D RID: 85789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F1E RID: 85790
		internal static int __PropertyOffset_44;

		// Token: 0x04014F1F RID: 85791
		internal static int __PropertyOffset_45;

		// Token: 0x04014F20 RID: 85792
		internal static int __PropertyOffset_46;

		// Token: 0x04014F21 RID: 85793
		internal static int __PropertyOffset_47;

		// Token: 0x04014F22 RID: 85794
		internal static int __PropertyOffset_48;

		// Token: 0x04014F23 RID: 85795
		internal static int __PropertyOffset_49;

		// Token: 0x04014F24 RID: 85796
		internal static int __PropertyOffset_50;

		// Token: 0x04014F25 RID: 85797
		internal static int __PropertyOffset_51;

		// Token: 0x04014F26 RID: 85798
		internal static int __PropertyOffset_52;

		// Token: 0x04014F27 RID: 85799
		internal static int __PropertyOffset_53;

		// Token: 0x04014F28 RID: 85800
		internal static int __PropertyOffset_54;

		// Token: 0x04014F29 RID: 85801
		internal static int __PropertyOffset_55;

		// Token: 0x04014F2A RID: 85802
		internal static int __PropertyOffset_56;

		// Token: 0x04014F2B RID: 85803
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04014F2C RID: 85804
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A2DB RID: 41691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403201F RID: 204831
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A2DC RID: 41692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032020 RID: 204832
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
