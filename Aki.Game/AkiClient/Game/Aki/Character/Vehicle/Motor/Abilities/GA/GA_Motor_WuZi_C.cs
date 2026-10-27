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
	// Token: 0x0200408F RID: 16527
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Wuzi.GA_Motor_WuZi_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_WuZi_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8DB RID: 174299 RVA: 0x009E4193 File Offset: 0x009E2393
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_WuZi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Wuzi.GA_Motor_WuZi_C");
			}
			return GA_Motor_WuZi_C._ClassPtr;
		}

		// Token: 0x0602A8DC RID: 174300 RVA: 0x009E41B8 File Offset: 0x009E23B8
		public GA_Motor_WuZi_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_WuZi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A8DD RID: 174301 RVA: 0x009E41E0 File Offset: 0x009E23E0
		[NullableContext(1)]
		public GA_Motor_WuZi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_WuZi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006850 RID: 26704
		// (get) Token: 0x0602A8DE RID: 174302 RVA: 0x009E4213 File Offset: 0x009E2413
		// (set) Token: 0x0602A8DF RID: 174303 RVA: 0x009E4227 File Offset: 0x009E2427
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_WuZi_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_WuZi_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A8E0 RID: 174304 RVA: 0x009E423C File Offset: 0x009E243C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_WuZi_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8E1 RID: 174305 RVA: 0x009E4250 File Offset: 0x009E2450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_WuZi_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8E2 RID: 174306 RVA: 0x009E4268 File Offset: 0x009E2468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_WuZi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_WuZi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A8E3 RID: 174307 RVA: 0x009E42B0 File Offset: 0x009E24B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_WuZi_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_WuZi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_WuZi_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A8E4 RID: 174308 RVA: 0x009E42F7 File Offset: 0x009E24F7
		protected GA_Motor_WuZi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016005 RID: 90117
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Wuzi.GA_Motor_WuZi_C";

		// Token: 0x04016006 RID: 90118
		private static IntPtr _ClassPtr;

		// Token: 0x04016007 RID: 90119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016008 RID: 90120
		internal new static int __PropertyOffset_1;

		// Token: 0x04016009 RID: 90121
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401600A RID: 90122
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C8 RID: 41928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B5 RID: 205237
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
