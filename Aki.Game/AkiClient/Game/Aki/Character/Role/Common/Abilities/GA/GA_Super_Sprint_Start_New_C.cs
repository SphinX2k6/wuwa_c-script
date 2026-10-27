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
	// Token: 0x02004179 RID: 16761
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New.GA_Super_Sprint_Start_New_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B627 RID: 177703 RVA: 0x009FEFE8 File Offset: 0x009FD1E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New.GA_Super_Sprint_Start_New_C");
			}
			return GA_Super_Sprint_Start_New_C._ClassPtr;
		}

		// Token: 0x0602B628 RID: 177704 RVA: 0x009FF00C File Offset: 0x009FD20C
		public GA_Super_Sprint_Start_New_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B629 RID: 177705 RVA: 0x009FF034 File Offset: 0x009FD234
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B01 RID: 27393
		// (get) Token: 0x0602B62A RID: 177706 RVA: 0x009FF067 File Offset: 0x009FD267
		// (set) Token: 0x0602B62B RID: 177707 RVA: 0x009FF077 File Offset: 0x009FD277
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B02 RID: 27394
		// (get) Token: 0x0602B62C RID: 177708 RVA: 0x009FF088 File Offset: 0x009FD288
		// (set) Token: 0x0602B62D RID: 177709 RVA: 0x009FF098 File Offset: 0x009FD298
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B03 RID: 27395
		// (get) Token: 0x0602B62E RID: 177710 RVA: 0x009FF0A9 File Offset: 0x009FD2A9
		// (set) Token: 0x0602B62F RID: 177711 RVA: 0x009FF0B9 File Offset: 0x009FD2B9
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B04 RID: 27396
		// (get) Token: 0x0602B630 RID: 177712 RVA: 0x009FF0CA File Offset: 0x009FD2CA
		// (set) Token: 0x0602B631 RID: 177713 RVA: 0x009FF0DA File Offset: 0x009FD2DA
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B05 RID: 27397
		// (get) Token: 0x0602B632 RID: 177714 RVA: 0x009FF0EB File Offset: 0x009FD2EB
		// (set) Token: 0x0602B633 RID: 177715 RVA: 0x009FF0FB File Offset: 0x009FD2FB
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B634 RID: 177716 RVA: 0x009FF10C File Offset: 0x009FD30C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3ABA4E8BA(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3ABA4E8BA_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3ABA4E8BA_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3ABA4E8BA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3ABA4E8BA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3ABA4E8BA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B635 RID: 177717 RVA: 0x009FF158 File Offset: 0x009FD358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A36D1729A6(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A36D1729A6_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A36D1729A6_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A36D1729A6_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A36D1729A6_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A36D1729A6_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B636 RID: 177718 RVA: 0x009FF1A4 File Offset: 0x009FD3A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3D35827D4(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3D35827D4_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3D35827D4_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3D35827D4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3D35827D4_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__Added_21071CB943CD992BF8EFD6A3D35827D4_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B637 RID: 177719 RVA: 0x009FF1F0 File Offset: 0x009FD3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381BBB8A764(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_C.__Removed_DB9F64004F8908FEAD99D381BBB8A764_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__Removed_DB9F64004F8908FEAD99D381BBB8A764_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__Removed_DB9F64004F8908FEAD99D381BBB8A764_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__Removed_DB9F64004F8908FEAD99D381BBB8A764_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__Removed_DB9F64004F8908FEAD99D381BBB8A764_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B638 RID: 177720 RVA: 0x009FF23B File Offset: 0x009FD43B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_9932D03940BD5B03E1B0449BB2547021()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnFinish_9932D03940BD5B03E1B0449BB2547021_NativeFunctionPtr, null);
		}

		// Token: 0x0602B639 RID: 177721 RVA: 0x009FF24F File Offset: 0x009FD44F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E819A8C94F3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnTick_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63A RID: 177722 RVA: 0x009FF263 File Offset: 0x009FD463
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E819A8C94F3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnCancelled_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63B RID: 177723 RVA: 0x009FF277 File Offset: 0x009FD477
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E819A8C94F3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnInterrupted_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63C RID: 177724 RVA: 0x009FF28B File Offset: 0x009FD48B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E819A8C94F3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnBlendOut_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63D RID: 177725 RVA: 0x009FF29F File Offset: 0x009FD49F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E819A8C94F3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__OnCompleted_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63E RID: 177726 RVA: 0x009FF2B3 File Offset: 0x009FD4B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B63F RID: 177727 RVA: 0x009FF2C7 File Offset: 0x009FD4C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B640 RID: 177728 RVA: 0x009FF2DC File Offset: 0x009FD4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B641 RID: 177729 RVA: 0x009FF324 File Offset: 0x009FD524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B642 RID: 177730 RVA: 0x009FF36B File Offset: 0x009FD56B
		protected GA_Super_Sprint_Start_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016924 RID: 92452
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New.GA_Super_Sprint_Start_New_C";

		// Token: 0x04016925 RID: 92453
		private static IntPtr _ClassPtr;

		// Token: 0x04016926 RID: 92454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016927 RID: 92455
		internal new static int __PropertyOffset_1;

		// Token: 0x04016928 RID: 92456
		internal new static int __PropertyOffset_2;

		// Token: 0x04016929 RID: 92457
		internal new static int __PropertyOffset_3;

		// Token: 0x0401692A RID: 92458
		internal static int __PropertyOffset_4;

		// Token: 0x0401692B RID: 92459
		internal static int __PropertyOffset_5;

		// Token: 0x0401692C RID: 92460
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3ABA4E8BA_NativeFunctionPtr;

		// Token: 0x0401692D RID: 92461
		private static IntPtr __Added_21071CB943CD992BF8EFD6A36D1729A6_NativeFunctionPtr;

		// Token: 0x0401692E RID: 92462
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3D35827D4_NativeFunctionPtr;

		// Token: 0x0401692F RID: 92463
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381BBB8A764_NativeFunctionPtr;

		// Token: 0x04016930 RID: 92464
		private static IntPtr __OnFinish_9932D03940BD5B03E1B0449BB2547021_NativeFunctionPtr;

		// Token: 0x04016931 RID: 92465
		private static IntPtr __OnTick_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr;

		// Token: 0x04016932 RID: 92466
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr;

		// Token: 0x04016933 RID: 92467
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr;

		// Token: 0x04016934 RID: 92468
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr;

		// Token: 0x04016935 RID: 92469
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E819A8C94F3_NativeFunctionPtr;

		// Token: 0x04016936 RID: 92470
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016937 RID: 92471
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A50B RID: 42251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3ABA4E8BA_FunctionParams
		{
			// Token: 0x04032379 RID: 205689
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A50C RID: 42252
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A36D1729A6_FunctionParams
		{
			// Token: 0x0403237A RID: 205690
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A50D RID: 42253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3D35827D4_FunctionParams
		{
			// Token: 0x0403237B RID: 205691
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A50E RID: 42254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381BBB8A764_FunctionParams
		{
			// Token: 0x0403237C RID: 205692
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A50F RID: 42255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403237D RID: 205693
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
