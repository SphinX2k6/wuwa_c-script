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
	// Token: 0x02004143 RID: 16707
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult.GA_Interaction_SuperCatapult_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_SuperCatapult_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B121 RID: 176417 RVA: 0x009F4D60 File Offset: 0x009F2F60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_SuperCatapult_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult.GA_Interaction_SuperCatapult_C");
			}
			return GA_Interaction_SuperCatapult_C._ClassPtr;
		}

		// Token: 0x0602B122 RID: 176418 RVA: 0x009F4D84 File Offset: 0x009F2F84
		public GA_Interaction_SuperCatapult_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_SuperCatapult_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B123 RID: 176419 RVA: 0x009F4DAC File Offset: 0x009F2FAC
		[NullableContext(1)]
		public GA_Interaction_SuperCatapult_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_SuperCatapult_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A13 RID: 27155
		// (get) Token: 0x0602B124 RID: 176420 RVA: 0x009F4DDF File Offset: 0x009F2FDF
		// (set) Token: 0x0602B125 RID: 176421 RVA: 0x009F4DF3 File Offset: 0x009F2FF3
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_SuperCatapult_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_SuperCatapult_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B126 RID: 176422 RVA: 0x009F4E08 File Offset: 0x009F3008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8128E8D714()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__OnTick_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr, null);
		}

		// Token: 0x0602B127 RID: 176423 RVA: 0x009F4E1C File Offset: 0x009F301C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8128E8D714()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__OnCancelled_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr, null);
		}

		// Token: 0x0602B128 RID: 176424 RVA: 0x009F4E30 File Offset: 0x009F3030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8128E8D714()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__OnInterrupted_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr, null);
		}

		// Token: 0x0602B129 RID: 176425 RVA: 0x009F4E44 File Offset: 0x009F3044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8128E8D714()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__OnBlendOut_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr, null);
		}

		// Token: 0x0602B12A RID: 176426 RVA: 0x009F4E58 File Offset: 0x009F3058
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8128E8D714()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__OnCompleted_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr, null);
		}

		// Token: 0x0602B12B RID: 176427 RVA: 0x009F4E6C File Offset: 0x009F306C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B12C RID: 176428 RVA: 0x009F4E80 File Offset: 0x009F3080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B12D RID: 176429 RVA: 0x009F4E98 File Offset: 0x009F3098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B12E RID: 176430 RVA: 0x009F4EE0 File Offset: 0x009F30E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B12F RID: 176431 RVA: 0x009F4F28 File Offset: 0x009F3128
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Interaction_SuperCatapult_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Interaction_SuperCatapult_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Interaction_SuperCatapult_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_SuperCatapult_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_SuperCatapult_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B130 RID: 176432 RVA: 0x009F4F90 File Offset: 0x009F3190
		protected GA_Interaction_SuperCatapult_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401659C RID: 91548
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_SuperCatapult.GA_Interaction_SuperCatapult_C";

		// Token: 0x0401659D RID: 91549
		private static IntPtr _ClassPtr;

		// Token: 0x0401659E RID: 91550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401659F RID: 91551
		internal new static int __PropertyOffset_1;

		// Token: 0x040165A0 RID: 91552
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr;

		// Token: 0x040165A1 RID: 91553
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr;

		// Token: 0x040165A2 RID: 91554
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr;

		// Token: 0x040165A3 RID: 91555
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr;

		// Token: 0x040165A4 RID: 91556
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8128E8D714_NativeFunctionPtr;

		// Token: 0x040165A5 RID: 91557
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165A6 RID: 91558
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040165A7 RID: 91559
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0200A472 RID: 42098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322BD RID: 205501
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A473 RID: 42099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322BE RID: 205502
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322BF RID: 205503
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322C0 RID: 205504
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
