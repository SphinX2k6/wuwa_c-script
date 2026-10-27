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
	// Token: 0x02004178 RID: 16760
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_3_7.GA_Super_Sprint_Start_New_3_7_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_3_7_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B60B RID: 177675 RVA: 0x009FEC5C File Offset: 0x009FCE5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_3_7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_3_7.GA_Super_Sprint_Start_New_3_7_C");
			}
			return GA_Super_Sprint_Start_New_3_7_C._ClassPtr;
		}

		// Token: 0x0602B60C RID: 177676 RVA: 0x009FEC80 File Offset: 0x009FCE80
		public GA_Super_Sprint_Start_New_3_7_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_3_7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B60D RID: 177677 RVA: 0x009FECA8 File Offset: 0x009FCEA8
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_3_7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_3_7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AFC RID: 27388
		// (get) Token: 0x0602B60E RID: 177678 RVA: 0x009FECDB File Offset: 0x009FCEDB
		// (set) Token: 0x0602B60F RID: 177679 RVA: 0x009FECEB File Offset: 0x009FCEEB
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AFD RID: 27389
		// (get) Token: 0x0602B610 RID: 177680 RVA: 0x009FECFC File Offset: 0x009FCEFC
		// (set) Token: 0x0602B611 RID: 177681 RVA: 0x009FED0C File Offset: 0x009FCF0C
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AFE RID: 27390
		// (get) Token: 0x0602B612 RID: 177682 RVA: 0x009FED1D File Offset: 0x009FCF1D
		// (set) Token: 0x0602B613 RID: 177683 RVA: 0x009FED2D File Offset: 0x009FCF2D
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AFF RID: 27391
		// (get) Token: 0x0602B614 RID: 177684 RVA: 0x009FED3E File Offset: 0x009FCF3E
		// (set) Token: 0x0602B615 RID: 177685 RVA: 0x009FED4E File Offset: 0x009FCF4E
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B00 RID: 27392
		// (get) Token: 0x0602B616 RID: 177686 RVA: 0x009FED5F File Offset: 0x009FCF5F
		// (set) Token: 0x0602B617 RID: 177687 RVA: 0x009FED6F File Offset: 0x009FCF6F
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_3_7_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B618 RID: 177688 RVA: 0x009FED80 File Offset: 0x009FCF80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3C545DD96(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3C545DD96_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3C545DD96_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3C545DD96_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3C545DD96_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3C545DD96_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B619 RID: 177689 RVA: 0x009FEDCC File Offset: 0x009FCFCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3989CCF1C(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3989CCF1C_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3989CCF1C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3989CCF1C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3989CCF1C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3989CCF1C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B61A RID: 177690 RVA: 0x009FEE18 File Offset: 0x009FD018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3437CC69C(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3437CC69C_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3437CC69C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3437CC69C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3437CC69C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__Added_21071CB943CD992BF8EFD6A3437CC69C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B61B RID: 177691 RVA: 0x009FEE64 File Offset: 0x009FD064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38136DA13AE(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_3_7_C.__Removed_DB9F64004F8908FEAD99D38136DA13AE_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__Removed_DB9F64004F8908FEAD99D38136DA13AE_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__Removed_DB9F64004F8908FEAD99D38136DA13AE_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__Removed_DB9F64004F8908FEAD99D38136DA13AE_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__Removed_DB9F64004F8908FEAD99D38136DA13AE_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B61C RID: 177692 RVA: 0x009FEEAF File Offset: 0x009FD0AF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_B18836404F7DA4EC48F0B5BA7966035B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnFinish_B18836404F7DA4EC48F0B5BA7966035B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B61D RID: 177693 RVA: 0x009FEEC3 File Offset: 0x009FD0C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81F7C067D0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnTick_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B61E RID: 177694 RVA: 0x009FEED7 File Offset: 0x009FD0D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81F7C067D0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnCancelled_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B61F RID: 177695 RVA: 0x009FEEEB File Offset: 0x009FD0EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81F7C067D0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnInterrupted_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B620 RID: 177696 RVA: 0x009FEEFF File Offset: 0x009FD0FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81F7C067D0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnBlendOut_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B621 RID: 177697 RVA: 0x009FEF13 File Offset: 0x009FD113
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81F7C067D0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__OnCompleted_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B622 RID: 177698 RVA: 0x009FEF27 File Offset: 0x009FD127
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B623 RID: 177699 RVA: 0x009FEF3B File Offset: 0x009FD13B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B624 RID: 177700 RVA: 0x009FEF50 File Offset: 0x009FD150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B625 RID: 177701 RVA: 0x009FEF98 File Offset: 0x009FD198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B626 RID: 177702 RVA: 0x009FEFDF File Offset: 0x009FD1DF
		protected GA_Super_Sprint_Start_New_3_7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016910 RID: 92432
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_3_7.GA_Super_Sprint_Start_New_3_7_C";

		// Token: 0x04016911 RID: 92433
		private static IntPtr _ClassPtr;

		// Token: 0x04016912 RID: 92434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016913 RID: 92435
		internal new static int __PropertyOffset_1;

		// Token: 0x04016914 RID: 92436
		internal new static int __PropertyOffset_2;

		// Token: 0x04016915 RID: 92437
		internal new static int __PropertyOffset_3;

		// Token: 0x04016916 RID: 92438
		internal static int __PropertyOffset_4;

		// Token: 0x04016917 RID: 92439
		internal static int __PropertyOffset_5;

		// Token: 0x04016918 RID: 92440
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3C545DD96_NativeFunctionPtr;

		// Token: 0x04016919 RID: 92441
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3989CCF1C_NativeFunctionPtr;

		// Token: 0x0401691A RID: 92442
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3437CC69C_NativeFunctionPtr;

		// Token: 0x0401691B RID: 92443
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38136DA13AE_NativeFunctionPtr;

		// Token: 0x0401691C RID: 92444
		private static IntPtr __OnFinish_B18836404F7DA4EC48F0B5BA7966035B_NativeFunctionPtr;

		// Token: 0x0401691D RID: 92445
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr;

		// Token: 0x0401691E RID: 92446
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr;

		// Token: 0x0401691F RID: 92447
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr;

		// Token: 0x04016920 RID: 92448
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr;

		// Token: 0x04016921 RID: 92449
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81F7C067D0_NativeFunctionPtr;

		// Token: 0x04016922 RID: 92450
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016923 RID: 92451
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A506 RID: 42246
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3C545DD96_FunctionParams
		{
			// Token: 0x04032374 RID: 205684
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A507 RID: 42247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3989CCF1C_FunctionParams
		{
			// Token: 0x04032375 RID: 205685
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A508 RID: 42248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3437CC69C_FunctionParams
		{
			// Token: 0x04032376 RID: 205686
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A509 RID: 42249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38136DA13AE_FunctionParams
		{
			// Token: 0x04032377 RID: 205687
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A50A RID: 42250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032378 RID: 205688
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
