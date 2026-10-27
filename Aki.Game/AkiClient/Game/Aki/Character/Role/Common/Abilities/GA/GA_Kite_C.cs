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
	// Token: 0x02004145 RID: 16709
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Kite.GA_Kite_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Kite_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B139 RID: 176441 RVA: 0x009F50DC File Offset: 0x009F32DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Kite_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Kite.GA_Kite_C");
			}
			return GA_Kite_C._ClassPtr;
		}

		// Token: 0x0602B13A RID: 176442 RVA: 0x009F5100 File Offset: 0x009F3300
		public GA_Kite_C() : this(BuiltinUtils.AllocNativeUObject(GA_Kite_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B13B RID: 176443 RVA: 0x009F5128 File Offset: 0x009F3328
		[NullableContext(1)]
		public GA_Kite_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Kite_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B13C RID: 176444 RVA: 0x009F515B File Offset: 0x009F335B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SummorMotorcycle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__SummorMotorcycle_NativeFunctionPtr, null);
		}

		// Token: 0x0602B13D RID: 176445 RVA: 0x009F516F File Offset: 0x009F336F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void KiteStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__KiteStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B13E RID: 176446 RVA: 0x009F5183 File Offset: 0x009F3383
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void KiteTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__KiteTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B13F RID: 176447 RVA: 0x009F5198 File Offset: 0x009F3398
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88CC3A85AA(FGameplayEventData Payload)
		{
			GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_FunctionParams* ptr = stackalloc GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD88CC3A85AA_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B140 RID: 176448 RVA: 0x009F5210 File Offset: 0x009F3410
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD882073BC78(FGameplayEventData Payload)
		{
			GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_FunctionParams* ptr = stackalloc GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Kite_C.__EventReceived_18B59F5945020DB23C42FD882073BC78_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B141 RID: 176449 RVA: 0x009F5285 File Offset: 0x009F3485
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B142 RID: 176450 RVA: 0x009F5299 File Offset: 0x009F3499
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Kite_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B143 RID: 176451 RVA: 0x009F52B0 File Offset: 0x009F34B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Kite_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Kite_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Kite_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B144 RID: 176452 RVA: 0x009F52F8 File Offset: 0x009F34F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Kite_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Kite_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Kite_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B145 RID: 176453 RVA: 0x009F5340 File Offset: 0x009F3540
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnMovementModeChanged(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Kite_C.__OnMovementModeChanged_FunctionParams* ptr = stackalloc GA_Kite_C.__OnMovementModeChanged_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Kite_C.__OnMovementModeChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Kite_C.__OnMovementModeChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Kite_C.__OnMovementModeChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B146 RID: 176454 RVA: 0x009F53A8 File Offset: 0x009F35A8
		protected GA_Kite_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165AD RID: 91565
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Kite.GA_Kite_C";

		// Token: 0x040165AE RID: 91566
		private static IntPtr _ClassPtr;

		// Token: 0x040165AF RID: 91567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165B0 RID: 91568
		private static IntPtr __SummorMotorcycle_NativeFunctionPtr;

		// Token: 0x040165B1 RID: 91569
		private static IntPtr __KiteStart_NativeFunctionPtr;

		// Token: 0x040165B2 RID: 91570
		private static IntPtr __KiteTick_NativeFunctionPtr;

		// Token: 0x040165B3 RID: 91571
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88CC3A85AA_NativeFunctionPtr;

		// Token: 0x040165B4 RID: 91572
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD882073BC78_NativeFunctionPtr;

		// Token: 0x040165B5 RID: 91573
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165B6 RID: 91574
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040165B7 RID: 91575
		private static IntPtr __OnMovementModeChanged_NativeFunctionPtr;

		// Token: 0x0200A475 RID: 42101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88CC3A85AA_FunctionParams
		{
			// Token: 0x040322C2 RID: 205506
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A476 RID: 42102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD882073BC78_FunctionParams
		{
			// Token: 0x040322C3 RID: 205507
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A477 RID: 42103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322C4 RID: 205508
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A478 RID: 42104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMovementModeChanged_FunctionParams
		{
			// Token: 0x040322C5 RID: 205509
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322C6 RID: 205510
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322C7 RID: 205511
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
