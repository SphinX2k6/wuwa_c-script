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
	// Token: 0x0200415B RID: 16731
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd_Net.GA_Role_LandEnd_Net_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Role_LandEnd_Net_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B34C RID: 176972 RVA: 0x009F8F31 File Offset: 0x009F7131
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_LandEnd_Net_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd_Net.GA_Role_LandEnd_Net_C");
			}
			return GA_Role_LandEnd_Net_C._ClassPtr;
		}

		// Token: 0x0602B34D RID: 176973 RVA: 0x009F8F58 File Offset: 0x009F7158
		public GA_Role_LandEnd_Net_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_LandEnd_Net_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B34E RID: 176974 RVA: 0x009F8F80 File Offset: 0x009F7180
		[NullableContext(1)]
		public GA_Role_LandEnd_Net_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_LandEnd_Net_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B34F RID: 176975 RVA: 0x009F8FB3 File Offset: 0x009F71B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8120D6F4B4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnTick_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B350 RID: 176976 RVA: 0x009F8FC7 File Offset: 0x009F71C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8120D6F4B4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnCancelled_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B351 RID: 176977 RVA: 0x009F8FDB File Offset: 0x009F71DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8120D6F4B4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnInterrupted_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B352 RID: 176978 RVA: 0x009F8FEF File Offset: 0x009F71EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8120D6F4B4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnBlendOut_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B353 RID: 176979 RVA: 0x009F9003 File Offset: 0x009F7203
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8120D6F4B4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnCompleted_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B354 RID: 176980 RVA: 0x009F9018 File Offset: 0x009F7218
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_B7E505E3445443CA4C27F38B7FAAFD98(in FGameplayTag Tag)
		{
			GA_Role_LandEnd_Net_C.__Added_B7E505E3445443CA4C27F38B7FAAFD98_FunctionParams* ptr = stackalloc GA_Role_LandEnd_Net_C.__Added_B7E505E3445443CA4C27F38B7FAAFD98_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_LandEnd_Net_C.__Added_B7E505E3445443CA4C27F38B7FAAFD98_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_Net_C.__Added_B7E505E3445443CA4C27F38B7FAAFD98_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__Added_B7E505E3445443CA4C27F38B7FAAFD98_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B355 RID: 176981 RVA: 0x009F9064 File Offset: 0x009F7264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_CF97F8BF4298CF4D3C76EB9D81A391D8(in FGameplayTag Tag)
		{
			GA_Role_LandEnd_Net_C.__Added_CF97F8BF4298CF4D3C76EB9D81A391D8_FunctionParams* ptr = stackalloc GA_Role_LandEnd_Net_C.__Added_CF97F8BF4298CF4D3C76EB9D81A391D8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_LandEnd_Net_C.__Added_CF97F8BF4298CF4D3C76EB9D81A391D8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_Net_C.__Added_CF97F8BF4298CF4D3C76EB9D81A391D8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__Added_CF97F8BF4298CF4D3C76EB9D81A391D8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B356 RID: 176982 RVA: 0x009F90AF File Offset: 0x009F72AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_60C8757C4F274DFA6A15BFB2BBC51946()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__OnFinish_60C8757C4F274DFA6A15BFB2BBC51946_NativeFunctionPtr, null);
		}

		// Token: 0x0602B357 RID: 176983 RVA: 0x009F90C4 File Offset: 0x009F72C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B358 RID: 176984 RVA: 0x009F910C File Offset: 0x009F730C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_LandEnd_Net_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_LandEnd_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B359 RID: 176985 RVA: 0x009F9153 File Offset: 0x009F7353
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B35A RID: 176986 RVA: 0x009F9167 File Offset: 0x009F7367
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_LandEnd_Net_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B35B RID: 176987 RVA: 0x009F917C File Offset: 0x009F737C
		protected GA_Role_LandEnd_Net_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016720 RID: 91936
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_LandEnd_Net.GA_Role_LandEnd_Net_C";

		// Token: 0x04016721 RID: 91937
		private static IntPtr _ClassPtr;

		// Token: 0x04016722 RID: 91938
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016723 RID: 91939
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr;

		// Token: 0x04016724 RID: 91940
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr;

		// Token: 0x04016725 RID: 91941
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr;

		// Token: 0x04016726 RID: 91942
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr;

		// Token: 0x04016727 RID: 91943
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8120D6F4B4_NativeFunctionPtr;

		// Token: 0x04016728 RID: 91944
		private static IntPtr __Added_B7E505E3445443CA4C27F38B7FAAFD98_NativeFunctionPtr;

		// Token: 0x04016729 RID: 91945
		private static IntPtr __Added_CF97F8BF4298CF4D3C76EB9D81A391D8_NativeFunctionPtr;

		// Token: 0x0401672A RID: 91946
		private static IntPtr __OnFinish_60C8757C4F274DFA6A15BFB2BBC51946_NativeFunctionPtr;

		// Token: 0x0401672B RID: 91947
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401672C RID: 91948
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4A1 RID: 42145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_B7E505E3445443CA4C27F38B7FAAFD98_FunctionParams
		{
			// Token: 0x040322FF RID: 205567
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4A2 RID: 42146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_CF97F8BF4298CF4D3C76EB9D81A391D8_FunctionParams
		{
			// Token: 0x04032300 RID: 205568
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4A3 RID: 42147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032301 RID: 205569
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
