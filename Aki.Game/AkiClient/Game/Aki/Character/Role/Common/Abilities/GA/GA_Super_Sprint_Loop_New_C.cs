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
	// Token: 0x02004172 RID: 16754
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop_New.GA_Super_Sprint_Loop_New_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1523)]
	public class GA_Super_Sprint_Loop_New_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B57F RID: 177535 RVA: 0x009FDA14 File Offset: 0x009FBC14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Loop_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop_New.GA_Super_Sprint_Loop_New_C");
			}
			return GA_Super_Sprint_Loop_New_C._ClassPtr;
		}

		// Token: 0x0602B580 RID: 177536 RVA: 0x009FDA38 File Offset: 0x009FBC38
		public GA_Super_Sprint_Loop_New_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Loop_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B581 RID: 177537 RVA: 0x009FDA60 File Offset: 0x009FBC60
		[NullableContext(1)]
		public GA_Super_Sprint_Loop_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Loop_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AE6 RID: 27366
		// (get) Token: 0x0602B582 RID: 177538 RVA: 0x009FDA93 File Offset: 0x009FBC93
		// (set) Token: 0x0602B583 RID: 177539 RVA: 0x009FDAA3 File Offset: 0x009FBCA3
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AE7 RID: 27367
		// (get) Token: 0x0602B584 RID: 177540 RVA: 0x009FDAB4 File Offset: 0x009FBCB4
		// (set) Token: 0x0602B585 RID: 177541 RVA: 0x009FDAC4 File Offset: 0x009FBCC4
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AE8 RID: 27368
		// (get) Token: 0x0602B586 RID: 177542 RVA: 0x009FDAD5 File Offset: 0x009FBCD5
		// (set) Token: 0x0602B587 RID: 177543 RVA: 0x009FDAE5 File Offset: 0x009FBCE5
		public unsafe float Block_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006AE9 RID: 27369
		// (get) Token: 0x0602B588 RID: 177544 RVA: 0x009FDAF6 File Offset: 0x009FBCF6
		// (set) Token: 0x0602B589 RID: 177545 RVA: 0x009FDB06 File Offset: 0x009FBD06
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AEA RID: 27370
		// (get) Token: 0x0602B58A RID: 177546 RVA: 0x009FDB17 File Offset: 0x009FBD17
		// (set) Token: 0x0602B58B RID: 177547 RVA: 0x009FDB27 File Offset: 0x009FBD27
		public unsafe bool 是否结束技能了
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AEB RID: 27371
		// (get) Token: 0x0602B58C RID: 177548 RVA: 0x009FDB38 File Offset: 0x009FBD38
		// (set) Token: 0x0602B58D RID: 177549 RVA: 0x009FDB48 File Offset: 0x009FBD48
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_New_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B58E RID: 177550 RVA: 0x009FDB5C File Offset: 0x009FBD5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3812D7418C1(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_New_C.__Removed_DB9F64004F8908FEAD99D3812D7418C1_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__Removed_DB9F64004F8908FEAD99D3812D7418C1_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__Removed_DB9F64004F8908FEAD99D3812D7418C1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__Removed_DB9F64004F8908FEAD99D3812D7418C1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__Removed_DB9F64004F8908FEAD99D3812D7418C1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B58F RID: 177551 RVA: 0x009FDBA8 File Offset: 0x009FBDA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3660641A9(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3660641A9_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3660641A9_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3660641A9_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3660641A9_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3660641A9_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B590 RID: 177552 RVA: 0x009FDBF4 File Offset: 0x009FBDF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3351F4890(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3351F4890_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3351F4890_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3351F4890_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3351F4890_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3351F4890_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B591 RID: 177553 RVA: 0x009FDC40 File Offset: 0x009FBE40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3E39B5E03(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3E39B5E03_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3E39B5E03_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3E39B5E03_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3E39B5E03_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__Added_21071CB943CD992BF8EFD6A3E39B5E03_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B592 RID: 177554 RVA: 0x009FDC8B File Offset: 0x009FBE8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_97D0EE2E47EAF7034F36A28B119A294B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnFinish_97D0EE2E47EAF7034F36A28B119A294B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B593 RID: 177555 RVA: 0x009FDC9F File Offset: 0x009FBE9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8100791CD4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnTick_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B594 RID: 177556 RVA: 0x009FDCB3 File Offset: 0x009FBEB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8100791CD4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnCancelled_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B595 RID: 177557 RVA: 0x009FDCC7 File Offset: 0x009FBEC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8100791CD4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnInterrupted_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B596 RID: 177558 RVA: 0x009FDCDB File Offset: 0x009FBEDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8100791CD4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnBlendOut_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B597 RID: 177559 RVA: 0x009FDCEF File Offset: 0x009FBEEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8100791CD4()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__OnCompleted_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr, null);
		}

		// Token: 0x0602B598 RID: 177560 RVA: 0x009FDD03 File Offset: 0x009FBF03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B599 RID: 177561 RVA: 0x009FDD17 File Offset: 0x009FBF17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B59A RID: 177562 RVA: 0x009FDD2C File Offset: 0x009FBF2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B59B RID: 177563 RVA: 0x009FDD74 File Offset: 0x009FBF74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Loop_New_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B59C RID: 177564 RVA: 0x009FDDBB File Offset: 0x009FBFBB
		protected GA_Super_Sprint_Loop_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168AB RID: 92331
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop_New.GA_Super_Sprint_Loop_New_C";

		// Token: 0x040168AC RID: 92332
		private static IntPtr _ClassPtr;

		// Token: 0x040168AD RID: 92333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168AE RID: 92334
		internal new static int __PropertyOffset_1;

		// Token: 0x040168AF RID: 92335
		internal new static int __PropertyOffset_2;

		// Token: 0x040168B0 RID: 92336
		internal new static int __PropertyOffset_3;

		// Token: 0x040168B1 RID: 92337
		internal static int __PropertyOffset_4;

		// Token: 0x040168B2 RID: 92338
		internal static int __PropertyOffset_5;

		// Token: 0x040168B3 RID: 92339
		internal static int __PropertyOffset_6;

		// Token: 0x040168B4 RID: 92340
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3812D7418C1_NativeFunctionPtr;

		// Token: 0x040168B5 RID: 92341
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3660641A9_NativeFunctionPtr;

		// Token: 0x040168B6 RID: 92342
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3351F4890_NativeFunctionPtr;

		// Token: 0x040168B7 RID: 92343
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3E39B5E03_NativeFunctionPtr;

		// Token: 0x040168B8 RID: 92344
		private static IntPtr __OnFinish_97D0EE2E47EAF7034F36A28B119A294B_NativeFunctionPtr;

		// Token: 0x040168B9 RID: 92345
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr;

		// Token: 0x040168BA RID: 92346
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr;

		// Token: 0x040168BB RID: 92347
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr;

		// Token: 0x040168BC RID: 92348
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr;

		// Token: 0x040168BD RID: 92349
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8100791CD4_NativeFunctionPtr;

		// Token: 0x040168BE RID: 92350
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040168BF RID: 92351
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4EC RID: 42220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3812D7418C1_FunctionParams
		{
			// Token: 0x0403235A RID: 205658
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4ED RID: 42221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3660641A9_FunctionParams
		{
			// Token: 0x0403235B RID: 205659
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4EE RID: 42222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3351F4890_FunctionParams
		{
			// Token: 0x0403235C RID: 205660
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4EF RID: 42223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3E39B5E03_FunctionParams
		{
			// Token: 0x0403235D RID: 205661
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F0 RID: 42224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403235E RID: 205662
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
