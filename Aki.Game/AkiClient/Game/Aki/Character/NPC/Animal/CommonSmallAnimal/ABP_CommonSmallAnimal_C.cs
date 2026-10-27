using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonSmallAnimal
{
	// Token: 0x02004243 RID: 16963
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/ABP_CommonSmallAnimal.ABP_CommonSmallAnimal_C")]
	[UnrealStructLayout(4368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4360)]
	public class ABP_CommonSmallAnimal_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF0A RID: 179978 RVA: 0x00A0F82C File Offset: 0x00A0DA2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_CommonSmallAnimal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/ABP_CommonSmallAnimal.ABP_CommonSmallAnimal_C");
			}
			return ABP_CommonSmallAnimal_C._ClassPtr;
		}

		// Token: 0x0602BF0B RID: 179979 RVA: 0x00A0F850 File Offset: 0x00A0DA50
		public ABP_CommonSmallAnimal_C() : this(BuiltinUtils.AllocNativeUObject(ABP_CommonSmallAnimal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF0C RID: 179980 RVA: 0x00A0F878 File Offset: 0x00A0DA78
		[NullableContext(1)]
		public ABP_CommonSmallAnimal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_CommonSmallAnimal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D02 RID: 27906
		// (get) Token: 0x0602BF0D RID: 179981 RVA: 0x00A0F8AB File Offset: 0x00A0DAAB
		// (set) Token: 0x0602BF0E RID: 179982 RVA: 0x00A0F8BF File Offset: 0x00A0DABF
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonSmallAnimal_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonSmallAnimal_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006D03 RID: 27907
		// (get) Token: 0x0602BF0F RID: 179983 RVA: 0x00A0F8D4 File Offset: 0x00A0DAD4
		// (set) Token: 0x0602BF10 RID: 179984 RVA: 0x00A0F8E4 File Offset: 0x00A0DAE4
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonSmallAnimal_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonSmallAnimal_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D04 RID: 27908
		// (get) Token: 0x0602BF11 RID: 179985 RVA: 0x00A0F8F5 File Offset: 0x00A0DAF5
		// (set) Token: 0x0602BF12 RID: 179986 RVA: 0x00A0F905 File Offset: 0x00A0DB05
		public unsafe float 走跑混合速度参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonSmallAnimal_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonSmallAnimal_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0602BF13 RID: 179987 RVA: 0x00A0F918 File Offset: 0x00A0DB18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_CommonSmallAnimal_C.__基础层_FunctionParams* ptr = stackalloc ABP_CommonSmallAnimal_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonSmallAnimal_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonSmallAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BF14 RID: 179988 RVA: 0x00A0F9A0 File Offset: 0x00A0DBA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_CommonSmallAnimal_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_CommonSmallAnimal_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonSmallAnimal_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonSmallAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BF15 RID: 179989 RVA: 0x00A0FA27 File Offset: 0x00A0DC27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF16 RID: 179990 RVA: 0x00A0FA3C File Offset: 0x00A0DC3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BF17 RID: 179991 RVA: 0x00A0FA84 File Offset: 0x00A0DC84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BF18 RID: 179992 RVA: 0x00A0FACB File Offset: 0x00A0DCCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF19 RID: 179993 RVA: 0x00A0FADF File Offset: 0x00A0DCDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonSmallAnimal_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BF1A RID: 179994 RVA: 0x00A0FAF4 File Offset: 0x00A0DCF4
		protected ABP_CommonSmallAnimal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F0D RID: 93965
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonSmallAnimal/ABP_CommonSmallAnimal.ABP_CommonSmallAnimal_C";

		// Token: 0x04016F0E RID: 93966
		private static IntPtr _ClassPtr;

		// Token: 0x04016F0F RID: 93967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F10 RID: 93968
		internal static int __PropertyOffset_13;

		// Token: 0x04016F11 RID: 93969
		internal static int __PropertyOffset_14;

		// Token: 0x04016F12 RID: 93970
		internal static int __PropertyOffset_15;

		// Token: 0x04016F13 RID: 93971
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016F14 RID: 93972
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016F15 RID: 93973
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016F16 RID: 93974
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016F17 RID: 93975
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A59E RID: 42398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032431 RID: 205873
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A59F RID: 42399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032432 RID: 205874
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A5A0 RID: 42400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032433 RID: 205875
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
