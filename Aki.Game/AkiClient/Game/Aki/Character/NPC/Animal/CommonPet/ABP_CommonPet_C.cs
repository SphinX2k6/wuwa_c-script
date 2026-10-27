using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.CommonPet
{
	// Token: 0x02004245 RID: 16965
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/CommonPet/ABP_CommonPet.ABP_CommonPet_C")]
	[UnrealStructLayout(5056, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5048)]
	public class ABP_CommonPet_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF1F RID: 179999 RVA: 0x00A0FB88 File Offset: 0x00A0DD88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_CommonPet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/CommonPet/ABP_CommonPet.ABP_CommonPet_C");
			}
			return ABP_CommonPet_C._ClassPtr;
		}

		// Token: 0x0602BF20 RID: 180000 RVA: 0x00A0FBAC File Offset: 0x00A0DDAC
		public ABP_CommonPet_C() : this(BuiltinUtils.AllocNativeUObject(ABP_CommonPet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF21 RID: 180001 RVA: 0x00A0FBD4 File Offset: 0x00A0DDD4
		[NullableContext(1)]
		public ABP_CommonPet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_CommonPet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D05 RID: 27909
		// (get) Token: 0x0602BF22 RID: 180002 RVA: 0x00A0FC07 File Offset: 0x00A0DE07
		// (set) Token: 0x0602BF23 RID: 180003 RVA: 0x00A0FC1B File Offset: 0x00A0DE1B
		public unsafe FVector SightDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006D06 RID: 27910
		// (get) Token: 0x0602BF24 RID: 180004 RVA: 0x00A0FC30 File Offset: 0x00A0DE30
		// (set) Token: 0x0602BF25 RID: 180005 RVA: 0x00A0FC40 File Offset: 0x00A0DE40
		public unsafe SightLockMode SightLockMode
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_17));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_17) = (byte)value;
			}
		}

		// Token: 0x17006D07 RID: 27911
		// (get) Token: 0x0602BF26 RID: 180006 RVA: 0x00A0FC51 File Offset: 0x00A0DE51
		// (set) Token: 0x0602BF27 RID: 180007 RVA: 0x00A0FC65 File Offset: 0x00A0DE65
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonPet_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_CommonPet_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17006D08 RID: 27912
		// (get) Token: 0x0602BF28 RID: 180008 RVA: 0x00A0FC7A File Offset: 0x00A0DE7A
		// (set) Token: 0x0602BF29 RID: 180009 RVA: 0x00A0FC8A File Offset: 0x00A0DE8A
		public unsafe bool 是否有移动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D09 RID: 27913
		// (get) Token: 0x0602BF2A RID: 180010 RVA: 0x00A0FC9B File Offset: 0x00A0DE9B
		// (set) Token: 0x0602BF2B RID: 180011 RVA: 0x00A0FCAB File Offset: 0x00A0DEAB
		public unsafe float 走跑混合速度参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_CommonPet_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602BF2C RID: 180012 RVA: 0x00A0FCBC File Offset: 0x00A0DEBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 基础层(ref FPoseLink 基础层)
		{
			ABP_CommonPet_C.__基础层_FunctionParams* ptr = stackalloc ABP_CommonPet_C.__基础层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonPet_C.__基础层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonPet_C.__基础层_NativeFunctionPtr, (void*)ptr, 1);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->基础层, 基础层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__基础层_NativeFunctionPtr, (void*)ptr);
			if (基础层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 基础层.NativePtr, &ptr->基础层, 1, false);
			}
		}

		// Token: 0x0602BF2D RID: 180013 RVA: 0x00A0FD44 File Offset: 0x00A0DF44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_CommonPet_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_CommonPet_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_CommonPet_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonPet_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BF2E RID: 180014 RVA: 0x00A0FDCB File Offset: 0x00A0DFCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新角色移动()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__更新角色移动_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF2F RID: 180015 RVA: 0x00A0FDDF File Offset: 0x00A0DFDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新视线()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__更新视线_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF30 RID: 180016 RVA: 0x00A0FDF4 File Offset: 0x00A0DFF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonPet_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BF31 RID: 180017 RVA: 0x00A0FE3C File Offset: 0x00A0E03C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_CommonPet_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_CommonPet_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonPet_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BF32 RID: 180018 RVA: 0x00A0FE83 File Offset: 0x00A0E083
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_CommonPet_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF33 RID: 180019 RVA: 0x00A0FE97 File Offset: 0x00A0E097
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_CommonPet_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BF34 RID: 180020 RVA: 0x00A0FEAC File Offset: 0x00A0E0AC
		protected ABP_CommonPet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F1B RID: 93979
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/CommonPet/ABP_CommonPet.ABP_CommonPet_C";

		// Token: 0x04016F1C RID: 93980
		private static IntPtr _ClassPtr;

		// Token: 0x04016F1D RID: 93981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F1E RID: 93982
		internal static int __PropertyOffset_16;

		// Token: 0x04016F1F RID: 93983
		internal static int __PropertyOffset_17;

		// Token: 0x04016F20 RID: 93984
		internal static int __PropertyOffset_18;

		// Token: 0x04016F21 RID: 93985
		internal static int __PropertyOffset_19;

		// Token: 0x04016F22 RID: 93986
		internal static int __PropertyOffset_20;

		// Token: 0x04016F23 RID: 93987
		private static IntPtr __基础层_NativeFunctionPtr;

		// Token: 0x04016F24 RID: 93988
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016F25 RID: 93989
		private static IntPtr __更新角色移动_NativeFunctionPtr;

		// Token: 0x04016F26 RID: 93990
		private static IntPtr __更新视线_NativeFunctionPtr;

		// Token: 0x04016F27 RID: 93991
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016F28 RID: 93992
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A5A1 RID: 42401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __基础层_FunctionParams
		{
			// Token: 0x04032434 RID: 205876
			[FieldOffset(0)]
			public byte 基础层;
		}

		// Token: 0x0200A5A2 RID: 42402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032435 RID: 205877
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A5A3 RID: 42403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032436 RID: 205878
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
