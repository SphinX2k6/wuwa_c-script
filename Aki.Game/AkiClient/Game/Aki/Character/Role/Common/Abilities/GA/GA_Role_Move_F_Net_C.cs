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
	// Token: 0x0200415F RID: 16735
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F_Net.GA_Role_Move_F_Net_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Role_Move_F_Net_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B38D RID: 177037 RVA: 0x009F9BD0 File Offset: 0x009F7DD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Move_F_Net_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F_Net.GA_Role_Move_F_Net_C");
			}
			return GA_Role_Move_F_Net_C._ClassPtr;
		}

		// Token: 0x0602B38E RID: 177038 RVA: 0x009F9BF4 File Offset: 0x009F7DF4
		public GA_Role_Move_F_Net_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_F_Net_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B38F RID: 177039 RVA: 0x009F9C1C File Offset: 0x009F7E1C
		[NullableContext(1)]
		public GA_Role_Move_F_Net_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_F_Net_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A82 RID: 27266
		// (get) Token: 0x0602B390 RID: 177040 RVA: 0x009F9C4F File Offset: 0x009F7E4F
		// (set) Token: 0x0602B391 RID: 177041 RVA: 0x009F9C63 File Offset: 0x009F7E63
		[Nullable(2)]
		public unsafe UBaseAbilitySystemComponent AbilitySystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBaseAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Move_F_Net_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Move_F_Net_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B392 RID: 177042 RVA: 0x009F9C78 File Offset: 0x009F7E78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B393 RID: 177043 RVA: 0x009F9D3C File Offset: 0x009F7F3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_F_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B394 RID: 177044 RVA: 0x009F9E00 File Offset: 0x009F8000
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81E2803D47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__OnTick_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B395 RID: 177045 RVA: 0x009F9E14 File Offset: 0x009F8014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81E2803D47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__OnCancelled_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B396 RID: 177046 RVA: 0x009F9E28 File Offset: 0x009F8028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81E2803D47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__OnInterrupted_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B397 RID: 177047 RVA: 0x009F9E3C File Offset: 0x009F803C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81E2803D47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__OnBlendOut_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B398 RID: 177048 RVA: 0x009F9E50 File Offset: 0x009F8050
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81E2803D47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__OnCompleted_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B399 RID: 177049 RVA: 0x009F9E64 File Offset: 0x009F8064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3DAFC9936(in FGameplayTag Tag)
		{
			GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A3DAFC9936_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A3DAFC9936_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A3DAFC9936_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A3DAFC9936_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A3DAFC9936_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B39A RID: 177050 RVA: 0x009F9EB0 File Offset: 0x009F80B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A382AFCAE1(in FGameplayTag Tag)
		{
			GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A382AFCAE1_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A382AFCAE1_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A382AFCAE1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A382AFCAE1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__Added_21071CB943CD992BF8EFD6A382AFCAE1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B39B RID: 177051 RVA: 0x009F9EFB File Offset: 0x009F80FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B39C RID: 177052 RVA: 0x009F9F0F File Offset: 0x009F810F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B39D RID: 177053 RVA: 0x009F9F24 File Offset: 0x009F8124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B39E RID: 177054 RVA: 0x009F9F6C File Offset: 0x009F816C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_F_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B39F RID: 177055 RVA: 0x009F9FB3 File Offset: 0x009F81B3
		protected GA_Role_Move_F_Net_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016751 RID: 91985
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F_Net.GA_Role_Move_F_Net_C";

		// Token: 0x04016752 RID: 91986
		private static IntPtr _ClassPtr;

		// Token: 0x04016753 RID: 91987
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016754 RID: 91988
		internal new static int __PropertyOffset_1;

		// Token: 0x04016755 RID: 91989
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x04016756 RID: 91990
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr;

		// Token: 0x04016757 RID: 91991
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr;

		// Token: 0x04016758 RID: 91992
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr;

		// Token: 0x04016759 RID: 91993
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr;

		// Token: 0x0401675A RID: 91994
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81E2803D47_NativeFunctionPtr;

		// Token: 0x0401675B RID: 91995
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3DAFC9936_NativeFunctionPtr;

		// Token: 0x0401675C RID: 91996
		private static IntPtr __Added_21071CB943CD992BF8EFD6A382AFCAE1_NativeFunctionPtr;

		// Token: 0x0401675D RID: 91997
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401675E RID: 91998
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4AC RID: 42156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x04032310 RID: 205584
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x04032311 RID: 205585
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x04032312 RID: 205586
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A4AD RID: 42157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3DAFC9936_FunctionParams
		{
			// Token: 0x04032313 RID: 205587
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4AE RID: 42158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A382AFCAE1_FunctionParams
		{
			// Token: 0x04032314 RID: 205588
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4AF RID: 42159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032315 RID: 205589
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
