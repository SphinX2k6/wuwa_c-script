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
	// Token: 0x0200416F RID: 16751
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End_New.GA_Super_Sprint_End_New_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1513)]
	public class GA_Super_Sprint_End_New_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B547 RID: 177479 RVA: 0x009FD240 File Offset: 0x009FB440
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_End_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End_New.GA_Super_Sprint_End_New_C");
			}
			return GA_Super_Sprint_End_New_C._ClassPtr;
		}

		// Token: 0x0602B548 RID: 177480 RVA: 0x009FD264 File Offset: 0x009FB464
		public GA_Super_Sprint_End_New_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_End_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B549 RID: 177481 RVA: 0x009FD28C File Offset: 0x009FB48C
		[NullableContext(1)]
		public GA_Super_Sprint_End_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_End_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AE1 RID: 27361
		// (get) Token: 0x0602B54A RID: 177482 RVA: 0x009FD2BF File Offset: 0x009FB4BF
		// (set) Token: 0x0602B54B RID: 177483 RVA: 0x009FD2CF File Offset: 0x009FB4CF
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_End_New_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_End_New_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B54C RID: 177484 RVA: 0x009FD2E0 File Offset: 0x009FB4E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818DF7D4CF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__OnTick_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr, null);
		}

		// Token: 0x0602B54D RID: 177485 RVA: 0x009FD2F4 File Offset: 0x009FB4F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818DF7D4CF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__OnCancelled_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr, null);
		}

		// Token: 0x0602B54E RID: 177486 RVA: 0x009FD308 File Offset: 0x009FB508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818DF7D4CF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__OnInterrupted_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr, null);
		}

		// Token: 0x0602B54F RID: 177487 RVA: 0x009FD31C File Offset: 0x009FB51C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818DF7D4CF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__OnBlendOut_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr, null);
		}

		// Token: 0x0602B550 RID: 177488 RVA: 0x009FD330 File Offset: 0x009FB530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818DF7D4CF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__OnCompleted_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr, null);
		}

		// Token: 0x0602B551 RID: 177489 RVA: 0x009FD344 File Offset: 0x009FB544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B552 RID: 177490 RVA: 0x009FD358 File Offset: 0x009FB558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B553 RID: 177491 RVA: 0x009FD370 File Offset: 0x009FB570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_End_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B554 RID: 177492 RVA: 0x009FD3B8 File Offset: 0x009FB5B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_End_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_End_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_End_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B555 RID: 177493 RVA: 0x009FD3FF File Offset: 0x009FB5FF
		protected GA_Super_Sprint_End_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016881 RID: 92289
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End_New.GA_Super_Sprint_End_New_C";

		// Token: 0x04016882 RID: 92290
		private static IntPtr _ClassPtr;

		// Token: 0x04016883 RID: 92291
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016884 RID: 92292
		internal new static int __PropertyOffset_1;

		// Token: 0x04016885 RID: 92293
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr;

		// Token: 0x04016886 RID: 92294
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr;

		// Token: 0x04016887 RID: 92295
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr;

		// Token: 0x04016888 RID: 92296
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr;

		// Token: 0x04016889 RID: 92297
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818DF7D4CF_NativeFunctionPtr;

		// Token: 0x0401688A RID: 92298
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401688B RID: 92299
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4E2 RID: 42210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032350 RID: 205648
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
