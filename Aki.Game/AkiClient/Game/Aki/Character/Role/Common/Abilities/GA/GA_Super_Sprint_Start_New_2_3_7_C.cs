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
	// Token: 0x02004175 RID: 16757
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_3_7.GA_Super_Sprint_Start_New_2_3_7_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_2_3_7_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B5B7 RID: 177591 RVA: 0x009FE1B8 File Offset: 0x009FC3B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_2_3_7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_3_7.GA_Super_Sprint_Start_New_2_3_7_C");
			}
			return GA_Super_Sprint_Start_New_2_3_7_C._ClassPtr;
		}

		// Token: 0x0602B5B8 RID: 177592 RVA: 0x009FE1DC File Offset: 0x009FC3DC
		public GA_Super_Sprint_Start_New_2_3_7_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_3_7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B5B9 RID: 177593 RVA: 0x009FE204 File Offset: 0x009FC404
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_2_3_7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_2_3_7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AED RID: 27373
		// (get) Token: 0x0602B5BA RID: 177594 RVA: 0x009FE237 File Offset: 0x009FC437
		// (set) Token: 0x0602B5BB RID: 177595 RVA: 0x009FE247 File Offset: 0x009FC447
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AEE RID: 27374
		// (get) Token: 0x0602B5BC RID: 177596 RVA: 0x009FE258 File Offset: 0x009FC458
		// (set) Token: 0x0602B5BD RID: 177597 RVA: 0x009FE268 File Offset: 0x009FC468
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AEF RID: 27375
		// (get) Token: 0x0602B5BE RID: 177598 RVA: 0x009FE279 File Offset: 0x009FC479
		// (set) Token: 0x0602B5BF RID: 177599 RVA: 0x009FE289 File Offset: 0x009FC489
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF0 RID: 27376
		// (get) Token: 0x0602B5C0 RID: 177600 RVA: 0x009FE29A File Offset: 0x009FC49A
		// (set) Token: 0x0602B5C1 RID: 177601 RVA: 0x009FE2AA File Offset: 0x009FC4AA
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AF1 RID: 27377
		// (get) Token: 0x0602B5C2 RID: 177602 RVA: 0x009FE2BB File Offset: 0x009FC4BB
		// (set) Token: 0x0602B5C3 RID: 177603 RVA: 0x009FE2CB File Offset: 0x009FC4CB
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_2_3_7_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B5C4 RID: 177604 RVA: 0x009FE2DC File Offset: 0x009FC4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A334BBE8F3(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A334BBE8F3_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A334BBE8F3_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A334BBE8F3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A334BBE8F3_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A334BBE8F3_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5C5 RID: 177605 RVA: 0x009FE328 File Offset: 0x009FC528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A38640AC5B(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A38640AC5B_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A38640AC5B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A38640AC5B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A38640AC5B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A38640AC5B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5C6 RID: 177606 RVA: 0x009FE374 File Offset: 0x009FC574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A37240AC60(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A37240AC60_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A37240AC60_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A37240AC60_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A37240AC60_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__Added_21071CB943CD992BF8EFD6A37240AC60_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5C7 RID: 177607 RVA: 0x009FE3C0 File Offset: 0x009FC5C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3817810F34D(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__Removed_DB9F64004F8908FEAD99D3817810F34D_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__Removed_DB9F64004F8908FEAD99D3817810F34D_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__Removed_DB9F64004F8908FEAD99D3817810F34D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__Removed_DB9F64004F8908FEAD99D3817810F34D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__Removed_DB9F64004F8908FEAD99D3817810F34D_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5C8 RID: 177608 RVA: 0x009FE40B File Offset: 0x009FC60B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_4DDA91C940462EAE1936D49C7CE404DE()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnFinish_4DDA91C940462EAE1936D49C7CE404DE_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5C9 RID: 177609 RVA: 0x009FE41F File Offset: 0x009FC61F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8135400026()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnTick_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CA RID: 177610 RVA: 0x009FE433 File Offset: 0x009FC633
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8135400026()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnCancelled_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CB RID: 177611 RVA: 0x009FE447 File Offset: 0x009FC647
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8135400026()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnInterrupted_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CC RID: 177612 RVA: 0x009FE45B File Offset: 0x009FC65B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8135400026()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnBlendOut_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CD RID: 177613 RVA: 0x009FE46F File Offset: 0x009FC66F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8135400026()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__OnCompleted_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CE RID: 177614 RVA: 0x009FE483 File Offset: 0x009FC683
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5CF RID: 177615 RVA: 0x009FE497 File Offset: 0x009FC697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B5D0 RID: 177616 RVA: 0x009FE4AC File Offset: 0x009FC6AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5D1 RID: 177617 RVA: 0x009FE4F4 File Offset: 0x009FC6F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_2_3_7_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B5D2 RID: 177618 RVA: 0x009FE53B File Offset: 0x009FC73B
		protected GA_Super_Sprint_Start_New_2_3_7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168D4 RID: 92372
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_2_3_7.GA_Super_Sprint_Start_New_2_3_7_C";

		// Token: 0x040168D5 RID: 92373
		private static IntPtr _ClassPtr;

		// Token: 0x040168D6 RID: 92374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168D7 RID: 92375
		internal new static int __PropertyOffset_1;

		// Token: 0x040168D8 RID: 92376
		internal new static int __PropertyOffset_2;

		// Token: 0x040168D9 RID: 92377
		internal new static int __PropertyOffset_3;

		// Token: 0x040168DA RID: 92378
		internal static int __PropertyOffset_4;

		// Token: 0x040168DB RID: 92379
		internal static int __PropertyOffset_5;

		// Token: 0x040168DC RID: 92380
		private static IntPtr __Added_21071CB943CD992BF8EFD6A334BBE8F3_NativeFunctionPtr;

		// Token: 0x040168DD RID: 92381
		private static IntPtr __Added_21071CB943CD992BF8EFD6A38640AC5B_NativeFunctionPtr;

		// Token: 0x040168DE RID: 92382
		private static IntPtr __Added_21071CB943CD992BF8EFD6A37240AC60_NativeFunctionPtr;

		// Token: 0x040168DF RID: 92383
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3817810F34D_NativeFunctionPtr;

		// Token: 0x040168E0 RID: 92384
		private static IntPtr __OnFinish_4DDA91C940462EAE1936D49C7CE404DE_NativeFunctionPtr;

		// Token: 0x040168E1 RID: 92385
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr;

		// Token: 0x040168E2 RID: 92386
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr;

		// Token: 0x040168E3 RID: 92387
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr;

		// Token: 0x040168E4 RID: 92388
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr;

		// Token: 0x040168E5 RID: 92389
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8135400026_NativeFunctionPtr;

		// Token: 0x040168E6 RID: 92390
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040168E7 RID: 92391
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4F7 RID: 42231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A334BBE8F3_FunctionParams
		{
			// Token: 0x04032365 RID: 205669
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F8 RID: 42232
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A38640AC5B_FunctionParams
		{
			// Token: 0x04032366 RID: 205670
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F9 RID: 42233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A37240AC60_FunctionParams
		{
			// Token: 0x04032367 RID: 205671
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4FA RID: 42234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3817810F34D_FunctionParams
		{
			// Token: 0x04032368 RID: 205672
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4FB RID: 42235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032369 RID: 205673
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
