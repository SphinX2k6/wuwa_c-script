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
	// Token: 0x02004184 RID: 16772
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi_Environment.GA_WuYinQu_HuangShiGaoDi_Environment_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_WuYinQu_HuangShiGaoDi_Environment_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6E5 RID: 177893 RVA: 0x00A0078B File Offset: 0x009FE98B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_HuangShiGaoDi_Environment_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi_Environment.GA_WuYinQu_HuangShiGaoDi_Environment_C");
			}
			return GA_WuYinQu_HuangShiGaoDi_Environment_C._ClassPtr;
		}

		// Token: 0x0602B6E6 RID: 177894 RVA: 0x00A007B0 File Offset: 0x009FE9B0
		public GA_WuYinQu_HuangShiGaoDi_Environment_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi_Environment_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6E7 RID: 177895 RVA: 0x00A007D8 File Offset: 0x009FE9D8
		[NullableContext(1)]
		public GA_WuYinQu_HuangShiGaoDi_Environment_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi_Environment_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B1E RID: 27422
		// (get) Token: 0x0602B6E8 RID: 177896 RVA: 0x00A0080B File Offset: 0x009FEA0B
		// (set) Token: 0x0602B6E9 RID: 177897 RVA: 0x00A0081B File Offset: 0x009FEA1B
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi_Environment_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi_Environment_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B1F RID: 27423
		// (get) Token: 0x0602B6EA RID: 177898 RVA: 0x00A0082C File Offset: 0x009FEA2C
		// (set) Token: 0x0602B6EB RID: 177899 RVA: 0x00A0083C File Offset: 0x009FEA3C
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi_Environment_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi_Environment_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B6EC RID: 177900 RVA: 0x00A00850 File Offset: 0x009FEA50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B6ED RID: 177901 RVA: 0x00A00898 File Offset: 0x009FEA98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B6EE RID: 177902 RVA: 0x00A008DF File Offset: 0x009FEADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6EF RID: 177903 RVA: 0x00A008F3 File Offset: 0x009FEAF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi_Environment_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6F0 RID: 177904 RVA: 0x00A00908 File Offset: 0x009FEB08
		protected GA_WuYinQu_HuangShiGaoDi_Environment_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169AA RID: 92586
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi_Environment.GA_WuYinQu_HuangShiGaoDi_Environment_C";

		// Token: 0x040169AB RID: 92587
		private static IntPtr _ClassPtr;

		// Token: 0x040169AC RID: 92588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169AD RID: 92589
		internal new static int __PropertyOffset_1;

		// Token: 0x040169AE RID: 92590
		internal new static int __PropertyOffset_2;

		// Token: 0x040169AF RID: 92591
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040169B0 RID: 92592
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A523 RID: 42275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032391 RID: 205713
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
