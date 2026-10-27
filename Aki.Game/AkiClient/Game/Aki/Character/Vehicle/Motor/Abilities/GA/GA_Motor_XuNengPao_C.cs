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
	// Token: 0x02004090 RID: 16528
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao.GA_Motor_XuNengPao_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class GA_Motor_XuNengPao_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A8E5 RID: 174309 RVA: 0x009E4300 File Offset: 0x009E2500
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_XuNengPao_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao.GA_Motor_XuNengPao_C");
			}
			return GA_Motor_XuNengPao_C._ClassPtr;
		}

		// Token: 0x0602A8E6 RID: 174310 RVA: 0x009E4324 File Offset: 0x009E2524
		public GA_Motor_XuNengPao_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_XuNengPao_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A8E7 RID: 174311 RVA: 0x009E434C File Offset: 0x009E254C
		[NullableContext(1)]
		public GA_Motor_XuNengPao_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_XuNengPao_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006851 RID: 26705
		// (get) Token: 0x0602A8E8 RID: 174312 RVA: 0x009E437F File Offset: 0x009E257F
		// (set) Token: 0x0602A8E9 RID: 174313 RVA: 0x009E4393 File Offset: 0x009E2593
		public unsafe AActor 被控物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006852 RID: 26706
		// (get) Token: 0x0602A8EA RID: 174314 RVA: 0x009E43A8 File Offset: 0x009E25A8
		// (set) Token: 0x0602A8EB RID: 174315 RVA: 0x009E43BC File Offset: 0x009E25BC
		public unsafe FVectorDouble NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_XuNengPao_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_XuNengPao_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006853 RID: 26707
		// (get) Token: 0x0602A8EC RID: 174316 RVA: 0x009E43D1 File Offset: 0x009E25D1
		// (set) Token: 0x0602A8ED RID: 174317 RVA: 0x009E43E5 File Offset: 0x009E25E5
		public unsafe TsBaseCharacter 驾驶员
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x0602A8EE RID: 174318 RVA: 0x009E43FA File Offset: 0x009E25FA
		// (set) Token: 0x0602A8EF RID: 174319 RVA: 0x009E440E File Offset: 0x009E260E
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_XuNengPao_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x0602A8F0 RID: 174320 RVA: 0x009E4423 File Offset: 0x009E2623
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B63F2FC9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnTick_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F1 RID: 174321 RVA: 0x009E4437 File Offset: 0x009E2637
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B63F2FC9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F2 RID: 174322 RVA: 0x009E444B File Offset: 0x009E264B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B63F2FC9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F3 RID: 174323 RVA: 0x009E445F File Offset: 0x009E265F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B63F2FC9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F4 RID: 174324 RVA: 0x009E4473 File Offset: 0x009E2673
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B63F2FC9B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F5 RID: 174325 RVA: 0x009E4487 File Offset: 0x009E2687
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BF1DC2867()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnTick_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F6 RID: 174326 RVA: 0x009E449B File Offset: 0x009E269B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BF1DC2867()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F7 RID: 174327 RVA: 0x009E44AF File Offset: 0x009E26AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BF1DC2867()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F8 RID: 174328 RVA: 0x009E44C3 File Offset: 0x009E26C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BF1DC2867()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8F9 RID: 174329 RVA: 0x009E44D7 File Offset: 0x009E26D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BF1DC2867()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8FA RID: 174330 RVA: 0x009E44EB File Offset: 0x009E26EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A8FB RID: 174331 RVA: 0x009E44FF File Offset: 0x009E26FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A8FC RID: 174332 RVA: 0x009E4514 File Offset: 0x009E2714
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_XuNengPao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A8FD RID: 174333 RVA: 0x009E455C File Offset: 0x009E275C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_XuNengPao_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_XuNengPao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_XuNengPao_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A8FE RID: 174334 RVA: 0x009E45A3 File Offset: 0x009E27A3
		protected GA_Motor_XuNengPao_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401600B RID: 90123
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_XuNengPao.GA_Motor_XuNengPao_C";

		// Token: 0x0401600C RID: 90124
		private static IntPtr _ClassPtr;

		// Token: 0x0401600D RID: 90125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401600E RID: 90126
		internal new static int __PropertyOffset_1;

		// Token: 0x0401600F RID: 90127
		internal new static int __PropertyOffset_2;

		// Token: 0x04016010 RID: 90128
		internal new static int __PropertyOffset_3;

		// Token: 0x04016011 RID: 90129
		internal static int __PropertyOffset_4;

		// Token: 0x04016012 RID: 90130
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr;

		// Token: 0x04016013 RID: 90131
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr;

		// Token: 0x04016014 RID: 90132
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr;

		// Token: 0x04016015 RID: 90133
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr;

		// Token: 0x04016016 RID: 90134
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B63F2FC9B_NativeFunctionPtr;

		// Token: 0x04016017 RID: 90135
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr;

		// Token: 0x04016018 RID: 90136
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr;

		// Token: 0x04016019 RID: 90137
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr;

		// Token: 0x0401601A RID: 90138
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr;

		// Token: 0x0401601B RID: 90139
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BF1DC2867_NativeFunctionPtr;

		// Token: 0x0401601C RID: 90140
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401601D RID: 90141
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3C9 RID: 41929
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321B6 RID: 205238
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
