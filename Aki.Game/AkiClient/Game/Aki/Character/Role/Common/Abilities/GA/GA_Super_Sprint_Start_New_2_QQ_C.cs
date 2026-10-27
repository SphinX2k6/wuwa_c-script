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
	// Token: 0x02004177 RID: 16759
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_QQ.GA_Super_Sprint_Start_New_2_QQ_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_2_QQ_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B5EF RID: 177647 RVA: 0x009FE8D0 File Offset: 0x009FCAD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_2_QQ_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_QQ.GA_Super_Sprint_Start_New_2_QQ_C");
			}
			return GA_Super_Sprint_Start_New_2_QQ_C._ClassPtr;
		}

		// Token: 0x0602B5F0 RID: 177648 RVA: 0x009FE8F4 File Offset: 0x009FCAF4
		public GA_Super_Sprint_Start_New_2_QQ_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_QQ_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B5F1 RID: 177649 RVA: 0x009FE91C File Offset: 0x009FCB1C
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_2_QQ_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_QQ_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AF7 RID: 27383
		// (get) Token: 0x0602B5F2 RID: 177650 RVA: 0x009FE94F File Offset: 0x009FCB4F
		// (set) Token: 0x0602B5F3 RID: 177651 RVA: 0x009FE95F File Offset: 0x009FCB5F
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF8 RID: 27384
		// (get) Token: 0x0602B5F4 RID: 177652 RVA: 0x009FE970 File Offset: 0x009FCB70
		// (set) Token: 0x0602B5F5 RID: 177653 RVA: 0x009FE980 File Offset: 0x009FCB80
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF9 RID: 27385
		// (get) Token: 0x0602B5F6 RID: 177654 RVA: 0x009FE991 File Offset: 0x009FCB91
		// (set) Token: 0x0602B5F7 RID: 177655 RVA: 0x009FE9A1 File Offset: 0x009FCBA1
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AFA RID: 27386
		// (get) Token: 0x0602B5F8 RID: 177656 RVA: 0x009FE9B2 File Offset: 0x009FCBB2
		// (set) Token: 0x0602B5F9 RID: 177657 RVA: 0x009FE9C2 File Offset: 0x009FCBC2
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AFB RID: 27387
		// (get) Token: 0x0602B5FA RID: 177658 RVA: 0x009FE9D3 File Offset: 0x009FCBD3
		// (set) Token: 0x0602B5FB RID: 177659 RVA: 0x009FE9E3 File Offset: 0x009FCBE3
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_QQ_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B5FC RID: 177660 RVA: 0x009FE9F4 File Offset: 0x009FCBF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3D9A2EB78(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3D9A2EB78_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3D9A2EB78_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3D9A2EB78_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3D9A2EB78_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3D9A2EB78_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5FD RID: 177661 RVA: 0x009FEA40 File Offset: 0x009FCC40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3788C0011(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3788C0011_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3788C0011_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3788C0011_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3788C0011_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3788C0011_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5FE RID: 177662 RVA: 0x009FEA8C File Offset: 0x009FCC8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3F74324C2(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3F74324C2_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3F74324C2_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3F74324C2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3F74324C2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__Added_21071CB943CD992BF8EFD6A3F74324C2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5FF RID: 177663 RVA: 0x009FEAD8 File Offset: 0x009FCCD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3814D063E56(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__Removed_DB9F64004F8908FEAD99D3814D063E56_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__Removed_DB9F64004F8908FEAD99D3814D063E56_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__Removed_DB9F64004F8908FEAD99D3814D063E56_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__Removed_DB9F64004F8908FEAD99D3814D063E56_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__Removed_DB9F64004F8908FEAD99D3814D063E56_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B600 RID: 177664 RVA: 0x009FEB23 File Offset: 0x009FCD23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_5FE9619447779BD7B2D25B9196C55F40()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnFinish_5FE9619447779BD7B2D25B9196C55F40_NativeFunctionPtr, null);
		}

		// Token: 0x0602B601 RID: 177665 RVA: 0x009FEB37 File Offset: 0x009FCD37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81F7FD97D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnTick_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B602 RID: 177666 RVA: 0x009FEB4B File Offset: 0x009FCD4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81F7FD97D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnCancelled_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B603 RID: 177667 RVA: 0x009FEB5F File Offset: 0x009FCD5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81F7FD97D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnInterrupted_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B604 RID: 177668 RVA: 0x009FEB73 File Offset: 0x009FCD73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81F7FD97D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnBlendOut_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B605 RID: 177669 RVA: 0x009FEB87 File Offset: 0x009FCD87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81F7FD97D5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__OnCompleted_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B606 RID: 177670 RVA: 0x009FEB9B File Offset: 0x009FCD9B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B607 RID: 177671 RVA: 0x009FEBAF File Offset: 0x009FCDAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B608 RID: 177672 RVA: 0x009FEBC4 File Offset: 0x009FCDC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B609 RID: 177673 RVA: 0x009FEC0C File Offset: 0x009FCE0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B60A RID: 177674 RVA: 0x009FEC53 File Offset: 0x009FCE53
		protected GA_Super_Sprint_Start_New_2_QQ_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168FC RID: 92412
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_QQ.GA_Super_Sprint_Start_New_2_QQ_C";

		// Token: 0x040168FD RID: 92413
		private static IntPtr _ClassPtr;

		// Token: 0x040168FE RID: 92414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168FF RID: 92415
		internal new static int __PropertyOffset_1;

		// Token: 0x04016900 RID: 92416
		internal new static int __PropertyOffset_2;

		// Token: 0x04016901 RID: 92417
		internal new static int __PropertyOffset_3;

		// Token: 0x04016902 RID: 92418
		internal static int __PropertyOffset_4;

		// Token: 0x04016903 RID: 92419
		internal static int __PropertyOffset_5;

		// Token: 0x04016904 RID: 92420
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3D9A2EB78_NativeFunctionPtr;

		// Token: 0x04016905 RID: 92421
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3788C0011_NativeFunctionPtr;

		// Token: 0x04016906 RID: 92422
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3F74324C2_NativeFunctionPtr;

		// Token: 0x04016907 RID: 92423
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3814D063E56_NativeFunctionPtr;

		// Token: 0x04016908 RID: 92424
		private static IntPtr __OnFinish_5FE9619447779BD7B2D25B9196C55F40_NativeFunctionPtr;

		// Token: 0x04016909 RID: 92425
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr;

		// Token: 0x0401690A RID: 92426
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr;

		// Token: 0x0401690B RID: 92427
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr;

		// Token: 0x0401690C RID: 92428
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr;

		// Token: 0x0401690D RID: 92429
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81F7FD97D5_NativeFunctionPtr;

		// Token: 0x0401690E RID: 92430
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401690F RID: 92431
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A501 RID: 42241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3D9A2EB78_FunctionParams
		{
			// Token: 0x0403236F RID: 205679
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A502 RID: 42242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3788C0011_FunctionParams
		{
			// Token: 0x04032370 RID: 205680
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A503 RID: 42243
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3F74324C2_FunctionParams
		{
			// Token: 0x04032371 RID: 205681
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A504 RID: 42244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3814D063E56_FunctionParams
		{
			// Token: 0x04032372 RID: 205682
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A505 RID: 42245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032373 RID: 205683
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
