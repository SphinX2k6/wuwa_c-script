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
	// Token: 0x02004091 RID: 16529
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao_Qte.GA_Motor_XuNengPao_Qte_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class GA_Motor_XuNengPao_Qte_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8FF RID: 174335 RVA: 0x009E45AC File Offset: 0x009E27AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_XuNengPao_Qte_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao_Qte.GA_Motor_XuNengPao_Qte_C");
			}
			return GA_Motor_XuNengPao_Qte_C._ClassPtr;
		}

		// Token: 0x0602A900 RID: 174336 RVA: 0x009E45D0 File Offset: 0x009E27D0
		public GA_Motor_XuNengPao_Qte_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_XuNengPao_Qte_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A901 RID: 174337 RVA: 0x009E45F8 File Offset: 0x009E27F8
		[NullableContext(1)]
		public GA_Motor_XuNengPao_Qte_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_XuNengPao_Qte_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x0602A902 RID: 174338 RVA: 0x009E462B File Offset: 0x009E282B
		// (set) Token: 0x0602A903 RID: 174339 RVA: 0x009E463F File Offset: 0x009E283F
		public unsafe AActor 被控物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x0602A904 RID: 174340 RVA: 0x009E4654 File Offset: 0x009E2854
		// (set) Token: 0x0602A905 RID: 174341 RVA: 0x009E4668 File Offset: 0x009E2868
		public unsafe FVectorDouble NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_XuNengPao_Qte_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_XuNengPao_Qte_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x0602A906 RID: 174342 RVA: 0x009E467D File Offset: 0x009E287D
		// (set) Token: 0x0602A907 RID: 174343 RVA: 0x009E4691 File Offset: 0x009E2891
		public unsafe TsBaseCharacter 驾驶员
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x0602A908 RID: 174344 RVA: 0x009E46A6 File Offset: 0x009E28A6
		// (set) Token: 0x0602A909 RID: 174345 RVA: 0x009E46BA File Offset: 0x009E28BA
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_Qte_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x0602A90A RID: 174346 RVA: 0x009E46CF File Offset: 0x009E28CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B5ADA6A96()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnTick_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr, null);
		}

		// Token: 0x0602A90B RID: 174347 RVA: 0x009E46E3 File Offset: 0x009E28E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B5ADA6A96()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr, null);
		}

		// Token: 0x0602A90C RID: 174348 RVA: 0x009E46F7 File Offset: 0x009E28F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B5ADA6A96()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr, null);
		}

		// Token: 0x0602A90D RID: 174349 RVA: 0x009E470B File Offset: 0x009E290B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B5ADA6A96()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr, null);
		}

		// Token: 0x0602A90E RID: 174350 RVA: 0x009E471F File Offset: 0x009E291F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B5ADA6A96()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr, null);
		}

		// Token: 0x0602A90F RID: 174351 RVA: 0x009E4733 File Offset: 0x009E2933
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B366C8F75()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnTick_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr, null);
		}

		// Token: 0x0602A910 RID: 174352 RVA: 0x009E4747 File Offset: 0x009E2947
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B366C8F75()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr, null);
		}

		// Token: 0x0602A911 RID: 174353 RVA: 0x009E475B File Offset: 0x009E295B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B366C8F75()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr, null);
		}

		// Token: 0x0602A912 RID: 174354 RVA: 0x009E476F File Offset: 0x009E296F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B366C8F75()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr, null);
		}

		// Token: 0x0602A913 RID: 174355 RVA: 0x009E4783 File Offset: 0x009E2983
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B366C8F75()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr, null);
		}

		// Token: 0x0602A914 RID: 174356 RVA: 0x009E4797 File Offset: 0x009E2997
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A915 RID: 174357 RVA: 0x009E47AB File Offset: 0x009E29AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A916 RID: 174358 RVA: 0x009E47C0 File Offset: 0x009E29C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A917 RID: 174359 RVA: 0x009E4808 File Offset: 0x009E2A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_XuNengPao_Qte_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A918 RID: 174360 RVA: 0x009E484F File Offset: 0x009E2A4F
		protected GA_Motor_XuNengPao_Qte_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401601E RID: 90142
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao_Qte.GA_Motor_XuNengPao_Qte_C";

		// Token: 0x0401601F RID: 90143
		private static IntPtr _ClassPtr;

		// Token: 0x04016020 RID: 90144
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016021 RID: 90145
		internal new static int __PropertyOffset_1;

		// Token: 0x04016022 RID: 90146
		internal new static int __PropertyOffset_2;

		// Token: 0x04016023 RID: 90147
		internal new static int __PropertyOffset_3;

		// Token: 0x04016024 RID: 90148
		internal static int __PropertyOffset_4;

		// Token: 0x04016025 RID: 90149
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr;

		// Token: 0x04016026 RID: 90150
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr;

		// Token: 0x04016027 RID: 90151
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr;

		// Token: 0x04016028 RID: 90152
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr;

		// Token: 0x04016029 RID: 90153
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B5ADA6A96_NativeFunctionPtr;

		// Token: 0x0401602A RID: 90154
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr;

		// Token: 0x0401602B RID: 90155
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr;

		// Token: 0x0401602C RID: 90156
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr;

		// Token: 0x0401602D RID: 90157
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr;

		// Token: 0x0401602E RID: 90158
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B366C8F75_NativeFunctionPtr;

		// Token: 0x0401602F RID: 90159
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016030 RID: 90160
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3CA RID: 41930
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B7 RID: 205239
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
