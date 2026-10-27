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
	// Token: 0x0200406E RID: 16494
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Exit_Fly.GA_Motor_Exit_Fly_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Motor_Exit_Fly_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5FA RID: 173562 RVA: 0x009DECB4 File Offset: 0x009DCEB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Exit_Fly_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Exit_Fly.GA_Motor_Exit_Fly_C");
			}
			return GA_Motor_Exit_Fly_C._ClassPtr;
		}

		// Token: 0x0602A5FB RID: 173563 RVA: 0x009DECD8 File Offset: 0x009DCED8
		public GA_Motor_Exit_Fly_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Exit_Fly_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5FC RID: 173564 RVA: 0x009DED00 File Offset: 0x009DCF00
		[NullableContext(1)]
		public GA_Motor_Exit_Fly_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Exit_Fly_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067DA RID: 26586
		// (get) Token: 0x0602A5FD RID: 173565 RVA: 0x009DED33 File Offset: 0x009DCF33
		// (set) Token: 0x0602A5FE RID: 173566 RVA: 0x009DED47 File Offset: 0x009DCF47
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Exit_Fly_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Exit_Fly_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A5FF RID: 173567 RVA: 0x009DED5C File Offset: 0x009DCF5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Exit_Fly_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A600 RID: 173568 RVA: 0x009DED70 File Offset: 0x009DCF70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Exit_Fly_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A601 RID: 173569 RVA: 0x009DED88 File Offset: 0x009DCF88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Exit_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Exit_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A602 RID: 173570 RVA: 0x009DEDD0 File Offset: 0x009DCFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Exit_Fly_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Exit_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Exit_Fly_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A603 RID: 173571 RVA: 0x009DEE17 File Offset: 0x009DD017
		protected GA_Motor_Exit_Fly_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DF2 RID: 89586
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Exit_Fly.GA_Motor_Exit_Fly_C";

		// Token: 0x04015DF3 RID: 89587
		private static IntPtr _ClassPtr;

		// Token: 0x04015DF4 RID: 89588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DF5 RID: 89589
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DF6 RID: 89590
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DF7 RID: 89591
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A38F RID: 41871
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032177 RID: 205175
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
