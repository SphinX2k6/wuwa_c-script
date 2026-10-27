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
	// Token: 0x02004080 RID: 16512
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_MotorSkill.GA_Motor_MotorSkill_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1572)]
	public class GA_Motor_MotorSkill_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A7DD RID: 174045 RVA: 0x009E2330 File Offset: 0x009E0530
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_MotorSkill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_MotorSkill.GA_Motor_MotorSkill_C");
			}
			return GA_Motor_MotorSkill_C._ClassPtr;
		}

		// Token: 0x0602A7DE RID: 174046 RVA: 0x009E2354 File Offset: 0x009E0554
		public GA_Motor_MotorSkill_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_MotorSkill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A7DF RID: 174047 RVA: 0x009E237C File Offset: 0x009E057C
		[NullableContext(1)]
		public GA_Motor_MotorSkill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_MotorSkill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x0602A7E0 RID: 174048 RVA: 0x009E23AF File Offset: 0x009E05AF
		// (set) Token: 0x0602A7E1 RID: 174049 RVA: 0x009E23C3 File Offset: 0x009E05C3
		public unsafe AActor 被控物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_MotorSkill_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_MotorSkill_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x0602A7E2 RID: 174050 RVA: 0x009E23D8 File Offset: 0x009E05D8
		// (set) Token: 0x0602A7E3 RID: 174051 RVA: 0x009E2411 File Offset: 0x009E0611
		[Nullable(1)]
		public FMotorBoostConfig 摩托_喷射与超速配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMotorBoostConfig result;
				if ((result = this._摩托_喷射与超速配置) == null)
				{
					result = (this._摩托_喷射与超速配置 = new FMotorBoostConfig(base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBoostConfig.StaticStruct(), base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x0602A7E4 RID: 174052 RVA: 0x009E2432 File Offset: 0x009E0632
		// (set) Token: 0x0602A7E5 RID: 174053 RVA: 0x009E2442 File Offset: 0x009E0642
		public unsafe float 起始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x0602A7E6 RID: 174054 RVA: 0x009E2453 File Offset: 0x009E0653
		// (set) Token: 0x0602A7E7 RID: 174055 RVA: 0x009E2467 File Offset: 0x009E0667
		public unsafe TsBaseCharacter 驾驶员
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_MotorSkill_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_MotorSkill_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x0602A7E8 RID: 174056 RVA: 0x009E247C File Offset: 0x009E067C
		// (set) Token: 0x0602A7E9 RID: 174057 RVA: 0x009E248C File Offset: 0x009E068C
		public unsafe float 起始Yaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_MotorSkill_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602A7EA RID: 174058 RVA: 0x009E249D File Offset: 0x009E069D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加BUFF()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__添加BUFF_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7EB RID: 174059 RVA: 0x009E24B1 File Offset: 0x009E06B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BD28C5FDC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnTick_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7EC RID: 174060 RVA: 0x009E24C5 File Offset: 0x009E06C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BD28C5FDC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7ED RID: 174061 RVA: 0x009E24D9 File Offset: 0x009E06D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BD28C5FDC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7EE RID: 174062 RVA: 0x009E24ED File Offset: 0x009E06ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BD28C5FDC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7EF RID: 174063 RVA: 0x009E2501 File Offset: 0x009E0701
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BD28C5FDC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F0 RID: 174064 RVA: 0x009E2515 File Offset: 0x009E0715
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BE8A81557()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnTick_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F1 RID: 174065 RVA: 0x009E2529 File Offset: 0x009E0729
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BE8A81557()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F2 RID: 174066 RVA: 0x009E253D File Offset: 0x009E073D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BE8A81557()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F3 RID: 174067 RVA: 0x009E2551 File Offset: 0x009E0751
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BE8A81557()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F4 RID: 174068 RVA: 0x009E2565 File Offset: 0x009E0765
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BE8A81557()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F5 RID: 174069 RVA: 0x009E2579 File Offset: 0x009E0779
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7F6 RID: 174070 RVA: 0x009E258D File Offset: 0x009E078D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A7F7 RID: 174071 RVA: 0x009E25A4 File Offset: 0x009E07A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_MotorSkill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A7F8 RID: 174072 RVA: 0x009E25EC File Offset: 0x009E07EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_MotorSkill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_MotorSkill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_MotorSkill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A7F9 RID: 174073 RVA: 0x009E2633 File Offset: 0x009E0833
		protected GA_Motor_MotorSkill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F4B RID: 89931
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_MotorSkill.GA_Motor_MotorSkill_C";

		// Token: 0x04015F4C RID: 89932
		private static IntPtr _ClassPtr;

		// Token: 0x04015F4D RID: 89933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F4E RID: 89934
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F4F RID: 89935
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F50 RID: 89936
		private FMotorBoostConfig _摩托_喷射与超速配置;

		// Token: 0x04015F51 RID: 89937
		internal new static int __PropertyOffset_3;

		// Token: 0x04015F52 RID: 89938
		internal static int __PropertyOffset_4;

		// Token: 0x04015F53 RID: 89939
		internal static int __PropertyOffset_5;

		// Token: 0x04015F54 RID: 89940
		private static IntPtr __添加BUFF_NativeFunctionPtr;

		// Token: 0x04015F55 RID: 89941
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr;

		// Token: 0x04015F56 RID: 89942
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr;

		// Token: 0x04015F57 RID: 89943
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr;

		// Token: 0x04015F58 RID: 89944
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr;

		// Token: 0x04015F59 RID: 89945
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BD28C5FDC_NativeFunctionPtr;

		// Token: 0x04015F5A RID: 89946
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr;

		// Token: 0x04015F5B RID: 89947
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr;

		// Token: 0x04015F5C RID: 89948
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr;

		// Token: 0x04015F5D RID: 89949
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr;

		// Token: 0x04015F5E RID: 89950
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BE8A81557_NativeFunctionPtr;

		// Token: 0x04015F5F RID: 89951
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F60 RID: 89952
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B8 RID: 41912
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A5 RID: 205221
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
