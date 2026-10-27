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
	// Token: 0x0200415E RID: 16734
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F.GA_Role_Move_F_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Role_Move_F_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B37B RID: 177019 RVA: 0x009F9830 File Offset: 0x009F7A30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Move_F_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F.GA_Role_Move_F_C");
			}
			return GA_Role_Move_F_C._ClassPtr;
		}

		// Token: 0x0602B37C RID: 177020 RVA: 0x009F9854 File Offset: 0x009F7A54
		public GA_Role_Move_F_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_F_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B37D RID: 177021 RVA: 0x009F987C File Offset: 0x009F7A7C
		[NullableContext(1)]
		public GA_Role_Move_F_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Move_F_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A81 RID: 27265
		// (get) Token: 0x0602B37E RID: 177022 RVA: 0x009F98AF File Offset: 0x009F7AAF
		// (set) Token: 0x0602B37F RID: 177023 RVA: 0x009F98C3 File Offset: 0x009F7AC3
		[Nullable(2)]
		public unsafe UBaseAbilitySystemComponent AbilitySystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBaseAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Move_F_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Move_F_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B380 RID: 177024 RVA: 0x009F98D8 File Offset: 0x009F7AD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B381 RID: 177025 RVA: 0x009F999C File Offset: 0x009F7B9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Move_F_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Move_F_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B382 RID: 177026 RVA: 0x009F9A60 File Offset: 0x009F7C60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81CC27EAD8()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__OnTick_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr, null);
		}

		// Token: 0x0602B383 RID: 177027 RVA: 0x009F9A74 File Offset: 0x009F7C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81CC27EAD8()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__OnCancelled_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr, null);
		}

		// Token: 0x0602B384 RID: 177028 RVA: 0x009F9A88 File Offset: 0x009F7C88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81CC27EAD8()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__OnInterrupted_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr, null);
		}

		// Token: 0x0602B385 RID: 177029 RVA: 0x009F9A9C File Offset: 0x009F7C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81CC27EAD8()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__OnBlendOut_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr, null);
		}

		// Token: 0x0602B386 RID: 177030 RVA: 0x009F9AB0 File Offset: 0x009F7CB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81CC27EAD8()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__OnCompleted_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr, null);
		}

		// Token: 0x0602B387 RID: 177031 RVA: 0x009F9AC4 File Offset: 0x009F7CC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_8AA179764AE301668C90EDB6D5BAFF54(in FGameplayTag Tag)
		{
			GA_Role_Move_F_C.__Added_8AA179764AE301668C90EDB6D5BAFF54_FunctionParams* ptr = stackalloc GA_Role_Move_F_C.__Added_8AA179764AE301668C90EDB6D5BAFF54_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Move_F_C.__Added_8AA179764AE301668C90EDB6D5BAFF54_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_C.__Added_8AA179764AE301668C90EDB6D5BAFF54_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__Added_8AA179764AE301668C90EDB6D5BAFF54_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B388 RID: 177032 RVA: 0x009F9B0F File Offset: 0x009F7D0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B389 RID: 177033 RVA: 0x009F9B23 File Offset: 0x009F7D23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B38A RID: 177034 RVA: 0x009F9B38 File Offset: 0x009F7D38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B38B RID: 177035 RVA: 0x009F9B80 File Offset: 0x009F7D80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Move_F_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Move_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Move_F_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B38C RID: 177036 RVA: 0x009F9BC7 File Offset: 0x009F7DC7
		protected GA_Role_Move_F_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016744 RID: 91972
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Move_F.GA_Role_Move_F_C";

		// Token: 0x04016745 RID: 91973
		private static IntPtr _ClassPtr;

		// Token: 0x04016746 RID: 91974
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016747 RID: 91975
		internal new static int __PropertyOffset_1;

		// Token: 0x04016748 RID: 91976
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x04016749 RID: 91977
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr;

		// Token: 0x0401674A RID: 91978
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr;

		// Token: 0x0401674B RID: 91979
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr;

		// Token: 0x0401674C RID: 91980
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr;

		// Token: 0x0401674D RID: 91981
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81CC27EAD8_NativeFunctionPtr;

		// Token: 0x0401674E RID: 91982
		private static IntPtr __Added_8AA179764AE301668C90EDB6D5BAFF54_NativeFunctionPtr;

		// Token: 0x0401674F RID: 91983
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016750 RID: 91984
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4A9 RID: 42153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x0403230B RID: 205579
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x0403230C RID: 205580
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x0403230D RID: 205581
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A4AA RID: 42154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_8AA179764AE301668C90EDB6D5BAFF54_FunctionParams
		{
			// Token: 0x0403230E RID: 205582
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4AB RID: 42155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403230F RID: 205583
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
