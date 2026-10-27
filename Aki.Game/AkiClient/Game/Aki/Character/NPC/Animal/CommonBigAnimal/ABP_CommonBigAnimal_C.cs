using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonBigAnimal
{
	// Token: 0x02004249 RID: 16969
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonBigAnimal/ABP_CommonBigAnimal.ABP_CommonBigAnimal_C")]
	[UnrealStructLayout(4368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4365)]
	public class ABP_CommonBigAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF45 RID: 180037 RVA: 0x00A1018C File Offset: 0x00A0E38C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_CommonBigAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonBigAnimal/ABP_CommonBigAnimal.ABP_CommonBigAnimal_C");
			}
			return ABP_CommonBigAnimal_C._ClassPtr;
		}

		// Token: 0x0602BF46 RID: 180038 RVA: 0x00A101B0 File Offset: 0x00A0E3B0
		public ABP_CommonBigAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_CommonBigAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF47 RID: 180039 RVA: 0x00A101D8 File Offset: 0x00A0E3D8
		[NullableContext(1)]
		public ABP_CommonBigAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_CommonBigAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D0B RID: 27915
		// (get) Token: 0x0602BF48 RID: 180040 RVA: 0x00A1020B File Offset: 0x00A0E40B
		// (set) Token: 0x0602BF49 RID: 180041 RVA: 0x00A1021B File Offset: 0x00A0E41B
		public unsafe float 走跑混合速度参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006D0C RID: 27916
		// (get) Token: 0x0602BF4A RID: 180042 RVA: 0x00A1022C File Offset: 0x00A0E42C
		// (set) Token: 0x0602BF4B RID: 180043 RVA: 0x00A1023C File Offset: 0x00A0E43C
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D0D RID: 27917
		// (get) Token: 0x0602BF4C RID: 180044 RVA: 0x00A1024D File Offset: 0x00A0E44D
		// (set) Token: 0x0602BF4D RID: 180045 RVA: 0x00A10261 File Offset: 0x00A0E461
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonBigAnimal_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonBigAnimal_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17006D0E RID: 27918
		// (get) Token: 0x0602BF4E RID: 180046 RVA: 0x00A10276 File Offset: 0x00A0E476
		// (set) Token: 0x0602BF4F RID: 180047 RVA: 0x00A10286 File Offset: 0x00A0E486
		public unsafe float 旋转剩余角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006D0F RID: 27919
		// (get) Token: 0x0602BF50 RID: 180048 RVA: 0x00A10297 File Offset: 0x00A0E497
		// (set) Token: 0x0602BF51 RID: 180049 RVA: 0x00A102A7 File Offset: 0x00A0E4A7
		public unsafe bool 是否有选转输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonBigAnimal_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BF52 RID: 180050 RVA: 0x00A102B8 File Offset: 0x00A0E4B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_CommonBigAnimal_C.__基础层_FunctionParams* ptr = stackalloc ABP_CommonBigAnimal_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonBigAnimal_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonBigAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BF53 RID: 180051 RVA: 0x00A10340 File Offset: 0x00A0E540
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_CommonBigAnimal_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_CommonBigAnimal_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonBigAnimal_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonBigAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BF54 RID: 180052 RVA: 0x00A103C7 File Offset: 0x00A0E5C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新旋转()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__更新旋转_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF55 RID: 180053 RVA: 0x00A103DB File Offset: 0x00A0E5DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF56 RID: 180054 RVA: 0x00A103F0 File Offset: 0x00A0E5F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BF57 RID: 180055 RVA: 0x00A10438 File Offset: 0x00A0E638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BF58 RID: 180056 RVA: 0x00A1047F File Offset: 0x00A0E67F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF59 RID: 180057 RVA: 0x00A10493 File Offset: 0x00A0E693
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonBigAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BF5A RID: 180058 RVA: 0x00A104A8 File Offset: 0x00A0E6A8
		protected ABP_CommonBigAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F35 RID: 94005
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonBigAnimal/ABP_CommonBigAnimal.ABP_CommonBigAnimal_C";

		// Token: 0x04016F36 RID: 94006
		private static IntPtr _ClassPtr;

		// Token: 0x04016F37 RID: 94007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F38 RID: 94008
		internal static int __PropertyOffset_13;

		// Token: 0x04016F39 RID: 94009
		internal static int __PropertyOffset_14;

		// Token: 0x04016F3A RID: 94010
		internal static int __PropertyOffset_15;

		// Token: 0x04016F3B RID: 94011
		internal static int __PropertyOffset_16;

		// Token: 0x04016F3C RID: 94012
		internal static int __PropertyOffset_17;

		// Token: 0x04016F3D RID: 94013
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016F3E RID: 94014
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016F3F RID: 94015
		private static IntPtr __更新旋转_NativeFunctionPtr;

		// Token: 0x04016F40 RID: 94016
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016F41 RID: 94017
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016F42 RID: 94018
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A5A6 RID: 42406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032439 RID: 205881
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A5A7 RID: 42407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403243A RID: 205882
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A5A8 RID: 42408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403243B RID: 205883
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
