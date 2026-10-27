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
	// Token: 0x02004083 RID: 16515
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_RailMove_Slide.GA_Motor_RailMove_Slide_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Motor_RailMove_Slide_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A82B RID: 174123 RVA: 0x009E2B3C File Offset: 0x009E0D3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_RailMove_Slide_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_RailMove_Slide.GA_Motor_RailMove_Slide_C");
			}
			return GA_Motor_RailMove_Slide_C._ClassPtr;
		}

		// Token: 0x0602A82C RID: 174124 RVA: 0x009E2B60 File Offset: 0x009E0D60
		public GA_Motor_RailMove_Slide_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_RailMove_Slide_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A82D RID: 174125 RVA: 0x009E2B88 File Offset: 0x009E0D88
		[NullableContext(1)]
		public GA_Motor_RailMove_Slide_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_RailMove_Slide_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A82E RID: 174126 RVA: 0x009E2BBC File Offset: 0x009E0DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3818F539AC4(in FGameplayTag Tag)
		{
			GA_Motor_RailMove_Slide_C.__Removed_DB9F64004F8908FEAD99D3818F539AC4_FunctionParams* ptr = stackalloc GA_Motor_RailMove_Slide_C.__Removed_DB9F64004F8908FEAD99D3818F539AC4_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_RailMove_Slide_C.__Removed_DB9F64004F8908FEAD99D3818F539AC4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_RailMove_Slide_C.__Removed_DB9F64004F8908FEAD99D3818F539AC4_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_RailMove_Slide_C.__Removed_DB9F64004F8908FEAD99D3818F539AC4_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A82F RID: 174127 RVA: 0x009E2C07 File Offset: 0x009E0E07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_RailMove_Slide_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A830 RID: 174128 RVA: 0x009E2C1B File Offset: 0x009E0E1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_RailMove_Slide_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A831 RID: 174129 RVA: 0x009E2C30 File Offset: 0x009E0E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A832 RID: 174130 RVA: 0x009E2C78 File Offset: 0x009E0E78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_RailMove_Slide_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A833 RID: 174131 RVA: 0x009E2CBF File Offset: 0x009E0EBF
		protected GA_Motor_RailMove_Slide_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F84 RID: 89988
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_RailMove_Slide.GA_Motor_RailMove_Slide_C";

		// Token: 0x04015F85 RID: 89989
		private static IntPtr _ClassPtr;

		// Token: 0x04015F86 RID: 89990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F87 RID: 89991
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3818F539AC4_NativeFunctionPtr;

		// Token: 0x04015F88 RID: 89992
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F89 RID: 89993
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3BB RID: 41915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3818F539AC4_FunctionParams
		{
			// Token: 0x040321A8 RID: 205224
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3BC RID: 41916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A9 RID: 205225
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
