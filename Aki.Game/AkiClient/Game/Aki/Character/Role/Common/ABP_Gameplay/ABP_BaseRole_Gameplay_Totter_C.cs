using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x0200411D RID: 16669
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Totter.ABP_BaseRole_Gameplay_Totter_C")]
	[UnrealStructLayout(6064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6052)]
	public class ABP_BaseRole_Gameplay_Totter_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AECA RID: 175818 RVA: 0x009EFF49 File Offset: 0x009EE149
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Totter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Totter.ABP_BaseRole_Gameplay_Totter_C");
			}
			return ABP_BaseRole_Gameplay_Totter_C._ClassPtr;
		}

		// Token: 0x0602AECB RID: 175819 RVA: 0x009EFF70 File Offset: 0x009EE170
		public ABP_BaseRole_Gameplay_Totter_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Totter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AECC RID: 175820 RVA: 0x009EFF98 File Offset: 0x009EE198
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Totter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Totter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069B4 RID: 27060
		// (get) Token: 0x0602AECD RID: 175821 RVA: 0x009EFFCB File Offset: 0x009EE1CB
		// (set) Token: 0x0602AECE RID: 175822 RVA: 0x009EFFDF File Offset: 0x009EE1DF
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x170069B5 RID: 27061
		// (get) Token: 0x0602AECF RID: 175823 RVA: 0x009EFFF4 File Offset: 0x009EE1F4
		// (set) Token: 0x0602AED0 RID: 175824 RVA: 0x009F0008 File Offset: 0x009EE208
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x170069B6 RID: 27062
		// (get) Token: 0x0602AED1 RID: 175825 RVA: 0x009F001D File Offset: 0x009EE21D
		// (set) Token: 0x0602AED2 RID: 175826 RVA: 0x009F002D File Offset: 0x009EE22D
		public unsafe bool IsStarted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069B7 RID: 27063
		// (get) Token: 0x0602AED3 RID: 175827 RVA: 0x009F003E File Offset: 0x009EE23E
		// (set) Token: 0x0602AED4 RID: 175828 RVA: 0x009F004E File Offset: 0x009EE24E
		public unsafe bool 使用额外开启结束表演
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069B8 RID: 27064
		// (get) Token: 0x0602AED5 RID: 175829 RVA: 0x009F005F File Offset: 0x009EE25F
		// (set) Token: 0x0602AED6 RID: 175830 RVA: 0x009F006F File Offset: 0x009EE26F
		public unsafe bool 进入结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069B9 RID: 27065
		// (get) Token: 0x0602AED7 RID: 175831 RVA: 0x009F0080 File Offset: 0x009EE280
		// (set) Token: 0x0602AED8 RID: 175832 RVA: 0x009F0090 File Offset: 0x009EE290
		public unsafe float 演出状态转移时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x170069BA RID: 27066
		// (get) Token: 0x0602AED9 RID: 175833 RVA: 0x009F00A1 File Offset: 0x009EE2A1
		// (set) Token: 0x0602AEDA RID: 175834 RVA: 0x009F00B1 File Offset: 0x009EE2B1
		public unsafe float 右脚停步动画Right标记时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x170069BB RID: 27067
		// (get) Token: 0x0602AEDB RID: 175835 RVA: 0x009F00C2 File Offset: 0x009EE2C2
		// (set) Token: 0x0602AEDC RID: 175836 RVA: 0x009F00D2 File Offset: 0x009EE2D2
		public unsafe bool bShouldPlayExtraEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069BC RID: 27068
		// (get) Token: 0x0602AEDD RID: 175837 RVA: 0x009F00E3 File Offset: 0x009EE2E3
		// (set) Token: 0x0602AEDE RID: 175838 RVA: 0x009F00F3 File Offset: 0x009EE2F3
		public unsafe float 演出To移动播放起点时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x170069BD RID: 27069
		// (get) Token: 0x0602AEDF RID: 175839 RVA: 0x009F0104 File Offset: 0x009EE304
		// (set) Token: 0x0602AEE0 RID: 175840 RVA: 0x009F0114 File Offset: 0x009EE314
		public unsafe float 当前移动Loop起点时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x170069BE RID: 27070
		// (get) Token: 0x0602AEE1 RID: 175841 RVA: 0x009F0125 File Offset: 0x009EE325
		// (set) Token: 0x0602AEE2 RID: 175842 RVA: 0x009F0135 File Offset: 0x009EE335
		public unsafe float 演出To移动状态转移时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x170069BF RID: 27071
		// (get) Token: 0x0602AEE3 RID: 175843 RVA: 0x009F0146 File Offset: 0x009EE346
		// (set) Token: 0x0602AEE4 RID: 175844 RVA: 0x009F0156 File Offset: 0x009EE356
		public unsafe float 停步静止转移时间百分比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x170069C0 RID: 27072
		// (get) Token: 0x0602AEE5 RID: 175845 RVA: 0x009F0167 File Offset: 0x009EE367
		// (set) Token: 0x0602AEE6 RID: 175846 RVA: 0x009F0177 File Offset: 0x009EE377
		public unsafe float 左脚停步动画Right标记时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x170069C1 RID: 27073
		// (get) Token: 0x0602AEE7 RID: 175847 RVA: 0x009F0188 File Offset: 0x009EE388
		// (set) Token: 0x0602AEE8 RID: 175848 RVA: 0x009F0198 File Offset: 0x009EE398
		public unsafe float 右脚停步动画Left标记时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170069C2 RID: 27074
		// (get) Token: 0x0602AEE9 RID: 175849 RVA: 0x009F01A9 File Offset: 0x009EE3A9
		// (set) Token: 0x0602AEEA RID: 175850 RVA: 0x009F01B9 File Offset: 0x009EE3B9
		public unsafe float 左脚停步动画Left标记时间点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Totter_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x0602AEEB RID: 175851 RVA: 0x009F01CC File Offset: 0x009EE3CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Totter_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Totter_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Totter_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Totter_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Totter_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AEEC RID: 175852 RVA: 0x009F0253 File Offset: 0x009EE453
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Totter_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602AEED RID: 175853 RVA: 0x009F0268 File Offset: 0x009EE468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AEEE RID: 175854 RVA: 0x009F02B0 File Offset: 0x009EE4B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Totter_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AEEF RID: 175855 RVA: 0x009F02F7 File Offset: 0x009EE4F7
		protected ABP_BaseRole_Gameplay_Totter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016404 RID: 91140
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Totter.ABP_BaseRole_Gameplay_Totter_C";

		// Token: 0x04016405 RID: 91141
		private static IntPtr _ClassPtr;

		// Token: 0x04016406 RID: 91142
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016407 RID: 91143
		internal static int __PropertyOffset_36;

		// Token: 0x04016408 RID: 91144
		internal static int __PropertyOffset_37;

		// Token: 0x04016409 RID: 91145
		internal static int __PropertyOffset_38;

		// Token: 0x0401640A RID: 91146
		internal static int __PropertyOffset_39;

		// Token: 0x0401640B RID: 91147
		internal static int __PropertyOffset_40;

		// Token: 0x0401640C RID: 91148
		internal static int __PropertyOffset_41;

		// Token: 0x0401640D RID: 91149
		internal static int __PropertyOffset_42;

		// Token: 0x0401640E RID: 91150
		internal static int __PropertyOffset_43;

		// Token: 0x0401640F RID: 91151
		internal static int __PropertyOffset_44;

		// Token: 0x04016410 RID: 91152
		internal static int __PropertyOffset_45;

		// Token: 0x04016411 RID: 91153
		internal static int __PropertyOffset_46;

		// Token: 0x04016412 RID: 91154
		internal static int __PropertyOffset_47;

		// Token: 0x04016413 RID: 91155
		internal static int __PropertyOffset_48;

		// Token: 0x04016414 RID: 91156
		internal static int __PropertyOffset_49;

		// Token: 0x04016415 RID: 91157
		internal static int __PropertyOffset_50;

		// Token: 0x04016416 RID: 91158
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016417 RID: 91159
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04016418 RID: 91160
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A433 RID: 42035
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403226E RID: 205422
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A434 RID: 42036
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403226F RID: 205423
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
