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
	// Token: 0x0200407E RID: 16510
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower.GA_Motor_Lower_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Motor_Lower_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A7A5 RID: 173989 RVA: 0x009E1D25 File Offset: 0x009DFF25
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Lower_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower.GA_Motor_Lower_C");
			}
			return GA_Motor_Lower_C._ClassPtr;
		}

		// Token: 0x0602A7A6 RID: 173990 RVA: 0x009E1D4C File Offset: 0x009DFF4C
		public GA_Motor_Lower_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A7A7 RID: 173991 RVA: 0x009E1D74 File Offset: 0x009DFF74
		[NullableContext(1)]
		public GA_Motor_Lower_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Lower_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x0602A7A8 RID: 173992 RVA: 0x009E1DA7 File Offset: 0x009DFFA7
		// (set) Token: 0x0602A7A9 RID: 173993 RVA: 0x009E1DB7 File Offset: 0x009DFFB7
		public unsafe bool 是否主动结束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Lower_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Lower_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x0602A7AA RID: 173994 RVA: 0x009E1DC8 File Offset: 0x009DFFC8
		// (set) Token: 0x0602A7AB RID: 173995 RVA: 0x009E1DDC File Offset: 0x009DFFDC
		[Nullable(2)]
		public unsafe TsBaseCharacter 驾驶员
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Lower_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602A7AC RID: 173996 RVA: 0x009E1DF1 File Offset: 0x009DFFF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B63C79509()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnTick_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7AD RID: 173997 RVA: 0x009E1E05 File Offset: 0x009E0005
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B63C79509()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7AE RID: 173998 RVA: 0x009E1E19 File Offset: 0x009E0019
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B63C79509()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7AF RID: 173999 RVA: 0x009E1E2D File Offset: 0x009E002D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B63C79509()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B0 RID: 174000 RVA: 0x009E1E41 File Offset: 0x009E0041
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B63C79509()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B1 RID: 174001 RVA: 0x009E1E55 File Offset: 0x009E0055
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B180B4D49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnTick_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B2 RID: 174002 RVA: 0x009E1E69 File Offset: 0x009E0069
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B180B4D49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B3 RID: 174003 RVA: 0x009E1E7D File Offset: 0x009E007D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B180B4D49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B4 RID: 174004 RVA: 0x009E1E91 File Offset: 0x009E0091
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B180B4D49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B5 RID: 174005 RVA: 0x009E1EA5 File Offset: 0x009E00A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B180B4D49()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B6 RID: 174006 RVA: 0x009E1EBC File Offset: 0x009E00BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3DA4D25FB(in FGameplayTag Tag)
		{
			GA_Motor_Lower_C.__Added_21071CB943CD992BF8EFD6A3DA4D25FB_FunctionParams* ptr = stackalloc GA_Motor_Lower_C.__Added_21071CB943CD992BF8EFD6A3DA4D25FB_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Motor_Lower_C.__Added_21071CB943CD992BF8EFD6A3DA4D25FB_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_C.__Added_21071CB943CD992BF8EFD6A3DA4D25FB_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__Added_21071CB943CD992BF8EFD6A3DA4D25FB_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A7B7 RID: 174007 RVA: 0x009E1F07 File Offset: 0x009E0107
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B5BC82BB6()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnTick_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B8 RID: 174008 RVA: 0x009E1F1B File Offset: 0x009E011B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B5BC82BB6()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7B9 RID: 174009 RVA: 0x009E1F2F File Offset: 0x009E012F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B5BC82BB6()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BA RID: 174010 RVA: 0x009E1F43 File Offset: 0x009E0143
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B5BC82BB6()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BB RID: 174011 RVA: 0x009E1F57 File Offset: 0x009E0157
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B5BC82BB6()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BC RID: 174012 RVA: 0x009E1F6B File Offset: 0x009E016B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BF18DAD51()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnTick_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BD RID: 174013 RVA: 0x009E1F7F File Offset: 0x009E017F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BF18DAD51()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BE RID: 174014 RVA: 0x009E1F93 File Offset: 0x009E0193
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BF18DAD51()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7BF RID: 174015 RVA: 0x009E1FA7 File Offset: 0x009E01A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BF18DAD51()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7C0 RID: 174016 RVA: 0x009E1FBB File Offset: 0x009E01BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BF18DAD51()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7C1 RID: 174017 RVA: 0x009E1FCF File Offset: 0x009E01CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A7C2 RID: 174018 RVA: 0x009E1FE3 File Offset: 0x009E01E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Lower_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A7C3 RID: 174019 RVA: 0x009E1FF8 File Offset: 0x009E01F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Lower_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A7C4 RID: 174020 RVA: 0x009E2040 File Offset: 0x009E0240
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Lower_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Lower_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Lower_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A7C5 RID: 174021 RVA: 0x009E2087 File Offset: 0x009E0287
		protected GA_Motor_Lower_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F1D RID: 89885
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Lower.GA_Motor_Lower_C";

		// Token: 0x04015F1E RID: 89886
		private static IntPtr _ClassPtr;

		// Token: 0x04015F1F RID: 89887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F20 RID: 89888
		internal new static int __PropertyOffset_1;

		// Token: 0x04015F21 RID: 89889
		internal new static int __PropertyOffset_2;

		// Token: 0x04015F22 RID: 89890
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr;

		// Token: 0x04015F23 RID: 89891
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr;

		// Token: 0x04015F24 RID: 89892
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr;

		// Token: 0x04015F25 RID: 89893
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr;

		// Token: 0x04015F26 RID: 89894
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B63C79509_NativeFunctionPtr;

		// Token: 0x04015F27 RID: 89895
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr;

		// Token: 0x04015F28 RID: 89896
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr;

		// Token: 0x04015F29 RID: 89897
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr;

		// Token: 0x04015F2A RID: 89898
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr;

		// Token: 0x04015F2B RID: 89899
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B180B4D49_NativeFunctionPtr;

		// Token: 0x04015F2C RID: 89900
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3DA4D25FB_NativeFunctionPtr;

		// Token: 0x04015F2D RID: 89901
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr;

		// Token: 0x04015F2E RID: 89902
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr;

		// Token: 0x04015F2F RID: 89903
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr;

		// Token: 0x04015F30 RID: 89904
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr;

		// Token: 0x04015F31 RID: 89905
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B5BC82BB6_NativeFunctionPtr;

		// Token: 0x04015F32 RID: 89906
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr;

		// Token: 0x04015F33 RID: 89907
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr;

		// Token: 0x04015F34 RID: 89908
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr;

		// Token: 0x04015F35 RID: 89909
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr;

		// Token: 0x04015F36 RID: 89910
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BF18DAD51_NativeFunctionPtr;

		// Token: 0x04015F37 RID: 89911
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F38 RID: 89912
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B4 RID: 41908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3DA4D25FB_FunctionParams
		{
			// Token: 0x040321A1 RID: 205217
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A3B5 RID: 41909
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321A2 RID: 205218
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
