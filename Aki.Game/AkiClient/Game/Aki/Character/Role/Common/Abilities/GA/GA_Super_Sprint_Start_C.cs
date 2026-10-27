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
	// Token: 0x02004174 RID: 16756
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start.GA_Super_Sprint_Start_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1513)]
	public class GA_Super_Sprint_Start_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B5A5 RID: 177573 RVA: 0x009FDF0D File Offset: 0x009FC10D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start.GA_Super_Sprint_Start_C");
			}
			return GA_Super_Sprint_Start_C._ClassPtr;
		}

		// Token: 0x0602B5A6 RID: 177574 RVA: 0x009FDF34 File Offset: 0x009FC134
		public GA_Super_Sprint_Start_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B5A7 RID: 177575 RVA: 0x009FDF5C File Offset: 0x009FC15C
		[NullableContext(1)]
		public GA_Super_Sprint_Start_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AEC RID: 27372
		// (get) Token: 0x0602B5A8 RID: 177576 RVA: 0x009FDF8F File Offset: 0x009FC18F
		// (set) Token: 0x0602B5A9 RID: 177577 RVA: 0x009FDF9F File Offset: 0x009FC19F
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B5AA RID: 177578 RVA: 0x009FDFB0 File Offset: 0x009FC1B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E811D61BD8B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__OnTick_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5AB RID: 177579 RVA: 0x009FDFC4 File Offset: 0x009FC1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E811D61BD8B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__OnCancelled_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5AC RID: 177580 RVA: 0x009FDFD8 File Offset: 0x009FC1D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E811D61BD8B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__OnInterrupted_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5AD RID: 177581 RVA: 0x009FDFEC File Offset: 0x009FC1EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E811D61BD8B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__OnBlendOut_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5AE RID: 177582 RVA: 0x009FE000 File Offset: 0x009FC200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E811D61BD8B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__OnCompleted_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5AF RID: 177583 RVA: 0x009FE014 File Offset: 0x009FC214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A30E0EBC01(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A30E0EBC01_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A30E0EBC01_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A30E0EBC01_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A30E0EBC01_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A30E0EBC01_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5B0 RID: 177584 RVA: 0x009FE060 File Offset: 0x009FC260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A37029C5B8(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A37029C5B8_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A37029C5B8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A37029C5B8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A37029C5B8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__Added_21071CB943CD992BF8EFD6A37029C5B8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5B1 RID: 177585 RVA: 0x009FE0AC File Offset: 0x009FC2AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3810B5C7265(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_C.__Removed_DB9F64004F8908FEAD99D3810B5C7265_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_C.__Removed_DB9F64004F8908FEAD99D3810B5C7265_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_C.__Removed_DB9F64004F8908FEAD99D3810B5C7265_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_C.__Removed_DB9F64004F8908FEAD99D3810B5C7265_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__Removed_DB9F64004F8908FEAD99D3810B5C7265_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5B2 RID: 177586 RVA: 0x009FE0F7 File Offset: 0x009FC2F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5B3 RID: 177587 RVA: 0x009FE10B File Offset: 0x009FC30B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B5B4 RID: 177588 RVA: 0x009FE120 File Offset: 0x009FC320
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5B5 RID: 177589 RVA: 0x009FE168 File Offset: 0x009FC368
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B5B6 RID: 177590 RVA: 0x009FE1AF File Offset: 0x009FC3AF
		protected GA_Super_Sprint_Start_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168C6 RID: 92358
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start.GA_Super_Sprint_Start_C";

		// Token: 0x040168C7 RID: 92359
		private static IntPtr _ClassPtr;

		// Token: 0x040168C8 RID: 92360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168C9 RID: 92361
		internal new static int __PropertyOffset_1;

		// Token: 0x040168CA RID: 92362
		private static IntPtr __OnTick_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr;

		// Token: 0x040168CB RID: 92363
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr;

		// Token: 0x040168CC RID: 92364
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr;

		// Token: 0x040168CD RID: 92365
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr;

		// Token: 0x040168CE RID: 92366
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E811D61BD8B_NativeFunctionPtr;

		// Token: 0x040168CF RID: 92367
		private static IntPtr __Added_21071CB943CD992BF8EFD6A30E0EBC01_NativeFunctionPtr;

		// Token: 0x040168D0 RID: 92368
		private static IntPtr __Added_21071CB943CD992BF8EFD6A37029C5B8_NativeFunctionPtr;

		// Token: 0x040168D1 RID: 92369
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3810B5C7265_NativeFunctionPtr;

		// Token: 0x040168D2 RID: 92370
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040168D3 RID: 92371
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4F3 RID: 42227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A30E0EBC01_FunctionParams
		{
			// Token: 0x04032361 RID: 205665
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F4 RID: 42228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A37029C5B8_FunctionParams
		{
			// Token: 0x04032362 RID: 205666
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F5 RID: 42229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3810B5C7265_FunctionParams
		{
			// Token: 0x04032363 RID: 205667
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F6 RID: 42230
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032364 RID: 205668
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
