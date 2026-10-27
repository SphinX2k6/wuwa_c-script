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
	// Token: 0x0200417C RID: 16764
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu_QQ.GA_Super_Sprint_Start_Yanxu_QQ_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_Yanxu_QQ_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B67B RID: 177787 RVA: 0x009FFA8C File Offset: 0x009FDC8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_Yanxu_QQ_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu_QQ.GA_Super_Sprint_Start_Yanxu_QQ_C");
			}
			return GA_Super_Sprint_Start_Yanxu_QQ_C._ClassPtr;
		}

		// Token: 0x0602B67C RID: 177788 RVA: 0x009FFAB0 File Offset: 0x009FDCB0
		public GA_Super_Sprint_Start_Yanxu_QQ_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_Yanxu_QQ_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B67D RID: 177789 RVA: 0x009FFAD8 File Offset: 0x009FDCD8
		[NullableContext(1)]
		public GA_Super_Sprint_Start_Yanxu_QQ_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_Yanxu_QQ_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B10 RID: 27408
		// (get) Token: 0x0602B67E RID: 177790 RVA: 0x009FFB0B File Offset: 0x009FDD0B
		// (set) Token: 0x0602B67F RID: 177791 RVA: 0x009FFB1B File Offset: 0x009FDD1B
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B11 RID: 27409
		// (get) Token: 0x0602B680 RID: 177792 RVA: 0x009FFB2C File Offset: 0x009FDD2C
		// (set) Token: 0x0602B681 RID: 177793 RVA: 0x009FFB3C File Offset: 0x009FDD3C
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B12 RID: 27410
		// (get) Token: 0x0602B682 RID: 177794 RVA: 0x009FFB4D File Offset: 0x009FDD4D
		// (set) Token: 0x0602B683 RID: 177795 RVA: 0x009FFB5D File Offset: 0x009FDD5D
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B13 RID: 27411
		// (get) Token: 0x0602B684 RID: 177796 RVA: 0x009FFB6E File Offset: 0x009FDD6E
		// (set) Token: 0x0602B685 RID: 177797 RVA: 0x009FFB7E File Offset: 0x009FDD7E
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B14 RID: 27412
		// (get) Token: 0x0602B686 RID: 177798 RVA: 0x009FFB8F File Offset: 0x009FDD8F
		// (set) Token: 0x0602B687 RID: 177799 RVA: 0x009FFB9F File Offset: 0x009FDD9F
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_Yanxu_QQ_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B688 RID: 177800 RVA: 0x009FFBB0 File Offset: 0x009FDDB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A325678CC2(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A325678CC2_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A325678CC2_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A325678CC2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A325678CC2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A325678CC2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B689 RID: 177801 RVA: 0x009FFBFC File Offset: 0x009FDDFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A349AF4DC7(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A349AF4DC7_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A349AF4DC7_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A349AF4DC7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A349AF4DC7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A349AF4DC7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B68A RID: 177802 RVA: 0x009FFC48 File Offset: 0x009FDE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A344D798AD(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A344D798AD_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A344D798AD_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A344D798AD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A344D798AD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__Added_21071CB943CD992BF8EFD6A344D798AD_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B68B RID: 177803 RVA: 0x009FFC94 File Offset: 0x009FDE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381CE1D5F8F(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__Removed_DB9F64004F8908FEAD99D381CE1D5F8F_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__Removed_DB9F64004F8908FEAD99D381CE1D5F8F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__Removed_DB9F64004F8908FEAD99D381CE1D5F8F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__Removed_DB9F64004F8908FEAD99D381CE1D5F8F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__Removed_DB9F64004F8908FEAD99D381CE1D5F8F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B68C RID: 177804 RVA: 0x009FFCDF File Offset: 0x009FDEDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_7FB741F8402D3695D88D6FB34C839BBC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnFinish_7FB741F8402D3695D88D6FB34C839BBC_NativeFunctionPtr, null);
		}

		// Token: 0x0602B68D RID: 177805 RVA: 0x009FFCF3 File Offset: 0x009FDEF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8194D1A5B9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnTick_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B68E RID: 177806 RVA: 0x009FFD07 File Offset: 0x009FDF07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8194D1A5B9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnCancelled_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B68F RID: 177807 RVA: 0x009FFD1B File Offset: 0x009FDF1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8194D1A5B9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnInterrupted_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B690 RID: 177808 RVA: 0x009FFD2F File Offset: 0x009FDF2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8194D1A5B9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnBlendOut_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B691 RID: 177809 RVA: 0x009FFD43 File Offset: 0x009FDF43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8194D1A5B9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__OnCompleted_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B692 RID: 177810 RVA: 0x009FFD57 File Offset: 0x009FDF57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B693 RID: 177811 RVA: 0x009FFD6B File Offset: 0x009FDF6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B694 RID: 177812 RVA: 0x009FFD80 File Offset: 0x009FDF80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B695 RID: 177813 RVA: 0x009FFDC8 File Offset: 0x009FDFC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_Yanxu_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B696 RID: 177814 RVA: 0x009FFE0F File Offset: 0x009FE00F
		protected GA_Super_Sprint_Start_Yanxu_QQ_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016960 RID: 92512
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_Yanxu_QQ.GA_Super_Sprint_Start_Yanxu_QQ_C";

		// Token: 0x04016961 RID: 92513
		private static IntPtr _ClassPtr;

		// Token: 0x04016962 RID: 92514
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016963 RID: 92515
		internal new static int __PropertyOffset_1;

		// Token: 0x04016964 RID: 92516
		internal new static int __PropertyOffset_2;

		// Token: 0x04016965 RID: 92517
		internal new static int __PropertyOffset_3;

		// Token: 0x04016966 RID: 92518
		internal static int __PropertyOffset_4;

		// Token: 0x04016967 RID: 92519
		internal static int __PropertyOffset_5;

		// Token: 0x04016968 RID: 92520
		private static IntPtr __Added_21071CB943CD992BF8EFD6A325678CC2_NativeFunctionPtr;

		// Token: 0x04016969 RID: 92521
		private static IntPtr __Added_21071CB943CD992BF8EFD6A349AF4DC7_NativeFunctionPtr;

		// Token: 0x0401696A RID: 92522
		private static IntPtr __Added_21071CB943CD992BF8EFD6A344D798AD_NativeFunctionPtr;

		// Token: 0x0401696B RID: 92523
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381CE1D5F8F_NativeFunctionPtr;

		// Token: 0x0401696C RID: 92524
		private static IntPtr __OnFinish_7FB741F8402D3695D88D6FB34C839BBC_NativeFunctionPtr;

		// Token: 0x0401696D RID: 92525
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr;

		// Token: 0x0401696E RID: 92526
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr;

		// Token: 0x0401696F RID: 92527
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr;

		// Token: 0x04016970 RID: 92528
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr;

		// Token: 0x04016971 RID: 92529
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8194D1A5B9_NativeFunctionPtr;

		// Token: 0x04016972 RID: 92530
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016973 RID: 92531
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A51A RID: 42266
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A325678CC2_FunctionParams
		{
			// Token: 0x04032388 RID: 205704
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A51B RID: 42267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A349AF4DC7_FunctionParams
		{
			// Token: 0x04032389 RID: 205705
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A51C RID: 42268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A344D798AD_FunctionParams
		{
			// Token: 0x0403238A RID: 205706
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A51D RID: 42269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381CE1D5F8F_FunctionParams
		{
			// Token: 0x0403238B RID: 205707
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A51E RID: 42270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403238C RID: 205708
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
