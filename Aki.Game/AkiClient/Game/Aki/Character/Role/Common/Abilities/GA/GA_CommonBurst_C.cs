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
	// Token: 0x02004122 RID: 16674
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonBurst.GA_CommonBurst_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1516)]
	public class GA_CommonBurst_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF3B RID: 175931 RVA: 0x009F0D3A File Offset: 0x009EEF3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_CommonBurst_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonBurst.GA_CommonBurst_C");
			}
			return GA_CommonBurst_C._ClassPtr;
		}

		// Token: 0x0602AF3C RID: 175932 RVA: 0x009F0D60 File Offset: 0x009EEF60
		public GA_CommonBurst_C() : this(BuiltinUtils.AllocNativeUObject(GA_CommonBurst_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF3D RID: 175933 RVA: 0x009F0D88 File Offset: 0x009EEF88
		[NullableContext(1)]
		public GA_CommonBurst_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_CommonBurst_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069D5 RID: 27093
		// (get) Token: 0x0602AF3E RID: 175934 RVA: 0x009F0DBB File Offset: 0x009EEFBB
		// (set) Token: 0x0602AF3F RID: 175935 RVA: 0x009F0DCB File Offset: 0x009EEFCB
		public unsafe float 原来质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_CommonBurst_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_CommonBurst_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602AF40 RID: 175936 RVA: 0x009F0DDC File Offset: 0x009EEFDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81DADDF27C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__OnTick_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF41 RID: 175937 RVA: 0x009F0DF0 File Offset: 0x009EEFF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81DADDF27C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__OnCancelled_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF42 RID: 175938 RVA: 0x009F0E04 File Offset: 0x009EF004
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81DADDF27C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__OnInterrupted_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF43 RID: 175939 RVA: 0x009F0E18 File Offset: 0x009EF018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81DADDF27C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__OnBlendOut_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF44 RID: 175940 RVA: 0x009F0E2C File Offset: 0x009EF02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81DADDF27C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__OnCompleted_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF45 RID: 175941 RVA: 0x009F0E40 File Offset: 0x009EF040
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF46 RID: 175942 RVA: 0x009F0E54 File Offset: 0x009EF054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonBurst_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF47 RID: 175943 RVA: 0x009F0E6C File Offset: 0x009EF06C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonBurst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_CommonBurst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF48 RID: 175944 RVA: 0x009F0EB4 File Offset: 0x009EF0B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_CommonBurst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_CommonBurst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_CommonBurst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF49 RID: 175945 RVA: 0x009F0EFB File Offset: 0x009EF0FB
		protected GA_CommonBurst_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016449 RID: 91209
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_CommonBurst.GA_CommonBurst_C";

		// Token: 0x0401644A RID: 91210
		private static IntPtr _ClassPtr;

		// Token: 0x0401644B RID: 91211
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401644C RID: 91212
		internal new static int __PropertyOffset_1;

		// Token: 0x0401644D RID: 91213
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr;

		// Token: 0x0401644E RID: 91214
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr;

		// Token: 0x0401644F RID: 91215
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr;

		// Token: 0x04016450 RID: 91216
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr;

		// Token: 0x04016451 RID: 91217
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81DADDF27C_NativeFunctionPtr;

		// Token: 0x04016452 RID: 91218
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016453 RID: 91219
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A43A RID: 42042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032279 RID: 205433
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
