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
	// Token: 0x0200408B RID: 16523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_Fall.GA_Motor_Stunt_Fall_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Stunt_Fall_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A894 RID: 174228 RVA: 0x009E3958 File Offset: 0x009E1B58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Stunt_Fall_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_Fall.GA_Motor_Stunt_Fall_C");
			}
			return GA_Motor_Stunt_Fall_C._ClassPtr;
		}

		// Token: 0x0602A895 RID: 174229 RVA: 0x009E397C File Offset: 0x009E1B7C
		public GA_Motor_Stunt_Fall_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_Fall_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A896 RID: 174230 RVA: 0x009E39A4 File Offset: 0x009E1BA4
		public GA_Motor_Stunt_Fall_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_Fall_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006848 RID: 26696
		// (get) Token: 0x0602A897 RID: 174231 RVA: 0x009E39D7 File Offset: 0x009E1BD7
		// (set) Token: 0x0602A898 RID: 174232 RVA: 0x009E39EB File Offset: 0x009E1BEB
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_Fall_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_Fall_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006849 RID: 26697
		// (get) Token: 0x0602A899 RID: 174233 RVA: 0x009E3A00 File Offset: 0x009E1C00
		// (set) Token: 0x0602A89A RID: 174234 RVA: 0x009E3A39 File Offset: 0x009E1C39
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_Stunt_Fall_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_Stunt_Fall_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A89B RID: 174235 RVA: 0x009E3A5A File Offset: 0x009E1C5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BE8CC028C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__OnTick_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A89C RID: 174236 RVA: 0x009E3A6E File Offset: 0x009E1C6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BE8CC028C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A89D RID: 174237 RVA: 0x009E3A82 File Offset: 0x009E1C82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BE8CC028C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A89E RID: 174238 RVA: 0x009E3A96 File Offset: 0x009E1C96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BE8CC028C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A89F RID: 174239 RVA: 0x009E3AAA File Offset: 0x009E1CAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BE8CC028C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8A0 RID: 174240 RVA: 0x009E3ABE File Offset: 0x009E1CBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8A1 RID: 174241 RVA: 0x009E3AD2 File Offset: 0x009E1CD2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8A2 RID: 174242 RVA: 0x009E3AE8 File Offset: 0x009E1CE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A8A3 RID: 174243 RVA: 0x009E3B30 File Offset: 0x009E1D30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_Fall_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A8A4 RID: 174244 RVA: 0x009E3B77 File Offset: 0x009E1D77
		protected GA_Motor_Stunt_Fall_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FCE RID: 90062
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_Fall.GA_Motor_Stunt_Fall_C";

		// Token: 0x04015FCF RID: 90063
		private static IntPtr _ClassPtr;

		// Token: 0x04015FD0 RID: 90064
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FD1 RID: 90065
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FD2 RID: 90066
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FD3 RID: 90067
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015FD4 RID: 90068
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr;

		// Token: 0x04015FD5 RID: 90069
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr;

		// Token: 0x04015FD6 RID: 90070
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr;

		// Token: 0x04015FD7 RID: 90071
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr;

		// Token: 0x04015FD8 RID: 90072
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BE8CC028C_NativeFunctionPtr;

		// Token: 0x04015FD9 RID: 90073
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FDA RID: 90074
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C5 RID: 41925
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B2 RID: 205234
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
