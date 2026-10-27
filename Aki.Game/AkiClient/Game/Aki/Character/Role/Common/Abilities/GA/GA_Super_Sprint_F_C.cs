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
	// Token: 0x02004170 RID: 16752
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_F.GA_Super_Sprint_F_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1513)]
	public class GA_Super_Sprint_F_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B556 RID: 177494 RVA: 0x009FD408 File Offset: 0x009FB608
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_F_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_F.GA_Super_Sprint_F_C");
			}
			return GA_Super_Sprint_F_C._ClassPtr;
		}

		// Token: 0x0602B557 RID: 177495 RVA: 0x009FD42C File Offset: 0x009FB62C
		public GA_Super_Sprint_F_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_F_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B558 RID: 177496 RVA: 0x009FD454 File Offset: 0x009FB654
		[NullableContext(1)]
		public GA_Super_Sprint_F_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_F_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AE2 RID: 27362
		// (get) Token: 0x0602B559 RID: 177497 RVA: 0x009FD487 File Offset: 0x009FB687
		// (set) Token: 0x0602B55A RID: 177498 RVA: 0x009FD497 File Offset: 0x009FB697
		public unsafe bool 刷新子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_F_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_F_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B55B RID: 177499 RVA: 0x009FD4A8 File Offset: 0x009FB6A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8128017D05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__OnTick_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr, null);
		}

		// Token: 0x0602B55C RID: 177500 RVA: 0x009FD4BC File Offset: 0x009FB6BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8128017D05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__OnCancelled_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr, null);
		}

		// Token: 0x0602B55D RID: 177501 RVA: 0x009FD4D0 File Offset: 0x009FB6D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8128017D05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__OnInterrupted_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr, null);
		}

		// Token: 0x0602B55E RID: 177502 RVA: 0x009FD4E4 File Offset: 0x009FB6E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8128017D05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__OnBlendOut_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr, null);
		}

		// Token: 0x0602B55F RID: 177503 RVA: 0x009FD4F8 File Offset: 0x009FB6F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8128017D05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__OnCompleted_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr, null);
		}

		// Token: 0x0602B560 RID: 177504 RVA: 0x009FD50C File Offset: 0x009FB70C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3E2664B71(in FGameplayTag Tag)
		{
			GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3E2664B71_FunctionParams* ptr = stackalloc GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3E2664B71_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3E2664B71_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3E2664B71_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3E2664B71_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B561 RID: 177505 RVA: 0x009FD558 File Offset: 0x009FB758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3015EDD8F(in FGameplayTag Tag)
		{
			GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3015EDD8F_FunctionParams* ptr = stackalloc GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3015EDD8F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3015EDD8F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3015EDD8F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A3015EDD8F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B562 RID: 177506 RVA: 0x009FD5A4 File Offset: 0x009FB7A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A36D09B45D(in FGameplayTag Tag)
		{
			GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A36D09B45D_FunctionParams* ptr = stackalloc GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A36D09B45D_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A36D09B45D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A36D09B45D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__Added_21071CB943CD992BF8EFD6A36D09B45D_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B563 RID: 177507 RVA: 0x009FD5EF File Offset: 0x009FB7EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B564 RID: 177508 RVA: 0x009FD603 File Offset: 0x009FB803
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_F_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B565 RID: 177509 RVA: 0x009FD618 File Offset: 0x009FB818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B566 RID: 177510 RVA: 0x009FD660 File Offset: 0x009FB860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_F_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B567 RID: 177511 RVA: 0x009FD6A7 File Offset: 0x009FB8A7
		protected GA_Super_Sprint_F_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401688C RID: 92300
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_F.GA_Super_Sprint_F_C";

		// Token: 0x0401688D RID: 92301
		private static IntPtr _ClassPtr;

		// Token: 0x0401688E RID: 92302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401688F RID: 92303
		internal new static int __PropertyOffset_1;

		// Token: 0x04016890 RID: 92304
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr;

		// Token: 0x04016891 RID: 92305
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr;

		// Token: 0x04016892 RID: 92306
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr;

		// Token: 0x04016893 RID: 92307
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr;

		// Token: 0x04016894 RID: 92308
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8128017D05_NativeFunctionPtr;

		// Token: 0x04016895 RID: 92309
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3E2664B71_NativeFunctionPtr;

		// Token: 0x04016896 RID: 92310
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3015EDD8F_NativeFunctionPtr;

		// Token: 0x04016897 RID: 92311
		private static IntPtr __Added_21071CB943CD992BF8EFD6A36D09B45D_NativeFunctionPtr;

		// Token: 0x04016898 RID: 92312
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016899 RID: 92313
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4E3 RID: 42211
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3E2664B71_FunctionParams
		{
			// Token: 0x04032351 RID: 205649
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E4 RID: 42212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3015EDD8F_FunctionParams
		{
			// Token: 0x04032352 RID: 205650
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E5 RID: 42213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A36D09B45D_FunctionParams
		{
			// Token: 0x04032353 RID: 205651
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E6 RID: 42214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032354 RID: 205652
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
