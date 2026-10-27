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
	// Token: 0x0200408C RID: 16524
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_NoCollision.GA_Motor_Stunt_NoCollision_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Stunt_NoCollision_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8A5 RID: 174245 RVA: 0x009E3B80 File Offset: 0x009E1D80
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Stunt_NoCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_NoCollision.GA_Motor_Stunt_NoCollision_C");
			}
			return GA_Motor_Stunt_NoCollision_C._ClassPtr;
		}

		// Token: 0x0602A8A6 RID: 174246 RVA: 0x009E3BA4 File Offset: 0x009E1DA4
		public GA_Motor_Stunt_NoCollision_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_NoCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A8A7 RID: 174247 RVA: 0x009E3BCC File Offset: 0x009E1DCC
		public GA_Motor_Stunt_NoCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_NoCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700684A RID: 26698
		// (get) Token: 0x0602A8A8 RID: 174248 RVA: 0x009E3BFF File Offset: 0x009E1DFF
		// (set) Token: 0x0602A8A9 RID: 174249 RVA: 0x009E3C13 File Offset: 0x009E1E13
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_NoCollision_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_NoCollision_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700684B RID: 26699
		// (get) Token: 0x0602A8AA RID: 174250 RVA: 0x009E3C28 File Offset: 0x009E1E28
		// (set) Token: 0x0602A8AB RID: 174251 RVA: 0x009E3C61 File Offset: 0x009E1E61
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_Stunt_NoCollision_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_Stunt_NoCollision_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A8AC RID: 174252 RVA: 0x009E3C82 File Offset: 0x009E1E82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B4491F765()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__OnTick_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8AD RID: 174253 RVA: 0x009E3C96 File Offset: 0x009E1E96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B4491F765()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8AE RID: 174254 RVA: 0x009E3CAA File Offset: 0x009E1EAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B4491F765()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8AF RID: 174255 RVA: 0x009E3CBE File Offset: 0x009E1EBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B4491F765()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8B0 RID: 174256 RVA: 0x009E3CD2 File Offset: 0x009E1ED2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B4491F765()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8B1 RID: 174257 RVA: 0x009E3CE6 File Offset: 0x009E1EE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8B2 RID: 174258 RVA: 0x009E3CFA File Offset: 0x009E1EFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8B3 RID: 174259 RVA: 0x009E3D10 File Offset: 0x009E1F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A8B4 RID: 174260 RVA: 0x009E3D58 File Offset: 0x009E1F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_NoCollision_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A8B5 RID: 174261 RVA: 0x009E3D9F File Offset: 0x009E1F9F
		protected GA_Motor_Stunt_NoCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FDB RID: 90075
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_NoCollision.GA_Motor_Stunt_NoCollision_C";

		// Token: 0x04015FDC RID: 90076
		private static IntPtr _ClassPtr;

		// Token: 0x04015FDD RID: 90077
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FDE RID: 90078
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FDF RID: 90079
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FE0 RID: 90080
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015FE1 RID: 90081
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr;

		// Token: 0x04015FE2 RID: 90082
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr;

		// Token: 0x04015FE3 RID: 90083
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr;

		// Token: 0x04015FE4 RID: 90084
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr;

		// Token: 0x04015FE5 RID: 90085
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B4491F765_NativeFunctionPtr;

		// Token: 0x04015FE6 RID: 90086
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FE7 RID: 90087
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C6 RID: 41926
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B3 RID: 205235
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
