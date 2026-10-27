using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleXL.Jiabeilina_FP
{
	// Token: 0x02004093 RID: 16531
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/ABP_Calbrena_Special.ABP_Calbrena_Special_C")]
	[UnrealStructLayout(45328, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 45324)]
	public class ABP_Calbrena_Special_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A92A RID: 174378 RVA: 0x009E4AAC File Offset: 0x009E2CAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Calbrena_Special_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/ABP_Calbrena_Special.ABP_Calbrena_Special_C");
			}
			return ABP_Calbrena_Special_C._ClassPtr;
		}

		// Token: 0x0602A92B RID: 174379 RVA: 0x009E4AD0 File Offset: 0x009E2CD0
		public ABP_Calbrena_Special_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Calbrena_Special_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A92C RID: 174380 RVA: 0x009E4AF8 File Offset: 0x009E2CF8
		[NullableContext(1)]
		public ABP_Calbrena_Special_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Calbrena_Special_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x0602A92D RID: 174381 RVA: 0x009E4B2B File Offset: 0x009E2D2B
		// (set) Token: 0x0602A92E RID: 174382 RVA: 0x009E4B3F File Offset: 0x009E2D3F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Calbrena_Special_C.__PropertyOffset_328);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Calbrena_Special_C.__PropertyOffset_328, value);
			}
		}

		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x0602A92F RID: 174383 RVA: 0x009E4B54 File Offset: 0x009E2D54
		// (set) Token: 0x0602A930 RID: 174384 RVA: 0x009E4B64 File Offset: 0x009E2D64
		public unsafe bool 状态_样条跑墙
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_329) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_329) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x0602A931 RID: 174385 RVA: 0x009E4B75 File Offset: 0x009E2D75
		// (set) Token: 0x0602A932 RID: 174386 RVA: 0x009E4B85 File Offset: 0x009E2D85
		public unsafe bool 状态_飞雷神移动中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_330) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_330) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x0602A933 RID: 174387 RVA: 0x009E4B96 File Offset: 0x009E2D96
		// (set) Token: 0x0602A934 RID: 174388 RVA: 0x009E4BAA File Offset: 0x009E2DAA
		public unsafe FVeloctiyBlend VelocityBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_331);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Calbrena_Special_C.__PropertyOffset_331) = value;
			}
		}

		// Token: 0x0602A935 RID: 174389 RVA: 0x009E4BC0 File Offset: 0x009E2DC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础姿势层(ref FPoseLink 基础姿势层)
		{
			ABP_Calbrena_Special_C.__基础姿势层_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__基础姿势层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__基础姿势层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__基础姿势层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础姿势层, 基础姿势层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__基础姿势层_NativeFunctionPtr, (void*)ptr);
			if (基础姿势层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础姿势层.NativePtr, &ptr->基础姿势层, 1, false);
			}
		}

		// Token: 0x0602A936 RID: 174390 RVA: 0x009E4C48 File Offset: 0x009E2E48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 叠加动作层(ref FPoseLink 叠加动作层)
		{
			ABP_Calbrena_Special_C.__叠加动作层_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__叠加动作层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__叠加动作层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__叠加动作层_NativeFunctionPtr, (void*)ptr, 1);
			if (叠加动作层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->叠加动作层, 叠加动作层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__叠加动作层_NativeFunctionPtr, (void*)ptr);
			if (叠加动作层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 叠加动作层.NativePtr, &ptr->叠加动作层, 1, false);
			}
		}

		// Token: 0x0602A937 RID: 174391 RVA: 0x009E4CD0 File Offset: 0x009E2ED0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 混合层(FPoseLink BaseLayer, FPoseLink OverlayLayer, FPoseLink BasePose, ref FPoseLink 混合层)
		{
			ABP_Calbrena_Special_C.__混合层_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__混合层_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__混合层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__混合层_NativeFunctionPtr, (void*)ptr, 1);
			if (BaseLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->BaseLayer, BaseLayer.NativePtr, 1, false);
			}
			if (OverlayLayer != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->OverlayLayer, OverlayLayer.NativePtr, 1, false);
			}
			if (BasePose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->BasePose, BasePose.NativePtr, 1, false);
			}
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->混合层, 混合层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__混合层_NativeFunctionPtr, (void*)ptr);
			if (混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 混合层.NativePtr, &ptr->混合层, 1, false);
			}
		}

		// Token: 0x0602A938 RID: 174392 RVA: 0x009E4DC4 File Offset: 0x009E2FC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_Calbrena_Special_C.__基础层_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602A939 RID: 174393 RVA: 0x009E4E4C File Offset: 0x009E304C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 地面站立循环混合层(FPoseLink 前, FPoseLink 后, FPoseLink 左前, FPoseLink 左后, FPoseLink 右前, FPoseLink 右后, FPoseLink 冲刺, ref FPoseLink 地面站立循环混合层)
		{
			ABP_Calbrena_Special_C.__地面站立循环混合层_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__地面站立循环混合层_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__地面站立循环混合层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__地面站立循环混合层_NativeFunctionPtr, (void*)ptr, 1);
			if (前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->前, 前.NativePtr, 1, false);
			}
			if (后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后, 后.NativePtr, 1, false);
			}
			if (左前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左前, 左前.NativePtr, 1, false);
			}
			if (左后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->左后, 左后.NativePtr, 1, false);
			}
			if (右前 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右前, 右前.NativePtr, 1, false);
			}
			if (右后 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->右后, 右后.NativePtr, 1, false);
			}
			if (冲刺 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->冲刺, 冲刺.NativePtr, 1, false);
			}
			if (地面站立循环混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->地面站立循环混合层, 地面站立循环混合层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__地面站立循环混合层_NativeFunctionPtr, (void*)ptr);
			if (地面站立循环混合层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 地面站立循环混合层.NativePtr, &ptr->地面站立循环混合层, 1, false);
			}
		}

		// Token: 0x0602A93A RID: 174394 RVA: 0x009E4FD0 File Offset: 0x009E31D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Calbrena_Special_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A93B RID: 174395 RVA: 0x009E5057 File Offset: 0x009E3257
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A93C RID: 174396 RVA: 0x009E506C File Offset: 0x009E326C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A93D RID: 174397 RVA: 0x009E50B4 File Offset: 0x009E32B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Calbrena_Special_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A93E RID: 174398 RVA: 0x009E50FB File Offset: 0x009E32FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602A93F RID: 174399 RVA: 0x009E510F File Offset: 0x009E330F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Calbrena_Special_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A940 RID: 174400 RVA: 0x009E5124 File Offset: 0x009E3324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Calbrena_Special_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A941 RID: 174401 RVA: 0x009E5138 File Offset: 0x009E3338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Calbrena_Special_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A942 RID: 174402 RVA: 0x009E514D File Offset: 0x009E334D
		protected ABP_Calbrena_Special_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401603B RID: 90171
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/ABP_Calbrena_Special.ABP_Calbrena_Special_C";

		// Token: 0x0401603C RID: 90172
		private static IntPtr _ClassPtr;

		// Token: 0x0401603D RID: 90173
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401603E RID: 90174
		internal static int __PropertyOffset_328;

		// Token: 0x0401603F RID: 90175
		internal static int __PropertyOffset_329;

		// Token: 0x04016040 RID: 90176
		internal static int __PropertyOffset_330;

		// Token: 0x04016041 RID: 90177
		internal static int __PropertyOffset_331;

		// Token: 0x04016042 RID: 90178
		private static IntPtr __基础姿势层_NativeFunctionPtr;

		// Token: 0x04016043 RID: 90179
		private static IntPtr __叠加动作层_NativeFunctionPtr;

		// Token: 0x04016044 RID: 90180
		private static IntPtr __混合层_NativeFunctionPtr;

		// Token: 0x04016045 RID: 90181
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016046 RID: 90182
		private static IntPtr __地面站立循环混合层_NativeFunctionPtr;

		// Token: 0x04016047 RID: 90183
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016048 RID: 90184
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04016049 RID: 90185
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0401604A RID: 90186
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0401604B RID: 90187
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A3CD RID: 41933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础姿势层_FunctionParams
		{
			// Token: 0x040321BA RID: 205242
			[FieldOffset(0)]
			public byte 基础姿势层;
		}

		// Token: 0x0200A3CE RID: 41934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __叠加动作层_FunctionParams
		{
			// Token: 0x040321BB RID: 205243
			[FieldOffset(0)]
			public byte 叠加动作层;
		}

		// Token: 0x0200A3CF RID: 41935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __混合层_FunctionParams
		{
			// Token: 0x040321BC RID: 205244
			[FieldOffset(0)]
			public byte BaseLayer;

			// Token: 0x040321BD RID: 205245
			[FieldOffset(24)]
			public byte OverlayLayer;

			// Token: 0x040321BE RID: 205246
			[FieldOffset(48)]
			public byte BasePose;

			// Token: 0x040321BF RID: 205247
			[FieldOffset(72)]
			public byte 混合层;
		}

		// Token: 0x0200A3D0 RID: 41936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x040321C0 RID: 205248
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A3D1 RID: 41937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __地面站立循环混合层_FunctionParams
		{
			// Token: 0x040321C1 RID: 205249
			[FieldOffset(0)]
			public byte 前;

			// Token: 0x040321C2 RID: 205250
			[FieldOffset(24)]
			public byte 后;

			// Token: 0x040321C3 RID: 205251
			[FieldOffset(48)]
			public byte 左前;

			// Token: 0x040321C4 RID: 205252
			[FieldOffset(72)]
			public byte 左后;

			// Token: 0x040321C5 RID: 205253
			[FieldOffset(96)]
			public byte 右前;

			// Token: 0x040321C6 RID: 205254
			[FieldOffset(120)]
			public byte 右后;

			// Token: 0x040321C7 RID: 205255
			[FieldOffset(144)]
			public byte 冲刺;

			// Token: 0x040321C8 RID: 205256
			[FieldOffset(168)]
			public byte 地面站立循环混合层;
		}

		// Token: 0x0200A3D2 RID: 41938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040321C9 RID: 205257
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A3D3 RID: 41939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040321CA RID: 205258
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
