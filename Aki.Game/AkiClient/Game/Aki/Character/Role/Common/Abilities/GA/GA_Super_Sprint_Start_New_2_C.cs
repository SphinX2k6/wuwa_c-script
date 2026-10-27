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
	// Token: 0x02004176 RID: 16758
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2.GA_Super_Sprint_Start_New_2_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_2_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B5D3 RID: 177619 RVA: 0x009FE544 File Offset: 0x009FC744
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2.GA_Super_Sprint_Start_New_2_C");
			}
			return GA_Super_Sprint_Start_New_2_C._ClassPtr;
		}

		// Token: 0x0602B5D4 RID: 177620 RVA: 0x009FE568 File Offset: 0x009FC768
		public GA_Super_Sprint_Start_New_2_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B5D5 RID: 177621 RVA: 0x009FE590 File Offset: 0x009FC790
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AF2 RID: 27378
		// (get) Token: 0x0602B5D6 RID: 177622 RVA: 0x009FE5C3 File Offset: 0x009FC7C3
		// (set) Token: 0x0602B5D7 RID: 177623 RVA: 0x009FE5D3 File Offset: 0x009FC7D3
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF3 RID: 27379
		// (get) Token: 0x0602B5D8 RID: 177624 RVA: 0x009FE5E4 File Offset: 0x009FC7E4
		// (set) Token: 0x0602B5D9 RID: 177625 RVA: 0x009FE5F4 File Offset: 0x009FC7F4
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF4 RID: 27380
		// (get) Token: 0x0602B5DA RID: 177626 RVA: 0x009FE605 File Offset: 0x009FC805
		// (set) Token: 0x0602B5DB RID: 177627 RVA: 0x009FE615 File Offset: 0x009FC815
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF5 RID: 27381
		// (get) Token: 0x0602B5DC RID: 177628 RVA: 0x009FE626 File Offset: 0x009FC826
		// (set) Token: 0x0602B5DD RID: 177629 RVA: 0x009FE636 File Offset: 0x009FC836
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF6 RID: 27382
		// (get) Token: 0x0602B5DE RID: 177630 RVA: 0x009FE647 File Offset: 0x009FC847
		// (set) Token: 0x0602B5DF RID: 177631 RVA: 0x009FE657 File Offset: 0x009FC857
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B5E0 RID: 177632 RVA: 0x009FE668 File Offset: 0x009FC868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A39F07CCF8(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A39F07CCF8_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A39F07CCF8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A39F07CCF8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A39F07CCF8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A39F07CCF8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5E1 RID: 177633 RVA: 0x009FE6B4 File Offset: 0x009FC8B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A30C14F14A(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A30C14F14A_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A30C14F14A_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A30C14F14A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A30C14F14A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A30C14F14A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5E2 RID: 177634 RVA: 0x009FE700 File Offset: 0x009FC900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A38B48ED17(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A38B48ED17_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A38B48ED17_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A38B48ED17_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A38B48ED17_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__Added_21071CB943CD992BF8EFD6A38B48ED17_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5E3 RID: 177635 RVA: 0x009FE74C File Offset: 0x009FC94C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38157E69CDD(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_C.__Removed_DB9F64004F8908FEAD99D38157E69CDD_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__Removed_DB9F64004F8908FEAD99D38157E69CDD_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__Removed_DB9F64004F8908FEAD99D38157E69CDD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__Removed_DB9F64004F8908FEAD99D38157E69CDD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__Removed_DB9F64004F8908FEAD99D38157E69CDD_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5E4 RID: 177636 RVA: 0x009FE797 File Offset: 0x009FC997
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_27CE4A214AF5F4C1386490B4DC5B38BD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnFinish_27CE4A214AF5F4C1386490B4DC5B38BD_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5E5 RID: 177637 RVA: 0x009FE7AB File Offset: 0x009FC9AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81C2BEF4CE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnTick_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5E6 RID: 177638 RVA: 0x009FE7BF File Offset: 0x009FC9BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81C2BEF4CE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnCancelled_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5E7 RID: 177639 RVA: 0x009FE7D3 File Offset: 0x009FC9D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81C2BEF4CE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnInterrupted_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5E8 RID: 177640 RVA: 0x009FE7E7 File Offset: 0x009FC9E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81C2BEF4CE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnBlendOut_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5E9 RID: 177641 RVA: 0x009FE7FB File Offset: 0x009FC9FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81C2BEF4CE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__OnCompleted_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5EA RID: 177642 RVA: 0x009FE80F File Offset: 0x009FCA0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5EB RID: 177643 RVA: 0x009FE823 File Offset: 0x009FCA23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B5EC RID: 177644 RVA: 0x009FE838 File Offset: 0x009FCA38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5ED RID: 177645 RVA: 0x009FE880 File Offset: 0x009FCA80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B5EE RID: 177646 RVA: 0x009FE8C7 File Offset: 0x009FCAC7
		protected GA_Super_Sprint_Start_New_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168E8 RID: 92392
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2.GA_Super_Sprint_Start_New_2_C";

		// Token: 0x040168E9 RID: 92393
		private static IntPtr _ClassPtr;

		// Token: 0x040168EA RID: 92394
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168EB RID: 92395
		internal new static int __PropertyOffset_1;

		// Token: 0x040168EC RID: 92396
		internal new static int __PropertyOffset_2;

		// Token: 0x040168ED RID: 92397
		internal new static int __PropertyOffset_3;

		// Token: 0x040168EE RID: 92398
		internal static int __PropertyOffset_4;

		// Token: 0x040168EF RID: 92399
		internal static int __PropertyOffset_5;

		// Token: 0x040168F0 RID: 92400
		private static IntPtr __Added_21071CB943CD992BF8EFD6A39F07CCF8_NativeFunctionPtr;

		// Token: 0x040168F1 RID: 92401
		private static IntPtr __Added_21071CB943CD992BF8EFD6A30C14F14A_NativeFunctionPtr;

		// Token: 0x040168F2 RID: 92402
		private static IntPtr __Added_21071CB943CD992BF8EFD6A38B48ED17_NativeFunctionPtr;

		// Token: 0x040168F3 RID: 92403
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38157E69CDD_NativeFunctionPtr;

		// Token: 0x040168F4 RID: 92404
		private static IntPtr __OnFinish_27CE4A214AF5F4C1386490B4DC5B38BD_NativeFunctionPtr;

		// Token: 0x040168F5 RID: 92405
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr;

		// Token: 0x040168F6 RID: 92406
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr;

		// Token: 0x040168F7 RID: 92407
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr;

		// Token: 0x040168F8 RID: 92408
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr;

		// Token: 0x040168F9 RID: 92409
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81C2BEF4CE_NativeFunctionPtr;

		// Token: 0x040168FA RID: 92410
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040168FB RID: 92411
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4FC RID: 42236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A39F07CCF8_FunctionParams
		{
			// Token: 0x0403236A RID: 205674
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4FD RID: 42237
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A30C14F14A_FunctionParams
		{
			// Token: 0x0403236B RID: 205675
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4FE RID: 42238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A38B48ED17_FunctionParams
		{
			// Token: 0x0403236C RID: 205676
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4FF RID: 42239
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38157E69CDD_FunctionParams
		{
			// Token: 0x0403236D RID: 205677
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A500 RID: 42240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403236E RID: 205678
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
