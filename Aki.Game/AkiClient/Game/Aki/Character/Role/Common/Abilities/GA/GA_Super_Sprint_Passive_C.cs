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
	// Token: 0x02004173 RID: 16755
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Passive.GA_Super_Sprint_Passive_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class GA_Super_Sprint_Passive_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B59D RID: 177565 RVA: 0x009FDDC4 File Offset: 0x009FBFC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Passive.GA_Super_Sprint_Passive_C");
			}
			return GA_Super_Sprint_Passive_C._ClassPtr;
		}

		// Token: 0x0602B59E RID: 177566 RVA: 0x009FDDE8 File Offset: 0x009FBFE8
		public GA_Super_Sprint_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B59F RID: 177567 RVA: 0x009FDE10 File Offset: 0x009FC010
		[NullableContext(1)]
		public GA_Super_Sprint_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B5A0 RID: 177568 RVA: 0x009FDE44 File Offset: 0x009FC044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38110EAC134(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38110EAC134_FunctionParams* ptr = stackalloc GA_Super_Sprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38110EAC134_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38110EAC134_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38110EAC134_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Passive_C.__Removed_DB9F64004F8908FEAD99D38110EAC134_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5A1 RID: 177569 RVA: 0x009FDE90 File Offset: 0x009FC090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A351E99F1A(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Passive_C.__Added_21071CB943CD992BF8EFD6A351E99F1A_FunctionParams* ptr = stackalloc GA_Super_Sprint_Passive_C.__Added_21071CB943CD992BF8EFD6A351E99F1A_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Passive_C.__Added_21071CB943CD992BF8EFD6A351E99F1A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Passive_C.__Added_21071CB943CD992BF8EFD6A351E99F1A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Passive_C.__Added_21071CB943CD992BF8EFD6A351E99F1A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B5A2 RID: 177570 RVA: 0x009FDEDB File Offset: 0x009FC0DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B5A3 RID: 177571 RVA: 0x009FDEEF File Offset: 0x009FC0EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B5A4 RID: 177572 RVA: 0x009FDF04 File Offset: 0x009FC104
		protected GA_Super_Sprint_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040168C0 RID: 92352
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Passive.GA_Super_Sprint_Passive_C";

		// Token: 0x040168C1 RID: 92353
		private static IntPtr _ClassPtr;

		// Token: 0x040168C2 RID: 92354
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040168C3 RID: 92355
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38110EAC134_NativeFunctionPtr;

		// Token: 0x040168C4 RID: 92356
		private static IntPtr __Added_21071CB943CD992BF8EFD6A351E99F1A_NativeFunctionPtr;

		// Token: 0x040168C5 RID: 92357
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4F1 RID: 42225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38110EAC134_FunctionParams
		{
			// Token: 0x0403235F RID: 205663
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4F2 RID: 42226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A351E99F1A_FunctionParams
		{
			// Token: 0x04032360 RID: 205664
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
