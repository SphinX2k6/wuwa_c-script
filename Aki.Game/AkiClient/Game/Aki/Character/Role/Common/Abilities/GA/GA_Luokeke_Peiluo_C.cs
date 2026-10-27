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
	// Token: 0x02004146 RID: 16710
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Luokeke_Peiluo.GA_Luokeke_Peiluo_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Luokeke_Peiluo_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B147 RID: 176455 RVA: 0x009F53B1 File Offset: 0x009F35B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Luokeke_Peiluo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Luokeke_Peiluo.GA_Luokeke_Peiluo_C");
			}
			return GA_Luokeke_Peiluo_C._ClassPtr;
		}

		// Token: 0x0602B148 RID: 176456 RVA: 0x009F53D8 File Offset: 0x009F35D8
		public GA_Luokeke_Peiluo_C() : this(BuiltinUtils.AllocNativeUObject(GA_Luokeke_Peiluo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B149 RID: 176457 RVA: 0x009F5400 File Offset: 0x009F3600
		[NullableContext(1)]
		public GA_Luokeke_Peiluo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Luokeke_Peiluo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B14A RID: 176458 RVA: 0x009F5433 File Offset: 0x009F3633
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_602D72ED446DF1A10F6F5184005CF56D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Luokeke_Peiluo_C.__OnFinish_602D72ED446DF1A10F6F5184005CF56D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B14B RID: 176459 RVA: 0x009F5447 File Offset: 0x009F3647
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Luokeke_Peiluo_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B14C RID: 176460 RVA: 0x009F545B File Offset: 0x009F365B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Luokeke_Peiluo_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B14D RID: 176461 RVA: 0x009F5470 File Offset: 0x009F3670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Luokeke_Peiluo_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Luokeke_Peiluo_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B14E RID: 176462 RVA: 0x009F54B8 File Offset: 0x009F36B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Luokeke_Peiluo_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Luokeke_Peiluo_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Luokeke_Peiluo_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B14F RID: 176463 RVA: 0x009F54FF File Offset: 0x009F36FF
		protected GA_Luokeke_Peiluo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165B8 RID: 91576
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Luokeke_Peiluo.GA_Luokeke_Peiluo_C";

		// Token: 0x040165B9 RID: 91577
		private static IntPtr _ClassPtr;

		// Token: 0x040165BA RID: 91578
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165BB RID: 91579
		private static IntPtr __OnFinish_602D72ED446DF1A10F6F5184005CF56D_NativeFunctionPtr;

		// Token: 0x040165BC RID: 91580
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165BD RID: 91581
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A479 RID: 42105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322C8 RID: 205512
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
