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
	// Token: 0x0200407F RID: 16511
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower_Level.GA_Motor_Lower_Level_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Motor_Lower_Level_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A7C6 RID: 174022 RVA: 0x009E2090 File Offset: 0x009E0290
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Lower_Level_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower_Level.GA_Motor_Lower_Level_C");
			}
			return GA_Motor_Lower_Level_C._ClassPtr;
		}

		// Token: 0x0602A7C7 RID: 174023 RVA: 0x009E20B4 File Offset: 0x009E02B4
		public GA_Motor_Lower_Level_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower_Level_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A7C8 RID: 174024 RVA: 0x009E20DC File Offset: 0x009E02DC
		[NullableContext(1)]
		public GA_Motor_Lower_Level_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower_Level_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x0602A7C9 RID: 174025 RVA: 0x009E210F File Offset: 0x009E030F
		// (set) Token: 0x0602A7CA RID: 174026 RVA: 0x009E211F File Offset: 0x009E031F
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Lower_Level_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Lower_Level_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x0602A7CB RID: 174027 RVA: 0x009E2130 File Offset: 0x009E0330
		// (set) Token: 0x0602A7CC RID: 174028 RVA: 0x009E2144 File Offset: 0x009E0344
		[Nullable(2)]
		public unsafe TsBaseCharacter 驾驶员
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower_Level_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower_Level_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602A7CD RID: 174029 RVA: 0x009E2159 File Offset: 0x009E0359
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BA87D4529()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnTick_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7CE RID: 174030 RVA: 0x009E216D File Offset: 0x009E036D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BA87D4529()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7CF RID: 174031 RVA: 0x009E2181 File Offset: 0x009E0381
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BA87D4529()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D0 RID: 174032 RVA: 0x009E2195 File Offset: 0x009E0395
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BA87D4529()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D1 RID: 174033 RVA: 0x009E21A9 File Offset: 0x009E03A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BA87D4529()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D2 RID: 174034 RVA: 0x009E21BD File Offset: 0x009E03BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BC2C5D807()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnTick_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D3 RID: 174035 RVA: 0x009E21D1 File Offset: 0x009E03D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BC2C5D807()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D4 RID: 174036 RVA: 0x009E21E5 File Offset: 0x009E03E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BC2C5D807()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D5 RID: 174037 RVA: 0x009E21F9 File Offset: 0x009E03F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BC2C5D807()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D6 RID: 174038 RVA: 0x009E220D File Offset: 0x009E040D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BC2C5D807()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D7 RID: 174039 RVA: 0x009E2224 File Offset: 0x009E0424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38123D3BC99(in FGameplayTag Tag)
		{
			GA_Motor_Lower_Level_C.__Removed_DB9F64004F8908FEAD99D38123D3BC99_FunctionParams* ptr = stackalloc GA_Motor_Lower_Level_C.__Removed_DB9F64004F8908FEAD99D38123D3BC99_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_Lower_Level_C.__Removed_DB9F64004F8908FEAD99D38123D3BC99_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_Level_C.__Removed_DB9F64004F8908FEAD99D38123D3BC99_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__Removed_DB9F64004F8908FEAD99D38123D3BC99_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A7D8 RID: 174040 RVA: 0x009E226F File Offset: 0x009E046F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7D9 RID: 174041 RVA: 0x009E2283 File Offset: 0x009E0483
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A7DA RID: 174042 RVA: 0x009E2298 File Offset: 0x009E0498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_Level_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A7DB RID: 174043 RVA: 0x009E22E0 File Offset: 0x009E04E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Lower_Level_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_Level_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Lower_Level_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A7DC RID: 174044 RVA: 0x009E2327 File Offset: 0x009E0527
		protected GA_Motor_Lower_Level_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F39 RID: 89913
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower_Level.GA_Motor_Lower_Level_C";

		// Token: 0x04015F3A RID: 89914
		private static IntPtr _ClassPtr;

		// Token: 0x04015F3B RID: 89915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F3C RID: 89916
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F3D RID: 89917
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F3E RID: 89918
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr;

		// Token: 0x04015F3F RID: 89919
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr;

		// Token: 0x04015F40 RID: 89920
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr;

		// Token: 0x04015F41 RID: 89921
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr;

		// Token: 0x04015F42 RID: 89922
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BA87D4529_NativeFunctionPtr;

		// Token: 0x04015F43 RID: 89923
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr;

		// Token: 0x04015F44 RID: 89924
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr;

		// Token: 0x04015F45 RID: 89925
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr;

		// Token: 0x04015F46 RID: 89926
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr;

		// Token: 0x04015F47 RID: 89927
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BC2C5D807_NativeFunctionPtr;

		// Token: 0x04015F48 RID: 89928
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38123D3BC99_NativeFunctionPtr;

		// Token: 0x04015F49 RID: 89929
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F4A RID: 89930
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B6 RID: 41910
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38123D3BC99_FunctionParams
		{
			// Token: 0x040321A3 RID: 205219
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3B7 RID: 41911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A4 RID: 205220
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
