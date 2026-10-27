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
	// Token: 0x02004062 RID: 16482
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Balance.GA_Motor_Balance_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Motor_Balance_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A561 RID: 173409 RVA: 0x009DD5BD File Offset: 0x009DB7BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Balance_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Balance.GA_Motor_Balance_C");
			}
			return GA_Motor_Balance_C._ClassPtr;
		}

		// Token: 0x0602A562 RID: 173410 RVA: 0x009DD5E4 File Offset: 0x009DB7E4
		public GA_Motor_Balance_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Balance_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A563 RID: 173411 RVA: 0x009DD60C File Offset: 0x009DB80C
		[NullableContext(1)]
		public GA_Motor_Balance_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Balance_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x0602A564 RID: 173412 RVA: 0x009DD63F File Offset: 0x009DB83F
		// (set) Token: 0x0602A565 RID: 173413 RVA: 0x009DD64F File Offset: 0x009DB84F
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Balance_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Balance_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067CB RID: 26571
		// (get) Token: 0x0602A566 RID: 173414 RVA: 0x009DD660 File Offset: 0x009DB860
		// (set) Token: 0x0602A567 RID: 173415 RVA: 0x009DD674 File Offset: 0x009DB874
		[Nullable(2)]
		public unsafe TsBaseCharacter 驾驶员
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Balance_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Balance_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602A568 RID: 173416 RVA: 0x009DD689 File Offset: 0x009DB889
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BE8EFD450()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnTick_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr, null);
		}

		// Token: 0x0602A569 RID: 173417 RVA: 0x009DD69D File Offset: 0x009DB89D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BE8EFD450()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56A RID: 173418 RVA: 0x009DD6B1 File Offset: 0x009DB8B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BE8EFD450()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56B RID: 173419 RVA: 0x009DD6C5 File Offset: 0x009DB8C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BE8EFD450()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56C RID: 173420 RVA: 0x009DD6D9 File Offset: 0x009DB8D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BE8EFD450()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56D RID: 173421 RVA: 0x009DD6ED File Offset: 0x009DB8ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B259AAA5B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnTick_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56E RID: 173422 RVA: 0x009DD701 File Offset: 0x009DB901
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B259AAA5B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A56F RID: 173423 RVA: 0x009DD715 File Offset: 0x009DB915
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B259AAA5B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A570 RID: 173424 RVA: 0x009DD729 File Offset: 0x009DB929
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B259AAA5B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A571 RID: 173425 RVA: 0x009DD73D File Offset: 0x009DB93D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B259AAA5B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A572 RID: 173426 RVA: 0x009DD754 File Offset: 0x009DB954
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381ED22EBBE(in FGameplayTag Tag)
		{
			GA_Motor_Balance_C.__Removed_DB9F64004F8908FEAD99D381ED22EBBE_FunctionParams* ptr = stackalloc GA_Motor_Balance_C.__Removed_DB9F64004F8908FEAD99D381ED22EBBE_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_Balance_C.__Removed_DB9F64004F8908FEAD99D381ED22EBBE_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Balance_C.__Removed_DB9F64004F8908FEAD99D381ED22EBBE_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__Removed_DB9F64004F8908FEAD99D381ED22EBBE_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A573 RID: 173427 RVA: 0x009DD79F File Offset: 0x009DB99F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A574 RID: 173428 RVA: 0x009DD7B3 File Offset: 0x009DB9B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Balance_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A575 RID: 173429 RVA: 0x009DD7C8 File Offset: 0x009DB9C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Balance_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Balance_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A576 RID: 173430 RVA: 0x009DD810 File Offset: 0x009DBA10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Balance_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Balance_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Balance_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A577 RID: 173431 RVA: 0x009DD857 File Offset: 0x009DBA57
		protected GA_Motor_Balance_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D84 RID: 89476
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Balance.GA_Motor_Balance_C";

		// Token: 0x04015D85 RID: 89477
		private static IntPtr _ClassPtr;

		// Token: 0x04015D86 RID: 89478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D87 RID: 89479
		internal new static int __PropertyOffset_1;

		// Token: 0x04015D88 RID: 89480
		internal new static int __PropertyOffset_2;

		// Token: 0x04015D89 RID: 89481
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr;

		// Token: 0x04015D8A RID: 89482
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr;

		// Token: 0x04015D8B RID: 89483
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr;

		// Token: 0x04015D8C RID: 89484
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr;

		// Token: 0x04015D8D RID: 89485
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BE8EFD450_NativeFunctionPtr;

		// Token: 0x04015D8E RID: 89486
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr;

		// Token: 0x04015D8F RID: 89487
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr;

		// Token: 0x04015D90 RID: 89488
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr;

		// Token: 0x04015D91 RID: 89489
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr;

		// Token: 0x04015D92 RID: 89490
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B259AAA5B_NativeFunctionPtr;

		// Token: 0x04015D93 RID: 89491
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381ED22EBBE_NativeFunctionPtr;

		// Token: 0x04015D94 RID: 89492
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015D95 RID: 89493
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A379 RID: 41849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381ED22EBBE_FunctionParams
		{
			// Token: 0x0403215D RID: 205149
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A37A RID: 41850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403215E RID: 205150
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
