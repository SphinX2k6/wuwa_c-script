using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200417B RID: 16763
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu.GA_Super_Sprint_Start_Yanxu_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_Yanxu_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B65F RID: 177759 RVA: 0x009FF700 File Offset: 0x009FD900
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_Yanxu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu.GA_Super_Sprint_Start_Yanxu_C");
			}
			return GA_Super_Sprint_Start_Yanxu_C._ClassPtr;
		}

		// Token: 0x0602B660 RID: 177760 RVA: 0x009FF724 File Offset: 0x009FD924
		public GA_Super_Sprint_Start_Yanxu_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_Yanxu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B661 RID: 177761 RVA: 0x009FF74C File Offset: 0x009FD94C
		[NullableContext(1)]
		public GA_Super_Sprint_Start_Yanxu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_Yanxu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B0B RID: 27403
		// (get) Token: 0x0602B662 RID: 177762 RVA: 0x009FF77F File Offset: 0x009FD97F
		// (set) Token: 0x0602B663 RID: 177763 RVA: 0x009FF78F File Offset: 0x009FD98F
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0C RID: 27404
		// (get) Token: 0x0602B664 RID: 177764 RVA: 0x009FF7A0 File Offset: 0x009FD9A0
		// (set) Token: 0x0602B665 RID: 177765 RVA: 0x009FF7B0 File Offset: 0x009FD9B0
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0D RID: 27405
		// (get) Token: 0x0602B666 RID: 177766 RVA: 0x009FF7C1 File Offset: 0x009FD9C1
		// (set) Token: 0x0602B667 RID: 177767 RVA: 0x009FF7D1 File Offset: 0x009FD9D1
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0E RID: 27406
		// (get) Token: 0x0602B668 RID: 177768 RVA: 0x009FF7E2 File Offset: 0x009FD9E2
		// (set) Token: 0x0602B669 RID: 177769 RVA: 0x009FF7F2 File Offset: 0x009FD9F2
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0F RID: 27407
		// (get) Token: 0x0602B66A RID: 177770 RVA: 0x009FF803 File Offset: 0x009FDA03
		// (set) Token: 0x0602B66B RID: 177771 RVA: 0x009FF813 File Offset: 0x009FDA13
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B66C RID: 177772 RVA: 0x009FF824 File Offset: 0x009FDA24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3E81CDA5C(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3E81CDA5C_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3E81CDA5C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3E81CDA5C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3E81CDA5C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3E81CDA5C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B66D RID: 177773 RVA: 0x009FF870 File Offset: 0x009FDA70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3270BFAB2(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3270BFAB2_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3270BFAB2_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3270BFAB2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3270BFAB2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3270BFAB2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B66E RID: 177774 RVA: 0x009FF8BC File Offset: 0x009FDABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3C3480ED0(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3C3480ED0_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3C3480ED0_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3C3480ED0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3C3480ED0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__Added_21071CB943CD992BF8EFD6A3C3480ED0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B66F RID: 177775 RVA: 0x009FF908 File Offset: 0x009FDB08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3812CE0EAD7(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_C.__Removed_DB9F64004F8908FEAD99D3812CE0EAD7_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__Removed_DB9F64004F8908FEAD99D3812CE0EAD7_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__Removed_DB9F64004F8908FEAD99D3812CE0EAD7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__Removed_DB9F64004F8908FEAD99D3812CE0EAD7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__Removed_DB9F64004F8908FEAD99D3812CE0EAD7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B670 RID: 177776 RVA: 0x009FF953 File Offset: 0x009FDB53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_F80496E9471CC89D5179909DCE37EA84()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnFinish_F80496E9471CC89D5179909DCE37EA84_NativeFunctionPtr, null);
		}

		// Token: 0x0602B671 RID: 177777 RVA: 0x009FF967 File Offset: 0x009FDB67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81DB6405D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnTick_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B672 RID: 177778 RVA: 0x009FF97B File Offset: 0x009FDB7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81DB6405D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnCancelled_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B673 RID: 177779 RVA: 0x009FF98F File Offset: 0x009FDB8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81DB6405D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnInterrupted_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B674 RID: 177780 RVA: 0x009FF9A3 File Offset: 0x009FDBA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81DB6405D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnBlendOut_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B675 RID: 177781 RVA: 0x009FF9B7 File Offset: 0x009FDBB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81DB6405D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__OnCompleted_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B676 RID: 177782 RVA: 0x009FF9CB File Offset: 0x009FDBCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B677 RID: 177783 RVA: 0x009FF9DF File Offset: 0x009FDBDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B678 RID: 177784 RVA: 0x009FF9F4 File Offset: 0x009FDBF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B679 RID: 177785 RVA: 0x009FFA3C File Offset: 0x009FDC3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B67A RID: 177786 RVA: 0x009FFA83 File Offset: 0x009FDC83
		protected GA_Super_Sprint_Start_Yanxu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401694C RID: 92492
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu.GA_Super_Sprint_Start_Yanxu_C";

		// Token: 0x0401694D RID: 92493
		private static IntPtr _ClassPtr;

		// Token: 0x0401694E RID: 92494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401694F RID: 92495
		internal new static int __PropertyOffset_1;

		// Token: 0x04016950 RID: 92496
		internal new static int __PropertyOffset_2;

		// Token: 0x04016951 RID: 92497
		internal new static int __PropertyOffset_3;

		// Token: 0x04016952 RID: 92498
		internal static int __PropertyOffset_4;

		// Token: 0x04016953 RID: 92499
		internal static int __PropertyOffset_5;

		// Token: 0x04016954 RID: 92500
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3E81CDA5C_NativeFunctionPtr;

		// Token: 0x04016955 RID: 92501
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3270BFAB2_NativeFunctionPtr;

		// Token: 0x04016956 RID: 92502
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3C3480ED0_NativeFunctionPtr;

		// Token: 0x04016957 RID: 92503
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3812CE0EAD7_NativeFunctionPtr;

		// Token: 0x04016958 RID: 92504
		private static IntPtr __OnFinish_F80496E9471CC89D5179909DCE37EA84_NativeFunctionPtr;

		// Token: 0x04016959 RID: 92505
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr;

		// Token: 0x0401695A RID: 92506
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr;

		// Token: 0x0401695B RID: 92507
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr;

		// Token: 0x0401695C RID: 92508
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr;

		// Token: 0x0401695D RID: 92509
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81DB6405D5_NativeFunctionPtr;

		// Token: 0x0401695E RID: 92510
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401695F RID: 92511
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A515 RID: 42261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3E81CDA5C_FunctionParams
		{
			// Token: 0x04032383 RID: 205699
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A516 RID: 42262
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3270BFAB2_FunctionParams
		{
			// Token: 0x04032384 RID: 205700
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A517 RID: 42263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3C3480ED0_FunctionParams
		{
			// Token: 0x04032385 RID: 205701
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A518 RID: 42264
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3812CE0EAD7_FunctionParams
		{
			// Token: 0x04032386 RID: 205702
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A519 RID: 42265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032387 RID: 205703
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
