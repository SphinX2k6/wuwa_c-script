using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004073 RID: 16499
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP.GA_Motor_FP_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class GA_Motor_FP_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A6CA RID: 173770 RVA: 0x009E0264 File Offset: 0x009DE464
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FP_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP.GA_Motor_FP_C");
			}
			return GA_Motor_FP_C._ClassPtr;
		}

		// Token: 0x0602A6CB RID: 173771 RVA: 0x009E0288 File Offset: 0x009DE488
		public GA_Motor_FP_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FP_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A6CC RID: 173772 RVA: 0x009E02B0 File Offset: 0x009DE4B0
		[NullableContext(1)]
		public GA_Motor_FP_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FP_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006818 RID: 26648
		// (get) Token: 0x0602A6CD RID: 173773 RVA: 0x009E02E3 File Offset: 0x009DE4E3
		// (set) Token: 0x0602A6CE RID: 173774 RVA: 0x009E02F7 File Offset: 0x009DE4F7
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006819 RID: 26649
		// (get) Token: 0x0602A6CF RID: 173775 RVA: 0x009E030C File Offset: 0x009DE50C
		// (set) Token: 0x0602A6D0 RID: 173776 RVA: 0x009E0345 File Offset: 0x009DE545
		[Nullable(1)]
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_FP_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_FP_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700681A RID: 26650
		// (get) Token: 0x0602A6D1 RID: 173777 RVA: 0x009E0366 File Offset: 0x009DE566
		// (set) Token: 0x0602A6D2 RID: 173778 RVA: 0x009E037A File Offset: 0x009DE57A
		[Nullable(2)]
		public unsafe TsBaseCharacter 当前角色
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FP_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602A6D3 RID: 173779 RVA: 0x009E0390 File Offset: 0x009DE590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 开启头部跟随旋转(int id)
		{
			GA_Motor_FP_C.__开启头部跟随旋转_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__开启头部跟随旋转_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(GA_Motor_FP_C.__开启头部跟随旋转_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__开启头部跟随旋转_NativeFunctionPtr, (void*)ptr, 1);
			ptr->id = id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__开启头部跟随旋转_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D4 RID: 173780 RVA: 0x009E03D8 File Offset: 0x009DE5D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 关闭头部跟随旋转开动态模糊(int id)
		{
			GA_Motor_FP_C.__关闭头部跟随旋转开动态模糊_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__关闭头部跟随旋转开动态模糊_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Motor_FP_C.__关闭头部跟随旋转开动态模糊_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__关闭头部跟随旋转开动态模糊_NativeFunctionPtr, (void*)ptr, 1);
			ptr->id = id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__关闭头部跟随旋转开动态模糊_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D5 RID: 173781 RVA: 0x009E0420 File Offset: 0x009DE620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3818185D810(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D3818185D810_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D3818185D810_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D3818185D810_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D3818185D810_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D3818185D810_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D6 RID: 173782 RVA: 0x009E046C File Offset: 0x009DE66C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381B592EC70(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381B592EC70_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381B592EC70_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381B592EC70_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381B592EC70_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381B592EC70_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D7 RID: 173783 RVA: 0x009E04B8 File Offset: 0x009DE6B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3ECEFA05A(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3ECEFA05A_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3ECEFA05A_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3ECEFA05A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3ECEFA05A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3ECEFA05A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D8 RID: 173784 RVA: 0x009E0504 File Offset: 0x009DE704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381AB958228(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381AB958228_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381AB958228_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381AB958228_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381AB958228_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Removed_DB9F64004F8908FEAD99D381AB958228_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6D9 RID: 173785 RVA: 0x009E0550 File Offset: 0x009DE750
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3F51FE60F(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3F51FE60F_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3F51FE60F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3F51FE60F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3F51FE60F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A3F51FE60F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6DA RID: 173786 RVA: 0x009E059C File Offset: 0x009DE79C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A30BC0D67E(in FGameplayTag Tag)
		{
			GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A30BC0D67E_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A30BC0D67E_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A30BC0D67E_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A30BC0D67E_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__Added_21071CB943CD992BF8EFD6A30BC0D67E_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6DB RID: 173787 RVA: 0x009E05E7 File Offset: 0x009DE7E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6DC RID: 173788 RVA: 0x009E05FB File Offset: 0x009DE7FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FP_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A6DD RID: 173789 RVA: 0x009E0610 File Offset: 0x009DE810
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6DE RID: 173790 RVA: 0x009E0658 File Offset: 0x009DE858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FP_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A6DF RID: 173791 RVA: 0x009E069F File Offset: 0x009DE89F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 自定义事件_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FP_C.__自定义事件_0_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6E0 RID: 173792 RVA: 0x009E06B3 File Offset: 0x009DE8B3
		protected GA_Motor_FP_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E75 RID: 89717
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FP.GA_Motor_FP_C";

		// Token: 0x04015E76 RID: 89718
		private static IntPtr _ClassPtr;

		// Token: 0x04015E77 RID: 89719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E78 RID: 89720
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E79 RID: 89721
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E7A RID: 89722
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015E7B RID: 89723
		internal new static int __PropertyOffset_3;

		// Token: 0x04015E7C RID: 89724
		private static IntPtr __开启头部跟随旋转_NativeFunctionPtr;

		// Token: 0x04015E7D RID: 89725
		private static IntPtr __关闭头部跟随旋转开动态模糊_NativeFunctionPtr;

		// Token: 0x04015E7E RID: 89726
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3818185D810_NativeFunctionPtr;

		// Token: 0x04015E7F RID: 89727
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381B592EC70_NativeFunctionPtr;

		// Token: 0x04015E80 RID: 89728
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3ECEFA05A_NativeFunctionPtr;

		// Token: 0x04015E81 RID: 89729
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381AB958228_NativeFunctionPtr;

		// Token: 0x04015E82 RID: 89730
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3F51FE60F_NativeFunctionPtr;

		// Token: 0x04015E83 RID: 89731
		private static IntPtr __Added_21071CB943CD992BF8EFD6A30BC0D67E_NativeFunctionPtr;

		// Token: 0x04015E84 RID: 89732
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E85 RID: 89733
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04015E86 RID: 89734
		private static IntPtr __自定义事件_0_NativeFunctionPtr;

		// Token: 0x0200A39E RID: 41886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __开启头部跟随旋转_FunctionParams
		{
			// Token: 0x0403218B RID: 205195
			[FieldOffset(0)]
			public int id;
		}

		// Token: 0x0200A39F RID: 41887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __关闭头部跟随旋转开动态模糊_FunctionParams
		{
			// Token: 0x0403218C RID: 205196
			[FieldOffset(0)]
			public int id;
		}

		// Token: 0x0200A3A0 RID: 41888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3818185D810_FunctionParams
		{
			// Token: 0x0403218D RID: 205197
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A1 RID: 41889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381B592EC70_FunctionParams
		{
			// Token: 0x0403218E RID: 205198
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A2 RID: 41890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3ECEFA05A_FunctionParams
		{
			// Token: 0x0403218F RID: 205199
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A3 RID: 41891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381AB958228_FunctionParams
		{
			// Token: 0x04032190 RID: 205200
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A4 RID: 41892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3F51FE60F_FunctionParams
		{
			// Token: 0x04032191 RID: 205201
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A5 RID: 41893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A30BC0D67E_FunctionParams
		{
			// Token: 0x04032192 RID: 205202
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3A6 RID: 41894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032193 RID: 205203
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
