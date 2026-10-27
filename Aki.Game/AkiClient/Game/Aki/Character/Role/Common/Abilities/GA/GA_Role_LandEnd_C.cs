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
	// Token: 0x0200415A RID: 16730
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd.GA_Role_LandEnd_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_LandEnd_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B33D RID: 176957 RVA: 0x009F8CF4 File Offset: 0x009F6EF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_LandEnd_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd.GA_Role_LandEnd_C");
			}
			return GA_Role_LandEnd_C._ClassPtr;
		}

		// Token: 0x0602B33E RID: 176958 RVA: 0x009F8D18 File Offset: 0x009F6F18
		public GA_Role_LandEnd_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_LandEnd_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B33F RID: 176959 RVA: 0x009F8D40 File Offset: 0x009F6F40
		[NullableContext(1)]
		public GA_Role_LandEnd_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_LandEnd_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B340 RID: 176960 RVA: 0x009F8D73 File Offset: 0x009F6F73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81A71A0E06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__OnTick_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B341 RID: 176961 RVA: 0x009F8D87 File Offset: 0x009F6F87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81A71A0E06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__OnCancelled_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B342 RID: 176962 RVA: 0x009F8D9B File Offset: 0x009F6F9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81A71A0E06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__OnInterrupted_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B343 RID: 176963 RVA: 0x009F8DAF File Offset: 0x009F6FAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81A71A0E06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__OnBlendOut_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B344 RID: 176964 RVA: 0x009F8DC3 File Offset: 0x009F6FC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81A71A0E06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__OnCompleted_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B345 RID: 176965 RVA: 0x009F8DD8 File Offset: 0x009F6FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_9E901F22482A6DDEB0D80EA7BE048B55(in FGameplayTag Tag)
		{
			GA_Role_LandEnd_C.__Added_9E901F22482A6DDEB0D80EA7BE048B55_FunctionParams* ptr = stackalloc GA_Role_LandEnd_C.__Added_9E901F22482A6DDEB0D80EA7BE048B55_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_LandEnd_C.__Added_9E901F22482A6DDEB0D80EA7BE048B55_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_C.__Added_9E901F22482A6DDEB0D80EA7BE048B55_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__Added_9E901F22482A6DDEB0D80EA7BE048B55_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B346 RID: 176966 RVA: 0x009F8E24 File Offset: 0x009F7024
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_9B3A4556409D48FAB54BE1AE6B3F1479(in FGameplayTag Tag)
		{
			GA_Role_LandEnd_C.__Added_9B3A4556409D48FAB54BE1AE6B3F1479_FunctionParams* ptr = stackalloc GA_Role_LandEnd_C.__Added_9B3A4556409D48FAB54BE1AE6B3F1479_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_LandEnd_C.__Added_9B3A4556409D48FAB54BE1AE6B3F1479_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_C.__Added_9B3A4556409D48FAB54BE1AE6B3F1479_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__Added_9B3A4556409D48FAB54BE1AE6B3F1479_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B347 RID: 176967 RVA: 0x009F8E70 File Offset: 0x009F7070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B348 RID: 176968 RVA: 0x009F8EB8 File Offset: 0x009F70B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_LandEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_LandEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B349 RID: 176969 RVA: 0x009F8EFF File Offset: 0x009F70FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B34A RID: 176970 RVA: 0x009F8F13 File Offset: 0x009F7113
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_LandEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B34B RID: 176971 RVA: 0x009F8F28 File Offset: 0x009F7128
		protected GA_Role_LandEnd_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016714 RID: 91924
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd.GA_Role_LandEnd_C";

		// Token: 0x04016715 RID: 91925
		private static IntPtr _ClassPtr;

		// Token: 0x04016716 RID: 91926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016717 RID: 91927
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr;

		// Token: 0x04016718 RID: 91928
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr;

		// Token: 0x04016719 RID: 91929
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr;

		// Token: 0x0401671A RID: 91930
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr;

		// Token: 0x0401671B RID: 91931
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81A71A0E06_NativeFunctionPtr;

		// Token: 0x0401671C RID: 91932
		private static IntPtr __Added_9E901F22482A6DDEB0D80EA7BE048B55_NativeFunctionPtr;

		// Token: 0x0401671D RID: 91933
		private static IntPtr __Added_9B3A4556409D48FAB54BE1AE6B3F1479_NativeFunctionPtr;

		// Token: 0x0401671E RID: 91934
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401671F RID: 91935
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A49E RID: 42142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_9E901F22482A6DDEB0D80EA7BE048B55_FunctionParams
		{
			// Token: 0x040322FC RID: 205564
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A49F RID: 42143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_9B3A4556409D48FAB54BE1AE6B3F1479_FunctionParams
		{
			// Token: 0x040322FD RID: 205565
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4A0 RID: 42144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322FE RID: 205566
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
