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
	// Token: 0x02004167 RID: 16743
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SeatSummon.GA_SeatSummon_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_SeatSummon_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4C9 RID: 177353 RVA: 0x009FBFE1 File Offset: 0x009FA1E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SeatSummon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SeatSummon.GA_SeatSummon_C");
			}
			return GA_SeatSummon_C._ClassPtr;
		}

		// Token: 0x0602B4CA RID: 177354 RVA: 0x009FC008 File Offset: 0x009FA208
		public GA_SeatSummon_C() : this(BuiltinUtils.AllocNativeUObject(GA_SeatSummon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4CB RID: 177355 RVA: 0x009FC030 File Offset: 0x009FA230
		[NullableContext(1)]
		public GA_SeatSummon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SeatSummon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B4CC RID: 177356 RVA: 0x009FC063 File Offset: 0x009FA263
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SeatSummon_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4CD RID: 177357 RVA: 0x009FC077 File Offset: 0x009FA277
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SeatSummon_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4CE RID: 177358 RVA: 0x009FC08C File Offset: 0x009FA28C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SeatSummon_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SeatSummon_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B4CF RID: 177359 RVA: 0x009FC0D4 File Offset: 0x009FA2D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_SeatSummon_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SeatSummon_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SeatSummon_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B4D0 RID: 177360 RVA: 0x009FC11B File Offset: 0x009FA31B
		protected GA_SeatSummon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016826 RID: 92198
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SeatSummon.GA_SeatSummon_C";

		// Token: 0x04016827 RID: 92199
		private static IntPtr _ClassPtr;

		// Token: 0x04016828 RID: 92200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016829 RID: 92201
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401682A RID: 92202
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4C8 RID: 42184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032336 RID: 205622
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
