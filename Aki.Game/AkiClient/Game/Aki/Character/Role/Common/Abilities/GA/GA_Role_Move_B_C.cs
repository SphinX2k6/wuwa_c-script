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
	// Token: 0x0200415C RID: 16732
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B.GA_Role_Move_B_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_Move_B_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B35C RID: 176988 RVA: 0x009F9185 File Offset: 0x009F7385
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Move_B_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B.GA_Role_Move_B_C");
			}
			return GA_Role_Move_B_C._ClassPtr;
		}

		// Token: 0x0602B35D RID: 176989 RVA: 0x009F91AC File Offset: 0x009F73AC
		public GA_Role_Move_B_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_B_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B35E RID: 176990 RVA: 0x009F91D4 File Offset: 0x009F73D4
		[NullableContext(1)]
		public GA_Role_Move_B_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_B_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B35F RID: 176991 RVA: 0x009F9208 File Offset: 0x009F7408
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B360 RID: 176992 RVA: 0x009F92CC File Offset: 0x009F74CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(GA_Role_Move_B_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_B_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B361 RID: 176993 RVA: 0x009F9390 File Offset: 0x009F7590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81AEFEF802()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__OnTick_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr, null);
		}

		// Token: 0x0602B362 RID: 176994 RVA: 0x009F93A4 File Offset: 0x009F75A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81AEFEF802()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__OnCancelled_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr, null);
		}

		// Token: 0x0602B363 RID: 176995 RVA: 0x009F93B8 File Offset: 0x009F75B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81AEFEF802()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__OnInterrupted_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr, null);
		}

		// Token: 0x0602B364 RID: 176996 RVA: 0x009F93CC File Offset: 0x009F75CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81AEFEF802()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__OnBlendOut_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr, null);
		}

		// Token: 0x0602B365 RID: 176997 RVA: 0x009F93E0 File Offset: 0x009F75E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81AEFEF802()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__OnCompleted_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr, null);
		}

		// Token: 0x0602B366 RID: 176998 RVA: 0x009F93F4 File Offset: 0x009F75F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B367 RID: 176999 RVA: 0x009F9408 File Offset: 0x009F7608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B368 RID: 177000 RVA: 0x009F9420 File Offset: 0x009F7620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B369 RID: 177001 RVA: 0x009F9468 File Offset: 0x009F7668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_B_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B36A RID: 177002 RVA: 0x009F94AF File Offset: 0x009F76AF
		protected GA_Role_Move_B_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401672D RID: 91949
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B.GA_Role_Move_B_C";

		// Token: 0x0401672E RID: 91950
		private static IntPtr _ClassPtr;

		// Token: 0x0401672F RID: 91951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016730 RID: 91952
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x04016731 RID: 91953
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr;

		// Token: 0x04016732 RID: 91954
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr;

		// Token: 0x04016733 RID: 91955
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr;

		// Token: 0x04016734 RID: 91956
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr;

		// Token: 0x04016735 RID: 91957
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81AEFEF802_NativeFunctionPtr;

		// Token: 0x04016736 RID: 91958
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016737 RID: 91959
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4A4 RID: 42148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x04032302 RID: 205570
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x04032303 RID: 205571
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x04032304 RID: 205572
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A4A5 RID: 42149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032305 RID: 205573
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
