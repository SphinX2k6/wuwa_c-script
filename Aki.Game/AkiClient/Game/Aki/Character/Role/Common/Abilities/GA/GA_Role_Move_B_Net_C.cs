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
	// Token: 0x0200415D RID: 16733
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B_Net.GA_Role_Move_B_Net_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_Move_B_Net_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B36B RID: 177003 RVA: 0x009F94B8 File Offset: 0x009F76B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Move_B_Net_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B_Net.GA_Role_Move_B_Net_C");
			}
			return GA_Role_Move_B_Net_C._ClassPtr;
		}

		// Token: 0x0602B36C RID: 177004 RVA: 0x009F94DC File Offset: 0x009F76DC
		public GA_Role_Move_B_Net_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_B_Net_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B36D RID: 177005 RVA: 0x009F9504 File Offset: 0x009F7704
		[NullableContext(1)]
		public GA_Role_Move_B_Net_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_B_Net_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B36E RID: 177006 RVA: 0x009F9538 File Offset: 0x009F7738
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B36F RID: 177007 RVA: 0x009F95FC File Offset: 0x009F77FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_B_Net_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B370 RID: 177008 RVA: 0x009F96C0 File Offset: 0x009F78C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81A7B032EA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__OnTick_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr, null);
		}

		// Token: 0x0602B371 RID: 177009 RVA: 0x009F96D4 File Offset: 0x009F78D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81A7B032EA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__OnCancelled_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr, null);
		}

		// Token: 0x0602B372 RID: 177010 RVA: 0x009F96E8 File Offset: 0x009F78E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81A7B032EA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__OnInterrupted_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr, null);
		}

		// Token: 0x0602B373 RID: 177011 RVA: 0x009F96FC File Offset: 0x009F78FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81A7B032EA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__OnBlendOut_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr, null);
		}

		// Token: 0x0602B374 RID: 177012 RVA: 0x009F9710 File Offset: 0x009F7910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81A7B032EA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__OnCompleted_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr, null);
		}

		// Token: 0x0602B375 RID: 177013 RVA: 0x009F9724 File Offset: 0x009F7924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A308FB4881(in FGameplayTag Tag)
		{
			GA_Role_Move_B_Net_C.__Added_21071CB943CD992BF8EFD6A308FB4881_FunctionParams* ptr = stackalloc GA_Role_Move_B_Net_C.__Added_21071CB943CD992BF8EFD6A308FB4881_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Move_B_Net_C.__Added_21071CB943CD992BF8EFD6A308FB4881_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_Net_C.__Added_21071CB943CD992BF8EFD6A308FB4881_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__Added_21071CB943CD992BF8EFD6A308FB4881_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B376 RID: 177014 RVA: 0x009F976F File Offset: 0x009F796F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B377 RID: 177015 RVA: 0x009F9783 File Offset: 0x009F7983
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B378 RID: 177016 RVA: 0x009F9798 File Offset: 0x009F7998
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B379 RID: 177017 RVA: 0x009F97E0 File Offset: 0x009F79E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_B_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_B_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_B_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B37A RID: 177018 RVA: 0x009F9827 File Offset: 0x009F7A27
		protected GA_Role_Move_B_Net_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016738 RID: 91960
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_B_Net.GA_Role_Move_B_Net_C";

		// Token: 0x04016739 RID: 91961
		private static IntPtr _ClassPtr;

		// Token: 0x0401673A RID: 91962
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401673B RID: 91963
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x0401673C RID: 91964
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr;

		// Token: 0x0401673D RID: 91965
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr;

		// Token: 0x0401673E RID: 91966
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr;

		// Token: 0x0401673F RID: 91967
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr;

		// Token: 0x04016740 RID: 91968
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81A7B032EA_NativeFunctionPtr;

		// Token: 0x04016741 RID: 91969
		private static IntPtr __Added_21071CB943CD992BF8EFD6A308FB4881_NativeFunctionPtr;

		// Token: 0x04016742 RID: 91970
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016743 RID: 91971
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4A6 RID: 42150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x04032306 RID: 205574
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x04032307 RID: 205575
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x04032308 RID: 205576
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A4A7 RID: 42151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A308FB4881_FunctionParams
		{
			// Token: 0x04032309 RID: 205577
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4A8 RID: 42152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403230A RID: 205578
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
