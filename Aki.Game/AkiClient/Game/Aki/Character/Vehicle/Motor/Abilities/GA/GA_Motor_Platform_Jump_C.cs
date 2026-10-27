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
	// Token: 0x02004082 RID: 16514
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Jump.GA_Motor_Platform_Jump_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Platform_Jump_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A807 RID: 174087 RVA: 0x009E27DC File Offset: 0x009E09DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Platform_Jump_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Jump.GA_Motor_Platform_Jump_C");
			}
			return GA_Motor_Platform_Jump_C._ClassPtr;
		}

		// Token: 0x0602A808 RID: 174088 RVA: 0x009E2800 File Offset: 0x009E0A00
		public GA_Motor_Platform_Jump_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_Jump_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A809 RID: 174089 RVA: 0x009E2828 File Offset: 0x009E0A28
		[NullableContext(1)]
		public GA_Motor_Platform_Jump_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Platform_Jump_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x0602A80A RID: 174090 RVA: 0x009E285B File Offset: 0x009E0A5B
		// (set) Token: 0x0602A80B RID: 174091 RVA: 0x009E286B File Offset: 0x009E0A6B
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700683A RID: 26682
		// (get) Token: 0x0602A80C RID: 174092 RVA: 0x009E287C File Offset: 0x009E0A7C
		// (set) Token: 0x0602A80D RID: 174093 RVA: 0x009E2890 File Offset: 0x009E0A90
		public unsafe TsBaseCharacter 驾驶员
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Jump_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Jump_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x0602A80E RID: 174094 RVA: 0x009E28A5 File Offset: 0x009E0AA5
		// (set) Token: 0x0602A80F RID: 174095 RVA: 0x009E28B5 File Offset: 0x009E0AB5
		public unsafe bool 是否进入了Catapult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x0602A810 RID: 174096 RVA: 0x009E28C6 File Offset: 0x009E0AC6
		// (set) Token: 0x0602A811 RID: 174097 RVA: 0x009E28D6 File Offset: 0x009E0AD6
		public unsafe bool 接Idle技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700683D RID: 26685
		// (get) Token: 0x0602A812 RID: 174098 RVA: 0x009E28E7 File Offset: 0x009E0AE7
		// (set) Token: 0x0602A813 RID: 174099 RVA: 0x009E28FB File Offset: 0x009E0AFB
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Platform_Jump_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x0602A814 RID: 174100 RVA: 0x009E2910 File Offset: 0x009E0B10
		// (set) Token: 0x0602A815 RID: 174101 RVA: 0x009E2924 File Offset: 0x009E0B24
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Jump_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Platform_Jump_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x0602A816 RID: 174102 RVA: 0x009E2939 File Offset: 0x009E0B39
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NewFunction_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__NewFunction_0_NativeFunctionPtr, null);
		}

		// Token: 0x0602A817 RID: 174103 RVA: 0x009E294D File Offset: 0x009E0B4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B6249659C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnTick_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A818 RID: 174104 RVA: 0x009E2961 File Offset: 0x009E0B61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B6249659C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A819 RID: 174105 RVA: 0x009E2975 File Offset: 0x009E0B75
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B6249659C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81A RID: 174106 RVA: 0x009E2989 File Offset: 0x009E0B89
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B6249659C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81B RID: 174107 RVA: 0x009E299D File Offset: 0x009E0B9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B6249659C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81C RID: 174108 RVA: 0x009E29B1 File Offset: 0x009E0BB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B8AB9B05C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnTick_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81D RID: 174109 RVA: 0x009E29C5 File Offset: 0x009E0BC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B8AB9B05C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81E RID: 174110 RVA: 0x009E29D9 File Offset: 0x009E0BD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B8AB9B05C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A81F RID: 174111 RVA: 0x009E29ED File Offset: 0x009E0BED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B8AB9B05C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A820 RID: 174112 RVA: 0x009E2A01 File Offset: 0x009E0C01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B8AB9B05C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr, null);
		}

		// Token: 0x0602A821 RID: 174113 RVA: 0x009E2A15 File Offset: 0x009E0C15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_9688557C424F8F0C8B36328604685B6B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnFinish_9688557C424F8F0C8B36328604685B6B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A822 RID: 174114 RVA: 0x009E2A29 File Offset: 0x009E0C29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_9688557C424F8F0C8B36328604685B6B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnTick_9688557C424F8F0C8B36328604685B6B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A823 RID: 174115 RVA: 0x009E2A3D File Offset: 0x009E0C3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_F9B3D327463A6F8C1B7239BE43C2B3D1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnFinish_F9B3D327463A6F8C1B7239BE43C2B3D1_NativeFunctionPtr, null);
		}

		// Token: 0x0602A824 RID: 174116 RVA: 0x009E2A51 File Offset: 0x009E0C51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_F9B3D327463A6F8C1B7239BE43C2B3D1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnTick_F9B3D327463A6F8C1B7239BE43C2B3D1_NativeFunctionPtr, null);
		}

		// Token: 0x0602A825 RID: 174117 RVA: 0x009E2A65 File Offset: 0x009E0C65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_91580C824CDF48A611FAD484BAC206DC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__OnFinish_91580C824CDF48A611FAD484BAC206DC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A826 RID: 174118 RVA: 0x009E2A79 File Offset: 0x009E0C79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A827 RID: 174119 RVA: 0x009E2A8D File Offset: 0x009E0C8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A828 RID: 174120 RVA: 0x009E2AA4 File Offset: 0x009E0CA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A829 RID: 174121 RVA: 0x009E2AEC File Offset: 0x009E0CEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Platform_Jump_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Platform_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Platform_Jump_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A82A RID: 174122 RVA: 0x009E2B33 File Offset: 0x009E0D33
		protected GA_Motor_Platform_Jump_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F69 RID: 89961
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Platform_Jump.GA_Motor_Platform_Jump_C";

		// Token: 0x04015F6A RID: 89962
		private static IntPtr _ClassPtr;

		// Token: 0x04015F6B RID: 89963
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F6C RID: 89964
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F6D RID: 89965
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F6E RID: 89966
		internal new static int __PropertyOffset_3;

		// Token: 0x04015F6F RID: 89967
		internal static int __PropertyOffset_4;

		// Token: 0x04015F70 RID: 89968
		internal static int __PropertyOffset_5;

		// Token: 0x04015F71 RID: 89969
		internal static int __PropertyOffset_6;

		// Token: 0x04015F72 RID: 89970
		private static IntPtr __NewFunction_0_NativeFunctionPtr;

		// Token: 0x04015F73 RID: 89971
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr;

		// Token: 0x04015F74 RID: 89972
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr;

		// Token: 0x04015F75 RID: 89973
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr;

		// Token: 0x04015F76 RID: 89974
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr;

		// Token: 0x04015F77 RID: 89975
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B6249659C_NativeFunctionPtr;

		// Token: 0x04015F78 RID: 89976
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr;

		// Token: 0x04015F79 RID: 89977
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr;

		// Token: 0x04015F7A RID: 89978
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr;

		// Token: 0x04015F7B RID: 89979
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr;

		// Token: 0x04015F7C RID: 89980
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B8AB9B05C_NativeFunctionPtr;

		// Token: 0x04015F7D RID: 89981
		private static IntPtr __OnFinish_9688557C424F8F0C8B36328604685B6B_NativeFunctionPtr;

		// Token: 0x04015F7E RID: 89982
		private static IntPtr __OnTick_9688557C424F8F0C8B36328604685B6B_NativeFunctionPtr;

		// Token: 0x04015F7F RID: 89983
		private static IntPtr __OnFinish_F9B3D327463A6F8C1B7239BE43C2B3D1_NativeFunctionPtr;

		// Token: 0x04015F80 RID: 89984
		private static IntPtr __OnTick_F9B3D327463A6F8C1B7239BE43C2B3D1_NativeFunctionPtr;

		// Token: 0x04015F81 RID: 89985
		private static IntPtr __OnFinish_91580C824CDF48A611FAD484BAC206DC_NativeFunctionPtr;

		// Token: 0x04015F82 RID: 89986
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F83 RID: 89987
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3BA RID: 41914
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A7 RID: 205223
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
