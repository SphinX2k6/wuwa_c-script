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
	// Token: 0x0200408A RID: 16522
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_End.GA_Motor_Stunt_End_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Stunt_End_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A883 RID: 174211 RVA: 0x009E3730 File Offset: 0x009E1930
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Stunt_End_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_End.GA_Motor_Stunt_End_C");
			}
			return GA_Motor_Stunt_End_C._ClassPtr;
		}

		// Token: 0x0602A884 RID: 174212 RVA: 0x009E3754 File Offset: 0x009E1954
		public GA_Motor_Stunt_End_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_End_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A885 RID: 174213 RVA: 0x009E377C File Offset: 0x009E197C
		public GA_Motor_Stunt_End_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Stunt_End_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006846 RID: 26694
		// (get) Token: 0x0602A886 RID: 174214 RVA: 0x009E37AF File Offset: 0x009E19AF
		// (set) Token: 0x0602A887 RID: 174215 RVA: 0x009E37C3 File Offset: 0x009E19C3
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_End_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Stunt_End_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006847 RID: 26695
		// (get) Token: 0x0602A888 RID: 174216 RVA: 0x009E37D8 File Offset: 0x009E19D8
		// (set) Token: 0x0602A889 RID: 174217 RVA: 0x009E3811 File Offset: 0x009E1A11
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_Stunt_End_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_Stunt_End_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A88A RID: 174218 RVA: 0x009E3832 File Offset: 0x009E1A32
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B8C82EA3B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__OnTick_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A88B RID: 174219 RVA: 0x009E3846 File Offset: 0x009E1A46
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B8C82EA3B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A88C RID: 174220 RVA: 0x009E385A File Offset: 0x009E1A5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B8C82EA3B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A88D RID: 174221 RVA: 0x009E386E File Offset: 0x009E1A6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B8C82EA3B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A88E RID: 174222 RVA: 0x009E3882 File Offset: 0x009E1A82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B8C82EA3B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A88F RID: 174223 RVA: 0x009E3896 File Offset: 0x009E1A96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A890 RID: 174224 RVA: 0x009E38AA File Offset: 0x009E1AAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A891 RID: 174225 RVA: 0x009E38C0 File Offset: 0x009E1AC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A892 RID: 174226 RVA: 0x009E3908 File Offset: 0x009E1B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Stunt_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Stunt_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Stunt_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A893 RID: 174227 RVA: 0x009E394F File Offset: 0x009E1B4F
		protected GA_Motor_Stunt_End_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015FC1 RID: 90049
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Stunt_End.GA_Motor_Stunt_End_C";

		// Token: 0x04015FC2 RID: 90050
		private static IntPtr _ClassPtr;

		// Token: 0x04015FC3 RID: 90051
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015FC4 RID: 90052
		internal new static int __PropertyOffset_1;

		// Token: 0x04015FC5 RID: 90053
		internal new static int __PropertyOffset_2;

		// Token: 0x04015FC6 RID: 90054
		[Nullable(2)]
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015FC7 RID: 90055
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr;

		// Token: 0x04015FC8 RID: 90056
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr;

		// Token: 0x04015FC9 RID: 90057
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr;

		// Token: 0x04015FCA RID: 90058
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr;

		// Token: 0x04015FCB RID: 90059
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B8C82EA3B_NativeFunctionPtr;

		// Token: 0x04015FCC RID: 90060
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015FCD RID: 90061
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C4 RID: 41924
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B1 RID: 205233
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
