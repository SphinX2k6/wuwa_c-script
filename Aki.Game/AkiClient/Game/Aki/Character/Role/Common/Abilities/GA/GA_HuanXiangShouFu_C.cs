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
	// Token: 0x02004137 RID: 16695
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_HuanXiangShouFu.GA_HuanXiangShouFu_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_HuanXiangShouFu_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B08D RID: 176269 RVA: 0x009F3A7C File Offset: 0x009F1C7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_HuanXiangShouFu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_HuanXiangShouFu.GA_HuanXiangShouFu_C");
			}
			return GA_HuanXiangShouFu_C._ClassPtr;
		}

		// Token: 0x0602B08E RID: 176270 RVA: 0x009F3AA0 File Offset: 0x009F1CA0
		public GA_HuanXiangShouFu_C() : this(BuiltinUtils.AllocNativeUObject(GA_HuanXiangShouFu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B08F RID: 176271 RVA: 0x009F3AC8 File Offset: 0x009F1CC8
		[NullableContext(1)]
		public GA_HuanXiangShouFu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_HuanXiangShouFu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0B RID: 27147
		// (get) Token: 0x0602B090 RID: 176272 RVA: 0x009F3AFB File Offset: 0x009F1CFB
		// (set) Token: 0x0602B091 RID: 176273 RVA: 0x009F3B0F File Offset: 0x009F1D0F
		public unsafe FVectorDouble loc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_HuanXiangShouFu_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_HuanXiangShouFu_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602B092 RID: 176274 RVA: 0x009F3B24 File Offset: 0x009F1D24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 面向目标收复(TsBaseCharacter 目标, FVectorDouble 面向目标)
		{
			GA_HuanXiangShouFu_C.__面向目标收复_FunctionParams* ptr = stackalloc GA_HuanXiangShouFu_C.__面向目标收复_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(GA_HuanXiangShouFu_C.__面向目标收复_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_HuanXiangShouFu_C.__面向目标收复_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->面向目标 = 面向目标;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_HuanXiangShouFu_C.__面向目标收复_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B093 RID: 176275 RVA: 0x009F3B84 File Offset: 0x009F1D84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_HuanXiangShouFu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_HuanXiangShouFu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B094 RID: 176276 RVA: 0x009F3BCC File Offset: 0x009F1DCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_HuanXiangShouFu_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_HuanXiangShouFu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_HuanXiangShouFu_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B095 RID: 176277 RVA: 0x009F3C13 File Offset: 0x009F1E13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_HuanXiangShouFu_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B096 RID: 176278 RVA: 0x009F3C27 File Offset: 0x009F1E27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_HuanXiangShouFu_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B097 RID: 176279 RVA: 0x009F3C3C File Offset: 0x009F1E3C
		protected GA_HuanXiangShouFu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016530 RID: 91440
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_HuanXiangShouFu.GA_HuanXiangShouFu_C";

		// Token: 0x04016531 RID: 91441
		private static IntPtr _ClassPtr;

		// Token: 0x04016532 RID: 91442
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016533 RID: 91443
		internal new static int __PropertyOffset_1;

		// Token: 0x04016534 RID: 91444
		private static IntPtr __面向目标收复_NativeFunctionPtr;

		// Token: 0x04016535 RID: 91445
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016536 RID: 91446
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A466 RID: 42086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __面向目标收复_FunctionParams
		{
			// Token: 0x040322AA RID: 205482
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x040322AB RID: 205483
			[FieldOffset(8)]
			public FVectorDouble 面向目标;
		}

		// Token: 0x0200A467 RID: 42087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322AC RID: 205484
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
