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
	// Token: 0x02004189 RID: 16777
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_XA.GA_XA_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1513)]
	public class GA_XA_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B723 RID: 177955 RVA: 0x00A00EED File Offset: 0x009FF0ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_XA_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_XA.GA_XA_C");
			}
			return GA_XA_C._ClassPtr;
		}

		// Token: 0x0602B724 RID: 177956 RVA: 0x00A00F14 File Offset: 0x009FF114
		public GA_XA_C() : this(BuiltinUtils.AllocNativeUObject(GA_XA_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B725 RID: 177957 RVA: 0x00A00F3C File Offset: 0x009FF13C
		[NullableContext(1)]
		public GA_XA_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_XA_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B2A RID: 27434
		// (get) Token: 0x0602B726 RID: 177958 RVA: 0x00A00F6F File Offset: 0x009FF16F
		// (set) Token: 0x0602B727 RID: 177959 RVA: 0x00A00F83 File Offset: 0x009FF183
		public unsafe TEnumAsByte<EMovementMode> 运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_XA_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_XA_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602B728 RID: 177960 RVA: 0x00A00F98 File Offset: 0x009FF198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_XA_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B729 RID: 177961 RVA: 0x00A00FAC File Offset: 0x009FF1AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_XA_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B72A RID: 177962 RVA: 0x00A00FC4 File Offset: 0x009FF1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_XA_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_XA_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_XA_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B72B RID: 177963 RVA: 0x00A0100C File Offset: 0x009FF20C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_XA_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_XA_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_XA_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_XA_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B72C RID: 177964 RVA: 0x00A01053 File Offset: 0x009FF253
		protected GA_XA_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169CE RID: 92622
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_XA.GA_XA_C";

		// Token: 0x040169CF RID: 92623
		private static IntPtr _ClassPtr;

		// Token: 0x040169D0 RID: 92624
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169D1 RID: 92625
		internal new static int __PropertyOffset_1;

		// Token: 0x040169D2 RID: 92626
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040169D3 RID: 92627
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A527 RID: 42279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032395 RID: 205717
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
