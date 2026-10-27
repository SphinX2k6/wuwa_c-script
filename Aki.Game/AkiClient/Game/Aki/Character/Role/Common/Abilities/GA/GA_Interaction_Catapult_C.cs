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
	// Token: 0x0200413A RID: 16698
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult.GA_Interaction_Catapult_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_Catapult_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0B0 RID: 176304 RVA: 0x009F3FC4 File Offset: 0x009F21C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Catapult_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult.GA_Interaction_Catapult_C");
			}
			return GA_Interaction_Catapult_C._ClassPtr;
		}

		// Token: 0x0602B0B1 RID: 176305 RVA: 0x009F3FE8 File Offset: 0x009F21E8
		public GA_Interaction_Catapult_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0B2 RID: 176306 RVA: 0x009F4010 File Offset: 0x009F2210
		[NullableContext(1)]
		public GA_Interaction_Catapult_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0D RID: 27149
		// (get) Token: 0x0602B0B3 RID: 176307 RVA: 0x009F4043 File Offset: 0x009F2243
		// (set) Token: 0x0602B0B4 RID: 176308 RVA: 0x009F4057 File Offset: 0x009F2257
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Catapult_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Catapult_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B0B5 RID: 176309 RVA: 0x009F406C File Offset: 0x009F226C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E810BF3ED21()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnTick_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0B6 RID: 176310 RVA: 0x009F4080 File Offset: 0x009F2280
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E810BF3ED21()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnCancelled_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0B7 RID: 176311 RVA: 0x009F4094 File Offset: 0x009F2294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E810BF3ED21()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnInterrupted_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0B8 RID: 176312 RVA: 0x009F40A8 File Offset: 0x009F22A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E810BF3ED21()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnBlendOut_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0B9 RID: 176313 RVA: 0x009F40BC File Offset: 0x009F22BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E810BF3ED21()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnCompleted_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BA RID: 176314 RVA: 0x009F40D0 File Offset: 0x009F22D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81BB40C26D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnTick_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BB RID: 176315 RVA: 0x009F40E4 File Offset: 0x009F22E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81BB40C26D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnCancelled_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BC RID: 176316 RVA: 0x009F40F8 File Offset: 0x009F22F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81BB40C26D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnInterrupted_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BD RID: 176317 RVA: 0x009F410C File Offset: 0x009F230C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81BB40C26D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnBlendOut_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BE RID: 176318 RVA: 0x009F4120 File Offset: 0x009F2320
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81BB40C26D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__OnCompleted_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0BF RID: 176319 RVA: 0x009F4134 File Offset: 0x009F2334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0C0 RID: 176320 RVA: 0x009F4148 File Offset: 0x009F2348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0C1 RID: 176321 RVA: 0x009F4160 File Offset: 0x009F2360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0C2 RID: 176322 RVA: 0x009F41A8 File Offset: 0x009F23A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0C3 RID: 176323 RVA: 0x009F41F0 File Offset: 0x009F23F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Interaction_Catapult_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Interaction_Catapult_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0C4 RID: 176324 RVA: 0x009F4258 File Offset: 0x009F2458
		protected GA_Interaction_Catapult_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016548 RID: 91464
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult.GA_Interaction_Catapult_C";

		// Token: 0x04016549 RID: 91465
		private static IntPtr _ClassPtr;

		// Token: 0x0401654A RID: 91466
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401654B RID: 91467
		internal new static int __PropertyOffset_1;

		// Token: 0x0401654C RID: 91468
		private static IntPtr __OnTick_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr;

		// Token: 0x0401654D RID: 91469
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr;

		// Token: 0x0401654E RID: 91470
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr;

		// Token: 0x0401654F RID: 91471
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr;

		// Token: 0x04016550 RID: 91472
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E810BF3ED21_NativeFunctionPtr;

		// Token: 0x04016551 RID: 91473
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr;

		// Token: 0x04016552 RID: 91474
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr;

		// Token: 0x04016553 RID: 91475
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr;

		// Token: 0x04016554 RID: 91476
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr;

		// Token: 0x04016555 RID: 91477
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81BB40C26D_NativeFunctionPtr;

		// Token: 0x04016556 RID: 91478
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016557 RID: 91479
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016558 RID: 91480
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0200A46B RID: 42091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322B2 RID: 205490
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A46C RID: 42092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322B3 RID: 205491
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322B4 RID: 205492
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322B5 RID: 205493
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
