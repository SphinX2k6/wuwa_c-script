using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004084 RID: 16516
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Saomiao.GA_Motor_Saomiao_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Saomiao_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A834 RID: 174132 RVA: 0x009E2CC8 File Offset: 0x009E0EC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Saomiao_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Saomiao.GA_Motor_Saomiao_C");
			}
			return GA_Motor_Saomiao_C._ClassPtr;
		}

		// Token: 0x0602A835 RID: 174133 RVA: 0x009E2CEC File Offset: 0x009E0EEC
		public GA_Motor_Saomiao_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Saomiao_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A836 RID: 174134 RVA: 0x009E2D14 File Offset: 0x009E0F14
		[NullableContext(1)]
		public GA_Motor_Saomiao_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Saomiao_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x0602A837 RID: 174135 RVA: 0x009E2D47 File Offset: 0x009E0F47
		// (set) Token: 0x0602A838 RID: 174136 RVA: 0x009E2D5B File Offset: 0x009E0F5B
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Saomiao_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Saomiao_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A839 RID: 174137 RVA: 0x009E2D70 File Offset: 0x009E0F70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Saomiao_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A83A RID: 174138 RVA: 0x009E2D84 File Offset: 0x009E0F84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Saomiao_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A83B RID: 174139 RVA: 0x009E2D9C File Offset: 0x009E0F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Saomiao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Saomiao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A83C RID: 174140 RVA: 0x009E2DE4 File Offset: 0x009E0FE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Saomiao_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Saomiao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Saomiao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A83D RID: 174141 RVA: 0x009E2E2B File Offset: 0x009E102B
		protected GA_Motor_Saomiao_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F8A RID: 89994
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Saomiao.GA_Motor_Saomiao_C";

		// Token: 0x04015F8B RID: 89995
		private static IntPtr _ClassPtr;

		// Token: 0x04015F8C RID: 89996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F8D RID: 89997
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F8E RID: 89998
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F8F RID: 89999
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3BD RID: 41917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321AA RID: 205226
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
