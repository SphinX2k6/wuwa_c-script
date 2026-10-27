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
	// Token: 0x0200416C RID: 16748
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive_QQ.GA_SuperSprint_Passive_QQ_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_SuperSprint_Passive_QQ_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B512 RID: 177426 RVA: 0x009FCA19 File Offset: 0x009FAC19
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_SuperSprint_Passive_QQ_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive_QQ.GA_SuperSprint_Passive_QQ_C");
			}
			return GA_SuperSprint_Passive_QQ_C._ClassPtr;
		}

		// Token: 0x0602B513 RID: 177427 RVA: 0x009FCA40 File Offset: 0x009FAC40
		public GA_SuperSprint_Passive_QQ_C() : this(BuiltinUtils.AllocNativeUObject(GA_SuperSprint_Passive_QQ_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B514 RID: 177428 RVA: 0x009FCA68 File Offset: 0x009FAC68
		[NullableContext(1)]
		public GA_SuperSprint_Passive_QQ_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_SuperSprint_Passive_QQ_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B515 RID: 177429 RVA: 0x009FCA9C File Offset: 0x009FAC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3C99CC24B(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3C99CC24B_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3C99CC24B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3C99CC24B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3C99CC24B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3C99CC24B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B516 RID: 177430 RVA: 0x009FCAE8 File Offset: 0x009FACE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38175136BBF(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38175136BBF_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38175136BBF_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38175136BBF_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38175136BBF_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38175136BBF_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B517 RID: 177431 RVA: 0x009FCB34 File Offset: 0x009FAD34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3D808DB6C(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3D808DB6C_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3D808DB6C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3D808DB6C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3D808DB6C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Added_21071CB943CD992BF8EFD6A3D808DB6C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B518 RID: 177432 RVA: 0x009FCB80 File Offset: 0x009FAD80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D3813DF7FC93(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D3813DF7FC93_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D3813DF7FC93_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D3813DF7FC93_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D3813DF7FC93_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D3813DF7FC93_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B519 RID: 177433 RVA: 0x009FCBCC File Offset: 0x009FADCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381DD224938(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381DD224938_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381DD224938_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381DD224938_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381DD224938_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381DD224938_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B51A RID: 177434 RVA: 0x009FCC18 File Offset: 0x009FAE18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381CF9139AA(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381CF9139AA_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381CF9139AA_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381CF9139AA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381CF9139AA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381CF9139AA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B51B RID: 177435 RVA: 0x009FCC64 File Offset: 0x009FAE64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381B50A1D09(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381B50A1D09_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381B50A1D09_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381B50A1D09_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381B50A1D09_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381B50A1D09_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B51C RID: 177436 RVA: 0x009FCCB0 File Offset: 0x009FAEB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381876E965F(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381876E965F_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381876E965F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381876E965F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381876E965F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D381876E965F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B51D RID: 177437 RVA: 0x009FCCFC File Offset: 0x009FAEFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38151948B4B(in FGameplayTag Tag)
		{
			GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38151948B4B_FunctionParams* ptr = stackalloc GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38151948B4B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38151948B4B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38151948B4B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__Removed_DB9F64004F8908FEAD99D38151948B4B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B51E RID: 177438 RVA: 0x009FCD47 File Offset: 0x009FAF47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_6B6877FE457CFD47135C64891F9C4C0C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__OnFinish_6B6877FE457CFD47135C64891F9C4C0C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B51F RID: 177439 RVA: 0x009FCD5B File Offset: 0x009FAF5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B520 RID: 177440 RVA: 0x009FCD6F File Offset: 0x009FAF6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_SuperSprint_Passive_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B521 RID: 177441 RVA: 0x009FCD84 File Offset: 0x009FAF84
		protected GA_SuperSprint_Passive_QQ_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016858 RID: 92248
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_SuperSprint_Passive_QQ.GA_SuperSprint_Passive_QQ_C";

		// Token: 0x04016859 RID: 92249
		private static IntPtr _ClassPtr;

		// Token: 0x0401685A RID: 92250
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401685B RID: 92251
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3C99CC24B_NativeFunctionPtr;

		// Token: 0x0401685C RID: 92252
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38175136BBF_NativeFunctionPtr;

		// Token: 0x0401685D RID: 92253
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3D808DB6C_NativeFunctionPtr;

		// Token: 0x0401685E RID: 92254
		private static IntPtr __Removed_DB9F64004F8908FEAD99D3813DF7FC93_NativeFunctionPtr;

		// Token: 0x0401685F RID: 92255
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381DD224938_NativeFunctionPtr;

		// Token: 0x04016860 RID: 92256
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381CF9139AA_NativeFunctionPtr;

		// Token: 0x04016861 RID: 92257
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381B50A1D09_NativeFunctionPtr;

		// Token: 0x04016862 RID: 92258
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381876E965F_NativeFunctionPtr;

		// Token: 0x04016863 RID: 92259
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38151948B4B_NativeFunctionPtr;

		// Token: 0x04016864 RID: 92260
		private static IntPtr __OnFinish_6B6877FE457CFD47135C64891F9C4C0C_NativeFunctionPtr;

		// Token: 0x04016865 RID: 92261
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4D4 RID: 42196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3C99CC24B_FunctionParams
		{
			// Token: 0x04032342 RID: 205634
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D5 RID: 42197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38175136BBF_FunctionParams
		{
			// Token: 0x04032343 RID: 205635
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D6 RID: 42198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3D808DB6C_FunctionParams
		{
			// Token: 0x04032344 RID: 205636
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D7 RID: 42199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D3813DF7FC93_FunctionParams
		{
			// Token: 0x04032345 RID: 205637
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D8 RID: 42200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381DD224938_FunctionParams
		{
			// Token: 0x04032346 RID: 205638
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4D9 RID: 42201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381CF9139AA_FunctionParams
		{
			// Token: 0x04032347 RID: 205639
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4DA RID: 42202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381B50A1D09_FunctionParams
		{
			// Token: 0x04032348 RID: 205640
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4DB RID: 42203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381876E965F_FunctionParams
		{
			// Token: 0x04032349 RID: 205641
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4DC RID: 42204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38151948B4B_FunctionParams
		{
			// Token: 0x0403234A RID: 205642
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
