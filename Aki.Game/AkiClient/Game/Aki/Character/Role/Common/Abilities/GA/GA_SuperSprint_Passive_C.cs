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
	// Token: 0x0200416B RID: 16747
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive.GA_SuperSprint_Passive_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_SuperSprint_Passive_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B502 RID: 177410 RVA: 0x009FC6A8 File Offset: 0x009FA8A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SuperSprint_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive.GA_SuperSprint_Passive_C");
			}
			return GA_SuperSprint_Passive_C._ClassPtr;
		}

		// Token: 0x0602B503 RID: 177411 RVA: 0x009FC6CC File Offset: 0x009FA8CC
		public GA_SuperSprint_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_SuperSprint_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B504 RID: 177412 RVA: 0x009FC6F4 File Offset: 0x009FA8F4
		[NullableContext(1)]
		public GA_SuperSprint_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SuperSprint_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B505 RID: 177413 RVA: 0x009FC728 File Offset: 0x009FA928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A392FC0505(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A392FC0505_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A392FC0505_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A392FC0505_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A392FC0505_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A392FC0505_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B506 RID: 177414 RVA: 0x009FC774 File Offset: 0x009FA974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38190205F77(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38190205F77_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38190205F77_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38190205F77_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38190205F77_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38190205F77_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B507 RID: 177415 RVA: 0x009FC7C0 File Offset: 0x009FA9C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3B2391EA2(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A3B2391EA2_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A3B2391EA2_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A3B2391EA2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A3B2391EA2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Added_21071CB943CD992BF8EFD6A3B2391EA2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B508 RID: 177416 RVA: 0x009FC80C File Offset: 0x009FAA0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3813E85AA71(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3813E85AA71_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3813E85AA71_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3813E85AA71_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3813E85AA71_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3813E85AA71_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B509 RID: 177417 RVA: 0x009FC858 File Offset: 0x009FAA58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381D963214C(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381D963214C_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381D963214C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381D963214C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381D963214C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381D963214C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B50A RID: 177418 RVA: 0x009FC8A4 File Offset: 0x009FAAA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38102C28DD9(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38102C28DD9_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38102C28DD9_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38102C28DD9_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38102C28DD9_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38102C28DD9_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B50B RID: 177419 RVA: 0x009FC8F0 File Offset: 0x009FAAF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381A06BE60F(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381A06BE60F_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381A06BE60F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381A06BE60F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381A06BE60F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381A06BE60F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B50C RID: 177420 RVA: 0x009FC93C File Offset: 0x009FAB3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3811399D330(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3811399D330_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3811399D330_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3811399D330_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3811399D330_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D3811399D330_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B50D RID: 177421 RVA: 0x009FC988 File Offset: 0x009FAB88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381FA852B9F(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381FA852B9F_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381FA852B9F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381FA852B9F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381FA852B9F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__Removed_DB9F64004F8908FEAD99D381FA852B9F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B50E RID: 177422 RVA: 0x009FC9D3 File Offset: 0x009FABD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_84E4D1EA47326B44391C1D810088F11A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__OnFinish_84E4D1EA47326B44391C1D810088F11A_NativeFunctionPtr, null);
		}

		// Token: 0x0602B50F RID: 177423 RVA: 0x009FC9E7 File Offset: 0x009FABE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B510 RID: 177424 RVA: 0x009FC9FB File Offset: 0x009FABFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SuperSprint_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B511 RID: 177425 RVA: 0x009FCA10 File Offset: 0x009FAC10
		protected GA_SuperSprint_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401684A RID: 92234
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive.GA_SuperSprint_Passive_C";

		// Token: 0x0401684B RID: 92235
		private static IntPtr _ClassPtr;

		// Token: 0x0401684C RID: 92236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401684D RID: 92237
		private static IntPtr __Added_21071CB943CD992BF8EFD6A392FC0505_NativeFunctionPtr;

		// Token: 0x0401684E RID: 92238
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38190205F77_NativeFunctionPtr;

		// Token: 0x0401684F RID: 92239
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3B2391EA2_NativeFunctionPtr;

		// Token: 0x04016850 RID: 92240
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3813E85AA71_NativeFunctionPtr;

		// Token: 0x04016851 RID: 92241
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381D963214C_NativeFunctionPtr;

		// Token: 0x04016852 RID: 92242
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38102C28DD9_NativeFunctionPtr;

		// Token: 0x04016853 RID: 92243
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381A06BE60F_NativeFunctionPtr;

		// Token: 0x04016854 RID: 92244
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3811399D330_NativeFunctionPtr;

		// Token: 0x04016855 RID: 92245
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381FA852B9F_NativeFunctionPtr;

		// Token: 0x04016856 RID: 92246
		private static IntPtr __OnFinish_84E4D1EA47326B44391C1D810088F11A_NativeFunctionPtr;

		// Token: 0x04016857 RID: 92247
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4CB RID: 42187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A392FC0505_FunctionParams
		{
			// Token: 0x04032339 RID: 205625
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4CC RID: 42188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38190205F77_FunctionParams
		{
			// Token: 0x0403233A RID: 205626
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4CD RID: 42189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3B2391EA2_FunctionParams
		{
			// Token: 0x0403233B RID: 205627
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4CE RID: 42190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3813E85AA71_FunctionParams
		{
			// Token: 0x0403233C RID: 205628
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4CF RID: 42191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381D963214C_FunctionParams
		{
			// Token: 0x0403233D RID: 205629
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D0 RID: 42192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38102C28DD9_FunctionParams
		{
			// Token: 0x0403233E RID: 205630
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D1 RID: 42193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381A06BE60F_FunctionParams
		{
			// Token: 0x0403233F RID: 205631
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D2 RID: 42194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3811399D330_FunctionParams
		{
			// Token: 0x04032340 RID: 205632
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D3 RID: 42195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381FA852B9F_FunctionParams
		{
			// Token: 0x04032341 RID: 205633
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
