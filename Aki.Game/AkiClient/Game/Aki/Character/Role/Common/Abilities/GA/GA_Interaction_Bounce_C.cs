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
	// Token: 0x02004138 RID: 16696
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce.GA_Interaction_Bounce_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_Bounce_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B098 RID: 176280 RVA: 0x009F3C45 File Offset: 0x009F1E45
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Bounce_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce.GA_Interaction_Bounce_C");
			}
			return GA_Interaction_Bounce_C._ClassPtr;
		}

		// Token: 0x0602B099 RID: 176281 RVA: 0x009F3C6C File Offset: 0x009F1E6C
		public GA_Interaction_Bounce_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Bounce_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B09A RID: 176282 RVA: 0x009F3C94 File Offset: 0x009F1E94
		[NullableContext(1)]
		public GA_Interaction_Bounce_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Bounce_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0C RID: 27148
		// (get) Token: 0x0602B09B RID: 176283 RVA: 0x009F3CC7 File Offset: 0x009F1EC7
		// (set) Token: 0x0602B09C RID: 176284 RVA: 0x009F3CDB File Offset: 0x009F1EDB
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Bounce_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Bounce_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B09D RID: 176285 RVA: 0x009F3CF0 File Offset: 0x009F1EF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818F2F100F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__OnTick_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B09E RID: 176286 RVA: 0x009F3D04 File Offset: 0x009F1F04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818F2F100F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__OnCancelled_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B09F RID: 176287 RVA: 0x009F3D18 File Offset: 0x009F1F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818F2F100F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__OnInterrupted_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0A0 RID: 176288 RVA: 0x009F3D2C File Offset: 0x009F1F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818F2F100F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__OnBlendOut_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0A1 RID: 176289 RVA: 0x009F3D40 File Offset: 0x009F1F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818F2F100F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__OnCompleted_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0A2 RID: 176290 RVA: 0x009F3D54 File Offset: 0x009F1F54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0A3 RID: 176291 RVA: 0x009F3D68 File Offset: 0x009F1F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Bounce_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0A4 RID: 176292 RVA: 0x009F3D80 File Offset: 0x009F1F80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Bounce_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0A5 RID: 176293 RVA: 0x009F3DC8 File Offset: 0x009F1FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Interaction_Bounce_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Bounce_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Bounce_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B0A6 RID: 176294 RVA: 0x009F3E10 File Offset: 0x009F2010
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Interaction_Bounce_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Interaction_Bounce_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Interaction_Bounce_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Interaction_Bounce_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Bounce_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B0A7 RID: 176295 RVA: 0x009F3E78 File Offset: 0x009F2078
		protected GA_Interaction_Bounce_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016537 RID: 91447
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Bounce.GA_Interaction_Bounce_C";

		// Token: 0x04016538 RID: 91448
		private static IntPtr _ClassPtr;

		// Token: 0x04016539 RID: 91449
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401653A RID: 91450
		internal new static int __PropertyOffset_1;

		// Token: 0x0401653B RID: 91451
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr;

		// Token: 0x0401653C RID: 91452
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr;

		// Token: 0x0401653D RID: 91453
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr;

		// Token: 0x0401653E RID: 91454
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr;

		// Token: 0x0401653F RID: 91455
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818F2F100F_NativeFunctionPtr;

		// Token: 0x04016540 RID: 91456
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016541 RID: 91457
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016542 RID: 91458
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0200A468 RID: 42088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322AD RID: 205485
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A469 RID: 42089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322AE RID: 205486
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322AF RID: 205487
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322B0 RID: 205488
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
