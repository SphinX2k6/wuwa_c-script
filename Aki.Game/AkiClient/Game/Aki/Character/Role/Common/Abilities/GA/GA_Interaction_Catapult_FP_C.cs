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
	// Token: 0x0200413B RID: 16699
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_FP.GA_Interaction_Catapult_FP_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_Catapult_FP_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0C5 RID: 176325 RVA: 0x009F4261 File Offset: 0x009F2461
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Catapult_FP_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_FP.GA_Interaction_Catapult_FP_C");
			}
			return GA_Interaction_Catapult_FP_C._ClassPtr;
		}

		// Token: 0x0602B0C6 RID: 176326 RVA: 0x009F4288 File Offset: 0x009F2488
		public GA_Interaction_Catapult_FP_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_FP_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0C7 RID: 176327 RVA: 0x009F42B0 File Offset: 0x009F24B0
		[NullableContext(1)]
		public GA_Interaction_Catapult_FP_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Catapult_FP_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0E RID: 27150
		// (get) Token: 0x0602B0C8 RID: 176328 RVA: 0x009F42E3 File Offset: 0x009F24E3
		// (set) Token: 0x0602B0C9 RID: 176329 RVA: 0x009F42F7 File Offset: 0x009F24F7
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Catapult_FP_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Catapult_FP_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B0CA RID: 176330 RVA: 0x009F430C File Offset: 0x009F250C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818897C20D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__OnTick_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0CB RID: 176331 RVA: 0x009F4320 File Offset: 0x009F2520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818897C20D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__OnCancelled_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0CC RID: 176332 RVA: 0x009F4334 File Offset: 0x009F2534
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818897C20D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__OnInterrupted_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0CD RID: 176333 RVA: 0x009F4348 File Offset: 0x009F2548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818897C20D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__OnBlendOut_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0CE RID: 176334 RVA: 0x009F435C File Offset: 0x009F255C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818897C20D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__OnCompleted_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0CF RID: 176335 RVA: 0x009F4370 File Offset: 0x009F2570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0D0 RID: 176336 RVA: 0x009F4384 File Offset: 0x009F2584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0D1 RID: 176337 RVA: 0x009F439C File Offset: 0x009F259C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0D2 RID: 176338 RVA: 0x009F43E4 File Offset: 0x009F25E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0D3 RID: 176339 RVA: 0x009F442C File Offset: 0x009F262C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Interaction_Catapult_FP_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Interaction_Catapult_FP_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Interaction_Catapult_FP_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Catapult_FP_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Catapult_FP_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0D4 RID: 176340 RVA: 0x009F4494 File Offset: 0x009F2694
		protected GA_Interaction_Catapult_FP_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016559 RID: 91481
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Catapult_FP.GA_Interaction_Catapult_FP_C";

		// Token: 0x0401655A RID: 91482
		private static IntPtr _ClassPtr;

		// Token: 0x0401655B RID: 91483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401655C RID: 91484
		internal new static int __PropertyOffset_1;

		// Token: 0x0401655D RID: 91485
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr;

		// Token: 0x0401655E RID: 91486
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr;

		// Token: 0x0401655F RID: 91487
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr;

		// Token: 0x04016560 RID: 91488
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr;

		// Token: 0x04016561 RID: 91489
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818897C20D_NativeFunctionPtr;

		// Token: 0x04016562 RID: 91490
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016563 RID: 91491
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016564 RID: 91492
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0200A46D RID: 42093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322B6 RID: 205494
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A46E RID: 42094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322B7 RID: 205495
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322B8 RID: 205496
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322B9 RID: 205497
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
