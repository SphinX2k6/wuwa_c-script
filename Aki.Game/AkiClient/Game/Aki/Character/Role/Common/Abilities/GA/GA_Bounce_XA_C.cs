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
	// Token: 0x02004120 RID: 16672
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Bounce_XA.GA_Bounce_XA_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1513)]
	public class GA_Bounce_XA_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF1B RID: 175899 RVA: 0x009F09B0 File Offset: 0x009EEBB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Bounce_XA_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Bounce_XA.GA_Bounce_XA_C");
			}
			return GA_Bounce_XA_C._ClassPtr;
		}

		// Token: 0x0602AF1C RID: 175900 RVA: 0x009F09D4 File Offset: 0x009EEBD4
		public GA_Bounce_XA_C() : this(BuiltinUtils.AllocNativeUObject(GA_Bounce_XA_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF1D RID: 175901 RVA: 0x009F09FC File Offset: 0x009EEBFC
		[NullableContext(1)]
		public GA_Bounce_XA_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Bounce_XA_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069CF RID: 27087
		// (get) Token: 0x0602AF1E RID: 175902 RVA: 0x009F0A2F File Offset: 0x009EEC2F
		// (set) Token: 0x0602AF1F RID: 175903 RVA: 0x009F0A43 File Offset: 0x009EEC43
		public unsafe TEnumAsByte<EMovementMode> 运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Bounce_XA_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Bounce_XA_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602AF20 RID: 175904 RVA: 0x009F0A58 File Offset: 0x009EEC58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818422C823()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__OnTick_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF21 RID: 175905 RVA: 0x009F0A6C File Offset: 0x009EEC6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818422C823()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__OnCancelled_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF22 RID: 175906 RVA: 0x009F0A80 File Offset: 0x009EEC80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818422C823()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__OnInterrupted_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF23 RID: 175907 RVA: 0x009F0A94 File Offset: 0x009EEC94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818422C823()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__OnBlendOut_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF24 RID: 175908 RVA: 0x009F0AA8 File Offset: 0x009EECA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818422C823()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__OnCompleted_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF25 RID: 175909 RVA: 0x009F0ABC File Offset: 0x009EECBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF26 RID: 175910 RVA: 0x009F0AD0 File Offset: 0x009EECD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Bounce_XA_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF27 RID: 175911 RVA: 0x009F0AE8 File Offset: 0x009EECE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Bounce_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Bounce_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF28 RID: 175912 RVA: 0x009F0B30 File Offset: 0x009EED30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Bounce_XA_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Bounce_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Bounce_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF29 RID: 175913 RVA: 0x009F0B77 File Offset: 0x009EED77
		protected GA_Bounce_XA_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016432 RID: 91186
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Bounce_XA.GA_Bounce_XA_C";

		// Token: 0x04016433 RID: 91187
		private static IntPtr _ClassPtr;

		// Token: 0x04016434 RID: 91188
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016435 RID: 91189
		internal new static int __PropertyOffset_1;

		// Token: 0x04016436 RID: 91190
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr;

		// Token: 0x04016437 RID: 91191
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr;

		// Token: 0x04016438 RID: 91192
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr;

		// Token: 0x04016439 RID: 91193
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr;

		// Token: 0x0401643A RID: 91194
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818422C823_NativeFunctionPtr;

		// Token: 0x0401643B RID: 91195
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401643C RID: 91196
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A439 RID: 42041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032278 RID: 205432
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
