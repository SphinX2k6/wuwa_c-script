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
	// Token: 0x02004088 RID: 16520
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Start_Fly.GA_Motor_Start_Fly_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Start_Fly_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A85C RID: 174172 RVA: 0x009E3278 File Offset: 0x009E1478
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Start_Fly_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Start_Fly.GA_Motor_Start_Fly_C");
			}
			return GA_Motor_Start_Fly_C._ClassPtr;
		}

		// Token: 0x0602A85D RID: 174173 RVA: 0x009E329C File Offset: 0x009E149C
		public GA_Motor_Start_Fly_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Start_Fly_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A85E RID: 174174 RVA: 0x009E32C4 File Offset: 0x009E14C4
		[NullableContext(1)]
		public GA_Motor_Start_Fly_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Start_Fly_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x0602A85F RID: 174175 RVA: 0x009E32F7 File Offset: 0x009E14F7
		// (set) Token: 0x0602A860 RID: 174176 RVA: 0x009E330B File Offset: 0x009E150B
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Start_Fly_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Start_Fly_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A861 RID: 174177 RVA: 0x009E3320 File Offset: 0x009E1520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38146F818BB(in FGameplayTag Tag)
		{
			GA_Motor_Start_Fly_C.__Removed_DB9F64004F8908FEAD99D38146F818BB_FunctionParams* ptr = stackalloc GA_Motor_Start_Fly_C.__Removed_DB9F64004F8908FEAD99D38146F818BB_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_Start_Fly_C.__Removed_DB9F64004F8908FEAD99D38146F818BB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Start_Fly_C.__Removed_DB9F64004F8908FEAD99D38146F818BB_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__Removed_DB9F64004F8908FEAD99D38146F818BB_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A862 RID: 174178 RVA: 0x009E336B File Offset: 0x009E156B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B870ACD04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnTick_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr, null);
		}

		// Token: 0x0602A863 RID: 174179 RVA: 0x009E337F File Offset: 0x009E157F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B870ACD04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr, null);
		}

		// Token: 0x0602A864 RID: 174180 RVA: 0x009E3393 File Offset: 0x009E1593
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B870ACD04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr, null);
		}

		// Token: 0x0602A865 RID: 174181 RVA: 0x009E33A7 File Offset: 0x009E15A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B870ACD04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr, null);
		}

		// Token: 0x0602A866 RID: 174182 RVA: 0x009E33BB File Offset: 0x009E15BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B870ACD04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr, null);
		}

		// Token: 0x0602A867 RID: 174183 RVA: 0x009E33CF File Offset: 0x009E15CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_A155CB1B4F6EA52B4C285081F43B5440()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__OnFinish_A155CB1B4F6EA52B4C285081F43B5440_NativeFunctionPtr, null);
		}

		// Token: 0x0602A868 RID: 174184 RVA: 0x009E33E3 File Offset: 0x009E15E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A869 RID: 174185 RVA: 0x009E33F7 File Offset: 0x009E15F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A86A RID: 174186 RVA: 0x009E340C File Offset: 0x009E160C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Start_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A86B RID: 174187 RVA: 0x009E3454 File Offset: 0x009E1654
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Start_Fly_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Start_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Start_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A86C RID: 174188 RVA: 0x009E349B File Offset: 0x009E169B
		protected GA_Motor_Start_Fly_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FA2 RID: 90018
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Start_Fly.GA_Motor_Start_Fly_C";

		// Token: 0x04015FA3 RID: 90019
		private static IntPtr _ClassPtr;

		// Token: 0x04015FA4 RID: 90020
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FA5 RID: 90021
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FA6 RID: 90022
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38146F818BB_NativeFunctionPtr;

		// Token: 0x04015FA7 RID: 90023
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr;

		// Token: 0x04015FA8 RID: 90024
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr;

		// Token: 0x04015FA9 RID: 90025
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr;

		// Token: 0x04015FAA RID: 90026
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr;

		// Token: 0x04015FAB RID: 90027
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B870ACD04_NativeFunctionPtr;

		// Token: 0x04015FAC RID: 90028
		private static IntPtr __OnFinish_A155CB1B4F6EA52B4C285081F43B5440_NativeFunctionPtr;

		// Token: 0x04015FAD RID: 90029
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FAE RID: 90030
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C1 RID: 41921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38146F818BB_FunctionParams
		{
			// Token: 0x040321AE RID: 205230
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3C2 RID: 41922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321AF RID: 205231
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
